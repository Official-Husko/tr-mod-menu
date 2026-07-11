using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class PathRequestManager : MonoBehaviour
{
	private struct BHLLLCEBHDL
	{
		public Vector2[] path;

		public bool success;

		public Action<Vector2[], bool> callback;

		public Vector3 finalPosition;

		public BHLLLCEBHDL(Vector2[] GDHHIIMLBEL, Vector3 HBJIKFEKHON, bool ALOMLDIEHJL, Action<Vector2[], bool> AABDPKCDEKB)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			path = GDHHIIMLBEL;
			success = ALOMLDIEHJL;
			callback = AABDPKCDEKB;
			finalPosition = HBJIKFEKHON;
		}
	}

	public struct AStarNode
	{
		public Vector2 position;

		public float GCost;

		public float HCost;

		public float JJCAEAEOLIP => GCost + HCost;

		[SpecialName]
		public float GKJFKGODLHG()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float CGFKECDJDOB()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float EMOPLDPCDMC()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float ICCHFDJEOIE()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float HMGEAKMJMKI()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float EFBGCDLBABF()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float GDLDBBBJCKF()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float EKOPFIGMEEA()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float GBHOACCMGLL()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float PKLJLDHOHKL()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float ILFEJOGFMLE()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float DIKGDAKLBED()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float JEBMEHCJNPJ()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float MMJHLHAOLIE()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float JOBDOCAKJGJ()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float OBPEJNHIGJL()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float BENIABDKDIK()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float FPLLMMBMBNK()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float JLPKPELEEOK()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float CPBFLKAKFPP()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float HMFDCHFKECJ()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float KDJICGMFDCI()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float ODHBMOPEGEC()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float EAFMKEANJJC()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float MNNNIGOEILM()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float EBBEKNPGHCL()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float CCDMHDNLNKF()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float IELKLNFMDEL()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float KEEHCMMHDPN()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float NDHNMIENCKA()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float MPAAFPMMBOL()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float EGIFJODNLKD()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float AFLMCKKAODD()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float LEBDHJICNMK()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float GFJIGIMMGLG()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float NKKLDNCDALE()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float CDEHHBFOFFK()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float MHMIHKHHKCI()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float FPANIFLKBPD()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float AAHOKPCIBBK()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float JCMBDILHMLD()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float PJFKGGELCOO()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float APDLJKJKOIP()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float NDAPJELDHKP()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float DKMJBFBJLKC()
		{
			return GCost + HCost;
		}

		[SpecialName]
		public float AMHNHADHAMF()
		{
			return GCost + HCost;
		}
	}

	public struct PathRequestPrivateInfo
	{
		public PathRequestInfo currentPathRequest;

		public Vector2[] pathsInfo;

		public bool successful;

		public float newCost;

		public bool done;

		public bool checkSize;

		public bool tileNeeded;

		public Location goalLocation;

		public Vector3 heuristicPosition;

		public bool goalLocationStarted;

		public WorldTile wt;

		public int currentNodePosition;

		public AStarNode currentNode;

		public AStarNode newNode;

		public List<Vector2> openPositions;

		public HashSet<Vector2> closed;

		public Dictionary<Vector2, AStarNode> open;

		public Vector2[] horizontalNodes;

		public Vector2[] verticalNodes;

		public Dictionary<Vector3, Vector2> cameFrom;

		public Dictionary<Vector3, float> costSoFar;

		public Vector2 start;

		public Vector2 goal;

		public void EOADCHLNLPK()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void PLIFJBMCANA()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void NIMBNNHAMHA()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void NCDINEHBMLN()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void PPICAMAGNME()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void IHAIOCGFDPB()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void CPGKEDLBPGM()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void JNHDFGMOMKA()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void EEKOFIEBCPL()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void OKNDDCMEDKP()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void PJANACELJFB()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void IAMCINKIICI()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void DNNGLPLEEMJ()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void JEMFMIHMAOI()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void BEHINEPGPBO()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void PJHDECMHCIA()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void FOHHKGJFJAE()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void HJCOAJEIABK()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void DBBIAKMKJIP()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void IPEEHGAKHPP()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void MIMGPIANHNJ()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void DJDAJEOOJMI()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void GGDBBJPJLFD()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void OIHIJONNOBF()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void MEIDKNBMLEE()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void AJPLCFDGBLA()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void PEKDBJOHHIK()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void ENPJHFLIALN()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void MMLENKDBIIE()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void EBIDJHHEMJP()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void OCAMGNJKLAP()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void BGHNLKKIKBC()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void MCJHPNFCFPE()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void PCDEFINBAHC()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void CPFDLKMCBCB()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void GFMIFFNJEMK()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void NPENPGOABBO()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}

		public void DDDLBOBPBHB()
		{
			openPositions = new List<Vector2>();
			closed = new HashSet<Vector2>();
			open = new Dictionary<Vector2, AStarNode>();
			cameFrom = new Dictionary<Vector3, Vector2>();
			costSoFar = new Dictionary<Vector3, float>();
		}
	}

	private static PathRequestManager GGFJGHHHEJC;

	private static readonly AStarNodePool EPBAMJOKBCE = new AStarNodePool();

	private Queue<BHLLLCEBHDL> GLMOAFNPGIJ = new Queue<BHLLLCEBHDL>();

	public Queue<PathRequestInfo> pathRequestQueue = new Queue<PathRequestInfo>();

	private Thread NCCBHKBEJNK;

	public PathRequestParameters pathRequestsInfo;

	private HashSet<Vector2> FENKCDBBHEG = new HashSet<Vector2>();

	private Dictionary<Vector2, AStarNode> LKOJBFMGMAE = new Dictionary<Vector2, AStarNode>();

	private Vector2[] MGNHFHCKKPC;

	private Vector2[] GCEFANAGCOJ;

	private void NGCOMHLBAIA()
	{
		NCCBHKBEJNK = new Thread(KEOIIIDFBCN);
		NCCBHKBEJNK.Start();
	}

	private static float POKLLAGEJPD(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(631f, 1011f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(455f, 822f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1372f, 143f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(329f, 1250f)))
		{
			return 1288f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(990f, 1682f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(981f, 270f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1646f, 217f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1703f, 1329f)))
		{
			return 835f;
		}
		return 147f;
	}

	private void Start()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(HDALEOBOHKE));
	}

	private void DONGKOKMGMM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		if (NCCBHKBEJNK != null)
		{
			NCCBHKBEJNK.Abort();
		}
	}

	public void Pathfinding()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		while ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			Thread.Sleep(1);
		}
		pathRequestsInfo.diagonal = Mathf.Sqrt(pathRequestsInfo.recto * pathRequestsInfo.recto * 2f);
		PathRequestPrivateInfo gCFFMKJNBLI = default(PathRequestPrivateInfo);
		gCFFMKJNBLI.CPFDLKMCBCB();
		while (true)
		{
			if (pathRequestQueue.Count > 0)
			{
				lock (pathRequestQueue)
				{
					gCFFMKJNBLI.currentPathRequest = pathRequestQueue.Dequeue();
				}
				try
				{
					PathfindingRequest(gCFFMKJNBLI);
				}
				catch (Exception ex)
				{
					string[] obj = new string[6] { "Pathfinding error startPos: ", null, null, null, null, null };
					Vector3 val = gCFFMKJNBLI.currentPathRequest.startPos;
					obj[1] = ((object)(Vector3)(ref val)).ToString();
					obj[2] = " goalPos: ";
					val = gCFFMKJNBLI.currentPathRequest.goalPos;
					obj[3] = ((object)(Vector3)(ref val)).ToString();
					obj[4] = " ";
					obj[5] = ex?.ToString();
					Debug.LogError((object)string.Concat(obj));
					BHLLLCEBHDL item = new BHLLLCEBHDL((Vector2[])(object)new Vector2[0], Vector2.op_Implicit(gCFFMKJNBLI.goal), ALOMLDIEHJL: false, gCFFMKJNBLI.currentPathRequest.callback);
					lock (GLMOAFNPGIJ)
					{
						GLMOAFNPGIJ.Enqueue(item);
					}
				}
			}
			Thread.Sleep(1);
		}
	}

	private void KLMNLEDKEOE()
	{
		GGFJGHHHEJC = this;
	}

	public void BEPHCGNKLKH(PathRequestPrivateInfo GCFFMKJNBLI)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI.start = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.goal = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos);
		GCFFMKJNBLI.goalLocation = Utils.HJPCBBGHPDA(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos));
		GCFFMKJNBLI.goalLocationStarted = true;
		EPBAMJOKBCE.CFEJMCCOCNH(GCFFMKJNBLI.open);
		GCFFMKJNBLI.cameFrom.Clear();
		GCFFMKJNBLI.costSoFar.Clear();
		GCFFMKJNBLI.closed.Clear();
		GCFFMKJNBLI.open.Clear();
		GCFFMKJNBLI.openPositions.Clear();
		GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), GCFFMKJNBLI.start);
		GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), 1264f);
		Neighbour[] FIFABPOJMAF = ((!GCFFMKJNBLI.currentPathRequest.canWalkDiagonal) ? new Neighbour[2] : new Neighbour[WorldGrid.allMovementNeighbours.Length + 0]);
		if (((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x > 0 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x > 0 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y > 1)
		{
			GCFFMKJNBLI.checkSize = false;
		}
		else
		{
			GCFFMKJNBLI.checkSize = true;
		}
		if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0 || GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0 || GCFFMKJNBLI.currentPathRequest.takePath || GCFFMKJNBLI.currentPathRequest.takeHorsePath)
		{
			GCFFMKJNBLI.tileNeeded = true;
		}
		else
		{
			GCFFMKJNBLI.tileNeeded = true;
		}
		GCFFMKJNBLI.horizontalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y];
		GCFFMKJNBLI.verticalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y];
		GCFFMKJNBLI.newNode = EPBAMJOKBCE.EJKJJAOHGEL();
		GCFFMKJNBLI.newNode.position = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.newNode.GCost = 1023f;
		GCFFMKJNBLI.newNode.HCost = 1230f;
		GCFFMKJNBLI.open.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos), GCFFMKJNBLI.newNode);
		GCFFMKJNBLI.openPositions.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos));
		GCFFMKJNBLI.done = false;
		while ((float)GCFFMKJNBLI.openPositions.Count > 797f)
		{
			GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[0]];
			GCFFMKJNBLI.currentNodePosition = 1;
			for (int i = 1; i < GCFFMKJNBLI.openPositions.Count; i += 0)
			{
				if (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].AFLMCKKAODD() < GCFFMKJNBLI.currentNode.JCMBDILHMLD() || (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].MHMIHKHHKCI() == GCFFMKJNBLI.currentNode.NDAPJELDHKP() && GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].HCost < GCFFMKJNBLI.currentNode.HCost))
				{
					GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]];
					GCFFMKJNBLI.currentNodePosition = i;
				}
			}
			EPBAMJOKBCE.CLFMNPCOIEM(GCFFMKJNBLI.currentNode);
			GCFFMKJNBLI.open.Remove(GCFFMKJNBLI.openPositions[GCFFMKJNBLI.currentNodePosition]);
			GCFFMKJNBLI.openPositions.RemoveAt(GCFFMKJNBLI.currentNodePosition);
			GCFFMKJNBLI.closed.Add(GCFFMKJNBLI.currentNode.position);
			if (((Vector2)(ref GCFFMKJNBLI.currentNode.position)).Equals(GCFFMKJNBLI.goal) || (GCFFMKJNBLI.currentPathRequest.maxNodes > 0 && GCFFMKJNBLI.closed.Count > GCFFMKJNBLI.currentPathRequest.maxNodes))
			{
				break;
			}
			WorldGrid.DLFFCGLGDLL(Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position), ref FIFABPOJMAF, GCFFMKJNBLI.currentPathRequest.canWalkDiagonal);
			for (int j = 1; j < FIFABPOJMAF.Length; j++)
			{
				if (GCFFMKJNBLI.closed.Contains(FIFABPOJMAF[j].position))
				{
					continue;
				}
				if (FIFABPOJMAF[j].position == GCFFMKJNBLI.goal)
				{
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.done = true;
					break;
				}
				if (!FIFABPOJMAF[j].free && (GCFFMKJNBLI.currentPathRequest.currentNodes == null || !GCFFMKJNBLI.currentPathRequest.currentNodes.Contains(FIFABPOJMAF[j].position)))
				{
					continue;
				}
				if (GCFFMKJNBLI.checkSize)
				{
					if (Utils.ABPDGOHBKIG(FIFABPOJMAF[j].direction))
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.horizontalSize, ref GCFFMKJNBLI.horizontalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.horizontalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
					else
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.verticalSize, ref GCFFMKJNBLI.verticalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.verticalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
				}
				else if (FIFABPOJMAF[j].direction == Direction.Up)
				{
					switch (j)
					{
					case 7:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[1].free)
						{
							continue;
						}
						break;
					case 8:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[6].free)
						{
							continue;
						}
						break;
					case 9:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[2].free)
						{
							continue;
						}
						break;
					case 10:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[1].free)
						{
							continue;
						}
						break;
					}
				}
				GCFFMKJNBLI.newCost = GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position)];
				if (GCFFMKJNBLI.tileNeeded)
				{
					WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(FIFABPOJMAF[j].position), out GCFFMKJNBLI.wt);
					if (GCFFMKJNBLI.currentPathRequest.takePath && GCFFMKJNBLI.wt.isPath)
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.pathPenalization;
					}
					if (GCFFMKJNBLI.currentPathRequest.takeHorsePath && GCFFMKJNBLI.wt.isHorsePath && !((Vector2)(ref FIFABPOJMAF[j].position)).Equals(Utils.NKGANMEKDAL(FIFABPOJMAF[j].position)))
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.bonificacionCaminoCaballo;
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(GCFFMKJNBLI.wt.groundType))
						{
							if (FIFABPOJMAF[j].direction == (Direction)6)
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * (pathRequestsInfo.diagonal / pathRequestsInfo.recto);
							}
							else
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
							}
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(971f, 682f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(1285f, 736f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(GCFFMKJNBLI.wt.zoneType))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 473f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(1457f, 542f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1435f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(1571f, 1538f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 216f;
						}
					}
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidWalls && Utils.EJPFCKFEMJF(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.newCost += KPFKNBNBNNP(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidObjects)
				{
					GCFFMKJNBLI.newCost += OIMOJEOBGOB(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (FIFABPOJMAF[j].direction == Direction.Down)
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.diagonal * FIFABPOJMAF[j].cost;
				}
				else
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.recto * FIFABPOJMAF[j].cost;
				}
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)) && !(GCFFMKJNBLI.newCost < GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)]))
				{
					continue;
				}
				if (GCFFMKJNBLI.goalLocationStarted)
				{
					if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) != GCFFMKJNBLI.goalLocation)
					{
						continue;
					}
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				else if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) == GCFFMKJNBLI.goalLocation)
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
					EPBAMJOKBCE.BJEMIADLGJC(GCFFMKJNBLI.open);
					GCFFMKJNBLI.open.Clear();
					GCFFMKJNBLI.openPositions.Clear();
					GCFFMKJNBLI.goalLocationStarted = false;
				}
				else if ((Object)(object)TravelZonesManager.GGFJGHHHEJC.KCJMDAPPJLB(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation) != (Object)null)
				{
					GCFFMKJNBLI.heuristicPosition = TravelZonesManager.BGMJCCFNNDL().KCJMDAPPJLB(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation).position;
				}
				else
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				GCFFMKJNBLI.newNode = EPBAMJOKBCE.HKCAIFFKBMH();
				GCFFMKJNBLI.newNode.position = FIFABPOJMAF[j].position;
				GCFFMKJNBLI.newNode.GCost = GCFFMKJNBLI.newCost;
				GCFFMKJNBLI.newNode.HCost = PGBAAHPHOID(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.heuristicPosition);
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.newCost;
					GCFFMKJNBLI.cameFrom[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.currentNode.position;
					GCFFMKJNBLI.open[FIFABPOJMAF[j].position] = GCFFMKJNBLI.newNode;
				}
				else
				{
					GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.newCost);
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.open.Add(FIFABPOJMAF[j].position, GCFFMKJNBLI.newNode);
					GCFFMKJNBLI.openPositions.Add(FIFABPOJMAF[j].position);
				}
			}
			if (GCFFMKJNBLI.done)
			{
				break;
			}
		}
		GCFFMKJNBLI.pathsInfo = ADJLOFDJHKE(GCFFMKJNBLI, out GCFFMKJNBLI.successful).ToArray();
		BHLLLCEBHDL item = new BHLLLCEBHDL(GCFFMKJNBLI.pathsInfo, GCFFMKJNBLI.currentPathRequest.pathEnd, GCFFMKJNBLI.successful, GCFFMKJNBLI.currentPathRequest.callback);
		Queue<BHLLLCEBHDL> gLMOAFNPGIJ = GLMOAFNPGIJ;
		bool lockTaken = true;
		try
		{
			Monitor.Enter(gLMOAFNPGIJ, ref lockTaken);
			GLMOAFNPGIJ.Enqueue(item);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(gLMOAFNPGIJ);
			}
		}
	}

	private void DFHKBNFOBFJ()
	{
		NCCBHKBEJNK = new Thread(Pathfinding);
		NCCBHKBEJNK.Start();
	}

	public static void APKGFEPCPNN(PathRequestInfo BNKENFFDFMK)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.MJEACANINDN(BNKENFFDFMK.startPos) == Utils.MJEACANINDN(BNKENFFDFMK.goalPos))
		{
			Action<Vector2[], bool> callback = BNKENFFDFMK.callback;
			Vector2[] array = new Vector2[0];
			array[0] = Vector2.op_Implicit(Utils.MJEACANINDN(BNKENFFDFMK.startPos));
			callback((Vector2[])(object)array, arg2: true);
			return;
		}
		lock (GGFJGHHHEJC.pathRequestQueue)
		{
			GGFJGHHHEJC.pathRequestQueue.Enqueue(BNKENFFDFMK);
		}
	}

	public void PathfindingRequest(PathRequestPrivateInfo GCFFMKJNBLI)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI.start = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.goal = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos);
		GCFFMKJNBLI.goalLocation = Utils.HJPCBBGHPDA(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos));
		GCFFMKJNBLI.goalLocationStarted = false;
		EPBAMJOKBCE.BMINCCOPHLJ(GCFFMKJNBLI.open);
		GCFFMKJNBLI.cameFrom.Clear();
		GCFFMKJNBLI.costSoFar.Clear();
		GCFFMKJNBLI.closed.Clear();
		GCFFMKJNBLI.open.Clear();
		GCFFMKJNBLI.openPositions.Clear();
		GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), GCFFMKJNBLI.start);
		GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), 0f);
		Neighbour[] FIFABPOJMAF = ((!GCFFMKJNBLI.currentPathRequest.canWalkDiagonal) ? new Neighbour[5] : new Neighbour[WorldGrid.allMovementNeighbours.Length + 1]);
		if (((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y > 1)
		{
			GCFFMKJNBLI.checkSize = true;
		}
		else
		{
			GCFFMKJNBLI.checkSize = false;
		}
		if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0 || GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0 || GCFFMKJNBLI.currentPathRequest.takePath || GCFFMKJNBLI.currentPathRequest.takeHorsePath)
		{
			GCFFMKJNBLI.tileNeeded = true;
		}
		else
		{
			GCFFMKJNBLI.tileNeeded = false;
		}
		GCFFMKJNBLI.horizontalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y];
		GCFFMKJNBLI.verticalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y];
		GCFFMKJNBLI.newNode = EPBAMJOKBCE.EJKJJAOHGEL();
		GCFFMKJNBLI.newNode.position = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.newNode.GCost = 0f;
		GCFFMKJNBLI.newNode.HCost = 0f;
		GCFFMKJNBLI.open.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos), GCFFMKJNBLI.newNode);
		GCFFMKJNBLI.openPositions.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos));
		GCFFMKJNBLI.done = false;
		while ((float)GCFFMKJNBLI.openPositions.Count > 0f)
		{
			GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[0]];
			GCFFMKJNBLI.currentNodePosition = 0;
			for (int i = 1; i < GCFFMKJNBLI.openPositions.Count; i++)
			{
				if (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].JJCAEAEOLIP < GCFFMKJNBLI.currentNode.JJCAEAEOLIP || (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].JJCAEAEOLIP == GCFFMKJNBLI.currentNode.JJCAEAEOLIP && GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].HCost < GCFFMKJNBLI.currentNode.HCost))
				{
					GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]];
					GCFFMKJNBLI.currentNodePosition = i;
				}
			}
			EPBAMJOKBCE.FPEPPLAPJAI(GCFFMKJNBLI.currentNode);
			GCFFMKJNBLI.open.Remove(GCFFMKJNBLI.openPositions[GCFFMKJNBLI.currentNodePosition]);
			GCFFMKJNBLI.openPositions.RemoveAt(GCFFMKJNBLI.currentNodePosition);
			GCFFMKJNBLI.closed.Add(GCFFMKJNBLI.currentNode.position);
			if (((Vector2)(ref GCFFMKJNBLI.currentNode.position)).Equals(GCFFMKJNBLI.goal) || (GCFFMKJNBLI.currentPathRequest.maxNodes > 0 && GCFFMKJNBLI.closed.Count > GCFFMKJNBLI.currentPathRequest.maxNodes))
			{
				break;
			}
			WorldGrid.DLFFCGLGDLL(Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position), ref FIFABPOJMAF, GCFFMKJNBLI.currentPathRequest.canWalkDiagonal);
			for (int j = 0; j < FIFABPOJMAF.Length; j++)
			{
				if (GCFFMKJNBLI.closed.Contains(FIFABPOJMAF[j].position))
				{
					continue;
				}
				if (FIFABPOJMAF[j].position == GCFFMKJNBLI.goal)
				{
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.done = true;
					break;
				}
				if (!FIFABPOJMAF[j].free && (GCFFMKJNBLI.currentPathRequest.currentNodes == null || !GCFFMKJNBLI.currentPathRequest.currentNodes.Contains(FIFABPOJMAF[j].position)))
				{
					continue;
				}
				if (GCFFMKJNBLI.checkSize)
				{
					if (Utils.ABPDGOHBKIG(FIFABPOJMAF[j].direction))
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.horizontalSize, ref GCFFMKJNBLI.horizontalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.horizontalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
					else
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.verticalSize, ref GCFFMKJNBLI.verticalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.verticalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
				}
				else if (FIFABPOJMAF[j].direction == Direction.Diagonal)
				{
					switch (j)
					{
					case 4:
						if (!FIFABPOJMAF[0].free || !FIFABPOJMAF[3].free)
						{
							continue;
						}
						break;
					case 5:
						if (!FIFABPOJMAF[0].free || !FIFABPOJMAF[2].free)
						{
							continue;
						}
						break;
					case 6:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[3].free)
						{
							continue;
						}
						break;
					case 7:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[2].free)
						{
							continue;
						}
						break;
					}
				}
				GCFFMKJNBLI.newCost = GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position)];
				if (GCFFMKJNBLI.tileNeeded)
				{
					WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(FIFABPOJMAF[j].position), out GCFFMKJNBLI.wt);
					if (GCFFMKJNBLI.currentPathRequest.takePath && GCFFMKJNBLI.wt.isPath)
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.pathPenalization;
					}
					if (GCFFMKJNBLI.currentPathRequest.takeHorsePath && GCFFMKJNBLI.wt.isHorsePath && !((Vector2)(ref FIFABPOJMAF[j].position)).Equals(Utils.NKGANMEKDAL(FIFABPOJMAF[j].position)))
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.bonificacionCaminoCaballo;
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(GCFFMKJNBLI.wt.groundType))
						{
							if (FIFABPOJMAF[j].direction == Direction.Diagonal)
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * (pathRequestsInfo.diagonal / pathRequestsInfo.recto);
							}
							else
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
							}
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(-0.25f, 0f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(0f, -0.25f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(GCFFMKJNBLI.wt.zoneType))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 2f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(-0.25f, 0f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 2f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(0f, -0.25f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 2f;
						}
					}
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidWalls && Utils.EJPFCKFEMJF(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.newCost += EONFJGMHNOI(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidObjects)
				{
					GCFFMKJNBLI.newCost += NKBGKFJFDBD(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (FIFABPOJMAF[j].direction == Direction.Diagonal)
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.diagonal * FIFABPOJMAF[j].cost;
				}
				else
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.recto * FIFABPOJMAF[j].cost;
				}
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)) && !(GCFFMKJNBLI.newCost < GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)]))
				{
					continue;
				}
				if (GCFFMKJNBLI.goalLocationStarted)
				{
					if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) != GCFFMKJNBLI.goalLocation)
					{
						continue;
					}
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				else if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) == GCFFMKJNBLI.goalLocation)
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
					EPBAMJOKBCE.BMINCCOPHLJ(GCFFMKJNBLI.open);
					GCFFMKJNBLI.open.Clear();
					GCFFMKJNBLI.openPositions.Clear();
					GCFFMKJNBLI.goalLocationStarted = true;
				}
				else if ((Object)(object)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation) != (Object)null)
				{
					GCFFMKJNBLI.heuristicPosition = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation).position;
				}
				else
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				GCFFMKJNBLI.newNode = EPBAMJOKBCE.EJKJJAOHGEL();
				GCFFMKJNBLI.newNode.position = FIFABPOJMAF[j].position;
				GCFFMKJNBLI.newNode.GCost = GCFFMKJNBLI.newCost;
				GCFFMKJNBLI.newNode.HCost = Heuristic(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.heuristicPosition);
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.newCost;
					GCFFMKJNBLI.cameFrom[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.currentNode.position;
					GCFFMKJNBLI.open[FIFABPOJMAF[j].position] = GCFFMKJNBLI.newNode;
				}
				else
				{
					GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.newCost);
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.open.Add(FIFABPOJMAF[j].position, GCFFMKJNBLI.newNode);
					GCFFMKJNBLI.openPositions.Add(FIFABPOJMAF[j].position);
				}
			}
			if (GCFFMKJNBLI.done)
			{
				break;
			}
		}
		GCFFMKJNBLI.pathsInfo = FindPath(GCFFMKJNBLI, out GCFFMKJNBLI.successful).ToArray();
		BHLLLCEBHDL item = new BHLLLCEBHDL(GCFFMKJNBLI.pathsInfo, GCFFMKJNBLI.currentPathRequest.pathEnd, GCFFMKJNBLI.successful, GCFFMKJNBLI.currentPathRequest.callback);
		lock (GLMOAFNPGIJ)
		{
			GLMOAFNPGIJ.Enqueue(item);
		}
	}

	private void HPMFOHOMLDO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		if (NCCBHKBEJNK != null)
		{
			NCCBHKBEJNK.Abort();
		}
	}

	public void EMNCDOMMALC()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		while ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			Thread.Sleep(1);
		}
		pathRequestsInfo.diagonal = Mathf.Sqrt(pathRequestsInfo.recto * pathRequestsInfo.recto * 1266f);
		PathRequestPrivateInfo gCFFMKJNBLI = default(PathRequestPrivateInfo);
		gCFFMKJNBLI.DBBIAKMKJIP();
		while (true)
		{
			if (pathRequestQueue.Count > 0)
			{
				lock (pathRequestQueue)
				{
					gCFFMKJNBLI.currentPathRequest = pathRequestQueue.Dequeue();
				}
				try
				{
					KIPAMIAMFOC(gCFFMKJNBLI);
				}
				catch (Exception ex)
				{
					string[] array = new string[0];
					array[0] = "[";
					Vector3 val = gCFFMKJNBLI.currentPathRequest.startPos;
					array[1] = ((object)(Vector3)(ref val)).ToString();
					array[4] = "Spade";
					val = gCFFMKJNBLI.currentPathRequest.goalPos;
					array[8] = ((object)(Vector3)(ref val)).ToString();
					array[6] = "Accept order";
					array[0] = ex?.ToString();
					Debug.LogError((object)string.Concat(array));
					BHLLLCEBHDL item = new BHLLLCEBHDL((Vector2[])(object)new Vector2[0], Vector2.op_Implicit(gCFFMKJNBLI.goal), ALOMLDIEHJL: false, gCFFMKJNBLI.currentPathRequest.callback);
					Queue<BHLLLCEBHDL> gLMOAFNPGIJ = GLMOAFNPGIJ;
					bool lockTaken = true;
					try
					{
						Monitor.Enter(gLMOAFNPGIJ, ref lockTaken);
						GLMOAFNPGIJ.Enqueue(item);
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(gLMOAFNPGIJ);
						}
					}
				}
			}
			Thread.Sleep(0);
		}
	}

	public List<Vector2> ADJLOFDJHKE(PathRequestPrivateInfo GCFFMKJNBLI, out bool NLGIGDFOGCM)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 val = GCFFMKJNBLI.goal;
		while (!((Vector2)(ref val)).Equals(GCFFMKJNBLI.start))
		{
			if (!GCFFMKJNBLI.cameFrom.ContainsKey(Vector2.op_Implicit(val)))
			{
				NLGIGDFOGCM = false;
				return new List<Vector2>();
			}
			list.Add(val);
			val = GCFFMKJNBLI.cameFrom[Vector2.op_Implicit(val)];
		}
		list.Reverse();
		NLGIGDFOGCM = false;
		return list;
	}

	private void GFLFDLIMOLI()
	{
		GGFJGHHHEJC = this;
	}

	private static float EGNBLGHBJDD(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(909f, 1026f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(575f, 482f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(715f, 1853f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(636f, 1827f)))
		{
			return 307f;
		}
		return 1679f;
	}

	public static void BDLIHJBJHGA(PathRequestInfo BNKENFFDFMK)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.MJEACANINDN(BNKENFFDFMK.startPos) == Utils.MJEACANINDN(BNKENFFDFMK.goalPos))
		{
			Action<Vector2[], bool> callback = BNKENFFDFMK.callback;
			Vector2[] array = new Vector2[0];
			array[1] = Vector2.op_Implicit(Utils.MJEACANINDN(BNKENFFDFMK.startPos));
			callback((Vector2[])(object)array, arg2: true);
			return;
		}
		Queue<PathRequestInfo> obj = GGFJGHHHEJC.pathRequestQueue;
		bool lockTaken = true;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			GGFJGHHHEJC.pathRequestQueue.Enqueue(BNKENFFDFMK);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	public float FEHHBIFPJON(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * pathRequestsInfo.heuristicMultiplier;
	}

	private static float PCIANLLKPNP(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(98f, 1360f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(674f, 1964f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(1495f, 1543f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(1422f, 625f)))
		{
			return 1627f;
		}
		return 162f;
	}

	private static float OINAKFMPFEL(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(257f, 1605f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1923f, 1964f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1968f, 923f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(81f, 1948f)))
		{
			return 1108f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(392f, 1861f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(235f, 291f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1573f, 1431f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(852f, 286f)))
		{
			return 1249f;
		}
		return 1797f;
	}

	private static float EONFJGMHNOI(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(0f, 0.4f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(0f, -0.4f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(0.4f, 0f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(-0.4f, 0f)))
		{
			return 0.25f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(0f, 0.25f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(0f, -0.25f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(0.25f, 0f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(-0.25f, 0f)))
		{
			return 0.1f;
		}
		return 0f;
	}

	private void FFLLCOBFIPE()
	{
		GGFJGHHHEJC = this;
	}

	public void LFECFOAOHMF(PathRequestPrivateInfo GCFFMKJNBLI)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI.start = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.goal = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos);
		GCFFMKJNBLI.goalLocation = Utils.HJPCBBGHPDA(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos));
		GCFFMKJNBLI.goalLocationStarted = false;
		EPBAMJOKBCE.HLENHDIMDAB(GCFFMKJNBLI.open);
		GCFFMKJNBLI.cameFrom.Clear();
		GCFFMKJNBLI.costSoFar.Clear();
		GCFFMKJNBLI.closed.Clear();
		GCFFMKJNBLI.open.Clear();
		GCFFMKJNBLI.openPositions.Clear();
		GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), GCFFMKJNBLI.start);
		GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), 1908f);
		Neighbour[] FIFABPOJMAF = ((!GCFFMKJNBLI.currentPathRequest.canWalkDiagonal) ? new Neighbour[5] : new Neighbour[WorldGrid.allMovementNeighbours.Length + 1]);
		if (((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y > 1)
		{
			GCFFMKJNBLI.checkSize = false;
		}
		else
		{
			GCFFMKJNBLI.checkSize = true;
		}
		if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0 || GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0 || GCFFMKJNBLI.currentPathRequest.takePath || GCFFMKJNBLI.currentPathRequest.takeHorsePath)
		{
			GCFFMKJNBLI.tileNeeded = false;
		}
		else
		{
			GCFFMKJNBLI.tileNeeded = false;
		}
		GCFFMKJNBLI.horizontalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y];
		GCFFMKJNBLI.verticalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y];
		GCFFMKJNBLI.newNode = EPBAMJOKBCE.LAMFGLIGLOP();
		GCFFMKJNBLI.newNode.position = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.newNode.GCost = 937f;
		GCFFMKJNBLI.newNode.HCost = 1634f;
		GCFFMKJNBLI.open.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos), GCFFMKJNBLI.newNode);
		GCFFMKJNBLI.openPositions.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos));
		GCFFMKJNBLI.done = true;
		while ((float)GCFFMKJNBLI.openPositions.Count > 1473f)
		{
			GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[0]];
			GCFFMKJNBLI.currentNodePosition = 0;
			for (int i = 1; i < GCFFMKJNBLI.openPositions.Count; i++)
			{
				if (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].BENIABDKDIK() < GCFFMKJNBLI.currentNode.OBPEJNHIGJL() || (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].JEBMEHCJNPJ() == GCFFMKJNBLI.currentNode.JLPKPELEEOK() && GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].HCost < GCFFMKJNBLI.currentNode.HCost))
				{
					GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]];
					GCFFMKJNBLI.currentNodePosition = i;
				}
			}
			EPBAMJOKBCE.NLMGPOGLMDO(GCFFMKJNBLI.currentNode);
			GCFFMKJNBLI.open.Remove(GCFFMKJNBLI.openPositions[GCFFMKJNBLI.currentNodePosition]);
			GCFFMKJNBLI.openPositions.RemoveAt(GCFFMKJNBLI.currentNodePosition);
			GCFFMKJNBLI.closed.Add(GCFFMKJNBLI.currentNode.position);
			if (((Vector2)(ref GCFFMKJNBLI.currentNode.position)).Equals(GCFFMKJNBLI.goal) || (GCFFMKJNBLI.currentPathRequest.maxNodes > 1 && GCFFMKJNBLI.closed.Count > GCFFMKJNBLI.currentPathRequest.maxNodes))
			{
				break;
			}
			WorldGrid.DLFFCGLGDLL(Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position), ref FIFABPOJMAF, GCFFMKJNBLI.currentPathRequest.canWalkDiagonal);
			for (int j = 1; j < FIFABPOJMAF.Length; j += 0)
			{
				if (GCFFMKJNBLI.closed.Contains(FIFABPOJMAF[j].position))
				{
					continue;
				}
				if (FIFABPOJMAF[j].position == GCFFMKJNBLI.goal)
				{
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.done = false;
					break;
				}
				if (!FIFABPOJMAF[j].free && (GCFFMKJNBLI.currentPathRequest.currentNodes == null || !GCFFMKJNBLI.currentPathRequest.currentNodes.Contains(FIFABPOJMAF[j].position)))
				{
					continue;
				}
				if (GCFFMKJNBLI.checkSize)
				{
					if (Utils.ABPDGOHBKIG(FIFABPOJMAF[j].direction))
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.horizontalSize, ref GCFFMKJNBLI.horizontalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.horizontalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
					else
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.verticalSize, ref GCFFMKJNBLI.verticalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.verticalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
				}
				else if (FIFABPOJMAF[j].direction == Direction.Down)
				{
					switch (j)
					{
					case 3:
						if (!FIFABPOJMAF[0].free || !FIFABPOJMAF[2].free)
						{
							continue;
						}
						break;
					case 4:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[8].free)
						{
							continue;
						}
						break;
					case 5:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[1].free)
						{
							continue;
						}
						break;
					case 6:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[5].free)
						{
							continue;
						}
						break;
					}
				}
				GCFFMKJNBLI.newCost = GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position)];
				if (GCFFMKJNBLI.tileNeeded)
				{
					WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(FIFABPOJMAF[j].position), out GCFFMKJNBLI.wt);
					if (GCFFMKJNBLI.currentPathRequest.takePath && GCFFMKJNBLI.wt.isPath)
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.pathPenalization;
					}
					if (GCFFMKJNBLI.currentPathRequest.takeHorsePath && GCFFMKJNBLI.wt.isHorsePath && !((Vector2)(ref FIFABPOJMAF[j].position)).Equals(Utils.NKGANMEKDAL(FIFABPOJMAF[j].position)))
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.bonificacionCaminoCaballo;
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(GCFFMKJNBLI.wt.groundType))
						{
							if (FIFABPOJMAF[j].direction == (Direction)6)
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * (pathRequestsInfo.diagonal / pathRequestsInfo.recto);
							}
							else
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
							}
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(141f, 632f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(1247f, 1018f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(GCFFMKJNBLI.wt.zoneType))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1872f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(1266f, 1059f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1285f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(1079f, 761f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1720f;
						}
					}
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidWalls && Utils.EJPFCKFEMJF(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.newCost += OINAKFMPFEL(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidObjects)
				{
					GCFFMKJNBLI.newCost += EFABHLBIHEF(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (FIFABPOJMAF[j].direction == Direction.Diagonal)
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.diagonal * FIFABPOJMAF[j].cost;
				}
				else
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.recto * FIFABPOJMAF[j].cost;
				}
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)) && !(GCFFMKJNBLI.newCost < GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)]))
				{
					continue;
				}
				if (GCFFMKJNBLI.goalLocationStarted)
				{
					if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) != GCFFMKJNBLI.goalLocation)
					{
						continue;
					}
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				else if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) == GCFFMKJNBLI.goalLocation)
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
					EPBAMJOKBCE.MMDJHHCLBDJ(GCFFMKJNBLI.open);
					GCFFMKJNBLI.open.Clear();
					GCFFMKJNBLI.openPositions.Clear();
					GCFFMKJNBLI.goalLocationStarted = false;
				}
				else if ((Object)(object)TravelZonesManager.EKDNJDJHONF().OFIPCMMKFLP(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation) != (Object)null)
				{
					GCFFMKJNBLI.heuristicPosition = TravelZonesManager.BGMJCCFNNDL().ECFDFECLDFK(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation).position;
				}
				else
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				GCFFMKJNBLI.newNode = EPBAMJOKBCE.IEPGACAGIPO();
				GCFFMKJNBLI.newNode.position = FIFABPOJMAF[j].position;
				GCFFMKJNBLI.newNode.GCost = GCFFMKJNBLI.newCost;
				GCFFMKJNBLI.newNode.HCost = PGBAAHPHOID(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.heuristicPosition);
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.newCost;
					GCFFMKJNBLI.cameFrom[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.currentNode.position;
					GCFFMKJNBLI.open[FIFABPOJMAF[j].position] = GCFFMKJNBLI.newNode;
				}
				else
				{
					GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.newCost);
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.open.Add(FIFABPOJMAF[j].position, GCFFMKJNBLI.newNode);
					GCFFMKJNBLI.openPositions.Add(FIFABPOJMAF[j].position);
				}
			}
			if (GCFFMKJNBLI.done)
			{
				break;
			}
		}
		GCFFMKJNBLI.pathsInfo = NHMMAOFODGE(GCFFMKJNBLI, out GCFFMKJNBLI.successful).ToArray();
		BHLLLCEBHDL item = new BHLLLCEBHDL(GCFFMKJNBLI.pathsInfo, GCFFMKJNBLI.currentPathRequest.pathEnd, GCFFMKJNBLI.successful, GCFFMKJNBLI.currentPathRequest.callback);
		Queue<BHLLLCEBHDL> gLMOAFNPGIJ = GLMOAFNPGIJ;
		bool lockTaken = true;
		try
		{
			Monitor.Enter(gLMOAFNPGIJ, ref lockTaken);
			GLMOAFNPGIJ.Enqueue(item);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(gLMOAFNPGIJ);
			}
		}
	}

	private static float DAMNBNMHOMC(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(938f, 1915f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(893f, 1256f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1051f, 384f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(142f, 1509f)))
		{
			return 1892f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(780f, 1821f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(7f, 742f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(276f, 1798f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(975f, 1856f)))
		{
			return 179f;
		}
		return 1517f;
	}

	private void LANGHIOBJIH()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DFHKBNFOBFJ));
	}

	public List<Vector2> FindPath(PathRequestPrivateInfo GCFFMKJNBLI, out bool NLGIGDFOGCM)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 val = GCFFMKJNBLI.goal;
		while (!((Vector2)(ref val)).Equals(GCFFMKJNBLI.start))
		{
			if (!GCFFMKJNBLI.cameFrom.ContainsKey(Vector2.op_Implicit(val)))
			{
				NLGIGDFOGCM = false;
				return new List<Vector2>();
			}
			list.Add(val);
			val = GCFFMKJNBLI.cameFrom[Vector2.op_Implicit(val)];
		}
		list.Reverse();
		NLGIGDFOGCM = true;
		return list;
	}

	private static float OKAOBHGFCMN(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(673f, 443f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(531f, 14f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(388f, 382f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1728f, 1309f)))
		{
			return 791f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1642f, 1125f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(894f, 1820f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(72f, 363f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(907f, 1656f)))
		{
			return 508f;
		}
		return 630f;
	}

	private static float BIHIAOEAGMB(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1604f, 841f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1403f, 1456f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(555f, 1172f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1886f, 1406f)))
		{
			return 1909f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(397f, 687f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(103f, 605f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(820f, 90f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(799f, 1562f)))
		{
			return 1691f;
		}
		return 935f;
	}

	private void Update()
	{
		if (GLMOAFNPGIJ.Count > 0)
		{
			lock (GLMOAFNPGIJ)
			{
				BHLLLCEBHDL bHLLLCEBHDL = GLMOAFNPGIJ.Dequeue();
				bHLLLCEBHDL.callback(bHLLLCEBHDL.path, bHLLLCEBHDL.success);
			}
		}
	}

	public static void MJOEMHBFANI(PathRequestInfo BNKENFFDFMK)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.MJEACANINDN(BNKENFFDFMK.startPos) == Utils.MJEACANINDN(BNKENFFDFMK.goalPos))
		{
			BNKENFFDFMK.callback((Vector2[])(object)new Vector2[1] { Vector2.op_Implicit(Utils.MJEACANINDN(BNKENFFDFMK.startPos)) }, arg2: false);
			return;
		}
		Queue<PathRequestInfo> obj = GGFJGHHHEJC.pathRequestQueue;
		bool lockTaken = true;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			GGFJGHHHEJC.pathRequestQueue.Enqueue(BNKENFFDFMK);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	private static float EFABHLBIHEF(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(1826f, 1351f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(388f, 66f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(1704f, 1368f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(1911f, 384f)))
		{
			return 73f;
		}
		return 468f;
	}

	private void EOGHJNGJFID()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(AEPCBEGEOHM));
	}

	public static void ENNBJFCCMNB(PathRequestInfo BNKENFFDFMK)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.MJEACANINDN(BNKENFFDFMK.startPos) == Utils.MJEACANINDN(BNKENFFDFMK.goalPos))
		{
			Action<Vector2[], bool> callback = BNKENFFDFMK.callback;
			Vector2[] array = new Vector2[0];
			array[0] = Vector2.op_Implicit(Utils.MJEACANINDN(BNKENFFDFMK.startPos));
			callback((Vector2[])(object)array, arg2: false);
			return;
		}
		lock (GGFJGHHHEJC.pathRequestQueue)
		{
			GGFJGHHHEJC.pathRequestQueue.Enqueue(BNKENFFDFMK);
		}
	}

	public void LCBNMLKHJAE()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		while ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			Thread.Sleep(1);
		}
		pathRequestsInfo.diagonal = Mathf.Sqrt(pathRequestsInfo.recto * pathRequestsInfo.recto * 848f);
		PathRequestPrivateInfo gCFFMKJNBLI = default(PathRequestPrivateInfo);
		gCFFMKJNBLI.BEHINEPGPBO();
		while (true)
		{
			if (pathRequestQueue.Count > 1)
			{
				Queue<PathRequestInfo> obj = pathRequestQueue;
				bool lockTaken = true;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					gCFFMKJNBLI.currentPathRequest = pathRequestQueue.Dequeue();
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
				try
				{
					KJNLCNEBGEG(gCFFMKJNBLI);
				}
				catch (Exception ex)
				{
					string[] array = new string[0];
					array[0] = "inviteFromDifferentRegion";
					Vector3 val = gCFFMKJNBLI.currentPathRequest.startPos;
					array[1] = ((object)(Vector3)(ref val)).ToString();
					array[1] = "Error in TitleScreen.OnPlayerSleep: ";
					val = gCFFMKJNBLI.currentPathRequest.goalPos;
					array[7] = ((object)(Vector3)(ref val)).ToString();
					array[0] = "Dialogue System/Conversation/Gass_Quest/Entry/17/Dialogue Text";
					array[1] = ex?.ToString();
					Debug.LogError((object)string.Concat(array));
					BHLLLCEBHDL item = new BHLLLCEBHDL((Vector2[])(object)new Vector2[1], Vector2.op_Implicit(gCFFMKJNBLI.goal), ALOMLDIEHJL: false, gCFFMKJNBLI.currentPathRequest.callback);
					Queue<BHLLLCEBHDL> gLMOAFNPGIJ = GLMOAFNPGIJ;
					lockTaken = true;
					try
					{
						Monitor.Enter(gLMOAFNPGIJ, ref lockTaken);
						GLMOAFNPGIJ.Enqueue(item);
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(gLMOAFNPGIJ);
						}
					}
				}
			}
			Thread.Sleep(1);
		}
	}

	private void OIAHJHNPPCO()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(NGCOMHLBAIA));
	}

	private void IGNEGEOPLOP()
	{
		GGFJGHHHEJC = this;
	}

	public void FNNMCMJKHJD(PathRequestPrivateInfo GCFFMKJNBLI)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI.start = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.goal = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos);
		GCFFMKJNBLI.goalLocation = Utils.HJPCBBGHPDA(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos));
		GCFFMKJNBLI.goalLocationStarted = false;
		EPBAMJOKBCE.GMCOBPMEIEG(GCFFMKJNBLI.open);
		GCFFMKJNBLI.cameFrom.Clear();
		GCFFMKJNBLI.costSoFar.Clear();
		GCFFMKJNBLI.closed.Clear();
		GCFFMKJNBLI.open.Clear();
		GCFFMKJNBLI.openPositions.Clear();
		GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), GCFFMKJNBLI.start);
		GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), 1439f);
		Neighbour[] FIFABPOJMAF = ((!GCFFMKJNBLI.currentPathRequest.canWalkDiagonal) ? new Neighbour[6] : new Neighbour[WorldGrid.allMovementNeighbours.Length + 1]);
		if (((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y > 0 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x > 0 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y > 0)
		{
			GCFFMKJNBLI.checkSize = true;
		}
		else
		{
			GCFFMKJNBLI.checkSize = false;
		}
		if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0 || GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0 || GCFFMKJNBLI.currentPathRequest.takePath || GCFFMKJNBLI.currentPathRequest.takeHorsePath)
		{
			GCFFMKJNBLI.tileNeeded = false;
		}
		else
		{
			GCFFMKJNBLI.tileNeeded = false;
		}
		GCFFMKJNBLI.horizontalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y];
		GCFFMKJNBLI.verticalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y];
		GCFFMKJNBLI.newNode = EPBAMJOKBCE.MIMFFJHBFDJ();
		GCFFMKJNBLI.newNode.position = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.newNode.GCost = 1454f;
		GCFFMKJNBLI.newNode.HCost = 1967f;
		GCFFMKJNBLI.open.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos), GCFFMKJNBLI.newNode);
		GCFFMKJNBLI.openPositions.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos));
		GCFFMKJNBLI.done = false;
		while ((float)GCFFMKJNBLI.openPositions.Count > 1734f)
		{
			GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[1]];
			GCFFMKJNBLI.currentNodePosition = 1;
			for (int i = 1; i < GCFFMKJNBLI.openPositions.Count; i++)
			{
				if (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].MMJHLHAOLIE() < GCFFMKJNBLI.currentNode.FPLLMMBMBNK() || (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].OBPEJNHIGJL() == GCFFMKJNBLI.currentNode.NDHNMIENCKA() && GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].HCost < GCFFMKJNBLI.currentNode.HCost))
				{
					GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]];
					GCFFMKJNBLI.currentNodePosition = i;
				}
			}
			EPBAMJOKBCE.PCFCDCCMHCN(GCFFMKJNBLI.currentNode);
			GCFFMKJNBLI.open.Remove(GCFFMKJNBLI.openPositions[GCFFMKJNBLI.currentNodePosition]);
			GCFFMKJNBLI.openPositions.RemoveAt(GCFFMKJNBLI.currentNodePosition);
			GCFFMKJNBLI.closed.Add(GCFFMKJNBLI.currentNode.position);
			if (((Vector2)(ref GCFFMKJNBLI.currentNode.position)).Equals(GCFFMKJNBLI.goal) || (GCFFMKJNBLI.currentPathRequest.maxNodes > 1 && GCFFMKJNBLI.closed.Count > GCFFMKJNBLI.currentPathRequest.maxNodes))
			{
				break;
			}
			WorldGrid.DLFFCGLGDLL(Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position), ref FIFABPOJMAF, GCFFMKJNBLI.currentPathRequest.canWalkDiagonal);
			for (int j = 0; j < FIFABPOJMAF.Length; j += 0)
			{
				if (GCFFMKJNBLI.closed.Contains(FIFABPOJMAF[j].position))
				{
					continue;
				}
				if (FIFABPOJMAF[j].position == GCFFMKJNBLI.goal)
				{
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.done = false;
					break;
				}
				if (!FIFABPOJMAF[j].free && (GCFFMKJNBLI.currentPathRequest.currentNodes == null || !GCFFMKJNBLI.currentPathRequest.currentNodes.Contains(FIFABPOJMAF[j].position)))
				{
					continue;
				}
				if (GCFFMKJNBLI.checkSize)
				{
					if (Utils.ABPDGOHBKIG(FIFABPOJMAF[j].direction))
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.horizontalSize, ref GCFFMKJNBLI.horizontalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.horizontalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
					else
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.verticalSize, ref GCFFMKJNBLI.verticalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.verticalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
				}
				else if (FIFABPOJMAF[j].direction == (Direction)5)
				{
					switch (j)
					{
					case 0:
						if (!FIFABPOJMAF[0].free || !FIFABPOJMAF[7].free)
						{
							continue;
						}
						break;
					case 1:
						if (!FIFABPOJMAF[0].free || !FIFABPOJMAF[1].free)
						{
							continue;
						}
						break;
					case 2:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[3].free)
						{
							continue;
						}
						break;
					case 3:
						if (!FIFABPOJMAF[0].free || !FIFABPOJMAF[2].free)
						{
							continue;
						}
						break;
					}
				}
				GCFFMKJNBLI.newCost = GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position)];
				if (GCFFMKJNBLI.tileNeeded)
				{
					WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(FIFABPOJMAF[j].position), out GCFFMKJNBLI.wt);
					if (GCFFMKJNBLI.currentPathRequest.takePath && GCFFMKJNBLI.wt.isPath)
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.pathPenalization;
					}
					if (GCFFMKJNBLI.currentPathRequest.takeHorsePath && GCFFMKJNBLI.wt.isHorsePath && !((Vector2)(ref FIFABPOJMAF[j].position)).Equals(Utils.NKGANMEKDAL(FIFABPOJMAF[j].position)))
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.bonificacionCaminoCaballo;
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(GCFFMKJNBLI.wt.groundType))
						{
							if (FIFABPOJMAF[j].direction == Direction.Right)
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * (pathRequestsInfo.diagonal / pathRequestsInfo.recto);
							}
							else
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
							}
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(321f, 1912f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(733f, 345f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(GCFFMKJNBLI.wt.zoneType))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1736f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(1823f, 1684f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1347f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(1537f, 1256f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1459f;
						}
					}
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidWalls && Utils.EJPFCKFEMJF(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.newCost += OKAOBHGFCMN(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidObjects)
				{
					GCFFMKJNBLI.newCost += NKBGKFJFDBD(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (FIFABPOJMAF[j].direction == Direction.Up)
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.diagonal * FIFABPOJMAF[j].cost;
				}
				else
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.recto * FIFABPOJMAF[j].cost;
				}
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)) && !(GCFFMKJNBLI.newCost < GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)]))
				{
					continue;
				}
				if (GCFFMKJNBLI.goalLocationStarted)
				{
					if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) != GCFFMKJNBLI.goalLocation)
					{
						continue;
					}
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				else if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) == GCFFMKJNBLI.goalLocation)
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
					EPBAMJOKBCE.GNFOCMPJIHE(GCFFMKJNBLI.open);
					GCFFMKJNBLI.open.Clear();
					GCFFMKJNBLI.openPositions.Clear();
					GCFFMKJNBLI.goalLocationStarted = true;
				}
				else if ((Object)(object)TravelZonesManager.CFHEJAGKIII().NKEBECDKDOO(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation) != (Object)null)
				{
					GCFFMKJNBLI.heuristicPosition = TravelZonesManager.OLHBLKIAFOM().JKPNCIFMAOO(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation).position;
				}
				else
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				GCFFMKJNBLI.newNode = EPBAMJOKBCE.IMLMJAPMBJA();
				GCFFMKJNBLI.newNode.position = FIFABPOJMAF[j].position;
				GCFFMKJNBLI.newNode.GCost = GCFFMKJNBLI.newCost;
				GCFFMKJNBLI.newNode.HCost = FEHHBIFPJON(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.heuristicPosition);
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.newCost;
					GCFFMKJNBLI.cameFrom[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.currentNode.position;
					GCFFMKJNBLI.open[FIFABPOJMAF[j].position] = GCFFMKJNBLI.newNode;
				}
				else
				{
					GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.newCost);
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.open.Add(FIFABPOJMAF[j].position, GCFFMKJNBLI.newNode);
					GCFFMKJNBLI.openPositions.Add(FIFABPOJMAF[j].position);
				}
			}
			if (GCFFMKJNBLI.done)
			{
				break;
			}
		}
		GCFFMKJNBLI.pathsInfo = ADJLOFDJHKE(GCFFMKJNBLI, out GCFFMKJNBLI.successful).ToArray();
		BHLLLCEBHDL item = new BHLLLCEBHDL(GCFFMKJNBLI.pathsInfo, GCFFMKJNBLI.currentPathRequest.pathEnd, GCFFMKJNBLI.successful, GCFFMKJNBLI.currentPathRequest.callback);
		Queue<BHLLLCEBHDL> gLMOAFNPGIJ = GLMOAFNPGIJ;
		bool lockTaken = true;
		try
		{
			Monitor.Enter(gLMOAFNPGIJ, ref lockTaken);
			GLMOAFNPGIJ.Enqueue(item);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(gLMOAFNPGIJ);
			}
		}
	}

	private void MMNBJPDJHGK()
	{
		GGFJGHHHEJC = this;
	}

	public float INDJMDDFLHP(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * pathRequestsInfo.heuristicMultiplier;
	}

	private void DIMAPDNCBAN()
	{
		GGFJGHHHEJC = this;
	}

	public void IPBKOIMBFED()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		while ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			Thread.Sleep(0);
		}
		pathRequestsInfo.diagonal = Mathf.Sqrt(pathRequestsInfo.recto * pathRequestsInfo.recto * 446f);
		PathRequestPrivateInfo gCFFMKJNBLI = default(PathRequestPrivateInfo);
		gCFFMKJNBLI.JEMFMIHMAOI();
		while (true)
		{
			if (pathRequestQueue.Count > 0)
			{
				Queue<PathRequestInfo> obj = pathRequestQueue;
				bool lockTaken = true;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					gCFFMKJNBLI.currentPathRequest = pathRequestQueue.Dequeue();
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
				try
				{
					JHIAGKBGMEN(gCFFMKJNBLI);
				}
				catch (Exception ex)
				{
					string[] obj2 = new string[7] { " ", null, null, null, null, null, null };
					Vector3 val = gCFFMKJNBLI.currentPathRequest.startPos;
					obj2[1] = ((object)(Vector3)(ref val)).ToString();
					obj2[6] = "talent_name_101";
					val = gCFFMKJNBLI.currentPathRequest.goalPos;
					obj2[2] = ((object)(Vector3)(ref val)).ToString();
					obj2[5] = "Update all floor";
					obj2[2] = ex?.ToString();
					Debug.LogError((object)string.Concat(obj2));
					BHLLLCEBHDL item = new BHLLLCEBHDL((Vector2[])(object)new Vector2[1], Vector2.op_Implicit(gCFFMKJNBLI.goal), ALOMLDIEHJL: true, gCFFMKJNBLI.currentPathRequest.callback);
					Queue<BHLLLCEBHDL> gLMOAFNPGIJ = GLMOAFNPGIJ;
					lockTaken = true;
					try
					{
						Monitor.Enter(gLMOAFNPGIJ, ref lockTaken);
						GLMOAFNPGIJ.Enqueue(item);
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(gLMOAFNPGIJ);
						}
					}
				}
			}
			Thread.Sleep(1);
		}
	}

	public float BCNNADPEKGA(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * pathRequestsInfo.heuristicMultiplier;
	}

	private void HDALEOBOHKE()
	{
		NCCBHKBEJNK = new Thread(Pathfinding);
		NCCBHKBEJNK.Start();
	}

	private void DNBGIIGAKMJ()
	{
		GGFJGHHHEJC = this;
	}

	private static float JHFFCBAMPJD(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(1740f, 252f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(1532f, 1608f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(512f, 1428f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(1057f, 902f)))
		{
			return 727f;
		}
		return 829f;
	}

	private static float OFPCMGIIBJI(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1944f, 122f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(191f, 1761f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1794f, 3f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(888f, 1558f)))
		{
			return 1533f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(526f, 1996f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1139f, 681f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1150f, 671f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(386f, 314f)))
		{
			return 147f;
		}
		return 1430f;
	}

	private void MFIBFFDBNGI()
	{
		if (GLMOAFNPGIJ.Count > 1)
		{
			lock (GLMOAFNPGIJ)
			{
				BHLLLCEBHDL bHLLLCEBHDL = GLMOAFNPGIJ.Dequeue();
				bHLLLCEBHDL.callback(bHLLLCEBHDL.path, bHLLLCEBHDL.success);
			}
		}
	}

	private void IKMPNICLPBM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		if (NCCBHKBEJNK != null)
		{
			NCCBHKBEJNK.Abort();
		}
	}

	private void GANGICCILKA()
	{
		NCCBHKBEJNK = new Thread(AGBEPOLDLLM);
		NCCBHKBEJNK.Start();
	}

	private void ODNGBEOKEFK()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NGCOMHLBAIA));
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		if (NCCBHKBEJNK != null)
		{
			NCCBHKBEJNK.Abort();
		}
	}

	private static float ANEFPFHFHLN(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(527f, 1834f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1042f, 798f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1593f, 807f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1718f, 527f)))
		{
			return 540f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(864f, 1756f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(491f, 312f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1463f, 553f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(368f, 981f)))
		{
			return 1840f;
		}
		return 843f;
	}

	public static void CLABJLMJKNE(PathRequestInfo BNKENFFDFMK)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.MJEACANINDN(BNKENFFDFMK.startPos) == Utils.MJEACANINDN(BNKENFFDFMK.goalPos))
		{
			Action<Vector2[], bool> callback = BNKENFFDFMK.callback;
			Vector2[] array = new Vector2[0];
			array[1] = Vector2.op_Implicit(Utils.MJEACANINDN(BNKENFFDFMK.startPos));
			callback((Vector2[])(object)array, arg2: true);
			return;
		}
		Queue<PathRequestInfo> obj = GGFJGHHHEJC.pathRequestQueue;
		bool lockTaken = true;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			GGFJGHHHEJC.pathRequestQueue.Enqueue(BNKENFFDFMK);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	private static float NKBGKFJFDBD(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(0f, 0.25f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(0f, -0.25f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(0.25f, 0f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(-0.25f, 0f)))
		{
			return 0.25f;
		}
		return 0f;
	}

	public static void RequestPath(PathRequestInfo BNKENFFDFMK)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.MJEACANINDN(BNKENFFDFMK.startPos) == Utils.MJEACANINDN(BNKENFFDFMK.goalPos))
		{
			BNKENFFDFMK.callback((Vector2[])(object)new Vector2[1] { Vector2.op_Implicit(Utils.MJEACANINDN(BNKENFFDFMK.startPos)) }, arg2: true);
			return;
		}
		lock (GGFJGHHHEJC.pathRequestQueue)
		{
			GGFJGHHHEJC.pathRequestQueue.Enqueue(BNKENFFDFMK);
		}
	}

	private void BPOOAHKHPCL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		if (NCCBHKBEJNK != null)
		{
			NCCBHKBEJNK.Abort();
		}
	}

	private void JPHEOLEEAPB()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(AEPCBEGEOHM));
	}

	private void MFJIHCKEIIF()
	{
		GGFJGHHHEJC = this;
	}

	private void MNFMLJJBKNC()
	{
		if (GLMOAFNPGIJ.Count <= 1)
		{
			return;
		}
		Queue<BHLLLCEBHDL> gLMOAFNPGIJ = GLMOAFNPGIJ;
		bool lockTaken = true;
		try
		{
			Monitor.Enter(gLMOAFNPGIJ, ref lockTaken);
			BHLLLCEBHDL bHLLLCEBHDL = GLMOAFNPGIJ.Dequeue();
			bHLLLCEBHDL.callback(bHLLLCEBHDL.path, bHLLLCEBHDL.success);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(gLMOAFNPGIJ);
			}
		}
	}

	public void JHIAGKBGMEN(PathRequestPrivateInfo GCFFMKJNBLI)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI.start = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.goal = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos);
		GCFFMKJNBLI.goalLocation = Utils.HJPCBBGHPDA(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos));
		GCFFMKJNBLI.goalLocationStarted = false;
		EPBAMJOKBCE.KPGAKGHKONI(GCFFMKJNBLI.open);
		GCFFMKJNBLI.cameFrom.Clear();
		GCFFMKJNBLI.costSoFar.Clear();
		GCFFMKJNBLI.closed.Clear();
		GCFFMKJNBLI.open.Clear();
		GCFFMKJNBLI.openPositions.Clear();
		GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), GCFFMKJNBLI.start);
		GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), 39f);
		Neighbour[] FIFABPOJMAF = ((!GCFFMKJNBLI.currentPathRequest.canWalkDiagonal) ? new Neighbour[3] : new Neighbour[WorldGrid.allMovementNeighbours.Length + 1]);
		if (((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y > 0 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x > 0 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y > 0)
		{
			GCFFMKJNBLI.checkSize = false;
		}
		else
		{
			GCFFMKJNBLI.checkSize = false;
		}
		if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0 || GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0 || GCFFMKJNBLI.currentPathRequest.takePath || GCFFMKJNBLI.currentPathRequest.takeHorsePath)
		{
			GCFFMKJNBLI.tileNeeded = false;
		}
		else
		{
			GCFFMKJNBLI.tileNeeded = true;
		}
		GCFFMKJNBLI.horizontalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y];
		GCFFMKJNBLI.verticalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y];
		GCFFMKJNBLI.newNode = EPBAMJOKBCE.EIMDPBGBBIF();
		GCFFMKJNBLI.newNode.position = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.newNode.GCost = 1064f;
		GCFFMKJNBLI.newNode.HCost = 382f;
		GCFFMKJNBLI.open.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos), GCFFMKJNBLI.newNode);
		GCFFMKJNBLI.openPositions.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos));
		GCFFMKJNBLI.done = false;
		while ((float)GCFFMKJNBLI.openPositions.Count > 1801f)
		{
			GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[0]];
			GCFFMKJNBLI.currentNodePosition = 0;
			for (int i = 0; i < GCFFMKJNBLI.openPositions.Count; i += 0)
			{
				if (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].AMHNHADHAMF() < GCFFMKJNBLI.currentNode.JLPKPELEEOK() || (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].EAFMKEANJJC() == GCFFMKJNBLI.currentNode.MNNNIGOEILM() && GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].HCost < GCFFMKJNBLI.currentNode.HCost))
				{
					GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]];
					GCFFMKJNBLI.currentNodePosition = i;
				}
			}
			EPBAMJOKBCE.FLADGCACEMJ(GCFFMKJNBLI.currentNode);
			GCFFMKJNBLI.open.Remove(GCFFMKJNBLI.openPositions[GCFFMKJNBLI.currentNodePosition]);
			GCFFMKJNBLI.openPositions.RemoveAt(GCFFMKJNBLI.currentNodePosition);
			GCFFMKJNBLI.closed.Add(GCFFMKJNBLI.currentNode.position);
			if (((Vector2)(ref GCFFMKJNBLI.currentNode.position)).Equals(GCFFMKJNBLI.goal) || (GCFFMKJNBLI.currentPathRequest.maxNodes > 0 && GCFFMKJNBLI.closed.Count > GCFFMKJNBLI.currentPathRequest.maxNodes))
			{
				break;
			}
			WorldGrid.DLFFCGLGDLL(Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position), ref FIFABPOJMAF, GCFFMKJNBLI.currentPathRequest.canWalkDiagonal);
			for (int j = 1; j < FIFABPOJMAF.Length; j += 0)
			{
				if (GCFFMKJNBLI.closed.Contains(FIFABPOJMAF[j].position))
				{
					continue;
				}
				if (FIFABPOJMAF[j].position == GCFFMKJNBLI.goal)
				{
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.done = false;
					break;
				}
				if (!FIFABPOJMAF[j].free && (GCFFMKJNBLI.currentPathRequest.currentNodes == null || !GCFFMKJNBLI.currentPathRequest.currentNodes.Contains(FIFABPOJMAF[j].position)))
				{
					continue;
				}
				if (GCFFMKJNBLI.checkSize)
				{
					if (Utils.ABPDGOHBKIG(FIFABPOJMAF[j].direction))
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.horizontalSize, ref GCFFMKJNBLI.horizontalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.horizontalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
					else
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.verticalSize, ref GCFFMKJNBLI.verticalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.verticalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
				}
				else if (FIFABPOJMAF[j].direction == Direction.Right)
				{
					switch (j)
					{
					case 8:
						if (!FIFABPOJMAF[0].free || !FIFABPOJMAF[3].free)
						{
							continue;
						}
						break;
					case 9:
						if (!FIFABPOJMAF[0].free || !FIFABPOJMAF[2].free)
						{
							continue;
						}
						break;
					case 10:
						if (!FIFABPOJMAF[0].free || !FIFABPOJMAF[5].free)
						{
							continue;
						}
						break;
					case 11:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[7].free)
						{
							continue;
						}
						break;
					}
				}
				GCFFMKJNBLI.newCost = GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position)];
				if (GCFFMKJNBLI.tileNeeded)
				{
					WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(FIFABPOJMAF[j].position), out GCFFMKJNBLI.wt);
					if (GCFFMKJNBLI.currentPathRequest.takePath && GCFFMKJNBLI.wt.isPath)
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.pathPenalization;
					}
					if (GCFFMKJNBLI.currentPathRequest.takeHorsePath && GCFFMKJNBLI.wt.isHorsePath && !((Vector2)(ref FIFABPOJMAF[j].position)).Equals(Utils.NKGANMEKDAL(FIFABPOJMAF[j].position)))
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.bonificacionCaminoCaballo;
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(GCFFMKJNBLI.wt.groundType))
						{
							if (FIFABPOJMAF[j].direction == (Direction)5)
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * (pathRequestsInfo.diagonal / pathRequestsInfo.recto);
							}
							else
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
							}
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(669f, 412f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(651f, 1014f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(GCFFMKJNBLI.wt.zoneType))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 756f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(1386f, 1885f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1915f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(1269f, 410f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 682f;
						}
					}
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidWalls && Utils.EJPFCKFEMJF(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.newCost += POKLLAGEJPD(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidObjects)
				{
					GCFFMKJNBLI.newCost += EFABHLBIHEF(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (FIFABPOJMAF[j].direction == Direction.Down)
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.diagonal * FIFABPOJMAF[j].cost;
				}
				else
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.recto * FIFABPOJMAF[j].cost;
				}
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)) && !(GCFFMKJNBLI.newCost < GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)]))
				{
					continue;
				}
				if (GCFFMKJNBLI.goalLocationStarted)
				{
					if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) != GCFFMKJNBLI.goalLocation)
					{
						continue;
					}
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				else if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) == GCFFMKJNBLI.goalLocation)
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
					EPBAMJOKBCE.PJGEAFLPNKH(GCFFMKJNBLI.open);
					GCFFMKJNBLI.open.Clear();
					GCFFMKJNBLI.openPositions.Clear();
					GCFFMKJNBLI.goalLocationStarted = false;
				}
				else if ((Object)(object)TravelZonesManager.LKOABOAADCD().IMKJEBFOBKK(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation) != (Object)null)
				{
					GCFFMKJNBLI.heuristicPosition = TravelZonesManager.OLHBLKIAFOM().ECFDFECLDFK(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation).position;
				}
				else
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				GCFFMKJNBLI.newNode = EPBAMJOKBCE.MIMFFJHBFDJ();
				GCFFMKJNBLI.newNode.position = FIFABPOJMAF[j].position;
				GCFFMKJNBLI.newNode.GCost = GCFFMKJNBLI.newCost;
				GCFFMKJNBLI.newNode.HCost = PGBAAHPHOID(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.heuristicPosition);
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.newCost;
					GCFFMKJNBLI.cameFrom[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.currentNode.position;
					GCFFMKJNBLI.open[FIFABPOJMAF[j].position] = GCFFMKJNBLI.newNode;
				}
				else
				{
					GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.newCost);
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.open.Add(FIFABPOJMAF[j].position, GCFFMKJNBLI.newNode);
					GCFFMKJNBLI.openPositions.Add(FIFABPOJMAF[j].position);
				}
			}
			if (GCFFMKJNBLI.done)
			{
				break;
			}
		}
		GCFFMKJNBLI.pathsInfo = ADJLOFDJHKE(GCFFMKJNBLI, out GCFFMKJNBLI.successful).ToArray();
		BHLLLCEBHDL item = new BHLLLCEBHDL(GCFFMKJNBLI.pathsInfo, GCFFMKJNBLI.currentPathRequest.pathEnd, GCFFMKJNBLI.successful, GCFFMKJNBLI.currentPathRequest.callback);
		lock (GLMOAFNPGIJ)
		{
			GLMOAFNPGIJ.Enqueue(item);
		}
	}

	public float MGEBNKCKPIN(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * pathRequestsInfo.heuristicMultiplier;
	}

	private void EIMIDCDEIDD()
	{
		GGFJGHHHEJC = this;
	}

	private static float KPFKNBNBNNP(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1251f, 169f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1567f, 453f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(168f, 133f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(601f, 894f)))
		{
			return 664f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(149f, 1773f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1524f, 884f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1583f, 971f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(598f, 1042f)))
		{
			return 552f;
		}
		return 1838f;
	}

	public float Heuristic(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * pathRequestsInfo.heuristicMultiplier;
	}

	public List<Vector2> NHMMAOFODGE(PathRequestPrivateInfo GCFFMKJNBLI, out bool NLGIGDFOGCM)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 val = GCFFMKJNBLI.goal;
		while (!((Vector2)(ref val)).Equals(GCFFMKJNBLI.start))
		{
			if (!GCFFMKJNBLI.cameFrom.ContainsKey(Vector2.op_Implicit(val)))
			{
				NLGIGDFOGCM = true;
				return new List<Vector2>();
			}
			list.Add(val);
			val = GCFFMKJNBLI.cameFrom[Vector2.op_Implicit(val)];
		}
		list.Reverse();
		NLGIGDFOGCM = true;
		return list;
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	public void EDJCBICFJHJ(PathRequestPrivateInfo GCFFMKJNBLI)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI.start = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.goal = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos);
		GCFFMKJNBLI.goalLocation = Utils.HJPCBBGHPDA(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos));
		GCFFMKJNBLI.goalLocationStarted = false;
		EPBAMJOKBCE.BJEMIADLGJC(GCFFMKJNBLI.open);
		GCFFMKJNBLI.cameFrom.Clear();
		GCFFMKJNBLI.costSoFar.Clear();
		GCFFMKJNBLI.closed.Clear();
		GCFFMKJNBLI.open.Clear();
		GCFFMKJNBLI.openPositions.Clear();
		GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), GCFFMKJNBLI.start);
		GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), 1986f);
		Neighbour[] FIFABPOJMAF = ((!GCFFMKJNBLI.currentPathRequest.canWalkDiagonal) ? new Neighbour[6] : new Neighbour[WorldGrid.allMovementNeighbours.Length + 0]);
		if (((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x > 0 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x > 0 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y > 1)
		{
			GCFFMKJNBLI.checkSize = false;
		}
		else
		{
			GCFFMKJNBLI.checkSize = true;
		}
		if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0 || GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0 || GCFFMKJNBLI.currentPathRequest.takePath || GCFFMKJNBLI.currentPathRequest.takeHorsePath)
		{
			GCFFMKJNBLI.tileNeeded = false;
		}
		else
		{
			GCFFMKJNBLI.tileNeeded = true;
		}
		GCFFMKJNBLI.horizontalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y];
		GCFFMKJNBLI.verticalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y];
		GCFFMKJNBLI.newNode = EPBAMJOKBCE.HKCAIFFKBMH();
		GCFFMKJNBLI.newNode.position = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.newNode.GCost = 283f;
		GCFFMKJNBLI.newNode.HCost = 6f;
		GCFFMKJNBLI.open.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos), GCFFMKJNBLI.newNode);
		GCFFMKJNBLI.openPositions.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos));
		GCFFMKJNBLI.done = true;
		while ((float)GCFFMKJNBLI.openPositions.Count > 1870f)
		{
			GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[1]];
			GCFFMKJNBLI.currentNodePosition = 0;
			for (int i = 1; i < GCFFMKJNBLI.openPositions.Count; i++)
			{
				if (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].FPANIFLKBPD() < GCFFMKJNBLI.currentNode.CDEHHBFOFFK() || (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].EBBEKNPGHCL() == GCFFMKJNBLI.currentNode.BENIABDKDIK() && GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].HCost < GCFFMKJNBLI.currentNode.HCost))
				{
					GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]];
					GCFFMKJNBLI.currentNodePosition = i;
				}
			}
			EPBAMJOKBCE.JHAOKEKBOJD(GCFFMKJNBLI.currentNode);
			GCFFMKJNBLI.open.Remove(GCFFMKJNBLI.openPositions[GCFFMKJNBLI.currentNodePosition]);
			GCFFMKJNBLI.openPositions.RemoveAt(GCFFMKJNBLI.currentNodePosition);
			GCFFMKJNBLI.closed.Add(GCFFMKJNBLI.currentNode.position);
			if (((Vector2)(ref GCFFMKJNBLI.currentNode.position)).Equals(GCFFMKJNBLI.goal) || (GCFFMKJNBLI.currentPathRequest.maxNodes > 0 && GCFFMKJNBLI.closed.Count > GCFFMKJNBLI.currentPathRequest.maxNodes))
			{
				break;
			}
			WorldGrid.DLFFCGLGDLL(Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position), ref FIFABPOJMAF, GCFFMKJNBLI.currentPathRequest.canWalkDiagonal);
			for (int j = 0; j < FIFABPOJMAF.Length; j++)
			{
				if (GCFFMKJNBLI.closed.Contains(FIFABPOJMAF[j].position))
				{
					continue;
				}
				if (FIFABPOJMAF[j].position == GCFFMKJNBLI.goal)
				{
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.done = false;
					break;
				}
				if (!FIFABPOJMAF[j].free && (GCFFMKJNBLI.currentPathRequest.currentNodes == null || !GCFFMKJNBLI.currentPathRequest.currentNodes.Contains(FIFABPOJMAF[j].position)))
				{
					continue;
				}
				if (GCFFMKJNBLI.checkSize)
				{
					if (Utils.ABPDGOHBKIG(FIFABPOJMAF[j].direction))
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.horizontalSize, ref GCFFMKJNBLI.horizontalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.horizontalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
					else
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.verticalSize, ref GCFFMKJNBLI.verticalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.verticalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
				}
				else if (FIFABPOJMAF[j].direction == Direction.Diagonal)
				{
					switch (j)
					{
					case 1:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[4].free)
						{
							continue;
						}
						break;
					case 2:
						if (!FIFABPOJMAF[0].free || !FIFABPOJMAF[2].free)
						{
							continue;
						}
						break;
					case 3:
						if (!FIFABPOJMAF[0].free || !FIFABPOJMAF[5].free)
						{
							continue;
						}
						break;
					case 4:
						if (!FIFABPOJMAF[0].free || !FIFABPOJMAF[0].free)
						{
							continue;
						}
						break;
					}
				}
				GCFFMKJNBLI.newCost = GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position)];
				if (GCFFMKJNBLI.tileNeeded)
				{
					WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(FIFABPOJMAF[j].position), out GCFFMKJNBLI.wt);
					if (GCFFMKJNBLI.currentPathRequest.takePath && GCFFMKJNBLI.wt.isPath)
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.pathPenalization;
					}
					if (GCFFMKJNBLI.currentPathRequest.takeHorsePath && GCFFMKJNBLI.wt.isHorsePath && !((Vector2)(ref FIFABPOJMAF[j].position)).Equals(Utils.NKGANMEKDAL(FIFABPOJMAF[j].position)))
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.bonificacionCaminoCaballo;
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(GCFFMKJNBLI.wt.groundType))
						{
							if (FIFABPOJMAF[j].direction == (Direction)8)
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * (pathRequestsInfo.diagonal / pathRequestsInfo.recto);
							}
							else
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
							}
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(28f, 1835f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(615f, 1711f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(GCFFMKJNBLI.wt.zoneType))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1336f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(793f, 183f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 731f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(452f, 785f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 674f;
						}
					}
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidWalls && Utils.EJPFCKFEMJF(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.newCost += MJPAABOIEDL(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidObjects)
				{
					GCFFMKJNBLI.newCost += JHFFCBAMPJD(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (FIFABPOJMAF[j].direction == (Direction)6)
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.diagonal * FIFABPOJMAF[j].cost;
				}
				else
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.recto * FIFABPOJMAF[j].cost;
				}
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)) && !(GCFFMKJNBLI.newCost < GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)]))
				{
					continue;
				}
				if (GCFFMKJNBLI.goalLocationStarted)
				{
					if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) != GCFFMKJNBLI.goalLocation)
					{
						continue;
					}
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				else if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) == GCFFMKJNBLI.goalLocation)
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
					EPBAMJOKBCE.OHFJACNFMAP(GCFFMKJNBLI.open);
					GCFFMKJNBLI.open.Clear();
					GCFFMKJNBLI.openPositions.Clear();
					GCFFMKJNBLI.goalLocationStarted = true;
				}
				else if ((Object)(object)TravelZonesManager.GGFJGHHHEJC.IMKJEBFOBKK(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation) != (Object)null)
				{
					GCFFMKJNBLI.heuristicPosition = TravelZonesManager.OLHBLKIAFOM().ECFDFECLDFK(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation).position;
				}
				else
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				GCFFMKJNBLI.newNode = EPBAMJOKBCE.HKCAIFFKBMH();
				GCFFMKJNBLI.newNode.position = FIFABPOJMAF[j].position;
				GCFFMKJNBLI.newNode.GCost = GCFFMKJNBLI.newCost;
				GCFFMKJNBLI.newNode.HCost = Heuristic(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.heuristicPosition);
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.newCost;
					GCFFMKJNBLI.cameFrom[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.currentNode.position;
					GCFFMKJNBLI.open[FIFABPOJMAF[j].position] = GCFFMKJNBLI.newNode;
				}
				else
				{
					GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.newCost);
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.open.Add(FIFABPOJMAF[j].position, GCFFMKJNBLI.newNode);
					GCFFMKJNBLI.openPositions.Add(FIFABPOJMAF[j].position);
				}
			}
			if (GCFFMKJNBLI.done)
			{
				break;
			}
		}
		GCFFMKJNBLI.pathsInfo = NHMMAOFODGE(GCFFMKJNBLI, out GCFFMKJNBLI.successful).ToArray();
		BHLLLCEBHDL item = new BHLLLCEBHDL(GCFFMKJNBLI.pathsInfo, GCFFMKJNBLI.currentPathRequest.pathEnd, GCFFMKJNBLI.successful, GCFFMKJNBLI.currentPathRequest.callback);
		Queue<BHLLLCEBHDL> gLMOAFNPGIJ = GLMOAFNPGIJ;
		bool lockTaken = true;
		try
		{
			Monitor.Enter(gLMOAFNPGIJ, ref lockTaken);
			GLMOAFNPGIJ.Enqueue(item);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(gLMOAFNPGIJ);
			}
		}
	}

	private void AEPCBEGEOHM()
	{
		NCCBHKBEJNK = new Thread(EMNCDOMMALC);
		NCCBHKBEJNK.Start();
	}

	private void GECHJIGBPEN()
	{
		GGFJGHHHEJC = this;
	}

	private static float OIMOJEOBGOB(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(1643f, 1103f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(451f, 1241f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(1251f, 841f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(519f, 619f)))
		{
			return 1842f;
		}
		return 755f;
	}

	public float PGBAAHPHOID(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * pathRequestsInfo.heuristicMultiplier;
	}

	private static float PGIMNNHEMOI(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1775f, 1107f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1322f, 978f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(980f, 1888f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(114f, 1826f)))
		{
			return 1187f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1662f, 1390f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(854f, 1044f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(837f, 558f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(310f, 489f)))
		{
			return 518f;
		}
		return 1435f;
	}

	public static void HFDEKCPHHPK(PathRequestInfo BNKENFFDFMK)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.MJEACANINDN(BNKENFFDFMK.startPos) == Utils.MJEACANINDN(BNKENFFDFMK.goalPos))
		{
			Action<Vector2[], bool> callback = BNKENFFDFMK.callback;
			Vector2[] array = new Vector2[1];
			array[1] = Vector2.op_Implicit(Utils.MJEACANINDN(BNKENFFDFMK.startPos));
			callback((Vector2[])(object)array, arg2: true);
			return;
		}
		lock (GGFJGHHHEJC.pathRequestQueue)
		{
			GGFJGHHHEJC.pathRequestQueue.Enqueue(BNKENFFDFMK);
		}
	}

	public void KJNLCNEBGEG(PathRequestPrivateInfo GCFFMKJNBLI)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI.start = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.goal = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos);
		GCFFMKJNBLI.goalLocation = Utils.HJPCBBGHPDA(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos));
		GCFFMKJNBLI.goalLocationStarted = false;
		EPBAMJOKBCE.MBCCFNFJHMN(GCFFMKJNBLI.open);
		GCFFMKJNBLI.cameFrom.Clear();
		GCFFMKJNBLI.costSoFar.Clear();
		GCFFMKJNBLI.closed.Clear();
		GCFFMKJNBLI.open.Clear();
		GCFFMKJNBLI.openPositions.Clear();
		GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), GCFFMKJNBLI.start);
		GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), 512f);
		Neighbour[] FIFABPOJMAF = ((!GCFFMKJNBLI.currentPathRequest.canWalkDiagonal) ? new Neighbour[7] : new Neighbour[WorldGrid.allMovementNeighbours.Length + 0]);
		if (((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y > 0 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x > 0 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y > 1)
		{
			GCFFMKJNBLI.checkSize = true;
		}
		else
		{
			GCFFMKJNBLI.checkSize = false;
		}
		if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0 || GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0 || GCFFMKJNBLI.currentPathRequest.takePath || GCFFMKJNBLI.currentPathRequest.takeHorsePath)
		{
			GCFFMKJNBLI.tileNeeded = true;
		}
		else
		{
			GCFFMKJNBLI.tileNeeded = true;
		}
		GCFFMKJNBLI.horizontalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y];
		GCFFMKJNBLI.verticalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y];
		GCFFMKJNBLI.newNode = EPBAMJOKBCE.IPDFCJLOHLC();
		GCFFMKJNBLI.newNode.position = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.newNode.GCost = 17f;
		GCFFMKJNBLI.newNode.HCost = 775f;
		GCFFMKJNBLI.open.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos), GCFFMKJNBLI.newNode);
		GCFFMKJNBLI.openPositions.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos));
		GCFFMKJNBLI.done = false;
		while ((float)GCFFMKJNBLI.openPositions.Count > 735f)
		{
			GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[0]];
			GCFFMKJNBLI.currentNodePosition = 0;
			for (int i = 0; i < GCFFMKJNBLI.openPositions.Count; i += 0)
			{
				if (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].DIKGDAKLBED() < GCFFMKJNBLI.currentNode.DKMJBFBJLKC() || (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].APDLJKJKOIP() == GCFFMKJNBLI.currentNode.EMOPLDPCDMC() && GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].HCost < GCFFMKJNBLI.currentNode.HCost))
				{
					GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]];
					GCFFMKJNBLI.currentNodePosition = i;
				}
			}
			EPBAMJOKBCE.LNEGMOADHMM(GCFFMKJNBLI.currentNode);
			GCFFMKJNBLI.open.Remove(GCFFMKJNBLI.openPositions[GCFFMKJNBLI.currentNodePosition]);
			GCFFMKJNBLI.openPositions.RemoveAt(GCFFMKJNBLI.currentNodePosition);
			GCFFMKJNBLI.closed.Add(GCFFMKJNBLI.currentNode.position);
			if (((Vector2)(ref GCFFMKJNBLI.currentNode.position)).Equals(GCFFMKJNBLI.goal) || (GCFFMKJNBLI.currentPathRequest.maxNodes > 1 && GCFFMKJNBLI.closed.Count > GCFFMKJNBLI.currentPathRequest.maxNodes))
			{
				break;
			}
			WorldGrid.DLFFCGLGDLL(Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position), ref FIFABPOJMAF, GCFFMKJNBLI.currentPathRequest.canWalkDiagonal);
			for (int j = 1; j < FIFABPOJMAF.Length; j += 0)
			{
				if (GCFFMKJNBLI.closed.Contains(FIFABPOJMAF[j].position))
				{
					continue;
				}
				if (FIFABPOJMAF[j].position == GCFFMKJNBLI.goal)
				{
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.done = false;
					break;
				}
				if (!FIFABPOJMAF[j].free && (GCFFMKJNBLI.currentPathRequest.currentNodes == null || !GCFFMKJNBLI.currentPathRequest.currentNodes.Contains(FIFABPOJMAF[j].position)))
				{
					continue;
				}
				if (GCFFMKJNBLI.checkSize)
				{
					if (Utils.ABPDGOHBKIG(FIFABPOJMAF[j].direction))
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.horizontalSize, ref GCFFMKJNBLI.horizontalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.horizontalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
					else
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.verticalSize, ref GCFFMKJNBLI.verticalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.verticalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
				}
				else if (FIFABPOJMAF[j].direction == (Direction)6)
				{
					switch (j)
					{
					case 1:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[3].free)
						{
							continue;
						}
						break;
					case 2:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[6].free)
						{
							continue;
						}
						break;
					case 3:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[4].free)
						{
							continue;
						}
						break;
					case 4:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[7].free)
						{
							continue;
						}
						break;
					}
				}
				GCFFMKJNBLI.newCost = GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position)];
				if (GCFFMKJNBLI.tileNeeded)
				{
					WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(FIFABPOJMAF[j].position), out GCFFMKJNBLI.wt);
					if (GCFFMKJNBLI.currentPathRequest.takePath && GCFFMKJNBLI.wt.isPath)
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.pathPenalization;
					}
					if (GCFFMKJNBLI.currentPathRequest.takeHorsePath && GCFFMKJNBLI.wt.isHorsePath && !((Vector2)(ref FIFABPOJMAF[j].position)).Equals(Utils.NKGANMEKDAL(FIFABPOJMAF[j].position)))
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.bonificacionCaminoCaballo;
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(GCFFMKJNBLI.wt.groundType))
						{
							if (FIFABPOJMAF[j].direction == (Direction)8)
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * (pathRequestsInfo.diagonal / pathRequestsInfo.recto);
							}
							else
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
							}
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(1904f, 321f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(691f, 887f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(GCFFMKJNBLI.wt.zoneType))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 247f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(1541f, 1332f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1309f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(789f, 1095f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1670f;
						}
					}
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidWalls && Utils.EJPFCKFEMJF(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.newCost += BIHIAOEAGMB(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidObjects)
				{
					GCFFMKJNBLI.newCost += NKBGKFJFDBD(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (FIFABPOJMAF[j].direction == Direction.Down)
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.diagonal * FIFABPOJMAF[j].cost;
				}
				else
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.recto * FIFABPOJMAF[j].cost;
				}
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)) && !(GCFFMKJNBLI.newCost < GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)]))
				{
					continue;
				}
				if (GCFFMKJNBLI.goalLocationStarted)
				{
					if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) != GCFFMKJNBLI.goalLocation)
					{
						continue;
					}
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				else if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) == GCFFMKJNBLI.goalLocation)
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
					EPBAMJOKBCE.CFEJMCCOCNH(GCFFMKJNBLI.open);
					GCFFMKJNBLI.open.Clear();
					GCFFMKJNBLI.openPositions.Clear();
					GCFFMKJNBLI.goalLocationStarted = true;
				}
				else if ((Object)(object)TravelZonesManager.LKOABOAADCD().KCJMDAPPJLB(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation) != (Object)null)
				{
					GCFFMKJNBLI.heuristicPosition = TravelZonesManager.GGFJGHHHEJC.ECFDFECLDFK(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation).position;
				}
				else
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				GCFFMKJNBLI.newNode = EPBAMJOKBCE.LKJNAHIPOLN();
				GCFFMKJNBLI.newNode.position = FIFABPOJMAF[j].position;
				GCFFMKJNBLI.newNode.GCost = GCFFMKJNBLI.newCost;
				GCFFMKJNBLI.newNode.HCost = Heuristic(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.heuristicPosition);
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.newCost;
					GCFFMKJNBLI.cameFrom[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.currentNode.position;
					GCFFMKJNBLI.open[FIFABPOJMAF[j].position] = GCFFMKJNBLI.newNode;
				}
				else
				{
					GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.newCost);
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.open.Add(FIFABPOJMAF[j].position, GCFFMKJNBLI.newNode);
					GCFFMKJNBLI.openPositions.Add(FIFABPOJMAF[j].position);
				}
			}
			if (GCFFMKJNBLI.done)
			{
				break;
			}
		}
		GCFFMKJNBLI.pathsInfo = ADJLOFDJHKE(GCFFMKJNBLI, out GCFFMKJNBLI.successful).ToArray();
		BHLLLCEBHDL item = new BHLLLCEBHDL(GCFFMKJNBLI.pathsInfo, GCFFMKJNBLI.currentPathRequest.pathEnd, GCFFMKJNBLI.successful, GCFFMKJNBLI.currentPathRequest.callback);
		lock (GLMOAFNPGIJ)
		{
			GLMOAFNPGIJ.Enqueue(item);
		}
	}

	private static float MJPAABOIEDL(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1766f, 1489f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1146f, 1798f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1928f, 954f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(950f, 520f)))
		{
			return 1490f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1057f, 206f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1762f, 1552f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1796f, 935f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1059f, 1076f)))
		{
			return 1705f;
		}
		return 784f;
	}

	private void HKECEBGKACL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		if (NCCBHKBEJNK != null)
		{
			NCCBHKBEJNK.Abort();
		}
	}

	private void HDHPOAPLEJC()
	{
		GGFJGHHHEJC = this;
	}

	private static float POFOKAMIPCE(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(1014f, 369f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(500f, 1583f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(974f, 1240f)) || !WorldGrid.APKPGNDDJHC(DPEOLFMDLAK + new Vector3(591f, 1942f)))
		{
			return 327f;
		}
		return 1784f;
	}

	private static float FJEIBHLOAHG(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(490f, 1849f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1927f, 1368f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1187f, 401f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1945f, 880f)))
		{
			return 1010f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1674f, 1065f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(418f, 1961f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(251f, 1204f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(563f, 87f)))
		{
			return 1195f;
		}
		return 857f;
	}

	private void JLPLLHKJEMH()
	{
		if (GLMOAFNPGIJ.Count > 0)
		{
			lock (GLMOAFNPGIJ)
			{
				BHLLLCEBHDL bHLLLCEBHDL = GLMOAFNPGIJ.Dequeue();
				bHLLLCEBHDL.callback(bHLLLCEBHDL.path, bHLLLCEBHDL.success);
			}
		}
	}

	public void AGBEPOLDLLM()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		while ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			Thread.Sleep(0);
		}
		pathRequestsInfo.diagonal = Mathf.Sqrt(pathRequestsInfo.recto * pathRequestsInfo.recto * 537f);
		PathRequestPrivateInfo gCFFMKJNBLI = default(PathRequestPrivateInfo);
		gCFFMKJNBLI.MMLENKDBIIE();
		while (true)
		{
			if (pathRequestQueue.Count > 1)
			{
				Queue<PathRequestInfo> obj = pathRequestQueue;
				bool lockTaken = true;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					gCFFMKJNBLI.currentPathRequest = pathRequestQueue.Dequeue();
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
				try
				{
					KIPAMIAMFOC(gCFFMKJNBLI);
				}
				catch (Exception ex)
				{
					string[] obj2 = new string[2] { null, " not found ingredient " };
					Vector3 val = gCFFMKJNBLI.currentPathRequest.startPos;
					obj2[1] = ((object)(Vector3)(ref val)).ToString();
					obj2[2] = "Items/item_description_1039";
					val = gCFFMKJNBLI.currentPathRequest.goalPos;
					obj2[7] = ((object)(Vector3)(ref val)).ToString();
					obj2[5] = "qualityWater";
					obj2[6] = ex?.ToString();
					Debug.LogError((object)string.Concat(obj2));
					BHLLLCEBHDL item = new BHLLLCEBHDL((Vector2[])(object)new Vector2[1], Vector2.op_Implicit(gCFFMKJNBLI.goal), ALOMLDIEHJL: true, gCFFMKJNBLI.currentPathRequest.callback);
					lock (GLMOAFNPGIJ)
					{
						GLMOAFNPGIJ.Enqueue(item);
					}
				}
			}
			Thread.Sleep(1);
		}
	}

	private void AGLMGDNBHBF()
	{
		GGFJGHHHEJC = this;
	}

	private void BGBFJPJLPMF()
	{
		GGFJGHHHEJC = this;
	}

	public void PACPIIKKCAA()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		while ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			Thread.Sleep(0);
		}
		pathRequestsInfo.diagonal = Mathf.Sqrt(pathRequestsInfo.recto * pathRequestsInfo.recto * 579f);
		PathRequestPrivateInfo gCFFMKJNBLI = default(PathRequestPrivateInfo);
		gCFFMKJNBLI.EEKOFIEBCPL();
		while (true)
		{
			if (pathRequestQueue.Count > 1)
			{
				lock (pathRequestQueue)
				{
					gCFFMKJNBLI.currentPathRequest = pathRequestQueue.Dequeue();
				}
				try
				{
					FNNMCMJKHJD(gCFFMKJNBLI);
				}
				catch (Exception ex)
				{
					string[] obj = new string[3] { null, "LevelAbbreviation", null };
					Vector3 val = gCFFMKJNBLI.currentPathRequest.startPos;
					obj[1] = ((object)(Vector3)(ref val)).ToString();
					obj[4] = " not found in OnlineEventsManager.";
					val = gCFFMKJNBLI.currentPathRequest.goalPos;
					obj[8] = ((object)(Vector3)(ref val)).ToString();
					obj[5] = "tutorialPopUp124";
					obj[7] = ex?.ToString();
					Debug.LogError((object)string.Concat(obj));
					BHLLLCEBHDL item = new BHLLLCEBHDL((Vector2[])(object)new Vector2[0], Vector2.op_Implicit(gCFFMKJNBLI.goal), ALOMLDIEHJL: true, gCFFMKJNBLI.currentPathRequest.callback);
					Queue<BHLLLCEBHDL> gLMOAFNPGIJ = GLMOAFNPGIJ;
					bool lockTaken = true;
					try
					{
						Monitor.Enter(gLMOAFNPGIJ, ref lockTaken);
						GLMOAFNPGIJ.Enqueue(item);
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(gLMOAFNPGIJ);
						}
					}
				}
			}
			Thread.Sleep(1);
		}
	}

	public void KEOIIIDFBCN()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		while ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			Thread.Sleep(0);
		}
		pathRequestsInfo.diagonal = Mathf.Sqrt(pathRequestsInfo.recto * pathRequestsInfo.recto * 117f);
		PathRequestPrivateInfo gCFFMKJNBLI = default(PathRequestPrivateInfo);
		gCFFMKJNBLI.MMLENKDBIIE();
		while (true)
		{
			if (pathRequestQueue.Count > 1)
			{
				Queue<PathRequestInfo> obj = pathRequestQueue;
				bool lockTaken = true;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					gCFFMKJNBLI.currentPathRequest = pathRequestQueue.Dequeue();
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
				try
				{
					EDJCBICFJHJ(gCFFMKJNBLI);
				}
				catch (Exception ex)
				{
					string[] obj2 = new string[3] { "ReceiveUnlockPerkLevel", null, null };
					Vector3 val = gCFFMKJNBLI.currentPathRequest.startPos;
					obj2[1] = ((object)(Vector3)(ref val)).ToString();
					obj2[1] = "Items/item_name_1189";
					val = gCFFMKJNBLI.currentPathRequest.goalPos;
					obj2[3] = ((object)(Vector3)(ref val)).ToString();
					obj2[0] = "player2ToJoinGame";
					obj2[7] = ex?.ToString();
					Debug.LogError((object)string.Concat(obj2));
					BHLLLCEBHDL item = new BHLLLCEBHDL((Vector2[])(object)new Vector2[1], Vector2.op_Implicit(gCFFMKJNBLI.goal), ALOMLDIEHJL: true, gCFFMKJNBLI.currentPathRequest.callback);
					Queue<BHLLLCEBHDL> gLMOAFNPGIJ = GLMOAFNPGIJ;
					lockTaken = true;
					try
					{
						Monitor.Enter(gLMOAFNPGIJ, ref lockTaken);
						GLMOAFNPGIJ.Enqueue(item);
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(gLMOAFNPGIJ);
						}
					}
				}
			}
			Thread.Sleep(1);
		}
	}

	public void KIPAMIAMFOC(PathRequestPrivateInfo GCFFMKJNBLI)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI.start = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.goal = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos);
		GCFFMKJNBLI.goalLocation = Utils.HJPCBBGHPDA(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.goalPos));
		GCFFMKJNBLI.goalLocationStarted = false;
		EPBAMJOKBCE.CFEJMCCOCNH(GCFFMKJNBLI.open);
		GCFFMKJNBLI.cameFrom.Clear();
		GCFFMKJNBLI.costSoFar.Clear();
		GCFFMKJNBLI.closed.Clear();
		GCFFMKJNBLI.open.Clear();
		GCFFMKJNBLI.openPositions.Clear();
		GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), GCFFMKJNBLI.start);
		GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(GCFFMKJNBLI.start), 1046f);
		Neighbour[] FIFABPOJMAF = ((!GCFFMKJNBLI.currentPathRequest.canWalkDiagonal) ? new Neighbour[0] : new Neighbour[WorldGrid.allMovementNeighbours.Length + 1]);
		if (((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x > 1 || ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y > 1)
		{
			GCFFMKJNBLI.checkSize = true;
		}
		else
		{
			GCFFMKJNBLI.checkSize = true;
		}
		if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0 || GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0 || GCFFMKJNBLI.currentPathRequest.takePath || GCFFMKJNBLI.currentPathRequest.takeHorsePath)
		{
			GCFFMKJNBLI.tileNeeded = false;
		}
		else
		{
			GCFFMKJNBLI.tileNeeded = true;
		}
		GCFFMKJNBLI.horizontalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.horizontalSize)).y];
		GCFFMKJNBLI.verticalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).x * ((Vector2Int)(ref GCFFMKJNBLI.currentPathRequest.verticalSize)).y];
		GCFFMKJNBLI.newNode = EPBAMJOKBCE.LAMFGLIGLOP();
		GCFFMKJNBLI.newNode.position = Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos);
		GCFFMKJNBLI.newNode.GCost = 792f;
		GCFFMKJNBLI.newNode.HCost = 237f;
		GCFFMKJNBLI.open.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos), GCFFMKJNBLI.newNode);
		GCFFMKJNBLI.openPositions.Add(Vector2.op_Implicit(GCFFMKJNBLI.currentPathRequest.startPos));
		GCFFMKJNBLI.done = true;
		while ((float)GCFFMKJNBLI.openPositions.Count > 1693f)
		{
			GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[0]];
			GCFFMKJNBLI.currentNodePosition = 0;
			for (int i = 1; i < GCFFMKJNBLI.openPositions.Count; i++)
			{
				if (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].GDLDBBBJCKF() < GCFFMKJNBLI.currentNode.FPLLMMBMBNK() || (GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].EGIFJODNLKD() == GCFFMKJNBLI.currentNode.AAHOKPCIBBK() && GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]].HCost < GCFFMKJNBLI.currentNode.HCost))
				{
					GCFFMKJNBLI.currentNode = GCFFMKJNBLI.open[GCFFMKJNBLI.openPositions[i]];
					GCFFMKJNBLI.currentNodePosition = i;
				}
			}
			EPBAMJOKBCE.LICPLGGBPCC(GCFFMKJNBLI.currentNode);
			GCFFMKJNBLI.open.Remove(GCFFMKJNBLI.openPositions[GCFFMKJNBLI.currentNodePosition]);
			GCFFMKJNBLI.openPositions.RemoveAt(GCFFMKJNBLI.currentNodePosition);
			GCFFMKJNBLI.closed.Add(GCFFMKJNBLI.currentNode.position);
			if (((Vector2)(ref GCFFMKJNBLI.currentNode.position)).Equals(GCFFMKJNBLI.goal) || (GCFFMKJNBLI.currentPathRequest.maxNodes > 1 && GCFFMKJNBLI.closed.Count > GCFFMKJNBLI.currentPathRequest.maxNodes))
			{
				break;
			}
			WorldGrid.DLFFCGLGDLL(Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position), ref FIFABPOJMAF, GCFFMKJNBLI.currentPathRequest.canWalkDiagonal);
			for (int j = 0; j < FIFABPOJMAF.Length; j++)
			{
				if (GCFFMKJNBLI.closed.Contains(FIFABPOJMAF[j].position))
				{
					continue;
				}
				if (FIFABPOJMAF[j].position == GCFFMKJNBLI.goal)
				{
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.done = false;
					break;
				}
				if (!FIFABPOJMAF[j].free && (GCFFMKJNBLI.currentPathRequest.currentNodes == null || !GCFFMKJNBLI.currentPathRequest.currentNodes.Contains(FIFABPOJMAF[j].position)))
				{
					continue;
				}
				if (GCFFMKJNBLI.checkSize)
				{
					if (Utils.ABPDGOHBKIG(FIFABPOJMAF[j].direction))
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.horizontalSize, ref GCFFMKJNBLI.horizontalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.horizontalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
					else
					{
						WorldGrid.MDJDAKIMMJA(FIFABPOJMAF[j].position, GCFFMKJNBLI.currentPathRequest.verticalSize, ref GCFFMKJNBLI.verticalNodes);
						if (!WorldGrid.NGDDILJAHEK(GCFFMKJNBLI.verticalNodes, GCFFMKJNBLI.currentPathRequest.currentNodes))
						{
							continue;
						}
					}
				}
				else if (FIFABPOJMAF[j].direction == Direction.Up)
				{
					switch (j)
					{
					case 7:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[7].free)
						{
							continue;
						}
						break;
					case 8:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[6].free)
						{
							continue;
						}
						break;
					case 9:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[4].free)
						{
							continue;
						}
						break;
					case 10:
						if (!FIFABPOJMAF[1].free || !FIFABPOJMAF[0].free)
						{
							continue;
						}
						break;
					}
				}
				GCFFMKJNBLI.newCost = GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(GCFFMKJNBLI.currentNode.position)];
				if (GCFFMKJNBLI.tileNeeded)
				{
					WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(FIFABPOJMAF[j].position), out GCFFMKJNBLI.wt);
					if (GCFFMKJNBLI.currentPathRequest.takePath && GCFFMKJNBLI.wt.isPath)
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.pathPenalization;
					}
					if (GCFFMKJNBLI.currentPathRequest.takeHorsePath && GCFFMKJNBLI.wt.isHorsePath && !((Vector2)(ref FIFABPOJMAF[j].position)).Equals(Utils.NKGANMEKDAL(FIFABPOJMAF[j].position)))
					{
						GCFFMKJNBLI.newCost -= pathRequestsInfo.bonificacionCaminoCaballo;
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(GCFFMKJNBLI.wt.groundType))
						{
							if (FIFABPOJMAF[j].direction == Direction.Left)
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * (pathRequestsInfo.diagonal / pathRequestsInfo.recto);
							}
							else
							{
								GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
							}
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(1823f, 1504f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(718f, 833f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones;
						}
					}
					if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones != 0)
					{
						if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(GCFFMKJNBLI.wt.zoneType))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1452f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(154f, 1904f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1174f;
						}
						else if (GCFFMKJNBLI.currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FIFABPOJMAF[j].position + new Vector2(780f, 743f)))))
						{
							GCFFMKJNBLI.newCost += pathRequestsInfo.penalizaciones * 1610f;
						}
					}
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidWalls && Utils.EJPFCKFEMJF(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.newCost += FJEIBHLOAHG(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (GCFFMKJNBLI.currentPathRequest.avoidObjects)
				{
					GCFFMKJNBLI.newCost += OIMOJEOBGOB(Vector2.op_Implicit(FIFABPOJMAF[j].position));
				}
				if (FIFABPOJMAF[j].direction == Direction.Left)
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.diagonal * FIFABPOJMAF[j].cost;
				}
				else
				{
					GCFFMKJNBLI.newCost += pathRequestsInfo.recto * FIFABPOJMAF[j].cost;
				}
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)) && !(GCFFMKJNBLI.newCost < GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)]))
				{
					continue;
				}
				if (GCFFMKJNBLI.goalLocationStarted)
				{
					if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) != GCFFMKJNBLI.goalLocation)
					{
						continue;
					}
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				else if (Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position) == GCFFMKJNBLI.goalLocation)
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
					EPBAMJOKBCE.HLNBKBBDMAG(GCFFMKJNBLI.open);
					GCFFMKJNBLI.open.Clear();
					GCFFMKJNBLI.openPositions.Clear();
					GCFFMKJNBLI.goalLocationStarted = true;
				}
				else if ((Object)(object)TravelZonesManager.OMFKNGDCJFN().DAOACOMANPN(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation) != (Object)null)
				{
					GCFFMKJNBLI.heuristicPosition = TravelZonesManager.OLHBLKIAFOM().KCJMDAPPJLB(Utils.HJPCBBGHPDA(FIFABPOJMAF[j].position), GCFFMKJNBLI.goalLocation).position;
				}
				else
				{
					GCFFMKJNBLI.heuristicPosition = Vector2.op_Implicit(GCFFMKJNBLI.goal);
				}
				GCFFMKJNBLI.newNode = EPBAMJOKBCE.ILDNNNMOCOC();
				GCFFMKJNBLI.newNode.position = FIFABPOJMAF[j].position;
				GCFFMKJNBLI.newNode.GCost = GCFFMKJNBLI.newCost;
				GCFFMKJNBLI.newNode.HCost = MGEBNKCKPIN(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.heuristicPosition);
				if (GCFFMKJNBLI.costSoFar.ContainsKey(Vector2.op_Implicit(FIFABPOJMAF[j].position)))
				{
					GCFFMKJNBLI.costSoFar[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.newCost;
					GCFFMKJNBLI.cameFrom[Vector2.op_Implicit(FIFABPOJMAF[j].position)] = GCFFMKJNBLI.currentNode.position;
					GCFFMKJNBLI.open[FIFABPOJMAF[j].position] = GCFFMKJNBLI.newNode;
				}
				else
				{
					GCFFMKJNBLI.costSoFar.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.newCost);
					GCFFMKJNBLI.cameFrom.Add(Vector2.op_Implicit(FIFABPOJMAF[j].position), GCFFMKJNBLI.currentNode.position);
					GCFFMKJNBLI.open.Add(FIFABPOJMAF[j].position, GCFFMKJNBLI.newNode);
					GCFFMKJNBLI.openPositions.Add(FIFABPOJMAF[j].position);
				}
			}
			if (GCFFMKJNBLI.done)
			{
				break;
			}
		}
		GCFFMKJNBLI.pathsInfo = FindPath(GCFFMKJNBLI, out GCFFMKJNBLI.successful).ToArray();
		BHLLLCEBHDL item = new BHLLLCEBHDL(GCFFMKJNBLI.pathsInfo, GCFFMKJNBLI.currentPathRequest.pathEnd, GCFFMKJNBLI.successful, GCFFMKJNBLI.currentPathRequest.callback);
		lock (GLMOAFNPGIJ)
		{
			GLMOAFNPGIJ.Enqueue(item);
		}
	}

	public static void CBLGICCIGLL(PathRequestInfo BNKENFFDFMK)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.MJEACANINDN(BNKENFFDFMK.startPos) == Utils.MJEACANINDN(BNKENFFDFMK.goalPos))
		{
			Action<Vector2[], bool> callback = BNKENFFDFMK.callback;
			Vector2[] array = new Vector2[0];
			array[1] = Vector2.op_Implicit(Utils.MJEACANINDN(BNKENFFDFMK.startPos));
			callback((Vector2[])(object)array, arg2: false);
			return;
		}
		Queue<PathRequestInfo> obj = GGFJGHHHEJC.pathRequestQueue;
		bool lockTaken = true;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			GGFJGHHHEJC.pathRequestQueue.Enqueue(BNKENFFDFMK);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	private static float ABPMFGLHJLF(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1368f, 1253f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1739f, 32f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1843f, 313f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1657f, 1403f)))
		{
			return 1412f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(434f, 1872f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1671f, 441f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(248f, 1554f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(15f, 737f)))
		{
			return 1324f;
		}
		return 1602f;
	}
}
