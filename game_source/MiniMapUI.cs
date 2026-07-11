using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MiniMapUI : MonoBehaviour
{
	private struct MICKLOOGJCO
	{
		public RectTransform rectTransform;

		public Image image;
	}

	[SerializeField]
	private Vector2 offset;

	[SerializeField]
	private GameObject miniMapTile;

	[SerializeField]
	private GameObject tilesParent;

	[SerializeField]
	private Vector2Int initialOffset = new Vector2Int(-80, -80);

	[SerializeField]
	private int tileSize = 12;

	[SerializeField]
	private Image[] symbols;

	[SerializeField]
	private Image[] states;

	[SerializeField]
	private TextMeshProUGUI floorText;

	[SerializeField]
	private Sprite floor;

	[SerializeField]
	private Sprite wall;

	[SerializeField]
	private Sprite leftWall;

	[SerializeField]
	private Sprite rightWall;

	[SerializeField]
	private Sprite leftRightWall;

	[SerializeField]
	private Sprite door;

	[SerializeField]
	private Sprite halfWall;

	[SerializeField]
	private Sprite halfLeftWall;

	[SerializeField]
	private Sprite halfRightWall;

	[SerializeField]
	private Sprite halfLeftRightWall;

	[SerializeField]
	private Sprite edgeMiddle;

	[SerializeField]
	private Sprite edgeUp;

	[SerializeField]
	private Sprite edgeMiddleUp;

	[SerializeField]
	private Sprite edgeHalfRight;

	[SerializeField]
	private Sprite edgeHalfLeft;

	[SerializeField]
	private Sprite edgeLR;

	[SerializeField]
	private Sprite edgeLHR;

	[SerializeField]
	private Sprite edgeLHPR;

	[SerializeField]
	private Sprite edgeHLR;

	[SerializeField]
	private Sprite edgeHRU;

	[SerializeField]
	private Sprite edgeHPLR;

	[SerializeField]
	private Sprite edgeHLHR;

	[SerializeField]
	private Sprite edgeHLHRU;

	[SerializeField]
	private Sprite edgeHLRU;

	[SerializeField]
	private Sprite edgeLHRU;

	[SerializeField]
	private Sprite edgeHPLHPR;

	[SerializeField]
	private Sprite edgeHPLHR;

	[SerializeField]
	private Sprite edgeHLHPR;

	[SerializeField]
	private Sprite edgeHPLPR;

	[SerializeField]
	private Sprite edgePLHPR;

	[SerializeField]
	private Sprite edgeLPR;

	[SerializeField]
	private Sprite edgePLR;

	[SerializeField]
	private Sprite edgeHLPR;

	[SerializeField]
	private Sprite edgePLHR;

	[SerializeField]
	private Sprite edgePL;

	[SerializeField]
	private Sprite edgePR;

	[SerializeField]
	private Sprite edgePLPR;

	[SerializeField]
	private Sprite edgeHPL;

	[SerializeField]
	private Sprite edgeHPR;

	[SerializeField]
	private Sprite edgeHL;

	[SerializeField]
	private Sprite edgeHR;

	[SerializeField]
	private Sprite edgeL;

	[SerializeField]
	private Sprite edgeR;

	[SerializeField]
	private Sprite edgeLRU;

	[SerializeField]
	private Sprite edgeLU;

	[SerializeField]
	private Sprite edgeRU;

	[SerializeField]
	private Sprite edgeHLU;

	[SerializeField]
	private Sprite edgeLRUM;

	[SerializeField]
	private Sprite edgeLUM;

	[SerializeField]
	private Sprite edgeRUM;

	[SerializeField]
	private Sprite edgeLRM;

	[SerializeField]
	private Sprite edgeRM;

	[SerializeField]
	private Sprite edgeLM;

	[SerializeField]
	private Sprite edgePRM;

	[SerializeField]
	private Sprite edgePLM;

	[SerializeField]
	private Sprite edgePLPRM;

	[SerializeField]
	private Sprite edgePLRM;

	[SerializeField]
	private Sprite edgeLPRM;

	[SerializeField]
	private Color highlightedColor;

	[SerializeField]
	private Color notValidColor;

	private List<Vector2Int> KGFCADKODFK = new List<Vector2Int>();

	private Vector3Int[] HAKPCIKJLNM;

	private List<MICKLOOGJCO> MBMAJABDGNE = new List<MICKLOOGJCO>();

	private List<MICKLOOGJCO> PAJJHHHKBMN = new List<MICKLOOGJCO>();

	private MICKLOOGJCO FJOELJMKEBH;

	private bool BGJFKBFPEML;

	private bool OOIDGPJAEPC;

	private bool IMAGDMGEKLH;

	private bool FANOBLAFEJF;

	private bool OGJOGEEOPEN;

	private bool HBAMCFOIJKB;

	private bool KEIBLGGEJAL;

	private bool OHKACKDCLHP;

	private bool NNFAMJBFKMF;

	private bool CILJDFNHIAD;

	private bool FHBGEDFPEOL;

	private bool LLJIDCBNKCM;

	private bool MBCGOKOIGCL;

	public void POPIKDPOKPA()
	{
		HAKPCIKJLNM = Utils.JGEPCPFJANP(Location.Tavern).HNLGGMFFFIM();
	}

	private void OPHOPNOIEHM(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC, Vector3 LDHICJGAADO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		IKCEGLLCPFK += LDHICJGAADO;
		AIJOOOIJEDC += Vector2Int.CeilToInt(Vector2.op_Implicit((float)tileSize * LDHICJGAADO));
		if (WorldGrid.PIOMBKLPIKB(IKCEGLLCPFK + new Vector3(0f, -1f)))
		{
			return;
		}
		for (int i = 0; i < KGFCADKODFK.Count; i++)
		{
			if (KGFCADKODFK[i] == AIJOOOIJEDC)
			{
				return;
			}
		}
		KGFCADKODFK.Add(AIJOOOIJEDC);
		CILJDFNHIAD = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(-1f, 1f));
		BGJFKBFPEML = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(-1f, -1f));
		IMAGDMGEKLH = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(-1f, -2f));
		FHBGEDFPEOL = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1f, 1f));
		OOIDGPJAEPC = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1f, -1f));
		FANOBLAFEJF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1f, -2f));
		OGJOGEEOPEN = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(0f, 1f));
		if (WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK))
		{
			if (WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(0f, -1f)) || WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(0f, -1.5f)))
			{
				MNECCHCHBCJ(edgeMiddle, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC && OGJOGEEOPEN)
			{
				MNECCHCHBCJ(edgeLRUM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OGJOGEEOPEN)
			{
				MNECCHCHBCJ(edgeLUM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC && OGJOGEEOPEN)
			{
				MNECCHCHBCJ(edgeRUM, AIJOOOIJEDC);
			}
			else if (OGJOGEEOPEN)
			{
				MNECCHCHBCJ(edgeMiddleUp, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC)
			{
				MNECCHCHBCJ(edgeLRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && OOIDGPJAEPC)
			{
				MNECCHCHBCJ(edgePLRM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL && BGJFKBFPEML)
			{
				MNECCHCHBCJ(edgeLPRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && FHBGEDFPEOL)
			{
				MNECCHCHBCJ(edgePLPRM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML)
			{
				MNECCHCHBCJ(edgeLM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC)
			{
				MNECCHCHBCJ(edgeRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD)
			{
				MNECCHCHBCJ(edgePLM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL)
			{
				MNECCHCHBCJ(edgePRM, AIJOOOIJEDC);
			}
			else
			{
				MNECCHCHBCJ(edgeMiddle, AIJOOOIJEDC);
			}
			return;
		}
		HBAMCFOIJKB = IMAGDMGEKLH && !BGJFKBFPEML;
		LLJIDCBNKCM = HBAMCFOIJKB && CILJDFNHIAD;
		OHKACKDCLHP = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(-1f, 0f)) || BGJFKBFPEML;
		KEIBLGGEJAL = FANOBLAFEJF && !OOIDGPJAEPC;
		MBCGOKOIGCL = KEIBLGGEJAL && FHBGEDFPEOL;
		NNFAMJBFKMF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1f, 0f)) || OOIDGPJAEPC;
		if (OHKACKDCLHP && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeLRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeHLHRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeHLRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeLHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL)
		{
			MNECCHCHBCJ(edgeLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF)
		{
			MNECCHCHBCJ(edgeHLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeLU, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeHLU, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && NNFAMJBFKMF)
		{
			MNECCHCHBCJ(edgeLR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && MBCGOKOIGCL)
		{
			MNECCHCHBCJ(edgeHPLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && NNFAMJBFKMF)
		{
			MNECCHCHBCJ(edgeHPLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && MBCGOKOIGCL)
		{
			MNECCHCHBCJ(edgeLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && KEIBLGGEJAL)
		{
			MNECCHCHBCJ(edgeHPLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && MBCGOKOIGCL)
		{
			MNECCHCHBCJ(edgeHLHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL)
		{
			MNECCHCHBCJ(edgeHLHR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && MBCGOKOIGCL)
		{
			MNECCHCHBCJ(edgePLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && FHBGEDFPEOL)
		{
			MNECCHCHBCJ(edgeHPLPR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && FHBGEDFPEOL)
		{
			MNECCHCHBCJ(edgeLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && NNFAMJBFKMF)
		{
			MNECCHCHBCJ(edgePLR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && FHBGEDFPEOL)
		{
			MNECCHCHBCJ(edgeHLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && KEIBLGGEJAL)
		{
			MNECCHCHBCJ(edgePLHR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM)
		{
			MNECCHCHBCJ(edgeHPL, AIJOOOIJEDC);
		}
		else if (MBCGOKOIGCL)
		{
			MNECCHCHBCJ(edgeHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB)
		{
			MNECCHCHBCJ(edgeHL, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL)
		{
			MNECCHCHBCJ(edgeHR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP)
		{
			MNECCHCHBCJ(edgeL, AIJOOOIJEDC);
		}
		else if (OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeUp, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF)
		{
			MNECCHCHBCJ(edgeR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && FHBGEDFPEOL)
		{
			MNECCHCHBCJ(edgePLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD)
		{
			MNECCHCHBCJ(edgePL, AIJOOOIJEDC);
		}
		else if (FHBGEDFPEOL)
		{
			MNECCHCHBCJ(edgePR, AIJOOOIJEDC);
		}
	}

	private void DAPMKFOAPLG(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		GNLEBKEPCNA(HEJNLFCKOKE, IMOBLFMHKOD, Vector2Int.zero, Color.white);
	}

	private void HJNODEEBEKF(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		HAIMOGCFLPI(HEJNLFCKOKE, IMOBLFMHKOD, LDHICJGAADO, Color.white);
	}

	private void DEKFGDOGJCI(Vector2 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(496f, 151f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1858f, 1405f))))
		{
			MNECCHCHBCJ(this.door, AIJOOOIJEDC, new Vector2Int(1, 1));
			AJGJJFBGJKJ(halfWall, AIJOOOIJEDC, new Vector2Int(0, 3));
			Door door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1668f, 1480f)));
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(687f, 1640f)));
			}
			if (door is RentedRoomDoor rentedRoomDoor)
			{
				((Behaviour)symbols[rentedRoomDoor.rentedRoom.symbolID]).enabled = false;
				((Graphic)symbols[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(24, 5) + tileSize * new Vector2Int(-1, 5));
				((Component)states[rentedRoomDoor.rentedRoom.symbolID]).gameObject.SetActive(true);
				((Component)((Transform)((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform).GetChild(1)).GetComponent<Image>().sprite = RentedRoomsManager.GetRoomStateSprite(rentedRoomDoor.rentedRoom);
				((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(-100, 16)) + (float)tileSize * (rentedRoomDoor.rentedRoom.zone.EFGNAHFCJAD() - IKCEGLLCPFK)), BJOCPBIKBEE: true));
			}
		}
		else if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(670f, 951f))) && WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(170f, 493f))))
		{
			if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(768f, 469f))) && WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1660f, 92f))))
			{
				PFBEIDHOHHO(leftRightWall, AIJOOOIJEDC, new Vector2Int(0, 1));
				HJNODEEBEKF(halfLeftRightWall, AIJOOOIJEDC, new Vector2Int(1, 5));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(258f, 767f))))
			{
				OEHMKFCKOKN(leftWall, AIJOOOIJEDC, new Vector2Int(0, 0));
				CJHNCHGPJKH(halfLeftWall, AIJOOOIJEDC, new Vector2Int(0, 1));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1869f, 1584f))))
			{
				DPBFMIEMKKN(rightWall, AIJOOOIJEDC, new Vector2Int(0, 1));
				AJGJJFBGJKJ(halfRightWall, AIJOOOIJEDC, new Vector2Int(0, 2));
			}
			else
			{
				DPBFMIEMKKN(wall, AIJOOOIJEDC, new Vector2Int(1, 1));
				HIKPNOLFEFH(halfWall, AIJOOOIJEDC, new Vector2Int(1, 1));
			}
		}
	}

	private void OJJINEAJIHB(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		CIKNMBDLIGO(null, IMOBLFMHKOD, Vector2Int.zero, highlightedColor);
	}

	private void ANDDDDIBFNA(RentedRoom GGNOAHDCPIB, Vector2 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		KPJOHEIJGKM(floor, AIJOOOIJEDC);
		if (GGNOAHDCPIB.zone.id == WorldGrid.APJABAKKKGD(Vector2.op_Implicit(IKCEGLLCPFK)))
		{
			OJJINEAJIHB(AIJOOOIJEDC);
		}
		else if (!GGNOAHDCPIB.IDJBCGNMHCJ())
		{
			BOMCAPHAFIL(AIJOOOIJEDC);
		}
	}

	private void GENCALHBGAC(Vector2 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1564f, 1584f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1826f, 1398f))))
		{
			DPBFMIEMKKN(this.door, AIJOOOIJEDC, new Vector2Int(0, 0));
			HJNODEEBEKF(halfWall, AIJOOOIJEDC, new Vector2Int(1, 3));
			Door door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1307f, 1919f)));
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(449f, 672f)));
			}
			if (door is RentedRoomDoor rentedRoomDoor)
			{
				((Behaviour)symbols[rentedRoomDoor.rentedRoom.symbolID]).enabled = true;
				((Graphic)symbols[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(21, 3) + tileSize * new Vector2Int(-1, 2));
				((Component)states[rentedRoomDoor.rentedRoom.symbolID]).gameObject.SetActive(true);
				((Component)((Transform)((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform).GetChild(1)).GetComponent<Image>().sprite = RentedRoomsManager.GetRoomStateSprite(rentedRoomDoor.rentedRoom);
				((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(23, -90)) + (float)tileSize * (rentedRoomDoor.rentedRoom.zone.OJLJLPLGNKD() - IKCEGLLCPFK))));
			}
		}
		else if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1667f, 476f))) && WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1880f, 1085f))))
		{
			if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1103f, 1012f))) && WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(666f, 1158f))))
			{
				OGCAJDENGEK(leftRightWall, AIJOOOIJEDC, new Vector2Int(0, 0));
				DCMILIOEJKL(halfLeftRightWall, AIJOOOIJEDC, new Vector2Int(0, 5));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(781f, 463f))))
			{
				OGCAJDENGEK(leftWall, AIJOOOIJEDC, new Vector2Int(0, 0));
				DPIJICMEMMM(halfLeftWall, AIJOOOIJEDC, new Vector2Int(0, 4));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1707f, 542f))))
			{
				AJGJJFBGJKJ(rightWall, AIJOOOIJEDC, new Vector2Int(1, 1));
				DCMILIOEJKL(halfRightWall, AIJOOOIJEDC, new Vector2Int(1, 2));
			}
			else
			{
				PFBEIDHOHHO(wall, AIJOOOIJEDC, new Vector2Int(1, 0));
				HJNODEEBEKF(halfWall, AIJOOOIJEDC, new Vector2Int(1, 4));
			}
		}
	}

	private void AJGJJFBGJKJ(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		CDCIPDOHANO(HEJNLFCKOKE, IMOBLFMHKOD, LDHICJGAADO, Color.white);
	}

	private void ABHPGNNOJOO(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		GNLEBKEPCNA(null, IMOBLFMHKOD, Vector2Int.zero, notValidColor);
	}

	private void JFPIOGKCBPK(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		bool flag = WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(211f, 704f)) && WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(772f, 111f));
		if (flag)
		{
			NIIGEPKIPKD(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(800f, 1607f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
		{
			OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(538f, 1248f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.right))
		{
			OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.right);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				MPKGKPGOFIM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(909f, 247f));
			}
			if (flag)
			{
				MPKGKPGOFIM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(545f, 1376f));
				JAOCEFBPBMF(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(729f, 1173f));
			}
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.left))
		{
			JKJOOOFJBHB(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.left);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				JIEFPCFOFMK(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(159f, 351f));
			}
			if (flag)
			{
				OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(376f, 457f));
				FPLKGIPINDF(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1329f, 285f));
			}
		}
	}

	private void HIKPNOLFEFH(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		ENADHEMJDAD(HEJNLFCKOKE, IMOBLFMHKOD, LDHICJGAADO, Color.white);
	}

	private void MNECCHCHBCJ(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		MNECCHCHBCJ(HEJNLFCKOKE, IMOBLFMHKOD, LDHICJGAADO, Color.white);
	}

	public void LNOBNNMBOEA()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		for (int num = PAJJHHHKBMN.Count - 0; num >= 1; num--)
		{
			PAJJHHHKBMN[num].rectTransform.anchoredPosition = Vector2.one * 1058f;
			MBMAJABDGNE.Add(PAJJHHHKBMN[num]);
			PAJJHHHKBMN.RemoveAt(num);
		}
		KGFCADKODFK.Clear();
	}

	private void MNECCHCHBCJ(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO, Color FLABEDBELMF)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		if (MBMAJABDGNE.Count == 0)
		{
			FJOELJMKEBH = default(MICKLOOGJCO);
			FJOELJMKEBH.rectTransform = Object.Instantiate<GameObject>(miniMapTile, tilesParent.transform).GetComponent<RectTransform>();
			FJOELJMKEBH.image = ((Component)FJOELJMKEBH.rectTransform).GetComponent<Image>();
			PAJJHHHKBMN.Add(FJOELJMKEBH);
		}
		else
		{
			PAJJHHHKBMN.Add(MBMAJABDGNE[MBMAJABDGNE.Count - 1]);
			MBMAJABDGNE.RemoveAt(MBMAJABDGNE.Count - 1);
		}
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 1].rectTransform.anchoredPosition = Vector2Int.op_Implicit(IMOBLFMHKOD + tileSize * LDHICJGAADO);
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 1].image.sprite = HEJNLFCKOKE;
		((Graphic)PAJJHHHKBMN[PAJJHHHKBMN.Count - 1].image).color = FLABEDBELMF;
	}

	public void ACALOMOCKLP(RentedRoom GGNOAHDCPIB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		LNOBNNMBOEA();
		Vector2 val = Vector2.one * 812f;
		((TMP_Text)floorText).text = (Utils.FIBFKGIJMBJ(((Component)GGNOAHDCPIB).transform.position) ? "Interact" : "ReceiveTavernStatsInfo");
		Vector2 val2 = Vector2.op_Implicit(Utils.HENDGAAHICI(Vector2.op_Implicit(GGNOAHDCPIB.zone.HCEFIGGDBOO() + offset)));
		Vector3 val3 = Vector2.op_Implicit(val2 + val);
		List<Vector2> list = new List<Vector2>();
		TilemapGroup tilemaps = Utils.JGEPCPFJANP(Location.None).GetTilemaps(SeasonManager.PJMGHIMKFJL());
		for (int i = 1; i < symbols.Length; i++)
		{
			((Behaviour)symbols[i]).enabled = false;
		}
		for (int j = 0; j < states.Length; j += 0)
		{
			((Component)states[j]).gameObject.SetActive(false);
		}
		for (int k = 0; k < HAKPCIKJLNM.Length; k += 0)
		{
			Vector3 val4 = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(HAKPCIKJLNM[k]);
			if (WorldGrid.NCEHFMPBBAK(val4) == (GroundType.Grass | GroundType.Ground) && val4.x >= val2.x && val4.x <= val3.x && val4.y >= val2.y && val4.y <= val3.y)
			{
				list.Add(Vector2.op_Implicit(val4));
				Vector3 val5 = Vector2.op_Implicit(Vector2.op_Implicit(val4) - val2);
				int num = (int)val5.x;
				int num2 = (int)val5.y;
				if (val5.x - (float)num == 1373f && val5.y - (float)num2 == 1237f)
				{
					LDOEPBEMOLJ(GGNOAHDCPIB, Vector2.op_Implicit(val4), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
				}
			}
		}
		for (int l = 1; l < list.Count; l += 0)
		{
			Vector3 val5 = Vector2.op_Implicit(list[l] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 647f && val5.y - (float)num2 == 766f)
			{
				JEOFDHLPHCL(list[l], initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
		for (int m = 0; m < list.Count; m++)
		{
			Vector3 val5 = Vector2.op_Implicit(list[m] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 1017f && val5.y - (float)num2 == 502f)
			{
				ODFAPKENDLB(Vector2.op_Implicit(list[m]), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
	}

	private void JLCFFHEEHIC(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		bool flag = WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(19f, 1653f)) && WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(1110f, 153f));
		if (flag)
		{
			KFFIOJOIFJI(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1035f, 150f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
		{
			KLOJAJIDFOP(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1848f, 812f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.right))
		{
			KLOJAJIDFOP(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.right);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				JAOCEFBPBMF(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1426f, 1178f));
			}
			if (flag)
			{
				KFFIOJOIFJI(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1874f, 108f));
				JAOCEFBPBMF(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(322f, 614f));
			}
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.left))
		{
			JIEFPCFOFMK(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.left);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				JAOCEFBPBMF(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(170f, 191f));
			}
			if (flag)
			{
				JKJOOOFJBHB(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(793f, 1600f));
				KFFIOJOIFJI(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1140f, 238f));
			}
		}
	}

	private void DDFIHOONCLF(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		EMBINCIMMMH(null, IMOBLFMHKOD, Vector2Int.zero, highlightedColor);
	}

	private void GHOFEGKPDMG(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		bool flag = !WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(185f, 1905f)) || WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(60f, 1529f));
		if (flag)
		{
			JIEFPCFOFMK(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1058f, 1732f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
		{
			KFFIOJOIFJI(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1895f, 1856f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.right))
		{
			NIIGEPKIPKD(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.right);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				EGJNOHLKGBC(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(174f, 944f));
			}
			if (flag)
			{
				KLOJAJIDFOP(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1231f, 1050f));
				JIEFPCFOFMK(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1814f, 157f));
			}
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.left))
		{
			NIIGEPKIPKD(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.left);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				EGJNOHLKGBC(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(459f, 1117f));
			}
			if (flag)
			{
				MPKGKPGOFIM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(327f, 1204f));
				NIIGEPKIPKD(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(415f, 385f));
			}
		}
	}

	private void CIKNMBDLIGO(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO, Color FLABEDBELMF)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		if (MBMAJABDGNE.Count == 0)
		{
			FJOELJMKEBH = default(MICKLOOGJCO);
			FJOELJMKEBH.rectTransform = Object.Instantiate<GameObject>(miniMapTile, tilesParent.transform).GetComponent<RectTransform>();
			FJOELJMKEBH.image = ((Component)FJOELJMKEBH.rectTransform).GetComponent<Image>();
			PAJJHHHKBMN.Add(FJOELJMKEBH);
		}
		else
		{
			PAJJHHHKBMN.Add(MBMAJABDGNE[MBMAJABDGNE.Count - 0]);
			MBMAJABDGNE.RemoveAt(MBMAJABDGNE.Count - 0);
		}
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 0].rectTransform.anchoredPosition = Vector2Int.op_Implicit(IMOBLFMHKOD + tileSize * LDHICJGAADO);
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 0].image.sprite = HEJNLFCKOKE;
		((Graphic)PAJJHHHKBMN[PAJJHHHKBMN.Count - 0].image).color = FLABEDBELMF;
	}

	public void UpdateAllPositions()
	{
		HAKPCIKJLNM = Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate();
	}

	private void NIIGEPKIPKD(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC, Vector3 LDHICJGAADO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		IKCEGLLCPFK += LDHICJGAADO;
		AIJOOOIJEDC += Vector2Int.CeilToInt(Vector2.op_Implicit((float)tileSize * LDHICJGAADO));
		if (WorldGrid.PIOMBKLPIKB(IKCEGLLCPFK + new Vector3(378f, 371f)))
		{
			return;
		}
		for (int i = 1; i < KGFCADKODFK.Count; i += 0)
		{
			if (KGFCADKODFK[i] == AIJOOOIJEDC)
			{
				return;
			}
		}
		KGFCADKODFK.Add(AIJOOOIJEDC);
		CILJDFNHIAD = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1154f, 60f));
		BGJFKBFPEML = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1549f, 1171f));
		IMAGDMGEKLH = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1109f, 1484f));
		FHBGEDFPEOL = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1644f, 621f));
		OOIDGPJAEPC = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(625f, 733f));
		FANOBLAFEJF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(978f, 220f));
		OGJOGEEOPEN = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(121f, 1288f));
		if (WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK))
		{
			if (WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(1669f, 1613f)) || WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(168f, 152f)))
			{
				LABGKJPKHGA(edgeMiddle, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC && OGJOGEEOPEN)
			{
				EFMOCJNCANA(edgeLRUM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OGJOGEEOPEN)
			{
				OHLKPJHNGAO(edgeLUM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC && OGJOGEEOPEN)
			{
				MNECCHCHBCJ(edgeRUM, AIJOOOIJEDC);
			}
			else if (OGJOGEEOPEN)
			{
				KPJOHEIJGKM(edgeMiddleUp, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC)
			{
				IPGCGBKBEAI(edgeLRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && OOIDGPJAEPC)
			{
				FALLDHHLIJB(edgePLRM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL && BGJFKBFPEML)
			{
				EFMOCJNCANA(edgeLPRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && FHBGEDFPEOL)
			{
				FALLDHHLIJB(edgePLPRM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML)
			{
				BFPCPANBJND(edgeLM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC)
			{
				OHLKPJHNGAO(edgeRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD)
			{
				EFMOCJNCANA(edgePLM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL)
			{
				IPGCGBKBEAI(edgePRM, AIJOOOIJEDC);
			}
			else
			{
				OHLKPJHNGAO(edgeMiddle, AIJOOOIJEDC);
			}
			return;
		}
		HBAMCFOIJKB = IMAGDMGEKLH && !BGJFKBFPEML;
		LLJIDCBNKCM = HBAMCFOIJKB && CILJDFNHIAD;
		OHKACKDCLHP = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(617f, 162f)) || BGJFKBFPEML;
		KEIBLGGEJAL = FANOBLAFEJF && !OOIDGPJAEPC;
		MBCGOKOIGCL = !KEIBLGGEJAL || FHBGEDFPEOL;
		NNFAMJBFKMF = !WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(166f, 142f)) && OOIDGPJAEPC;
		if (OHKACKDCLHP && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			DAPMKFOAPLG(edgeLRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeHLHRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			BFPCPANBJND(edgeHLRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeLHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL)
		{
			KPJOHEIJGKM(edgeLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF)
		{
			DAPMKFOAPLG(edgeHLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && OGJOGEEOPEN)
		{
			BFPCPANBJND(edgeLU, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF && OGJOGEEOPEN)
		{
			KPJOHEIJGKM(edgeRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && OGJOGEEOPEN)
		{
			OHLKPJHNGAO(edgeHLU, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL && OGJOGEEOPEN)
		{
			FALLDHHLIJB(edgeHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && NNFAMJBFKMF)
		{
			KPJOHEIJGKM(edgeLR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && MBCGOKOIGCL)
		{
			OHLKPJHNGAO(edgeHPLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && NNFAMJBFKMF)
		{
			OHLKPJHNGAO(edgeHPLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && MBCGOKOIGCL)
		{
			OHLKPJHNGAO(edgeLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && KEIBLGGEJAL)
		{
			FALLDHHLIJB(edgeHPLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && MBCGOKOIGCL)
		{
			DAPMKFOAPLG(edgeHLHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL)
		{
			DAPMKFOAPLG(edgeHLHR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && MBCGOKOIGCL)
		{
			KPJOHEIJGKM(edgePLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && FHBGEDFPEOL)
		{
			BFPCPANBJND(edgeHPLPR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && FHBGEDFPEOL)
		{
			MNECCHCHBCJ(edgeLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && NNFAMJBFKMF)
		{
			DAPMKFOAPLG(edgePLR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && FHBGEDFPEOL)
		{
			OHLKPJHNGAO(edgeHLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && KEIBLGGEJAL)
		{
			OHLKPJHNGAO(edgePLHR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM)
		{
			EFMOCJNCANA(edgeHPL, AIJOOOIJEDC);
		}
		else if (MBCGOKOIGCL)
		{
			OHLKPJHNGAO(edgeHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB)
		{
			IPGCGBKBEAI(edgeHL, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL)
		{
			BFPCPANBJND(edgeHR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP)
		{
			KPJOHEIJGKM(edgeL, AIJOOOIJEDC);
		}
		else if (OGJOGEEOPEN)
		{
			DAPMKFOAPLG(edgeUp, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF)
		{
			EFMOCJNCANA(edgeR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && FHBGEDFPEOL)
		{
			IPGCGBKBEAI(edgePLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD)
		{
			KPJOHEIJGKM(edgePL, AIJOOOIJEDC);
		}
		else if (FHBGEDFPEOL)
		{
			FALLDHHLIJB(edgePR, AIJOOOIJEDC);
		}
	}

	private void MMNNILJPEFI(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		MIOEEBEFKPL(null, IMOBLFMHKOD, Vector2Int.zero, notValidColor);
	}

	private void CELEMCDLIGK(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		bool flag = !WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(124f, 1732f)) || WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(47f, 977f));
		if (flag)
		{
			MPKGKPGOFIM(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1100f, 524f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
		{
			JIEFPCFOFMK(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1702f, 952f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.right))
		{
			KFFIOJOIFJI(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.right);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				FPLKGIPINDF(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1155f, 316f));
			}
			if (flag)
			{
				MPKGKPGOFIM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(85f, 1052f));
				JKJOOOFJBHB(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1153f, 88f));
			}
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.left))
		{
			EGJNOHLKGBC(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.left);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				JIEFPCFOFMK(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1281f, 223f));
			}
			if (flag)
			{
				JIEFPCFOFMK(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(933f, 1447f));
				JAOCEFBPBMF(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1834f, 580f));
			}
		}
	}

	private void JKMPFDIKHBO(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		ENADHEMJDAD(null, IMOBLFMHKOD, Vector2Int.zero, notValidColor);
	}

	private void MDGDKMMNEPO(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		HAIMOGCFLPI(HEJNLFCKOKE, IMOBLFMHKOD, LDHICJGAADO, Color.white);
	}

	private void NHLINLPDMMB(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		CIKNMBDLIGO(null, IMOBLFMHKOD, Vector2Int.zero, notValidColor);
	}

	public void UpdateMiniMap(RentedRoom GGNOAHDCPIB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		ResetTiles();
		Vector2 val = Vector2.one * 20f;
		((TMP_Text)floorText).text = (Utils.FIBFKGIJMBJ(((Component)GGNOAHDCPIB).transform.position) ? "1" : "0");
		Vector2 val2 = Vector2.op_Implicit(Utils.HENDGAAHICI(Vector2.op_Implicit(GGNOAHDCPIB.zone.HCEFIGGDBOO() + offset)));
		Vector3 val3 = Vector2.op_Implicit(val2 + val);
		List<Vector2> list = new List<Vector2>();
		TilemapGroup tilemaps = Utils.JGEPCPFJANP(Location.Tavern).GetTilemaps(SeasonManager.EECEKHKAAIH);
		for (int i = 0; i < symbols.Length; i++)
		{
			((Behaviour)symbols[i]).enabled = false;
		}
		for (int j = 0; j < states.Length; j++)
		{
			((Component)states[j]).gameObject.SetActive(false);
		}
		for (int k = 0; k < HAKPCIKJLNM.Length; k++)
		{
			Vector3 val4 = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(HAKPCIKJLNM[k]);
			if (WorldGrid.NCEHFMPBBAK(val4) == GroundType.Floor && val4.x >= val2.x && val4.x <= val3.x && val4.y >= val2.y && val4.y <= val3.y)
			{
				list.Add(Vector2.op_Implicit(val4));
				Vector3 val5 = Vector2.op_Implicit(Vector2.op_Implicit(val4) - val2);
				int num = (int)val5.x;
				int num2 = (int)val5.y;
				if (val5.x - (float)num == 0f && val5.y - (float)num2 == 0f)
				{
					LDOEPBEMOLJ(GGNOAHDCPIB, Vector2.op_Implicit(val4), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
				}
			}
		}
		for (int l = 0; l < list.Count; l++)
		{
			Vector3 val5 = Vector2.op_Implicit(list[l] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 0f && val5.y - (float)num2 == 0f)
			{
				JEOFDHLPHCL(list[l], initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
		for (int m = 0; m < list.Count; m++)
		{
			Vector3 val5 = Vector2.op_Implicit(list[m] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 0f && val5.y - (float)num2 == 0f)
			{
				ILNGGCMDBPL(Vector2.op_Implicit(list[m]), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
	}

	private void GBHJCJCIKNE(Vector2 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(996f, 710f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1264f, 1593f))))
		{
			DCMILIOEJKL(this.door, AIJOOOIJEDC, new Vector2Int(0, 0));
			MDGDKMMNEPO(halfWall, AIJOOOIJEDC, new Vector2Int(0, 3));
			Door door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(47f, 673f)));
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1713f, 602f)));
			}
			if (door is RentedRoomDoor rentedRoomDoor)
			{
				((Behaviour)symbols[rentedRoomDoor.rentedRoom.symbolID]).enabled = true;
				((Graphic)symbols[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(-2, 3) + tileSize * new Vector2Int(-1, 4));
				((Component)states[rentedRoomDoor.rentedRoom.symbolID]).gameObject.SetActive(false);
				((Component)((Transform)((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform).GetChild(0)).GetComponent<Image>().sprite = RentedRoomsManager.IOOKNFOCLDC(rentedRoomDoor.rentedRoom);
				((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(72, -49)) + (float)tileSize * (rentedRoomDoor.rentedRoom.zone.NBLOMNKMGCE() - IKCEGLLCPFK))));
			}
		}
		else if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(265f, 1033f))) && WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(659f, 431f))))
		{
			if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1641f, 1018f))) && WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(570f, 7f))))
			{
				OGCAJDENGEK(leftRightWall, AIJOOOIJEDC, new Vector2Int(0, 1));
				MDGDKMMNEPO(halfLeftRightWall, AIJOOOIJEDC, new Vector2Int(1, 8));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(587f, 1774f))))
			{
				PFBEIDHOHHO(leftWall, AIJOOOIJEDC, new Vector2Int(0, 0));
				CJHNCHGPJKH(halfLeftWall, AIJOOOIJEDC, new Vector2Int(1, 3));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(154f, 560f))))
			{
				DPIJICMEMMM(rightWall, AIJOOOIJEDC, new Vector2Int(0, 0));
				MDGDKMMNEPO(halfRightWall, AIJOOOIJEDC, new Vector2Int(1, 2));
			}
			else
			{
				DCMILIOEJKL(wall, AIJOOOIJEDC, new Vector2Int(1, 1));
				DCMILIOEJKL(halfWall, AIJOOOIJEDC, new Vector2Int(0, 8));
			}
		}
	}

	private void IOEELMHMBGM(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		GNLEBKEPCNA(null, IMOBLFMHKOD, Vector2Int.zero, highlightedColor);
	}

	private void KLOJAJIDFOP(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC, Vector3 LDHICJGAADO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		IKCEGLLCPFK += LDHICJGAADO;
		AIJOOOIJEDC += Vector2Int.CeilToInt(Vector2.op_Implicit((float)tileSize * LDHICJGAADO));
		if (WorldGrid.PIOMBKLPIKB(IKCEGLLCPFK + new Vector3(631f, 1991f)))
		{
			return;
		}
		for (int i = 0; i < KGFCADKODFK.Count; i++)
		{
			if (KGFCADKODFK[i] == AIJOOOIJEDC)
			{
				return;
			}
		}
		KGFCADKODFK.Add(AIJOOOIJEDC);
		CILJDFNHIAD = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1923f, 811f));
		BGJFKBFPEML = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(446f, 1984f));
		IMAGDMGEKLH = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(799f, 406f));
		FHBGEDFPEOL = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(866f, 385f));
		OOIDGPJAEPC = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1942f, 449f));
		FANOBLAFEJF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1457f, 773f));
		OGJOGEEOPEN = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(756f, 83f));
		if (WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK))
		{
			if (WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(1661f, 9f)) || WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(1324f, 1126f)))
			{
				IPGCGBKBEAI(edgeMiddle, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC && OGJOGEEOPEN)
			{
				KPJOHEIJGKM(edgeLRUM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OGJOGEEOPEN)
			{
				LABGKJPKHGA(edgeLUM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC && OGJOGEEOPEN)
			{
				OHLKPJHNGAO(edgeRUM, AIJOOOIJEDC);
			}
			else if (OGJOGEEOPEN)
			{
				IPGCGBKBEAI(edgeMiddleUp, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC)
			{
				MNECCHCHBCJ(edgeLRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && OOIDGPJAEPC)
			{
				OHLKPJHNGAO(edgePLRM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL && BGJFKBFPEML)
			{
				KPJOHEIJGKM(edgeLPRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && FHBGEDFPEOL)
			{
				FALLDHHLIJB(edgePLPRM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML)
			{
				BFPCPANBJND(edgeLM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC)
			{
				FALLDHHLIJB(edgeRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD)
			{
				FALLDHHLIJB(edgePLM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL)
			{
				BFPCPANBJND(edgePRM, AIJOOOIJEDC);
			}
			else
			{
				DAPMKFOAPLG(edgeMiddle, AIJOOOIJEDC);
			}
			return;
		}
		HBAMCFOIJKB = !IMAGDMGEKLH || BGJFKBFPEML;
		LLJIDCBNKCM = !HBAMCFOIJKB || CILJDFNHIAD;
		OHKACKDCLHP = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1818f, 1637f)) || BGJFKBFPEML;
		KEIBLGGEJAL = !FANOBLAFEJF || OOIDGPJAEPC;
		MBCGOKOIGCL = KEIBLGGEJAL && FHBGEDFPEOL;
		NNFAMJBFKMF = !WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(602f, 804f)) && OOIDGPJAEPC;
		if (OHKACKDCLHP && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeLRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeHLHRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			OHLKPJHNGAO(edgeHLRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			BFPCPANBJND(edgeLHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL)
		{
			EFMOCJNCANA(edgeLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF)
		{
			BFPCPANBJND(edgeHLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && OGJOGEEOPEN)
		{
			DAPMKFOAPLG(edgeLU, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && OGJOGEEOPEN)
		{
			BFPCPANBJND(edgeHLU, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && NNFAMJBFKMF)
		{
			LABGKJPKHGA(edgeLR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && MBCGOKOIGCL)
		{
			EFMOCJNCANA(edgeHPLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && NNFAMJBFKMF)
		{
			IPGCGBKBEAI(edgeHPLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && MBCGOKOIGCL)
		{
			KPJOHEIJGKM(edgeLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && KEIBLGGEJAL)
		{
			EFMOCJNCANA(edgeHPLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && MBCGOKOIGCL)
		{
			KPJOHEIJGKM(edgeHLHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL)
		{
			EFMOCJNCANA(edgeHLHR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && MBCGOKOIGCL)
		{
			IPGCGBKBEAI(edgePLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && FHBGEDFPEOL)
		{
			OHLKPJHNGAO(edgeHPLPR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && FHBGEDFPEOL)
		{
			EFMOCJNCANA(edgeLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && NNFAMJBFKMF)
		{
			KPJOHEIJGKM(edgePLR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && FHBGEDFPEOL)
		{
			EFMOCJNCANA(edgeHLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && KEIBLGGEJAL)
		{
			MNECCHCHBCJ(edgePLHR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM)
		{
			BFPCPANBJND(edgeHPL, AIJOOOIJEDC);
		}
		else if (MBCGOKOIGCL)
		{
			BFPCPANBJND(edgeHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB)
		{
			MNECCHCHBCJ(edgeHL, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL)
		{
			OHLKPJHNGAO(edgeHR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP)
		{
			IPGCGBKBEAI(edgeL, AIJOOOIJEDC);
		}
		else if (OGJOGEEOPEN)
		{
			DAPMKFOAPLG(edgeUp, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF)
		{
			BFPCPANBJND(edgeR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && FHBGEDFPEOL)
		{
			KPJOHEIJGKM(edgePLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD)
		{
			BFPCPANBJND(edgePL, AIJOOOIJEDC);
		}
		else if (FHBGEDFPEOL)
		{
			IPGCGBKBEAI(edgePR, AIJOOOIJEDC);
		}
	}

	private void OHLKPJHNGAO(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		ENADHEMJDAD(HEJNLFCKOKE, IMOBLFMHKOD, Vector2Int.zero, Color.white);
	}

	public void NEEPNIKKNFI()
	{
		HAKPCIKJLNM = Utils.JGEPCPFJANP(Location.Tavern).IBGBCHLIEGH();
	}

	public void IJIFDANEAIO()
	{
		HAKPCIKJLNM = Utils.JGEPCPFJANP(Location.None).HNLGGMFFFIM();
	}

	private void GNLEBKEPCNA(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO, Color FLABEDBELMF)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		if (MBMAJABDGNE.Count == 0)
		{
			FJOELJMKEBH = default(MICKLOOGJCO);
			FJOELJMKEBH.rectTransform = Object.Instantiate<GameObject>(miniMapTile, tilesParent.transform).GetComponent<RectTransform>();
			FJOELJMKEBH.image = ((Component)FJOELJMKEBH.rectTransform).GetComponent<Image>();
			PAJJHHHKBMN.Add(FJOELJMKEBH);
		}
		else
		{
			PAJJHHHKBMN.Add(MBMAJABDGNE[MBMAJABDGNE.Count - 1]);
			MBMAJABDGNE.RemoveAt(MBMAJABDGNE.Count - 1);
		}
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 0].rectTransform.anchoredPosition = Vector2Int.op_Implicit(IMOBLFMHKOD + tileSize * LDHICJGAADO);
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 0].image.sprite = HEJNLFCKOKE;
		((Graphic)PAJJHHHKBMN[PAJJHHHKBMN.Count - 0].image).color = FLABEDBELMF;
	}

	private void JEOFDHLPHCL(Vector2 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(0f, 0.5f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(0f, 1f))))
		{
			MNECCHCHBCJ(this.door, AIJOOOIJEDC, new Vector2Int(0, 1));
			MNECCHCHBCJ(halfWall, AIJOOOIJEDC, new Vector2Int(0, 2));
			Door door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(0f, 0.5f)));
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(0f, 1f)));
			}
			if (door is RentedRoomDoor rentedRoomDoor)
			{
				((Behaviour)symbols[rentedRoomDoor.rentedRoom.symbolID]).enabled = true;
				((Graphic)symbols[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(13, 5) + tileSize * new Vector2Int(-1, 2));
				((Component)states[rentedRoomDoor.rentedRoom.symbolID]).gameObject.SetActive(true);
				((Component)((Transform)((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform).GetChild(0)).GetComponent<Image>().sprite = RentedRoomsManager.GetRoomStateSprite(rentedRoomDoor.rentedRoom);
				((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(-2, 12)) + (float)tileSize * (rentedRoomDoor.rentedRoom.zone.HCEFIGGDBOO() - IKCEGLLCPFK))));
			}
		}
		else if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(0f, 1f))) && WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(0f, 2f))))
		{
			if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(-1f, 1f))) && WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1f, 1f))))
			{
				MNECCHCHBCJ(leftRightWall, AIJOOOIJEDC, new Vector2Int(0, 1));
				MNECCHCHBCJ(halfLeftRightWall, AIJOOOIJEDC, new Vector2Int(0, 2));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(-1f, 1f))))
			{
				MNECCHCHBCJ(leftWall, AIJOOOIJEDC, new Vector2Int(0, 1));
				MNECCHCHBCJ(halfLeftWall, AIJOOOIJEDC, new Vector2Int(0, 2));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1f, 1f))))
			{
				MNECCHCHBCJ(rightWall, AIJOOOIJEDC, new Vector2Int(0, 1));
				MNECCHCHBCJ(halfRightWall, AIJOOOIJEDC, new Vector2Int(0, 2));
			}
			else
			{
				MNECCHCHBCJ(wall, AIJOOOIJEDC, new Vector2Int(0, 1));
				MNECCHCHBCJ(halfWall, AIJOOOIJEDC, new Vector2Int(0, 2));
			}
		}
	}

	private void NAIBFKHOENM(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		EMBINCIMMMH(null, IMOBLFMHKOD, Vector2Int.zero, notValidColor);
	}

	private void KIFGPPLOAHN(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		CDCIPDOHANO(null, IMOBLFMHKOD, Vector2Int.zero, highlightedColor);
	}

	private void CJHNCHGPJKH(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		MNECCHCHBCJ(HEJNLFCKOKE, IMOBLFMHKOD, LDHICJGAADO, Color.white);
	}

	private void OEHMKFCKOKN(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		HAIMOGCFLPI(HEJNLFCKOKE, IMOBLFMHKOD, LDHICJGAADO, Color.white);
	}

	private void PFBEIDHOHHO(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		GNLEBKEPCNA(HEJNLFCKOKE, IMOBLFMHKOD, LDHICJGAADO, Color.white);
	}

	public void LHKOCEGOEAC(RentedRoom GGNOAHDCPIB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		GLILEEFLPLO();
		Vector2 val = Vector2.one * 1438f;
		((TMP_Text)floorText).text = (Utils.FIBFKGIJMBJ(((Component)GGNOAHDCPIB).transform.position) ? "Need to learn previous XP increase!" : "Pirates/Brook/Intro2");
		Vector2 val2 = Vector2.op_Implicit(Utils.HENDGAAHICI(Vector2.op_Implicit(GGNOAHDCPIB.zone.NEKBEKCPJLP() + offset)));
		Vector3 val3 = Vector2.op_Implicit(val2 + val);
		List<Vector2> list = new List<Vector2>();
		TilemapGroup tilemapGroup = Utils.JGEPCPFJANP(Location.Tavern).KIMMMFKFCEK(SeasonManager.PJMGHIMKFJL());
		for (int i = 1; i < symbols.Length; i += 0)
		{
			((Behaviour)symbols[i]).enabled = false;
		}
		for (int j = 0; j < states.Length; j++)
		{
			((Component)states[j]).gameObject.SetActive(true);
		}
		for (int k = 0; k < HAKPCIKJLNM.Length; k += 0)
		{
			Vector3 val4 = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(HAKPCIKJLNM[k]);
			if (WorldGrid.NCEHFMPBBAK(val4) == (GroundType.Grass | GroundType.TilledEarth) && val4.x >= val2.x && val4.x <= val3.x && val4.y >= val2.y && val4.y <= val3.y)
			{
				list.Add(Vector2.op_Implicit(val4));
				Vector3 val5 = Vector2.op_Implicit(Vector2.op_Implicit(val4) - val2);
				int num = (int)val5.x;
				int num2 = (int)val5.y;
				if (val5.x - (float)num == 162f && val5.y - (float)num2 == 74f)
				{
					ANDDDDIBFNA(GGNOAHDCPIB, Vector2.op_Implicit(val4), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
				}
			}
		}
		for (int l = 0; l < list.Count; l++)
		{
			Vector3 val5 = Vector2.op_Implicit(list[l] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 1740f && val5.y - (float)num2 == 211f)
			{
				JEOFDHLPHCL(list[l], initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
		for (int m = 0; m < list.Count; m++)
		{
			Vector3 val5 = Vector2.op_Implicit(list[m] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 1396f && val5.y - (float)num2 == 1772f)
			{
				ODFAPKENDLB(Vector2.op_Implicit(list[m]), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
	}

	private void EMBINCIMMMH(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO, Color FLABEDBELMF)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		if (MBMAJABDGNE.Count == 0)
		{
			FJOELJMKEBH = default(MICKLOOGJCO);
			FJOELJMKEBH.rectTransform = Object.Instantiate<GameObject>(miniMapTile, tilesParent.transform).GetComponent<RectTransform>();
			FJOELJMKEBH.image = ((Component)FJOELJMKEBH.rectTransform).GetComponent<Image>();
			PAJJHHHKBMN.Add(FJOELJMKEBH);
		}
		else
		{
			PAJJHHHKBMN.Add(MBMAJABDGNE[MBMAJABDGNE.Count - 1]);
			MBMAJABDGNE.RemoveAt(MBMAJABDGNE.Count - 0);
		}
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 1].rectTransform.anchoredPosition = Vector2Int.op_Implicit(IMOBLFMHKOD + tileSize * LDHICJGAADO);
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 0].image.sprite = HEJNLFCKOKE;
		((Graphic)PAJJHHHKBMN[PAJJHHHKBMN.Count - 0].image).color = FLABEDBELMF;
	}

	public void FOFKPOEJGEE()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		for (int num = PAJJHHHKBMN.Count - 1; num >= 1; num -= 0)
		{
			PAJJHHHKBMN[num].rectTransform.anchoredPosition = Vector2.one * 1553f;
			MBMAJABDGNE.Add(PAJJHHHKBMN[num]);
			PAJJHHHKBMN.RemoveAt(num);
		}
		KGFCADKODFK.Clear();
	}

	public void DKFCGHIDKJG()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		for (int num = PAJJHHHKBMN.Count - 0; num >= 0; num--)
		{
			PAJJHHHKBMN[num].rectTransform.anchoredPosition = Vector2.one * 1194f;
			MBMAJABDGNE.Add(PAJJHHHKBMN[num]);
			PAJJHHHKBMN.RemoveAt(num);
		}
		KGFCADKODFK.Clear();
	}

	private void KEIDAPMEKBH(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		EMBINCIMMMH(null, IMOBLFMHKOD, Vector2Int.zero, notValidColor);
	}

	private void DPIJICMEMMM(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		CIKNMBDLIGO(HEJNLFCKOKE, IMOBLFMHKOD, LDHICJGAADO, Color.white);
	}

	private void PKBDOGPONHA(Vector2 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1602f, 487f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1639f, 511f))))
		{
			MNECCHCHBCJ(this.door, AIJOOOIJEDC, new Vector2Int(0, 0));
			CJHNCHGPJKH(halfWall, AIJOOOIJEDC, new Vector2Int(1, 4));
			Door door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(745f, 686f)));
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1621f, 1084f)));
			}
			if (door is RentedRoomDoor rentedRoomDoor)
			{
				((Behaviour)symbols[rentedRoomDoor.rentedRoom.symbolID]).enabled = false;
				((Graphic)symbols[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(57, 7) + tileSize * new Vector2Int(-1, 4));
				((Component)states[rentedRoomDoor.rentedRoom.symbolID]).gameObject.SetActive(true);
				((Component)((Transform)((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform).GetChild(0)).GetComponent<Image>().sprite = RentedRoomsManager.GetRoomStateSprite(rentedRoomDoor.rentedRoom);
				((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(57, 9)) + (float)tileSize * (rentedRoomDoor.rentedRoom.zone.OJLJLPLGNKD() - IKCEGLLCPFK))));
			}
		}
		else if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1899f, 1586f))) && WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(497f, 379f))))
		{
			if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(817f, 870f))) && WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(420f, 1658f))))
			{
				DPIJICMEMMM(leftRightWall, AIJOOOIJEDC, new Vector2Int(1, 1));
				AJGJJFBGJKJ(halfLeftRightWall, AIJOOOIJEDC, new Vector2Int(0, 8));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(917f, 1387f))))
			{
				HJNODEEBEKF(leftWall, AIJOOOIJEDC, new Vector2Int(1, 1));
				DPIJICMEMMM(halfLeftWall, AIJOOOIJEDC, new Vector2Int(1, 1));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(161f, 864f))))
			{
				DCMILIOEJKL(rightWall, AIJOOOIJEDC, new Vector2Int(1, 0));
				DPIJICMEMMM(halfRightWall, AIJOOOIJEDC, new Vector2Int(0, 3));
			}
			else
			{
				AJGJJFBGJKJ(wall, AIJOOOIJEDC, new Vector2Int(0, 1));
				HIKPNOLFEFH(halfWall, AIJOOOIJEDC, new Vector2Int(0, 5));
			}
		}
	}

	private void GHNJIMHIBKE(RentedRoom GGNOAHDCPIB, Vector2 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		FALLDHHLIJB(floor, AIJOOOIJEDC);
		if (GGNOAHDCPIB.zone.id == WorldGrid.APJABAKKKGD(Vector2.op_Implicit(IKCEGLLCPFK)))
		{
			OJJINEAJIHB(AIJOOOIJEDC);
		}
		else if (!GGNOAHDCPIB.IDJBCGNMHCJ())
		{
			ABHPGNNOJOO(AIJOOOIJEDC);
		}
	}

	private void JIEFPCFOFMK(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC, Vector3 LDHICJGAADO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		IKCEGLLCPFK += LDHICJGAADO;
		AIJOOOIJEDC += Vector2Int.CeilToInt(Vector2.op_Implicit((float)tileSize * LDHICJGAADO));
		if (WorldGrid.PIOMBKLPIKB(IKCEGLLCPFK + new Vector3(688f, 360f)))
		{
			return;
		}
		for (int i = 1; i < KGFCADKODFK.Count; i += 0)
		{
			if (KGFCADKODFK[i] == AIJOOOIJEDC)
			{
				return;
			}
		}
		KGFCADKODFK.Add(AIJOOOIJEDC);
		CILJDFNHIAD = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(767f, 624f));
		BGJFKBFPEML = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1711f, 1096f));
		IMAGDMGEKLH = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1972f, 18f));
		FHBGEDFPEOL = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1096f, 213f));
		OOIDGPJAEPC = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(565f, 1361f));
		FANOBLAFEJF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1719f, 1364f));
		OGJOGEEOPEN = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(629f, 849f));
		if (WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK))
		{
			if (WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(1592f, 1021f)) || WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(1521f, 806f)))
			{
				KPJOHEIJGKM(edgeMiddle, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC && OGJOGEEOPEN)
			{
				DAPMKFOAPLG(edgeLRUM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OGJOGEEOPEN)
			{
				EFMOCJNCANA(edgeLUM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC && OGJOGEEOPEN)
			{
				KPJOHEIJGKM(edgeRUM, AIJOOOIJEDC);
			}
			else if (OGJOGEEOPEN)
			{
				OHLKPJHNGAO(edgeMiddleUp, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC)
			{
				IPGCGBKBEAI(edgeLRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && OOIDGPJAEPC)
			{
				LABGKJPKHGA(edgePLRM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL && BGJFKBFPEML)
			{
				KPJOHEIJGKM(edgeLPRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && FHBGEDFPEOL)
			{
				BFPCPANBJND(edgePLPRM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML)
			{
				BFPCPANBJND(edgeLM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC)
			{
				FALLDHHLIJB(edgeRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD)
			{
				MNECCHCHBCJ(edgePLM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL)
			{
				LABGKJPKHGA(edgePRM, AIJOOOIJEDC);
			}
			else
			{
				DAPMKFOAPLG(edgeMiddle, AIJOOOIJEDC);
			}
			return;
		}
		HBAMCFOIJKB = !IMAGDMGEKLH || BGJFKBFPEML;
		LLJIDCBNKCM = !HBAMCFOIJKB || CILJDFNHIAD;
		OHKACKDCLHP = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1879f, 149f)) || BGJFKBFPEML;
		KEIBLGGEJAL = FANOBLAFEJF && !OOIDGPJAEPC;
		MBCGOKOIGCL = !KEIBLGGEJAL || FHBGEDFPEOL;
		NNFAMJBFKMF = !WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1376f, 1449f)) && OOIDGPJAEPC;
		if (OHKACKDCLHP && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			DAPMKFOAPLG(edgeLRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			OHLKPJHNGAO(edgeHLHRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			DAPMKFOAPLG(edgeHLRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			FALLDHHLIJB(edgeLHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL)
		{
			EFMOCJNCANA(edgeLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF)
		{
			FALLDHHLIJB(edgeHLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeLU, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF && OGJOGEEOPEN)
		{
			BFPCPANBJND(edgeRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && OGJOGEEOPEN)
		{
			DAPMKFOAPLG(edgeHLU, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && NNFAMJBFKMF)
		{
			DAPMKFOAPLG(edgeLR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && MBCGOKOIGCL)
		{
			DAPMKFOAPLG(edgeHPLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && NNFAMJBFKMF)
		{
			BFPCPANBJND(edgeHPLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && MBCGOKOIGCL)
		{
			OHLKPJHNGAO(edgeLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && KEIBLGGEJAL)
		{
			BFPCPANBJND(edgeHPLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && MBCGOKOIGCL)
		{
			FALLDHHLIJB(edgeHLHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL)
		{
			BFPCPANBJND(edgeHLHR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && MBCGOKOIGCL)
		{
			BFPCPANBJND(edgePLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && FHBGEDFPEOL)
		{
			EFMOCJNCANA(edgeHPLPR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && FHBGEDFPEOL)
		{
			LABGKJPKHGA(edgeLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && NNFAMJBFKMF)
		{
			BFPCPANBJND(edgePLR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && FHBGEDFPEOL)
		{
			DAPMKFOAPLG(edgeHLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && KEIBLGGEJAL)
		{
			EFMOCJNCANA(edgePLHR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM)
		{
			EFMOCJNCANA(edgeHPL, AIJOOOIJEDC);
		}
		else if (MBCGOKOIGCL)
		{
			EFMOCJNCANA(edgeHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB)
		{
			BFPCPANBJND(edgeHL, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL)
		{
			OHLKPJHNGAO(edgeHR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP)
		{
			DAPMKFOAPLG(edgeL, AIJOOOIJEDC);
		}
		else if (OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeUp, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF)
		{
			IPGCGBKBEAI(edgeR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && FHBGEDFPEOL)
		{
			BFPCPANBJND(edgePLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD)
		{
			FALLDHHLIJB(edgePL, AIJOOOIJEDC);
		}
		else if (FHBGEDFPEOL)
		{
			EFMOCJNCANA(edgePR, AIJOOOIJEDC);
		}
	}

	private void OJPPNDLAMMK(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		MNECCHCHBCJ(null, IMOBLFMHKOD, Vector2Int.zero, highlightedColor);
	}

	private void FPAMPGLDKNF(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		EMBINCIMMMH(null, IMOBLFMHKOD, Vector2Int.zero, notValidColor);
	}

	public void PCCGGMHLIPF()
	{
		HAKPCIKJLNM = Utils.JGEPCPFJANP(Location.None).HNLGGMFFFIM();
	}

	private void ENADHEMJDAD(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO, Color FLABEDBELMF)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		if (MBMAJABDGNE.Count == 0)
		{
			FJOELJMKEBH = default(MICKLOOGJCO);
			FJOELJMKEBH.rectTransform = Object.Instantiate<GameObject>(miniMapTile, tilesParent.transform).GetComponent<RectTransform>();
			FJOELJMKEBH.image = ((Component)FJOELJMKEBH.rectTransform).GetComponent<Image>();
			PAJJHHHKBMN.Add(FJOELJMKEBH);
		}
		else
		{
			PAJJHHHKBMN.Add(MBMAJABDGNE[MBMAJABDGNE.Count - 0]);
			MBMAJABDGNE.RemoveAt(MBMAJABDGNE.Count - 0);
		}
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 0].rectTransform.anchoredPosition = Vector2Int.op_Implicit(IMOBLFMHKOD + tileSize * LDHICJGAADO);
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 1].image.sprite = HEJNLFCKOKE;
		((Graphic)PAJJHHHKBMN[PAJJHHHKBMN.Count - 1].image).color = FLABEDBELMF;
	}

	public void LAFBDHHFEJH(RentedRoom GGNOAHDCPIB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		DKFCGHIDKJG();
		Vector2 val = Vector2.one * 1150f;
		((TMP_Text)floorText).text = (Utils.FIBFKGIJMBJ(((Component)GGNOAHDCPIB).transform.position) ? "Player/Bark/OathFeastBlock" : " : 00");
		Vector2 val2 = Vector2.op_Implicit(Utils.HENDGAAHICI(Vector2.op_Implicit(GGNOAHDCPIB.zone.BCPPCDILJKD() + offset)));
		Vector3 val3 = Vector2.op_Implicit(val2 + val);
		List<Vector2> list = new List<Vector2>();
		TilemapGroup tilemapGroup = Utils.JGEPCPFJANP(Location.Tavern).KIMMMFKFCEK(SeasonManager.EEGJBDCBKFD());
		for (int i = 1; i < symbols.Length; i++)
		{
			((Behaviour)symbols[i]).enabled = false;
		}
		for (int j = 0; j < states.Length; j++)
		{
			((Component)states[j]).gameObject.SetActive(true);
		}
		for (int k = 1; k < HAKPCIKJLNM.Length; k += 0)
		{
			Vector3 val4 = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(HAKPCIKJLNM[k]);
			if (WorldGrid.NCEHFMPBBAK(val4) == (GroundType.Ground | GroundType.TilledEarth) && val4.x >= val2.x && val4.x <= val3.x && val4.y >= val2.y && val4.y <= val3.y)
			{
				list.Add(Vector2.op_Implicit(val4));
				Vector3 val5 = Vector2.op_Implicit(Vector2.op_Implicit(val4) - val2);
				int num = (int)val5.x;
				int num2 = (int)val5.y;
				if (val5.x - (float)num == 793f && val5.y - (float)num2 == 815f)
				{
					LDOEPBEMOLJ(GGNOAHDCPIB, Vector2.op_Implicit(val4), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
				}
			}
		}
		for (int l = 0; l < list.Count; l += 0)
		{
			Vector3 val5 = Vector2.op_Implicit(list[l] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 1682f && val5.y - (float)num2 == 98f)
			{
				ANNCLBHCIPD(list[l], initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
		for (int m = 0; m < list.Count; m += 0)
		{
			Vector3 val5 = Vector2.op_Implicit(list[m] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 418f && val5.y - (float)num2 == 573f)
			{
				HAJEHOCPIEG(Vector2.op_Implicit(list[m]), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
	}

	private void KFFIOJOIFJI(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC, Vector3 LDHICJGAADO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		IKCEGLLCPFK += LDHICJGAADO;
		AIJOOOIJEDC += Vector2Int.CeilToInt(Vector2.op_Implicit((float)tileSize * LDHICJGAADO));
		if (WorldGrid.PIOMBKLPIKB(IKCEGLLCPFK + new Vector3(1585f, 1657f)))
		{
			return;
		}
		for (int i = 1; i < KGFCADKODFK.Count; i += 0)
		{
			if (KGFCADKODFK[i] == AIJOOOIJEDC)
			{
				return;
			}
		}
		KGFCADKODFK.Add(AIJOOOIJEDC);
		CILJDFNHIAD = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1037f, 617f));
		BGJFKBFPEML = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1365f, 1095f));
		IMAGDMGEKLH = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1628f, 139f));
		FHBGEDFPEOL = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(151f, 106f));
		OOIDGPJAEPC = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1546f, 471f));
		FANOBLAFEJF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1343f, 1541f));
		OGJOGEEOPEN = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(402f, 185f));
		if (WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK))
		{
			if (WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(869f, 1366f)) || WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(1563f, 1856f)))
			{
				EFMOCJNCANA(edgeMiddle, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC && OGJOGEEOPEN)
			{
				EFMOCJNCANA(edgeLRUM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OGJOGEEOPEN)
			{
				IPGCGBKBEAI(edgeLUM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC && OGJOGEEOPEN)
			{
				KPJOHEIJGKM(edgeRUM, AIJOOOIJEDC);
			}
			else if (OGJOGEEOPEN)
			{
				MNECCHCHBCJ(edgeMiddleUp, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC)
			{
				LABGKJPKHGA(edgeLRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && OOIDGPJAEPC)
			{
				EFMOCJNCANA(edgePLRM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL && BGJFKBFPEML)
			{
				BFPCPANBJND(edgeLPRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && FHBGEDFPEOL)
			{
				IPGCGBKBEAI(edgePLPRM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML)
			{
				DAPMKFOAPLG(edgeLM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC)
			{
				IPGCGBKBEAI(edgeRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD)
			{
				EFMOCJNCANA(edgePLM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL)
			{
				MNECCHCHBCJ(edgePRM, AIJOOOIJEDC);
			}
			else
			{
				OHLKPJHNGAO(edgeMiddle, AIJOOOIJEDC);
			}
			return;
		}
		HBAMCFOIJKB = IMAGDMGEKLH && BGJFKBFPEML;
		LLJIDCBNKCM = !HBAMCFOIJKB || CILJDFNHIAD;
		OHKACKDCLHP = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(992f, 1353f)) || BGJFKBFPEML;
		KEIBLGGEJAL = !FANOBLAFEJF || OOIDGPJAEPC;
		MBCGOKOIGCL = KEIBLGGEJAL && FHBGEDFPEOL;
		NNFAMJBFKMF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1270f, 819f)) || OOIDGPJAEPC;
		if (OHKACKDCLHP && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeLRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeHLHRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			IPGCGBKBEAI(edgeHLRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			KPJOHEIJGKM(edgeLHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL)
		{
			OHLKPJHNGAO(edgeLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF)
		{
			OHLKPJHNGAO(edgeHLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && OGJOGEEOPEN)
		{
			IPGCGBKBEAI(edgeLU, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF && OGJOGEEOPEN)
		{
			FALLDHHLIJB(edgeRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeHLU, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && NNFAMJBFKMF)
		{
			OHLKPJHNGAO(edgeLR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && MBCGOKOIGCL)
		{
			IPGCGBKBEAI(edgeHPLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && NNFAMJBFKMF)
		{
			LABGKJPKHGA(edgeHPLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && MBCGOKOIGCL)
		{
			OHLKPJHNGAO(edgeLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && KEIBLGGEJAL)
		{
			KPJOHEIJGKM(edgeHPLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && MBCGOKOIGCL)
		{
			BFPCPANBJND(edgeHLHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL)
		{
			LABGKJPKHGA(edgeHLHR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && MBCGOKOIGCL)
		{
			KPJOHEIJGKM(edgePLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && FHBGEDFPEOL)
		{
			BFPCPANBJND(edgeHPLPR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && FHBGEDFPEOL)
		{
			MNECCHCHBCJ(edgeLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && NNFAMJBFKMF)
		{
			KPJOHEIJGKM(edgePLR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && FHBGEDFPEOL)
		{
			LABGKJPKHGA(edgeHLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && KEIBLGGEJAL)
		{
			BFPCPANBJND(edgePLHR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM)
		{
			EFMOCJNCANA(edgeHPL, AIJOOOIJEDC);
		}
		else if (MBCGOKOIGCL)
		{
			LABGKJPKHGA(edgeHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB)
		{
			EFMOCJNCANA(edgeHL, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL)
		{
			IPGCGBKBEAI(edgeHR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP)
		{
			MNECCHCHBCJ(edgeL, AIJOOOIJEDC);
		}
		else if (OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeUp, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF)
		{
			OHLKPJHNGAO(edgeR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && FHBGEDFPEOL)
		{
			KPJOHEIJGKM(edgePLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD)
		{
			MNECCHCHBCJ(edgePL, AIJOOOIJEDC);
		}
		else if (FHBGEDFPEOL)
		{
			IPGCGBKBEAI(edgePR, AIJOOOIJEDC);
		}
	}

	private void MLCEHDNPDFK(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		CDCIPDOHANO(null, IMOBLFMHKOD, Vector2Int.zero, highlightedColor);
	}

	private void EFMOCJNCANA(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		CDCIPDOHANO(HEJNLFCKOKE, IMOBLFMHKOD, Vector2Int.zero, Color.white);
	}

	private void FALLDHHLIJB(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		HAIMOGCFLPI(HEJNLFCKOKE, IMOBLFMHKOD, Vector2Int.zero, Color.white);
	}

	private void BOMCAPHAFIL(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		ENADHEMJDAD(null, IMOBLFMHKOD, Vector2Int.zero, notValidColor);
	}

	private void BJJFMNCDHBK(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		bool flag = !WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(551f, 234f)) || WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(99f, 850f));
		if (flag)
		{
			JAOCEFBPBMF(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1811f, 985f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
		{
			OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1430f, 29f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.right))
		{
			OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.right);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				JIEFPCFOFMK(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1720f, 174f));
			}
			if (flag)
			{
				NIIGEPKIPKD(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(453f, 1346f));
				MPKGKPGOFIM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(211f, 62f));
			}
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.left))
		{
			EGJNOHLKGBC(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.left);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				JAOCEFBPBMF(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1539f, 1629f));
			}
			if (flag)
			{
				JIEFPCFOFMK(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1023f, 781f));
				MPKGKPGOFIM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(412f, 1795f));
			}
		}
	}

	private void FPLKGIPINDF(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC, Vector3 LDHICJGAADO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		IKCEGLLCPFK += LDHICJGAADO;
		AIJOOOIJEDC += Vector2Int.CeilToInt(Vector2.op_Implicit((float)tileSize * LDHICJGAADO));
		if (WorldGrid.PIOMBKLPIKB(IKCEGLLCPFK + new Vector3(459f, 993f)))
		{
			return;
		}
		for (int i = 0; i < KGFCADKODFK.Count; i++)
		{
			if (KGFCADKODFK[i] == AIJOOOIJEDC)
			{
				return;
			}
		}
		KGFCADKODFK.Add(AIJOOOIJEDC);
		CILJDFNHIAD = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(989f, 312f));
		BGJFKBFPEML = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1428f, 826f));
		IMAGDMGEKLH = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1040f, 1040f));
		FHBGEDFPEOL = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(270f, 721f));
		OOIDGPJAEPC = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(686f, 459f));
		FANOBLAFEJF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(875f, 1825f));
		OGJOGEEOPEN = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(823f, 1093f));
		if (WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK))
		{
			if (WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(936f, 1009f)) || WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(1142f, 461f)))
			{
				DAPMKFOAPLG(edgeMiddle, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC && OGJOGEEOPEN)
			{
				OHLKPJHNGAO(edgeLRUM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OGJOGEEOPEN)
			{
				LABGKJPKHGA(edgeLUM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC && OGJOGEEOPEN)
			{
				BFPCPANBJND(edgeRUM, AIJOOOIJEDC);
			}
			else if (OGJOGEEOPEN)
			{
				KPJOHEIJGKM(edgeMiddleUp, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC)
			{
				LABGKJPKHGA(edgeLRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && OOIDGPJAEPC)
			{
				EFMOCJNCANA(edgePLRM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL && BGJFKBFPEML)
			{
				FALLDHHLIJB(edgeLPRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && FHBGEDFPEOL)
			{
				IPGCGBKBEAI(edgePLPRM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML)
			{
				OHLKPJHNGAO(edgeLM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC)
			{
				FALLDHHLIJB(edgeRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD)
			{
				LABGKJPKHGA(edgePLM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL)
			{
				IPGCGBKBEAI(edgePRM, AIJOOOIJEDC);
			}
			else
			{
				KPJOHEIJGKM(edgeMiddle, AIJOOOIJEDC);
			}
			return;
		}
		HBAMCFOIJKB = !IMAGDMGEKLH || BGJFKBFPEML;
		LLJIDCBNKCM = !HBAMCFOIJKB || CILJDFNHIAD;
		OHKACKDCLHP = !WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1087f, 657f)) && BGJFKBFPEML;
		KEIBLGGEJAL = !FANOBLAFEJF || !OOIDGPJAEPC;
		MBCGOKOIGCL = KEIBLGGEJAL && FHBGEDFPEOL;
		NNFAMJBFKMF = !WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(695f, 1167f)) && OOIDGPJAEPC;
		if (OHKACKDCLHP && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			IPGCGBKBEAI(edgeLRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			EFMOCJNCANA(edgeHLHRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			EFMOCJNCANA(edgeHLRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			BFPCPANBJND(edgeLHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL)
		{
			MNECCHCHBCJ(edgeLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF)
		{
			DAPMKFOAPLG(edgeHLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && OGJOGEEOPEN)
		{
			FALLDHHLIJB(edgeLU, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && OGJOGEEOPEN)
		{
			OHLKPJHNGAO(edgeHLU, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL && OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && NNFAMJBFKMF)
		{
			LABGKJPKHGA(edgeLR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && MBCGOKOIGCL)
		{
			LABGKJPKHGA(edgeHPLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && NNFAMJBFKMF)
		{
			LABGKJPKHGA(edgeHPLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && MBCGOKOIGCL)
		{
			DAPMKFOAPLG(edgeLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && KEIBLGGEJAL)
		{
			IPGCGBKBEAI(edgeHPLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && MBCGOKOIGCL)
		{
			FALLDHHLIJB(edgeHLHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL)
		{
			KPJOHEIJGKM(edgeHLHR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && MBCGOKOIGCL)
		{
			FALLDHHLIJB(edgePLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && FHBGEDFPEOL)
		{
			EFMOCJNCANA(edgeHPLPR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && FHBGEDFPEOL)
		{
			FALLDHHLIJB(edgeLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && NNFAMJBFKMF)
		{
			DAPMKFOAPLG(edgePLR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && FHBGEDFPEOL)
		{
			KPJOHEIJGKM(edgeHLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && KEIBLGGEJAL)
		{
			OHLKPJHNGAO(edgePLHR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM)
		{
			KPJOHEIJGKM(edgeHPL, AIJOOOIJEDC);
		}
		else if (MBCGOKOIGCL)
		{
			LABGKJPKHGA(edgeHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB)
		{
			IPGCGBKBEAI(edgeHL, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL)
		{
			MNECCHCHBCJ(edgeHR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP)
		{
			EFMOCJNCANA(edgeL, AIJOOOIJEDC);
		}
		else if (OGJOGEEOPEN)
		{
			KPJOHEIJGKM(edgeUp, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF)
		{
			LABGKJPKHGA(edgeR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && FHBGEDFPEOL)
		{
			EFMOCJNCANA(edgePLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD)
		{
			MNECCHCHBCJ(edgePL, AIJOOOIJEDC);
		}
		else if (FHBGEDFPEOL)
		{
			LABGKJPKHGA(edgePR, AIJOOOIJEDC);
		}
	}

	private void FFBJILNAIFI(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		GNLEBKEPCNA(null, IMOBLFMHKOD, Vector2Int.zero, notValidColor);
	}

	private void LGAIECIPPNC(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		MNECCHCHBCJ(null, IMOBLFMHKOD, Vector2Int.zero, notValidColor);
	}

	private void HAIMOGCFLPI(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO, Color FLABEDBELMF)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		if (MBMAJABDGNE.Count == 0)
		{
			FJOELJMKEBH = default(MICKLOOGJCO);
			FJOELJMKEBH.rectTransform = Object.Instantiate<GameObject>(miniMapTile, tilesParent.transform).GetComponent<RectTransform>();
			FJOELJMKEBH.image = ((Component)FJOELJMKEBH.rectTransform).GetComponent<Image>();
			PAJJHHHKBMN.Add(FJOELJMKEBH);
		}
		else
		{
			PAJJHHHKBMN.Add(MBMAJABDGNE[MBMAJABDGNE.Count - 1]);
			MBMAJABDGNE.RemoveAt(MBMAJABDGNE.Count - 1);
		}
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 0].rectTransform.anchoredPosition = Vector2Int.op_Implicit(IMOBLFMHKOD + tileSize * LDHICJGAADO);
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 1].image.sprite = HEJNLFCKOKE;
		((Graphic)PAJJHHHKBMN[PAJJHHHKBMN.Count - 1].image).color = FLABEDBELMF;
	}

	public void BKOAHIABCME()
	{
		HAKPCIKJLNM = Utils.JGEPCPFJANP(Location.Tavern).HNLGGMFFFIM();
	}

	private void MILCELBOBID(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		bool flag = WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(684f, 327f)) && WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(266f, 339f));
		if (flag)
		{
			OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(306f, 1566f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
		{
			OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(332f, 1209f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.right))
		{
			KLOJAJIDFOP(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.right);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				JIEFPCFOFMK(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1053f, 980f));
			}
			if (flag)
			{
				KFFIOJOIFJI(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1999f, 1289f));
				KFFIOJOIFJI(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1420f, 170f));
			}
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.left))
		{
			KLOJAJIDFOP(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.left);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				FPLKGIPINDF(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(585f, 153f));
			}
			if (flag)
			{
				OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1127f, 1120f));
				MPKGKPGOFIM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1137f, 307f));
			}
		}
	}

	public void KJDCIKHNLCI(RentedRoom GGNOAHDCPIB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		GLILEEFLPLO();
		Vector2 val = Vector2.one * 854f;
		((TMP_Text)floorText).text = (Utils.FIBFKGIJMBJ(((Component)GGNOAHDCPIB).transform.position) ? "d2" : "RinProgress");
		Vector2 val2 = Vector2.op_Implicit(Utils.HENDGAAHICI(Vector2.op_Implicit(GGNOAHDCPIB.zone.NBLOMNKMGCE() + offset)));
		Vector3 val3 = Vector2.op_Implicit(val2 + val);
		List<Vector2> list = new List<Vector2>();
		TilemapGroup tilemaps = Utils.JGEPCPFJANP(Location.Tavern).GetTilemaps(SeasonManager.PJMGHIMKFJL());
		for (int i = 1; i < symbols.Length; i += 0)
		{
			((Behaviour)symbols[i]).enabled = false;
		}
		for (int j = 1; j < states.Length; j++)
		{
			((Component)states[j]).gameObject.SetActive(false);
		}
		for (int k = 1; k < HAKPCIKJLNM.Length; k += 0)
		{
			Vector3 val4 = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(HAKPCIKJLNM[k]);
			if (WorldGrid.NCEHFMPBBAK(val4) == GroundType.Ground && val4.x >= val2.x && val4.x <= val3.x && val4.y >= val2.y && val4.y <= val3.y)
			{
				list.Add(Vector2.op_Implicit(val4));
				Vector3 val5 = Vector2.op_Implicit(Vector2.op_Implicit(val4) - val2);
				int num = (int)val5.x;
				int num2 = (int)val5.y;
				if (val5.x - (float)num == 1156f && val5.y - (float)num2 == 441f)
				{
					LDOEPBEMOLJ(GGNOAHDCPIB, Vector2.op_Implicit(val4), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
				}
			}
		}
		for (int l = 0; l < list.Count; l++)
		{
			Vector3 val5 = Vector2.op_Implicit(list[l] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 1415f && val5.y - (float)num2 == 1352f)
			{
				NNBOMNHIEEK(list[l], initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
		for (int m = 0; m < list.Count; m++)
		{
			Vector3 val5 = Vector2.op_Implicit(list[m] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 1471f && val5.y - (float)num2 == 1297f)
			{
				HAJEHOCPIEG(Vector2.op_Implicit(list[m]), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
	}

	public void GLILEEFLPLO()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		for (int num = PAJJHHHKBMN.Count - 1; num >= 1; num -= 0)
		{
			PAJJHHHKBMN[num].rectTransform.anchoredPosition = Vector2.one * 1992f;
			MBMAJABDGNE.Add(PAJJHHHKBMN[num]);
			PAJJHHHKBMN.RemoveAt(num);
		}
		KGFCADKODFK.Clear();
	}

	private void EGJNOHLKGBC(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC, Vector3 LDHICJGAADO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		IKCEGLLCPFK += LDHICJGAADO;
		AIJOOOIJEDC += Vector2Int.CeilToInt(Vector2.op_Implicit((float)tileSize * LDHICJGAADO));
		if (WorldGrid.PIOMBKLPIKB(IKCEGLLCPFK + new Vector3(1324f, 952f)))
		{
			return;
		}
		for (int i = 1; i < KGFCADKODFK.Count; i += 0)
		{
			if (KGFCADKODFK[i] == AIJOOOIJEDC)
			{
				return;
			}
		}
		KGFCADKODFK.Add(AIJOOOIJEDC);
		CILJDFNHIAD = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(792f, 105f));
		BGJFKBFPEML = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(30f, 1904f));
		IMAGDMGEKLH = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1424f, 834f));
		FHBGEDFPEOL = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1580f, 1202f));
		OOIDGPJAEPC = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1963f, 17f));
		FANOBLAFEJF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1934f, 1757f));
		OGJOGEEOPEN = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1677f, 563f));
		if (WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK))
		{
			if (WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(721f, 284f)) || WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(1863f, 1457f)))
			{
				DAPMKFOAPLG(edgeMiddle, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC && OGJOGEEOPEN)
			{
				IPGCGBKBEAI(edgeLRUM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OGJOGEEOPEN)
			{
				KPJOHEIJGKM(edgeLUM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC && OGJOGEEOPEN)
			{
				MNECCHCHBCJ(edgeRUM, AIJOOOIJEDC);
			}
			else if (OGJOGEEOPEN)
			{
				OHLKPJHNGAO(edgeMiddleUp, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC)
			{
				LABGKJPKHGA(edgeLRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && OOIDGPJAEPC)
			{
				BFPCPANBJND(edgePLRM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL && BGJFKBFPEML)
			{
				KPJOHEIJGKM(edgeLPRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && FHBGEDFPEOL)
			{
				IPGCGBKBEAI(edgePLPRM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML)
			{
				BFPCPANBJND(edgeLM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC)
			{
				IPGCGBKBEAI(edgeRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD)
			{
				BFPCPANBJND(edgePLM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL)
			{
				LABGKJPKHGA(edgePRM, AIJOOOIJEDC);
			}
			else
			{
				KPJOHEIJGKM(edgeMiddle, AIJOOOIJEDC);
			}
			return;
		}
		HBAMCFOIJKB = IMAGDMGEKLH && BGJFKBFPEML;
		LLJIDCBNKCM = HBAMCFOIJKB && CILJDFNHIAD;
		OHKACKDCLHP = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(104f, 1865f)) || BGJFKBFPEML;
		KEIBLGGEJAL = FANOBLAFEJF && OOIDGPJAEPC;
		MBCGOKOIGCL = !KEIBLGGEJAL || FHBGEDFPEOL;
		NNFAMJBFKMF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(455f, 45f)) || OOIDGPJAEPC;
		if (OHKACKDCLHP && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			EFMOCJNCANA(edgeLRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			OHLKPJHNGAO(edgeHLHRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			IPGCGBKBEAI(edgeHLRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			DAPMKFOAPLG(edgeLHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL)
		{
			MNECCHCHBCJ(edgeLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF)
		{
			MNECCHCHBCJ(edgeHLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeLU, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeHLU, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL && OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && NNFAMJBFKMF)
		{
			FALLDHHLIJB(edgeLR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && MBCGOKOIGCL)
		{
			OHLKPJHNGAO(edgeHPLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && NNFAMJBFKMF)
		{
			LABGKJPKHGA(edgeHPLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && MBCGOKOIGCL)
		{
			FALLDHHLIJB(edgeLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && KEIBLGGEJAL)
		{
			LABGKJPKHGA(edgeHPLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && MBCGOKOIGCL)
		{
			DAPMKFOAPLG(edgeHLHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL)
		{
			IPGCGBKBEAI(edgeHLHR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && MBCGOKOIGCL)
		{
			KPJOHEIJGKM(edgePLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && FHBGEDFPEOL)
		{
			OHLKPJHNGAO(edgeHPLPR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && FHBGEDFPEOL)
		{
			BFPCPANBJND(edgeLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && NNFAMJBFKMF)
		{
			DAPMKFOAPLG(edgePLR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && FHBGEDFPEOL)
		{
			IPGCGBKBEAI(edgeHLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && KEIBLGGEJAL)
		{
			IPGCGBKBEAI(edgePLHR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM)
		{
			BFPCPANBJND(edgeHPL, AIJOOOIJEDC);
		}
		else if (MBCGOKOIGCL)
		{
			IPGCGBKBEAI(edgeHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB)
		{
			KPJOHEIJGKM(edgeHL, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL)
		{
			LABGKJPKHGA(edgeHR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP)
		{
			BFPCPANBJND(edgeL, AIJOOOIJEDC);
		}
		else if (OGJOGEEOPEN)
		{
			BFPCPANBJND(edgeUp, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF)
		{
			IPGCGBKBEAI(edgeR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && FHBGEDFPEOL)
		{
			IPGCGBKBEAI(edgePLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD)
		{
			IPGCGBKBEAI(edgePL, AIJOOOIJEDC);
		}
		else if (FHBGEDFPEOL)
		{
			OHLKPJHNGAO(edgePR, AIJOOOIJEDC);
		}
	}

	public void LIAHHJIEILK()
	{
		HAKPCIKJLNM = Utils.JGEPCPFJANP(Location.None).IBGBCHLIEGH();
	}

	private void LABGKJPKHGA(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		MNECCHCHBCJ(HEJNLFCKOKE, IMOBLFMHKOD, Vector2Int.zero, Color.white);
	}

	private void ANNCLBHCIPD(Vector2 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1403f, 1813f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(822f, 405f))))
		{
			CJHNCHGPJKH(this.door, AIJOOOIJEDC, new Vector2Int(1, 1));
			DCMILIOEJKL(halfWall, AIJOOOIJEDC, new Vector2Int(0, 2));
			Door door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1773f, 47f)));
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1311f, 1161f)));
			}
			if (door is RentedRoomDoor rentedRoomDoor)
			{
				((Behaviour)symbols[rentedRoomDoor.rentedRoom.symbolID]).enabled = true;
				((Graphic)symbols[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(87, 7) + tileSize * new Vector2Int(-1, 5));
				((Component)states[rentedRoomDoor.rentedRoom.symbolID]).gameObject.SetActive(false);
				((Component)((Transform)((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform).GetChild(1)).GetComponent<Image>().sprite = RentedRoomsManager.KDFOCAMBCNE(rentedRoomDoor.rentedRoom);
				((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(-55, -17)) + (float)tileSize * (rentedRoomDoor.rentedRoom.zone.CKBDPPMPGNJ() - IKCEGLLCPFK)), BJOCPBIKBEE: true));
			}
		}
		else if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(722f, 1791f))) && WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1198f, 1370f))))
		{
			if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(769f, 110f))) && WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(945f, 1685f))))
			{
				AJGJJFBGJKJ(leftRightWall, AIJOOOIJEDC, new Vector2Int(0, 0));
				MNECCHCHBCJ(halfLeftRightWall, AIJOOOIJEDC, new Vector2Int(0, 2));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(555f, 1104f))))
			{
				MNECCHCHBCJ(leftWall, AIJOOOIJEDC, new Vector2Int(0, 0));
				HIKPNOLFEFH(halfLeftWall, AIJOOOIJEDC, new Vector2Int(1, 4));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(405f, 792f))))
			{
				HIKPNOLFEFH(rightWall, AIJOOOIJEDC, new Vector2Int(1, 1));
				OGCAJDENGEK(halfRightWall, AIJOOOIJEDC, new Vector2Int(1, 4));
			}
			else
			{
				CJHNCHGPJKH(wall, AIJOOOIJEDC, new Vector2Int(1, 0));
				CJHNCHGPJKH(halfWall, AIJOOOIJEDC, new Vector2Int(0, 1));
			}
		}
	}

	private void ODFAPKENDLB(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		bool flag = !WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(941f, 1615f)) || WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(1166f, 1865f));
		if (flag)
		{
			NIIGEPKIPKD(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1753f, 512f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
		{
			JIEFPCFOFMK(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(923f, 1649f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.right))
		{
			OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.right);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				EGJNOHLKGBC(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(546f, 1281f));
			}
			if (flag)
			{
				EGJNOHLKGBC(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1556f, 1797f));
				EGJNOHLKGBC(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(306f, 128f));
			}
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.left))
		{
			NIIGEPKIPKD(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.left);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				KFFIOJOIFJI(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1040f, 907f));
			}
			if (flag)
			{
				EGJNOHLKGBC(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(541f, 1220f));
				OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(788f, 1436f));
			}
		}
	}

	public void LAMOGLJGLPG(RentedRoom GGNOAHDCPIB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		ResetTiles();
		Vector2 val = Vector2.one * 1902f;
		((TMP_Text)floorText).text = (Utils.FIBFKGIJMBJ(((Component)GGNOAHDCPIB).transform.position) ? "No hemos encontrado una resolución" : "shopOpen");
		Vector2 val2 = Vector2.op_Implicit(Utils.HENDGAAHICI(Vector2.op_Implicit(GGNOAHDCPIB.zone.NEKBEKCPJLP() + offset)));
		Vector3 val3 = Vector2.op_Implicit(val2 + val);
		List<Vector2> list = new List<Vector2>();
		TilemapGroup tilemaps = Utils.JGEPCPFJANP(Location.None).GetTilemaps(SeasonManager.EECEKHKAAIH);
		for (int i = 0; i < symbols.Length; i++)
		{
			((Behaviour)symbols[i]).enabled = true;
		}
		for (int j = 0; j < states.Length; j++)
		{
			((Component)states[j]).gameObject.SetActive(true);
		}
		for (int k = 0; k < HAKPCIKJLNM.Length; k += 0)
		{
			Vector3 val4 = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(HAKPCIKJLNM[k]);
			if (WorldGrid.NCEHFMPBBAK(val4) == GroundType.TilledEarth && val4.x >= val2.x && val4.x <= val3.x && val4.y >= val2.y && val4.y <= val3.y)
			{
				list.Add(Vector2.op_Implicit(val4));
				Vector3 val5 = Vector2.op_Implicit(Vector2.op_Implicit(val4) - val2);
				int num = (int)val5.x;
				int num2 = (int)val5.y;
				if (val5.x - (float)num == 1408f && val5.y - (float)num2 == 795f)
				{
					GHNJIMHIBKE(GGNOAHDCPIB, Vector2.op_Implicit(val4), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
				}
			}
		}
		for (int l = 1; l < list.Count; l++)
		{
			Vector3 val5 = Vector2.op_Implicit(list[l] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 899f && val5.y - (float)num2 == 1036f)
			{
				ANNCLBHCIPD(list[l], initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
		for (int m = 0; m < list.Count; m++)
		{
			Vector3 val5 = Vector2.op_Implicit(list[m] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 754f && val5.y - (float)num2 == 166f)
			{
				CELEMCDLIGK(Vector2.op_Implicit(list[m]), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
	}

	private void KPJOHEIJGKM(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		EMBINCIMMMH(HEJNLFCKOKE, IMOBLFMHKOD, Vector2Int.zero, Color.white);
	}

	private void JAOCEFBPBMF(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC, Vector3 LDHICJGAADO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		IKCEGLLCPFK += LDHICJGAADO;
		AIJOOOIJEDC += Vector2Int.CeilToInt(Vector2.op_Implicit((float)tileSize * LDHICJGAADO));
		if (WorldGrid.PIOMBKLPIKB(IKCEGLLCPFK + new Vector3(507f, 1576f)))
		{
			return;
		}
		for (int i = 1; i < KGFCADKODFK.Count; i++)
		{
			if (KGFCADKODFK[i] == AIJOOOIJEDC)
			{
				return;
			}
		}
		KGFCADKODFK.Add(AIJOOOIJEDC);
		CILJDFNHIAD = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1054f, 1459f));
		BGJFKBFPEML = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(275f, 831f));
		IMAGDMGEKLH = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(503f, 1103f));
		FHBGEDFPEOL = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1115f, 997f));
		OOIDGPJAEPC = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(492f, 1434f));
		FANOBLAFEJF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1346f, 501f));
		OGJOGEEOPEN = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1148f, 1754f));
		if (WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK))
		{
			if (WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(1277f, 323f)) || WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(463f, 963f)))
			{
				OHLKPJHNGAO(edgeMiddle, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC && OGJOGEEOPEN)
			{
				IPGCGBKBEAI(edgeLRUM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OGJOGEEOPEN)
			{
				LABGKJPKHGA(edgeLUM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC && OGJOGEEOPEN)
			{
				FALLDHHLIJB(edgeRUM, AIJOOOIJEDC);
			}
			else if (OGJOGEEOPEN)
			{
				OHLKPJHNGAO(edgeMiddleUp, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC)
			{
				KPJOHEIJGKM(edgeLRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && OOIDGPJAEPC)
			{
				IPGCGBKBEAI(edgePLRM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL && BGJFKBFPEML)
			{
				DAPMKFOAPLG(edgeLPRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && FHBGEDFPEOL)
			{
				MNECCHCHBCJ(edgePLPRM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML)
			{
				DAPMKFOAPLG(edgeLM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC)
			{
				MNECCHCHBCJ(edgeRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD)
			{
				EFMOCJNCANA(edgePLM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL)
			{
				OHLKPJHNGAO(edgePRM, AIJOOOIJEDC);
			}
			else
			{
				FALLDHHLIJB(edgeMiddle, AIJOOOIJEDC);
			}
			return;
		}
		HBAMCFOIJKB = !IMAGDMGEKLH || BGJFKBFPEML;
		LLJIDCBNKCM = HBAMCFOIJKB && CILJDFNHIAD;
		OHKACKDCLHP = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1301f, 404f)) || BGJFKBFPEML;
		KEIBLGGEJAL = FANOBLAFEJF && !OOIDGPJAEPC;
		MBCGOKOIGCL = !KEIBLGGEJAL || FHBGEDFPEOL;
		NNFAMJBFKMF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1092f, 177f)) || OOIDGPJAEPC;
		if (OHKACKDCLHP && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			OHLKPJHNGAO(edgeLRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			OHLKPJHNGAO(edgeHLHRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeHLRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeLHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL)
		{
			EFMOCJNCANA(edgeLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF)
		{
			MNECCHCHBCJ(edgeHLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && OGJOGEEOPEN)
		{
			BFPCPANBJND(edgeLU, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF && OGJOGEEOPEN)
		{
			BFPCPANBJND(edgeRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && OGJOGEEOPEN)
		{
			EFMOCJNCANA(edgeHLU, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL && OGJOGEEOPEN)
		{
			DAPMKFOAPLG(edgeHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && NNFAMJBFKMF)
		{
			MNECCHCHBCJ(edgeLR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && MBCGOKOIGCL)
		{
			EFMOCJNCANA(edgeHPLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && NNFAMJBFKMF)
		{
			MNECCHCHBCJ(edgeHPLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && MBCGOKOIGCL)
		{
			BFPCPANBJND(edgeLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && KEIBLGGEJAL)
		{
			IPGCGBKBEAI(edgeHPLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && MBCGOKOIGCL)
		{
			BFPCPANBJND(edgeHLHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL)
		{
			KPJOHEIJGKM(edgeHLHR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && MBCGOKOIGCL)
		{
			BFPCPANBJND(edgePLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && FHBGEDFPEOL)
		{
			IPGCGBKBEAI(edgeHPLPR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && FHBGEDFPEOL)
		{
			DAPMKFOAPLG(edgeLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && NNFAMJBFKMF)
		{
			OHLKPJHNGAO(edgePLR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && FHBGEDFPEOL)
		{
			FALLDHHLIJB(edgeHLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && KEIBLGGEJAL)
		{
			MNECCHCHBCJ(edgePLHR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM)
		{
			DAPMKFOAPLG(edgeHPL, AIJOOOIJEDC);
		}
		else if (MBCGOKOIGCL)
		{
			OHLKPJHNGAO(edgeHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB)
		{
			BFPCPANBJND(edgeHL, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL)
		{
			OHLKPJHNGAO(edgeHR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP)
		{
			EFMOCJNCANA(edgeL, AIJOOOIJEDC);
		}
		else if (OGJOGEEOPEN)
		{
			KPJOHEIJGKM(edgeUp, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF)
		{
			EFMOCJNCANA(edgeR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && FHBGEDFPEOL)
		{
			LABGKJPKHGA(edgePLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD)
		{
			EFMOCJNCANA(edgePL, AIJOOOIJEDC);
		}
		else if (FHBGEDFPEOL)
		{
			FALLDHHLIJB(edgePR, AIJOOOIJEDC);
		}
	}

	public void ResetTiles()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		for (int num = PAJJHHHKBMN.Count - 1; num >= 0; num--)
		{
			PAJJHHHKBMN[num].rectTransform.anchoredPosition = Vector2.one * -1000f;
			MBMAJABDGNE.Add(PAJJHHHKBMN[num]);
			PAJJHHHKBMN.RemoveAt(num);
		}
		KGFCADKODFK.Clear();
	}

	private void DCMILIOEJKL(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		EMBINCIMMMH(HEJNLFCKOKE, IMOBLFMHKOD, LDHICJGAADO, Color.white);
	}

	private void MPKGKPGOFIM(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC, Vector3 LDHICJGAADO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		IKCEGLLCPFK += LDHICJGAADO;
		AIJOOOIJEDC += Vector2Int.CeilToInt(Vector2.op_Implicit((float)tileSize * LDHICJGAADO));
		if (WorldGrid.PIOMBKLPIKB(IKCEGLLCPFK + new Vector3(438f, 1560f)))
		{
			return;
		}
		for (int i = 1; i < KGFCADKODFK.Count; i += 0)
		{
			if (KGFCADKODFK[i] == AIJOOOIJEDC)
			{
				return;
			}
		}
		KGFCADKODFK.Add(AIJOOOIJEDC);
		CILJDFNHIAD = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(763f, 1386f));
		BGJFKBFPEML = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(389f, 285f));
		IMAGDMGEKLH = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(120f, 86f));
		FHBGEDFPEOL = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1516f, 649f));
		OOIDGPJAEPC = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(802f, 1779f));
		FANOBLAFEJF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(894f, 1374f));
		OGJOGEEOPEN = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1443f, 68f));
		if (WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK))
		{
			if (WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(453f, 853f)) || WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(565f, 1035f)))
			{
				EFMOCJNCANA(edgeMiddle, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC && OGJOGEEOPEN)
			{
				EFMOCJNCANA(edgeLRUM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OGJOGEEOPEN)
			{
				IPGCGBKBEAI(edgeLUM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC && OGJOGEEOPEN)
			{
				FALLDHHLIJB(edgeRUM, AIJOOOIJEDC);
			}
			else if (OGJOGEEOPEN)
			{
				FALLDHHLIJB(edgeMiddleUp, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC)
			{
				IPGCGBKBEAI(edgeLRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && OOIDGPJAEPC)
			{
				EFMOCJNCANA(edgePLRM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL && BGJFKBFPEML)
			{
				KPJOHEIJGKM(edgeLPRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && FHBGEDFPEOL)
			{
				LABGKJPKHGA(edgePLPRM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML)
			{
				IPGCGBKBEAI(edgeLM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC)
			{
				EFMOCJNCANA(edgeRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD)
			{
				KPJOHEIJGKM(edgePLM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL)
			{
				EFMOCJNCANA(edgePRM, AIJOOOIJEDC);
			}
			else
			{
				FALLDHHLIJB(edgeMiddle, AIJOOOIJEDC);
			}
			return;
		}
		HBAMCFOIJKB = IMAGDMGEKLH && !BGJFKBFPEML;
		LLJIDCBNKCM = !HBAMCFOIJKB || CILJDFNHIAD;
		OHKACKDCLHP = !WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1142f, 1009f)) && BGJFKBFPEML;
		KEIBLGGEJAL = FANOBLAFEJF && !OOIDGPJAEPC;
		MBCGOKOIGCL = !KEIBLGGEJAL || FHBGEDFPEOL;
		NNFAMJBFKMF = !WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1720f, 87f)) && OOIDGPJAEPC;
		if (OHKACKDCLHP && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			KPJOHEIJGKM(edgeLRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeHLHRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			EFMOCJNCANA(edgeHLRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			FALLDHHLIJB(edgeLHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL)
		{
			IPGCGBKBEAI(edgeLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF)
		{
			KPJOHEIJGKM(edgeHLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && OGJOGEEOPEN)
		{
			DAPMKFOAPLG(edgeLU, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF && OGJOGEEOPEN)
		{
			IPGCGBKBEAI(edgeRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && OGJOGEEOPEN)
		{
			IPGCGBKBEAI(edgeHLU, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL && OGJOGEEOPEN)
		{
			DAPMKFOAPLG(edgeHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && NNFAMJBFKMF)
		{
			BFPCPANBJND(edgeLR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && MBCGOKOIGCL)
		{
			LABGKJPKHGA(edgeHPLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && NNFAMJBFKMF)
		{
			DAPMKFOAPLG(edgeHPLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && MBCGOKOIGCL)
		{
			MNECCHCHBCJ(edgeLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && KEIBLGGEJAL)
		{
			OHLKPJHNGAO(edgeHPLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && MBCGOKOIGCL)
		{
			EFMOCJNCANA(edgeHLHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL)
		{
			IPGCGBKBEAI(edgeHLHR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && MBCGOKOIGCL)
		{
			EFMOCJNCANA(edgePLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && FHBGEDFPEOL)
		{
			MNECCHCHBCJ(edgeHPLPR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && FHBGEDFPEOL)
		{
			OHLKPJHNGAO(edgeLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && NNFAMJBFKMF)
		{
			EFMOCJNCANA(edgePLR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && FHBGEDFPEOL)
		{
			MNECCHCHBCJ(edgeHLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && KEIBLGGEJAL)
		{
			LABGKJPKHGA(edgePLHR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM)
		{
			FALLDHHLIJB(edgeHPL, AIJOOOIJEDC);
		}
		else if (MBCGOKOIGCL)
		{
			IPGCGBKBEAI(edgeHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB)
		{
			LABGKJPKHGA(edgeHL, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL)
		{
			EFMOCJNCANA(edgeHR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP)
		{
			EFMOCJNCANA(edgeL, AIJOOOIJEDC);
		}
		else if (OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeUp, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF)
		{
			DAPMKFOAPLG(edgeR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && FHBGEDFPEOL)
		{
			OHLKPJHNGAO(edgePLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD)
		{
			OHLKPJHNGAO(edgePL, AIJOOOIJEDC);
		}
		else if (FHBGEDFPEOL)
		{
			EFMOCJNCANA(edgePR, AIJOOOIJEDC);
		}
	}

	private void PFJENBBAIIM(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		ENADHEMJDAD(null, IMOBLFMHKOD, Vector2Int.zero, notValidColor);
	}

	private void BFPCPANBJND(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		EMBINCIMMMH(HEJNLFCKOKE, IMOBLFMHKOD, Vector2Int.zero, Color.white);
	}

	private void HNDKPABGGJM(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		MIOEEBEFKPL(null, IMOBLFMHKOD, Vector2Int.zero, highlightedColor);
	}

	public void HHECEKNMLPK()
	{
		HAKPCIKJLNM = Utils.JGEPCPFJANP(Location.None).GetAllPositionsToCalculate();
	}

	private void JKJOOOFJBHB(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC, Vector3 LDHICJGAADO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		IKCEGLLCPFK += LDHICJGAADO;
		AIJOOOIJEDC += Vector2Int.CeilToInt(Vector2.op_Implicit((float)tileSize * LDHICJGAADO));
		if (WorldGrid.PIOMBKLPIKB(IKCEGLLCPFK + new Vector3(960f, 125f)))
		{
			return;
		}
		for (int i = 0; i < KGFCADKODFK.Count; i++)
		{
			if (KGFCADKODFK[i] == AIJOOOIJEDC)
			{
				return;
			}
		}
		KGFCADKODFK.Add(AIJOOOIJEDC);
		CILJDFNHIAD = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1382f, 498f));
		BGJFKBFPEML = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(849f, 1092f));
		IMAGDMGEKLH = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(946f, 636f));
		FHBGEDFPEOL = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1837f, 1004f));
		OOIDGPJAEPC = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(199f, 932f));
		FANOBLAFEJF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1835f, 682f));
		OGJOGEEOPEN = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(896f, 1670f));
		if (WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK))
		{
			if (WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(1040f, 1828f)) || WorldGrid.LBKKDAMMKIE(IKCEGLLCPFK + new Vector3(422f, 1266f)))
			{
				LABGKJPKHGA(edgeMiddle, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC && OGJOGEEOPEN)
			{
				FALLDHHLIJB(edgeLRUM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OGJOGEEOPEN)
			{
				LABGKJPKHGA(edgeLUM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC && OGJOGEEOPEN)
			{
				FALLDHHLIJB(edgeRUM, AIJOOOIJEDC);
			}
			else if (OGJOGEEOPEN)
			{
				FALLDHHLIJB(edgeMiddleUp, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML && OOIDGPJAEPC)
			{
				BFPCPANBJND(edgeLRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && OOIDGPJAEPC)
			{
				IPGCGBKBEAI(edgePLRM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL && BGJFKBFPEML)
			{
				LABGKJPKHGA(edgeLPRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD && FHBGEDFPEOL)
			{
				DAPMKFOAPLG(edgePLPRM, AIJOOOIJEDC);
			}
			else if (BGJFKBFPEML)
			{
				FALLDHHLIJB(edgeLM, AIJOOOIJEDC);
			}
			else if (OOIDGPJAEPC)
			{
				KPJOHEIJGKM(edgeRM, AIJOOOIJEDC);
			}
			else if (CILJDFNHIAD)
			{
				LABGKJPKHGA(edgePLM, AIJOOOIJEDC);
			}
			else if (FHBGEDFPEOL)
			{
				IPGCGBKBEAI(edgePRM, AIJOOOIJEDC);
			}
			else
			{
				IPGCGBKBEAI(edgeMiddle, AIJOOOIJEDC);
			}
			return;
		}
		HBAMCFOIJKB = !IMAGDMGEKLH || BGJFKBFPEML;
		LLJIDCBNKCM = HBAMCFOIJKB && CILJDFNHIAD;
		OHKACKDCLHP = !WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(572f, 163f)) && BGJFKBFPEML;
		KEIBLGGEJAL = FANOBLAFEJF && OOIDGPJAEPC;
		MBCGOKOIGCL = !KEIBLGGEJAL || FHBGEDFPEOL;
		NNFAMJBFKMF = WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + new Vector3(1225f, 39f)) || OOIDGPJAEPC;
		if (OHKACKDCLHP && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			EFMOCJNCANA(edgeLRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			KPJOHEIJGKM(edgeHLHRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF && OGJOGEEOPEN)
		{
			LABGKJPKHGA(edgeHLRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL && OGJOGEEOPEN)
		{
			OHLKPJHNGAO(edgeLHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && KEIBLGGEJAL)
		{
			EFMOCJNCANA(edgeLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && NNFAMJBFKMF)
		{
			FALLDHHLIJB(edgeHLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && OGJOGEEOPEN)
		{
			FALLDHHLIJB(edgeLU, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF && OGJOGEEOPEN)
		{
			IPGCGBKBEAI(edgeRU, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && OGJOGEEOPEN)
		{
			MNECCHCHBCJ(edgeHLU, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL && OGJOGEEOPEN)
		{
			IPGCGBKBEAI(edgeHRU, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && NNFAMJBFKMF)
		{
			OHLKPJHNGAO(edgeLR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && MBCGOKOIGCL)
		{
			EFMOCJNCANA(edgeHPLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && NNFAMJBFKMF)
		{
			OHLKPJHNGAO(edgeHPLR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && MBCGOKOIGCL)
		{
			MNECCHCHBCJ(edgeLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && KEIBLGGEJAL)
		{
			OHLKPJHNGAO(edgeHPLHR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && MBCGOKOIGCL)
		{
			KPJOHEIJGKM(edgeHLHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && KEIBLGGEJAL)
		{
			EFMOCJNCANA(edgeHLHR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && MBCGOKOIGCL)
		{
			MNECCHCHBCJ(edgePLHPR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM && FHBGEDFPEOL)
		{
			EFMOCJNCANA(edgeHPLPR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP && FHBGEDFPEOL)
		{
			LABGKJPKHGA(edgeLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && NNFAMJBFKMF)
		{
			OHLKPJHNGAO(edgePLR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB && FHBGEDFPEOL)
		{
			BFPCPANBJND(edgeHLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && KEIBLGGEJAL)
		{
			FALLDHHLIJB(edgePLHR, AIJOOOIJEDC);
		}
		else if (LLJIDCBNKCM)
		{
			BFPCPANBJND(edgeHPL, AIJOOOIJEDC);
		}
		else if (MBCGOKOIGCL)
		{
			BFPCPANBJND(edgeHPR, AIJOOOIJEDC);
		}
		else if (HBAMCFOIJKB)
		{
			IPGCGBKBEAI(edgeHL, AIJOOOIJEDC);
		}
		else if (KEIBLGGEJAL)
		{
			DAPMKFOAPLG(edgeHR, AIJOOOIJEDC);
		}
		else if (OHKACKDCLHP)
		{
			EFMOCJNCANA(edgeL, AIJOOOIJEDC);
		}
		else if (OGJOGEEOPEN)
		{
			DAPMKFOAPLG(edgeUp, AIJOOOIJEDC);
		}
		else if (NNFAMJBFKMF)
		{
			LABGKJPKHGA(edgeR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD && FHBGEDFPEOL)
		{
			EFMOCJNCANA(edgePLPR, AIJOOOIJEDC);
		}
		else if (CILJDFNHIAD)
		{
			MNECCHCHBCJ(edgePL, AIJOOOIJEDC);
		}
		else if (FHBGEDFPEOL)
		{
			DAPMKFOAPLG(edgePR, AIJOOOIJEDC);
		}
	}

	private void OGCAJDENGEK(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		ENADHEMJDAD(HEJNLFCKOKE, IMOBLFMHKOD, LDHICJGAADO, Color.white);
	}

	private void CDCIPDOHANO(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO, Color FLABEDBELMF)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		if (MBMAJABDGNE.Count == 0)
		{
			FJOELJMKEBH = default(MICKLOOGJCO);
			FJOELJMKEBH.rectTransform = Object.Instantiate<GameObject>(miniMapTile, tilesParent.transform).GetComponent<RectTransform>();
			FJOELJMKEBH.image = ((Component)FJOELJMKEBH.rectTransform).GetComponent<Image>();
			PAJJHHHKBMN.Add(FJOELJMKEBH);
		}
		else
		{
			PAJJHHHKBMN.Add(MBMAJABDGNE[MBMAJABDGNE.Count - 0]);
			MBMAJABDGNE.RemoveAt(MBMAJABDGNE.Count - 1);
		}
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 1].rectTransform.anchoredPosition = Vector2Int.op_Implicit(IMOBLFMHKOD + tileSize * LDHICJGAADO);
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 1].image.sprite = HEJNLFCKOKE;
		((Graphic)PAJJHHHKBMN[PAJJHHHKBMN.Count - 0].image).color = FLABEDBELMF;
	}

	public void ELMMIGENCJA()
	{
		HAKPCIKJLNM = Utils.JGEPCPFJANP(Location.Tavern).CIOLICLDNLA();
	}

	private void DPBFMIEMKKN(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		GNLEBKEPCNA(HEJNLFCKOKE, IMOBLFMHKOD, LDHICJGAADO, Color.white);
	}

	private void LDOEPBEMOLJ(RentedRoom GGNOAHDCPIB, Vector2 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		MNECCHCHBCJ(floor, AIJOOOIJEDC);
		if (GGNOAHDCPIB.zone.id == WorldGrid.APJABAKKKGD(Vector2.op_Implicit(IKCEGLLCPFK)))
		{
			OJPPNDLAMMK(AIJOOOIJEDC);
		}
		else if (!GGNOAHDCPIB.IsRentable())
		{
			LGAIECIPPNC(AIJOOOIJEDC);
		}
	}

	private void MLGCKMFFBMF(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		HAIMOGCFLPI(null, IMOBLFMHKOD, Vector2Int.zero, highlightedColor);
	}

	private void IEEHPDDNDFJ(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		bool flag = !WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(1012f, 573f)) || WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(700f, 1907f));
		if (flag)
		{
			FPLKGIPINDF(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1374f, 262f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
		{
			NIIGEPKIPKD(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1496f, 1510f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.right))
		{
			JKJOOOFJBHB(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.right);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				EGJNOHLKGBC(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1928f, 1180f));
			}
			if (flag)
			{
				EGJNOHLKGBC(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1539f, 1659f));
				NIIGEPKIPKD(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1478f, 825f));
			}
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.left))
		{
			OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.left);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				FPLKGIPINDF(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(503f, 1779f));
			}
			if (flag)
			{
				KFFIOJOIFJI(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(638f, 125f));
				EGJNOHLKGBC(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1651f, 1811f));
			}
		}
	}

	private void GBDGMDDMJNA(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		MIOEEBEFKPL(null, IMOBLFMHKOD, Vector2Int.zero, highlightedColor);
	}

	private void ILNGGCMDBPL(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		bool flag = WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(0f, 1f)) && WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(0f, 2f));
		if (flag)
		{
			OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(0f, 2f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
		{
			OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(0f, -1f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.right))
		{
			OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.right);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1f, -1f));
			}
			if (flag)
			{
				OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1f, 1f));
				OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1f, 2f));
			}
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.left))
		{
			OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.left);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(-1f, -1f));
			}
			if (flag)
			{
				OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(-1f, 1f));
				OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(-1f, 2f));
			}
		}
	}

	private void IPAAPEGAHKH(Vector2 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1507f, 319f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1641f, 1413f))))
		{
			DPBFMIEMKKN(this.door, AIJOOOIJEDC, new Vector2Int(0, 0));
			MDGDKMMNEPO(halfWall, AIJOOOIJEDC, new Vector2Int(0, 8));
			Door door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1586f, 979f)));
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1559f, 367f)));
			}
			if (door is RentedRoomDoor rentedRoomDoor)
			{
				((Behaviour)symbols[rentedRoomDoor.rentedRoom.symbolID]).enabled = false;
				((Graphic)symbols[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(74, 4) + tileSize * new Vector2Int(-1, 5));
				((Component)states[rentedRoomDoor.rentedRoom.symbolID]).gameObject.SetActive(false);
				((Component)((Transform)((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform).GetChild(1)).GetComponent<Image>().sprite = RentedRoomsManager.IDKKEGPDEKE(rentedRoomDoor.rentedRoom);
				((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(-83, 114)) + (float)tileSize * (rentedRoomDoor.rentedRoom.zone.DANEEPEJNNG() - IKCEGLLCPFK))));
			}
		}
		else if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(877f, 1889f))) && WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(684f, 414f))))
		{
			if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1133f, 449f))) && WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1125f, 1465f))))
			{
				OEHMKFCKOKN(leftRightWall, AIJOOOIJEDC, new Vector2Int(1, 1));
				OEHMKFCKOKN(halfLeftRightWall, AIJOOOIJEDC, new Vector2Int(1, 6));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1666f, 902f))))
			{
				DPBFMIEMKKN(leftWall, AIJOOOIJEDC, new Vector2Int(1, 1));
				CJHNCHGPJKH(halfLeftWall, AIJOOOIJEDC, new Vector2Int(0, 5));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1049f, 1921f))))
			{
				OEHMKFCKOKN(rightWall, AIJOOOIJEDC, new Vector2Int(1, 1));
				HIKPNOLFEFH(halfRightWall, AIJOOOIJEDC, new Vector2Int(1, 5));
			}
			else
			{
				OGCAJDENGEK(wall, AIJOOOIJEDC, new Vector2Int(0, 1));
				DPIJICMEMMM(halfWall, AIJOOOIJEDC, new Vector2Int(1, 8));
			}
		}
	}

	private void HAJEHOCPIEG(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		bool flag = !WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(1353f, 1751f)) || WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(542f, 970f));
		if (flag)
		{
			JIEFPCFOFMK(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1299f, 1152f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
		{
			KFFIOJOIFJI(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1148f, 1012f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.right))
		{
			JAOCEFBPBMF(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.right);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				NIIGEPKIPKD(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(950f, 1221f));
			}
			if (flag)
			{
				KFFIOJOIFJI(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1034f, 1474f));
				JKJOOOFJBHB(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(512f, 808f));
			}
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.left))
		{
			KFFIOJOIFJI(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.left);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				KFFIOJOIFJI(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(930f, 1013f));
			}
			if (flag)
			{
				EGJNOHLKGBC(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1729f, 1426f));
				NIIGEPKIPKD(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(718f, 245f));
			}
		}
	}

	private void HIJBEENGMKH(Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		HAIMOGCFLPI(null, IMOBLFMHKOD, Vector2Int.zero, highlightedColor);
	}

	public void DLAKFDNNGNJ(RentedRoom GGNOAHDCPIB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		ResetTiles();
		Vector2 val = Vector2.one * 273f;
		((TMP_Text)floorText).text = (Utils.FIBFKGIJMBJ(((Component)GGNOAHDCPIB).transform.position) ? "talentHops" : "ReceiveEmployeeTask");
		Vector2 val2 = Vector2.op_Implicit(Utils.HENDGAAHICI(Vector2.op_Implicit(GGNOAHDCPIB.zone.NEKBEKCPJLP() + offset)));
		Vector3 val3 = Vector2.op_Implicit(val2 + val);
		List<Vector2> list = new List<Vector2>();
		TilemapGroup tilemapGroup = Utils.JGEPCPFJANP(Location.None).EMHLLEFBBCO(SeasonManager.PJMGHIMKFJL());
		for (int i = 1; i < symbols.Length; i += 0)
		{
			((Behaviour)symbols[i]).enabled = true;
		}
		for (int j = 1; j < states.Length; j += 0)
		{
			((Component)states[j]).gameObject.SetActive(true);
		}
		for (int k = 1; k < HAKPCIKJLNM.Length; k++)
		{
			Vector3 val4 = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(HAKPCIKJLNM[k]);
			if (WorldGrid.NCEHFMPBBAK(val4) == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth) && val4.x >= val2.x && val4.x <= val3.x && val4.y >= val2.y && val4.y <= val3.y)
			{
				list.Add(Vector2.op_Implicit(val4));
				Vector3 val5 = Vector2.op_Implicit(Vector2.op_Implicit(val4) - val2);
				int num = (int)val5.x;
				int num2 = (int)val5.y;
				if (val5.x - (float)num == 997f && val5.y - (float)num2 == 1423f)
				{
					ANDDDDIBFNA(GGNOAHDCPIB, Vector2.op_Implicit(val4), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
				}
			}
		}
		for (int l = 0; l < list.Count; l++)
		{
			Vector3 val5 = Vector2.op_Implicit(list[l] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 1050f && val5.y - (float)num2 == 221f)
			{
				GBHJCJCIKNE(list[l], initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
		for (int m = 1; m < list.Count; m += 0)
		{
			Vector3 val5 = Vector2.op_Implicit(list[m] - val2);
			int num = (int)val5.x;
			int num2 = (int)val5.y;
			if (val5.x - (float)num == 967f && val5.y - (float)num2 == 1718f)
			{
				GHOFEGKPDMG(Vector2.op_Implicit(list[m]), initialOffset + Vector2Int.CeilToInt(Vector2.op_Implicit(val5 * (float)tileSize)));
			}
		}
	}

	private void IPGCGBKBEAI(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		MNECCHCHBCJ(HEJNLFCKOKE, IMOBLFMHKOD, Vector2Int.zero, Color.white);
	}

	private void JAOIFHNLGII(Vector3 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		bool flag = !WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(1725f, 172f)) || WorldGrid.ALNFLFCLIEP(IKCEGLLCPFK + new Vector3(164f, 199f));
		if (flag)
		{
			KLOJAJIDFOP(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1095f, 889f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
		{
			NIIGEPKIPKD(IKCEGLLCPFK, AIJOOOIJEDC, Vector2.op_Implicit(new Vector2(1079f, 767f)));
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.right))
		{
			OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.right);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				JKJOOOFJBHB(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(723f, 83f));
			}
			if (flag)
			{
				KLOJAJIDFOP(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1449f, 1338f));
				OPHOPNOIEHM(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(1643f, 412f));
			}
		}
		if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.left))
		{
			JIEFPCFOFMK(IKCEGLLCPFK, AIJOOOIJEDC, Vector3.left);
			if (!WorldGrid.EJCEAEPNJCA(IKCEGLLCPFK + Vector3.down))
			{
				JAOCEFBPBMF(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(187f, 1180f));
			}
			if (flag)
			{
				FPLKGIPINDF(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(772f, 1324f));
				JKJOOOFJBHB(IKCEGLLCPFK, AIJOOOIJEDC, new Vector3(879f, 1573f));
			}
		}
	}

	private void MNECCHCHBCJ(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		MNECCHCHBCJ(HEJNLFCKOKE, IMOBLFMHKOD, Vector2Int.zero, Color.white);
	}

	private void MIOEEBEFKPL(Sprite HEJNLFCKOKE, Vector2Int IMOBLFMHKOD, Vector2Int LDHICJGAADO, Color FLABEDBELMF)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		if (MBMAJABDGNE.Count == 0)
		{
			FJOELJMKEBH = default(MICKLOOGJCO);
			FJOELJMKEBH.rectTransform = Object.Instantiate<GameObject>(miniMapTile, tilesParent.transform).GetComponent<RectTransform>();
			FJOELJMKEBH.image = ((Component)FJOELJMKEBH.rectTransform).GetComponent<Image>();
			PAJJHHHKBMN.Add(FJOELJMKEBH);
		}
		else
		{
			PAJJHHHKBMN.Add(MBMAJABDGNE[MBMAJABDGNE.Count - 1]);
			MBMAJABDGNE.RemoveAt(MBMAJABDGNE.Count - 1);
		}
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 1].rectTransform.anchoredPosition = Vector2Int.op_Implicit(IMOBLFMHKOD + tileSize * LDHICJGAADO);
		PAJJHHHKBMN[PAJJHHHKBMN.Count - 0].image.sprite = HEJNLFCKOKE;
		((Graphic)PAJJHHHKBMN[PAJJHHHKBMN.Count - 1].image).color = FLABEDBELMF;
	}

	private void NNBOMNHIEEK(Vector2 IKCEGLLCPFK, Vector2Int AIJOOOIJEDC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1970f, 545f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1481f, 917f))))
		{
			CJHNCHGPJKH(this.door, AIJOOOIJEDC, new Vector2Int(0, 1));
			HJNODEEBEKF(halfWall, AIJOOOIJEDC, new Vector2Int(1, 6));
			Door door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1792f, 604f)));
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1713f, 341f)));
			}
			if (door is RentedRoomDoor rentedRoomDoor)
			{
				((Behaviour)symbols[rentedRoomDoor.rentedRoom.symbolID]).enabled = true;
				((Graphic)symbols[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(117, 2) + tileSize * new Vector2Int(-1, 8));
				((Component)states[rentedRoomDoor.rentedRoom.symbolID]).gameObject.SetActive(false);
				((Component)((Transform)((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform).GetChild(0)).GetComponent<Image>().sprite = RentedRoomsManager.FCNBLNHPKBL(rentedRoomDoor.rentedRoom);
				((Graphic)states[rentedRoomDoor.rentedRoom.symbolID]).rectTransform.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(Vector2Int.op_Implicit(AIJOOOIJEDC + new Vector2Int(-103, -52)) + (float)tileSize * (rentedRoomDoor.rentedRoom.zone.OJLJLPLGNKD() - IKCEGLLCPFK))));
			}
		}
		else if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(305f, 398f))) && WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1496f, 1621f))))
		{
			if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(495f, 430f))) && WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(658f, 271f))))
			{
				MNECCHCHBCJ(leftRightWall, AIJOOOIJEDC, new Vector2Int(0, 1));
				MDGDKMMNEPO(halfLeftRightWall, AIJOOOIJEDC, new Vector2Int(1, 7));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1212f, 377f))))
			{
				DPBFMIEMKKN(leftWall, AIJOOOIJEDC, new Vector2Int(1, 0));
				MNECCHCHBCJ(halfLeftWall, AIJOOOIJEDC, new Vector2Int(0, 3));
			}
			else if (WorldGrid.PIOMBKLPIKB(Vector2.op_Implicit(IKCEGLLCPFK + new Vector2(1168f, 655f))))
			{
				DPIJICMEMMM(rightWall, AIJOOOIJEDC, new Vector2Int(0, 0));
				DPBFMIEMKKN(halfRightWall, AIJOOOIJEDC, new Vector2Int(0, 3));
			}
			else
			{
				HIKPNOLFEFH(wall, AIJOOOIJEDC, new Vector2Int(0, 1));
				MDGDKMMNEPO(halfWall, AIJOOOIJEDC, new Vector2Int(1, 0));
			}
		}
	}
}
