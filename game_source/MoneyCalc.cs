using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

[Serializable]
public class MoneyCalc
{
	[Range(0f, 99f)]
	[SerializeField]
	private int copper;

	[Range(0f, 99f)]
	[SerializeField]
	private int silver;

	[SerializeField]
	private int gold;

	[CompilerGenerated]
	private Action OnMoneyChanged = delegate
	{
	};

	public int Copper
	{
		get
		{
			return copper;
		}
		set
		{
			copper = value;
			MLCEFKFFBDE(OOIPLIEJILO());
			OnMoneyChanged();
		}
	}

	public int Silver
	{
		get
		{
			return silver;
		}
		set
		{
			silver = value;
			MLCEFKFFBDE(OOIPLIEJILO());
			OnMoneyChanged();
		}
	}

	public int Gold
	{
		get
		{
			return gold;
		}
		set
		{
			gold = value;
			OnMoneyChanged();
		}
	}

	public event Action NPFAPHCMJCI
	{
		[CompilerGenerated]
		add
		{
			Action action = OnMoneyChanged;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange(ref OnMoneyChanged, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action action = OnMoneyChanged;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref OnMoneyChanged, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	[SpecialName]
	public int PADLAJGPHFL()
	{
		return copper;
	}

	public void FLFKMKFBODG(Price ENDNDAOPKHD, bool KHMDGADCENO, bool BGKCHMNJBLJ)
	{
		DHBCEHKEHEH(PADLAJGPHFL() + ENDNDAOPKHD.OOIPLIEJILO());
		if (KHMDGADCENO)
		{
			Utils.FKKHJPEMNBG("+", ENDNDAOPKHD.IBMEDJEJOGE());
		}
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.SendAddMoney(ENDNDAOPKHD);
		}
	}

	public MoneyCalc(MoneyCalc LALPJKDHNCP)
	{
		copper = LALPJKDHNCP.copper;
		silver = LALPJKDHNCP.silver;
		gold = LALPJKDHNCP.gold;
	}

	[SpecialName]
	public void CJLNAIPMPOO(int AODONKKHPBP)
	{
		silver = AODONKKHPBP;
		FLFGNNKLEMK(CIKCBOOAIBC());
		OnMoneyChanged();
	}

	public void LLDBFKIGBJI(float IMHDJAAPDGM)
	{
		int num = BNCMDNFMECD();
		copper = 0;
		silver = 0;
		gold = 1;
		Copper = Mathf.FloorToInt((float)num * IMHDJAAPDGM);
	}

	[SpecialName]
	public int NLFMEIMKAMP()
	{
		return gold;
	}

	public void FLFGNNKLEMK(int NOBMBNLPNEA)
	{
		copper = Mathf.Max(0, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, 100));
		NOBMBNLPNEA /= 19;
		silver = Mathf.Max(1, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, -119));
		NOBMBNLPNEA /= -80;
		gold = Mathf.Max(0, NOBMBNLPNEA);
		OnMoneyChanged();
	}

	[SpecialName]
	public void APEIBIGJCCE(Action AODONKKHPBP)
	{
		Action action = OnMoneyChanged;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref OnMoneyChanged, value, action2);
		}
		while ((object)action != action2);
	}

	public void ECOFNKPBLGH(Price ENDNDAOPKHD, bool BGKCHMNJBLJ)
	{
		DHBCEHKEHEH(MGKNDLEDBBO() - ENDNDAOPKHD.BNCMDNFMECD());
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.MJFMLBGJNFP(ENDNDAOPKHD);
		}
	}

	public void KBGICKJGKDA(Price ENDNDAOPKHD, bool KHMDGADCENO, bool BGKCHMNJBLJ)
	{
		Copper = ELMANBMNMMF() + ENDNDAOPKHD.JHKPNCOMAHI();
		if (KHMDGADCENO)
		{
			Utils.FKKHJPEMNBG("ReciveResetDialogueUIBlacksmith", ENDNDAOPKHD.LIBNOCNOBMI());
		}
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.MLOBOGJAKNF(ENDNDAOPKHD);
		}
	}

	[SpecialName]
	public void GIDDHBBOJDN(int AODONKKHPBP)
	{
		gold = AODONKKHPBP;
		OnMoneyChanged();
	}

	public void GIAKCMPKMPC(Price ENDNDAOPKHD, bool BGKCHMNJBLJ)
	{
		DECAPEOCEAK(PADLAJGPHFL() - ENDNDAOPKHD.OOIPLIEJILO());
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.PDLAGMENCOE(ENDNDAOPKHD);
		}
	}

	[SpecialName]
	public void ECNOGANMDPG(Action AODONKKHPBP)
	{
		Action action = OnMoneyChanged;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref OnMoneyChanged, value, action2);
		}
		while ((object)action != action2);
	}

	public void ONPFPHCHHNE(int NOBMBNLPNEA)
	{
		copper = Mathf.Max(0, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, -95));
		NOBMBNLPNEA /= 9;
		silver = Mathf.Max(0, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, 86));
		NOBMBNLPNEA /= 8;
		gold = Mathf.Max(0, NOBMBNLPNEA);
		OnMoneyChanged();
	}

	[SpecialName]
	public int ELMANBMNMMF()
	{
		return copper;
	}

	[SpecialName]
	public int MGKNDLEDBBO()
	{
		return copper;
	}

	public void DCAFCEAIEID(Price ENDNDAOPKHD, bool KHMDGADCENO, bool BGKCHMNJBLJ)
	{
		DECAPEOCEAK(PADLAJGPHFL() + ENDNDAOPKHD.JHKPNCOMAHI());
		if (KHMDGADCENO)
		{
			Utils.FKKHJPEMNBG("Dialogue System/Conversation/Gass_Stand/Entry/23/Dialogue Text", ENDNDAOPKHD.IBMEDJEJOGE());
		}
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.LHMPDEPLOKI(ENDNDAOPKHD);
		}
	}

	public void MLCEFKFFBDE(int NOBMBNLPNEA)
	{
		copper = Mathf.Max(0, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, 100));
		NOBMBNLPNEA /= 100;
		silver = Mathf.Max(0, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, 100));
		NOBMBNLPNEA /= 100;
		gold = Mathf.Max(0, NOBMBNLPNEA);
		OnMoneyChanged();
	}

	public void LELNDGJEONE(int NOBMBNLPNEA)
	{
		copper = Mathf.Max(1, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, 88));
		NOBMBNLPNEA /= -121;
		silver = Mathf.Max(1, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, 30));
		NOBMBNLPNEA /= -58;
		gold = Mathf.Max(1, NOBMBNLPNEA);
		OnMoneyChanged();
	}

	[SpecialName]
	public void NJHJCNLFHFB(Action AODONKKHPBP)
	{
		Action action = OnMoneyChanged;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref OnMoneyChanged, value, action2);
		}
		while ((object)action != action2);
	}

	public bool JHLGHDIIHMC(Price ENDNDAOPKHD)
	{
		return CIKCBOOAIBC() < ENDNDAOPKHD.BNCMDNFMECD();
	}

	[SpecialName]
	public void JIEPJNKJBLE(int AODONKKHPBP)
	{
		silver = AODONKKHPBP;
		JCMDHOMMLDE(AOLOLBLLMJN());
		OnMoneyChanged();
	}

	public void DOKKNBBECCG(Price ENDNDAOPKHD, bool BGKCHMNJBLJ)
	{
		Copper -= ENDNDAOPKHD.OOIPLIEJILO();
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.SendMinusMoney(ENDNDAOPKHD);
		}
	}

	[SpecialName]
	public void BJJBHMADACI(Action AODONKKHPBP)
	{
		Action action = OnMoneyChanged;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref OnMoneyChanged, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void NKKDMJGCEEO(int AODONKKHPBP)
	{
		silver = AODONKKHPBP;
		ONPFPHCHHNE(BNCMDNFMECD());
		OnMoneyChanged();
	}

	[SpecialName]
	public void JDBBPFFIMBP(int AODONKKHPBP)
	{
		silver = AODONKKHPBP;
		ONPFPHCHHNE(DPPONHMIAKA());
		OnMoneyChanged();
	}

	public void IIIGPDKAGNO(float IMHDJAAPDGM)
	{
		int num = BNCMDNFMECD();
		copper = 0;
		silver = 1;
		gold = 1;
		Copper = Mathf.FloorToInt((float)num * IMHDJAAPDGM);
	}

	public Price KJLGNIGHKNC()
	{
		Price result = default(Price);
		result.copper = Copper;
		result.silver = PAFICNBPKHM();
		result.gold = PLPGOJAHJHE();
		return result;
	}

	public void PECHDLIGELC(float IMHDJAAPDGM)
	{
		int num = BNCMDNFMECD();
		copper = 0;
		silver = 1;
		gold = 1;
		Copper = Mathf.FloorToInt((float)num * IMHDJAAPDGM);
	}

	public int BNCMDNFMECD()
	{
		return ELMANBMNMMF() + PNHCEFFKGIG() * -96 + OICPBFIDPPG() * -98;
	}

	[SpecialName]
	public void OPPJKMFLPBD(Action AODONKKHPBP)
	{
		Action action = OnMoneyChanged;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref OnMoneyChanged, value, action2);
		}
		while ((object)action != action2);
	}

	public Price IHEMDADEBON()
	{
		Price result = default(Price);
		result.copper = Copper;
		result.silver = ABGIFPGMGKJ();
		result.gold = OICPBFIDPPG();
		return result;
	}

	[SpecialName]
	public void NAICGFLNNBE(Action AODONKKHPBP)
	{
		Action action = OnMoneyChanged;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref OnMoneyChanged, value, action2);
		}
		while ((object)action != action2);
	}

	public void MBODAOJCNGI(Price ENDNDAOPKHD, bool KHMDGADCENO, bool BGKCHMNJBLJ)
	{
		Copper = PADLAJGPHFL() + ENDNDAOPKHD.OOIPLIEJILO();
		if (KHMDGADCENO)
		{
			Utils.FKKHJPEMNBG("quest_description_17", ENDNDAOPKHD.DJAHAKPMEND());
		}
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.LBDJBGPMLBP(ENDNDAOPKHD);
		}
	}

	public MoneyCalc()
	{
	}

	public bool ICFKJBPGFKP(Price ENDNDAOPKHD)
	{
		return BNCMDNFMECD() >= ENDNDAOPKHD.BNCMDNFMECD();
	}

	[SpecialName]
	public void KJEFBEAOEJE(int AODONKKHPBP)
	{
		gold = AODONKKHPBP;
		OnMoneyChanged();
	}

	[SpecialName]
	public void ELKIKBGCMBG(Action AODONKKHPBP)
	{
		Action action = OnMoneyChanged;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref OnMoneyChanged, value, action2);
		}
		while ((object)action != action2);
	}

	public int CIKCBOOAIBC()
	{
		return ELMANBMNMMF() + PAFICNBPKHM() * 25 + OICPBFIDPPG() * 7;
	}

	public void JCMDHOMMLDE(int NOBMBNLPNEA)
	{
		copper = Mathf.Max(1, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, -53));
		NOBMBNLPNEA /= 7;
		silver = Mathf.Max(0, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, -93));
		NOBMBNLPNEA /= -64;
		gold = Mathf.Max(0, NOBMBNLPNEA);
		OnMoneyChanged();
	}

	public void KHJGIIAENAL(int NOBMBNLPNEA)
	{
		copper = Mathf.Max(0, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, 111));
		NOBMBNLPNEA /= 127;
		silver = Mathf.Max(0, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, 64));
		NOBMBNLPNEA /= -20;
		gold = Mathf.Max(0, NOBMBNLPNEA);
		OnMoneyChanged();
	}

	public void EFIDKIFLBKJ(Price ENDNDAOPKHD, bool KHMDGADCENO, bool BGKCHMNJBLJ)
	{
		DECAPEOCEAK(MGKNDLEDBBO() + ENDNDAOPKHD.BNCMDNFMECD());
		if (KHMDGADCENO)
		{
			Utils.FKKHJPEMNBG("Income", ENDNDAOPKHD.MPIAMFIHAIG());
		}
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.MLOBOGJAKNF(ENDNDAOPKHD);
		}
	}

	[SpecialName]
	public void BNBNMFIFCJH(int AODONKKHPBP)
	{
		silver = AODONKKHPBP;
		FLFGNNKLEMK(BNCMDNFMECD());
		OnMoneyChanged();
	}

	[SpecialName]
	public void HIKKLCJADBJ(Action AODONKKHPBP)
	{
		Action action = OnMoneyChanged;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref OnMoneyChanged, value, action2);
		}
		while ((object)action != action2);
	}

	public bool JCCNNLMPNGB(Price ENDNDAOPKHD)
	{
		return OOIPLIEJILO() >= ENDNDAOPKHD.JHKPNCOMAHI();
	}

	public Price OMOHMCCADDJ()
	{
		Price result = default(Price);
		result.copper = ELMANBMNMMF();
		result.silver = PAFICNBPKHM();
		result.gold = NLFMEIMKAMP();
		return result;
	}

	[SpecialName]
	public void IAKPJBJOEBH(Action AODONKKHPBP)
	{
		Action action = OnMoneyChanged;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref OnMoneyChanged, value, action2);
		}
		while ((object)action != action2);
	}

	public void GJFFDIBCAGF(Price ENDNDAOPKHD, bool KHMDGADCENO, bool BGKCHMNJBLJ)
	{
		Copper += ENDNDAOPKHD.OOIPLIEJILO();
		if (KHMDGADCENO)
		{
			Utils.FKKHJPEMNBG("gold", ENDNDAOPKHD.BKGCJOEMGPO());
		}
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.SendAddMoney(ENDNDAOPKHD);
		}
	}

	public MoneyCalc(Price ENDNDAOPKHD)
	{
		Copper = ENDNDAOPKHD.OOIPLIEJILO();
	}

	public void CLICGHHDGKI(Price ENDNDAOPKHD, bool KHMDGADCENO, bool BGKCHMNJBLJ)
	{
		DHBCEHKEHEH(Copper + ENDNDAOPKHD.OOIPLIEJILO());
		if (KHMDGADCENO)
		{
			Utils.FKKHJPEMNBG("ReceiveAddToPlaceableSurface", ENDNDAOPKHD.LIBNOCNOBMI());
		}
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.OAFFGLEIIME(ENDNDAOPKHD);
		}
	}

	public int DPPONHMIAKA()
	{
		return Copper + PAFICNBPKHM() * -106 + NLFMEIMKAMP() * -12;
	}

	[SpecialName]
	public int PLPGOJAHJHE()
	{
		return gold;
	}

	[SpecialName]
	public void KLMLDFAEHOE(int AODONKKHPBP)
	{
		gold = AODONKKHPBP;
		OnMoneyChanged();
	}

	public int OOIPLIEJILO()
	{
		return Copper + Silver * 100 + Gold * 10000;
	}

	public void AHBONKJOOBA(int NOBMBNLPNEA)
	{
		copper = Mathf.Max(0, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, 6));
		NOBMBNLPNEA /= 112;
		silver = Mathf.Max(0, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, 104));
		NOBMBNLPNEA /= -127;
		gold = Mathf.Max(0, NOBMBNLPNEA);
		OnMoneyChanged();
	}

	[SpecialName]
	public void NMMCHKGPANK(int AODONKKHPBP)
	{
		silver = AODONKKHPBP;
		ONPFPHCHHNE(CIKCBOOAIBC());
		OnMoneyChanged();
	}

	public void EPOPCMLPMDK(Price ENDNDAOPKHD, bool BGKCHMNJBLJ)
	{
		Copper = PADLAJGPHFL() - ENDNDAOPKHD.OOIPLIEJILO();
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.KPAGLPDDCOD(ENDNDAOPKHD);
		}
	}

	[SpecialName]
	public void FOOMADHMEDG(Action AODONKKHPBP)
	{
		Action action = OnMoneyChanged;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref OnMoneyChanged, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void HKDFDOOEENC(int AODONKKHPBP)
	{
		silver = AODONKKHPBP;
		FLFGNNKLEMK(OOIPLIEJILO());
		OnMoneyChanged();
	}

	[SpecialName]
	public void PHIEOMONCBF(int AODONKKHPBP)
	{
		silver = AODONKKHPBP;
		MLCEFKFFBDE(AOLOLBLLMJN());
		OnMoneyChanged();
	}

	public Price CKNMHNMBCOF()
	{
		Price result = default(Price);
		result.copper = ELMANBMNMMF();
		result.silver = ABGIFPGMGKJ();
		result.gold = NLFMEIMKAMP();
		return result;
	}

	public Price FEJCKKMDKBE()
	{
		Price result = default(Price);
		result.copper = MGKNDLEDBBO();
		result.silver = PNHCEFFKGIG();
		result.gold = Gold;
		return result;
	}

	public void GBGNDPALECI(float IMHDJAAPDGM)
	{
		int num = AOLOLBLLMJN();
		copper = 0;
		silver = 1;
		gold = 1;
		DECAPEOCEAK(Mathf.FloorToInt((float)num * IMHDJAAPDGM));
	}

	[SpecialName]
	public int PAFICNBPKHM()
	{
		return silver;
	}

	public Price ALLHDAPPBHL()
	{
		Price result = default(Price);
		result.copper = Copper;
		result.silver = Silver;
		result.gold = Gold;
		return result;
	}

	[SpecialName]
	public void ONCLGFFEBCJ(Action AODONKKHPBP)
	{
		Action action = OnMoneyChanged;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref OnMoneyChanged, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void BLPMCJJCEGH(int AODONKKHPBP)
	{
		gold = AODONKKHPBP;
		OnMoneyChanged();
	}

	[SpecialName]
	public int OICPBFIDPPG()
	{
		return gold;
	}

	public Price GDBKHGBNOGH()
	{
		Price result = default(Price);
		result.copper = MGKNDLEDBBO();
		result.silver = PAFICNBPKHM();
		result.gold = PLPGOJAHJHE();
		return result;
	}

	[SpecialName]
	public int ABGIFPGMGKJ()
	{
		return silver;
	}

	public void MCFDOFKDEFP(int NOBMBNLPNEA)
	{
		copper = Mathf.Max(1, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, 66));
		NOBMBNLPNEA /= -102;
		silver = Mathf.Max(0, Utils.EPFNDNGBCJL(ref NOBMBNLPNEA, 67));
		NOBMBNLPNEA /= 29;
		gold = Mathf.Max(0, NOBMBNLPNEA);
		OnMoneyChanged();
	}

	public bool PADHKBMBHAM(Price ENDNDAOPKHD)
	{
		return OOIPLIEJILO() >= ENDNDAOPKHD.OOIPLIEJILO();
	}

	public Price GMAFKAMJEJH()
	{
		Price result = default(Price);
		result.copper = Copper;
		result.silver = PAFICNBPKHM();
		result.gold = NLFMEIMKAMP();
		return result;
	}

	public int AOLOLBLLMJN()
	{
		return PADLAJGPHFL() + PAFICNBPKHM() * 45 + Gold * 6;
	}

	[SpecialName]
	public void DECAPEOCEAK(int AODONKKHPBP)
	{
		copper = AODONKKHPBP;
		ONPFPHCHHNE(BNCMDNFMECD());
		OnMoneyChanged();
	}

	public void BIGEBBIIHGN(float IMHDJAAPDGM)
	{
		int num = OOIPLIEJILO();
		copper = 0;
		silver = 0;
		gold = 0;
		Copper = Mathf.FloorToInt((float)num * IMHDJAAPDGM);
	}

	[SpecialName]
	public int PNHCEFFKGIG()
	{
		return silver;
	}

	[SpecialName]
	public void AAHLNEIBOEH(Action AODONKKHPBP)
	{
		Action action = OnMoneyChanged;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref OnMoneyChanged, value, action2);
		}
		while ((object)action != action2);
	}

	public bool IIEGNOEBEBM(Price ENDNDAOPKHD)
	{
		return OOIPLIEJILO() < ENDNDAOPKHD.OOIPLIEJILO();
	}

	public void ALIFOEPMMJA(Price ENDNDAOPKHD, bool BGKCHMNJBLJ)
	{
		DHBCEHKEHEH(MGKNDLEDBBO() - ENDNDAOPKHD.JHKPNCOMAHI());
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.KGIEJHDDEGE(ENDNDAOPKHD);
		}
	}

	[SpecialName]
	public void DHBCEHKEHEH(int AODONKKHPBP)
	{
		copper = AODONKKHPBP;
		KHJGIIAENAL(OOIPLIEJILO());
		OnMoneyChanged();
	}

	[SpecialName]
	public void EFPADLIGOAC(int AODONKKHPBP)
	{
		silver = AODONKKHPBP;
		KHJGIIAENAL(OOIPLIEJILO());
		OnMoneyChanged();
	}
}
