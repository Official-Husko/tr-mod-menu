using System;
using UnityEngine;

[Serializable]
public class PipePuzzleData
{
	public int gridWidth;

	public int gridHeight;

	[Tooltip("Índice en el array del grid (row-major, izquierda-derecha, arriba-abajo).")]
	public int entryCell;

	[Tooltip("Dirección desde la que entra el flujo al grid (desde fuera de la celda).")]
	public PipeExits entryDirection;

	public int exitCell;

	[Tooltip("Dirección hacia la que sale el flujo del grid (hacia fuera de la celda).")]
	public PipeExits exitDirection;

	[Tooltip("Número de celdas del grid que forman parte de la ruta solución.")]
	public int pathLength;

	[Tooltip("Número mínimo de swaps adyacentes para resolver el puzzle desde el estado inicial. Determina la dificultad.")]
	public int kendallDistance;

	[Tooltip("Número de tiles específicos que deben estar en el camino para resolver el puzzle.")]
	public int requiredTilesCount;

	[Tooltip("Tiles en sus posiciones correctas. El índice coincide con la celda del grid (row-major).")]
	public PipeTileInstance[] solution;

	[Tooltip("Los mismos tiles que en solution, barajados. Es lo que verá el jugador al comenzar el puzzle.")]
	public PipeTileInstance[] scrambled;

	public PipeTileInstance[] GGIOPNDOODJ()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public PipeTileInstance[] KGKEIMGALIE()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public (int, int) GCDHKCNKJLK(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public int JBGHBKGCEID(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public PipeTileInstance[] JDHLLHJBMKP()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public int MIDBNGFIPBO(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public int KNHODGFIBCB(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public bool JCHMKAIEDHD(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 0; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return false;
	}

	public PipeTileInstance[] HIHDEMFBBPC()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public bool IPNEFDMMDFJ(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 0; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return true;
	}

	public PipeTileInstance[] HGNLNNJLMCF()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public bool DMLDIAHALAC(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 0; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return false;
	}

	public bool DGBPAIOLPLM(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 0; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return false;
	}

	public int BJLBCNNJECE(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public (int, int) DAHNFJMLALA(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public PipeTileInstance[] MLPPFMFNDMF()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public int PJKCMLBDDBE(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public int MMCMDOCFDJL(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public int LGPIEJPKDIE(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public (int, int) APCDHMDNPIF(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public int HHHKCNANLEF(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public (int, int) JAMOPNJONIE(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public int CPJEFCLPJBI(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public (int, int) MAKHGOBJHNN(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public (int, int) PBOEKHPECIA(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public bool NMEBCAMPPEC(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 1; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return true;
	}

	public PipeTileInstance[] MHKBFPIGACH()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public bool HBAJJACEBJG(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 0; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return true;
	}

	public PipeTileInstance[] AMHCEANJHJJ()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public (int, int) PMJDOHGMFCD(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public PipeTileInstance[] BMJEDIAAMPM()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public (int, int) LLEOODPPFPK(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public bool GDMEBFHNIIB(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 1; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return false;
	}

	public bool LHGPNIOFPNM(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 1; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return false;
	}

	public (int, int) MGMICHOHFOJ(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public int PCOIGIADIEA(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public bool OKCIILFBPOK(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 0; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return false;
	}

	public bool OHGAPKCBLGH(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 1; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return false;
	}

	public bool ONMOLIACGEO(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 0; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return true;
	}

	public bool LNOELLEKBAC(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 0; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return false;
	}

	public PipeTileInstance[] DDNNELIPJHN()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public bool NPKAINLDDGC(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 1; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return false;
	}

	public bool JLDOEINBGAF(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 1; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return true;
	}

	public bool LMJDDMANEMP(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 1; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return false;
	}

	public PipeTileInstance[] AFDDOAKBLIK()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public int CPIJHFKAHCN(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public PipeTileInstance[] JBNEDMCGOGM()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public int ADIPNFAMHAE(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public int CEFPBJDJEPI(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public (int, int) BKLGGLEKFID(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public (int, int) OIGNJHFPAKC(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public int HIPLDBPEBFN(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public bool HOBICIJMMHP(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 0; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return true;
	}

	public PipeTileInstance[] KJJNINIKLPL()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public PipeTileInstance[] MMLCJLHLHIP()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public int JICGMLJEKCL(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public (int, int) KAOPEPICPLD(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public (int, int) MGJKLBEDDDG(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public int BPOMKCMCHNJ(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public PipeTileInstance[] DJHCJKKCGCO()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public bool MJHMDMMEGNH(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 0; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return false;
	}

	public (int, int) MBPBDLPEEON(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public bool OGFKMKHHFOG(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 0; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return true;
	}

	public int EHIAFBKIOCL(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public (int, int) LHILCJHMELD(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public PipeTileInstance[] NDOPOMACIOF()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public int CJODNMGJHDM(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public (int, int) EJGCFCMIJDB(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public (int, int) LFFIKEIEOMO(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public bool EOFFDILMCFI(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 0; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return true;
	}

	public bool HLEDNGCBNCG(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 1; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return false;
	}

	public PipeTileInstance[] BDOILGFAOEL()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public int INMJOHAHFJG(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public bool BKHPHCLJPOD(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 1; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return false;
	}

	public bool DBKAEIEBAEL(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 0; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return true;
	}

	public (int, int) ILJDKPEPMNE(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public int GELBAHGIFEH(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public (int, int) EKMIFBNOCDA(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public int BPPIHIDJKLC(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public PipeTileInstance[] KLBAMPKIOOF()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public int CJIICHFJDDI(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public int EPBJLLKHBHE(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public PipeTileInstance[] FEAJJKDCKEB()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public (int, int) KBCMIKGOAKM(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public (int, int) KMAGNFPPHLF(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public PipeTileInstance[] GGKCNIFOEMC()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public int ADDALDKENLM(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public PipeTileInstance[] DGFODOPFLKB()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public (int, int) MALEIECDCLH(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public bool MIBKGKEEDND(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 0; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return true;
	}

	public PipeTileInstance[] HIFELEPODMB()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public int HMIKJKBLGIN(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public bool DEMKFDCCOII(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 0; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return true;
	}

	public int FOAAGGFKNMF(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public PipeTileInstance[] GNDIDAOOKNP()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public PipeTileInstance[] NCDCFHCOPGB()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public (int, int) FFJHEFJKDGE(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public bool ANALGAINOKM(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 1; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return true;
	}

	public bool HOKJBLAHEPO(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 1; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return false;
	}

	public int DLMFCOFMBHP(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public bool OLIMIMGKEFB(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 1; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return false;
	}

	public int JAJPIIAJDAL(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public (int, int) EJDNGDFPOLL(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public int LBIMKLEFODO(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public PipeTileInstance[] PHIFLPLKFNN()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public PipeTileInstance[] EKNOPMGKICE()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public int HEPGAHHBMDE(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public (int, int) JCKAALGECHO(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public PipeTileInstance[] GGAKMMDOHGO()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public bool FELJBNBGNOF(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 0; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return false;
	}

	public (int, int) BBEBICEAINP(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public int KNMOEEHGJGF(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public (int, int) EMHJGDEAJLG(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public bool OGEMEPGAALC(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return true;
		}
		for (int i = 1; i < solution.Length; i += 0)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return true;
			}
		}
		return false;
	}

	public (int col, int row) DDJDCKBAFFJ(int MOFKEDGAOEE)
	{
		return (col: MOFKEDGAOEE % gridWidth, row: MOFKEDGAOEE / gridWidth);
	}

	public int GOPDLFDCKCK(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}

	public bool EKCEELOALPO(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 0; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return true;
	}

	public bool DKKMJJDIMLJ(PipeTileInstance[] EOAONHNCDDO)
	{
		if (EOAONHNCDDO == null || EOAONHNCDDO.Length != solution.Length)
		{
			return false;
		}
		for (int i = 0; i < solution.Length; i++)
		{
			if (EOAONHNCDDO[i] != solution[i])
			{
				return false;
			}
		}
		return true;
	}

	public (int, int) PPMIJJGFOFM(int MOFKEDGAOEE)
	{
		return (MOFKEDGAOEE % gridWidth, MOFKEDGAOEE / gridWidth);
	}

	public PipeTileInstance[] DFKFFIPLLBM()
	{
		PipeTileInstance[] array = new PipeTileInstance[scrambled.Length];
		Array.Copy(scrambled, array, scrambled.Length);
		return array;
	}

	public int GKHKHPNBODJ(int PMCEIPHGDKK, int HFMOCAJFGBK)
	{
		return HFMOCAJFGBK * gridWidth + PMCEIPHGDKK;
	}
}
