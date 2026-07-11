using UnityEngine;

public class VioletAnimation : CharacterAnimBase
{
	public SpriteRenderer violetSprite;

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
			if (Object.op_Implicit((Object)(object)violetSprite))
			{
				if (FCGBJEIIMBC == Direction.Left)
				{
					((Component)violetSprite).transform.localScale = new Vector3(-1f, 1f, 1f);
				}
				else
				{
					((Component)violetSprite).transform.localScale = new Vector3(1f, 1f, 1f);
				}
			}
		}
	}

	private void GONDLJKGLGO()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1553f)
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

	private void PFNIPILPGFN()
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
		if (((Vector3)(ref val)).sqrMagnitude > 991f)
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
		if (((Vector3)(ref val)).sqrMagnitude > 1323f)
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

	private void FFLLCOBFIPE()
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
		if (((Vector3)(ref val)).sqrMagnitude > 181f)
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

	private void KLMNLEDKEOE()
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
		if (((Vector3)(ref val)).sqrMagnitude > 16f)
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

	private void DADPOICMNPI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void MIKNFPCDLML()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FGJPOPCBFNE()
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
		if (((Vector3)(ref val)).sqrMagnitude > 75f)
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

	private void HPJBLOPJIMI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
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
		if (((Vector3)(ref val)).sqrMagnitude > 1597f)
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

	private void KMBEOPAHKGB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void EHBMONGBJFI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void DEFIFMAOPCM()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1270f)
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

	private void JDHHJKBOJML()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void CLGBFOIBANN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void Awake()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1216f)
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
		if (((Vector3)(ref val)).sqrMagnitude > 1383f)
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
		if (((Vector3)(ref val)).sqrMagnitude > 593f)
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
		if (((Vector3)(ref val)).sqrMagnitude > 121f)
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

	private void HEMAHKJEONA()
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
		if (((Vector3)(ref val)).sqrMagnitude > 693f)
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

	private void BHAFCBHENPL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void JIAJFDKNJME()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
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
		if (((Vector3)(ref val)).sqrMagnitude > 1388f)
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

	private void JBABHOJPFPG()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1337f)
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

	private void COKBJNMAMDI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FPNCANODJKE()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1135f)
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

	private void DIMAPDNCBAN()
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
		if (((Vector3)(ref val)).sqrMagnitude > 532f)
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

	private void HAHFKJCIPKH()
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
		if (((Vector3)(ref val)).sqrMagnitude > 681f)
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

	private void BNFGHAGJEGG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void EFCNKPEPELL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void EMJKKALMGLK()
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

	private void LILOALHNAND()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1280f)
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

	private void BCIMMPHOOFM()
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
		if (((Vector3)(ref val)).sqrMagnitude > 886f)
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

	private void NJAFKFAPDIE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void OCJOAHDNDIJ()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1654f)
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

	private void EIMIDCDEIDD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void HCCJBKKGCLJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void KJHKBGDJNDC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void LALGIJBMOMI()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1357f)
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

	private void GNOBDKFFPOL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
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
		if (((Vector3)(ref val)).sqrMagnitude > 1007f)
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

	private void NODDNBFDJGO()
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
		if (((Vector3)(ref val)).sqrMagnitude > 480f)
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

	private void HINGECEDJAP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
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
		if (((Vector3)(ref val)).sqrMagnitude > 922f)
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

	private void KHCJDKHONPK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FBNHGAOGDJE()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1128f)
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

	private void GHBEMCOFHOC()
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
		if (((Vector3)(ref val)).sqrMagnitude > 447f)
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

	private void MFJIHCKEIIF()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1457f)
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

	private void FHOCCEBKHJI()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1626f)
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
		if (((Vector3)(ref val)).sqrMagnitude > 1590f)
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
		if (((Vector3)(ref val)).sqrMagnitude > 1581f)
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

	private void DGDCMLPELHD()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1446f)
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

	private void GFLFDLIMOLI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void LNPDALMANFB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void PKPHKBMPJGJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GIHCKNBINMG()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1032f)
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

	private void FOIGFCMPAAO()
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
		if (((Vector3)(ref val)).sqrMagnitude > 319f)
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

	private void PNLAJCHBHPH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void PHJKJHKAABL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GOJKOBEEMNA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}
}
