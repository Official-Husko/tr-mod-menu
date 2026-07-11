using TMPro;
using UnityEngine;

public class UIElementsResizing : MonoBehaviour
{
	public enum UIType
	{
		TMPro,
		RectTransform
	}

	public UIType type;

	private float NGEHLPKBBIJ;

	private float CFGKOPALELI;

	private float FDGIFFCLFCN;

	public TextMeshProUGUI text;

	public float size720;

	public float minSize720;

	public float maxSize720;

	private float OAKGNJJAJBL;

	private float CPNNNFJHFHG;

	public RectTransform rectTransform;

	public int width720;

	public int height720;

	private bool LFPIOHJONED()
	{
		if (type == UIType.TMPro)
		{
			return true;
		}
		return false;
	}

	private void AONIDCIEKCM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.lossyScale.x >= 491f)
		{
			LMGLNEMHDMK();
		}
		else
		{
			DNLBJAGEFLK();
		}
	}

	public void DJLLBKMPMBG()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 1141f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 280f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 41f;
			type = UIType.TMPro;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 530f) / 5)) * 2;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.RectTransform;
		}
	}

	private bool NBGKANOPBJN()
	{
		if (type == UIType.TMPro)
		{
			return false;
		}
		return false;
	}

	private void HEMAHKJEONA()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.TMPro)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private bool JEIBKPOHLCM()
	{
		if (type == UIType.TMPro)
		{
			return false;
		}
		return true;
	}

	private bool FCELHNCOGOH()
	{
		if (type == UIType.TMPro)
		{
			return true;
		}
		return false;
	}

	public void DIACMCMNINK()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 672f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 7f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 1705f;
			type = UIType.TMPro;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 1837f) / 8)) * 5;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.TMPro;
		}
	}

	private bool LCDNFLNIPHC()
	{
		if (type == UIType.TMPro)
		{
			return false;
		}
		return true;
	}

	private bool IHNGOGIFIGC()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && !((TMP_Text)text).enableAutoSizing)
		{
			return false;
		}
		return true;
	}

	public void NNCCIAALOKD()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 1506f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 1621f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 223f;
			type = UIType.TMPro;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 703f) / 2)) * 3;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.RectTransform;
		}
	}

	private void LEPDLPEPEFD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.lossyScale.x >= 989f)
		{
			BLKHBFCMAHN();
		}
		else
		{
			BFOGJHJJKDP();
		}
	}

	private void BFJOEMCBJJO()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.RectTransform)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private void FCNKGINGJNM()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.RectTransform)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private void PPCAAJPCCJI()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			break;
		}
	}

	private bool IFKKAOFLHBI()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && !((TMP_Text)text).enableAutoSizing)
		{
			return false;
		}
		return true;
	}

	private void MFJIHCKEIIF()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.RectTransform)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private void AJGLDLLIIFO()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.RectTransform)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private void CJDJDDNCNDJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.lossyScale.x >= 505f)
		{
			EGEJNONJEHD();
		}
		else
		{
			HIMKEHOEKJE();
		}
	}

	private void BFOGJHJJKDP()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		UIType uIType = type;
		if (uIType != 0)
		{
			if (uIType == UIType.TMPro)
			{
				rectTransform.sizeDelta = new Vector2((float)width720, (float)height720);
			}
		}
		else
		{
			((TMP_Text)text).fontSize = size720;
			((TMP_Text)text).fontSizeMin = minSize720;
			((TMP_Text)text).fontSizeMax = maxSize720;
		}
	}

	private void ALEAOANPHIO()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.RectTransform)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private void FHOCCEBKHJI()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.TMPro)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private void AFMEGDJMLHD()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			break;
		}
	}

	private void OOKCGEEPIEI()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = size720;
			((TMP_Text)text).fontSizeMin = minSize720;
			((TMP_Text)text).fontSizeMax = maxSize720;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2((float)width720, (float)height720);
			break;
		}
	}

	public void JNNJOJNPKJO()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 113f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 1151f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 519f;
			type = UIType.TMPro;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 525f) / 1)) * 7;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.RectTransform;
		}
	}

	private void OCPFPGDKFEB()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			break;
		}
	}

	private void GMCKBBECJOE()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.RectTransform)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private void CLGBFOIBANN()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.TMPro)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private void DNLBJAGEFLK()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		UIType uIType = type;
		if (uIType != 0)
		{
			if (uIType == UIType.TMPro)
			{
				rectTransform.sizeDelta = new Vector2((float)width720, (float)height720);
			}
		}
		else
		{
			((TMP_Text)text).fontSize = size720;
			((TMP_Text)text).fontSizeMin = minSize720;
			((TMP_Text)text).fontSizeMax = maxSize720;
		}
	}

	private bool NHPMKNFIPBK()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && !((TMP_Text)text).enableAutoSizing)
		{
			return false;
		}
		return true;
	}

	private bool PAGGODAAKNJ()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && !((TMP_Text)text).enableAutoSizing)
		{
			return true;
		}
		return false;
	}

	private void OHOHFGMJGAJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.lossyScale.x >= 1544f)
		{
			GCFIMFKFHAK();
		}
		else
		{
			DNLBJAGEFLK();
		}
	}

	private void GMNJDGGBEPB()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			break;
		}
	}

	private void EAMBGENODNE()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		UIType uIType = type;
		if (uIType != 0)
		{
			if (uIType == UIType.TMPro)
			{
				rectTransform.sizeDelta = new Vector2((float)width720, (float)height720);
			}
		}
		else
		{
			((TMP_Text)text).fontSize = size720;
			((TMP_Text)text).fontSizeMin = minSize720;
			((TMP_Text)text).fontSizeMax = maxSize720;
		}
	}

	private bool LJPEBLAKBNF()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && ((TMP_Text)text).enableAutoSizing)
		{
			return false;
		}
		return false;
	}

	private void FLONHDPKKOL()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		UIType uIType = type;
		if (uIType != 0)
		{
			if (uIType == UIType.TMPro)
			{
				rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			}
		}
		else
		{
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
		}
	}

	private bool OAKCHMPIPHN()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && ((TMP_Text)text).enableAutoSizing)
		{
			return true;
		}
		return false;
	}

	private bool LIIBGHKILHK()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && ((TMP_Text)text).enableAutoSizing)
		{
			return true;
		}
		return false;
	}

	private void IEPJAFLDBJJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.lossyScale.x >= 188f)
		{
			MDJEFPLPDOE();
		}
		else
		{
			EJAHGJLLPEJ();
		}
	}

	private void LDPNDNEFKCP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.lossyScale.x >= 450f)
		{
			OCPFPGDKFEB();
		}
		else
		{
			HIMKEHOEKJE();
		}
	}

	private bool AMHDBDLAALG()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && !((TMP_Text)text).enableAutoSizing)
		{
			return true;
		}
		return true;
	}

	public void IAENNJLJICJ()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 1437f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 570f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 794f;
			type = UIType.TMPro;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 1985f) / 5)) * 7;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.TMPro;
		}
	}

	private void Awake()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.RectTransform)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private bool MANNBDNACLD()
	{
		if (type == UIType.RectTransform)
		{
			return true;
		}
		return false;
	}

	private void PHNJGHKBIIL()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.TMPro)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private bool DKGKIECLOND()
	{
		if (type == UIType.RectTransform)
		{
			return false;
		}
		return true;
	}

	private void GCFIMFKFHAK()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		UIType uIType = type;
		if (uIType != 0)
		{
			if (uIType == UIType.TMPro)
			{
				rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			}
		}
		else
		{
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
		}
	}

	private void EGEJNONJEHD()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		UIType uIType = type;
		if (uIType != 0)
		{
			if (uIType == UIType.TMPro)
			{
				rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			}
		}
		else
		{
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
		}
	}

	private bool LMELHDPKAGH()
	{
		if (type == UIType.TMPro)
		{
			return false;
		}
		return false;
	}

	private void EIMIDCDEIDD()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.RectTransform)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	public void PKBIDEJGEMO()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 1140f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 196f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 931f;
			type = UIType.TMPro;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 1058f) / 2)) * 1;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.TMPro;
		}
	}

	private void BAKDKFKNHDE()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.TMPro)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private void KMEJBPOOBJK()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.RectTransform)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private void BLKHBFCMAHN()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		UIType uIType = type;
		if (uIType != 0)
		{
			if (uIType == UIType.TMPro)
			{
				rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			}
		}
		else
		{
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
		}
	}

	private bool LDEFPNFECPL()
	{
		if (type == UIType.TMPro)
		{
			return true;
		}
		return false;
	}

	private void GEJBKGIHEJG()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			break;
		}
	}

	public void PGAGDLJFDHA()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 1458f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 1801f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 1396f;
			type = UIType.TMPro;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 823f) / 5)) * 5;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.RectTransform;
		}
	}

	private bool JBNOCKLJEOI()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && !((TMP_Text)text).enableAutoSizing)
		{
			return false;
		}
		return true;
	}

	private bool PCJEHPDBFIN()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && !((TMP_Text)text).enableAutoSizing)
		{
			return true;
		}
		return true;
	}

	private void MDJEFPLPDOE()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			break;
		}
	}

	private bool LMOGJALAPPN()
	{
		if (type == UIType.RectTransform)
		{
			return true;
		}
		return false;
	}

	public void JBHBGCKGHFF()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 638f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 634f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 1972f;
			type = UIType.RectTransform;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 1679f) / 7)) * 3;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.RectTransform;
		}
	}

	private bool FONLBIHGAOF()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && ((TMP_Text)text).enableAutoSizing)
		{
			return true;
		}
		return false;
	}

	private void HIMKEHOEKJE()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = size720;
			((TMP_Text)text).fontSizeMin = minSize720;
			((TMP_Text)text).fontSizeMax = maxSize720;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2((float)width720, (float)height720);
			break;
		}
	}

	private bool EPGODKMBJHF()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && ((TMP_Text)text).enableAutoSizing)
		{
			return false;
		}
		return false;
	}

	public void BBDANCOCDJC()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 357f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 1318f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 86f;
			type = UIType.TMPro;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 1586f) / 5)) * 8;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.RectTransform;
		}
	}

	public void IIMLLBKNDJA()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 1540f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 632f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 28f;
			type = UIType.RectTransform;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 1589f) / 7)) * 6;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.TMPro;
		}
	}

	private bool FOFMLCGPOEO()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && ((TMP_Text)text).enableAutoSizing)
		{
			return false;
		}
		return false;
	}

	private void LJCPCILIDLM()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			break;
		}
	}

	private void GKHCKMCKHEM()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			break;
		}
	}

	private bool DKGKHGFBPBC()
	{
		if (type == UIType.RectTransform)
		{
			return false;
		}
		return false;
	}

	private bool DDOONDEFNHD()
	{
		if (type == UIType.RectTransform)
		{
			return false;
		}
		return true;
	}

	private bool LGJGHDNDAAE()
	{
		if (type == UIType.RectTransform)
		{
			return true;
		}
		return true;
	}

	private bool GMDAGBICEII()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && ((TMP_Text)text).enableAutoSizing)
		{
			return false;
		}
		return false;
	}

	private bool KBDOFFDHMOE()
	{
		if (type == UIType.TMPro)
		{
			return true;
		}
		return false;
	}

	private void LMGLNEMHDMK()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			break;
		}
	}

	private bool JPNKGHKMIPO()
	{
		if (type == UIType.TMPro)
		{
			return false;
		}
		return false;
	}

	private bool HKHIGEPHKIO()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && ((TMP_Text)text).enableAutoSizing)
		{
			return true;
		}
		return false;
	}

	private void PGEGODAEBLC()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (type == UIType.TMPro)
		{
			NGEHLPKBBIJ = ((TMP_Text)text).fontSize;
			CFGKOPALELI = ((TMP_Text)text).fontSizeMin;
			FDGIFFCLFCN = ((TMP_Text)text).fontSizeMax;
		}
		else if (type == UIType.TMPro)
		{
			OAKGNJJAJBL = rectTransform.sizeDelta.x;
			CPNNNFJHFHG = rectTransform.sizeDelta.y;
		}
	}

	private void DNJHCOAPKCB()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		UIType uIType = type;
		if (uIType != 0)
		{
			if (uIType == UIType.TMPro)
			{
				rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			}
		}
		else
		{
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
		}
	}

	private void KPIDNCECDOJ()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			break;
		}
	}

	private bool OIMHDNNHIBL()
	{
		if (type == UIType.TMPro)
		{
			return true;
		}
		return false;
	}

	private void KAANJGEDPIN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.lossyScale.x >= 557f)
		{
			LJCPCILIDLM();
		}
		else
		{
			HIMKEHOEKJE();
		}
	}

	private void JNNFKOKJOCF()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			break;
		}
	}

	private void FEPFNOEGFEM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.lossyScale.x >= 1412f)
		{
			KPIDNCECDOJ();
		}
		else
		{
			HIMKEHOEKJE();
		}
	}

	private bool GGHMPPADMDG()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && ((TMP_Text)text).enableAutoSizing)
		{
			return true;
		}
		return true;
	}

	private void GKCKLIAANHA()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.lossyScale.x >= 1337f)
		{
			BLKHBFCMAHN();
		}
		else
		{
			EJAHGJLLPEJ();
		}
	}

	private void ICKIAOEOHDJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.lossyScale.x >= 308f)
		{
			GEJBKGIHEJG();
		}
		else
		{
			OOKCGEEPIEI();
		}
	}

	private bool LNMLHIDLELA()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && ((TMP_Text)text).enableAutoSizing)
		{
			return false;
		}
		return false;
	}

	private void FJFLGDADEKM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.lossyScale.x >= 739f)
		{
			GMNJDGGBEPB();
		}
		else
		{
			DNLBJAGEFLK();
		}
	}

	public void OBFEKOKHCFJ()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 1897f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 1446f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 1064f;
			type = UIType.RectTransform;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 744f) / 3)) * 3;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.RectTransform;
		}
	}

	private bool ABNGEGJNJMB()
	{
		if (type == UIType.TMPro)
		{
			return false;
		}
		return false;
	}

	private void OnEnable()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.lossyScale.x >= 2f)
		{
			KPIDNCECDOJ();
		}
		else
		{
			NIDICCABMLH();
		}
	}

	public void JDINKPABOJP()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 1693f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 81f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 1593f;
			type = UIType.TMPro;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 736f) / 3)) * 0;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.TMPro;
		}
	}

	public void ConfiguracionBasica()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 1.4f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 1.4f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 1.4f;
			type = UIType.TMPro;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 1.4f) / 2)) * 2;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.RectTransform;
		}
	}

	private bool LCFGGGGBIAK()
	{
		if (type == UIType.TMPro)
		{
			return true;
		}
		return true;
	}

	private void EJAHGJLLPEJ()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = size720;
			((TMP_Text)text).fontSizeMin = minSize720;
			((TMP_Text)text).fontSizeMax = maxSize720;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2((float)width720, (float)height720);
			break;
		}
	}

	private bool FMPGPCCABHB()
	{
		if (type == UIType.TMPro)
		{
			return false;
		}
		return true;
	}

	private bool FALLLAIIKFN()
	{
		if (type == UIType.TMPro)
		{
			return false;
		}
		return true;
	}

	private void NIDICCABMLH()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = size720;
			((TMP_Text)text).fontSizeMin = minSize720;
			((TMP_Text)text).fontSizeMax = maxSize720;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2((float)width720, (float)height720);
			break;
		}
	}

	public void KMGODDICGIJ()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		text = ((Component)this).GetComponent<TextMeshProUGUI>();
		if ((Object)(object)text != (Object)null)
		{
			size720 = ((TMP_Text)text).fontSize * 1295f;
			minSize720 = ((TMP_Text)text).fontSizeMin * 1143f;
			maxSize720 = ((TMP_Text)text).fontSizeMax * 1863f;
			type = UIType.TMPro;
			return;
		}
		rectTransform = ((Component)this).GetComponent<RectTransform>();
		if ((Object)(object)rectTransform != (Object)null)
		{
			width720 = Mathf.RoundToInt((float)(Mathf.RoundToInt(rectTransform.sizeDelta.x * 1337f) / 8)) * 8;
			height720 = Mathf.RoundToInt(rectTransform.sizeDelta.y);
			type = UIType.RectTransform;
		}
	}

	private bool KODOBBLOBCM()
	{
		if (type == UIType.TMPro && (Object)(object)text != (Object)null && !((TMP_Text)text).enableAutoSizing)
		{
			return false;
		}
		return true;
	}

	private void LAIKKHJKPNG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.lossyScale.x >= 1922f)
		{
			KPGDGEADONB();
		}
		else
		{
			BFOGJHJJKDP();
		}
	}

	private void KPGDGEADONB()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case UIType.TMPro:
			((TMP_Text)text).fontSize = NGEHLPKBBIJ;
			((TMP_Text)text).fontSizeMin = CFGKOPALELI;
			((TMP_Text)text).fontSizeMax = FDGIFFCLFCN;
			break;
		case UIType.RectTransform:
			rectTransform.sizeDelta = new Vector2(OAKGNJJAJBL, CPNNNFJHFHG);
			break;
		}
	}
}
