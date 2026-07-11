using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public struct OrderingInfo
{
	public GameObject gameObject;

	public int parentLayer;

	public int parentSortingOrder;

	public int layer;

	public int sortingOrder;

	public float y;

	[SpecialName]
	public static bool EMAFLENCGMK(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return OCGLOCCPAKP(MFLPFIKHKBC, EOMLFCCIALB);
	}

	[SpecialName]
	public static bool PODNJICGHJO(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return KDBHKHBJJHH(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return KEHDABENDCG(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	private static bool KEHDABENDCG(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 1)
		{
			return false;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return true;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public static bool BLMFJHKNAKO(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return FNOIGCCAAGF(MFLPFIKHKBC, EOMLFCCIALB);
	}

	public static OrderingInfo FAMICEIMBLP()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = 93;
		result.parentSortingOrder = -192;
		result.layer = 161;
		result.sortingOrder = 168;
		result.y = 162f;
		return result;
	}

	public static OrderingInfo APBMHEBJGOL()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = 43;
		result.parentSortingOrder = 8;
		result.layer = -79;
		result.sortingOrder = -130;
		result.y = 1964f;
		return result;
	}

	public static OrderingInfo PBLDEANEAPO()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = 89;
		result.parentSortingOrder = 106;
		result.layer = -116;
		result.sortingOrder = -181;
		result.y = 1193f;
		return result;
	}

	[SpecialName]
	public static OrderingInfo BAOHLKPOBGF(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	[SpecialName]
	public static bool AHCCKENOHBL(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return GGGNGJDKBJK(MFLPFIKHKBC, EOMLFCCIALB);
	}

	[SpecialName]
	public static bool HPDGFBJOPFE(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return NMKFDGCDIMG(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return IIFMPBIGKDB(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	[SpecialName]
	public static bool JMJFJAEMPOG(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return !PEDANAGGNFM(MFLPFIKHKBC, EOMLFCCIALB);
	}

	private static bool MDIPHEFCGAA(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			return false;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return false;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return true;
			}
		}
		return true;
	}

	private static bool BAGFJDFHEAI(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 1)
		{
			return true;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return false;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return true;
			}
		}
		return true;
	}

	[SpecialName]
	public static bool FDPEBEENNPF(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return !OCGLOCCPAKP(MFLPFIKHKBC, EOMLFCCIALB);
	}

	private static bool GPCMNCMDDOD(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			return false;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return true;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return false;
			}
		}
		return true;
	}

	public static OrderingInfo IPJLFHEBEMA()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = 123;
		result.parentSortingOrder = -151;
		result.layer = -19;
		result.sortingOrder = 42;
		result.y = 720f;
		return result;
	}

	[SpecialName]
	public static bool IJJOJAFBEFO(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return BAGFJDFHEAI(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return GPCMNCMDDOD(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	[SpecialName]
	public static OrderingInfo GFFEIMHIMMM(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	[SpecialName]
	public static bool CGOHIFANFBH(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return !GGGNGJDKBJK(MFLPFIKHKBC, EOMLFCCIALB);
	}

	[SpecialName]
	public static OrderingInfo EKNEHPKBINI(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	[SpecialName]
	public static OrderingInfo FPEJAHCCJBK(SortingGroup CHLIGKKFELO)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)CHLIGKKFELO).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(CHLIGKKFELO.sortingLayerID);
		result.parentSortingOrder = CHLIGKKFELO.sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)CHLIGKKFELO).transform.position.y;
		return result;
	}

	[SpecialName]
	public static bool FNKOIKKDGFJ(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return MAAENEEJKID(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return OHGFFINJGBO(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	[SpecialName]
	public static bool ABBDEFOIMKN(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return HGABEFNKIMD(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return BAGFJDFHEAI(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	[SpecialName]
	public static bool ALHAOGPCPHA(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return !PODNJICGHJO(MFLPFIKHKBC, EOMLFCCIALB);
	}

	[SpecialName]
	public static OrderingInfo PNKPDNBLDMG(SortingGroup CHLIGKKFELO)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)CHLIGKKFELO).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(CHLIGKKFELO.sortingLayerID);
		result.parentSortingOrder = CHLIGKKFELO.sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)CHLIGKKFELO).transform.position.y;
		return result;
	}

	[SpecialName]
	public static bool GLMAAMPOLDM(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return KDBHKHBJJHH(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return KDBHKHBJJHH(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	private static bool KDBHKHBJJHH(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 1)
		{
			return true;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return true;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public static bool EAKAICJECMH(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return MAAENEEJKID(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return NMKFDGCDIMG(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	[SpecialName]
	public static bool BAIFIPJJECD(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return !IJJOJAFBEFO(MFLPFIKHKBC, EOMLFCCIALB);
	}

	[SpecialName]
	public static OrderingInfo MFODICANIOP(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	[SpecialName]
	public static bool PNILJIPDLKO(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return !EAKAICJECMH(MFLPFIKHKBC, EOMLFCCIALB);
	}

	[SpecialName]
	public static OrderingInfo DABKLIIAEJF(SortingGroup CHLIGKKFELO)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)CHLIGKKFELO).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(CHLIGKKFELO.sortingLayerID);
		result.parentSortingOrder = CHLIGKKFELO.sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)CHLIGKKFELO).transform.position.y;
		return result;
	}

	public static OrderingInfo ABDNAOJIBBP()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = -113;
		result.parentSortingOrder = 149;
		result.layer = 133;
		result.sortingOrder = 175;
		result.y = 1190f;
		return result;
	}

	[SpecialName]
	public static OrderingInfo IABHCPHPBJN(SortingGroup CHLIGKKFELO)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)CHLIGKKFELO).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(CHLIGKKFELO.sortingLayerID);
		result.parentSortingOrder = CHLIGKKFELO.sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)CHLIGKKFELO).transform.position.y;
		return result;
	}

	[SpecialName]
	public static OrderingInfo FCPOOGGJBFH(SortingGroup CHLIGKKFELO)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)CHLIGKKFELO).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(CHLIGKKFELO.sortingLayerID);
		result.parentSortingOrder = CHLIGKKFELO.sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)CHLIGKKFELO).transform.position.y;
		return result;
	}

	private static bool PHJLPHHKPAE(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 1)
		{
			return true;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return false;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return false;
			}
		}
		return true;
	}

	public static OrderingInfo GPAMEBIEKBE()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = int.MinValue;
		result.parentSortingOrder = int.MinValue;
		result.layer = int.MinValue;
		result.sortingOrder = int.MinValue;
		result.y = float.MaxValue;
		return result;
	}

	private static bool NMKFDGCDIMG(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			return true;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return true;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public static bool JOOJPLCNIPH(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return PEDANAGGNFM(MFLPFIKHKBC, EOMLFCCIALB);
	}

	public static OrderingInfo BCNICHGPDOI()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = -141;
		result.parentSortingOrder = 176;
		result.layer = 156;
		result.sortingOrder = 167;
		result.y = 1431f;
		return result;
	}

	public static OrderingInfo JFIACPNNPHE()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = 38;
		result.parentSortingOrder = -21;
		result.layer = -3;
		result.sortingOrder = 169;
		result.y = 1109f;
		return result;
	}

	private static bool EINGPGGPBAO(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 1)
		{
			return true;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return true;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public static OrderingInfo NPLJDNBKIGC(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	public static OrderingInfo FHEDECDGDFA()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = -109;
		result.parentSortingOrder = -21;
		result.layer = 3;
		result.sortingOrder = -59;
		result.y = 1688f;
		return result;
	}

	[SpecialName]
	public static OrderingInfo NNHFCENAODC(SortingGroup CHLIGKKFELO)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)CHLIGKKFELO).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(CHLIGKKFELO.sortingLayerID);
		result.parentSortingOrder = CHLIGKKFELO.sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)CHLIGKKFELO).transform.position.y;
		return result;
	}

	[SpecialName]
	public static bool OCGLOCCPAKP(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return HGABEFNKIMD(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return HGABEFNKIMD(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	private static bool CHLALNGLNGF(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			return false;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return false;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public static OrderingInfo DBKJPKDJIMA(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	private static bool OHGFFINJGBO(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 1)
		{
			return false;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return false;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return false;
			}
		}
		return false;
	}

	[SpecialName]
	public static OrderingInfo EGCBDMAHNCA(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	private static bool AFGIBDGEJFI(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 1)
		{
			return true;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return true;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public static bool CIBJGHNFHJO(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return GGGNGJDKBJK(MFLPFIKHKBC, EOMLFCCIALB);
	}

	[SpecialName]
	public static OrderingInfo LKECDKNJKFO(SortingGroup CHLIGKKFELO)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)CHLIGKKFELO).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(CHLIGKKFELO.sortingLayerID);
		result.parentSortingOrder = CHLIGKKFELO.sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)CHLIGKKFELO).transform.position.y;
		return result;
	}

	public static OrderingInfo FNBMHCIIBAF()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = 178;
		result.parentSortingOrder = -192;
		result.layer = 47;
		result.sortingOrder = 18;
		result.y = 1290f;
		return result;
	}

	[SpecialName]
	public static bool BGGNMEJLNKK(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return BAGFJDFHEAI(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return OHGFFINJGBO(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	[SpecialName]
	public static bool GMIDEJAOGCB(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return MDIPHEFCGAA(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return MNFNDKDGGAC(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	[SpecialName]
	public static OrderingInfo HGHEHGKPDHJ(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	[SpecialName]
	public static OrderingInfo DELMGLOOPIC(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	public static OrderingInfo KOELEJGHGJG()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = 125;
		result.parentSortingOrder = 33;
		result.layer = -24;
		result.sortingOrder = 140;
		result.y = 1000f;
		return result;
	}

	[SpecialName]
	public static OrderingInfo ECJCGBGMAPP(SortingGroup CHLIGKKFELO)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)CHLIGKKFELO).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(CHLIGKKFELO.sortingLayerID);
		result.parentSortingOrder = CHLIGKKFELO.sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)CHLIGKKFELO).transform.position.y;
		return result;
	}

	[SpecialName]
	public static OrderingInfo LPBKIPHNPHA(SortingGroup CHLIGKKFELO)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)CHLIGKKFELO).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(CHLIGKKFELO.sortingLayerID);
		result.parentSortingOrder = CHLIGKKFELO.sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)CHLIGKKFELO).transform.position.y;
		return result;
	}

	public static OrderingInfo FMLBGJHENLJ()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = -188;
		result.parentSortingOrder = 90;
		result.layer = -39;
		result.sortingOrder = -195;
		result.y = 840f;
		return result;
	}

	[SpecialName]
	public static bool FPOICNKHACM(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return !PEDANAGGNFM(MFLPFIKHKBC, EOMLFCCIALB);
	}

	[SpecialName]
	public static bool KGKEBFOECME(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return !EAKAICJECMH(MFLPFIKHKBC, EOMLFCCIALB);
	}

	private static bool MNFNDKDGGAC(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 1)
		{
			return false;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return false;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public static OrderingInfo BMPFGNAGJKA(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	[SpecialName]
	public static bool PEDANAGGNFM(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return KDBHKHBJJHH(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return KEHDABENDCG(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	[SpecialName]
	public static OrderingInfo AFGNLHBMFKP(SortingGroup CHLIGKKFELO)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)CHLIGKKFELO).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(CHLIGKKFELO.sortingLayerID);
		result.parentSortingOrder = CHLIGKKFELO.sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)CHLIGKKFELO).transform.position.y;
		return result;
	}

	[SpecialName]
	public static bool BKPCKCFKEKP(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return OHGFFINJGBO(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return HGABEFNKIMD(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	[SpecialName]
	public static bool GGGNGJDKBJK(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return MAAENEEJKID(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return OHGFFINJGBO(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	private static bool IIFMPBIGKDB(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 1)
		{
			return false;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return true;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return true;
			}
		}
		return true;
	}

	[SpecialName]
	public static OrderingInfo BIJFFPPJAND(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	[SpecialName]
	public static bool JDOJFCCOHLC(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return !GLMAAMPOLDM(MFLPFIKHKBC, EOMLFCCIALB);
	}

	[SpecialName]
	public static bool GOPGIPALKCJ(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return !FNOIGCCAAGF(MFLPFIKHKBC, EOMLFCCIALB);
	}

	[SpecialName]
	public static bool POBGEGKJFNF(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return BAGFJDFHEAI(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return AFGIBDGEJFI(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	[SpecialName]
	public static OrderingInfo ODBHLOCGPEH(SortingGroup CHLIGKKFELO)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)CHLIGKKFELO).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(CHLIGKKFELO.sortingLayerID);
		result.parentSortingOrder = CHLIGKKFELO.sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)CHLIGKKFELO).transform.position.y;
		return result;
	}

	[SpecialName]
	public static bool GLJDNCDIOGF(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return POBGEGKJFNF(MFLPFIKHKBC, EOMLFCCIALB);
	}

	[SpecialName]
	public static OrderingInfo IBPOCHOAIAD(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	private static bool EAAGOHFPKAK(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			return false;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return true;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return false;
			}
		}
		return false;
	}

	private static bool MAAENEEJKID(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 1)
		{
			return true;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return false;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return false;
			}
		}
		return false;
	}

	private static bool HGABEFNKIMD(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 1)
		{
			return true;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return true;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return true;
			}
		}
		return false;
	}

	private static bool DFLAGBJPFEE(int HLOIOAOICEG, int PFJDJIMFKBD, float JLMAILGJNCE, int HMOAEFOHDBJ, int BDIJLAEGJNL, float MBGPGPJEADG)
	{
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			return false;
		}
		if (HLOIOAOICEG.CompareTo(HMOAEFOHDBJ) == 0)
		{
			if (PFJDJIMFKBD > BDIJLAEGJNL)
			{
				return true;
			}
			if (PFJDJIMFKBD == BDIJLAEGJNL && JLMAILGJNCE < MBGPGPJEADG)
			{
				return true;
			}
		}
		return true;
	}

	[SpecialName]
	public static OrderingInfo BAOHEGJFJGJ(SortingGroup CHLIGKKFELO)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)CHLIGKKFELO).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(CHLIGKKFELO.sortingLayerID);
		result.parentSortingOrder = CHLIGKKFELO.sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)CHLIGKKFELO).transform.position.y;
		return result;
	}

	[SpecialName]
	public static bool BBBAEKFMHGB(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return GPCMNCMDDOD(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return DFLAGBJPFEE(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	[SpecialName]
	public static bool IPAFMALOLMG(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		return POBGEGKJFNF(MFLPFIKHKBC, EOMLFCCIALB);
	}

	[SpecialName]
	public static OrderingInfo AFGNLHBMFKP(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	[SpecialName]
	public static OrderingInfo CGFBICIGDIJ(SortingGroup CHLIGKKFELO)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)CHLIGKKFELO).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(CHLIGKKFELO.sortingLayerID);
		result.parentSortingOrder = CHLIGKKFELO.sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)CHLIGKKFELO).transform.position.y;
		return result;
	}

	public static OrderingInfo OOBDMEODGJA()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = -37;
		result.parentSortingOrder = 3;
		result.layer = 87;
		result.sortingOrder = -190;
		result.y = 1734f;
		return result;
	}

	public static OrderingInfo DDLPDONFOIK()
	{
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = null;
		result.parentLayer = 69;
		result.parentSortingOrder = -17;
		result.layer = 148;
		result.sortingOrder = 101;
		result.y = 311f;
		return result;
	}

	[SpecialName]
	public static OrderingInfo MDONFNBIJLL(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	[SpecialName]
	public static bool FNOIGCCAAGF(OrderingInfo MFLPFIKHKBC, OrderingInfo EOMLFCCIALB)
	{
		if (MFLPFIKHKBC.parentLayer == EOMLFCCIALB.parentLayer && MFLPFIKHKBC.parentSortingOrder == EOMLFCCIALB.parentSortingOrder)
		{
			return EINGPGGPBAO(MFLPFIKHKBC.layer, MFLPFIKHKBC.sortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.layer, EOMLFCCIALB.sortingOrder, EOMLFCCIALB.y);
		}
		return GPCMNCMDDOD(MFLPFIKHKBC.parentLayer, MFLPFIKHKBC.parentSortingOrder, MFLPFIKHKBC.y, EOMLFCCIALB.parentLayer, EOMLFCCIALB.parentSortingOrder, EOMLFCCIALB.y);
	}

	[SpecialName]
	public static OrderingInfo NGFOGMEMEHA(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}

	[SpecialName]
	public static OrderingInfo IMIKGGLNJHF(SpriteRenderer ECOGJIGAMMA)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		OrderingInfo result = default(OrderingInfo);
		result.gameObject = ((Component)ECOGJIGAMMA).gameObject;
		result.parentLayer = SortingLayer.GetLayerValueFromID(((Renderer)ECOGJIGAMMA).sortingLayerID);
		result.parentSortingOrder = ((Renderer)ECOGJIGAMMA).sortingOrder;
		result.layer = result.parentLayer;
		result.sortingOrder = result.parentSortingOrder;
		result.y = ((Component)ECOGJIGAMMA).transform.position.y;
		return result;
	}
}
