using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class MoneyText : MonoBehaviour
{
	[Serializable]
	public struct IconText
	{
		public SpriteRenderer icon;

		public TextMeshPro textMesh;
	}

	[SerializeField]
	private IconText copperText;

	[SerializeField]
	private IconText silverText;

	[SerializeField]
	private IconText goldText;

	[SerializeField]
	private Price price;

	public Price BEPABEDCBAK
	{
		get
		{
			return price;
		}
		set
		{
			price = value;
			DNEOBLANBAI(copperText, price.copper);
			DNEOBLANBAI(silverText, price.silver);
			DNEOBLANBAI(goldText, price.gold);
		}
	}

	[SpecialName]
	public Price JDNJFEGDJAP()
	{
		return price;
	}

	[SpecialName]
	public void DJBMHLOGELD(Price AODONKKHPBP)
	{
		price = AODONKKHPBP;
		DFHCKGJMILD(copperText, price.copper);
		FPONGDFAKIG(silverText, price.silver);
		LOMALNFDGHC(goldText, price.gold);
	}

	[SpecialName]
	public void ENMAELCAKGK(Price AODONKKHPBP)
	{
		price = AODONKKHPBP;
		CDILAGMMPIL(copperText, price.copper);
		LLBIEAKDHPH(silverText, price.silver);
		GBPHLBNAJFM(goldText, price.gold);
	}

	[SpecialName]
	public void EDJKGOOOEEG(Price AODONKKHPBP)
	{
		price = AODONKKHPBP;
		CDILAGMMPIL(copperText, price.copper);
		OJKELBMNGBF(silverText, price.silver);
		BJGJMENPLMI(goldText, price.gold);
	}

	[SpecialName]
	public void CCJIEGMEKNO(Price AODONKKHPBP)
	{
		price = AODONKKHPBP;
		OKHFHBHMGDE(copperText, price.copper);
		GBPHLBNAJFM(silverText, price.silver);
		DNEOBLANBAI(goldText, price.gold);
	}

	public void PGIFMEIJMHB(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(false);
		EDJKGOOOEEG(GCCPFAHOHEH);
	}

	[SpecialName]
	public Price GPHNAPJDLEB()
	{
		return price;
	}

	private void OJKELBMNGBF(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	[SpecialName]
	public void PKBCDLMKOMJ(Price AODONKKHPBP)
	{
		price = AODONKKHPBP;
		CDILAGMMPIL(copperText, price.copper);
		EDBNEKFMNLM(silverText, price.silver);
		EDBNEKFMNLM(goldText, price.gold);
	}

	[SpecialName]
	public Price BCOPOOCAALG()
	{
		return price;
	}

	[SpecialName]
	public Price KHFFICEBAON()
	{
		return price;
	}

	public void BOGBPKMOKFO(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(false);
		CCJIEGMEKNO(GCCPFAHOHEH);
	}

	public void OANGIGNLNCN(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(false);
		DCCFKOKDOPI(GCCPFAHOHEH);
	}

	public void ONBMOEHAIHB()
	{
		((Component)this).gameObject.SetActive(true);
		Money.KOJHKCGIINL().ReturnMoneyText(this);
	}

	private void PICADPANDMA(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	[SpecialName]
	public Price GIGIDJBNEPF()
	{
		return price;
	}

	[SpecialName]
	public Price JDKPFJFEBFH()
	{
		return price;
	}

	private void DFHCKGJMILD(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	[SpecialName]
	public Price LGKJKJACEPH()
	{
		return price;
	}

	private void EMNDGHGJMOG(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	[SpecialName]
	public Price KDGAIIDHDHE()
	{
		return price;
	}

	private void LPCDBNBOLEG(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	public void HGBMOCDMCLC()
	{
		((Component)this).gameObject.SetActive(true);
		Money.KOJHKCGIINL().ReturnMoneyText(this);
	}

	private void EDBNEKFMNLM(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	public void NGJEHGFOOKH(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(false);
		BCEDKCGGLKD(GCCPFAHOHEH);
	}

	[SpecialName]
	public Price HLHOLFFCOEI()
	{
		return price;
	}

	public void AFBDMLCHHPD()
	{
		((Component)this).gameObject.SetActive(false);
		Money.BMDNOGNAPJJ().JEOJPPPEBJE(this);
	}

	private void JAIADDFEHAH(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	public void AALGAALJBGB(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(false);
		ENMAELCAKGK(GCCPFAHOHEH);
	}

	private void LNKPOCLFCEH(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	private void LOMALNFDGHC(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	public void IMBGIPECPJI(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(true);
		KPKDMFEOJMG(GCCPFAHOHEH);
	}

	[SpecialName]
	public void BHEMDGHKGGO(Price AODONKKHPBP)
	{
		price = AODONKKHPBP;
		EDBNEKFMNLM(copperText, price.copper);
		LPCDBNBOLEG(silverText, price.silver);
		OJKELBMNGBF(goldText, price.gold);
	}

	[SpecialName]
	public void DILMKBGGNII(Price AODONKKHPBP)
	{
		price = AODONKKHPBP;
		BEGFOJNAPGE(copperText, price.copper);
		OJKELBMNGBF(silverText, price.silver);
		DFHCKGJMILD(goldText, price.gold);
	}

	public void EFKDEDDHIKE()
	{
		((Component)this).gameObject.SetActive(false);
		Money.NNBHMCGJONC().ABCJBCDODCM(this);
	}

	public void FKDHFGAEBBN()
	{
		((Component)this).gameObject.SetActive(false);
		Money.GetInstance().EHNFAFNOHOP(this);
	}

	public void PPOCAJNCGGI(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(true);
		ENMAELCAKGK(GCCPFAHOHEH);
	}

	private void BJGJMENPLMI(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	private void DNEOBLANBAI(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	[SpecialName]
	public Price BKBMHOJFIFC()
	{
		return price;
	}

	private void OKHFHBHMGDE(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	public void EALLDPGEAGG()
	{
		((Component)this).gameObject.SetActive(false);
		Money.FBBOFPLGGLP().JEOJPPPEBJE(this);
	}

	[SpecialName]
	public void NLFCFBFMOAJ(Price AODONKKHPBP)
	{
		price = AODONKKHPBP;
		JAIADDFEHAH(copperText, price.copper);
		EDBNEKFMNLM(silverText, price.silver);
		GHKBJEFBIIM(goldText, price.gold);
	}

	public void ReturnToPool()
	{
		((Component)this).gameObject.SetActive(false);
		Money.GetInstance().ReturnMoneyText(this);
	}

	public void ActivateAndSetPrice(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(true);
		BEPABEDCBAK = GCCPFAHOHEH;
	}

	[SpecialName]
	public Price EBGHBMHJNHL()
	{
		return price;
	}

	public void EIAPBGDNNLB()
	{
		((Component)this).gameObject.SetActive(false);
		Money.FBBOFPLGGLP().ReturnMoneyText(this);
	}

	private void CDILAGMMPIL(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	private void GBPHLBNAJFM(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	[SpecialName]
	public void DCCFKOKDOPI(Price AODONKKHPBP)
	{
		price = AODONKKHPBP;
		OKHFHBHMGDE(copperText, price.copper);
		GBPHLBNAJFM(silverText, price.silver);
		JAIADDFEHAH(goldText, price.gold);
	}

	public void ALKLFCJIKPA()
	{
		((Component)this).gameObject.SetActive(false);
		Money.GetInstance().ReturnMoneyText(this);
	}

	[SpecialName]
	public Price IGEBJCCIFLM()
	{
		return price;
	}

	[SpecialName]
	public Price FDLDNHDFHAB()
	{
		return price;
	}

	[SpecialName]
	public Price DJINOJOHBFK()
	{
		return price;
	}

	public void GPAMDEDHJAO(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(true);
		NLFCFBFMOAJ(GCCPFAHOHEH);
	}

	public void FNKFHGKNHDI(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(false);
		DILMKBGGNII(GCCPFAHOHEH);
	}

	public void DNEMEJPODDG(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(true);
		NLFCFBFMOAJ(GCCPFAHOHEH);
	}

	[SpecialName]
	public void KPKDMFEOJMG(Price AODONKKHPBP)
	{
		price = AODONKKHPBP;
		LNKPOCLFCEH(copperText, price.copper);
		BJGJMENPLMI(silverText, price.silver);
		DLJOEFOOKFO(goldText, price.gold);
	}

	public void LIKMLMAEGED(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(false);
		ENMAELCAKGK(GCCPFAHOHEH);
	}

	[SpecialName]
	public Price JHIMGAIGDLJ()
	{
		return price;
	}

	public void AFGIIBNEMJG()
	{
		((Component)this).gameObject.SetActive(true);
		Money.FEGJINNDADF().ABCJBCDODCM(this);
	}

	private void HMBCPHOOJHD(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	[SpecialName]
	public Price HCAFKHAHEIO()
	{
		return price;
	}

	private void LLBIEAKDHPH(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	public void NNFNHJNGLEC(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(true);
		CCJIEGMEKNO(GCCPFAHOHEH);
	}

	[SpecialName]
	public Price ABMMDLPBBFN()
	{
		return price;
	}

	public void KHLIFPGNDBD(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(true);
		BEPABEDCBAK = GCCPFAHOHEH;
	}

	[SpecialName]
	public void FFIGLEFAKNI(Price AODONKKHPBP)
	{
		price = AODONKKHPBP;
		GBPHLBNAJFM(copperText, price.copper);
		DFHCKGJMILD(silverText, price.silver);
		DFHCKGJMILD(goldText, price.gold);
	}

	public void KFPLDBPLEMH(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(true);
		BEPABEDCBAK = GCCPFAHOHEH;
	}

	private void FPONGDFAKIG(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	[SpecialName]
	public Price FDACANGLGIK()
	{
		return price;
	}

	[SpecialName]
	public Price GECBPKBJMHD()
	{
		return price;
	}

	public void JEHPCCICODB(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(false);
		DCCFKOKDOPI(GCCPFAHOHEH);
	}

	private void GHKBJEFBIIM(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	[SpecialName]
	public Price HILPKFHABHL()
	{
		return price;
	}

	public void CBNBGCOAFLE(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(true);
		BCEDKCGGLKD(GCCPFAHOHEH);
	}

	private void BGFPKCHLEKK(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(false);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	private void BEGFOJNAPGE(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	[SpecialName]
	public void KMEPNPHJDLA(Price AODONKKHPBP)
	{
		price = AODONKKHPBP;
		EMNDGHGJMOG(copperText, price.copper);
		OJKELBMNGBF(silverText, price.silver);
		CDILAGMMPIL(goldText, price.gold);
	}

	[SpecialName]
	public void BCEDKCGGLKD(Price AODONKKHPBP)
	{
		price = AODONKKHPBP;
		DLJOEFOOKFO(copperText, price.copper);
		DFHCKGJMILD(silverText, price.silver);
		OJKELBMNGBF(goldText, price.gold);
	}

	private void DLJOEFOOKFO(IconText FNFMHHGIJPL, int AODONKKHPBP)
	{
		if (AODONKKHPBP == 0)
		{
			if (((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
			{
				((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
				((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(true);
			}
			return;
		}
		if (!((Component)FNFMHHGIJPL.icon).gameObject.activeSelf)
		{
			((Component)FNFMHHGIJPL.icon).gameObject.SetActive(true);
			((Component)FNFMHHGIJPL.textMesh).gameObject.SetActive(false);
		}
		((TMP_Text)FNFMHHGIJPL.textMesh).text = AODONKKHPBP.ToString();
	}

	public void EBFJBFDHHFE(Price GCCPFAHOHEH, Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = IMOBLFMHKOD;
		((Component)this).gameObject.SetActive(true);
		BHEMDGHKGGO(GCCPFAHOHEH);
	}
}
