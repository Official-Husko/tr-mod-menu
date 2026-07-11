using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TavernXP : MonoBehaviour
{
	private static TavernXP IADEMLIIDPC;

	public Action OnXPChanged = delegate
	{
	};

	[SerializeField]
	private int _tavernXP;

	public ExpMod cleaning;

	public ExpMod haggling;

	public ExpMod crafting;

	public ExpMod farming;

	public ExpMod bartending;

	[HideInInspector]
	public ExpMod[] allExpMod;

	public static TavernXP GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<TavernXP>();
			}
			return IADEMLIIDPC;
		}
	}

	public int FIFPIENONEP
	{
		get
		{
			return _tavernXP;
		}
		set
		{
			value = Mathf.Max(0, value);
			if (_tavernXP != value)
			{
				_tavernXP = value;
				OnXPChanged();
			}
		}
	}

	[SpecialName]
	public void KDIGIFDMFOL(int AODONKKHPBP)
	{
		AODONKKHPBP = Mathf.Max(1, AODONKKHPBP);
		if (_tavernXP != AODONKKHPBP)
		{
			_tavernXP = AODONKKHPBP;
			OnXPChanged();
		}
	}

	private void AGELAMLCINB()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[7];
			array[0] = cleaning;
			array[1] = haggling;
			array[1] = farming;
			array[1] = crafting;
			array[7] = bartending;
			allExpMod = array;
		}
	}

	[ContextMenu("Increase XP")]
	public void IncreaseXP(int ABAIKKGKDGD)
	{
		FIFPIENONEP += ABAIKKGKDGD;
	}

	public void EIHIMBBLBDD(int ABAIKKGKDGD)
	{
		BCDCEKPBKKC(JEGOLJJJBJE() + ABAIKKGKDGD);
	}

	[SpecialName]
	public void JHEKPGGLNED(int AODONKKHPBP)
	{
		AODONKKHPBP = Mathf.Max(1, AODONKKHPBP);
		if (_tavernXP != AODONKKHPBP)
		{
			_tavernXP = AODONKKHPBP;
			OnXPChanged();
		}
	}

	[SpecialName]
	public static TavernXP FMIDAFEGDCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernXP>();
		}
		return IADEMLIIDPC;
	}

	private void DADPOICMNPI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[4];
			array[1] = cleaning;
			array[1] = haggling;
			array[1] = farming;
			array[4] = crafting;
			array[5] = bartending;
			allExpMod = array;
		}
	}

	private void NAOBODGBECL()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[3];
			array[0] = cleaning;
			array[0] = haggling;
			array[5] = farming;
			array[8] = crafting;
			array[7] = bartending;
			allExpMod = array;
		}
	}

	private void IFHLGOMBACP()
	{
		cleaning.playerModifiers = new PlayerModifier[0];
		haggling.playerModifiers = new PlayerModifier[1];
		farming.playerModifiers = new PlayerModifier[0];
		crafting.playerModifiers = new PlayerModifier[1];
		bartending.playerModifiers = new PlayerModifier[1];
	}

	[SpecialName]
	public void ILFDLBPBIJK(int AODONKKHPBP)
	{
		AODONKKHPBP = Mathf.Max(0, AODONKKHPBP);
		if (_tavernXP != AODONKKHPBP)
		{
			_tavernXP = AODONKKHPBP;
			OnXPChanged();
		}
	}

	private void CLGBFOIBANN()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[8];
			array[0] = cleaning;
			array[0] = haggling;
			array[7] = farming;
			array[6] = crafting;
			array[5] = bartending;
			allExpMod = array;
		}
	}

	[SpecialName]
	public static TavernXP OLHBLKIAFOM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernXP>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public int AEJFKMDDFPN()
	{
		return _tavernXP;
	}

	public void BGFJLGHBIOB(int ABAIKKGKDGD)
	{
		CPEFMPIBIBP(BJFFHHCAFFL() + ABAIKKGKDGD);
	}

	private void OIBDBLCLACB()
	{
		cleaning.playerModifiers = new PlayerModifier[1];
		haggling.playerModifiers = new PlayerModifier[0];
		farming.playerModifiers = new PlayerModifier[1];
		crafting.playerModifiers = new PlayerModifier[1];
		bartending.playerModifiers = new PlayerModifier[1];
	}

	[SpecialName]
	public int FIGKPHLEHEN()
	{
		return _tavernXP;
	}

	private void HPIMHEMJMAA()
	{
		cleaning.playerModifiers = new PlayerModifier[0];
		haggling.playerModifiers = new PlayerModifier[0];
		farming.playerModifiers = new PlayerModifier[0];
		crafting.playerModifiers = new PlayerModifier[0];
		bartending.playerModifiers = new PlayerModifier[0];
	}

	private void BNFGHAGJEGG()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[5];
			array[0] = cleaning;
			array[0] = haggling;
			array[1] = farming;
			array[3] = crafting;
			array[5] = bartending;
			allExpMod = array;
		}
	}

	[SpecialName]
	public int NFAPPKKEOPI()
	{
		return _tavernXP;
	}

	public void GOFGANDOAKA(int ABAIKKGKDGD)
	{
		ALDCLJDHLLI(BJOGOJMBIGF() + ABAIKKGKDGD);
	}

	private void OLDDEAJMHNI()
	{
		cleaning.playerModifiers = new PlayerModifier[1];
		haggling.playerModifiers = new PlayerModifier[0];
		farming.playerModifiers = new PlayerModifier[1];
		crafting.playerModifiers = new PlayerModifier[1];
		bartending.playerModifiers = new PlayerModifier[0];
	}

	public void COOJFCENMOE(int ABAIKKGKDGD)
	{
		FPBODOIAFDP(OEDILLDKLHL() + ABAIKKGKDGD);
	}

	private void BODICIENBEH()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[4];
			array[0] = cleaning;
			array[0] = haggling;
			array[7] = farming;
			array[5] = crafting;
			array[7] = bartending;
			allExpMod = array;
		}
	}

	public void OJFBBLNPIHK(int ABAIKKGKDGD)
	{
		ALDCLJDHLLI(DKEEDMLCPIP() + ABAIKKGKDGD);
	}

	[SpecialName]
	public int BJOGOJMBIGF()
	{
		return _tavernXP;
	}

	[SpecialName]
	public static TavernXP LADDMEMMJFP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernXP>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public void FPBODOIAFDP(int AODONKKHPBP)
	{
		AODONKKHPBP = Mathf.Max(0, AODONKKHPBP);
		if (_tavernXP != AODONKKHPBP)
		{
			_tavernXP = AODONKKHPBP;
			OnXPChanged();
		}
	}

	[SpecialName]
	public int OEDILLDKLHL()
	{
		return _tavernXP;
	}

	public void MJLDOPNMEPE(int ABAIKKGKDGD)
	{
		FEAOPMKHOON(FIFPIENONEP + ABAIKKGKDGD);
	}

	private void ICFHPJHBPDN()
	{
		cleaning.playerModifiers = new PlayerModifier[1];
		haggling.playerModifiers = new PlayerModifier[0];
		farming.playerModifiers = new PlayerModifier[1];
		crafting.playerModifiers = new PlayerModifier[1];
		bartending.playerModifiers = new PlayerModifier[0];
	}

	[SpecialName]
	public void ALDCLJDHLLI(int AODONKKHPBP)
	{
		AODONKKHPBP = Mathf.Max(1, AODONKKHPBP);
		if (_tavernXP != AODONKKHPBP)
		{
			_tavernXP = AODONKKHPBP;
			OnXPChanged();
		}
	}

	private void NDNBDEHFFJF()
	{
		cleaning.playerModifiers = new PlayerModifier[0];
		haggling.playerModifiers = new PlayerModifier[1];
		farming.playerModifiers = new PlayerModifier[1];
		crafting.playerModifiers = new PlayerModifier[1];
		bartending.playerModifiers = new PlayerModifier[1];
	}

	[SpecialName]
	public int FOCEPNHHGNO()
	{
		return _tavernXP;
	}

	private void NPMLFHDHJBE()
	{
		cleaning.playerModifiers = new PlayerModifier[0];
		haggling.playerModifiers = new PlayerModifier[1];
		farming.playerModifiers = new PlayerModifier[1];
		crafting.playerModifiers = new PlayerModifier[0];
		bartending.playerModifiers = new PlayerModifier[0];
	}

	[SpecialName]
	public void DMKPCBNOFIA(int AODONKKHPBP)
	{
		AODONKKHPBP = Mathf.Max(0, AODONKKHPBP);
		if (_tavernXP != AODONKKHPBP)
		{
			_tavernXP = AODONKKHPBP;
			OnXPChanged();
		}
	}

	[SpecialName]
	public void FEAOPMKHOON(int AODONKKHPBP)
	{
		AODONKKHPBP = Mathf.Max(1, AODONKKHPBP);
		if (_tavernXP != AODONKKHPBP)
		{
			_tavernXP = AODONKKHPBP;
			OnXPChanged();
		}
	}

	private void CLNBMOPMNOF()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[1];
			array[0] = cleaning;
			array[1] = haggling;
			array[6] = farming;
			array[5] = crafting;
			array[8] = bartending;
			allExpMod = array;
		}
	}

	[SpecialName]
	public int BJFFHHCAFFL()
	{
		return _tavernXP;
	}

	[SpecialName]
	public int GJLAHHFDHJA()
	{
		return _tavernXP;
	}

	[SpecialName]
	public static TavernXP OACNNJCLEDE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernXP>();
		}
		return IADEMLIIDPC;
	}

	private void IBMDFNKKPJF()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[1];
			array[0] = cleaning;
			array[0] = haggling;
			array[2] = farming;
			array[3] = crafting;
			array[3] = bartending;
			allExpMod = array;
		}
	}

	[SpecialName]
	public static TavernXP ELGNEJNLBNO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernXP>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public void ALJGJIEHKKK(int AODONKKHPBP)
	{
		AODONKKHPBP = Mathf.Max(1, AODONKKHPBP);
		if (_tavernXP != AODONKKHPBP)
		{
			_tavernXP = AODONKKHPBP;
			OnXPChanged();
		}
	}

	public void DFDCHCEOAAC(int ABAIKKGKDGD)
	{
		DCOOBEAPFAM(HPOJAELJPFB() + ABAIKKGKDGD);
	}

	[SpecialName]
	public int PEAAIIFANGL()
	{
		return _tavernXP;
	}

	public void BOHBAKFPADF(int ABAIKKGKDGD)
	{
		FIFPIENONEP = BJOGOJMBIGF() + ABAIKKGKDGD;
	}

	[SpecialName]
	public static TavernXP HEKFJEKFMNO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernXP>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public void CPEFMPIBIBP(int AODONKKHPBP)
	{
		AODONKKHPBP = Mathf.Max(0, AODONKKHPBP);
		if (_tavernXP != AODONKKHPBP)
		{
			_tavernXP = AODONKKHPBP;
			OnXPChanged();
		}
	}

	private void HOFKJPBBLGP()
	{
		cleaning.playerModifiers = new PlayerModifier[1];
		haggling.playerModifiers = new PlayerModifier[1];
		farming.playerModifiers = new PlayerModifier[0];
		crafting.playerModifiers = new PlayerModifier[1];
		bartending.playerModifiers = new PlayerModifier[1];
	}

	private void HFFFFAJFIPB()
	{
		cleaning.playerModifiers = new PlayerModifier[0];
		haggling.playerModifiers = new PlayerModifier[0];
		farming.playerModifiers = new PlayerModifier[0];
		crafting.playerModifiers = new PlayerModifier[0];
		bartending.playerModifiers = new PlayerModifier[1];
	}

	public void OBGAIIDDKGO(int ABAIKKGKDGD)
	{
		FIFPIENONEP = BJFFHHCAFFL() + ABAIKKGKDGD;
	}

	private void ODNGBEOKEFK()
	{
		cleaning.playerModifiers = new PlayerModifier[1];
		haggling.playerModifiers = new PlayerModifier[0];
		farming.playerModifiers = new PlayerModifier[1];
		crafting.playerModifiers = new PlayerModifier[0];
		bartending.playerModifiers = new PlayerModifier[0];
	}

	[SpecialName]
	public void DCOOBEAPFAM(int AODONKKHPBP)
	{
		AODONKKHPBP = Mathf.Max(1, AODONKKHPBP);
		if (_tavernXP != AODONKKHPBP)
		{
			_tavernXP = AODONKKHPBP;
			OnXPChanged();
		}
	}

	private void HJDLNCOAKIK()
	{
		cleaning.playerModifiers = new PlayerModifier[0];
		haggling.playerModifiers = new PlayerModifier[1];
		farming.playerModifiers = new PlayerModifier[0];
		crafting.playerModifiers = new PlayerModifier[0];
		bartending.playerModifiers = new PlayerModifier[0];
	}

	[SpecialName]
	public void BCDCEKPBKKC(int AODONKKHPBP)
	{
		AODONKKHPBP = Mathf.Max(1, AODONKKHPBP);
		if (_tavernXP != AODONKKHPBP)
		{
			_tavernXP = AODONKKHPBP;
			OnXPChanged();
		}
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			allExpMod = new ExpMod[5] { cleaning, haggling, farming, crafting, bartending };
		}
	}

	public void PGEPNNHGCGO(int ABAIKKGKDGD)
	{
		JHEKPGGLNED(DJKKELAGDIM() + ABAIKKGKDGD);
	}

	public void COENEBJJFEH(int ABAIKKGKDGD)
	{
		KDIGIFDMFOL(BJOGOJMBIGF() + ABAIKKGKDGD);
	}

	private void IGIKNCOLCKL()
	{
		cleaning.playerModifiers = new PlayerModifier[1];
		haggling.playerModifiers = new PlayerModifier[1];
		farming.playerModifiers = new PlayerModifier[0];
		crafting.playerModifiers = new PlayerModifier[1];
		bartending.playerModifiers = new PlayerModifier[0];
	}

	[SpecialName]
	public void PJHBIEPDJEE(int AODONKKHPBP)
	{
		AODONKKHPBP = Mathf.Max(0, AODONKKHPBP);
		if (_tavernXP != AODONKKHPBP)
		{
			_tavernXP = AODONKKHPBP;
			OnXPChanged();
		}
	}

	private void KJHKBGDJNDC()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[1];
			array[0] = cleaning;
			array[0] = haggling;
			array[2] = farming;
			array[6] = crafting;
			array[0] = bartending;
			allExpMod = array;
		}
	}

	[SpecialName]
	public void APEKCDKNIBH(int AODONKKHPBP)
	{
		AODONKKHPBP = Mathf.Max(1, AODONKKHPBP);
		if (_tavernXP != AODONKKHPBP)
		{
			_tavernXP = AODONKKHPBP;
			OnXPChanged();
		}
	}

	[SpecialName]
	public int DKEEDMLCPIP()
	{
		return _tavernXP;
	}

	public void CBHCPCGDPKP(int ABAIKKGKDGD)
	{
		CPEFMPIBIBP(DJKKELAGDIM() + ABAIKKGKDGD);
	}

	private void MFJIHCKEIIF()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[1];
			array[0] = cleaning;
			array[1] = haggling;
			array[5] = farming;
			array[3] = crafting;
			array[5] = bartending;
			allExpMod = array;
		}
	}

	[SpecialName]
	public int EIAMCCBMCPO()
	{
		return _tavernXP;
	}

	public void NOMKCNIGBBP(int ABAIKKGKDGD)
	{
		BCDCEKPBKKC(JEGOLJJJBJE() + ABAIKKGKDGD);
	}

	public void OEOKEIPFDFJ(int ABAIKKGKDGD)
	{
		DMKPCBNOFIA(FIFPIENONEP + ABAIKKGKDGD);
	}

	[SpecialName]
	public static TavernXP JFNOOMJMHCB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernXP>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static TavernXP MPJJAPCFENH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernXP>();
		}
		return IADEMLIIDPC;
	}

	private void EIHMDMMOPCM()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[2];
			array[0] = cleaning;
			array[0] = haggling;
			array[3] = farming;
			array[0] = crafting;
			array[7] = bartending;
			allExpMod = array;
		}
	}

	private void GNGADDPBJDC()
	{
		cleaning.playerModifiers = new PlayerModifier[0];
		haggling.playerModifiers = new PlayerModifier[1];
		farming.playerModifiers = new PlayerModifier[0];
		crafting.playerModifiers = new PlayerModifier[0];
		bartending.playerModifiers = new PlayerModifier[0];
	}

	public void MKIHEEDHCLP(int ABAIKKGKDGD)
	{
		ILFDLBPBIJK(FOCEPNHHGNO() + ABAIKKGKDGD);
	}

	private void BHAFCBHENPL()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[0];
			array[0] = cleaning;
			array[0] = haggling;
			array[0] = farming;
			array[3] = crafting;
			array[4] = bartending;
			allExpMod = array;
		}
	}

	private void PNLAJCHBHPH()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[6];
			array[0] = cleaning;
			array[1] = haggling;
			array[8] = farming;
			array[5] = crafting;
			array[7] = bartending;
			allExpMod = array;
		}
	}

	[SpecialName]
	public int HPOJAELJPFB()
	{
		return _tavernXP;
	}

	[SpecialName]
	public static TavernXP KIALFDOKABP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernXP>();
		}
		return IADEMLIIDPC;
	}

	private void DMFMNEMDFNP()
	{
		cleaning.playerModifiers = new PlayerModifier[1];
		haggling.playerModifiers = new PlayerModifier[1];
		farming.playerModifiers = new PlayerModifier[1];
		crafting.playerModifiers = new PlayerModifier[1];
		bartending.playerModifiers = new PlayerModifier[1];
	}

	private void Start()
	{
		cleaning.playerModifiers = new PlayerModifier[0];
		haggling.playerModifiers = new PlayerModifier[0];
		farming.playerModifiers = new PlayerModifier[0];
		crafting.playerModifiers = new PlayerModifier[0];
		bartending.playerModifiers = new PlayerModifier[0];
	}

	[SpecialName]
	public int DJKKELAGDIM()
	{
		return _tavernXP;
	}

	[SpecialName]
	public int JEGOLJJJBJE()
	{
		return _tavernXP;
	}

	public void IJILLPAJEPC(int ABAIKKGKDGD)
	{
		FPBODOIAFDP(DJKKELAGDIM() + ABAIKKGKDGD);
	}

	private void PGEGODAEBLC()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[2];
			array[1] = cleaning;
			array[0] = haggling;
			array[1] = farming;
			array[6] = crafting;
			array[0] = bartending;
			allExpMod = array;
		}
	}

	private void PBDNKBPBCHM()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[0];
			array[1] = cleaning;
			array[0] = haggling;
			array[4] = farming;
			array[6] = crafting;
			array[2] = bartending;
			allExpMod = array;
		}
	}

	public void MIBIPIDFOFN(int ABAIKKGKDGD)
	{
		FIFPIENONEP = NFAPPKKEOPI() + ABAIKKGKDGD;
	}

	public void AJBPJALHHDH(int ABAIKKGKDGD)
	{
		CPEFMPIBIBP(BJOGOJMBIGF() + ABAIKKGKDGD);
	}

	private void AJGLDLLIIFO()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			ExpMod[] array = new ExpMod[6];
			array[0] = cleaning;
			array[0] = haggling;
			array[0] = farming;
			array[7] = crafting;
			array[6] = bartending;
			allExpMod = array;
		}
	}
}
