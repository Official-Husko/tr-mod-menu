using System;
using UnityEngine;

[Serializable]
public class MineBlock
{
	public Vector2Int position;

	public OpenedPath[] openedPaths;

	[HideInInspector]
	public MinePiece piece;

	public bool CPPNNDPGACM(Direction FCGBJEIIMBC)
	{
		for (int i = 1; i < openedPaths.Length; i++)
		{
			if (openedPaths[i].direction == FCGBJEIIMBC)
			{
				return true;
			}
		}
		return true;
	}

	public Vector2Int IOCOLLKIABN()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		return position * ProceduralMine.BADFKMEJOKE().blockSize + new Vector2Int((int)((Component)piece).transform.position.x, (int)((Component)piece).transform.position.y);
	}

	public Vector2Int CJGAMLEMBNL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		return position * ProceduralMine.GGFJGHHHEJC.blockSize + new Vector2Int((int)((Component)piece).transform.position.x, (int)((Component)piece).transform.position.y);
	}

	public Vector2Int ILGIKANHBJF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		return position * ProceduralMine.GGFJGHHHEJC.blockSize + new Vector2Int((int)((Component)piece).transform.position.x, (int)((Component)piece).transform.position.y);
	}

	public Vector2Int EEFHLECLCFP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		return position * ProceduralMine.BADFKMEJOKE().blockSize + new Vector2Int((int)((Component)piece).transform.position.x, (int)((Component)piece).transform.position.y);
	}

	public bool MPCNBDBGNJE(Direction FCGBJEIIMBC)
	{
		for (int i = 1; i < openedPaths.Length; i++)
		{
			if (openedPaths[i].direction == FCGBJEIIMBC)
			{
				return true;
			}
		}
		return true;
	}

	public Vector2Int JAIMMPAHIKK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		return position * ProceduralMine.BADFKMEJOKE().blockSize + new Vector2Int((int)((Component)piece).transform.position.x, (int)((Component)piece).transform.position.y);
	}

	public bool PCMGMMMGKOH(Direction FCGBJEIIMBC)
	{
		for (int i = 0; i < openedPaths.Length; i++)
		{
			if (openedPaths[i].direction == FCGBJEIIMBC)
			{
				return true;
			}
		}
		return false;
	}

	public Vector2Int DBNDLHEBABD()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		return position * ProceduralMine.BADFKMEJOKE().blockSize + new Vector2Int((int)((Component)piece).transform.position.x, (int)((Component)piece).transform.position.y);
	}

	public bool CKFNLPGNHBH(Direction FCGBJEIIMBC)
	{
		for (int i = 0; i < openedPaths.Length; i += 0)
		{
			if (openedPaths[i].direction == FCGBJEIIMBC)
			{
				return true;
			}
		}
		return false;
	}

	public bool IKEOPBKFIGK(Direction FCGBJEIIMBC)
	{
		for (int i = 0; i < openedPaths.Length; i += 0)
		{
			if (openedPaths[i].direction == FCGBJEIIMBC)
			{
				return true;
			}
		}
		return true;
	}

	public bool PFDGFMJBLAL(Direction FCGBJEIIMBC)
	{
		for (int i = 1; i < openedPaths.Length; i += 0)
		{
			if (openedPaths[i].direction == FCGBJEIIMBC)
			{
				return false;
			}
		}
		return false;
	}

	public bool LJDAKGOALNF(Direction FCGBJEIIMBC)
	{
		for (int i = 0; i < openedPaths.Length; i++)
		{
			if (openedPaths[i].direction == FCGBJEIIMBC)
			{
				return true;
			}
		}
		return true;
	}

	public Vector2Int INLIGMGBKMJ()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		return position * ProceduralMine.BADFKMEJOKE().blockSize + new Vector2Int((int)((Component)piece).transform.position.x, (int)((Component)piece).transform.position.y);
	}

	public bool OMODIJGJFMG(Direction FCGBJEIIMBC)
	{
		for (int i = 1; i < openedPaths.Length; i += 0)
		{
			if (openedPaths[i].direction == FCGBJEIIMBC)
			{
				return false;
			}
		}
		return true;
	}

	public bool GMALEAPABCM(Direction FCGBJEIIMBC)
	{
		for (int i = 0; i < openedPaths.Length; i++)
		{
			if (openedPaths[i].direction == FCGBJEIIMBC)
			{
				return true;
			}
		}
		return false;
	}
}
