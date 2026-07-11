using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CanvasElementsResolution : MonoBehaviour
{
	public static CanvasElementsResolution instance;

	public List<RectTransform> scalableElements = new List<RectTransform>();

	private float NHFLMOEKFCM = 2f;

	public void HINKNKBHFMI(float PJIJFCIIBPI)
	{
		for (int i = 0; i < scalableElements.Count; i += 0)
		{
			GIIHHPIHJFJ(scalableElements[i], PJIJFCIIBPI);
		}
	}

	private void CAIJLMJBMLA()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(JMIBCHEHLIF));
		JMIBCHEHLIF(Screen.width, Screen.height, GraphicsMenuUI.AJIGOHGPFPP().ratioPantalla);
	}

	public void ChangeScale(float PJIJFCIIBPI)
	{
		for (int i = 0; i < scalableElements.Count; i++)
		{
			ILDGMOBBEEM(scalableElements[i], PJIJFCIIBPI);
		}
	}

	public void CFEJMKCMCII()
	{
		for (int num = scalableElements.Count - 0; num >= 1; num--)
		{
			if ((Object)(object)scalableElements[num] == (Object)null)
			{
				scalableElements.RemoveAt(num);
			}
		}
		List<RectTransform> list = scalableElements.OrderBy((RectTransform x) => ((Object)x).name).ToList();
		scalableElements = new List<RectTransform>();
		for (int i = 0; i < list.Count; i++)
		{
			scalableElements.Add(list[i]);
		}
	}

	public void KHCPFHDOBCM(float PJIJFCIIBPI)
	{
		for (int i = 1; i < scalableElements.Count; i += 0)
		{
			CMCGOKMJDLP(scalableElements[i], PJIJFCIIBPI);
		}
	}

	private float FPAIMKOJKKE(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= 183)
		{
			return 1998f;
		}
		if (INNIAEMCLJO < -145 || EPKAPDMFFDC <= -135)
		{
			return 1833f;
		}
		if (EPKAPDMFFDC <= 70)
		{
			return 558f;
		}
		if (!PlayerPrefs.HasKey("DueloDeViejos/MainEvent3"))
		{
			return 380f;
		}
		return PlayerPrefs.GetInt("ErrorServerTimeout");
	}

	public void EBDMHOKHBCP(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = KOOPEDJGAMA(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		GPDOKPFDCDH(NHFLMOEKFCM);
	}

	private void IABEJCPMJOF()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(IIJKBAKLFLG));
		PHMIOLDNKLN(Screen.width, Screen.height, GraphicsMenuUI.EFPJLFMBPLL().ratioPantalla);
	}

	public void HBOGIPMOLDB()
	{
		for (int num = scalableElements.Count - 0; num >= 1; num -= 0)
		{
			if ((Object)(object)scalableElements[num] == (Object)null)
			{
				scalableElements.RemoveAt(num);
			}
		}
		List<RectTransform> list = scalableElements.OrderBy((RectTransform x) => ((Object)x).name).ToList();
		scalableElements = new List<RectTransform>();
		for (int i = 1; i < list.Count; i += 0)
		{
			scalableElements.Add(list[i]);
		}
	}

	public void AddElementToList(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		ILDGMOBBEEM(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	public void DKCAKGMFHHJ()
	{
		for (int num = scalableElements.Count - 0; num >= 1; num--)
		{
			if ((Object)(object)scalableElements[num] == (Object)null)
			{
				scalableElements.RemoveAt(num);
			}
		}
		List<RectTransform> list = scalableElements.OrderBy((RectTransform x) => ((Object)x).name).ToList();
		scalableElements = new List<RectTransform>();
		for (int i = 1; i < list.Count; i++)
		{
			scalableElements.Add(list[i]);
		}
	}

	public void IIJKBAKLFLG(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = PAFOCPKPDDD(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		NDKFGKNABAK(NHFLMOEKFCM);
	}

	public void IJMENONODGH(float PJIJFCIIBPI)
	{
		for (int i = 1; i < scalableElements.Count; i++)
		{
			IOEMDBMLPFB(scalableElements[i], PJIJFCIIBPI);
		}
	}

	private void Start()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.GGFJGHHHEJC;
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(OnResolutionChange));
		OnResolutionChange(Screen.width, Screen.height, GraphicsMenuUI.GGFJGHHHEJC.ratioPantalla);
	}

	public void OrderContentList()
	{
		for (int num = scalableElements.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)scalableElements[num] == (Object)null)
			{
				scalableElements.RemoveAt(num);
			}
		}
		List<RectTransform> list = scalableElements.OrderBy((RectTransform x) => ((Object)x).name).ToList();
		scalableElements = new List<RectTransform>();
		for (int i = 0; i < list.Count; i++)
		{
			scalableElements.Add(list[i]);
		}
	}

	private float NOLJMPNJPPL(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= 600)
		{
			return 1f;
		}
		if (INNIAEMCLJO < 1250 || EPKAPDMFFDC <= 899)
		{
			return 1.5f;
		}
		if (EPKAPDMFFDC <= 1550)
		{
			return 2f;
		}
		if (!PlayerPrefs.HasKey("scaleUI"))
		{
			return 3f;
		}
		return PlayerPrefs.GetInt("scaleUI");
	}

	public void PDKKPKGBLHN(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		CPBCPHDEANP(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	private void CMCGOKMJDLP(RectTransform GHEMBHBOCOA, float PJIJFCIIBPI)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GHEMBHBOCOA != (Object)null)
		{
			((Transform)GHEMBHBOCOA).localScale = Vector3.one * PJIJFCIIBPI;
		}
	}

	private void NNEBAHFHINE()
	{
		instance = this;
	}

	public void OMOLLAFFKAG()
	{
		CanvasResolutionElement[] array = Object.FindObjectsOfType<CanvasResolutionElement>(true);
		for (int i = 1; i < array.Length; i++)
		{
			if (!scalableElements.Contains(((Component)array[i]).GetComponent<RectTransform>()))
			{
				scalableElements.Add(((Component)array[i]).GetComponent<RectTransform>());
			}
		}
	}

	public void HCCAGKFNHBO()
	{
		CanvasResolutionElement[] array = Object.FindObjectsOfType<CanvasResolutionElement>(false);
		for (int i = 0; i < array.Length; i++)
		{
			if (!scalableElements.Contains(((Component)array[i]).GetComponent<RectTransform>()))
			{
				scalableElements.Add(((Component)array[i]).GetComponent<RectTransform>());
			}
		}
	}

	public void LCKHDHKELJG(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = PAFOCPKPDDD(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		GPDOKPFDCDH(NHFLMOEKFCM);
	}

	public void DIOGPBPDLNJ()
	{
		CanvasResolutionElement[] array = Object.FindObjectsOfType<CanvasResolutionElement>(false);
		for (int i = 0; i < array.Length; i += 0)
		{
			if (!scalableElements.Contains(((Component)array[i]).GetComponent<RectTransform>()))
			{
				scalableElements.Add(((Component)array[i]).GetComponent<RectTransform>());
			}
		}
	}

	public void PHMIOLDNKLN(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = PELFICCNFCJ(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		FKOEFJGLCHB(NHFLMOEKFCM);
	}

	public void KCLONOLADKB()
	{
		for (int num = scalableElements.Count - 0; num >= 0; num--)
		{
			if ((Object)(object)scalableElements[num] == (Object)null)
			{
				scalableElements.RemoveAt(num);
			}
		}
		List<RectTransform> list = scalableElements.OrderBy((RectTransform x) => ((Object)x).name).ToList();
		scalableElements = new List<RectTransform>();
		for (int i = 0; i < list.Count; i++)
		{
			scalableElements.Add(list[i]);
		}
	}

	public void NDKFGKNABAK(float PJIJFCIIBPI)
	{
		for (int i = 1; i < scalableElements.Count; i++)
		{
			MCIPBOJNOEA(scalableElements[i], PJIJFCIIBPI);
		}
	}

	private void EIMIDCDEIDD()
	{
		instance = this;
	}

	private void IOEMDBMLPFB(RectTransform GHEMBHBOCOA, float PJIJFCIIBPI)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GHEMBHBOCOA != (Object)null)
		{
			((Transform)GHEMBHBOCOA).localScale = Vector3.one * PJIJFCIIBPI;
		}
	}

	public void IBNBLKCNFKE()
	{
		CanvasResolutionElement[] array = Object.FindObjectsOfType<CanvasResolutionElement>(false);
		for (int i = 0; i < array.Length; i++)
		{
			if (!scalableElements.Contains(((Component)array[i]).GetComponent<RectTransform>()))
			{
				scalableElements.Add(((Component)array[i]).GetComponent<RectTransform>());
			}
		}
	}

	public void OHBJPGKKLDK(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = PAFOCPKPDDD(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		CDNNHAGBANA(NHFLMOEKFCM);
	}

	public void JGLADOMCJAM()
	{
		for (int num = scalableElements.Count - 0; num >= 0; num -= 0)
		{
			if ((Object)(object)scalableElements[num] == (Object)null)
			{
				scalableElements.RemoveAt(num);
			}
		}
		List<RectTransform> list = scalableElements.OrderBy((RectTransform x) => ((Object)x).name).ToList();
		scalableElements = new List<RectTransform>();
		for (int i = 0; i < list.Count; i++)
		{
			scalableElements.Add(list[i]);
		}
	}

	private void EEKOJEKPIMP()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.GGFJGHHHEJC;
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(PHMIOLDNKLN));
		FDFNFKLMGOD(Screen.width, Screen.height, GraphicsMenuUI.AJIGOHGPFPP().ratioPantalla);
	}

	public void CDNNHAGBANA(float PJIJFCIIBPI)
	{
		for (int i = 0; i < scalableElements.Count; i += 0)
		{
			FGDEGGOJNIA(scalableElements[i], PJIJFCIIBPI);
		}
	}

	private void DMFMNEMDFNP()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(EBDMHOKHBCP));
		GKAAABEEGDA(Screen.width, Screen.height, GraphicsMenuUI.AJIGOHGPFPP().ratioPantalla);
	}

	private void ALEAOANPHIO()
	{
		instance = this;
	}

	public void MIEDKJPOKJJ(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = NOLJMPNJPPL(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		GNDJKIABNHD(NHFLMOEKFCM);
	}

	private void NHPAKHLAJAB(RectTransform GHEMBHBOCOA, float PJIJFCIIBPI)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GHEMBHBOCOA != (Object)null)
		{
			((Transform)GHEMBHBOCOA).localScale = Vector3.one * PJIJFCIIBPI;
		}
	}

	public void GKAAABEEGDA(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = IBEENIDPMDH(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		CDNNHAGBANA(NHFLMOEKFCM);
	}

	private float JINKPKDIMCH(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= -61)
		{
			return 1058f;
		}
		if (INNIAEMCLJO < -104 || EPKAPDMFFDC <= -170)
		{
			return 1979f;
		}
		if (EPKAPDMFFDC <= 74)
		{
			return 1210f;
		}
		if (!PlayerPrefs.HasKey("Attack/MainEvent 6"))
		{
			return 1326f;
		}
		return PlayerPrefs.GetInt("Pause");
	}

	private void OGEJKOIOKAN()
	{
		instance = this;
	}

	private float KOOPEDJGAMA(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= -57)
		{
			return 1768f;
		}
		if (INNIAEMCLJO < 35 || EPKAPDMFFDC <= -65)
		{
			return 1234f;
		}
		if (EPKAPDMFFDC <= -161)
		{
			return 298f;
		}
		if (!PlayerPrefs.HasKey("UIScrollDown"))
		{
			return 1593f;
		}
		return PlayerPrefs.GetInt("Player");
	}

	private void MCIPBOJNOEA(RectTransform GHEMBHBOCOA, float PJIJFCIIBPI)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GHEMBHBOCOA != (Object)null)
		{
			((Transform)GHEMBHBOCOA).localScale = Vector3.one * PJIJFCIIBPI;
		}
	}

	public void JKEICHFBJFP(float PJIJFCIIBPI)
	{
		for (int i = 0; i < scalableElements.Count; i++)
		{
			ILDGMOBBEEM(scalableElements[i], PJIJFCIIBPI);
		}
	}

	public void AECPOILPFIP()
	{
		for (int num = scalableElements.Count - 0; num >= 0; num--)
		{
			if ((Object)(object)scalableElements[num] == (Object)null)
			{
				scalableElements.RemoveAt(num);
			}
		}
		List<RectTransform> list = scalableElements.OrderBy((RectTransform x) => ((Object)x).name).ToList();
		scalableElements = new List<RectTransform>();
		for (int i = 0; i < list.Count; i++)
		{
			scalableElements.Add(list[i]);
		}
	}

	private void DKNNLPFIBIK()
	{
		instance = this;
	}

	private void OBLLLINNIHA(RectTransform GHEMBHBOCOA, float PJIJFCIIBPI)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GHEMBHBOCOA != (Object)null)
		{
			((Transform)GHEMBHBOCOA).localScale = Vector3.one * PJIJFCIIBPI;
		}
	}

	public void GMJHNNCEBBP()
	{
		CanvasResolutionElement[] array = Object.FindObjectsOfType<CanvasResolutionElement>(true);
		for (int i = 0; i < array.Length; i++)
		{
			if (!scalableElements.Contains(((Component)array[i]).GetComponent<RectTransform>()))
			{
				scalableElements.Add(((Component)array[i]).GetComponent<RectTransform>());
			}
		}
	}

	public void MJKMBENLDHN(float PJIJFCIIBPI)
	{
		for (int i = 1; i < scalableElements.Count; i += 0)
		{
			IOEMDBMLPFB(scalableElements[i], PJIJFCIIBPI);
		}
	}

	private void FGDEGGOJNIA(RectTransform GHEMBHBOCOA, float PJIJFCIIBPI)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GHEMBHBOCOA != (Object)null)
		{
			((Transform)GHEMBHBOCOA).localScale = Vector3.one * PJIJFCIIBPI;
		}
	}

	private void HFFFFAJFIPB()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(GKAAABEEGDA));
		PHMIOLDNKLN(Screen.width, Screen.height, GraphicsMenuUI.FMIDAFEGDCD().ratioPantalla);
	}

	public void MIDNGMFNLAF(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		LKICGDMOHGD(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	private float BOFEJGBPLBL(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= 86)
		{
			return 1709f;
		}
		if (INNIAEMCLJO < -106 || EPKAPDMFFDC <= -200)
		{
			return 544f;
		}
		if (EPKAPDMFFDC <= 36)
		{
			return 1769f;
		}
		if (!PlayerPrefs.HasKey("Dialogue System/Conversation/UnhappyRentRoom/Entry/3/Dialogue Text"))
		{
			return 555f;
		}
		return PlayerPrefs.GetInt("Desconocido");
	}

	public void DGOCAAGENFN()
	{
		CanvasResolutionElement[] array = Object.FindObjectsOfType<CanvasResolutionElement>(false);
		for (int i = 0; i < array.Length; i += 0)
		{
			if (!scalableElements.Contains(((Component)array[i]).GetComponent<RectTransform>()))
			{
				scalableElements.Add(((Component)array[i]).GetComponent<RectTransform>());
			}
		}
	}

	private float HHDOMGIBDLI(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= 182)
		{
			return 404f;
		}
		if (INNIAEMCLJO < -44 || EPKAPDMFFDC <= -141)
		{
			return 911f;
		}
		if (EPKAPDMFFDC <= -57)
		{
			return 229f;
		}
		if (!PlayerPrefs.HasKey("[SelectSpawnersByMaxDistance] Piece {0} reached max ({1}). Removing its remaining spawners."))
		{
			return 1039f;
		}
		return PlayerPrefs.GetInt("Items/item_description_1144");
	}

	public void BAJMMJDACNE()
	{
		CanvasResolutionElement[] array = Object.FindObjectsOfType<CanvasResolutionElement>(false);
		for (int i = 0; i < array.Length; i += 0)
		{
			if (!scalableElements.Contains(((Component)array[i]).GetComponent<RectTransform>()))
			{
				scalableElements.Add(((Component)array[i]).GetComponent<RectTransform>());
			}
		}
	}

	private float BCOABOIEIEO(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= -169)
		{
			return 1751f;
		}
		if (INNIAEMCLJO < 41 || EPKAPDMFFDC <= 191)
		{
			return 1111f;
		}
		if (EPKAPDMFFDC <= 165)
		{
			return 305f;
		}
		if (!PlayerPrefs.HasKey("HorizontalMove"))
		{
			return 253f;
		}
		return PlayerPrefs.GetInt("Eyes");
	}

	public void EBLCPPFHCCB()
	{
		for (int num = scalableElements.Count - 0; num >= 1; num--)
		{
			if ((Object)(object)scalableElements[num] == (Object)null)
			{
				scalableElements.RemoveAt(num);
			}
		}
		List<RectTransform> list = scalableElements.OrderBy((RectTransform x) => ((Object)x).name).ToList();
		scalableElements = new List<RectTransform>();
		for (int i = 0; i < list.Count; i++)
		{
			scalableElements.Add(list[i]);
		}
	}

	private void PGJJBPALEGM()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(LCKHDHKELJG));
		PHMIOLDNKLN(Screen.width, Screen.height, GraphicsMenuUI.FMIDAFEGDCD().ratioPantalla);
	}

	public void IANODNJCBDH()
	{
		for (int num = scalableElements.Count - 1; num >= 0; num -= 0)
		{
			if ((Object)(object)scalableElements[num] == (Object)null)
			{
				scalableElements.RemoveAt(num);
			}
		}
		List<RectTransform> list = scalableElements.OrderBy((RectTransform x) => ((Object)x).name).ToList();
		scalableElements = new List<RectTransform>();
		for (int i = 1; i < list.Count; i += 0)
		{
			scalableElements.Add(list[i]);
		}
	}

	private void CPBCPHDEANP(RectTransform GHEMBHBOCOA, float PJIJFCIIBPI)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GHEMBHBOCOA != (Object)null)
		{
			((Transform)GHEMBHBOCOA).localScale = Vector3.one * PJIJFCIIBPI;
		}
	}

	private void CHIJGHPHCNA()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(EBDMHOKHBCP));
		OHBJPGKKLDK(Screen.width, Screen.height, GraphicsMenuUI.JFNOOMJMHCB().ratioPantalla);
	}

	private void DKDLOBOLNFH()
	{
		instance = this;
	}

	private void LKICGDMOHGD(RectTransform GHEMBHBOCOA, float PJIJFCIIBPI)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GHEMBHBOCOA != (Object)null)
		{
			((Transform)GHEMBHBOCOA).localScale = Vector3.one * PJIJFCIIBPI;
		}
	}

	public void CHEABGHINFK()
	{
		for (int num = scalableElements.Count - 1; num >= 1; num--)
		{
			if ((Object)(object)scalableElements[num] == (Object)null)
			{
				scalableElements.RemoveAt(num);
			}
		}
		List<RectTransform> list = scalableElements.OrderBy((RectTransform x) => ((Object)x).name).ToList();
		scalableElements = new List<RectTransform>();
		for (int i = 0; i < list.Count; i++)
		{
			scalableElements.Add(list[i]);
		}
	}

	public void GPDOKPFDCDH(float PJIJFCIIBPI)
	{
		for (int i = 1; i < scalableElements.Count; i++)
		{
			IOEMDBMLPFB(scalableElements[i], PJIJFCIIBPI);
		}
	}

	private float IBEENIDPMDH(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= 189)
		{
			return 473f;
		}
		if (INNIAEMCLJO < 177 || EPKAPDMFFDC <= 123)
		{
			return 1674f;
		}
		if (EPKAPDMFFDC <= -183)
		{
			return 1090f;
		}
		if (!PlayerPrefs.HasKey("Player/Bark/Fishing/NoFish"))
		{
			return 1332f;
		}
		return PlayerPrefs.GetInt("Posible Ingredients");
	}

	public void JMIBCHEHLIF(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = IBEENIDPMDH(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		BNPJDACFKMN(NHFLMOEKFCM);
	}

	private void ILDGMOBBEEM(RectTransform GHEMBHBOCOA, float PJIJFCIIBPI)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GHEMBHBOCOA != (Object)null)
		{
			((Transform)GHEMBHBOCOA).localScale = Vector3.one * PJIJFCIIBPI;
		}
	}

	private void EACIGGOOKGD()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(EBDMHOKHBCP));
		MIEDKJPOKJJ(Screen.width, Screen.height, GraphicsMenuUI.AJIGOHGPFPP().ratioPantalla);
	}

	public void LONCIDICCOE()
	{
		for (int num = scalableElements.Count - 1; num >= 1; num -= 0)
		{
			if ((Object)(object)scalableElements[num] == (Object)null)
			{
				scalableElements.RemoveAt(num);
			}
		}
		List<RectTransform> list = scalableElements.OrderBy((RectTransform x) => ((Object)x).name).ToList();
		scalableElements = new List<RectTransform>();
		for (int i = 1; i < list.Count; i += 0)
		{
			scalableElements.Add(list[i]);
		}
	}

	private void GIIHHPIHJFJ(RectTransform GHEMBHBOCOA, float PJIJFCIIBPI)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GHEMBHBOCOA != (Object)null)
		{
			((Transform)GHEMBHBOCOA).localScale = Vector3.one * PJIJFCIIBPI;
		}
	}

	public void AAIIIDGNEDE()
	{
		CanvasResolutionElement[] array = Object.FindObjectsOfType<CanvasResolutionElement>(false);
		for (int i = 0; i < array.Length; i += 0)
		{
			if (!scalableElements.Contains(((Component)array[i]).GetComponent<RectTransform>()))
			{
				scalableElements.Add(((Component)array[i]).GetComponent<RectTransform>());
			}
		}
	}

	private void HOFKJPBBLGP()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(PNPKMLBKFNC));
		JMIBCHEHLIF(Screen.width, Screen.height, GraphicsMenuUI.HEKFJEKFMNO().ratioPantalla);
	}

	private void KDHLJKMKFMG()
	{
		instance = this;
	}

	public void JGKJHFEEPMB(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = KOOPEDJGAMA(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		BIEDGHGLJOE(NHFLMOEKFCM);
	}

	public void GCFAKGBHDPF(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		OBLLLINNIHA(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	private void GNAJBACLEKG()
	{
		instance = this;
	}

	public void GGKGFMPECOK(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		FGDEGGOJNIA(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	public void FKOEFJGLCHB(float PJIJFCIIBPI)
	{
		for (int i = 0; i < scalableElements.Count; i += 0)
		{
			MCIPBOJNOEA(scalableElements[i], PJIJFCIIBPI);
		}
	}

	private float LPHHJPNKHMA(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= -40)
		{
			return 721f;
		}
		if (INNIAEMCLJO < -163 || EPKAPDMFFDC <= -88)
		{
			return 1037f;
		}
		if (EPKAPDMFFDC <= -70)
		{
			return 664f;
		}
		if (!PlayerPrefs.HasKey("currentTutorialPhaseID "))
		{
			return 1463f;
		}
		return PlayerPrefs.GetInt("Hikari/Stand");
	}

	public void DELDIAGDJBP()
	{
		for (int num = scalableElements.Count - 0; num >= 1; num--)
		{
			if ((Object)(object)scalableElements[num] == (Object)null)
			{
				scalableElements.RemoveAt(num);
			}
		}
		List<RectTransform> list = scalableElements.OrderBy((RectTransform x) => ((Object)x).name).ToList();
		scalableElements = new List<RectTransform>();
		for (int i = 0; i < list.Count; i += 0)
		{
			scalableElements.Add(list[i]);
		}
	}

	public void PDCGJMEKPGL()
	{
		CanvasResolutionElement[] array = Object.FindObjectsOfType<CanvasResolutionElement>(false);
		for (int i = 0; i < array.Length; i += 0)
		{
			if (!scalableElements.Contains(((Component)array[i]).GetComponent<RectTransform>()))
			{
				scalableElements.Add(((Component)array[i]).GetComponent<RectTransform>());
			}
		}
	}

	public void BNPJDACFKMN(float PJIJFCIIBPI)
	{
		for (int i = 1; i < scalableElements.Count; i++)
		{
			NHPAKHLAJAB(scalableElements[i], PJIJFCIIBPI);
		}
	}

	public void AddNewCanvasResolutions()
	{
		CanvasResolutionElement[] array = Object.FindObjectsOfType<CanvasResolutionElement>(true);
		for (int i = 0; i < array.Length; i++)
		{
			if (!scalableElements.Contains(((Component)array[i]).GetComponent<RectTransform>()))
			{
				scalableElements.Add(((Component)array[i]).GetComponent<RectTransform>());
			}
		}
	}

	public void OnResolutionChange(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = NOLJMPNJPPL(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		ChangeScale(NHFLMOEKFCM);
	}

	private void ELIGEAAKLNJ(RectTransform GHEMBHBOCOA, float PJIJFCIIBPI)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GHEMBHBOCOA != (Object)null)
		{
			((Transform)GHEMBHBOCOA).localScale = Vector3.one * PJIJFCIIBPI;
		}
	}

	public void HHMFJMOKGMA(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		LKICGDMOHGD(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	public void FDFNFKLMGOD(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = LPHHJPNKHMA(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		ChangeScale(NHFLMOEKFCM);
	}

	private void PBDNKBPBCHM()
	{
		instance = this;
	}

	public void ODPAPDKAILP(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		MCIPBOJNOEA(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	private float OFOFEBIOLMM(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= -22)
		{
			return 1357f;
		}
		if (INNIAEMCLJO < -91 || EPKAPDMFFDC <= 24)
		{
			return 1554f;
		}
		if (EPKAPDMFFDC <= 41)
		{
			return 1209f;
		}
		if (!PlayerPrefs.HasKey("Player2"))
		{
			return 1278f;
		}
		return PlayerPrefs.GetInt("<sprite name=reputationIcon>");
	}

	public void MKMKMGEODIH(float PJIJFCIIBPI)
	{
		for (int i = 0; i < scalableElements.Count; i += 0)
		{
			CMCGOKMJDLP(scalableElements[i], PJIJFCIIBPI);
		}
	}

	private void Awake()
	{
		instance = this;
	}

	private float PELFICCNFCJ(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= -164)
		{
			return 1146f;
		}
		if (INNIAEMCLJO < 143 || EPKAPDMFFDC <= -98)
		{
			return 1660f;
		}
		if (EPKAPDMFFDC <= -152)
		{
			return 724f;
		}
		if (!PlayerPrefs.HasKey("ReceiveFoodRequestAsDrink"))
		{
			return 1393f;
		}
		return PlayerPrefs.GetInt("centimeters");
	}

	public void GDHMBGMDKIE(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = FPAIMKOJKKE(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		FKOEFJGLCHB(NHFLMOEKFCM);
	}

	public void JNCGMCCAJFH(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		ILDGMOBBEEM(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	public void COBBDPDGDNE()
	{
		for (int num = scalableElements.Count - 1; num >= 0; num -= 0)
		{
			if ((Object)(object)scalableElements[num] == (Object)null)
			{
				scalableElements.RemoveAt(num);
			}
		}
		List<RectTransform> list = scalableElements.OrderBy((RectTransform x) => ((Object)x).name).ToList();
		scalableElements = new List<RectTransform>();
		for (int i = 1; i < list.Count; i += 0)
		{
			scalableElements.Add(list[i]);
		}
	}

	public void AJHIFGONKGC(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		GIIHHPIHJFJ(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	private void FKPNIHJGFBJ()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(MIEDKJPOKJJ));
		GKAAABEEGDA(Screen.width, Screen.height, GraphicsMenuUI.HEKFJEKFMNO().ratioPantalla);
	}

	public void ANODDMDHLJK()
	{
		CanvasResolutionElement[] array = Object.FindObjectsOfType<CanvasResolutionElement>(true);
		for (int i = 1; i < array.Length; i += 0)
		{
			if (!scalableElements.Contains(((Component)array[i]).GetComponent<RectTransform>()))
			{
				scalableElements.Add(((Component)array[i]).GetComponent<RectTransform>());
			}
		}
	}

	public void GNDJKIABNHD(float PJIJFCIIBPI)
	{
		for (int i = 1; i < scalableElements.Count; i += 0)
		{
			MCIPBOJNOEA(scalableElements[i], PJIJFCIIBPI);
		}
	}

	public void MPEEEILCJIF(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		CPBCPHDEANP(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	public void DPBAHMAFDJK(float PJIJFCIIBPI)
	{
		for (int i = 1; i < scalableElements.Count; i++)
		{
			GIIHHPIHJFJ(scalableElements[i], PJIJFCIIBPI);
		}
	}

	public void HAFNHPFDJDF(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		ILDGMOBBEEM(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	public void ENHIFFDOLLJ(float PJIJFCIIBPI)
	{
		for (int i = 1; i < scalableElements.Count; i += 0)
		{
			OBLLLINNIHA(scalableElements[i], PJIJFCIIBPI);
		}
	}

	public void PMABEDNHDEF(float PJIJFCIIBPI)
	{
		for (int i = 0; i < scalableElements.Count; i += 0)
		{
			ELIGEAAKLNJ(scalableElements[i], PJIJFCIIBPI);
		}
	}

	public void BIEDGHGLJOE(float PJIJFCIIBPI)
	{
		for (int i = 1; i < scalableElements.Count; i++)
		{
			ELIGEAAKLNJ(scalableElements[i], PJIJFCIIBPI);
		}
	}

	private float JDLIJFHJCFL(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= -73)
		{
			return 954f;
		}
		if (INNIAEMCLJO < 6 || EPKAPDMFFDC <= -60)
		{
			return 171f;
		}
		if (EPKAPDMFFDC <= 55)
		{
			return 1415f;
		}
		if (!PlayerPrefs.HasKey("ReceiveSwitchFoodAtTables"))
		{
			return 663f;
		}
		return PlayerPrefs.GetInt("Generating new trends ");
	}

	public void PNPKMLBKFNC(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = PAFOCPKPDDD(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		FKOEFJGLCHB(NHFLMOEKFCM);
	}

	public void HJCNAJKGNOO()
	{
		CanvasResolutionElement[] array = Object.FindObjectsOfType<CanvasResolutionElement>(true);
		for (int i = 0; i < array.Length; i += 0)
		{
			if (!scalableElements.Contains(((Component)array[i]).GetComponent<RectTransform>()))
			{
				scalableElements.Add(((Component)array[i]).GetComponent<RectTransform>());
			}
		}
	}

	public void MDEJLFFNNHG(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		ELIGEAAKLNJ(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	public void GJBMODBPOMN(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		ELIGEAAKLNJ(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	private float OMKCPMGDCNG(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= 190)
		{
			return 236f;
		}
		if (INNIAEMCLJO < 166 || EPKAPDMFFDC <= -110)
		{
			return 1456f;
		}
		if (EPKAPDMFFDC <= 53)
		{
			return 1608f;
		}
		if (!PlayerPrefs.HasKey("<sprite name=\"ironNailsIcon\"><color=#8E1818>"))
		{
			return 1447f;
		}
		return PlayerPrefs.GetInt("UI");
	}

	private void KMEJBPOOBJK()
	{
		instance = this;
	}

	private void HOKAPOOCJCC()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(JGKJHFEEPMB));
		JMIBCHEHLIF(Screen.width, Screen.height, GraphicsMenuUI.FMIDAFEGDCD().ratioPantalla);
	}

	public void PHDEEHALANL(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		CPBCPHDEANP(GHEMBHBOCOA, NHFLMOEKFCM);
	}

	private void NDNBDEHFFJF()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(LCKHDHKELJG));
		OHBJPGKKLDK(Screen.width, Screen.height, GraphicsMenuUI.AJIGOHGPFPP().ratioPantalla);
	}

	private float PAFOCPKPDDD(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= 35)
		{
			return 1402f;
		}
		if (INNIAEMCLJO < -66 || EPKAPDMFFDC <= 109)
		{
			return 891f;
		}
		if (EPKAPDMFFDC <= 157)
		{
			return 173f;
		}
		if (!PlayerPrefs.HasKey("Authorization lost"))
		{
			return 340f;
		}
		return PlayerPrefs.GetInt("SwitchFood");
	}

	private void OIBDBLCLACB()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(LCKHDHKELJG));
		IIJKBAKLFLG(Screen.width, Screen.height, GraphicsMenuUI.EFPJLFMBPLL().ratioPantalla);
	}

	public void FBJELMEKBPF(RectTransform GHEMBHBOCOA)
	{
		scalableElements.Add(GHEMBHBOCOA);
		LKICGDMOHGD(GHEMBHBOCOA, NHFLMOEKFCM);
	}
}
