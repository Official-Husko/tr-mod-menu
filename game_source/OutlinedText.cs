using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class OutlinedText : MonoBehaviour
{
	[SerializeField]
	private TextMesh outlineText;

	[SerializeField]
	private TextMesh backgroundText;

	[SerializeField]
	private TextMeshPro tmProText;

	[SerializeField]
	private string text;

	private Color MIKONDHOMHM;

	public string JJLCPIHPAOL
	{
		get
		{
			return text;
		}
		set
		{
			DNEOBLANBAI(value);
		}
	}

	public Color KKEOCDDJPKH
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return MIKONDHOMHM;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			MIKONDHOMHM = value;
			backgroundText.color = MIKONDHOMHM;
		}
	}

	public void ODJANIEJOIL()
	{
		IPPFBLHGAGK(text);
	}

	private void HMBCPHOOJHD(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.HEKFJEKFMNO() != (Object)null && LocalisationSystem.HEKFJEKFMNO().useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	private void Awake()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	private void AJGKMFOJLBJ()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	private void EKDNFMBLMJP(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.HEKFJEKFMNO() != (Object)null && LocalisationSystem.GGFJGHHHEJC.useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	public void BNEPGEFCOBF()
	{
		DFHCKGJMILD(text);
	}

	public void KIDMEBCAHBP()
	{
		DNEOBLANBAI(text);
	}

	private void EMJKKALMGLK()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	[SpecialName]
	public void CEIOIFDFGIK(string AODONKKHPBP)
	{
		OLKGNCMDFFM(AODONKKHPBP);
	}

	public void MLBGBKHDCDA()
	{
		OLKGNCMDFFM(text);
	}

	[SpecialName]
	public string HNBCKGMLBEC()
	{
		return text;
	}

	[SpecialName]
	public void OFIIEJGKKAD(string AODONKKHPBP)
	{
		FPONGDFAKIG(AODONKKHPBP);
	}

	private void OCJOAHDNDIJ()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	[SpecialName]
	public void DBHIBPJNAAP(string AODONKKHPBP)
	{
		DNGMLGKCPCH(AODONKKHPBP);
	}

	public void NIHFGDJFBGP()
	{
		IECMBNIPKPC(text);
	}

	[SpecialName]
	public string KEJHBACPNPA()
	{
		return text;
	}

	[SpecialName]
	public void BAOBOCMANMP(string AODONKKHPBP)
	{
		GDHCHJAMJOC(AODONKKHPBP);
	}

	[SpecialName]
	public Color PNHIFOKFFFB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	private void COKBJNMAMDI()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	private void MMNBJPDJHGK()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	[SpecialName]
	public void HHICNKEDEMG(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	[SpecialName]
	public void PEACLDOGPLA(string AODONKKHPBP)
	{
		OLCJCJKMGPI(AODONKKHPBP);
	}

	[SpecialName]
	public void DHEAEPLDCHB(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	private void FELJAKBBFJD()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	[SpecialName]
	public string MOKPPDDBDBB()
	{
		return text;
	}

	[SpecialName]
	public string OBJMHDBEECF()
	{
		return text;
	}

	[SpecialName]
	public void JCGDPFOPPDJ(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	private void IPPFBLHGAGK(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.HEKFJEKFMNO() != (Object)null && LocalisationSystem.GGFJGHHHEJC.useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	[SpecialName]
	public string HEMOGMAMMKD()
	{
		return text;
	}

	private void HJJNOKKALAP(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.GGFJGHHHEJC != (Object)null && LocalisationSystem.HEKFJEKFMNO().useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	[SpecialName]
	public Color ADOOOBCLGEK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	private void FBLAMCDFMPE()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	[SpecialName]
	public void BCMCBFBMDPN(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	[SpecialName]
	public Color OPCFDEDLPFN()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	[SpecialName]
	public void NGDDBJLDCII(string AODONKKHPBP)
	{
		GDHCHJAMJOC(AODONKKHPBP);
	}

	[SpecialName]
	public Color JEMOAKCGCFI()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	[SpecialName]
	public void PFEAAHAJEHL(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	private void KHJALBJMLHP()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	private void KKNHADAMLFP()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	private void DKDLOBOLNFH()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	private void DNEOBLANBAI(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.GGFJGHHHEJC != (Object)null && LocalisationSystem.GGFJGHHHEJC.useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	[SpecialName]
	public void LLLJFNJBJOC(string AODONKKHPBP)
	{
		NPNHGGCPMDC(AODONKKHPBP);
	}

	public void BEPNFJNMLOJ()
	{
		PDLDEFGJGFJ(text);
	}

	private void HFPDNCBLNDE()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	public void MODGIKAEGNB()
	{
		GDHCHJAMJOC(text);
	}

	[SpecialName]
	public string JJLFCKHBFIL()
	{
		return text;
	}

	[SpecialName]
	public Color OPBCPBLAGHM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	private void LNPDALMANFB()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	[SpecialName]
	public Color HGHKDAJHCIM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	[SpecialName]
	public Color PENNHAIEGBA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	[SpecialName]
	public string HHELCLJBJCH()
	{
		return text;
	}

	[SpecialName]
	public Color GPDMGNKPJLE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	private void PHJKJHKAABL()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	private void FCEBDLIAFPK(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.GGFJGHHHEJC != (Object)null && LocalisationSystem.GGFJGHHHEJC.useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	private void EFJFJJDGGGI()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	private void MPCFCNCMOAF()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	[SpecialName]
	public void LEJJKLIGHNM(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	[SpecialName]
	public void LAELCDMMHEI(string AODONKKHPBP)
	{
		OLLCAHNAGJC(AODONKKHPBP);
	}

	private void JPFDPIAFACG()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	[SpecialName]
	public void JBGGDPENDGG(string AODONKKHPBP)
	{
		EKDNFMBLMJP(AODONKKHPBP);
	}

	public void LHJHEBBEGMJ()
	{
		OJKELBMNGBF(text);
	}

	[SpecialName]
	public void MELIOINJGME(string AODONKKHPBP)
	{
		PDLDEFGJGFJ(AODONKKHPBP);
	}

	private void OLKGNCMDFFM(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.GGFJGHHHEJC != (Object)null && LocalisationSystem.HEKFJEKFMNO().useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	private void HPJBLOPJIMI()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	private void OGEJKOIOKAN()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	[SpecialName]
	public void APADFPFGHFD(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	[SpecialName]
	public void MAKLJPDIGIE(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	public void MDLDCKONCGC()
	{
		DNEOBLANBAI(text);
	}

	[SpecialName]
	public string IFDFFPKABGE()
	{
		return text;
	}

	[SpecialName]
	public void EJAMGJGICME(string AODONKKHPBP)
	{
		IPPFBLHGAGK(AODONKKHPBP);
	}

	[SpecialName]
	public string NDNKHCJNNEH()
	{
		return text;
	}

	[SpecialName]
	public string IAFNLBNDMPF()
	{
		return text;
	}

	[SpecialName]
	public Color BIJJAFLAEDJ()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	[SpecialName]
	public string LMILIEGBHCI()
	{
		return text;
	}

	private void FALNOOOKLGA()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	[SpecialName]
	public string NNIKMJHCABH()
	{
		return text;
	}

	[SpecialName]
	public void HOMBBFIGEFC(string AODONKKHPBP)
	{
		HJJNOKKALAP(AODONKKHPBP);
	}

	public void HMOAKJCLFLF()
	{
		OJKELBMNGBF(text);
	}

	private void OOIHNJHMBMC()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	private void GCNPJLNFNPH(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.GGFJGHHHEJC != (Object)null && LocalisationSystem.GGFJGHHHEJC.useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	private void DFHCKGJMILD(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.GGFJGHHHEJC != (Object)null && LocalisationSystem.HEKFJEKFMNO().useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	[SpecialName]
	public string EIMGEPLLCBA()
	{
		return text;
	}

	[SpecialName]
	public void DOFIDIIEIJB(string AODONKKHPBP)
	{
		DNGMLGKCPCH(AODONKKHPBP);
	}

	[SpecialName]
	public void OMGAMADCONN(string AODONKKHPBP)
	{
		IECMBNIPKPC(AODONKKHPBP);
	}

	private void NPNHGGCPMDC(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.GGFJGHHHEJC != (Object)null && LocalisationSystem.HEKFJEKFMNO().useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	private void GDHCHJAMJOC(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.HEKFJEKFMNO() != (Object)null && LocalisationSystem.HEKFJEKFMNO().useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	[SpecialName]
	public string EJLJLDCMKAC()
	{
		return text;
	}

	private void FHOCCEBKHJI()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	private void FCNKGINGJNM()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	[SpecialName]
	public void FJCIIPDDEIO(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	[SpecialName]
	public void CBMNHPOFJBG(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	[SpecialName]
	public void OMPMHEJDNIE(string AODONKKHPBP)
	{
		OLCJCJKMGPI(AODONKKHPBP);
	}

	[SpecialName]
	public void LPEHBCNEMGK(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	private void KJPECNGCOKK()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	public void IBFEAHAAKBO()
	{
		JAJFFBDPNME(text);
	}

	public void GLCKPMKMGIP()
	{
		JAJFFBDPNME(text);
	}

	[SpecialName]
	public Color LALNCENBIKC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	public void KNDEMCKCMCL()
	{
		IECMBNIPKPC(text);
	}

	[SpecialName]
	public string FINEDCIBMPD()
	{
		return text;
	}

	private void OLCJCJKMGPI(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.GGFJGHHHEJC != (Object)null && LocalisationSystem.GGFJGHHHEJC.useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	[SpecialName]
	public Color JLACDAAPCBO()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	[SpecialName]
	public void PPCPKMMKFHG(string AODONKKHPBP)
	{
		FCEBDLIAFPK(AODONKKHPBP);
	}

	[SpecialName]
	public void DGDNLJEPOAE(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	private void PDLDEFGJGFJ(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.HEKFJEKFMNO() != (Object)null && LocalisationSystem.HEKFJEKFMNO().useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	[SpecialName]
	public Color FKCFFACNKEH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	public void NJHFDODCAEG()
	{
		OLCJCJKMGPI(text);
	}

	[SpecialName]
	public void DNCFGIJBJNH(string AODONKKHPBP)
	{
		GDHCHJAMJOC(AODONKKHPBP);
	}

	[SpecialName]
	public void FNKKIPNCNGC(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	public void KFJLJJKLBJN()
	{
		OLCJCJKMGPI(text);
	}

	[SpecialName]
	public Color CCCMCHDJKMA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	[SpecialName]
	public Color IPGCJOEBIEJ()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	private void KLGCMMIKGIO()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	private void IECMBNIPKPC(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.GGFJGHHHEJC != (Object)null && LocalisationSystem.HEKFJEKFMNO().useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	[SpecialName]
	public string KGFGJLAJOOB()
	{
		return text;
	}

	[SpecialName]
	public Color IIALEMADEOD()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	private void PNJJEDEFAGO()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	[SpecialName]
	public void COEDBJPNKCM(string AODONKKHPBP)
	{
		NPNHGGCPMDC(AODONKKHPBP);
	}

	[SpecialName]
	public void NBBELAEGMCD(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	private void OLLCAHNAGJC(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.GGFJGHHHEJC != (Object)null && LocalisationSystem.GGFJGHHHEJC.useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	[SpecialName]
	public string EAMPBHCAODO()
	{
		return text;
	}

	[SpecialName]
	public Color AIILJGKFKIC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	[SpecialName]
	public void DFDIFLPMNKO(string AODONKKHPBP)
	{
		HMBCPHOOJHD(AODONKKHPBP);
	}

	[SpecialName]
	public void HIKDHMNAJCJ(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	[SpecialName]
	public Color MILBGKEDIKE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	[SpecialName]
	public Color GAKFANPMHGP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	private void FPNCANODJKE()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	[SpecialName]
	public string OBBIEMECMHH()
	{
		return text;
	}

	[SpecialName]
	public void CGKODCNNCHP(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	[SpecialName]
	public string LODLDIBHDOB()
	{
		return text;
	}

	private void JAJFFBDPNME(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.GGFJGHHHEJC != (Object)null && LocalisationSystem.GGFJGHHHEJC.useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	[SpecialName]
	public void PLOJMMKMNAC(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	[SpecialName]
	public string GKDJMHBOIKF()
	{
		return text;
	}

	[SpecialName]
	public Color AEJCCBCFMIK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MIKONDHOMHM;
	}

	[SpecialName]
	public string JBBIKIEABJG()
	{
		return text;
	}

	private void OIOLGAOPECC()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
	}

	private void MJOLEIMPOGI()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(!LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	public void IKBKNHDKNMD()
	{
		FPONGDFAKIG(text);
	}

	[SpecialName]
	public void MCCLCFEFPHB(Color AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		MIKONDHOMHM = AODONKKHPBP;
		backgroundText.color = MIKONDHOMHM;
	}

	private void KGIKOECKEHI()
	{
		((Component)outlineText).gameObject.SetActive(!LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	private void FPONGDFAKIG(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.HEKFJEKFMNO() != (Object)null && LocalisationSystem.GGFJGHHHEJC.useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	[SpecialName]
	public string INDICCHJMFG()
	{
		return text;
	}

	[SpecialName]
	public void LHMMPNHGMGK(string AODONKKHPBP)
	{
		FPONGDFAKIG(AODONKKHPBP);
	}

	private void ALEAOANPHIO()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	[SpecialName]
	public void MEFFCJGGNCA(string AODONKKHPBP)
	{
		DNGMLGKCPCH(AODONKKHPBP);
	}

	private void DNGMLGKCPCH(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.GGFJGHHHEJC != (Object)null && LocalisationSystem.HEKFJEKFMNO().useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}

	public void UpdateText()
	{
		DNEOBLANBAI(text);
	}

	[SpecialName]
	public string DFHJDMFKFFI()
	{
		return text;
	}

	private void INHBDHMJHEB()
	{
		((Component)outlineText).gameObject.SetActive(LocalisationSystem.GGFJGHHHEJC.useTMProOutline);
		((Component)backgroundText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
		((Component)tmProText).gameObject.SetActive(LocalisationSystem.HEKFJEKFMNO().useTMProOutline);
	}

	private void OJKELBMNGBF(string EOHLMDEPNNK)
	{
		if ((Object)(object)LocalisationSystem.HEKFJEKFMNO() != (Object)null && LocalisationSystem.HEKFJEKFMNO().useTMProOutline)
		{
			((TMP_Text)tmProText).text = EOHLMDEPNNK;
		}
		else
		{
			outlineText.text = EOHLMDEPNNK;
			backgroundText.text = EOHLMDEPNNK;
		}
		text = EOHLMDEPNNK;
	}
}
