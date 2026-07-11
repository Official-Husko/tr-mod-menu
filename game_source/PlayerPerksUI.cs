using UnityEngine;

public class PlayerPerksUI : MainPanelWindow
{
	public TabUI[] categoriesTabUI;

	[SerializeField]
	private Sprite spriteFocusCategories;

	[SerializeField]
	private Sprite spriteNotFocusCategories;

	private int GBFGPENGELF;

	private float CMGDCLIIONE;

	public static PlayerPerksUI[] instances = new PlayerPerksUI[3];

	public void FOMCOHIJFAA(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].ShowTab(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].BMANHBFCGNE(spriteNotFocusCategories);
			}
		}
	}

	public static PlayerPerksUI DPBGKDNKDGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PlayerPerksUI IMLMJAPMBJA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PlayerPerksUI BBDNJAKIBFN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PlayerPerksUI PHDBJGOEKHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void HFAACJPODHA(int KHEICLKLPDE)
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].KPAAJFPAEAH(base.JIIGOACEIKL, spriteFocusCategories);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].NEFLMNAEEMD(spriteNotFocusCategories);
			}
		}
	}

	public static PlayerPerksUI FHOGLBPBGMI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void HNBDOGMBCCA(int KHEICLKLPDE)
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].ShowTab(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].OHOCOHIKHPA(spriteNotFocusCategories);
			}
		}
	}

	public static PlayerPerksUI NDPAJCGHGOB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void PCDAPEDKDKM(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].PMAIDBCLDFO(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].EOICNOKEMFN(spriteNotFocusCategories);
			}
		}
	}

	public void ECMHFFJBPKE(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].KHJLGGKPHLH(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].DKFODKJNNJN(spriteNotFocusCategories);
			}
		}
	}

	public void IDEKHMAFIHF(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].FKNDNHJBLHB(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].JNFIBAIJBEN(spriteNotFocusCategories);
			}
		}
	}

	public static PlayerPerksUI FBKOKJCKICN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
		}
	}

	public void JGGMPBBOMOL(int KHEICLKLPDE)
	{
		for (int i = 1; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].OEIKFIHLDHO(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].NNIBKIDJGGG(spriteNotFocusCategories);
			}
		}
	}

	public static PlayerPerksUI LKJNAHIPOLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PlayerPerksUI EOPIEMLAPFN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JKMPAGPNOFL(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].ShowTab(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].IIFCKDAMIPI(spriteNotFocusCategories);
			}
		}
	}

	public void MJFLELCHHCB(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].FKNDNHJBLHB(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].HDJHEGPJKDM(spriteNotFocusCategories);
			}
		}
	}

	public void BEKAIGFKJCC(int KHEICLKLPDE)
	{
		for (int i = 1; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].ADNJKEAPMIC(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].NNIBKIDJGGG(spriteNotFocusCategories);
			}
		}
	}

	public static PlayerPerksUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PlayerPerksUI NIGDBMAOAEN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PlayerPerksUI AEJKCONFPHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PlayerPerksUI CJMILOMGFJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PlayerPerksUI OCCEHEMCGJF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void NILIECLOHLO(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].LDFIMGKJGHA(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].HDJHEGPJKDM(spriteNotFocusCategories);
			}
		}
	}

	public static PlayerPerksUI NALKHGMLALJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PlayerPerksUI LAMFGLIGLOP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PlayerPerksUI HJHCKIAKCKD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void BBJKMJKJJKM(int KHEICLKLPDE)
	{
		for (int i = 1; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].AEFOGEIIFLK(base.JIIGOACEIKL, spriteFocusCategories);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].BJIHNCGPNFL(spriteNotFocusCategories);
			}
		}
	}

	public void PIOPDGLELGJ(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].AEFOGEIIFLK(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].EJLCLMCOPML(spriteNotFocusCategories);
			}
		}
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			base.CloseUI();
			ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public static PlayerPerksUI FHPEHDDFOIB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void NAKKBHCIEFC(int KHEICLKLPDE)
	{
		for (int i = 1; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].FKNDNHJBLHB(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].BMANHBFCGNE(spriteNotFocusCategories);
			}
		}
	}

	public static PlayerPerksUI AKMJEPMHFMO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PlayerPerksUI MDFIDKHOPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void DCKKCNIGAHP(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].FKNDNHJBLHB(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].DFHFPOIPCLK(spriteNotFocusCategories);
			}
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		FocusTalentFilter(0);
	}

	public static PlayerPerksUI EPLOMIBMKFC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected override void Update()
	{
		base.Update();
		if (LKOJBFMGMAE && PlayerInputs.InputsEnabled(base.JIIGOACEIKL))
		{
			if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UINextCategory"))
			{
				FocusTalentFilter(Utils.NMLNAGFLNMC(GBFGPENGELF + 1, categoriesTabUI.Length));
			}
			else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousCategory"))
			{
				FocusTalentFilter(Utils.NMLNAGFLNMC(GBFGPENGELF - 1, categoriesTabUI.Length));
			}
		}
	}

	public static PlayerPerksUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void AMGHKDEHBGM(int KHEICLKLPDE)
	{
		for (int i = 1; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].AEFOGEIIFLK(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].PICAPHOJNEK(spriteNotFocusCategories);
			}
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public void FJOCEHJLNDH(int KHEICLKLPDE)
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].KPAAJFPAEAH(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].LEJGHAGGOEH(spriteNotFocusCategories);
			}
		}
	}

	public static PlayerPerksUI FFOABBDFMNE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void PFHFBAPFPDK(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].LDFIMGKJGHA(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].HideTab(spriteNotFocusCategories);
			}
		}
	}

	public static PlayerPerksUI NJOFJHCKGAL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PlayerPerksUI NIDHCIHFOHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void LJCGFKDIBHN(int KHEICLKLPDE)
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].BIGONMIJCMH(base.JIIGOACEIKL, spriteFocusCategories);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].DFHFPOIPCLK(spriteNotFocusCategories);
			}
		}
	}

	public static PlayerPerksUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PlayerPerksUI CGFJPHEFFLO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FocusTalentFilter(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].ShowTab(base.JIIGOACEIKL, spriteFocusCategories);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].HideTab(spriteNotFocusCategories);
			}
		}
	}

	public void NIJOAJIGCAM(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].FKNDNHJBLHB(base.JIIGOACEIKL, spriteFocusCategories);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].DFHFPOIPCLK(spriteNotFocusCategories);
			}
		}
	}

	public override void CloseUIRemainActive()
	{
		if (IsOpen())
		{
			base.CloseUIRemainActive();
			ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public void MKENIHNMHIO(int KHEICLKLPDE)
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].PMAIDBCLDFO(base.JIIGOACEIKL, spriteFocusCategories);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].NNKJNKJMDKA(spriteNotFocusCategories);
			}
		}
	}

	public static PlayerPerksUI COIEMAJLHAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JBFFANINEOE(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].BIGONMIJCMH(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].HLJLOBHLMNM(spriteNotFocusCategories);
			}
		}
	}
}
