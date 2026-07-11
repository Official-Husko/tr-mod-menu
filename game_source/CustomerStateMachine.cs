using UnityEngine;

public class CustomerStateMachine : GenericStateMachine
{
	[Header("References")]
	public HumanNPC npc;

	public Customer customer;

	private void OILCECLCEPA(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		LNOAPCNOBPI(initialState);
	}

	public void LGFLPBGODKJ(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.EDEOOIFHKDO() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!LCPLOJAJKHL())
			{
				initialState = customerStateBase;
				LNOAPCNOBPI(initialState);
			}
			HNOHBDNDCJM(customerStateBase, KCNFNAICINO);
		}
	}

	public void MJKGGABKEMM(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.PJCJDHLNOHN() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!LCPLOJAJKHL())
			{
				initialState = customerStateBase;
				EDFHGNPBICM(initialState);
			}
			LAIKBPAJEEL(customerStateBase, KCNFNAICINO);
		}
	}

	public CustomerStateBase DEOAGNKOPGH()
	{
		return (CustomerStateBase)currentState;
	}

	public void HFNDBBFNGBP(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.MHOMONJLOBL() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!GNDHCEALPOI())
			{
				initialState = customerStateBase;
				HGKNFCAIOKE(initialState);
			}
			HNOHBDNDCJM(customerStateBase, KCNFNAICINO);
		}
	}

	protected override void HGKNFCAIOKE(GenericStateBase DGCONJOFNEL)
	{
		if ((Object)(object)npc == (Object)null || (Object)(object)customer == (Object)null)
		{
			Debug.LogError((object)"Initial Customer State Machine values are null.", (Object)(object)this);
		}
		else
		{
			base.HGKNFCAIOKE(DGCONJOFNEL);
		}
	}

	private void LHCGCFFDEMO(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		EDFHGNPBICM(initialState);
	}

	private void DJLEENCKFJN()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this);
		}
	}

	public CustomerStateBase FOPCOKAJDLJ()
	{
		return (CustomerStateBase)currentState;
	}

	public CustomerStateBase MCJEHGKCOGC()
	{
		return (CustomerStateBase)currentState;
	}

	private void KPEDGCNJODC(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		EDFHGNPBICM(initialState);
	}

	private void FMNOHCHLJAC()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this);
		}
	}

	public CustomerStateBase EGCMONJCJJL()
	{
		return (CustomerStateBase)currentState;
	}

	private void EHJFIGJDNNE()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this);
		}
	}

	private void PIPHACIFLFH(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		HGKNFCAIOKE(initialState);
	}

	public CustomerStateBase FMHFLADLOFE()
	{
		return (CustomerStateBase)currentState;
	}

	private void EKFNNFEJLKO(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		HGKNFCAIOKE(initialState);
	}

	private void OFDKJLNJEOB(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		HGKNFCAIOKE(initialState);
	}

	private void ONGCFOOLEEM(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		EDFHGNPBICM(initialState);
	}

	private void GPCNNBFJCMF()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this);
		}
	}

	public void EOIBPBMOKNN(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.HMJEJFAHEKJ() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!LCPLOJAJKHL())
			{
				initialState = customerStateBase;
				JKCLMKEDLOG(initialState);
			}
			HNOHBDNDCJM(customerStateBase, KCNFNAICINO);
		}
	}

	private void BCILFDGDPIE()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this);
		}
	}

	public CustomerStateBase BNHNDGHLCJC()
	{
		return (CustomerStateBase)currentState;
	}

	private void DLNLLCOFFEG(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		LNOAPCNOBPI(initialState);
	}

	public void NBHFECBNBCC(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.LCLNMMCICJG() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!base.GGJFEPEOLJA)
			{
				initialState = customerStateBase;
				EDFHGNPBICM(initialState);
			}
			LAIKBPAJEEL(customerStateBase, KCNFNAICINO);
		}
	}

	public void IAMGNPLILFG(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.PBDDMJKOLJC() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!LCPLOJAJKHL())
			{
				initialState = customerStateBase;
				EDFHGNPBICM(initialState);
			}
			GNCLBACINCA(customerStateBase, KCNFNAICINO);
		}
	}

	public void GNNLHOMNCHN(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.OIKHJFNDAKE() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!base.GGJFEPEOLJA)
			{
				initialState = customerStateBase;
				JKCLMKEDLOG(initialState);
			}
			LAIKBPAJEEL(customerStateBase, KCNFNAICINO);
		}
	}

	private void KBLDHFMJOGD()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this, GDHCBGCIIKG: true);
		}
	}

	private void PGMLDIIFOMK()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this);
		}
	}

	private void ONBJNHBLBBB()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this, GDHCBGCIIKG: true);
		}
	}

	public CustomerStateBase GetCurrentState()
	{
		return (CustomerStateBase)currentState;
	}

	private void DLGINHIFIFL(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		HGKNFCAIOKE(initialState);
	}

	private void OBLIFOPINBD(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		JKCLMKEDLOG(initialState);
	}

	public CustomerStateBase IHKFJPFPMIJ()
	{
		return (CustomerStateBase)currentState;
	}

	public CustomerStateBase LIPLEBNEFFA()
	{
		return (CustomerStateBase)currentState;
	}

	private void EAHDJINLGLN()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this);
		}
	}

	private void ENDCJLNBEEI(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		LNOAPCNOBPI(initialState);
	}

	private void PLCEDNEEIPG(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		EDFHGNPBICM(initialState);
	}

	private void NDAPPFFGCDD()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this);
		}
	}

	public void HAINPCPNCNL(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.EAHCHMKILCL() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!base.GGJFEPEOLJA)
			{
				initialState = customerStateBase;
				LNOAPCNOBPI(initialState);
			}
			LAIKBPAJEEL(customerStateBase, KCNFNAICINO);
		}
	}

	public CustomerStateBase EMDFELAFIND()
	{
		return (CustomerStateBase)currentState;
	}

	private void KOIIHIBCEGE()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this);
		}
	}

	private void IGJFEGPKPEO()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this);
		}
	}

	public CustomerStateBase DPJBFBAMDDK()
	{
		return (CustomerStateBase)currentState;
	}

	private void BAIPCLNJELL()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this);
		}
	}

	public void LGNAGGBHLOC(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.PNPNDEOAHAI() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!base.GGJFEPEOLJA)
			{
				initialState = customerStateBase;
				EDFHGNPBICM(initialState);
			}
			GNCLBACINCA(customerStateBase, KCNFNAICINO);
		}
	}

	public CustomerStateBase BGBJNLJDLPO()
	{
		return (CustomerStateBase)currentState;
	}

	public void OGOGEONPDOO(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.GetStateEnumID() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!LCPLOJAJKHL())
			{
				initialState = customerStateBase;
				JKCLMKEDLOG(initialState);
			}
			ChangeState(customerStateBase, KCNFNAICINO);
		}
	}

	private void GEKBCEBFBAA()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this);
		}
	}

	private void JJDBDODOOJP(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		JKCLMKEDLOG(initialState);
	}

	public void IIENGEBHKNO(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.PNPNDEOAHAI() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!GNDHCEALPOI())
			{
				initialState = customerStateBase;
				GPDAGLPLHPF(initialState);
			}
			ChangeState(customerStateBase, KCNFNAICINO);
		}
	}

	public void ChangeState(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.GetStateEnumID() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!base.GGJFEPEOLJA)
			{
				initialState = customerStateBase;
				HGKNFCAIOKE(initialState);
			}
			ChangeState(customerStateBase, KCNFNAICINO);
		}
	}

	public CustomerStateBase PACECOMMPLJ()
	{
		return (CustomerStateBase)currentState;
	}

	public CustomerStateBase NKKGEECNLCK()
	{
		return (CustomerStateBase)currentState;
	}

	public void LFCPOIPPCHF(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.EDEOOIFHKDO() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!GNDHCEALPOI())
			{
				initialState = customerStateBase;
				HGKNFCAIOKE(initialState);
			}
			HNOHBDNDCJM(customerStateBase, KCNFNAICINO);
		}
	}

	private void CPLFLKHDBLB(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		EDFHGNPBICM(initialState);
	}

	private void KJBMEIIDHHE(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		GPDAGLPLHPF(initialState);
	}

	private void PGHHLNLGLHL(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		GPDAGLPLHPF(initialState);
	}

	public void EDNHPLFFBOE(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.PCAHAEIHBBB() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!base.GGJFEPEOLJA)
			{
				initialState = customerStateBase;
				LNOAPCNOBPI(initialState);
			}
			ChangeState(customerStateBase, KCNFNAICINO);
		}
	}

	public void CMKKLBBFDIA(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		CustomerStateBase customerStateBase = null;
		foreach (CustomerStateBase state in states)
		{
			if (state.PBDDMJKOLJC() == (int)OJGICFBAAMH)
			{
				customerStateBase = state;
				break;
			}
		}
		if (!((Object)(object)customerStateBase == (Object)null))
		{
			if (!LCPLOJAJKHL())
			{
				initialState = customerStateBase;
				EDFHGNPBICM(initialState);
			}
			GNCLBACINCA(customerStateBase, KCNFNAICINO);
		}
	}

	private void HFKMFFBMDJO()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this);
		}
	}

	private void DLNFHKEEJCD(Animator BNAJNKBCLEJ, HumanNPC JFLENDJFAOE, Customer CINEJKCOOCL)
	{
		npc = JFLENDJFAOE;
		customer = CINEJKCOOCL;
		HGKNFCAIOKE(initialState);
	}

	private void DJFKILPMKNA()
	{
		foreach (CustomerStateBase state in states)
		{
			state.InitializeState(this, GDHCBGCIIKG: true);
		}
	}
}
