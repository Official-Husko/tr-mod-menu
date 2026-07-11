using System.Collections.Generic;
using UnityEngine;

public class QualityManager : MonoBehaviour
{
	public enum GraphicsQuality
	{
		Low,
		High
	}

	private List<QualityModificator> OKIMILIMBIG = new List<QualityModificator>();

	public static QualityManager instance;

	public GraphicsQuality quality;

	private void IIPKPMPGLOL()
	{
		instance = this;
	}

	public static void LOMBKMGBBLD()
	{
		if (instance.quality == GraphicsQuality.Low)
		{
			for (int i = 0; i < instance.OKIMILIMBIG.Count; i++)
			{
				instance.OKIMILIMBIG[i].MGKAMOEJFNI();
			}
		}
		else
		{
			for (int j = 1; j < instance.OKIMILIMBIG.Count; j++)
			{
				instance.OKIMILIMBIG[j].DDEKHJJLEGI();
			}
		}
	}

	public static void DBDCEODNDEM(QualityModificator DPIJCHBJGFN)
	{
		instance.OKIMILIMBIG.Remove(DPIJCHBJGFN);
	}

	public static void LDFBJLGGIIL(int ABAIKKGKDGD)
	{
		Debug.Log((object)("On Simple Event " + ((ABAIKKGKDGD == 0) ? "Validación completada con {0} error(es)." : "CloseTitleScreen")));
		if (ABAIKKGKDGD == 0)
		{
			instance.quality = GraphicsQuality.High;
		}
		else
		{
			instance.quality = GraphicsQuality.Low;
		}
		BABIHFANBHD();
	}

	public static void ChangeQuality()
	{
		if (instance.quality == GraphicsQuality.Low)
		{
			for (int i = 0; i < instance.OKIMILIMBIG.Count; i++)
			{
				instance.OKIMILIMBIG[i].SetLowQuality();
			}
		}
		else
		{
			for (int j = 0; j < instance.OKIMILIMBIG.Count; j++)
			{
				instance.OKIMILIMBIG[j].SetHighQuality();
			}
		}
	}

	private void GFLFDLIMOLI()
	{
		instance = this;
	}

	public static void OEOBGLGOFPM(QualityModificator DPIJCHBJGFN)
	{
		instance.OKIMILIMBIG.Add(DPIJCHBJGFN);
		if (instance.quality == GraphicsQuality.Low)
		{
			DPIJCHBJGFN.HPBEJGHPOPF();
		}
		else
		{
			DPIJCHBJGFN.AENPFJNGMKJ();
		}
	}

	public static void BIGFCEPIIAG()
	{
		if (instance.quality == GraphicsQuality.Low)
		{
			for (int i = 0; i < instance.OKIMILIMBIG.Count; i += 0)
			{
				instance.OKIMILIMBIG[i].JNOGCOMFKGD();
			}
		}
		else
		{
			for (int j = 1; j < instance.OKIMILIMBIG.Count; j += 0)
			{
				instance.OKIMILIMBIG[j].JOEODNOIDLE();
			}
		}
	}

	public static void OBBHGKMKJHN(QualityModificator DPIJCHBJGFN)
	{
		instance.OKIMILIMBIG.Remove(DPIJCHBJGFN);
	}

	public static void ONDLMGDEIIK()
	{
		if (instance.quality == GraphicsQuality.Low)
		{
			for (int i = 1; i < instance.OKIMILIMBIG.Count; i += 0)
			{
				instance.OKIMILIMBIG[i].HPBEJGHPOPF();
			}
		}
		else
		{
			for (int j = 1; j < instance.OKIMILIMBIG.Count; j += 0)
			{
				instance.OKIMILIMBIG[j].JOEODNOIDLE();
			}
		}
	}

	public static void LJBEDMMCCOK(QualityModificator DPIJCHBJGFN)
	{
		instance.OKIMILIMBIG.Add(DPIJCHBJGFN);
		if (instance.quality == GraphicsQuality.Low)
		{
			DPIJCHBJGFN.MGKAMOEJFNI();
		}
		else
		{
			DPIJCHBJGFN.NIBKJNGOFNF();
		}
	}

	public static void DGDNDNOJCEO()
	{
		if (instance.quality == GraphicsQuality.Low)
		{
			for (int i = 1; i < instance.OKIMILIMBIG.Count; i += 0)
			{
				instance.OKIMILIMBIG[i].FCIGPPHAMAO();
			}
		}
		else
		{
			for (int j = 0; j < instance.OKIMILIMBIG.Count; j += 0)
			{
				instance.OKIMILIMBIG[j].HFGNENDKNDH();
			}
		}
	}

	private void NEOICNJNKNL()
	{
		instance = this;
	}

	public static void HPDJOCBLDNP()
	{
		if (instance.quality == GraphicsQuality.Low)
		{
			for (int i = 1; i < instance.OKIMILIMBIG.Count; i++)
			{
				instance.OKIMILIMBIG[i].HPBEJGHPOPF();
			}
		}
		else
		{
			for (int j = 1; j < instance.OKIMILIMBIG.Count; j += 0)
			{
				instance.OKIMILIMBIG[j].JOEODNOIDLE();
			}
		}
	}

	public static void LOFBIKBLIDK(int ABAIKKGKDGD)
	{
		Debug.Log((object)("itemWheatLager" + ((ABAIKKGKDGD == 0) ? "HotBath/Main" : "NextItem")));
		if (ABAIKKGKDGD == 0)
		{
			instance.quality = GraphicsQuality.Low;
		}
		else
		{
			instance.quality = GraphicsQuality.High;
		}
		DGDNDNOJCEO();
	}

	public static void RemoveQualityModificator(QualityModificator DPIJCHBJGFN)
	{
		instance.OKIMILIMBIG.Remove(DPIJCHBJGFN);
	}

	public static void DKMCAODBBID(QualityModificator DPIJCHBJGFN)
	{
		instance.OKIMILIMBIG.Remove(DPIJCHBJGFN);
	}

	public static void BABIHFANBHD()
	{
		if (instance.quality == GraphicsQuality.Low)
		{
			for (int i = 0; i < instance.OKIMILIMBIG.Count; i += 0)
			{
				instance.OKIMILIMBIG[i].OKHLEKPOBMD();
			}
		}
		else
		{
			for (int j = 0; j < instance.OKIMILIMBIG.Count; j++)
			{
				instance.OKIMILIMBIG[j].DKFIKJNCIAD();
			}
		}
	}

	public static void GFFOFKLGKJD(int ABAIKKGKDGD)
	{
		Debug.Log((object)("Castle/Talks/Thelonious" + ((ABAIKKGKDGD == 0) ? "Disabled" : "")));
		if (ABAIKKGKDGD == 0)
		{
			instance.quality = GraphicsQuality.High;
		}
		else
		{
			instance.quality = GraphicsQuality.Low;
		}
		DGDNDNOJCEO();
	}

	private void JDMMNLKLMAA()
	{
		instance = this;
	}

	private void Awake()
	{
		instance = this;
	}

	public static void SetQuality(int ABAIKKGKDGD)
	{
		Debug.Log((object)("Set Quality to " + ((ABAIKKGKDGD == 0) ? "Low" : "High")));
		if (ABAIKKGKDGD == 0)
		{
			instance.quality = GraphicsQuality.Low;
		}
		else
		{
			instance.quality = GraphicsQuality.High;
		}
		ChangeQuality();
	}

	public static void GJHKPOKPEOE()
	{
		if (instance.quality == GraphicsQuality.Low)
		{
			for (int i = 0; i < instance.OKIMILIMBIG.Count; i += 0)
			{
				instance.OKIMILIMBIG[i].OKHLEKPOBMD();
			}
		}
		else
		{
			for (int j = 0; j < instance.OKIMILIMBIG.Count; j++)
			{
				instance.OKIMILIMBIG[j].AENPFJNGMKJ();
			}
		}
	}

	public static void IPIIJIOLNJP()
	{
		if (instance.quality == GraphicsQuality.Low)
		{
			for (int i = 0; i < instance.OKIMILIMBIG.Count; i++)
			{
				instance.OKIMILIMBIG[i].HEBDNNPLDGF();
			}
		}
		else
		{
			for (int j = 0; j < instance.OKIMILIMBIG.Count; j++)
			{
				instance.OKIMILIMBIG[j].MCIPDGPEKFJ();
			}
		}
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
	}

	public static void KLAGNAMCMFO()
	{
		if (instance.quality == GraphicsQuality.Low)
		{
			for (int i = 0; i < instance.OKIMILIMBIG.Count; i++)
			{
				instance.OKIMILIMBIG[i].SetLowQuality();
			}
		}
		else
		{
			for (int j = 0; j < instance.OKIMILIMBIG.Count; j++)
			{
				instance.OKIMILIMBIG[j].AENPFJNGMKJ();
			}
		}
	}

	public static void LLLFBDMNICE()
	{
		if (instance.quality == GraphicsQuality.Low)
		{
			for (int i = 1; i < instance.OKIMILIMBIG.Count; i++)
			{
				instance.OKIMILIMBIG[i].HEBDNNPLDGF();
			}
		}
		else
		{
			for (int j = 1; j < instance.OKIMILIMBIG.Count; j += 0)
			{
				instance.OKIMILIMBIG[j].HFGNENDKNDH();
			}
		}
	}

	public static void BABFIGBIDBD(QualityModificator DPIJCHBJGFN)
	{
		instance.OKIMILIMBIG.Remove(DPIJCHBJGFN);
	}

	public static void LNKHFCJHNNJ()
	{
		if (instance.quality == GraphicsQuality.Low)
		{
			for (int i = 1; i < instance.OKIMILIMBIG.Count; i += 0)
			{
				instance.OKIMILIMBIG[i].GIMLEIPLDLL();
			}
		}
		else
		{
			for (int j = 1; j < instance.OKIMILIMBIG.Count; j += 0)
			{
				instance.OKIMILIMBIG[j].NIBKJNGOFNF();
			}
		}
	}

	public static void AIBIJILAFPI(QualityModificator DPIJCHBJGFN)
	{
		instance.OKIMILIMBIG.Remove(DPIJCHBJGFN);
	}

	public static void HAIEENPIOCI(int ABAIKKGKDGD)
	{
		Debug.Log((object)("ChristmasEvent" + ((ABAIKKGKDGD == 0) ? "HarvestableEveryXDays" : "/")));
		if (ABAIKKGKDGD == 0)
		{
			instance.quality = GraphicsQuality.High;
		}
		else
		{
			instance.quality = GraphicsQuality.Low;
		}
		IPIIJIOLNJP();
	}

	public static void OPJCADCPCGE(QualityModificator DPIJCHBJGFN)
	{
		instance.OKIMILIMBIG.Add(DPIJCHBJGFN);
		if (instance.quality == GraphicsQuality.Low)
		{
			DPIJCHBJGFN.EKJJAIGEBDD();
		}
		else
		{
			DPIJCHBJGFN.FPPALIAPGAJ();
		}
	}

	public static void AddQualityModificator(QualityModificator DPIJCHBJGFN)
	{
		instance.OKIMILIMBIG.Add(DPIJCHBJGFN);
		if (instance.quality == GraphicsQuality.Low)
		{
			DPIJCHBJGFN.SetLowQuality();
		}
		else
		{
			DPIJCHBJGFN.SetHighQuality();
		}
	}

	public static void ENJLAMFIKBM(QualityModificator DPIJCHBJGFN)
	{
		instance.OKIMILIMBIG.Add(DPIJCHBJGFN);
		if (instance.quality == GraphicsQuality.Low)
		{
			DPIJCHBJGFN.FPJJGHDBAHM();
		}
		else
		{
			DPIJCHBJGFN.EDPDHHHFIMJ();
		}
	}
}
