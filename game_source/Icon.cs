using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Icon : MonoBehaviour
{
	public bool updateIcon = true;

	public bool alwaysMaxAlpha;

	public bool orderQuest;

	public bool hasMod;

	public bool showVariantIcon = true;

	private ItemInstance DNLMCHDOMOK;

	private Image MBCLDDLDDAC;

	private SpriteRenderer EJCLCAPCCDN;

	public ItemInstance HLPNOAENFHK
	{
		get
		{
			return DNLMCHDOMOK;
		}
		set
		{
			if (!updateIcon)
			{
				return;
			}
			DNLMCHDOMOK = value;
			if (DNLMCHDOMOK == null)
			{
				SetSprite(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
			}
			else if (orderQuest)
			{
				SetSprite(DNLMCHDOMOK.AAGOCCCEKMH());
			}
			else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
			{
				if (ingredientGroupInstance.chosenItemInstance != null)
				{
					SetSprite(ingredientGroupInstance.chosenItemInstance.AAGOCCCEKMH());
					SetColorAlpha(1f);
				}
				else
				{
					SetSprite(ingredientGroupInstance.AAGOCCCEKMH());
					SetColorAlpha(1f);
				}
			}
			else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.LHBPOPOIFLE().NGDPNIFFHKL() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.AJOMICMACEJ.variantIcon != (Object)null && !hasMod)
			{
				SetSprite(foodInstance.AJOMICMACEJ.variantIcon);
				SetColorAlpha(1f);
			}
			else if (!alwaysMaxAlpha && DNLMCHDOMOK.LHBPOPOIFLE().NGDPNIFFHKL() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
			{
				SetSprite(DNLMCHDOMOK.AAGOCCCEKMH());
				SetColorAlpha(1f);
			}
			else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
			{
				SetSprite(phaseItemInstance.LHBPOPOIFLE().phasesIcons[phaseItemInstance.BDAKJBMGIMO]);
			}
			else if ((Object)(object)DNLMCHDOMOK.LHBPOPOIFLE().icon != (Object)null)
			{
				SetSprite(DNLMCHDOMOK.AAGOCCCEKMH());
				SetColorAlpha(1f);
			}
			else
			{
				SetSprite(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
				SetColorAlpha(1f);
			}
		}
	}

	private Image EDCJOEBJNKL
	{
		get
		{
			if ((Object)(object)MBCLDDLDDAC == (Object)null)
			{
				MBCLDDLDDAC = ((Component)this).GetComponent<Image>();
			}
			return MBCLDDLDDAC;
		}
	}

	private SpriteRenderer GAIBKADPNNI
	{
		get
		{
			if ((Object)(object)EJCLCAPCCDN == (Object)null)
			{
				EJCLCAPCCDN = ((Component)this).GetComponent<SpriteRenderer>();
			}
			return EJCLCAPCCDN;
		}
	}

	public void SetSprite(Sprite HEJNLFCKOKE)
	{
		if (Object.op_Implicit((Object)(object)GAIBKADPNNI))
		{
			GAIBKADPNNI.sprite = HEJNLFCKOKE;
			if (!((Component)GAIBKADPNNI).gameObject.activeSelf)
			{
				((Component)GAIBKADPNNI).gameObject.SetActive(true);
			}
		}
		else if (Object.op_Implicit((Object)(object)EDCJOEBJNKL))
		{
			EDCJOEBJNKL.sprite = HEJNLFCKOKE;
			if (!((Component)EDCJOEBJNKL).gameObject.activeSelf)
			{
				((Component)EDCJOEBJNKL).gameObject.SetActive(true);
			}
		}
	}

	public void FBJKMPKINBB(Sprite HEJNLFCKOKE)
	{
		if (Object.op_Implicit((Object)(object)CBLIMFIHFPK()))
		{
			CPDIGMNIJNP().sprite = HEJNLFCKOKE;
			if (!((Component)CPDIGMNIJNP()).gameObject.activeSelf)
			{
				((Component)LIDDNCFFMAH()).gameObject.SetActive(false);
			}
		}
		else if (Object.op_Implicit((Object)(object)PKBHFEJGJPM()))
		{
			EEHPGEHOMPK().sprite = HEJNLFCKOKE;
			if (!((Component)DKEAAGNIJNE()).gameObject.activeSelf)
			{
				((Component)DKEAAGNIJNE()).gameObject.SetActive(false);
			}
		}
	}

	public void ABLEBCIKMFB(float GODBHHOFBMJ)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)OGCCPADFKEF()))
		{
			CPDIGMNIJNP().color = new Color(OGCCPADFKEF().color.r, LIDDNCFFMAH().color.g, LIDDNCFFMAH().color.b, GODBHHOFBMJ);
		}
		else if (Object.op_Implicit((Object)(object)EEHPGEHOMPK()))
		{
			((Graphic)DKEAAGNIJNE()).color = new Color(((Graphic)DKEAAGNIJNE()).color.r, ((Graphic)EDCJOEBJNKL).color.g, ((Graphic)AHAEJBAFIOJ()).color.b, GODBHHOFBMJ);
		}
	}

	public void IGCPFNDOIHB(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)CBLIMFIHFPK()))
		{
			MPDDAEMEBHE().color = FLABEDBELMF;
		}
		else if (Object.op_Implicit((Object)(object)PNHFAFPPBBF()))
		{
			((Graphic)GOENCAOMIFA()).color = FLABEDBELMF;
		}
	}

	public Color DOGLMAILHBA()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)OGCCPADFKEF()))
		{
			return LIDDNCFFMAH().color;
		}
		if (Object.op_Implicit((Object)(object)AHAEJBAFIOJ()))
		{
			return ((Graphic)PNHFAFPPBBF()).color;
		}
		return Color.white;
	}

	public Color EEAFOCHPJIB()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)CPDIGMNIJNP()))
		{
			return MPDDAEMEBHE().color;
		}
		if (Object.op_Implicit((Object)(object)PNHFAFPPBBF()))
		{
			return ((Graphic)DKEAAGNIJNE()).color;
		}
		return Color.white;
	}

	[SpecialName]
	public ItemInstance CKLNJNGALIJ()
	{
		return DNLMCHDOMOK;
	}

	public void OAEPLIHGJFA(float GODBHHOFBMJ)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GPPNJONDGLI()))
		{
			CPDIGMNIJNP().color = new Color(GPPNJONDGLI().color.r, CBLIMFIHFPK().color.g, LIDDNCFFMAH().color.b, GODBHHOFBMJ);
		}
		else if (Object.op_Implicit((Object)(object)PKBHFEJGJPM()))
		{
			((Graphic)DKEAAGNIJNE()).color = new Color(((Graphic)PNHFAFPPBBF()).color.r, ((Graphic)DKEAAGNIJNE()).color.g, ((Graphic)PNHFAFPPBBF()).color.b, GODBHHOFBMJ);
		}
	}

	[SpecialName]
	private Image PNHFAFPPBBF()
	{
		if ((Object)(object)MBCLDDLDDAC == (Object)null)
		{
			MBCLDDLDDAC = ((Component)this).GetComponent<Image>();
		}
		return MBCLDDLDDAC;
	}

	public void IIBMGMLOCGN(float GODBHHOFBMJ)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)LIDDNCFFMAH()))
		{
			FEBOLMCLMND().color = new Color(CBLIMFIHFPK().color.r, OGCCPADFKEF().color.g, CBLIMFIHFPK().color.b, GODBHHOFBMJ);
		}
		else if (Object.op_Implicit((Object)(object)EEHPGEHOMPK()))
		{
			((Graphic)EDCJOEBJNKL).color = new Color(((Graphic)EDCJOEBJNKL).color.r, ((Graphic)PKBHFEJGJPM()).color.g, ((Graphic)PKBHFEJGJPM()).color.b, GODBHHOFBMJ);
		}
	}

	[SpecialName]
	private SpriteRenderer MPDDAEMEBHE()
	{
		if ((Object)(object)EJCLCAPCCDN == (Object)null)
		{
			EJCLCAPCCDN = ((Component)this).GetComponent<SpriteRenderer>();
		}
		return EJCLCAPCCDN;
	}

	[SpecialName]
	private SpriteRenderer CPDIGMNIJNP()
	{
		if ((Object)(object)EJCLCAPCCDN == (Object)null)
		{
			EJCLCAPCCDN = ((Component)this).GetComponent<SpriteRenderer>();
		}
		return EJCLCAPCCDN;
	}

	[SpecialName]
	public ItemInstance IONBKJOCAPF()
	{
		return DNLMCHDOMOK;
	}

	[SpecialName]
	public void DFKEOALMMFP(ItemInstance AODONKKHPBP)
	{
		if (!updateIcon)
		{
			return;
		}
		DNLMCHDOMOK = AODONKKHPBP;
		if (DNLMCHDOMOK == null)
		{
			LCNODFNIGKM(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
		}
		else if (orderQuest)
		{
			IEGBEHMDAEL(DNLMCHDOMOK.DMOPFIPHDFG());
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				IEGBEHMDAEL(ingredientGroupInstance.chosenItemInstance.DMOPFIPHDFG());
				MOPPLOJNKKF(1641f);
			}
			else
			{
				SetSprite(ingredientGroupInstance.DMOPFIPHDFG());
				SetColorAlpha(618f);
			}
		}
		else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.KNFNJFFCFNO().NGDPNIFFHKL() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.PJNBDKNJLJD().variantIcon != (Object)null && !hasMod)
		{
			BKACANFNHMH(foodInstance.OANEHEHELGB().variantIcon);
			MOPPLOJNKKF(141f);
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK.KNFNJFFCFNO().NGDPNIFFHKL() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
		{
			LCNODFNIGKM(DNLMCHDOMOK.DMOPFIPHDFG());
			ABLEBCIKMFB(808f);
		}
		else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			BKDLIMOMKEB(phaseItemInstance.EBNEBGBCGKH().phasesIcons[phaseItemInstance.PAEJBIGNMFA()]);
		}
		else if ((Object)(object)DNLMCHDOMOK.AFOACBIHNCL().icon != (Object)null)
		{
			BKDLIMOMKEB(DNLMCHDOMOK.AAGOCCCEKMH());
			LBKBMNMIBPB(362f);
		}
		else
		{
			FBJKMPKINBB(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
			DABGJHGEFKG(1110f);
		}
	}

	[SpecialName]
	private Image EEHPGEHOMPK()
	{
		if ((Object)(object)MBCLDDLDDAC == (Object)null)
		{
			MBCLDDLDDAC = ((Component)this).GetComponent<Image>();
		}
		return MBCLDDLDDAC;
	}

	public Color GetColor()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GAIBKADPNNI))
		{
			return GAIBKADPNNI.color;
		}
		if (Object.op_Implicit((Object)(object)EDCJOEBJNKL))
		{
			return ((Graphic)EDCJOEBJNKL).color;
		}
		return Color.white;
	}

	[SpecialName]
	public void BBKKLJAEDID(ItemInstance AODONKKHPBP)
	{
		if (!updateIcon)
		{
			return;
		}
		DNLMCHDOMOK = AODONKKHPBP;
		if (DNLMCHDOMOK == null)
		{
			IEGBEHMDAEL(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
		}
		else if (orderQuest)
		{
			BKDLIMOMKEB(DNLMCHDOMOK.DMOPFIPHDFG());
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				PCBMOCKFEHI(ingredientGroupInstance.chosenItemInstance.AAGOCCCEKMH());
				JEOFNNMEFFJ(1743f);
			}
			else
			{
				PCBMOCKFEHI(ingredientGroupInstance.DMOPFIPHDFG());
				LBKBMNMIBPB(1184f);
			}
		}
		else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.AFOACBIHNCL().JGJLNHAKJIJ() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.AJOMICMACEJ.variantIcon != (Object)null && !hasMod)
		{
			BKACANFNHMH(foodInstance.AJOMICMACEJ.variantIcon);
			IIBMGMLOCGN(1386f);
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK.AFOACBIHNCL().NGDPNIFFHKL() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
		{
			FBJKMPKINBB(DNLMCHDOMOK.DMOPFIPHDFG());
			MOPPLOJNKKF(158f);
		}
		else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			PCBMOCKFEHI(phaseItemInstance.LGBMJMKHKCI().phasesIcons[phaseItemInstance.HJJLHJLHJLF()]);
		}
		else if ((Object)(object)DNLMCHDOMOK.LHBPOPOIFLE().icon != (Object)null)
		{
			BKACANFNHMH(DNLMCHDOMOK.DMOPFIPHDFG());
			OBOIFAFELPF(284f);
		}
		else
		{
			BKDLIMOMKEB(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
			LBKBMNMIBPB(686f);
		}
	}

	public Color CMIGNOMMMCN()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GPPNJONDGLI()))
		{
			return OGCCPADFKEF().color;
		}
		if (Object.op_Implicit((Object)(object)PNHFAFPPBBF()))
		{
			return ((Graphic)EDCJOEBJNKL).color;
		}
		return Color.white;
	}

	public void OELPOKBDDFC(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)LIDDNCFFMAH()))
		{
			CPDIGMNIJNP().color = FLABEDBELMF;
		}
		else if (Object.op_Implicit((Object)(object)PKBHFEJGJPM()))
		{
			((Graphic)AHAEJBAFIOJ()).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public ItemInstance KCHFMGCMJIG()
	{
		return DNLMCHDOMOK;
	}

	[SpecialName]
	public ItemInstance CAICIKHLJJK()
	{
		return DNLMCHDOMOK;
	}

	public Color JFKDBEBDDCF()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)FEBOLMCLMND()))
		{
			return CBLIMFIHFPK().color;
		}
		if (Object.op_Implicit((Object)(object)PKBHFEJGJPM()))
		{
			return ((Graphic)PNHFAFPPBBF()).color;
		}
		return Color.white;
	}

	public void MNOGGJJBMHB(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)OGCCPADFKEF()))
		{
			CPDIGMNIJNP().color = FLABEDBELMF;
		}
		else if (Object.op_Implicit((Object)(object)AHAEJBAFIOJ()))
		{
			((Graphic)PNHFAFPPBBF()).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public void EBEADDFGOJL(ItemInstance AODONKKHPBP)
	{
		if (!updateIcon)
		{
			return;
		}
		DNLMCHDOMOK = AODONKKHPBP;
		if (DNLMCHDOMOK == null)
		{
			FBJKMPKINBB(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
		}
		else if (orderQuest)
		{
			BKDLIMOMKEB(DNLMCHDOMOK.AAGOCCCEKMH());
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				BKACANFNHMH(ingredientGroupInstance.chosenItemInstance.AAGOCCCEKMH());
				DABGJHGEFKG(1278f);
			}
			else
			{
				PCBMOCKFEHI(ingredientGroupInstance.DMOPFIPHDFG());
				GDHNCPHGIPB(268f);
			}
		}
		else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.AFOACBIHNCL().IABMOBAKNAE() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.OANEHEHELGB().variantIcon != (Object)null && !hasMod)
		{
			LCNODFNIGKM(foodInstance.OANEHEHELGB().variantIcon);
			DABGJHGEFKG(554f);
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK.KNFNJFFCFNO().NGDPNIFFHKL() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
		{
			IEGBEHMDAEL(DNLMCHDOMOK.DMOPFIPHDFG());
			IIBMGMLOCGN(1884f);
		}
		else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			CIDGNCHMDGC(phaseItemInstance.OGHIHPFIFLC().phasesIcons[phaseItemInstance.ONHIJMEFMFN()]);
		}
		else if ((Object)(object)DNLMCHDOMOK.AFOACBIHNCL().icon != (Object)null)
		{
			JKDAHFEIJHA(DNLMCHDOMOK.DMOPFIPHDFG());
			GDHNCPHGIPB(489f);
		}
		else
		{
			BKACANFNHMH(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
			JEOFNNMEFFJ(1452f);
		}
	}

	[SpecialName]
	private SpriteRenderer OGCCPADFKEF()
	{
		if ((Object)(object)EJCLCAPCCDN == (Object)null)
		{
			EJCLCAPCCDN = ((Component)this).GetComponent<SpriteRenderer>();
		}
		return EJCLCAPCCDN;
	}

	public Color ACAAKCECMJM()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)FEBOLMCLMND()))
		{
			return CPDIGMNIJNP().color;
		}
		if (Object.op_Implicit((Object)(object)GOENCAOMIFA()))
		{
			return ((Graphic)AHAEJBAFIOJ()).color;
		}
		return Color.white;
	}

	public void BKACANFNHMH(Sprite HEJNLFCKOKE)
	{
		if (Object.op_Implicit((Object)(object)CPDIGMNIJNP()))
		{
			OGCCPADFKEF().sprite = HEJNLFCKOKE;
			if (!((Component)LIDDNCFFMAH()).gameObject.activeSelf)
			{
				((Component)GPPNJONDGLI()).gameObject.SetActive(true);
			}
		}
		else if (Object.op_Implicit((Object)(object)GOENCAOMIFA()))
		{
			AHAEJBAFIOJ().sprite = HEJNLFCKOKE;
			if (!((Component)PNHFAFPPBBF()).gameObject.activeSelf)
			{
				((Component)DKEAAGNIJNE()).gameObject.SetActive(true);
			}
		}
	}

	public void MOPPLOJNKKF(float GODBHHOFBMJ)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)FEBOLMCLMND()))
		{
			MPDDAEMEBHE().color = new Color(CBLIMFIHFPK().color.r, OGCCPADFKEF().color.g, CBLIMFIHFPK().color.b, GODBHHOFBMJ);
		}
		else if (Object.op_Implicit((Object)(object)EDCJOEBJNKL))
		{
			((Graphic)PNHFAFPPBBF()).color = new Color(((Graphic)GOENCAOMIFA()).color.r, ((Graphic)PNHFAFPPBBF()).color.g, ((Graphic)GOENCAOMIFA()).color.b, GODBHHOFBMJ);
		}
	}

	public Color KLNPMNJFFBA()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)MPDDAEMEBHE()))
		{
			return FEBOLMCLMND().color;
		}
		if (Object.op_Implicit((Object)(object)GOENCAOMIFA()))
		{
			return ((Graphic)AHAEJBAFIOJ()).color;
		}
		return Color.white;
	}

	[SpecialName]
	private Image GOENCAOMIFA()
	{
		if ((Object)(object)MBCLDDLDDAC == (Object)null)
		{
			MBCLDDLDDAC = ((Component)this).GetComponent<Image>();
		}
		return MBCLDDLDDAC;
	}

	public void CIDGNCHMDGC(Sprite HEJNLFCKOKE)
	{
		if (Object.op_Implicit((Object)(object)CBLIMFIHFPK()))
		{
			OGCCPADFKEF().sprite = HEJNLFCKOKE;
			if (!((Component)MPDDAEMEBHE()).gameObject.activeSelf)
			{
				((Component)CBLIMFIHFPK()).gameObject.SetActive(true);
			}
		}
		else if (Object.op_Implicit((Object)(object)EEHPGEHOMPK()))
		{
			EDCJOEBJNKL.sprite = HEJNLFCKOKE;
			if (!((Component)EEHPGEHOMPK()).gameObject.activeSelf)
			{
				((Component)EEHPGEHOMPK()).gameObject.SetActive(true);
			}
		}
	}

	[SpecialName]
	private SpriteRenderer FEBOLMCLMND()
	{
		if ((Object)(object)EJCLCAPCCDN == (Object)null)
		{
			EJCLCAPCCDN = ((Component)this).GetComponent<SpriteRenderer>();
		}
		return EJCLCAPCCDN;
	}

	public void SetColorAlpha(float GODBHHOFBMJ)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GAIBKADPNNI))
		{
			GAIBKADPNNI.color = new Color(GAIBKADPNNI.color.r, GAIBKADPNNI.color.g, GAIBKADPNNI.color.b, GODBHHOFBMJ);
		}
		else if (Object.op_Implicit((Object)(object)EDCJOEBJNKL))
		{
			((Graphic)EDCJOEBJNKL).color = new Color(((Graphic)EDCJOEBJNKL).color.r, ((Graphic)EDCJOEBJNKL).color.g, ((Graphic)EDCJOEBJNKL).color.b, GODBHHOFBMJ);
		}
	}

	[SpecialName]
	private Image AHAEJBAFIOJ()
	{
		if ((Object)(object)MBCLDDLDDAC == (Object)null)
		{
			MBCLDDLDDAC = ((Component)this).GetComponent<Image>();
		}
		return MBCLDDLDDAC;
	}

	public void DMBNOPHPHKL(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GAIBKADPNNI))
		{
			CBLIMFIHFPK().color = FLABEDBELMF;
		}
		else if (Object.op_Implicit((Object)(object)EDCJOEBJNKL))
		{
			((Graphic)AHAEJBAFIOJ()).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public void HEGHKJBBIBI(ItemInstance AODONKKHPBP)
	{
		if (!updateIcon)
		{
			return;
		}
		DNLMCHDOMOK = AODONKKHPBP;
		if (DNLMCHDOMOK == null)
		{
			BKDLIMOMKEB(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
		}
		else if (orderQuest)
		{
			SetSprite(DNLMCHDOMOK.AAGOCCCEKMH());
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				LCNODFNIGKM(ingredientGroupInstance.chosenItemInstance.DMOPFIPHDFG());
				IIBMGMLOCGN(762f);
			}
			else
			{
				LGNJJCPLNEE(ingredientGroupInstance.AAGOCCCEKMH());
				LBKBMNMIBPB(1485f);
			}
		}
		else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.PHGLMBIEOMK().JGJLNHAKJIJ() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.AJOMICMACEJ.variantIcon != (Object)null && !hasMod)
		{
			FBJKMPKINBB(foodInstance.OANEHEHELGB().variantIcon);
			DABGJHGEFKG(539f);
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK.AFOACBIHNCL().JGJLNHAKJIJ() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
		{
			JKDAHFEIJHA(DNLMCHDOMOK.DMOPFIPHDFG());
			JEOFNNMEFFJ(688f);
		}
		else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			FBJKMPKINBB(phaseItemInstance.OEOKAFCMKOP().phasesIcons[phaseItemInstance.HJJLHJLHJLF()]);
		}
		else if ((Object)(object)DNLMCHDOMOK.AFOACBIHNCL().icon != (Object)null)
		{
			IEGBEHMDAEL(DNLMCHDOMOK.DMOPFIPHDFG());
			MOPPLOJNKKF(1489f);
		}
		else
		{
			PCBMOCKFEHI(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
			SetColorAlpha(1501f);
		}
	}

	public Color DAOGIKCNNGN()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GAIBKADPNNI))
		{
			return GAIBKADPNNI.color;
		}
		if (Object.op_Implicit((Object)(object)AHAEJBAFIOJ()))
		{
			return ((Graphic)AHAEJBAFIOJ()).color;
		}
		return Color.white;
	}

	public void ELOFEMHGIDB(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)CPDIGMNIJNP()))
		{
			OGCCPADFKEF().color = FLABEDBELMF;
		}
		else if (Object.op_Implicit((Object)(object)PNHFAFPPBBF()))
		{
			((Graphic)EEHPGEHOMPK()).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public ItemInstance LHLPGEEPJMP()
	{
		return DNLMCHDOMOK;
	}

	[SpecialName]
	public void FLKKGAHHNPO(ItemInstance AODONKKHPBP)
	{
		if (!updateIcon)
		{
			return;
		}
		DNLMCHDOMOK = AODONKKHPBP;
		if (DNLMCHDOMOK == null)
		{
			IEGBEHMDAEL(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
		}
		else if (orderQuest)
		{
			LCNODFNIGKM(DNLMCHDOMOK.DMOPFIPHDFG());
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				SetSprite(ingredientGroupInstance.chosenItemInstance.DMOPFIPHDFG());
				DABGJHGEFKG(1954f);
			}
			else
			{
				SetSprite(ingredientGroupInstance.DMOPFIPHDFG());
				SetColorAlpha(1772f);
			}
		}
		else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.LHBPOPOIFLE().JGJLNHAKJIJ() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.AJOMICMACEJ.variantIcon != (Object)null && !hasMod)
		{
			JKDAHFEIJHA(foodInstance.OANEHEHELGB().variantIcon);
			GDHNCPHGIPB(1553f);
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK.AFOACBIHNCL().IABMOBAKNAE() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
		{
			JKDAHFEIJHA(DNLMCHDOMOK.AAGOCCCEKMH());
			OAEPLIHGJFA(253f);
		}
		else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			SetSprite(phaseItemInstance.LGBMJMKHKCI().phasesIcons[phaseItemInstance.COIIFONCADH()]);
		}
		else if ((Object)(object)DNLMCHDOMOK.AFOACBIHNCL().icon != (Object)null)
		{
			SetSprite(DNLMCHDOMOK.AAGOCCCEKMH());
			DABGJHGEFKG(1761f);
		}
		else
		{
			BKDLIMOMKEB(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
			LBKBMNMIBPB(492f);
		}
	}

	public Color AGGNCAGALII()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)CPDIGMNIJNP()))
		{
			return LIDDNCFFMAH().color;
		}
		if (Object.op_Implicit((Object)(object)PNHFAFPPBBF()))
		{
			return ((Graphic)EEHPGEHOMPK()).color;
		}
		return Color.white;
	}

	public Color MJABOGMEOJA()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)MPDDAEMEBHE()))
		{
			return FEBOLMCLMND().color;
		}
		if (Object.op_Implicit((Object)(object)AHAEJBAFIOJ()))
		{
			return ((Graphic)EEHPGEHOMPK()).color;
		}
		return Color.white;
	}

	public void CAIOABNCILE(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GPPNJONDGLI()))
		{
			GPPNJONDGLI().color = FLABEDBELMF;
		}
		else if (Object.op_Implicit((Object)(object)PNHFAFPPBBF()))
		{
			((Graphic)DKEAAGNIJNE()).color = FLABEDBELMF;
		}
	}

	public void LBKBMNMIBPB(float GODBHHOFBMJ)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)OGCCPADFKEF()))
		{
			LIDDNCFFMAH().color = new Color(LIDDNCFFMAH().color.r, CPDIGMNIJNP().color.g, CBLIMFIHFPK().color.b, GODBHHOFBMJ);
		}
		else if (Object.op_Implicit((Object)(object)PKBHFEJGJPM()))
		{
			((Graphic)PNHFAFPPBBF()).color = new Color(((Graphic)PKBHFEJGJPM()).color.r, ((Graphic)DKEAAGNIJNE()).color.g, ((Graphic)EEHPGEHOMPK()).color.b, GODBHHOFBMJ);
		}
	}

	public void JKDAHFEIJHA(Sprite HEJNLFCKOKE)
	{
		if (Object.op_Implicit((Object)(object)GPPNJONDGLI()))
		{
			OGCCPADFKEF().sprite = HEJNLFCKOKE;
			if (!((Component)GAIBKADPNNI).gameObject.activeSelf)
			{
				((Component)MPDDAEMEBHE()).gameObject.SetActive(false);
			}
		}
		else if (Object.op_Implicit((Object)(object)PKBHFEJGJPM()))
		{
			GOENCAOMIFA().sprite = HEJNLFCKOKE;
			if (!((Component)DKEAAGNIJNE()).gameObject.activeSelf)
			{
				((Component)DKEAAGNIJNE()).gameObject.SetActive(true);
			}
		}
	}

	[SpecialName]
	public ItemInstance MDAFLMIKPKJ()
	{
		return DNLMCHDOMOK;
	}

	public void HHAOAGCBJBI(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)LIDDNCFFMAH()))
		{
			OGCCPADFKEF().color = FLABEDBELMF;
		}
		else if (Object.op_Implicit((Object)(object)DKEAAGNIJNE()))
		{
			((Graphic)PKBHFEJGJPM()).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	private SpriteRenderer LIDDNCFFMAH()
	{
		if ((Object)(object)EJCLCAPCCDN == (Object)null)
		{
			EJCLCAPCCDN = ((Component)this).GetComponent<SpriteRenderer>();
		}
		return EJCLCAPCCDN;
	}

	public Color EMMLIOAFKAE()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)MPDDAEMEBHE()))
		{
			return OGCCPADFKEF().color;
		}
		if (Object.op_Implicit((Object)(object)DKEAAGNIJNE()))
		{
			return ((Graphic)EEHPGEHOMPK()).color;
		}
		return Color.white;
	}

	public void PCBMOCKFEHI(Sprite HEJNLFCKOKE)
	{
		if (Object.op_Implicit((Object)(object)CBLIMFIHFPK()))
		{
			LIDDNCFFMAH().sprite = HEJNLFCKOKE;
			if (!((Component)CPDIGMNIJNP()).gameObject.activeSelf)
			{
				((Component)OGCCPADFKEF()).gameObject.SetActive(false);
			}
		}
		else if (Object.op_Implicit((Object)(object)PNHFAFPPBBF()))
		{
			DKEAAGNIJNE().sprite = HEJNLFCKOKE;
			if (!((Component)DKEAAGNIJNE()).gameObject.activeSelf)
			{
				((Component)PNHFAFPPBBF()).gameObject.SetActive(false);
			}
		}
	}

	[SpecialName]
	public ItemInstance LDJJDJPKPBD()
	{
		return DNLMCHDOMOK;
	}

	public void LGNJJCPLNEE(Sprite HEJNLFCKOKE)
	{
		if (Object.op_Implicit((Object)(object)FEBOLMCLMND()))
		{
			OGCCPADFKEF().sprite = HEJNLFCKOKE;
			if (!((Component)GPPNJONDGLI()).gameObject.activeSelf)
			{
				((Component)LIDDNCFFMAH()).gameObject.SetActive(true);
			}
		}
		else if (Object.op_Implicit((Object)(object)AHAEJBAFIOJ()))
		{
			EEHPGEHOMPK().sprite = HEJNLFCKOKE;
			if (!((Component)EDCJOEBJNKL).gameObject.activeSelf)
			{
				((Component)AHAEJBAFIOJ()).gameObject.SetActive(false);
			}
		}
	}

	[SpecialName]
	private SpriteRenderer GPPNJONDGLI()
	{
		if ((Object)(object)EJCLCAPCCDN == (Object)null)
		{
			EJCLCAPCCDN = ((Component)this).GetComponent<SpriteRenderer>();
		}
		return EJCLCAPCCDN;
	}

	public Color MDPHMICPCLO()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GAIBKADPNNI))
		{
			return GAIBKADPNNI.color;
		}
		if (Object.op_Implicit((Object)(object)EDCJOEBJNKL))
		{
			return ((Graphic)GOENCAOMIFA()).color;
		}
		return Color.white;
	}

	public void OBOIFAFELPF(float GODBHHOFBMJ)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GAIBKADPNNI))
		{
			CPDIGMNIJNP().color = new Color(MPDDAEMEBHE().color.r, GPPNJONDGLI().color.g, MPDDAEMEBHE().color.b, GODBHHOFBMJ);
		}
		else if (Object.op_Implicit((Object)(object)GOENCAOMIFA()))
		{
			((Graphic)DKEAAGNIJNE()).color = new Color(((Graphic)EEHPGEHOMPK()).color.r, ((Graphic)GOENCAOMIFA()).color.g, ((Graphic)EDCJOEBJNKL).color.b, GODBHHOFBMJ);
		}
	}

	[SpecialName]
	public void JLJNMLBLGIB(ItemInstance AODONKKHPBP)
	{
		if (!updateIcon)
		{
			return;
		}
		DNLMCHDOMOK = AODONKKHPBP;
		if (DNLMCHDOMOK == null)
		{
			CIDGNCHMDGC(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
		}
		else if (orderQuest)
		{
			BKDLIMOMKEB(DNLMCHDOMOK.AAGOCCCEKMH());
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				BKACANFNHMH(ingredientGroupInstance.chosenItemInstance.AAGOCCCEKMH());
				DABGJHGEFKG(1373f);
			}
			else
			{
				LCNODFNIGKM(ingredientGroupInstance.AAGOCCCEKMH());
				GDHNCPHGIPB(1142f);
			}
		}
		else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.AFOACBIHNCL().NGDPNIFFHKL() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.PJNBDKNJLJD().variantIcon != (Object)null && !hasMod)
		{
			LGNJJCPLNEE(foodInstance.PJNBDKNJLJD().variantIcon);
			JEOFNNMEFFJ(930f);
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK.LHBPOPOIFLE().NGDPNIFFHKL() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
		{
			BKACANFNHMH(DNLMCHDOMOK.DMOPFIPHDFG());
			MOPPLOJNKKF(1150f);
		}
		else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			BKDLIMOMKEB(phaseItemInstance.EBNEBGBCGKH().phasesIcons[phaseItemInstance.COIIFONCADH()]);
		}
		else if ((Object)(object)DNLMCHDOMOK.LHBPOPOIFLE().icon != (Object)null)
		{
			FBJKMPKINBB(DNLMCHDOMOK.DMOPFIPHDFG());
			LBKBMNMIBPB(256f);
		}
		else
		{
			BKDLIMOMKEB(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
			MOPPLOJNKKF(1968f);
		}
	}

	[SpecialName]
	public void AKAOHLPIGAG(ItemInstance AODONKKHPBP)
	{
		if (!updateIcon)
		{
			return;
		}
		DNLMCHDOMOK = AODONKKHPBP;
		if (DNLMCHDOMOK == null)
		{
			FBJKMPKINBB(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
		}
		else if (orderQuest)
		{
			CIDGNCHMDGC(DNLMCHDOMOK.AAGOCCCEKMH());
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				CIDGNCHMDGC(ingredientGroupInstance.chosenItemInstance.AAGOCCCEKMH());
				JEOFNNMEFFJ(1733f);
			}
			else
			{
				BKACANFNHMH(ingredientGroupInstance.DMOPFIPHDFG());
				DABGJHGEFKG(412f);
			}
		}
		else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.AFOACBIHNCL().JGJLNHAKJIJ() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.OANEHEHELGB().variantIcon != (Object)null && !hasMod)
		{
			BKACANFNHMH(foodInstance.AJOMICMACEJ.variantIcon);
			LBKBMNMIBPB(954f);
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK.KNFNJFFCFNO().JGJLNHAKJIJ() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
		{
			JKDAHFEIJHA(DNLMCHDOMOK.AAGOCCCEKMH());
			ABLEBCIKMFB(212f);
		}
		else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			BKACANFNHMH(phaseItemInstance.JCBBMDCFDLC().phasesIcons[phaseItemInstance.COIIFONCADH()]);
		}
		else if ((Object)(object)DNLMCHDOMOK.KNFNJFFCFNO().icon != (Object)null)
		{
			LCNODFNIGKM(DNLMCHDOMOK.AAGOCCCEKMH());
			ABLEBCIKMFB(323f);
		}
		else
		{
			IEGBEHMDAEL(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
			SetColorAlpha(155f);
		}
	}

	public void LCNODFNIGKM(Sprite HEJNLFCKOKE)
	{
		if (Object.op_Implicit((Object)(object)CBLIMFIHFPK()))
		{
			MPDDAEMEBHE().sprite = HEJNLFCKOKE;
			if (!((Component)CPDIGMNIJNP()).gameObject.activeSelf)
			{
				((Component)LIDDNCFFMAH()).gameObject.SetActive(false);
			}
		}
		else if (Object.op_Implicit((Object)(object)PNHFAFPPBBF()))
		{
			EDCJOEBJNKL.sprite = HEJNLFCKOKE;
			if (!((Component)PNHFAFPPBBF()).gameObject.activeSelf)
			{
				((Component)EEHPGEHOMPK()).gameObject.SetActive(true);
			}
		}
	}

	[SpecialName]
	public void KOEPPODAGOG(ItemInstance AODONKKHPBP)
	{
		if (!updateIcon)
		{
			return;
		}
		DNLMCHDOMOK = AODONKKHPBP;
		if (DNLMCHDOMOK == null)
		{
			LGNJJCPLNEE(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
		}
		else if (orderQuest)
		{
			SetSprite(DNLMCHDOMOK.AAGOCCCEKMH());
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				LCNODFNIGKM(ingredientGroupInstance.chosenItemInstance.DMOPFIPHDFG());
				OBOIFAFELPF(76f);
			}
			else
			{
				BKDLIMOMKEB(ingredientGroupInstance.AAGOCCCEKMH());
				SetColorAlpha(314f);
			}
		}
		else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.PHGLMBIEOMK().NGDPNIFFHKL() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.AJOMICMACEJ.variantIcon != (Object)null && !hasMod)
		{
			PCBMOCKFEHI(foodInstance.AJOMICMACEJ.variantIcon);
			IIBMGMLOCGN(394f);
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK.KNFNJFFCFNO().IABMOBAKNAE() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
		{
			PCBMOCKFEHI(DNLMCHDOMOK.DMOPFIPHDFG());
			IIBMGMLOCGN(948f);
		}
		else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			CIDGNCHMDGC(phaseItemInstance.LHBPOPOIFLE().phasesIcons[phaseItemInstance.HJJLHJLHJLF()]);
		}
		else if ((Object)(object)DNLMCHDOMOK.LHBPOPOIFLE().icon != (Object)null)
		{
			CIDGNCHMDGC(DNLMCHDOMOK.DMOPFIPHDFG());
			MOPPLOJNKKF(64f);
		}
		else
		{
			LGNJJCPLNEE(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
			IIBMGMLOCGN(1319f);
		}
	}

	public void IEGBEHMDAEL(Sprite HEJNLFCKOKE)
	{
		if (Object.op_Implicit((Object)(object)LIDDNCFFMAH()))
		{
			LIDDNCFFMAH().sprite = HEJNLFCKOKE;
			if (!((Component)FEBOLMCLMND()).gameObject.activeSelf)
			{
				((Component)GPPNJONDGLI()).gameObject.SetActive(true);
			}
		}
		else if (Object.op_Implicit((Object)(object)EDCJOEBJNKL))
		{
			PKBHFEJGJPM().sprite = HEJNLFCKOKE;
			if (!((Component)AHAEJBAFIOJ()).gameObject.activeSelf)
			{
				((Component)GOENCAOMIFA()).gameObject.SetActive(false);
			}
		}
	}

	[SpecialName]
	private SpriteRenderer CBLIMFIHFPK()
	{
		if ((Object)(object)EJCLCAPCCDN == (Object)null)
		{
			EJCLCAPCCDN = ((Component)this).GetComponent<SpriteRenderer>();
		}
		return EJCLCAPCCDN;
	}

	public void CHIADEKJJMH(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)LIDDNCFFMAH()))
		{
			OGCCPADFKEF().color = FLABEDBELMF;
		}
		else if (Object.op_Implicit((Object)(object)EEHPGEHOMPK()))
		{
			((Graphic)PKBHFEJGJPM()).color = FLABEDBELMF;
		}
	}

	public Color NHDCKIBCGPG()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)LIDDNCFFMAH()))
		{
			return FEBOLMCLMND().color;
		}
		if (Object.op_Implicit((Object)(object)EEHPGEHOMPK()))
		{
			return ((Graphic)PKBHFEJGJPM()).color;
		}
		return Color.white;
	}

	[SpecialName]
	public void OCAEPIHEPEC(ItemInstance AODONKKHPBP)
	{
		if (!updateIcon)
		{
			return;
		}
		DNLMCHDOMOK = AODONKKHPBP;
		if (DNLMCHDOMOK == null)
		{
			FBJKMPKINBB(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
		}
		else if (orderQuest)
		{
			LGNJJCPLNEE(DNLMCHDOMOK.DMOPFIPHDFG());
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				SetSprite(ingredientGroupInstance.chosenItemInstance.AAGOCCCEKMH());
				OAEPLIHGJFA(973f);
			}
			else
			{
				BKACANFNHMH(ingredientGroupInstance.DMOPFIPHDFG());
				LBKBMNMIBPB(985f);
			}
		}
		else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.KNFNJFFCFNO().JGJLNHAKJIJ() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.AJOMICMACEJ.variantIcon != (Object)null && !hasMod)
		{
			LCNODFNIGKM(foodInstance.PJNBDKNJLJD().variantIcon);
			ABLEBCIKMFB(1696f);
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK.KNFNJFFCFNO().AGFIIGGGBHC() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
		{
			IEGBEHMDAEL(DNLMCHDOMOK.DMOPFIPHDFG());
			GDHNCPHGIPB(882f);
		}
		else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			PCBMOCKFEHI(phaseItemInstance.EBNEBGBCGKH().phasesIcons[phaseItemInstance.MJPOLEMIJLH()]);
		}
		else if ((Object)(object)DNLMCHDOMOK.PHGLMBIEOMK().icon != (Object)null)
		{
			LCNODFNIGKM(DNLMCHDOMOK.AAGOCCCEKMH());
			OBOIFAFELPF(1698f);
		}
		else
		{
			LCNODFNIGKM(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
			OBOIFAFELPF(1123f);
		}
	}

	[SpecialName]
	private Image PKBHFEJGJPM()
	{
		if ((Object)(object)MBCLDDLDDAC == (Object)null)
		{
			MBCLDDLDDAC = ((Component)this).GetComponent<Image>();
		}
		return MBCLDDLDDAC;
	}

	[SpecialName]
	public void COHJINBDLLO(ItemInstance AODONKKHPBP)
	{
		if (!updateIcon)
		{
			return;
		}
		DNLMCHDOMOK = AODONKKHPBP;
		if (DNLMCHDOMOK == null)
		{
			LCNODFNIGKM(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
		}
		else if (orderQuest)
		{
			BKACANFNHMH(DNLMCHDOMOK.DMOPFIPHDFG());
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				IEGBEHMDAEL(ingredientGroupInstance.chosenItemInstance.DMOPFIPHDFG());
				JEOFNNMEFFJ(1227f);
			}
			else
			{
				LGNJJCPLNEE(ingredientGroupInstance.DMOPFIPHDFG());
				GDHNCPHGIPB(432f);
			}
		}
		else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.PHGLMBIEOMK().NGDPNIFFHKL() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.AJOMICMACEJ.variantIcon != (Object)null && !hasMod)
		{
			FBJKMPKINBB(foodInstance.AJOMICMACEJ.variantIcon);
			MOPPLOJNKKF(1101f);
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK.AFOACBIHNCL().IABMOBAKNAE() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
		{
			LGNJJCPLNEE(DNLMCHDOMOK.DMOPFIPHDFG());
			OBOIFAFELPF(1425f);
		}
		else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			LCNODFNIGKM(phaseItemInstance.CKJJENMMHAL().phasesIcons[phaseItemInstance.BDAKJBMGIMO]);
		}
		else if ((Object)(object)DNLMCHDOMOK.KNFNJFFCFNO().icon != (Object)null)
		{
			CIDGNCHMDGC(DNLMCHDOMOK.AAGOCCCEKMH());
			LBKBMNMIBPB(1769f);
		}
		else
		{
			JKDAHFEIJHA(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
			GDHNCPHGIPB(1604f);
		}
	}

	public Color CMJNGNBOGJN()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)LIDDNCFFMAH()))
		{
			return OGCCPADFKEF().color;
		}
		if (Object.op_Implicit((Object)(object)EEHPGEHOMPK()))
		{
			return ((Graphic)DKEAAGNIJNE()).color;
		}
		return Color.white;
	}

	public void SetColor(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GAIBKADPNNI))
		{
			GAIBKADPNNI.color = FLABEDBELMF;
		}
		else if (Object.op_Implicit((Object)(object)EDCJOEBJNKL))
		{
			((Graphic)EDCJOEBJNKL).color = FLABEDBELMF;
		}
	}

	public Color OBPKCHGHPOK()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)LIDDNCFFMAH()))
		{
			return OGCCPADFKEF().color;
		}
		if (Object.op_Implicit((Object)(object)PKBHFEJGJPM()))
		{
			return ((Graphic)DKEAAGNIJNE()).color;
		}
		return Color.white;
	}

	[SpecialName]
	private Image DKEAAGNIJNE()
	{
		if ((Object)(object)MBCLDDLDDAC == (Object)null)
		{
			MBCLDDLDDAC = ((Component)this).GetComponent<Image>();
		}
		return MBCLDDLDDAC;
	}

	public void BKDLIMOMKEB(Sprite HEJNLFCKOKE)
	{
		if (Object.op_Implicit((Object)(object)CBLIMFIHFPK()))
		{
			CBLIMFIHFPK().sprite = HEJNLFCKOKE;
			if (!((Component)CBLIMFIHFPK()).gameObject.activeSelf)
			{
				((Component)GAIBKADPNNI).gameObject.SetActive(false);
			}
		}
		else if (Object.op_Implicit((Object)(object)PKBHFEJGJPM()))
		{
			PNHFAFPPBBF().sprite = HEJNLFCKOKE;
			if (!((Component)PKBHFEJGJPM()).gameObject.activeSelf)
			{
				((Component)PNHFAFPPBBF()).gameObject.SetActive(false);
			}
		}
	}

	public void DABGJHGEFKG(float GODBHHOFBMJ)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GAIBKADPNNI))
		{
			FEBOLMCLMND().color = new Color(LIDDNCFFMAH().color.r, GPPNJONDGLI().color.g, OGCCPADFKEF().color.b, GODBHHOFBMJ);
		}
		else if (Object.op_Implicit((Object)(object)DKEAAGNIJNE()))
		{
			((Graphic)GOENCAOMIFA()).color = new Color(((Graphic)GOENCAOMIFA()).color.r, ((Graphic)PKBHFEJGJPM()).color.g, ((Graphic)EEHPGEHOMPK()).color.b, GODBHHOFBMJ);
		}
	}

	public void IEHHJBAGLMO(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)FEBOLMCLMND()))
		{
			GAIBKADPNNI.color = FLABEDBELMF;
		}
		else if (Object.op_Implicit((Object)(object)EDCJOEBJNKL))
		{
			((Graphic)EEHPGEHOMPK()).color = FLABEDBELMF;
		}
	}

	public void GDHNCPHGIPB(float GODBHHOFBMJ)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)LIDDNCFFMAH()))
		{
			GPPNJONDGLI().color = new Color(FEBOLMCLMND().color.r, GAIBKADPNNI.color.g, LIDDNCFFMAH().color.b, GODBHHOFBMJ);
		}
		else if (Object.op_Implicit((Object)(object)PNHFAFPPBBF()))
		{
			((Graphic)EEHPGEHOMPK()).color = new Color(((Graphic)GOENCAOMIFA()).color.r, ((Graphic)AHAEJBAFIOJ()).color.g, ((Graphic)PNHFAFPPBBF()).color.b, GODBHHOFBMJ);
		}
	}

	[SpecialName]
	public ItemInstance EGLLPMLAHCB()
	{
		return DNLMCHDOMOK;
	}

	public Color IIIDGNDFEJP()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)CBLIMFIHFPK()))
		{
			return CPDIGMNIJNP().color;
		}
		if (Object.op_Implicit((Object)(object)PNHFAFPPBBF()))
		{
			return ((Graphic)DKEAAGNIJNE()).color;
		}
		return Color.white;
	}

	[SpecialName]
	public void IMJDEBOJJFH(ItemInstance AODONKKHPBP)
	{
		if (!updateIcon)
		{
			return;
		}
		DNLMCHDOMOK = AODONKKHPBP;
		if (DNLMCHDOMOK == null)
		{
			LCNODFNIGKM(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
		}
		else if (orderQuest)
		{
			FBJKMPKINBB(DNLMCHDOMOK.DMOPFIPHDFG());
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				IEGBEHMDAEL(ingredientGroupInstance.chosenItemInstance.DMOPFIPHDFG());
				JEOFNNMEFFJ(1467f);
			}
			else
			{
				FBJKMPKINBB(ingredientGroupInstance.AAGOCCCEKMH());
				MOPPLOJNKKF(1504f);
			}
		}
		else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.LHBPOPOIFLE().NGDPNIFFHKL() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.PJNBDKNJLJD().variantIcon != (Object)null && !hasMod)
		{
			LGNJJCPLNEE(foodInstance.OANEHEHELGB().variantIcon);
			OBOIFAFELPF(1038f);
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK.LHBPOPOIFLE().NGDPNIFFHKL() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
		{
			SetSprite(DNLMCHDOMOK.DMOPFIPHDFG());
			MOPPLOJNKKF(989f);
		}
		else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			SetSprite(phaseItemInstance.LHBPOPOIFLE().phasesIcons[phaseItemInstance.MJPOLEMIJLH()]);
		}
		else if ((Object)(object)DNLMCHDOMOK.KNFNJFFCFNO().icon != (Object)null)
		{
			SetSprite(DNLMCHDOMOK.DMOPFIPHDFG());
			ABLEBCIKMFB(439f);
		}
		else
		{
			BKDLIMOMKEB(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
			GDHNCPHGIPB(1352f);
		}
	}

	public void JEOFNNMEFFJ(float GODBHHOFBMJ)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)FEBOLMCLMND()))
		{
			GAIBKADPNNI.color = new Color(FEBOLMCLMND().color.r, FEBOLMCLMND().color.g, LIDDNCFFMAH().color.b, GODBHHOFBMJ);
		}
		else if (Object.op_Implicit((Object)(object)AHAEJBAFIOJ()))
		{
			((Graphic)EEHPGEHOMPK()).color = new Color(((Graphic)EEHPGEHOMPK()).color.r, ((Graphic)EDCJOEBJNKL).color.g, ((Graphic)PNHFAFPPBBF()).color.b, GODBHHOFBMJ);
		}
	}

	[SpecialName]
	public void GHBHOGNGLNP(ItemInstance AODONKKHPBP)
	{
		if (!updateIcon)
		{
			return;
		}
		DNLMCHDOMOK = AODONKKHPBP;
		if (DNLMCHDOMOK == null)
		{
			IEGBEHMDAEL(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
		}
		else if (orderQuest)
		{
			BKDLIMOMKEB(DNLMCHDOMOK.DMOPFIPHDFG());
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				BKDLIMOMKEB(ingredientGroupInstance.chosenItemInstance.DMOPFIPHDFG());
				MOPPLOJNKKF(591f);
			}
			else
			{
				PCBMOCKFEHI(ingredientGroupInstance.DMOPFIPHDFG());
				IIBMGMLOCGN(614f);
			}
		}
		else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.AFOACBIHNCL().NGDPNIFFHKL() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.OANEHEHELGB().variantIcon != (Object)null && !hasMod)
		{
			LGNJJCPLNEE(foodInstance.AJOMICMACEJ.variantIcon);
			JEOFNNMEFFJ(919f);
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK.PHGLMBIEOMK().IABMOBAKNAE() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
		{
			BKDLIMOMKEB(DNLMCHDOMOK.DMOPFIPHDFG());
			ABLEBCIKMFB(1212f);
		}
		else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			LGNJJCPLNEE(phaseItemInstance.JCBBMDCFDLC().phasesIcons[phaseItemInstance.COIIFONCADH()]);
		}
		else if ((Object)(object)DNLMCHDOMOK.PHGLMBIEOMK().icon != (Object)null)
		{
			LGNJJCPLNEE(DNLMCHDOMOK.DMOPFIPHDFG());
			IIBMGMLOCGN(1155f);
		}
		else
		{
			SetSprite(CommonReferences.MNFMOEKMJKN().defaultBagIcon);
			OAEPLIHGJFA(38f);
		}
	}

	public void OHGKPLKPOKM(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)CBLIMFIHFPK()))
		{
			MPDDAEMEBHE().color = FLABEDBELMF;
		}
		else if (Object.op_Implicit((Object)(object)EEHPGEHOMPK()))
		{
			((Graphic)DKEAAGNIJNE()).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public void NDACODOJPPA(ItemInstance AODONKKHPBP)
	{
		if (!updateIcon)
		{
			return;
		}
		DNLMCHDOMOK = AODONKKHPBP;
		if (DNLMCHDOMOK == null)
		{
			LGNJJCPLNEE(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
		}
		else if (orderQuest)
		{
			SetSprite(DNLMCHDOMOK.DMOPFIPHDFG());
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				LGNJJCPLNEE(ingredientGroupInstance.chosenItemInstance.AAGOCCCEKMH());
				IIBMGMLOCGN(1571f);
			}
			else
			{
				FBJKMPKINBB(ingredientGroupInstance.AAGOCCCEKMH());
				JEOFNNMEFFJ(322f);
			}
		}
		else if (!alwaysMaxAlpha && showVariantIcon && DNLMCHDOMOK.LHBPOPOIFLE().JGJLNHAKJIJ() && DNLMCHDOMOK is FoodInstance foodInstance && (Object)(object)foodInstance.OANEHEHELGB().variantIcon != (Object)null && !hasMod)
		{
			CIDGNCHMDGC(foodInstance.PJNBDKNJLJD().variantIcon);
			LBKBMNMIBPB(1038f);
		}
		else if (!alwaysMaxAlpha && DNLMCHDOMOK.PHGLMBIEOMK().IABMOBAKNAE() && (!(DNLMCHDOMOK is FoodInstance { KEKBKGGFOLK: not null } foodInstance2) || foodInstance2.KEKBKGGFOLK.Count == 0))
		{
			CIDGNCHMDGC(DNLMCHDOMOK.AAGOCCCEKMH());
			OAEPLIHGJFA(1882f);
		}
		else if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			FBJKMPKINBB(phaseItemInstance.OGHIHPFIFLC().phasesIcons[phaseItemInstance.BDAKJBMGIMO]);
		}
		else if ((Object)(object)DNLMCHDOMOK.PHGLMBIEOMK().icon != (Object)null)
		{
			PCBMOCKFEHI(DNLMCHDOMOK.AAGOCCCEKMH());
			OAEPLIHGJFA(1983f);
		}
		else
		{
			LGNJJCPLNEE(CommonReferences.GGFJGHHHEJC.defaultBagIcon);
			SetColorAlpha(298f);
		}
	}

	public void MCPLANAPGEE(Color FLABEDBELMF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GAIBKADPNNI))
		{
			OGCCPADFKEF().color = FLABEDBELMF;
		}
		else if (Object.op_Implicit((Object)(object)GOENCAOMIFA()))
		{
			((Graphic)AHAEJBAFIOJ()).color = FLABEDBELMF;
		}
	}
}
