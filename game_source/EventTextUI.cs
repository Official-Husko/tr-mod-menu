using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EventTextUI : UIWindow
{
	[CompilerGenerated]
	private sealed class MOMAAHMJFJN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float alpha;

		public Image image;

		public EventTextUI _003C_003E4__this;

		private float _003ClerpDuration_003E5__2;

		private float _003CelapsedTime_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public MOMAAHMJFJN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			EventTextUI eventTextUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003ClerpDuration_003E5__2 = 1f;
				_003CelapsedTime_003E5__3 = 0f;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003CelapsedTime_003E5__3 < _003ClerpDuration_003E5__2)
			{
				_003CelapsedTime_003E5__3 += Time.deltaTime;
				float a = Mathf.Lerp(0f, alpha, _003CelapsedTime_003E5__3 / _003ClerpDuration_003E5__2);
				Color color = ((Graphic)image).color;
				color.a = a;
				((Graphic)image).color = color;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			((Component)eventTextUI.eventText).gameObject.SetActive(true);
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	private static EventTextUI[] GJBBNHCMNJN = new EventTextUI[3];

	public TextMeshProUGUI eventText;

	public Image imageBg;

	public Image imageBg2;

	public static EventTextUI MHOKIBDMIPL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI FBKOKJCKICN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator DCLIOPCDFPP(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	private IEnumerator LLHBMJOMEFK(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		return new MOMAAHMJFJN(1)
		{
			_003C_003E4__this = this,
			image = FNKBAOIINEN,
			alpha = GODBHHOFBMJ
		};
	}

	private IEnumerator FLCEMDOBBON(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		return new MOMAAHMJFJN(1)
		{
			_003C_003E4__this = this,
			image = FNKBAOIINEN,
			alpha = GODBHHOFBMJ
		};
	}

	public static EventTextUI FFOABBDFMNE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator GGNBCLABCIM(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	private IEnumerator AFGPGOEFAPG(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		return new MOMAAHMJFJN(1)
		{
			_003C_003E4__this = this,
			image = FNKBAOIINEN,
			alpha = GODBHHOFBMJ
		};
	}

	private IEnumerator PNBFMALMDMH(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	public static EventTextUI MIAOGLENOHL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI ILDNNNMOCOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator NKOGGDOHHHM(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	public static EventTextUI JHOHGMODKGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator BPCGEOPIEEC(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		return new MOMAAHMJFJN(1)
		{
			_003C_003E4__this = this,
			image = FNKBAOIINEN,
			alpha = GODBHHOFBMJ
		};
	}

	public static EventTextUI IMLMJAPMBJA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator IPELBDLCPKL(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	public static EventTextUI ENIICLMAPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator IMGNHHGFEFP(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	public static EventTextUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI BBDNJAKIBFN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator FKGELHIHBMB(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	public static EventTextUI FHPEHDDFOIB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI DIMABMEHNNI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator IFAANBACLJN(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	private IEnumerator AKJDIDJNMMA(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		return new MOMAAHMJFJN(1)
		{
			_003C_003E4__this = this,
			image = FNKBAOIINEN,
			alpha = GODBHHOFBMJ
		};
	}

	public static EventTextUI NMCJELBLKBB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI LAIEKOOCNPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI EIMDPBGBBIF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI LKJNAHIPOLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator EAOKHLMMDKG(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	public static EventTextUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator JMKIEBNEJOE(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		return new MOMAAHMJFJN(1)
		{
			_003C_003E4__this = this,
			image = FNKBAOIINEN,
			alpha = GODBHHOFBMJ
		};
	}

	public static EventTextUI JELOGNCPDAB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI OMCDJAOBFCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI JGNOJMLHPOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			base.OpenUI();
			((MonoBehaviour)this).StartCoroutine(KMALPFNPKMJ(imageBg, 0.8f));
			((MonoBehaviour)this).StartCoroutine(KMALPFNPKMJ(imageBg2, 1f));
		}
	}

	public static EventTextUI CJMILOMGFJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	protected override void Awake()
	{
		GJBBNHCMNJN[numInstance] = this;
		base.Awake();
	}

	public static EventTextUI MDFIDKHOPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator IBKMKIMIMIB(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	public static EventTextUI NALKHGMLALJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator BPOCKIBBLCC(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		return new MOMAAHMJFJN(1)
		{
			_003C_003E4__this = this,
			image = FNKBAOIINEN,
			alpha = GODBHHOFBMJ
		};
	}

	private IEnumerator OFIPCMPMEBM(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		return new MOMAAHMJFJN(1)
		{
			_003C_003E4__this = this,
			image = FNKBAOIINEN,
			alpha = GODBHHOFBMJ
		};
	}

	public static EventTextUI JOAAFGBPJOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI MGLNAMHAIDG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public override void CloseUI()
	{
		base.CloseUI();
		((Component)eventText).gameObject.SetActive(false);
	}

	public static EventTextUI CGFJPHEFFLO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator HJBDFIPIGED(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	private IEnumerator DPGJAHEHJNP(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		return new MOMAAHMJFJN(1)
		{
			_003C_003E4__this = this,
			image = FNKBAOIINEN,
			alpha = GODBHHOFBMJ
		};
	}

	public static EventTextUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI PCEEOGGDBFB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator NGJOPDPJCFE(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	public static EventTextUI KDLDGFBDDCN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator DEPKEODADEP(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	private IEnumerator KCOOCOOPLLC(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		return new MOMAAHMJFJN(1)
		{
			_003C_003E4__this = this,
			image = FNKBAOIINEN,
			alpha = GODBHHOFBMJ
		};
	}

	private IEnumerator KMALPFNPKMJ(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	public static EventTextUI NIGDBMAOAEN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator MMHHNIMHHID(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		float lerpDuration = 1f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = Mathf.Lerp(0f, GODBHHOFBMJ, elapsedTime / lerpDuration);
			Color color = ((Graphic)FNKBAOIINEN).color;
			color.a = a;
			((Graphic)FNKBAOIINEN).color = color;
			yield return null;
		}
		((Component)eventText).gameObject.SetActive(true);
	}

	public static EventTextUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator MGAFDJMGJJD(Image FNKBAOIINEN, float GODBHHOFBMJ)
	{
		return new MOMAAHMJFJN(1)
		{
			_003C_003E4__this = this,
			image = FNKBAOIINEN,
			alpha = GODBHHOFBMJ
		};
	}

	public static EventTextUI NJOFJHCKGAL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI NDPAJCGHGOB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI NIDHCIHFOHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static EventTextUI IEPGACAGIPO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}
}
