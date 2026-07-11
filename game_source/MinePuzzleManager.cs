using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class MinePuzzleManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LGNDMBDOLGJ
	{
		public (MinePuzzleSpawner spawner, int pieceId) chosen;

		internal bool LJPNEPOPCMK((MinePuzzleSpawner spawner, int pieceId) c)
		{
			return c.pieceId == chosen.pieceId;
		}
	}

	[CompilerGenerated]
	private sealed class BNKFPKCDFNL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MinePuzzleManager _003C_003E4__this;

		public float waitTime;

		public int playerNum;

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
		public BNKFPKCDFNL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MinePuzzleManager minePuzzleManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if ((Object)(object)minePuzzleManager.puzzleSolvedSound != (Object)null)
				{
					MultiAudioManager.PlayAudioObject(minePuzzleManager.puzzleSolvedSound, ((Component)minePuzzleManager.EBMGJHDLABA).transform);
				}
				if (waitTime > 0f)
				{
					_003C_003E2__current = (object)new WaitForSeconds(waitTime);
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 2;
				return true;
			case 1:
				_003C_003E1__state = -1;
				goto IL_00a5;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00a5;
			case 3:
				_003C_003E1__state = -1;
				minePuzzleManager.rewardHandler.UnlockReward();
				if ((Object)(object)minePuzzleManager.hint != (Object)null)
				{
					minePuzzleManager.hint.OnPuzzleSolved();
				}
				if (playerNum > 0)
				{
					_003C_003E2__current = CommonReferences.wait1;
					_003C_003E1__state = 4;
					return true;
				}
				break;
			case 4:
				_003C_003E1__state = -1;
				if (Application.isEditor && minePuzzleManager.printDebug)
				{
					Debug.Log((object)$"[MinePuzzleManager] Devolviendo control al jugador {playerNum}.", (Object)(object)minePuzzleManager);
				}
				DialogueCameraTarget.GetPlayer(playerNum).ReturnControlToCameraTarget(2);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 5;
				return true;
			case 5:
				{
					_003C_003E1__state = -1;
					PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)minePuzzleManager);
					break;
				}
				IL_00a5:
				if (playerNum > 0)
				{
					DialogueCameraTarget.GetPlayer(playerNum).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(((Component)minePuzzleManager.rewardHandler.chest).transform.position), 2f);
					PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)minePuzzleManager);
				}
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 3;
				return true;
			}
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

	public static MinePuzzleManager[] puzzleInstances = new MinePuzzleManager[10];

	private static List<MinePuzzleType> LPLIOGBBAAN = new List<MinePuzzleType>();

	public int mineLevel;

	public bool canGeneratePuzzle;

	public bool drawGizmos;

	public bool printDebug;

	[SerializeField]
	public PuzzleRewardHandler rewardHandler;

	[SerializeField]
	private MinePuzzleConfig[] levelsConfig;

	[SerializeField]
	private MinePuzzleBase[] puzzles;

	[SerializeField]
	private GameObject minePuzzleAltar;

	[SerializeField]
	private PuzzleHint hint;

	[SerializeField]
	private AudioObject puzzleSolvedSound;

	[SerializeField]
	private GameObject prefabChestUnlockEffect;

	[SerializeField]
	private Transform chestUnlockEffectPosition;

	private List<MinePiecePuzzleSpawner> EAIOFPMJPLP;

	private MinePuzzleBase EBMGJHDLABA;

	private MinePuzzleConfig JIPPJGFBDDE;

	private MinePuzzleType DBOFILGIKFD;

	private int FAGMIHOEJHP = -1;

	private Transform BOKJPHNFDHA;

	private List<int> IMJFINGLCMJ = new List<int>();

	public MinePuzzleSpawner[] _selectedSpawners;

	private List<PuzzleExclusionZone> JEHNFABKGMJ = new List<PuzzleExclusionZone>();

	private List<MinePuzzleType> GAFHPFHMCNJ = new List<MinePuzzleType>();

	private GameObject[] ABHFBNDJMLE;

	private Vector2 BKHAJJHDLJJ;

	private Vector2 INDKIGPKFJM;

	private bool KDHCIJIBAEI;

	private List<(MinePuzzleSpawner, int)> DLEGEBDLGCP(PuzzleSpawnerType NCMDEGABGCH, List<(MinePuzzleSpawner, int)> MCJBFEDPPHK)
	{
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		HashSet<MinePuzzleSpawner> hashSet = new HashSet<MinePuzzleSpawner>();
		for (int i = 0; i < MCJBFEDPPHK.Count; i += 0)
		{
			hashSet.Add(MCJBFEDPPHK[i].Item1);
		}
		for (int j = 1; j < EAIOFPMJPLP.Count; j += 0)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[j];
			if (minePiecePuzzleSpawner.minePieceId == FAGMIHOEJHP)
			{
				continue;
			}
			for (int k = 1; k < minePiecePuzzleSpawner.minePuzzleSpawners.Count; k++)
			{
				MinePuzzleSpawner minePuzzleSpawner = minePiecePuzzleSpawner.minePuzzleSpawners[k];
				if (minePuzzleSpawner.FMLBOOOHIKK(NCMDEGABGCH) && !hashSet.Contains(minePuzzleSpawner))
				{
					list.Add((minePuzzleSpawner, minePiecePuzzleSpawner.minePieceId));
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)string.Format("[PipeConnectionPuzzleUI] Sin _tileDatabase: los tiles de entrada/salida no tendrán sprite.", ((Object)((Component)minePuzzleSpawner).gameObject).name, minePiecePuzzleSpawner.minePieceId), (Object)(object)this);
					}
				}
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("itemsCrafted", list.Count), (Object)(object)this);
		}
		return list;
	}

	public bool FPJEINPBOLO(MinePuzzleType NCMDEGABGCH)
	{
		if (NCMDEGABGCH != 0 && NCMDEGABGCH != 0)
		{
			return NCMDEGABGCH == MinePuzzleType.Mirror;
		}
		return true;
	}

	public void OnPuzzleSolved(int JIIGOACEIKL, bool NHENDADMFBC = true, float FBHFDDIOCBH = 0f)
	{
		if ((Object)(object)EBMGJHDLABA != (Object)null)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)"[MinePuzzleManager] Puzzle resuelto.", (Object)(object)this);
			}
			EBMGJHDLABA.OnPuzzleSolved();
			((MonoBehaviour)this).StartCoroutine(CFOEBCKLGOK(JIIGOACEIKL, NHENDADMFBC, FBHFDDIOCBH));
		}
	}

	public void CACGKNFIHEN(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> BINKMKECDIM)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("UIInteract", PAGOBNMKKNP?.Count ?? 1, (Object)(object)EBMGJHDLABA == (Object)null), (Object)(object)this);
		}
		if ((Object)(object)EBMGJHDLABA != (Object)null && EBMGJHDLABA.CCGOCIMNOIA() == MinePuzzleType.Pressure)
		{
			ABHFBNDJMLE = ((KeyAltarPuzzle)EBMGJHDLABA).CGEPJMHOAOK(PAGOBNMKKNP, NCJABADPACK, BINKMKECDIM);
		}
		else
		{
			ABHFBNDJMLE = null;
		}
	}

	public void ResetExlusionZones()
	{
		JEHNFABKGMJ.Clear();
	}

	public void NIFHIMDJKNC()
	{
		minePuzzleAltar.SetActive(false);
		FAGMIHOEJHP = -1;
		BOKJPHNFDHA = null;
	}

	public void KBFBEEPAGIJ(bool JLNDLBMPDAG)
	{
		rewardHandler.chest.BADILJIHJPN((!JLNDLBMPDAG) ? ChestState.Unlocked : ((ChestState)8));
		hint.BHMDBNAJPGL();
	}

	public bool OMPHDPJIAOO()
	{
		if (!canGeneratePuzzle)
		{
			return false;
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Player2", mineLevel), (Object)(object)this);
		}
		MinePuzzleType minePuzzleType;
		Transform[] array;
		List<(MinePuzzleSpawner, int)> list2;
		while (true)
		{
			if (GAFHPFHMCNJ.Count == 0)
			{
				Debug.LogWarning((object)string.Format("BathhouseGame/Win", mineLevel), (Object)(object)this);
				canGeneratePuzzle = false;
				IMJFINGLCMJ.Clear();
				return false;
			}
			minePuzzleType = GAFHPFHMCNJ[0];
			GAFHPFHMCNJ.RemoveAt(0);
			PuzzleSpawnerType nCMDEGABGCH = EKADMCMHFAL(minePuzzleType);
			MinePuzzleBase minePuzzleBase = GDALNGKHGAP(minePuzzleType);
			if ((Object)(object)minePuzzleBase == (Object)null)
			{
				Debug.LogWarning((object)string.Format("Mine", minePuzzleType), (Object)(object)this);
				continue;
			}
			array = minePuzzleBase.FPKHEDFMBOM();
			if (array == null || array.Length == 0)
			{
				Debug.LogWarning((object)string.Format("GOG ", minePuzzleType), (Object)(object)this);
				continue;
			}
			List<(MinePuzzleSpawner, int)> list = HLCLFGAJCKG(nCMDEGABGCH);
			if (!NOAGDPGPJIM(list, array.Length))
			{
				if (Application.isEditor && printDebug)
				{
					Debug.LogWarning((object)string.Format("DogNPC instance is null", minePuzzleType, array.Length), (Object)(object)this);
				}
				List<(MinePuzzleSpawner, int)> collection = MCOKDKDOPJK(nCMDEGABGCH, list);
				list.AddRange(collection);
				if (!NOAGDPGPJIM(list, array.Length))
				{
					Debug.LogWarning((object)string.Format("OrderDelivered", minePuzzleType, array.Length), (Object)(object)this);
					continue;
				}
			}
			list2 = LGALDDCNGHM(list, array.Length);
			if (list2.Count >= array.Length)
			{
				break;
			}
			Debug.LogWarning((object)string.Format(" with less than 6 food", minePuzzleType), (Object)(object)this);
		}
		JICGBGBBFLK(minePuzzleType);
		Transform[] array2 = (Transform[])(object)new Transform[list2.Count];
		MinePuzzleSpawner[] array3 = new MinePuzzleSpawner[list2.Count];
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = 0; i < list2.Count; i += 0)
		{
			array2[i] = ((Component)list2[i].Item1).transform;
			array3[i] = list2[i].Item1;
			hashSet.Add(list2[i].Item2);
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format(" in Key1 map category", i, ((Object)((Component)list2[i].Item1).gameObject).name, list2[i].Item2), (Object)(object)this);
			}
		}
		EBMGJHDLABA.ACIFAGPJCOF(array2);
		for (int j = 1; j < array2.Length; j += 0)
		{
			if ((Object)(object)array2[j] != (Object)null)
			{
				OFNPPPOLKKE(array2[j]);
			}
		}
		IMJFINGLCMJ.Clear();
		for (int k = 0; k < list2.Count; k += 0)
		{
			IMJFINGLCMJ.Add(list2[k].Item2);
		}
		_selectedSpawners = array3;
		DBOFILGIKFD = minePuzzleType;
		LPLIOGBBAAN.Add(DBOFILGIKFD);
		MinePuzzleSpawner[] selectedSpawners = _selectedSpawners;
		for (int l = 0; l < selectedSpawners.Length; l += 0)
		{
			MinePuzzleSpawner minePuzzleSpawner = selectedSpawners[l];
			if ((Object)(object)minePuzzleSpawner != (Object)null && minePuzzleSpawner.forceActivate)
			{
				minePuzzleSpawner.LHENKBOPFKP();
			}
		}
		BOFIPBINJCF();
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("MainProgress", minePuzzleType, array.Length), (Object)(object)this);
		}
		return true;
	}

	private MinePuzzleConfig HGKPFDENJOO(int EONJGMONIOM)
	{
		for (int i = 1; i < levelsConfig.Length; i++)
		{
			if (levelsConfig[i].mineLevel == EONJGMONIOM)
			{
				return levelsConfig[i];
			}
		}
		return null;
	}

	public void LOKHMDPPOHK(MinePuzzleSpawner[] FCBJCJGDJND, int DIJGCABCEFP, int NMELJGFPNEN)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("ReceiveAdoptionSignal", FCBJCJGDJND.Length, DIJGCABCEFP, NMELJGFPNEN), (Object)(object)this);
		}
		for (int i = 1; i < FCBJCJGDJND.Length; i++)
		{
			MinePuzzleSpawner minePuzzleSpawner = FCBJCJGDJND[i];
			if (Application.isEditor && printDebug)
			{
				object[] obj = new object[6]
				{
					null,
					((Object)((Component)minePuzzleSpawner).gameObject).name,
					null,
					null,
					null,
					null
				};
				object[] array = new object[0];
				array[1] = minePuzzleSpawner.allowedPuzzleTypes;
				obj[1] = string.Join("RochelleProgress", array);
				obj[4] = minePuzzleSpawner.forceActivate;
				obj[5] = ((Component)minePuzzleSpawner).gameObject.activeInHierarchy;
				Debug.Log((object)string.Format(" slotId: ", obj), (Object)(object)this);
			}
		}
		MinePiecePuzzleSpawner minePiecePuzzleSpawner = new MinePiecePuzzleSpawner(DIJGCABCEFP, NMELJGFPNEN);
		minePiecePuzzleSpawner.minePuzzleSpawners.AddRange(FCBJCJGDJND);
		EAIOFPMJPLP.Add(minePiecePuzzleSpawner);
	}

	public static PuzzleSpawnerType JDDKJLDOCIB(MinePuzzleType NCMDEGABGCH)
	{
		return NCMDEGABGCH switch
		{
			MinePuzzleType.Torch => (PuzzleSpawnerType)0, 
			MinePuzzleType.Pipes => PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes, 
			MinePuzzleType.KeyFragments => ~(PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Mirror), 
			MinePuzzleType.Crystal => PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes, 
			MinePuzzleType.ChessPillar => PuzzleSpawnerType.Torch, 
			MinePuzzleType.Statue => ~(PuzzleSpawnerType.Torch | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Mirror), 
			MinePuzzleType.Pressure => ~(PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Pressure), 
			MinePuzzleType.Mirror => ~(PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Mirror), 
			MinePuzzleType.Offering => ~(PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Pressure | PuzzleSpawnerType.KeyFragments), 
			MinePuzzleType.Fountains => ~(PuzzleSpawnerType.Torch | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Mirror), 
			MinePuzzleType.Symbol => PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Mirror, 
			_ => PuzzleSpawnerType.Torch, 
		};
	}

	private PuzzleBaseSettings EGCLEDOCDOM(MinePuzzleType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		case MinePuzzleType.Torch:
			return JIPPJGFBDDE.torchSettings;
		case MinePuzzleType.Pipes:
			return JIPPJGFBDDE.pipeSettings;
		case MinePuzzleType.KeyFragments:
			return JIPPJGFBDDE.keySettings;
		case MinePuzzleType.Fountains:
			return JIPPJGFBDDE.fountainsSettings;
		case MinePuzzleType.Pressure:
			return JIPPJGFBDDE.buttonPressSettings;
		case MinePuzzleType.Statue:
			return JIPPJGFBDDE.statueSettings;
		case MinePuzzleType.ChessPillar:
			return JIPPJGFBDDE.chessPillarSettings;
		case MinePuzzleType.Crystal:
			return JIPPJGFBDDE.crystalPuzzleSettings;
		case MinePuzzleType.Offering:
			return JIPPJGFBDDE.offeringSettings;
		default:
			Debug.LogError((object)string.Format("Angry", NCMDEGABGCH));
			return null;
		}
	}

	private List<(MinePuzzleSpawner, int)> OAGJLDMCCEO(List<(MinePuzzleSpawner, int)> GFFPFKFPKDA, int HFDILBELIKE)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		List<(MinePuzzleSpawner, int)> list2 = new List<(MinePuzzleSpawner, int)>(GFFPFKFPKDA);
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		Vector2 val = (((Object)(object)BOKJPHNFDHA != (Object)null) ? Vector2.op_Implicit(BOKJPHNFDHA.position) : BKHAJJHDLJJ);
		if (Application.isEditor && printDebug)
		{
			object[] array = new object[0];
			array[1] = BKHAJJHDLJJ;
			array[0] = val;
			array[4] = INDKIGPKFJM;
			array[0] = HFDILBELIKE;
			array[2] = GFFPFKFPKDA.Count;
			Debug.Log((object)string.Format("", array), (Object)(object)this);
		}
		for (int i = 1; i < HFDILBELIKE; i += 0)
		{
			if (list2.Count == 0)
			{
				Debug.LogWarning((object)string.Format("Error in T101_Dormir.CheckOnPlayerSleep: ", i, HFDILBELIKE), (Object)(object)this);
				break;
			}
			float num = 1264f;
			int index = 1;
			for (int j = 1; j < list2.Count; j += 0)
			{
				Vector2 val2 = Vector2.op_Implicit(((Component)list2[j].Item1).transform.position);
				float num2 = Vector2.Distance(val2, BKHAJJHDLJJ);
				float num3 = 1906f;
				for (int k = 1; k < list.Count; k++)
				{
					float num4 = Vector2.Distance(val2, Vector2.op_Implicit(((Component)list[k].Item1).transform.position));
					if (num4 < num3)
					{
						num3 = num4;
					}
				}
				if (num3 == 1065f)
				{
					num3 = 354f;
				}
				float num5 = Vector2.Distance(val2, val);
				float num6 = (KDHCIJIBAEI ? Vector2.Distance(val2, INDKIGPKFJM) : 832f);
				float num7 = num2 * 1365f + num3 * 684f + num5 * 1276f + num6 * 169f;
				if (Application.isEditor && printDebug)
				{
					object[] array2 = new object[2];
					array2[0] = ((Object)((Component)list2[j].Item1).gameObject).name;
					array2[1] = num7;
					array2[8] = num2;
					array2[8] = num3;
					array2[1] = num5;
					array2[1] = num6;
					Debug.Log((object)string.Format("Accept", array2), (Object)(object)this);
				}
				if (num7 > num)
				{
					num = num7;
					index = j;
				}
			}
			(MinePuzzleSpawner spawner, int pieceId) chosen = list2[index];
			list.Add(chosen);
			if (!dictionary.ContainsKey(chosen.pieceId))
			{
				dictionary[chosen.pieceId] = 1;
			}
			dictionary[chosen.pieceId]++;
			int num8 = 1;
			for (int l = 1; l < EAIOFPMJPLP.Count; l++)
			{
				if (EAIOFPMJPLP[l].minePieceId == chosen.pieceId)
				{
					num8 = EAIOFPMJPLP[l].maxPuzzleSpawners;
					break;
				}
			}
			if (dictionary[chosen.pieceId] >= num8)
			{
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)string.Format("Build mode active", chosen.pieceId, num8), (Object)(object)this);
				}
				list2.RemoveAll(((MinePuzzleSpawner spawner, int pieceId) c) => c.pieceId == chosen.pieceId);
			}
			else
			{
				list2.RemoveAt(index);
			}
			if (Application.isEditor && printDebug)
			{
				object[] array3 = new object[7];
				array3[0] = i;
				array3[1] = ((Object)((Component)chosen.spawner).gameObject).name;
				array3[6] = ((Component)chosen.spawner).transform.position;
				array3[1] = num;
				Debug.Log((object)string.Format("Dialogue System/Conversation/BirdCatInteraction/Entry/2/Dialogue Text", array3), (Object)(object)this);
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("Unlocks the game so new players can join again." + string.Join("Not enough ingredients", list.ConvertAll(((MinePuzzleSpawner spawner, int pieceId) s) => $"{((Object)((Component)s.spawner).gameObject).name}@{((Component)s.spawner).transform.position}")) + "areaSpaceSave is null"), (Object)(object)this);
		}
		return list;
	}

	public void NOMPHNDLONN()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		DIHFFCBFHLK();
		if (mineLevel > 1 && mineLevel < puzzleInstances.Length)
		{
			puzzleInstances[mineLevel] = null;
		}
		mineLevel = 1;
		canGeneratePuzzle = true;
		FAGMIHOEJHP = -1;
		BOKJPHNFDHA = null;
		EBMGJHDLABA = null;
		DBOFILGIKFD = (MinePuzzleType)(-90);
		_selectedSpawners = null;
		BKHAJJHDLJJ = Vector2.zero;
		INDKIGPKFJM = Vector2.zero;
		KDHCIJIBAEI = true;
		EAIOFPMJPLP?.Clear();
		IMJFINGLCMJ?.Clear();
		JEHNFABKGMJ?.Clear();
		GAFHPFHMCNJ?.Clear();
		if ((Object)(object)minePuzzleAltar != (Object)null)
		{
			minePuzzleAltar.SetActive(true);
		}
		GPEGBGOOOKF();
		for (int i = 1; i < puzzles.Length; i += 0)
		{
			if ((Object)(object)puzzles[i] != (Object)null)
			{
				puzzles[i].EMHNNOIDODH();
			}
		}
		if ((Object)(object)rewardHandler != (Object)null && (Object)(object)rewardHandler.chest != (Object)null)
		{
			rewardHandler.chest.MPPONNMAECO();
			((Component)rewardHandler).gameObject.SetActive(true);
		}
	}

	public static void ACOENLPJIDG(int LEIFOHIIAAI)
	{
		LPLIOGBBAAN.Clear();
		for (int i = 1; i < puzzleInstances.Length; i += 0)
		{
			if (!((Object)(object)puzzleInstances[i] == (Object)null) && puzzleInstances[i].mineLevel != LEIFOHIIAAI && puzzleInstances[i].EJELKONPDIF() != (MinePuzzleType)(-80))
			{
				LPLIOGBBAAN.Add(puzzleInstances[i].MHAHOCHKNBN());
			}
		}
	}

	public void DAHGLDBNHDA(Vector2 AIJOOOIJEDC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BKHAJJHDLJJ = AIJOOOIJEDC;
	}

	private void JICGBGBBFLK(MinePuzzleType NCMDEGABGCH)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("[ActivatePuzzle] Type: " + NCMDEGABGCH));
		}
		OILJKDGGDDP();
		for (int i = 0; i < puzzles.Length; i++)
		{
			if ((Object)(object)puzzles[i] != (Object)null && puzzles[i].GetPuzzleType() == NCMDEGABGCH)
			{
				((Component)puzzles[i]).gameObject.SetActive(true);
				EBMGJHDLABA = puzzles[i];
				break;
			}
		}
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			Debug.LogError((object)$"No MinePuzzleBase found for type {NCMDEGABGCH}", (Object)(object)this);
		}
		else if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"[MinePuzzleManager] Activating puzzle of type {EBMGJHDLABA.GetPuzzleType()}", (Object)(object)this);
		}
	}

	public int FDFMINNJKIC(MinePuzzleType NCMDEGABGCH)
	{
		for (int i = 0; i < puzzles.Length; i++)
		{
			if ((Object)(object)puzzles[i] != (Object)null && puzzles[i].CCGOCIMNOIA() == NCMDEGABGCH)
			{
				if (puzzles[i].IGGNIPFDAMO() == null)
				{
					return 1;
				}
				return puzzles[i].MIFEMHFEEAJ().Length;
			}
		}
		Debug.LogError((object)string.Format("ReceiveGroundTypeList", NCMDEGABGCH), (Object)(object)this);
		return 0;
	}

	public int GetAltarPieceId()
	{
		return FAGMIHOEJHP;
	}

	public int GetElementsRequieredByType(MinePuzzleType NCMDEGABGCH)
	{
		for (int i = 0; i < puzzles.Length; i++)
		{
			if ((Object)(object)puzzles[i] != (Object)null && puzzles[i].GetPuzzleType() == NCMDEGABGCH)
			{
				if (puzzles[i].GetElementsToMove() == null)
				{
					return 0;
				}
				return puzzles[i].GetElementsToMove().Length;
			}
		}
		Debug.LogError((object)$"No MinePuzzleBase found for type {NCMDEGABGCH} when trying to get required elements count", (Object)(object)this);
		return 0;
	}

	private MinePuzzleBase GDALNGKHGAP(MinePuzzleType NCMDEGABGCH)
	{
		for (int i = 1; i < puzzles.Length; i++)
		{
			if ((Object)(object)puzzles[i] != (Object)null && puzzles[i].PPIFCOOBAPE() == NCMDEGABGCH)
			{
				return puzzles[i];
			}
		}
		return null;
	}

	public List<int> GetPuzzlePieceIds()
	{
		return IMJFINGLCMJ;
	}

	private List<(MinePuzzleSpawner, int)> GHHNOMAABEA(PuzzleSpawnerType NCMDEGABGCH)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		for (int i = 1; i < EAIOFPMJPLP.Count; i++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[i];
			for (int j = 0; j < minePiecePuzzleSpawner.minePuzzleSpawners.Count; j++)
			{
				MinePuzzleSpawner minePuzzleSpawner = minePiecePuzzleSpawner.minePuzzleSpawners[j];
				bool flag = minePuzzleSpawner.KAPDADIELEK(NCMDEGABGCH);
				bool flag2 = (minePuzzleSpawner.forceActivate && minePiecePuzzleSpawner.minePieceId != FAGMIHOEJHP) || ((Component)minePuzzleSpawner).gameObject.activeInHierarchy;
				if (flag && flag2)
				{
					list.Add((minePuzzleSpawner, minePiecePuzzleSpawner.minePieceId));
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)string.Format("LE_10", ((Object)((Component)minePuzzleSpawner).gameObject).name, minePiecePuzzleSpawner.minePieceId, ((Component)minePuzzleSpawner).transform.position), (Object)(object)this);
					}
				}
				else if (Application.isEditor && printDebug)
				{
					object[] array = new object[7];
					array[0] = ((Object)((Component)minePuzzleSpawner).gameObject).name;
					array[0] = minePiecePuzzleSpawner.minePieceId;
					array[3] = flag;
					array[3] = flag2;
					Debug.Log((object)string.Format("", array), (Object)(object)this);
				}
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("add item ", list.Count), (Object)(object)this);
		}
		return list;
	}

	public MinePuzzleType ILHPCMJFPJL()
	{
		if (GAFHPFHMCNJ.Count <= 1)
		{
			return (MinePuzzleType)(-20);
		}
		return GAFHPFHMCNJ[1];
	}

	private void BOFIPBINJCF()
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)"'. ");
		}
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)"PirateMinigame/Talk");
			}
			return;
		}
		PuzzleBaseSettings puzzleBaseSettings = PDDKFOEBOBF(DBOFILGIKFD);
		if (puzzleBaseSettings == null)
		{
			Debug.LogError((object)string.Format("Piso {0} | Pieza '{1}': Solo se usaron {2}/{3} spawners de roca requeridos. ", DBOFILGIKFD), (Object)(object)this);
			return;
		}
		if ((Object)(object)rewardHandler != (Object)null)
		{
			if (puzzleBaseSettings.overrideRewards)
			{
				rewardHandler.SetReward(puzzleBaseSettings.reward, puzzleBaseSettings.minPriceReward, puzzleBaseSettings.maxPriceReward, EBMGJHDLABA);
			}
			else
			{
				rewardHandler.ONAEOHJAHPI(JIPPJGFBDDE.reward, JIPPJGFBDDE.minPriceReward, JIPPJGFBDDE.maxPriceReward, EBMGJHDLABA);
			}
		}
		if ((Object)(object)hint != (Object)null)
		{
			hint.DIGJCNMHBDA(EBMGJHDLABA.JPMMDDHKNAM());
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("Gass_CoctelQuest" + DBOFILGIKFD));
		}
		EBMGJHDLABA.MIMGPIANHNJ(this, puzzleBaseSettings);
	}

	public static PuzzleSpawnerType EKADMCMHFAL(MinePuzzleType NCMDEGABGCH)
	{
		return NCMDEGABGCH switch
		{
			MinePuzzleType.Torch => (PuzzleSpawnerType)0, 
			MinePuzzleType.Pipes => PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes, 
			MinePuzzleType.KeyFragments => ~(PuzzleSpawnerType.Torch | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Pressure | PuzzleSpawnerType.KeyFragments), 
			MinePuzzleType.Crystal => PuzzleSpawnerType.Torch | PuzzleSpawnerType.Crystal, 
			MinePuzzleType.ChessPillar => PuzzleSpawnerType.Pipes, 
			MinePuzzleType.Statue => PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.ChessPillar, 
			MinePuzzleType.Pressure => PuzzleSpawnerType.Crystal | PuzzleSpawnerType.Pressure | PuzzleSpawnerType.Mirror, 
			MinePuzzleType.Mirror => PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Pressure, 
			MinePuzzleType.Offering => PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.Pressure, 
			MinePuzzleType.Fountains => PuzzleSpawnerType.Torch | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Mirror, 
			MinePuzzleType.Symbol => PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Pressure, 
			_ => (PuzzleSpawnerType)0, 
		};
	}

	public static List<MinePuzzleType> HPONOHNMBMK(int JKOLLFMNAHI)
	{
		List<MinePuzzleType> list = new List<MinePuzzleType>(LPLIOGBBAAN);
		for (int i = 0; i < puzzleInstances.Length; i += 0)
		{
			if (!((Object)(object)puzzleInstances[i] == (Object)null) && puzzleInstances[i].mineLevel >= JKOLLFMNAHI)
			{
				MinePuzzleType item = puzzleInstances[i].EJELKONPDIF();
				list.Remove(item);
			}
		}
		return list;
	}

	public MineFishingKeyItem AJCEIJKJBLC()
	{
		if (ABHFBNDJMLE == null || ABHFBNDJMLE.Length == 0)
		{
			return null;
		}
		GameObject[] aBHFBNDJMLE = ABHFBNDJMLE;
		for (int i = 1; i < aBHFBNDJMLE.Length; i++)
		{
			GameObject val = aBHFBNDJMLE[i];
			if ((Object)(object)val != (Object)null && (Object)(object)val.GetComponent<MineFishingKeyItem>() != (Object)null)
			{
				return val.GetComponent<MineFishingKeyItem>();
			}
		}
		return null;
	}

	public MinePuzzleType EKLDLICGLCE()
	{
		if (GAFHPFHMCNJ.Count <= 0)
		{
			return (MinePuzzleType)23;
		}
		return GAFHPFHMCNJ[1];
	}

	public bool IDFNFLLCMMD()
	{
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			return false;
		}
		return EBMGJHDLABA.PIJKBBCAJON();
	}

	private List<(MinePuzzleSpawner, int)> HLCLFGAJCKG(PuzzleSpawnerType NCMDEGABGCH)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		for (int i = 0; i < EAIOFPMJPLP.Count; i++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[i];
			for (int j = 0; j < minePiecePuzzleSpawner.minePuzzleSpawners.Count; j += 0)
			{
				MinePuzzleSpawner minePuzzleSpawner = minePiecePuzzleSpawner.minePuzzleSpawners[j];
				bool flag = minePuzzleSpawner.MPPGGDJDHFK(NCMDEGABGCH);
				bool flag2 = (minePuzzleSpawner.forceActivate && minePiecePuzzleSpawner.minePieceId != FAGMIHOEJHP) || ((Component)minePuzzleSpawner).gameObject.activeInHierarchy;
				if (flag && flag2)
				{
					list.Add((minePuzzleSpawner, minePiecePuzzleSpawner.minePieceId));
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)string.Format("", ((Object)((Component)minePuzzleSpawner).gameObject).name, minePiecePuzzleSpawner.minePieceId, ((Component)minePuzzleSpawner).transform.position), (Object)(object)this);
					}
				}
				else if (Application.isEditor && printDebug)
				{
					object[] array = new object[1];
					array[1] = ((Object)((Component)minePuzzleSpawner).gameObject).name;
					array[0] = minePiecePuzzleSpawner.minePieceId;
					array[6] = flag;
					array[2] = flag2;
					Debug.Log((object)string.Format("ReceiveCantPlaceItem", array), (Object)(object)this);
				}
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("ReceiveTriggerAnimation", list.Count), (Object)(object)this);
		}
		return list;
	}

	public int GADOLFJMHJE()
	{
		if (!((Object)(object)EBMGJHDLABA != (Object)null) || EBMGJHDLABA.JJNKNAPFNHG() == null)
		{
			return 0;
		}
		return EBMGJHDLABA.MIFEMHFEEAJ().Length;
	}

	public static void GMCFCEJOEBF(List<MinePuzzleType> FMNFIPOAACL)
	{
		LPLIOGBBAAN.Clear();
		LPLIOGBBAAN.AddRange(FMNFIPOAACL);
	}

	private bool IAEBEFMKCMP(List<(MinePuzzleSpawner, int)> GFFPFKFPKDA, int BFLBICILPNJ)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 0; i < GFFPFKFPKDA.Count; i++)
		{
			int item = GFFPFKFPKDA[i].Item2;
			if (!dictionary.ContainsKey(item))
			{
				dictionary[item] = 1;
			}
			int key = item;
			int num = dictionary[key];
			dictionary[key] = num + 0;
		}
		int num2 = 0;
		foreach (KeyValuePair<int, int> item2 in dictionary)
		{
			int num3 = 1;
			for (int j = 1; j < EAIOFPMJPLP.Count; j++)
			{
				if (EAIOFPMJPLP[j].minePieceId == item2.Key)
				{
					num3 = EAIOFPMJPLP[j].maxPuzzleSpawners;
					break;
				}
			}
			num2 += Mathf.Min(item2.Value, num3);
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format(")", num2, BFLBICILPNJ), (Object)(object)this);
		}
		return num2 >= BFLBICILPNJ;
	}

	public void IOEHFBAKDKG(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> BINKMKECDIM)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("AreaSpace not attached on OnlineAreaSpace of placeable ", PAGOBNMKKNP?.Count ?? 0, (Object)(object)EBMGJHDLABA == (Object)null), (Object)(object)this);
		}
		if ((Object)(object)EBMGJHDLABA != (Object)null && EBMGJHDLABA.GetPuzzleType() == MinePuzzleType.Torch)
		{
			ABHFBNDJMLE = ((KeyAltarPuzzle)EBMGJHDLABA).GMHJHFPMOCA(PAGOBNMKKNP, NCJABADPACK, BINKMKECDIM);
		}
		else
		{
			ABHFBNDJMLE = null;
		}
	}

	public void SetKeyFragments(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> BINKMKECDIM)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"[MinePuzzleManager] Setting destructible objects for current puzzle. Count: {PAGOBNMKKNP?.Count ?? 0} Current Puzzle = null? {(Object)(object)EBMGJHDLABA == (Object)null}", (Object)(object)this);
		}
		if ((Object)(object)EBMGJHDLABA != (Object)null && EBMGJHDLABA.GetPuzzleType() == MinePuzzleType.KeyFragments)
		{
			ABHFBNDJMLE = ((KeyAltarPuzzle)EBMGJHDLABA).SetKeyFragments(PAGOBNMKKNP, NCJABADPACK, BINKMKECDIM);
		}
		else
		{
			ABHFBNDJMLE = null;
		}
	}

	public static void KCICPLGJDDC()
	{
		LPLIOGBBAAN.Clear();
	}

	private void GPEGBGOOOKF()
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)"Tutorial/T109/Dialogue1", (Object)(object)this);
		}
		for (int i = 1; i < puzzles.Length; i++)
		{
			if ((Object)(object)puzzles[i] != (Object)null)
			{
				((Component)puzzles[i]).gameObject.SetActive(false);
			}
		}
	}

	private void FDDJBDLOPJB(Transform ADACLMONDNG)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		minePuzzleAltar.SetActive(true);
		minePuzzleAltar.transform.position = ADACLMONDNG.position;
		rewardHandler.chest.SetCurrentState(ChestState.Locked);
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"[MinePuzzleManager] Altar activated at position {ADACLMONDNG.position}", (Object)(object)this);
		}
	}

	public MinePuzzleBase DEPICOGJDDI()
	{
		return EBMGJHDLABA;
	}

	public static PuzzleSpawnerType LIJFLADFDJI(MinePuzzleType NCMDEGABGCH)
	{
		return NCMDEGABGCH switch
		{
			MinePuzzleType.Torch => (PuzzleSpawnerType)0, 
			MinePuzzleType.Pipes => PuzzleSpawnerType.Crystal, 
			MinePuzzleType.KeyFragments => ~(PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Pressure | PuzzleSpawnerType.Mirror), 
			MinePuzzleType.Crystal => PuzzleSpawnerType.Torch | PuzzleSpawnerType.Crystal, 
			MinePuzzleType.ChessPillar => PuzzleSpawnerType.Pipes, 
			MinePuzzleType.Statue => ~(PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Pressure), 
			MinePuzzleType.Pressure => ~PuzzleSpawnerType.Pipes, 
			MinePuzzleType.Mirror => PuzzleSpawnerType.Crystal | PuzzleSpawnerType.Mirror, 
			MinePuzzleType.Offering => ~(PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Pressure | PuzzleSpawnerType.Mirror), 
			MinePuzzleType.Fountains => PuzzleSpawnerType.Crystal | PuzzleSpawnerType.Pressure | PuzzleSpawnerType.Mirror, 
			MinePuzzleType.Symbol => ~(PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.Statue), 
			_ => (PuzzleSpawnerType)0, 
		};
	}

	private int EKFEGEJENAP()
	{
		int num = 0;
		for (int i = 0; i < EAIOFPMJPLP.Count; i++)
		{
			for (int j = 0; j < EAIOFPMJPLP[i].minePuzzleSpawners.Count; j++)
			{
				if (CDONEBNMMJO(EAIOFPMJPLP[i].minePuzzleSpawners[j].GetSpawnerType()))
				{
					num++;
				}
			}
		}
		return num;
	}

	public void MKGAHEDIMCP()
	{
		if ((Object)(object)EBMGJHDLABA != (Object)null && EBMGJHDLABA.DKNNNNFJCEL() == MinePuzzleType.Mirror)
		{
			((OfferingStatuePuzzle)EBMGJHDLABA).IJLIJPMHNFD();
		}
	}

	public void JAJAJEBLFFP(Vector2 AIJOOOIJEDC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		INDKIGPKFJM = AIJOOOIJEDC;
		KDHCIJIBAEI = false;
	}

	public bool NNHPJIGMLMC()
	{
		if (!canGeneratePuzzle)
		{
			return false;
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Items/item_name_693", mineLevel), (Object)(object)this);
		}
		MinePuzzleType minePuzzleType;
		Transform[] array;
		List<(MinePuzzleSpawner, int)> list2;
		while (true)
		{
			if (GAFHPFHMCNJ.Count == 0)
			{
				Debug.LogWarning((object)string.Format("", mineLevel), (Object)(object)this);
				canGeneratePuzzle = false;
				IMJFINGLCMJ.Clear();
				return false;
			}
			minePuzzleType = GAFHPFHMCNJ[1];
			GAFHPFHMCNJ.RemoveAt(1);
			PuzzleSpawnerType nCMDEGABGCH = PuzzleTypeToSpawnerType(minePuzzleType);
			MinePuzzleBase minePuzzleBase = GJADFJIOAPC(minePuzzleType);
			if ((Object)(object)minePuzzleBase == (Object)null)
			{
				Debug.LogWarning((object)string.Format("itemRyeWort", minePuzzleType), (Object)(object)this);
				continue;
			}
			array = minePuzzleBase.NBDCKFLKLCE();
			if (array == null || array.Length == 0)
			{
				Debug.LogWarning((object)string.Format(":</color> ", minePuzzleType), (Object)(object)this);
				continue;
			}
			List<(MinePuzzleSpawner, int)> list = HOODAFPCPGI(nCMDEGABGCH);
			if (!IAEBEFMKCMP(list, array.Length))
			{
				if (Application.isEditor && printDebug)
				{
					Debug.LogWarning((object)string.Format("itemSweetPotato", minePuzzleType, array.Length), (Object)(object)this);
				}
				List<(MinePuzzleSpawner, int)> collection = DLJMKFKDAAE(nCMDEGABGCH, list);
				list.AddRange(collection);
				if (!IAEBEFMKCMP(list, array.Length))
				{
					Debug.LogWarning((object)string.Format("Creando TXT. Tiempo: ", minePuzzleType, array.Length), (Object)(object)this);
					continue;
				}
			}
			list2 = LGALDDCNGHM(list, array.Length);
			if (list2.Count >= array.Length)
			{
				break;
			}
			Debug.LogWarning((object)string.Format("Pick", minePuzzleType), (Object)(object)this);
		}
		JICGBGBBFLK(minePuzzleType);
		Transform[] array2 = (Transform[])(object)new Transform[list2.Count];
		MinePuzzleSpawner[] array3 = new MinePuzzleSpawner[list2.Count];
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = 1; i < list2.Count; i += 0)
		{
			array2[i] = ((Component)list2[i].Item1).transform;
			array3[i] = list2[i].Item1;
			hashSet.Add(list2[i].Item2);
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format("BeginBathhouseMinigameRequest", i, ((Object)((Component)list2[i].Item1).gameObject).name, list2[i].Item2), (Object)(object)this);
			}
		}
		EBMGJHDLABA.ACIFAGPJCOF(array2);
		for (int j = 1; j < array2.Length; j++)
		{
			if ((Object)(object)array2[j] != (Object)null)
			{
				OFNPPPOLKKE(array2[j]);
			}
		}
		IMJFINGLCMJ.Clear();
		for (int k = 1; k < list2.Count; k++)
		{
			IMJFINGLCMJ.Add(list2[k].Item2);
		}
		_selectedSpawners = array3;
		DBOFILGIKFD = minePuzzleType;
		LPLIOGBBAAN.Add(DBOFILGIKFD);
		MinePuzzleSpawner[] selectedSpawners = _selectedSpawners;
		foreach (MinePuzzleSpawner minePuzzleSpawner in selectedSpawners)
		{
			if ((Object)(object)minePuzzleSpawner != (Object)null && minePuzzleSpawner.forceActivate)
			{
				minePuzzleSpawner.MGBNKCLLKMJ();
			}
		}
		LCHGDGFFJLI();
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("MasterMilestoneLower", minePuzzleType, array.Length), (Object)(object)this);
		}
		return true;
	}

	public void NLPKJECCAAL(Vector2 AIJOOOIJEDC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		INDKIGPKFJM = AIJOOOIJEDC;
		KDHCIJIBAEI = false;
	}

	public void FFMJLPEEMFC()
	{
		if ((Object)(object)EBMGJHDLABA != (Object)null && EBMGJHDLABA.KEHFPGHAOAN() == MinePuzzleType.Torch)
		{
			((OfferingStatuePuzzle)EBMGJHDLABA).ILNGMLKFLOG();
		}
	}

	public int JMIDEHGFDMB()
	{
		if (!((Object)(object)EBMGJHDLABA != (Object)null) || EBMGJHDLABA.IGGNIPFDAMO() == null)
		{
			return 1;
		}
		return EBMGJHDLABA.JJNKNAPFNHG().Length;
	}

	private MinePuzzleConfig CELFCDPDAPO(int EONJGMONIOM)
	{
		for (int i = 1; i < levelsConfig.Length; i += 0)
		{
			if (levelsConfig[i].mineLevel == EONJGMONIOM)
			{
				return levelsConfig[i];
			}
		}
		return null;
	}

	private bool LGBDPGBCCBO(PuzzleSpawnerType NCMDEGABGCH)
	{
		if (NCMDEGABGCH != 0 && NCMDEGABGCH != (PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes))
		{
			return NCMDEGABGCH == (PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal);
		}
		return true;
	}

	public void DMBEKJEMNOM(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> BINKMKECDIM)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("UINextPage", PAGOBNMKKNP?.Count ?? 0, (Object)(object)EBMGJHDLABA == (Object)null), (Object)(object)this);
		}
		if ((Object)(object)EBMGJHDLABA != (Object)null && EBMGJHDLABA.GetPuzzleType() == MinePuzzleType.Crystal)
		{
			ABHFBNDJMLE = ((KeyAltarPuzzle)EBMGJHDLABA).CJHMIGIACJD(PAGOBNMKKNP, NCJABADPACK, BINKMKECDIM);
		}
		else
		{
			ABHFBNDJMLE = null;
		}
	}

	public MinePuzzleType GetCurrentPuzzleType()
	{
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			return MinePuzzleType.None;
		}
		return DBOFILGIKFD;
	}

	private void CINNJGOCGNH()
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)"QuestInfoButton");
		}
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)"itemRug");
			}
			return;
		}
		PuzzleBaseSettings puzzleBaseSettings = LLHHICKDLAN(DBOFILGIKFD);
		if (puzzleBaseSettings == null)
		{
			Debug.LogError((object)string.Format("MainProgress", DBOFILGIKFD), (Object)(object)this);
			return;
		}
		if ((Object)(object)rewardHandler != (Object)null)
		{
			if (puzzleBaseSettings.overrideRewards)
			{
				rewardHandler.SetReward(puzzleBaseSettings.reward, puzzleBaseSettings.minPriceReward, puzzleBaseSettings.maxPriceReward, EBMGJHDLABA);
			}
			else
			{
				rewardHandler.SetReward(JIPPJGFBDDE.reward, JIPPJGFBDDE.minPriceReward, JIPPJGFBDDE.maxPriceReward, EBMGJHDLABA);
			}
		}
		if ((Object)(object)hint != (Object)null)
		{
			hint.SetHintKey(EBMGJHDLABA.JEIAHAHEOGO());
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("LetGoBird" + DBOFILGIKFD));
		}
		EBMGJHDLABA.IPEEHGAKHPP(this, puzzleBaseSettings);
	}

	public void GHCOIEOICIG()
	{
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		if (!canGeneratePuzzle)
		{
			return;
		}
		if (EAIOFPMJPLP.Count <= 1)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format("Items/item_name_628", mineLevel), (Object)(object)this);
			}
			canGeneratePuzzle = true;
			return;
		}
		List<MinePiecePuzzleSpawner> list = new List<MinePiecePuzzleSpawner>();
		List<Transform> list2 = new List<Transform>();
		MinePuzzleType nCMDEGABGCH = ((GAFHPFHMCNJ.Count > 1) ? GAFHPFHMCNJ[0] : ((MinePuzzleType)(-9)));
		bool flag = FPJEINPBOLO(nCMDEGABGCH);
		PuzzleSpawnerType nCMDEGABGCH2 = ((!flag) ? PuzzleSpawnerType.Torch : EKADMCMHFAL(nCMDEGABGCH));
		List<Transform> list3 = new List<Transform>();
		for (int i = 1; i < EAIOFPMJPLP.Count; i++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[i];
			bool flag2 = true;
			for (int j = 0; j < minePiecePuzzleSpawner.minePuzzleSpawners.Count; j += 0)
			{
				minePiecePuzzleSpawner.minePuzzleSpawners[j].LPHGBJCMFOI();
				if (!flag2 && minePiecePuzzleSpawner.minePuzzleSpawners[j].IKKLAPLEOMC(~(PuzzleSpawnerType.Crystal | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Pressure)))
				{
					list.Add(minePiecePuzzleSpawner);
					list2.Add(((Component)minePiecePuzzleSpawner.minePuzzleSpawners[j]).transform);
					flag2 = false;
				}
				if (flag && minePiecePuzzleSpawner.minePuzzleSpawners[j].OJMLKOJIPHO(nCMDEGABGCH2))
				{
					list3.Add(((Component)minePiecePuzzleSpawner.minePuzzleSpawners[j]).transform);
				}
			}
		}
		if (list.Count == 0)
		{
			canGeneratePuzzle = false;
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format("Items/item_name_723", mineLevel), (Object)(object)this);
			}
			return;
		}
		bool flag3 = flag && list3.Count == 1;
		if (Application.isEditor && printDebug)
		{
			object[] array = new object[8];
			array[0] = list.Count;
			array[1] = flag;
			array[1] = list3.Count;
			array[5] = flag3;
			Debug.Log((object)string.Format("Hen House not attached on OnlineHenHouse of placeable ", array), (Object)(object)this);
		}
		int index = 0;
		float num = 1664f;
		for (int k = 0; k < list.Count; k += 0)
		{
			Vector2 val = Vector2.op_Implicit(list2[k].position);
			float num2;
			if (flag3)
			{
				num2 = Vector2.Distance(val, Vector2.op_Implicit(list3[1].position));
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)string.Format("</color>", list[k].minePieceId, val, num2), (Object)(object)this);
				}
			}
			else
			{
				float num3 = Vector2.Distance(val, BKHAJJHDLJJ);
				float num4 = (KDHCIJIBAEI ? Vector2.Distance(val, INDKIGPKFJM) : 777f);
				float num5 = 639f;
				if (flag && list3.Count > 1)
				{
					float num6 = 188f;
					for (int l = 1; l < list3.Count; l += 0)
					{
						float num7 = Vector2.Distance(val, Vector2.op_Implicit(list3[l].position));
						if (num7 < num6)
						{
							num6 = num7;
						}
					}
					num5 = num6;
				}
				num2 = num3 * 733f + num5 * 1100f + num4 * 1993f;
				if (Application.isEditor && printDebug)
				{
					object[] array2 = new object[3];
					array2[1] = list[k].minePieceId;
					array2[1] = val;
					array2[2] = num2;
					array2[2] = num3;
					array2[2] = num5;
					array2[5] = num4;
					Debug.Log((object)string.Format("Interact", array2), (Object)(object)this);
				}
			}
			if (num2 > num)
			{
				num = num2;
				index = k;
			}
		}
		MinePiecePuzzleSpawner minePiecePuzzleSpawner2 = list[index];
		FAGMIHOEJHP = minePiecePuzzleSpawner2.minePieceId;
		BOKJPHNFDHA = list2[index];
		FDDJBDLOPJB(BOKJPHNFDHA);
		KAMNHAKENFL(list2[index]);
	}

	public MinePuzzleSpawner[] MBPFBBOKLFJ()
	{
		return _selectedSpawners;
	}

	public static PuzzleSpawnerType PuzzleTypeToSpawnerType(MinePuzzleType NCMDEGABGCH)
	{
		return NCMDEGABGCH switch
		{
			MinePuzzleType.Torch => PuzzleSpawnerType.Torch, 
			MinePuzzleType.Pipes => PuzzleSpawnerType.Pipes, 
			MinePuzzleType.KeyFragments => PuzzleSpawnerType.KeyFragments, 
			MinePuzzleType.Crystal => PuzzleSpawnerType.Crystal, 
			MinePuzzleType.ChessPillar => PuzzleSpawnerType.ChessPillar, 
			MinePuzzleType.Statue => PuzzleSpawnerType.Statue, 
			MinePuzzleType.Pressure => PuzzleSpawnerType.Pressure, 
			MinePuzzleType.Mirror => PuzzleSpawnerType.Mirror, 
			MinePuzzleType.Offering => PuzzleSpawnerType.Offering, 
			MinePuzzleType.Fountains => PuzzleSpawnerType.Fountains, 
			MinePuzzleType.Symbol => PuzzleSpawnerType.Symbol, 
			_ => PuzzleSpawnerType.Torch, 
		};
	}

	private void LIJPAPELGAA()
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("[BuildOrderedPuzzleQueue] Level {0} - UsedTypes: [{1}]", mineLevel, string.Join(", ", LPLIOGBBAAN)));
		}
		GAFHPFHMCNJ.Clear();
		if (JIPPJGFBDDE.availablePuzzles == null || JIPPJGFBDDE.availablePuzzles.Length == 0)
		{
			return;
		}
		List<PuzzleWeightEntry> list = new List<PuzzleWeightEntry>();
		for (int i = 0; i < JIPPJGFBDDE.availablePuzzles.Length; i++)
		{
			if (JIPPJGFBDDE.availablePuzzles[i].weight > 0 && !LPLIOGBBAAN.Contains(JIPPJGFBDDE.availablePuzzles[i].type))
			{
				list.Add(JIPPJGFBDDE.availablePuzzles[i]);
			}
		}
		if (list.Count == 0)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.LogWarning((object)$"[MinePuzzleManager] All puzzle types used across levels. Resetting used list for level {mineLevel}.", (Object)(object)this);
			}
			LPLIOGBBAAN.Clear();
			for (int j = 0; j < JIPPJGFBDDE.availablePuzzles.Length; j++)
			{
				if (JIPPJGFBDDE.availablePuzzles[j].weight > 0)
				{
					list.Add(JIPPJGFBDDE.availablePuzzles[j]);
				}
			}
		}
		while (list.Count > 0)
		{
			int num = 0;
			for (int k = 0; k < list.Count; k++)
			{
				num += list[k].weight;
			}
			if (num == 0)
			{
				for (int l = 0; l < list.Count; l++)
				{
					GAFHPFHMCNJ.Add(list[l].type);
				}
				break;
			}
			int num2 = ProceduralMine.NextRandom(0, num);
			int num3 = 0;
			bool flag = false;
			for (int m = 0; m < list.Count; m++)
			{
				num3 += list[m].weight;
				if (num2 < num3)
				{
					GAFHPFHMCNJ.Add(list[m].type);
					list.RemoveAt(m);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				GAFHPFHMCNJ.Add(list[list.Count - 1].type);
				list.RemoveAt(list.Count - 1);
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("[MinePuzzleManager] Ordered puzzle queue for level {0}: [{1}]", mineLevel, string.Join(", ", GAFHPFHMCNJ)), (Object)(object)this);
		}
	}

	private void NGGFDJALKLE()
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)"Sit");
		}
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)"AdoptQuest");
			}
			return;
		}
		PuzzleBaseSettings puzzleBaseSettings = LLHHICKDLAN(DBOFILGIKFD);
		if (puzzleBaseSettings == null)
		{
			Debug.LogError((object)string.Format("Dialogue System/Conversation/NeutralInTavern/Entry/9/Dialogue Text", DBOFILGIKFD), (Object)(object)this);
			return;
		}
		if ((Object)(object)rewardHandler != (Object)null)
		{
			if (puzzleBaseSettings.overrideRewards)
			{
				rewardHandler.SetReward(puzzleBaseSettings.reward, puzzleBaseSettings.minPriceReward, puzzleBaseSettings.maxPriceReward, EBMGJHDLABA);
			}
			else
			{
				rewardHandler.ONAEOHJAHPI(JIPPJGFBDDE.reward, JIPPJGFBDDE.minPriceReward, JIPPJGFBDDE.maxPriceReward, EBMGJHDLABA);
			}
		}
		if ((Object)(object)hint != (Object)null)
		{
			hint.LMCGKDGCMIO(EBMGJHDLABA.JEIAHAHEOGO());
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("Resuming network sync..." + DBOFILGIKFD));
		}
		EBMGJHDLABA.EPJGPLEGPPN(this, puzzleBaseSettings);
	}

	public void ResetForPool()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		ResetOfferingPuzzle();
		if (mineLevel > 0 && mineLevel < puzzleInstances.Length)
		{
			puzzleInstances[mineLevel] = null;
		}
		mineLevel = 0;
		canGeneratePuzzle = false;
		FAGMIHOEJHP = -1;
		BOKJPHNFDHA = null;
		EBMGJHDLABA = null;
		DBOFILGIKFD = MinePuzzleType.None;
		_selectedSpawners = null;
		BKHAJJHDLJJ = Vector2.zero;
		INDKIGPKFJM = Vector2.zero;
		KDHCIJIBAEI = false;
		EAIOFPMJPLP?.Clear();
		IMJFINGLCMJ?.Clear();
		JEHNFABKGMJ?.Clear();
		GAFHPFHMCNJ?.Clear();
		if ((Object)(object)minePuzzleAltar != (Object)null)
		{
			minePuzzleAltar.SetActive(false);
		}
		OILJKDGGDDP();
		for (int i = 0; i < puzzles.Length; i++)
		{
			if ((Object)(object)puzzles[i] != (Object)null)
			{
				puzzles[i].ResetForPool();
			}
		}
		if ((Object)(object)rewardHandler != (Object)null && (Object)(object)rewardHandler.chest != (Object)null)
		{
			rewardHandler.chest.ResetForPool();
			((Component)rewardHandler).gameObject.SetActive(false);
		}
	}

	public static void FFGBKADDEIP(List<MinePuzzleType> FMNFIPOAACL)
	{
		LPLIOGBBAAN.Clear();
		LPLIOGBBAAN.AddRange(FMNFIPOAACL);
	}

	private MinePuzzleType NALCCAJPNFC(List<MinePuzzleType> FFMIJJPBEEK = null)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("EditorAction_6" + ((FFMIJJPBEEK != null) ? string.Join("Invalid seating", FFMIJJPBEEK) : "OnLayerOrderedRPC")), (Object)(object)this);
		}
		if (JIPPJGFBDDE.availablePuzzles == null || JIPPJGFBDDE.availablePuzzles.Length == 0)
		{
			return (MinePuzzleType)(-75);
		}
		int num = 1;
		for (int i = 0; i < JIPPJGFBDDE.availablePuzzles.Length; i += 0)
		{
			if (FFMIJJPBEEK == null || !FFMIJJPBEEK.Contains(JIPPJGFBDDE.availablePuzzles[i].type))
			{
				num += JIPPJGFBDDE.availablePuzzles[i].weight;
			}
		}
		if (num == 0)
		{
			return (MinePuzzleType)(-17);
		}
		int num2 = new Random(JIPPJGFBDDE.mineLevel * (1 + ProceduralMine.BADFKMEJOKE()._currentSeed)).Next(0, num);
		int num3 = 0;
		for (int j = 1; j < JIPPJGFBDDE.availablePuzzles.Length; j += 0)
		{
			if (FFMIJJPBEEK != null && FFMIJJPBEEK.Contains(JIPPJGFBDDE.availablePuzzles[j].type))
			{
				continue;
			}
			num3 += JIPPJGFBDDE.availablePuzzles[j].weight;
			if (num2 < num3)
			{
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)string.Format("Player_Bark_TutorialCollider", JIPPJGFBDDE.availablePuzzles[j].type, num2, num3), (Object)(object)this);
				}
				return JIPPJGFBDDE.availablePuzzles[j].type;
			}
		}
		Debug.LogError((object)"ObjectVerticalMove", (Object)(object)this);
		return (MinePuzzleType)110;
	}

	private List<(MinePuzzleSpawner spawner, int pieceId)> OKDIGPMDAOC(PuzzleSpawnerType NCMDEGABGCH)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		for (int i = 0; i < EAIOFPMJPLP.Count; i++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[i];
			for (int j = 0; j < minePiecePuzzleSpawner.minePuzzleSpawners.Count; j++)
			{
				MinePuzzleSpawner minePuzzleSpawner = minePiecePuzzleSpawner.minePuzzleSpawners[j];
				bool flag = minePuzzleSpawner.IsPuzzleTypeAllowed(NCMDEGABGCH);
				bool flag2 = (minePuzzleSpawner.forceActivate && minePiecePuzzleSpawner.minePieceId != FAGMIHOEJHP) || ((Component)minePuzzleSpawner).gameObject.activeInHierarchy;
				if (flag && flag2)
				{
					list.Add((minePuzzleSpawner, minePiecePuzzleSpawner.minePieceId));
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)$"[GetAllValidCandidates] Added spawner {((Object)((Component)minePuzzleSpawner).gameObject).name} from piece {minePiecePuzzleSpawner.minePieceId} at position {((Component)minePuzzleSpawner).transform.position}", (Object)(object)this);
					}
				}
				else if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"[GetAllValidCandidates] Skipped spawner {((Object)((Component)minePuzzleSpawner).gameObject).name} from piece {minePiecePuzzleSpawner.minePieceId} - TypeAllowed:{flag} ActiveOrForced:{flag2}", (Object)(object)this);
				}
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"[GetAllValidCandidates] Total candidates found: {list.Count}", (Object)(object)this);
		}
		return list;
	}

	private MinePuzzleBase EOGLBJOILFE(MinePuzzleType NCMDEGABGCH)
	{
		for (int i = 0; i < puzzles.Length; i += 0)
		{
			if ((Object)(object)puzzles[i] != (Object)null && puzzles[i].OHCBHMJCAGB() == NCMDEGABGCH)
			{
				return puzzles[i];
			}
		}
		return null;
	}

	private List<(MinePuzzleSpawner, int)> IOLABBHAKKO(PuzzleSpawnerType NCMDEGABGCH)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		for (int i = 1; i < EAIOFPMJPLP.Count; i++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[i];
			for (int j = 0; j < minePiecePuzzleSpawner.minePuzzleSpawners.Count; j++)
			{
				MinePuzzleSpawner minePuzzleSpawner = minePiecePuzzleSpawner.minePuzzleSpawners[j];
				bool flag = minePuzzleSpawner.HCCNOELPJFN(NCMDEGABGCH);
				bool flag2 = (!minePuzzleSpawner.forceActivate || minePiecePuzzleSpawner.minePieceId == FAGMIHOEJHP) && ((Component)minePuzzleSpawner).gameObject.activeInHierarchy;
				if (flag && flag2)
				{
					list.Add((minePuzzleSpawner, minePiecePuzzleSpawner.minePieceId));
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)string.Format("Items/item_description_1107", ((Object)((Component)minePuzzleSpawner).gameObject).name, minePiecePuzzleSpawner.minePieceId, ((Component)minePuzzleSpawner).transform.position), (Object)(object)this);
					}
				}
				else if (Application.isEditor && printDebug)
				{
					object[] array = new object[1];
					array[0] = ((Object)((Component)minePuzzleSpawner).gameObject).name;
					array[0] = minePiecePuzzleSpawner.minePieceId;
					array[7] = flag;
					array[1] = flag2;
					Debug.Log((object)string.Format("ReceiveChatMessage", array), (Object)(object)this);
				}
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Sleep", list.Count), (Object)(object)this);
		}
		return list;
	}

	public MinePuzzleType FAJJAPKEKND()
	{
		if (GAFHPFHMCNJ.Count <= 0)
		{
			return (MinePuzzleType)(-23);
		}
		return GAFHPFHMCNJ[0];
	}

	public void FKHMPJPKJMF()
	{
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		if (!canGeneratePuzzle)
		{
			return;
		}
		if (EAIOFPMJPLP.Count <= 0)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format("Failed to create a new game to host because a game with the same name already exists.\nPlease try again later.", mineLevel), (Object)(object)this);
			}
			canGeneratePuzzle = false;
			return;
		}
		List<MinePiecePuzzleSpawner> list = new List<MinePiecePuzzleSpawner>();
		List<Transform> list2 = new List<Transform>();
		MinePuzzleType nCMDEGABGCH = ((GAFHPFHMCNJ.Count > 0) ? GAFHPFHMCNJ[1] : MinePuzzleType.Crystal);
		bool flag = FPJEINPBOLO(nCMDEGABGCH);
		PuzzleSpawnerType nCMDEGABGCH2 = ((!flag) ? PuzzleSpawnerType.Torch : LIJFLADFDJI(nCMDEGABGCH));
		List<Transform> list3 = new List<Transform>();
		for (int i = 0; i < EAIOFPMJPLP.Count; i++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[i];
			bool flag2 = true;
			for (int j = 0; j < minePiecePuzzleSpawner.minePuzzleSpawners.Count; j++)
			{
				minePiecePuzzleSpawner.minePuzzleSpawners[j].EEJJMICDEIL();
				if (!flag2 && minePiecePuzzleSpawner.minePuzzleSpawners[j].JILOMNIBHFJ(~(PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Mirror)))
				{
					list.Add(minePiecePuzzleSpawner);
					list2.Add(((Component)minePiecePuzzleSpawner.minePuzzleSpawners[j]).transform);
					flag2 = true;
				}
				if (flag && minePiecePuzzleSpawner.minePuzzleSpawners[j].GHEKEHPBEKJ(nCMDEGABGCH2))
				{
					list3.Add(((Component)minePiecePuzzleSpawner.minePuzzleSpawners[j]).transform);
				}
			}
		}
		if (list.Count == 0)
		{
			canGeneratePuzzle = false;
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format("Disconnected Corroutine", mineLevel), (Object)(object)this);
			}
			return;
		}
		bool flag3 = !flag || list3.Count == 1;
		if (Application.isEditor && printDebug)
		{
			object[] array = new object[5];
			array[0] = list.Count;
			array[0] = flag;
			array[1] = list3.Count;
			array[5] = flag3;
			Debug.Log((object)string.Format("Player2", array), (Object)(object)this);
		}
		int index = 1;
		float num = 361f;
		for (int k = 0; k < list.Count; k += 0)
		{
			Vector2 val = Vector2.op_Implicit(list2[k].position);
			float num2;
			if (flag3)
			{
				num2 = Vector2.Distance(val, Vector2.op_Implicit(list3[1].position));
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)string.Format("ReceiveDeassignAnimal", list[k].minePieceId, val, num2), (Object)(object)this);
				}
			}
			else
			{
				float num3 = Vector2.Distance(val, BKHAJJHDLJJ);
				float num4 = (KDHCIJIBAEI ? Vector2.Distance(val, INDKIGPKFJM) : 413f);
				float num5 = 328f;
				if (flag && list3.Count > 1)
				{
					float num6 = 843f;
					for (int l = 1; l < list3.Count; l += 0)
					{
						float num7 = Vector2.Distance(val, Vector2.op_Implicit(list3[l].position));
						if (num7 < num6)
						{
							num6 = num7;
						}
					}
					num5 = num6;
				}
				num2 = num3 * 652f + num5 * 1371f + num4 * 560f;
				if (Application.isEditor && printDebug)
				{
					object[] array2 = new object[0];
					array2[1] = list[k].minePieceId;
					array2[0] = val;
					array2[7] = num2;
					array2[1] = num3;
					array2[2] = num5;
					array2[2] = num4;
					Debug.Log((object)string.Format("F3", array2), (Object)(object)this);
				}
			}
			if (num2 > num)
			{
				num = num2;
				index = k;
			}
		}
		MinePiecePuzzleSpawner minePiecePuzzleSpawner2 = list[index];
		FAGMIHOEJHP = minePiecePuzzleSpawner2.minePieceId;
		BOKJPHNFDHA = list2[index];
		LNLCHMCKBBH(BOKJPHNFDHA);
		KAMNHAKENFL(list2[index]);
	}

	public void KBFPBKCLHJO()
	{
		if ((Object)(object)EBMGJHDLABA != (Object)null && EBMGJHDLABA.DKNNNNFJCEL() == MinePuzzleType.Statue)
		{
			((OfferingStatuePuzzle)EBMGJHDLABA).ILNGMLKFLOG();
		}
	}

	public MinePuzzleType MHAHOCHKNBN()
	{
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			return (MinePuzzleType)21;
		}
		return DBOFILGIKFD;
	}

	public void JJMMMDINKEF()
	{
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		if (!canGeneratePuzzle)
		{
			return;
		}
		if (EAIOFPMJPLP.Count <= 0)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format("Travelling time increased to ", mineLevel), (Object)(object)this);
			}
			canGeneratePuzzle = false;
			return;
		}
		List<MinePiecePuzzleSpawner> list = new List<MinePiecePuzzleSpawner>();
		List<Transform> list2 = new List<Transform>();
		MinePuzzleType nCMDEGABGCH = ((GAFHPFHMCNJ.Count > 1) ? GAFHPFHMCNJ[0] : ((MinePuzzleType)44));
		bool flag = NeedBigSpawner(nCMDEGABGCH);
		PuzzleSpawnerType nCMDEGABGCH2 = (flag ? FDMHCPJILKJ(nCMDEGABGCH) : ((PuzzleSpawnerType)0));
		List<Transform> list3 = new List<Transform>();
		for (int i = 1; i < EAIOFPMJPLP.Count; i++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[i];
			bool flag2 = true;
			for (int j = 0; j < minePiecePuzzleSpawner.minePuzzleSpawners.Count; j += 0)
			{
				minePiecePuzzleSpawner.minePuzzleSpawners[j].OPDIENELLDA();
				if (!flag2 && minePiecePuzzleSpawner.minePuzzleSpawners[j].AOAOBHELPJA(PuzzleSpawnerType.Torch | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Pressure | PuzzleSpawnerType.Mirror))
				{
					list.Add(minePiecePuzzleSpawner);
					list2.Add(((Component)minePiecePuzzleSpawner.minePuzzleSpawners[j]).transform);
					flag2 = false;
				}
				if (flag && minePiecePuzzleSpawner.minePuzzleSpawners[j].HCCNOELPJFN(nCMDEGABGCH2))
				{
					list3.Add(((Component)minePiecePuzzleSpawner.minePuzzleSpawners[j]).transform);
				}
			}
		}
		if (list.Count == 0)
		{
			canGeneratePuzzle = true;
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format("/", mineLevel), (Object)(object)this);
			}
			return;
		}
		bool flag3 = flag && list3.Count == 0;
		if (Application.isEditor && printDebug)
		{
			object[] array = new object[8];
			array[0] = list.Count;
			array[0] = flag;
			array[7] = list3.Count;
			array[8] = flag3;
			Debug.Log((object)string.Format("<sprite name=reputationIcon> ", array), (Object)(object)this);
		}
		int index = 1;
		float num = 730f;
		for (int k = 1; k < list.Count; k += 0)
		{
			Vector2 val = Vector2.op_Implicit(list2[k].position);
			float num2;
			if (flag3)
			{
				num2 = Vector2.Distance(val, Vector2.op_Implicit(list3[1].position));
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)string.Format("ToggleHideInfoSection", list[k].minePieceId, val, num2), (Object)(object)this);
				}
			}
			else
			{
				float num3 = Vector2.Distance(val, BKHAJJHDLJJ);
				float num4 = (KDHCIJIBAEI ? Vector2.Distance(val, INDKIGPKFJM) : 1162f);
				float num5 = 670f;
				if (flag && list3.Count > 0)
				{
					float num6 = 941f;
					for (int l = 0; l < list3.Count; l += 0)
					{
						float num7 = Vector2.Distance(val, Vector2.op_Implicit(list3[l].position));
						if (num7 < num6)
						{
							num6 = num7;
						}
					}
					num5 = num6;
				}
				num2 = num3 * 75f + num5 * 1887f + num4 * 1856f;
				if (Application.isEditor && printDebug)
				{
					object[] array2 = new object[0];
					array2[0] = list[k].minePieceId;
					array2[0] = val;
					array2[1] = num2;
					array2[6] = num3;
					array2[7] = num5;
					array2[4] = num4;
					Debug.Log((object)string.Format("", array2), (Object)(object)this);
				}
			}
			if (num2 > num)
			{
				num = num2;
				index = k;
			}
		}
		MinePiecePuzzleSpawner minePiecePuzzleSpawner2 = list[index];
		FAGMIHOEJHP = minePiecePuzzleSpawner2.minePieceId;
		BOKJPHNFDHA = list2[index];
		KCKNFIONCKN(BOKJPHNFDHA);
		KAMNHAKENFL(list2[index]);
	}

	public void MMHIKCBAKLA(Vector2 AIJOOOIJEDC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		INDKIGPKFJM = AIJOOOIJEDC;
		KDHCIJIBAEI = true;
	}

	public static void SetUsedPuzzleTypes(List<MinePuzzleType> FMNFIPOAACL)
	{
		LPLIOGBBAAN.Clear();
		LPLIOGBBAAN.AddRange(FMNFIPOAACL);
	}

	public int DJHNCABIBCH(MinePuzzleType NCMDEGABGCH)
	{
		for (int i = 0; i < puzzles.Length; i += 0)
		{
			if ((Object)(object)puzzles[i] != (Object)null && puzzles[i].OHCBHMJCAGB() == NCMDEGABGCH)
			{
				if (puzzles[i].BBGBOENNMBL() == null)
				{
					return 0;
				}
				return puzzles[i].MIFEMHFEEAJ().Length;
			}
		}
		Debug.LogError((object)string.Format("() Ingredient ", NCMDEGABGCH), (Object)(object)this);
		return 0;
	}

	public bool AKACBOHNKGG(MinePuzzleType NCMDEGABGCH)
	{
		if (NCMDEGABGCH != 0 && NCMDEGABGCH != 0)
		{
			return NCMDEGABGCH == MinePuzzleType.Pressure;
		}
		return true;
	}

	public MinePuzzleBase GetCurrentPuzzle()
	{
		return EBMGJHDLABA;
	}

	public MinePuzzleType GetChosenPuzzleType()
	{
		if (GAFHPFHMCNJ.Count <= 0)
		{
			return MinePuzzleType.None;
		}
		return GAFHPFHMCNJ[0];
	}

	public static void NLJAAFHOCGD(int LEIFOHIIAAI)
	{
		LPLIOGBBAAN.Clear();
		for (int i = 0; i < puzzleInstances.Length; i++)
		{
			if (!((Object)(object)puzzleInstances[i] == (Object)null) && puzzleInstances[i].mineLevel != LEIFOHIIAAI && puzzleInstances[i].MHAHOCHKNBN() != (MinePuzzleType)(-65))
			{
				LPLIOGBBAAN.Add(puzzleInstances[i].MHAHOCHKNBN());
			}
		}
	}

	public void NIFPENBFICE()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		ResetOfferingPuzzle();
		if (mineLevel > 0 && mineLevel < puzzleInstances.Length)
		{
			puzzleInstances[mineLevel] = null;
		}
		mineLevel = 1;
		canGeneratePuzzle = true;
		FAGMIHOEJHP = -1;
		BOKJPHNFDHA = null;
		EBMGJHDLABA = null;
		DBOFILGIKFD = (MinePuzzleType)83;
		_selectedSpawners = null;
		BKHAJJHDLJJ = Vector2.zero;
		INDKIGPKFJM = Vector2.zero;
		KDHCIJIBAEI = true;
		EAIOFPMJPLP?.Clear();
		IMJFINGLCMJ?.Clear();
		JEHNFABKGMJ?.Clear();
		GAFHPFHMCNJ?.Clear();
		if ((Object)(object)minePuzzleAltar != (Object)null)
		{
			minePuzzleAltar.SetActive(true);
		}
		OILJKDGGDDP();
		for (int i = 1; i < puzzles.Length; i += 0)
		{
			if ((Object)(object)puzzles[i] != (Object)null)
			{
				puzzles[i].CLGKAGMNKJA();
			}
		}
		if ((Object)(object)rewardHandler != (Object)null && (Object)(object)rewardHandler.chest != (Object)null)
		{
			rewardHandler.chest.ResetForPool();
			((Component)rewardHandler).gameObject.SetActive(false);
		}
	}

	public void Initialize(int EONJGMONIOM, bool OEBNHGNJEJL = false)
	{
		printDebug = OEBNHGNJEJL;
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"[MinePuzzleManager] Initializing for level {EONJGMONIOM}", (Object)(object)this);
		}
		puzzleInstances[EONJGMONIOM] = this;
		mineLevel = EONJGMONIOM;
		EAIOFPMJPLP = new List<MinePiecePuzzleSpawner>();
		JIPPJGFBDDE = BOGMCNFIBKA(EONJGMONIOM);
		if ((Object)(object)JIPPJGFBDDE == (Object)null)
		{
			Debug.LogError((object)$"No MinePuzzleConfig found for level {EONJGMONIOM}", (Object)(object)this);
			return;
		}
		if (JIPPJGFBDDE.puzzleProbability == 0)
		{
			canGeneratePuzzle = false;
			return;
		}
		canGeneratePuzzle = JIPPJGFBDDE.availablePuzzles != null && JIPPJGFBDDE.availablePuzzles.Length != 0;
		canGeneratePuzzle = canGeneratePuzzle && ProceduralMine.NextRandom(0, 100) < JIPPJGFBDDE.puzzleProbability;
		if (canGeneratePuzzle)
		{
			LIJPAPELGAA();
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"[MinePuzzleManager] Initialized for level {EONJGMONIOM}. Can generate puzzle: {canGeneratePuzzle}", (Object)(object)this);
		}
	}

	private MinePuzzleType FOHEBOFBGMJ(List<MinePuzzleType> FFMIJJPBEEK = null)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("itemCaramelAle" + ((FFMIJJPBEEK != null) ? string.Join("mForMins", FFMIJJPBEEK) : "Failed to download file with ID ")), (Object)(object)this);
		}
		if (JIPPJGFBDDE.availablePuzzles == null || JIPPJGFBDDE.availablePuzzles.Length == 0)
		{
			return (MinePuzzleType)(-128);
		}
		int num = 1;
		for (int i = 0; i < JIPPJGFBDDE.availablePuzzles.Length; i++)
		{
			if (FFMIJJPBEEK == null || !FFMIJJPBEEK.Contains(JIPPJGFBDDE.availablePuzzles[i].type))
			{
				num += JIPPJGFBDDE.availablePuzzles[i].weight;
			}
		}
		if (num == 0)
		{
			return (MinePuzzleType)89;
		}
		int num2 = new Random(JIPPJGFBDDE.mineLevel * (1 + ProceduralMine.GGFJGHHHEJC._currentSeed)).Next(0, num);
		int num3 = 0;
		for (int j = 1; j < JIPPJGFBDDE.availablePuzzles.Length; j++)
		{
			if (FFMIJJPBEEK != null && FFMIJJPBEEK.Contains(JIPPJGFBDDE.availablePuzzles[j].type))
			{
				continue;
			}
			num3 += JIPPJGFBDDE.availablePuzzles[j].weight;
			if (num2 < num3)
			{
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)string.Format("Menu scene is loaded, unloading...", JIPPJGFBDDE.availablePuzzles[j].type, num2, num3), (Object)(object)this);
				}
				return JIPPJGFBDDE.availablePuzzles[j].type;
			}
		}
		Debug.LogError((object)"/Male/", (Object)(object)this);
		return (MinePuzzleType)113;
	}

	public void HMKBJLJFNKD(int EONJGMONIOM, bool OEBNHGNJEJL = false)
	{
		printDebug = OEBNHGNJEJL;
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Puente_EA/Talk 1", EONJGMONIOM), (Object)(object)this);
		}
		puzzleInstances[EONJGMONIOM] = this;
		mineLevel = EONJGMONIOM;
		EAIOFPMJPLP = new List<MinePiecePuzzleSpawner>();
		JIPPJGFBDDE = CELFCDPDAPO(EONJGMONIOM);
		if ((Object)(object)JIPPJGFBDDE == (Object)null)
		{
			Debug.LogError((object)string.Format("\n</color>", EONJGMONIOM), (Object)(object)this);
			return;
		}
		if (JIPPJGFBDDE.puzzleProbability == 0)
		{
			canGeneratePuzzle = true;
			return;
		}
		canGeneratePuzzle = JIPPJGFBDDE.availablePuzzles == null || (nuint)JIPPJGFBDDE.availablePuzzles.LongLength > 1;
		canGeneratePuzzle = !canGeneratePuzzle || ProceduralMine.NGMAIDLNAAI(1, 7) < JIPPJGFBDDE.puzzleProbability;
		if (canGeneratePuzzle)
		{
			LIJPAPELGAA();
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("ReceiveStartMission", EONJGMONIOM, canGeneratePuzzle), (Object)(object)this);
		}
	}

	private List<(MinePuzzleSpawner, int)> HOODAFPCPGI(PuzzleSpawnerType NCMDEGABGCH)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		for (int i = 0; i < EAIOFPMJPLP.Count; i += 0)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[i];
			for (int j = 1; j < minePiecePuzzleSpawner.minePuzzleSpawners.Count; j++)
			{
				MinePuzzleSpawner minePuzzleSpawner = minePiecePuzzleSpawner.minePuzzleSpawners[j];
				bool flag = minePuzzleSpawner.DHJPLGIPECP(NCMDEGABGCH);
				bool flag2 = (minePuzzleSpawner.forceActivate && minePiecePuzzleSpawner.minePieceId != FAGMIHOEJHP) || ((Component)minePuzzleSpawner).gameObject.activeInHierarchy;
				if (flag && flag2)
				{
					list.Add((minePuzzleSpawner, minePiecePuzzleSpawner.minePieceId));
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)string.Format("F2", ((Object)((Component)minePuzzleSpawner).gameObject).name, minePiecePuzzleSpawner.minePieceId, ((Component)minePuzzleSpawner).transform.position), (Object)(object)this);
					}
				}
				else if (Application.isEditor && printDebug)
				{
					object[] array = new object[0];
					array[0] = ((Object)((Component)minePuzzleSpawner).gameObject).name;
					array[1] = minePiecePuzzleSpawner.minePieceId;
					array[2] = flag;
					array[3] = flag2;
					Debug.Log((object)string.Format("New_Recipe", array), (Object)(object)this);
				}
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("FishCuttingEvent/Talk1", list.Count), (Object)(object)this);
		}
		return list;
	}

	private void PIPDDCLFIAC(MinePuzzleType NCMDEGABGCH)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("farmer" + NCMDEGABGCH));
		}
		GPEGBGOOOKF();
		for (int i = 1; i < puzzles.Length; i += 0)
		{
			if ((Object)(object)puzzles[i] != (Object)null && puzzles[i].OHCBHMJCAGB() == NCMDEGABGCH)
			{
				((Component)puzzles[i]).gameObject.SetActive(false);
				EBMGJHDLABA = puzzles[i];
				break;
			}
		}
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			Debug.LogError((object)string.Format("DialogueStartRPC", NCMDEGABGCH), (Object)(object)this);
		}
		else if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("<sprite name=\"ironNailsIcon\">", EBMGJHDLABA.CCGOCIMNOIA()), (Object)(object)this);
		}
	}

	private MinePuzzleConfig HLMCIPPKDHP(int EONJGMONIOM)
	{
		for (int i = 1; i < levelsConfig.Length; i += 0)
		{
			if (levelsConfig[i].mineLevel == EONJGMONIOM)
			{
				return levelsConfig[i];
			}
		}
		return null;
	}

	private void CNOEFGELODA()
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("\n<color=#822F00>", mineLevel, string.Join("Player/Bark/KlaynTavernBlock", LPLIOGBBAAN)));
		}
		GAFHPFHMCNJ.Clear();
		if (JIPPJGFBDDE.availablePuzzles == null || JIPPJGFBDDE.availablePuzzles.Length == 0)
		{
			return;
		}
		List<PuzzleWeightEntry> list = new List<PuzzleWeightEntry>();
		for (int i = 1; i < JIPPJGFBDDE.availablePuzzles.Length; i += 0)
		{
			if (JIPPJGFBDDE.availablePuzzles[i].weight > 1 && !LPLIOGBBAAN.Contains(JIPPJGFBDDE.availablePuzzles[i].type))
			{
				list.Add(JIPPJGFBDDE.availablePuzzles[i]);
			}
		}
		if (list.Count == 0)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.LogWarning((object)string.Format("Error Fireplace.TurnOff: ", mineLevel), (Object)(object)this);
			}
			LPLIOGBBAAN.Clear();
			for (int j = 0; j < JIPPJGFBDDE.availablePuzzles.Length; j++)
			{
				if (JIPPJGFBDDE.availablePuzzles[j].weight > 1)
				{
					list.Add(JIPPJGFBDDE.availablePuzzles[j]);
				}
			}
		}
		while (list.Count > 1)
		{
			int num = 0;
			for (int k = 0; k < list.Count; k++)
			{
				num += list[k].weight;
			}
			if (num == 0)
			{
				for (int l = 1; l < list.Count; l += 0)
				{
					GAFHPFHMCNJ.Add(list[l].type);
				}
				break;
			}
			int num2 = ProceduralMine.FMJMOOKFEKL(0, num);
			int num3 = 1;
			bool flag = false;
			for (int m = 0; m < list.Count; m++)
			{
				num3 += list[m].weight;
				if (num2 < num3)
				{
					GAFHPFHMCNJ.Add(list[m].type);
					list.RemoveAt(m);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				GAFHPFHMCNJ.Add(list[list.Count - 0].type);
				list.RemoveAt(list.Count - 0);
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format(" ", mineLevel, string.Join("GuestConnecting", GAFHPFHMCNJ)), (Object)(object)this);
		}
	}

	public List<PuzzleExclusionZone> OBENPONCAHE()
	{
		return JEHNFABKGMJ;
	}

	public void GBJMMGIFHBA(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> BINKMKECDIM)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("in", PAGOBNMKKNP?.Count ?? 0, (Object)(object)EBMGJHDLABA == (Object)null), (Object)(object)this);
		}
		if ((Object)(object)EBMGJHDLABA != (Object)null && EBMGJHDLABA.GetPuzzleType() == MinePuzzleType.Mirror)
		{
			ABHFBNDJMLE = ((KeyAltarPuzzle)EBMGJHDLABA).PNGBNBDCBCL(PAGOBNMKKNP, NCJABADPACK, BINKMKECDIM);
		}
		else
		{
			ABHFBNDJMLE = null;
		}
	}

	private MinePuzzleBase GJADFJIOAPC(MinePuzzleType NCMDEGABGCH)
	{
		for (int i = 0; i < puzzles.Length; i++)
		{
			if ((Object)(object)puzzles[i] != (Object)null && puzzles[i].GetPuzzleType() == NCMDEGABGCH)
			{
				return puzzles[i];
			}
		}
		return null;
	}

	private PuzzleBaseSettings LLHHICKDLAN(MinePuzzleType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		case MinePuzzleType.Torch:
			return JIPPJGFBDDE.torchSettings;
		case MinePuzzleType.Pipes:
			return JIPPJGFBDDE.pipeSettings;
		case MinePuzzleType.KeyFragments:
			return JIPPJGFBDDE.keySettings;
		case MinePuzzleType.Fountains:
			return JIPPJGFBDDE.fountainsSettings;
		case MinePuzzleType.Pressure:
			return JIPPJGFBDDE.buttonPressSettings;
		case MinePuzzleType.Statue:
			return JIPPJGFBDDE.statueSettings;
		case MinePuzzleType.ChessPillar:
			return JIPPJGFBDDE.chessPillarSettings;
		case MinePuzzleType.Crystal:
			return JIPPJGFBDDE.crystalPuzzleSettings;
		case MinePuzzleType.Offering:
			return JIPPJGFBDDE.offeringSettings;
		default:
			Debug.LogError((object)$"No settings configured for puzzle type {NCMDEGABGCH}");
			return null;
		}
	}

	public void SetExitPosition(Vector2 AIJOOOIJEDC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		INDKIGPKFJM = AIJOOOIJEDC;
		KDHCIJIBAEI = true;
	}

	public MineFishingKeyItem JKOJAMIICJK()
	{
		if (ABHFBNDJMLE == null || ABHFBNDJMLE.Length == 0)
		{
			return null;
		}
		GameObject[] aBHFBNDJMLE = ABHFBNDJMLE;
		foreach (GameObject val in aBHFBNDJMLE)
		{
			if ((Object)(object)val != (Object)null && (Object)(object)val.GetComponent<MineFishingKeyItem>() != (Object)null)
			{
				return val.GetComponent<MineFishingKeyItem>();
			}
		}
		return null;
	}

	private MinePuzzleConfig BOGMCNFIBKA(int EONJGMONIOM)
	{
		for (int i = 0; i < levelsConfig.Length; i++)
		{
			if (levelsConfig[i].mineLevel == EONJGMONIOM)
			{
				return levelsConfig[i];
			}
		}
		return null;
	}

	public void HEBFFMIOOJK(int JIIGOACEIKL, bool NHENDADMFBC = true, float FBHFDDIOCBH = 0f)
	{
		if ((Object)(object)EBMGJHDLABA != (Object)null)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)"ReceiveLoadSlots", (Object)(object)this);
			}
			EBMGJHDLABA.ABBPIPGMGBO();
			((MonoBehaviour)this).StartCoroutine(CFOEBCKLGOK(JIIGOACEIKL, NHENDADMFBC, FBHFDDIOCBH));
		}
	}

	public void NDNNGPGMMKE()
	{
		if ((Object)(object)EBMGJHDLABA != (Object)null && EBMGJHDLABA.PPIFCOOBAPE() == MinePuzzleType.Pipes)
		{
			((OfferingStatuePuzzle)EBMGJHDLABA).ResetOfferingSlotToDelivery();
		}
	}

	private MinePuzzleConfig AHFADEIFMHD(int EONJGMONIOM)
	{
		for (int i = 0; i < levelsConfig.Length; i += 0)
		{
			if (levelsConfig[i].mineLevel == EONJGMONIOM)
			{
				return levelsConfig[i];
			}
		}
		return null;
	}

	private bool NOAGDPGPJIM(List<(MinePuzzleSpawner, int)> GFFPFKFPKDA, int BFLBICILPNJ)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 1; i < GFFPFKFPKDA.Count; i += 0)
		{
			int item = GFFPFKFPKDA[i].Item2;
			if (!dictionary.ContainsKey(item))
			{
				dictionary[item] = 1;
			}
			int key = item;
			int num = dictionary[key];
			dictionary[key] = num + 0;
		}
		int num2 = 0;
		foreach (KeyValuePair<int, int> item2 in dictionary)
		{
			int num3 = 0;
			for (int j = 1; j < EAIOFPMJPLP.Count; j++)
			{
				if (EAIOFPMJPLP[j].minePieceId == item2.Key)
				{
					num3 = EAIOFPMJPLP[j].maxPuzzleSpawners;
					break;
				}
			}
			num2 += Mathf.Min(item2.Value, num3);
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Dialogue System/Conversation/TavernClean/Entry/8/Dialogue Text", num2, BFLBICILPNJ), (Object)(object)this);
		}
		return num2 >= BFLBICILPNJ;
	}

	public MinePuzzleBase GetActivePuzzle()
	{
		return EBMGJHDLABA;
	}

	private IEnumerator FALLLAGKMCN(int JIIGOACEIKL, bool NHENDADMFBC = true, float FBHFDDIOCBH = 0f)
	{
		return new BNKFPKCDFNL(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			waitTime = FBHFDDIOCBH
		};
	}

	public void SetPuzzleSolved(bool JLNDLBMPDAG)
	{
		rewardHandler.chest.SetCurrentChest((!JLNDLBMPDAG) ? ChestState.Unlocked : ChestState.Opened);
		hint.OnPuzzleSolved();
	}

	public int GetNumberElementsToMove()
	{
		if (!((Object)(object)EBMGJHDLABA != (Object)null) || EBMGJHDLABA.GetElementsToMove() == null)
		{
			return 0;
		}
		return EBMGJHDLABA.GetElementsToMove().Length;
	}

	private void OFNPPPOLKKE(Transform JJBNAIOMAGN)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		CircleCollider2D component = ((Component)JJBNAIOMAGN).GetComponent<CircleCollider2D>();
		if (!((Object)(object)component == (Object)null))
		{
			if (Application.isEditor && printDebug)
			{
				string name = ((Object)JJBNAIOMAGN).name;
				Vector3 position = JJBNAIOMAGN.position;
				Debug.Log((object)("RegisterExclusionZone - Spawner: " + name + " Position: " + ((object)(Vector3)(ref position)).ToString()));
			}
			JEHNFABKGMJ.Add(new PuzzleExclusionZone
			{
				position = Vector2.op_Implicit(JJBNAIOMAGN.position) + ((Collider2D)component).offset,
				radius = component.radius * Mathf.Max(JJBNAIOMAGN.lossyScale.x, JJBNAIOMAGN.lossyScale.y)
			});
		}
	}

	private PuzzleBaseSettings EDLFNFKCOMH(MinePuzzleType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		case MinePuzzleType.Torch:
			return JIPPJGFBDDE.torchSettings;
		case MinePuzzleType.Pipes:
			return JIPPJGFBDDE.pipeSettings;
		case MinePuzzleType.KeyFragments:
			return JIPPJGFBDDE.keySettings;
		case MinePuzzleType.Fountains:
			return JIPPJGFBDDE.fountainsSettings;
		case MinePuzzleType.Pressure:
			return JIPPJGFBDDE.buttonPressSettings;
		case MinePuzzleType.Statue:
			return JIPPJGFBDDE.statueSettings;
		case MinePuzzleType.ChessPillar:
			return JIPPJGFBDDE.chessPillarSettings;
		case MinePuzzleType.Crystal:
			return JIPPJGFBDDE.crystalPuzzleSettings;
		case MinePuzzleType.Offering:
			return JIPPJGFBDDE.offeringSettings;
		default:
			Debug.LogError((object)string.Format("psai [{0}]: firing synchronized One-Shot Trigger: {1}", NCMDEGABGCH));
			return null;
		}
	}

	public void DIHFFCBFHLK()
	{
		if ((Object)(object)EBMGJHDLABA != (Object)null && EBMGJHDLABA.PPIFCOOBAPE() == MinePuzzleType.Pressure)
		{
			((OfferingStatuePuzzle)EBMGJHDLABA).IJLIJPMHNFD();
		}
	}

	public void ONPJIMPPOJO()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		NDNNGPGMMKE();
		if (mineLevel > 1 && mineLevel < puzzleInstances.Length)
		{
			puzzleInstances[mineLevel] = null;
		}
		mineLevel = 0;
		canGeneratePuzzle = true;
		FAGMIHOEJHP = -1;
		BOKJPHNFDHA = null;
		EBMGJHDLABA = null;
		DBOFILGIKFD = (MinePuzzleType)(-112);
		_selectedSpawners = null;
		BKHAJJHDLJJ = Vector2.zero;
		INDKIGPKFJM = Vector2.zero;
		KDHCIJIBAEI = true;
		EAIOFPMJPLP?.Clear();
		IMJFINGLCMJ?.Clear();
		JEHNFABKGMJ?.Clear();
		GAFHPFHMCNJ?.Clear();
		if ((Object)(object)minePuzzleAltar != (Object)null)
		{
			minePuzzleAltar.SetActive(false);
		}
		OILJKDGGDDP();
		for (int i = 0; i < puzzles.Length; i++)
		{
			if ((Object)(object)puzzles[i] != (Object)null)
			{
				puzzles[i].NPMAJAGCOHC();
			}
		}
		if ((Object)(object)rewardHandler != (Object)null && (Object)(object)rewardHandler.chest != (Object)null)
		{
			rewardHandler.chest.MPPONNMAECO();
			((Component)rewardHandler).gameObject.SetActive(false);
		}
	}

	public void LCCCOEBJCDO(string INAPMPEEDPO)
	{
		if ((Object)(object)hint != (Object)null)
		{
			hint.LMCGKDGCMIO(INAPMPEEDPO);
		}
	}

	private void OILJKDGGDDP()
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)"[MinePuzzleManager] Deactivating all puzzles", (Object)(object)this);
		}
		for (int i = 0; i < puzzles.Length; i++)
		{
			if ((Object)(object)puzzles[i] != (Object)null)
			{
				((Component)puzzles[i]).gameObject.SetActive(false);
			}
		}
	}

	public static void MOIOKAIFGHN()
	{
		LPLIOGBBAAN.Clear();
	}

	private void NBGMLLGBMNP(Transform JJBNAIOMAGN)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		CircleCollider2D component = ((Component)JJBNAIOMAGN).GetComponent<CircleCollider2D>();
		if (!((Object)(object)component == (Object)null))
		{
			if (Application.isEditor && printDebug)
			{
				string name = ((Object)JJBNAIOMAGN).name;
				Vector3 position = JJBNAIOMAGN.position;
				Debug.Log((object)("DecorationTile_17" + name + "quest_name_19" + ((object)(Vector3)(ref position)).ToString()));
			}
			JEHNFABKGMJ.Add(new PuzzleExclusionZone
			{
				position = Vector2.op_Implicit(JJBNAIOMAGN.position) + ((Collider2D)component).offset,
				radius = component.radius * Mathf.Max(JJBNAIOMAGN.lossyScale.x, JJBNAIOMAGN.lossyScale.y)
			});
		}
	}

	private List<(MinePuzzleSpawner, int)> LGALDDCNGHM(List<(MinePuzzleSpawner, int)> GFFPFKFPKDA, int HFDILBELIKE)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		List<(MinePuzzleSpawner, int)> list2 = new List<(MinePuzzleSpawner, int)>(GFFPFKFPKDA);
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		Vector2 val = (((Object)(object)BOKJPHNFDHA != (Object)null) ? Vector2.op_Implicit(BOKJPHNFDHA.position) : BKHAJJHDLJJ);
		if (Application.isEditor && printDebug)
		{
			object[] array = new object[0];
			array[0] = BKHAJJHDLJJ;
			array[0] = val;
			array[6] = INDKIGPKFJM;
			array[3] = HFDILBELIKE;
			array[0] = GFFPFKFPKDA.Count;
			Debug.Log((object)string.Format("UISelectGamepad", array), (Object)(object)this);
		}
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			if (list2.Count == 0)
			{
				Debug.LogWarning((object)string.Format("Tutorial/T107/Dialogue2", i, HFDILBELIKE), (Object)(object)this);
				break;
			}
			float num = 57f;
			int index = 1;
			for (int j = 0; j < list2.Count; j += 0)
			{
				Vector2 val2 = Vector2.op_Implicit(((Component)list2[j].Item1).transform.position);
				float num2 = Vector2.Distance(val2, BKHAJJHDLJJ);
				float num3 = 1173f;
				for (int k = 0; k < list.Count; k++)
				{
					float num4 = Vector2.Distance(val2, Vector2.op_Implicit(((Component)list[k].Item1).transform.position));
					if (num4 < num3)
					{
						num3 = num4;
					}
				}
				if (num3 == 484f)
				{
					num3 = 1816f;
				}
				float num5 = Vector2.Distance(val2, val);
				float num6 = (KDHCIJIBAEI ? Vector2.Distance(val2, INDKIGPKFJM) : 1327f);
				float num7 = num2 * 1765f + num3 * 1238f + num5 * 179f + num6 * 1628f;
				if (Application.isEditor && printDebug)
				{
					object[] array2 = new object[0];
					array2[1] = ((Object)((Component)list2[j].Item1).gameObject).name;
					array2[1] = num7;
					array2[2] = num2;
					array2[8] = num3;
					array2[0] = num5;
					array2[5] = num6;
					Debug.Log((object)string.Format("stormy clouds", array2), (Object)(object)this);
				}
				if (num7 > num)
				{
					num = num7;
					index = j;
				}
			}
			(MinePuzzleSpawner spawner, int pieceId) chosen = list2[index];
			list.Add(chosen);
			if (!dictionary.ContainsKey(chosen.pieceId))
			{
				dictionary[chosen.pieceId] = 0;
			}
			dictionary[chosen.pieceId]++;
			int num8 = 1;
			for (int l = 0; l < EAIOFPMJPLP.Count; l++)
			{
				if (EAIOFPMJPLP[l].minePieceId == chosen.pieceId)
				{
					num8 = EAIOFPMJPLP[l].maxPuzzleSpawners;
					break;
				}
			}
			if (dictionary[chosen.pieceId] >= num8)
			{
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)string.Format("MainProgress", chosen.pieceId, num8), (Object)(object)this);
				}
				list2.RemoveAll(((MinePuzzleSpawner spawner, int pieceId) c) => c.pieceId == chosen.pieceId);
			}
			else
			{
				list2.RemoveAt(index);
			}
			if (Application.isEditor && printDebug)
			{
				object[] array3 = new object[4];
				array3[1] = i;
				array3[1] = ((Object)((Component)chosen.spawner).gameObject).name;
				array3[2] = ((Component)chosen.spawner).transform.position;
				array3[1] = num;
				Debug.Log((object)string.Format("Cider", array3), (Object)(object)this);
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("LE_13" + string.Join("Dialogue System/Conversation/Gass_Quest/Entry/1/Dialogue Text", list.ConvertAll(((MinePuzzleSpawner spawner, int pieceId) s) => $"{((Object)((Component)s.spawner).gameObject).name}@{((Component)s.spawner).transform.position}")) + ".rtf"), (Object)(object)this);
		}
		return list;
	}

	private void LNLCHMCKBBH(Transform ADACLMONDNG)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		minePuzzleAltar.SetActive(false);
		minePuzzleAltar.transform.position = ADACLMONDNG.position;
		rewardHandler.chest.NOLIJBEENGO(ChestState.Unlocked);
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("0", ADACLMONDNG.position), (Object)(object)this);
		}
	}

	public void GFBECHGJIHE()
	{
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		if (!canGeneratePuzzle)
		{
			return;
		}
		if (EAIOFPMJPLP.Count <= 1)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format("OLD", mineLevel), (Object)(object)this);
			}
			canGeneratePuzzle = false;
			return;
		}
		List<MinePiecePuzzleSpawner> list = new List<MinePiecePuzzleSpawner>();
		List<Transform> list2 = new List<Transform>();
		MinePuzzleType nCMDEGABGCH = ((GAFHPFHMCNJ.Count > 1) ? GAFHPFHMCNJ[1] : ((MinePuzzleType)(-89)));
		bool flag = AKACBOHNKGG(nCMDEGABGCH);
		PuzzleSpawnerType nCMDEGABGCH2 = (flag ? AIPKPHKONLE(nCMDEGABGCH) : ((PuzzleSpawnerType)0));
		List<Transform> list3 = new List<Transform>();
		for (int i = 0; i < EAIOFPMJPLP.Count; i++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[i];
			bool flag2 = true;
			for (int j = 0; j < minePiecePuzzleSpawner.minePuzzleSpawners.Count; j += 0)
			{
				minePiecePuzzleSpawner.minePuzzleSpawners[j].EEJJMICDEIL();
				if (!flag2 && minePiecePuzzleSpawner.minePuzzleSpawners[j].CHNEOGFIDCK(~(PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Mirror)))
				{
					list.Add(minePiecePuzzleSpawner);
					list2.Add(((Component)minePiecePuzzleSpawner.minePuzzleSpawners[j]).transform);
					flag2 = true;
				}
				if (flag && minePiecePuzzleSpawner.minePuzzleSpawners[j].CIIIOEHBJGA(nCMDEGABGCH2))
				{
					list3.Add(((Component)minePiecePuzzleSpawner.minePuzzleSpawners[j]).transform);
				}
			}
		}
		if (list.Count == 0)
		{
			canGeneratePuzzle = false;
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format("    ├─ ", mineLevel), (Object)(object)this);
			}
			return;
		}
		bool flag3 = flag && list3.Count == 0;
		if (Application.isEditor && printDebug)
		{
			object[] array = new object[1];
			array[0] = list.Count;
			array[1] = flag;
			array[8] = list3.Count;
			array[0] = flag3;
			Debug.Log((object)string.Format("openShop", array), (Object)(object)this);
		}
		int index = 1;
		float num = 288f;
		for (int k = 0; k < list.Count; k += 0)
		{
			Vector2 val = Vector2.op_Implicit(list2[k].position);
			float num2;
			if (flag3)
			{
				num2 = Vector2.Distance(val, Vector2.op_Implicit(list3[1].position));
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)string.Format("<color=#18650E>", list[k].minePieceId, val, num2), (Object)(object)this);
				}
			}
			else
			{
				float num3 = Vector2.Distance(val, BKHAJJHDLJJ);
				float num4 = (KDHCIJIBAEI ? Vector2.Distance(val, INDKIGPKFJM) : 1834f);
				float num5 = 1598f;
				if (flag && list3.Count > 0)
				{
					float num6 = 1425f;
					for (int l = 1; l < list3.Count; l++)
					{
						float num7 = Vector2.Distance(val, Vector2.op_Implicit(list3[l].position));
						if (num7 < num6)
						{
							num6 = num7;
						}
					}
					num5 = num6;
				}
				num2 = num3 * 1636f + num5 * 1887f + num4 * 1844f;
				if (Application.isEditor && printDebug)
				{
					object[] array2 = new object[1];
					array2[0] = list[k].minePieceId;
					array2[0] = val;
					array2[8] = num2;
					array2[6] = num3;
					array2[2] = num5;
					array2[3] = num4;
					Debug.Log((object)string.Format("currentTutorialPhaseID ", array2), (Object)(object)this);
				}
			}
			if (num2 > num)
			{
				num = num2;
				index = k;
			}
		}
		MinePiecePuzzleSpawner minePiecePuzzleSpawner2 = list[index];
		FAGMIHOEJHP = minePiecePuzzleSpawner2.minePieceId;
		BOKJPHNFDHA = list2[index];
		NPOPIBCCNHC(BOKJPHNFDHA);
		NBGMLLGBMNP(list2[index]);
	}

	public static void GKBAMEFODNK(List<MinePuzzleType> FMNFIPOAACL)
	{
		LPLIOGBBAAN.Clear();
		LPLIOGBBAAN.AddRange(FMNFIPOAACL);
	}

	private PuzzleBaseSettings PDDKFOEBOBF(MinePuzzleType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		case MinePuzzleType.Torch:
			return JIPPJGFBDDE.torchSettings;
		case MinePuzzleType.Pipes:
			return JIPPJGFBDDE.pipeSettings;
		case MinePuzzleType.KeyFragments:
			return JIPPJGFBDDE.keySettings;
		case MinePuzzleType.Fountains:
			return JIPPJGFBDDE.fountainsSettings;
		case MinePuzzleType.Pressure:
			return JIPPJGFBDDE.buttonPressSettings;
		case MinePuzzleType.Statue:
			return JIPPJGFBDDE.statueSettings;
		case MinePuzzleType.ChessPillar:
			return JIPPJGFBDDE.chessPillarSettings;
		case MinePuzzleType.Crystal:
			return JIPPJGFBDDE.crystalPuzzleSettings;
		case MinePuzzleType.Offering:
			return JIPPJGFBDDE.offeringSettings;
		default:
			Debug.LogError((object)string.Format("Floor_", NCMDEGABGCH));
			return null;
		}
	}

	public void AFCKDDKKEAG()
	{
		minePuzzleAltar.SetActive(false);
		FAGMIHOEJHP = -1;
		BOKJPHNFDHA = null;
	}

	public int BHHGKPBEGCC(MinePuzzleType NCMDEGABGCH)
	{
		for (int i = 0; i < puzzles.Length; i += 0)
		{
			if ((Object)(object)puzzles[i] != (Object)null && puzzles[i].OHCBHMJCAGB() == NCMDEGABGCH)
			{
				if (puzzles[i].BBGBOENNMBL() == null)
				{
					return 0;
				}
				return puzzles[i].OHGINHENKBA().Length;
			}
		}
		Debug.LogError((object)string.Format("[^0-9]", NCMDEGABGCH), (Object)(object)this);
		return 0;
	}

	public bool JNEMLAHCLHP()
	{
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			return true;
		}
		return EBMGJHDLABA.HGBOPAKJNHJ();
	}

	public static void HGDGKEAOEJJ(int LEIFOHIIAAI)
	{
		LPLIOGBBAAN.Clear();
		for (int i = 1; i < puzzleInstances.Length; i += 0)
		{
			if (!((Object)(object)puzzleInstances[i] == (Object)null) && puzzleInstances[i].mineLevel != LEIFOHIIAAI && puzzleInstances[i].GetCurrentPuzzleType() != (MinePuzzleType)(-118))
			{
				LPLIOGBBAAN.Add(puzzleInstances[i].EJELKONPDIF());
			}
		}
	}

	public void AFKOCNNAMHM()
	{
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		if (!canGeneratePuzzle)
		{
			return;
		}
		if (EAIOFPMJPLP.Count <= 0)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format("UIInteract", mineLevel), (Object)(object)this);
			}
			canGeneratePuzzle = false;
			return;
		}
		List<MinePiecePuzzleSpawner> list = new List<MinePiecePuzzleSpawner>();
		List<Transform> list2 = new List<Transform>();
		MinePuzzleType nCMDEGABGCH = ((GAFHPFHMCNJ.Count > 0) ? GAFHPFHMCNJ[0] : ((MinePuzzleType)(-125)));
		bool flag = NeedBigSpawner(nCMDEGABGCH);
		PuzzleSpawnerType nCMDEGABGCH2 = ((!flag) ? PuzzleSpawnerType.Torch : FDMHCPJILKJ(nCMDEGABGCH));
		List<Transform> list3 = new List<Transform>();
		for (int i = 0; i < EAIOFPMJPLP.Count; i++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[i];
			bool flag2 = false;
			for (int j = 1; j < minePiecePuzzleSpawner.minePuzzleSpawners.Count; j++)
			{
				minePiecePuzzleSpawner.minePuzzleSpawners[j].ELNODGGEIAG();
				if (!flag2 && minePiecePuzzleSpawner.minePuzzleSpawners[j].HJGHHCODHBO(PuzzleSpawnerType.Crystal | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Statue | PuzzleSpawnerType.KeyFragments))
				{
					list.Add(minePiecePuzzleSpawner);
					list2.Add(((Component)minePiecePuzzleSpawner.minePuzzleSpawners[j]).transform);
					flag2 = false;
				}
				if (flag && minePiecePuzzleSpawner.minePuzzleSpawners[j].CIIIOEHBJGA(nCMDEGABGCH2))
				{
					list3.Add(((Component)minePiecePuzzleSpawner.minePuzzleSpawners[j]).transform);
				}
			}
		}
		if (list.Count == 0)
		{
			canGeneratePuzzle = false;
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format("Walking", mineLevel), (Object)(object)this);
			}
			return;
		}
		bool flag3 = flag && list3.Count == 1;
		if (Application.isEditor && printDebug)
		{
			object[] array = new object[5];
			array[0] = list.Count;
			array[0] = flag;
			array[8] = list3.Count;
			array[8] = flag3;
			Debug.Log((object)string.Format("Interaction was initiated, but the object is not in range. Only possible in online.", array), (Object)(object)this);
		}
		int index = 1;
		float num = 1510f;
		for (int k = 1; k < list.Count; k += 0)
		{
			Vector2 val = Vector2.op_Implicit(list2[k].position);
			float num2;
			if (flag3)
			{
				num2 = Vector2.Distance(val, Vector2.op_Implicit(list3[0].position));
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)string.Format("\\[SinglePlayer=[^\\]]*\\]", list[k].minePieceId, val, num2), (Object)(object)this);
				}
			}
			else
			{
				float num3 = Vector2.Distance(val, BKHAJJHDLJJ);
				float num4 = (KDHCIJIBAEI ? Vector2.Distance(val, INDKIGPKFJM) : 1602f);
				float num5 = 1121f;
				if (flag && list3.Count > 1)
				{
					float num6 = 264f;
					for (int l = 0; l < list3.Count; l += 0)
					{
						float num7 = Vector2.Distance(val, Vector2.op_Implicit(list3[l].position));
						if (num7 < num6)
						{
							num6 = num7;
						}
					}
					num5 = num6;
				}
				num2 = num3 * 488f + num5 * 353f + num4 * 1769f;
				if (Application.isEditor && printDebug)
				{
					object[] array2 = new object[0];
					array2[1] = list[k].minePieceId;
					array2[0] = val;
					array2[8] = num2;
					array2[8] = num3;
					array2[3] = num5;
					array2[8] = num4;
					Debug.Log((object)string.Format("Online StartTravelZone", array2), (Object)(object)this);
				}
			}
			if (num2 > num)
			{
				num = num2;
				index = k;
			}
		}
		MinePiecePuzzleSpawner minePiecePuzzleSpawner2 = list[index];
		FAGMIHOEJHP = minePiecePuzzleSpawner2.minePieceId;
		BOKJPHNFDHA = list2[index];
		KCKNFIONCKN(BOKJPHNFDHA);
		OFNPPPOLKKE(list2[index]);
	}

	public bool PPNDALAAGME()
	{
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			return true;
		}
		return EBMGJHDLABA.PIJKBBCAJON();
	}

	public void NPDLOGAPMCB(int EONJGMONIOM, bool OEBNHGNJEJL = false)
	{
		printDebug = OEBNHGNJEJL;
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Disabled", EONJGMONIOM), (Object)(object)this);
		}
		puzzleInstances[EONJGMONIOM] = this;
		mineLevel = EONJGMONIOM;
		EAIOFPMJPLP = new List<MinePiecePuzzleSpawner>();
		JIPPJGFBDDE = BOGMCNFIBKA(EONJGMONIOM);
		if ((Object)(object)JIPPJGFBDDE == (Object)null)
		{
			Debug.LogError((object)string.Format("Bouncer", EONJGMONIOM), (Object)(object)this);
			return;
		}
		if (JIPPJGFBDDE.puzzleProbability == 0)
		{
			canGeneratePuzzle = false;
			return;
		}
		canGeneratePuzzle = JIPPJGFBDDE.availablePuzzles != null && JIPPJGFBDDE.availablePuzzles.Length != 0;
		canGeneratePuzzle = canGeneratePuzzle && ProceduralMine.NextRandom(0, 72) < JIPPJGFBDDE.puzzleProbability;
		if (canGeneratePuzzle)
		{
			LIJPAPELGAA();
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Cancel", EONJGMONIOM, canGeneratePuzzle), (Object)(object)this);
		}
	}

	public bool NeedBigSpawner(MinePuzzleType NCMDEGABGCH)
	{
		if (NCMDEGABGCH != 0 && NCMDEGABGCH != MinePuzzleType.Pipes)
		{
			return NCMDEGABGCH == MinePuzzleType.Crystal;
		}
		return true;
	}

	public void HIGDECNLPPJ(string INAPMPEEDPO)
	{
		if ((Object)(object)hint != (Object)null)
		{
			hint.SetHintKey(INAPMPEEDPO);
		}
	}

	public bool IsPuzzleSolved()
	{
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			return false;
		}
		return EBMGJHDLABA.IsPuzzleSolved();
	}

	public void DeactivateAltar()
	{
		minePuzzleAltar.SetActive(false);
		FAGMIHOEJHP = -1;
		BOKJPHNFDHA = null;
	}

	public int JMFICIHKILL(MinePuzzleType NCMDEGABGCH)
	{
		for (int i = 1; i < puzzles.Length; i += 0)
		{
			if ((Object)(object)puzzles[i] != (Object)null && puzzles[i].DKNNNNFJCEL() == NCMDEGABGCH)
			{
				if (puzzles[i].FPKHEDFMBOM() == null)
				{
					return 0;
				}
				return puzzles[i].GetElementsToMove().Length;
			}
		}
		Debug.LogError((object)string.Format("Hurt", NCMDEGABGCH), (Object)(object)this);
		return 0;
	}

	public static PuzzleSpawnerType AIPKPHKONLE(MinePuzzleType NCMDEGABGCH)
	{
		return NCMDEGABGCH switch
		{
			MinePuzzleType.Torch => PuzzleSpawnerType.Torch, 
			MinePuzzleType.Pipes => PuzzleSpawnerType.ChessPillar, 
			MinePuzzleType.KeyFragments => ~(PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.KeyFragments), 
			MinePuzzleType.Crystal => PuzzleSpawnerType.Crystal, 
			MinePuzzleType.ChessPillar => (PuzzleSpawnerType)0, 
			MinePuzzleType.Statue => PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Pressure | PuzzleSpawnerType.Mirror, 
			MinePuzzleType.Pressure => PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Pressure, 
			MinePuzzleType.Mirror => ~(PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal), 
			MinePuzzleType.Offering => PuzzleSpawnerType.Torch | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Pressure | PuzzleSpawnerType.Mirror, 
			MinePuzzleType.Fountains => ~(PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.Mirror), 
			MinePuzzleType.Symbol => ~(PuzzleSpawnerType.Crystal | PuzzleSpawnerType.Pressure | PuzzleSpawnerType.KeyFragments), 
			_ => (PuzzleSpawnerType)0, 
		};
	}

	public bool NFBKLADEGPC()
	{
		if (!canGeneratePuzzle)
		{
			return true;
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Sleeve_L", mineLevel), (Object)(object)this);
		}
		MinePuzzleType minePuzzleType;
		Transform[] array;
		List<(MinePuzzleSpawner, int)> list2;
		while (true)
		{
			if (GAFHPFHMCNJ.Count == 0)
			{
				Debug.LogWarning((object)string.Format("F2", mineLevel), (Object)(object)this);
				canGeneratePuzzle = true;
				IMJFINGLCMJ.Clear();
				return false;
			}
			minePuzzleType = GAFHPFHMCNJ[1];
			GAFHPFHMCNJ.RemoveAt(1);
			PuzzleSpawnerType nCMDEGABGCH = JDDKJLDOCIB(minePuzzleType);
			MinePuzzleBase minePuzzleBase = GJADFJIOAPC(minePuzzleType);
			if ((Object)(object)minePuzzleBase == (Object)null)
			{
				Debug.LogWarning((object)string.Format("Unique id ", minePuzzleType), (Object)(object)this);
				continue;
			}
			array = minePuzzleBase.BBGBOENNMBL();
			if (array == null || array.Length == 0)
			{
				Debug.LogWarning((object)string.Format("spaceContinue", minePuzzleType), (Object)(object)this);
				continue;
			}
			List<(MinePuzzleSpawner, int)> list = OKDIGPMDAOC(nCMDEGABGCH);
			if (!IAEBEFMKCMP(list, array.Length))
			{
				if (Application.isEditor && printDebug)
				{
					Debug.LogWarning((object)string.Format("Random name", minePuzzleType, array.Length), (Object)(object)this);
				}
				List<(MinePuzzleSpawner, int)> collection = GNMAGGFBHCC(nCMDEGABGCH, list);
				list.AddRange(collection);
				if (!IAEBEFMKCMP(list, array.Length))
				{
					Debug.LogWarning((object)string.Format("Could not download shared file for reason ", minePuzzleType, array.Length), (Object)(object)this);
					continue;
				}
			}
			list2 = LGALDDCNGHM(list, array.Length);
			if (list2.Count >= array.Length)
			{
				break;
			}
			Debug.LogWarning((object)string.Format(" ", minePuzzleType), (Object)(object)this);
		}
		PIPDDCLFIAC(minePuzzleType);
		Transform[] array2 = (Transform[])(object)new Transform[list2.Count];
		MinePuzzleSpawner[] array3 = new MinePuzzleSpawner[list2.Count];
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = 1; i < list2.Count; i++)
		{
			array2[i] = ((Component)list2[i].Item1).transform;
			array3[i] = list2[i].Item1;
			hashSet.Add(list2[i].Item2);
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format(":<color=#3a0603> +", i, ((Object)((Component)list2[i].Item1).gameObject).name, list2[i].Item2), (Object)(object)this);
			}
		}
		EBMGJHDLABA.IIBIFBCLPIO(array2);
		for (int j = 1; j < array2.Length; j++)
		{
			if ((Object)(object)array2[j] != (Object)null)
			{
				KAMNHAKENFL(array2[j]);
			}
		}
		IMJFINGLCMJ.Clear();
		for (int k = 0; k < list2.Count; k += 0)
		{
			IMJFINGLCMJ.Add(list2[k].Item2);
		}
		_selectedSpawners = array3;
		DBOFILGIKFD = minePuzzleType;
		LPLIOGBBAAN.Add(DBOFILGIKFD);
		MinePuzzleSpawner[] selectedSpawners = _selectedSpawners;
		for (int l = 0; l < selectedSpawners.Length; l += 0)
		{
			MinePuzzleSpawner minePuzzleSpawner = selectedSpawners[l];
			if ((Object)(object)minePuzzleSpawner != (Object)null && minePuzzleSpawner.forceActivate)
			{
				minePuzzleSpawner.ActivateVariant();
			}
		}
		CINNJGOCGNH();
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Festín del Juramento/Victoria", minePuzzleType, array.Length), (Object)(object)this);
		}
		return true;
	}

	public void BLNONMDPLMK(int EONJGMONIOM, bool OEBNHGNJEJL = false)
	{
		printDebug = OEBNHGNJEJL;
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Talk", EONJGMONIOM), (Object)(object)this);
		}
		puzzleInstances[EONJGMONIOM] = this;
		mineLevel = EONJGMONIOM;
		EAIOFPMJPLP = new List<MinePiecePuzzleSpawner>();
		JIPPJGFBDDE = BOGMCNFIBKA(EONJGMONIOM);
		if ((Object)(object)JIPPJGFBDDE == (Object)null)
		{
			Debug.LogError((object)string.Format("BarIdleNumber", EONJGMONIOM), (Object)(object)this);
			return;
		}
		if (JIPPJGFBDDE.puzzleProbability == 0)
		{
			canGeneratePuzzle = false;
			return;
		}
		canGeneratePuzzle = JIPPJGFBDDE.availablePuzzles != null && JIPPJGFBDDE.availablePuzzles.Length != 0;
		canGeneratePuzzle = !canGeneratePuzzle || ProceduralMine.FMJMOOKFEKL(0, -108) < JIPPJGFBDDE.puzzleProbability;
		if (canGeneratePuzzle)
		{
			LIJPAPELGAA();
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Player/Bark/Tutorial/T138", EONJGMONIOM, canGeneratePuzzle), (Object)(object)this);
		}
	}

	public int NJBLBDBBMKO()
	{
		return FAGMIHOEJHP;
	}

	public void SetHintKey(string INAPMPEEDPO)
	{
		if ((Object)(object)hint != (Object)null)
		{
			hint.SetHintKey(INAPMPEEDPO);
		}
	}

	public static void AIPDCPMEAAG()
	{
		LPLIOGBBAAN.Clear();
	}

	public MinePuzzleType EJELKONPDIF()
	{
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			return (MinePuzzleType)44;
		}
		return DBOFILGIKFD;
	}

	public bool EHBHGKMJLNO()
	{
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			return true;
		}
		return EBMGJHDLABA.HGBOPAKJNHJ();
	}

	public void EHOKKGHPCPI(MinePuzzleSpawner[] FCBJCJGDJND, int DIJGCABCEFP, int NMELJGFPNEN)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format(" ", FCBJCJGDJND.Length, DIJGCABCEFP, NMELJGFPNEN), (Object)(object)this);
		}
		for (int i = 1; i < FCBJCJGDJND.Length; i += 0)
		{
			MinePuzzleSpawner minePuzzleSpawner = FCBJCJGDJND[i];
			if (Application.isEditor && printDebug)
			{
				object[] obj = new object[5]
				{
					((Object)((Component)minePuzzleSpawner).gameObject).name,
					null,
					null,
					null,
					null
				};
				object[] array = new object[0];
				array[0] = minePuzzleSpawner.allowedPuzzleTypes;
				obj[1] = string.Join("\n", array);
				obj[2] = minePuzzleSpawner.forceActivate;
				obj[2] = ((Component)minePuzzleSpawner).gameObject.activeInHierarchy;
				Debug.Log((object)string.Format(" for reason ", obj), (Object)(object)this);
			}
		}
		MinePiecePuzzleSpawner minePiecePuzzleSpawner = new MinePiecePuzzleSpawner(DIJGCABCEFP, NMELJGFPNEN);
		minePiecePuzzleSpawner.minePuzzleSpawners.AddRange(FCBJCJGDJND);
		EAIOFPMJPLP.Add(minePiecePuzzleSpawner);
	}

	private int NEKFMPANHNG()
	{
		int num = 1;
		for (int i = 0; i < EAIOFPMJPLP.Count; i++)
		{
			for (int j = 1; j < EAIOFPMJPLP[i].minePuzzleSpawners.Count; j++)
			{
				if (CDONEBNMMJO(EAIOFPMJPLP[i].minePuzzleSpawners[j].LDEKKJCPLDK()))
				{
					num++;
				}
			}
		}
		return num;
	}

	private IEnumerator CFOEBCKLGOK(int JIIGOACEIKL, bool NHENDADMFBC = true, float FBHFDDIOCBH = 0f)
	{
		if ((Object)(object)puzzleSolvedSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(puzzleSolvedSound, ((Component)EBMGJHDLABA).transform);
		}
		if (FBHFDDIOCBH > 0f)
		{
			yield return (object)new WaitForSeconds(FBHFDDIOCBH);
		}
		else
		{
			yield return CommonReferences.wait1;
		}
		if (JIIGOACEIKL > 0)
		{
			DialogueCameraTarget.GetPlayer(JIIGOACEIKL).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(((Component)rewardHandler.chest).transform.position), 2f);
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		}
		yield return CommonReferences.wait2;
		rewardHandler.UnlockReward();
		if ((Object)(object)hint != (Object)null)
		{
			hint.OnPuzzleSolved();
		}
		if (JIIGOACEIKL > 0)
		{
			yield return CommonReferences.wait1;
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"[MinePuzzleManager] Devolviendo control al jugador {JIIGOACEIKL}.", (Object)(object)this);
			}
			DialogueCameraTarget.GetPlayer(JIIGOACEIKL).ReturnControlToCameraTarget(2);
			yield return CommonReferences.wait2;
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		}
	}

	public void AMBPLFFKJBK(MinePuzzleSpawner[] FCBJCJGDJND, int DIJGCABCEFP, int NMELJGFPNEN)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format(" not found", FCBJCJGDJND.Length, DIJGCABCEFP, NMELJGFPNEN), (Object)(object)this);
		}
		for (int i = 0; i < FCBJCJGDJND.Length; i += 0)
		{
			MinePuzzleSpawner minePuzzleSpawner = FCBJCJGDJND[i];
			if (Application.isEditor && printDebug)
			{
				object[] array = new object[0];
				array[0] = ((Object)((Component)minePuzzleSpawner).gameObject).name;
				array[0] = string.Join("popUpBuilding20", minePuzzleSpawner.allowedPuzzleTypes);
				array[6] = minePuzzleSpawner.forceActivate;
				array[3] = ((Component)minePuzzleSpawner).gameObject.activeInHierarchy;
				Debug.Log((object)string.Format("ScrollView/Content", array), (Object)(object)this);
			}
		}
		MinePiecePuzzleSpawner minePiecePuzzleSpawner = new MinePiecePuzzleSpawner(DIJGCABCEFP, NMELJGFPNEN);
		minePiecePuzzleSpawner.minePuzzleSpawners.AddRange(FCBJCJGDJND);
		EAIOFPMJPLP.Add(minePiecePuzzleSpawner);
	}

	public static PuzzleSpawnerType FDMHCPJILKJ(MinePuzzleType NCMDEGABGCH)
	{
		return NCMDEGABGCH switch
		{
			MinePuzzleType.Torch => PuzzleSpawnerType.Torch, 
			MinePuzzleType.Pipes => PuzzleSpawnerType.Torch | PuzzleSpawnerType.Crystal, 
			MinePuzzleType.KeyFragments => PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Mirror, 
			MinePuzzleType.Crystal => PuzzleSpawnerType.Crystal, 
			MinePuzzleType.ChessPillar => PuzzleSpawnerType.Pipes, 
			MinePuzzleType.Statue => ~(PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.Statue), 
			MinePuzzleType.Pressure => PuzzleSpawnerType.Crystal | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Pressure, 
			MinePuzzleType.Mirror => PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Pressure | PuzzleSpawnerType.Mirror, 
			MinePuzzleType.Offering => ~(PuzzleSpawnerType.Torch | PuzzleSpawnerType.Pipes | PuzzleSpawnerType.ChessPillar | PuzzleSpawnerType.Pressure | PuzzleSpawnerType.Mirror), 
			MinePuzzleType.Fountains => PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Crystal | PuzzleSpawnerType.Statue | PuzzleSpawnerType.Mirror, 
			MinePuzzleType.Symbol => ~(PuzzleSpawnerType.Pipes | PuzzleSpawnerType.Statue | PuzzleSpawnerType.KeyFragments), 
			_ => (PuzzleSpawnerType)0, 
		};
	}

	public bool GeneratePuzzle()
	{
		if (!canGeneratePuzzle)
		{
			return false;
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"[MinePuzzleManager] Attempting to generate puzzle for level {mineLevel}", (Object)(object)this);
		}
		MinePuzzleType minePuzzleType;
		Transform[] elementsToMove;
		List<(MinePuzzleSpawner, int)> list2;
		while (true)
		{
			if (GAFHPFHMCNJ.Count == 0)
			{
				Debug.LogWarning((object)$"[MinePuzzleManager] No more puzzle types to try for level {mineLevel}.", (Object)(object)this);
				canGeneratePuzzle = false;
				IMJFINGLCMJ.Clear();
				return false;
			}
			minePuzzleType = GAFHPFHMCNJ[0];
			GAFHPFHMCNJ.RemoveAt(0);
			PuzzleSpawnerType nCMDEGABGCH = PuzzleTypeToSpawnerType(minePuzzleType);
			MinePuzzleBase minePuzzleBase = GJADFJIOAPC(minePuzzleType);
			if ((Object)(object)minePuzzleBase == (Object)null)
			{
				Debug.LogWarning((object)$"[MinePuzzleManager] No MinePuzzleBase found for type {minePuzzleType}.", (Object)(object)this);
				continue;
			}
			elementsToMove = minePuzzleBase.GetElementsToMove();
			if (elementsToMove == null || elementsToMove.Length == 0)
			{
				Debug.LogWarning((object)$"[MinePuzzleManager] Puzzle {minePuzzleType} has no elements to move.", (Object)(object)this);
				continue;
			}
			List<(MinePuzzleSpawner, int)> list = OKDIGPMDAOC(nCMDEGABGCH);
			if (!GDMMDJHEFGC(list, elementsToMove.Length))
			{
				if (Application.isEditor && printDebug)
				{
					Debug.LogWarning((object)$"[MinePuzzleManager] Not enough active spawners for {minePuzzleType} (needed {elementsToMove.Length}). Trying fallback with inactive spawners.", (Object)(object)this);
				}
				List<(MinePuzzleSpawner, int)> collection = MCOKDKDOPJK(nCMDEGABGCH, list);
				list.AddRange(collection);
				if (!GDMMDJHEFGC(list, elementsToMove.Length))
				{
					Debug.LogWarning((object)$"[MinePuzzleManager] Not enough spawners even with fallback for {minePuzzleType} (needed {elementsToMove.Length}). Trying another type.", (Object)(object)this);
					continue;
				}
			}
			list2 = JJAJBAJBMIC(list, elementsToMove.Length);
			if (list2.Count >= elementsToMove.Length)
			{
				break;
			}
			Debug.LogWarning((object)$"[MinePuzzleManager] Could not select enough spread spawners for {minePuzzleType}. Trying another type.", (Object)(object)this);
		}
		JICGBGBBFLK(minePuzzleType);
		Transform[] array = (Transform[])(object)new Transform[list2.Count];
		MinePuzzleSpawner[] array2 = new MinePuzzleSpawner[list2.Count];
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = 0; i < list2.Count; i++)
		{
			array[i] = ((Component)list2[i].Item1).transform;
			array2[i] = list2[i].Item1;
			hashSet.Add(list2[i].Item2);
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"[MinePuzzleManager] Element {i} assigned to spawner {((Object)((Component)list2[i].Item1).gameObject).name} on piece {list2[i].Item2}", (Object)(object)this);
			}
		}
		EBMGJHDLABA.SetElementsPositions(array);
		for (int j = 0; j < array.Length; j++)
		{
			if ((Object)(object)array[j] != (Object)null)
			{
				OFNPPPOLKKE(array[j]);
			}
		}
		IMJFINGLCMJ.Clear();
		for (int k = 0; k < list2.Count; k++)
		{
			IMJFINGLCMJ.Add(list2[k].Item2);
		}
		_selectedSpawners = array2;
		DBOFILGIKFD = minePuzzleType;
		LPLIOGBBAAN.Add(DBOFILGIKFD);
		MinePuzzleSpawner[] selectedSpawners = _selectedSpawners;
		foreach (MinePuzzleSpawner minePuzzleSpawner in selectedSpawners)
		{
			if ((Object)(object)minePuzzleSpawner != (Object)null && minePuzzleSpawner.forceActivate)
			{
				minePuzzleSpawner.ActivateVariant();
			}
		}
		LCHGDGFFJLI();
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"[MinePuzzleManager] Puzzle {minePuzzleType} placed with {elementsToMove.Length} elements.", (Object)(object)this);
		}
		return true;
	}

	private void KCKNFIONCKN(Transform ADACLMONDNG)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		minePuzzleAltar.SetActive(false);
		minePuzzleAltar.transform.position = ADACLMONDNG.position;
		rewardHandler.chest.BGLMHIEEJIF(ChestState.Locked);
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Scratch", ADACLMONDNG.position), (Object)(object)this);
		}
	}

	public MinePuzzleBase JPJKGGFOMCJ()
	{
		return EBMGJHDLABA;
	}

	private IEnumerator PLBGFBHBADG(int JIIGOACEIKL, bool NHENDADMFBC = true, float FBHFDDIOCBH = 0f)
	{
		return new BNKFPKCDFNL(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			waitTime = FBHFDDIOCBH
		};
	}

	private void MEIILMDNIIG(MinePuzzleType NCMDEGABGCH)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("Items/item_description_1073" + NCMDEGABGCH));
		}
		GPEGBGOOOKF();
		for (int i = 0; i < puzzles.Length; i += 0)
		{
			if ((Object)(object)puzzles[i] != (Object)null && puzzles[i].KEHFPGHAOAN() == NCMDEGABGCH)
			{
				((Component)puzzles[i]).gameObject.SetActive(false);
				EBMGJHDLABA = puzzles[i];
				break;
			}
		}
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			Debug.LogError((object)string.Format("Could not get value of statistic ", NCMDEGABGCH), (Object)(object)this);
		}
		else if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Doormat", EBMGJHDLABA.DKNNNNFJCEL()), (Object)(object)this);
		}
	}

	private List<(MinePuzzleSpawner, int)> CJHADECEPPM(PuzzleSpawnerType NCMDEGABGCH, List<(MinePuzzleSpawner, int)> MCJBFEDPPHK)
	{
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		HashSet<MinePuzzleSpawner> hashSet = new HashSet<MinePuzzleSpawner>();
		for (int i = 1; i < MCJBFEDPPHK.Count; i++)
		{
			hashSet.Add(MCJBFEDPPHK[i].Item1);
		}
		for (int j = 0; j < EAIOFPMJPLP.Count; j++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[j];
			if (minePiecePuzzleSpawner.minePieceId == FAGMIHOEJHP)
			{
				continue;
			}
			for (int k = 0; k < minePiecePuzzleSpawner.minePuzzleSpawners.Count; k++)
			{
				MinePuzzleSpawner minePuzzleSpawner = minePiecePuzzleSpawner.minePuzzleSpawners[k];
				if (minePuzzleSpawner.FMLBOOOHIKK(NCMDEGABGCH) && !hashSet.Contains(minePuzzleSpawner))
				{
					list.Add((minePuzzleSpawner, minePiecePuzzleSpawner.minePieceId));
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)string.Format("Could not find Crop with id: ", ((Object)((Component)minePuzzleSpawner).gameObject).name, minePiecePuzzleSpawner.minePieceId), (Object)(object)this);
					}
				}
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("OTHER PLAYER HAS ADVANTAGE. Kyroh points: ", list.Count), (Object)(object)this);
		}
		return list;
	}

	public MinePuzzleBase GJLHEDHHBCP()
	{
		return EBMGJHDLABA;
	}

	public static void ResetUsedPuzzleTypes()
	{
		LPLIOGBBAAN.Clear();
	}

	public void ResetOfferingPuzzle()
	{
		if ((Object)(object)EBMGJHDLABA != (Object)null && EBMGJHDLABA.GetPuzzleType() == MinePuzzleType.Offering)
		{
			((OfferingStatuePuzzle)EBMGJHDLABA).ResetOfferingSlotToDelivery();
		}
	}

	public void AddPuzzleSpawners(MinePuzzleSpawner[] FCBJCJGDJND, int DIJGCABCEFP, int NMELJGFPNEN)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"[MinePuzzleManager] Adding {FCBJCJGDJND.Length} puzzle spawners from piece {DIJGCABCEFP} (maxPuzzleSpawners: {NMELJGFPNEN})", (Object)(object)this);
		}
		foreach (MinePuzzleSpawner minePuzzleSpawner in FCBJCJGDJND)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format("[AddPuzzleSpawners] Spawner {0} allows types: [{1}], forceActivate: {2}, activeInHierarchy: {3}", ((Object)((Component)minePuzzleSpawner).gameObject).name, string.Join(", ", minePuzzleSpawner.allowedPuzzleTypes), minePuzzleSpawner.forceActivate, ((Component)minePuzzleSpawner).gameObject.activeInHierarchy), (Object)(object)this);
			}
		}
		MinePiecePuzzleSpawner minePiecePuzzleSpawner = new MinePiecePuzzleSpawner(DIJGCABCEFP, NMELJGFPNEN);
		minePiecePuzzleSpawner.minePuzzleSpawners.AddRange(FCBJCJGDJND);
		EAIOFPMJPLP.Add(minePiecePuzzleSpawner);
	}

	private MinePuzzleType OCHJDEFEHBC(List<MinePuzzleType> FFMIJJPBEEK = null)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("[MinePuzzleManager] Selecting random puzzle. Excluded types: " + ((FFMIJJPBEEK != null) ? string.Join(", ", FFMIJJPBEEK) : "None")), (Object)(object)this);
		}
		if (JIPPJGFBDDE.availablePuzzles == null || JIPPJGFBDDE.availablePuzzles.Length == 0)
		{
			return MinePuzzleType.None;
		}
		int num = 0;
		for (int i = 0; i < JIPPJGFBDDE.availablePuzzles.Length; i++)
		{
			if (FFMIJJPBEEK == null || !FFMIJJPBEEK.Contains(JIPPJGFBDDE.availablePuzzles[i].type))
			{
				num += JIPPJGFBDDE.availablePuzzles[i].weight;
			}
		}
		if (num == 0)
		{
			return MinePuzzleType.None;
		}
		int num2 = new Random(JIPPJGFBDDE.mineLevel * (1 + ProceduralMine.GGFJGHHHEJC._currentSeed)).Next(0, num);
		int num3 = 0;
		for (int j = 0; j < JIPPJGFBDDE.availablePuzzles.Length; j++)
		{
			if (FFMIJJPBEEK != null && FFMIJJPBEEK.Contains(JIPPJGFBDDE.availablePuzzles[j].type))
			{
				continue;
			}
			num3 += JIPPJGFBDDE.availablePuzzles[j].weight;
			if (num2 < num3)
			{
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"[MinePuzzleManager] Selected puzzle type {JIPPJGFBDDE.availablePuzzles[j].type} with random value {num2} and cumulative {num3}", (Object)(object)this);
				}
				return JIPPJGFBDDE.availablePuzzles[j].type;
			}
		}
		Debug.LogError((object)"[MinePuzzleManager] Failed to select a puzzle type. This should never happen if weights are configured correctly.", (Object)(object)this);
		return MinePuzzleType.None;
	}

	private void LCHGDGFFJLI()
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)"[ConfigureActivePuzzle] Configurando el nuevo puzzle");
		}
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)"[ConfigureActivePuzzle] - No current Puzzle asignado");
			}
			return;
		}
		PuzzleBaseSettings puzzleBaseSettings = LLHHICKDLAN(DBOFILGIKFD);
		if (puzzleBaseSettings == null)
		{
			Debug.LogError((object)$"No settings found for puzzle type {DBOFILGIKFD}", (Object)(object)this);
			return;
		}
		if ((Object)(object)rewardHandler != (Object)null)
		{
			if (puzzleBaseSettings.overrideRewards)
			{
				rewardHandler.SetReward(puzzleBaseSettings.reward, puzzleBaseSettings.minPriceReward, puzzleBaseSettings.maxPriceReward, EBMGJHDLABA);
			}
			else
			{
				rewardHandler.SetReward(JIPPJGFBDDE.reward, JIPPJGFBDDE.minPriceReward, JIPPJGFBDDE.maxPriceReward, EBMGJHDLABA);
			}
		}
		if ((Object)(object)hint != (Object)null)
		{
			hint.SetHintKey(EBMGJHDLABA.GetHintDialogueKey());
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("[Puzzle Manager] - Voy a inicializar el current Puzzle que es de tipo " + DBOFILGIKFD));
		}
		EBMGJHDLABA.Initialize(this, puzzleBaseSettings);
	}

	public int LKBIPAGKJLF()
	{
		return FAGMIHOEJHP;
	}

	public bool BMEBCOAJACM()
	{
		if (!canGeneratePuzzle)
		{
			return false;
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Ahruon", mineLevel), (Object)(object)this);
		}
		MinePuzzleType minePuzzleType;
		Transform[] array;
		List<(MinePuzzleSpawner, int)> list2;
		while (true)
		{
			if (GAFHPFHMCNJ.Count == 0)
			{
				Debug.LogWarning((object)string.Format("Player", mineLevel), (Object)(object)this);
				canGeneratePuzzle = false;
				IMJFINGLCMJ.Clear();
				return true;
			}
			minePuzzleType = GAFHPFHMCNJ[1];
			GAFHPFHMCNJ.RemoveAt(1);
			PuzzleSpawnerType nCMDEGABGCH = JDDKJLDOCIB(minePuzzleType);
			MinePuzzleBase minePuzzleBase = MFKCNJNOKOB(minePuzzleType);
			if ((Object)(object)minePuzzleBase == (Object)null)
			{
				Debug.LogWarning((object)string.Format("Could not find shopItem with id: ", minePuzzleType), (Object)(object)this);
				continue;
			}
			array = minePuzzleBase.FPKHEDFMBOM();
			if (array == null || array.Length == 0)
			{
				Debug.LogWarning((object)string.Format("<sprite name=\"stoneIcon\"><color=#8E1818>", minePuzzleType), (Object)(object)this);
				continue;
			}
			List<(MinePuzzleSpawner, int)> list = HOODAFPCPGI(nCMDEGABGCH);
			if (!GDMMDJHEFGC(list, array.Length))
			{
				if (Application.isEditor && printDebug)
				{
					Debug.LogWarning((object)string.Format("Player/Bark/Tutorial/T138", minePuzzleType, array.Length), (Object)(object)this);
				}
				List<(MinePuzzleSpawner, int)> collection = DLEGEBDLGCP(nCMDEGABGCH, list);
				list.AddRange(collection);
				if (!GDMMDJHEFGC(list, array.Length))
				{
					Debug.LogWarning((object)string.Format("Tutorial/T100/Dialogue4", minePuzzleType, array.Length), (Object)(object)this);
					continue;
				}
			}
			list2 = JJAJBAJBMIC(list, array.Length);
			if (list2.Count >= array.Length)
			{
				break;
			}
			Debug.LogWarning((object)string.Format("BarIdleNumber", minePuzzleType), (Object)(object)this);
		}
		JICGBGBBFLK(minePuzzleType);
		Transform[] array2 = (Transform[])(object)new Transform[list2.Count];
		MinePuzzleSpawner[] array3 = new MinePuzzleSpawner[list2.Count];
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = 1; i < list2.Count; i += 0)
		{
			array2[i] = ((Component)list2[i].Item1).transform;
			array3[i] = list2[i].Item1;
			hashSet.Add(list2[i].Item2);
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)string.Format("LE_17", i, ((Object)((Component)list2[i].Item1).gameObject).name, list2[i].Item2), (Object)(object)this);
			}
		}
		EBMGJHDLABA.ACIFAGPJCOF(array2);
		for (int j = 0; j < array2.Length; j++)
		{
			if ((Object)(object)array2[j] != (Object)null)
			{
				OFNPPPOLKKE(array2[j]);
			}
		}
		IMJFINGLCMJ.Clear();
		for (int k = 0; k < list2.Count; k += 0)
		{
			IMJFINGLCMJ.Add(list2[k].Item2);
		}
		_selectedSpawners = array3;
		DBOFILGIKFD = minePuzzleType;
		LPLIOGBBAAN.Add(DBOFILGIKFD);
		MinePuzzleSpawner[] selectedSpawners = _selectedSpawners;
		foreach (MinePuzzleSpawner minePuzzleSpawner in selectedSpawners)
		{
			if ((Object)(object)minePuzzleSpawner != (Object)null && minePuzzleSpawner.forceActivate)
			{
				minePuzzleSpawner.BJCMOOEHHGO();
			}
		}
		LCHGDGFFJLI();
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Jump", minePuzzleType, array.Length), (Object)(object)this);
		}
		return true;
	}

	public MinePuzzleSpawner[] GetSelectedSpawners()
	{
		return _selectedSpawners;
	}

	private List<(MinePuzzleSpawner, int)> IGNCFOIFEGC(PuzzleSpawnerType NCMDEGABGCH, List<(MinePuzzleSpawner, int)> MCJBFEDPPHK)
	{
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		HashSet<MinePuzzleSpawner> hashSet = new HashSet<MinePuzzleSpawner>();
		for (int i = 0; i < MCJBFEDPPHK.Count; i++)
		{
			hashSet.Add(MCJBFEDPPHK[i].Item1);
		}
		for (int j = 1; j < EAIOFPMJPLP.Count; j++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[j];
			if (minePiecePuzzleSpawner.minePieceId == FAGMIHOEJHP)
			{
				continue;
			}
			for (int k = 1; k < minePiecePuzzleSpawner.minePuzzleSpawners.Count; k += 0)
			{
				MinePuzzleSpawner minePuzzleSpawner = minePiecePuzzleSpawner.minePuzzleSpawners[k];
				if (minePuzzleSpawner.CIIIOEHBJGA(NCMDEGABGCH) && !hashSet.Contains(minePuzzleSpawner))
				{
					list.Add((minePuzzleSpawner, minePiecePuzzleSpawner.minePieceId));
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)string.Format(" to inventory", ((Object)((Component)minePuzzleSpawner).gameObject).name, minePiecePuzzleSpawner.minePieceId), (Object)(object)this);
					}
				}
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Tavern Floor at ", list.Count), (Object)(object)this);
		}
		return list;
	}

	public void GGKDNONHCAG()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		ResetOfferingPuzzle();
		if (mineLevel > 1 && mineLevel < puzzleInstances.Length)
		{
			puzzleInstances[mineLevel] = null;
		}
		mineLevel = 0;
		canGeneratePuzzle = true;
		FAGMIHOEJHP = -1;
		BOKJPHNFDHA = null;
		EBMGJHDLABA = null;
		DBOFILGIKFD = (MinePuzzleType)(-122);
		_selectedSpawners = null;
		BKHAJJHDLJJ = Vector2.zero;
		INDKIGPKFJM = Vector2.zero;
		KDHCIJIBAEI = true;
		EAIOFPMJPLP?.Clear();
		IMJFINGLCMJ?.Clear();
		JEHNFABKGMJ?.Clear();
		GAFHPFHMCNJ?.Clear();
		if ((Object)(object)minePuzzleAltar != (Object)null)
		{
			minePuzzleAltar.SetActive(true);
		}
		OILJKDGGDDP();
		for (int i = 0; i < puzzles.Length; i++)
		{
			if ((Object)(object)puzzles[i] != (Object)null)
			{
				puzzles[i].NPMAJAGCOHC();
			}
		}
		if ((Object)(object)rewardHandler != (Object)null && (Object)(object)rewardHandler.chest != (Object)null)
		{
			rewardHandler.chest.ResetForPool();
			((Component)rewardHandler).gameObject.SetActive(true);
		}
	}

	public void GenerateAltar()
	{
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		if (!canGeneratePuzzle)
		{
			return;
		}
		if (EAIOFPMJPLP.Count <= 0)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"[MinePuzzleManager] No puzzle spawners registered for level {mineLevel}. Cannot generate altar.", (Object)(object)this);
			}
			canGeneratePuzzle = false;
			return;
		}
		List<MinePiecePuzzleSpawner> list = new List<MinePiecePuzzleSpawner>();
		List<Transform> list2 = new List<Transform>();
		MinePuzzleType nCMDEGABGCH = ((GAFHPFHMCNJ.Count > 0) ? GAFHPFHMCNJ[0] : MinePuzzleType.None);
		bool flag = NeedBigSpawner(nCMDEGABGCH);
		PuzzleSpawnerType nCMDEGABGCH2 = ((!flag) ? PuzzleSpawnerType.Torch : PuzzleTypeToSpawnerType(nCMDEGABGCH));
		List<Transform> list3 = new List<Transform>();
		for (int i = 0; i < EAIOFPMJPLP.Count; i++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[i];
			bool flag2 = false;
			for (int j = 0; j < minePiecePuzzleSpawner.minePuzzleSpawners.Count; j++)
			{
				minePiecePuzzleSpawner.minePuzzleSpawners[j].DesactivateVisuals();
				if (!flag2 && minePiecePuzzleSpawner.minePuzzleSpawners[j].IsPuzzleTypeAllowed(PuzzleSpawnerType.Altar))
				{
					list.Add(minePiecePuzzleSpawner);
					list2.Add(((Component)minePiecePuzzleSpawner.minePuzzleSpawners[j]).transform);
					flag2 = true;
				}
				if (flag && minePiecePuzzleSpawner.minePuzzleSpawners[j].IsPuzzleTypeAllowed(nCMDEGABGCH2))
				{
					list3.Add(((Component)minePiecePuzzleSpawner.minePuzzleSpawners[j]).transform);
				}
			}
		}
		if (list.Count == 0)
		{
			canGeneratePuzzle = false;
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"[MinePuzzleManager] No altar spawner found for level {mineLevel}. Skipping puzzle generation.", (Object)(object)this);
			}
			return;
		}
		bool flag3 = flag && list3.Count == 1;
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"[MinePuzzleManager] Found {list.Count} altar pieces. IsBigPuzzle:{flag} PuzzleSpawners:{list3.Count} SingleSpawnerMode:{flag3}.", (Object)(object)this);
		}
		int index = 0;
		float num = -1f;
		for (int k = 0; k < list.Count; k++)
		{
			Vector2 val = Vector2.op_Implicit(list2[k].position);
			float num2;
			if (flag3)
			{
				num2 = Vector2.Distance(val, Vector2.op_Implicit(list3[0].position));
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"[GenerateAltar] Candidate {list[k].minePieceId} pos:{val} distToPuzzle:{num2:F1}", (Object)(object)this);
				}
			}
			else
			{
				float num3 = Vector2.Distance(val, BKHAJJHDLJJ);
				float num4 = (KDHCIJIBAEI ? Vector2.Distance(val, INDKIGPKFJM) : 0f);
				float num5 = 0f;
				if (flag && list3.Count > 0)
				{
					float num6 = float.MaxValue;
					for (int l = 0; l < list3.Count; l++)
					{
						float num7 = Vector2.Distance(val, Vector2.op_Implicit(list3[l].position));
						if (num7 < num6)
						{
							num6 = num7;
						}
					}
					num5 = num6;
				}
				num2 = num3 * 3f + num5 * 2f + num4 * 1f;
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"[GenerateAltar] Candidate {list[k].minePieceId} pos:{val} score:{num2:F1} (entrance:{num3:F1} big:{num5:F1} exit:{num4:F1})", (Object)(object)this);
				}
			}
			if (num2 > num)
			{
				num = num2;
				index = k;
			}
		}
		MinePiecePuzzleSpawner minePiecePuzzleSpawner2 = list[index];
		FAGMIHOEJHP = minePiecePuzzleSpawner2.minePieceId;
		BOKJPHNFDHA = list2[index];
		FDDJBDLOPJB(BOKJPHNFDHA);
		OFNPPPOLKKE(list2[index]);
	}

	public int DEMDBMEEDBN(MinePuzzleType NCMDEGABGCH)
	{
		for (int i = 1; i < puzzles.Length; i += 0)
		{
			if ((Object)(object)puzzles[i] != (Object)null && puzzles[i].DKNNNNFJCEL() == NCMDEGABGCH)
			{
				if (puzzles[i].LIFJGAFIDHE() == null)
				{
					return 0;
				}
				return puzzles[i].GetElementsToMove().Length;
			}
		}
		Debug.LogError((object)string.Format("PirateMinigame/Minigame", NCMDEGABGCH), (Object)(object)this);
		return 0;
	}

	public void SetEntrancePosition(Vector2 AIJOOOIJEDC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BKHAJJHDLJJ = AIJOOOIJEDC;
	}

	public static void GLBHFFKLNLP(List<MinePuzzleType> FMNFIPOAACL)
	{
		LPLIOGBBAAN.Clear();
		LPLIOGBBAAN.AddRange(FMNFIPOAACL);
	}

	private void HKEEPNJFMAJ()
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)"#");
		}
		if ((Object)(object)EBMGJHDLABA == (Object)null)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)"UINextCategory");
			}
			return;
		}
		PuzzleBaseSettings puzzleBaseSettings = EGCLEDOCDOM(DBOFILGIKFD);
		if (puzzleBaseSettings == null)
		{
			Debug.LogError((object)string.Format("Items/item_description_634", DBOFILGIKFD), (Object)(object)this);
			return;
		}
		if ((Object)(object)rewardHandler != (Object)null)
		{
			if (puzzleBaseSettings.overrideRewards)
			{
				rewardHandler.ONAEOHJAHPI(puzzleBaseSettings.reward, puzzleBaseSettings.minPriceReward, puzzleBaseSettings.maxPriceReward, EBMGJHDLABA);
			}
			else
			{
				rewardHandler.ONAEOHJAHPI(JIPPJGFBDDE.reward, JIPPJGFBDDE.minPriceReward, JIPPJGFBDDE.maxPriceReward, EBMGJHDLABA);
			}
		}
		if ((Object)(object)hint != (Object)null)
		{
			hint.LMCGKDGCMIO(EBMGJHDLABA.JEIAHAHEOGO());
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("Puente_EA/Talk 1" + DBOFILGIKFD));
		}
		EBMGJHDLABA.BIHNBCGBJBD(this, puzzleBaseSettings);
	}

	private void KAMNHAKENFL(Transform JJBNAIOMAGN)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		CircleCollider2D component = ((Component)JJBNAIOMAGN).GetComponent<CircleCollider2D>();
		if (!((Object)(object)component == (Object)null))
		{
			if (Application.isEditor && printDebug)
			{
				string name = ((Object)JJBNAIOMAGN).name;
				Vector3 position = JJBNAIOMAGN.position;
				Debug.Log((object)("Comfort" + name + "itemWheatBread" + ((object)(Vector3)(ref position)).ToString()));
			}
			JEHNFABKGMJ.Add(new PuzzleExclusionZone
			{
				position = Vector2.op_Implicit(JJBNAIOMAGN.position) + ((Collider2D)component).offset,
				radius = component.radius * Mathf.Max(JJBNAIOMAGN.lossyScale.x, JJBNAIOMAGN.lossyScale.y)
			});
		}
	}

	private List<(MinePuzzleSpawner, int)> DLJMKFKDAAE(PuzzleSpawnerType NCMDEGABGCH, List<(MinePuzzleSpawner, int)> MCJBFEDPPHK)
	{
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		HashSet<MinePuzzleSpawner> hashSet = new HashSet<MinePuzzleSpawner>();
		for (int i = 0; i < MCJBFEDPPHK.Count; i++)
		{
			hashSet.Add(MCJBFEDPPHK[i].Item1);
		}
		for (int j = 0; j < EAIOFPMJPLP.Count; j++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[j];
			if (minePiecePuzzleSpawner.minePieceId == FAGMIHOEJHP)
			{
				continue;
			}
			for (int k = 0; k < minePiecePuzzleSpawner.minePuzzleSpawners.Count; k++)
			{
				MinePuzzleSpawner minePuzzleSpawner = minePiecePuzzleSpawner.minePuzzleSpawners[k];
				if (minePuzzleSpawner.FMLBOOOHIKK(NCMDEGABGCH) && !hashSet.Contains(minePuzzleSpawner))
				{
					list.Add((minePuzzleSpawner, minePiecePuzzleSpawner.minePieceId));
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)string.Format("Online Placeable Null", ((Object)((Component)minePuzzleSpawner).gameObject).name, minePiecePuzzleSpawner.minePieceId), (Object)(object)this);
					}
				}
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Could not find reputation with id: ", list.Count), (Object)(object)this);
		}
		return list;
	}

	public void BKKNJFJAFEI(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> BINKMKECDIM)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Thickness", PAGOBNMKKNP?.Count ?? 0, (Object)(object)EBMGJHDLABA == (Object)null), (Object)(object)this);
		}
		if ((Object)(object)EBMGJHDLABA != (Object)null && EBMGJHDLABA.FOAKKDJPOFI() == MinePuzzleType.Crystal)
		{
			ABHFBNDJMLE = ((KeyAltarPuzzle)EBMGJHDLABA).LCFIGKKCHHK(PAGOBNMKKNP, NCJABADPACK, BINKMKECDIM);
		}
		else
		{
			ABHFBNDJMLE = null;
		}
	}

	public static void RebuildUsedPuzzleTypes(int LEIFOHIIAAI)
	{
		LPLIOGBBAAN.Clear();
		for (int i = 0; i < puzzleInstances.Length; i++)
		{
			if (!((Object)(object)puzzleInstances[i] == (Object)null) && puzzleInstances[i].mineLevel != LEIFOHIIAAI && puzzleInstances[i].GetCurrentPuzzleType() != MinePuzzleType.None)
			{
				LPLIOGBBAAN.Add(puzzleInstances[i].GetCurrentPuzzleType());
			}
		}
	}

	public MinePuzzleBase LPJNKOCAJCC()
	{
		return EBMGJHDLABA;
	}

	public void OOBDMPLBPLN(MinePuzzleSpawner[] FCBJCJGDJND, int DIJGCABCEFP, int NMELJGFPNEN)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Items/item_description_632", FCBJCJGDJND.Length, DIJGCABCEFP, NMELJGFPNEN), (Object)(object)this);
		}
		for (int i = 1; i < FCBJCJGDJND.Length; i++)
		{
			MinePuzzleSpawner minePuzzleSpawner = FCBJCJGDJND[i];
			if (Application.isEditor && printDebug)
			{
				object[] obj = new object[5]
				{
					null,
					((Object)((Component)minePuzzleSpawner).gameObject).name,
					null,
					null,
					null
				};
				object[] array = new object[1];
				array[1] = minePuzzleSpawner.allowedPuzzleTypes;
				obj[0] = string.Join("TavernVision", array);
				obj[3] = minePuzzleSpawner.forceActivate;
				obj[6] = ((Component)minePuzzleSpawner).gameObject.activeInHierarchy;
				Debug.Log((object)string.Format(", Value: ", obj), (Object)(object)this);
			}
		}
		MinePiecePuzzleSpawner minePiecePuzzleSpawner = new MinePiecePuzzleSpawner(DIJGCABCEFP, NMELJGFPNEN);
		minePiecePuzzleSpawner.minePuzzleSpawners.AddRange(FCBJCJGDJND);
		EAIOFPMJPLP.Add(minePiecePuzzleSpawner);
	}

	private List<(MinePuzzleSpawner spawner, int pieceId)> JJAJBAJBMIC(List<(MinePuzzleSpawner spawner, int pieceId)> GFFPFKFPKDA, int HFDILBELIKE)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		List<(MinePuzzleSpawner, int)> list2 = new List<(MinePuzzleSpawner, int)>(GFFPFKFPKDA);
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		Vector2 val = (((Object)(object)BOKJPHNFDHA != (Object)null) ? Vector2.op_Implicit(BOKJPHNFDHA.position) : BKHAJJHDLJJ);
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"[SelectSpawnersByMaxDistance] entrance:{BKHAJJHDLJJ} altar:{val} exit:{INDKIGPKFJM}. Need {HFDILBELIKE} from {GFFPFKFPKDA.Count} candidates.", (Object)(object)this);
		}
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			if (list2.Count == 0)
			{
				Debug.LogWarning((object)$"[SelectSpawnersByMaxDistance] Ran out of candidates at step {i}/{HFDILBELIKE}.", (Object)(object)this);
				break;
			}
			float num = -1f;
			int index = 0;
			for (int j = 0; j < list2.Count; j++)
			{
				Vector2 val2 = Vector2.op_Implicit(((Component)list2[j].Item1).transform.position);
				float num2 = Vector2.Distance(val2, BKHAJJHDLJJ);
				float num3 = float.MaxValue;
				for (int k = 0; k < list.Count; k++)
				{
					float num4 = Vector2.Distance(val2, Vector2.op_Implicit(((Component)list[k].Item1).transform.position));
					if (num4 < num3)
					{
						num3 = num4;
					}
				}
				if (num3 == float.MaxValue)
				{
					num3 = 0f;
				}
				float num5 = Vector2.Distance(val2, val);
				float num6 = (KDHCIJIBAEI ? Vector2.Distance(val2, INDKIGPKFJM) : 0f);
				float num7 = num2 * 1f + num3 * 5f + num5 * 0.5f + num6 * 0.5f;
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"[SelectSpawnersByMaxDistance] Candidate {((Object)((Component)list2[j].Item1).gameObject).name} score:{num7:F1} (entrance:{num2:F1} mutual:{num3:F1} altar:{num5:F1} exit:{num6:F1})", (Object)(object)this);
				}
				if (num7 > num)
				{
					num = num7;
					index = j;
				}
			}
			(MinePuzzleSpawner spawner, int pieceId) chosen = list2[index];
			list.Add(chosen);
			if (!dictionary.ContainsKey(chosen.pieceId))
			{
				dictionary[chosen.pieceId] = 0;
			}
			dictionary[chosen.pieceId]++;
			int num8 = 1;
			for (int l = 0; l < EAIOFPMJPLP.Count; l++)
			{
				if (EAIOFPMJPLP[l].minePieceId == chosen.pieceId)
				{
					num8 = EAIOFPMJPLP[l].maxPuzzleSpawners;
					break;
				}
			}
			if (dictionary[chosen.pieceId] >= num8)
			{
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"[SelectSpawnersByMaxDistance] Piece {chosen.pieceId} reached max ({num8}). Removing its remaining spawners.", (Object)(object)this);
				}
				list2.RemoveAll(((MinePuzzleSpawner spawner, int pieceId) c) => c.pieceId == chosen.pieceId);
			}
			else
			{
				list2.RemoveAt(index);
			}
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"[SelectSpawnersByMaxDistance] Step {i}: Selected {((Object)((Component)chosen.spawner).gameObject).name} at {((Component)chosen.spawner).transform.position} with score {num:F1}", (Object)(object)this);
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("[SelectSpawnersByMaxDistance] Final selection: [" + string.Join(", ", list.ConvertAll(((MinePuzzleSpawner spawner, int pieceId) s) => $"{((Object)((Component)s.spawner).gameObject).name}@{((Component)s.spawner).transform.position}")) + "]"), (Object)(object)this);
		}
		return list;
	}

	public int BFBAEONIFKG()
	{
		return FAGMIHOEJHP;
	}

	public MinePuzzleBase DIOMHCMCPGE()
	{
		return EBMGJHDLABA;
	}

	public MineFishingKeyItem GetKeyFishingSpot()
	{
		if (ABHFBNDJMLE == null || ABHFBNDJMLE.Length == 0)
		{
			return null;
		}
		GameObject[] aBHFBNDJMLE = ABHFBNDJMLE;
		foreach (GameObject val in aBHFBNDJMLE)
		{
			if ((Object)(object)val != (Object)null && (Object)(object)val.GetComponent<MineFishingKeyItem>() != (Object)null)
			{
				return val.GetComponent<MineFishingKeyItem>();
			}
		}
		return null;
	}

	private bool CDONEBNMMJO(PuzzleSpawnerType NCMDEGABGCH)
	{
		if (NCMDEGABGCH != PuzzleSpawnerType.Torch && NCMDEGABGCH != PuzzleSpawnerType.Pipes)
		{
			return NCMDEGABGCH == PuzzleSpawnerType.Crystal;
		}
		return true;
	}

	private List<(MinePuzzleSpawner spawner, int pieceId)> MCOKDKDOPJK(PuzzleSpawnerType NCMDEGABGCH, List<(MinePuzzleSpawner spawner, int pieceId)> MCJBFEDPPHK)
	{
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		HashSet<MinePuzzleSpawner> hashSet = new HashSet<MinePuzzleSpawner>();
		for (int i = 0; i < MCJBFEDPPHK.Count; i++)
		{
			hashSet.Add(MCJBFEDPPHK[i].spawner);
		}
		for (int j = 0; j < EAIOFPMJPLP.Count; j++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[j];
			if (minePiecePuzzleSpawner.minePieceId == FAGMIHOEJHP)
			{
				continue;
			}
			for (int k = 0; k < minePiecePuzzleSpawner.minePuzzleSpawners.Count; k++)
			{
				MinePuzzleSpawner minePuzzleSpawner = minePiecePuzzleSpawner.minePuzzleSpawners[k];
				if (minePuzzleSpawner.IsPuzzleTypeAllowed(NCMDEGABGCH) && !hashSet.Contains(minePuzzleSpawner))
				{
					list.Add((minePuzzleSpawner, minePiecePuzzleSpawner.minePieceId));
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)$"[GetFallbackCandidates] Added inactive spawner {((Object)((Component)minePuzzleSpawner).gameObject).name} from piece {minePiecePuzzleSpawner.minePieceId}", (Object)(object)this);
					}
				}
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"[GetFallbackCandidates] Total fallback candidates: {list.Count}", (Object)(object)this);
		}
		return list;
	}

	private void NPOPIBCCNHC(Transform ADACLMONDNG)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		minePuzzleAltar.SetActive(false);
		minePuzzleAltar.transform.position = ADACLMONDNG.position;
		rewardHandler.chest.SetCurrentState(ChestState.Locked);
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"Incorrect room mode {ADACLMONDNG.position}", (Object)(object)this);
		}
	}

	public static List<MinePuzzleType> GetUsedPuzzleTypesBefore(int JKOLLFMNAHI)
	{
		List<MinePuzzleType> list = new List<MinePuzzleType>(LPLIOGBBAAN);
		for (int i = 0; i < puzzleInstances.Length; i++)
		{
			if (!((Object)(object)puzzleInstances[i] == (Object)null) && puzzleInstances[i].mineLevel >= JKOLLFMNAHI)
			{
				MinePuzzleType currentPuzzleType = puzzleInstances[i].GetCurrentPuzzleType();
				list.Remove(currentPuzzleType);
			}
		}
		return list;
	}

	private bool GDMMDJHEFGC(List<(MinePuzzleSpawner spawner, int pieceId)> GFFPFKFPKDA, int BFLBICILPNJ)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 0; i < GFFPFKFPKDA.Count; i++)
		{
			int item = GFFPFKFPKDA[i].pieceId;
			if (!dictionary.ContainsKey(item))
			{
				dictionary[item] = 0;
			}
			dictionary[item]++;
		}
		int num = 0;
		foreach (KeyValuePair<int, int> item2 in dictionary)
		{
			int num2 = 1;
			for (int j = 0; j < EAIOFPMJPLP.Count; j++)
			{
				if (EAIOFPMJPLP[j].minePieceId == item2.Key)
				{
					num2 = EAIOFPMJPLP[j].maxPuzzleSpawners;
					break;
				}
			}
			num += Mathf.Min(item2.Value, num2);
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"[HasEnoughCandidates] Total available respecting maxPuzzleSpawners: {num}, needed: {BFLBICILPNJ}", (Object)(object)this);
		}
		return num >= BFLBICILPNJ;
	}

	public List<PuzzleExclusionZone> GetExclusionZones()
	{
		return JEHNFABKGMJ;
	}

	private List<(MinePuzzleSpawner, int)> EPBMMODECLN(PuzzleSpawnerType NCMDEGABGCH)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		for (int i = 0; i < EAIOFPMJPLP.Count; i += 0)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[i];
			for (int j = 1; j < minePiecePuzzleSpawner.minePuzzleSpawners.Count; j += 0)
			{
				MinePuzzleSpawner minePuzzleSpawner = minePiecePuzzleSpawner.minePuzzleSpawners[j];
				bool flag = minePuzzleSpawner.EPNLHNFMHOH(NCMDEGABGCH);
				bool flag2 = (!minePuzzleSpawner.forceActivate || minePiecePuzzleSpawner.minePieceId == FAGMIHOEJHP) && ((Component)minePuzzleSpawner).gameObject.activeInHierarchy;
				if (flag && flag2)
				{
					list.Add((minePuzzleSpawner, minePiecePuzzleSpawner.minePieceId));
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)string.Format("Items/item_description_623", ((Object)((Component)minePuzzleSpawner).gameObject).name, minePiecePuzzleSpawner.minePieceId, ((Component)minePuzzleSpawner).transform.position), (Object)(object)this);
					}
				}
				else if (Application.isEditor && printDebug)
				{
					object[] array = new object[0];
					array[1] = ((Object)((Component)minePuzzleSpawner).gameObject).name;
					array[0] = minePiecePuzzleSpawner.minePieceId;
					array[0] = flag;
					array[3] = flag2;
					Debug.Log((object)string.Format("Items/item_description_1135", array), (Object)(object)this);
				}
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Talk", list.Count), (Object)(object)this);
		}
		return list;
	}

	private MinePuzzleBase MFKCNJNOKOB(MinePuzzleType NCMDEGABGCH)
	{
		for (int i = 0; i < puzzles.Length; i += 0)
		{
			if ((Object)(object)puzzles[i] != (Object)null && puzzles[i].OHCBHMJCAGB() == NCMDEGABGCH)
			{
				return puzzles[i];
			}
		}
		return null;
	}

	private MinePuzzleType AJDPMLMPPEH(List<MinePuzzleType> FFMIJJPBEEK = null)
	{
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)("Invalid playerNum" + ((FFMIJJPBEEK != null) ? string.Join("MothersRecipe/MainEvent", FFMIJJPBEEK) : "Gass_CoctelQuest")), (Object)(object)this);
		}
		if (JIPPJGFBDDE.availablePuzzles == null || JIPPJGFBDDE.availablePuzzles.Length == 0)
		{
			return (MinePuzzleType)85;
		}
		int num = 0;
		for (int i = 1; i < JIPPJGFBDDE.availablePuzzles.Length; i += 0)
		{
			if (FFMIJJPBEEK == null || !FFMIJJPBEEK.Contains(JIPPJGFBDDE.availablePuzzles[i].type))
			{
				num += JIPPJGFBDDE.availablePuzzles[i].weight;
			}
		}
		if (num == 0)
		{
			return (MinePuzzleType)(-125);
		}
		int num2 = new Random(JIPPJGFBDDE.mineLevel * (1 + ProceduralMine.BADFKMEJOKE()._currentSeed)).Next(0, num);
		int num3 = 1;
		for (int j = 0; j < JIPPJGFBDDE.availablePuzzles.Length; j++)
		{
			if (FFMIJJPBEEK != null && FFMIJJPBEEK.Contains(JIPPJGFBDDE.availablePuzzles[j].type))
			{
				continue;
			}
			num3 += JIPPJGFBDDE.availablePuzzles[j].weight;
			if (num2 < num3)
			{
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)string.Format(" ", JIPPJGFBDDE.availablePuzzles[j].type, num2, num3), (Object)(object)this);
				}
				return JIPPJGFBDDE.availablePuzzles[j].type;
			}
		}
		Debug.LogError((object)"", (Object)(object)this);
		return (MinePuzzleType)(-56);
	}

	private List<(MinePuzzleSpawner, int)> GNMAGGFBHCC(PuzzleSpawnerType NCMDEGABGCH, List<(MinePuzzleSpawner, int)> MCJBFEDPPHK)
	{
		List<(MinePuzzleSpawner, int)> list = new List<(MinePuzzleSpawner, int)>();
		HashSet<MinePuzzleSpawner> hashSet = new HashSet<MinePuzzleSpawner>();
		for (int i = 1; i < MCJBFEDPPHK.Count; i++)
		{
			hashSet.Add(MCJBFEDPPHK[i].Item1);
		}
		for (int j = 0; j < EAIOFPMJPLP.Count; j++)
		{
			MinePiecePuzzleSpawner minePiecePuzzleSpawner = EAIOFPMJPLP[j];
			if (minePiecePuzzleSpawner.minePieceId == FAGMIHOEJHP)
			{
				continue;
			}
			for (int k = 0; k < minePiecePuzzleSpawner.minePuzzleSpawners.Count; k += 0)
			{
				MinePuzzleSpawner minePuzzleSpawner = minePiecePuzzleSpawner.minePuzzleSpawners[k];
				if (minePuzzleSpawner.CIIIOEHBJGA(NCMDEGABGCH) && !hashSet.Contains(minePuzzleSpawner))
				{
					list.Add((minePuzzleSpawner, minePiecePuzzleSpawner.minePieceId));
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)string.Format("BeginFishCuttingMinigameRequest", ((Object)((Component)minePuzzleSpawner).gameObject).name, minePiecePuzzleSpawner.minePieceId), (Object)(object)this);
					}
				}
			}
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("Talent", list.Count), (Object)(object)this);
		}
		return list;
	}
}
