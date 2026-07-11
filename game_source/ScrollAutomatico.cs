using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

public class ScrollAutomatico : MonoBehaviour
{
	public UIWindow uIWindow;

	private int JIIGOACEIKL = 1;

	public bool vertical = true;

	public Scrollbar barra;

	public RectTransform contingut;

	public RectTransform viewport;

	public bool cogerPadreDelContenido;

	public bool sumarExtraParaCuadrarArriba;

	public bool forceScrollToTop;

	public int offset;

	private int GFMHOCMEFLH;

	private int HPOFHLGABIN;

	[SerializeField]
	private VerticalLayoutGroup contingutVerticalLayout;

	[SerializeField]
	private HorizontalLayoutGroup contingutHorizontalLayout;

	[SerializeField]
	private GridLayoutGroup contingutGridLayout;

	private GameObject IFNANNLHCMO;

	private RectTransform IAIPKBFFJFG;

	private bool PCJNPLHEJGO
	{
		get
		{
			if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
			{
				return (Object)(object)contingutGridLayout != (Object)null;
			}
			return true;
		}
	}

	private void LMFICKFGEFI()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).HGNKFFMDOOL) && ((Component)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).HGNKFFMDOOL).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 1) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))))
		{
			DPPKEFLFOBF();
		}
	}

	private void OJIGLLGCPMJ()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).KBFCCPBHDMP()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).CGCIFFOJGOK()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).PBGKEEENPME()).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 2) : HPOFHLGABIN) < 1)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(230f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(297f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).PBGKEEENPME()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 272f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 7) : HPOFHLGABIN) < 1)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 71f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 227f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 1922f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 274f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 1010f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).HGNKFFMDOOL).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1065f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void ACPFEBOENOM()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).PBGKEEENPME()) && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).PBGKEEENPME()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 7) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))))
		{
			KHPDKMLDENE();
		}
	}

	private void BDGCFCPFKKE()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!DDCGDMFCNKO())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!KEKAJADCHML())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Cheer")) ? 1 : 0);
	}

	private void EBNKNEIDDDI()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!LOPCFOGDBOC())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!ANHFBBBOPIG())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("quest_reward_27_28_29")) ? 2 : 0);
	}

	private void CNBLOMJJECI()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).KBFCCPBHDMP()) && ((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).BCHJGDHJHJK()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 7) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))))
		{
			DBNJNIGACAO();
		}
	}

	private void FHEGBNMJADG()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!NKGBEBDEOCA())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!NOPKKMJLGCN())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" at ")) ? 1 : 6);
	}

	[SpecialName]
	private bool NEGMLAPCGJC()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return false;
	}

	[SpecialName]
	private bool CEDMNJJKADN()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return false;
	}

	private void BHLHCOALABE()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(JIIGOACEIKL).HGNKFFMDOOL) && ((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).MGOEJJIMAIP()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 1) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))))
		{
			OJIGLLGCPMJ();
		}
	}

	private void BHKNJOEBCKA()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(JIIGOACEIKL).KBFCCPBHDMP()) && ((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).KBFCCPBHDMP()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 0) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))))
		{
			PENIBJAOIMF();
		}
	}

	private void MCLAJGDIIBK()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).BEOANCLEPOO()) && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).OFCEDMBCBBH()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 5) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))))
		{
			DPPKEFLFOBF();
		}
	}

	private void DJADNFCFHAG()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!PCJNPLHEJGO)
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!PMOIFMFCJDD())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("MenuMode")) ? 6 : 0);
	}

	private void CAIJLMJBMLA()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!HEMMMEEDDMP())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!NEGMLAPCGJC())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("[ActivateVariantObjects] - VariantObjects: {0} AltarId: {1}")) ? 1 : 0);
	}

	private void NPMLFHDHJBE()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!BHKNIMLPHNH())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!NBFJDKDBNBD())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("[ProceduralMine] ALTAR: No valid piece for path dir={0} at block {1}. Candidates: {2}. Retrying next iteration.")) ? 4 : 0);
	}

	[SpecialName]
	private bool MICDOPEMFCB()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return true;
	}

	private void LFNENELHOGJ()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!KEKAJADCHML())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!IHCGGIIGCMM())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Message is too long to send.")) ? 1 : 2);
	}

	private void DBNJNIGACAO()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).BCHJGDHJHJK()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).FOKMCIDMIKF()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).KDJFBLKPFKM()).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 5) : HPOFHLGABIN) < 1)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(1920f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(512f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).BEOANCLEPOO()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1521f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 8) : HPOFHLGABIN) < 0)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 1642f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 1598f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 436f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 1073f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 461f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).KDJFBLKPFKM()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 598f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void DOJGPCIFKHM()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).OFCEDMBCBBH()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).CGCIFFOJGOK()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).KDJFBLKPFKM()).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 0) : HPOFHLGABIN) < 0)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(1945f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(1255f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).BOHHKGMEEEE()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 991f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 7) : HPOFHLGABIN) < 1)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 109f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 7f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 1885f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 1037f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 1151f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).BOHHKGMEEEE()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1552f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void MFMMHDPGCBO()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!MIKDINJIHFO())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!GLLJPCEACMN())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Hay {0} destructibles y {1} agujeros para cavar disponibles para el puzzle {2}")) ? 1 : 8);
	}

	[SpecialName]
	private bool GLLJPCEACMN()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return true;
	}

	private void GNMMELIJKML()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!CEDMNJJKADN())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!GNICOKHHKOP())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Sprinting is now FASTER.")) ? 2 : 0);
	}

	[SpecialName]
	private bool BHKNIMLPHNH()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return true;
	}

	[SpecialName]
	private bool MODDJAKJBKK()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return false;
	}

	private void LMEJFGKCHEF()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).MGOEJJIMAIP()) && ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).PBGKEEENPME()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 0) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))))
		{
			KHPDKMLDENE();
		}
	}

	private void HIPNEFOEJPL()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(JIIGOACEIKL).OFCEDMBCBBH()) && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).FOKMCIDMIKF()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 2) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))))
		{
			HJNCELKPDGN();
		}
	}

	private void MCPBFAAGOBA()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).HGNKFFMDOOL).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).HGNKFFMDOOL).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).CGCIFFOJGOK()).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 8) : HPOFHLGABIN) < 1)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(255f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(1277f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).BEOANCLEPOO()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 455f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 0) : HPOFHLGABIN) < 0)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 1519f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 1959f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 895f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 575f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 1199f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).BOHHKGMEEEE()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 56f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void HBMDEHPHAPF()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!IBAFLEGFGAG())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!GADDKCCBKKB())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("On Simple Event ")) ? 1 : 6);
	}

	private void HONFDJKKGJK()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).BCHJGDHJHJK()) && ((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).KBFCCPBHDMP()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 1) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))))
		{
			OLAKIACJGGN();
		}
	}

	private void KMGOHMOGHJH()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).PBGKEEENPME()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).BEOANCLEPOO()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).HGNKFFMDOOL).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 0) : HPOFHLGABIN) < 1)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(1932f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(602f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).OFCEDMBCBBH()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1715f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 6) : HPOFHLGABIN) < 0)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 286f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 1838f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 326f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 1704f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 1870f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).OFCEDMBCBBH()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1010f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void Update()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(JIIGOACEIKL).HGNKFFMDOOL) && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).HGNKFFMDOOL).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 2) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.IsGamepadActive(JIIGOACEIKL))))
		{
			PENIBJAOIMF();
		}
	}

	[SpecialName]
	private bool DDCGDMFCNKO()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return true;
	}

	private void CNJMEALOCJJ()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).OFCEDMBCBBH()) && ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).BOHHKGMEEEE()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 6) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))))
		{
			KMDAHGPNBHA();
		}
	}

	[SpecialName]
	private bool ANHFBBBOPIG()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return true;
	}

	private void ICMNODPLPBK()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).KDJFBLKPFKM()) && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).KDJFBLKPFKM()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 2) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))))
		{
			HJNCELKPDGN();
		}
	}

	private void HCEDMLJNOBL()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!DDCGDMFCNKO())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!IHCGGIIGCMM())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI")) ? 1 : 6);
	}

	[SpecialName]
	private bool HEMMMEEDDMP()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return true;
	}

	private void CAOKPIIFHBJ()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!PMOIFMFCJDD())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!NBFJDKDBNBD())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("OpenXPModifiers")) ? 6 : 0);
	}

	[SpecialName]
	private bool KEKAJADCHML()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return false;
	}

	private void HELHNJDFPPF()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!PMOIFMFCJDD())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!LOPCFOGDBOC())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("ErrorJoinDefault")) ? 1 : 8);
	}

	private void PDKEPCIEHEP()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).BEOANCLEPOO()) && ((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).HGNKFFMDOOL).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 7) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))))
		{
			MCAFHCGADHE();
		}
	}

	private void OLAKIACJGGN()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).PBGKEEENPME()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).MGOEJJIMAIP()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).HGNKFFMDOOL).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 3) : HPOFHLGABIN) < 1)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(1636f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(413f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).BEOANCLEPOO()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1855f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 1) : HPOFHLGABIN) < 0)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 1558f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 1354f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 778f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 1899f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 337f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).KDJFBLKPFKM()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 196f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void EBNJADODONG()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).PBGKEEENPME()) && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).CGCIFFOJGOK()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 6) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))))
		{
			GAACDMJEOAP();
		}
	}

	private void PNPAADMIDKI()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).OFCEDMBCBBH()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).OFCEDMBCBBH()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).KDJFBLKPFKM()).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 3) : HPOFHLGABIN) < 1)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(86f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(141f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).PBGKEEENPME()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 748f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 2) : HPOFHLGABIN) < 1)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 1083f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 1852f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 100f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 1747f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 1079f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).KBFCCPBHDMP()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1284f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void HCPKBJDHLAC()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).BCHJGDHJHJK()) && ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).FOKMCIDMIKF()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 8) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.IsGamepadActive(JIIGOACEIKL))))
		{
			AMOMFGIPEPI();
		}
	}

	private void JLCFNPBBKEK()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!PMOIFMFCJDD())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!PMOIFMFCJDD())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Create Public Room")) ? 2 : 0);
	}

	private void NEPDNLPCCON()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).BCHJGDHJHJK()) && ((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).BCHJGDHJHJK()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 3) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))))
		{
			KHPDKMLDENE();
		}
	}

	private void BNIKICAEIND()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!IBAFLEGFGAG())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!ANHFBBBOPIG())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Items/item_name_666")) ? 3 : 0);
	}

	private void OHGABHEDILE()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).OFCEDMBCBBH()) && ((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).KDJFBLKPFKM()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 0) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))))
		{
			PNPAADMIDKI();
		}
	}

	private void GHEHLJANBCF()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(JIIGOACEIKL).KDJFBLKPFKM()) && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).KBFCCPBHDMP()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 5) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))))
		{
			DOJGPCIFKHM();
		}
	}

	private void NIHJCJJKDBA()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).MGOEJJIMAIP()) && ((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).PBGKEEENPME()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 8) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))))
		{
			PNPAADMIDKI();
		}
	}

	private void PENIBJAOIMF()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).HGNKFFMDOOL).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).HGNKFFMDOOL).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).HGNKFFMDOOL).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 2) : HPOFHLGABIN) < 0)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(0f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(0f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).HGNKFFMDOOL).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 2) : HPOFHLGABIN) < 0)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 0f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 0.66f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 0f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 0.33f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 0f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).HGNKFFMDOOL).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void DJHDBLJMJPB()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).HGNKFFMDOOL).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).MGOEJJIMAIP()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).HGNKFFMDOOL).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 2) : HPOFHLGABIN) < 1)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(1584f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(454f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).HGNKFFMDOOL).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1121f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 5) : HPOFHLGABIN) < 0)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 604f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 953f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 1904f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 674f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 1656f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).BCHJGDHJHJK()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 481f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void OILHJENGGEL()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!EMNKKNPNMND())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!PMOIFMFCJDD())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("ChatCommandLockDescription")) ? 1 : 1);
	}

	private void LEDIGKGAFHC()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(JIIGOACEIKL).KBFCCPBHDMP()) && ((Component)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).PBGKEEENPME()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 7) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.IsGamepadActive(JIIGOACEIKL))))
		{
			HJNCELKPDGN();
		}
	}

	private void HJNCELKPDGN()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).FOKMCIDMIKF()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).BOHHKGMEEEE()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).MGOEJJIMAIP()).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 0) : HPOFHLGABIN) < 1)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(635f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(1005f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).KBFCCPBHDMP()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 113f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 7) : HPOFHLGABIN) < 1)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 321f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 860f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 1440f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 264f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 572f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).OFCEDMBCBBH()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1850f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void JPOLFKMLHNH()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!BHKNIMLPHNH())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!HEMMMEEDDMP())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("NeutralInTavern")) ? 3 : 0);
	}

	private void MNFJELNEGPG()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).HGNKFFMDOOL) && ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).OFCEDMBCBBH()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 5) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.IsGamepadActive(JIIGOACEIKL))))
		{
			PNPAADMIDKI();
		}
	}

	private void BDJKNKIOPIJ()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!IHCGGIIGCMM())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!NEGMLAPCGJC())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Information")) ? 1 : 6);
	}

	private void OLDDEAJMHNI()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!COENKJNJMAB())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!NBFJDKDBNBD())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(". ")) ? 4 : 0);
	}

	[SpecialName]
	private bool IHCGGIIGCMM()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return false;
	}

	[SpecialName]
	private bool EMNKKNPNMND()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return false;
	}

	[SpecialName]
	private bool PMOIFMFCJDD()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return true;
	}

	private void KMDAHGPNBHA()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).CGCIFFOJGOK()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).PBGKEEENPME()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).FOKMCIDMIKF()).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 3) : HPOFHLGABIN) < 1)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(1882f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(375f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).CGCIFFOJGOK()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1905f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 0) : HPOFHLGABIN) < 0)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 206f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 942f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 649f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 490f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 1777f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).BCHJGDHJHJK()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1639f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	[SpecialName]
	private bool JCBFBNGGODM()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return false;
	}

	[SpecialName]
	private bool IBAFLEGFGAG()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return false;
	}

	[SpecialName]
	private bool NBFJDKDBNBD()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return false;
	}

	private void MLBELDAIJHB()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).KBFCCPBHDMP()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).OFCEDMBCBBH()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).HGNKFFMDOOL).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 8) : HPOFHLGABIN) < 0)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(1627f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(1719f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).KDJFBLKPFKM()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 119f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 7) : HPOFHLGABIN) < 0)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 1668f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 1726f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 830f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 1432f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 117f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).BCHJGDHJHJK()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1518f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void GAACDMJEOAP()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).BEOANCLEPOO()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).BCHJGDHJHJK()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).FOKMCIDMIKF()).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 1) : HPOFHLGABIN) < 0)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(1303f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(1320f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).KDJFBLKPFKM()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1563f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 3) : HPOFHLGABIN) < 1)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 700f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 278f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 1794f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 543f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 1491f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).MGOEJJIMAIP()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 61f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void DPPKEFLFOBF()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).CGCIFFOJGOK()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).CGCIFFOJGOK()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).MGOEJJIMAIP()).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 8) : HPOFHLGABIN) < 1)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(1626f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(1718f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).FOKMCIDMIKF()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1910f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 6) : HPOFHLGABIN) < 1)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 1385f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 1830f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 1671f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 1294f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 1307f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).FOKMCIDMIKF()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1102f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void HKKDEKIFPPJ()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!NOPKKMJLGCN())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!IBAFLEGFGAG())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Sleep")) ? 1 : 0);
	}

	private void GBFPCABGAII()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!PDIFBCFPONB())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!PCJNPLHEJGO)
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("SetSnapshot Location: ")) ? 1 : 6);
	}

	private void Start()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!PCJNPLHEJGO)
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!PCJNPLHEJGO)
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	private void AMOMFGIPEPI()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).KDJFBLKPFKM()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).KDJFBLKPFKM()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).HGNKFFMDOOL).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 1) : HPOFHLGABIN) < 0)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(1122f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(1840f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).PBGKEEENPME()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 822f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 2) : HPOFHLGABIN) < 0)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 584f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 823f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 1788f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 511f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 1153f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).OFCEDMBCBBH()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 225f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void CKCHKHNBBFG()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).HGNKFFMDOOL) && ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).KDJFBLKPFKM()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 2) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.IsGamepadActive(JIIGOACEIKL))))
		{
			HJNCELKPDGN();
		}
	}

	private void DLNOLBHCIGC()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).BOHHKGMEEEE()) && ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).BOHHKGMEEEE()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 0) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))))
		{
			MOIDMFHMMOL();
		}
	}

	private void MCAFHCGADHE()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).CGCIFFOJGOK()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).CGCIFFOJGOK()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).OFCEDMBCBBH()).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 3) : HPOFHLGABIN) < 1)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(862f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(116f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).KBFCCPBHDMP()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1596f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 5) : HPOFHLGABIN) < 1)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 1848f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 1321f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 1234f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 1272f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 775f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).HGNKFFMDOOL).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1663f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void MMPMJNAFKHC()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).CGCIFFOJGOK()) && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).BOHHKGMEEEE()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 0) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))))
		{
			KHPDKMLDENE();
		}
	}

	private void AAPIHKGLKGL()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).OFCEDMBCBBH()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).PBGKEEENPME()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).FOKMCIDMIKF()).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 7) : HPOFHLGABIN) < 0)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(1074f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(1120f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).FOKMCIDMIKF()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1590f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 2) : HPOFHLGABIN) < 0)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 1499f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 1823f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 1918f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 158f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 738f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).BOHHKGMEEEE()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 14f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void OGNIDHAIABM()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(JIIGOACEIKL).PBGKEEENPME()) && ((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).OFCEDMBCBBH()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 5) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))))
		{
			PENIBJAOIMF();
		}
	}

	private void HOKBBFHGACN()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!JCBFBNGGODM())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!MIKDINJIHFO())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Feed")) ? 1 : 4);
	}

	private void NJNCKELODLF()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).FOKMCIDMIKF()) && ((Component)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).KBFCCPBHDMP()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 8) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))))
		{
			GAACDMJEOAP();
		}
	}

	[SpecialName]
	private bool NKGBEBDEOCA()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return true;
	}

	private void CMJPIAAGIFF()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).OFCEDMBCBBH()) && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).KBFCCPBHDMP()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 2) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))))
		{
			AAPIHKGLKGL();
		}
	}

	[SpecialName]
	private bool GNICOKHHKOP()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return false;
	}

	private void KFBOPABEJNL()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).BOHHKGMEEEE()) && ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).BOHHKGMEEEE()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 5) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))))
		{
			DJHDBLJMJPB();
		}
	}

	private void HFFFFAJFIPB()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!PMOIFMFCJDD())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!PDIFBCFPONB())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("ReceiveNinjaChallengeEventStartMinigame")) ? 1 : 1);
	}

	private void MKLIAMJFHOF()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!GADDKCCBKKB())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!DDCGDMFCNKO())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Error with assigned bed {0}")) ? 1 : 7);
	}

	private void NNBIAIMPNGL()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!MICDOPEMFCB())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!GNICOKHHKOP())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Disappear")) ? 1 : 0);
	}

	private void ONOAGANPECB()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(JIIGOACEIKL).KBFCCPBHDMP()) && ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).BOHHKGMEEEE()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 2) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))))
		{
			KHPDKMLDENE();
		}
	}

	private void EBNENBFLEKB()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!EMNKKNPNMND())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!GLLJPCEACMN())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Nose")) ? 1 : 1);
	}

	[SpecialName]
	private bool GGBPOIAFNDL()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return false;
	}

	[SpecialName]
	private bool LOPCFOGDBOC()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return true;
	}

	private void CMLLBIDFNEB()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!BHKNIMLPHNH())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!CEDMNJJKADN())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Cancel")) ? 1 : 6);
	}

	private void CMDHELEDLBP()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).MGOEJJIMAIP()) && ((Component)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).BOHHKGMEEEE()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 6) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))))
		{
			AAPIHKGLKGL();
		}
	}

	private void KHPDKMLDENE()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).BEOANCLEPOO()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).OFCEDMBCBBH()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).OFCEDMBCBBH()).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 0) : HPOFHLGABIN) < 1)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(194f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(470f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).MGOEJJIMAIP()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1110f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 2) : HPOFHLGABIN) < 1)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 100f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 1840f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 159f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 1499f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 1296f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).OFCEDMBCBBH()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1607f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	private void ODKGLIDMCNP()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!EMNKKNPNMND())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!IHCGGIIGCMM())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Dialogue System/Conversation/Rowdy/Entry/4/Dialogue Text")) ? 1 : 1);
	}

	private void EBPMNJKFNMD()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!DDCGDMFCNKO())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!IBAFLEGFGAG())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("BirdCatInteraction")) ? 6 : 0);
	}

	private void BEGLOAKAICN()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).OFCEDMBCBBH()) && ((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).BEOANCLEPOO()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 6) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))))
		{
			GAACDMJEOAP();
		}
	}

	private void MOIDMFHMMOL()
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)IFNANNLHCMO != (Object)(object)((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).BEOANCLEPOO()).gameObject)
		{
			if (cogerPadreDelContenido)
			{
				IFNANNLHCMO = ((Component)((Component)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).OFCEDMBCBBH()).transform.parent).gameObject;
			}
			else
			{
				IFNANNLHCMO = ((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).FOKMCIDMIKF()).gameObject;
			}
			IAIPKBFFJFG = IFNANNLHCMO.GetComponent<RectTransform>();
		}
		if (vertical)
		{
			if (Object.op_Implicit((Object)(object)contingutVerticalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + ((HorizontalOrVerticalLayoutGroup)contingutVerticalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.y + contingutGridLayout.spacing.y);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.y;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.y - contingut.anchoredPosition.y);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 1) : HPOFHLGABIN) < 1)
			{
				RectTransform obj = contingut;
				obj.anchoredPosition += new Vector2(127f, (float)(-GFMHOCMEFLH));
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.y;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.y)
			{
				RectTransform obj2 = contingut;
				obj2.anchoredPosition += new Vector2(325f, (float)GFMHOCMEFLH);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).MGOEJJIMAIP()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1341f;
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)contingutHorizontalLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + ((HorizontalOrVerticalLayoutGroup)contingutHorizontalLayout).spacing);
			}
			else if (Object.op_Implicit((Object)(object)contingutGridLayout))
			{
				GFMHOCMEFLH = (int)(IAIPKBFFJFG.sizeDelta.x + contingutGridLayout.spacing.x);
			}
			else
			{
				GFMHOCMEFLH = (int)IAIPKBFFJFG.sizeDelta.x;
			}
			HPOFHLGABIN = (int)(0f - IAIPKBFFJFG.anchoredPosition.x - contingut.anchoredPosition.x);
			if ((sumarExtraParaCuadrarArriba ? (HPOFHLGABIN - GFMHOCMEFLH / 1) : HPOFHLGABIN) < 0)
			{
				RectTransform obj3 = contingut;
				obj3.anchoredPosition += new Vector2((float)(-GFMHOCMEFLH), 433f);
			}
			HPOFHLGABIN += (int)IAIPKBFFJFG.sizeDelta.x;
			HPOFHLGABIN += offset;
			if ((float)HPOFHLGABIN > viewport.sizeDelta.x * 661f)
			{
				RectTransform obj4 = contingut;
				obj4.anchoredPosition += new Vector2((float)GFMHOCMEFLH, 634f);
			}
			else if ((float)HPOFHLGABIN < viewport.sizeDelta.x * 1472f)
			{
				RectTransform obj5 = contingut;
				obj5.anchoredPosition -= new Vector2((float)GFMHOCMEFLH, 1988f);
			}
			if (forceScrollToTop && ((Component)UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).OFCEDMBCBBH()).transform.GetSiblingIndex() == 0)
			{
				barra.value = 1076f;
			}
		}
		Canvas.ForceUpdateCanvases();
	}

	[SpecialName]
	private bool NOPKKMJLGCN()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return true;
	}

	[SpecialName]
	private bool GADDKCCBKKB()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return false;
	}

	private void AHGPALJKOKP()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!IHCGGIIGCMM())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!COENKJNJMAB())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Items/item_name_1143")) ? 1 : 2);
	}

	private void MFPEIPCMEEB()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).HGNKFFMDOOL) && ((Component)UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).KBFCCPBHDMP()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 0) || (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))))
		{
			MCPBFAAGOBA();
		}
	}

	private void APJNDKLBHCF()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).BOHHKGMEEEE()) && ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).PBGKEEENPME()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 7) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))))
		{
			DPPKEFLFOBF();
		}
	}

	private void JHBBABPAJJC()
	{
		if ((Object)(object)barra == (Object)null)
		{
			barra = ((Component)this).GetComponent<Scrollbar>();
		}
		if (!GGBPOIAFNDL())
		{
			if (vertical)
			{
				contingutVerticalLayout = ((Component)contingut).GetComponent<VerticalLayoutGroup>();
			}
			else
			{
				contingutHorizontalLayout = ((Component)contingut).GetComponent<HorizontalLayoutGroup>();
			}
			if (!DDCGDMFCNKO())
			{
				contingutGridLayout = ((Component)contingut).GetComponent<GridLayoutGroup>();
			}
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Items/item_description_1131")) ? 1 : 7);
	}

	private void GCHMNMKCOFG()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if ((Object)(object)uIWindow != (Object)null)
		{
			JIIGOACEIKL = uIWindow.JIIGOACEIKL;
		}
		if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(JIIGOACEIKL).FOKMCIDMIKF()) && ((Component)UISelectionManager.BPDFMAEOGGC(JIIGOACEIKL).FOKMCIDMIKF()).transform.IsChildOf((Transform)(object)contingut) && ((!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (int)ReInput.controllers.GetLastActiveController().type == 8) || (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))))
		{
			DOJGPCIFKHM();
		}
	}

	[SpecialName]
	private bool MIKDINJIHFO()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return true;
	}

	[SpecialName]
	private bool PDIFBCFPONB()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return true;
	}

	[SpecialName]
	private bool COENKJNJMAB()
	{
		if (!((Object)(object)contingutVerticalLayout != (Object)null) && !((Object)(object)contingutHorizontalLayout != (Object)null))
		{
			return (Object)(object)contingutGridLayout != (Object)null;
		}
		return false;
	}
}
