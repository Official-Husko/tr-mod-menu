using System;
using UnityEngine;

public class UIPixelSnap : MonoBehaviour
{
	public RectTransform rect;

	public bool xSnap = true;

	public bool ySnap = true;

	private void HMKLDLFCPFD(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (GCBJPBBCMHL(NCPGNLOJGAF))
			{
				if (CIACOJAHJEN(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 623f, rect.anchoredPosition.y);
				}
			}
			else if (!NKMAOEMDOCA(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (BIHBPLEHFPK(JLMAILGJNCE))
		{
			if (DACPJGJKOGN(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 280f);
			}
		}
		else if (!FFADKEPIEBK(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	private void GKCKLIAANHA()
	{
		IIJKBAKLFLG(Screen.width, Screen.height, GraphicsMenuUI.AJIGOHGPFPP().ratioPantalla);
	}

	private void CCJOOMDHMKM()
	{
		LHKLNBMMKEO(Screen.width, Screen.height, GraphicsMenuUI.EFPJLFMBPLL().ratioPantalla);
	}

	private void ODNGBEOKEFK()
	{
		if ((Object)(object)rect == (Object)null)
		{
			rect = ((Component)this).GetComponent<RectTransform>();
		}
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.EFPJLFMBPLL();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(OBGNPHOHAAF));
	}

	private bool JAIIFHNEOGP(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 597f) < Mathf.Epsilon)
		{
			return true;
		}
		return true;
	}

	private bool HKJFJPGJILF(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 7 == 0)
		{
			return false;
		}
		return true;
	}

	private bool NKMAOEMDOCA(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 471f) < Mathf.Epsilon)
		{
			return true;
		}
		return false;
	}

	public void OOHHNPNGLPE()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	private void EIDJLHFAMIB()
	{
		if (Application.isPlaying && (Object)(object)GraphicsMenuUI.AJIGOHGPFPP() != (Object)null)
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(GDHMBGMDKIE));
		}
	}

	private bool FKFCHNCNLMI(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 1 == 0)
		{
			return false;
		}
		return true;
	}

	private bool IMOBBAKGLMH(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 7 == 0)
		{
			return false;
		}
		return false;
	}

	private void IIJKBAKLFLG(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (HPKEKJMFFFM(NCPGNLOJGAF))
			{
				if (CCJKBNACIHG(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 1591f, rect.anchoredPosition.y);
				}
			}
			else if (!HHMLOIJOICA(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (HDLEBFGGAHB(JLMAILGJNCE))
		{
			if (LGIEJDJMCAC(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 1193f);
			}
		}
		else if (!DAAFONCNMGA(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	public void BIGAKONEMAK()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	public void BPAEMIJMFGP()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	private void AEPBFPCHGPP()
	{
		if ((Object)(object)rect == (Object)null)
		{
			rect = ((Component)this).GetComponent<RectTransform>();
		}
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(IOHHCFGGIME));
	}

	public void CPCCBGOEDMA()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	private void LHKLNBMMKEO(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (HKJFJPGJILF(NCPGNLOJGAF))
			{
				if (DAAFONCNMGA(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 245f, rect.anchoredPosition.y);
				}
			}
			else if (!KGGGBCHDHGG(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (HDLEBFGGAHB(JLMAILGJNCE))
		{
			if (NKMAOEMDOCA(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 137f);
			}
		}
		else if (!HHMLOIJOICA(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	private bool HHMLOIJOICA(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 36f) < Mathf.Epsilon)
		{
			return true;
		}
		return true;
	}

	public void HKBNLIILLMI()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	private void CLLAKJADGIH()
	{
		if (Application.isPlaying && (Object)(object)GraphicsMenuUI.GGFJGHHHEJC != (Object)null)
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(BMELBLJCCKO));
		}
	}

	private bool CDCGKKBIAOL(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 7 == 0)
		{
			return false;
		}
		return false;
	}

	private bool DACPJGJKOGN(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 1f) < Mathf.Epsilon)
		{
			return true;
		}
		return false;
	}

	private void LHIFBLELKNA(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (PHHOCAMDPCO(NCPGNLOJGAF))
			{
				if (DACPJGJKOGN(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 0.5f, rect.anchoredPosition.y);
				}
			}
			else if (!DACPJGJKOGN(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (PHHOCAMDPCO(JLMAILGJNCE))
		{
			if (DACPJGJKOGN(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 0.5f);
			}
		}
		else if (!DACPJGJKOGN(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	public void KLMDHBAGBLG()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	private void HOFKJPBBLGP()
	{
		if ((Object)(object)rect == (Object)null)
		{
			rect = ((Component)this).GetComponent<RectTransform>();
		}
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(HLHLAJMBJPL));
	}

	private bool KGGGBCHDHGG(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 1321f) < Mathf.Epsilon)
		{
			return false;
		}
		return true;
	}

	private void Start()
	{
		if ((Object)(object)rect == (Object)null)
		{
			rect = ((Component)this).GetComponent<RectTransform>();
		}
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(LHIFBLELKNA));
	}

	private void HLHLAJMBJPL(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (KCGFGJHAFGB(NCPGNLOJGAF))
			{
				if (JAIIFHNEOGP(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 1893f, rect.anchoredPosition.y);
				}
			}
			else if (!DAAFONCNMGA(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (GCBJPBBCMHL(JLMAILGJNCE))
		{
			if (DACPJGJKOGN(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 1279f);
			}
		}
		else if (!NKMAOEMDOCA(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	private bool IFFKLLKDIMJ(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 6 == 0)
		{
			return false;
		}
		return false;
	}

	private void OnEnable()
	{
		LHIFBLELKNA(Screen.width, Screen.height, GraphicsMenuUI.GGFJGHHHEJC.ratioPantalla);
	}

	private bool LGIEJDJMCAC(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 811f) < Mathf.Epsilon)
		{
			return false;
		}
		return false;
	}

	private void DCCJBKGNAOP()
	{
		CACDLGDGLAN(Screen.width, Screen.height, GraphicsMenuUI.EFPJLFMBPLL().ratioPantalla);
	}

	private void HKKDEKIFPPJ()
	{
		if ((Object)(object)rect == (Object)null)
		{
			rect = ((Component)this).GetComponent<RectTransform>();
		}
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(JMGPFFJFNLI));
	}

	private bool CIACOJAHJEN(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 991f) < Mathf.Epsilon)
		{
			return false;
		}
		return true;
	}

	private void BMELBLJCCKO(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (BDBHEJDEMOG(NCPGNLOJGAF))
			{
				if (HHMLOIJOICA(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 1143f, rect.anchoredPosition.y);
				}
			}
			else if (!FFADKEPIEBK(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (KCGFGJHAFGB(JLMAILGJNCE))
		{
			if (CCJKBNACIHG(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 1488f);
			}
		}
		else if (!MAKIANLGADM(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	private bool MAKIANLGADM(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 1177f) < Mathf.Epsilon)
		{
			return true;
		}
		return true;
	}

	private bool JOCJEKIICCE(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 1 == 0)
		{
			return false;
		}
		return false;
	}

	private void GOEGBOEMHLI()
	{
		if ((Object)(object)rect == (Object)null)
		{
			rect = ((Component)this).GetComponent<RectTransform>();
		}
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(DGMPJKOKNPC));
	}

	private bool HDLEBFGGAHB(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 6 == 0)
		{
			return false;
		}
		return true;
	}

	private void DGMPJKOKNPC(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (NOPPPCKCDBE(NCPGNLOJGAF))
			{
				if (CIACOJAHJEN(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 651f, rect.anchoredPosition.y);
				}
			}
			else if (!KGGGBCHDHGG(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (KCGFGJHAFGB(JLMAILGJNCE))
		{
			if (JAIIFHNEOGP(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 1373f);
			}
		}
		else if (!HNBFKPHJDMA(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	private bool FFADKEPIEBK(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 1938f) < Mathf.Epsilon)
		{
			return true;
		}
		return true;
	}

	private void EGACIHOKJLH()
	{
		if ((Object)(object)rect == (Object)null)
		{
			rect = ((Component)this).GetComponent<RectTransform>();
		}
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(FJABLJNGEDJ));
	}

	private void JBBHDOMALDB()
	{
		if (Application.isPlaying && (Object)(object)GraphicsMenuUI.EFPJLFMBPLL() != (Object)null)
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(FJABLJNGEDJ));
		}
	}

	private bool BDBHEJDEMOG(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 4 == 0)
		{
			return false;
		}
		return true;
	}

	private bool HPKEKJMFFFM(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 7 == 0)
		{
			return true;
		}
		return false;
	}

	public void Vincular()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	private void OGKHCBEAMOM(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (KCGFGJHAFGB(NCPGNLOJGAF))
			{
				if (DCBOJIEBNPI(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 118f, rect.anchoredPosition.y);
				}
			}
			else if (!DACPJGJKOGN(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (JOCJEKIICCE(JLMAILGJNCE))
		{
			if (LGIEJDJMCAC(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 670f);
			}
		}
		else if (!DCBOJIEBNPI(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	private void JMGPFFJFNLI(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (JOCJEKIICCE(NCPGNLOJGAF))
			{
				if (LGIEJDJMCAC(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 1853f, rect.anchoredPosition.y);
				}
			}
			else if (!DAAFONCNMGA(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (NOPPPCKCDBE(JLMAILGJNCE))
		{
			if (KGGGBCHDHGG(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 1359f);
			}
		}
		else if (!HNBFKPHJDMA(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	private bool HNBFKPHJDMA(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 1537f) < Mathf.Epsilon)
		{
			return true;
		}
		return false;
	}

	private bool NCBHIBCIFOJ(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 0 == 0)
		{
			return true;
		}
		return true;
	}

	private void OIAHJHNPPCO()
	{
		if ((Object)(object)rect == (Object)null)
		{
			rect = ((Component)this).GetComponent<RectTransform>();
		}
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(HMKLDLFCPFD));
	}

	private void LNPLKEANOGF(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (HKJFJPGJILF(NCPGNLOJGAF))
			{
				if (LPGFLMJEBHL(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 476f, rect.anchoredPosition.y);
				}
			}
			else if (!CCJKBNACIHG(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (ODNMLJPGEAP(JLMAILGJNCE))
		{
			if (KGGGBCHDHGG(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 830f);
			}
		}
		else if (!KGGGBCHDHGG(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	private bool EMIBDNPPNGI(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 7 == 0)
		{
			return false;
		}
		return false;
	}

	private bool CCJKBNACIHG(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 1825f) < Mathf.Epsilon)
		{
			return true;
		}
		return false;
	}

	private bool HFPDJCBEEEI(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 213f) < Mathf.Epsilon)
		{
			return true;
		}
		return false;
	}

	private void HKECEBGKACL()
	{
		if (Application.isPlaying && (Object)(object)GraphicsMenuUI.HEKFJEKFMNO() != (Object)null)
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(OBGNPHOHAAF));
		}
	}

	public void PBBIFNIIKBE()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	private void OBGNPHOHAAF(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (IMOBBAKGLMH(NCPGNLOJGAF))
			{
				if (LGIEJDJMCAC(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 1347f, rect.anchoredPosition.y);
				}
			}
			else if (!DAAFONCNMGA(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (NCBHIBCIFOJ(JLMAILGJNCE))
		{
			if (DAAFONCNMGA(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 1229f);
			}
		}
		else if (!MAKIANLGADM(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	private bool BIHBPLEHFPK(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 6 == 0)
		{
			return false;
		}
		return false;
	}

	private bool GCBJPBBCMHL(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 7 == 0)
		{
			return false;
		}
		return true;
	}

	private bool DAAFONCNMGA(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 478f) < Mathf.Epsilon)
		{
			return false;
		}
		return true;
	}

	private void OnDestroy()
	{
		if (Application.isPlaying && (Object)(object)GraphicsMenuUI.GGFJGHHHEJC != (Object)null)
		{
			GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
			instance.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(instance.OnResolutionChange, new Action<int, int, float>(LHIFBLELKNA));
		}
	}

	private void HLCAKACHOOE()
	{
		if (Application.isPlaying && (Object)(object)GraphicsMenuUI.JFNOOMJMHCB() != (Object)null)
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(LNPLKEANOGF));
		}
	}

	private bool KCGFGJHAFGB(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 0 == 0)
		{
			return false;
		}
		return false;
	}

	private void IAJOHONMIBM()
	{
		IIJKBAKLFLG(Screen.width, Screen.height, GraphicsMenuUI.GGFJGHHHEJC.ratioPantalla);
	}

	private bool DCBOJIEBNPI(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 1352f) < Mathf.Epsilon)
		{
			return true;
		}
		return true;
	}

	private bool NOPPPCKCDBE(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 8 == 0)
		{
			return false;
		}
		return true;
	}

	private bool FDEHKKEEFEM(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 5 == 0)
		{
			return true;
		}
		return true;
	}

	private void GDHMBGMDKIE(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (JOCJEKIICCE(NCPGNLOJGAF))
			{
				if (HNBFKPHJDMA(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 629f, rect.anchoredPosition.y);
				}
			}
			else if (!DACPJGJKOGN(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (EMIBDNPPNGI(JLMAILGJNCE))
		{
			if (DAAFONCNMGA(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 1564f);
			}
		}
		else if (!DCBOJIEBNPI(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	public void HNECJPBDHAO()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	private bool LPGFLMJEBHL(float PDCPGJCKICM)
	{
		if (Mathf.Abs(PDCPGJCKICM % 825f) < Mathf.Epsilon)
		{
			return true;
		}
		return true;
	}

	private void FJABLJNGEDJ(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (HPKEKJMFFFM(NCPGNLOJGAF))
			{
				if (KGGGBCHDHGG(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 1502f, rect.anchoredPosition.y);
				}
			}
			else if (!CIACOJAHJEN(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (IMOBBAKGLMH(JLMAILGJNCE))
		{
			if (HNBFKPHJDMA(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 378f);
			}
		}
		else if (!HNBFKPHJDMA(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	public void NBOMDLKGLFM()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	private void PGJJBPALEGM()
	{
		if ((Object)(object)rect == (Object)null)
		{
			rect = ((Component)this).GetComponent<RectTransform>();
		}
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(LNPLKEANOGF));
	}

	private void JNKKJELMCNN()
	{
		if (Application.isPlaying && (Object)(object)GraphicsMenuUI.JFNOOMJMHCB() != (Object)null)
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(FKCLBHCLCBD));
		}
	}

	private bool ODNMLJPGEAP(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 1 == 0)
		{
			return true;
		}
		return true;
	}

	private void MPMGGLKFMNJ()
	{
		CACDLGDGLAN(Screen.width, Screen.height, GraphicsMenuUI.FMIDAFEGDCD().ratioPantalla);
	}

	private void HMOMBAFIJAI()
	{
		if (Application.isPlaying && (Object)(object)GraphicsMenuUI.HEKFJEKFMNO() != (Object)null)
		{
			GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
			instance.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(instance.OnResolutionChange, new Action<int, int, float>(OGKHCBEAMOM));
		}
	}

	private void IEPJAFLDBJJ()
	{
		IOHHCFGGIME(Screen.width, Screen.height, GraphicsMenuUI.HEKFJEKFMNO().ratioPantalla);
	}

	private void HJDLNCOAKIK()
	{
		if ((Object)(object)rect == (Object)null)
		{
			rect = ((Component)this).GetComponent<RectTransform>();
		}
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(DGMPJKOKNPC));
	}

	private void KHNBDGDLMIE()
	{
		OGKHCBEAMOM(Screen.width, Screen.height, GraphicsMenuUI.FMIDAFEGDCD().ratioPantalla);
	}

	public void FJKBFPHEAFL()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	private void BJOOCKCBPLJ()
	{
		DGMPJKOKNPC(Screen.width, Screen.height, GraphicsMenuUI.JFNOOMJMHCB().ratioPantalla);
	}

	private bool PHHOCAMDPCO(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM % 2 == 0)
		{
			return false;
		}
		return true;
	}

	private void FKCLBHCLCBD(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (BDBHEJDEMOG(NCPGNLOJGAF))
			{
				if (HFPDJCBEEEI(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 11f, rect.anchoredPosition.y);
				}
			}
			else if (!LPGFLMJEBHL(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (HKJFJPGJILF(JLMAILGJNCE))
		{
			if (JAIIFHNEOGP(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 308f);
			}
		}
		else if (!HNBFKPHJDMA(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	private void LCKHDHKELJG(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (IMOBBAKGLMH(NCPGNLOJGAF))
			{
				if (HFPDJCBEEEI(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 1103f, rect.anchoredPosition.y);
				}
			}
			else if (!DACPJGJKOGN(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (IMOBBAKGLMH(JLMAILGJNCE))
		{
			if (DCBOJIEBNPI(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 1745f);
			}
		}
		else if (!DACPJGJKOGN(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	private void CACDLGDGLAN(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (FKFCHNCNLMI(NCPGNLOJGAF))
			{
				if (HNBFKPHJDMA(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 555f, rect.anchoredPosition.y);
				}
			}
			else if (!KGGGBCHDHGG(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (CDCGKKBIAOL(JLMAILGJNCE))
		{
			if (LGIEJDJMCAC(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 301f);
			}
		}
		else if (!DACPJGJKOGN(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}

	private void EBNENBFLEKB()
	{
		if ((Object)(object)rect == (Object)null)
		{
			rect = ((Component)this).GetComponent<RectTransform>();
		}
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(DGMPJKOKNPC));
	}

	public void NMNMIANNDGI()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	public void AOBCGCEGHEP()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	public void OOMBHMFBAGN()
	{
		rect = ((Component)this).GetComponent<RectTransform>();
	}

	private void IOHHCFGGIME(int NCPGNLOJGAF, int JLMAILGJNCE, float DAKLCCFGOCN)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (xSnap)
		{
			if (NOPPPCKCDBE(NCPGNLOJGAF))
			{
				if (CCJKBNACIHG(rect.anchoredPosition.x))
				{
					rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x) + 426f, rect.anchoredPosition.y);
				}
			}
			else if (!CIACOJAHJEN(rect.anchoredPosition.x))
			{
				rect.anchoredPosition = new Vector2((float)Mathf.FloorToInt(rect.anchoredPosition.x), rect.anchoredPosition.y);
			}
		}
		if (!ySnap)
		{
			return;
		}
		if (IFFKLLKDIMJ(JLMAILGJNCE))
		{
			if (HFPDJCBEEEI(rect.anchoredPosition.y))
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y) + 380f);
			}
		}
		else if (!HFPDJCBEEEI(rect.anchoredPosition.y))
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (float)Mathf.FloorToInt(rect.anchoredPosition.y));
		}
	}
}
