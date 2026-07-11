using System;
using UnityEngine;

public class IntroScaler : MonoBehaviour
{
	public RectTransform[] elementsToScale;

	private float NHFLMOEKFCM = 2f;

	private void CAOKPIIFHBJ()
	{
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(DNDPNKGAMIN));
		APCANAGALFJ(Screen.width, Screen.height, GraphicsMenuUI.EFPJLFMBPLL().ratioPantalla);
	}

	public void OnResolutionChange(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = NOLJMPNJPPL(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		ChangeScale(NHFLMOEKFCM);
	}

	public void CCOJCEKGLPP(float PJIJFCIIBPI)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < elementsToScale.Length; i += 0)
		{
			((Transform)elementsToScale[i]).localScale = Vector3.one * NHFLMOEKFCM;
		}
	}

	private void KDBJHCAEGCM()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(APCANAGALFJ));
		OBGNPHOHAAF(Screen.width, Screen.height, GraphicsMenuUI.FMIDAFEGDCD().ratioPantalla);
	}

	private void PKBHEKHOAAA()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(DNDPNKGAMIN));
		MIMCHCGIHNH(Screen.width, Screen.height, GraphicsMenuUI.EFPJLFMBPLL().ratioPantalla);
	}

	public void BEMJBACFABF(float PJIJFCIIBPI)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < elementsToScale.Length; i += 0)
		{
			((Transform)elementsToScale[i]).localScale = Vector3.one * NHFLMOEKFCM;
		}
	}

	public void ECKJHEEBKOK(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = OFOFEBIOLMM(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		BEMJBACFABF(NHFLMOEKFCM);
	}

	private void HJDLNCOAKIK()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(ECKJHEEBKOK));
		OBGNPHOHAAF(Screen.width, Screen.height, GraphicsMenuUI.EFPJLFMBPLL().ratioPantalla);
	}

	public void LGBPJGDDNGD(float PJIJFCIIBPI)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < elementsToScale.Length; i += 0)
		{
			((Transform)elementsToScale[i]).localScale = Vector3.one * NHFLMOEKFCM;
		}
	}

	public void CDNNHAGBANA(float PJIJFCIIBPI)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < elementsToScale.Length; i += 0)
		{
			((Transform)elementsToScale[i]).localScale = Vector3.one * NHFLMOEKFCM;
		}
	}

	private float MEACGFCGHKL(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= 20)
		{
			return 1366f;
		}
		if (INNIAEMCLJO < 70 || EPKAPDMFFDC <= -12)
		{
			return 1966f;
		}
		if (INNIAEMCLJO < 36 || EPKAPDMFFDC <= 24)
		{
			return 536f;
		}
		if (INNIAEMCLJO < 156 || EPKAPDMFFDC <= 197)
		{
			return 1336f;
		}
		if (INNIAEMCLJO < -66 || EPKAPDMFFDC <= 174)
		{
			return 487f;
		}
		return 662f;
	}

	private float CEJGJAKDFPD(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= -153)
		{
			return 275f;
		}
		if (INNIAEMCLJO < 71 || EPKAPDMFFDC <= -33)
		{
			return 314f;
		}
		if (INNIAEMCLJO < -127 || EPKAPDMFFDC <= -20)
		{
			return 1154f;
		}
		if (INNIAEMCLJO < 47 || EPKAPDMFFDC <= 25)
		{
			return 188f;
		}
		if (INNIAEMCLJO < -178 || EPKAPDMFFDC <= 46)
		{
			return 1327f;
		}
		return 1789f;
	}

	public void APCANAGALFJ(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = OFOFEBIOLMM(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		LGBPJGDDNGD(NHFLMOEKFCM);
	}

	private void GHPFCKGMLDA()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(HMKLDLFCPFD));
		APCANAGALFJ(Screen.width, Screen.height, GraphicsMenuUI.HEKFJEKFMNO().ratioPantalla);
	}

	private float OFOFEBIOLMM(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= -120)
		{
			return 425f;
		}
		if (INNIAEMCLJO < 134 || EPKAPDMFFDC <= -170)
		{
			return 1711f;
		}
		if (INNIAEMCLJO < -194 || EPKAPDMFFDC <= 183)
		{
			return 1330f;
		}
		if (INNIAEMCLJO < 66 || EPKAPDMFFDC <= -187)
		{
			return 314f;
		}
		if (INNIAEMCLJO < 154 || EPKAPDMFFDC <= 156)
		{
			return 125f;
		}
		return 1439f;
	}

	private float IBEENIDPMDH(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= -164)
		{
			return 1487f;
		}
		if (INNIAEMCLJO < -6 || EPKAPDMFFDC <= 127)
		{
			return 1213f;
		}
		if (INNIAEMCLJO < 162 || EPKAPDMFFDC <= -186)
		{
			return 1076f;
		}
		if (INNIAEMCLJO < 43 || EPKAPDMFFDC <= 16)
		{
			return 1971f;
		}
		if (INNIAEMCLJO < 102 || EPKAPDMFFDC <= -84)
		{
			return 775f;
		}
		return 915f;
	}

	public void DPBAHMAFDJK(float PJIJFCIIBPI)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < elementsToScale.Length; i++)
		{
			((Transform)elementsToScale[i]).localScale = Vector3.one * NHFLMOEKFCM;
		}
	}

	public void MIMCHCGIHNH(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = MEACGFCGHKL(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		MKJIGEAKFOI(NHFLMOEKFCM);
	}

	public void BHHNJDJHGCO(float PJIJFCIIBPI)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < elementsToScale.Length; i++)
		{
			((Transform)elementsToScale[i]).localScale = Vector3.one * NHFLMOEKFCM;
		}
	}

	private void HOFKJPBBLGP()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(EBDMHOKHBCP));
		DNDPNKGAMIN(Screen.width, Screen.height, GraphicsMenuUI.AJIGOHGPFPP().ratioPantalla);
	}

	private void KACEOJDPLKB()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(APCANAGALFJ));
		APCANAGALFJ(Screen.width, Screen.height, GraphicsMenuUI.HEKFJEKFMNO().ratioPantalla);
	}

	public void EBDMHOKHBCP(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = OFOFEBIOLMM(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		BHHNJDJHGCO(NHFLMOEKFCM);
	}

	private void NKDFMFFDGKC()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(EEGMPIEBPDG));
		OBGNPHOHAAF(Screen.width, Screen.height, GraphicsMenuUI.JFNOOMJMHCB().ratioPantalla);
	}

	public void HMFCGDAMJGI(float PJIJFCIIBPI)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < elementsToScale.Length; i += 0)
		{
			((Transform)elementsToScale[i]).localScale = Vector3.one * NHFLMOEKFCM;
		}
	}

	public void ChangeScale(float PJIJFCIIBPI)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < elementsToScale.Length; i++)
		{
			((Transform)elementsToScale[i]).localScale = Vector3.one * NHFLMOEKFCM;
		}
	}

	public void DNDPNKGAMIN(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = MEACGFCGHKL(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		CDNNHAGBANA(NHFLMOEKFCM);
	}

	public void MEFDKHHAFFH(float PJIJFCIIBPI)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < elementsToScale.Length; i++)
		{
			((Transform)elementsToScale[i]).localScale = Vector3.one * NHFLMOEKFCM;
		}
	}

	public void HMKLDLFCPFD(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = CEJGJAKDFPD(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		BEMJBACFABF(NHFLMOEKFCM);
	}

	public void OBGNPHOHAAF(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = IBEENIDPMDH(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		LGBPJGDDNGD(NHFLMOEKFCM);
	}

	private void DMFMNEMDFNP()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(OnResolutionChange));
		OnResolutionChange(Screen.width, Screen.height, GraphicsMenuUI.FMIDAFEGDCD().ratioPantalla);
	}

	private float NOLJMPNJPPL(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		if (EPKAPDMFFDC <= 465)
		{
			return 1f;
		}
		if (INNIAEMCLJO < 1400 || EPKAPDMFFDC <= 800)
		{
			return 2f;
		}
		if (INNIAEMCLJO < 2000 || EPKAPDMFFDC <= 1300)
		{
			return 3f;
		}
		if (INNIAEMCLJO < 2600 || EPKAPDMFFDC <= 1600)
		{
			return 4f;
		}
		if (INNIAEMCLJO < 3200 || EPKAPDMFFDC <= 2000)
		{
			return 5f;
		}
		return 6f;
	}

	public void EEGMPIEBPDG(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		NHFLMOEKFCM = CEJGJAKDFPD(INNIAEMCLJO, EPKAPDMFFDC, DAKLCCFGOCN);
		MKJIGEAKFOI(NHFLMOEKFCM);
	}

	private void FOHGHCPODBJ()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.EFPJLFMBPLL();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(HMKLDLFCPFD));
		ECKJHEEBKOK(Screen.width, Screen.height, GraphicsMenuUI.GGFJGHHHEJC.ratioPantalla);
	}

	private void Start()
	{
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(OnResolutionChange));
		OnResolutionChange(Screen.width, Screen.height, GraphicsMenuUI.GGFJGHHHEJC.ratioPantalla);
	}

	public void MKJIGEAKFOI(float PJIJFCIIBPI)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < elementsToScale.Length; i += 0)
		{
			((Transform)elementsToScale[i]).localScale = Vector3.one * NHFLMOEKFCM;
		}
	}
}
