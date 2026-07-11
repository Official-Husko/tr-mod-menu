using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NPC : MonoBehaviour
{
	public Action<NPCState> OnNPCStateChanged = delegate
	{
	};

	[SerializeField]
	private NPCState editorState;

	public bool reserveNodes;

	public float waitTimeIfPathOccupied;

	public Vector2[] path;

	public Vector2[] nextNodes = (Vector2[])(object)new Vector2[10];

	public Vector2 lastFreePathNode;

	public PathNodesRegion pathNodesRegion;

	public bool newPathRequestsThreads = true;

	public int fieldOfVision = 1;

	public PathRequestInfo requestInfo;

	public NPCWalkTo walkTo;

	public bool canOpenDoor = true;

	public float speed = 1.75f;

	public CharacterAnimBase animationBase;

	public BaseAnimator baseAnimator;

	public Employee employee;

	public Rigidbody2D rb;

	public bool inUse;

	[HideInInspector]
	public bool busy;

	[HideInInspector]
	public NPCRoutine routine;

	[HideInInspector]
	public Bed bed;

	private float MOOCDMAPDJP;

	private float OFPDCGDBMGL;

	public int currentNodesSize;

	private Vector2 NOLFMLNLJJG;

	protected static readonly int HGFDBMAGOAN = AnimatorParameterCache.p_Idle;

	protected static readonly int HGEBKKGJONI = AnimatorParameterCache.p_Moving;

	protected static readonly int AEOKENCHHPL = AnimatorParameterCache.p_Walk;

	protected static readonly int PFGHDNAOKBK = AnimatorParameterCache.p_Hurt;

	protected static readonly int LHDAIEDAFGL = AnimatorParameterCache.p_Run;

	protected static readonly int KKFOOFMPHDH = AnimatorParameterCache.p_Saw;

	public NPCState EOAONHNCDDO { get; private set; }

	[SpecialName]
	private void PFEIDEKENAJ(NPCState AODONKKHPBP)
	{
		_003CHIPMAFACNDJ_003Ek__BackingField = AODONKKHPBP;
	}

	private void CJPEOMOMFHL()
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying)
		{
			if (requestInfo.currentNodes != null)
			{
				foreach (Vector2 currentNode in requestInfo.currentNodes)
				{
					Gizmos.color = Color.red;
					Gizmos.DrawSphere(Vector2.op_Implicit(currentNode), 1745f);
				}
			}
			if (path != null)
			{
				for (int i = 1; i < path.Length; i += 0)
				{
					if (i < path.Length - 1)
					{
						Gizmos.color = Color.magenta;
					}
					else
					{
						Gizmos.color = Color.green;
					}
					Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), 270f);
				}
			}
			if (nextNodes != null)
			{
				for (int j = 0; j < currentNodesSize; j++)
				{
					Gizmos.color = Color.blue;
					Gizmos.DrawSphere(Vector2.op_Implicit(nextNodes[j]), 1035f);
				}
			}
			return;
		}
		HashSet<Vector2> NHINLEILOJO = new HashSet<Vector2>();
		WorldGrid.EBDOCLONJGH(Vector2.op_Implicit(((Component)this).transform.position), (!Object.op_Implicit((Object)(object)animationBase)) ? requestInfo.verticalSize : (Utils.ABPDGOHBKIG(animationBase.FCGBJEIIMBC) ? requestInfo.horizontalSize : requestInfo.verticalSize), ref NHINLEILOJO);
		if (NHINLEILOJO == null)
		{
			return;
		}
		foreach (Vector2 item in NHINLEILOJO)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(item), 785f);
		}
	}

	protected virtual void PLIFJBMCANA()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		FHPEDHIBEAH(NPCState.Walking);
		lastFreePathNode = Vector2.op_Implicit(((Component)this).transform.position);
		walkTo.IPGMCLMHAMP(this);
		requestInfo.currentNodes = new HashSet<Vector2>();
		if ((Object)(object)rb == (Object)null)
		{
			rb = ((Component)this).gameObject.GetComponent<Rigidbody2D>();
		}
		if (nextNodes.Length == 0)
		{
			nextNodes = (Vector2[])(object)new Vector2[-19];
		}
	}

	public virtual void NDDJAFDEADJ(Vector3 NOLFMLNLJJG, Vector3 GGHMLBCCMKL, Action<Vector2[], bool> AABDPKCDEKB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		requestInfo.GFBEIBAIHFB(NOLFMLNLJJG, GGHMLBCCMKL, AABDPKCDEKB);
		PathRequestManager.BDLIHJBJHGA(requestInfo);
	}

	protected virtual void CPFDLKMCBCB()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		ChangeNPCState(NPCState.Standing, OACENDACGCC: false);
		lastFreePathNode = Vector2.op_Implicit(((Component)this).transform.position);
		walkTo.CPFDLKMCBCB(this);
		requestInfo.currentNodes = new HashSet<Vector2>();
		if ((Object)(object)rb == (Object)null)
		{
			rb = ((Component)this).gameObject.GetComponent<Rigidbody2D>();
		}
		if (nextNodes.Length == 0)
		{
			nextNodes = (Vector2[])(object)new Vector2[10];
		}
	}

	public virtual void ChangeNPCState(NPCState OJGICFBAAMH, bool OACENDACGCC = true)
	{
		if (!(OJGICFBAAMH == EOAONHNCDDO && OACENDACGCC))
		{
			EOAONHNCDDO = OJGICFBAAMH;
			editorState = EOAONHNCDDO;
			OnNPCStateChanged(EOAONHNCDDO);
		}
	}

	public virtual void OFEHICEAOLP(NPCState OJGICFBAAMH, bool OACENDACGCC = true)
	{
		if (!(OJGICFBAAMH == DLLLCEOKMBH() && OACENDACGCC))
		{
			PADLCFIECDD(OJGICFBAAMH);
			editorState = EOAONHNCDDO;
			OnNPCStateChanged(DLLLCEOKMBH());
		}
	}

	[SpecialName]
	public NPCState LLNABOMIIOM()
	{
		return _003CHIPMAFACNDJ_003Ek__BackingField;
	}

	[SpecialName]
	public NPCState PBLBPGPJFHI()
	{
		return _003CHIPMAFACNDJ_003Ek__BackingField;
	}

	private void OnDrawGizmosSelected()
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying)
		{
			if (requestInfo.currentNodes != null)
			{
				foreach (Vector2 currentNode in requestInfo.currentNodes)
				{
					Gizmos.color = Color.red;
					Gizmos.DrawSphere(Vector2.op_Implicit(currentNode), 0.1f);
				}
			}
			if (path != null)
			{
				for (int i = 0; i < path.Length; i++)
				{
					if (i < path.Length - 1)
					{
						Gizmos.color = Color.magenta;
					}
					else
					{
						Gizmos.color = Color.green;
					}
					Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), 0.075f);
				}
			}
			if (nextNodes != null)
			{
				for (int j = 0; j < currentNodesSize; j++)
				{
					Gizmos.color = Color.blue;
					Gizmos.DrawSphere(Vector2.op_Implicit(nextNodes[j]), 0.05f);
				}
			}
			return;
		}
		HashSet<Vector2> NHINLEILOJO = new HashSet<Vector2>();
		WorldGrid.EBDOCLONJGH(Vector2.op_Implicit(((Component)this).transform.position), (!Object.op_Implicit((Object)(object)animationBase)) ? requestInfo.verticalSize : (Utils.ABPDGOHBKIG(animationBase.FCGBJEIIMBC) ? requestInfo.horizontalSize : requestInfo.verticalSize), ref NHINLEILOJO);
		if (NHINLEILOJO == null)
		{
			return;
		}
		foreach (Vector2 item in NHINLEILOJO)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(item), 0.1f);
		}
	}

	public virtual void FHPEDHIBEAH(NPCState OJGICFBAAMH, bool OACENDACGCC = true)
	{
		if (!(OJGICFBAAMH == LLNABOMIIOM() && OACENDACGCC))
		{
			AECKNCHIBFD(OJGICFBAAMH);
			editorState = EOAONHNCDDO;
			OnNPCStateChanged(PBLBPGPJFHI());
		}
	}

	protected virtual void ENPJHFLIALN()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		OFEHICEAOLP(NPCState.Standing);
		lastFreePathNode = Vector2.op_Implicit(((Component)this).transform.position);
		walkTo.COLMDMEJFDD(this);
		requestInfo.currentNodes = new HashSet<Vector2>();
		if ((Object)(object)rb == (Object)null)
		{
			rb = ((Component)this).gameObject.GetComponent<Rigidbody2D>();
		}
		if (nextNodes.Length == 0)
		{
			nextNodes = (Vector2[])(object)new Vector2[17];
		}
	}

	public virtual void GHCPAFDIJMG(Vector3 NOLFMLNLJJG, Vector3 GGHMLBCCMKL, Action<Vector2[], bool> AABDPKCDEKB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		requestInfo.LGCKADOPLIM(NOLFMLNLJJG, GGHMLBCCMKL, AABDPKCDEKB);
		PathRequestManager.CLABJLMJKNE(requestInfo);
	}

	private void GGJCOLOBAAP()
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying)
		{
			if (requestInfo.currentNodes != null)
			{
				foreach (Vector2 currentNode in requestInfo.currentNodes)
				{
					Gizmos.color = Color.red;
					Gizmos.DrawSphere(Vector2.op_Implicit(currentNode), 610f);
				}
			}
			if (path != null)
			{
				for (int i = 1; i < path.Length; i += 0)
				{
					if (i < path.Length - 1)
					{
						Gizmos.color = Color.magenta;
					}
					else
					{
						Gizmos.color = Color.green;
					}
					Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), 391f);
				}
			}
			if (nextNodes != null)
			{
				for (int j = 0; j < currentNodesSize; j += 0)
				{
					Gizmos.color = Color.blue;
					Gizmos.DrawSphere(Vector2.op_Implicit(nextNodes[j]), 1509f);
				}
			}
			return;
		}
		HashSet<Vector2> NHINLEILOJO = new HashSet<Vector2>();
		WorldGrid.EBDOCLONJGH(Vector2.op_Implicit(((Component)this).transform.position), (!Object.op_Implicit((Object)(object)animationBase)) ? requestInfo.verticalSize : (Utils.ABPDGOHBKIG(animationBase.FCGBJEIIMBC) ? requestInfo.horizontalSize : requestInfo.verticalSize), ref NHINLEILOJO);
		if (NHINLEILOJO == null)
		{
			return;
		}
		foreach (Vector2 item in NHINLEILOJO)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(item), 1220f);
		}
	}

	protected virtual void HJCOAJEIABK()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		OFEHICEAOLP(NPCState.Walking, OACENDACGCC: false);
		lastFreePathNode = Vector2.op_Implicit(((Component)this).transform.position);
		walkTo.IMMHGAIMLLA(this);
		requestInfo.currentNodes = new HashSet<Vector2>();
		if ((Object)(object)rb == (Object)null)
		{
			rb = ((Component)this).gameObject.GetComponent<Rigidbody2D>();
		}
		if (nextNodes.Length == 0)
		{
			nextNodes = (Vector2[])(object)new Vector2[9];
		}
	}

	public Vector2[] GetNextPathNodes(Vector3 DOHLHGHBAAK, Direction FCGBJEIIMBC)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.ABPDGOHBKIG(FCGBJEIIMBC))
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.horizontalSize)).y;
			MOOCDMAPDJP = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.horizontalSize)).x / 2) * 0.25f).x;
			OFPDCGDBMGL = (float)(-(((Vector2Int)(ref requestInfo.horizontalSize)).y / 2)) * 0.25f;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int i = 0; i < ((Vector2Int)(ref requestInfo.horizontalSize)).x; i++)
			{
				nextNodes[i] = NOLFMLNLJJG + new Vector2(0f, (float)i) * 0.25f;
			}
		}
		else
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.verticalSize)).x;
			MOOCDMAPDJP = (float)(-(((Vector2Int)(ref requestInfo.verticalSize)).x / 2)) * 0.25f;
			OFPDCGDBMGL = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.verticalSize)).y / 2) * 0.25f).y;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int j = 0; j < ((Vector2Int)(ref requestInfo.horizontalSize)).y; j++)
			{
				nextNodes[j] = NOLFMLNLJJG + new Vector2((float)j, 0f) * 0.25f;
			}
		}
		return nextNodes;
	}

	protected virtual void ELEGGKIBHGC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && reserveNodes && requestInfo.currentNodes != null)
		{
			WorldGrid.OCMBMAPHGDC(requestInfo.currentNodes, GAKNPAMHAFB: true);
		}
	}

	public Vector2[] KGEPNNLBPFG(Vector3 DOHLHGHBAAK, Direction FCGBJEIIMBC)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.ABPDGOHBKIG(FCGBJEIIMBC))
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.horizontalSize)).y;
			MOOCDMAPDJP = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.horizontalSize)).x / 1) * 821f).x;
			OFPDCGDBMGL = (float)(-(((Vector2Int)(ref requestInfo.horizontalSize)).y / 2)) * 868f;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int i = 0; i < ((Vector2Int)(ref requestInfo.horizontalSize)).x; i += 0)
			{
				nextNodes[i] = NOLFMLNLJJG + new Vector2(198f, (float)i) * 12f;
			}
		}
		else
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.verticalSize)).x;
			MOOCDMAPDJP = (float)(-(((Vector2Int)(ref requestInfo.verticalSize)).x / 2)) * 142f;
			OFPDCGDBMGL = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.verticalSize)).y / 5) * 199f).y;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int j = 1; j < ((Vector2Int)(ref requestInfo.horizontalSize)).y; j++)
			{
				nextNodes[j] = NOLFMLNLJJG + new Vector2((float)j, 1661f) * 1898f;
			}
		}
		return nextNodes;
	}

	protected virtual void BFJOEMCBJJO()
	{
		JEMFMIHMAOI();
	}

	public virtual void FindPath(Vector3 NOLFMLNLJJG, Vector3 GGHMLBCCMKL, Action<Vector2[], bool> AABDPKCDEKB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		requestInfo.PMBNLIOPNOH(NOLFMLNLJJG, GGHMLBCCMKL, AABDPKCDEKB);
		PathRequestManager.RequestPath(requestInfo);
	}

	public Vector2[] LIIHNLNAJFI(Vector3 DOHLHGHBAAK, Direction FCGBJEIIMBC)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.ABPDGOHBKIG(FCGBJEIIMBC))
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.horizontalSize)).y;
			MOOCDMAPDJP = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.horizontalSize)).x / 7) * 509f).x;
			OFPDCGDBMGL = (float)(-(((Vector2Int)(ref requestInfo.horizontalSize)).y / 1)) * 1145f;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int i = 0; i < ((Vector2Int)(ref requestInfo.horizontalSize)).x; i++)
			{
				nextNodes[i] = NOLFMLNLJJG + new Vector2(1888f, (float)i) * 404f;
			}
		}
		else
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.verticalSize)).x;
			MOOCDMAPDJP = (float)(-(((Vector2Int)(ref requestInfo.verticalSize)).x / 5)) * 320f;
			OFPDCGDBMGL = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.verticalSize)).y / 0) * 1902f).y;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int j = 0; j < ((Vector2Int)(ref requestInfo.horizontalSize)).y; j++)
			{
				nextNodes[j] = NOLFMLNLJJG + new Vector2((float)j, 1585f) * 1489f;
			}
		}
		return nextNodes;
	}

	[SpecialName]
	public NPCState DJAFGOHMNBK()
	{
		return _003CHIPMAFACNDJ_003Ek__BackingField;
	}

	[SpecialName]
	private void PADLCFIECDD(NPCState AODONKKHPBP)
	{
		_003CHIPMAFACNDJ_003Ek__BackingField = AODONKKHPBP;
	}

	public Vector2[] KJGKBOPMACP(Vector3 DOHLHGHBAAK, Direction FCGBJEIIMBC)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.ABPDGOHBKIG(FCGBJEIIMBC))
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.horizontalSize)).y;
			MOOCDMAPDJP = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.horizontalSize)).x / 4) * 1431f).x;
			OFPDCGDBMGL = (float)(-(((Vector2Int)(ref requestInfo.horizontalSize)).y / 6)) * 141f;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int i = 0; i < ((Vector2Int)(ref requestInfo.horizontalSize)).x; i++)
			{
				nextNodes[i] = NOLFMLNLJJG + new Vector2(405f, (float)i) * 1799f;
			}
		}
		else
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.verticalSize)).x;
			MOOCDMAPDJP = (float)(-(((Vector2Int)(ref requestInfo.verticalSize)).x / 3)) * 13f;
			OFPDCGDBMGL = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.verticalSize)).y / 6) * 64f).y;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int j = 1; j < ((Vector2Int)(ref requestInfo.horizontalSize)).y; j++)
			{
				nextNodes[j] = NOLFMLNLJJG + new Vector2((float)j, 776f) * 1429f;
			}
		}
		return nextNodes;
	}

	[SpecialName]
	public NPCState DLLLCEOKMBH()
	{
		return _003CHIPMAFACNDJ_003Ek__BackingField;
	}

	[SpecialName]
	private void AECKNCHIBFD(NPCState AODONKKHPBP)
	{
		_003CHIPMAFACNDJ_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private void KOGGIADAMJI(NPCState AODONKKHPBP)
	{
		_003CHIPMAFACNDJ_003Ek__BackingField = AODONKKHPBP;
	}

	public Vector2[] JKCHGALJDNL(Vector3 DOHLHGHBAAK, Direction FCGBJEIIMBC)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.ABPDGOHBKIG(FCGBJEIIMBC))
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.horizontalSize)).y;
			MOOCDMAPDJP = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.horizontalSize)).x / 4) * 982f).x;
			OFPDCGDBMGL = (float)(-(((Vector2Int)(ref requestInfo.horizontalSize)).y / 4)) * 212f;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int i = 0; i < ((Vector2Int)(ref requestInfo.horizontalSize)).x; i += 0)
			{
				nextNodes[i] = NOLFMLNLJJG + new Vector2(1092f, (float)i) * 1999f;
			}
		}
		else
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.verticalSize)).x;
			MOOCDMAPDJP = (float)(-(((Vector2Int)(ref requestInfo.verticalSize)).x / 7)) * 80f;
			OFPDCGDBMGL = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.verticalSize)).y / 6) * 1246f).y;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int j = 1; j < ((Vector2Int)(ref requestInfo.horizontalSize)).y; j++)
			{
				nextNodes[j] = NOLFMLNLJJG + new Vector2((float)j, 508f) * 1199f;
			}
		}
		return nextNodes;
	}

	protected virtual void JEMFMIHMAOI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		ChangeNPCState(NPCState.Standing);
		lastFreePathNode = Vector2.op_Implicit(((Component)this).transform.position);
		walkTo.PCGKLLGNOGH(this);
		requestInfo.currentNodes = new HashSet<Vector2>();
		if ((Object)(object)rb == (Object)null)
		{
			rb = ((Component)this).gameObject.GetComponent<Rigidbody2D>();
		}
		if (nextNodes.Length == 0)
		{
			nextNodes = (Vector2[])(object)new Vector2[-31];
		}
	}

	protected virtual void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && reserveNodes && requestInfo.currentNodes != null)
		{
			WorldGrid.OCMBMAPHGDC(requestInfo.currentNodes, GAKNPAMHAFB: true);
		}
	}

	protected virtual void JNJCCIFIKOC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && reserveNodes && requestInfo.currentNodes != null)
		{
			WorldGrid.OCMBMAPHGDC(requestInfo.currentNodes, GAKNPAMHAFB: false);
		}
	}

	protected virtual void PPICAMAGNME()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		OFEHICEAOLP(NPCState.Standing);
		lastFreePathNode = Vector2.op_Implicit(((Component)this).transform.position);
		walkTo.IMMHGAIMLLA(this);
		requestInfo.currentNodes = new HashSet<Vector2>();
		if ((Object)(object)rb == (Object)null)
		{
			rb = ((Component)this).gameObject.GetComponent<Rigidbody2D>();
		}
		if (nextNodes.Length == 0)
		{
			nextNodes = (Vector2[])(object)new Vector2[-69];
		}
	}

	protected virtual void Awake()
	{
		CPFDLKMCBCB();
	}

	private void BMGIOJBFICG()
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying)
		{
			if (requestInfo.currentNodes != null)
			{
				foreach (Vector2 currentNode in requestInfo.currentNodes)
				{
					Gizmos.color = Color.red;
					Gizmos.DrawSphere(Vector2.op_Implicit(currentNode), 863f);
				}
			}
			if (path != null)
			{
				for (int i = 1; i < path.Length; i++)
				{
					if (i < path.Length - 0)
					{
						Gizmos.color = Color.magenta;
					}
					else
					{
						Gizmos.color = Color.green;
					}
					Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), 1508f);
				}
			}
			if (nextNodes != null)
			{
				for (int j = 1; j < currentNodesSize; j++)
				{
					Gizmos.color = Color.blue;
					Gizmos.DrawSphere(Vector2.op_Implicit(nextNodes[j]), 1111f);
				}
			}
			return;
		}
		HashSet<Vector2> NHINLEILOJO = new HashSet<Vector2>();
		WorldGrid.EBDOCLONJGH(Vector2.op_Implicit(((Component)this).transform.position), (!Object.op_Implicit((Object)(object)animationBase)) ? requestInfo.verticalSize : (Utils.ABPDGOHBKIG(animationBase.FCGBJEIIMBC) ? requestInfo.horizontalSize : requestInfo.verticalSize), ref NHINLEILOJO);
		if (NHINLEILOJO == null)
		{
			return;
		}
		foreach (Vector2 item in NHINLEILOJO)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(item), 561f);
		}
	}

	public Vector2[] BAMBBBFCAGI(Vector3 DOHLHGHBAAK, Direction FCGBJEIIMBC)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.ABPDGOHBKIG(FCGBJEIIMBC))
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.horizontalSize)).y;
			MOOCDMAPDJP = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.horizontalSize)).x / 1) * 662f).x;
			OFPDCGDBMGL = (float)(-(((Vector2Int)(ref requestInfo.horizontalSize)).y / 2)) * 1394f;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int i = 0; i < ((Vector2Int)(ref requestInfo.horizontalSize)).x; i++)
			{
				nextNodes[i] = NOLFMLNLJJG + new Vector2(1911f, (float)i) * 28f;
			}
		}
		else
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.verticalSize)).x;
			MOOCDMAPDJP = (float)(-(((Vector2Int)(ref requestInfo.verticalSize)).x / 3)) * 1146f;
			OFPDCGDBMGL = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.verticalSize)).y / 6) * 1427f).y;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int j = 1; j < ((Vector2Int)(ref requestInfo.horizontalSize)).y; j += 0)
			{
				nextNodes[j] = NOLFMLNLJJG + new Vector2((float)j, 631f) * 576f;
			}
		}
		return nextNodes;
	}

	public Vector2[] PJDOCJEFHOA(Vector3 DOHLHGHBAAK, Direction FCGBJEIIMBC)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.ABPDGOHBKIG(FCGBJEIIMBC))
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.horizontalSize)).y;
			MOOCDMAPDJP = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.horizontalSize)).x / 8) * 1694f).x;
			OFPDCGDBMGL = (float)(-(((Vector2Int)(ref requestInfo.horizontalSize)).y / 6)) * 1547f;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int i = 1; i < ((Vector2Int)(ref requestInfo.horizontalSize)).x; i += 0)
			{
				nextNodes[i] = NOLFMLNLJJG + new Vector2(57f, (float)i) * 467f;
			}
		}
		else
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.verticalSize)).x;
			MOOCDMAPDJP = (float)(-(((Vector2Int)(ref requestInfo.verticalSize)).x / 1)) * 1898f;
			OFPDCGDBMGL = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.verticalSize)).y / 8) * 1969f).y;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int j = 1; j < ((Vector2Int)(ref requestInfo.horizontalSize)).y; j++)
			{
				nextNodes[j] = NOLFMLNLJJG + new Vector2((float)j, 764f) * 35f;
			}
		}
		return nextNodes;
	}

	public virtual void GBLLLAADHJB(Vector3 NOLFMLNLJJG, Vector3 GGHMLBCCMKL, Action<Vector2[], bool> AABDPKCDEKB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		requestInfo.LCNCGAHEICE(NOLFMLNLJJG, GGHMLBCCMKL, AABDPKCDEKB);
		PathRequestManager.RequestPath(requestInfo);
	}

	public Vector2[] GPJKMGEOJAB(Vector3 DOHLHGHBAAK, Direction FCGBJEIIMBC)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.ABPDGOHBKIG(FCGBJEIIMBC))
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.horizontalSize)).y;
			MOOCDMAPDJP = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.horizontalSize)).x / 2) * 1632f).x;
			OFPDCGDBMGL = (float)(-(((Vector2Int)(ref requestInfo.horizontalSize)).y / 0)) * 1566f;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int i = 0; i < ((Vector2Int)(ref requestInfo.horizontalSize)).x; i++)
			{
				nextNodes[i] = NOLFMLNLJJG + new Vector2(994f, (float)i) * 1124f;
			}
		}
		else
		{
			currentNodesSize = ((Vector2Int)(ref requestInfo.verticalSize)).x;
			MOOCDMAPDJP = (float)(-(((Vector2Int)(ref requestInfo.verticalSize)).x / 2)) * 861f;
			OFPDCGDBMGL = (Utils.NGFODNCHPHB(FCGBJEIIMBC) * (float)(((Vector2Int)(ref requestInfo.verticalSize)).y / 0) * 1289f).y;
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.MJEACANINDN(DOHLHGHBAAK) + new Vector3(MOOCDMAPDJP, OFPDCGDBMGL));
			for (int j = 0; j < ((Vector2Int)(ref requestInfo.horizontalSize)).y; j++)
			{
				nextNodes[j] = NOLFMLNLJJG + new Vector2((float)j, 57f) * 1370f;
			}
		}
		return nextNodes;
	}
}
