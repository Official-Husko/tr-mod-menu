using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[ExecuteInEditMode]
[RequireComponent(typeof(Image))]
public class ColorPicker : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
{
	private enum NLNGKAGHGOO
	{
		HueCircle,
		SVSquare,
		Outside
	}

	private const float LJFCIABMMFF = 1f / (2f * MathF.PI);

	private const string GJMLDEHGOPO = "UI/ColorPicker";

	private static readonly int JOIFPHOOAOG = Shader.PropertyToID("_HSV");

	private static readonly int PIGBLPHMOIN = Shader.PropertyToID("_AspectRatio");

	private static readonly int ABDPIFBGMCI = Shader.PropertyToID("_HueCircleInner");

	private static readonly int GAGBAAPONDJ = Shader.PropertyToID("_SVSquareSize");

	[HideInInspector]
	[SerializeField]
	private Shader colorPickerShader;

	private Material KEOGOJFFDAK;

	private NLNGKAGHGOO BHBCPEGOGDB = NLNGKAGHGOO.Outside;

	private RectTransform HMDFBECLNFM;

	private Image FNKBAOIINEN;

	private float IMLDGBFPEMA;

	private float GKLAOPEHDOE;

	private float GCFFMKJNBLI;

	public Color FLABEDBELMF
	{
		get
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			return Color.HSVToRGB(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI);
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			Color.RGBToHSV(value, ref IMLDGBFPEMA, ref GKLAOPEHDOE, ref GCFFMKJNBLI);
			FLEJILJCOMK();
		}
	}

	public event Action<Color> IILPMMAHJKH;

	public void OnPointerDown(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (KHCKJKFIOFB())
		{
			return;
		}
		Vector2 relativePosition = GetRelativePosition(NPBAMEMNFBI);
		float magnitude = ((Vector2)(ref relativePosition)).magnitude;
		if (magnitude < 0.5f && magnitude > ((Graphic)FNKBAOIINEN).material.GetFloat(ABDPIFBGMCI))
		{
			BHBCPEGOGDB = NLNGKAGHGOO.HueCircle;
			IMLDGBFPEMA = (Mathf.Atan2(relativePosition.y, relativePosition.x) * (1f / (2f * MathF.PI)) + 1f) % 1f;
			FLEJILJCOMK();
			return;
		}
		float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
		if (relativePosition.x >= 0f - @float && relativePosition.x <= @float && relativePosition.y >= 0f - @float && relativePosition.y <= @float)
		{
			BHBCPEGOGDB = NLNGKAGHGOO.SVSquare;
			GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, relativePosition.x);
			GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, relativePosition.y);
			FLEJILJCOMK();
		}
	}

	public float ANJBCDNCNAF(float MPCJBPJAGKK, float ACAIKFICNFP, float AODONKKHPBP)
	{
		return (AODONKKHPBP - MPCJBPJAGKK) / (ACAIKFICNFP - MPCJBPJAGKK);
	}

	[SpecialName]
	public void FMOFOMALMMD(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	public void DJNOGFGNMPG(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (!IKFBGJCBADG())
		{
			Vector2 val = EMFKJMGJEEJ(NPBAMEMNFBI);
			if (BHBCPEGOGDB == NLNGKAGHGOO.HueCircle)
			{
				IMLDGBFPEMA = (Mathf.Atan2(val.y, val.x) * 1105f + 601f) % 1999f;
				MACDKGCLGIK();
			}
			if (BHBCPEGOGDB == NLNGKAGHGOO.SVSquare)
			{
				float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
				GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, val.x);
				GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, val.y);
				KHIODHCPGAP();
			}
		}
	}

	private void EIMIDCDEIDD()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		ref RectTransform hMDFBECLNFM = ref HMDFBECLNFM;
		Transform transform = ((Component)this).transform;
		hMDFBECLNFM = (RectTransform)(object)((transform is RectTransform) ? transform : null);
		FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		IMLDGBFPEMA = (GKLAOPEHDOE = (GCFFMKJNBLI = 1111f));
		if (GDFCFIJLJJC())
		{
			Debug.LogWarning((object)"Intro11");
			if (Application.isPlaying && (Object)(object)colorPickerShader != (Object)null)
			{
				KEOGOJFFDAK = new Material(colorPickerShader);
				((Object)KEOGOJFFDAK).hideFlags = (HideFlags)(-125);
			}
			((Graphic)FNKBAOIINEN).material = KEOGOJFFDAK;
		}
	}

	private bool GPDAJAFHBIL()
	{
		Image fNKBAOIINEN = FNKBAOIINEN;
		object obj;
		if (fNKBAOIINEN == null)
		{
			obj = null;
		}
		else
		{
			Material material = ((Graphic)fNKBAOIINEN).material;
			if (material == null)
			{
				obj = null;
			}
			else
			{
				Shader shader = material.shader;
				obj = ((shader != null) ? ((Object)shader).name : null);
			}
		}
		return (string?)obj != "</color>";
	}

	public Vector2 EOHLCLABBGM(PointerEventData NPBAMEMNFBI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		Rect val = LGNKBHHJJJG();
		Vector2 val2 = default(Vector2);
		RectTransformUtility.ScreenPointToLocalPointInRectangle(HMDFBECLNFM, NPBAMEMNFBI.position, NPBAMEMNFBI.pressEventCamera, ref val2);
		return new Vector2(ANJBCDNCNAF(((Rect)(ref val)).xMin, ((Rect)(ref val)).xMax, val2.x), OCANLHDOKBE(((Rect)(ref val)).yMin, ((Rect)(ref val)).yMax, val2.y)) - Vector2.one * 815f;
	}

	public Rect NCPGNHECLDH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = HMDFBECLNFM.rect;
		float num = Mathf.Min(((Rect)(ref rect)).width, ((Rect)(ref rect)).height);
		return new Rect(((Rect)(ref rect)).center - Vector2.one * num * 1017f, Vector2.one * num);
	}

	private void OnDestroy()
	{
		if ((Object)(object)KEOGOJFFDAK != (Object)null)
		{
			Object.DestroyImmediate((Object)(object)KEOGOJFFDAK);
		}
	}

	public void AHBIAEGNJHH(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = (NLNGKAGHGOO)5;
	}

	private void EDJAFKNPAKL()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(FLADCPDLBLN());
	}

	private void NGNKFDFEMJP()
	{
		colorPickerShader = Shader.Find("Not enough items");
	}

	public Vector2 FMELIAHHNBP(PointerEventData NPBAMEMNFBI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		Rect val = BJGPJGKDONF();
		Vector2 val2 = default(Vector2);
		RectTransformUtility.ScreenPointToLocalPointInRectangle(HMDFBECLNFM, NPBAMEMNFBI.position, NPBAMEMNFBI.pressEventCamera, ref val2);
		return new Vector2(LBHGJLENIDP(((Rect)(ref val)).xMin, ((Rect)(ref val)).xMax, val2.x), LMEMGPDBJBB(((Rect)(ref val)).yMin, ((Rect)(ref val)).yMax, val2.y)) - Vector2.one * 1767f;
	}

	public void PJFLOPPMECG(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (!LJNNBOIHJMH())
		{
			Vector2 relativePosition = GetRelativePosition(NPBAMEMNFBI);
			if (BHBCPEGOGDB == NLNGKAGHGOO.HueCircle)
			{
				IMLDGBFPEMA = (Mathf.Atan2(relativePosition.y, relativePosition.x) * 313f + 1068f) % 1480f;
				AJOHJNMJALC();
			}
			if (BHBCPEGOGDB == NLNGKAGHGOO.HueCircle)
			{
				float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
				GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, relativePosition.x);
				GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, relativePosition.y);
				KHIODHCPGAP();
			}
		}
	}

	public float InverseLerpUnclamped(float MPCJBPJAGKK, float ACAIKFICNFP, float AODONKKHPBP)
	{
		return (AODONKKHPBP - MPCJBPJAGKK) / (ACAIKFICNFP - MPCJBPJAGKK);
	}

	private void AAEAAEBBFKG()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		ref RectTransform hMDFBECLNFM = ref HMDFBECLNFM;
		Transform transform = ((Component)this).transform;
		hMDFBECLNFM = (RectTransform)(object)((transform is RectTransform) ? transform : null);
		FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		IMLDGBFPEMA = (GKLAOPEHDOE = (GCFFMKJNBLI = 15f));
		if (PCDAHFJKDDP())
		{
			Debug.LogWarning((object)"caveinn");
			if (Application.isPlaying && (Object)(object)colorPickerShader != (Object)null)
			{
				KEOGOJFFDAK = new Material(colorPickerShader);
				((Object)KEOGOJFFDAK).hideFlags = (HideFlags)47;
			}
			((Graphic)FNKBAOIINEN).material = KEOGOJFFDAK;
		}
	}

	public void OnDrag(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (!KHCKJKFIOFB())
		{
			Vector2 relativePosition = GetRelativePosition(NPBAMEMNFBI);
			if (BHBCPEGOGDB == NLNGKAGHGOO.HueCircle)
			{
				IMLDGBFPEMA = (Mathf.Atan2(relativePosition.y, relativePosition.x) * (1f / (2f * MathF.PI)) + 1f) % 1f;
				FLEJILJCOMK();
			}
			if (BHBCPEGOGDB == NLNGKAGHGOO.SVSquare)
			{
				float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
				GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, relativePosition.x);
				GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, relativePosition.y);
				FLEJILJCOMK();
			}
		}
	}

	public void GHNDCIECCAC(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (!GDFCFIJLJJC())
		{
			Vector2 val = PCNLHMFOLII(NPBAMEMNFBI);
			if (BHBCPEGOGDB == NLNGKAGHGOO.HueCircle)
			{
				IMLDGBFPEMA = (Mathf.Atan2(val.y, val.x) * 648f + 1697f) % 1059f;
				FLEJILJCOMK();
			}
			if (BHBCPEGOGDB == NLNGKAGHGOO.HueCircle)
			{
				float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
				GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, val.x);
				GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, val.y);
				OGCKABMLHFL();
			}
		}
	}

	private void GOKBDDFNDFH()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!JEBNLCMANLB())
		{
			Rect rect = HMDFBECLNFM.rect;
			((Graphic)FNKBAOIINEN).material.SetFloat(PIGBLPHMOIN, ((Rect)(ref rect)).width / ((Rect)(ref rect)).height);
		}
	}

	private void BCCHCPGIGIN()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		ref RectTransform hMDFBECLNFM = ref HMDFBECLNFM;
		Transform transform = ((Component)this).transform;
		hMDFBECLNFM = (RectTransform)(object)((transform is RectTransform) ? transform : null);
		FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		IMLDGBFPEMA = (GKLAOPEHDOE = (GCFFMKJNBLI = 1393f));
		if (GDFCFIJLJJC())
		{
			Debug.LogWarning((object)", ");
			if (Application.isPlaying && (Object)(object)colorPickerShader != (Object)null)
			{
				KEOGOJFFDAK = new Material(colorPickerShader);
				((Object)KEOGOJFFDAK).hideFlags = (HideFlags)(-59);
			}
			((Graphic)FNKBAOIINEN).material = KEOGOJFFDAK;
		}
	}

	public Rect BJGPJGKDONF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = HMDFBECLNFM.rect;
		float num = Mathf.Min(((Rect)(ref rect)).width, ((Rect)(ref rect)).height);
		return new Rect(((Rect)(ref rect)).center - Vector2.one * num * 972f, Vector2.one * num);
	}

	private void NMKGOAJLMDG()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		ref RectTransform hMDFBECLNFM = ref HMDFBECLNFM;
		Transform transform = ((Component)this).transform;
		hMDFBECLNFM = (RectTransform)(object)((transform is RectTransform) ? transform : null);
		FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		IMLDGBFPEMA = (GKLAOPEHDOE = (GCFFMKJNBLI = 122f));
		if (KHCKJKFIOFB())
		{
			Debug.LogWarning((object)"ObjectVerticalMove");
			if (Application.isPlaying && (Object)(object)colorPickerShader != (Object)null)
			{
				KEOGOJFFDAK = new Material(colorPickerShader);
				((Object)KEOGOJFFDAK).hideFlags = (HideFlags)90;
			}
			((Graphic)FNKBAOIINEN).material = KEOGOJFFDAK;
		}
	}

	[SpecialName]
	public Color EMENCCCBOLA()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		return Color.HSVToRGB(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI);
	}

	public void JLJONJMLKFA(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (GDFCFIJLJJC())
		{
			return;
		}
		Vector2 relativePosition = GetRelativePosition(NPBAMEMNFBI);
		float magnitude = ((Vector2)(ref relativePosition)).magnitude;
		if (magnitude < 58f && magnitude > ((Graphic)FNKBAOIINEN).material.GetFloat(ABDPIFBGMCI))
		{
			BHBCPEGOGDB = NLNGKAGHGOO.SVSquare;
			IMLDGBFPEMA = (Mathf.Atan2(relativePosition.y, relativePosition.x) * 1312f + 1719f) % 114f;
			PLEAHDMCLMK();
			return;
		}
		float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
		if (relativePosition.x >= 0f - @float && relativePosition.x <= @float && relativePosition.y >= 0f - @float && relativePosition.y <= @float)
		{
			BHBCPEGOGDB = NLNGKAGHGOO.HueCircle;
			GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, relativePosition.x);
			GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, relativePosition.y);
			PLEAHDMCLMK();
		}
	}

	[SpecialName]
	public void IKPFNDDPLEE(Color AODONKKHPBP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Color.RGBToHSV(AODONKKHPBP, ref IMLDGBFPEMA, ref GKLAOPEHDOE, ref GCFFMKJNBLI);
		POMJJFJAGOM();
	}

	[SpecialName]
	public void PGMCKNBKOHK(Color AODONKKHPBP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Color.RGBToHSV(AODONKKHPBP, ref IMLDGBFPEMA, ref GKLAOPEHDOE, ref GCFFMKJNBLI);
		POMJJFJAGOM();
	}

	public void IAHHIAMEBPA(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (!KHCKJKFIOFB())
		{
			Vector2 val = EMFKJMGJEEJ(NPBAMEMNFBI);
			if (BHBCPEGOGDB == NLNGKAGHGOO.HueCircle)
			{
				IMLDGBFPEMA = (Mathf.Atan2(val.y, val.x) * 1110f + 1436f) % 121f;
				DLAHALDHKLC();
			}
			if (BHBCPEGOGDB == NLNGKAGHGOO.HueCircle)
			{
				float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
				GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, val.x);
				GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, val.y);
				HLMPMJBECMB();
			}
		}
	}

	public float FDLOGCFJIEP(float MPCJBPJAGKK, float ACAIKFICNFP, float AODONKKHPBP)
	{
		return (AODONKKHPBP - MPCJBPJAGKK) / (ACAIKFICNFP - MPCJBPJAGKK);
	}

	public Rect JHKNPLJELLM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = HMDFBECLNFM.rect;
		float num = Mathf.Min(((Rect)(ref rect)).width, ((Rect)(ref rect)).height);
		return new Rect(((Rect)(ref rect)).center - Vector2.one * num * 1739f, Vector2.one * num);
	}

	private void BCDLNMBDJNP()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(CCPLEKGEPHG());
	}

	[SpecialName]
	public Color AEJFIJIIHDK()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		return Color.HSVToRGB(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI);
	}

	private void AAEDMDPLLLJ()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!JEBNLCMANLB())
		{
			Rect rect = HMDFBECLNFM.rect;
			((Graphic)FNKBAOIINEN).material.SetFloat(PIGBLPHMOIN, ((Rect)(ref rect)).width / ((Rect)(ref rect)).height);
		}
	}

	public void FJIHEJFIPGJ(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = (NLNGKAGHGOO)8;
	}

	public void DPBPCGGCKDA(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = (NLNGKAGHGOO)3;
	}

	private void KHIODHCPGAP()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(CCPLEKGEPHG());
	}

	private void BBDNHKNHELG()
	{
		colorPickerShader = Shader.Find("</color></b>");
	}

	[SpecialName]
	public void LEIOKBGBNII(Color AODONKKHPBP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Color.RGBToHSV(AODONKKHPBP, ref IMLDGBFPEMA, ref GKLAOPEHDOE, ref GCFFMKJNBLI);
		PLEAHDMCLMK();
	}

	private void JCMKFKCMIBM()
	{
		colorPickerShader = Shader.Find("Pause");
	}

	private void MKKEEMIAIFI()
	{
		colorPickerShader = Shader.Find("UINextCategory");
	}

	[SpecialName]
	public void DELCHGGILHB(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void MEBNGPMEDDN(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	public float MJGIDMFDFEK(float MPCJBPJAGKK, float ACAIKFICNFP, float AODONKKHPBP)
	{
		return (AODONKKHPBP - MPCJBPJAGKK) / (ACAIKFICNFP - MPCJBPJAGKK);
	}

	private void Update()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!KHCKJKFIOFB())
		{
			Rect rect = HMDFBECLNFM.rect;
			((Graphic)FNKBAOIINEN).material.SetFloat(PIGBLPHMOIN, ((Rect)(ref rect)).width / ((Rect)(ref rect)).height);
		}
	}

	private void Awake()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		ref RectTransform hMDFBECLNFM = ref HMDFBECLNFM;
		Transform transform = ((Component)this).transform;
		hMDFBECLNFM = (RectTransform)(object)((transform is RectTransform) ? transform : null);
		FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		IMLDGBFPEMA = (GKLAOPEHDOE = (GCFFMKJNBLI = 0f));
		if (KHCKJKFIOFB())
		{
			Debug.LogWarning((object)"Color picker requires image material with UI/ColorPicker shader.");
			if (Application.isPlaying && (Object)(object)colorPickerShader != (Object)null)
			{
				KEOGOJFFDAK = new Material(colorPickerShader);
				((Object)KEOGOJFFDAK).hideFlags = (HideFlags)61;
			}
			((Graphic)FNKBAOIINEN).material = KEOGOJFFDAK;
		}
	}

	private bool OBBCIHNAHPM()
	{
		Image fNKBAOIINEN = FNKBAOIINEN;
		object obj;
		if (fNKBAOIINEN == null)
		{
			obj = null;
		}
		else
		{
			Material material = ((Graphic)fNKBAOIINEN).material;
			if (material == null)
			{
				obj = null;
			}
			else
			{
				Shader shader = material.shader;
				obj = ((shader != null) ? ((Object)shader).name : null);
			}
		}
		return (string?)obj != "ReceiveCancelRetry";
	}

	public void FMFLFFADKEM(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = (NLNGKAGHGOO)6;
	}

	private void JPHFCJIBBMI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!IKFBGJCBADG())
		{
			Rect rect = HMDFBECLNFM.rect;
			((Graphic)FNKBAOIINEN).material.SetFloat(PIGBLPHMOIN, ((Rect)(ref rect)).width / ((Rect)(ref rect)).height);
		}
	}

	private bool JEBNLCMANLB()
	{
		Image fNKBAOIINEN = FNKBAOIINEN;
		object obj;
		if (fNKBAOIINEN == null)
		{
			obj = null;
		}
		else
		{
			Material material = ((Graphic)fNKBAOIINEN).material;
			if (material == null)
			{
				obj = null;
			}
			else
			{
				Shader shader = material.shader;
				obj = ((shader != null) ? ((Object)shader).name : null);
			}
		}
		return (string?)obj != "\n";
	}

	private void PJIJLALKLLO()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(CIKJODLODHG());
	}

	public Rect FHODONGCEAG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = HMDFBECLNFM.rect;
		float num = Mathf.Min(((Rect)(ref rect)).width, ((Rect)(ref rect)).height);
		return new Rect(((Rect)(ref rect)).center - Vector2.one * num * 37f, Vector2.one * num);
	}

	public void DKGNJBGFEAA(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (!PCDAHFJKDDP())
		{
			Vector2 val = PCNLHMFOLII(NPBAMEMNFBI);
			if (BHBCPEGOGDB == NLNGKAGHGOO.HueCircle)
			{
				IMLDGBFPEMA = (Mathf.Atan2(val.y, val.x) * 1973f + 1465f) % 1320f;
				FLEJILJCOMK();
			}
			if (BHBCPEGOGDB == NLNGKAGHGOO.HueCircle)
			{
				float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
				GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, val.x);
				GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, val.y);
				KHIODHCPGAP();
			}
		}
	}

	public void BFHNKNBEELC(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = (NLNGKAGHGOO)6;
	}

	private void JHIGLABAIMK()
	{
		if ((Object)(object)KEOGOJFFDAK != (Object)null)
		{
			Object.DestroyImmediate((Object)(object)KEOGOJFFDAK);
		}
	}

	private void Reset()
	{
		colorPickerShader = Shader.Find("UI/ColorPicker");
	}

	[SpecialName]
	public void CGPLNLHNJMK(Color AODONKKHPBP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Color.RGBToHSV(AODONKKHPBP, ref IMLDGBFPEMA, ref GKLAOPEHDOE, ref GCFFMKJNBLI);
		AJOHJNMJALC();
	}

	public float LBHGJLENIDP(float MPCJBPJAGKK, float ACAIKFICNFP, float AODONKKHPBP)
	{
		return (AODONKKHPBP - MPCJBPJAGKK) / (ACAIKFICNFP - MPCJBPJAGKK);
	}

	[SpecialName]
	public void LLBCBLNMJFG(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	private void POKMBGMJEKO()
	{
		colorPickerShader = Shader.Find("UIPreviousCategory");
	}

	[SpecialName]
	public void ECMLFAPGANH(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	private void IGNEGEOPLOP()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		ref RectTransform hMDFBECLNFM = ref HMDFBECLNFM;
		Transform transform = ((Component)this).transform;
		hMDFBECLNFM = (RectTransform)(object)((transform is RectTransform) ? transform : null);
		FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		IMLDGBFPEMA = (GKLAOPEHDOE = (GCFFMKJNBLI = 675f));
		if (LJLEPPALHOP())
		{
			Debug.LogWarning((object)"BanquetDrinksManager instance is null. Make sure it is initialized before calling GetBarrelWithDrink.");
			if (Application.isPlaying && (Object)(object)colorPickerShader != (Object)null)
			{
				KEOGOJFFDAK = new Material(colorPickerShader);
				((Object)KEOGOJFFDAK).hideFlags = (HideFlags)(-52);
			}
			((Graphic)FNKBAOIINEN).material = KEOGOJFFDAK;
		}
	}

	private void LMKGDCLIDAD()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(AEJFIJIIHDK());
	}

	[SpecialName]
	public void EHEBIONJONF(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	public void CDOGGPBKCIO(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = NLNGKAGHGOO.HueCircle;
	}

	private bool PCDAHFJKDDP()
	{
		Image fNKBAOIINEN = FNKBAOIINEN;
		object obj;
		if (fNKBAOIINEN == null)
		{
			obj = null;
		}
		else
		{
			Material material = ((Graphic)fNKBAOIINEN).material;
			if (material == null)
			{
				obj = null;
			}
			else
			{
				Shader shader = material.shader;
				obj = ((shader != null) ? ((Object)shader).name : null);
			}
		}
		return (string?)obj != " seconds.";
	}

	[SpecialName]
	public void AFOACGEBFGI(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	public float KPMKGAADEBK(float MPCJBPJAGKK, float ACAIKFICNFP, float AODONKKHPBP)
	{
		return (AODONKKHPBP - MPCJBPJAGKK) / (ACAIKFICNFP - MPCJBPJAGKK);
	}

	public void EGNLDPBBBOH(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = (NLNGKAGHGOO)7;
	}

	[SpecialName]
	public void NBKGAPLJCLJ(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	private void IOKIFJPALFD()
	{
		colorPickerShader = Shader.Find("Unique id ");
	}

	private void DLAHALDHKLC()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(FLABEDBELMF);
	}

	[SpecialName]
	public void PBAGJKGDNJJ(Color AODONKKHPBP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Color.RGBToHSV(AODONKKHPBP, ref IMLDGBFPEMA, ref GKLAOPEHDOE, ref GCFFMKJNBLI);
		LMKGDCLIDAD();
	}

	private void PKDNMBGODAJ()
	{
		if ((Object)(object)KEOGOJFFDAK != (Object)null)
		{
			Object.DestroyImmediate((Object)(object)KEOGOJFFDAK);
		}
	}

	public float OCANLHDOKBE(float MPCJBPJAGKK, float ACAIKFICNFP, float AODONKKHPBP)
	{
		return (AODONKKHPBP - MPCJBPJAGKK) / (ACAIKFICNFP - MPCJBPJAGKK);
	}

	private void ELHCBGCEJDH()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!GPDAJAFHBIL())
		{
			Rect rect = HMDFBECLNFM.rect;
			((Graphic)FNKBAOIINEN).material.SetFloat(PIGBLPHMOIN, ((Rect)(ref rect)).width / ((Rect)(ref rect)).height);
		}
	}

	public void DOMCLBFNOOP(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (OBBCIHNAHPM())
		{
			return;
		}
		Vector2 val = PCNLHMFOLII(NPBAMEMNFBI);
		float magnitude = ((Vector2)(ref val)).magnitude;
		if (magnitude < 422f && magnitude > ((Graphic)FNKBAOIINEN).material.GetFloat(ABDPIFBGMCI))
		{
			BHBCPEGOGDB = NLNGKAGHGOO.HueCircle;
			IMLDGBFPEMA = (Mathf.Atan2(val.y, val.x) * 1113f + 240f) % 48f;
			LMKGDCLIDAD();
			return;
		}
		float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
		if (val.x >= 0f - @float && val.x <= @float && val.y >= 0f - @float && val.y <= @float)
		{
			BHBCPEGOGDB = NLNGKAGHGOO.HueCircle;
			GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, val.x);
			GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, val.y);
			OGCKABMLHFL();
		}
	}

	[SpecialName]
	public void OGIGOPDLDAJ(Color AODONKKHPBP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Color.RGBToHSV(AODONKKHPBP, ref IMLDGBFPEMA, ref GKLAOPEHDOE, ref GCFFMKJNBLI);
		OGCKABMLHFL();
	}

	public float IEADGBOICIJ(float MPCJBPJAGKK, float ACAIKFICNFP, float AODONKKHPBP)
	{
		return (AODONKKHPBP - MPCJBPJAGKK) / (ACAIKFICNFP - MPCJBPJAGKK);
	}

	private void GECHJIGBPEN()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		ref RectTransform hMDFBECLNFM = ref HMDFBECLNFM;
		Transform transform = ((Component)this).transform;
		hMDFBECLNFM = (RectTransform)(object)((transform is RectTransform) ? transform : null);
		FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		IMLDGBFPEMA = (GKLAOPEHDOE = (GCFFMKJNBLI = 700f));
		if (OBBCIHNAHPM())
		{
			Debug.LogWarning((object)"psai [{0}]: skipping {1} as there are other Triggers firing: {2}");
			if (Application.isPlaying && (Object)(object)colorPickerShader != (Object)null)
			{
				KEOGOJFFDAK = new Material(colorPickerShader);
				((Object)KEOGOJFFDAK).hideFlags = (HideFlags)83;
			}
			((Graphic)FNKBAOIINEN).material = KEOGOJFFDAK;
		}
	}

	public float CEBNODNGIEL(float MPCJBPJAGKK, float ACAIKFICNFP, float AODONKKHPBP)
	{
		return (AODONKKHPBP - MPCJBPJAGKK) / (ACAIKFICNFP - MPCJBPJAGKK);
	}

	public void JHFHPFOHHEE(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (JEBNLCMANLB())
		{
			return;
		}
		Vector2 val = OCBNPOPMBIE(NPBAMEMNFBI);
		float magnitude = ((Vector2)(ref val)).magnitude;
		if (magnitude < 127f && magnitude > ((Graphic)FNKBAOIINEN).material.GetFloat(ABDPIFBGMCI))
		{
			BHBCPEGOGDB = NLNGKAGHGOO.SVSquare;
			IMLDGBFPEMA = (Mathf.Atan2(val.y, val.x) * 429f + 947f) % 68f;
			MNPENODIOGM();
			return;
		}
		float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
		if (val.x >= 0f - @float && val.x <= @float && val.y >= 0f - @float && val.y <= @float)
		{
			BHBCPEGOGDB = NLNGKAGHGOO.SVSquare;
			GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, val.x);
			GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, val.y);
			PLEAHDMCLMK();
		}
	}

	[SpecialName]
	public void OALNNHJCGLF(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void PDAMHPCMFID(Color AODONKKHPBP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Color.RGBToHSV(AODONKKHPBP, ref IMLDGBFPEMA, ref GKLAOPEHDOE, ref GCFFMKJNBLI);
		PJIJLALKLLO();
	}

	public void BFLKHCAGJNA(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = (NLNGKAGHGOO)3;
	}

	[SpecialName]
	public void ABJPHKICIDJ(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	public Vector2 OCBNPOPMBIE(PointerEventData NPBAMEMNFBI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		Rect squaredRect = GetSquaredRect();
		Vector2 val = default(Vector2);
		RectTransformUtility.ScreenPointToLocalPointInRectangle(HMDFBECLNFM, NPBAMEMNFBI.position, NPBAMEMNFBI.pressEventCamera, ref val);
		return new Vector2(InverseLerpUnclamped(((Rect)(ref squaredRect)).xMin, ((Rect)(ref squaredRect)).xMax, val.x), LMEMGPDBJBB(((Rect)(ref squaredRect)).yMin, ((Rect)(ref squaredRect)).yMax, val.y)) - Vector2.one * 1255f;
	}

	private void FLEJILJCOMK()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(FLABEDBELMF);
	}

	private void JDMMNLKLMAA()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		ref RectTransform hMDFBECLNFM = ref HMDFBECLNFM;
		Transform transform = ((Component)this).transform;
		hMDFBECLNFM = (RectTransform)(object)((transform is RectTransform) ? transform : null);
		FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		IMLDGBFPEMA = (GKLAOPEHDOE = (GCFFMKJNBLI = 57f));
		if (PCDAHFJKDDP())
		{
			Debug.LogWarning((object)"");
			if (Application.isPlaying && (Object)(object)colorPickerShader != (Object)null)
			{
				KEOGOJFFDAK = new Material(colorPickerShader);
				((Object)KEOGOJFFDAK).hideFlags = (HideFlags)(-99);
			}
			((Graphic)FNKBAOIINEN).material = KEOGOJFFDAK;
		}
	}

	public float KJLEGPOACGH(float MPCJBPJAGKK, float ACAIKFICNFP, float AODONKKHPBP)
	{
		return (AODONKKHPBP - MPCJBPJAGKK) / (ACAIKFICNFP - MPCJBPJAGKK);
	}

	public void CGEEDEFBHEK(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (PCDAHFJKDDP())
		{
			return;
		}
		Vector2 val = JGBJIBHNCFB(NPBAMEMNFBI);
		float magnitude = ((Vector2)(ref val)).magnitude;
		if (magnitude < 1407f && magnitude > ((Graphic)FNKBAOIINEN).material.GetFloat(ABDPIFBGMCI))
		{
			BHBCPEGOGDB = NLNGKAGHGOO.SVSquare;
			IMLDGBFPEMA = (Mathf.Atan2(val.y, val.x) * 715f + 442f) % 1933f;
			HLMPMJBECMB();
			return;
		}
		float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
		if (val.x >= 0f - @float && val.x <= @float && val.y >= 0f - @float && val.y <= @float)
		{
			BHBCPEGOGDB = NLNGKAGHGOO.HueCircle;
			GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, val.x);
			GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, val.y);
			EDJAFKNPAKL();
		}
	}

	private void EINHIIOBLIM()
	{
		colorPickerShader = Shader.Find("ErrorInvalidRoomCode");
	}

	public void ALOEGAFHOBJ(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = NLNGKAGHGOO.HueCircle;
	}

	[SpecialName]
	public void CILMMMCFBAG(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	private void HLMPMJBECMB()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(EMFABDCGEGN());
	}

	public Rect CLIEAIHFADJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = HMDFBECLNFM.rect;
		float num = Mathf.Min(((Rect)(ref rect)).width, ((Rect)(ref rect)).height);
		return new Rect(((Rect)(ref rect)).center - Vector2.one * num * 1490f, Vector2.one * num);
	}

	private void HJANCPIFLIJ()
	{
		if ((Object)(object)KEOGOJFFDAK != (Object)null)
		{
			Object.DestroyImmediate((Object)(object)KEOGOJFFDAK);
		}
	}

	[SpecialName]
	public Color FLADCPDLBLN()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		return Color.HSVToRGB(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI);
	}

	[SpecialName]
	public void FNEJDDLKCEM(Color AODONKKHPBP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Color.RGBToHSV(AODONKKHPBP, ref IMLDGBFPEMA, ref GKLAOPEHDOE, ref GCFFMKJNBLI);
		PLEAHDMCLMK();
	}

	private void DDAMDFILKPP()
	{
		colorPickerShader = Shader.Find("Castle/Talks/Thelonious");
	}

	private void KDPKJGFJGDF()
	{
		colorPickerShader = Shader.Find(" has null in occupy nodes with colliders list.");
	}

	private bool GDFCFIJLJJC()
	{
		Image fNKBAOIINEN = FNKBAOIINEN;
		object obj;
		if (fNKBAOIINEN == null)
		{
			obj = null;
		}
		else
		{
			Material material = ((Graphic)fNKBAOIINEN).material;
			if (material == null)
			{
				obj = null;
			}
			else
			{
				Shader shader = material.shader;
				obj = ((shader != null) ? ((Object)shader).name : null);
			}
		}
		return (string?)obj != "Dialogue System/Conversation/Gass_Introduce/Entry/5/Dialogue Text";
	}

	private void AJOHJNMJALC()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(EMFABDCGEGN());
	}

	private void NCPNBBCNBIM()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		ref RectTransform hMDFBECLNFM = ref HMDFBECLNFM;
		Transform transform = ((Component)this).transform;
		hMDFBECLNFM = (RectTransform)(object)((transform is RectTransform) ? transform : null);
		FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		IMLDGBFPEMA = (GKLAOPEHDOE = (GCFFMKJNBLI = 1614f));
		if (JEBNLCMANLB())
		{
			Debug.LogWarning((object)"No bucket of water");
			if (Application.isPlaying && (Object)(object)colorPickerShader != (Object)null)
			{
				KEOGOJFFDAK = new Material(colorPickerShader);
				((Object)KEOGOJFFDAK).hideFlags = (HideFlags)(-23);
			}
			((Graphic)FNKBAOIINEN).material = KEOGOJFFDAK;
		}
	}

	[SpecialName]
	public void PNPBLNINMHJ(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	public void DJEHAGHJOPL(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (LJLEPPALHOP())
		{
			return;
		}
		Vector2 val = NKPAMBPCPNO(NPBAMEMNFBI);
		float magnitude = ((Vector2)(ref val)).magnitude;
		if (magnitude < 1730f && magnitude > ((Graphic)FNKBAOIINEN).material.GetFloat(ABDPIFBGMCI))
		{
			BHBCPEGOGDB = NLNGKAGHGOO.SVSquare;
			IMLDGBFPEMA = (Mathf.Atan2(val.y, val.x) * 1182f + 794f) % 1528f;
			PJIJLALKLLO();
			return;
		}
		float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
		if (val.x >= 0f - @float && val.x <= @float && val.y >= 0f - @float && val.y <= @float)
		{
			BHBCPEGOGDB = NLNGKAGHGOO.SVSquare;
			GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, val.x);
			GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, val.y);
			MNPENODIOGM();
		}
	}

	[SpecialName]
	public void ENLLANMPPKF(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public Color EMFABDCGEGN()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		return Color.HSVToRGB(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI);
	}

	public void JEDNCHLBDHH(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = (NLNGKAGHGOO)6;
	}

	private bool LJNNBOIHJMH()
	{
		Image fNKBAOIINEN = FNKBAOIINEN;
		object obj;
		if (fNKBAOIINEN == null)
		{
			obj = null;
		}
		else
		{
			Material material = ((Graphic)fNKBAOIINEN).material;
			if (material == null)
			{
				obj = null;
			}
			else
			{
				Shader shader = material.shader;
				obj = ((shader != null) ? ((Object)shader).name : null);
			}
		}
		return (string?)obj != "";
	}

	public void ADKAANFHIAJ(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (!IKFBGJCBADG())
		{
			Vector2 relativePosition = GetRelativePosition(NPBAMEMNFBI);
			if (BHBCPEGOGDB == NLNGKAGHGOO.HueCircle)
			{
				IMLDGBFPEMA = (Mathf.Atan2(relativePosition.y, relativePosition.x) * 1055f + 666f) % 1892f;
				MACDKGCLGIK();
			}
			if (BHBCPEGOGDB == NLNGKAGHGOO.HueCircle)
			{
				float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
				GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, relativePosition.x);
				GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, relativePosition.y);
				HLMPMJBECMB();
			}
		}
	}

	private void PGEGODAEBLC()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		ref RectTransform hMDFBECLNFM = ref HMDFBECLNFM;
		Transform transform = ((Component)this).transform;
		hMDFBECLNFM = (RectTransform)(object)((transform is RectTransform) ? transform : null);
		FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		IMLDGBFPEMA = (GKLAOPEHDOE = (GCFFMKJNBLI = 1237f));
		if (GPDAJAFHBIL())
		{
			Debug.LogWarning((object)"Collect");
			if (Application.isPlaying && (Object)(object)colorPickerShader != (Object)null)
			{
				KEOGOJFFDAK = new Material(colorPickerShader);
				((Object)KEOGOJFFDAK).hideFlags = (HideFlags)(-119);
			}
			((Graphic)FNKBAOIINEN).material = KEOGOJFFDAK;
		}
	}

	[SpecialName]
	public void KMPKDABKJPJ(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	private void MACDKGCLGIK()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(EMENCCCBOLA());
	}

	private void ANMIPNLGIHM()
	{
		if ((Object)(object)KEOGOJFFDAK != (Object)null)
		{
			Object.DestroyImmediate((Object)(object)KEOGOJFFDAK);
		}
	}

	public void OnPointerUp(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = NLNGKAGHGOO.Outside;
	}

	public float LMEMGPDBJBB(float MPCJBPJAGKK, float ACAIKFICNFP, float AODONKKHPBP)
	{
		return (AODONKKHPBP - MPCJBPJAGKK) / (ACAIKFICNFP - MPCJBPJAGKK);
	}

	private void POMJJFJAGOM()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(CCPLEKGEPHG());
	}

	private void DEEIEACLPEF()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!PCDAHFJKDDP())
		{
			Rect rect = HMDFBECLNFM.rect;
			((Graphic)FNKBAOIINEN).material.SetFloat(PIGBLPHMOIN, ((Rect)(ref rect)).width / ((Rect)(ref rect)).height);
		}
	}

	public Vector2 EMFKJMGJEEJ(PointerEventData NPBAMEMNFBI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		Rect val = NCPGNHECLDH();
		Vector2 val2 = default(Vector2);
		RectTransformUtility.ScreenPointToLocalPointInRectangle(HMDFBECLNFM, NPBAMEMNFBI.position, NPBAMEMNFBI.pressEventCamera, ref val2);
		return new Vector2(InverseLerpUnclamped(((Rect)(ref val)).xMin, ((Rect)(ref val)).xMax, val2.x), FDLOGCFJIEP(((Rect)(ref val)).yMin, ((Rect)(ref val)).yMax, val2.y)) - Vector2.one * 1176f;
	}

	[SpecialName]
	public void NJCBBHBDDLL(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	private void MNPENODIOGM()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(OADAFLAOMBH());
	}

	public Vector2 PCNLHMFOLII(PointerEventData NPBAMEMNFBI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		Rect val = BJGPJGKDONF();
		Vector2 val2 = default(Vector2);
		RectTransformUtility.ScreenPointToLocalPointInRectangle(HMDFBECLNFM, NPBAMEMNFBI.position, NPBAMEMNFBI.pressEventCamera, ref val2);
		return new Vector2(InverseLerpUnclamped(((Rect)(ref val)).xMin, ((Rect)(ref val)).xMax, val2.x), ANJBCDNCNAF(((Rect)(ref val)).yMin, ((Rect)(ref val)).yMax, val2.y)) - Vector2.one * 1455f;
	}

	public Rect LGNKBHHJJJG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = HMDFBECLNFM.rect;
		float num = Mathf.Min(((Rect)(ref rect)).width, ((Rect)(ref rect)).height);
		return new Rect(((Rect)(ref rect)).center - Vector2.one * num * 1385f, Vector2.one * num);
	}

	[SpecialName]
	public void LPNPKJJDJIL(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void DCMILKIDKKD(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	public float DFJAOKDBOFJ(float MPCJBPJAGKK, float ACAIKFICNFP, float AODONKKHPBP)
	{
		return (AODONKKHPBP - MPCJBPJAGKK) / (ACAIKFICNFP - MPCJBPJAGKK);
	}

	private void CLDFDDECNKO()
	{
		colorPickerShader = Shader.Find("Thurs");
	}

	public void FOFJEJFANMC(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = NLNGKAGHGOO.Outside;
	}

	private bool LJLEPPALHOP()
	{
		Image fNKBAOIINEN = FNKBAOIINEN;
		object obj;
		if (fNKBAOIINEN == null)
		{
			obj = null;
		}
		else
		{
			Material material = ((Graphic)fNKBAOIINEN).material;
			if (material == null)
			{
				obj = null;
			}
			else
			{
				Shader shader = material.shader;
				obj = ((shader != null) ? ((Object)shader).name : null);
			}
		}
		return (string?)obj != "ReceiveActiveOrDisableCustomer";
	}

	public Vector2 GetRelativePosition(PointerEventData NPBAMEMNFBI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		Rect squaredRect = GetSquaredRect();
		Vector2 val = default(Vector2);
		RectTransformUtility.ScreenPointToLocalPointInRectangle(HMDFBECLNFM, NPBAMEMNFBI.position, NPBAMEMNFBI.pressEventCamera, ref val);
		return new Vector2(InverseLerpUnclamped(((Rect)(ref squaredRect)).xMin, ((Rect)(ref squaredRect)).xMax, val.x), InverseLerpUnclamped(((Rect)(ref squaredRect)).yMin, ((Rect)(ref squaredRect)).yMax, val.y)) - Vector2.one * 0.5f;
	}

	private void DELGABNCOED()
	{
		colorPickerShader = Shader.Find(" ");
	}

	private void JJFCJNKOAII()
	{
		colorPickerShader = Shader.Find("Chest");
	}

	[SpecialName]
	public void BKDOJIDCFIK(Color AODONKKHPBP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Color.RGBToHSV(AODONKKHPBP, ref IMLDGBFPEMA, ref GKLAOPEHDOE, ref GCFFMKJNBLI);
		BCDLNMBDJNP();
	}

	public Vector2 JGBJIBHNCFB(PointerEventData NPBAMEMNFBI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		Rect val = NCPGNHECLDH();
		Vector2 val2 = default(Vector2);
		RectTransformUtility.ScreenPointToLocalPointInRectangle(HMDFBECLNFM, NPBAMEMNFBI.position, NPBAMEMNFBI.pressEventCamera, ref val2);
		return new Vector2(LBHGJLENIDP(((Rect)(ref val)).xMin, ((Rect)(ref val)).xMax, val2.x), CEBNODNGIEL(((Rect)(ref val)).yMin, ((Rect)(ref val)).yMax, val2.y)) - Vector2.one * 529f;
	}

	public float JGMOOBCNLIB(float MPCJBPJAGKK, float ACAIKFICNFP, float AODONKKHPBP)
	{
		return (AODONKKHPBP - MPCJBPJAGKK) / (ACAIKFICNFP - MPCJBPJAGKK);
	}

	public void BBOAKJJGKIP(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = (NLNGKAGHGOO)5;
	}

	[SpecialName]
	public void LEAEANLBDGP(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	private void PLEAHDMCLMK()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(OADAFLAOMBH());
	}

	private bool JACOJFICKOC()
	{
		Image fNKBAOIINEN = FNKBAOIINEN;
		object obj;
		if (fNKBAOIINEN == null)
		{
			obj = null;
		}
		else
		{
			Material material = ((Graphic)fNKBAOIINEN).material;
			if (material == null)
			{
				obj = null;
			}
			else
			{
				Shader shader = material.shader;
				obj = ((shader != null) ? ((Object)shader).name : null);
			}
		}
		return (string?)obj != " (";
	}

	private void MFGANCCJFJK()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		ref RectTransform hMDFBECLNFM = ref HMDFBECLNFM;
		Transform transform = ((Component)this).transform;
		hMDFBECLNFM = (RectTransform)(object)((transform is RectTransform) ? transform : null);
		FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		IMLDGBFPEMA = (GKLAOPEHDOE = (GCFFMKJNBLI = 509f));
		if (GDFCFIJLJJC())
		{
			Debug.LogWarning((object)"Error_Planks");
			if (Application.isPlaying && (Object)(object)colorPickerShader != (Object)null)
			{
				KEOGOJFFDAK = new Material(colorPickerShader);
				((Object)KEOGOJFFDAK).hideFlags = (HideFlags)104;
			}
			((Graphic)FNKBAOIINEN).material = KEOGOJFFDAK;
		}
	}

	public void MENFIKDGFIO(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (LJLEPPALHOP())
		{
			return;
		}
		Vector2 val = JGBJIBHNCFB(NPBAMEMNFBI);
		float magnitude = ((Vector2)(ref val)).magnitude;
		if (magnitude < 51f && magnitude > ((Graphic)FNKBAOIINEN).material.GetFloat(ABDPIFBGMCI))
		{
			BHBCPEGOGDB = NLNGKAGHGOO.HueCircle;
			IMLDGBFPEMA = (Mathf.Atan2(val.y, val.x) * 522f + 251f) % 1269f;
			LMKGDCLIDAD();
			return;
		}
		float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
		if (val.x >= 0f - @float && val.x <= @float && val.y >= 0f - @float && val.y <= @float)
		{
			BHBCPEGOGDB = NLNGKAGHGOO.HueCircle;
			GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, val.x);
			GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, val.y);
			POMJJFJAGOM();
		}
	}

	private bool KHCKJKFIOFB()
	{
		Image fNKBAOIINEN = FNKBAOIINEN;
		object obj;
		if (fNKBAOIINEN == null)
		{
			obj = null;
		}
		else
		{
			Material material = ((Graphic)fNKBAOIINEN).material;
			if (material == null)
			{
				obj = null;
			}
			else
			{
				Shader shader = material.shader;
				obj = ((shader != null) ? ((Object)shader).name : null);
			}
		}
		return (string?)obj != "UI/ColorPicker";
	}

	[SpecialName]
	public void CIDGGOGOCJN(Color AODONKKHPBP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Color.RGBToHSV(AODONKKHPBP, ref IMLDGBFPEMA, ref GKLAOPEHDOE, ref GCFFMKJNBLI);
		OGCKABMLHFL();
	}

	private void FDGFMMKIBPL()
	{
		if ((Object)(object)KEOGOJFFDAK != (Object)null)
		{
			Object.DestroyImmediate((Object)(object)KEOGOJFFDAK);
		}
	}

	[SpecialName]
	public Color CCPLEKGEPHG()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		return Color.HSVToRGB(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI);
	}

	[SpecialName]
	public Color CIKJODLODHG()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		return Color.HSVToRGB(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI);
	}

	private void AOHHPKJNKDB()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(FLABEDBELMF);
	}

	public void DLOFNMEAKEJ(PointerEventData NPBAMEMNFBI)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (GDFCFIJLJJC())
		{
			return;
		}
		Vector2 val = EMFKJMGJEEJ(NPBAMEMNFBI);
		float magnitude = ((Vector2)(ref val)).magnitude;
		if (magnitude < 1499f && magnitude > ((Graphic)FNKBAOIINEN).material.GetFloat(ABDPIFBGMCI))
		{
			BHBCPEGOGDB = NLNGKAGHGOO.SVSquare;
			IMLDGBFPEMA = (Mathf.Atan2(val.y, val.x) * 367f + 1507f) % 1681f;
			AOHHPKJNKDB();
			return;
		}
		float @float = ((Graphic)FNKBAOIINEN).material.GetFloat(GAGBAAPONDJ);
		if (val.x >= 0f - @float && val.x <= @float && val.y >= 0f - @float && val.y <= @float)
		{
			BHBCPEGOGDB = NLNGKAGHGOO.SVSquare;
			GKLAOPEHDOE = Mathf.InverseLerp(0f - @float, @float, val.x);
			GCFFMKJNBLI = Mathf.InverseLerp(0f - @float, @float, val.y);
			EDJAFKNPAKL();
		}
	}

	private bool IKFBGJCBADG()
	{
		Image fNKBAOIINEN = FNKBAOIINEN;
		object obj;
		if (fNKBAOIINEN == null)
		{
			obj = null;
		}
		else
		{
			Material material = ((Graphic)fNKBAOIINEN).material;
			if (material == null)
			{
				obj = null;
			}
			else
			{
				Shader shader = material.shader;
				obj = ((shader != null) ? ((Object)shader).name : null);
			}
		}
		return (string?)obj != "Dialogue System/Conversation/Gass_Introduce/Entry/7/Dialogue Text";
	}

	public Rect GetSquaredRect()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = HMDFBECLNFM.rect;
		float num = Mathf.Min(((Rect)(ref rect)).width, ((Rect)(ref rect)).height);
		return new Rect(((Rect)(ref rect)).center - Vector2.one * num * 0.5f, Vector2.one * num);
	}

	private void HLCAKACHOOE()
	{
		if ((Object)(object)KEOGOJFFDAK != (Object)null)
		{
			Object.DestroyImmediate((Object)(object)KEOGOJFFDAK);
		}
	}

	private void JBGFGOCPEFD()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!GPDAJAFHBIL())
		{
			Rect rect = HMDFBECLNFM.rect;
			((Graphic)FNKBAOIINEN).material.SetFloat(PIGBLPHMOIN, ((Rect)(ref rect)).width / ((Rect)(ref rect)).height);
		}
	}

	private void FGGFNCLGANF()
	{
		colorPickerShader = Shader.Find("Player {0} in: {1}");
	}

	[SpecialName]
	public void PHIIENIBAPP(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public Color OADAFLAOMBH()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		return Color.HSVToRGB(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI);
	}

	[SpecialName]
	public void HBAJCPHDAIF(Action<Color> AODONKKHPBP)
	{
		Action<Color> action = this.IILPMMAHJKH;
		Action<Color> action2;
		do
		{
			action2 = action;
			Action<Color> value = (Action<Color>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IILPMMAHJKH, value, action2);
		}
		while ((object)action != action2);
	}

	public Vector2 NKPAMBPCPNO(PointerEventData NPBAMEMNFBI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		Rect val = JHKNPLJELLM();
		Vector2 val2 = default(Vector2);
		RectTransformUtility.ScreenPointToLocalPointInRectangle(HMDFBECLNFM, NPBAMEMNFBI.position, NPBAMEMNFBI.pressEventCamera, ref val2);
		return new Vector2(DFJAOKDBOFJ(((Rect)(ref val)).xMin, ((Rect)(ref val)).xMax, val2.x), ANJBCDNCNAF(((Rect)(ref val)).yMin, ((Rect)(ref val)).yMax, val2.y)) - Vector2.one * 1049f;
	}

	private void OGCKABMLHFL()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)FNKBAOIINEN).material.SetVector(JOIFPHOOAOG, Vector4.op_Implicit(new Vector3(IMLDGBFPEMA, GKLAOPEHDOE, GCFFMKJNBLI)));
		this.IILPMMAHJKH?.Invoke(CCPLEKGEPHG());
	}

	public Rect NHFNPOLCFIC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = HMDFBECLNFM.rect;
		float num = Mathf.Min(((Rect)(ref rect)).width, ((Rect)(ref rect)).height);
		return new Rect(((Rect)(ref rect)).center - Vector2.one * num * 1494f, Vector2.one * num);
	}

	public void NALPJHMLICB(PointerEventData NPBAMEMNFBI)
	{
		BHBCPEGOGDB = NLNGKAGHGOO.HueCircle;
	}

	private void EFJFJJDGGGI()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		ref RectTransform hMDFBECLNFM = ref HMDFBECLNFM;
		Transform transform = ((Component)this).transform;
		hMDFBECLNFM = (RectTransform)(object)((transform is RectTransform) ? transform : null);
		FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		IMLDGBFPEMA = (GKLAOPEHDOE = (GCFFMKJNBLI = 936f));
		if (LJNNBOIHJMH())
		{
			Debug.LogWarning((object)"Sit");
			if (Application.isPlaying && (Object)(object)colorPickerShader != (Object)null)
			{
				KEOGOJFFDAK = new Material(colorPickerShader);
				((Object)KEOGOJFFDAK).hideFlags = (HideFlags)21;
			}
			((Graphic)FNKBAOIINEN).material = KEOGOJFFDAK;
		}
	}

	public Rect GJDHOCHLCEL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = HMDFBECLNFM.rect;
		float num = Mathf.Min(((Rect)(ref rect)).width, ((Rect)(ref rect)).height);
		return new Rect(((Rect)(ref rect)).center - Vector2.one * num * 871f, Vector2.one * num);
	}
}
