using UnityEngine;

public class StaffBaseState : StateMachineBehaviour
{
	protected Employee staff;

	protected static readonly int p_Avoid = AnimatorParameterCache.p_Avoid;

	protected static readonly int p_Waiting = AnimatorParameterCache.p_Waiting;

	protected static readonly int p_ServingCustomer = AnimatorParameterCache.p_ServingCustomer;

	protected static readonly int p_TakingDrink = AnimatorParameterCache.p_TakingDrink;

	protected static readonly int p_Club = AnimatorParameterCache.p_Club;

	protected static readonly int p_KickRowdyCustomer = AnimatorParameterCache.p_KickRowdyCustomer;

	protected static readonly int p_Hit = AnimatorParameterCache.p_Hit;

	protected static readonly int p_BringBackWorkers = AnimatorParameterCache.p_BringBackWorkers;

	protected static readonly int p_UseHold = AnimatorParameterCache.p_UseHold;

	protected static readonly int p_Mop = AnimatorParameterCache.p_Mop;

	protected static readonly int p_ServingRoomOrder = AnimatorParameterCache.p_ServingRoomOrder;

	protected static readonly int p_RentingRooms = AnimatorParameterCache.p_RentingRooms;

	protected static readonly int p_HeadingToDrinksTable = AnimatorParameterCache.p_HeadingToDrinksTable;

	protected static readonly int p_ServingTableOrder = AnimatorParameterCache.p_ServingTableOrder;

	protected static readonly int p_CleaningTable = AnimatorParameterCache.p_CleaningTable;

	public virtual void OGFKFGAMGCE()
	{
	}

	public virtual void EIOFKDODGKK()
	{
	}

	public virtual void EHBFECEJGCE()
	{
	}

	public virtual void LALGIJBMOMI()
	{
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		if ((Object)(object)staff == (Object)null)
		{
			staff = ((Component)ONDMDLMHMHK).GetComponent<Employee>();
		}
		staff.currentState = this;
		staff.OEONGPFALKH.isActive = false;
	}

	public virtual void CLJBKGOGBII()
	{
	}

	public virtual void HHPANGDONBN()
	{
	}

	public virtual void FOIGFCMPAAO()
	{
	}

	public virtual void JDHKHKJOKFF()
	{
	}

	public virtual void EEPKGNNILBE()
	{
	}

	public virtual void PMLHDLPJPDG()
	{
	}

	public virtual void GFABFDHPJOK()
	{
	}

	public virtual void JMLDAJEFMPE()
	{
	}

	public virtual void NLOEGNNLKKE()
	{
	}

	public virtual void DBNAJMBFJEG()
	{
	}

	public virtual void PFNIPILPGFN()
	{
	}

	public virtual void FGJPOPCBFNE()
	{
	}

	public virtual void MAGACCHLAOE()
	{
	}

	public virtual void OOBDKJHKPEP()
	{
	}

	public virtual void ADJMGPNBDGF()
	{
	}

	public virtual void AFKGJCIANOF()
	{
	}

	public virtual void HEDGGNKENPB()
	{
	}

	public virtual void OBJHHNMMCGF()
	{
	}

	public virtual void FKCOPHFELKD()
	{
	}

	public virtual void FBNHGAOGDJE()
	{
	}

	public virtual void FKIEEDDAGKG()
	{
	}

	public virtual void KPPIKBFOIFB()
	{
	}

	public virtual void ADHFFJDEBMK()
	{
	}

	public virtual void OHJIFGGCDAN()
	{
	}

	public virtual void MDKNIJCHHCE()
	{
	}

	public virtual void PGJLFLKDLAE()
	{
	}

	public virtual void DGIFHBIJDDE()
	{
	}

	public virtual void HDDBJBECDPP()
	{
	}

	public virtual void FJIJNLKJGKC()
	{
	}

	public virtual void IGNLHLAAMMN()
	{
	}

	public virtual void DEFIFMAOPCM()
	{
	}

	public virtual void AHPNEDOLBII()
	{
	}

	public virtual void MJENOBKFPIN()
	{
	}

	public virtual void NBNCMOAPDOG()
	{
	}

	public virtual void DHJOHHEMMFK()
	{
	}

	public virtual void KIGPIILBDAC()
	{
	}

	public virtual void JBABHOJPFPG()
	{
	}

	public virtual void HKOFLOPDCEJ()
	{
	}

	public virtual void MOEJIBLELHP()
	{
	}

	public virtual void NODDNBFDJGO()
	{
	}

	public virtual void HINEHDJIPGP()
	{
	}
}
