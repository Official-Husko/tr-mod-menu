using System;
using UnityEngine;

public class TileMapColorOverTime : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private Gradient tilemapColor;

	private Color FODFAHIOMPN()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.DHPFCKNGHLO() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color KPJPNLIJGNK()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.BNKLACHEGOP() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void NAEGOPAEJID()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = PNFHNHPJOAO();
	}

	private void CKKPEJGBDKK()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(ENFIDAMMGAF));
		}
	}

	private void LHABENPEMPB()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void PMMGCDBMMMN()
	{
		ILHHPLCAHDJ();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(IHDOJLKFPKP));
	}

	private void DCCJBKGNAOP()
	{
		KLEAAELDILC();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(CHIKHGJCJNB));
	}

	private void Awake()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void IEPJAFLDBJJ()
	{
		GDCNIDKFNIA();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(GFNEBAPGFNP));
	}

	private void FHOCCEBKHJI()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void NCFCFOKDGAB()
	{
		BDDHNLPBEFO();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(CHIKHGJCJNB));
	}

	private void IMMHKDGFCJA()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HAKLIGJFAIF));
		}
	}

	private Color OCONMJMNMDG()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.BBBGEBIPHPI() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(KLEAAELDILC));
		}
	}

	private void KLEAAELDILC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = JLCFBDHNEHA();
	}

	private void GEJLBPLNAOF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = GEKNEDIHDLG();
	}

	private void CGHHPELBKBK()
	{
		MCDDMCJLFLE();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(DCNOPODPMIP));
	}

	private void ILHHPLCAHDJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = BFHHALFLFAE();
	}

	private Color ADEEOAPIHKJ()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.BNKLACHEGOP() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void OBLCKPMAADM()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(GFNEBAPGFNP));
		}
	}

	private void JNNJIDAFBPI()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(DCNOPODPMIP));
		}
	}

	private void KMMBGBPDEMJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = DJHPGILMNOH();
	}

	private void PGPPIHJJGDB()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private Color DABFBPPODAJ()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void JKBBAOGHPKO()
	{
		GDCNIDKFNIA();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(KMMBGBPDEMJ));
	}

	private void AJGLDLLIIFO()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void GDCNIDKFNIA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = PMKDLHDNMBI();
	}

	private void ANPKHOCNLGK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = KDPJONGJLHJ();
	}

	private void GFNEBAPGFNP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = DNNDMFGBFCK();
	}

	private void DCNOPODPMIP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = GCAIFPDCBGM();
	}

	private void BPINJGFECPF()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(ANPKHOCNLGK));
		}
	}

	private Color LAPGHBDECAH()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.EDIPJBOOEHD / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color GGJAFLGKECJ()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.BBBGEBIPHPI() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void OKMGBGDDGAB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = LAPGHBDECAH();
	}

	private void CIAIAEJIMCM()
	{
		CHDHEPPMPNF();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(ENFIDAMMGAF));
	}

	private Color DJHPGILMNOH()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.EDIPJBOOEHD / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void AFGJLAACCFN()
	{
		NAEGOPAEJID();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(AIMFODMDLJD));
	}

	private Color EALEIHCABMH()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.BNKLACHEGOP() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color OHJOBAEBLDF()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.BBBGEBIPHPI() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void HPJBLOPJIMI()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void MCDDMCJLFLE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = PMKDLHDNMBI();
	}

	private void GCANIILEGFN()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(ANPKHOCNLGK));
		}
	}

	private void EPFJBCOKEHC()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(ILHHPLCAHDJ));
		}
	}

	private Color CPFPOCGKEKA()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.GBCKNDKCFFF() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color LBIMJOLEGCJ()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void DKDLOBOLNFH()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void GJCADEIJMCM()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HAKLIGJFAIF));
		}
	}

	private void DADPOICMNPI()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private Color IKDFGGHDILG()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void ABJHHOOJKCA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = GCAIFPDCBGM();
	}

	private void FNDJALHNLME()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(GFNEBAPGFNP));
		}
	}

	private void LAADMMNHHGA()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(OPHEHAALJKN));
		}
	}

	private void CACPOGPOKOJ()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(DCNOPODPMIP));
		}
	}

	private void ADJHOLOIGJE()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(MKDEOMGBCFE));
		}
	}

	private void JJCDLIHLDMJ()
	{
		MKDEOMGBCFE();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(GDCNIDKFNIA));
	}

	private void ADEBBJOALDN()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HAKLIGJFAIF));
		}
	}

	private void DMEEIHDDALH()
	{
		MKDEOMGBCFE();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(OPINKHFAKLD));
	}

	private void KLHIMJFCHPD()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void HJONPCBENJH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = CPFPOCGKEKA();
	}

	private void HEMAHKJEONA()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private Color PNFHNHPJOAO()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.BNKLACHEGOP() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void EHBMONGBJFI()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void NMPFHHEFOPH()
	{
		ENFIDAMMGAF();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(BDDHNLPBEFO));
	}

	private void ENFIDAMMGAF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = CPFPOCGKEKA();
	}

	private Color AILMIKMPGAH()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.GBCKNDKCFFF() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color GEKNEDIHDLG()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.DHPFCKNGHLO() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void JPJDFHEANJH()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HJONPCBENJH));
		}
	}

	private void AMHGMJDKONK()
	{
		MKDEOMGBCFE();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(MKDEOMGBCFE));
	}

	private void EIMIDCDEIDD()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void MPCFCNCMOAF()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void ANLHPMPMBFM()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(MCDDMCJLFLE));
		}
	}

	private void OnEnable()
	{
		KLEAAELDILC();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(KLEAAELDILC));
	}

	private void IHDOJLKFPKP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = OHJOBAEBLDF();
	}

	private void AIMFODMDLJD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = ADEEOAPIHKJ();
	}

	private void CHDHEPPMPNF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = BFHHALFLFAE();
	}

	private Color GCAIFPDCBGM()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.GBCKNDKCFFF() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color OOIKCNLDLMJ()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.GBCKNDKCFFF() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color DNNDMFGBFCK()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color JLCFBDHNEHA()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.EDIPJBOOEHD / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void DIJOBOFGCIK()
	{
		OPHEHAALJKN();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(GDCNIDKFNIA));
	}

	private void ECHMKEAGFFO()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(CHIKHGJCJNB));
		}
	}

	private Color KDPJONGJLHJ()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.BNKLACHEGOP() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void LMPCDDGFBGD()
	{
		HJONPCBENJH();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(GDCNIDKFNIA));
	}

	private void MKDEOMGBCFE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = OCONMJMNMDG();
	}

	private void OPHEHAALJKN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = DJHPGILMNOH();
	}

	private void NMKGOAJLMDG()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private Color DDEOGGEOGEA()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void GONDLJKGLGO()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private Color FFJPAJIJALE()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color JPMNJKFDCHI()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color KCKLNDPAIEN()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.BNKLACHEGOP() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void HAKLIGJFAIF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = KEONJMBADHD();
	}

	private Color HEFCJHOBMCN()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.BNKLACHEGOP() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void DNAMDIHOOKN()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(GEJLBPLNAOF));
		}
	}

	private Color BHHKLPKBEGK()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void HMANFAEHJCA()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void DJJENHCMCBN()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(BDDHNLPBEFO));
		}
	}

	private void PNLAJCHBHPH()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void PBDNKBPBCHM()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void NPDFCPEOFPD()
	{
		KMMBGBPDEMJ();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(AIMFODMDLJD));
	}

	private Color BFHHALFLFAE()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.GBCKNDKCFFF() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color PMKDLHDNMBI()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void CHIKHGJCJNB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = OOIKCNLDLMJ();
	}

	private void OPINKHFAKLD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = FFFJOECMMMB();
	}

	private void MKGKKAJHLAO()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(DCNOPODPMIP));
		}
	}

	private Color KLGIIEGFCJN()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.GBCKNDKCFFF() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void IJPALFMAAJN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = GGJAFLGKECJ();
	}

	private void BODICIENBEH()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void EBPAMIHFCBG()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(CHDHEPPMPNF));
		}
	}

	private void IBMDFNKKPJF()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void CEOEHODJAJK()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private Color FFFJOECMMMB()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.EDIPJBOOEHD / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color CBKHEKAOOKJ()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.EDIPJBOOEHD / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void OAEJGGFFCBO()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void IMOMHCNPCEC()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HJONPCBENJH));
		}
	}

	private void KJJAGKNOFIG()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(DCNOPODPMIP));
		}
	}

	private void BJOOCKCBPLJ()
	{
		MCDDMCJLFLE();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(MCDDMCJLFLE));
	}

	private void BDDHNLPBEFO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		spriteRenderer.color = JPMNJKFDCHI();
	}

	private void BONEKIAPEIK()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(CHDHEPPMPNF));
		}
	}

	private Color KEONJMBADHD()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return tilemapColor.Evaluate(WorldTime.BNKLACHEGOP() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void ABJIPFAEENG()
	{
		CHIKHGJCJNB();
		WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(DCNOPODPMIP));
	}

	private void MAGILKJCCJE()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(CHDHEPPMPNF));
		}
	}
}
