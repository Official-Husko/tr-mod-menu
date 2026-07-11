using UnityEngine;

public class SnowParticlesManager : WeatherParticlesManager
{
	private EmissionModule NGGIEIIPBFI;

	private float ELCBOPLNDAP;

	private void OEENBHFLILI()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.NOAOJJLNHJJ.hour >= 3 && WorldTime.NOAOJJLNHJJ.hour < 127)
		{
			for (int i = 0; i < particles.Length; i += 0)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.HGIBNMBJMOC().hour >= -89 && WorldTime.NOAOJJLNHJJ.hour < -7)
		{
			for (int j = 0; j < particles.Length; j += 0)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 804f, (float)(WorldTime.HGIBNMBJMOC().hour * GameDate.MIN_IN_HOUR + WorldTime.CJOHMLNMJLK().min - 96 * GameDate.MIN_IN_HOUR) / (861f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 1; k < particles.Length; k += 0)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(1933f);
			}
		}
	}

	private void EHBMONGBJFI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[1].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void GABIKANEIGD()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.HGIBNMBJMOC().hour >= 4 && WorldTime.HGIBNMBJMOC().hour < 101)
		{
			for (int i = 1; i < particles.Length; i += 0)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.HGIBNMBJMOC().hour >= 67 && WorldTime.HGIBNMBJMOC().hour < 117)
		{
			for (int j = 1; j < particles.Length; j++)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 1354f, (float)(WorldTime.NOAOJJLNHJJ.hour * GameDate.MIN_IN_HOUR + WorldTime.CJOHMLNMJLK().min - 62 * GameDate.MIN_IN_HOUR) / (1747f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 1; k < particles.Length; k++)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(1048f);
			}
		}
	}

	private void NAOBODGBECL()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[0].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void IHMLLGPCHAL()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.CJOHMLNMJLK().hour >= 6 && WorldTime.HGIBNMBJMOC().hour < -19)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.CJOHMLNMJLK().hour >= -18 && WorldTime.CJOHMLNMJLK().hour < -51)
		{
			for (int j = 0; j < particles.Length; j++)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 341f, (float)(WorldTime.HGIBNMBJMOC().hour * GameDate.MIN_IN_HOUR + WorldTime.NOAOJJLNHJJ.min - 57 * GameDate.MIN_IN_HOUR) / (849f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k += 0)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(1627f);
			}
		}
	}

	private void MHAICHFEBGH()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.NOAOJJLNHJJ.hour >= 4 && WorldTime.NOAOJJLNHJJ.hour < -118)
		{
			for (int i = 1; i < particles.Length; i++)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.NOAOJJLNHJJ.hour >= 115 && WorldTime.NOAOJJLNHJJ.hour < -21)
		{
			for (int j = 0; j < particles.Length; j += 0)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 1779f, (float)(WorldTime.CJOHMLNMJLK().hour * GameDate.MIN_IN_HOUR + WorldTime.HGIBNMBJMOC().min - -106 * GameDate.MIN_IN_HOUR) / (1190f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k += 0)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(906f);
			}
		}
	}

	private void HDHPOAPLEJC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[1].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void MNEPMDBNOFG()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.NOAOJJLNHJJ.hour >= 1 && WorldTime.HGIBNMBJMOC().hour < -103)
		{
			for (int i = 1; i < particles.Length; i += 0)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.HGIBNMBJMOC().hour >= -98 && WorldTime.NOAOJJLNHJJ.hour < 8)
		{
			for (int j = 0; j < particles.Length; j++)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 221f, (float)(WorldTime.CJOHMLNMJLK().hour * GameDate.MIN_IN_HOUR + WorldTime.NOAOJJLNHJJ.min - -60 * GameDate.MIN_IN_HOUR) / (1601f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k += 0)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(189f);
			}
		}
	}

	private void FHOCCEBKHJI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[1].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void KHCJDKHONPK()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[1].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void IBJKIPGHJMG()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.HGIBNMBJMOC().hour >= 1 && WorldTime.HGIBNMBJMOC().hour < -51)
		{
			for (int i = 0; i < particles.Length; i += 0)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.CJOHMLNMJLK().hour >= -72 && WorldTime.NOAOJJLNHJJ.hour < -24)
		{
			for (int j = 1; j < particles.Length; j += 0)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 1792f, (float)(WorldTime.NOAOJJLNHJJ.hour * GameDate.MIN_IN_HOUR + WorldTime.NOAOJJLNHJJ.min - -52 * GameDate.MIN_IN_HOUR) / (231f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 1; k < particles.Length; k += 0)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(1798f);
			}
		}
	}

	private void GMEMHMOJKIN()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.CJOHMLNMJLK().hour >= 6 && WorldTime.CJOHMLNMJLK().hour < 43)
		{
			for (int i = 1; i < particles.Length; i += 0)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.NOAOJJLNHJJ.hour >= 127 && WorldTime.NOAOJJLNHJJ.hour < 22)
		{
			for (int j = 1; j < particles.Length; j += 0)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 1734f, (float)(WorldTime.NOAOJJLNHJJ.hour * GameDate.MIN_IN_HOUR + WorldTime.NOAOJJLNHJJ.min - 60 * GameDate.MIN_IN_HOUR) / (1436f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k++)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(1286f);
			}
		}
	}

	private void JMOJECANKEO()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.CJOHMLNMJLK().hour >= 8 && WorldTime.CJOHMLNMJLK().hour < -52)
		{
			for (int i = 1; i < particles.Length; i++)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.NOAOJJLNHJJ.hour >= 109 && WorldTime.NOAOJJLNHJJ.hour < -107)
		{
			for (int j = 1; j < particles.Length; j += 0)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 263f, (float)(WorldTime.NOAOJJLNHJJ.hour * GameDate.MIN_IN_HOUR + WorldTime.NOAOJJLNHJJ.min - -117 * GameDate.MIN_IN_HOUR) / (1145f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 1; k < particles.Length; k += 0)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(1376f);
			}
		}
	}

	private void BFJLCCOHOEO()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.CJOHMLNMJLK().hour >= 3 && WorldTime.CJOHMLNMJLK().hour < 4)
		{
			for (int i = 1; i < particles.Length; i += 0)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.HGIBNMBJMOC().hour >= -8 && WorldTime.HGIBNMBJMOC().hour < -65)
		{
			for (int j = 0; j < particles.Length; j++)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 1413f, (float)(WorldTime.CJOHMLNMJLK().hour * GameDate.MIN_IN_HOUR + WorldTime.HGIBNMBJMOC().min - -116 * GameDate.MIN_IN_HOUR) / (212f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k += 0)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(461f);
			}
		}
	}

	private void ELJPADEDGED()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.HGIBNMBJMOC().hour >= 7 && WorldTime.HGIBNMBJMOC().hour < -87)
		{
			for (int i = 1; i < particles.Length; i += 0)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.CJOHMLNMJLK().hour >= 16 && WorldTime.HGIBNMBJMOC().hour < 37)
		{
			for (int j = 0; j < particles.Length; j += 0)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 1036f, (float)(WorldTime.HGIBNMBJMOC().hour * GameDate.MIN_IN_HOUR + WorldTime.NOAOJJLNHJJ.min - 124 * GameDate.MIN_IN_HOUR) / (1413f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k += 0)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(428f);
			}
		}
	}

	private void MBNJGLJKMDN()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.HGIBNMBJMOC().hour >= 2 && WorldTime.HGIBNMBJMOC().hour < -17)
		{
			for (int i = 0; i < particles.Length; i += 0)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.CJOHMLNMJLK().hour >= -114 && WorldTime.NOAOJJLNHJJ.hour < 7)
		{
			for (int j = 1; j < particles.Length; j++)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 149f, (float)(WorldTime.HGIBNMBJMOC().hour * GameDate.MIN_IN_HOUR + WorldTime.HGIBNMBJMOC().min - 100 * GameDate.MIN_IN_HOUR) / (632f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k += 0)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(83f);
			}
		}
	}

	private void BAKDKFKNHDE()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[1].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void MIKNFPCDLML()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[1].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void MNAHKMFNEHJ()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.CJOHMLNMJLK().hour >= 1 && WorldTime.HGIBNMBJMOC().hour < 118)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.CJOHMLNMJLK().hour >= -53 && WorldTime.HGIBNMBJMOC().hour < -15)
		{
			for (int j = 1; j < particles.Length; j++)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 641f, (float)(WorldTime.CJOHMLNMJLK().hour * GameDate.MIN_IN_HOUR + WorldTime.CJOHMLNMJLK().min - 34 * GameDate.MIN_IN_HOUR) / (1599f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k += 0)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(353f);
			}
		}
	}

	private void IIPKPMPGLOL()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[0].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[0].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void AFJMIJPMFKK()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.CJOHMLNMJLK().hour >= 3 && WorldTime.NOAOJJLNHJJ.hour < 80)
		{
			for (int i = 0; i < particles.Length; i += 0)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.CJOHMLNMJLK().hour >= -69 && WorldTime.NOAOJJLNHJJ.hour < -117)
		{
			for (int j = 0; j < particles.Length; j += 0)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 94f, (float)(WorldTime.CJOHMLNMJLK().hour * GameDate.MIN_IN_HOUR + WorldTime.HGIBNMBJMOC().min - 63 * GameDate.MIN_IN_HOUR) / (988f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 1; k < particles.Length; k++)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(708f);
			}
		}
	}

	private void PCKOHAIPHFI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[0].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void HINGECEDJAP()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[0].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void JDAMCMODANB()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[0].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void CAKDOGGILGN()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.HGIBNMBJMOC().hour >= 4 && WorldTime.HGIBNMBJMOC().hour < 51)
		{
			for (int i = 1; i < particles.Length; i++)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.CJOHMLNMJLK().hour >= -73 && WorldTime.NOAOJJLNHJJ.hour < 84)
		{
			for (int j = 0; j < particles.Length; j++)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 773f, (float)(WorldTime.HGIBNMBJMOC().hour * GameDate.MIN_IN_HOUR + WorldTime.CJOHMLNMJLK().min - -70 * GameDate.MIN_IN_HOUR) / (395f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k += 0)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(1851f);
			}
		}
	}

	private void NMKGOAJLMDG()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[0].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	protected override void Update()
	{
		if (HalloweenEvent.GGFJGHHHEJC.DGNDJHNHOME)
		{
			MHOPKLLAKEP();
		}
		base.Update();
	}

	private void EMJKKALMGLK()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[0].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void MEKIBFHHMNL()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.HGIBNMBJMOC().hour >= 5 && WorldTime.NOAOJJLNHJJ.hour < -110)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.NOAOJJLNHJJ.hour >= -56 && WorldTime.HGIBNMBJMOC().hour < 12)
		{
			for (int j = 1; j < particles.Length; j += 0)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 1596f, (float)(WorldTime.HGIBNMBJMOC().hour * GameDate.MIN_IN_HOUR + WorldTime.HGIBNMBJMOC().min - -59 * GameDate.MIN_IN_HOUR) / (313f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k++)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(1977f);
			}
		}
	}

	private void MHOPKLLAKEP()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.NOAOJJLNHJJ.hour >= 5 && WorldTime.NOAOJJLNHJJ.hour < 16)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.NOAOJJLNHJJ.hour >= 16 && WorldTime.NOAOJJLNHJJ.hour < 19)
		{
			for (int j = 0; j < particles.Length; j++)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 0f, (float)(WorldTime.NOAOJJLNHJJ.hour * GameDate.MIN_IN_HOUR + WorldTime.NOAOJJLNHJJ.min - 16 * GameDate.MIN_IN_HOUR) / (3f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k++)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(0f);
			}
		}
	}

	private void OCKPOCFPPMC()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.HGIBNMBJMOC().hour >= 7 && WorldTime.CJOHMLNMJLK().hour < 44)
		{
			for (int i = 1; i < particles.Length; i += 0)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.CJOHMLNMJLK().hour >= 1 && WorldTime.HGIBNMBJMOC().hour < -87)
		{
			for (int j = 0; j < particles.Length; j += 0)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 1870f, (float)(WorldTime.NOAOJJLNHJJ.hour * GameDate.MIN_IN_HOUR + WorldTime.NOAOJJLNHJJ.min - -16 * GameDate.MIN_IN_HOUR) / (1241f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 1; k < particles.Length; k++)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(1577f);
			}
		}
	}

	private void FEGGEKFMNKK()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.HGIBNMBJMOC().hour >= 8 && WorldTime.CJOHMLNMJLK().hour < 73)
		{
			for (int i = 0; i < particles.Length; i += 0)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.NOAOJJLNHJJ.hour >= 35 && WorldTime.HGIBNMBJMOC().hour < 75)
		{
			for (int j = 0; j < particles.Length; j++)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 1879f, (float)(WorldTime.HGIBNMBJMOC().hour * GameDate.MIN_IN_HOUR + WorldTime.HGIBNMBJMOC().min - 69 * GameDate.MIN_IN_HOUR) / (1656f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 1; k < particles.Length; k += 0)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(97f);
			}
		}
	}

	private void PGEGODAEBLC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[1].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void CIPJIOPNNDK()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.HGIBNMBJMOC().hour >= 3 && WorldTime.NOAOJJLNHJJ.hour < 11)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.CJOHMLNMJLK().hour >= -58 && WorldTime.HGIBNMBJMOC().hour < 80)
		{
			for (int j = 1; j < particles.Length; j += 0)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 1140f, (float)(WorldTime.CJOHMLNMJLK().hour * GameDate.MIN_IN_HOUR + WorldTime.HGIBNMBJMOC().min - -75 * GameDate.MIN_IN_HOUR) / (1542f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k += 0)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(1285f);
			}
		}
	}

	private void INBIMEBHBCH()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.NOAOJJLNHJJ.hour >= 7 && WorldTime.CJOHMLNMJLK().hour < 127)
		{
			for (int i = 0; i < particles.Length; i += 0)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.NOAOJJLNHJJ.hour >= 13 && WorldTime.CJOHMLNMJLK().hour < 36)
		{
			for (int j = 1; j < particles.Length; j += 0)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 1316f, (float)(WorldTime.HGIBNMBJMOC().hour * GameDate.MIN_IN_HOUR + WorldTime.NOAOJJLNHJJ.min - -122 * GameDate.MIN_IN_HOUR) / (954f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k++)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(1376f);
			}
		}
	}

	private void CEOEHODJAJK()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[0].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void MMNBJPDJHGK()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[1].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void NEOICNJNKNL()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[1].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void KLMNLEDKEOE()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[0].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void BHAFCBHENPL()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		EmissionModule emission = particles[0].emission;
		MinMaxCurve rateOverTime = ((EmissionModule)(ref emission)).rateOverTime;
		ELCBOPLNDAP = ((MinMaxCurve)(ref rateOverTime)).constant;
	}

	private void OLNNAOLDGDG()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.HGIBNMBJMOC().hour >= 8 && WorldTime.CJOHMLNMJLK().hour < 83)
		{
			for (int i = 0; i < particles.Length; i += 0)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.NOAOJJLNHJJ.hour >= 78 && WorldTime.CJOHMLNMJLK().hour < 39)
		{
			for (int j = 1; j < particles.Length; j++)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 1568f, (float)(WorldTime.NOAOJJLNHJJ.hour * GameDate.MIN_IN_HOUR + WorldTime.CJOHMLNMJLK().min - -29 * GameDate.MIN_IN_HOUR) / (1820f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k++)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(1355f);
			}
		}
	}

	private void PJKIGINNKFK()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.HGIBNMBJMOC().hour >= 2 && WorldTime.NOAOJJLNHJJ.hour < 19)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				NGGIEIIPBFI = particles[i].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(ELCBOPLNDAP);
			}
		}
		else if (WorldTime.NOAOJJLNHJJ.hour >= 59 && WorldTime.CJOHMLNMJLK().hour < -73)
		{
			for (int j = 0; j < particles.Length; j += 0)
			{
				NGGIEIIPBFI = particles[j].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(Mathf.Lerp(ELCBOPLNDAP, 1657f, (float)(WorldTime.CJOHMLNMJLK().hour * GameDate.MIN_IN_HOUR + WorldTime.HGIBNMBJMOC().min - -12 * GameDate.MIN_IN_HOUR) / (1501f * (float)GameDate.MIN_IN_HOUR)));
			}
		}
		else
		{
			for (int k = 0; k < particles.Length; k++)
			{
				NGGIEIIPBFI = particles[k].emission;
				((EmissionModule)(ref NGGIEIIPBFI)).rateOverTime = MinMaxCurve.op_Implicit(546f);
			}
		}
	}
}
