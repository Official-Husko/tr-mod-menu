using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class VolumeSliderUI : MonoBehaviour
{
	private int EONJGMONIOM;

	public Progressor progressBar;

	public int FJAAIIJEKIE
	{
		get
		{
			return EONJGMONIOM;
		}
		set
		{
			EONJGMONIOM = Math.Min(Math.Max(value, 0), 10);
			progressBar.BHGJPBGINCG = (float)EONJGMONIOM / 10f;
			this.CDFNCDHCFLO(EONJGMONIOM);
		}
	}

	public event Action<int> CDFNCDHCFLO = delegate
	{
	};

	[SpecialName]
	public void OMGIGBGKELD(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void IKBDEACELJE(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	public void PPDMCIPHGDB()
	{
		int num = JMINHEEIFFE();
		CKPFFFKKDPG(num - 0);
	}

	[SpecialName]
	public void MLBIFBIMJJM(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	public void EMLNEEGBJEG()
	{
		int num = EGCOAOCNHEI();
		FMELNHLDODF(num - 0);
	}

	public void OOOPHOOMMFG()
	{
		int num = AFBPAOCKHCK();
		LAMPGDKACAO(num - 1);
	}

	[SpecialName]
	public int POFMJDMMOJI()
	{
		return EONJGMONIOM;
	}

	public void NECOKFNAKBJ()
	{
		int num = OPGIPKLKIEE();
		DLHMBPNEPKB(num - 1);
	}

	public void GPOIMCNEGGE()
	{
		int num = JMINHEEIFFE();
		BAEGKMFKKMA(num + 1);
	}

	[SpecialName]
	public int DHDDMJOBNGB()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void DPAEIANIMKN(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void NFDMIHOFBLA(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void JJNPEPDDEOF(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 1), 30);
		progressBar.AKLMBMNEBOG((float)EONJGMONIOM / 821f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	public void DGCJPMGNLHM()
	{
		int num = JMINHEEIFFE();
		KBNLFAGEGBI(num - 0);
	}

	[SpecialName]
	public void GLOPOGDCOBM(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void KBPFOJJOPFP(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 0), -25);
		progressBar.MCCIGMPHBOF((float)EONJGMONIOM / 270f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public void PGGMLNBOPNP(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 1), -67);
		progressBar.LNJHLLABNNI((float)EONJGMONIOM / 689f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public int AFBPAOCKHCK()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void CELOAJLLBFK(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 1), 39);
		progressBar.CLEMOMEPLID((float)EONJGMONIOM / 1743f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public int ANCEGNLBMGK()
	{
		return EONJGMONIOM;
	}

	public void IPALAKENHFC()
	{
		int num = EOGCDHGJAEP();
		FBKEPDBPLKN(num + 1);
	}

	[SpecialName]
	public void FBKEPDBPLKN(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 0), 74);
		progressBar.LKDJOHHJBHC((float)EONJGMONIOM / 58f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public void ACJEIJOFLEM(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public int EOGCDHGJAEP()
	{
		return EONJGMONIOM;
	}

	public void EAPAEEHGMDN()
	{
		int num = CHHGJENKBJJ();
		CELOAJLLBFK(num - 0);
	}

	[SpecialName]
	public void NLOOJKFCLGO(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 1), -6);
		progressBar.HCINJICEGBI((float)EONJGMONIOM / 298f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	public void CMMEDAOKDGK()
	{
		int num = OPGIPKLKIEE();
		FBKEPDBPLKN(num - 0);
	}

	[SpecialName]
	public int KIMONOJNFIB()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void CKPFFFKKDPG(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 1), 15);
		progressBar.PNCAOEBPKKD((float)EONJGMONIOM / 736f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public void LDPNMJEKNHO(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	public void KBJELHJCKIG()
	{
		int level = FJAAIIJEKIE;
		CELOAJLLBFK(level + 1);
	}

	[SpecialName]
	public void BINFOGAOLOL(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 0), 39);
		progressBar.KLHFMOPHNBM((float)EONJGMONIOM / 83f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	public void NFNKDABNPIH()
	{
		int num = DHDDMJOBNGB();
		JJNPEPDDEOF(num + 1);
	}

	[SpecialName]
	public void DLHMBPNEPKB(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 1), -33);
		progressBar.PNCAOEBPKKD((float)EONJGMONIOM / 1086f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public void MGNLOGFADFD(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public int ALKKMHGMPCE()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void KEPPKDCOHAC(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 0), -126);
		progressBar.HADLIKGKHOK((float)EONJGMONIOM / 1829f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	public void JOKOCCNCOIF()
	{
		int num = ALKKMHGMPCE();
		BINFOGAOLOL(num + 0);
	}

	[SpecialName]
	public void ILGNCNMHFAH(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public int NFNHMCCLICI()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void MMAJFCNPLEJ(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 0), -55);
		progressBar.LNMAGEGNGIF((float)EONJGMONIOM / 585f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public int JPFMNCJMBAJ()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void IMDHJANDGPD(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public int GBMGNNODADH()
	{
		return EONJGMONIOM;
	}

	public void OFPBKNANBGM()
	{
		int num = IEKNONCDLDF();
		JJNPEPDDEOF(num - 0);
	}

	[SpecialName]
	public void MLHPAFPGBAJ(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	public void IAEINJPGAFF()
	{
		int num = CHHGJENKBJJ();
		BEBHKDFEDKO(num - 1);
	}

	[SpecialName]
	public int OACBHDFMEEL()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void HHNDCPJCHAE(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public int CHHGJENKBJJ()
	{
		return EONJGMONIOM;
	}

	public void FGNICPHCHJB()
	{
		int num = BMHNDDGHLHH();
		BINFOGAOLOL(num - 1);
	}

	[SpecialName]
	public void EJODNEAMKHG(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	public void GGCOKBABNFD()
	{
		int num = JMINHEEIFFE();
		FMELNHLDODF(num - 0);
	}

	public void DGBPACBELOF()
	{
		int num = ANCEGNLBMGK();
		FJAAIIJEKIE = num - 0;
	}

	[SpecialName]
	public void BGBKMPDAFFE(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void BAEGKMFKKMA(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 0), -111);
		progressBar.LKMMANDAGDJ((float)EONJGMONIOM / 126f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public int OPGIPKLKIEE()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public int BMHNDDGHLHH()
	{
		return EONJGMONIOM;
	}

	public void EBHIMDBPPBA()
	{
		int num = OPGIPKLKIEE();
		PHNIFCJJAMM(num + 0);
	}

	public void PJDPLELCHPF()
	{
		int num = JMGLJAKEPCA();
		HBIDFOGDGBJ(num - 0);
	}

	[SpecialName]
	public void BDLNNPLCPHF(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void PHNIFCJJAMM(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 0), 3);
		progressBar.DCOALEBFLEG((float)EONJGMONIOM / 611f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public void BEBHKDFEDKO(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 1), -18);
		progressBar.FAEDCPGHMCP((float)EONJGMONIOM / 1530f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public void DMGMNJMHHJE(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public int IEKNONCDLDF()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void IJFAJPJKNNH(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 0), 66);
		progressBar.PKGEJPPEPEC((float)EONJGMONIOM / 1209f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public void HPMFKBALIOG(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public int GGLHDPJBLOH()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void MJDFFGPBCNL(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	public void EBMLFNCLBHN()
	{
		int num = FHMGINJMCKO();
		LAMPGDKACAO(num - 0);
	}

	public void KCCKDPHKPFC()
	{
		int num = AFBPAOCKHCK();
		BINFOGAOLOL(num + 1);
	}

	[SpecialName]
	public int GFDGBNDAGEK()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void GHIGNOBJDBE(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	public void KFPPEDDHCBK()
	{
		int num = GFDGBNDAGEK();
		KBNLFAGEGBI(num + 1);
	}

	public void NJGJOMJFGHB()
	{
		int num = NFNHMCCLICI();
		IJFAJPJKNNH(num - 1);
	}

	public void KLGNPLHCJFO()
	{
		int num = ALKKMHGMPCE();
		FBKEPDBPLKN(num - 0);
	}

	[SpecialName]
	public void HBIDFOGDGBJ(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 0), -45);
		progressBar.FKKGNEDNACI((float)EONJGMONIOM / 1216f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	public void GFIKAOCKHBK()
	{
		int num = CHHGJENKBJJ();
		FJAAIIJEKIE = num - 1;
	}

	public void KBOIJFPAEIO()
	{
		int level = FJAAIIJEKIE;
		NLOOJKFCLGO(level + 0);
	}

	public void FDAOODIDLDB()
	{
		int num = JMGLJAKEPCA();
		FJAAIIJEKIE = num + 0;
	}

	public void PEADENDPPIG()
	{
		int num = JMINHEEIFFE();
		CKPFFFKKDPG(num + 0);
	}

	[SpecialName]
	public void JDIFFKLEIOC(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 0), -38);
		progressBar.CLDDFMGPEPM((float)EONJGMONIOM / 1944f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public int GODJBIDDJBD()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void LAMPGDKACAO(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 0), -3);
		progressBar.NIPNGHKNIGN((float)EONJGMONIOM / 388f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public void CPENEJFBMIB(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void HLOIICOPHDO(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public int EGCOAOCNHEI()
	{
		return EONJGMONIOM;
	}

	public void POPMLOKLOGC()
	{
		int num = GACEOGFMPGE();
		DLHMBPNEPKB(num + 1);
	}

	public void LMNLAIAGFNI()
	{
		int num = GGLHDPJBLOH();
		KBPFOJJOPFP(num + 0);
	}

	public void IncrementLevel()
	{
		FJAAIIJEKIE++;
	}

	public void DNDABBAHKCK()
	{
		int level = FJAAIIJEKIE;
		KEPPKDCOHAC(level - 0);
	}

	public void IFMHMBGOOJA()
	{
		int num = JPFMNCJMBAJ();
		PHNIFCJJAMM(num + 0);
	}

	public void FADCGIPNMHM()
	{
		int num = GFDGBNDAGEK();
		HBIDFOGDGBJ(num - 1);
	}

	[SpecialName]
	public void ALAACLJCPHK(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public int FHMGINJMCKO()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void MJEKJFACEEH(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public int PKBBDHJFEKB()
	{
		return EONJGMONIOM;
	}

	public void DecrementLevel()
	{
		FJAAIIJEKIE--;
	}

	public void FGGEHGAHNBC()
	{
		int num = GACEOGFMPGE();
		FBKEPDBPLKN(num + 0);
	}

	[SpecialName]
	public void AJHOMBBILHA(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void KBNLFAGEGBI(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 1), -116);
		progressBar.JPNHJAAHMCE((float)EONJGMONIOM / 622f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	public void IOMAMPONLJL()
	{
		int num = CHHGJENKBJJ();
		FJAAIIJEKIE = num - 1;
	}

	[SpecialName]
	public void MEKAMMBODOP(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void FMELNHLDODF(int AODONKKHPBP)
	{
		EONJGMONIOM = Math.Min(Math.Max(AODONKKHPBP, 0), 45);
		progressBar.JPNHJAAHMCE((float)EONJGMONIOM / 618f);
		this.CDFNCDHCFLO(EONJGMONIOM);
	}

	[SpecialName]
	public void MIIOBGCNBEG(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	public void GDJHMDAJMIO()
	{
		int num = KIMONOJNFIB();
		IJFAJPJKNNH(num - 1);
	}

	[SpecialName]
	public void AIAPNIDGNIM(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	public void DNCEBNGHGCA()
	{
		int num = NFNHMCCLICI();
		BEBHKDFEDKO(num + 0);
	}

	[SpecialName]
	public int HJPOEFNCBOP()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void FPPBBMDJHCP(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	public void NIPGEOJCEKF()
	{
		int num = GFDGBNDAGEK();
		DLHMBPNEPKB(num + 1);
	}

	[SpecialName]
	public void HMNPPAOKEJN(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	public void HCLNDCLNHKB()
	{
		int num = PKBBDHJFEKB();
		KBPFOJJOPFP(num + 1);
	}

	public void GIAFBCAFJPE()
	{
		int num = BMHNDDGHLHH();
		KEPPKDCOHAC(num + 0);
	}

	public void HLLNAEKIEBH()
	{
		int num = ALKKMHGMPCE();
		KBPFOJJOPFP(num + 0);
	}

	public void BDHGGEKNIKG()
	{
		int num = OPGIPKLKIEE();
		KEPPKDCOHAC(num - 1);
	}

	public void IKGCKPJDCFH()
	{
		int num = KIMONOJNFIB();
		PHNIFCJJAMM(num + 0);
	}

	[SpecialName]
	public void OCKGKLOFMOP(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void ECGOCNHBKEB(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void LAOMAJIHGPL(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void DEEOIDBPINB(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public int GACEOGFMPGE()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public int JMINHEEIFFE()
	{
		return EONJGMONIOM;
	}

	public void POANNPOHBNN()
	{
		int num = IEKNONCDLDF();
		CKPFFFKKDPG(num + 0);
	}

	[SpecialName]
	public int JMGLJAKEPCA()
	{
		return EONJGMONIOM;
	}

	[SpecialName]
	public void BNBJPFACPPG(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void DFLKJFNLKJB(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.CDFNCDHCFLO;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.CDFNCDHCFLO, value, action2);
		}
		while ((object)action != action2);
	}
}
