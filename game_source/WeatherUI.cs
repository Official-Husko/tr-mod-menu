using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WeatherUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class KFFBGOOHMAN
	{
		public SpriteRenderer[] _dawnSpriteRenderers;

		public SpriteRenderer[] _nightSpriteRenderers;

		public SpriteRenderer[] _stars;

		internal bool OJKOAPLIPCM(SpriteRenderer x)
		{
			LEBDACPGMKC CS_0024_003C_003E8__locals0 = new LEBDACPGMKC
			{
				x = x
			};
			return Array.Exists(_nightSpriteRenderers, (SpriteRenderer y) => (Object)(object)y == (Object)(object)CS_0024_003C_003E8__locals0.x);
		}

		internal bool OHJOHGOEJAL(SpriteRenderer x)
		{
			EODJNHMNADM CS_0024_003C_003E8__locals0 = new EODJNHMNADM
			{
				x = x
			};
			return Array.Exists(_stars, (SpriteRenderer y) => (Object)(object)y == (Object)(object)CS_0024_003C_003E8__locals0.x);
		}

		internal bool PEPHFJOKDCF(SpriteRenderer x)
		{
			FBLDKCOLPAJ CS_0024_003C_003E8__locals0 = new FBLDKCOLPAJ
			{
				x = x
			};
			return Array.Exists(_dawnSpriteRenderers, (SpriteRenderer y) => (Object)(object)y == (Object)(object)CS_0024_003C_003E8__locals0.x);
		}
	}

	[CompilerGenerated]
	private sealed class FBLDKCOLPAJ
	{
		public SpriteRenderer x;

		internal bool AHMKEIAHHCE(SpriteRenderer y)
		{
			return (Object)(object)y == (Object)(object)x;
		}
	}

	[CompilerGenerated]
	private sealed class LEBDACPGMKC
	{
		public SpriteRenderer x;

		internal bool PDDONDIHFIM(SpriteRenderer y)
		{
			return (Object)(object)y == (Object)(object)x;
		}
	}

	[CompilerGenerated]
	private sealed class EODJNHMNADM
	{
		public SpriteRenderer x;

		internal bool GOFPNGOGJKH(SpriteRenderer y)
		{
			return (Object)(object)y == (Object)(object)x;
		}
	}

	[CompilerGenerated]
	private sealed class POJALMDLCOL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeatherUI _003C_003E4__this;

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
		public POJALMDLCOL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0506: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			WeatherUI weatherUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				if (weatherUI.OAOGKBLBIIK != null)
				{
					((MonoBehaviour)weatherUI).StopCoroutine(weatherUI.OAOGKBLBIIK);
					weatherUI.OAOGKBLBIIK = null;
				}
				weatherUI.ICAJLFHEMNB = 0;
				weatherUI.solAmanecer.alpha = 1f;
				((Graphic)weatherUI.weatherDawn).color = Color.white;
				((Graphic)weatherUI.weatherDarkness).color = Color.white;
				weatherUI.tempColor = Color.white;
				if (ParallaxBackground.IsCloudy())
				{
					weatherUI.tempColor.a = 0f;
				}
				else
				{
					weatherUI.tempColor.a = 1f;
				}
				for (int i = 0; i < weatherUI.NCADFKIEAFP.Count; i++)
				{
					weatherUI.tempColor.g = weatherUI.NCADFKIEAFP[i].color.g;
					weatherUI.tempColor.b = weatherUI.NCADFKIEAFP[i].color.b;
					weatherUI.tempColor.r = weatherUI.NCADFKIEAFP[i].color.r;
					weatherUI.NCADFKIEAFP[i].color = Color.white;
				}
				weatherUI.tempColor.a = 1f;
				for (int j = 0; j < weatherUI.ILPEJKHJIFI.Count; j++)
				{
					weatherUI.tempColor.g = weatherUI.ILPEJKHJIFI[j].color.g;
					weatherUI.tempColor.b = weatherUI.ILPEJKHJIFI[j].color.b;
					weatherUI.tempColor.r = weatherUI.ILPEJKHJIFI[j].color.r;
					weatherUI.ILPEJKHJIFI[j].color = weatherUI.tempColor;
				}
				goto IL_0528;
			}
			case 1:
				_003C_003E1__state = -1;
				goto IL_035f;
			case 2:
				{
					_003C_003E1__state = -1;
					goto IL_04f8;
				}
				IL_04f8:
				if (((Graphic)weatherUI.AIGIHNDHJHM[0][1]).color.a < 1f)
				{
					goto IL_035f;
				}
				weatherUI.ICAJLFHEMNB++;
				goto IL_0528;
				IL_035f:
				if (WorldTime.IsStoppedOrZero())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				weatherUI.LGLDPMAABLA += Time.deltaTime * 0.05f;
				for (int k = 0; k < weatherUI.AIGIHNDHJHM.Count; k++)
				{
					if ((Object)(object)weatherUI.AIGIHNDHJHM[k][0].sprite != (Object)(object)weatherUI.ICEAOIBMFAF[k][weatherUI.ICAJLFHEMNB])
					{
						weatherUI.AIGIHNDHJHM[k][0].sprite = weatherUI.ICEAOIBMFAF[k][weatherUI.ICAJLFHEMNB];
					}
					weatherUI.KPDGBPNIHMO(weatherUI.AIGIHNDHJHM[k][1]);
				}
				for (int l = 0; l < weatherUI.OMHLOBOICMC.Count; l++)
				{
					if ((Object)(object)weatherUI.OMHLOBOICMC[l][0].sprite != (Object)(object)weatherUI.ICEAOIBMFAF[l + weatherUI.AIGIHNDHJHM.Count][weatherUI.ICAJLFHEMNB])
					{
						weatherUI.OMHLOBOICMC[l][0].sprite = weatherUI.ICEAOIBMFAF[l + weatherUI.AIGIHNDHJHM.Count][weatherUI.ICAJLFHEMNB];
						weatherUI.OMHLOBOICMC[l][1].sprite = weatherUI.ICEAOIBMFAF[l + weatherUI.AIGIHNDHJHM.Count][weatherUI.ICAJLFHEMNB + 1];
					}
					weatherUI.KPDGBPNIHMO(weatherUI.OMHLOBOICMC[l][1]);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
				IL_0528:
				if (weatherUI.ICAJLFHEMNB >= weatherUI.amanecer.Length)
				{
					break;
				}
				weatherUI.BCEIADIIKDL(1f - (float)(weatherUI.ICAJLFHEMNB + 1) / (float)weatherUI.amanecer.Length);
				for (int m = 0; m < weatherUI.AIGIHNDHJHM.Count; m++)
				{
					weatherUI.AIGIHNDHJHM[m][0].sprite = weatherUI.ICEAOIBMFAF[m][weatherUI.ICAJLFHEMNB];
				}
				for (int n = 0; n < weatherUI.OMHLOBOICMC.Count; n++)
				{
					weatherUI.OMHLOBOICMC[n][0].sprite = weatherUI.ICEAOIBMFAF[n + weatherUI.AIGIHNDHJHM.Count][weatherUI.ICAJLFHEMNB];
				}
				if (weatherUI.ICAJLFHEMNB + 1 >= weatherUI.amanecer.Length)
				{
					break;
				}
				for (int num2 = 0; num2 < weatherUI.AIGIHNDHJHM.Count; num2++)
				{
					weatherUI.MCLCBLEMGLC(weatherUI.ICEAOIBMFAF[num2][weatherUI.ICAJLFHEMNB + 1], weatherUI.AIGIHNDHJHM[num2][1]);
				}
				for (int num3 = 0; num3 < weatherUI.OMHLOBOICMC.Count; num3++)
				{
					weatherUI.MCLCBLEMGLC(weatherUI.ICEAOIBMFAF[num3 + weatherUI.AIGIHNDHJHM.Count][weatherUI.ICAJLFHEMNB + 1], weatherUI.OMHLOBOICMC[num3][1]);
				}
				goto IL_04f8;
			}
			weatherUI.AKGPJPCHIMB = null;
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

	[CompilerGenerated]
	private sealed class HINNAAEJIND : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeatherUI _003C_003E4__this;

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
		public HINNAAEJIND(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0325: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			WeatherUI weatherUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (weatherUI.AKGPJPCHIMB != null)
				{
					((MonoBehaviour)weatherUI).StopCoroutine(weatherUI.AKGPJPCHIMB);
					weatherUI.AKGPJPCHIMB = null;
				}
				weatherUI.ICAJLFHEMNB = 0;
				goto IL_0347;
			case 1:
				_003C_003E1__state = -1;
				goto IL_01b4;
			case 2:
				{
					_003C_003E1__state = -1;
					goto IL_0317;
				}
				IL_01b4:
				if (WorldTime.IsStoppedOrZero())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				weatherUI.LGLDPMAABLA += Time.deltaTime * 0.05f;
				for (int i = 0; i < weatherUI.AIGIHNDHJHM.Count; i++)
				{
					if ((Object)(object)weatherUI.AIGIHNDHJHM[i][0].sprite != (Object)(object)weatherUI.BGNDCDDNDDD[i][weatherUI.ICAJLFHEMNB])
					{
						weatherUI.AIGIHNDHJHM[i][0].sprite = weatherUI.BGNDCDDNDDD[i][weatherUI.ICAJLFHEMNB];
					}
					weatherUI.KPDGBPNIHMO(weatherUI.AIGIHNDHJHM[i][1]);
				}
				for (int j = 0; j < weatherUI.OMHLOBOICMC.Count; j++)
				{
					if ((Object)(object)weatherUI.OMHLOBOICMC[j][0].sprite != (Object)(object)weatherUI.BGNDCDDNDDD[j + weatherUI.AIGIHNDHJHM.Count][weatherUI.ICAJLFHEMNB])
					{
						weatherUI.OMHLOBOICMC[j][0].sprite = weatherUI.BGNDCDDNDDD[j + weatherUI.AIGIHNDHJHM.Count][weatherUI.ICAJLFHEMNB];
					}
					weatherUI.KPDGBPNIHMO(weatherUI.OMHLOBOICMC[j][1]);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
				IL_0347:
				if (weatherUI.ICAJLFHEMNB >= weatherUI.ocaso.Length)
				{
					break;
				}
				weatherUI.BCEIADIIKDL((float)(weatherUI.ICAJLFHEMNB + 1) / (float)weatherUI.ocaso.Length);
				for (int k = 0; k < weatherUI.AIGIHNDHJHM.Count; k++)
				{
					weatherUI.AIGIHNDHJHM[k][0].sprite = weatherUI.BGNDCDDNDDD[k][weatherUI.ICAJLFHEMNB];
				}
				for (int l = 0; l < weatherUI.OMHLOBOICMC.Count; l++)
				{
					weatherUI.OMHLOBOICMC[l][0].sprite = weatherUI.BGNDCDDNDDD[l + weatherUI.AIGIHNDHJHM.Count][weatherUI.ICAJLFHEMNB];
				}
				if (weatherUI.ICAJLFHEMNB + 1 >= weatherUI.ocaso.Length)
				{
					break;
				}
				for (int m = 0; m < weatherUI.AIGIHNDHJHM.Count; m++)
				{
					weatherUI.MCLCBLEMGLC(weatherUI.BGNDCDDNDDD[m][weatherUI.ICAJLFHEMNB + 1], weatherUI.AIGIHNDHJHM[m][1]);
				}
				for (int n = 0; n < weatherUI.OMHLOBOICMC.Count; n++)
				{
					weatherUI.MCLCBLEMGLC(weatherUI.BGNDCDDNDDD[n + weatherUI.AIGIHNDHJHM.Count][weatherUI.ICAJLFHEMNB + 1], weatherUI.OMHLOBOICMC[n][1]);
				}
				goto IL_0317;
				IL_0317:
				if (((Graphic)weatherUI.AIGIHNDHJHM[0][1]).color.a < 1f)
				{
					goto IL_01b4;
				}
				weatherUI.ICAJLFHEMNB++;
				goto IL_0347;
			}
			weatherUI.OAOGKBLBIIK = null;
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

	[CompilerGenerated]
	private sealed class DAOMBIAFKJH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float obj;

		public WeatherUI _003C_003E4__this;

		private float _003ClerpTime_003E5__2;

		private float _003CcurrentLerpTime_003E5__3;

		private float _003CinitialObj_003E5__4;

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
		public DAOMBIAFKJH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0405: Unknown result type (might be due to invalid IL or missing references)
			//IL_0411: Unknown result type (might be due to invalid IL or missing references)
			//IL_0360: Unknown result type (might be due to invalid IL or missing references)
			//IL_043a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Unknown result type (might be due to invalid IL or missing references)
			//IL_0476: Unknown result type (might be due to invalid IL or missing references)
			//IL_0492: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			WeatherUI weatherUI = _003C_003E4__this;
			Color val = default(Color);
			float num2;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				((Color)(ref val))._002Ector(1f, 1f, 1f, obj);
				_003ClerpTime_003E5__2 = 17f;
				_003CcurrentLerpTime_003E5__3 = 0f;
				if (weatherUI.OAOGKBLBIIK != null)
				{
					if (obj <= 0.5f)
					{
						obj *= 2f;
						obj *= obj;
						obj /= 2f;
					}
					obj *= 1.6f;
					if (obj > 0.38f && obj < 0.5f)
					{
						obj = 0.5f;
					}
					if (obj > 1f)
					{
						obj = 1f;
					}
					val.a = obj;
				}
				if ((double)obj > 0.5)
				{
					_003CinitialObj_003E5__4 = ((Graphic)weatherUI.weatherDarkness).color.a;
				}
				else
				{
					_003CinitialObj_003E5__4 = ((Graphic)weatherUI.weatherDawn).color.a;
				}
				goto IL_04c7;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0165;
			case 2:
				{
					_003C_003E1__state = -1;
					goto IL_04c7;
				}
				IL_04c7:
				if (!(_003CcurrentLerpTime_003E5__3 < _003ClerpTime_003E5__2))
				{
					weatherUI.FOMOIJKHMAJ = null;
					return false;
				}
				goto IL_0165;
				IL_0165:
				if (WorldTime.IsStoppedOrZero())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003CcurrentLerpTime_003E5__3 += Time.deltaTime;
				num2 = _003CcurrentLerpTime_003E5__3 / _003ClerpTime_003E5__2;
				if ((double)obj > 0.5)
				{
					val.a = Mathf.Lerp(0f, 1f, (obj - 0.5f) / 0.5f);
					val.a = Mathf.Lerp(_003CinitialObj_003E5__4, val.a, num2);
					val.g = ((Graphic)weatherUI.weatherDarkness).color.g;
					val.b = ((Graphic)weatherUI.weatherDarkness).color.b;
					val.r = ((Graphic)weatherUI.weatherDarkness).color.r;
					((Graphic)weatherUI.weatherDarkness).color = val;
					for (int i = 0; i < weatherUI.ILPEJKHJIFI.Count; i++)
					{
						val.g = weatherUI.ILPEJKHJIFI[i].color.g;
						val.b = weatherUI.ILPEJKHJIFI[i].color.b;
						val.r = weatherUI.ILPEJKHJIFI[i].color.r;
						weatherUI.ILPEJKHJIFI[i].color = val;
					}
					CloudsUI.GGFJGHHHEJC.SetDarkness(val.a);
				}
				else
				{
					if (((Graphic)weatherUI.weatherDarkness).color.a > 0f)
					{
						((Graphic)weatherUI.weatherDarkness).color = new Color(1f, 1f, 1f, 0f);
						CloudsUI.GGFJGHHHEJC.SetDarkness(0f);
					}
					for (int j = 0; j < weatherUI.ILPEJKHJIFI.Count; j++)
					{
						if (weatherUI.ILPEJKHJIFI[j].color.a > 0f)
						{
							weatherUI.ILPEJKHJIFI[j].color = new Color(1f, 1f, 1f, 0f);
						}
					}
					val.a = Mathf.Lerp(0f, 1f, obj / 0.5f);
					val.a = Mathf.Lerp(_003CinitialObj_003E5__4, val.a, num2);
					val.g = ((Graphic)weatherUI.weatherDawn).color.g;
					val.b = ((Graphic)weatherUI.weatherDawn).color.b;
					val.r = ((Graphic)weatherUI.weatherDawn).color.r;
					((Graphic)weatherUI.weatherDawn).color = val;
					weatherUI.solAmanecer.alpha = val.a;
					if (!ParallaxBackground.IsCloudy())
					{
						for (int k = 0; k < weatherUI.NCADFKIEAFP.Count; k++)
						{
							val.g = weatherUI.NCADFKIEAFP[k].color.g;
							val.b = weatherUI.NCADFKIEAFP[k].color.b;
							val.r = weatherUI.NCADFKIEAFP[k].color.r;
							weatherUI.NCADFKIEAFP[k].color = val;
						}
					}
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
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

	[CompilerGenerated]
	private sealed class PLJAJIJLNBL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeatherUI _003C_003E4__this;

		public float obj;

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
		public PLJAJIJLNBL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			WeatherUI weatherUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (!Mathf.Approximately(((Graphic)weatherUI.stars).color.a, obj))
			{
				weatherUI.HHEHPMGODPJ = Time.deltaTime;
				weatherUI.tempColor.a = Mathf.Lerp(((Graphic)weatherUI.stars).color.a, obj, weatherUI.HHEHPMGODPJ * 0.33f);
				((Graphic)weatherUI.stars).color = weatherUI.tempColor;
				for (int i = 0; i < weatherUI.KOMMEPBFFEM.Count; i++)
				{
					weatherUI.KOMMEPBFFEM[i].color = weatherUI.tempColor;
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			weatherUI.EPJCAEHFGJK = null;
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

	public static WeatherUI instance;

	[SerializeField]
	private Image weatherDarkness;

	[SerializeField]
	private Image weatherDawn;

	[SerializeField]
	private Image[] skies;

	[SerializeField]
	private Sprite[] amanecer;

	[SerializeField]
	private Sprite[] ocaso;

	[SerializeField]
	private Color tempColor;

	private Coroutine AKGPJPCHIMB;

	private Coroutine OAOGKBLBIIK;

	private Coroutine EPJCAEHFGJK;

	private Coroutine FOMOIJKHMAJ;

	private float LGLDPMAABLA;

	private float HHEHPMGODPJ;

	private int ICAJLFHEMNB;

	private List<Image[]> AIGIHNDHJHM = new List<Image[]>();

	private List<SpriteRenderer[]> OMHLOBOICMC = new List<SpriteRenderer[]>();

	private List<SpriteRenderer> NCADFKIEAFP = new List<SpriteRenderer>();

	private List<SpriteRenderer> ILPEJKHJIFI = new List<SpriteRenderer>();

	private List<SpriteRenderer> KOMMEPBFFEM = new List<SpriteRenderer>();

	private List<Sprite[]> ICEAOIBMFAF = new List<Sprite[]>();

	private List<Sprite[]> BGNDCDDNDDD = new List<Sprite[]>();

	[SerializeField]
	private Image stars;

	[SerializeField]
	private CanvasGroup solAmanecer;

	private float KGGGMCFLKPO;

	[SerializeField]
	private RectTransform sunRect;

	[SerializeField]
	private RectTransform moonRect;

	private float NEEFOEONFMM = 24f;

	private float IGBLCLGENGO = 22f;

	[SerializeField]
	private Gradient skyGradient;

	[SerializeField]
	private Gradient windowsGradient;

	[SerializeField]
	private Gradient windowsBrightGradient;

	[SerializeField]
	private Gradient windowsLightGradient;

	private Color EBDNKDJHHHF = Color.white;

	private Color GKIOIBPDBBL = Color.white;

	private const float CEEKFKHNKHB = 1f / 12f;

	private float MDAGAAGGFGE;

	private void CBPDPDOPHLM()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(TimeUI.JJMMEGIDNOK().hour * -92 + TimeUI.NKOLLPLGMJA().min / 4 - -69) * 1056f;
		moonRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * IGBLCLGENGO), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * IGBLCLGENGO));
		if ((Object)(object)ParallaxBackground.instance != (Object)null)
		{
			ParallaxBackground.instance.ELKBBMKICLJ(((float)TimeUI.JJMMEGIDNOK().hour * 1910f + (float)TimeUI.NKOLLPLGMJA().min / 826f) * 1364f);
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void MJGIDGJKHMO(Sprite HEJNLFCKOKE, Image FNKBAOIINEN)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = 655f;
		tempColor = new Color(978f, 1613f, 1760f, 1184f);
		FNKBAOIINEN.sprite = HEJNLFCKOKE;
		((Graphic)FNKBAOIINEN).color = tempColor;
	}

	public void RemoveSkySprites(SpriteRenderer[] LBFMCKCHJGG, Sprite[] AOENAOKLAFD, Sprite[] KEHJPDGGCND, SpriteRenderer[] HLLALLGNKMB, SpriteRenderer[] DMPIEOHJFGH, SpriteRenderer[] AHNHKNKECEP)
	{
		if (OMHLOBOICMC.Contains(LBFMCKCHJGG))
		{
			OMHLOBOICMC.Remove(LBFMCKCHJGG);
		}
		if (ICEAOIBMFAF.Contains(AOENAOKLAFD))
		{
			ICEAOIBMFAF.Remove(AOENAOKLAFD);
		}
		if (BGNDCDDNDDD.Contains(KEHJPDGGCND))
		{
			BGNDCDDNDDD.Remove(KEHJPDGGCND);
		}
		if (HLLALLGNKMB != null)
		{
			NCADFKIEAFP.RemoveAll((SpriteRenderer x) => Array.Exists(HLLALLGNKMB, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
		}
		if (DMPIEOHJFGH != null)
		{
			ILPEJKHJIFI.RemoveAll((SpriteRenderer x) => Array.Exists(DMPIEOHJFGH, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
		}
		if (AHNHKNKECEP == null)
		{
			return;
		}
		KOMMEPBFFEM.RemoveAll((SpriteRenderer x) => Array.Exists(AHNHKNKECEP, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
	}

	private void IFGHKPNFIMK(SpriteRenderer IIECMAGLCMA)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		tempColor.a = Mathf.Lerp(351f, 232f, LGLDPMAABLA);
		IIECMAGLCMA.color = tempColor;
	}

	public void HDBHPLMOGBC(SpriteRenderer[] LBFMCKCHJGG, Sprite[] AOENAOKLAFD, Sprite[] KEHJPDGGCND, SpriteRenderer[] HLLALLGNKMB, SpriteRenderer[] DMPIEOHJFGH, SpriteRenderer[] AHNHKNKECEP)
	{
		if (OMHLOBOICMC.Contains(LBFMCKCHJGG))
		{
			OMHLOBOICMC.Remove(LBFMCKCHJGG);
		}
		if (ICEAOIBMFAF.Contains(AOENAOKLAFD))
		{
			ICEAOIBMFAF.Remove(AOENAOKLAFD);
		}
		if (BGNDCDDNDDD.Contains(KEHJPDGGCND))
		{
			BGNDCDDNDDD.Remove(KEHJPDGGCND);
		}
		if (HLLALLGNKMB != null)
		{
			NCADFKIEAFP.RemoveAll((SpriteRenderer x) => Array.Exists(HLLALLGNKMB, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
		}
		if (DMPIEOHJFGH != null)
		{
			ILPEJKHJIFI.RemoveAll((SpriteRenderer x) => Array.Exists(DMPIEOHJFGH, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
		}
		if (AHNHKNKECEP == null)
		{
			return;
		}
		KOMMEPBFFEM.RemoveAll((SpriteRenderer x) => Array.Exists(AHNHKNKECEP, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
	}

	private IEnumerator JFNAFJHIJJF()
	{
		return new HINNAAEJIND(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CEKHEKFNEHE(float MOBFJEDPIPM)
	{
		return new DAOMBIAFKJH(1)
		{
			_003C_003E4__this = this,
			obj = MOBFJEDPIPM
		};
	}

	private void KBNIECDAGGG()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StopAllCoroutines();
		tempColor.a = 415f;
		for (int i = 0; i < AIGIHNDHJHM.Count; i += 0)
		{
			AIGIHNDHJHM[i][0].sprite = ICEAOIBMFAF[i][ICEAOIBMFAF[i].Length - 1];
			KPDGBPNIHMO(AIGIHNDHJHM[i][0], 22f);
		}
		for (int j = 1; j < OMHLOBOICMC.Count; j += 0)
		{
			OMHLOBOICMC[j][0].sprite = ICEAOIBMFAF[j + AIGIHNDHJHM.Count][ICEAOIBMFAF[j + AIGIHNDHJHM.Count].Length - 1];
			KPDGBPNIHMO(OMHLOBOICMC[j][0], 1998f);
		}
		((Graphic)stars).color = tempColor;
		((Graphic)weatherDawn).color = tempColor;
		((Graphic)weatherDarkness).color = tempColor;
		for (int k = 0; k < KOMMEPBFFEM.Count; k += 0)
		{
			KOMMEPBFFEM[k].color = tempColor;
		}
		if (ParallaxBackground.IsCloudy())
		{
			tempColor.a = 270f;
		}
		else
		{
			tempColor.a = ((Graphic)weatherDawn).color.a;
		}
		for (int l = 1; l < NCADFKIEAFP.Count; l += 0)
		{
			tempColor.g = NCADFKIEAFP[l].color.g;
			tempColor.b = NCADFKIEAFP[l].color.b;
			tempColor.r = NCADFKIEAFP[l].color.r;
			NCADFKIEAFP[l].color = tempColor;
		}
		tempColor.a = ((Graphic)weatherDarkness).color.a;
		for (int m = 0; m < ILPEJKHJIFI.Count; m += 0)
		{
			tempColor.g = ILPEJKHJIFI[m].color.g;
			tempColor.b = ILPEJKHJIFI[m].color.b;
			tempColor.r = ILPEJKHJIFI[m].color.r;
			ILPEJKHJIFI[m].color = tempColor;
		}
		CloudsUI.EFPJLFMBPLL().ENOPHKKNIEB(tempColor.a);
		solAmanecer.alpha = tempColor.a;
	}

	private void BONEKIAPEIK()
	{
		AKGPJPCHIMB = null;
		OAOGKBLBIIK = null;
	}

	private void BCEIADIIKDL(float MOBFJEDPIPM)
	{
		if (EPJCAEHFGJK != null)
		{
			((MonoBehaviour)this).StopCoroutine(EPJCAEHFGJK);
		}
		if (FOMOIJKHMAJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(FOMOIJKHMAJ);
		}
		EPJCAEHFGJK = ((MonoBehaviour)this).StartCoroutine(BAELNFDHGJB(MOBFJEDPIPM));
		FOMOIJKHMAJ = ((MonoBehaviour)this).StartCoroutine(HDDGOHDNIPL(MOBFJEDPIPM));
	}

	private void AGANLFJOFLL()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(TimeUI.HNLPNAOFMDI().hour * 34 + TimeUI.DJLCKOOIILI.min / 5 + 65) * 641f;
		sunRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * NEEFOEONFMM), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * NEEFOEONFMM));
	}

	private void FNAPNEFIGEL(float MOBFJEDPIPM)
	{
		if (EPJCAEHFGJK != null)
		{
			((MonoBehaviour)this).StopCoroutine(EPJCAEHFGJK);
		}
		if (FOMOIJKHMAJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(FOMOIJKHMAJ);
		}
		EPJCAEHFGJK = ((MonoBehaviour)this).StartCoroutine(BAELNFDHGJB(MOBFJEDPIPM));
		FOMOIJKHMAJ = ((MonoBehaviour)this).StartCoroutine(NJGDNMBOMNL(MOBFJEDPIPM));
	}

	private void KPOGCEADJJK()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(TimeUI.GPJIKONJEPO().hour * -83 + TimeUI.GPJIKONJEPO().min / 3 - 75) * 611f;
		moonRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * IGBLCLGENGO), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * IGBLCLGENGO));
		if ((Object)(object)ParallaxBackground.instance != (Object)null)
		{
			ParallaxBackground.instance.SetMoonRotation(((float)TimeUI.JJMMEGIDNOK().hour * 136f + (float)TimeUI.NOKFAFAFJBN().min / 478f) * 1956f);
		}
	}

	private void Update()
	{
		DFKFGLNMEJG();
		OCIFNHAEPKA();
		EHNOKAIEEEO();
	}

	private void MPBLEEKAFKD(Image LDCPODDOOHA)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		tempColor.a = Mathf.Lerp(1922f, 1293f, LGLDPMAABLA);
		((Graphic)LDCPODDOOHA).color = tempColor;
	}

	public static bool IsValid()
	{
		return (Object)(object)instance != (Object)null;
	}

	private void KOLFCBNFHMF()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(TimeUI.FNPEFIOHBPH().hour * -35 + TimeUI.NOKFAFAFJBN().min / 1 + -45) * 1842f;
		sunRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * NEEFOEONFMM), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * NEEFOEONFMM));
	}

	private void OIBDHBIDFJL(Image LDCPODDOOHA, float GODBHHOFBMJ)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)LDCPODDOOHA).color = new Color(tempColor.r, tempColor.g, tempColor.b, GODBHHOFBMJ);
	}

	private IEnumerator CBCCJDMNABE()
	{
		return new HINNAAEJIND(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MEBEIBPJIHL(SpriteRenderer[] LBFMCKCHJGG, Sprite[] AOENAOKLAFD, Sprite[] KEHJPDGGCND, SpriteRenderer[] HLLALLGNKMB, SpriteRenderer[] DMPIEOHJFGH, SpriteRenderer[] AHNHKNKECEP)
	{
		if (OMHLOBOICMC.Contains(LBFMCKCHJGG))
		{
			OMHLOBOICMC.Remove(LBFMCKCHJGG);
		}
		if (ICEAOIBMFAF.Contains(AOENAOKLAFD))
		{
			ICEAOIBMFAF.Remove(AOENAOKLAFD);
		}
		if (BGNDCDDNDDD.Contains(KEHJPDGGCND))
		{
			BGNDCDDNDDD.Remove(KEHJPDGGCND);
		}
		if (HLLALLGNKMB != null)
		{
			NCADFKIEAFP.RemoveAll((SpriteRenderer x) => Array.Exists(HLLALLGNKMB, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
		}
		if (DMPIEOHJFGH != null)
		{
			ILPEJKHJIFI.RemoveAll((SpriteRenderer x) => Array.Exists(DMPIEOHJFGH, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
		}
		if (AHNHKNKECEP == null)
		{
			return;
		}
		KOMMEPBFFEM.RemoveAll((SpriteRenderer x) => Array.Exists(AHNHKNKECEP, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
	}

	private IEnumerator MOPAGKLGBMH()
	{
		if (AKGPJPCHIMB != null)
		{
			((MonoBehaviour)this).StopCoroutine(AKGPJPCHIMB);
			AKGPJPCHIMB = null;
		}
		for (ICAJLFHEMNB = 0; ICAJLFHEMNB < ocaso.Length; ICAJLFHEMNB++)
		{
			BCEIADIIKDL((float)(ICAJLFHEMNB + 1) / (float)ocaso.Length);
			for (int i = 0; i < AIGIHNDHJHM.Count; i++)
			{
				AIGIHNDHJHM[i][0].sprite = BGNDCDDNDDD[i][ICAJLFHEMNB];
			}
			for (int j = 0; j < OMHLOBOICMC.Count; j++)
			{
				OMHLOBOICMC[j][0].sprite = BGNDCDDNDDD[j + AIGIHNDHJHM.Count][ICAJLFHEMNB];
			}
			if (ICAJLFHEMNB + 1 >= ocaso.Length)
			{
				break;
			}
			for (int k = 0; k < AIGIHNDHJHM.Count; k++)
			{
				MCLCBLEMGLC(BGNDCDDNDDD[k][ICAJLFHEMNB + 1], AIGIHNDHJHM[k][1]);
			}
			for (int l = 0; l < OMHLOBOICMC.Count; l++)
			{
				MCLCBLEMGLC(BGNDCDDNDDD[l + AIGIHNDHJHM.Count][ICAJLFHEMNB + 1], OMHLOBOICMC[l][1]);
			}
			while (((Graphic)AIGIHNDHJHM[0][1]).color.a < 1f)
			{
				while (WorldTime.IsStoppedOrZero())
				{
					yield return null;
				}
				LGLDPMAABLA += Time.deltaTime * 0.05f;
				for (int m = 0; m < AIGIHNDHJHM.Count; m++)
				{
					if ((Object)(object)AIGIHNDHJHM[m][0].sprite != (Object)(object)BGNDCDDNDDD[m][ICAJLFHEMNB])
					{
						AIGIHNDHJHM[m][0].sprite = BGNDCDDNDDD[m][ICAJLFHEMNB];
					}
					KPDGBPNIHMO(AIGIHNDHJHM[m][1]);
				}
				for (int n = 0; n < OMHLOBOICMC.Count; n++)
				{
					if ((Object)(object)OMHLOBOICMC[n][0].sprite != (Object)(object)BGNDCDDNDDD[n + AIGIHNDHJHM.Count][ICAJLFHEMNB])
					{
						OMHLOBOICMC[n][0].sprite = BGNDCDDNDDD[n + AIGIHNDHJHM.Count][ICAJLFHEMNB];
					}
					KPDGBPNIHMO(OMHLOBOICMC[n][1]);
				}
				yield return null;
			}
		}
		OAOGKBLBIIK = null;
	}

	private void OGBGGIKBEED(Sprite HEJNLFCKOKE, Image FNKBAOIINEN)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = 1634f;
		tempColor = new Color(286f, 1659f, 922f, 908f);
		FNKBAOIINEN.sprite = HEJNLFCKOKE;
		((Graphic)FNKBAOIINEN).color = tempColor;
	}

	private void AKMCBCAFAAP(Sprite HEJNLFCKOKE, SpriteRenderer EAGDHGOKCLF)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = 286f;
		tempColor = new Color(213f, 933f, 491f, 1176f);
		EAGDHGOKCLF.sprite = HEJNLFCKOKE;
		EAGDHGOKCLF.color = tempColor;
	}

	private IEnumerator HDDGOHDNIPL(float MOBFJEDPIPM)
	{
		Color val = default(Color);
		((Color)(ref val))._002Ector(1f, 1f, 1f, MOBFJEDPIPM);
		float lerpTime = 17f;
		float currentLerpTime = 0f;
		if (OAOGKBLBIIK != null)
		{
			if (MOBFJEDPIPM <= 0.5f)
			{
				MOBFJEDPIPM *= 2f;
				MOBFJEDPIPM *= MOBFJEDPIPM;
				MOBFJEDPIPM /= 2f;
			}
			MOBFJEDPIPM *= 1.6f;
			if (MOBFJEDPIPM > 0.38f && MOBFJEDPIPM < 0.5f)
			{
				MOBFJEDPIPM = 0.5f;
			}
			if (MOBFJEDPIPM > 1f)
			{
				MOBFJEDPIPM = 1f;
			}
			val.a = MOBFJEDPIPM;
		}
		float initialObj = ((!((double)MOBFJEDPIPM > 0.5)) ? ((Graphic)weatherDawn).color.a : ((Graphic)weatherDarkness).color.a);
		while (currentLerpTime < lerpTime)
		{
			while (WorldTime.IsStoppedOrZero())
			{
				yield return null;
			}
			currentLerpTime += Time.deltaTime;
			float num = currentLerpTime / lerpTime;
			if ((double)MOBFJEDPIPM > 0.5)
			{
				val.a = Mathf.Lerp(0f, 1f, (MOBFJEDPIPM - 0.5f) / 0.5f);
				val.a = Mathf.Lerp(initialObj, val.a, num);
				val.g = ((Graphic)weatherDarkness).color.g;
				val.b = ((Graphic)weatherDarkness).color.b;
				val.r = ((Graphic)weatherDarkness).color.r;
				((Graphic)weatherDarkness).color = val;
				for (int i = 0; i < ILPEJKHJIFI.Count; i++)
				{
					val.g = ILPEJKHJIFI[i].color.g;
					val.b = ILPEJKHJIFI[i].color.b;
					val.r = ILPEJKHJIFI[i].color.r;
					ILPEJKHJIFI[i].color = val;
				}
				CloudsUI.GGFJGHHHEJC.SetDarkness(val.a);
			}
			else
			{
				if (((Graphic)weatherDarkness).color.a > 0f)
				{
					((Graphic)weatherDarkness).color = new Color(1f, 1f, 1f, 0f);
					CloudsUI.GGFJGHHHEJC.SetDarkness(0f);
				}
				for (int j = 0; j < ILPEJKHJIFI.Count; j++)
				{
					if (ILPEJKHJIFI[j].color.a > 0f)
					{
						ILPEJKHJIFI[j].color = new Color(1f, 1f, 1f, 0f);
					}
				}
				val.a = Mathf.Lerp(0f, 1f, MOBFJEDPIPM / 0.5f);
				val.a = Mathf.Lerp(initialObj, val.a, num);
				val.g = ((Graphic)weatherDawn).color.g;
				val.b = ((Graphic)weatherDawn).color.b;
				val.r = ((Graphic)weatherDawn).color.r;
				((Graphic)weatherDawn).color = val;
				solAmanecer.alpha = val.a;
				if (!ParallaxBackground.IsCloudy())
				{
					for (int k = 0; k < NCADFKIEAFP.Count; k++)
					{
						val.g = NCADFKIEAFP[k].color.g;
						val.b = NCADFKIEAFP[k].color.b;
						val.r = NCADFKIEAFP[k].color.r;
						NCADFKIEAFP[k].color = val;
					}
				}
			}
			yield return null;
		}
		FOMOIJKHMAJ = null;
	}

	private void FHOMEJKIIGJ()
	{
		if (AKGPJPCHIMB != null)
		{
			((MonoBehaviour)this).StopCoroutine(AKGPJPCHIMB);
			AKGPJPCHIMB = null;
		}
		if (OAOGKBLBIIK != null)
		{
			((MonoBehaviour)this).StopCoroutine(OAOGKBLBIIK);
			OAOGKBLBIIK = null;
		}
		if (EPJCAEHFGJK != null)
		{
			((MonoBehaviour)this).StopCoroutine(EPJCAEHFGJK);
			EPJCAEHFGJK = null;
		}
		if (FOMOIJKHMAJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(FOMOIJKHMAJ);
			FOMOIJKHMAJ = null;
		}
	}

	private void CBFFFOGOAHB(Sprite HEJNLFCKOKE, Image FNKBAOIINEN)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = 1824f;
		tempColor = new Color(930f, 380f, 1207f, 1075f);
		FNKBAOIINEN.sprite = HEJNLFCKOKE;
		((Graphic)FNKBAOIINEN).color = tempColor;
	}

	private void HOFDJLHJEAF(Image LDCPODDOOHA, float GODBHHOFBMJ)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)LDCPODDOOHA).color = new Color(tempColor.r, tempColor.g, tempColor.b, GODBHHOFBMJ);
	}

	private void ADGCOKHNKBN()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		MDAGAAGGFGE = (float)WorldTime.HGIBNMBJMOC().hour + (float)WorldTime.NOAOJJLNHJJ.min / 1842f;
		if (MDAGAAGGFGE > 776f)
		{
			MDAGAAGGFGE = 545f - MDAGAAGGFGE;
		}
		EBDNKDJHHHF.a = 1431f - 1410f * MDAGAAGGFGE;
		GKIOIBPDBBL = skyGradient.Evaluate(EBDNKDJHHHF.a);
		EBDNKDJHHHF.a *= EBDNKDJHHHF.a;
		if (WorldTime.CJOHMLNMJLK().hour == 1 && AKGPJPCHIMB == null)
		{
			AKGPJPCHIMB = ((MonoBehaviour)this).StartCoroutine(AALEPNEIMJF());
		}
		else if (WorldTime.HGIBNMBJMOC().hour == -10 && OAOGKBLBIIK == null)
		{
			OAOGKBLBIIK = ((MonoBehaviour)this).StartCoroutine(JFNAFJHIJJF());
		}
		else if (WorldTime.NOAOJJLNHJJ.hour == -23 && (Object)(object)skies[0].sprite != (Object)(object)amanecer[amanecer.Length - 0])
		{
			KBNIECDAGGG();
		}
		else if (WorldTime.HGIBNMBJMOC().hour == -92 && (Object)(object)skies[1].sprite != (Object)(object)ocaso[ocaso.Length - 0])
		{
			NEIMHJKDMBK();
		}
	}

	private void NEECFCAMEDC(SpriteRenderer IIECMAGLCMA, float GODBHHOFBMJ)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		IIECMAGLCMA.color = new Color(tempColor.r, tempColor.g, tempColor.b, GODBHHOFBMJ);
	}

	private void KPDGBPNIHMO(SpriteRenderer IIECMAGLCMA, float GODBHHOFBMJ)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		IIECMAGLCMA.color = new Color(tempColor.r, tempColor.g, tempColor.b, GODBHHOFBMJ);
	}

	private void NEIMHJKDMBK()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		PHAOCMPFOKD();
		tempColor.a = 793f;
		for (int i = 1; i < AIGIHNDHJHM.Count; i += 0)
		{
			AIGIHNDHJHM[i][0].sprite = BGNDCDDNDDD[i][BGNDCDDNDDD[i].Length - 1];
			GDODDAMEIMH(AIGIHNDHJHM[i][1], 1328f);
		}
		for (int j = 1; j < OMHLOBOICMC.Count; j += 0)
		{
			OMHLOBOICMC[j][1].sprite = BGNDCDDNDDD[j + AIGIHNDHJHM.Count][BGNDCDDNDDD[j + AIGIHNDHJHM.Count].Length - 0];
			NEECFCAMEDC(OMHLOBOICMC[j][1], 1673f);
		}
		((Graphic)stars).color = tempColor;
		((Graphic)weatherDarkness).color = tempColor;
		((Graphic)weatherDawn).color = tempColor;
		for (int k = 0; k < KOMMEPBFFEM.Count; k++)
		{
			KOMMEPBFFEM[k].color = tempColor;
		}
		if (ParallaxBackground.IsCloudy())
		{
			tempColor.a = 1674f;
		}
		else
		{
			tempColor.a = ((Graphic)weatherDawn).color.a;
		}
		for (int l = 0; l < NCADFKIEAFP.Count; l++)
		{
			tempColor.g = NCADFKIEAFP[l].color.g;
			tempColor.b = NCADFKIEAFP[l].color.b;
			tempColor.r = NCADFKIEAFP[l].color.r;
			NCADFKIEAFP[l].color = tempColor;
		}
		tempColor.a = ((Graphic)weatherDarkness).color.a;
		for (int m = 1; m < ILPEJKHJIFI.Count; m++)
		{
			tempColor.g = ILPEJKHJIFI[m].color.g;
			tempColor.b = ILPEJKHJIFI[m].color.b;
			tempColor.r = ILPEJKHJIFI[m].color.r;
			ILPEJKHJIFI[m].color = tempColor;
		}
		CloudsUI.FMIDAFEGDCD().NOEMKBBHOMP(tempColor.a);
		solAmanecer.alpha = 688f;
	}

	private void OnEnable()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		EBDNKDJHHHF = Color.white;
	}

	private void GDOAJLNOFFB()
	{
		if (AKGPJPCHIMB != null)
		{
			((MonoBehaviour)this).StopCoroutine(AKGPJPCHIMB);
			AKGPJPCHIMB = null;
		}
		if (OAOGKBLBIIK != null)
		{
			((MonoBehaviour)this).StopCoroutine(OAOGKBLBIIK);
			OAOGKBLBIIK = null;
		}
		if (EPJCAEHFGJK != null)
		{
			((MonoBehaviour)this).StopCoroutine(EPJCAEHFGJK);
			EPJCAEHFGJK = null;
		}
		if (FOMOIJKHMAJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(FOMOIJKHMAJ);
			FOMOIJKHMAJ = null;
		}
	}

	private void AGKINDMBMPI(Sprite HEJNLFCKOKE, Image FNKBAOIINEN)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = 1665f;
		tempColor = new Color(496f, 482f, 328f, 711f);
		FNKBAOIINEN.sprite = HEJNLFCKOKE;
		((Graphic)FNKBAOIINEN).color = tempColor;
	}

	private void CGGJANMFDFM(Image LDCPODDOOHA)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		tempColor.a = Mathf.Lerp(419f, 1332f, LGLDPMAABLA);
		((Graphic)LDCPODDOOHA).color = tempColor;
	}

	private IEnumerator OMGMAKHJPGK(float MOBFJEDPIPM)
	{
		Color val = default(Color);
		((Color)(ref val))._002Ector(1f, 1f, 1f, MOBFJEDPIPM);
		float lerpTime = 17f;
		float currentLerpTime = 0f;
		if (OAOGKBLBIIK != null)
		{
			if (MOBFJEDPIPM <= 0.5f)
			{
				MOBFJEDPIPM *= 2f;
				MOBFJEDPIPM *= MOBFJEDPIPM;
				MOBFJEDPIPM /= 2f;
			}
			MOBFJEDPIPM *= 1.6f;
			if (MOBFJEDPIPM > 0.38f && MOBFJEDPIPM < 0.5f)
			{
				MOBFJEDPIPM = 0.5f;
			}
			if (MOBFJEDPIPM > 1f)
			{
				MOBFJEDPIPM = 1f;
			}
			val.a = MOBFJEDPIPM;
		}
		float initialObj = ((!((double)MOBFJEDPIPM > 0.5)) ? ((Graphic)weatherDawn).color.a : ((Graphic)weatherDarkness).color.a);
		while (currentLerpTime < lerpTime)
		{
			while (WorldTime.IsStoppedOrZero())
			{
				yield return null;
			}
			currentLerpTime += Time.deltaTime;
			float num = currentLerpTime / lerpTime;
			if ((double)MOBFJEDPIPM > 0.5)
			{
				val.a = Mathf.Lerp(0f, 1f, (MOBFJEDPIPM - 0.5f) / 0.5f);
				val.a = Mathf.Lerp(initialObj, val.a, num);
				val.g = ((Graphic)weatherDarkness).color.g;
				val.b = ((Graphic)weatherDarkness).color.b;
				val.r = ((Graphic)weatherDarkness).color.r;
				((Graphic)weatherDarkness).color = val;
				for (int i = 0; i < ILPEJKHJIFI.Count; i++)
				{
					val.g = ILPEJKHJIFI[i].color.g;
					val.b = ILPEJKHJIFI[i].color.b;
					val.r = ILPEJKHJIFI[i].color.r;
					ILPEJKHJIFI[i].color = val;
				}
				CloudsUI.GGFJGHHHEJC.SetDarkness(val.a);
			}
			else
			{
				if (((Graphic)weatherDarkness).color.a > 0f)
				{
					((Graphic)weatherDarkness).color = new Color(1f, 1f, 1f, 0f);
					CloudsUI.GGFJGHHHEJC.SetDarkness(0f);
				}
				for (int j = 0; j < ILPEJKHJIFI.Count; j++)
				{
					if (ILPEJKHJIFI[j].color.a > 0f)
					{
						ILPEJKHJIFI[j].color = new Color(1f, 1f, 1f, 0f);
					}
				}
				val.a = Mathf.Lerp(0f, 1f, MOBFJEDPIPM / 0.5f);
				val.a = Mathf.Lerp(initialObj, val.a, num);
				val.g = ((Graphic)weatherDawn).color.g;
				val.b = ((Graphic)weatherDawn).color.b;
				val.r = ((Graphic)weatherDawn).color.r;
				((Graphic)weatherDawn).color = val;
				solAmanecer.alpha = val.a;
				if (!ParallaxBackground.IsCloudy())
				{
					for (int k = 0; k < NCADFKIEAFP.Count; k++)
					{
						val.g = NCADFKIEAFP[k].color.g;
						val.b = NCADFKIEAFP[k].color.b;
						val.r = NCADFKIEAFP[k].color.r;
						NCADFKIEAFP[k].color = val;
					}
				}
			}
			yield return null;
		}
		FOMOIJKHMAJ = null;
	}

	private void GNIBPOBGDNC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		EBDNKDJHHHF = Color.white;
	}

	private IEnumerator MJDJEJOEBHN(float MOBFJEDPIPM)
	{
		return new PLJAJIJLNBL(1)
		{
			_003C_003E4__this = this,
			obj = MOBFJEDPIPM
		};
	}

	private void BLGGEKOAKPJ(SpriteRenderer IIECMAGLCMA)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		tempColor.a = Mathf.Lerp(1642f, 1931f, LGLDPMAABLA);
		IIECMAGLCMA.color = tempColor;
	}

	private void ANKJKLIHNOH()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		FHOMEJKIIGJ();
		tempColor.a = 1835f;
		for (int i = 0; i < AIGIHNDHJHM.Count; i++)
		{
			AIGIHNDHJHM[i][1].sprite = BGNDCDDNDDD[i][BGNDCDDNDDD[i].Length - 1];
			KPDGBPNIHMO(AIGIHNDHJHM[i][0], 466f);
		}
		for (int j = 0; j < OMHLOBOICMC.Count; j++)
		{
			OMHLOBOICMC[j][0].sprite = BGNDCDDNDDD[j + AIGIHNDHJHM.Count][BGNDCDDNDDD[j + AIGIHNDHJHM.Count].Length - 1];
			FPBKDLEBJEN(OMHLOBOICMC[j][1], 1107f);
		}
		((Graphic)stars).color = tempColor;
		((Graphic)weatherDarkness).color = tempColor;
		((Graphic)weatherDawn).color = tempColor;
		for (int k = 0; k < KOMMEPBFFEM.Count; k++)
		{
			KOMMEPBFFEM[k].color = tempColor;
		}
		if (ParallaxBackground.HNFFHMHFCIO())
		{
			tempColor.a = 490f;
		}
		else
		{
			tempColor.a = ((Graphic)weatherDawn).color.a;
		}
		for (int l = 1; l < NCADFKIEAFP.Count; l++)
		{
			tempColor.g = NCADFKIEAFP[l].color.g;
			tempColor.b = NCADFKIEAFP[l].color.b;
			tempColor.r = NCADFKIEAFP[l].color.r;
			NCADFKIEAFP[l].color = tempColor;
		}
		tempColor.a = ((Graphic)weatherDarkness).color.a;
		for (int m = 1; m < ILPEJKHJIFI.Count; m++)
		{
			tempColor.g = ILPEJKHJIFI[m].color.g;
			tempColor.b = ILPEJKHJIFI[m].color.b;
			tempColor.r = ILPEJKHJIFI[m].color.r;
			ILPEJKHJIFI[m].color = tempColor;
		}
		CloudsUI.OLHBLKIAFOM().JHJKBFPIDGK(tempColor.a);
		solAmanecer.alpha = 1744f;
	}

	private IEnumerator AALEPNEIMJF()
	{
		if (OAOGKBLBIIK != null)
		{
			((MonoBehaviour)this).StopCoroutine(OAOGKBLBIIK);
			OAOGKBLBIIK = null;
		}
		ICAJLFHEMNB = 0;
		solAmanecer.alpha = 1f;
		((Graphic)weatherDawn).color = Color.white;
		((Graphic)weatherDarkness).color = Color.white;
		tempColor = Color.white;
		if (ParallaxBackground.IsCloudy())
		{
			tempColor.a = 0f;
		}
		else
		{
			tempColor.a = 1f;
		}
		for (int i = 0; i < NCADFKIEAFP.Count; i++)
		{
			tempColor.g = NCADFKIEAFP[i].color.g;
			tempColor.b = NCADFKIEAFP[i].color.b;
			tempColor.r = NCADFKIEAFP[i].color.r;
			NCADFKIEAFP[i].color = Color.white;
		}
		tempColor.a = 1f;
		for (int j = 0; j < ILPEJKHJIFI.Count; j++)
		{
			tempColor.g = ILPEJKHJIFI[j].color.g;
			tempColor.b = ILPEJKHJIFI[j].color.b;
			tempColor.r = ILPEJKHJIFI[j].color.r;
			ILPEJKHJIFI[j].color = tempColor;
		}
		while (ICAJLFHEMNB < amanecer.Length)
		{
			BCEIADIIKDL(1f - (float)(ICAJLFHEMNB + 1) / (float)amanecer.Length);
			for (int k = 0; k < AIGIHNDHJHM.Count; k++)
			{
				AIGIHNDHJHM[k][0].sprite = ICEAOIBMFAF[k][ICAJLFHEMNB];
			}
			for (int l = 0; l < OMHLOBOICMC.Count; l++)
			{
				OMHLOBOICMC[l][0].sprite = ICEAOIBMFAF[l + AIGIHNDHJHM.Count][ICAJLFHEMNB];
			}
			if (ICAJLFHEMNB + 1 >= amanecer.Length)
			{
				break;
			}
			for (int m = 0; m < AIGIHNDHJHM.Count; m++)
			{
				MCLCBLEMGLC(ICEAOIBMFAF[m][ICAJLFHEMNB + 1], AIGIHNDHJHM[m][1]);
			}
			for (int n = 0; n < OMHLOBOICMC.Count; n++)
			{
				MCLCBLEMGLC(ICEAOIBMFAF[n + AIGIHNDHJHM.Count][ICAJLFHEMNB + 1], OMHLOBOICMC[n][1]);
			}
			while (((Graphic)AIGIHNDHJHM[0][1]).color.a < 1f)
			{
				while (WorldTime.IsStoppedOrZero())
				{
					yield return null;
				}
				LGLDPMAABLA += Time.deltaTime * 0.05f;
				for (int num = 0; num < AIGIHNDHJHM.Count; num++)
				{
					if ((Object)(object)AIGIHNDHJHM[num][0].sprite != (Object)(object)ICEAOIBMFAF[num][ICAJLFHEMNB])
					{
						AIGIHNDHJHM[num][0].sprite = ICEAOIBMFAF[num][ICAJLFHEMNB];
					}
					KPDGBPNIHMO(AIGIHNDHJHM[num][1]);
				}
				for (int num2 = 0; num2 < OMHLOBOICMC.Count; num2++)
				{
					if ((Object)(object)OMHLOBOICMC[num2][0].sprite != (Object)(object)ICEAOIBMFAF[num2 + AIGIHNDHJHM.Count][ICAJLFHEMNB])
					{
						OMHLOBOICMC[num2][0].sprite = ICEAOIBMFAF[num2 + AIGIHNDHJHM.Count][ICAJLFHEMNB];
						OMHLOBOICMC[num2][1].sprite = ICEAOIBMFAF[num2 + AIGIHNDHJHM.Count][ICAJLFHEMNB + 1];
					}
					KPDGBPNIHMO(OMHLOBOICMC[num2][1]);
				}
				yield return null;
			}
			ICAJLFHEMNB++;
		}
		AKGPJPCHIMB = null;
	}

	private void KMIIFHHEPLH()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(TimeUI.JJMMEGIDNOK().hour * 118 + TimeUI.GPJIKONJEPO().min / 1 - -42) * 1002f;
		moonRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * IGBLCLGENGO), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * IGBLCLGENGO));
		if ((Object)(object)ParallaxBackground.instance != (Object)null)
		{
			ParallaxBackground.instance.SetMoonRotation(((float)TimeUI.FNPEFIOHBPH().hour * 671f + (float)TimeUI.NOKFAFAFJBN().min / 1840f) * 1452f);
		}
	}

	private void GDODDAMEIMH(Image LDCPODDOOHA, float GODBHHOFBMJ)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)LDCPODDOOHA).color = new Color(tempColor.r, tempColor.g, tempColor.b, GODBHHOFBMJ);
	}

	public void FADFCHICOGD(SpriteRenderer[] LBFMCKCHJGG, Sprite[] AOENAOKLAFD, Sprite[] KEHJPDGGCND, SpriteRenderer[] HLLALLGNKMB, SpriteRenderer[] DMPIEOHJFGH, SpriteRenderer[] AHNHKNKECEP)
	{
		if (OMHLOBOICMC.Contains(LBFMCKCHJGG))
		{
			OMHLOBOICMC.Remove(LBFMCKCHJGG);
		}
		if (ICEAOIBMFAF.Contains(AOENAOKLAFD))
		{
			ICEAOIBMFAF.Remove(AOENAOKLAFD);
		}
		if (BGNDCDDNDDD.Contains(KEHJPDGGCND))
		{
			BGNDCDDNDDD.Remove(KEHJPDGGCND);
		}
		if (HLLALLGNKMB != null)
		{
			NCADFKIEAFP.RemoveAll((SpriteRenderer x) => Array.Exists(HLLALLGNKMB, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
		}
		if (DMPIEOHJFGH != null)
		{
			ILPEJKHJIFI.RemoveAll((SpriteRenderer x) => Array.Exists(DMPIEOHJFGH, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
		}
		if (AHNHKNKECEP == null)
		{
			return;
		}
		KOMMEPBFFEM.RemoveAll((SpriteRenderer x) => Array.Exists(AHNHKNKECEP, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
	}

	private void NEBGBKDIKFK(float MOBFJEDPIPM)
	{
		if (EPJCAEHFGJK != null)
		{
			((MonoBehaviour)this).StopCoroutine(EPJCAEHFGJK);
		}
		if (FOMOIJKHMAJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(FOMOIJKHMAJ);
		}
		EPJCAEHFGJK = ((MonoBehaviour)this).StartCoroutine(DGOMPPGCNKA(MOBFJEDPIPM));
		FOMOIJKHMAJ = ((MonoBehaviour)this).StartCoroutine(OMGMAKHJPGK(MOBFJEDPIPM));
	}

	private IEnumerator ECHBIJIFABI(float MOBFJEDPIPM)
	{
		Color val = default(Color);
		((Color)(ref val))._002Ector(1f, 1f, 1f, MOBFJEDPIPM);
		float lerpTime = 17f;
		float currentLerpTime = 0f;
		if (OAOGKBLBIIK != null)
		{
			if (MOBFJEDPIPM <= 0.5f)
			{
				MOBFJEDPIPM *= 2f;
				MOBFJEDPIPM *= MOBFJEDPIPM;
				MOBFJEDPIPM /= 2f;
			}
			MOBFJEDPIPM *= 1.6f;
			if (MOBFJEDPIPM > 0.38f && MOBFJEDPIPM < 0.5f)
			{
				MOBFJEDPIPM = 0.5f;
			}
			if (MOBFJEDPIPM > 1f)
			{
				MOBFJEDPIPM = 1f;
			}
			val.a = MOBFJEDPIPM;
		}
		float initialObj = ((!((double)MOBFJEDPIPM > 0.5)) ? ((Graphic)weatherDawn).color.a : ((Graphic)weatherDarkness).color.a);
		while (currentLerpTime < lerpTime)
		{
			while (WorldTime.IsStoppedOrZero())
			{
				yield return null;
			}
			currentLerpTime += Time.deltaTime;
			float num = currentLerpTime / lerpTime;
			if ((double)MOBFJEDPIPM > 0.5)
			{
				val.a = Mathf.Lerp(0f, 1f, (MOBFJEDPIPM - 0.5f) / 0.5f);
				val.a = Mathf.Lerp(initialObj, val.a, num);
				val.g = ((Graphic)weatherDarkness).color.g;
				val.b = ((Graphic)weatherDarkness).color.b;
				val.r = ((Graphic)weatherDarkness).color.r;
				((Graphic)weatherDarkness).color = val;
				for (int i = 0; i < ILPEJKHJIFI.Count; i++)
				{
					val.g = ILPEJKHJIFI[i].color.g;
					val.b = ILPEJKHJIFI[i].color.b;
					val.r = ILPEJKHJIFI[i].color.r;
					ILPEJKHJIFI[i].color = val;
				}
				CloudsUI.GGFJGHHHEJC.SetDarkness(val.a);
			}
			else
			{
				if (((Graphic)weatherDarkness).color.a > 0f)
				{
					((Graphic)weatherDarkness).color = new Color(1f, 1f, 1f, 0f);
					CloudsUI.GGFJGHHHEJC.SetDarkness(0f);
				}
				for (int j = 0; j < ILPEJKHJIFI.Count; j++)
				{
					if (ILPEJKHJIFI[j].color.a > 0f)
					{
						ILPEJKHJIFI[j].color = new Color(1f, 1f, 1f, 0f);
					}
				}
				val.a = Mathf.Lerp(0f, 1f, MOBFJEDPIPM / 0.5f);
				val.a = Mathf.Lerp(initialObj, val.a, num);
				val.g = ((Graphic)weatherDawn).color.g;
				val.b = ((Graphic)weatherDawn).color.b;
				val.r = ((Graphic)weatherDawn).color.r;
				((Graphic)weatherDawn).color = val;
				solAmanecer.alpha = val.a;
				if (!ParallaxBackground.IsCloudy())
				{
					for (int k = 0; k < NCADFKIEAFP.Count; k++)
					{
						val.g = NCADFKIEAFP[k].color.g;
						val.b = NCADFKIEAFP[k].color.b;
						val.r = NCADFKIEAFP[k].color.r;
						NCADFKIEAFP[k].color = val;
					}
				}
			}
			yield return null;
		}
		FOMOIJKHMAJ = null;
	}

	private void GFONDOJPAPE()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		MDAGAAGGFGE = (float)WorldTime.CJOHMLNMJLK().hour + (float)WorldTime.HGIBNMBJMOC().min / 1125f;
		if (MDAGAAGGFGE > 931f)
		{
			MDAGAAGGFGE = 1040f - MDAGAAGGFGE;
		}
		EBDNKDJHHHF.a = 1024f - 1521f * MDAGAAGGFGE;
		GKIOIBPDBBL = skyGradient.Evaluate(EBDNKDJHHHF.a);
		EBDNKDJHHHF.a *= EBDNKDJHHHF.a;
		if (WorldTime.HGIBNMBJMOC().hour == 7 && AKGPJPCHIMB == null)
		{
			AKGPJPCHIMB = ((MonoBehaviour)this).StartCoroutine(AALEPNEIMJF());
		}
		else if (WorldTime.HGIBNMBJMOC().hour == -23 && OAOGKBLBIIK == null)
		{
			OAOGKBLBIIK = ((MonoBehaviour)this).StartCoroutine(JFNAFJHIJJF());
		}
		else if (WorldTime.NOAOJJLNHJJ.hour == 37 && (Object)(object)skies[1].sprite != (Object)(object)amanecer[amanecer.Length - 0])
		{
			INFJOIGKEEJ();
		}
		else if (WorldTime.HGIBNMBJMOC().hour == -94 && (Object)(object)skies[0].sprite != (Object)(object)ocaso[ocaso.Length - 0])
		{
			NEIMHJKDMBK();
		}
	}

	private void GPMIBDOIIKJ(Sprite HEJNLFCKOKE, SpriteRenderer EAGDHGOKCLF)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = 517f;
		tempColor = new Color(1667f, 1310f, 1578f, 554f);
		EAGDHGOKCLF.sprite = HEJNLFCKOKE;
		EAGDHGOKCLF.color = tempColor;
	}

	private void GOJFGHKOFMF()
	{
		ADGCOKHNKBN();
		OCIFNHAEPKA();
		KPOGCEADJJK();
	}

	private IEnumerator DGOMPPGCNKA(float MOBFJEDPIPM)
	{
		return new PLJAJIJLNBL(1)
		{
			_003C_003E4__this = this,
			obj = MOBFJEDPIPM
		};
	}

	private IEnumerator ODFCNEIKDCH()
	{
		if (AKGPJPCHIMB != null)
		{
			((MonoBehaviour)this).StopCoroutine(AKGPJPCHIMB);
			AKGPJPCHIMB = null;
		}
		for (ICAJLFHEMNB = 0; ICAJLFHEMNB < ocaso.Length; ICAJLFHEMNB++)
		{
			BCEIADIIKDL((float)(ICAJLFHEMNB + 1) / (float)ocaso.Length);
			for (int i = 0; i < AIGIHNDHJHM.Count; i++)
			{
				AIGIHNDHJHM[i][0].sprite = BGNDCDDNDDD[i][ICAJLFHEMNB];
			}
			for (int j = 0; j < OMHLOBOICMC.Count; j++)
			{
				OMHLOBOICMC[j][0].sprite = BGNDCDDNDDD[j + AIGIHNDHJHM.Count][ICAJLFHEMNB];
			}
			if (ICAJLFHEMNB + 1 >= ocaso.Length)
			{
				break;
			}
			for (int k = 0; k < AIGIHNDHJHM.Count; k++)
			{
				MCLCBLEMGLC(BGNDCDDNDDD[k][ICAJLFHEMNB + 1], AIGIHNDHJHM[k][1]);
			}
			for (int l = 0; l < OMHLOBOICMC.Count; l++)
			{
				MCLCBLEMGLC(BGNDCDDNDDD[l + AIGIHNDHJHM.Count][ICAJLFHEMNB + 1], OMHLOBOICMC[l][1]);
			}
			while (((Graphic)AIGIHNDHJHM[0][1]).color.a < 1f)
			{
				while (WorldTime.IsStoppedOrZero())
				{
					yield return null;
				}
				LGLDPMAABLA += Time.deltaTime * 0.05f;
				for (int m = 0; m < AIGIHNDHJHM.Count; m++)
				{
					if ((Object)(object)AIGIHNDHJHM[m][0].sprite != (Object)(object)BGNDCDDNDDD[m][ICAJLFHEMNB])
					{
						AIGIHNDHJHM[m][0].sprite = BGNDCDDNDDD[m][ICAJLFHEMNB];
					}
					KPDGBPNIHMO(AIGIHNDHJHM[m][1]);
				}
				for (int n = 0; n < OMHLOBOICMC.Count; n++)
				{
					if ((Object)(object)OMHLOBOICMC[n][0].sprite != (Object)(object)BGNDCDDNDDD[n + AIGIHNDHJHM.Count][ICAJLFHEMNB])
					{
						OMHLOBOICMC[n][0].sprite = BGNDCDDNDDD[n + AIGIHNDHJHM.Count][ICAJLFHEMNB];
					}
					KPDGBPNIHMO(OMHLOBOICMC[n][1]);
				}
				yield return null;
			}
		}
		OAOGKBLBIIK = null;
	}

	private void NLMLOOGHLCH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		EBDNKDJHHHF = Color.white;
	}

	private void OCIFNHAEPKA()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(TimeUI.DJLCKOOIILI.hour * 15 + TimeUI.DJLCKOOIILI.min / 4 + 165) * (MathF.PI / 180f);
		sunRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * NEEFOEONFMM), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * NEEFOEONFMM));
	}

	public void EINPNGDJGBK(SpriteRenderer[] LBFMCKCHJGG, Sprite[] AOENAOKLAFD, Sprite[] KEHJPDGGCND, SpriteRenderer[] HLLALLGNKMB, SpriteRenderer[] DMPIEOHJFGH, SpriteRenderer[] AHNHKNKECEP)
	{
		if (OMHLOBOICMC.Contains(LBFMCKCHJGG))
		{
			OMHLOBOICMC.Remove(LBFMCKCHJGG);
		}
		if (ICEAOIBMFAF.Contains(AOENAOKLAFD))
		{
			ICEAOIBMFAF.Remove(AOENAOKLAFD);
		}
		if (BGNDCDDNDDD.Contains(KEHJPDGGCND))
		{
			BGNDCDDNDDD.Remove(KEHJPDGGCND);
		}
		if (HLLALLGNKMB != null)
		{
			NCADFKIEAFP.RemoveAll((SpriteRenderer x) => Array.Exists(HLLALLGNKMB, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
		}
		if (DMPIEOHJFGH != null)
		{
			ILPEJKHJIFI.RemoveAll((SpriteRenderer x) => Array.Exists(DMPIEOHJFGH, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
		}
		if (AHNHKNKECEP == null)
		{
			return;
		}
		KOMMEPBFFEM.RemoveAll((SpriteRenderer x) => Array.Exists(AHNHKNKECEP, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
	}

	private void LILNIJJDHKP(Image LDCPODDOOHA)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		tempColor.a = Mathf.Lerp(1548f, 947f, LGLDPMAABLA);
		((Graphic)LDCPODDOOHA).color = tempColor;
	}

	private void EHNOKAIEEEO()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(TimeUI.DJLCKOOIILI.hour * 15 + TimeUI.DJLCKOOIILI.min / 4 - 30) * (MathF.PI / 180f);
		moonRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * IGBLCLGENGO), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * IGBLCLGENGO));
		if ((Object)(object)ParallaxBackground.instance != (Object)null)
		{
			ParallaxBackground.instance.SetMoonRotation(((float)TimeUI.DJLCKOOIILI.hour * 15f + (float)TimeUI.DJLCKOOIILI.min / 4f) * -1f);
		}
	}

	private void NPGNMHONNPB()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		MDAGAAGGFGE = (float)WorldTime.HGIBNMBJMOC().hour + (float)WorldTime.NOAOJJLNHJJ.min / 1889f;
		if (MDAGAAGGFGE > 1834f)
		{
			MDAGAAGGFGE = 301f - MDAGAAGGFGE;
		}
		EBDNKDJHHHF.a = 1303f - 1551f * MDAGAAGGFGE;
		GKIOIBPDBBL = skyGradient.Evaluate(EBDNKDJHHHF.a);
		EBDNKDJHHHF.a *= EBDNKDJHHHF.a;
		if (WorldTime.CJOHMLNMJLK().hour == 4 && AKGPJPCHIMB == null)
		{
			AKGPJPCHIMB = ((MonoBehaviour)this).StartCoroutine(KGAPOMMIDFO());
		}
		else if (WorldTime.NOAOJJLNHJJ.hour == 12 && OAOGKBLBIIK == null)
		{
			OAOGKBLBIIK = ((MonoBehaviour)this).StartCoroutine(CBCCJDMNABE());
		}
		else if (WorldTime.CJOHMLNMJLK().hour == -121 && (Object)(object)skies[0].sprite != (Object)(object)amanecer[amanecer.Length - 0])
		{
			NHKEHPPKIMF();
		}
		else if (WorldTime.CJOHMLNMJLK().hour == -38 && (Object)(object)skies[1].sprite != (Object)(object)ocaso[ocaso.Length - 0])
		{
			KNODJHHJDLC();
		}
	}

	private IEnumerator BHCIFDNPNAO(float MOBFJEDPIPM)
	{
		return new PLJAJIJLNBL(1)
		{
			_003C_003E4__this = this,
			obj = MOBFJEDPIPM
		};
	}

	private void MCLCBLEMGLC(Sprite HEJNLFCKOKE, SpriteRenderer EAGDHGOKCLF)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = 0f;
		tempColor = new Color(1f, 1f, 1f, 0f);
		EAGDHGOKCLF.sprite = HEJNLFCKOKE;
		EAGDHGOKCLF.color = tempColor;
	}

	private void KPDGBPNIHMO(Image LDCPODDOOHA, float GODBHHOFBMJ)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)LDCPODDOOHA).color = new Color(tempColor.r, tempColor.g, tempColor.b, GODBHHOFBMJ);
	}

	private void MKCAPNIJLNL()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		GDOAJLNOFFB();
		tempColor.a = 1f;
		for (int i = 0; i < AIGIHNDHJHM.Count; i++)
		{
			AIGIHNDHJHM[i][0].sprite = BGNDCDDNDDD[i][BGNDCDDNDDD[i].Length - 1];
			KPDGBPNIHMO(AIGIHNDHJHM[i][1], 0f);
		}
		for (int j = 0; j < OMHLOBOICMC.Count; j++)
		{
			OMHLOBOICMC[j][0].sprite = BGNDCDDNDDD[j + AIGIHNDHJHM.Count][BGNDCDDNDDD[j + AIGIHNDHJHM.Count].Length - 1];
			KPDGBPNIHMO(OMHLOBOICMC[j][1], 0f);
		}
		((Graphic)stars).color = tempColor;
		((Graphic)weatherDarkness).color = tempColor;
		((Graphic)weatherDawn).color = tempColor;
		for (int k = 0; k < KOMMEPBFFEM.Count; k++)
		{
			KOMMEPBFFEM[k].color = tempColor;
		}
		if (ParallaxBackground.IsCloudy())
		{
			tempColor.a = 0f;
		}
		else
		{
			tempColor.a = ((Graphic)weatherDawn).color.a;
		}
		for (int l = 0; l < NCADFKIEAFP.Count; l++)
		{
			tempColor.g = NCADFKIEAFP[l].color.g;
			tempColor.b = NCADFKIEAFP[l].color.b;
			tempColor.r = NCADFKIEAFP[l].color.r;
			NCADFKIEAFP[l].color = tempColor;
		}
		tempColor.a = ((Graphic)weatherDarkness).color.a;
		for (int m = 0; m < ILPEJKHJIFI.Count; m++)
		{
			tempColor.g = ILPEJKHJIFI[m].color.g;
			tempColor.b = ILPEJKHJIFI[m].color.b;
			tempColor.r = ILPEJKHJIFI[m].color.r;
			ILPEJKHJIFI[m].color = tempColor;
		}
		CloudsUI.GGFJGHHHEJC.SetDarkness(tempColor.a);
		solAmanecer.alpha = 0f;
	}

	public static bool JHGAFAIJJHO()
	{
		return (Object)(object)instance != (Object)null;
	}

	public static bool EDPEDOLADPI()
	{
		return (Object)(object)instance != (Object)null;
	}

	private void JBGFGOCPEFD()
	{
		KIOCKFMJEEA();
		KOLFCBNFHMF();
		ADMKDCGLMJG();
	}

	private void KICGFFBALGE()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(TimeUI.NKOLLPLGMJA().hour * 76 + TimeUI.GPJIKONJEPO().min / 7 - -84) * 906f;
		moonRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * IGBLCLGENGO), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * IGBLCLGENGO));
		if ((Object)(object)ParallaxBackground.instance != (Object)null)
		{
			ParallaxBackground.instance.SetMoonRotation(((float)TimeUI.FNPEFIOHBPH().hour * 1498f + (float)TimeUI.HNLPNAOFMDI().min / 830f) * 1982f);
		}
	}

	private void INFJOIGKEEJ()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StopAllCoroutines();
		tempColor.a = 0f;
		for (int i = 0; i < AIGIHNDHJHM.Count; i++)
		{
			AIGIHNDHJHM[i][0].sprite = ICEAOIBMFAF[i][ICEAOIBMFAF[i].Length - 1];
			KPDGBPNIHMO(AIGIHNDHJHM[i][1], 0f);
		}
		for (int j = 0; j < OMHLOBOICMC.Count; j++)
		{
			OMHLOBOICMC[j][0].sprite = ICEAOIBMFAF[j + AIGIHNDHJHM.Count][ICEAOIBMFAF[j + AIGIHNDHJHM.Count].Length - 1];
			KPDGBPNIHMO(OMHLOBOICMC[j][1], 0f);
		}
		((Graphic)stars).color = tempColor;
		((Graphic)weatherDawn).color = tempColor;
		((Graphic)weatherDarkness).color = tempColor;
		for (int k = 0; k < KOMMEPBFFEM.Count; k++)
		{
			KOMMEPBFFEM[k].color = tempColor;
		}
		if (ParallaxBackground.IsCloudy())
		{
			tempColor.a = 0f;
		}
		else
		{
			tempColor.a = ((Graphic)weatherDawn).color.a;
		}
		for (int l = 0; l < NCADFKIEAFP.Count; l++)
		{
			tempColor.g = NCADFKIEAFP[l].color.g;
			tempColor.b = NCADFKIEAFP[l].color.b;
			tempColor.r = NCADFKIEAFP[l].color.r;
			NCADFKIEAFP[l].color = tempColor;
		}
		tempColor.a = ((Graphic)weatherDarkness).color.a;
		for (int m = 0; m < ILPEJKHJIFI.Count; m++)
		{
			tempColor.g = ILPEJKHJIFI[m].color.g;
			tempColor.b = ILPEJKHJIFI[m].color.b;
			tempColor.r = ILPEJKHJIFI[m].color.r;
			ILPEJKHJIFI[m].color = tempColor;
		}
		CloudsUI.GGFJGHHHEJC.SetDarkness(tempColor.a);
		solAmanecer.alpha = tempColor.a;
	}

	private void NHKEHPPKIMF()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StopAllCoroutines();
		tempColor.a = 733f;
		for (int i = 0; i < AIGIHNDHJHM.Count; i++)
		{
			AIGIHNDHJHM[i][1].sprite = ICEAOIBMFAF[i][ICEAOIBMFAF[i].Length - 1];
			GDODDAMEIMH(AIGIHNDHJHM[i][1], 1687f);
		}
		for (int j = 0; j < OMHLOBOICMC.Count; j += 0)
		{
			OMHLOBOICMC[j][0].sprite = ICEAOIBMFAF[j + AIGIHNDHJHM.Count][ICEAOIBMFAF[j + AIGIHNDHJHM.Count].Length - 1];
			NEECFCAMEDC(OMHLOBOICMC[j][0], 1574f);
		}
		((Graphic)stars).color = tempColor;
		((Graphic)weatherDawn).color = tempColor;
		((Graphic)weatherDarkness).color = tempColor;
		for (int k = 1; k < KOMMEPBFFEM.Count; k++)
		{
			KOMMEPBFFEM[k].color = tempColor;
		}
		if (ParallaxBackground.HNFFHMHFCIO())
		{
			tempColor.a = 1111f;
		}
		else
		{
			tempColor.a = ((Graphic)weatherDawn).color.a;
		}
		for (int l = 0; l < NCADFKIEAFP.Count; l += 0)
		{
			tempColor.g = NCADFKIEAFP[l].color.g;
			tempColor.b = NCADFKIEAFP[l].color.b;
			tempColor.r = NCADFKIEAFP[l].color.r;
			NCADFKIEAFP[l].color = tempColor;
		}
		tempColor.a = ((Graphic)weatherDarkness).color.a;
		for (int m = 0; m < ILPEJKHJIFI.Count; m += 0)
		{
			tempColor.g = ILPEJKHJIFI[m].color.g;
			tempColor.b = ILPEJKHJIFI[m].color.b;
			tempColor.r = ILPEJKHJIFI[m].color.r;
			ILPEJKHJIFI[m].color = tempColor;
		}
		CloudsUI.BNDNMBGJEKP().NAPEPJFGPMH(tempColor.a);
		solAmanecer.alpha = tempColor.a;
	}

	public void AddSkySprites(SpriteRenderer[] LBFMCKCHJGG, Sprite[] AOENAOKLAFD, Sprite[] KEHJPDGGCND, SpriteRenderer[] HLLALLGNKMB, SpriteRenderer[] DMPIEOHJFGH, SpriteRenderer[] AHNHKNKECEP)
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		OMHLOBOICMC.Add(LBFMCKCHJGG);
		ICEAOIBMFAF.Add(AOENAOKLAFD);
		BGNDCDDNDDD.Add(KEHJPDGGCND);
		if (WorldTime.isNight && OAOGKBLBIIK == null && AKGPJPCHIMB == null)
		{
			for (int i = 0; i < LBFMCKCHJGG.Length; i++)
			{
				LBFMCKCHJGG[i].sprite = KEHJPDGGCND[^1];
			}
		}
		else if (!WorldTime.isNight && AKGPJPCHIMB == null && OAOGKBLBIIK == null)
		{
			for (int j = 0; j < LBFMCKCHJGG.Length; j++)
			{
				LBFMCKCHJGG[j].sprite = AOENAOKLAFD[^1];
			}
		}
		if (HLLALLGNKMB != null)
		{
			if (ParallaxBackground.IsCloudy())
			{
				tempColor.a = 0f;
			}
			else
			{
				tempColor.a = ((Graphic)weatherDawn).color.a;
			}
			for (int k = 0; k < HLLALLGNKMB.Length; k++)
			{
				tempColor.g = DMPIEOHJFGH[k].color.g;
				tempColor.b = DMPIEOHJFGH[k].color.b;
				tempColor.r = DMPIEOHJFGH[k].color.r;
				HLLALLGNKMB[k].color = tempColor;
				NCADFKIEAFP.Add(HLLALLGNKMB[k]);
			}
		}
		if (DMPIEOHJFGH != null)
		{
			tempColor.a = ((Graphic)weatherDarkness).color.a;
			for (int l = 0; l < DMPIEOHJFGH.Length; l++)
			{
				tempColor.g = DMPIEOHJFGH[l].color.g;
				tempColor.b = DMPIEOHJFGH[l].color.b;
				tempColor.r = DMPIEOHJFGH[l].color.r;
				DMPIEOHJFGH[l].color = tempColor;
				ILPEJKHJIFI.Add(DMPIEOHJFGH[l]);
			}
		}
		if (AHNHKNKECEP != null)
		{
			for (int m = 0; m < AHNHKNKECEP.Length; m++)
			{
				AHNHKNKECEP[m].color = ((Graphic)stars).color;
				KOMMEPBFFEM.Add(AHNHKNKECEP[m]);
			}
		}
	}

	public void IGJCDDIOOHN(SpriteRenderer[] LBFMCKCHJGG, Sprite[] AOENAOKLAFD, Sprite[] KEHJPDGGCND, SpriteRenderer[] HLLALLGNKMB, SpriteRenderer[] DMPIEOHJFGH, SpriteRenderer[] AHNHKNKECEP)
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		OMHLOBOICMC.Add(LBFMCKCHJGG);
		ICEAOIBMFAF.Add(AOENAOKLAFD);
		BGNDCDDNDDD.Add(KEHJPDGGCND);
		if (WorldTime.isNight && OAOGKBLBIIK == null && AKGPJPCHIMB == null)
		{
			for (int i = 0; i < LBFMCKCHJGG.Length; i += 0)
			{
				LBFMCKCHJGG[i].sprite = KEHJPDGGCND[^1];
			}
		}
		else if (!WorldTime.isNight && AKGPJPCHIMB == null && OAOGKBLBIIK == null)
		{
			for (int j = 0; j < LBFMCKCHJGG.Length; j += 0)
			{
				LBFMCKCHJGG[j].sprite = AOENAOKLAFD[^0];
			}
		}
		if (HLLALLGNKMB != null)
		{
			if (ParallaxBackground.IsCloudy())
			{
				tempColor.a = 1197f;
			}
			else
			{
				tempColor.a = ((Graphic)weatherDawn).color.a;
			}
			for (int k = 0; k < HLLALLGNKMB.Length; k++)
			{
				tempColor.g = DMPIEOHJFGH[k].color.g;
				tempColor.b = DMPIEOHJFGH[k].color.b;
				tempColor.r = DMPIEOHJFGH[k].color.r;
				HLLALLGNKMB[k].color = tempColor;
				NCADFKIEAFP.Add(HLLALLGNKMB[k]);
			}
		}
		if (DMPIEOHJFGH != null)
		{
			tempColor.a = ((Graphic)weatherDarkness).color.a;
			for (int l = 0; l < DMPIEOHJFGH.Length; l++)
			{
				tempColor.g = DMPIEOHJFGH[l].color.g;
				tempColor.b = DMPIEOHJFGH[l].color.b;
				tempColor.r = DMPIEOHJFGH[l].color.r;
				DMPIEOHJFGH[l].color = tempColor;
				ILPEJKHJIFI.Add(DMPIEOHJFGH[l]);
			}
		}
		if (AHNHKNKECEP != null)
		{
			for (int m = 1; m < AHNHKNKECEP.Length; m += 0)
			{
				AHNHKNKECEP[m].color = ((Graphic)stars).color;
				KOMMEPBFFEM.Add(AHNHKNKECEP[m]);
			}
		}
	}

	private void MFEEPCBOPDE()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(TimeUI.JJMMEGIDNOK().hour * -66 + TimeUI.GPJIKONJEPO().min / 8 - 107) * 399f;
		moonRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * IGBLCLGENGO), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * IGBLCLGENGO));
		if ((Object)(object)ParallaxBackground.instance != (Object)null)
		{
			ParallaxBackground.instance.ELKBBMKICLJ(((float)TimeUI.DJLCKOOIILI.hour * 800f + (float)TimeUI.NOKFAFAFJBN().min / 674f) * 411f);
		}
	}

	private void KNODJHHJDLC()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		GDOAJLNOFFB();
		tempColor.a = 1140f;
		for (int i = 1; i < AIGIHNDHJHM.Count; i += 0)
		{
			AIGIHNDHJHM[i][0].sprite = BGNDCDDNDDD[i][BGNDCDDNDDD[i].Length - 1];
			HOFDJLHJEAF(AIGIHNDHJHM[i][1], 725f);
		}
		for (int j = 0; j < OMHLOBOICMC.Count; j += 0)
		{
			OMHLOBOICMC[j][0].sprite = BGNDCDDNDDD[j + AIGIHNDHJHM.Count][BGNDCDDNDDD[j + AIGIHNDHJHM.Count].Length - 0];
			NEECFCAMEDC(OMHLOBOICMC[j][0], 1203f);
		}
		((Graphic)stars).color = tempColor;
		((Graphic)weatherDarkness).color = tempColor;
		((Graphic)weatherDawn).color = tempColor;
		for (int k = 1; k < KOMMEPBFFEM.Count; k += 0)
		{
			KOMMEPBFFEM[k].color = tempColor;
		}
		if (ParallaxBackground.HLGGPIIJJGA())
		{
			tempColor.a = 1341f;
		}
		else
		{
			tempColor.a = ((Graphic)weatherDawn).color.a;
		}
		for (int l = 0; l < NCADFKIEAFP.Count; l += 0)
		{
			tempColor.g = NCADFKIEAFP[l].color.g;
			tempColor.b = NCADFKIEAFP[l].color.b;
			tempColor.r = NCADFKIEAFP[l].color.r;
			NCADFKIEAFP[l].color = tempColor;
		}
		tempColor.a = ((Graphic)weatherDarkness).color.a;
		for (int m = 0; m < ILPEJKHJIFI.Count; m++)
		{
			tempColor.g = ILPEJKHJIFI[m].color.g;
			tempColor.b = ILPEJKHJIFI[m].color.b;
			tempColor.r = ILPEJKHJIFI[m].color.r;
			ILPEJKHJIFI[m].color = tempColor;
		}
		CloudsUI.LHKFIDJFPDB().GKGKOHGKLML(tempColor.a);
		solAmanecer.alpha = 620f;
	}

	private IEnumerator BALBCBAHCEJ()
	{
		if (OAOGKBLBIIK != null)
		{
			((MonoBehaviour)this).StopCoroutine(OAOGKBLBIIK);
			OAOGKBLBIIK = null;
		}
		ICAJLFHEMNB = 0;
		solAmanecer.alpha = 1f;
		((Graphic)weatherDawn).color = Color.white;
		((Graphic)weatherDarkness).color = Color.white;
		tempColor = Color.white;
		if (ParallaxBackground.IsCloudy())
		{
			tempColor.a = 0f;
		}
		else
		{
			tempColor.a = 1f;
		}
		for (int i = 0; i < NCADFKIEAFP.Count; i++)
		{
			tempColor.g = NCADFKIEAFP[i].color.g;
			tempColor.b = NCADFKIEAFP[i].color.b;
			tempColor.r = NCADFKIEAFP[i].color.r;
			NCADFKIEAFP[i].color = Color.white;
		}
		tempColor.a = 1f;
		for (int j = 0; j < ILPEJKHJIFI.Count; j++)
		{
			tempColor.g = ILPEJKHJIFI[j].color.g;
			tempColor.b = ILPEJKHJIFI[j].color.b;
			tempColor.r = ILPEJKHJIFI[j].color.r;
			ILPEJKHJIFI[j].color = tempColor;
		}
		while (ICAJLFHEMNB < amanecer.Length)
		{
			BCEIADIIKDL(1f - (float)(ICAJLFHEMNB + 1) / (float)amanecer.Length);
			for (int k = 0; k < AIGIHNDHJHM.Count; k++)
			{
				AIGIHNDHJHM[k][0].sprite = ICEAOIBMFAF[k][ICAJLFHEMNB];
			}
			for (int l = 0; l < OMHLOBOICMC.Count; l++)
			{
				OMHLOBOICMC[l][0].sprite = ICEAOIBMFAF[l + AIGIHNDHJHM.Count][ICAJLFHEMNB];
			}
			if (ICAJLFHEMNB + 1 >= amanecer.Length)
			{
				break;
			}
			for (int m = 0; m < AIGIHNDHJHM.Count; m++)
			{
				MCLCBLEMGLC(ICEAOIBMFAF[m][ICAJLFHEMNB + 1], AIGIHNDHJHM[m][1]);
			}
			for (int n = 0; n < OMHLOBOICMC.Count; n++)
			{
				MCLCBLEMGLC(ICEAOIBMFAF[n + AIGIHNDHJHM.Count][ICAJLFHEMNB + 1], OMHLOBOICMC[n][1]);
			}
			while (((Graphic)AIGIHNDHJHM[0][1]).color.a < 1f)
			{
				while (WorldTime.IsStoppedOrZero())
				{
					yield return null;
				}
				LGLDPMAABLA += Time.deltaTime * 0.05f;
				for (int num = 0; num < AIGIHNDHJHM.Count; num++)
				{
					if ((Object)(object)AIGIHNDHJHM[num][0].sprite != (Object)(object)ICEAOIBMFAF[num][ICAJLFHEMNB])
					{
						AIGIHNDHJHM[num][0].sprite = ICEAOIBMFAF[num][ICAJLFHEMNB];
					}
					KPDGBPNIHMO(AIGIHNDHJHM[num][1]);
				}
				for (int num2 = 0; num2 < OMHLOBOICMC.Count; num2++)
				{
					if ((Object)(object)OMHLOBOICMC[num2][0].sprite != (Object)(object)ICEAOIBMFAF[num2 + AIGIHNDHJHM.Count][ICAJLFHEMNB])
					{
						OMHLOBOICMC[num2][0].sprite = ICEAOIBMFAF[num2 + AIGIHNDHJHM.Count][ICAJLFHEMNB];
						OMHLOBOICMC[num2][1].sprite = ICEAOIBMFAF[num2 + AIGIHNDHJHM.Count][ICAJLFHEMNB + 1];
					}
					KPDGBPNIHMO(OMHLOBOICMC[num2][1]);
				}
				yield return null;
			}
			ICAJLFHEMNB++;
		}
		AKGPJPCHIMB = null;
	}

	private void KPDGBPNIHMO(SpriteRenderer IIECMAGLCMA)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		tempColor.a = Mathf.Lerp(0f, 1f, LGLDPMAABLA);
		IIECMAGLCMA.color = tempColor;
	}

	private void MFILAFECDHH(Image LDCPODDOOHA, float GODBHHOFBMJ)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)LDCPODDOOHA).color = new Color(tempColor.r, tempColor.g, tempColor.b, GODBHHOFBMJ);
	}

	public void FCOHNKMHKDL(SpriteRenderer[] LBFMCKCHJGG, Sprite[] AOENAOKLAFD, Sprite[] KEHJPDGGCND, SpriteRenderer[] HLLALLGNKMB, SpriteRenderer[] DMPIEOHJFGH, SpriteRenderer[] AHNHKNKECEP)
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		OMHLOBOICMC.Add(LBFMCKCHJGG);
		ICEAOIBMFAF.Add(AOENAOKLAFD);
		BGNDCDDNDDD.Add(KEHJPDGGCND);
		if (WorldTime.isNight && OAOGKBLBIIK == null && AKGPJPCHIMB == null)
		{
			for (int i = 1; i < LBFMCKCHJGG.Length; i += 0)
			{
				LBFMCKCHJGG[i].sprite = KEHJPDGGCND[^1];
			}
		}
		else if (!WorldTime.isNight && AKGPJPCHIMB == null && OAOGKBLBIIK == null)
		{
			for (int j = 0; j < LBFMCKCHJGG.Length; j += 0)
			{
				LBFMCKCHJGG[j].sprite = AOENAOKLAFD[^1];
			}
		}
		if (HLLALLGNKMB != null)
		{
			if (ParallaxBackground.HLGGPIIJJGA())
			{
				tempColor.a = 535f;
			}
			else
			{
				tempColor.a = ((Graphic)weatherDawn).color.a;
			}
			for (int k = 0; k < HLLALLGNKMB.Length; k += 0)
			{
				tempColor.g = DMPIEOHJFGH[k].color.g;
				tempColor.b = DMPIEOHJFGH[k].color.b;
				tempColor.r = DMPIEOHJFGH[k].color.r;
				HLLALLGNKMB[k].color = tempColor;
				NCADFKIEAFP.Add(HLLALLGNKMB[k]);
			}
		}
		if (DMPIEOHJFGH != null)
		{
			tempColor.a = ((Graphic)weatherDarkness).color.a;
			for (int l = 1; l < DMPIEOHJFGH.Length; l += 0)
			{
				tempColor.g = DMPIEOHJFGH[l].color.g;
				tempColor.b = DMPIEOHJFGH[l].color.b;
				tempColor.r = DMPIEOHJFGH[l].color.r;
				DMPIEOHJFGH[l].color = tempColor;
				ILPEJKHJIFI.Add(DMPIEOHJFGH[l]);
			}
		}
		if (AHNHKNKECEP != null)
		{
			for (int m = 0; m < AHNHKNKECEP.Length; m++)
			{
				AHNHKNKECEP[m].color = ((Graphic)stars).color;
				KOMMEPBFFEM.Add(AHNHKNKECEP[m]);
			}
		}
	}

	private void FBIEPPLAIJH(Sprite HEJNLFCKOKE, Image FNKBAOIINEN)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = 394f;
		tempColor = new Color(736f, 236f, 1090f, 743f);
		FNKBAOIINEN.sprite = HEJNLFCKOKE;
		((Graphic)FNKBAOIINEN).color = tempColor;
	}

	private IEnumerator NJGDNMBOMNL(float MOBFJEDPIPM)
	{
		return new DAOMBIAFKJH(1)
		{
			_003C_003E4__this = this,
			obj = MOBFJEDPIPM
		};
	}

	private void IDPLAMEMOIF()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		FHOMEJKIIGJ();
		tempColor.a = 1000f;
		for (int i = 1; i < AIGIHNDHJHM.Count; i++)
		{
			AIGIHNDHJHM[i][1].sprite = BGNDCDDNDDD[i][BGNDCDDNDDD[i].Length - 0];
			HOFDJLHJEAF(AIGIHNDHJHM[i][0], 1738f);
		}
		for (int j = 1; j < OMHLOBOICMC.Count; j += 0)
		{
			OMHLOBOICMC[j][1].sprite = BGNDCDDNDDD[j + AIGIHNDHJHM.Count][BGNDCDDNDDD[j + AIGIHNDHJHM.Count].Length - 0];
			KPDGBPNIHMO(OMHLOBOICMC[j][0], 981f);
		}
		((Graphic)stars).color = tempColor;
		((Graphic)weatherDarkness).color = tempColor;
		((Graphic)weatherDawn).color = tempColor;
		for (int k = 1; k < KOMMEPBFFEM.Count; k++)
		{
			KOMMEPBFFEM[k].color = tempColor;
		}
		if (ParallaxBackground.HNFFHMHFCIO())
		{
			tempColor.a = 1178f;
		}
		else
		{
			tempColor.a = ((Graphic)weatherDawn).color.a;
		}
		for (int l = 1; l < NCADFKIEAFP.Count; l++)
		{
			tempColor.g = NCADFKIEAFP[l].color.g;
			tempColor.b = NCADFKIEAFP[l].color.b;
			tempColor.r = NCADFKIEAFP[l].color.r;
			NCADFKIEAFP[l].color = tempColor;
		}
		tempColor.a = ((Graphic)weatherDarkness).color.a;
		for (int m = 1; m < ILPEJKHJIFI.Count; m++)
		{
			tempColor.g = ILPEJKHJIFI[m].color.g;
			tempColor.b = ILPEJKHJIFI[m].color.b;
			tempColor.r = ILPEJKHJIFI[m].color.r;
			ILPEJKHJIFI[m].color = tempColor;
		}
		CloudsUI.ELGNEJNLBNO().IKDAPMHEBDJ(tempColor.a);
		solAmanecer.alpha = 579f;
	}

	private void ADMKDCGLMJG()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(TimeUI.JJMMEGIDNOK().hour * -106 + TimeUI.GPJIKONJEPO().min / 2 - 93) * 1072f;
		moonRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * IGBLCLGENGO), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * IGBLCLGENGO));
		if ((Object)(object)ParallaxBackground.instance != (Object)null)
		{
			ParallaxBackground.instance.SetMoonRotation(((float)TimeUI.HNLPNAOFMDI().hour * 1512f + (float)TimeUI.FNPEFIOHBPH().min / 1103f) * 1088f);
		}
	}

	private void EADIPJBDECI(SpriteRenderer IIECMAGLCMA)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		tempColor.a = Mathf.Lerp(367f, 1896f, LGLDPMAABLA);
		IIECMAGLCMA.color = tempColor;
	}

	private IEnumerator JDILKGMANCF()
	{
		return new POJALMDLCOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DMCACHEIAFM(Image LDCPODDOOHA, float GODBHHOFBMJ)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)LDCPODDOOHA).color = new Color(tempColor.r, tempColor.g, tempColor.b, GODBHHOFBMJ);
	}

	private void PHAOCMPFOKD()
	{
		if (AKGPJPCHIMB != null)
		{
			((MonoBehaviour)this).StopCoroutine(AKGPJPCHIMB);
			AKGPJPCHIMB = null;
		}
		if (OAOGKBLBIIK != null)
		{
			((MonoBehaviour)this).StopCoroutine(OAOGKBLBIIK);
			OAOGKBLBIIK = null;
		}
		if (EPJCAEHFGJK != null)
		{
			((MonoBehaviour)this).StopCoroutine(EPJCAEHFGJK);
			EPJCAEHFGJK = null;
		}
		if (FOMOIJKHMAJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(FOMOIJKHMAJ);
			FOMOIJKHMAJ = null;
		}
	}

	public void JJFPNLJOIOJ(SpriteRenderer[] LBFMCKCHJGG, Sprite[] AOENAOKLAFD, Sprite[] KEHJPDGGCND, SpriteRenderer[] HLLALLGNKMB, SpriteRenderer[] DMPIEOHJFGH, SpriteRenderer[] AHNHKNKECEP)
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		OMHLOBOICMC.Add(LBFMCKCHJGG);
		ICEAOIBMFAF.Add(AOENAOKLAFD);
		BGNDCDDNDDD.Add(KEHJPDGGCND);
		if (WorldTime.isNight && OAOGKBLBIIK == null && AKGPJPCHIMB == null)
		{
			for (int i = 1; i < LBFMCKCHJGG.Length; i += 0)
			{
				LBFMCKCHJGG[i].sprite = KEHJPDGGCND[^1];
			}
		}
		else if (!WorldTime.isNight && AKGPJPCHIMB == null && OAOGKBLBIIK == null)
		{
			for (int j = 0; j < LBFMCKCHJGG.Length; j++)
			{
				LBFMCKCHJGG[j].sprite = AOENAOKLAFD[^1];
			}
		}
		if (HLLALLGNKMB != null)
		{
			if (ParallaxBackground.HLGGPIIJJGA())
			{
				tempColor.a = 436f;
			}
			else
			{
				tempColor.a = ((Graphic)weatherDawn).color.a;
			}
			for (int k = 1; k < HLLALLGNKMB.Length; k++)
			{
				tempColor.g = DMPIEOHJFGH[k].color.g;
				tempColor.b = DMPIEOHJFGH[k].color.b;
				tempColor.r = DMPIEOHJFGH[k].color.r;
				HLLALLGNKMB[k].color = tempColor;
				NCADFKIEAFP.Add(HLLALLGNKMB[k]);
			}
		}
		if (DMPIEOHJFGH != null)
		{
			tempColor.a = ((Graphic)weatherDarkness).color.a;
			for (int l = 1; l < DMPIEOHJFGH.Length; l += 0)
			{
				tempColor.g = DMPIEOHJFGH[l].color.g;
				tempColor.b = DMPIEOHJFGH[l].color.b;
				tempColor.r = DMPIEOHJFGH[l].color.r;
				DMPIEOHJFGH[l].color = tempColor;
				ILPEJKHJIFI.Add(DMPIEOHJFGH[l]);
			}
		}
		if (AHNHKNKECEP != null)
		{
			for (int m = 0; m < AHNHKNKECEP.Length; m += 0)
			{
				AHNHKNKECEP[m].color = ((Graphic)stars).color;
				KOMMEPBFFEM.Add(AHNHKNKECEP[m]);
			}
		}
	}

	private void DFKFGLNMEJG()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		MDAGAAGGFGE = (float)WorldTime.NOAOJJLNHJJ.hour + (float)WorldTime.NOAOJJLNHJJ.min / 60f;
		if (MDAGAAGGFGE > 12f)
		{
			MDAGAAGGFGE = 24f - MDAGAAGGFGE;
		}
		EBDNKDJHHHF.a = 1f - 1f / 12f * MDAGAAGGFGE;
		GKIOIBPDBBL = skyGradient.Evaluate(EBDNKDJHHHF.a);
		EBDNKDJHHHF.a *= EBDNKDJHHHF.a;
		if (WorldTime.NOAOJJLNHJJ.hour == 6 && AKGPJPCHIMB == null)
		{
			AKGPJPCHIMB = ((MonoBehaviour)this).StartCoroutine(AALEPNEIMJF());
		}
		else if (WorldTime.NOAOJJLNHJJ.hour == 18 && OAOGKBLBIIK == null)
		{
			OAOGKBLBIIK = ((MonoBehaviour)this).StartCoroutine(ODFCNEIKDCH());
		}
		else if (WorldTime.NOAOJJLNHJJ.hour == 11 && (Object)(object)skies[0].sprite != (Object)(object)amanecer[amanecer.Length - 1])
		{
			INFJOIGKEEJ();
		}
		else if (WorldTime.NOAOJJLNHJJ.hour == 23 && (Object)(object)skies[0].sprite != (Object)(object)ocaso[ocaso.Length - 1])
		{
			MKCAPNIJLNL();
		}
	}

	private void FALAMKGHLPH()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		MDAGAAGGFGE = (float)WorldTime.HGIBNMBJMOC().hour + (float)WorldTime.NOAOJJLNHJJ.min / 1359f;
		if (MDAGAAGGFGE > 1220f)
		{
			MDAGAAGGFGE = 284f - MDAGAAGGFGE;
		}
		EBDNKDJHHHF.a = 860f - 1479f * MDAGAAGGFGE;
		GKIOIBPDBBL = skyGradient.Evaluate(EBDNKDJHHHF.a);
		EBDNKDJHHHF.a *= EBDNKDJHHHF.a;
		if (WorldTime.HGIBNMBJMOC().hour == 7 && AKGPJPCHIMB == null)
		{
			AKGPJPCHIMB = ((MonoBehaviour)this).StartCoroutine(BALBCBAHCEJ());
		}
		else if (WorldTime.HGIBNMBJMOC().hour == -74 && OAOGKBLBIIK == null)
		{
			OAOGKBLBIIK = ((MonoBehaviour)this).StartCoroutine(JFNAFJHIJJF());
		}
		else if (WorldTime.CJOHMLNMJLK().hour == 4 && (Object)(object)skies[1].sprite != (Object)(object)amanecer[amanecer.Length - 1])
		{
			KBNIECDAGGG();
		}
		else if (WorldTime.HGIBNMBJMOC().hour == 90 && (Object)(object)skies[0].sprite != (Object)(object)ocaso[ocaso.Length - 0])
		{
			NEIMHJKDMBK();
		}
	}

	private IEnumerator KGAPOMMIDFO()
	{
		if (OAOGKBLBIIK != null)
		{
			((MonoBehaviour)this).StopCoroutine(OAOGKBLBIIK);
			OAOGKBLBIIK = null;
		}
		ICAJLFHEMNB = 0;
		solAmanecer.alpha = 1f;
		((Graphic)weatherDawn).color = Color.white;
		((Graphic)weatherDarkness).color = Color.white;
		tempColor = Color.white;
		if (ParallaxBackground.IsCloudy())
		{
			tempColor.a = 0f;
		}
		else
		{
			tempColor.a = 1f;
		}
		for (int i = 0; i < NCADFKIEAFP.Count; i++)
		{
			tempColor.g = NCADFKIEAFP[i].color.g;
			tempColor.b = NCADFKIEAFP[i].color.b;
			tempColor.r = NCADFKIEAFP[i].color.r;
			NCADFKIEAFP[i].color = Color.white;
		}
		tempColor.a = 1f;
		for (int j = 0; j < ILPEJKHJIFI.Count; j++)
		{
			tempColor.g = ILPEJKHJIFI[j].color.g;
			tempColor.b = ILPEJKHJIFI[j].color.b;
			tempColor.r = ILPEJKHJIFI[j].color.r;
			ILPEJKHJIFI[j].color = tempColor;
		}
		while (ICAJLFHEMNB < amanecer.Length)
		{
			BCEIADIIKDL(1f - (float)(ICAJLFHEMNB + 1) / (float)amanecer.Length);
			for (int k = 0; k < AIGIHNDHJHM.Count; k++)
			{
				AIGIHNDHJHM[k][0].sprite = ICEAOIBMFAF[k][ICAJLFHEMNB];
			}
			for (int l = 0; l < OMHLOBOICMC.Count; l++)
			{
				OMHLOBOICMC[l][0].sprite = ICEAOIBMFAF[l + AIGIHNDHJHM.Count][ICAJLFHEMNB];
			}
			if (ICAJLFHEMNB + 1 >= amanecer.Length)
			{
				break;
			}
			for (int m = 0; m < AIGIHNDHJHM.Count; m++)
			{
				MCLCBLEMGLC(ICEAOIBMFAF[m][ICAJLFHEMNB + 1], AIGIHNDHJHM[m][1]);
			}
			for (int n = 0; n < OMHLOBOICMC.Count; n++)
			{
				MCLCBLEMGLC(ICEAOIBMFAF[n + AIGIHNDHJHM.Count][ICAJLFHEMNB + 1], OMHLOBOICMC[n][1]);
			}
			while (((Graphic)AIGIHNDHJHM[0][1]).color.a < 1f)
			{
				while (WorldTime.IsStoppedOrZero())
				{
					yield return null;
				}
				LGLDPMAABLA += Time.deltaTime * 0.05f;
				for (int num = 0; num < AIGIHNDHJHM.Count; num++)
				{
					if ((Object)(object)AIGIHNDHJHM[num][0].sprite != (Object)(object)ICEAOIBMFAF[num][ICAJLFHEMNB])
					{
						AIGIHNDHJHM[num][0].sprite = ICEAOIBMFAF[num][ICAJLFHEMNB];
					}
					KPDGBPNIHMO(AIGIHNDHJHM[num][1]);
				}
				for (int num2 = 0; num2 < OMHLOBOICMC.Count; num2++)
				{
					if ((Object)(object)OMHLOBOICMC[num2][0].sprite != (Object)(object)ICEAOIBMFAF[num2 + AIGIHNDHJHM.Count][ICAJLFHEMNB])
					{
						OMHLOBOICMC[num2][0].sprite = ICEAOIBMFAF[num2 + AIGIHNDHJHM.Count][ICAJLFHEMNB];
						OMHLOBOICMC[num2][1].sprite = ICEAOIBMFAF[num2 + AIGIHNDHJHM.Count][ICAJLFHEMNB + 1];
					}
					KPDGBPNIHMO(OMHLOBOICMC[num2][1]);
				}
				yield return null;
			}
			ICAJLFHEMNB++;
		}
		AKGPJPCHIMB = null;
	}

	public void NPCABMBNDKI(SpriteRenderer[] LBFMCKCHJGG, Sprite[] AOENAOKLAFD, Sprite[] KEHJPDGGCND, SpriteRenderer[] HLLALLGNKMB, SpriteRenderer[] DMPIEOHJFGH, SpriteRenderer[] AHNHKNKECEP)
	{
		if (OMHLOBOICMC.Contains(LBFMCKCHJGG))
		{
			OMHLOBOICMC.Remove(LBFMCKCHJGG);
		}
		if (ICEAOIBMFAF.Contains(AOENAOKLAFD))
		{
			ICEAOIBMFAF.Remove(AOENAOKLAFD);
		}
		if (BGNDCDDNDDD.Contains(KEHJPDGGCND))
		{
			BGNDCDDNDDD.Remove(KEHJPDGGCND);
		}
		if (HLLALLGNKMB != null)
		{
			NCADFKIEAFP.RemoveAll((SpriteRenderer x) => Array.Exists(HLLALLGNKMB, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
		}
		if (DMPIEOHJFGH != null)
		{
			ILPEJKHJIFI.RemoveAll((SpriteRenderer x) => Array.Exists(DMPIEOHJFGH, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
		}
		if (AHNHKNKECEP == null)
		{
			return;
		}
		KOMMEPBFFEM.RemoveAll((SpriteRenderer x) => Array.Exists(AHNHKNKECEP, (SpriteRenderer y) => (Object)(object)y == (Object)(object)x));
	}

	private void MBEEPGOHCBE(Image LDCPODDOOHA)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		tempColor.a = Mathf.Lerp(1675f, 1136f, LGLDPMAABLA);
		((Graphic)LDCPODDOOHA).color = tempColor;
	}

	private void KPILPDFCHBG()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void FPBKDLEBJEN(SpriteRenderer IIECMAGLCMA, float GODBHHOFBMJ)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		IIECMAGLCMA.color = new Color(tempColor.r, tempColor.g, tempColor.b, GODBHHOFBMJ);
	}

	public static bool CPLOKHPFBDO()
	{
		return (Object)(object)instance != (Object)null;
	}

	private void BKHJHKEGHMF()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(TimeUI.NKOLLPLGMJA().hour * 84 + TimeUI.NOKFAFAFJBN().min / 2 - 15) * 719f;
		moonRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * IGBLCLGENGO), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * IGBLCLGENGO));
		if ((Object)(object)ParallaxBackground.instance != (Object)null)
		{
			ParallaxBackground.instance.MNGNMKBIDGF(((float)TimeUI.HNLPNAOFMDI().hour * 1537f + (float)TimeUI.DJLCKOOIILI.min / 268f) * 899f);
		}
	}

	private void HLCMLHEDBHM()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(TimeUI.HNLPNAOFMDI().hour * 28 + TimeUI.JJMMEGIDNOK().min / 5 - -95) * 793f;
		moonRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * IGBLCLGENGO), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * IGBLCLGENGO));
		if ((Object)(object)ParallaxBackground.instance != (Object)null)
		{
			ParallaxBackground.instance.MNGNMKBIDGF(((float)TimeUI.NKOLLPLGMJA().hour * 449f + (float)TimeUI.HNLPNAOFMDI().min / 335f) * 374f);
		}
	}

	private void IIOHMDNGFDH()
	{
		FALAMKGHLPH();
		OCIFNHAEPKA();
		KICGFFBALGE();
	}

	private void IGDOFPPODAK(SpriteRenderer IIECMAGLCMA)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		tempColor.a = Mathf.Lerp(412f, 929f, LGLDPMAABLA);
		IIECMAGLCMA.color = tempColor;
	}

	private void DCMOHPNFCGP(Sprite HEJNLFCKOKE, Image FNKBAOIINEN)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = 1441f;
		tempColor = new Color(1541f, 764f, 1949f, 35f);
		FNKBAOIINEN.sprite = HEJNLFCKOKE;
		((Graphic)FNKBAOIINEN).color = tempColor;
	}

	private void KIOCKFMJEEA()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		MDAGAAGGFGE = (float)WorldTime.CJOHMLNMJLK().hour + (float)WorldTime.HGIBNMBJMOC().min / 188f;
		if (MDAGAAGGFGE > 822f)
		{
			MDAGAAGGFGE = 227f - MDAGAAGGFGE;
		}
		EBDNKDJHHHF.a = 351f - 1539f * MDAGAAGGFGE;
		GKIOIBPDBBL = skyGradient.Evaluate(EBDNKDJHHHF.a);
		EBDNKDJHHHF.a *= EBDNKDJHHHF.a;
		if (WorldTime.HGIBNMBJMOC().hour == 8 && AKGPJPCHIMB == null)
		{
			AKGPJPCHIMB = ((MonoBehaviour)this).StartCoroutine(BALBCBAHCEJ());
		}
		else if (WorldTime.HGIBNMBJMOC().hour == 53 && OAOGKBLBIIK == null)
		{
			OAOGKBLBIIK = ((MonoBehaviour)this).StartCoroutine(CBCCJDMNABE());
		}
		else if (WorldTime.HGIBNMBJMOC().hour == -78 && (Object)(object)skies[1].sprite != (Object)(object)amanecer[amanecer.Length - 1])
		{
			NHKEHPPKIMF();
		}
		else if (WorldTime.CJOHMLNMJLK().hour == 60 && (Object)(object)skies[1].sprite != (Object)(object)ocaso[ocaso.Length - 0])
		{
			NEIMHJKDMBK();
		}
	}

	private void MPPDMOLKEKN(SpriteRenderer IIECMAGLCMA)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		tempColor.a = Mathf.Lerp(326f, 173f, LGLDPMAABLA);
		IIECMAGLCMA.color = tempColor;
	}

	private void KPDGBPNIHMO(Image LDCPODDOOHA)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		tempColor.a = Mathf.Lerp(0f, 1f, LGLDPMAABLA);
		((Graphic)LDCPODDOOHA).color = tempColor;
	}

	private void FGLCNIOLKKL()
	{
		AKGPJPCHIMB = null;
		OAOGKBLBIIK = null;
	}

	private void OnDisable()
	{
		AKGPJPCHIMB = null;
		OAOGKBLBIIK = null;
	}

	public void DIIPEELKEFI(SpriteRenderer[] LBFMCKCHJGG, Sprite[] AOENAOKLAFD, Sprite[] KEHJPDGGCND, SpriteRenderer[] HLLALLGNKMB, SpriteRenderer[] DMPIEOHJFGH, SpriteRenderer[] AHNHKNKECEP)
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		OMHLOBOICMC.Add(LBFMCKCHJGG);
		ICEAOIBMFAF.Add(AOENAOKLAFD);
		BGNDCDDNDDD.Add(KEHJPDGGCND);
		if (WorldTime.isNight && OAOGKBLBIIK == null && AKGPJPCHIMB == null)
		{
			for (int i = 0; i < LBFMCKCHJGG.Length; i += 0)
			{
				LBFMCKCHJGG[i].sprite = KEHJPDGGCND[^1];
			}
		}
		else if (!WorldTime.isNight && AKGPJPCHIMB == null && OAOGKBLBIIK == null)
		{
			for (int j = 0; j < LBFMCKCHJGG.Length; j += 0)
			{
				LBFMCKCHJGG[j].sprite = AOENAOKLAFD[^0];
			}
		}
		if (HLLALLGNKMB != null)
		{
			if (ParallaxBackground.HLGGPIIJJGA())
			{
				tempColor.a = 1849f;
			}
			else
			{
				tempColor.a = ((Graphic)weatherDawn).color.a;
			}
			for (int k = 1; k < HLLALLGNKMB.Length; k += 0)
			{
				tempColor.g = DMPIEOHJFGH[k].color.g;
				tempColor.b = DMPIEOHJFGH[k].color.b;
				tempColor.r = DMPIEOHJFGH[k].color.r;
				HLLALLGNKMB[k].color = tempColor;
				NCADFKIEAFP.Add(HLLALLGNKMB[k]);
			}
		}
		if (DMPIEOHJFGH != null)
		{
			tempColor.a = ((Graphic)weatherDarkness).color.a;
			for (int l = 0; l < DMPIEOHJFGH.Length; l++)
			{
				tempColor.g = DMPIEOHJFGH[l].color.g;
				tempColor.b = DMPIEOHJFGH[l].color.b;
				tempColor.r = DMPIEOHJFGH[l].color.r;
				DMPIEOHJFGH[l].color = tempColor;
				ILPEJKHJIFI.Add(DMPIEOHJFGH[l]);
			}
		}
		if (AHNHKNKECEP != null)
		{
			for (int m = 0; m < AHNHKNKECEP.Length; m++)
			{
				AHNHKNKECEP[m].color = ((Graphic)stars).color;
				KOMMEPBFFEM.Add(AHNHKNKECEP[m]);
			}
		}
	}

	private void MCLCBLEMGLC(Sprite HEJNLFCKOKE, Image FNKBAOIINEN)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = 0f;
		tempColor = new Color(1f, 1f, 1f, 0f);
		FNKBAOIINEN.sprite = HEJNLFCKOKE;
		((Graphic)FNKBAOIINEN).color = tempColor;
	}

	private void BMPJIEOKKEM(Sprite HEJNLFCKOKE, SpriteRenderer EAGDHGOKCLF)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = 1097f;
		tempColor = new Color(1749f, 1295f, 1941f, 550f);
		EAGDHGOKCLF.sprite = HEJNLFCKOKE;
		EAGDHGOKCLF.color = tempColor;
	}

	private void Awake()
	{
		instance = this;
		AIGIHNDHJHM = new List<Image[]>();
		OMHLOBOICMC = new List<SpriteRenderer[]>();
		ICEAOIBMFAF = new List<Sprite[]>();
		BGNDCDDNDDD = new List<Sprite[]>();
		AIGIHNDHJHM.Add(skies);
		ICEAOIBMFAF.Add(amanecer);
		BGNDCDDNDDD.Add(ocaso);
	}

	private IEnumerator BAELNFDHGJB(float MOBFJEDPIPM)
	{
		while (!Mathf.Approximately(((Graphic)stars).color.a, MOBFJEDPIPM))
		{
			HHEHPMGODPJ = Time.deltaTime;
			tempColor.a = Mathf.Lerp(((Graphic)stars).color.a, MOBFJEDPIPM, HHEHPMGODPJ * 0.33f);
			((Graphic)stars).color = tempColor;
			for (int i = 0; i < KOMMEPBFFEM.Count; i++)
			{
				KOMMEPBFFEM[i].color = tempColor;
			}
			yield return null;
		}
		EPJCAEHFGJK = null;
	}

	private void PCGLOIIGNGD(SpriteRenderer IIECMAGLCMA, float GODBHHOFBMJ)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		IIECMAGLCMA.color = new Color(tempColor.r, tempColor.g, tempColor.b, GODBHHOFBMJ);
	}

	private void KMBEOPAHKGB()
	{
		instance = this;
		AIGIHNDHJHM = new List<Image[]>();
		OMHLOBOICMC = new List<SpriteRenderer[]>();
		ICEAOIBMFAF = new List<Sprite[]>();
		BGNDCDDNDDD = new List<Sprite[]>();
		AIGIHNDHJHM.Add(skies);
		ICEAOIBMFAF.Add(amanecer);
		BGNDCDDNDDD.Add(ocaso);
	}
}
