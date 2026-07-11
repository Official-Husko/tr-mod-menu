using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class NPCShowOff : MonoBehaviour
{
	private CharacterAnimation PBGCIHNAIAN;

	private CharacterCreator FBDKDGBBPKI;

	private float ECEOKAIAJDG;

	private float NOFPIKJHEBM;

	private int[] PLMBMPCJPJD = new int[4] { 1, 2, 0, 3 };

	private int MENBAFNNBFB;

	private bool EOKCCGDOLEL;

	public static event Action BDJENIOPJKC;

	private void EBJPPNBLGOC()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.BAMEGNNLCFD();
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 4;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 668f;
		}
	}

	private void OKHLEMPJONN()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void OIHPFDGFCHF()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = true;
			FBDKDGBBPKI.BAMEGNNLCFD(GCANBIEGDOA: false);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 5;
			PBGCIHNAIAN.NCAJNNHBHJM((Direction)PLMBMPCJPJD[MENBAFNNBFB]);
			NOFPIKJHEBM = Time.time + 793f;
		}
	}

	private void DNBGIIGAKMJ()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void LNPDALMANFB()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void NLGHNDLPPKI()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void BHLAGCODJGJ()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.FGIGIKNMLEM(GCANBIEGDOA: true, GADKADLHDGJ: false, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 0;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 673f;
		}
	}

	private void EDFDMFBJKBA()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.OEBDHLPOHEE(GCANBIEGDOA: false);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 6;
			PBGCIHNAIAN.NCAJNNHBHJM((Direction)PLMBMPCJPJD[MENBAFNNBFB]);
			NOFPIKJHEBM = Time.time + 1840f;
		}
	}

	private void CEOEHODJAJK()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	[SpecialName]
	public static void OBDJMBJMJMH(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public static void OHLDCCDJGML(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void DKFGDMNBAAK()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = true;
			FBDKDGBBPKI.FGIGIKNMLEM(GCANBIEGDOA: true, GADKADLHDGJ: true, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 2;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 1189f;
		}
	}

	private void Awake()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void BNFGHAGJEGG()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	[SpecialName]
	public static void AACBLPJAHKN(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public static void GBLIBPMMPMM(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void GOBPJEDFOAC()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.RandomCharacter(GCANBIEGDOA: false, GADKADLHDGJ: false);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 7;
			PBGCIHNAIAN.NCAJNNHBHJM((Direction)PLMBMPCJPJD[MENBAFNNBFB]);
			NOFPIKJHEBM = Time.time + 1834f;
		}
	}

	private void NDDPKJIHKNA()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = true;
			FBDKDGBBPKI.FGIGIKNMLEM(GCANBIEGDOA: false, GADKADLHDGJ: false);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 1) % 3;
			PBGCIHNAIAN.NCAJNNHBHJM((Direction)PLMBMPCJPJD[MENBAFNNBFB]);
			NOFPIKJHEBM = Time.time + 257f;
		}
	}

	[SpecialName]
	public static void ABDBHHLBELO(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void DNKEFFMOCKP()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void JDAMCMODANB()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void MEKHIDLBMHN()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = true;
			FBDKDGBBPKI.FGIGIKNMLEM(GCANBIEGDOA: true, GADKADLHDGJ: true, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 1;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 1694f;
		}
	}

	[SpecialName]
	public static void MCFLDPGMPLD(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void CEGIGMHMJOB()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = true;
			FBDKDGBBPKI.RandomCharacter(GCANBIEGDOA: true, GADKADLHDGJ: false, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 1) % 5;
			PBGCIHNAIAN.NCAJNNHBHJM((Direction)PLMBMPCJPJD[MENBAFNNBFB]);
			NOFPIKJHEBM = Time.time + 801f;
		}
	}

	[SpecialName]
	public static void NICCECEJANG(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void HINGECEDJAP()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void KMDMCEEGHAG()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = true;
			FBDKDGBBPKI.BAMEGNNLCFD(GCANBIEGDOA: true, GADKADLHDGJ: false, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 1) % 0;
			PBGCIHNAIAN.NCAJNNHBHJM((Direction)PLMBMPCJPJD[MENBAFNNBFB]);
			NOFPIKJHEBM = Time.time + 564f;
		}
	}

	[SpecialName]
	public static void JABJKELLHNC(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public static void CEEGHJAHDBI(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void GFPPEHOHGDD()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = true;
			FBDKDGBBPKI.FGIGIKNMLEM(GCANBIEGDOA: true, GADKADLHDGJ: true, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 1) % 6;
			PBGCIHNAIAN.NCAJNNHBHJM((Direction)PLMBMPCJPJD[MENBAFNNBFB]);
			NOFPIKJHEBM = Time.time + 95f;
		}
	}

	private void LAPKOCHBNNP()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = true;
			FBDKDGBBPKI.FGIGIKNMLEM(GCANBIEGDOA: false, GADKADLHDGJ: true, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 1;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 1766f;
		}
	}

	[SpecialName]
	public static void IJCKIJDLDJP(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void KDHLJKMKFMG()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	[SpecialName]
	public static void MEJPGEECLIM(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void MBMFDJHDNCI()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.BAMEGNNLCFD(GCANBIEGDOA: false, GADKADLHDGJ: true, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 0;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 937f;
		}
	}

	private void GNOBDKFFPOL()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	[SpecialName]
	public static void EFLLDFKJKAI(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public static void BBLAGANAMDF(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void CLNBMOPMNOF()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	[SpecialName]
	public static void AEPLNKGLLON(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void IIKAAAHEFMP()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = true;
			FBDKDGBBPKI.OEBDHLPOHEE(GCANBIEGDOA: true, GADKADLHDGJ: true, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 3;
			PBGCIHNAIAN.NCAJNNHBHJM((Direction)PLMBMPCJPJD[MENBAFNNBFB]);
			NOFPIKJHEBM = Time.time + 1146f;
		}
	}

	private void LateUpdate()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.RandomCharacter(GCANBIEGDOA: true, GADKADLHDGJ: true, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 1) % 4;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 1f;
		}
	}

	[SpecialName]
	public static void AEKDJHBPGFP(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public static void ADCCAIGGCIM(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public static void JFOJKALPEPE(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void GONDLJKGLGO()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void AMNCIAEMBFO()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	[SpecialName]
	public static void MIANDFAOCFG(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void JIAJFDKNJME()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	[SpecialName]
	public static void KBKHIIIOEGD(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public static void NGECPKDIGNK(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void GOGOIJNNEJF()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.FGIGIKNMLEM(GCANBIEGDOA: true, GADKADLHDGJ: false, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 1;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 1251f;
		}
	}

	private void PNLAJCHBHPH()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void LPPMKNJBPHC()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.OEBDHLPOHEE(GCANBIEGDOA: false);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 6;
			PBGCIHNAIAN.NCAJNNHBHJM((Direction)PLMBMPCJPJD[MENBAFNNBFB]);
			NOFPIKJHEBM = Time.time + 1845f;
		}
	}

	[SpecialName]
	public static void FGCMBHKABJC(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void PDIECJCKCOD()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	[SpecialName]
	public static void OMFKHFOBAPD(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void PBDNKBPBCHM()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void KMEJBPOOBJK()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	[SpecialName]
	public static void OOIEKDEBPAG(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public static void EBMODDMLNLK(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void ADPGHKHOONH()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.FGIGIKNMLEM(GCANBIEGDOA: false, GADKADLHDGJ: false, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 1) % 1;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 124f;
		}
	}

	private void GPABCKFFLLM()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.FGIGIKNMLEM();
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 1) % 5;
			PBGCIHNAIAN.NCAJNNHBHJM((Direction)PLMBMPCJPJD[MENBAFNNBFB]);
			NOFPIKJHEBM = Time.time + 1447f;
		}
	}

	private void HMGBIMHKFOD()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.FGIGIKNMLEM(GCANBIEGDOA: true, GADKADLHDGJ: true, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 4;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 1457f;
		}
	}

	private void AFHGDCBNALO()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = true;
			FBDKDGBBPKI.BAMEGNNLCFD(GCANBIEGDOA: false, GADKADLHDGJ: false, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 3;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 1644f;
		}
	}

	[SpecialName]
	public static void FJPJLDAONDM(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public static void FAAGIPEABCG(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public static void LIILCDFBKKF(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void IFGLHEPFIKN()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.OEBDHLPOHEE(GCANBIEGDOA: false);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 1) % 7;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 275f;
		}
	}

	[SpecialName]
	public static void IADFFMKGJDG(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public static void HBDHGONGHNA(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void AAEAAEBBFKG()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	[SpecialName]
	public static void HHAPCJGILGB(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void ILBGPIEPNGO()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.RandomCharacter();
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 1) % 1;
			PBGCIHNAIAN.NCAJNNHBHJM((Direction)PLMBMPCJPJD[MENBAFNNBFB]);
			NOFPIKJHEBM = Time.time + 575f;
		}
	}

	[SpecialName]
	public static void HGMPANCEMIF(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void NMKGOAJLMDG()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	[SpecialName]
	public static void PLCKOBFHIOJ(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void GECHJIGBPEN()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void BGBFJPJLPMF()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	static NPCShowOff()
	{
		NPCShowOff.BDJENIOPJKC = delegate
		{
		};
	}

	private void BODEIHFOAMI()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.FGIGIKNMLEM(GCANBIEGDOA: false, GADKADLHDGJ: false, JHIFLALPEBF: true);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 1) % 2;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 73f;
		}
	}

	private void FHOCCEBKHJI()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	[SpecialName]
	public static void GNKIMLCMDNF(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void ALEAOANPHIO()
	{
		PBGCIHNAIAN = ((Component)this).GetComponent<CharacterAnimation>();
		FBDKDGBBPKI = ((Component)this).GetComponent<CharacterCreator>();
	}

	[SpecialName]
	public static void HOBFBLFAMME(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}

	private void NKJGCFHENMG()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = false;
			FBDKDGBBPKI.OEBDHLPOHEE(GCANBIEGDOA: false);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 5;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 727f;
		}
	}

	private void DAKLOGKFLLD()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = true;
			FBDKDGBBPKI.FGIGIKNMLEM(GCANBIEGDOA: false, GADKADLHDGJ: false);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 1) % 2;
			PBGCIHNAIAN.NCAJNNHBHJM((Direction)PLMBMPCJPJD[MENBAFNNBFB]);
			NOFPIKJHEBM = Time.time + 676f;
		}
	}

	private void MOGGLNNINON()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = true;
			FBDKDGBBPKI.RandomCharacter(GCANBIEGDOA: true, GADKADLHDGJ: false);
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 4;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 1527f;
		}
	}

	private void JPPCPMOMDON()
	{
		if (EOKCCGDOLEL)
		{
			EOKCCGDOLEL = true;
			FBDKDGBBPKI.OEBDHLPOHEE();
			NPCShowOff.BDJENIOPJKC();
		}
		if (Time.time > NOFPIKJHEBM)
		{
			MENBAFNNBFB = (MENBAFNNBFB + 0) % 1;
			PBGCIHNAIAN.FCGBJEIIMBC = (Direction)PLMBMPCJPJD[MENBAFNNBFB];
			NOFPIKJHEBM = Time.time + 1814f;
		}
	}

	[SpecialName]
	public static void FJIGDABCPED(Action AODONKKHPBP)
	{
		Action action = NPCShowOff.BDJENIOPJKC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref NPCShowOff.BDJENIOPJKC, value, action2);
		}
		while ((object)action != action2);
	}
}
