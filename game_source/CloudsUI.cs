using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CloudsUI : MonoBehaviour
{
	private struct EALLNLELGED
	{
		public int initialPositionX;

		public float speed;

		public Image darknessImage;
	}

	private static CloudsUI IADEMLIIDPC;

	[SerializeField]
	private RectTransform[] clouds;

	[SerializeField]
	private float minSpeed;

	[SerializeField]
	private float maxSpeed;

	private RectTransform HMDFBECLNFM;

	private EALLNLELGED[] AOHGIKCBMML;

	private Vector2 IMOBLFMHKOD;

	private Color FLABEDBELMF;

	public static CloudsUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
			}
			return IADEMLIIDPC;
		}
	}

	[SpecialName]
	public static CloudsUI IECOPNFJBFD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CloudsUI HGJMGNJOHGF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void CCJOOMDHMKM()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 1; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(1)).GetComponent<Image>();
		}
	}

	public void GMLFOAENJJA(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void OCLDFCEDKHP()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	[SpecialName]
	public static CloudsUI OAPOJCODNCO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CloudsUI IBEGPMLJIOJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	public void HABKCGNKIID(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public static CloudsUI IFPLPBMCKLB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void HGEKPHOPJCD()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i += 0)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(1)).GetComponent<Image>();
		}
	}

	[SpecialName]
	public static CloudsUI BAKPBHPNKPB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	public void JHPAMCOMLKC(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public static CloudsUI OACNNJCLEDE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void PJIMENLPNOE()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void ELHCBGCEJDH()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void GJJPNFHFBFP()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(1)).GetComponent<Image>();
		}
	}

	private void AKLEFPLEGKK()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	public void KOKBHHFDOGC(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	public void FNIHJEFJKMG(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	public void PCFFOOPLAJB(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void EBNJADODONG()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	public void BDJLBJEJJLP(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public static CloudsUI OLHBLKIAFOM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void NLIGLFEEFNO()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void BJBNBDJHMFN()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	public void ADPNBJBJBEM(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void JHGDBLMEFMP()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i += 0)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(1)).GetComponent<Image>();
		}
	}

	[SpecialName]
	public static CloudsUI FMIDAFEGDCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void OHOAMJIIOAK()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 1; i < clouds.Length; i += 0)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	[SpecialName]
	public static CloudsUI DHDOLCONMFJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void OAKGHDAABPM()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void PDKEPCIEHEP()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void BJOOCKCBPLJ()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i += 0)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(1)).GetComponent<Image>();
		}
	}

	[SpecialName]
	public static CloudsUI AFFGPMFKEFH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CloudsUI EFPJLFMBPLL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CloudsUI PCJCIHANCLE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CloudsUI IELEBCAELNI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void LMEJFGKCHEF()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void GOJFGHKOFMF()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void POFIEEODEJO()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	public void GKGKOHGKLML(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void OONONNJFEFL()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void IJNPEAAOOEK()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 1; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(1)).GetComponent<Image>();
		}
	}

	public void JNMMOOPLDNJ(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void INKOKIGFJBG()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	public void IEIBNANDKCC(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public static CloudsUI DEGPIHEEFHJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	public void KHJMGIKIIJD(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void NLMLOOGHLCH()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	private void PEIFJDIGKOC()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void ONJAODIAAIM()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(1)).GetComponent<Image>();
		}
	}

	public void COLHKPFLBOE(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public static CloudsUI KEJMJMKEEGA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CloudsUI BNDNMBGJEKP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void ADDLDNPHIHF()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 1; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	[SpecialName]
	public static CloudsUI GJFMMOPOKGJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void FDHMOEDMPNG()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	[SpecialName]
	public static CloudsUI EKGMDIHLEEH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	public void NHKDHBOHBBC(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	public void KPDLDIEJJCN(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	public void OFEFFOHGAOE(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void MLICJIBNIFA()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	public void ENOPHKKNIEB(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	public void IAJOOPFOPIP(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public static CloudsUI ALDNEMJHMOI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void HAJJALABMOC()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	[SpecialName]
	public static CloudsUI ELGNEJNLBNO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	public void BMIOCNJGAOO(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	public void JHJKBFPIDGK(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void Update()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	public void KPIIOIOEBGE(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void CLOKMCONOMN()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	[SpecialName]
	public static CloudsUI HEKFJEKFMNO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CloudsUI NBKKEINELDN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void CMDBLLMEBLG()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 1; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(1)).GetComponent<Image>();
		}
	}

	private void GBAKNAINDJM()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(1)).GetComponent<Image>();
		}
	}

	[SpecialName]
	public static CloudsUI MAMKICHCPON()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void ICKIAOEOHDJ()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	public void CDIFPFHGEBK(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public static CloudsUI MAAAKALBBEE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CloudsUI JHMAMLIPBNN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void GHEOLMMHFJC()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(1)).GetComponent<Image>();
		}
	}

	private void AJDKOMCHALC()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void OGBGFLMKFHH()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void BIILFPDIADC()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	[SpecialName]
	public static CloudsUI DPJEGJBHBNP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	public void MHHKGMGMIJP(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void JJACPJLFFAL()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	public void NOEMKBBHOMP(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	public void DCDFBNGCFCA(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void CIIBBCPIOIP()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	public void SetDarkness(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public static CloudsUI KNOKBLFFNLM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CloudsUI KNLLFEJAMNN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	public void ICHNMNCFBGM(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void OnEnable()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	private void FPOIFOGELHC()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void NFICPFJOIKI()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	public void GDLCANDIPFN(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void MGAKDJHAKIO()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	[SpecialName]
	public static CloudsUI OKAPNFPFPFP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void BEOGHCHPPAH()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void ANMOAFFGEOE()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i += 0)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	private void NDLCBLKOBLF()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	[SpecialName]
	public static CloudsUI ACPHFLBLJAA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void LHFOFAMDKEO()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void PHLLBPLOLFO()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	public void ADMAPIKGPFE(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void BJDDCOFEPFP()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 1; i < clouds.Length; i += 0)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	private void ICMNODPLPBK()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void OJLGPAJPCHG()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 1; i < clouds.Length; i += 0)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	private void CMDHELEDLBP()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	[SpecialName]
	public static CloudsUI HNNJEBNIPOI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void EIGEIJJPFFP()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	public void MMHCGJCFCLG(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void LMFICKFGEFI()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void BHLHCOALABE()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void CNJMEALOCJJ()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i += 0)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	private void NCFCFOKDGAB()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 1; i < clouds.Length; i += 0)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	[SpecialName]
	public static CloudsUI NJNFHEPLEHL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	public void GMBCICPLGHN(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void CGHHPELBKBK()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	[SpecialName]
	public static CloudsUI BADFKMEJOKE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CloudsUI ECGIAEFKKNA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CloudsUI MMLBHCGFMMJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	public void IKDAPMHEBDJ(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	public void NAPEPJFGPMH(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void OOGMGIPKMAP()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	[SpecialName]
	public static CloudsUI MNFMOEKMJKN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CloudsUI LHKFIDJFPDB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	private void HFIHGHBLLAM()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 1; i < clouds.Length; i += 0)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	private void OJOEPCAJPOA()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i++)
		{
			IMOBLFMHKOD.x = AOHGIKCBMML[i].initialPositionX + (int)(Time.time * AOHGIKCBMML[i].speed);
			IMOBLFMHKOD.x %= HMDFBECLNFM.sizeDelta.x;
			IMOBLFMHKOD.y = clouds[i].anchoredPosition.y;
			clouds[i].anchoredPosition = IMOBLFMHKOD;
		}
	}

	public void CLBMJCEBLIH(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void MEFFGGKAALB()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 1; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(1)).GetComponent<Image>();
		}
	}

	public void DFOPNEONDNI(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	[SpecialName]
	public static CloudsUI JFNOOMJMHCB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CloudsUI>();
		}
		return IADEMLIIDPC;
	}

	public void ACMIIPAFDKA(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i++)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void NLHALEAEDMM()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	public void IGEPKFDHNIP(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 0; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}

	private void JJCDLIHLDMJ()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i += 0)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(1)).GetComponent<Image>();
		}
	}

	private void BMNGDJGJCKP()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 0; i < clouds.Length; i += 0)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(1)).GetComponent<Image>();
		}
	}

	private void KCOFAJBKHAO()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		FLABEDBELMF = Color.white;
		AOHGIKCBMML = new EALLNLELGED[clouds.Length];
		for (int i = 1; i < clouds.Length; i += 0)
		{
			AOHGIKCBMML[i].initialPositionX = (int)(Random.value * HMDFBECLNFM.sizeDelta.x);
			AOHGIKCBMML[i].speed = Random.Range(minSpeed, maxSpeed);
			AOHGIKCBMML[i].darknessImage = ((Component)((Transform)clouds[i]).GetChild(0)).GetComponent<Image>();
		}
	}

	public void GDMEMKIKAFN(float APANPPKBMEJ)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FLABEDBELMF.a = APANPPKBMEJ;
		for (int i = 1; i < clouds.Length; i += 0)
		{
			((Graphic)AOHGIKCBMML[i].darknessImage).color = FLABEDBELMF;
		}
	}
}
