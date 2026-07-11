using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class NPCWalkTo : NPCAction
{
	public Action<TravelZone> OnTravelZoneUsed = delegate
	{
	};

	public Action<int> CurrentTargetChanged = delegate
	{
	};

	public bool isActive;

	public float currentSpeed;

	public float speed = 1.75f;

	public bool run;

	public float runningSpeed;

	public Vector2 startRunningTime = new Vector2(0.5f, 1f);

	public float stopRunningDistance = 2f;

	public float followPlayerDistance;

	private float runTime;

	private Vector2 direction;

	[SerializeField]
	private int _currentTarget;

	private Vector2 currentTargetPos;

	[SerializeField]
	private bool nearestMovementNode = true;

	private bool pathFound;

	public bool findNearPosiblePosition;

	[SerializeField]
	private bool goingToLastPosition;

	[SerializeField]
	private float timer;

	[SerializeField]
	private bool walkPriorityDone;

	[SerializeField]
	private bool nextPosReached;

	private Vector2Int size;

	private static AnimalNPC animalNPC;

	private Door door;

	private JapaneseDoor japaneseDoor;

	private TravelZone travelZone;

	private float openDoorTimer;

	private bool nextNodesFree;

	public int currentTarget
	{
		get
		{
			return _currentTarget;
		}
		set
		{
			if (_currentTarget != value)
			{
				_currentTarget = value;
				if (CurrentTargetChanged != null)
				{
					CurrentTargetChanged(value);
				}
			}
		}
	}

	public Vector2 target { get; private set; }

	private void LKGINJBGJJG(Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.position = IMOBLFMHKOD;
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		}
	}

	private void IIHPNGCNDJO(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (canceled)
		{
			return;
		}
		if (ALOMLDIEHJL)
		{
			if (GDHHIIMLBEL != null && GDHHIIMLBEL.Length == 0 && GDHHIIMLBEL[1].x == 1276f && GDHHIIMLBEL[1].y == 111f)
			{
				if (Application.isEditor)
				{
					NPC nPC = npc;
					string? text = ((nPC != null) ? new Vector3?(((Component)nPC).transform.position) : null).ToString();
					NPC nPC2 = npc;
					Debug.LogError((object)("questNameBoiling" + text + "I have to wait other players" + ((nPC2 != null) ? ((Object)((Component)nPC2).gameObject).name : null)));
				}
				IALPAKDIDKG();
			}
			else
			{
				isActive = false;
				OALJDOMENMG(GDHHIIMLBEL);
			}
		}
		else if ((Object)(object)npc != (Object)null && ((Behaviour)npc).isActiveAndEnabled && findNearPosiblePosition && !WorldGrid.APKPGNDDJHC(((Component)npc).transform.position))
		{
			npc.NDDJAFDEADJ(Vector2.op_Implicit(npc.lastFreePathNode), Vector2.op_Implicit(AMHCONACMOH()), MLDPFNCKDLK);
		}
		else
		{
			CDBLJBAFIIK();
		}
	}

	[SpecialName]
	public int JPPIHNNNAMB()
	{
		return _currentTarget;
	}

	[SpecialName]
	public int NDACCOFCFCP()
	{
		return _currentTarget;
	}

	public void LHKPADJNPFN(int ABAIKKGKDGD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		BMECLNKDEEK(ABAIKKGKDGD);
		currentTargetPos = npc.path[ABAIKKGKDGD];
	}

	public void HJIOLGOOFMH(Vector2[] GDHHIIMLBEL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc == (Object)null)
		{
			return;
		}
		npc.path = GDHHIIMLBEL;
		OHCNMNBDAHE(0);
		if (npc.path == null || npc.path.Length == 0)
		{
			currentTargetPos = Vector2.op_Implicit(((Component)npc).transform.position);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
		}
		else
		{
			currentTargetPos = npc.path[1];
			npc.lastFreePathNode = npc.path[0];
		}
		npc.ChangeNPCState(NPCState.Walking, OACENDACGCC: false);
		pathFound = true;
		if (run)
		{
			if (currentSpeed == runningSpeed)
			{
				runTime = 450f;
			}
			else
			{
				runTime = Time.timeSinceLevelLoad + Random.Range(startRunningTime.x, startRunningTime.y);
			}
		}
		EGDEAFHIKAI();
	}

	private void JHDPNFCFMCI(Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.position = IMOBLFMHKOD;
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		}
	}

	public void MJFDKBGGFMD(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = true;
				CKJACJMOCDC(list.ToArray());
			}
			else
			{
				BDKBIAPEJAA();
			}
		}
	}

	[SpecialName]
	public void GPEHHAOPMFA(int AODONKKHPBP)
	{
		if (_currentTarget != AODONKKHPBP)
		{
			_currentTarget = AODONKKHPBP;
			if (CurrentTargetChanged != null)
			{
				CurrentTargetChanged(AODONKKHPBP);
			}
		}
	}

	private void DKIKOPFCIOK(Vector2 OFIIBHBOPJI, Vector2 NKIAGIMMHIC, float MEEFGBBKIKG, bool NFOHEGJMGHE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = NKIAGIMMHIC - OFIIBHBOPJI;
		val.y *= MEEFGBBKIKG;
		Vector2 val2;
		if (NFOHEGJMGHE)
		{
			float magnitude = ((Vector2)(ref val)).magnitude;
			val2 = ((Vector2)(ref val)).normalized * new Vector2(538f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
			if (((Vector2)(ref val2)).magnitude >= magnitude)
			{
				if (MHOPADBKJLE())
				{
					return;
				}
				int num = FJKPLAADNFO();
				GPEHHAOPMFA(num + 0);
				if (FJKPLAADNFO() < npc.path.Length)
				{
					currentTargetPos = npc.path[AJEIBKJFCAB()];
				}
				else
				{
					currentTargetPos = FAOGGPOMAKH();
				}
				val = currentTargetPos - OFIIBHBOPJI;
			}
		}
		val2 = ((Vector2)(ref val)).normalized * new Vector2(307f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.MovePosition(OFIIBHBOPJI + val2);
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(OFIIBHBOPJI + val2);
		}
		nextPosReached = false;
		if (Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), NKIAGIMMHIC) < 1826f)
		{
			BGEPOAEEPFP(NKIAGIMMHIC);
			nextPosReached = false;
		}
	}

	public void EJPGFOEDPBG(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		BLAENIPBIFJ(NKIAGIMMHIC);
		nearestMovementNode = AHDHLIECIGH;
		complete = true;
		canceled = false;
		pathFound = false;
		findNearPosiblePosition = false;
		goingToLastPosition = true;
		timer = 546f;
		walkPriorityDone = true;
		nextPosReached = false;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(-106) / 474f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(-70) / 498f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.MDDCPOILOOM()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(-60) / 345f;
			}
		}
	}

	private void NDGBKEICMLD(Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.position = IMOBLFMHKOD;
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		}
	}

	public void CGFMBJFGLAG(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		target = NKIAGIMMHIC;
		nearestMovementNode = AHDHLIECIGH;
		complete = true;
		canceled = true;
		pathFound = false;
		findNearPosiblePosition = false;
		goingToLastPosition = false;
		timer = 1009f;
		walkPriorityDone = false;
		nextPosReached = true;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(-112) / 1643f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(-50) / 1020f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.IIJAOOJGNHO()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(-99) / 1535f;
			}
		}
	}

	public void DBHOIIIHIIM(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		INGNLHCEBPG(NKIAGIMMHIC);
		nearestMovementNode = AHDHLIECIGH;
		complete = true;
		canceled = false;
		pathFound = false;
		findNearPosiblePosition = true;
		goingToLastPosition = true;
		timer = 805f;
		walkPriorityDone = true;
		nextPosReached = false;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(111) / 1948f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(-62) / 265f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.IIJAOOJGNHO()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(-121) / 1175f;
			}
		}
	}

	private void BGEPOAEEPFP(Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.position = IMOBLFMHKOD;
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		}
	}

	public Direction KDAPNNCBFBA(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	private void IKEGLAPDPAI(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (canceled)
		{
			return;
		}
		if (ALOMLDIEHJL)
		{
			if (GDHHIIMLBEL != null && GDHHIIMLBEL.Length == 0 && GDHHIIMLBEL[1].x == 1504f && GDHHIIMLBEL[1].y == 1535f)
			{
				if (Application.isEditor)
				{
					NPC nPC = npc;
					string? text = ((nPC != null) ? new Vector3?(((Component)nPC).transform.position) : null).ToString();
					NPC nPC2 = npc;
					Debug.LogError((object)("Letter without ID: " + text + "Precision/DrinkEvent3" + ((nPC2 != null) ? ((Object)((Component)nPC2).gameObject).name : null)));
				}
				BDKBIAPEJAA();
			}
			else
			{
				isActive = true;
				CJDPPIJHHNE(GDHHIIMLBEL);
			}
		}
		else if ((Object)(object)npc != (Object)null && ((Behaviour)npc).isActiveAndEnabled && findNearPosiblePosition && !WorldGrid.APKPGNDDJHC(((Component)npc).transform.position))
		{
			npc.NDDJAFDEADJ(Vector2.op_Implicit(npc.lastFreePathNode), Vector2.op_Implicit(AMHCONACMOH()), CIADGCJMOHG);
		}
		else
		{
			CDBLJBAFIIK();
		}
	}

	private void PNMGDGCENBG(Vector2 OFIIBHBOPJI, Vector2 NKIAGIMMHIC, float MEEFGBBKIKG, bool NFOHEGJMGHE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = NKIAGIMMHIC - OFIIBHBOPJI;
		val.y *= MEEFGBBKIKG;
		Vector2 val2;
		if (NFOHEGJMGHE)
		{
			float magnitude = ((Vector2)(ref val)).magnitude;
			val2 = ((Vector2)(ref val)).normalized * new Vector2(1546f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
			if (((Vector2)(ref val2)).magnitude >= magnitude)
			{
				if (FOPKJNIGHEM())
				{
					return;
				}
				int num = AJEIBKJFCAB();
				GPEHHAOPMFA(num + 1);
				if (currentTarget < npc.path.Length)
				{
					currentTargetPos = npc.path[JCIJLCLMPNC()];
				}
				else
				{
					currentTargetPos = FAOGGPOMAKH();
				}
				val = currentTargetPos - OFIIBHBOPJI;
			}
		}
		val2 = ((Vector2)(ref val)).normalized * new Vector2(1198f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.MovePosition(OFIIBHBOPJI + val2);
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(OFIIBHBOPJI + val2);
		}
		nextPosReached = false;
		if (Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), NKIAGIMMHIC) < 1841f)
		{
			LBPPDKOGPLK(NKIAGIMMHIC);
			nextPosReached = false;
		}
	}

	public Direction HKOMHEEIODJ(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	private void JBFDJKCKCPJ(Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.position = IMOBLFMHKOD;
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		}
	}

	public void KNBOIOOOKBG(Vector2[] GDHHIIMLBEL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc == (Object)null)
		{
			return;
		}
		npc.path = GDHHIIMLBEL;
		BMECLNKDEEK(0);
		if (npc.path == null || npc.path.Length == 0)
		{
			currentTargetPos = Vector2.op_Implicit(((Component)npc).transform.position);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
		}
		else
		{
			currentTargetPos = npc.path[0];
			npc.lastFreePathNode = npc.path[1];
		}
		npc.FHPEDHIBEAH(NPCState.Standing);
		pathFound = true;
		if (run)
		{
			if (currentSpeed == runningSpeed)
			{
				runTime = 1530f;
			}
			else
			{
				runTime = Time.timeSinceLevelLoad + Random.Range(startRunningTime.x, startRunningTime.y);
			}
		}
		EGDEAFHIKAI();
	}

	public Direction CNMPDDHPMCO(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	public void ALIADLGLMOE(Vector2[] GDHHIIMLBEL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc == (Object)null)
		{
			return;
		}
		npc.path = GDHHIIMLBEL;
		FNBJIMFEGJG(0);
		if (npc.path == null || npc.path.Length == 0)
		{
			currentTargetPos = Vector2.op_Implicit(((Component)npc).transform.position);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
		}
		else
		{
			currentTargetPos = npc.path[0];
			npc.lastFreePathNode = npc.path[1];
		}
		npc.ChangeNPCState(NPCState.Walking, OACENDACGCC: false);
		pathFound = false;
		if (run)
		{
			if (currentSpeed == runningSpeed)
			{
				runTime = 1360f;
			}
			else
			{
				runTime = Time.timeSinceLevelLoad + Random.Range(startRunningTime.x, startRunningTime.y);
			}
		}
		EGDEAFHIKAI();
	}

	public Direction KBPNKAOJOCK(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	private void HMIOEJBDDJD(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (canceled)
		{
			return;
		}
		if (ALOMLDIEHJL)
		{
			if (GDHHIIMLBEL != null && GDHHIIMLBEL.Length == 1 && GDHHIIMLBEL[1].x == 1610f && GDHHIIMLBEL[1].y == 1532f)
			{
				if (Application.isEditor)
				{
					NPC nPC = npc;
					string? text = ((nPC != null) ? new Vector3?(((Component)nPC).transform.position) : null).ToString();
					NPC nPC2 = npc;
					Debug.LogError((object)("Error_CloseMenus" + text + "Body" + ((nPC2 != null) ? ((Object)((Component)nPC2).gameObject).name : null)));
				}
				IALPAKDIDKG();
			}
			else
			{
				isActive = false;
				ALIADLGLMOE(GDHHIIMLBEL);
			}
		}
		else if ((Object)(object)npc != (Object)null && ((Behaviour)npc).isActiveAndEnabled && findNearPosiblePosition && !WorldGrid.APKPGNDDJHC(((Component)npc).transform.position))
		{
			npc.NDDJAFDEADJ(Vector2.op_Implicit(npc.lastFreePathNode), Vector2.op_Implicit(DEEFLGJFAOO()), IHJLEEMJAGJ);
		}
		else
		{
			AANGNFFBNNB();
		}
	}

	[SpecialName]
	public Vector2 MHKDBAHAAKH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return target;
	}

	[SpecialName]
	public Vector2 PKEKGJCKNNH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return target;
	}

	private bool JLLODJEDGLE()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (JCIJLCLMPNC() >= npc.path.Length || JCIJLCLMPNC() + 0 >= npc.path.Length)
		{
			return true;
		}
		travelZone = TravelZonesManager.OMFKNGDCJFN().KEOLPEDPKNH(Vector2.op_Implicit(npc.path[MNEGKHFIHJB()]));
		if ((Object)(object)travelZone != (Object)null && Vector2.Distance(npc.path[currentTarget + 0], Vector2.op_Implicit(((Component)npc).transform.position)) > 1146f && Vector2.Distance(npc.path[FJKPLAADNFO()], npc.path[JCIJLCLMPNC() + 1]) > 1734f)
		{
			JCBDGOFPOID(npc.path[currentTarget + 0]);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			GPFEHJKNAJI(MNEGKHFIHJB() + 6);
			if (FJKPLAADNFO() < npc.path.Length)
			{
				currentTargetPos = npc.path[AJEIBKJFCAB()];
			}
			if (OnTravelZoneUsed != null)
			{
				OnTravelZoneUsed(travelZone);
			}
			return false;
		}
		return true;
	}

	[SpecialName]
	public Vector2 KOJIPIOMPEE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return target;
	}

	[SpecialName]
	public int AJEIBKJFCAB()
	{
		return _currentTarget;
	}

	public void JDHMPOJKOLF(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		target = NKIAGIMMHIC;
		nearestMovementNode = AHDHLIECIGH;
		complete = false;
		canceled = true;
		pathFound = false;
		findNearPosiblePosition = false;
		goingToLastPosition = false;
		timer = 981f;
		walkPriorityDone = true;
		nextPosReached = false;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(37) / 1527f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(125) / 1510f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.DCILOFEFFAG()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(-66) / 1888f;
			}
		}
	}

	public void GBKCMOLJKKL(Vector2[] GDHHIIMLBEL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc == (Object)null)
		{
			return;
		}
		npc.path = GDHHIIMLBEL;
		GPFEHJKNAJI(1);
		if (npc.path == null || npc.path.Length == 0)
		{
			currentTargetPos = Vector2.op_Implicit(((Component)npc).transform.position);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
		}
		else
		{
			currentTargetPos = npc.path[1];
			npc.lastFreePathNode = npc.path[1];
		}
		npc.OFEHICEAOLP(NPCState.Walking, OACENDACGCC: false);
		pathFound = true;
		if (run)
		{
			if (currentSpeed == runningSpeed)
			{
				runTime = 122f;
			}
			else
			{
				runTime = Time.timeSinceLevelLoad + Random.Range(startRunningTime.x, startRunningTime.y);
			}
		}
		EGDEAFHIKAI();
	}

	public void CKJACJMOCDC(Vector2[] GDHHIIMLBEL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc == (Object)null)
		{
			return;
		}
		npc.path = GDHHIIMLBEL;
		JPOPMHLLAID(1);
		if (npc.path == null || npc.path.Length == 0)
		{
			currentTargetPos = Vector2.op_Implicit(((Component)npc).transform.position);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
		}
		else
		{
			currentTargetPos = npc.path[0];
			npc.lastFreePathNode = npc.path[0];
		}
		npc.FHPEDHIBEAH(NPCState.Standing);
		pathFound = false;
		if (run)
		{
			if (currentSpeed == runningSpeed)
			{
				runTime = 1123f;
			}
			else
			{
				runTime = Time.timeSinceLevelLoad + Random.Range(startRunningTime.x, startRunningTime.y);
			}
		}
		EGDEAFHIKAI();
	}

	private void PJJMLFEGCEL(Vector2 OFIIBHBOPJI, Vector2 NKIAGIMMHIC, float MEEFGBBKIKG, bool NFOHEGJMGHE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = NKIAGIMMHIC - OFIIBHBOPJI;
		val.y *= MEEFGBBKIKG;
		Vector2 val2;
		if (NFOHEGJMGHE)
		{
			float magnitude = ((Vector2)(ref val)).magnitude;
			val2 = ((Vector2)(ref val)).normalized * new Vector2(1803f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
			if (((Vector2)(ref val2)).magnitude >= magnitude)
			{
				if (LJCBDLCMLAK())
				{
					return;
				}
				int num = AJEIBKJFCAB();
				OHCNMNBDAHE(num + 1);
				if (NDACCOFCFCP() < npc.path.Length)
				{
					currentTargetPos = npc.path[PDFLPAEIBAB()];
				}
				else
				{
					currentTargetPos = target;
				}
				val = currentTargetPos - OFIIBHBOPJI;
			}
		}
		val2 = ((Vector2)(ref val)).normalized * new Vector2(745f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.MovePosition(OFIIBHBOPJI + val2);
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(OFIIBHBOPJI + val2);
		}
		nextPosReached = true;
		if (Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), NKIAGIMMHIC) < 385f)
		{
			JHDPNFCFMCI(NKIAGIMMHIC);
			nextPosReached = false;
		}
	}

	[SpecialName]
	public int FJKPLAADNFO()
	{
		return _currentTarget;
	}

	public Direction MFAOCJFFEPA(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	private bool IPEBGLOEIJM()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (AJEIBKJFCAB() >= npc.path.Length || currentTarget + 0 >= npc.path.Length)
		{
			return false;
		}
		travelZone = TravelZonesManager.LKOABOAADCD().IBEFLJNMABM(Vector2.op_Implicit(npc.path[FJKPLAADNFO()]));
		if ((Object)(object)travelZone != (Object)null && Vector2.Distance(npc.path[MNEGKHFIHJB() + 0], Vector2.op_Implicit(((Component)npc).transform.position)) > 1718f && Vector2.Distance(npc.path[NDACCOFCFCP()], npc.path[JPPIHNNNAMB() + 1]) > 111f)
		{
			INKJEPINCLI(npc.path[PDFLPAEIBAB() + 1]);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			FNBJIMFEGJG(PDFLPAEIBAB() + 3);
			if (AJEIBKJFCAB() < npc.path.Length)
			{
				currentTargetPos = npc.path[NDACCOFCFCP()];
			}
			if (OnTravelZoneUsed != null)
			{
				OnTravelZoneUsed(travelZone);
			}
			return false;
		}
		return true;
	}

	public void DBMKNHJPAEJ(int ABAIKKGKDGD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		GPEHHAOPMFA(ABAIKKGKDGD);
		currentTargetPos = npc.path[ABAIKKGKDGD];
	}

	public void EELJCLNJDDD(NPC JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		speed = npc.speed;
	}

	public void IPGMCLMHAMP(NPC JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		speed = npc.speed;
	}

	private bool FOPKJNIGHEM()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (PDFLPAEIBAB() >= npc.path.Length || FJKPLAADNFO() + 1 >= npc.path.Length)
		{
			return false;
		}
		travelZone = TravelZonesManager.DGCNCEDIFOF().MMKIELBCIOK(Vector2.op_Implicit(npc.path[AJEIBKJFCAB()]));
		if ((Object)(object)travelZone != (Object)null && Vector2.Distance(npc.path[currentTarget + 0], Vector2.op_Implicit(((Component)npc).transform.position)) > 833f && Vector2.Distance(npc.path[PDFLPAEIBAB()], npc.path[NDACCOFCFCP() + 1]) > 1314f)
		{
			DMINBHEKMLO(npc.path[NDACCOFCFCP() + 0]);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			GPFEHJKNAJI(PDFLPAEIBAB() + 3);
			if (JCIJLCLMPNC() < npc.path.Length)
			{
				currentTargetPos = npc.path[AJEIBKJFCAB()];
			}
			if (OnTravelZoneUsed != null)
			{
				OnTravelZoneUsed(travelZone);
			}
			return false;
		}
		return true;
	}

	public void GBDLMLNPAPM(NPC JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		speed = npc.speed;
	}

	[SpecialName]
	public int MNEGKHFIHJB()
	{
		return _currentTarget;
	}

	public void OALJDOMENMG(Vector2[] GDHHIIMLBEL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc == (Object)null)
		{
			return;
		}
		npc.path = GDHHIIMLBEL;
		JPOPMHLLAID(0);
		if (npc.path == null || npc.path.Length == 0)
		{
			currentTargetPos = Vector2.op_Implicit(((Component)npc).transform.position);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
		}
		else
		{
			currentTargetPos = npc.path[0];
			npc.lastFreePathNode = npc.path[1];
		}
		npc.FHPEDHIBEAH(NPCState.Standing);
		pathFound = true;
		if (run)
		{
			if (currentSpeed == runningSpeed)
			{
				runTime = 61f;
			}
			else
			{
				runTime = Time.timeSinceLevelLoad + Random.Range(startRunningTime.x, startRunningTime.y);
			}
		}
		EGDEAFHIKAI();
	}

	public override void PEHELKCIECB()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)npc == (Object)null) && ((Behaviour)npc).isActiveAndEnabled)
		{
			npc.FindPath(((Component)npc).transform.position, Vector2.op_Implicit(target), FDDJKPPNLKG);
		}
	}

	public Direction IGAHJCHLFGL(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	[SpecialName]
	public Vector2 FAOGGPOMAKH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return target;
	}

	public void DLFDIFMAMNC(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = false;
				CKJACJMOCDC(list.ToArray());
			}
			else
			{
				BDKBIAPEJAA();
			}
		}
	}

	[SpecialName]
	public Vector2 GCBEHEALINL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return target;
	}

	public Direction GIPOACILBBM(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	private void FPBPEKOHLIN(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (canceled)
		{
			return;
		}
		if (ALOMLDIEHJL)
		{
			if (GDHHIIMLBEL != null && GDHHIIMLBEL.Length == 0 && GDHHIIMLBEL[0].x == 548f && GDHHIIMLBEL[0].y == 1989f)
			{
				if (Application.isEditor)
				{
					NPC nPC = npc;
					string? text = ((nPC != null) ? new Vector3?(((Component)nPC).transform.position) : null).ToString();
					NPC nPC2 = npc;
					Debug.LogError((object)("Interact" + text + "Seedy" + ((nPC2 != null) ? ((Object)((Component)nPC2).gameObject).name : null)));
				}
				AANGNFFBNNB();
			}
			else
			{
				isActive = true;
				NDBJOGGIKCG(GDHHIIMLBEL);
			}
		}
		else if ((Object)(object)npc != (Object)null && ((Behaviour)npc).isActiveAndEnabled && findNearPosiblePosition && !WorldGrid.APKPGNDDJHC(((Component)npc).transform.position))
		{
			npc.NDDJAFDEADJ(Vector2.op_Implicit(npc.lastFreePathNode), Vector2.op_Implicit(PKEKGJCKNNH()), DCPLINBLIGC);
		}
		else
		{
			CDBLJBAFIIK();
		}
	}

	public void PCGKLLGNOGH(NPC JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		speed = npc.speed;
	}

	public void OGLJDLEGJAA(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		MIADAFEMOHJ(NKIAGIMMHIC);
		nearestMovementNode = AHDHLIECIGH;
		complete = false;
		canceled = true;
		pathFound = false;
		findNearPosiblePosition = false;
		goingToLastPosition = true;
		timer = 726f;
		walkPriorityDone = false;
		nextPosReached = false;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(-58) / 1564f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(113) / 504f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.MDDCPOILOOM()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(41) / 1950f;
			}
		}
	}

	private bool BOHGMOIGBLI()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (JCIJLCLMPNC() >= npc.path.Length || currentTarget + 1 >= npc.path.Length)
		{
			return false;
		}
		travelZone = TravelZonesManager.LKOABOAADCD().HMEFEFKKPOA(Vector2.op_Implicit(npc.path[FJKPLAADNFO()]));
		if ((Object)(object)travelZone != (Object)null && Vector2.Distance(npc.path[FJKPLAADNFO() + 0], Vector2.op_Implicit(((Component)npc).transform.position)) > 907f && Vector2.Distance(npc.path[MNEGKHFIHJB()], npc.path[FJKPLAADNFO() + 1]) > 1318f)
		{
			NDGBKEICMLD(npc.path[AJEIBKJFCAB() + 1]);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			GPFEHJKNAJI(currentTarget + 5);
			if (AJEIBKJFCAB() < npc.path.Length)
			{
				currentTargetPos = npc.path[currentTarget];
			}
			if (OnTravelZoneUsed != null)
			{
				OnTravelZoneUsed(travelZone);
			}
			return false;
		}
		return false;
	}

	[SpecialName]
	public void GPFEHJKNAJI(int AODONKKHPBP)
	{
		if (_currentTarget != AODONKKHPBP)
		{
			_currentTarget = AODONKKHPBP;
			if (CurrentTargetChanged != null)
			{
				CurrentTargetChanged(AODONKKHPBP);
			}
		}
	}

	public void FGBKFONGINI(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = true;
				HJIOLGOOFMH(list.ToArray());
			}
			else
			{
				BDKBIAPEJAA();
			}
		}
	}

	public void CPFDLKMCBCB(NPC JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		speed = npc.speed;
	}

	[SpecialName]
	private void INGNLHCEBPG(Vector2 AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		target = AODONKKHPBP;
	}

	public void CIEOJOCJFCK(int ABAIKKGKDGD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		currentTarget = ABAIKKGKDGD;
		currentTargetPos = npc.path[ABAIKKGKDGD];
	}

	private bool MHOPADBKJLE()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (PDFLPAEIBAB() >= npc.path.Length || JCIJLCLMPNC() + 1 >= npc.path.Length)
		{
			return true;
		}
		travelZone = TravelZonesManager.CFHEJAGKIII().DIAFEOKAOPL(Vector2.op_Implicit(npc.path[JPPIHNNNAMB()]));
		if ((Object)(object)travelZone != (Object)null && Vector2.Distance(npc.path[MNEGKHFIHJB() + 1], Vector2.op_Implicit(((Component)npc).transform.position)) > 1213f && Vector2.Distance(npc.path[currentTarget], npc.path[MNEGKHFIHJB() + 1]) > 1719f)
		{
			NDGBKEICMLD(npc.path[FJKPLAADNFO() + 0]);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			BMECLNKDEEK(JPPIHNNNAMB() + 7);
			if (MNEGKHFIHJB() < npc.path.Length)
			{
				currentTargetPos = npc.path[NDACCOFCFCP()];
			}
			if (OnTravelZoneUsed != null)
			{
				OnTravelZoneUsed(travelZone);
			}
			return true;
		}
		return false;
	}

	public void FOHHKGJFJAE(NPC JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		speed = npc.speed;
	}

	[SpecialName]
	public Vector2 DEEFLGJFAOO()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return target;
	}

	public void CIADGCJMOHG(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = true;
				NDBJOGGIKCG(list.ToArray());
			}
			else
			{
				CDBLJBAFIIK();
			}
		}
	}

	public void PHGDCCOIKOD(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = false;
				CDHICEDNNKF(list.ToArray());
			}
			else
			{
				CDBLJBAFIIK();
			}
		}
	}

	public void IIFDJMLGIGG(int ABAIKKGKDGD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		JPOPMHLLAID(ABAIKKGKDGD);
		currentTargetPos = npc.path[ABAIKKGKDGD];
	}

	public void GLHBJNDMIDC(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		BLAENIPBIFJ(NKIAGIMMHIC);
		nearestMovementNode = AHDHLIECIGH;
		complete = true;
		canceled = false;
		pathFound = false;
		findNearPosiblePosition = true;
		goingToLastPosition = false;
		timer = 1204f;
		walkPriorityDone = false;
		nextPosReached = false;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(-71) / 1185f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(9) / 1864f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.DCILOFEFFAG()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(31) / 1092f;
			}
		}
	}

	private void NGLNOOIHOEH(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (canceled)
		{
			return;
		}
		if (ALOMLDIEHJL)
		{
			if (GDHHIIMLBEL != null && GDHHIIMLBEL.Length == 0 && GDHHIIMLBEL[1].x == 401f && GDHHIIMLBEL[1].y == 1146f)
			{
				if (Application.isEditor)
				{
					NPC nPC = npc;
					string? text = ((nPC != null) ? new Vector3?(((Component)nPC).transform.position) : null).ToString();
					NPC nPC2 = npc;
					Debug.LogError((object)("End" + text + "Achievement " + ((nPC2 != null) ? ((Object)((Component)nPC2).gameObject).name : null)));
				}
				AANGNFFBNNB();
			}
			else
			{
				isActive = false;
				HJIOLGOOFMH(GDHHIIMLBEL);
			}
		}
		else if ((Object)(object)npc != (Object)null && ((Behaviour)npc).isActiveAndEnabled && findNearPosiblePosition && !WorldGrid.APKPGNDDJHC(((Component)npc).transform.position))
		{
			npc.FindPath(Vector2.op_Implicit(npc.lastFreePathNode), Vector2.op_Implicit(KOJIPIOMPEE()), DLFDIFMAMNC);
		}
		else
		{
			AANGNFFBNNB();
		}
	}

	private void DMINBHEKMLO(Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.position = IMOBLFMHKOD;
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		}
	}

	[SpecialName]
	public Vector2 MOGNMPIOEIH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return target;
	}

	public void CJDPPIJHHNE(Vector2[] GDHHIIMLBEL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc == (Object)null)
		{
			return;
		}
		npc.path = GDHHIIMLBEL;
		GPEHHAOPMFA(0);
		if (npc.path == null || npc.path.Length == 0)
		{
			currentTargetPos = Vector2.op_Implicit(((Component)npc).transform.position);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
		}
		else
		{
			currentTargetPos = npc.path[0];
			npc.lastFreePathNode = npc.path[0];
		}
		npc.FHPEDHIBEAH(NPCState.Walking);
		pathFound = false;
		if (run)
		{
			if (currentSpeed == runningSpeed)
			{
				runTime = 520f;
			}
			else
			{
				runTime = Time.timeSinceLevelLoad + Random.Range(startRunningTime.x, startRunningTime.y);
			}
		}
		EGDEAFHIKAI();
	}

	public void IHJLEEMJAGJ(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = false;
				KNBOIOOOKBG(list.ToArray());
			}
			else
			{
				BDKBIAPEJAA();
			}
		}
	}

	private bool ABDAKLCGGNH()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (FJKPLAADNFO() >= npc.path.Length || JCIJLCLMPNC() + 0 >= npc.path.Length)
		{
			return false;
		}
		travelZone = TravelZonesManager.GGFJGHHHEJC.OPKANNKFJJI(Vector2.op_Implicit(npc.path[FJKPLAADNFO()]));
		if ((Object)(object)travelZone != (Object)null && Vector2.Distance(npc.path[JPPIHNNNAMB() + 1], Vector2.op_Implicit(((Component)npc).transform.position)) > 1029f && Vector2.Distance(npc.path[JPPIHNNNAMB()], npc.path[MNEGKHFIHJB() + 0]) > 1533f)
		{
			DFCLBCGDFMP(npc.path[NDACCOFCFCP() + 0]);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			GPFEHJKNAJI(AJEIBKJFCAB() + 4);
			if (PDFLPAEIBAB() < npc.path.Length)
			{
				currentTargetPos = npc.path[AJEIBKJFCAB()];
			}
			if (OnTravelZoneUsed != null)
			{
				OnTravelZoneUsed(travelZone);
			}
			return false;
		}
		return true;
	}

	public void COLMDMEJFDD(NPC JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		speed = npc.speed;
	}

	public void MPPMAJMFDAB(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = true;
				OALJDOMENMG(list.ToArray());
			}
			else
			{
				BDKBIAPEJAA();
			}
		}
	}

	public void GDGGABHLNOH(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		target = NKIAGIMMHIC;
		nearestMovementNode = AHDHLIECIGH;
		complete = false;
		canceled = true;
		pathFound = true;
		findNearPosiblePosition = false;
		goingToLastPosition = true;
		timer = 1809f;
		walkPriorityDone = true;
		nextPosReached = true;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(-50) / 779f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(121) / 1865f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.IIJAOOJGNHO()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(-31) / 1970f;
			}
		}
	}

	public void GLNFNPKAABI(int ABAIKKGKDGD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		JPOPMHLLAID(ABAIKKGKDGD);
		currentTargetPos = npc.path[ABAIKKGKDGD];
	}

	[SpecialName]
	public void JPOPMHLLAID(int AODONKKHPBP)
	{
		if (_currentTarget != AODONKKHPBP)
		{
			_currentTarget = AODONKKHPBP;
			if (CurrentTargetChanged != null)
			{
				CurrentTargetChanged(AODONKKHPBP);
			}
		}
	}

	public void IIMCLFALMOA(NPC JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		speed = npc.speed;
	}

	private void LBPPDKOGPLK(Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.position = IMOBLFMHKOD;
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		}
	}

	public void CPKMNEANMPN(int ABAIKKGKDGD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		GPEHHAOPMFA(ABAIKKGKDGD);
		currentTargetPos = npc.path[ABAIKKGKDGD];
	}

	public void GOMKFNJLFGN(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = true;
				CKJACJMOCDC(list.ToArray());
			}
			else
			{
				AANGNFFBNNB();
			}
		}
	}

	public void IOLNMLBOCOL(int ABAIKKGKDGD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		FNBJIMFEGJG(ABAIKKGKDGD);
		currentTargetPos = npc.path[ABAIKKGKDGD];
	}

	private void JBPIBGFBNHN(Vector2 OFIIBHBOPJI, Vector2 NKIAGIMMHIC, float MEEFGBBKIKG, bool NFOHEGJMGHE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = NKIAGIMMHIC - OFIIBHBOPJI;
		val.y *= MEEFGBBKIKG;
		Vector2 val2;
		if (NFOHEGJMGHE)
		{
			float magnitude = ((Vector2)(ref val)).magnitude;
			val2 = ((Vector2)(ref val)).normalized * new Vector2(1402f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
			if (((Vector2)(ref val2)).magnitude >= magnitude)
			{
				if (IPEBGLOEIJM())
				{
					return;
				}
				int num = FJKPLAADNFO();
				BMECLNKDEEK(num + 0);
				if (FJKPLAADNFO() < npc.path.Length)
				{
					currentTargetPos = npc.path[JPPIHNNNAMB()];
				}
				else
				{
					currentTargetPos = KOJIPIOMPEE();
				}
				val = currentTargetPos - OFIIBHBOPJI;
			}
		}
		val2 = ((Vector2)(ref val)).normalized * new Vector2(468f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.MovePosition(OFIIBHBOPJI + val2);
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(OFIIBHBOPJI + val2);
		}
		nextPosReached = true;
		if (Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), NKIAGIMMHIC) < 1241f)
		{
			LBPPDKOGPLK(NKIAGIMMHIC);
			nextPosReached = false;
		}
	}

	private void PKBHGCJEKCB(Vector2 OFIIBHBOPJI, Vector2 NKIAGIMMHIC, float MEEFGBBKIKG, bool NFOHEGJMGHE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = NKIAGIMMHIC - OFIIBHBOPJI;
		val.y *= MEEFGBBKIKG;
		Vector2 val2;
		if (NFOHEGJMGHE)
		{
			float magnitude = ((Vector2)(ref val)).magnitude;
			val2 = ((Vector2)(ref val)).normalized * new Vector2(1764f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
			if (((Vector2)(ref val2)).magnitude >= magnitude)
			{
				if (BOHGMOIGBLI())
				{
					return;
				}
				int num = PDFLPAEIBAB();
				BMECLNKDEEK(num + 1);
				if (FJKPLAADNFO() < npc.path.Length)
				{
					currentTargetPos = npc.path[NDACCOFCFCP()];
				}
				else
				{
					currentTargetPos = MHKDBAHAAKH();
				}
				val = currentTargetPos - OFIIBHBOPJI;
			}
		}
		val2 = ((Vector2)(ref val)).normalized * new Vector2(1132f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.MovePosition(OFIIBHBOPJI + val2);
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(OFIIBHBOPJI + val2);
		}
		nextPosReached = false;
		if (Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), NKIAGIMMHIC) < 276f)
		{
			JHDPNFCFMCI(NKIAGIMMHIC);
			nextPosReached = true;
		}
	}

	public void BEEMOHBNPNA(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = true;
				KNBOIOOOKBG(list.ToArray());
			}
			else
			{
				AANGNFFBNNB();
			}
		}
	}

	public void NDBJOGGIKCG(Vector2[] GDHHIIMLBEL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc == (Object)null)
		{
			return;
		}
		npc.path = GDHHIIMLBEL;
		OHCNMNBDAHE(0);
		if (npc.path == null || npc.path.Length == 0)
		{
			currentTargetPos = Vector2.op_Implicit(((Component)npc).transform.position);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
		}
		else
		{
			currentTargetPos = npc.path[0];
			npc.lastFreePathNode = npc.path[0];
		}
		npc.OFEHICEAOLP(NPCState.Walking);
		pathFound = false;
		if (run)
		{
			if (currentSpeed == runningSpeed)
			{
				runTime = 1176f;
			}
			else
			{
				runTime = Time.timeSinceLevelLoad + Random.Range(startRunningTime.x, startRunningTime.y);
			}
		}
		EGDEAFHIKAI();
	}

	private void PBACPBMHKKI(Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.position = IMOBLFMHKOD;
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		}
	}

	[SpecialName]
	public int JCIJLCLMPNC()
	{
		return _currentTarget;
	}

	public void FNLDJDHNNBE(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = true;
				CJDPPIJHHNE(list.ToArray());
			}
			else
			{
				IALPAKDIDKG();
			}
		}
	}

	public override void JKGGEMBAPAJ()
	{
		base.JKGGEMBAPAJ();
		isActive = false;
	}

	[SpecialName]
	public int PDFLPAEIBAB()
	{
		return _currentTarget;
	}

	private void DFCLBCGDFMP(Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.position = IMOBLFMHKOD;
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		}
	}

	private void INKJEPINCLI(Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.position = IMOBLFMHKOD;
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		}
	}

	public void PENCJIOHGGM(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = false;
				OALJDOMENMG(list.ToArray());
			}
			else
			{
				CDBLJBAFIIK();
			}
		}
	}

	private bool CBDLLOJFPHF()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (NDACCOFCFCP() >= npc.path.Length || MNEGKHFIHJB() + 0 >= npc.path.Length)
		{
			return true;
		}
		travelZone = TravelZonesManager.OACNNJCLEDE().MMKIELBCIOK(Vector2.op_Implicit(npc.path[JCIJLCLMPNC()]));
		if ((Object)(object)travelZone != (Object)null && Vector2.Distance(npc.path[JCIJLCLMPNC() + 1], Vector2.op_Implicit(((Component)npc).transform.position)) > 1009f && Vector2.Distance(npc.path[NDACCOFCFCP()], npc.path[AJEIBKJFCAB() + 1]) > 752f)
		{
			PBACPBMHKKI(npc.path[PDFLPAEIBAB() + 1]);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			BMECLNKDEEK(JCIJLCLMPNC() + 1);
			if (JPPIHNNNAMB() < npc.path.Length)
			{
				currentTargetPos = npc.path[JPPIHNNNAMB()];
			}
			if (OnTravelZoneUsed != null)
			{
				OnTravelZoneUsed(travelZone);
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	public Vector2 AMHCONACMOH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return target;
	}

	[SpecialName]
	public Vector2 GHEHJJONNAA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return target;
	}

	private void JCBDGOFPOID(Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.position = IMOBLFMHKOD;
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		}
	}

	public void DHFPOCOEONG(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		BLAENIPBIFJ(NKIAGIMMHIC);
		nearestMovementNode = AHDHLIECIGH;
		complete = true;
		canceled = true;
		pathFound = false;
		findNearPosiblePosition = true;
		goingToLastPosition = false;
		timer = 341f;
		walkPriorityDone = false;
		nextPosReached = false;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(109) / 1568f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(-94) / 1170f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.DCILOFEFFAG()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(-62) / 1250f;
			}
		}
	}

	public void HELOLJBENMK(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		target = NKIAGIMMHIC;
		nearestMovementNode = AHDHLIECIGH;
		complete = false;
		canceled = false;
		pathFound = true;
		findNearPosiblePosition = true;
		goingToLastPosition = false;
		timer = 951f;
		walkPriorityDone = false;
		nextPosReached = false;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(17) / 707f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(25) / 667f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.GetInstance()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(96) / 647f;
			}
		}
	}

	public void JGINDJDOKFK(int ABAIKKGKDGD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		currentTarget = ABAIKKGKDGD;
		currentTargetPos = npc.path[ABAIKKGKDGD];
	}

	private bool NFJOAEJODAK()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (FJKPLAADNFO() >= npc.path.Length || currentTarget + 1 >= npc.path.Length)
		{
			return true;
		}
		travelZone = TravelZonesManager.BGMJCCFNNDL().KEOLPEDPKNH(Vector2.op_Implicit(npc.path[NDACCOFCFCP()]));
		if ((Object)(object)travelZone != (Object)null && Vector2.Distance(npc.path[NDACCOFCFCP() + 0], Vector2.op_Implicit(((Component)npc).transform.position)) > 147f && Vector2.Distance(npc.path[FJKPLAADNFO()], npc.path[currentTarget + 0]) > 1387f)
		{
			JBFDJKCKCPJ(npc.path[AJEIBKJFCAB() + 1]);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			GPEHHAOPMFA(JCIJLCLMPNC() + 8);
			if (NDACCOFCFCP() < npc.path.Length)
			{
				currentTargetPos = npc.path[FJKPLAADNFO()];
			}
			if (OnTravelZoneUsed != null)
			{
				OnTravelZoneUsed(travelZone);
			}
			return false;
		}
		return false;
	}

	public void DCPLINBLIGC(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = true;
				ALIADLGLMOE(list.ToArray());
			}
			else
			{
				IALPAKDIDKG();
			}
		}
	}

	private void LAMEIDKIGLL(Vector2 OFIIBHBOPJI, Vector2 NKIAGIMMHIC, float MEEFGBBKIKG, bool NFOHEGJMGHE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = NKIAGIMMHIC - OFIIBHBOPJI;
		val.y *= MEEFGBBKIKG;
		Vector2 val2;
		if (NFOHEGJMGHE)
		{
			float magnitude = ((Vector2)(ref val)).magnitude;
			val2 = ((Vector2)(ref val)).normalized * new Vector2(1920f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
			if (((Vector2)(ref val2)).magnitude >= magnitude)
			{
				if (PNGABLIFBJJ())
				{
					return;
				}
				int num = MNEGKHFIHJB();
				currentTarget = num + 0;
				if (currentTarget < npc.path.Length)
				{
					currentTargetPos = npc.path[FJKPLAADNFO()];
				}
				else
				{
					currentTargetPos = PKEKGJCKNNH();
				}
				val = currentTargetPos - OFIIBHBOPJI;
			}
		}
		val2 = ((Vector2)(ref val)).normalized * new Vector2(1620f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.MovePosition(OFIIBHBOPJI + val2);
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(OFIIBHBOPJI + val2);
		}
		nextPosReached = true;
		if (Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), NKIAGIMMHIC) < 1790f)
		{
			BGEPOAEEPFP(NKIAGIMMHIC);
			nextPosReached = true;
		}
	}

	public Direction ILDNJHGFBHI(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	public void LFOMLHLENFG(int ABAIKKGKDGD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		JPOPMHLLAID(ABAIKKGKDGD);
		currentTargetPos = npc.path[ABAIKKGKDGD];
	}

	private bool LJCBDLCMLAK()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (NDACCOFCFCP() >= npc.path.Length || NDACCOFCFCP() + 0 >= npc.path.Length)
		{
			return false;
		}
		travelZone = TravelZonesManager.DGCNCEDIFOF().NDDJDFIPHHD(Vector2.op_Implicit(npc.path[FJKPLAADNFO()]));
		if ((Object)(object)travelZone != (Object)null && Vector2.Distance(npc.path[PDFLPAEIBAB() + 0], Vector2.op_Implicit(((Component)npc).transform.position)) > 156f && Vector2.Distance(npc.path[FJKPLAADNFO()], npc.path[FJKPLAADNFO() + 1]) > 1842f)
		{
			DFCLBCGDFMP(npc.path[JPPIHNNNAMB() + 1]);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			BMECLNKDEEK(MNEGKHFIHJB() + 1);
			if (FJKPLAADNFO() < npc.path.Length)
			{
				currentTargetPos = npc.path[MNEGKHFIHJB()];
			}
			if (OnTravelZoneUsed != null)
			{
				OnTravelZoneUsed(travelZone);
			}
			return true;
		}
		return false;
	}

	public void AOFCCIKIAGJ(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = true;
				GBKCMOLJKKL(list.ToArray());
			}
			else
			{
				CDBLJBAFIIK();
			}
		}
	}

	public void NLHFEJADPPA(int ABAIKKGKDGD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		FNBJIMFEGJG(ABAIKKGKDGD);
		currentTargetPos = npc.path[ABAIKKGKDGD];
	}

	private void GJEGBEGCBIL(Vector2 OFIIBHBOPJI, Vector2 NKIAGIMMHIC, float MEEFGBBKIKG, bool NFOHEGJMGHE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = NKIAGIMMHIC - OFIIBHBOPJI;
		val.y *= MEEFGBBKIKG;
		Vector2 val2;
		if (NFOHEGJMGHE)
		{
			float magnitude = ((Vector2)(ref val)).magnitude;
			val2 = ((Vector2)(ref val)).normalized * new Vector2(349f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
			if (((Vector2)(ref val2)).magnitude >= magnitude)
			{
				if (NDNJABAGHEL())
				{
					return;
				}
				int num = AJEIBKJFCAB();
				FNBJIMFEGJG(num + 1);
				if (AJEIBKJFCAB() < npc.path.Length)
				{
					currentTargetPos = npc.path[JPPIHNNNAMB()];
				}
				else
				{
					currentTargetPos = NAKJMIEODKB();
				}
				val = currentTargetPos - OFIIBHBOPJI;
			}
		}
		val2 = ((Vector2)(ref val)).normalized * new Vector2(1658f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.MovePosition(OFIIBHBOPJI + val2);
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(OFIIBHBOPJI + val2);
		}
		nextPosReached = true;
		if (Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), NKIAGIMMHIC) < 1784f)
		{
			INKJEPINCLI(NKIAGIMMHIC);
			nextPosReached = false;
		}
	}

	private bool DODIODPOBDC()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (NDACCOFCFCP() >= npc.path.Length || JCIJLCLMPNC() + 1 >= npc.path.Length)
		{
			return false;
		}
		travelZone = TravelZonesManager.OLHBLKIAFOM().NDDJDFIPHHD(Vector2.op_Implicit(npc.path[MNEGKHFIHJB()]));
		if ((Object)(object)travelZone != (Object)null && Vector2.Distance(npc.path[PDFLPAEIBAB() + 1], Vector2.op_Implicit(((Component)npc).transform.position)) > 1455f && Vector2.Distance(npc.path[JPPIHNNNAMB()], npc.path[MNEGKHFIHJB() + 0]) > 1420f)
		{
			NDGBKEICMLD(npc.path[AJEIBKJFCAB() + 0]);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			currentTarget = AJEIBKJFCAB() + 7;
			if (MNEGKHFIHJB() < npc.path.Length)
			{
				currentTargetPos = npc.path[JPPIHNNNAMB()];
			}
			if (OnTravelZoneUsed != null)
			{
				OnTravelZoneUsed(travelZone);
			}
			return true;
		}
		return false;
	}

	public void JJDCANFBFMK(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		AFJCEMPDHID(NKIAGIMMHIC);
		nearestMovementNode = AHDHLIECIGH;
		complete = false;
		canceled = false;
		pathFound = true;
		findNearPosiblePosition = true;
		goingToLastPosition = true;
		timer = 1222f;
		walkPriorityDone = true;
		nextPosReached = false;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(34) / 1569f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(33) / 370f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.FFOMKKIAHKI()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(29) / 439f;
			}
		}
	}

	[SpecialName]
	public void FNBJIMFEGJG(int AODONKKHPBP)
	{
		if (_currentTarget != AODONKKHPBP)
		{
			_currentTarget = AODONKKHPBP;
			if (CurrentTargetChanged != null)
			{
				CurrentTargetChanged(AODONKKHPBP);
			}
		}
	}

	[SpecialName]
	private void AFJCEMPDHID(Vector2 AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		target = AODONKKHPBP;
	}

	public Direction CPGNPFHKKLJ(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	public Direction BEOFIIIHLBM(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	[SpecialName]
	public void BMECLNKDEEK(int AODONKKHPBP)
	{
		if (_currentTarget != AODONKKHPBP)
		{
			_currentTarget = AODONKKHPBP;
			if (CurrentTargetChanged != null)
			{
				CurrentTargetChanged(AODONKKHPBP);
			}
		}
	}

	private void HDGBBLJFALO(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (canceled)
		{
			return;
		}
		if (ALOMLDIEHJL)
		{
			if (GDHHIIMLBEL != null && GDHHIIMLBEL.Length == 0 && GDHHIIMLBEL[1].x == 1489f && GDHHIIMLBEL[0].y == 1102f)
			{
				if (Application.isEditor)
				{
					NPC nPC = npc;
					string? text = ((nPC != null) ? new Vector3?(((Component)nPC).transform.position) : null).ToString();
					NPC nPC2 = npc;
					Debug.LogError((object)("intensity:" + text + "ReceiveObjectInteract" + ((nPC2 != null) ? ((Object)((Component)nPC2).gameObject).name : null)));
				}
				CDBLJBAFIIK();
			}
			else
			{
				isActive = false;
				JKOPNGHNPKF(GDHHIIMLBEL);
			}
		}
		else if ((Object)(object)npc != (Object)null && ((Behaviour)npc).isActiveAndEnabled && findNearPosiblePosition && !WorldGrid.APKPGNDDJHC(((Component)npc).transform.position))
		{
			npc.NDDJAFDEADJ(Vector2.op_Implicit(npc.lastFreePathNode), Vector2.op_Implicit(MOGNMPIOEIH()), BEEMOHBNPNA);
		}
		else
		{
			IALPAKDIDKG();
		}
	}

	[SpecialName]
	private void BLAENIPBIFJ(Vector2 AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		target = AODONKKHPBP;
	}

	private void FDDJKPPNLKG(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (canceled)
		{
			return;
		}
		if (ALOMLDIEHJL)
		{
			if (GDHHIIMLBEL != null && GDHHIIMLBEL.Length == 1 && GDHHIIMLBEL[0].x == 0f && GDHHIIMLBEL[0].y == 0f)
			{
				if (Application.isEditor)
				{
					NPC nPC = npc;
					string? text = ((nPC != null) ? new Vector3?(((Component)nPC).transform.position) : null).ToString();
					NPC nPC2 = npc;
					Debug.LogError((object)("Path node error. Only 1 node at [0, 0] " + text + " " + ((nPC2 != null) ? ((Object)((Component)nPC2).gameObject).name : null)));
				}
				IALPAKDIDKG();
			}
			else
			{
				isActive = true;
				JKOPNGHNPKF(GDHHIIMLBEL);
			}
		}
		else if ((Object)(object)npc != (Object)null && ((Behaviour)npc).isActiveAndEnabled && findNearPosiblePosition && !WorldGrid.APKPGNDDJHC(((Component)npc).transform.position))
		{
			npc.FindPath(Vector2.op_Implicit(npc.lastFreePathNode), Vector2.op_Implicit(target), MLDPFNCKDLK);
		}
		else
		{
			IALPAKDIDKG();
		}
	}

	public void BDIKOLNFKGD(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		target = NKIAGIMMHIC;
		nearestMovementNode = AHDHLIECIGH;
		complete = true;
		canceled = true;
		pathFound = true;
		findNearPosiblePosition = false;
		goingToLastPosition = false;
		timer = 383f;
		walkPriorityDone = false;
		nextPosReached = false;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(-114) / 1256f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(-33) / 1460f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.MDDCPOILOOM()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(-64) / 1304f;
			}
		}
	}

	public void IMMHGAIMLLA(NPC JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		speed = npc.speed;
	}

	private void IAJOPDFBJOK(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (canceled)
		{
			return;
		}
		if (ALOMLDIEHJL)
		{
			if (GDHHIIMLBEL != null && GDHHIIMLBEL.Length == 1 && GDHHIIMLBEL[1].x == 992f && GDHHIIMLBEL[0].y == 126f)
			{
				if (Application.isEditor)
				{
					NPC nPC = npc;
					string? text = ((nPC != null) ? new Vector3?(((Component)nPC).transform.position) : null).ToString();
					NPC nPC2 = npc;
					Debug.LogError((object)("ReceiveDialogueInfo" + text + "dForDays" + ((nPC2 != null) ? ((Object)((Component)nPC2).gameObject).name : null)));
				}
				IALPAKDIDKG();
			}
			else
			{
				isActive = true;
				NDBJOGGIKCG(GDHHIIMLBEL);
			}
		}
		else if ((Object)(object)npc != (Object)null && ((Behaviour)npc).isActiveAndEnabled && findNearPosiblePosition && !WorldGrid.APKPGNDDJHC(((Component)npc).transform.position))
		{
			npc.GBLLLAADHJB(Vector2.op_Implicit(npc.lastFreePathNode), Vector2.op_Implicit(DEEFLGJFAOO()), MLDPFNCKDLK);
		}
		else
		{
			IALPAKDIDKG();
		}
	}

	private bool PIHBIAAGJCK()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (JCIJLCLMPNC() >= npc.path.Length || JPPIHNNNAMB() + 0 >= npc.path.Length)
		{
			return true;
		}
		travelZone = TravelZonesManager.GFMBEDCANNI().CPLBJKJDLPA(Vector2.op_Implicit(npc.path[MNEGKHFIHJB()]));
		if ((Object)(object)travelZone != (Object)null && Vector2.Distance(npc.path[NDACCOFCFCP() + 1], Vector2.op_Implicit(((Component)npc).transform.position)) > 1214f && Vector2.Distance(npc.path[PDFLPAEIBAB()], npc.path[JCIJLCLMPNC() + 0]) > 37f)
		{
			LKGINJBGJJG(npc.path[FJKPLAADNFO() + 0]);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			GPEHHAOPMFA(NDACCOFCFCP() + 3);
			if (FJKPLAADNFO() < npc.path.Length)
			{
				currentTargetPos = npc.path[PDFLPAEIBAB()];
			}
			if (OnTravelZoneUsed != null)
			{
				OnTravelZoneUsed(travelZone);
			}
			return true;
		}
		return false;
	}

	public Direction NKDJMDNBNPG(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	public void MLDPFNCKDLK(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!canceled)
		{
			if (ALOMLDIEHJL)
			{
				List<Vector2> list = new List<Vector2> { npc.lastFreePathNode };
				list.AddRange(GDHHIIMLBEL);
				isActive = true;
				JKOPNGHNPKF(list.ToArray());
			}
			else
			{
				IALPAKDIDKG();
			}
		}
	}

	[SpecialName]
	private void MIADAFEMOHJ(Vector2 AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		target = AODONKKHPBP;
	}

	public override bool IIMEFNIECLI(bool OEBNHGNJEJL = false)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc == (Object)null)
		{
			return false;
		}
		if (!isActive)
		{
			return false;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"NPCWalkTo PerformAction");
		}
		if (complete)
		{
			return true;
		}
		if (!pathFound)
		{
			return false;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)("NPCWalkTo Path length: " + npc.path.Length));
		}
		if ((Object)(object)npc.baseAnimator != (Object)null && npc.baseAnimator.blockMovement)
		{
			return false;
		}
		if (currentTarget < npc.path.Length)
		{
			door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(npc.path[currentTarget]));
			japaneseDoor = WorldGrid.AHINHLBFBDE(Vector2.op_Implicit(npc.path[currentTarget]));
		}
		else
		{
			door = null;
		}
		if ((Object)(object)door != (Object)null)
		{
			if (!door.ECMGCJGPKNO)
			{
				if (npc.canOpenDoor)
				{
					if (door is RentedRoomDoor rentedRoomDoor && rentedRoomDoor.rentedRoom.occupied && rentedRoomDoor.HGPPJMCLOKH && rentedRoomDoor.rentedRoom.readyToLeave)
					{
						rentedRoomDoor.rentedRoom.VacateRoom();
					}
					else
					{
						door.OpenCloseAction(DBCDEKIEHMG: true);
						if (Object.op_Implicit((Object)(object)npc.animationBase))
						{
							npc.animationBase.ForceDirection(Utils.EIDFHLPBICI(new Vector2(0f, ((Component)door).transform.position.y - ((Component)npc).transform.position.y)));
						}
					}
					openDoorTimer = 0f;
					return false;
				}
				openDoorTimer += Time.fixedDeltaTime;
				if (openDoorTimer > 10f)
				{
					openDoorTimer = 0f;
					IALPAKDIDKG();
				}
				return false;
			}
			openDoorTimer = 0f;
		}
		if ((Object)(object)japaneseDoor != (Object)null)
		{
			if (japaneseDoor.open)
			{
				openDoorTimer = 0f;
			}
			else if (npc.canOpenDoor)
			{
				japaneseDoor.Open(CDPAMNIPPEC: true);
				if (Object.op_Implicit((Object)(object)npc.animationBase))
				{
					npc.animationBase.ForceDirection(Utils.EIDFHLPBICI(new Vector2(0f, ((Component)door).transform.position.y - ((Component)npc).transform.position.y)));
				}
				openDoorTimer = 0f;
				return false;
			}
		}
		if (!run)
		{
			currentSpeed = speed;
			if (Object.op_Implicit((Object)(object)npc) && Object.op_Implicit((Object)(object)npc.animationBase))
			{
				npc.animationBase.IGONGEODOFP = false;
			}
		}
		else if (Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), target) < stopRunningDistance)
		{
			if (currentSpeed != speed)
			{
				currentSpeed = speed;
				if (Object.op_Implicit((Object)(object)npc) && Object.op_Implicit((Object)(object)npc.animationBase))
				{
					npc.animationBase.IGONGEODOFP = false;
				}
			}
		}
		else if (Time.timeSinceLevelLoad > runTime)
		{
			if (currentSpeed != runningSpeed)
			{
				currentSpeed = runningSpeed;
				if (Object.op_Implicit((Object)(object)npc) && Object.op_Implicit((Object)(object)npc.animationBase))
				{
					npc.animationBase.IGONGEODOFP = true;
				}
			}
		}
		else if (currentSpeed != speed)
		{
			currentSpeed = speed;
			if (Object.op_Implicit((Object)(object)npc) && Object.op_Implicit((Object)(object)npc.animationBase))
			{
				npc.animationBase.IGONGEODOFP = false;
			}
		}
		if (!nearestMovementNode && goingToLastPosition)
		{
			FNPFIFHGGBJ(Vector2.op_Implicit(((Component)npc).transform.position), target, 0.85f, NFOHEGJMGHE: false);
		}
		else if (!nearestMovementNode && Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), target) < Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), currentTargetPos))
		{
			goingToLastPosition = true;
			FNPFIFHGGBJ(Vector2.op_Implicit(((Component)npc).transform.position), target, 0.85f, NFOHEGJMGHE: false);
		}
		else
		{
			Vector3 position;
			if (OEBNHGNJEJL)
			{
				position = ((Component)npc).transform.position;
				Debug.Log((object)("before pos " + ((object)(Vector3)(ref position)).ToString()));
			}
			FNPFIFHGGBJ(Vector2.op_Implicit(((Component)npc).transform.position), currentTargetPos, 0.85f, NFOHEGJMGHE: true);
			if (OEBNHGNJEJL)
			{
				string[] obj = new string[10] { "next pos ", null, null, null, null, null, null, null, null, null };
				position = ((Component)npc).transform.position;
				obj[1] = ((object)(Vector3)(ref position)).ToString();
				obj[2] = " ";
				Vector2 val = currentTargetPos;
				obj[3] = ((object)(Vector2)(ref val)).ToString();
				obj[4] = " ";
				obj[5] = currentSpeed.ToString();
				obj[6] = " ";
				obj[7] = Time.fixedDeltaTime.ToString();
				obj[8] = " ";
				obj[9] = (currentSpeed * Time.fixedDeltaTime).ToString();
				Debug.Log((object)string.Concat(obj));
			}
			if (nextPosReached)
			{
				if (OEBNHGNJEJL)
				{
					Debug.Log((object)"next pos reached");
				}
				if (currentTarget < npc.path.Length - 1 && currentTarget >= 0)
				{
					if (!PNGABLIFBJJ())
					{
						npc.lastFreePathNode = npc.path[currentTarget];
						npc.nextNodes = npc.GetNextPathNodes(Vector2.op_Implicit(npc.path[currentTarget + 1]), Utils.EIDFHLPBICI(npc.path[currentTarget + 1] - npc.path[currentTarget]));
						nextNodesFree = WorldGrid.NGDDILJAHEK(npc.nextNodes, npc.currentNodesSize, npc.requestInfo.currentNodes);
						if (nextNodesFree && npc.fieldOfVision > 1)
						{
							for (int i = 2; i <= npc.fieldOfVision && currentTarget + i + 1 < npc.path.Length; i++)
							{
								travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZoneAtPosition(Vector2.op_Implicit(npc.path[currentTarget + i]));
								if (Object.op_Implicit((Object)(object)travelZone))
								{
									break;
								}
								npc.nextNodes = npc.GetNextPathNodes(Vector2.op_Implicit(npc.path[currentTarget + i]), Utils.EIDFHLPBICI(npc.path[currentTarget + i] - npc.path[currentTarget + i - 1]));
								if (!WorldGrid.NGDDILJAHEK(npc.nextNodes, npc.currentNodesSize, npc.requestInfo.currentNodes))
								{
									nextNodesFree = false;
								}
							}
						}
						if (nextNodesFree)
						{
							if (OEBNHGNJEJL)
							{
								Debug.Log((object)"nextNodes free");
							}
							timer = 0f;
							walkPriorityDone = false;
							currentTarget++;
							currentTargetPos = npc.path[currentTarget];
							if (npc.reserveNodes)
							{
								WorldGrid.OCMBMAPHGDC(npc.requestInfo.currentNodes, GAKNPAMHAFB: true);
								size = (Utils.ABPDGOHBKIG(Utils.EIDFHLPBICI(npc.path[currentTarget] - npc.path[currentTarget - 1])) ? npc.requestInfo.horizontalSize : npc.requestInfo.verticalSize);
								WorldGrid.EBDOCLONJGH(npc.path[currentTarget], size, ref npc.requestInfo.currentNodes);
								WorldGrid.OCMBMAPHGDC(npc.requestInfo.currentNodes, GAKNPAMHAFB: false, npc as AnimalNPC);
							}
						}
						else
						{
							if (OEBNHGNJEJL)
							{
								Debug.Log((object)"nextNodes NOT free");
							}
							if (nearestMovementNode || currentTarget + 1 < npc.path.Length - 1)
							{
								if (OEBNHGNJEJL)
								{
									Debug.Log((object)("nextNodes NOT free. timer: " + timer + "//" + npc.waitTimeIfPathOccupied));
								}
								if (timer >= npc.waitTimeIfPathOccupied)
								{
									timer = 0f;
									walkPriorityDone = false;
									JKGGEMBAPAJ();
									IALPAKDIDKG();
									if (OEBNHGNJEJL)
									{
										Debug.Log((object)"nodes not free 1");
									}
									return false;
								}
								timer += Time.fixedDeltaTime;
								if (!walkPriorityDone)
								{
									animalNPC = WorldGrid.AGIJJFBMIIA(npc.nextNodes, npc.currentNodesSize, npc.requestInfo.currentNodes);
									if (Object.op_Implicit((Object)(object)animalNPC) && !animalNPC.walkTo.walkPriorityDone)
									{
										animalNPC.WalkAround();
										walkPriorityDone = true;
									}
								}
								if (OEBNHGNJEJL)
								{
									Debug.Log((object)"nodes not free 2");
								}
								return false;
							}
							currentTarget++;
						}
					}
				}
				else
				{
					currentTarget++;
				}
			}
		}
		if (nearestMovementNode)
		{
			if (currentTarget >= npc.path.Length)
			{
				npc.ChangeNPCState(NPCState.Standing);
				npc.lastFreePathNode = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)npc).transform.position));
				EGIBBBDHEGC();
				return true;
			}
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"not target 1");
			}
			return false;
		}
		if (currentTarget >= npc.path.Length)
		{
			goingToLastPosition = true;
		}
		if (Vector2.op_Implicit(((Component)npc).transform.position) == target)
		{
			npc.ChangeNPCState(NPCState.Standing);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			EGIBBBDHEGC();
			return true;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"not target 2");
		}
		return false;
	}

	public void FNNPPBDFBCI(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		target = NKIAGIMMHIC;
		nearestMovementNode = AHDHLIECIGH;
		complete = false;
		canceled = false;
		pathFound = false;
		findNearPosiblePosition = false;
		goingToLastPosition = false;
		timer = 0f;
		walkPriorityDone = false;
		nextPosReached = false;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(24) / 100f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(64) / 100f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.GetInstance()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(35) / 100f;
			}
		}
	}

	private void OIIMLFNLCAL(Vector2 OFIIBHBOPJI, Vector2 NKIAGIMMHIC, float MEEFGBBKIKG, bool NFOHEGJMGHE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = NKIAGIMMHIC - OFIIBHBOPJI;
		val.y *= MEEFGBBKIKG;
		Vector2 val2;
		if (NFOHEGJMGHE)
		{
			float magnitude = ((Vector2)(ref val)).magnitude;
			val2 = ((Vector2)(ref val)).normalized * new Vector2(1303f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
			if (((Vector2)(ref val2)).magnitude >= magnitude)
			{
				if (NFJOAEJODAK())
				{
					return;
				}
				int num = FJKPLAADNFO();
				JPOPMHLLAID(num + 1);
				if (AJEIBKJFCAB() < npc.path.Length)
				{
					currentTargetPos = npc.path[NDACCOFCFCP()];
				}
				else
				{
					currentTargetPos = MOGNMPIOEIH();
				}
				val = currentTargetPos - OFIIBHBOPJI;
			}
		}
		val2 = ((Vector2)(ref val)).normalized * new Vector2(1419f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.MovePosition(OFIIBHBOPJI + val2);
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(OFIIBHBOPJI + val2);
		}
		nextPosReached = true;
		if (Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), NKIAGIMMHIC) < 1203f)
		{
			LBPPDKOGPLK(NKIAGIMMHIC);
			nextPosReached = false;
		}
	}

	public void CDHICEDNNKF(Vector2[] GDHHIIMLBEL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc == (Object)null)
		{
			return;
		}
		npc.path = GDHHIIMLBEL;
		GPFEHJKNAJI(0);
		if (npc.path == null || npc.path.Length == 0)
		{
			currentTargetPos = Vector2.op_Implicit(((Component)npc).transform.position);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
		}
		else
		{
			currentTargetPos = npc.path[1];
			npc.lastFreePathNode = npc.path[1];
		}
		npc.OFEHICEAOLP(NPCState.Standing, OACENDACGCC: false);
		pathFound = true;
		if (run)
		{
			if (currentSpeed == runningSpeed)
			{
				runTime = 1454f;
			}
			else
			{
				runTime = Time.timeSinceLevelLoad + Random.Range(startRunningTime.x, startRunningTime.y);
			}
		}
		EGDEAFHIKAI();
	}

	[SpecialName]
	public Vector2 NAKJMIEODKB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return target;
	}

	public void JKOPNGHNPKF(Vector2[] GDHHIIMLBEL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc == (Object)null)
		{
			return;
		}
		npc.path = GDHHIIMLBEL;
		currentTarget = 0;
		if (npc.path == null || npc.path.Length == 0)
		{
			currentTargetPos = Vector2.op_Implicit(((Component)npc).transform.position);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
		}
		else
		{
			currentTargetPos = npc.path[0];
			npc.lastFreePathNode = npc.path[0];
		}
		npc.ChangeNPCState(NPCState.Walking);
		pathFound = true;
		if (run)
		{
			if (currentSpeed == runningSpeed)
			{
				runTime = 0f;
			}
			else
			{
				runTime = Time.timeSinceLevelLoad + Random.Range(startRunningTime.x, startRunningTime.y);
			}
		}
		EGDEAFHIKAI();
	}

	public void GINPKMBGOFN(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		MIADAFEMOHJ(NKIAGIMMHIC);
		nearestMovementNode = AHDHLIECIGH;
		complete = true;
		canceled = true;
		pathFound = false;
		findNearPosiblePosition = true;
		goingToLastPosition = true;
		timer = 831f;
		walkPriorityDone = true;
		nextPosReached = true;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(-51) / 1044f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(-43) / 222f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.MDDCPOILOOM()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(14) / 111f;
			}
		}
	}

	public Direction OPFAKBDFEEP(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	public NPCWalkTo(NPC JFLENDJFAOE)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		CPFDLKMCBCB(JFLENDJFAOE);
	}

	public override void EGIBBBDHEGC()
	{
		if (Object.op_Implicit((Object)(object)npc) && Object.op_Implicit((Object)(object)npc.animationBase))
		{
			npc.animationBase.IGONGEODOFP = false;
		}
		base.EGIBBBDHEGC();
	}

	public Direction KIDNOOAGAID(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	private void GLAAAINCNGA(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (canceled)
		{
			return;
		}
		if (ALOMLDIEHJL)
		{
			if (GDHHIIMLBEL != null && GDHHIIMLBEL.Length == 1 && GDHHIIMLBEL[0].x == 205f && GDHHIIMLBEL[0].y == 885f)
			{
				if (Application.isEditor)
				{
					NPC nPC = npc;
					string? text = ((nPC != null) ? new Vector3?(((Component)nPC).transform.position) : null).ToString();
					NPC nPC2 = npc;
					Debug.LogError((object)("Failed to find prefab: " + text + "AceT_Quest" + ((nPC2 != null) ? ((Object)((Component)nPC2).gameObject).name : null)));
				}
				CDBLJBAFIIK();
			}
			else
			{
				isActive = false;
				CDHICEDNNKF(GDHHIIMLBEL);
			}
		}
		else if ((Object)(object)npc != (Object)null && ((Behaviour)npc).isActiveAndEnabled && findNearPosiblePosition && !WorldGrid.APKPGNDDJHC(((Component)npc).transform.position))
		{
			npc.FindPath(Vector2.op_Implicit(npc.lastFreePathNode), Vector2.op_Implicit(PKEKGJCKNNH()), IHJLEEMJAGJ);
		}
		else
		{
			CDBLJBAFIIK();
		}
	}

	private void IFAOBCBFECK(Vector2 OFIIBHBOPJI, Vector2 NKIAGIMMHIC, float MEEFGBBKIKG, bool NFOHEGJMGHE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = NKIAGIMMHIC - OFIIBHBOPJI;
		val.y *= MEEFGBBKIKG;
		Vector2 val2;
		if (NFOHEGJMGHE)
		{
			float magnitude = ((Vector2)(ref val)).magnitude;
			val2 = ((Vector2)(ref val)).normalized * new Vector2(239f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
			if (((Vector2)(ref val2)).magnitude >= magnitude)
			{
				if (CBDLLOJFPHF())
				{
					return;
				}
				int num = currentTarget;
				FNBJIMFEGJG(num + 1);
				if (JCIJLCLMPNC() < npc.path.Length)
				{
					currentTargetPos = npc.path[FJKPLAADNFO()];
				}
				else
				{
					currentTargetPos = MOGNMPIOEIH();
				}
				val = currentTargetPos - OFIIBHBOPJI;
			}
		}
		val2 = ((Vector2)(ref val)).normalized * new Vector2(883f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.MovePosition(OFIIBHBOPJI + val2);
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(OFIIBHBOPJI + val2);
		}
		nextPosReached = true;
		if (Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), NKIAGIMMHIC) < 1192f)
		{
			PBACPBMHKKI(NKIAGIMMHIC);
			nextPosReached = false;
		}
	}

	private void FNPFIFHGGBJ(Vector2 OFIIBHBOPJI, Vector2 NKIAGIMMHIC, float MEEFGBBKIKG, bool NFOHEGJMGHE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = NKIAGIMMHIC - OFIIBHBOPJI;
		val.y *= MEEFGBBKIKG;
		Vector2 val2;
		if (NFOHEGJMGHE)
		{
			float magnitude = ((Vector2)(ref val)).magnitude;
			val2 = ((Vector2)(ref val)).normalized * new Vector2(1f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
			if (((Vector2)(ref val2)).magnitude >= magnitude)
			{
				if (PNGABLIFBJJ())
				{
					return;
				}
				currentTarget++;
				if (currentTarget < npc.path.Length)
				{
					currentTargetPos = npc.path[currentTarget];
				}
				else
				{
					currentTargetPos = target;
				}
				val = currentTargetPos - OFIIBHBOPJI;
			}
		}
		val2 = ((Vector2)(ref val)).normalized * new Vector2(1f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.MovePosition(OFIIBHBOPJI + val2);
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(OFIIBHBOPJI + val2);
		}
		nextPosReached = false;
		if (Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), NKIAGIMMHIC) < 0.05f)
		{
			JBFDJKCKCPJ(NKIAGIMMHIC);
			nextPosReached = true;
		}
	}

	private void GPIHCALELHK(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (canceled)
		{
			return;
		}
		if (ALOMLDIEHJL)
		{
			if (GDHHIIMLBEL != null && GDHHIIMLBEL.Length == 1 && GDHHIIMLBEL[0].x == 289f && GDHHIIMLBEL[0].y == 341f)
			{
				if (Application.isEditor)
				{
					NPC nPC = npc;
					string? text = ((nPC != null) ? new Vector3?(((Component)nPC).transform.position) : null).ToString();
					NPC nPC2 = npc;
					Debug.LogError((object)("customersInTavern" + text + "Activated " + ((nPC2 != null) ? ((Object)((Component)nPC2).gameObject).name : null)));
				}
				BDKBIAPEJAA();
			}
			else
			{
				isActive = true;
				NDBJOGGIKCG(GDHHIIMLBEL);
			}
		}
		else if ((Object)(object)npc != (Object)null && ((Behaviour)npc).isActiveAndEnabled && findNearPosiblePosition && !WorldGrid.APKPGNDDJHC(((Component)npc).transform.position))
		{
			npc.FindPath(Vector2.op_Implicit(npc.lastFreePathNode), Vector2.op_Implicit(target), FNLDJDHNNBE);
		}
		else
		{
			BDKBIAPEJAA();
		}
	}

	public void KBEENHPEOAB(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		MIADAFEMOHJ(NKIAGIMMHIC);
		nearestMovementNode = AHDHLIECIGH;
		complete = true;
		canceled = true;
		pathFound = false;
		findNearPosiblePosition = true;
		goingToLastPosition = false;
		timer = 1898f;
		walkPriorityDone = true;
		nextPosReached = true;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(-21) / 270f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(-63) / 347f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.GetInstance()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(-29) / 400f;
			}
		}
	}

	public Direction BOPHKLOPLJI(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	private void BNIGBFFCPIH(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (canceled)
		{
			return;
		}
		if (ALOMLDIEHJL)
		{
			if (GDHHIIMLBEL != null && GDHHIIMLBEL.Length == 1 && GDHHIIMLBEL[1].x == 603f && GDHHIIMLBEL[0].y == 1307f)
			{
				if (Application.isEditor)
				{
					NPC nPC = npc;
					string? text = ((nPC != null) ? new Vector3?(((Component)nPC).transform.position) : null).ToString();
					NPC nPC2 = npc;
					Debug.LogError((object)("Selected" + text + "Drink" + ((nPC2 != null) ? ((Object)((Component)nPC2).gameObject).name : null)));
				}
				IALPAKDIDKG();
			}
			else
			{
				isActive = true;
				JKOPNGHNPKF(GDHHIIMLBEL);
			}
		}
		else if ((Object)(object)npc != (Object)null && ((Behaviour)npc).isActiveAndEnabled && findNearPosiblePosition && !WorldGrid.APKPGNDDJHC(((Component)npc).transform.position))
		{
			npc.NDDJAFDEADJ(Vector2.op_Implicit(npc.lastFreePathNode), Vector2.op_Implicit(KOJIPIOMPEE()), FNLDJDHNNBE);
		}
		else
		{
			IALPAKDIDKG();
		}
	}

	private bool PNGABLIFBJJ()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (currentTarget >= npc.path.Length || currentTarget + 1 >= npc.path.Length)
		{
			return false;
		}
		travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZoneAtPosition(Vector2.op_Implicit(npc.path[currentTarget]));
		if ((Object)(object)travelZone != (Object)null && Vector2.Distance(npc.path[currentTarget + 1], Vector2.op_Implicit(((Component)npc).transform.position)) > 1f && Vector2.Distance(npc.path[currentTarget], npc.path[currentTarget + 1]) > 30f)
		{
			JBFDJKCKCPJ(npc.path[currentTarget + 1]);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			currentTarget += 2;
			if (currentTarget < npc.path.Length)
			{
				currentTargetPos = npc.path[currentTarget];
			}
			if (OnTravelZoneUsed != null)
			{
				OnTravelZoneUsed(travelZone);
			}
			return true;
		}
		return false;
	}

	private bool NDNJABAGHEL()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (MNEGKHFIHJB() >= npc.path.Length || currentTarget + 0 >= npc.path.Length)
		{
			return false;
		}
		travelZone = TravelZonesManager.GFMBEDCANNI().CPLBJKJDLPA(Vector2.op_Implicit(npc.path[NDACCOFCFCP()]));
		if ((Object)(object)travelZone != (Object)null && Vector2.Distance(npc.path[PDFLPAEIBAB() + 0], Vector2.op_Implicit(((Component)npc).transform.position)) > 1985f && Vector2.Distance(npc.path[NDACCOFCFCP()], npc.path[MNEGKHFIHJB() + 0]) > 1750f)
		{
			PBACPBMHKKI(npc.path[AJEIBKJFCAB() + 0]);
			npc.lastFreePathNode = Vector2.op_Implicit(((Component)npc).transform.position);
			GPEHHAOPMFA(NDACCOFCFCP() + 3);
			if (AJEIBKJFCAB() < npc.path.Length)
			{
				currentTargetPos = npc.path[currentTarget];
			}
			if (OnTravelZoneUsed != null)
			{
				OnTravelZoneUsed(travelZone);
			}
			return true;
		}
		return true;
	}

	private void ECFPJNJOEKA(Vector2 OFIIBHBOPJI, Vector2 NKIAGIMMHIC, float MEEFGBBKIKG, bool NFOHEGJMGHE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = NKIAGIMMHIC - OFIIBHBOPJI;
		val.y *= MEEFGBBKIKG;
		Vector2 val2;
		if (NFOHEGJMGHE)
		{
			float magnitude = ((Vector2)(ref val)).magnitude;
			val2 = ((Vector2)(ref val)).normalized * new Vector2(799f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
			if (((Vector2)(ref val2)).magnitude >= magnitude)
			{
				if (PNGABLIFBJJ())
				{
					return;
				}
				int num = currentTarget;
				BMECLNKDEEK(num + 1);
				if (AJEIBKJFCAB() < npc.path.Length)
				{
					currentTargetPos = npc.path[FJKPLAADNFO()];
				}
				else
				{
					currentTargetPos = GCBEHEALINL();
				}
				val = currentTargetPos - OFIIBHBOPJI;
			}
		}
		val2 = ((Vector2)(ref val)).normalized * new Vector2(1242f, MEEFGBBKIKG) * currentSpeed * Time.fixedDeltaTime;
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.MovePosition(OFIIBHBOPJI + val2);
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(OFIIBHBOPJI + val2);
		}
		nextPosReached = true;
		if (Vector2.Distance(Vector2.op_Implicit(((Component)npc).transform.position), NKIAGIMMHIC) < 400f)
		{
			JHDPNFCFMCI(NKIAGIMMHIC);
			nextPosReached = true;
		}
	}

	public void GHDMBFOAAHK(Vector2 NKIAGIMMHIC, bool AHDHLIECIGH = true, bool NGAKHGJANLO = true)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		MIADAFEMOHJ(NKIAGIMMHIC);
		nearestMovementNode = AHDHLIECIGH;
		complete = false;
		canceled = false;
		pathFound = false;
		findNearPosiblePosition = false;
		goingToLastPosition = false;
		timer = 255f;
		walkPriorityDone = true;
		nextPosReached = true;
		if (NGAKHGJANLO)
		{
			OnSuccessfulStart = null;
			OnActionComplete = null;
			OnFailStart = null;
			OnTravelZoneUsed = null;
		}
		if (!((Object)(object)npc == (Object)null) && !((Object)(object)npc.employee == (Object)null))
		{
			speed = npc.speed;
			speed += npc.speed * (float)npc.employee.GetPerkValue(-60) / 1309f;
			speed -= npc.speed * (float)npc.employee.GetPerkValue(-85) / 175f;
			if (!((Object)(object)npc.employee == (Object)(object)Bouncer.MDDCPOILOOM()))
			{
				speed += npc.speed * (float)npc.employee.GetPerkValue(-12) / 1102f;
			}
		}
	}

	public Direction CDPLJJGGBPF(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	public void NHINIAECHNC(NPC JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		speed = npc.speed;
	}

	public Direction JAJDDINCPAI(Direction LFJKPDEMMLC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!isActive)
		{
			return LFJKPDEMMLC;
		}
		return Utils.LFOGGLLPPBI(currentTargetPos - Vector2.op_Implicit(((Component)npc).transform.position), LFJKPDEMMLC);
	}

	[SpecialName]
	public Vector2 JJJLPOBIBJL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return target;
	}

	[SpecialName]
	public void OHCNMNBDAHE(int AODONKKHPBP)
	{
		if (_currentTarget != AODONKKHPBP)
		{
			_currentTarget = AODONKKHPBP;
			if (CurrentTargetChanged != null)
			{
				CurrentTargetChanged(AODONKKHPBP);
			}
		}
	}

	private void CENNIIBJHOH(Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npc.rb != (Object)null)
		{
			npc.rb.position = IMOBLFMHKOD;
		}
		else
		{
			((Component)npc).transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
		}
	}
}
