using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LocalisationSystemUI : MonoBehaviour
{
	private static LocalisationSystemUI IADEMLIIDPC;

	public Image currentFlag;

	public TextMeshProUGUI currentText;

	[SerializeField]
	private GameObject allFlags;

	private bool EHOFFFMFILA;

	public bool BOAPMIGIPPH
	{
		get
		{
			return EHOFFFMFILA;
		}
		set
		{
			EHOFFFMFILA = value;
			EKEHFPKGDIK();
		}
	}

	public static LocalisationSystemUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
			}
			return IADEMLIIDPC;
		}
	}

	[SpecialName]
	public static LocalisationSystemUI OPILDPFDFKJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	public void LPLCDAPLJMF(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(!MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(true);
				return;
			}
			((Component)currentText).gameObject.SetActive(false);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	[SpecialName]
	public bool INAHCJBDMHM()
	{
		return EHOFFFMFILA;
	}

	[SpecialName]
	public static LocalisationSystemUI EAGMIHGJKNB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public bool INADDPAEJCF()
	{
		return EHOFFFMFILA;
	}

	[SpecialName]
	public static LocalisationSystemUI OJJDNLEFNPJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	private void LCELGMABLOC()
	{
		if (EHOFFFMFILA)
		{
			EEPKAMCIJPF(MJHBHDAEDLF: true);
			UISelectionManager.EAJJMLJKOPH(1).MGIFADFILOI(((Component)allFlags.transform.GetChild(1)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			NDBIOBNEHBI(MJHBHDAEDLF: true);
			UISelectionManager.HELHJMDEDNL(1).MFCNGGMNBHB(null);
		}
	}

	private void OONONNJFEFL()
	{
		if (EHOFFFMFILA && PlayerInputs.POLDHCKJINN(1))
		{
			if ((Object)(object)UISelectionManager.GNCPLNHMFHN(1).KDJFBLKPFKM() == (Object)null)
			{
				UISelectionManager.HELHJMDEDNL(1).IHFNCOGFJOJ(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.DEGBDMMDIIL(1).KFAFNEJNDDL("ScrollDown"))
			{
				DFCBHGOGNFO(AODONKKHPBP: false);
			}
		}
		if (PlayerInputs.GetPlayer(0).KFAFNEJNDDL("Error launching fish, can't find player. Attempting index - 1..."))
		{
			LAKMKFOMGDD(!DCHOOGBEBLN());
		}
	}

	[SpecialName]
	public static LocalisationSystemUI DOIKFJDLKJP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	private void IPCIJFPIJCM()
	{
		if (EHOFFFMFILA)
		{
			LGEABFNFKLD(MJHBHDAEDLF: false);
			UISelectionManager.GNCPLNHMFHN(1).IHFNCOGFJOJ(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			MCNAIPDCDML(MJHBHDAEDLF: false);
			UISelectionManager.GIGBGIIAKMP(1).IHFNCOGFJOJ(null);
		}
	}

	public void MPEJELCCANA(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(!MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(true);
				return;
			}
			((Component)currentText).gameObject.SetActive(true);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	[SpecialName]
	public bool FMAFAPDMJLF()
	{
		return EHOFFFMFILA;
	}

	private void OOIHNJHMBMC()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void ONPIFHHLOFE()
	{
		if (EHOFFFMFILA)
		{
			FNHGEFMGOOH(MJHBHDAEDLF: true);
			UISelectionManager.EAJJMLJKOPH(1).GPCLGOHKMCK(((Component)allFlags.transform.GetChild(1)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			LGEABFNFKLD(MJHBHDAEDLF: false);
			UISelectionManager.GNCPLNHMFHN(1).HPJBFMEHFKF(null);
		}
	}

	[SpecialName]
	public bool DCHOOGBEBLN()
	{
		return EHOFFFMFILA;
	}

	private void Start()
	{
		ToggleAllFlags(MJHBHDAEDLF: false);
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void GCHMNMKCOFG()
	{
		if (EHOFFFMFILA && PlayerInputs.POLDHCKJINN(1))
		{
			if ((Object)(object)UISelectionManager.GNCPLNHMFHN(1).MGOEJJIMAIP() == (Object)null)
			{
				UISelectionManager.EAJJMLJKOPH(1).NCGCKHGOJCM(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.GetPlayer(0).GetButtonUp("talent_name_112"))
			{
				BCKPGAEAPKB(AODONKKHPBP: true);
			}
		}
		if (PlayerInputs.GetPlayer(1).LKOGGHNGBKD("Partida comprimida. Tiempo: "))
		{
			OFPFOOJNGGD(GFMBKAPPFAC());
		}
	}

	[SpecialName]
	public void CMPHKEFGNEE(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		NEALDCNGGML();
	}

	private void AAOMCHHNKKM()
	{
		if (EHOFFFMFILA && PlayerInputs.EEJEOALIHFJ(0))
		{
			if ((Object)(object)UISelectionManager.EAJJMLJKOPH(0).CGCIFFOJGOK() == (Object)null)
			{
				UISelectionManager.HELHJMDEDNL(1).NMAOFEFMNNB(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.DEGBDMMDIIL(0).ALPHFOIMNIA("Direction"))
			{
				LKFIGJENHDG(AODONKKHPBP: false);
			}
		}
		if (PlayerInputs.GetPlayer(0).KFAFNEJNDDL("Missing fade image for coop mode"))
		{
			LAKMKFOMGDD(!JGCBMAIIGIK());
		}
	}

	private void HPJBLOPJIMI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void MJEEFOIOHOL()
	{
		if (EHOFFFMFILA)
		{
			ToggleAllFlags(MJHBHDAEDLF: true);
			UISelectionManager.GNCPLNHMFHN(0).HPJBFMEHFKF(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			JBHEIMCIFLN(MJHBHDAEDLF: true);
			UISelectionManager.HELHJMDEDNL(0).HPJBFMEHFKF(null);
		}
	}

	private void CGLIGKKCKCG()
	{
		GCOEPHFKHFK(MJHBHDAEDLF: true);
	}

	private void EBNJADODONG()
	{
		if (EHOFFFMFILA && PlayerInputs.ODGALPDEIFG(1))
		{
			if ((Object)(object)UISelectionManager.GNCPLNHMFHN(0).KBFCCPBHDMP() == (Object)null)
			{
				UISelectionManager.GNCPLNHMFHN(0).CMBBFEABMBE(((Component)allFlags.transform.GetChild(1)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.GetPlayer(0).KFAFNEJNDDL(""))
			{
				HMMKHCLIGIK(AODONKKHPBP: false);
			}
		}
		if (PlayerInputs.GetPlayer(0).GetButtonUp("Rotate"))
		{
			HCHECIIKHBM(!INAHCJBDMHM());
		}
	}

	private void CEOEHODJAJK()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public bool NEPGACEPMHA()
	{
		return EHOFFFMFILA;
	}

	private void AGLMGDNBHBF()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public bool KACJNDKGECI()
	{
		return EHOFFFMFILA;
	}

	private void NCIBKMLIIAJ()
	{
		GLOPCIHBCLE(MJHBHDAEDLF: true);
	}

	public void GLOPCIHBCLE(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(!MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(false);
				return;
			}
			((Component)currentText).gameObject.SetActive(false);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	[SpecialName]
	public void DFCBHGOGNFO(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		KMEPPFNNHHK();
	}

	[SpecialName]
	public static LocalisationSystemUI DEGPIHEEFHJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	private void PJLKGOACDEN()
	{
		if (EHOFFFMFILA && PlayerInputs.ODGALPDEIFG(0))
		{
			if ((Object)(object)UISelectionManager.EAJJMLJKOPH(1).MGOEJJIMAIP() == (Object)null)
			{
				UISelectionManager.GNCPLNHMFHN(1).MGIFADFILOI(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.DEGBDMMDIIL(0).ALPHFOIMNIA("NinjaChallengeEvent/Win 3"))
			{
				OFPFOOJNGGD(AODONKKHPBP: true);
			}
		}
		if (PlayerInputs.DEGBDMMDIIL(1).LKOGGHNGBKD("ReceiveInfoCrops"))
		{
			MLGDELBJJLH(!ENFMHLOKPCI());
		}
	}

	public void EEPKAMCIJPF(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(false);
				return;
			}
			((Component)currentText).gameObject.SetActive(true);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	[SpecialName]
	public static LocalisationSystemUI NJNFHEPLEHL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	public void PDHOFAJBGGN(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(!MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(false);
				return;
			}
			((Component)currentText).gameObject.SetActive(false);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	public void NLCJLEOCOAA(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(true);
				return;
			}
			((Component)currentText).gameObject.SetActive(true);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	private void HCCJBKKGCLJ()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void NKDFMFFDGKC()
	{
		BJLBOJCHLAN(MJHBHDAEDLF: true);
	}

	[SpecialName]
	public static LocalisationSystemUI LFPEPJBNCBF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public void EBPIBOICIGJ(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		FLOPAMMPFNP();
	}

	public void EAAEGCGNHKP(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(!MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(false);
				return;
			}
			((Component)currentText).gameObject.SetActive(true);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	private void NLNOFEBEBDE()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void AAEAAEBBFKG()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void GHPFCKGMLDA()
	{
		FNHGEFMGOOH(MJHBHDAEDLF: true);
	}

	public void ToggleAllFlags(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(!MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(false);
				return;
			}
			((Component)currentText).gameObject.SetActive(true);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	private void GNMMELIJKML()
	{
		EEPKAMCIJPF(MJHBHDAEDLF: true);
	}

	private void ODKGLIDMCNP()
	{
		JBHEIMCIFLN(MJHBHDAEDLF: false);
	}

	private void IOMICCBCFDN()
	{
		if (EHOFFFMFILA)
		{
			MPEJELCCANA(MJHBHDAEDLF: true);
			UISelectionManager.HELHJMDEDNL(1).PICNNIMLFFL(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			FNHGEFMGOOH(MJHBHDAEDLF: true);
			UISelectionManager.BPDFMAEOGGC(1).CMBBFEABMBE(null);
		}
	}

	private void LCJPPBAIGJL()
	{
		if (EHOFFFMFILA)
		{
			JBHEIMCIFLN(MJHBHDAEDLF: true);
			UISelectionManager.GIGBGIIAKMP(0).GPCLGOHKMCK(((Component)allFlags.transform.GetChild(1)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			CAJDDGEMIIP(MJHBHDAEDLF: true);
			UISelectionManager.EAJJMLJKOPH(1).BNBPMIKMDDP(null);
		}
	}

	public void NMEDCFHCHEL(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(true);
				return;
			}
			((Component)currentText).gameObject.SetActive(true);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	[SpecialName]
	public void DOJGPGGCKCA(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		EKEHFPKGDIK();
	}

	[SpecialName]
	public static LocalisationSystemUI JHMAMLIPBNN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	public void LMHLNCMGCBJ(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(true);
				return;
			}
			((Component)currentText).gameObject.SetActive(true);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	private void IHICKHAABJH()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void LPNBCBIBNNI()
	{
		JBHEIMCIFLN(MJHBHDAEDLF: false);
	}

	public void GBHNJCDNAOJ(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(false);
				return;
			}
			((Component)currentText).gameObject.SetActive(true);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	[SpecialName]
	public void MLGDELBJJLH(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		KAIONFPCKAL();
	}

	public void FNHGEFMGOOH(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(!MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(true);
				return;
			}
			((Component)currentText).gameObject.SetActive(false);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	private void FDHMOEDMPNG()
	{
		if (EHOFFFMFILA && PlayerInputs.EEJEOALIHFJ(0))
		{
			if ((Object)(object)UISelectionManager.HELHJMDEDNL(1).CGCIFFOJGOK() == (Object)null)
			{
				UISelectionManager.GetPlayer(0).HPJBFMEHFKF(((Component)allFlags.transform.GetChild(1)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.GetPlayer(0).GetButtonUp("Quests"))
			{
				LAKMKFOMGDD(AODONKKHPBP: false);
			}
		}
		if (PlayerInputs.GetPlayer(1).ALPHFOIMNIA("Waiting"))
		{
			DFCBHGOGNFO(GFMBKAPPFAC());
		}
	}

	[SpecialName]
	public static LocalisationSystemUI OAPOJCODNCO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	private void JLPLLHKJEMH()
	{
		if (EHOFFFMFILA && PlayerInputs.FJLAMCHKCOI(0))
		{
			if ((Object)(object)UISelectionManager.GIGBGIIAKMP(0).KBFCCPBHDMP() == (Object)null)
			{
				UISelectionManager.GetPlayer(0).Select(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.GetPlayer(1).GetButtonUp("City/PetShop/Nessy/PerritosAbandonados3"))
			{
				BCKPGAEAPKB(AODONKKHPBP: false);
			}
		}
		if (PlayerInputs.GetPlayer(0).LKOGGHNGBKD("talent_name_109"))
		{
			CMPHKEFGNEE(!LOJOICDNJDF());
		}
	}

	private void FHEGBNMJADG()
	{
		KKCIALNAGCA(MJHBHDAEDLF: false);
	}

	private void GOJKOBEEMNA()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void LDLBMMMLEDJ()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void AMBJKHAFAFF()
	{
		if (EHOFFFMFILA && PlayerInputs.IsGamepadActive(1))
		{
			if ((Object)(object)UISelectionManager.EAJJMLJKOPH(0).FOKMCIDMIKF() == (Object)null)
			{
				UISelectionManager.EAJJMLJKOPH(1).Select(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.DEGBDMMDIIL(0).GetButtonUp("Player Bed with actor number {0} is already in the dictionary."))
			{
				CMPHKEFGNEE(AODONKKHPBP: true);
			}
		}
		if (PlayerInputs.GetPlayer(0).GetButtonUp("MainProgress"))
		{
			DHHJHFAANEN(!FMAFAPDMJLF());
		}
	}

	private void KEOFDFJMDAM()
	{
		if (EHOFFFMFILA && PlayerInputs.POLDHCKJINN(1))
		{
			if ((Object)(object)UISelectionManager.HELHJMDEDNL(0).HGNKFFMDOOL == (Object)null)
			{
				UISelectionManager.HELHJMDEDNL(1).CMBBFEABMBE(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.DEGBDMMDIIL(1).LKOGGHNGBKD("Name..."))
			{
				BCKPGAEAPKB(AODONKKHPBP: false);
			}
		}
		if (PlayerInputs.DEGBDMMDIIL(0).LKOGGHNGBKD("LE_22"))
		{
			HMMKHCLIGIK(INAHCJBDMHM());
		}
	}

	private void Update()
	{
		if (EHOFFFMFILA && PlayerInputs.IsGamepadActive(1))
		{
			if ((Object)(object)UISelectionManager.GetPlayer(1).HGNKFFMDOOL == (Object)null)
			{
				UISelectionManager.GetPlayer(1).Select(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.GetPlayer(1).GetButtonUp("UIBack"))
			{
				BOAPMIGIPPH = false;
			}
		}
		if (PlayerInputs.GetPlayer(1).GetButtonUp("UISelectGamepad"))
		{
			BOAPMIGIPPH = !BOAPMIGIPPH;
		}
	}

	private void MLLADNLMIMP()
	{
		MCNAIPDCDML(MJHBHDAEDLF: false);
	}

	[SpecialName]
	public static LocalisationSystemUI IBEGPMLJIOJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public bool ENFMHLOKPCI()
	{
		return EHOFFFMFILA;
	}

	[SpecialName]
	public bool JGCBMAIIGIK()
	{
		return EHOFFFMFILA;
	}

	private void FALNOOOKLGA()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public static LocalisationSystemUI LHKFIDJFPDB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static LocalisationSystemUI HFHPMKJGMPA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	private void NFCHGJHGECO()
	{
		if (EHOFFFMFILA)
		{
			NDBIOBNEHBI(MJHBHDAEDLF: true);
			UISelectionManager.GetPlayer(0).MFCNGGMNBHB(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			GBHNJCDNAOJ(MJHBHDAEDLF: true);
			UISelectionManager.HELHJMDEDNL(1).MGIFADFILOI(null);
		}
	}

	[SpecialName]
	public static LocalisationSystemUI ABHIDHPMLLD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	public void GCOEPHFKHFK(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(true);
				return;
			}
			((Component)currentText).gameObject.SetActive(false);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	[SpecialName]
	public void LAKMKFOMGDD(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		KMEPPFNNHHK();
	}

	private void BGBFJPJLPMF()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void KMEPPFNNHHK()
	{
		if (EHOFFFMFILA)
		{
			JBHEIMCIFLN(MJHBHDAEDLF: false);
			UISelectionManager.HELHJMDEDNL(0).NCGCKHGOJCM(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			FNHGEFMGOOH(MJHBHDAEDLF: true);
			UISelectionManager.HELHJMDEDNL(0).GPCLGOHKMCK(null);
		}
	}

	private void NBOLEBJOOCB()
	{
		if (EHOFFFMFILA)
		{
			MPEJELCCANA(MJHBHDAEDLF: false);
			UISelectionManager.BPDFMAEOGGC(1).BNBPMIKMDDP(((Component)allFlags.transform.GetChild(1)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			PDHOFAJBGGN(MJHBHDAEDLF: false);
			UISelectionManager.GIGBGIIAKMP(0).PICNNIMLFFL(null);
		}
	}

	private void GOJFGHKOFMF()
	{
		if (EHOFFFMFILA && PlayerInputs.POLDHCKJINN(0))
		{
			if ((Object)(object)UISelectionManager.GNCPLNHMFHN(0).BEOANCLEPOO() == (Object)null)
			{
				UISelectionManager.EAJJMLJKOPH(1).NCGCKHGOJCM(((Component)allFlags.transform.GetChild(1)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.DEGBDMMDIIL(1).LKOGGHNGBKD("Mussel parent not found!!. Parent unique ID: "))
			{
				HMMKHCLIGIK(AODONKKHPBP: true);
			}
		}
		if (PlayerInputs.GetPlayer(0).ALPHFOIMNIA("No bed assigned to player num: {0}"))
		{
			OIGDAGOEEOF(LOJOICDNJDF());
		}
	}

	[SpecialName]
	public bool LOJOICDNJDF()
	{
		return EHOFFFMFILA;
	}

	[SpecialName]
	public static LocalisationSystemUI BDAGIEIJOOG()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public bool GFMBKAPPFAC()
	{
		return EHOFFFMFILA;
	}

	private void AGGJDFHNPPI()
	{
		if (EHOFFFMFILA && PlayerInputs.EEJEOALIHFJ(0))
		{
			if ((Object)(object)UISelectionManager.GNCPLNHMFHN(1).BCHJGDHJHJK() == (Object)null)
			{
				UISelectionManager.GNCPLNHMFHN(0).BNBPMIKMDDP(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.GetPlayer(0).ALPHFOIMNIA("ReceiveEnable"))
			{
				OFPFOOJNGGD(AODONKKHPBP: true);
			}
		}
		if (PlayerInputs.GetPlayer(0).GetButtonUp("Profit"))
		{
			MLGDELBJJLH(INAHCJBDMHM());
		}
	}

	private void DADPOICMNPI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void EOOGMGKJAHC()
	{
		if (EHOFFFMFILA)
		{
			EAAEGCGNHKP(MJHBHDAEDLF: false);
			UISelectionManager.GIGBGIIAKMP(0).HPJBFMEHFKF(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			PDHOFAJBGGN(MJHBHDAEDLF: false);
			UISelectionManager.BPDFMAEOGGC(1).BNFLJFFKMMN(null);
		}
	}

	public void JBHEIMCIFLN(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(!MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(true);
				return;
			}
			((Component)currentText).gameObject.SetActive(false);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	public void KKCIALNAGCA(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(true);
				return;
			}
			((Component)currentText).gameObject.SetActive(false);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	private void KEJCJCFPKHE()
	{
		if (EHOFFFMFILA)
		{
			BJLBOJCHLAN(MJHBHDAEDLF: true);
			UISelectionManager.GIGBGIIAKMP(1).HPJBFMEHFKF(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			GLOPCIHBCLE(MJHBHDAEDLF: true);
			UISelectionManager.GNCPLNHMFHN(0).MFCNGGMNBHB(null);
		}
	}

	private void PNJJEDEFAGO()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void NEALDCNGGML()
	{
		if (EHOFFFMFILA)
		{
			LGEABFNFKLD(MJHBHDAEDLF: true);
			UISelectionManager.EAJJMLJKOPH(1).MGIFADFILOI(((Component)allFlags.transform.GetChild(1)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			JBHEIMCIFLN(MJHBHDAEDLF: true);
			UISelectionManager.GetPlayer(1).BNFLJFFKMMN(null);
		}
	}

	private void GAPJBNMCDDK()
	{
		if (EHOFFFMFILA && PlayerInputs.IsGamepadActive(0))
		{
			if ((Object)(object)UISelectionManager.GIGBGIIAKMP(0).PBGKEEENPME() == (Object)null)
			{
				UISelectionManager.BPDFMAEOGGC(0).MFCNGGMNBHB(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.DEGBDMMDIIL(0).GetButtonUp("OK"))
			{
				HCHECIIKHBM(AODONKKHPBP: false);
			}
		}
		if (PlayerInputs.DEGBDMMDIIL(1).GetButtonUp("Drag item:"))
		{
			OFPFOOJNGGD(DCHOOGBEBLN());
		}
	}

	public void NDBIOBNEHBI(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(!MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(true);
				return;
			}
			((Component)currentText).gameObject.SetActive(true);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	[SpecialName]
	public void LKFIGJENHDG(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		FLOPAMMPFNP();
	}

	private void LFNENELHOGJ()
	{
		MCNAIPDCDML(MJHBHDAEDLF: false);
	}

	public void LGEABFNFKLD(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(false);
				return;
			}
			((Component)currentText).gameObject.SetActive(true);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	[SpecialName]
	public void OOLADLKNICL(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		NEALDCNGGML();
	}

	private void EBFLGINAKOL()
	{
		if (EHOFFFMFILA)
		{
			GLOPCIHBCLE(MJHBHDAEDLF: false);
			UISelectionManager.GIGBGIIAKMP(1).IHFNCOGFJOJ(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			NMEDCFHCHEL(MJHBHDAEDLF: false);
			UISelectionManager.GetPlayer(0).MGIFADFILOI(null);
		}
	}

	[SpecialName]
	public void DHHJHFAANEN(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		OGNMFMBNHJF();
	}

	private void OGNMFMBNHJF()
	{
		if (EHOFFFMFILA)
		{
			LPLCDAPLJMF(MJHBHDAEDLF: false);
			UISelectionManager.GetPlayer(1).HPJBFMEHFKF(((Component)allFlags.transform.GetChild(1)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			MCNAIPDCDML(MJHBHDAEDLF: false);
			UISelectionManager.GetPlayer(0).NMAOFEFMNNB(null);
		}
	}

	private void KGIKOECKEHI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void GGOPCJOAOMC()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void EKEHFPKGDIK()
	{
		if (EHOFFFMFILA)
		{
			ToggleAllFlags(MJHBHDAEDLF: true);
			UISelectionManager.GetPlayer(1).Select(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			ToggleAllFlags(MJHBHDAEDLF: false);
			UISelectionManager.GetPlayer(1).Select((Selectable)null);
		}
	}

	private void PPJDJCPLHNN()
	{
		if (EHOFFFMFILA)
		{
			PDHOFAJBGGN(MJHBHDAEDLF: true);
			UISelectionManager.GetPlayer(1).HPJBFMEHFKF(((Component)allFlags.transform.GetChild(1)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			NDBIOBNEHBI(MJHBHDAEDLF: false);
			UISelectionManager.HELHJMDEDNL(1).BNBPMIKMDDP(null);
		}
	}

	[SpecialName]
	public bool IJBCJNOLCGK()
	{
		return EHOFFFMFILA;
	}

	private void DCMNFJOPCPF()
	{
		LPLCDAPLJMF(MJHBHDAEDLF: false);
	}

	[SpecialName]
	public void NLKBBAJBKEM(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		IOMICCBCFDN();
	}

	[SpecialName]
	public void AGILFCIMAIE(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		LCELGMABLOC();
	}

	public void CAJDDGEMIIP(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(!MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(false);
				return;
			}
			((Component)currentText).gameObject.SetActive(true);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	private void PCKOHAIPHFI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void OMBHDODDHNO()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void BJLBOJCHLAN(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(!MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(false);
				return;
			}
			((Component)currentText).gameObject.SetActive(false);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	private void KAIONFPCKAL()
	{
		if (EHOFFFMFILA)
		{
			JBHEIMCIFLN(MJHBHDAEDLF: true);
			UISelectionManager.EAJJMLJKOPH(1).IHFNCOGFJOJ(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			FNHGEFMGOOH(MJHBHDAEDLF: false);
			UISelectionManager.HELHJMDEDNL(0).GPCLGOHKMCK(null);
		}
	}

	private void JPHFCJIBBMI()
	{
		if (EHOFFFMFILA && PlayerInputs.EEJEOALIHFJ(1))
		{
			if ((Object)(object)UISelectionManager.GNCPLNHMFHN(1).CGCIFFOJGOK() == (Object)null)
			{
				UISelectionManager.GNCPLNHMFHN(0).GPCLGOHKMCK(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
			}
			if (PlayerInputs.GetPlayer(0).ALPHFOIMNIA(" "))
			{
				DHHJHFAANEN(AODONKKHPBP: false);
			}
		}
		if (PlayerInputs.DEGBDMMDIIL(0).KFAFNEJNDDL("<sprite name=\"woodPlanksIcon\"><color=#8E1818>"))
		{
			OIGDAGOEEOF(!BJJLFJGBMHG());
		}
	}

	public void MCNAIPDCDML(bool MJHBHDAEDLF)
	{
		allFlags.SetActive(MJHBHDAEDLF);
		((Component)currentFlag).gameObject.SetActive(!MJHBHDAEDLF);
		if (!MJHBHDAEDLF)
		{
			currentFlag.sprite = LocalisationSystem.CMIBBDJLMBM.flag;
			if (string.IsNullOrEmpty(LocalisationSystem.CMIBBDJLMBM.text))
			{
				((Component)currentText).gameObject.SetActive(false);
				return;
			}
			((Component)currentText).gameObject.SetActive(true);
			((TMP_Text)currentText).text = LocalisationSystem.CMIBBDJLMBM.text;
		}
	}

	[SpecialName]
	public bool EPHOHBHEDOM()
	{
		return EHOFFFMFILA;
	}

	[SpecialName]
	public bool BJJLFJGBMHG()
	{
		return EHOFFFMFILA;
	}

	private void AMNCIAEMBFO()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public static LocalisationSystemUI DICHPHEOINO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public void OIGDAGOEEOF(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		PPJDJCPLHNN();
	}

	private void OIBDBLCLACB()
	{
		MCNAIPDCDML(MJHBHDAEDLF: true);
	}

	[SpecialName]
	public void HMMKHCLIGIK(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		MJEEFOIOHOL();
	}

	[SpecialName]
	public void OFPFOOJNGGD(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		MJEEFOIOHOL();
	}

	private void FLOPAMMPFNP()
	{
		if (EHOFFFMFILA)
		{
			NMEDCFHCHEL(MJHBHDAEDLF: false);
			UISelectionManager.HELHJMDEDNL(1).MFCNGGMNBHB(((Component)allFlags.transform.GetChild(0)).gameObject.GetComponent<Selectable>());
		}
		else
		{
			NLCJLEOCOAA(MJHBHDAEDLF: false);
			UISelectionManager.GIGBGIIAKMP(0).MGIFADFILOI(null);
		}
	}

	private void EBNKNEIDDDI()
	{
		LGEABFNFKLD(MJHBHDAEDLF: false);
	}

	[SpecialName]
	public void HCHECIIKHBM(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		EKEHFPKGDIK();
	}

	[SpecialName]
	public static LocalisationSystemUI HLMGBEGEAPC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystemUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public void BCKPGAEAPKB(bool AODONKKHPBP)
	{
		EHOFFFMFILA = AODONKKHPBP;
		EKEHFPKGDIK();
	}
}
