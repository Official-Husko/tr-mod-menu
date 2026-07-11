using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnlineChatResizeButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[SerializeField]
	private RectTransform chatRect;

	private Vector2 HNIDMDKEKKF = new Vector2(160f, 120f);

	private Vector2 ILNDDPDEFFM = new Vector2(350f, 180f);

	[SerializeField]
	private Transform sizeHelper;

	private bool LFCBEHHBGDM;

	private bool MNEINFMFGFI;

	private readonly Vector2 KJEKEGAFIOC = new Vector2(300f, 120f);

	private Vector2 BCOFNPCDDLI = new Vector2(300f, 120f);

	private const string IGEDDEAEFAD = "chatx";

	private const string MGEMAIPNLDD = "chaty";

	[Range(1f, 20f)]
	[SerializeField]
	private float shrinkSpeed = 10f;

	private Vector2 JEFHFIGCOJL = Vector2.zero;

	public void ICMLFDOIHMF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		HMFAIPHMOBJ();
	}

	public void ILNODCBHHMA()
	{
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineChatUI.IsChatHidden())
		{
			if (!MNEINFMFGFI)
			{
				MNEINFMFGFI = true;
				JEFHFIGCOJL = Vector2.op_Implicit(sizeHelper.position);
			}
			sizeHelper.localPosition = new Vector3(Mathf.MoveTowards(sizeHelper.localPosition.x, 1751f, shrinkSpeed * 1274f * Time.deltaTime), sizeHelper.localPosition.y);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(sizeHelper.localPosition.x);
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
		else if (MNEINFMFGFI)
		{
			MNEINFMFGFI = true;
			sizeHelper.position = Vector2.op_Implicit(JEFHFIGCOJL);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void IMIONHLAKIH()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.HasKey("Items/item_name_699") && PlayerPrefs.HasKey("HouseKeeper"))
		{
			BCOFNPCDDLI.x = PlayerPrefs.GetFloat("Player2", BCOFNPCDDLI.x);
			BCOFNPCDDLI.y = PlayerPrefs.GetFloat("AceT_Quest", BCOFNPCDDLI.y);
		}
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(BGFAFMFCEGC));
	}

	private void PHLFIKKEOKC()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(1))
			{
				MAEAMFNLBOM();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void FOHCEDHJOEF()
	{
		IEBKCCPCNHN();
	}

	public void GIAOEOPNCON()
	{
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineChatUI.IsChatHidden())
		{
			if (!MNEINFMFGFI)
			{
				MNEINFMFGFI = false;
				JEFHFIGCOJL = Vector2.op_Implicit(sizeHelper.position);
			}
			sizeHelper.localPosition = new Vector3(Mathf.MoveTowards(sizeHelper.localPosition.x, 1602f, shrinkSpeed * 1982f * Time.deltaTime), sizeHelper.localPosition.y);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(sizeHelper.localPosition.x);
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
		else if (MNEINFMFGFI)
		{
			MNEINFMFGFI = true;
			sizeHelper.position = Vector2.op_Implicit(JEFHFIGCOJL);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	public void LIGPCKJPIEA(PointerEventData NPBAMEMNFBI)
	{
		DIIOLKJKFAD();
	}

	public void LIGDOKENJKJ(PointerEventData NPBAMEMNFBI)
	{
		CFELMHGACMH();
	}

	private void PHMIOLDNKLN(int EBHNPJCHGFI, int AEPKEMADCIP, float NMLHLNFDFAM)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
		BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
	}

	private void NDPBKJIDCLL()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(0))
			{
				DIIOLKJKFAD();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	public void FHBIHKFAHEB(PointerEventData NPBAMEMNFBI)
	{
		DDCDPPJBEHJ();
	}

	private void CAPGENMIELF()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(1))
			{
				NFECJGNINPE();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	public void FLKEBFPBADN(PointerEventData NPBAMEMNFBI)
	{
		IALEGLOCJFP();
	}

	private void ELHCBGCEJDH()
	{
		PHLFIKKEOKC();
	}

	public void CGBKINANJGD()
	{
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineChatUI.IsChatHidden())
		{
			if (!MNEINFMFGFI)
			{
				MNEINFMFGFI = true;
				JEFHFIGCOJL = Vector2.op_Implicit(sizeHelper.position);
			}
			sizeHelper.localPosition = new Vector3(Mathf.MoveTowards(sizeHelper.localPosition.x, 777f, shrinkSpeed * 19f * Time.deltaTime), sizeHelper.localPosition.y);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(sizeHelper.localPosition.x);
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
		else if (MNEINFMFGFI)
		{
			MNEINFMFGFI = false;
			sizeHelper.position = Vector2.op_Implicit(JEFHFIGCOJL);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void ODMMILINOII()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(0))
			{
				NFECJGNINPE();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	public void GBJBMJJMIFG(PointerEventData NPBAMEMNFBI)
	{
		MAEAMFNLBOM();
	}

	public void NIFDMAHCFKB(PointerEventData NPBAMEMNFBI)
	{
		LAFIDFNJGLI();
	}

	private void LIOAJKCBPFJ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(0))
			{
				DIIOLKJKFAD();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void NCDJCLCBHKA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(0))
			{
				BDMGMOANAPD();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void KOEHNENIBNP()
	{
		if (Application.isPlaying && !((Object)(object)GraphicsMenuUI.FMIDAFEGDCD() == (Object)null))
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(BGFAFMFCEGC));
		}
	}

	public void GICFDCEBDFE(PointerEventData NPBAMEMNFBI)
	{
		MAEAMFNLBOM();
	}

	public void HLGLIACKKFD(PointerEventData NPBAMEMNFBI)
	{
		DKPBMHCCLJN();
	}

	private void DKPBMHCCLJN()
	{
		LFCBEHHBGDM = false;
		HMFAIPHMOBJ();
	}

	public void OAMPHEIMJAE(PointerEventData NPBAMEMNFBI)
	{
		DDCDPPJBEHJ();
	}

	public void ResetSize()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		AGFJCKNEMPM();
	}

	public void JLIJJPLBEDG(PointerEventData NPBAMEMNFBI)
	{
		MAEAMFNLBOM();
	}

	private void FDFNFKLMGOD(int EBHNPJCHGFI, int AEPKEMADCIP, float NMLHLNFDFAM)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
		BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
	}

	private void PBGCDGNHHHA()
	{
		LFCBEHHBGDM = true;
	}

	private void IALEGLOCJFP()
	{
		LFCBEHHBGDM = false;
		HMFAIPHMOBJ();
	}

	private void HPIMHEMJMAA()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.HasKey("UIInteract") && PlayerPrefs.HasKey("privatetest"))
		{
			BCOFNPCDDLI.x = PlayerPrefs.GetFloat("Player", BCOFNPCDDLI.x);
			BCOFNPCDDLI.y = PlayerPrefs.GetFloat("Run", BCOFNPCDDLI.y);
		}
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(DLCKKFENHNO));
	}

	private void LKHMCLABKLG()
	{
		if (Application.isPlaying && !((Object)(object)GraphicsMenuUI.FMIDAFEGDCD() == (Object)null))
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(FDFNFKLMGOD));
		}
	}

	private void LKFFFBIGJFI()
	{
		PlayerPrefs.SetFloat("City/Petra/Bark/Bye", BCOFNPCDDLI.x);
		PlayerPrefs.SetFloat("Chair", BCOFNPCDDLI.y);
	}

	private void HJANCPIFLIJ()
	{
		if (Application.isPlaying && !((Object)(object)GraphicsMenuUI.AJIGOHGPFPP() == (Object)null))
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(PHMIOLDNKLN));
		}
	}

	public void EJIOEIJMCBA()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		KDOBEDDGLMF();
	}

	public void FLCLBPIMAMA()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		DIBFNLKLMND();
	}

	private void OnDestroy()
	{
		if (Application.isPlaying && !((Object)(object)GraphicsMenuUI.GGFJGHHHEJC == (Object)null))
		{
			GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
			instance.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(instance.OnResolutionChange, new Action<int, int, float>(LHIFBLELKNA));
		}
	}

	public void OMPPFFCBCCK(PointerEventData NPBAMEMNFBI)
	{
		PBGCDGNHHHA();
	}

	public void OHMPEIPLCAK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		AGFJCKNEMPM();
	}

	private void DAMKCMDCBBC()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(0))
			{
				DKPBMHCCLJN();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	public void DDKCJKJDHJE(PointerEventData NPBAMEMNFBI)
	{
		HMAEIBOIMBB();
	}

	public void HEKPOICEKIH()
	{
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineChatUI.IsChatHidden())
		{
			if (!MNEINFMFGFI)
			{
				MNEINFMFGFI = true;
				JEFHFIGCOJL = Vector2.op_Implicit(sizeHelper.position);
			}
			sizeHelper.localPosition = new Vector3(Mathf.MoveTowards(sizeHelper.localPosition.x, 1930f, shrinkSpeed * 1873f * Time.deltaTime), sizeHelper.localPosition.y);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(sizeHelper.localPosition.x);
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
		else if (MNEINFMFGFI)
		{
			MNEINFMFGFI = false;
			sizeHelper.position = Vector2.op_Implicit(JEFHFIGCOJL);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void KIGKOOIDJNH()
	{
		LFCBEHHBGDM = true;
	}

	private void MINIPAJNGDG()
	{
		LFCBEHHBGDM = true;
	}

	private void DLCKKFENHNO(int EBHNPJCHGFI, int AEPKEMADCIP, float NMLHLNFDFAM)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
		BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
	}

	private void OCLDFCEDKHP()
	{
		IEBKCCPCNHN();
	}

	public void EIHAPJJJFOO()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		AGFJCKNEMPM();
	}

	public void ProcessShrink()
	{
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineChatUI.IsChatHidden())
		{
			if (!MNEINFMFGFI)
			{
				MNEINFMFGFI = true;
				JEFHFIGCOJL = Vector2.op_Implicit(sizeHelper.position);
			}
			sizeHelper.localPosition = new Vector3(Mathf.MoveTowards(sizeHelper.localPosition.x, 23f, shrinkSpeed * 100f * Time.deltaTime), sizeHelper.localPosition.y);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(sizeHelper.localPosition.x);
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
		else if (MNEINFMFGFI)
		{
			MNEINFMFGFI = false;
			sizeHelper.position = Vector2.op_Implicit(JEFHFIGCOJL);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void EHBIMKJILDA()
	{
		LIOAJKCBPFJ();
	}

	public void NKKDCGDJDIH(PointerEventData NPBAMEMNFBI)
	{
		NFECJGNINPE();
	}

	private void HJDLNCOAKIK()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.HasKey(" world door: ") && PlayerPrefs.HasKey("TooHot"))
		{
			BCOFNPCDDLI.x = PlayerPrefs.GetFloat("ChatCommandKickDescription", BCOFNPCDDLI.x);
			BCOFNPCDDLI.y = PlayerPrefs.GetFloat("Override Dialogue Settings NULL!!", BCOFNPCDDLI.y);
		}
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(PHMIOLDNKLN));
	}

	private void FHKIDGKOLAF(int EBHNPJCHGFI, int AEPKEMADCIP, float NMLHLNFDFAM)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
		BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
	}

	public void OnPointerDown(PointerEventData NPBAMEMNFBI)
	{
		MINIPAJNGDG();
	}

	private void BGFAFMFCEGC(int EBHNPJCHGFI, int AEPKEMADCIP, float NMLHLNFDFAM)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
		BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
	}

	public void AHLCELEPIIL()
	{
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineChatUI.IsChatHidden())
		{
			if (!MNEINFMFGFI)
			{
				MNEINFMFGFI = true;
				JEFHFIGCOJL = Vector2.op_Implicit(sizeHelper.position);
			}
			sizeHelper.localPosition = new Vector3(Mathf.MoveTowards(sizeHelper.localPosition.x, 912f, shrinkSpeed * 1027f * Time.deltaTime), sizeHelper.localPosition.y);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(sizeHelper.localPosition.x);
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
		else if (MNEINFMFGFI)
		{
			MNEINFMFGFI = false;
			sizeHelper.position = Vector2.op_Implicit(JEFHFIGCOJL);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void ELPFAGMEFJP()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.HasKey("Null shop in database: ") && PlayerPrefs.HasKey("Attack/MainEvent 12"))
		{
			BCOFNPCDDLI.x = PlayerPrefs.GetFloat("Player", BCOFNPCDDLI.x);
			BCOFNPCDDLI.y = PlayerPrefs.GetFloat(". Time since startup: ", BCOFNPCDDLI.y);
		}
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.EFPJLFMBPLL();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(HLHLAJMBJPL));
	}

	public void PKLAKCFLDON(PointerEventData NPBAMEMNFBI)
	{
		PBGCDGNHHHA();
	}

	private void LKNEFKBGGGG()
	{
		PlayerPrefs.SetFloat("ReceiveCrafterRepaired", BCOFNPCDDLI.x);
		PlayerPrefs.SetFloat("FishCuttingEvent/Win1", BCOFNPCDDLI.y);
	}

	public void DOHNOPICFBI()
	{
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineChatUI.IsChatHidden())
		{
			if (!MNEINFMFGFI)
			{
				MNEINFMFGFI = false;
				JEFHFIGCOJL = Vector2.op_Implicit(sizeHelper.position);
			}
			sizeHelper.localPosition = new Vector3(Mathf.MoveTowards(sizeHelper.localPosition.x, 201f, shrinkSpeed * 1899f * Time.deltaTime), sizeHelper.localPosition.y);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(sizeHelper.localPosition.x);
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
		else if (MNEINFMFGFI)
		{
			MNEINFMFGFI = true;
			sizeHelper.position = Vector2.op_Implicit(JEFHFIGCOJL);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	public void AFLPEPENONN(PointerEventData NPBAMEMNFBI)
	{
		MINIPAJNGDG();
	}

	public void CMCPIGBFLIA()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		DGODIMKHOPP();
	}

	private void HCKBMOKECOA()
	{
		PHLFIKKEOKC();
	}

	private void HKMHACBDFIA()
	{
		LFCBEHHBGDM = true;
	}

	private void NIOEBLGJBEG()
	{
		LFCBEHHBGDM = true;
	}

	private void CFOJHDGFMGD()
	{
		PlayerPrefs.SetFloat("itemBroccoliSeeds", BCOFNPCDDLI.x);
		PlayerPrefs.SetFloat("ReceiveAnimalIncreaseProduction", BCOFNPCDDLI.y);
	}

	public void CDOGGPBKCIO(PointerEventData NPBAMEMNFBI)
	{
		DIIOLKJKFAD();
	}

	public void AMOJIJNLCHO(PointerEventData NPBAMEMNFBI)
	{
		LAFIDFNJGLI();
	}

	public void ALBDKCPEIFE(PointerEventData NPBAMEMNFBI)
	{
		DIIOLKJKFAD();
	}

	private void AMNMMJKOHLP()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(1))
			{
				LAFIDFNJGLI();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	public void MPHFMKCEOEL(PointerEventData NPBAMEMNFBI)
	{
		DIIOLKJKFAD();
	}

	public void OnPointerUp(PointerEventData NPBAMEMNFBI)
	{
		BDMGMOANAPD();
	}

	private void IAICCKPOBMJ()
	{
		ODMMILINOII();
	}

	private void BDGCFCPFKKE()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.HasKey("") && PlayerPrefs.HasKey("Items/item_name_677"))
		{
			BCOFNPCDDLI.x = PlayerPrefs.GetFloat("Open", BCOFNPCDDLI.x);
			BCOFNPCDDLI.y = PlayerPrefs.GetFloat("LE_10", BCOFNPCDDLI.y);
		}
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(HLHLAJMBJPL));
	}

	private void PFOAHHLNKNH()
	{
		JAFJMHDMAHC();
	}

	private void DDCDPPJBEHJ()
	{
		LFCBEHHBGDM = false;
		DGODIMKHOPP();
	}

	private void APJIONJLMNN()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(1))
			{
				IALEGLOCJFP();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	public void MENFIKDGFIO(PointerEventData NPBAMEMNFBI)
	{
		MINIPAJNGDG();
	}

	private void KLEAPLOKEDK()
	{
		AMNMMJKOHLP();
	}

	public void OHIFLPKNKMI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		HMFAIPHMOBJ();
	}

	private void EIGEIJJPFFP()
	{
		PMAEKFCOMIC();
	}

	private void NFECJGNINPE()
	{
		LFCBEHHBGDM = false;
		AGFJCKNEMPM();
	}

	private void LANGHIOBJIH()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.HasKey("UpgradeObjectConfirmation") && PlayerPrefs.HasKey(" "))
		{
			BCOFNPCDDLI.x = PlayerPrefs.GetFloat("invitecode", BCOFNPCDDLI.x);
			BCOFNPCDDLI.y = PlayerPrefs.GetFloat("", BCOFNPCDDLI.y);
		}
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(PHMIOLDNKLN));
	}

	public void KDHDJKNABAM()
	{
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineChatUI.IsChatHidden())
		{
			if (!MNEINFMFGFI)
			{
				MNEINFMFGFI = false;
				JEFHFIGCOJL = Vector2.op_Implicit(sizeHelper.position);
			}
			sizeHelper.localPosition = new Vector3(Mathf.MoveTowards(sizeHelper.localPosition.x, 280f, shrinkSpeed * 1761f * Time.deltaTime), sizeHelper.localPosition.y);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(sizeHelper.localPosition.x);
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
		else if (MNEINFMFGFI)
		{
			MNEINFMFGFI = false;
			sizeHelper.position = Vector2.op_Implicit(JEFHFIGCOJL);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void MAEAMFNLBOM()
	{
		LFCBEHHBGDM = false;
		LKFFFBIGJFI();
	}

	private void HLHLAJMBJPL(int EBHNPJCHGFI, int AEPKEMADCIP, float NMLHLNFDFAM)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
		BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
	}

	public void KEHOPOOLDCG(PointerEventData NPBAMEMNFBI)
	{
		BFIKINAAFNA();
	}

	private void GFEOBIGKDMG()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.HasKey("Eat") && PlayerPrefs.HasKey("Dialogue System/Conversation/Gass_Stand/Entry/15/Dialogue Text"))
		{
			BCOFNPCDDLI.x = PlayerPrefs.GetFloat("Normal", BCOFNPCDDLI.x);
			BCOFNPCDDLI.y = PlayerPrefs.GetFloat("ReceiveStartKlaynCombat", BCOFNPCDDLI.y);
		}
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(FDFNFKLMGOD));
	}

	public void HNOLIECHBBC()
	{
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineChatUI.IsChatHidden())
		{
			if (!MNEINFMFGFI)
			{
				MNEINFMFGFI = true;
				JEFHFIGCOJL = Vector2.op_Implicit(sizeHelper.position);
			}
			sizeHelper.localPosition = new Vector3(Mathf.MoveTowards(sizeHelper.localPosition.x, 541f, shrinkSpeed * 26f * Time.deltaTime), sizeHelper.localPosition.y);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(sizeHelper.localPosition.x);
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
		else if (MNEINFMFGFI)
		{
			MNEINFMFGFI = false;
			sizeHelper.position = Vector2.op_Implicit(JEFHFIGCOJL);
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void Update()
	{
		NCDJCLCBHKA();
	}

	private void KCGMGAMGHBP()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(1))
			{
				DDCDPPJBEHJ();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void PGJJBPALEGM()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.HasKey("RPCSnapPosition") && PlayerPrefs.HasKey("MainProgress"))
		{
			BCOFNPCDDLI.x = PlayerPrefs.GetFloat("Sending ", BCOFNPCDDLI.x);
			BCOFNPCDDLI.y = PlayerPrefs.GetFloat("[", BCOFNPCDDLI.y);
		}
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.EFPJLFMBPLL();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(HLHLAJMBJPL));
	}

	public void HKEACDDGAJM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		CFOJHDGFMGD();
	}

	private void KFAPGKGOOHP()
	{
		LFCBEHHBGDM = false;
	}

	private void KDBJHCAEGCM()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.HasKey("Social") && PlayerPrefs.HasKey("Waiting for scene {0} load on master. Current state: {1}"))
		{
			BCOFNPCDDLI.x = PlayerPrefs.GetFloat("Tail", BCOFNPCDDLI.x);
			BCOFNPCDDLI.y = PlayerPrefs.GetFloat("itemRedWine", BCOFNPCDDLI.y);
		}
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(PHMIOLDNKLN));
	}

	private void KJOJLHCDFPP()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.HasKey("Reject") && PlayerPrefs.HasKey("Players lose..."))
		{
			BCOFNPCDDLI.x = PlayerPrefs.GetFloat("Perks/perk_name_", BCOFNPCDDLI.x);
			BCOFNPCDDLI.y = PlayerPrefs.GetFloat("IntensitySectionCanvas/IntensitySection", BCOFNPCDDLI.y);
		}
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(FDFNFKLMGOD));
	}

	private void DIBFNLKLMND()
	{
		PlayerPrefs.SetFloat("Player", BCOFNPCDDLI.x);
		PlayerPrefs.SetFloat("Dialogue System/Conversation/Crowly_Introduce/Entry/17/Dialogue Text", BCOFNPCDDLI.y);
	}

	public void IIFAIAIAFIP(PointerEventData NPBAMEMNFBI)
	{
		DIIOLKJKFAD();
	}

	public void HCNBPOBOHCG(PointerEventData NPBAMEMNFBI)
	{
		DIIOLKJKFAD();
	}

	private void DIIOLKJKFAD()
	{
		LFCBEHHBGDM = true;
		LKFFFBIGJFI();
	}

	private void CMDEICKLKJB()
	{
		LFCBEHHBGDM = true;
		ABLMFIHCOBI();
	}

	public void EANFKBOOMDI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		DGODIMKHOPP();
	}

	private void LAFIDFNJGLI()
	{
		LFCBEHHBGDM = false;
		LKFFFBIGJFI();
	}

	private void BFIKINAAFNA()
	{
		LFCBEHHBGDM = false;
	}

	public void KEDOJHJLJOK(PointerEventData NPBAMEMNFBI)
	{
		NFECJGNINPE();
	}

	public void JOFCFHPFAAG()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		DIBFNLKLMND();
	}

	private void DDJJPEPDJKJ()
	{
		LFCBEHHBGDM = false;
	}

	private void AJFEFILHLNE()
	{
		LFCBEHHBGDM = false;
	}

	public void NALPJHMLICB(PointerEventData NPBAMEMNFBI)
	{
		IALEGLOCJFP();
	}

	public void OIJIENHHJLD(PointerEventData NPBAMEMNFBI)
	{
		KLEJBFNLLNB();
	}

	private void Start()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.HasKey("chatx") && PlayerPrefs.HasKey("chaty"))
		{
			BCOFNPCDDLI.x = PlayerPrefs.GetFloat("chatx", BCOFNPCDDLI.x);
			BCOFNPCDDLI.y = PlayerPrefs.GetFloat("chaty", BCOFNPCDDLI.y);
		}
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(LHIFBLELKNA));
	}

	private void ODBDHFBMDAG()
	{
		if (Application.isPlaying && !((Object)(object)GraphicsMenuUI.FMIDAFEGDCD() == (Object)null))
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(DLCKKFENHNO));
		}
	}

	public void OGDPAMNEMAE()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		HMFAIPHMOBJ();
	}

	public void DKDOOEOPJJO()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		KDOBEDDGLMF();
	}

	public void IJDHPNFHMED(PointerEventData NPBAMEMNFBI)
	{
		DKPBMHCCLJN();
	}

	private void IIOHMDNGFDH()
	{
		OJMDEGEOHIN();
	}

	public void OPHANFFPCKI(PointerEventData NPBAMEMNFBI)
	{
		MINIPAJNGDG();
	}

	private void HMFAIPHMOBJ()
	{
		PlayerPrefs.SetFloat("LE_14", BCOFNPCDDLI.x);
		PlayerPrefs.SetFloat("Successfully signed in", BCOFNPCDDLI.y);
	}

	private void HMAEIBOIMBB()
	{
		LFCBEHHBGDM = false;
	}

	private void GBKNIJENJEF()
	{
		if (Application.isPlaying && !((Object)(object)GraphicsMenuUI.HEKFJEKFMNO() == (Object)null))
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(PANPFEMFBIH));
		}
	}

	public void LNPHIKPNHKD(PointerEventData NPBAMEMNFBI)
	{
		HMAEIBOIMBB();
	}

	private void LIDCKNJAEND()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(0))
			{
				DIIOLKJKFAD();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void JAFJMHDMAHC()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(0))
			{
				BDMGMOANAPD();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void OONONNJFEFL()
	{
		NDPBKJIDCLL();
	}

	private void AGFJCKNEMPM()
	{
		PlayerPrefs.SetFloat("chatx", BCOFNPCDDLI.x);
		PlayerPrefs.SetFloat("chaty", BCOFNPCDDLI.y);
	}

	private void ABLMFIHCOBI()
	{
		PlayerPrefs.SetFloat("Tutorial/T108/Dialogue1", BCOFNPCDDLI.x);
		PlayerPrefs.SetFloat("chatSounds", BCOFNPCDDLI.y);
	}

	private void BDMGMOANAPD()
	{
		LFCBEHHBGDM = false;
		AGFJCKNEMPM();
	}

	public void GJIGOOLAMBD()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		HMFAIPHMOBJ();
	}

	public void EGNLDPBBBOH(PointerEventData NPBAMEMNFBI)
	{
		CMDEICKLKJB();
	}

	private void FOADEAKHHMN()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(1))
			{
				DIIOLKJKFAD();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	public void MKIOLIPCEOO(PointerEventData NPBAMEMNFBI)
	{
		DDJJPEPDJKJ();
	}

	public void OGEOHJFJNCD(PointerEventData NPBAMEMNFBI)
	{
		HMAEIBOIMBB();
	}

	private void CFELMHGACMH()
	{
		LFCBEHHBGDM = true;
	}

	private void KKKPAADHJCL()
	{
		if (Application.isPlaying && !((Object)(object)GraphicsMenuUI.FMIDAFEGDCD() == (Object)null))
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(PANPFEMFBIH));
		}
	}

	private void MFIBFFDBNGI()
	{
		LIDCKNJAEND();
	}

	public void CFCEIPBMBBM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		HMFAIPHMOBJ();
	}

	public void EODBGJNLFNM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		KDOBEDDGLMF();
	}

	private void BFGEPALNFMD(int EBHNPJCHGFI, int AEPKEMADCIP, float NMLHLNFDFAM)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
		BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
	}

	private void JCNPCJOBENP()
	{
		if (Application.isPlaying && !((Object)(object)GraphicsMenuUI.JFNOOMJMHCB() == (Object)null))
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(FHKIDGKOLAF));
		}
	}

	private void OJMDEGEOHIN()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(1))
			{
				CMDEICKLKJB();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void FCBINNDHDAK()
	{
		LFCBEHHBGDM = false;
	}

	private void GBFPCABGAII()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.HasKey("endconversations") && PlayerPrefs.HasKey("End"))
		{
			BCOFNPCDDLI.x = PlayerPrefs.GetFloat("NormalRightExterior", BCOFNPCDDLI.x);
			BCOFNPCDDLI.y = PlayerPrefs.GetFloat("LoadGameplaySceneOnline IsMasterClient ", BCOFNPCDDLI.y);
		}
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(BGFAFMFCEGC));
	}

	private void CDJPNDIKABM(int EBHNPJCHGFI, int AEPKEMADCIP, float NMLHLNFDFAM)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
		BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
	}

	private void DACKLLECMNA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(0))
			{
				DDCDPPJBEHJ();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	public void LDOPFKFNPNE()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI = KJEKEGAFIOC;
		chatRect.sizeDelta = BCOFNPCDDLI;
		LKFFFBIGJFI();
	}

	private void PMAEKFCOMIC()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(1))
			{
				BDMGMOANAPD();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void NMIJACDOGMF()
	{
		APJIONJLMNN();
	}

	public void DHKHMOHDKML(PointerEventData NPBAMEMNFBI)
	{
		BOGGHEJHHBI();
	}

	private void KLEJBFNLLNB()
	{
		LFCBEHHBGDM = true;
	}

	private void IEBKCCPCNHN()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!MNEINFMFGFI && LFCBEHHBGDM)
		{
			if (!Input.GetMouseButton(1))
			{
				IALEGLOCJFP();
				return;
			}
			sizeHelper.position = Input.mousePosition;
			BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
			BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
			chatRect.sizeDelta = BCOFNPCDDLI;
		}
	}

	private void GNOHDHPGBOH()
	{
		LFCBEHHBGDM = false;
	}

	private void JACCJNEFBBA()
	{
		LFCBEHHBGDM = false;
	}

	public void CIMBIHDLKHO(PointerEventData NPBAMEMNFBI)
	{
		NFECJGNINPE();
	}

	private void KIFMLPBFFDP()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.HasKey("cameraZoom2") && PlayerPrefs.HasKey("ReceiveDialogueInfo"))
		{
			BCOFNPCDDLI.x = PlayerPrefs.GetFloat("UIInteract", BCOFNPCDDLI.x);
			BCOFNPCDDLI.y = PlayerPrefs.GetFloat("Spicy", BCOFNPCDDLI.y);
		}
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.EFPJLFMBPLL();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(BGFAFMFCEGC));
	}

	private void BOGGHEJHHBI()
	{
		LFCBEHHBGDM = false;
	}

	private void KFBCJNFMPIL()
	{
		if (Application.isPlaying && !((Object)(object)GraphicsMenuUI.HEKFJEKFMNO() == (Object)null))
		{
			GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
			graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Remove(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(CDJPNDIKABM));
		}
	}

	private void KDOBEDDGLMF()
	{
		PlayerPrefs.SetFloat("F2", BCOFNPCDDLI.x);
		PlayerPrefs.SetFloat("Player with playerNum {0} does not exist or has been removed from the dictionary after disconnecting.", BCOFNPCDDLI.y);
	}

	private void PANPFEMFBIH(int EBHNPJCHGFI, int AEPKEMADCIP, float NMLHLNFDFAM)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
		BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
	}

	private void DGODIMKHOPP()
	{
		PlayerPrefs.SetFloat(" ", BCOFNPCDDLI.x);
		PlayerPrefs.SetFloat("ReceiveTicketPrice", BCOFNPCDDLI.y);
	}

	public void BFLBJEIKEPP(PointerEventData NPBAMEMNFBI)
	{
		DKPBMHCCLJN();
	}

	private void LHIFBLELKNA(int EBHNPJCHGFI, int AEPKEMADCIP, float NMLHLNFDFAM)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		BCOFNPCDDLI.x = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.x, HNIDMDKEKKF.x, ILNDDPDEFFM.x * ((Component)this).transform.lossyScale.x));
		BCOFNPCDDLI.y = Utils.ILDPJNAFIAG(Mathf.Clamp(sizeHelper.localPosition.y, HNIDMDKEKKF.y, ILNDDPDEFFM.y * ((Component)this).transform.lossyScale.y));
		chatRect.sizeDelta = BCOFNPCDDLI;
		sizeHelper.localPosition = Vector2.op_Implicit(BCOFNPCDDLI);
	}
}
