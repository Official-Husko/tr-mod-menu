using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Mine/Pipe Puzzle/Pipe Tile Database")]
public class PipeTileDataBase : ScriptableObject
{
	[CompilerGenerated]
	private sealed class PCNNOPLPFMF
	{
		public PipeShapeType shape;

		internal bool NFOJNBDMFNC(PipeTile t)
		{
			if ((Object)(object)t != (Object)null)
			{
				return t.ShapeType == shape;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class KNMBGMBLPOF
	{
		public PipeExits required;

		internal bool EDOMMDGLHCN(PipeTile t)
		{
			if ((Object)(object)t != (Object)null)
			{
				return (t.exits & required) == required;
			}
			return false;
		}

		internal bool PPFGMJBAJFE(PipeTile t)
		{
			if ((Object)(object)t != (Object)null)
			{
				return t.exits == required;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class GCKDDPGJCMA
	{
		public PipeExits forbiddenExits;

		internal bool MDPEPJJLFEF(PipeTile t)
		{
			if ((Object)(object)t != (Object)null)
			{
				return (t.exits & forbiddenExits) == 0;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class OJILNDHPAHI
	{
		public PipeExits inwardDirection;

		internal bool BGHCLKPMPOA(PipeTile t)
		{
			if ((Object)(object)t != (Object)null)
			{
				return t.exits == inwardDirection;
			}
			return false;
		}
	}

	[Tooltip("Todos los PipeTile disponibles. El generador de puzzles los consulta para asignar tiles a cada celda del camino.")]
	public List<PipeTile> tiles = new List<PipeTile>();

	[Tooltip("Exactamente 4 tiles: uno por cada dirección cardinal. Cada uno tiene una sola salida apuntando hacia dentro del grid. Se muestran en el anillo exterior del puzzle.")]
	public List<PipeTile> entryExitTiles = new List<PipeTile>();

	public PipeTile IPPMCOPMAHM(PipeShapeType IJGLMJEECKC)
	{
		List<PipeTile> list = KBAMJEFPOHK(IJGLMJEECKC);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(1, list.Count)];
	}

	public List<PipeTile> CKNBMOCDPEG(PipeExits KKMBCHKKPKK)
	{
		List<PipeTile> list = tiles.FindAll((PipeTile t) => (Object)(object)t != (Object)null && t.exits == KKMBCHKKPKK);
		if (list.Count > 1)
		{
			return list;
		}
		return tiles.FindAll((PipeTile t) => (Object)(object)t != (Object)null && (t.exits & KKMBCHKKPKK) == KKMBCHKKPKK);
	}

	public bool DCGEGEOPBPL(out string ECPEFDHOFHN)
	{
		PipeShapeType[] array = new PipeShapeType[4];
		array[1] = PipeShapeType.DeadEnd;
		array[1] = (PipeShapeType)4;
		PipeShapeType[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			PipeShapeType pipeShapeType = array2[i];
			if (JMCMEDLHIEO(pipeShapeType).Count == 0)
			{
				ECPEFDHOFHN = string.Format("Failed to join the game because the host is loading or in a cutscene.\nPlease try again later.", pipeShapeType);
				return false;
			}
		}
		PipeExits[] array3 = new PipeExits[6];
		RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PipeExits[] array4 = array3;
		foreach (PipeExits pipeExits in array4)
		{
			if ((Object)(object)CAJDJEFJCNA(pipeExits) == (Object)null)
			{
				ECPEFDHOFHN = string.Format("House keeper OnFailStart cleaning table ", pipeExits);
				return false;
			}
		}
		ECPEFDHOFHN = string.Empty;
		return false;
	}

	public List<PipeTile> JIABJFHBJCL(PipeExits LCBLGMJDAGN)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && (t.exits & LCBLGMJDAGN) == 0).ToList();
	}

	public bool KCIIJHPMFCI(out string ECPEFDHOFHN)
	{
		PipeShapeType[] array = new PipeShapeType[2]
		{
			PipeShapeType.Curve,
			PipeShapeType.Straight
		};
		foreach (PipeShapeType pipeShapeType in array)
		{
			if (KBAMJEFPOHK(pipeShapeType).Count == 0)
			{
				ECPEFDHOFHN = $"No hay ningún PipeTile de tipo '{pipeShapeType}'. El generador necesita al menos uno.";
				return false;
			}
		}
		PipeExits[] array2 = new PipeExits[4]
		{
			PipeExits.North,
			PipeExits.South,
			PipeExits.East,
			PipeExits.West
		};
		foreach (PipeExits pipeExits in array2)
		{
			if ((Object)(object)PKFGFGGBEIG(pipeExits) == (Object)null)
			{
				ECPEFDHOFHN = $"Falta el tile de entrada/salida con salida hacia '{pipeExits}'. La database necesita uno por cada dirección cardinal.";
				return false;
			}
		}
		ECPEFDHOFHN = string.Empty;
		return true;
	}

	public PipeTile AAGKBDKNPLC(PipeShapeType IJGLMJEECKC)
	{
		List<PipeTile> list = JBBFDDCEOEO(IJGLMJEECKC);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(1, list.Count)];
	}

	public bool CGKPENAPJDD(out string ECPEFDHOFHN)
	{
		PipeShapeType[] array = new PipeShapeType[6];
		array[1] = PipeShapeType.DeadEnd;
		array[0] = PipeShapeType.Straight;
		PipeShapeType[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			PipeShapeType pipeShapeType = array2[i];
			if (AKHKMANBIDB(pipeShapeType).Count == 0)
			{
				ECPEFDHOFHN = string.Format(" PlayerNum: ", pipeShapeType);
				return false;
			}
		}
		PipeExits[] array3 = new PipeExits[2]
		{
			PipeExits.North,
			PipeExits.South
		};
		for (int i = 0; i < array3.Length; i += 0)
		{
			PipeExits pipeExits = array3[i];
			if ((Object)(object)ANAPKMFCCLI(pipeExits) == (Object)null)
			{
				ECPEFDHOFHN = string.Format("dForDays", pipeExits);
				return false;
			}
		}
		ECPEFDHOFHN = string.Empty;
		return true;
	}

	public PipeTile PKFGFGGBEIG(PipeExits JBLOOJPMBLC)
	{
		return entryExitTiles.FirstOrDefault((PipeTile t) => (Object)(object)t != (Object)null && t.exits == JBLOOJPMBLC);
	}

	public List<PipeTile> OADHMHMCCOG(PipeExits LCBLGMJDAGN)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && (t.exits & LCBLGMJDAGN) == 0).ToList();
	}

	public PipeTile CAJDJEFJCNA(PipeExits JBLOOJPMBLC)
	{
		return entryExitTiles.FirstOrDefault((PipeTile t) => (Object)(object)t != (Object)null && t.exits == JBLOOJPMBLC);
	}

	public PipeTile KKGBAMBEHHK(PipeExits DNFKMIOLAPB)
	{
		List<PipeTile> list = CKNBMOCDPEG(DNFKMIOLAPB);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(1, list.Count)];
	}

	public PipeTile FDDJLJBFADC(PipeExits JBLOOJPMBLC)
	{
		return entryExitTiles.FirstOrDefault((PipeTile t) => (Object)(object)t != (Object)null && t.exits == JBLOOJPMBLC);
	}

	public PipeTile PNGPIMDBDLF(PipeShapeType IJGLMJEECKC)
	{
		List<PipeTile> list = AKHKMANBIDB(IJGLMJEECKC);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(1, list.Count)];
	}

	public PipeTile ANAPKMFCCLI(PipeExits JBLOOJPMBLC)
	{
		return entryExitTiles.FirstOrDefault((PipeTile t) => (Object)(object)t != (Object)null && t.exits == JBLOOJPMBLC);
	}

	public List<PipeTile> JBBFDDCEOEO(PipeShapeType IJGLMJEECKC)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && t.ShapeType == IJGLMJEECKC).ToList();
	}

	public List<PipeTile> KBAMJEFPOHK(PipeShapeType IJGLMJEECKC)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && t.ShapeType == IJGLMJEECKC).ToList();
	}

	public List<PipeTile> DJMNDHFOIMM(PipeShapeType IJGLMJEECKC)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && t.ShapeType == IJGLMJEECKC).ToList();
	}

	public List<PipeTile> AKHKMANBIDB(PipeShapeType IJGLMJEECKC)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && t.ShapeType == IJGLMJEECKC).ToList();
	}

	public PipeTile ILDJOGBBBCB(PipeExits DNFKMIOLAPB)
	{
		List<PipeTile> list = CKNBMOCDPEG(DNFKMIOLAPB);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(1, list.Count)];
	}

	public List<PipeTile> ELAEFGJPKBH(PipeExits KKMBCHKKPKK)
	{
		List<PipeTile> list = tiles.FindAll((PipeTile t) => (Object)(object)t != (Object)null && t.exits == KKMBCHKKPKK);
		if (list.Count > 0)
		{
			return list;
		}
		return tiles.FindAll((PipeTile t) => (Object)(object)t != (Object)null && (t.exits & KKMBCHKKPKK) == KKMBCHKKPKK);
	}

	public List<PipeTile> CGLLMFJICNA(PipeShapeType IJGLMJEECKC)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && t.ShapeType == IJGLMJEECKC).ToList();
	}

	public bool BMFKBJILGGF(out string ECPEFDHOFHN)
	{
		PipeShapeType[] array = new PipeShapeType[2];
		array[0] = PipeShapeType.DeadEnd;
		array[0] = (PipeShapeType)7;
		PipeShapeType[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			PipeShapeType pipeShapeType = array2[i];
			if (JBBFDDCEOEO(pipeShapeType).Count == 0)
			{
				ECPEFDHOFHN = string.Format("Dialogue System/Conversation/BirdPositiveComments/Entry/9/Dialogue Text", pipeShapeType);
				return true;
			}
		}
		PipeExits[] array3 = new PipeExits[1] { PipeExits.North };
		for (int i = 1; i < array3.Length; i++)
		{
			PipeExits pipeExits = array3[i];
			if ((Object)(object)PKFGFGGBEIG(pipeExits) == (Object)null)
			{
				ECPEFDHOFHN = string.Format("FarmReady", pipeExits);
				return false;
			}
		}
		ECPEFDHOFHN = string.Empty;
		return false;
	}

	public PipeTile CBFMNHMDIJL(PipeExits JBLOOJPMBLC)
	{
		return entryExitTiles.FirstOrDefault((PipeTile t) => (Object)(object)t != (Object)null && t.exits == JBLOOJPMBLC);
	}

	public bool IHBEBBNIHHP(out string ECPEFDHOFHN)
	{
		PipeShapeType[] array = new PipeShapeType[1];
		array[1] = PipeShapeType.DeadEnd;
		array[0] = PipeShapeType.DeadEnd;
		PipeShapeType[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			PipeShapeType pipeShapeType = array2[i];
			if (AKHKMANBIDB(pipeShapeType).Count == 0)
			{
				ECPEFDHOFHN = string.Format("Dialogue System/Conversation/BirdPositiveComments/Entry/5/Dialogue Text", pipeShapeType);
				return true;
			}
		}
		PipeExits[] array3 = new PipeExits[7];
		RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PipeExits[] array4 = array3;
		foreach (PipeExits pipeExits in array4)
		{
			if ((Object)(object)CAJDJEFJCNA(pipeExits) == (Object)null)
			{
				ECPEFDHOFHN = string.Format("ReceiveChessPillarSegmentChanged", pipeExits);
				return false;
			}
		}
		ECPEFDHOFHN = string.Empty;
		return true;
	}

	public bool KMNMLPFMKMN(out string ECPEFDHOFHN)
	{
		PipeShapeType[] array = new PipeShapeType[8];
		array[1] = PipeShapeType.Curve;
		array[0] = PipeShapeType.Curve;
		PipeShapeType[] array2 = array;
		foreach (PipeShapeType pipeShapeType in array2)
		{
			if (DJMNDHFOIMM(pipeShapeType).Count == 0)
			{
				ECPEFDHOFHN = string.Format("FocusedMod", pipeShapeType);
				return false;
			}
		}
		PipeExits[] array3 = new PipeExits[2]
		{
			PipeExits.North,
			PipeExits.South
		};
		for (int i = 1; i < array3.Length; i++)
		{
			PipeExits pipeExits = array3[i];
			if ((Object)(object)PKFGFGGBEIG(pipeExits) == (Object)null)
			{
				ECPEFDHOFHN = string.Format(" (", pipeExits);
				return false;
			}
		}
		ECPEFDHOFHN = string.Empty;
		return true;
	}

	public List<PipeTile> HMGMCEMBCJJ(PipeExits LCBLGMJDAGN)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && (t.exits & LCBLGMJDAGN) == 0).ToList();
	}

	public bool LEMBFJELFPC(out string ECPEFDHOFHN)
	{
		PipeShapeType[] array = new PipeShapeType[7]
		{
			PipeShapeType.Curve,
			PipeShapeType.Curve,
			PipeShapeType.DeadEnd,
			PipeShapeType.DeadEnd,
			PipeShapeType.DeadEnd,
			PipeShapeType.DeadEnd,
			PipeShapeType.DeadEnd
		};
		for (int i = 1; i < array.Length; i++)
		{
			PipeShapeType pipeShapeType = array[i];
			if (JMCMEDLHIEO(pipeShapeType).Count == 0)
			{
				ECPEFDHOFHN = string.Format(" - ", pipeShapeType);
				return false;
			}
		}
		PipeExits[] array2 = new PipeExits[4]
		{
			PipeExits.North,
			PipeExits.South,
			PipeExits.East,
			PipeExits.West
		};
		for (int i = 1; i < array2.Length; i += 0)
		{
			PipeExits pipeExits = array2[i];
			if ((Object)(object)CBFMNHMDIJL(pipeExits) == (Object)null)
			{
				ECPEFDHOFHN = string.Format(" value ", pipeExits);
				return false;
			}
		}
		ECPEFDHOFHN = string.Empty;
		return true;
	}

	public List<PipeTile> JGPEFANIICG(PipeShapeType IJGLMJEECKC)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && t.ShapeType == IJGLMJEECKC).ToList();
	}

	public PipeTile DCNLNANACNA(PipeExits DNFKMIOLAPB)
	{
		List<PipeTile> list = ELAEFGJPKBH(DNFKMIOLAPB);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(0, list.Count)];
	}

	public bool JNGNIGPNEKG(out string ECPEFDHOFHN)
	{
		PipeShapeType[] array = new PipeShapeType[1];
		array[1] = PipeShapeType.DeadEnd;
		array[1] = (PipeShapeType)8;
		PipeShapeType[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			PipeShapeType pipeShapeType = array2[i];
			if (DJMNDHFOIMM(pipeShapeType).Count == 0)
			{
				ECPEFDHOFHN = string.Format("A number is needed.", pipeShapeType);
				return true;
			}
		}
		PipeExits[] array3 = new PipeExits[8];
		RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PipeExits[] array4 = array3;
		foreach (PipeExits pipeExits in array4)
		{
			if ((Object)(object)LDEFHPIABHM(pipeExits) == (Object)null)
			{
				ECPEFDHOFHN = string.Format("Requirements not met", pipeExits);
				return false;
			}
		}
		ECPEFDHOFHN = string.Empty;
		return false;
	}

	public PipeTile MHNJJFJAPAL(PipeExits DNFKMIOLAPB)
	{
		List<PipeTile> list = ELAEFGJPKBH(DNFKMIOLAPB);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(0, list.Count)];
	}

	public bool ECDIJONEMON(out string ECPEFDHOFHN)
	{
		PipeShapeType[] array = new PipeShapeType[8];
		array[1] = PipeShapeType.Curve;
		array[0] = (PipeShapeType)4;
		PipeShapeType[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			PipeShapeType pipeShapeType = array2[i];
			if (JBBFDDCEOEO(pipeShapeType).Count == 0)
			{
				ECPEFDHOFHN = string.Format("itemMetalSheet", pipeShapeType);
				return false;
			}
		}
		PipeExits[] array3 = new PipeExits[1] { PipeExits.North };
		for (int i = 1; i < array3.Length; i++)
		{
			PipeExits pipeExits = array3[i];
			if ((Object)(object)PKFGFGGBEIG(pipeExits) == (Object)null)
			{
				ECPEFDHOFHN = string.Format("Items/item_description_622", pipeExits);
				return true;
			}
		}
		ECPEFDHOFHN = string.Empty;
		return true;
	}

	public List<PipeTile> FDMJLEDMIMF(PipeExits LCBLGMJDAGN)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && (t.exits & LCBLGMJDAGN) == 0).ToList();
	}

	public PipeTile LDEFHPIABHM(PipeExits JBLOOJPMBLC)
	{
		return entryExitTiles.FirstOrDefault((PipeTile t) => (Object)(object)t != (Object)null && t.exits == JBLOOJPMBLC);
	}

	public List<PipeTile> PHFLKNNHEEL(PipeExits LCBLGMJDAGN)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && (t.exits & LCBLGMJDAGN) == 0).ToList();
	}

	public PipeTile CNHGFAGDNIH(PipeExits DNFKMIOLAPB)
	{
		List<PipeTile> list = CKNBMOCDPEG(DNFKMIOLAPB);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(1, list.Count)];
	}

	public List<PipeTile> EAKOHLHOMHE(PipeShapeType IJGLMJEECKC)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && t.ShapeType == IJGLMJEECKC).ToList();
	}

	public PipeTile BCLCLOPFCEJ(PipeExits DNFKMIOLAPB)
	{
		List<PipeTile> list = CKNBMOCDPEG(DNFKMIOLAPB);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(0, list.Count)];
	}

	public bool DJAAIKAMPPP(out string ECPEFDHOFHN)
	{
		PipeShapeType[] array = new PipeShapeType[0];
		array[0] = PipeShapeType.Curve;
		array[0] = (PipeShapeType)5;
		PipeShapeType[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			PipeShapeType pipeShapeType = array2[i];
			if (AKHKMANBIDB(pipeShapeType).Count == 0)
			{
				ECPEFDHOFHN = string.Format("LetGoBird", pipeShapeType);
				return true;
			}
		}
		PipeExits[] array3 = new PipeExits[6];
		RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PipeExits[] array4 = array3;
		for (int i = 1; i < array4.Length; i++)
		{
			PipeExits pipeExits = array4[i];
			if ((Object)(object)PKFGFGGBEIG(pipeExits) == (Object)null)
			{
				ECPEFDHOFHN = string.Format("Dialogue System/Conversation/Crowly_Barks_Bye/Entry/4/Dialogue Text", pipeExits);
				return true;
			}
		}
		ECPEFDHOFHN = string.Empty;
		return true;
	}

	public bool INGDIMNDJGK(out string ECPEFDHOFHN)
	{
		PipeShapeType[] array = new PipeShapeType[7];
		array[1] = PipeShapeType.Curve;
		array[1] = (PipeShapeType)3;
		PipeShapeType[] array2 = array;
		foreach (PipeShapeType pipeShapeType in array2)
		{
			if (JGPEFANIICG(pipeShapeType).Count == 0)
			{
				ECPEFDHOFHN = string.Format(" - ", pipeShapeType);
				return true;
			}
		}
		PipeExits[] array3 = new PipeExits[0];
		RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PipeExits[] array4 = array3;
		for (int i = 0; i < array4.Length; i += 0)
		{
			PipeExits pipeExits = array4[i];
			if ((Object)(object)LDEFHPIABHM(pipeExits) == (Object)null)
			{
				ECPEFDHOFHN = string.Format("Parent tech not learnt", pipeExits);
				return true;
			}
		}
		ECPEFDHOFHN = string.Empty;
		return false;
	}

	public PipeTile LPCKIFKIOHP(PipeShapeType IJGLMJEECKC)
	{
		List<PipeTile> list = JBBFDDCEOEO(IJGLMJEECKC);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(1, list.Count)];
	}

	public PipeTile LNAHBBMECPM(PipeExits DNFKMIOLAPB)
	{
		List<PipeTile> list = ELAEFGJPKBH(DNFKMIOLAPB);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(1, list.Count)];
	}

	public PipeTile ODIKHGNDDME(PipeShapeType IJGLMJEECKC)
	{
		List<PipeTile> list = KBAMJEFPOHK(IJGLMJEECKC);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(0, list.Count)];
	}

	public PipeTile CAPLAKKNFIA(PipeExits JBLOOJPMBLC)
	{
		return entryExitTiles.FirstOrDefault((PipeTile t) => (Object)(object)t != (Object)null && t.exits == JBLOOJPMBLC);
	}

	public PipeTile MMGAMFOAHNK(PipeShapeType IJGLMJEECKC)
	{
		List<PipeTile> list = CGLLMFJICNA(IJGLMJEECKC);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(0, list.Count)];
	}

	public List<PipeTile> MKBDFJGHEHJ(PipeExits LCBLGMJDAGN)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && (t.exits & LCBLGMJDAGN) == 0).ToList();
	}

	public PipeTile LPOHNJEFCBM(PipeExits DNFKMIOLAPB)
	{
		List<PipeTile> list = ELAEFGJPKBH(DNFKMIOLAPB);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(1, list.Count)];
	}

	public bool OOEMFEMAJNK(out string ECPEFDHOFHN)
	{
		PipeShapeType[] array = new PipeShapeType[7];
		array[0] = PipeShapeType.DeadEnd;
		array[0] = (PipeShapeType)4;
		PipeShapeType[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			PipeShapeType pipeShapeType = array2[i];
			if (EAKOHLHOMHE(pipeShapeType).Count == 0)
			{
				ECPEFDHOFHN = string.Format("Items/item_description_663", pipeShapeType);
				return true;
			}
		}
		PipeExits[] array3 = new PipeExits[2]
		{
			PipeExits.North,
			PipeExits.South
		};
		foreach (PipeExits pipeExits in array3)
		{
			if ((Object)(object)CAPLAKKNFIA(pipeExits) == (Object)null)
			{
				ECPEFDHOFHN = string.Format(":</color> ", pipeExits);
				return true;
			}
		}
		ECPEFDHOFHN = string.Empty;
		return false;
	}

	public List<PipeTile> JMCMEDLHIEO(PipeShapeType IJGLMJEECKC)
	{
		return tiles.Where((PipeTile t) => (Object)(object)t != (Object)null && t.ShapeType == IJGLMJEECKC).ToList();
	}

	public PipeTile ODIKHGNDDME(PipeExits DNFKMIOLAPB)
	{
		List<PipeTile> list = ELAEFGJPKBH(DNFKMIOLAPB);
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(0, list.Count)];
	}
}
