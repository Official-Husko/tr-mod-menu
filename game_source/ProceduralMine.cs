using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Mine;
using Photon.Pun;
using UnityEngine;

public class ProceduralMine : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class JKNONHFNCHG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProceduralMine _003C_003E4__this;

		public int level;

		private GameObject _003CblackModulesParent_003E5__2;

		private MinePuzzleType _003CchosenPuzzle_003E5__3;

		private bool _003CneedBigSpawner_003E5__4;

		private bool _003CaltarPlaced_003E5__5;

		private bool _003CbigSpawnerPlaced_003E5__6;

		private int _003CaltarAttempts_003E5__7;

		private List<MinePiece> _003CaltarPieces_003E5__8;

		private List<MinePiece> _003CbigSpawnerPieces_003E5__9;

		private int _003CaltarTargetBlock_003E5__10;

		private int _003CbigSpawnerTargetBlock_003E5__11;

		private bool _003CcanGeneratePuzzle_003E5__12;

		private List<PuzzleExclusionZone> _003CexclusionZones_003E5__13;

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
		public JKNONHFNCHG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected O, but got Unknown
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d30: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0323: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c60: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c65: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0366: Unknown result type (might be due to invalid IL or missing references)
			//IL_036f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Unknown result type (might be due to invalid IL or missing references)
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0abe: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0849: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_096d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ProceduralMine proceduralMine = _003C_003E4__this;
			Vector2Int val;
			OpenedPath openedPath;
			MinePiece minePiece2;
			int kMIEMNOMHPD;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				proceduralMine.generatingLevel = level;
				proceduralMine.currentLevel = level;
				proceduralMine.currentOnlineId = -100000 - level * 1000;
				proceduralMine.KMIEMNOMHPD = proceduralMine.blocksGenerationNumber;
				proceduralMine.HELLFPBFCAA.Clear();
				proceduralMine.openedPaths.Clear();
				if (!Application.isPlaying)
				{
					proceduralMine.NDMFDOHLBPD();
				}
				proceduralMine.GDMCKLPPMAM();
				proceduralMine.LADFMDJAMLO.Clear();
				proceduralMine.LGMIANCNPMI.Clear();
				proceduralMine.LADFMDJAMLO.Clear();
				proceduralMine.LGMIANCNPMI.Clear();
				MineVariantsSelector.DHMBKGALAFC(proceduralMine.piecesPrefabs);
				MinePiece lPBEOKMHKGO = proceduralMine.KIMCNNHEHNH();
				proceduralMine.DestroyLevel(proceduralMine.currentLevel);
				proceduralMine.BPIIMNLBEKK = Object.Instantiate<MineLevel>(proceduralMine.mineLevelPrefab, Vector2.op_Implicit(Vector2.zero), Quaternion.identity, ((Component)proceduralMine).transform);
				proceduralMine.APONCLJEAPJ = ((Component)proceduralMine.BPIIMNLBEKK).gameObject;
				((Object)proceduralMine.APONCLJEAPJ).name = "Level " + proceduralMine.currentLevel;
				proceduralMine.BPIIMNLBEKK.level = proceduralMine.currentLevel;
				proceduralMine.allBlocks = proceduralMine.BPIIMNLBEKK.blocks;
				MineManager.AddLevel(proceduralMine.BPIIMNLBEKK);
				proceduralMine.BPIIMNLBEKK.currentSeed = proceduralMine._currentSeed;
				_003CblackModulesParent_003E5__2 = new GameObject("Black modules");
				_003CblackModulesParent_003E5__2.transform.SetParent(proceduralMine.APONCLJEAPJ.transform);
				_003CblackModulesParent_003E5__2.AddComponent<Grid>().cellSize = new Vector3(0.5f, 0.5f);
				if ((Object)(object)_003CblackModulesParent_003E5__2 != (Object)null)
				{
					Debug.Log((object)("Creado blackmodule parent: " + ((Object)_003CblackModulesParent_003E5__2).name));
				}
				else
				{
					Debug.LogError((object)"Error al crear blackModulesParent");
				}
				MinePuzzleManager minePuzzleManager = (proceduralMine.KFNHEOAAAKD ? MinePuzzleManagerPool.Get(proceduralMine.minePuzzleManagerPrefab, proceduralMine.APONCLJEAPJ.transform) : Object.Instantiate<MinePuzzleManager>(proceduralMine.minePuzzleManagerPrefab, proceduralMine.APONCLJEAPJ.transform));
				proceduralMine.BPIIMNLBEKK.SetPuzzleManager(minePuzzleManager, proceduralMine.printDebug);
				_003CchosenPuzzle_003E5__3 = minePuzzleManager.GetChosenPuzzleType();
				int elementsRequieredByType = minePuzzleManager.GetElementsRequieredByType(_003CchosenPuzzle_003E5__3);
				_003CneedBigSpawner_003E5__4 = minePuzzleManager.NeedBigSpawner(_003CchosenPuzzle_003E5__3);
				proceduralMine.KMIEMNOMHPD = Mathf.Max(proceduralMine.KMIEMNOMHPD, elementsRequieredByType + 2);
				if (Application.isEditor && proceduralMine.printDebug)
				{
					Debug.Log((object)$"BLOCKS NUMBER: {proceduralMine.KMIEMNOMHPD} Puzzle Needit: {elementsRequieredByType + 2}");
				}
				MinePiece minePiece = proceduralMine.LEODJOIEIDC(lPBEOKMHKGO, proceduralMine.APONCLJEAPJ);
				((Component)minePiece).transform.position = proceduralMine.ONHBHPNCNGM(proceduralMine.currentLevel);
				minePiece.SetMineStairsInfo(proceduralMine.currentLevel, proceduralMine.currentLevel - 1);
				minePiece.elevatorSwitch.SetTravelZone(proceduralMine.currentLevel);
				proceduralMine.BPIIMNLBEKK.puzzleManager.SetEntrancePosition(Vector2.op_Implicit(((Component)minePiece).transform.position));
				for (int i = 0; i < ((Vector2Int)(ref minePiece.pieceSize)).x; i++)
				{
					for (int j = 0; j < ((Vector2Int)(ref minePiece.pieceSize)).y; j++)
					{
						Vector2Int key = new Vector2Int((int)((Component)minePiece).transform.position.x, (int)((Component)minePiece).transform.position.y) + new Vector2Int(i, j) * proceduralMine.blockSize;
						proceduralMine.BPIIMNLBEKK.AddPiece(minePiece);
						proceduralMine.BPIIMNLBEKK.blocks.Add(key, minePiece.blocks[j * ((Vector2Int)(ref minePiece.pieceSize)).x + i]);
						proceduralMine.BPIIMNLBEKK.blocks[key].piece = minePiece;
					}
				}
				for (int k = 0; k < minePiece.blocks.Length; k++)
				{
					for (int l = 0; l < minePiece.blocks[k].openedPaths.Length; l++)
					{
						minePiece.blocks[k].openedPaths[l].distance = 0;
						proceduralMine.openedPaths.Add(minePiece.blocks[k].openedPaths[l]);
						minePiece.blocks[k].openedPaths[l].block = minePiece.blocks[k];
					}
				}
				if (!proceduralMine.generateInOneFrame && Application.isPlaying)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_04c1;
			}
			case 1:
				_003C_003E1__state = -1;
				goto IL_04c1;
			case 2:
				_003C_003E1__state = -1;
				return false;
			case 3:
				_003C_003E1__state = -1;
				goto IL_0b15;
			case 4:
				_003C_003E1__state = -1;
				goto IL_0b44;
			case 5:
				_003C_003E1__state = -1;
				return false;
			case 6:
				_003C_003E1__state = -1;
				goto IL_0c95;
			case 7:
				_003C_003E1__state = -1;
				goto IL_0d8b;
			case 8:
				_003C_003E1__state = -1;
				goto IL_0e03;
			case 9:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0b44:
				if (!MaximumBlocksReached() || !MinimumClosedRoomsReached() || (_003CcanGeneratePuzzle_003E5__12 && !_003CaltarPlaced_003E5__5 && _003CaltarPieces_003E5__8.Count > 0 && _003CaltarAttempts_003E5__7 < 5))
				{
					if (Application.isEditor && proceduralMine.printDebug)
					{
						Debug.Log((object)$"Blocks generated: {proceduralMine.allBlocks.Count}. Opened paths: {proceduralMine.openedPaths.Count}. Current steps: {proceduralMine.EDMKFGBHAPL}. Altar placed: {_003CaltarPlaced_003E5__5}. Big spawner placed: {_003CbigSpawnerPlaced_003E5__6} AltarPieces Array: {_003CaltarPieces_003E5__8.Count}.");
					}
					minePiece2 = null;
					if (proceduralMine.openedPaths.Count == 0)
					{
						Debug.LogError((object)"openedPaths 0 before all blocksGenerationNumber");
						if (OnlineManager.MasterOrOffline())
						{
							_003C_003E2__current = proceduralMine.LJCACPLNIIG(level);
							_003C_003E1__state = 2;
							return true;
						}
					}
					openedPath = proceduralMine.DGMPPKCJKGP();
					if (_003CcanGeneratePuzzle_003E5__12 && !_003CaltarPlaced_003E5__5 && _003CaltarPieces_003E5__8.Count > 0 && proceduralMine.allBlocks.Count >= _003CaltarTargetBlock_003E5__10)
					{
						if (Application.isEditor && proceduralMine.printDebug)
						{
							Debug.Log((object)$"[ProceduralMine] Trying to force ALTAR piece at block {proceduralMine.allBlocks.Count} (target is {_003CaltarTargetBlock_003E5__10}). Path block pos: {openedPath.block.CJGAMLEMBNL()}", (Object)(object)proceduralMine);
						}
						minePiece2 = MinePieceSelector.OGGPMJDMBPB(openedPath, _003CaltarPieces_003E5__8, NKEMALMMOBL: false);
						if ((Object)(object)minePiece2 != (Object)null)
						{
							if (Application.isEditor && proceduralMine.printDebug)
							{
								Debug.Log((object)$"[ProceduralMine] Forced ALTAR piece {((Object)minePiece2).name} at block {proceduralMine.allBlocks.Count} (target was {_003CaltarTargetBlock_003E5__10}). Path block pos: {openedPath.block.CJGAMLEMBNL()}", (Object)(object)proceduralMine);
							}
							_003CaltarPlaced_003E5__5 = true;
						}
						else
						{
							_003CaltarAttempts_003E5__7++;
							if (Application.isEditor && proceduralMine.printDebug)
							{
								Debug.Log((object)$"[ProceduralMine] ALTAR: No valid piece for path dir={openedPath.direction} at block {proceduralMine.allBlocks.Count}. Candidates: {_003CaltarPieces_003E5__8.Count}. Retrying next iteration.", (Object)(object)proceduralMine);
							}
						}
					}
					if (((_003CcanGeneratePuzzle_003E5__12 && (Object)(object)minePiece2 == (Object)null) & _003CneedBigSpawner_003E5__4) && !_003CbigSpawnerPlaced_003E5__6 && proceduralMine.allBlocks.Count >= _003CbigSpawnerTargetBlock_003E5__11)
					{
						minePiece2 = MinePieceSelector.OGGPMJDMBPB(openedPath, _003CbigSpawnerPieces_003E5__9, NKEMALMMOBL: false);
						if ((Object)(object)minePiece2 != (Object)null)
						{
							if (Application.isEditor && proceduralMine.printDebug)
							{
								Debug.Log((object)$"[ProceduralMine] Forced BIG SPAWNER piece {((Object)minePiece2).name} at block {proceduralMine.allBlocks.Count} (target was {_003CbigSpawnerTargetBlock_003E5__11}). Path block pos: {openedPath.block.CJGAMLEMBNL()}", (Object)(object)proceduralMine);
							}
							_003CbigSpawnerPlaced_003E5__6 = true;
						}
						else if (Application.isEditor && proceduralMine.printDebug)
						{
							Debug.LogWarning((object)$"[ProceduralMine] BIG SPAWNER: No valid piece for path dir={openedPath.direction} at block {proceduralMine.allBlocks.Count}. Candidates: {_003CbigSpawnerPieces_003E5__9.Count}. Retrying next iteration.", (Object)(object)proceduralMine);
						}
					}
					if ((Object)(object)minePiece2 == (Object)null)
					{
						minePiece2 = MinePieceSelector.IGFKEFKNPEN(openedPath, ANCMKNOJCHI: false, proceduralMine.usePiecesRarity, proceduralMine.BPIIMNLBEKK.isPuzzlePlaced);
					}
					if (Object.op_Implicit((Object)(object)minePiece2))
					{
						proceduralMine.LEODJOIEIDC(minePiece2, openedPath);
						if (minePiece2.uniquePiece)
						{
							proceduralMine.RegisterUniquePiece(minePiece2);
						}
						if (Application.isEditor && proceduralMine.printDebug)
						{
							Debug.Log((object)$"Placed piece {((Object)minePiece2).name} at block {proceduralMine.allBlocks.Count}. Path block pos: {openedPath.block.CJGAMLEMBNL()}. Opened path dir: {openedPath.direction}. Altar placed: {_003CaltarPlaced_003E5__5}. Big spawner placed: {_003CbigSpawnerPlaced_003E5__6}.", (Object)(object)proceduralMine);
						}
					}
					else
					{
						val = openedPath.block.CJGAMLEMBNL();
						Debug.LogError((object)("Cannot place mine block piece at " + ((object)(Vector2Int)(ref val)).ToString() + " " + openedPath.direction));
					}
					proceduralMine.EDMKFGBHAPL--;
					goto IL_0b15;
				}
				if (proceduralMine.currentLevel < 6)
				{
					openedPath = proceduralMine.APAEGBDPHJL();
					minePiece2 = null;
					minePiece2 = MinePieceSelector.MFECIFINPPH(openedPath, proceduralMine.nextLevelPrefabs, NKEMALMMOBL: true);
					if (!Object.op_Implicit((Object)(object)minePiece2) && OnlineManager.MasterOrOffline())
					{
						_003C_003E2__current = proceduralMine.LJCACPLNIIG(level);
						_003C_003E1__state = 5;
						return true;
					}
					MinePiece minePiece3 = proceduralMine.LEODJOIEIDC(minePiece2, openedPath);
					if (Object.op_Implicit((Object)(object)minePiece3))
					{
						if (Application.isEditor && proceduralMine.printDebug)
						{
							Debug.Log((object)$"[ProceduralMine] Exit piece: {((Object)minePiece3).name} - stairsTravelZone: {minePiece3.stairsTravelZone}", (Object)(object)proceduralMine);
						}
						minePiece3.SetMineStairsInfo(proceduralMine.currentLevel, proceduralMine.currentLevel + 1);
						minePiece3.ActivateStairsBlocker(proceduralMine.currentLevel);
						proceduralMine.BPIIMNLBEKK.nextLevelPiece = minePiece3;
						proceduralMine.BPIIMNLBEKK.puzzleManager.SetExitPosition(Vector2.op_Implicit(((Component)minePiece3).transform.position));
					}
					if (!proceduralMine.generateInOneFrame && Application.isPlaying)
					{
						_003C_003E2__current = null;
						_003C_003E1__state = 6;
						return true;
					}
				}
				goto IL_0c95;
				IL_0c95:
				if (OnlineManager.IsMasterClient())
				{
					OnlineMineManager.instance.SendGenerateMineLevel(level, proceduralMine._currentSeed);
				}
				goto IL_0d8b;
				IL_0d8b:
				while (proceduralMine.openedPaths.Count > 0)
				{
					openedPath = proceduralMine.APAEGBDPHJL();
					minePiece2 = MinePieceSelector.IGFKEFKNPEN(openedPath, ANCMKNOJCHI: true, proceduralMine.usePiecesRarity, proceduralMine.BPIIMNLBEKK.isPuzzlePlaced);
					if (Object.op_Implicit((Object)(object)minePiece2))
					{
						proceduralMine.LEODJOIEIDC(minePiece2, openedPath);
					}
					else
					{
						minePiece2 = MinePieceSelector.IGFKEFKNPEN(openedPath, ANCMKNOJCHI: false, proceduralMine.usePiecesRarity, proceduralMine.BPIIMNLBEKK.isPuzzlePlaced);
						if (Object.op_Implicit((Object)(object)minePiece2))
						{
							proceduralMine.LEODJOIEIDC(minePiece2, openedPath);
						}
						else
						{
							val = openedPath.block.CJGAMLEMBNL();
							Debug.LogError((object)("Cannot place mine block piece at " + ((object)(Vector2Int)(ref val)).ToString() + " " + openedPath.direction));
						}
					}
					if (!proceduralMine.generateInOneFrame && Application.isPlaying)
					{
						_003C_003E2__current = null;
						_003C_003E1__state = 7;
						return true;
					}
				}
				proceduralMine.ONGIFNCJBDD(ref proceduralMine.HHOPCCKCBJM, ref proceduralMine.FEOJNEGIHKI, ref proceduralMine.HLPLAHPIEHB, ref proceduralMine.GOCGLKPEBIG);
				proceduralMine.LACOFNDKGDA();
				proceduralMine.BPIIMNLBEKK.puzzleManager.GenerateAltar();
				if (Application.isPlaying)
				{
					proceduralMine.CalculateCameraBounds();
				}
				if (!proceduralMine.generateInOneFrame && Application.isPlaying)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 8;
					return true;
				}
				goto IL_0e03;
				IL_04c1:
				openedPath = null;
				minePiece2 = null;
				kMIEMNOMHPD = proceduralMine.KMIEMNOMHPD;
				_003CaltarPlaced_003E5__5 = false;
				_003CbigSpawnerPlaced_003E5__6 = false;
				_003CaltarAttempts_003E5__7 = 0;
				_003CaltarPieces_003E5__8 = new List<MinePiece>();
				_003CbigSpawnerPieces_003E5__9 = null;
				_003CaltarTargetBlock_003E5__10 = 0;
				_003CbigSpawnerTargetBlock_003E5__11 = 0;
				_003CcanGeneratePuzzle_003E5__12 = proceduralMine.BPIIMNLBEKK.puzzleManager.canGeneratePuzzle;
				if (_003CcanGeneratePuzzle_003E5__12)
				{
					for (int m = 0; m < proceduralMine.notClosingPiecesPrefabs.Count; m++)
					{
						if ((proceduralMine.notClosingPiecesPrefabs[m].puzzleSpawnersTypes & PuzzleSpawnerType.Altar) != 0)
						{
							_003CaltarPieces_003E5__8.Add(proceduralMine.notClosingPiecesPrefabs[m]);
						}
					}
					bool flag = NextRandom(0, 2) == 0;
					int num2 = NextRandom(Mathf.Max(1, kMIEMNOMHPD / 4), Mathf.Max(kMIEMNOMHPD / 2, 2));
					int num3 = NextRandom(num2 + 2, Mathf.Max(num2 + 3, 3 * kMIEMNOMHPD / 4));
					_003CaltarTargetBlock_003E5__10 = (flag ? num2 : num3);
					if (_003CneedBigSpawner_003E5__4)
					{
						_003CbigSpawnerTargetBlock_003E5__11 = (flag ? num3 : num2);
						_003CbigSpawnerPieces_003E5__9 = new List<MinePiece>();
						PuzzleSpawnerType puzzleSpawnerType = MinePuzzleManager.PuzzleTypeToSpawnerType(_003CchosenPuzzle_003E5__3);
						for (int n = 0; n < proceduralMine.notClosingPiecesPrefabs.Count; n++)
						{
							if ((proceduralMine.notClosingPiecesPrefabs[n].puzzleSpawnersTypes & puzzleSpawnerType) != 0)
							{
								_003CbigSpawnerPieces_003E5__9.Add(proceduralMine.notClosingPiecesPrefabs[n]);
							}
						}
					}
					if (Application.isEditor && proceduralMine.printDebug)
					{
						Debug.Log((object)$"[ProceduralMine] AltarFirst: {flag} - AltarTarget: {_003CaltarTargetBlock_003E5__10} - PuzzleTarget: {_003CbigSpawnerTargetBlock_003E5__11}", (Object)(object)proceduralMine);
					}
				}
				goto IL_0b44;
				IL_0b15:
				if (proceduralMine.EDMKFGBHAPL <= 0)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				if (!proceduralMine.generateInOneFrame && Application.isPlaying)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				goto IL_0b44;
				IL_0e03:
				if (Application.isEditor && proceduralMine.printDebug)
				{
					Debug.Log((object)"== START PLACE PIECES ==");
				}
				for (int num4 = 0; num4 < proceduralMine.BPIIMNLBEKK.pieces.Count; num4++)
				{
					proceduralMine.BPIIMNLBEKK.pieces[num4].ActivateVariants(proceduralMine.BPIIMNLBEKK.puzzleManager.GetAltarPieceId());
				}
				if (proceduralMine.BPIIMNLBEKK.puzzleManager.canGeneratePuzzle && !proceduralMine.BPIIMNLBEKK.puzzleManager.GeneratePuzzle())
				{
					Debug.LogError((object)"NO SE HA PODIDO GENERAR EL PUZZLE - ERROR!!");
				}
				_003CexclusionZones_003E5__13 = proceduralMine.BPIIMNLBEKK.puzzleManager.GetExclusionZones();
				_003CexclusionZones_003E5__13.AddRange(proceduralMine.BPIIMNLBEKK.GetDestructibleDisablerZones());
				for (int num5 = 0; num5 < proceduralMine.BPIIMNLBEKK.pieces.Count; num5++)
				{
					proceduralMine.BPIIMNLBEKK.pieces[num5].PlacePiece(proceduralMine.currentLevel, _003CexclusionZones_003E5__13);
				}
				if (Application.isEditor && proceduralMine.printDebug)
				{
					Debug.Log((object)"== END PLACE PIECES ==");
				}
				if (!proceduralMine.generateInOneFrame && Application.isPlaying)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 9;
					return true;
				}
				break;
			}
			proceduralMine.allBlocks = proceduralMine.BPIIMNLBEKK.blocks;
			string text = $"blackModulesParent null: {(Object)(object)_003CblackModulesParent_003E5__2 == (Object)null}, ";
			GameObject obj = _003CblackModulesParent_003E5__2;
			object obj2;
			if (obj == null)
			{
				obj2 = null;
			}
			else
			{
				Transform transform = obj.transform;
				obj2 = ((transform != null) ? transform.parent : null);
			}
			Debug.Log((object)(text + $"parent null: {(Object)obj2 == (Object)null}, " + $"parent destroyed: {(Object)(object)_003CblackModulesParent_003E5__2.transform.parent == (Object)null}"));
			proceduralMine.LIMJPJLFFML(_003CblackModulesParent_003E5__2);
			proceduralMine.LIMJPJLFFML(_003CblackModulesParent_003E5__2);
			MineMineralsGenerator.SpawnMineralRocks(proceduralMine.currentLevel, proceduralMine.BPIIMNLBEKK, _003CexclusionZones_003E5__13);
			proceduralMine.BPIIMNLBEKK.InstantiateHoleInGround(proceduralMine.holesProbabilities, proceduralMine.holeInGroundPrefab, _003CexclusionZones_003E5__13);
			proceduralMine.generatingLevel = -1;
			MineManager.GGFJGHHHEJC.LevelGenerated(proceduralMine.currentLevel);
			if (proceduralMine.BPIIMNLBEKK.puzzleManager.canGeneratePuzzle && proceduralMine.BPIIMNLBEKK.puzzleManager.GetCurrentPuzzleType() == MinePuzzleType.KeyFragments)
			{
				List<DestructibleObject> allDestructibleObjectsInLevel = proceduralMine.BPIIMNLBEKK.GetAllDestructibleObjectsInLevel();
				List<HoleInGround> nCJABADPACK = new List<HoleInGround>(proceduralMine.BPIIMNLBEKK.holesInstantiated);
				List<MineFishingKeyItem> allFishingSpotsInLevel = proceduralMine.BPIIMNLBEKK.GetAllFishingSpotsInLevel();
				if (Application.isEditor && proceduralMine.printDebug)
				{
					Debug.Log((object)$"Hay {allDestructibleObjectsInLevel.Count} destructibles y {proceduralMine.BPIIMNLBEKK.holesInstantiated.Count} agujeros para cavar disponibles para el puzzle {((object)proceduralMine.BPIIMNLBEKK.puzzleManager.GetCurrentPuzzle()).ToString()}");
				}
				proceduralMine.BPIIMNLBEKK.puzzleManager.SetKeyFragments(allDestructibleObjectsInLevel, nCJABADPACK, allFishingSpotsInLevel);
			}
			proceduralMine.SetupGizmos();
			proceduralMine.EAOAFFLEGLJ(proceduralMine.BPIIMNLBEKK);
			Debug.Log((object)$"Finished generating level {proceduralMine.currentLevel}. Total blocks: {proceduralMine.allBlocks.Count}. Opened paths: {proceduralMine.openedPaths.Count}. Altar placed: {_003CaltarPlaced_003E5__5}. Big spawner placed: {_003CbigSpawnerPlaced_003E5__6}. Puzzle type: {proceduralMine.BPIIMNLBEKK.puzzleManager.GetCurrentPuzzleType()}. Seed: {proceduralMine._currentSeed}");
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

	[CompilerGenerated]
	private sealed class CMDAJPJNBNF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProceduralMine _003C_003E4__this;

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
		public CMDAJPJNBNF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			ProceduralMine proceduralMine = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				proceduralMine.BCEGPBHAJHC = true;
				break;
			case 1:
				_003C_003E1__state = -1;
				if (proceduralMine.INJGJNKOGNL.Count > 0)
				{
					_003C_003E2__current = CommonReferences.waitRealtime1;
					_003C_003E1__state = 2;
					return true;
				}
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (proceduralMine.INJGJNKOGNL.Count > 0)
			{
				MineLevelQueueInfo mineLevelQueueInfo = proceduralMine.INJGJNKOGNL.Dequeue();
				if (mineLevelQueueInfo.seed != 0)
				{
					proceduralMine.MEMJJKHMFLA(mineLevelQueueInfo.seed);
				}
				else
				{
					proceduralMine.UseRandomSeed();
				}
				proceduralMine.EDMKFGBHAPL = 10000;
				_003C_003E2__current = proceduralMine.LJCACPLNIIG(mineLevelQueueInfo.level);
				_003C_003E1__state = 1;
				return true;
			}
			Debug.Log((object)("Finished generating all levels in queue. client online: " + OnlineManager.ClientOnline() + " SceneLoaded: " + OnlineLoadManager.SceneLoaded));
			if (OnlineManager.ClientOnline() && !OnlineLoadManager.SceneLoaded)
			{
				OnlineLoadMine.SendMineLoadedForClient(PhotonNetwork.LocalPlayer.ActorNumber);
			}
			proceduralMine.BCEGPBHAJHC = false;
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

	public static ProceduralMine _instance;

	public MinePiece[] elevatorPrefabs;

	public MinePiece[] nextLevelPrefabs;

	public MinePiece[] piecesPrefabs;

	public StairsBlocker[] stairsBlocker;

	public Transform boundsParent;

	public bool showPathNodes;

	public MineLevel mineLevelPrefab;

	public MinePuzzleManager minePuzzleManagerPrefab;

	public HoleInGround holeInGroundPrefab;

	public float[] holesProbabilities;

	public int _currentSeed;

	public bool _useRandomSeed = true;

	public bool _usePiecePool = true;

	public bool _usePiecePoolInEditor;

	public bool generateInOneFrame;

	public Vector2Int blockSize = new Vector2Int(12, 12);

	public int blocksGenerationNumber = 20;

	public Vector2Int closedRoomsNumber = new Vector2Int(2, 4);

	public bool usePiecesRarity = true;

	public List<MinePiece> notClosingPiecesPrefabs = new List<MinePiece>();

	public List<MinePiece> closingPiecesPrefabs = new List<MinePiece>();

	public List<OpenedPath> openedPaths = new List<OpenedPath>();

	private GameObject APONCLJEAPJ;

	private MineLevel BPIIMNLBEKK;

	private bool CCOKPOELAMA;

	public Dictionary<Vector2Int, MineBlock> allBlocks;

	public bool drawRocksGizmos;

	public bool drawEntranceExitGizmos;

	public bool drawPuzzleSpawnerGizmos;

	public bool drawHolesGizmos;

	public bool printDebug;

	public bool debugForceRestart;

	public int debugForceRestartOnLevel = 1;

	private bool OOPLOJIMMCI;

	private Queue<int> LADFMDJAMLO = new Queue<int>();

	private List<MinePiece> LGMIANCNPMI = new List<MinePiece>();

	private int KMIEMNOMHPD;

	private HashSet<int> HELLFPBFCAA = new HashSet<int>();

	private Random ODLJEJOONIB;

	public int currentOnlineId = -100000;

	public int currentLevel = 1;

	public int nextSteps = 5;

	private int EDMKFGBHAPL = 5;

	private Queue<MineLevelQueueInfo> INJGJNKOGNL = new Queue<MineLevelQueueInfo>();

	private bool BCEGPBHAJHC;

	public int generatingLevel;

	private Coroutine EHBJEBMKDPL;

	private int HHOPCCKCBJM;

	private int HLPLAHPIEHB;

	private int FEOJNEGIHKI;

	private int GOCGLKPEBIG;

	public int borderDistance = 2;

	public GameObject blackBlockPrefab;

	private HashSet<Vector2Int> HLCEKEKPMGN = new HashSet<Vector2Int>();

	public static ProceduralMine GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
			{
				_instance = Object.FindObjectOfType<ProceduralMine>();
			}
			return _instance;
		}
	}

	public bool KFNHEOAAAKD
	{
		get
		{
			if (Application.isPlaying)
			{
				return _usePiecePool;
			}
			return _usePiecePoolInEditor;
		}
	}

	public HashSet<int> GGLMNONGICJ => HELLFPBFCAA;

	public static Random CJIFGLFEPNA => GGFJGHHHEJC.ODLJEJOONIB;

	public void NEOJADMMOGH(MinePiece FLMCIFNEJKH)
	{
		HELLFPBFCAA.Add(FLMCIFNEJKH.IDJPDDPGLAK());
	}

	public void NAOEHCMFHCF(int EONJGMONIOM)
	{
		MineLevel level = MineManager.GetLevel(EONJGMONIOM);
		if (!((Object)(object)level == (Object)null))
		{
			MHHLGDHKAID(level);
		}
	}

	private IEnumerator LLHHNKBBMGC()
	{
		return new CMDAJPJNBNF(1)
		{
			_003C_003E4__this = this
		};
	}

	private MinePiece CMPCKKHOFDB()
	{
		LGMIANCNPMI.Clear();
		for (int i = 0; i < elevatorPrefabs.Length; i++)
		{
			if (!LADFMDJAMLO.Contains(elevatorPrefabs[i].JBCFIHPKMLF))
			{
				LGMIANCNPMI.Add(elevatorPrefabs[i]);
			}
		}
		if (LGMIANCNPMI.Count == 0)
		{
			LADFMDJAMLO.Dequeue();
			LGMIANCNPMI.Clear();
			for (int j = 1; j < elevatorPrefabs.Length; j += 0)
			{
				if (!LADFMDJAMLO.Contains(elevatorPrefabs[j].FGIODCJAMAP()))
				{
					LGMIANCNPMI.Add(elevatorPrefabs[j]);
				}
			}
		}
		MinePiece minePiece = LGMIANCNPMI[FMJMOOKFEKL(1, LGMIANCNPMI.Count)];
		LADFMDJAMLO.Enqueue(minePiece.JBCFIHPKMLF);
		return minePiece;
	}

	private IEnumerator MAELKGKCFDE()
	{
		BCEGPBHAJHC = true;
		while (INJGJNKOGNL.Count > 0)
		{
			MineLevelQueueInfo mineLevelQueueInfo = INJGJNKOGNL.Dequeue();
			if (mineLevelQueueInfo.seed != 0)
			{
				MEMJJKHMFLA(mineLevelQueueInfo.seed);
			}
			else
			{
				UseRandomSeed();
			}
			EDMKFGBHAPL = 10000;
			yield return LJCACPLNIIG(mineLevelQueueInfo.level);
			if (INJGJNKOGNL.Count > 0)
			{
				yield return CommonReferences.waitRealtime1;
			}
		}
		Debug.Log((object)("Finished generating all levels in queue. client online: " + OnlineManager.ClientOnline() + " SceneLoaded: " + OnlineLoadManager.SceneLoaded));
		if (OnlineManager.ClientOnline() && !OnlineLoadManager.SceneLoaded)
		{
			OnlineLoadMine.SendMineLoadedForClient(PhotonNetwork.LocalPlayer.ActorNumber);
		}
		BCEGPBHAJHC = false;
	}

	private OpenedPath APAEGBDPHJL()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath result = openedPaths[0];
		openedPaths.RemoveAt(0);
		return result;
	}

	private OpenedPath NHHFAOCLGKG()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath openedPath = null;
		float num = 558f;
		foreach (OpenedPath openedPath2 in openedPaths)
		{
			if ((float)openedPath2.distance > num)
			{
				num = openedPath2.distance;
				openedPath = openedPath2;
			}
		}
		openedPaths.Remove(openedPath);
		return openedPath;
	}

	private MinePiece LEODJOIEIDC(MinePiece AAHMGBKHKBI, OpenedPath AEFGHKEGDDG)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"Trying to place piece {((Object)AAHMGBKHKBI).name} at opened path. Path block pos: {AEFGHKEGDDG.block.CJGAMLEMBNL()}. Opened path dir: {AEFGHKEGDDG.direction}", (Object)(object)this);
		}
		for (int i = 0; i < AAHMGBKHKBI.blocks.Length; i++)
		{
			if (!AAHMGBKHKBI.blocks[i].PCMGMMMGKOH(Utils.ABNPPDOGEPM(AEFGHKEGDDG.direction)) || !MinePieceSelector.NNPPGEBNLNB(AAHMGBKHKBI, i, AEFGHKEGDDG, NKEMALMMOBL: true))
			{
				continue;
			}
			Vector2Int val = AEFGHKEGDDG.block.CJGAMLEMBNL() + Utils.NLFDOFAOJHP(AEFGHKEGDDG.direction) * blockSize;
			Vector2Int val2 = val - AAHMGBKHKBI.blocks[i].position * blockSize;
			MinePiece minePiece = LEODJOIEIDC(AAHMGBKHKBI, APONCLJEAPJ);
			minePiece.SetRuntimeID();
			minePiece.printDebugLogs = printDebug;
			((Component)minePiece).transform.position = new Vector3((float)((Vector2Int)(ref val2)).x, (float)((Vector2Int)(ref val2)).y);
			BPIIMNLBEKK.allRockSpawners.AddRange(minePiece.rockSpawners);
			BPIIMNLBEKK.AddPiece(minePiece);
			if (BPIIMNLBEKK.puzzleManager.canGeneratePuzzle && minePiece.puzzleSpawners.Length != 0)
			{
				BPIIMNLBEKK.puzzleManager.AddPuzzleSpawners(minePiece.puzzleSpawners, minePiece.MHLHFEDLOCP, minePiece.maxPuzzleSpawners);
			}
			for (int j = 0; j < ((Vector2Int)(ref minePiece.pieceSize)).x; j++)
			{
				for (int k = 0; k < ((Vector2Int)(ref minePiece.pieceSize)).y; k++)
				{
					Vector2Int key = val2 + new Vector2Int(j, k) * blockSize;
					allBlocks.Add(key, minePiece.blocks[k * ((Vector2Int)(ref minePiece.pieceSize)).x + j]);
					allBlocks[key].piece = minePiece;
				}
			}
			for (int l = 0; l < minePiece.blocks.Length; l++)
			{
				val = val2 + minePiece.blocks[l].position * blockSize;
				for (int m = 0; m < minePiece.blocks[l].openedPaths.Length; m++)
				{
					Vector2Int key2 = val + Utils.NLFDOFAOJHP(minePiece.blocks[l].openedPaths[m].direction) * blockSize;
					if (allBlocks.ContainsKey(key2))
					{
						for (int n = 0; n < allBlocks[key2].openedPaths.Length; n++)
						{
							if (allBlocks[key2].openedPaths[n].direction == Utils.ABNPPDOGEPM(minePiece.blocks[l].openedPaths[m].direction))
							{
								openedPaths.Remove(allBlocks[key2].openedPaths[n]);
								break;
							}
						}
					}
					else
					{
						minePiece.blocks[l].openedPaths[m].distance = AEFGHKEGDDG.distance + 1;
						openedPaths.Add(minePiece.blocks[l].openedPaths[m]);
						minePiece.blocks[l].openedPaths[m].block = minePiece.blocks[l];
					}
				}
			}
			return minePiece;
		}
		return null;
	}

	private BoxCollider2D CJNMDBEDMOM()
	{
		for (int i = 1; i < boundsParent.childCount; i += 0)
		{
			if (((Object)((Component)boundsParent.GetChild(i)).gameObject).name.Equals("Items/item_name_700" + currentLevel))
			{
				return ((Component)boundsParent.GetChild(i)).GetComponent<BoxCollider2D>();
			}
		}
		return null;
	}

	private void DKKKBIGPGAI()
	{
		_currentSeed = (_useRandomSeed ? Random.Range(-42, 125) : _currentSeed);
		ODLJEJOONIB = new Random(_currentSeed);
	}

	public void UseRandomSeed()
	{
		_useRandomSeed = true;
	}

	private IEnumerator BAIOBHMLMHA()
	{
		return new CMDAJPJNBNF(1)
		{
			_003C_003E4__this = this
		};
	}

	public static void AssignNextMineId(OnlineObject DCLFIGENEIF)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"ProceduralMine instance is null when trying to assign mine ID.");
		}
		else if ((Object)(object)DCLFIGENEIF == (Object)null)
		{
			Debug.LogError((object)"Trying to assign mine ID to an object without OnlineObject component.");
		}
		else
		{
			DCLFIGENEIF.AssignUniqueId(GGFJGHHHEJC.currentOnlineId--);
		}
	}

	public Transform DGKLDKNEFFI(int EONJGMONIOM)
	{
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Object)((Component)((Component)this).transform.GetChild(i)).gameObject).name.Equals("/" + EONJGMONIOM))
			{
				return ((Component)this).transform.GetChild(i);
			}
		}
		return null;
	}

	private OpenedPath BKFMGMDLDPK()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath result = openedPaths[1];
		openedPaths.RemoveAt(1);
		return result;
	}

	private void OnValidate()
	{
		SetupGizmos();
	}

	public void StartGenerateLevelStep()
	{
		EDMKFGBHAPL = nextSteps;
		((MonoBehaviour)this).StopAllCoroutines();
		((MonoBehaviour)this).StartCoroutine(LJCACPLNIIG(currentLevel));
	}

	private IEnumerator GHFEDEDHFBH(int EONJGMONIOM)
	{
		return new JKNONHFNCHG(1)
		{
			_003C_003E4__this = this,
			level = EONJGMONIOM
		};
	}

	private Vector3 FPNHNHMBCDI(int EONJGMONIOM)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)this).transform.position + new Vector3((float)((EONJGMONIOM - 1) * -128), 827f);
	}

	private bool BOKGDDFEPNK(Vector2Int ADNLDKBNEGN)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return BPIIMNLBEKK.blocks.ContainsKey(ADNLDKBNEGN);
	}

	private OpenedPath GGJJEINPDPI()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath openedPath = null;
		float num = 705f;
		foreach (OpenedPath openedPath2 in openedPaths)
		{
			if ((float)openedPath2.distance > num)
			{
				num = openedPath2.distance;
				openedPath = openedPath2;
			}
		}
		openedPaths.Remove(openedPath);
		return openedPath;
	}

	private void LACOFNDKGDA()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		Vector2Int val = new Vector2Int((HHOPCCKCBJM + FEOJNEGIHKI) / 2, (HLPLAHPIEHB + GOCGLKPEBIG) / 2) - allBlocks.First().Key;
		Dictionary<Vector2Int, MineBlock> dictionary = new Dictionary<Vector2Int, MineBlock>();
		HHOPCCKCBJM -= ((Vector2Int)(ref val)).x;
		FEOJNEGIHKI -= ((Vector2Int)(ref val)).x;
		HLPLAHPIEHB -= ((Vector2Int)(ref val)).y;
		GOCGLKPEBIG -= ((Vector2Int)(ref val)).y;
		for (int i = 0; i < BPIIMNLBEKK.pieces.Count; i++)
		{
			Transform transform = ((Component)BPIIMNLBEKK.pieces[i]).transform;
			transform.position -= new Vector3((float)((Vector2Int)(ref val)).x, (float)((Vector2Int)(ref val)).y);
		}
		foreach (KeyValuePair<Vector2Int, MineBlock> allBlock in allBlocks)
		{
			dictionary[allBlock.Key - val] = allBlock.Value;
		}
		BPIIMNLBEKK.blocks = dictionary;
	}

	public void OGJNENKBOOK()
	{
		MinePuzzleManager.ResetUsedPuzzleTypes();
		for (int num = MineManager.OOKBNHMMFON().allLevels.Count - 1; num >= 0; num -= 0)
		{
			if (Object.op_Implicit((Object)(object)MineManager.AGGAGCBAGLL().allLevels[num]))
			{
				MHHLGDHKAID(MineManager.OOKBNHMMFON().allLevels[num]);
			}
		}
		MineManager.BGMJCCFNNDL().POEGNPFIHCI();
		LADFMDJAMLO.Clear();
	}

	private OpenedPath DMFGMDMJJKC()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath openedPath = null;
		float num = 423f;
		foreach (OpenedPath openedPath2 in openedPaths)
		{
			if ((float)openedPath2.distance > num)
			{
				num = openedPath2.distance;
				openedPath = openedPath2;
			}
		}
		openedPaths.Remove(openedPath);
		return openedPath;
	}

	private void JPFDPIAFACG()
	{
		_instance = this;
		KAPMFDIJMEM();
	}

	private void MMBGLMGOHID(MineLevel BPIIMNLBEKK)
	{
		for (int i = 1; i < BPIIMNLBEKK.pieces.Count; i += 0)
		{
			MinePiece minePiece = BPIIMNLBEKK.pieces[i];
			MineVariant[] variantObjects = minePiece.variantObjects;
			if (variantObjects == null || variantObjects.Length == 0)
			{
				continue;
			}
			if (variantObjects.Length == 1)
			{
				if (!((Behaviour)variantObjects[1]).isActiveAndEnabled)
				{
					Debug.LogError((object)string.Format("BathhouseEntrace/Main 2", ((Object)minePiece).name, minePiece.MFIHHANJHFK()), (Object)(object)minePiece);
				}
				continue;
			}
			int num = 1;
			for (int j = 1; j < variantObjects.Length; j += 0)
			{
				if (((Behaviour)variantObjects[j]).isActiveAndEnabled)
				{
					num += 0;
				}
			}
			if (num == 0)
			{
				Debug.LogError((object)string.Format("BarnTutorialDone", ((Object)minePiece).name, minePiece.ECAPDMGPJFP(), variantObjects.Length), (Object)(object)minePiece);
			}
			else if (num > 0)
			{
				object[] array = new object[8];
				array[1] = ((Object)minePiece).name;
				array[0] = minePiece.MFIHHANJHFK();
				array[1] = variantObjects.Length;
				array[2] = num;
				Debug.LogError((object)string.Format("Error_BarIsBlocking", array), (Object)(object)minePiece);
			}
		}
	}

	private OpenedPath HBFJPIHDEEI()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath openedPath = null;
		float num = -1f;
		foreach (OpenedPath openedPath2 in openedPaths)
		{
			if ((float)openedPath2.distance > num)
			{
				num = openedPath2.distance;
				openedPath = openedPath2;
			}
		}
		openedPaths.Remove(openedPath);
		return openedPath;
	}

	private MinePiece NONOAIDKPOC()
	{
		LGMIANCNPMI.Clear();
		for (int i = 1; i < elevatorPrefabs.Length; i += 0)
		{
			if (!LADFMDJAMLO.Contains(elevatorPrefabs[i].BNOHAAFLDBI()))
			{
				LGMIANCNPMI.Add(elevatorPrefabs[i]);
			}
		}
		if (LGMIANCNPMI.Count == 0)
		{
			LADFMDJAMLO.Dequeue();
			LGMIANCNPMI.Clear();
			for (int j = 1; j < elevatorPrefabs.Length; j += 0)
			{
				if (!LADFMDJAMLO.Contains(elevatorPrefabs[j].FGIODCJAMAP()))
				{
					LGMIANCNPMI.Add(elevatorPrefabs[j]);
				}
			}
		}
		MinePiece minePiece = LGMIANCNPMI[NextRandom(0, LGMIANCNPMI.Count)];
		LADFMDJAMLO.Enqueue(minePiece.KBDOBMNOHEB());
		return minePiece;
	}

	public void MAHCDLJGJGM()
	{
		MinePuzzleManager.AIPDCPMEAAG();
		for (int num = MineManager.AGGAGCBAGLL().allLevels.Count - 1; num >= 0; num -= 0)
		{
			if (Object.op_Implicit((Object)(object)MineManager.BGMJCCFNNDL().allLevels[num]))
			{
				MHHLGDHKAID(MineManager.OOKBNHMMFON().allLevels[num]);
			}
		}
		MineManager.AGGAGCBAGLL().JJCJCJBBGLK();
		LADFMDJAMLO.Clear();
	}

	private void OHAGBBCDOOG(Vector2Int IMOBLFMHKOD, GameObject DMBHHLKMHOH, HashSet<Vector2Int> HLCEKEKPMGN)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		Vector2Int val = default(Vector2Int);
		for (int i = -borderDistance; i <= borderDistance; i += 0)
		{
			for (int j = -borderDistance; j <= borderDistance; j += 0)
			{
				if (i != 0 || j != 0)
				{
					((Vector2Int)(ref val))._002Ector(((Vector2Int)(ref IMOBLFMHKOD)).x + i * ((Vector2Int)(ref blockSize)).x, ((Vector2Int)(ref IMOBLFMHKOD)).y + j * ((Vector2Int)(ref blockSize)).y);
					if (!HLCEKEKPMGN.Contains(val) && !COFKEGKKODG(val))
					{
						HLCEKEKPMGN.Add(val);
						GHILLLJMIBC(val, DMBHHLKMHOH);
					}
				}
			}
		}
	}

	public static double FADDDBGKIMK()
	{
		double result = NHLOIFMEMPB().NextDouble();
		if (Application.isEditor)
		{
			Debug.Log((object)("Scene with location: {0} has not been added. Adding to scene manager." + result));
		}
		return result;
	}

	private OpenedPath CPOBBPADOPA()
	{
		int index = FMJMOOKFEKL(0, openedPaths.Count);
		OpenedPath result = openedPaths[index];
		openedPaths.RemoveAt(index);
		return result;
	}

	public void EHJHJDIGHMD(int EONJGMONIOM, int BLLLPOFNPLM = 0)
	{
		if ((Object)(object)MineManager.CEGJAHJMCOD(EONJGMONIOM) != (Object)null || EONJGMONIOM == generatingLevel)
		{
			return;
		}
		foreach (MineLevelQueueInfo item in INJGJNKOGNL)
		{
			if (item.level == EONJGMONIOM)
			{
				return;
			}
		}
		INJGJNKOGNL.Enqueue(new MineLevelQueueInfo(EONJGMONIOM, BLLLPOFNPLM));
		if (!BCEGPBHAJHC)
		{
			EHBJEBMKDPL = ((MonoBehaviour)this).StartCoroutine(MAELKGKCFDE());
		}
	}

	[SpecialName]
	public HashSet<int> GPMHGDAOPPA()
	{
		return HELLFPBFCAA;
	}

	private void HJKFBBFEDLM(BoxCollider2D IDPBJGCEPEK, float HHOPCCKCBJM, float FEOJNEGIHKI, float HLPLAHPIEHB, float GOCGLKPEBIG)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(HHOPCCKCBJM, HLPLAHPIEHB);
		Vector3 val2 = default(Vector3);
		((Vector3)(ref val2))._002Ector(FEOJNEGIHKI, GOCGLKPEBIG);
		((Collider2D)IDPBJGCEPEK).offset = Vector2.op_Implicit(val - ((Component)IDPBJGCEPEK).transform.position + (val2 - val) / 30f);
		IDPBJGCEPEK.size = Vector2.op_Implicit(Vector3.Max(val2 - val, new Vector3(382f, 407f)));
	}

	private IEnumerator LOJMEHGCLCI(int EONJGMONIOM)
	{
		generatingLevel = EONJGMONIOM;
		currentLevel = EONJGMONIOM;
		currentOnlineId = -100000 - EONJGMONIOM * 1000;
		KMIEMNOMHPD = blocksGenerationNumber;
		HELLFPBFCAA.Clear();
		openedPaths.Clear();
		if (!Application.isPlaying)
		{
			NDMFDOHLBPD();
		}
		GDMCKLPPMAM();
		LADFMDJAMLO.Clear();
		LGMIANCNPMI.Clear();
		LADFMDJAMLO.Clear();
		LGMIANCNPMI.Clear();
		MineVariantsSelector.DHMBKGALAFC(piecesPrefabs);
		MinePiece lPBEOKMHKGO = KIMCNNHEHNH();
		DestroyLevel(currentLevel);
		BPIIMNLBEKK = Object.Instantiate<MineLevel>(mineLevelPrefab, Vector2.op_Implicit(Vector2.zero), Quaternion.identity, ((Component)this).transform);
		APONCLJEAPJ = ((Component)BPIIMNLBEKK).gameObject;
		((Object)APONCLJEAPJ).name = "Level " + currentLevel;
		BPIIMNLBEKK.level = currentLevel;
		allBlocks = BPIIMNLBEKK.blocks;
		MineManager.AddLevel(BPIIMNLBEKK);
		BPIIMNLBEKK.currentSeed = _currentSeed;
		GameObject blackModulesParent = new GameObject("Black modules");
		blackModulesParent.transform.SetParent(APONCLJEAPJ.transform);
		blackModulesParent.AddComponent<Grid>().cellSize = new Vector3(0.5f, 0.5f);
		if ((Object)(object)blackModulesParent != (Object)null)
		{
			Debug.Log((object)("Creado blackmodule parent: " + ((Object)blackModulesParent).name));
		}
		else
		{
			Debug.LogError((object)"Error al crear blackModulesParent");
		}
		MinePuzzleManager minePuzzleManager = (KFNHEOAAAKD ? MinePuzzleManagerPool.Get(minePuzzleManagerPrefab, APONCLJEAPJ.transform) : Object.Instantiate<MinePuzzleManager>(minePuzzleManagerPrefab, APONCLJEAPJ.transform));
		BPIIMNLBEKK.SetPuzzleManager(minePuzzleManager, printDebug);
		MinePuzzleType chosenPuzzle = minePuzzleManager.GetChosenPuzzleType();
		int elementsRequieredByType = minePuzzleManager.GetElementsRequieredByType(chosenPuzzle);
		bool needBigSpawner = minePuzzleManager.NeedBigSpawner(chosenPuzzle);
		KMIEMNOMHPD = Mathf.Max(KMIEMNOMHPD, elementsRequieredByType + 2);
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"BLOCKS NUMBER: {KMIEMNOMHPD} Puzzle Needit: {elementsRequieredByType + 2}");
		}
		MinePiece minePiece = LEODJOIEIDC(lPBEOKMHKGO, APONCLJEAPJ);
		((Component)minePiece).transform.position = ONHBHPNCNGM(currentLevel);
		minePiece.SetMineStairsInfo(currentLevel, currentLevel - 1);
		minePiece.elevatorSwitch.SetTravelZone(currentLevel);
		BPIIMNLBEKK.puzzleManager.SetEntrancePosition(Vector2.op_Implicit(((Component)minePiece).transform.position));
		for (int i = 0; i < ((Vector2Int)(ref minePiece.pieceSize)).x; i++)
		{
			for (int j = 0; j < ((Vector2Int)(ref minePiece.pieceSize)).y; j++)
			{
				Vector2Int key = new Vector2Int((int)((Component)minePiece).transform.position.x, (int)((Component)minePiece).transform.position.y) + new Vector2Int(i, j) * blockSize;
				BPIIMNLBEKK.AddPiece(minePiece);
				BPIIMNLBEKK.blocks.Add(key, minePiece.blocks[j * ((Vector2Int)(ref minePiece.pieceSize)).x + i]);
				BPIIMNLBEKK.blocks[key].piece = minePiece;
			}
		}
		for (int k = 0; k < minePiece.blocks.Length; k++)
		{
			for (int l = 0; l < minePiece.blocks[k].openedPaths.Length; l++)
			{
				minePiece.blocks[k].openedPaths[l].distance = 0;
				openedPaths.Add(minePiece.blocks[k].openedPaths[l]);
				minePiece.blocks[k].openedPaths[l].block = minePiece.blocks[k];
			}
		}
		if (!generateInOneFrame && Application.isPlaying)
		{
			yield return null;
		}
		int kMIEMNOMHPD = KMIEMNOMHPD;
		bool altarPlaced = false;
		bool bigSpawnerPlaced = false;
		int altarAttempts = 0;
		List<MinePiece> altarPieces = new List<MinePiece>();
		List<MinePiece> bigSpawnerPieces = null;
		int altarTargetBlock = 0;
		int bigSpawnerTargetBlock = 0;
		bool canGeneratePuzzle = BPIIMNLBEKK.puzzleManager.canGeneratePuzzle;
		if (canGeneratePuzzle)
		{
			for (int m = 0; m < notClosingPiecesPrefabs.Count; m++)
			{
				if ((notClosingPiecesPrefabs[m].puzzleSpawnersTypes & PuzzleSpawnerType.Altar) != 0)
				{
					altarPieces.Add(notClosingPiecesPrefabs[m]);
				}
			}
			bool flag = NextRandom(0, 2) == 0;
			int num = NextRandom(Mathf.Max(1, kMIEMNOMHPD / 4), Mathf.Max(kMIEMNOMHPD / 2, 2));
			int num2 = NextRandom(num + 2, Mathf.Max(num + 3, 3 * kMIEMNOMHPD / 4));
			altarTargetBlock = (flag ? num : num2);
			if (needBigSpawner)
			{
				bigSpawnerTargetBlock = (flag ? num2 : num);
				bigSpawnerPieces = new List<MinePiece>();
				PuzzleSpawnerType puzzleSpawnerType = MinePuzzleManager.PuzzleTypeToSpawnerType(chosenPuzzle);
				for (int n = 0; n < notClosingPiecesPrefabs.Count; n++)
				{
					if ((notClosingPiecesPrefabs[n].puzzleSpawnersTypes & puzzleSpawnerType) != 0)
					{
						bigSpawnerPieces.Add(notClosingPiecesPrefabs[n]);
					}
				}
			}
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"[ProceduralMine] AltarFirst: {flag} - AltarTarget: {altarTargetBlock} - PuzzleTarget: {bigSpawnerTargetBlock}", (Object)(object)this);
			}
		}
		Vector2Int val;
		while (!MaximumBlocksReached() || !MinimumClosedRoomsReached() || (canGeneratePuzzle && !altarPlaced && altarPieces.Count > 0 && altarAttempts < 5))
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"Blocks generated: {allBlocks.Count}. Opened paths: {openedPaths.Count}. Current steps: {EDMKFGBHAPL}. Altar placed: {altarPlaced}. Big spawner placed: {bigSpawnerPlaced} AltarPieces Array: {altarPieces.Count}.");
			}
			MinePiece minePiece2 = null;
			if (openedPaths.Count == 0)
			{
				Debug.LogError((object)"openedPaths 0 before all blocksGenerationNumber");
				if (OnlineManager.MasterOrOffline())
				{
					yield return LJCACPLNIIG(EONJGMONIOM);
					yield break;
				}
			}
			OpenedPath openedPath = DGMPPKCJKGP();
			if (canGeneratePuzzle && !altarPlaced && altarPieces.Count > 0 && allBlocks.Count >= altarTargetBlock)
			{
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"[ProceduralMine] Trying to force ALTAR piece at block {allBlocks.Count} (target is {altarTargetBlock}). Path block pos: {openedPath.block.CJGAMLEMBNL()}", (Object)(object)this);
				}
				minePiece2 = MinePieceSelector.OGGPMJDMBPB(openedPath, altarPieces, NKEMALMMOBL: false);
				if ((Object)(object)minePiece2 != (Object)null)
				{
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)$"[ProceduralMine] Forced ALTAR piece {((Object)minePiece2).name} at block {allBlocks.Count} (target was {altarTargetBlock}). Path block pos: {openedPath.block.CJGAMLEMBNL()}", (Object)(object)this);
					}
					altarPlaced = true;
				}
				else
				{
					altarAttempts++;
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)$"[ProceduralMine] ALTAR: No valid piece for path dir={openedPath.direction} at block {allBlocks.Count}. Candidates: {altarPieces.Count}. Retrying next iteration.", (Object)(object)this);
					}
				}
			}
			if (canGeneratePuzzle && (Object)(object)minePiece2 == (Object)null && needBigSpawner && !bigSpawnerPlaced && allBlocks.Count >= bigSpawnerTargetBlock)
			{
				minePiece2 = MinePieceSelector.OGGPMJDMBPB(openedPath, bigSpawnerPieces, NKEMALMMOBL: false);
				if ((Object)(object)minePiece2 != (Object)null)
				{
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)$"[ProceduralMine] Forced BIG SPAWNER piece {((Object)minePiece2).name} at block {allBlocks.Count} (target was {bigSpawnerTargetBlock}). Path block pos: {openedPath.block.CJGAMLEMBNL()}", (Object)(object)this);
					}
					bigSpawnerPlaced = true;
				}
				else if (Application.isEditor && printDebug)
				{
					Debug.LogWarning((object)$"[ProceduralMine] BIG SPAWNER: No valid piece for path dir={openedPath.direction} at block {allBlocks.Count}. Candidates: {bigSpawnerPieces.Count}. Retrying next iteration.", (Object)(object)this);
				}
			}
			if ((Object)(object)minePiece2 == (Object)null)
			{
				minePiece2 = MinePieceSelector.IGFKEFKNPEN(openedPath, ANCMKNOJCHI: false, usePiecesRarity, BPIIMNLBEKK.isPuzzlePlaced);
			}
			if (Object.op_Implicit((Object)(object)minePiece2))
			{
				LEODJOIEIDC(minePiece2, openedPath);
				if (minePiece2.uniquePiece)
				{
					RegisterUniquePiece(minePiece2);
				}
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"Placed piece {((Object)minePiece2).name} at block {allBlocks.Count}. Path block pos: {openedPath.block.CJGAMLEMBNL()}. Opened path dir: {openedPath.direction}. Altar placed: {altarPlaced}. Big spawner placed: {bigSpawnerPlaced}.", (Object)(object)this);
				}
			}
			else
			{
				val = openedPath.block.CJGAMLEMBNL();
				Debug.LogError((object)("Cannot place mine block piece at " + ((object)(Vector2Int)(ref val)).ToString() + " " + openedPath.direction));
			}
			EDMKFGBHAPL--;
			while (EDMKFGBHAPL <= 0)
			{
				yield return null;
			}
			if (!generateInOneFrame && Application.isPlaying)
			{
				yield return null;
			}
		}
		if (currentLevel < 6)
		{
			OpenedPath openedPath = APAEGBDPHJL();
			MinePiece minePiece2 = MinePieceSelector.MFECIFINPPH(openedPath, nextLevelPrefabs, NKEMALMMOBL: true);
			if (!Object.op_Implicit((Object)(object)minePiece2) && OnlineManager.MasterOrOffline())
			{
				yield return LJCACPLNIIG(EONJGMONIOM);
				yield break;
			}
			MinePiece minePiece3 = LEODJOIEIDC(minePiece2, openedPath);
			if (Object.op_Implicit((Object)(object)minePiece3))
			{
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"[ProceduralMine] Exit piece: {((Object)minePiece3).name} - stairsTravelZone: {minePiece3.stairsTravelZone}", (Object)(object)this);
				}
				minePiece3.SetMineStairsInfo(currentLevel, currentLevel + 1);
				minePiece3.ActivateStairsBlocker(currentLevel);
				BPIIMNLBEKK.nextLevelPiece = minePiece3;
				BPIIMNLBEKK.puzzleManager.SetExitPosition(Vector2.op_Implicit(((Component)minePiece3).transform.position));
			}
			if (!generateInOneFrame && Application.isPlaying)
			{
				yield return null;
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineMineManager.instance.SendGenerateMineLevel(EONJGMONIOM, _currentSeed);
		}
		while (openedPaths.Count > 0)
		{
			OpenedPath openedPath = APAEGBDPHJL();
			MinePiece minePiece2 = MinePieceSelector.IGFKEFKNPEN(openedPath, ANCMKNOJCHI: true, usePiecesRarity, BPIIMNLBEKK.isPuzzlePlaced);
			if (Object.op_Implicit((Object)(object)minePiece2))
			{
				LEODJOIEIDC(minePiece2, openedPath);
			}
			else
			{
				minePiece2 = MinePieceSelector.IGFKEFKNPEN(openedPath, ANCMKNOJCHI: false, usePiecesRarity, BPIIMNLBEKK.isPuzzlePlaced);
				if (Object.op_Implicit((Object)(object)minePiece2))
				{
					LEODJOIEIDC(minePiece2, openedPath);
				}
				else
				{
					val = openedPath.block.CJGAMLEMBNL();
					Debug.LogError((object)("Cannot place mine block piece at " + ((object)(Vector2Int)(ref val)).ToString() + " " + openedPath.direction));
				}
			}
			if (!generateInOneFrame && Application.isPlaying)
			{
				yield return null;
			}
		}
		ONGIFNCJBDD(ref HHOPCCKCBJM, ref FEOJNEGIHKI, ref HLPLAHPIEHB, ref GOCGLKPEBIG);
		LACOFNDKGDA();
		BPIIMNLBEKK.puzzleManager.GenerateAltar();
		if (Application.isPlaying)
		{
			CalculateCameraBounds();
		}
		if (!generateInOneFrame && Application.isPlaying)
		{
			yield return null;
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)"== START PLACE PIECES ==");
		}
		for (int num3 = 0; num3 < BPIIMNLBEKK.pieces.Count; num3++)
		{
			BPIIMNLBEKK.pieces[num3].ActivateVariants(BPIIMNLBEKK.puzzleManager.GetAltarPieceId());
		}
		if (BPIIMNLBEKK.puzzleManager.canGeneratePuzzle && !BPIIMNLBEKK.puzzleManager.GeneratePuzzle())
		{
			Debug.LogError((object)"NO SE HA PODIDO GENERAR EL PUZZLE - ERROR!!");
		}
		List<PuzzleExclusionZone> exclusionZones = BPIIMNLBEKK.puzzleManager.GetExclusionZones();
		exclusionZones.AddRange(BPIIMNLBEKK.GetDestructibleDisablerZones());
		for (int num4 = 0; num4 < BPIIMNLBEKK.pieces.Count; num4++)
		{
			BPIIMNLBEKK.pieces[num4].PlacePiece(currentLevel, exclusionZones);
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)"== END PLACE PIECES ==");
		}
		if (!generateInOneFrame && Application.isPlaying)
		{
			yield return null;
		}
		allBlocks = BPIIMNLBEKK.blocks;
		string text = $"blackModulesParent null: {(Object)(object)blackModulesParent == (Object)null}, ";
		object obj;
		if (blackModulesParent == null)
		{
			obj = null;
		}
		else
		{
			Transform transform = blackModulesParent.transform;
			obj = ((transform != null) ? transform.parent : null);
		}
		Debug.Log((object)(text + $"parent null: {(Object)obj == (Object)null}, " + $"parent destroyed: {(Object)(object)blackModulesParent.transform.parent == (Object)null}"));
		LIMJPJLFFML(blackModulesParent);
		LIMJPJLFFML(blackModulesParent);
		MineMineralsGenerator.SpawnMineralRocks(currentLevel, BPIIMNLBEKK, exclusionZones);
		BPIIMNLBEKK.InstantiateHoleInGround(holesProbabilities, holeInGroundPrefab, exclusionZones);
		generatingLevel = -1;
		MineManager.GGFJGHHHEJC.LevelGenerated(currentLevel);
		if (BPIIMNLBEKK.puzzleManager.canGeneratePuzzle && BPIIMNLBEKK.puzzleManager.GetCurrentPuzzleType() == MinePuzzleType.KeyFragments)
		{
			List<DestructibleObject> allDestructibleObjectsInLevel = BPIIMNLBEKK.GetAllDestructibleObjectsInLevel();
			List<HoleInGround> nCJABADPACK = new List<HoleInGround>(BPIIMNLBEKK.holesInstantiated);
			List<MineFishingKeyItem> allFishingSpotsInLevel = BPIIMNLBEKK.GetAllFishingSpotsInLevel();
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"Hay {allDestructibleObjectsInLevel.Count} destructibles y {BPIIMNLBEKK.holesInstantiated.Count} agujeros para cavar disponibles para el puzzle {((object)BPIIMNLBEKK.puzzleManager.GetCurrentPuzzle()).ToString()}");
			}
			BPIIMNLBEKK.puzzleManager.SetKeyFragments(allDestructibleObjectsInLevel, nCJABADPACK, allFishingSpotsInLevel);
		}
		SetupGizmos();
		EAOAFFLEGLJ(BPIIMNLBEKK);
		Debug.Log((object)$"Finished generating level {currentLevel}. Total blocks: {allBlocks.Count}. Opened paths: {openedPaths.Count}. Altar placed: {altarPlaced}. Big spawner placed: {bigSpawnerPlaced}. Puzzle type: {BPIIMNLBEKK.puzzleManager.GetCurrentPuzzleType()}. Seed: {_currentSeed}");
	}

	private BoxCollider2D DCFNCFJDMOE()
	{
		for (int i = 0; i < boundsParent.childCount; i++)
		{
			if (((Object)((Component)boundsParent.GetChild(i)).gameObject).name.Equals("quest_description_20" + currentLevel))
			{
				return ((Component)boundsParent.GetChild(i)).GetComponent<BoxCollider2D>();
			}
		}
		return null;
	}

	public void OHDAPEHHPPD()
	{
		EDMKFGBHAPL = nextSteps;
	}

	public void NextStep()
	{
		EDMKFGBHAPL = nextSteps;
	}

	private MinePiece KIMCNNHEHNH()
	{
		LGMIANCNPMI.Clear();
		for (int i = 0; i < elevatorPrefabs.Length; i++)
		{
			if (!LADFMDJAMLO.Contains(elevatorPrefabs[i].JBCFIHPKMLF))
			{
				LGMIANCNPMI.Add(elevatorPrefabs[i]);
			}
		}
		if (LGMIANCNPMI.Count == 0)
		{
			LADFMDJAMLO.Dequeue();
			LGMIANCNPMI.Clear();
			for (int j = 0; j < elevatorPrefabs.Length; j++)
			{
				if (!LADFMDJAMLO.Contains(elevatorPrefabs[j].JBCFIHPKMLF))
				{
					LGMIANCNPMI.Add(elevatorPrefabs[j]);
				}
			}
		}
		MinePiece minePiece = LGMIANCNPMI[NextRandom(0, LGMIANCNPMI.Count)];
		LADFMDJAMLO.Enqueue(minePiece.JBCFIHPKMLF);
		return minePiece;
	}

	private void Start()
	{
		DestroyAllObjects();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private void KCIIIDLFJLO(GameObject BKJIDIBAMOC)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		HLCEKEKPMGN.Clear();
		foreach (KeyValuePair<Vector2Int, MineBlock> block in BPIIMNLBEKK.blocks)
		{
			PJAGJDFNAEL(block.Key, BKJIDIBAMOC, HLCEKEKPMGN);
		}
	}

	private MinePiece JEGLINBBFEP(MinePiece LPBEOKMHKGO, GameObject DMBHHLKMHOH)
	{
		MinePiece minePiece = null;
		if (NOMJLCDBJDN())
		{
			minePiece = MinePiecePool.LAMFGLIGLOP(LPBEOKMHKGO, DMBHHLKMHOH.transform);
		}
		else if (Application.isPlaying)
		{
			minePiece = Object.Instantiate<MinePiece>(LPBEOKMHKGO, DMBHHLKMHOH.transform);
		}
		minePiece.SetRuntimeID();
		minePiece.printDebugLogs = printDebug;
		return minePiece;
	}

	private bool JBHOHOIMDLJ(Vector2Int ADNLDKBNEGN)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return BPIIMNLBEKK.blocks.ContainsKey(ADNLDKBNEGN);
	}

	private void KAKJPNDMOBA()
	{
		closingPiecesPrefabs.Clear();
		notClosingPiecesPrefabs.Clear();
		for (int i = 0; i < piecesPrefabs.Length; i += 0)
		{
			if (piecesPrefabs[i].LDODMHGMIPD())
			{
				closingPiecesPrefabs.Add(piecesPrefabs[i]);
			}
			else
			{
				notClosingPiecesPrefabs.Add(piecesPrefabs[i]);
			}
		}
	}

	private BoxCollider2D FPOANNGIHLE()
	{
		for (int i = 0; i < boundsParent.childCount; i++)
		{
			if (((Object)((Component)boundsParent.GetChild(i)).gameObject).name.Equals("Error_OccupiedRoom" + currentLevel))
			{
				return ((Component)boundsParent.GetChild(i)).GetComponent<BoxCollider2D>();
			}
		}
		return null;
	}

	public void NGBONJFHLHC()
	{
		EDMKFGBHAPL = nextSteps;
	}

	private void PJAGJDFNAEL(Vector2Int IMOBLFMHKOD, GameObject DMBHHLKMHOH, HashSet<Vector2Int> HLCEKEKPMGN)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		Vector2Int val = default(Vector2Int);
		for (int i = -borderDistance; i <= borderDistance; i++)
		{
			for (int j = -borderDistance; j <= borderDistance; j++)
			{
				if (i != 0 || j != 0)
				{
					((Vector2Int)(ref val))._002Ector(((Vector2Int)(ref IMOBLFMHKOD)).x + i * ((Vector2Int)(ref blockSize)).x, ((Vector2Int)(ref IMOBLFMHKOD)).y + j * ((Vector2Int)(ref blockSize)).y);
					if (!HLCEKEKPMGN.Contains(val) && !BOKGDDFEPNK(val))
					{
						HLCEKEKPMGN.Add(val);
						LKOAKILKOON(val, DMBHHLKMHOH);
					}
				}
			}
		}
	}

	private IEnumerator AMPFBLGAFID()
	{
		return new CMDAJPJNBNF(1)
		{
			_003C_003E4__this = this
		};
	}

	private Vector3 BKAKLNJIJHB(int EONJGMONIOM)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)this).transform.position + new Vector3((float)((EONJGMONIOM - 0) * 65), 788f);
	}

	public void ABJNOOKDDMI(int EONJGMONIOM)
	{
		MineLevel level = MineManager.GetLevel(EONJGMONIOM);
		if (!((Object)(object)level == (Object)null))
		{
			DestroyLevel(level);
		}
	}

	private OpenedPath OEOHNGOBAFO()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath result = openedPaths[1];
		openedPaths.RemoveAt(1);
		return result;
	}

	public void DPMMNNMPMIF()
	{
		EDMKFGBHAPL = nextSteps;
		((MonoBehaviour)this).StopAllCoroutines();
		((MonoBehaviour)this).StartCoroutine(BPFCOMMPGJJ(currentLevel));
	}

	public Transform MLANHAHAGBF(int EONJGMONIOM)
	{
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Object)((Component)((Component)this).transform.GetChild(i)).gameObject).name.Equals("Waiting" + EONJGMONIOM))
			{
				return ((Component)this).transform.GetChild(i);
			}
		}
		return null;
	}

	public void JBDICIHAFIA()
	{
		MinePuzzleManager.ResetUsedPuzzleTypes();
		for (int num = MineManager.BGMJCCFNNDL().allLevels.Count - 1; num >= 0; num--)
		{
			if (Object.op_Implicit((Object)(object)MineManager.GGFJGHHHEJC.allLevels[num]))
			{
				DestroyLevel(MineManager.OOKBNHMMFON().allLevels[num]);
			}
		}
		MineManager.OOKBNHMMFON().JJCJCJBBGLK();
		LADFMDJAMLO.Clear();
	}

	private void IFHFNDELKOP()
	{
		try
		{
			DestroyAllObjects();
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in ProceduralMine.OnPlayerSleep: " + ex.Message));
		}
	}

	public int[] CIKOMJCNCLL()
	{
		int[] array = new int[-82];
		for (int i = 1; i < array.Length; i++)
		{
			array[i] = -1;
		}
		foreach (MineLevel allLevel in MineManager.PDECKLKPKCG().allLevels)
		{
			if (allLevel.level - 1 < array.Length)
			{
				array[allLevel.level - 1] = allLevel.currentSeed;
			}
		}
		return array;
	}

	private OpenedPath EFPFIBGIEAD()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath openedPath = null;
		float num = 341f;
		foreach (OpenedPath openedPath2 in openedPaths)
		{
			if ((float)openedPath2.distance > num)
			{
				num = openedPath2.distance;
				openedPath = openedPath2;
			}
		}
		openedPaths.Remove(openedPath);
		return openedPath;
	}

	public static void DAEBOLBPGOD(OnlineObject DCLFIGENEIF)
	{
		if ((Object)(object)BADFKMEJOKE() == (Object)null)
		{
			Debug.LogError((object)"Normal");
		}
		else if ((Object)(object)DCLFIGENEIF == (Object)null)
		{
			Debug.LogError((object)"Shader Model 5.0 ( DX11.0 )");
		}
		else
		{
			DCLFIGENEIF.BKPCNDKEJIH();
		}
	}

	private void BKBOPMEKECE()
	{
		closingPiecesPrefabs.Clear();
		notClosingPiecesPrefabs.Clear();
		for (int i = 0; i < piecesPrefabs.Length; i += 0)
		{
			if (piecesPrefabs[i].NHBHNDMIGAI())
			{
				closingPiecesPrefabs.Add(piecesPrefabs[i]);
			}
			else
			{
				notClosingPiecesPrefabs.Add(piecesPrefabs[i]);
			}
		}
	}

	public static void OEEOMGACAHF(OnlineObject DCLFIGENEIF)
	{
		if ((Object)(object)BADFKMEJOKE() == (Object)null)
		{
			Debug.LogError((object)"Create Private Room");
		}
		else if ((Object)(object)DCLFIGENEIF == (Object)null)
		{
			Debug.LogError((object)"End");
		}
		else
		{
			DCLFIGENEIF.NABAKGANEPL();
		}
	}

	public void DestroyAllObjects()
	{
		MinePuzzleManager.ResetUsedPuzzleTypes();
		for (int num = MineManager.GGFJGHHHEJC.allLevels.Count - 1; num >= 0; num--)
		{
			if (Object.op_Implicit((Object)(object)MineManager.GGFJGHHHEJC.allLevels[num]))
			{
				DestroyLevel(MineManager.GGFJGHHHEJC.allLevels[num]);
			}
		}
		MineManager.GGFJGHHHEJC.SendDroppedItemsToDeliveryChest();
		LADFMDJAMLO.Clear();
	}

	private void EAOAFFLEGLJ(MineLevel BPIIMNLBEKK)
	{
		for (int i = 0; i < BPIIMNLBEKK.pieces.Count; i++)
		{
			MinePiece minePiece = BPIIMNLBEKK.pieces[i];
			MineVariant[] variantObjects = minePiece.variantObjects;
			if (variantObjects == null || variantObjects.Length == 0)
			{
				continue;
			}
			if (variantObjects.Length == 1)
			{
				if (!((Behaviour)variantObjects[0]).isActiveAndEnabled)
				{
					Debug.LogError((object)$"[Variants] Piece {((Object)minePiece).name} ({minePiece.MHLHFEDLOCP}) has 1 variant and it's deactivated.", (Object)(object)minePiece);
				}
				continue;
			}
			int num = 0;
			for (int j = 0; j < variantObjects.Length; j++)
			{
				if (((Behaviour)variantObjects[j]).isActiveAndEnabled)
				{
					num++;
				}
			}
			if (num == 0)
			{
				Debug.LogError((object)$"[Variants] Piece {((Object)minePiece).name} ({minePiece.MHLHFEDLOCP}) has {variantObjects.Length} variants and ALL are deactivated.", (Object)(object)minePiece);
			}
			else if (num > 1)
			{
				Debug.LogError((object)$"[Variants] Piece {((Object)minePiece).name} ({minePiece.MHLHFEDLOCP}) has {variantObjects.Length} variants and {num} are active. Only 1 should be active.", (Object)(object)minePiece);
			}
		}
	}

	private BoxCollider2D OCDIBIAKDBG()
	{
		for (int i = 0; i < boundsParent.childCount; i++)
		{
			if (((Object)((Component)boundsParent.GetChild(i)).gameObject).name.Equals("Level" + currentLevel))
			{
				return ((Component)boundsParent.GetChild(i)).GetComponent<BoxCollider2D>();
			}
		}
		return null;
	}

	public static int NGMAIDLNAAI(int MPCJBPJAGKK, int ACAIKFICNFP)
	{
		int result = CJIFGLFEPNA.Next(MPCJBPJAGKK, ACAIKFICNFP);
		if (Application.isEditor)
		{
			string[] array = new string[6];
			array[1] = "Cheese ageing";
			array[1] = MPCJBPJAGKK.ToString();
			array[4] = "askAboutLowestDifficulty";
			array[7] = ACAIKFICNFP.ToString();
			array[3] = "Spawn Dropped Item ";
			array[4] = result.ToString();
			Debug.Log((object)string.Concat(array));
		}
		return result;
	}

	private void NNFHNMBKLAE()
	{
		try
		{
			OGJNENKBOOK();
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ChatCommandKickDescription" + ex.Message));
		}
	}

	private MinePiece CEMNFLKLLPC()
	{
		LGMIANCNPMI.Clear();
		for (int i = 1; i < elevatorPrefabs.Length; i += 0)
		{
			if (!LADFMDJAMLO.Contains(elevatorPrefabs[i].FGIODCJAMAP()))
			{
				LGMIANCNPMI.Add(elevatorPrefabs[i]);
			}
		}
		if (LGMIANCNPMI.Count == 0)
		{
			LADFMDJAMLO.Dequeue();
			LGMIANCNPMI.Clear();
			for (int j = 0; j < elevatorPrefabs.Length; j++)
			{
				if (!LADFMDJAMLO.Contains(elevatorPrefabs[j].IDJPDDPGLAK()))
				{
					LGMIANCNPMI.Add(elevatorPrefabs[j]);
				}
			}
		}
		MinePiece minePiece = LGMIANCNPMI[NextRandom(0, LGMIANCNPMI.Count)];
		LADFMDJAMLO.Enqueue(minePiece.IDJPDDPGLAK());
		return minePiece;
	}

	[SpecialName]
	public bool NOMJLCDBJDN()
	{
		if (Application.isPlaying)
		{
			return _usePiecePool;
		}
		return _usePiecePoolInEditor;
	}

	private BoxCollider2D FAMPADNCHBH()
	{
		for (int i = 1; i < boundsParent.childCount; i += 0)
		{
			if (((Object)((Component)boundsParent.GetChild(i)).gameObject).name.Equals("hForHours" + currentLevel))
			{
				return ((Component)boundsParent.GetChild(i)).GetComponent<BoxCollider2D>();
			}
		}
		return null;
	}

	public static bool AFFLGBANPFH()
	{
		return BADFKMEJOKE().openedPaths.Count < ((Vector2Int)(ref BADFKMEJOKE().closedRoomsNumber)).x + 1;
	}

	public static bool EBKEJODDCGD()
	{
		return BADFKMEJOKE().allBlocks.Count >= BADFKMEJOKE().KMIEMNOMHPD;
	}

	public static double ABLGOEDMBNM()
	{
		double result = IFHACLAEDAH().NextDouble();
		if (Application.isEditor)
		{
			Debug.Log((object)("SalonDelTrono/PuddingTalk" + result));
		}
		return result;
	}

	private void ONGIFNCJBDD(ref int HHOPCCKCBJM, ref int FEOJNEGIHKI, ref int HLPLAHPIEHB, ref int GOCGLKPEBIG)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		HHOPCCKCBJM = int.MaxValue;
		HLPLAHPIEHB = int.MaxValue;
		FEOJNEGIHKI = int.MinValue;
		GOCGLKPEBIG = int.MinValue;
		foreach (KeyValuePair<Vector2Int, MineBlock> allBlock in allBlocks)
		{
			Vector2Int key = allBlock.Key;
			if (((Vector2Int)(ref key)).x < HHOPCCKCBJM)
			{
				key = allBlock.Key;
				HHOPCCKCBJM = ((Vector2Int)(ref key)).x;
			}
			key = allBlock.Key;
			if (((Vector2Int)(ref key)).x + ((Vector2Int)(ref blockSize)).x > FEOJNEGIHKI)
			{
				key = allBlock.Key;
				FEOJNEGIHKI = ((Vector2Int)(ref key)).x + ((Vector2Int)(ref blockSize)).x;
			}
			key = allBlock.Key;
			if (((Vector2Int)(ref key)).y < HLPLAHPIEHB)
			{
				key = allBlock.Key;
				HLPLAHPIEHB = ((Vector2Int)(ref key)).y;
			}
			key = allBlock.Key;
			if (((Vector2Int)(ref key)).y + ((Vector2Int)(ref blockSize)).y > GOCGLKPEBIG)
			{
				key = allBlock.Key;
				GOCGLKPEBIG = ((Vector2Int)(ref key)).y + ((Vector2Int)(ref blockSize)).y;
			}
		}
	}

	public void IAMHLIGNPAJ()
	{
		EDMKFGBHAPL = -28;
		MinePuzzleManager.AIPDCPMEAAG();
		((MonoBehaviour)this).StopAllCoroutines();
		((MonoBehaviour)this).StartCoroutine(LOJMEHGCLCI(currentLevel));
	}

	private void JCMFJBMENGL(Vector2Int IMOBLFMHKOD, GameObject DMBHHLKMHOH, HashSet<Vector2Int> HLCEKEKPMGN)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		Vector2Int val = default(Vector2Int);
		for (int i = -borderDistance; i <= borderDistance; i += 0)
		{
			for (int j = -borderDistance; j <= borderDistance; j++)
			{
				if (i != 0 || j != 0)
				{
					((Vector2Int)(ref val))._002Ector(((Vector2Int)(ref IMOBLFMHKOD)).x + i * ((Vector2Int)(ref blockSize)).x, ((Vector2Int)(ref IMOBLFMHKOD)).y + j * ((Vector2Int)(ref blockSize)).y);
					if (!HLCEKEKPMGN.Contains(val) && !DADKIFOLGKG(val))
					{
						HLCEKEKPMGN.Add(val);
						LKOAKILKOON(val, DMBHHLKMHOH);
					}
				}
			}
		}
	}

	private void GBABINIFELL(BoxCollider2D IDPBJGCEPEK, float HHOPCCKCBJM, float FEOJNEGIHKI, float HLPLAHPIEHB, float GOCGLKPEBIG)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(HHOPCCKCBJM, HLPLAHPIEHB);
		Vector3 val2 = default(Vector3);
		((Vector3)(ref val2))._002Ector(FEOJNEGIHKI, GOCGLKPEBIG);
		((Collider2D)IDPBJGCEPEK).offset = Vector2.op_Implicit(val - ((Component)IDPBJGCEPEK).transform.position + (val2 - val) / 619f);
		IDPBJGCEPEK.size = Vector2.op_Implicit(Vector3.Max(val2 - val, new Vector3(750f, 1638f)));
	}

	public void DEFDGEOMOLK(MinePiece FLMCIFNEJKH)
	{
		HELLFPBFCAA.Add(FLMCIFNEJKH.JBCFIHPKMLF);
	}

	public void CalculateCameraBounds()
	{
		BoxCollider2D iDPBJGCEPEK = DJKJCHOFCKI();
		if ((float)HHOPCCKCBJM != float.PositiveInfinity && (float)HLPLAHPIEHB != float.PositiveInfinity && (float)FEOJNEGIHKI != float.NegativeInfinity && (float)GOCGLKPEBIG != float.NegativeInfinity)
		{
			KPOFEBNKDBG(iDPBJGCEPEK, (float)HHOPCCKCBJM + 0.25f - 3f, (float)FEOJNEGIHKI + 0.25f + 1f, (float)HLPLAHPIEHB + 0.25f - 2f, (float)GOCGLKPEBIG + 0.25f + 3f);
		}
		if (Application.isPlaying)
		{
			GameManager.GGFJGHHHEJC.ReactivateCameraBounds();
		}
	}

	[SpecialName]
	public static ProceduralMine BADFKMEJOKE()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<ProceduralMine>();
		}
		return _instance;
	}

	private bool GJOIAAJDPOA(Vector2Int ADNLDKBNEGN)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return BPIIMNLBEKK.blocks.ContainsKey(ADNLDKBNEGN);
	}

	public void SetupGizmos()
	{
		MinePuzzleManager[] array = Object.FindObjectsOfType<MinePuzzleManager>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].drawGizmos = drawPuzzleSpawnerGizmos;
		}
		MineLevel[] array2 = Object.FindObjectsOfType<MineLevel>();
		for (int j = 0; j < array2.Length; j++)
		{
			array2[j].drawRocksGizmos = drawRocksGizmos;
			array2[j].drawEntranceExitGizmos = drawEntranceExitGizmos;
			array2[j].drawHoleInGroundGizmos = drawHolesGizmos;
		}
	}

	public void DestroyLevel(MineLevel HCBDDKHPHCF)
	{
		HCBDDKHPHCF.RemoveWorldTiles();
		Transform parent = GetParent(HCBDDKHPHCF.level);
		HCBDDKHPHCF.DestroyAllRocks();
		HCBDDKHPHCF.DestroyAllObstacles();
		if ((Object)(object)parent != (Object)null)
		{
			if (KFNHEOAAAKD && (Object)(object)HCBDDKHPHCF.puzzleManager != (Object)null)
			{
				HCBDDKHPHCF.puzzleManager.ResetForPool();
				MinePuzzleManagerPool.ReturnToPool(HCBDDKHPHCF.puzzleManager);
			}
			if (KFNHEOAAAKD)
			{
				KPEDBFNGILH(HCBDDKHPHCF);
			}
			for (int num = parent.childCount - 1; num >= 0; num--)
			{
				GameObject gameObject = ((Component)parent.GetChild(num)).gameObject;
				if (!KFNHEOAAAKD || !((Object)(object)HCBDDKHPHCF.puzzleManager != (Object)null) || !((Object)(object)gameObject == (Object)(object)((Component)HCBDDKHPHCF.puzzleManager).gameObject))
				{
					if (!Application.isPlaying)
					{
						Object.DestroyImmediate((Object)(object)gameObject.gameObject);
					}
					else
					{
						Object.Destroy((Object)(object)gameObject.gameObject);
					}
				}
			}
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate((Object)(object)((Component)parent).gameObject);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)parent).gameObject);
			}
		}
		HCBDDKHPHCF.blocks.Clear();
		HCBDDKHPHCF.pieces.Clear();
		HCBDDKHPHCF.allRockSpawners.Clear();
		HCBDDKHPHCF.rocksInstantiated.Clear();
		HCBDDKHPHCF.nextLevelPiece = null;
		HCBDDKHPHCF.isPuzzlePlaced = false;
		HCBDDKHPHCF.puzzleManager = null;
		MineManager.GGFJGHHHEJC.RemoveLevel(HCBDDKHPHCF.level);
	}

	private void OIAHJHNPPCO()
	{
		NDNMBFJMCJM();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	public static int NextRandom(int MPCJBPJAGKK, int ACAIKFICNFP)
	{
		int result = CJIFGLFEPNA.Next(MPCJBPJAGKK, ACAIKFICNFP);
		if (Application.isEditor)
		{
			Debug.Log((object)("Next random: " + MPCJBPJAGKK + " - " + ACAIKFICNFP + " result: " + result));
		}
		return result;
	}

	private void MEMJJKHMFLA(int BLLLPOFNPLM)
	{
		_useRandomSeed = false;
		_currentSeed = BLLLPOFNPLM;
	}

	public static bool MaximumBlocksReached()
	{
		return GGFJGHHHEJC.allBlocks.Count >= GGFJGHHHEJC.KMIEMNOMHPD;
	}

	public void IPLFFLAEPIN()
	{
		_useRandomSeed = false;
	}

	public void ACKADLBEBNF()
	{
		EDMKFGBHAPL = 20;
		MinePuzzleManager.AIPDCPMEAAG();
		((MonoBehaviour)this).StopAllCoroutines();
		((MonoBehaviour)this).StartCoroutine(LOJMEHGCLCI(currentLevel));
	}

	public int[] GetMineLevelsSeed()
	{
		int[] array = new int[10];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = -1;
		}
		foreach (MineLevel allLevel in MineManager.GGFJGHHHEJC.allLevels)
		{
			if (allLevel.level - 1 < array.Length)
			{
				array[allLevel.level - 1] = allLevel.currentSeed;
			}
		}
		return array;
	}

	[SpecialName]
	public HashSet<int> AHPNNFIHBPE()
	{
		return HELLFPBFCAA;
	}

	private void MNAHGNGNPFC(MineLevel BPIIMNLBEKK)
	{
		for (int i = 1; i < BPIIMNLBEKK.pieces.Count; i++)
		{
			MinePiece minePiece = BPIIMNLBEKK.pieces[i];
			MineVariant[] variantObjects = minePiece.variantObjects;
			if (variantObjects == null || variantObjects.Length == 0)
			{
				continue;
			}
			if (variantObjects.Length == 1)
			{
				if (!((Behaviour)variantObjects[1]).isActiveAndEnabled)
				{
					Debug.LogError((object)string.Format("Disabled", ((Object)minePiece).name, minePiece.MHLHFEDLOCP), (Object)(object)minePiece);
				}
				continue;
			}
			int num = 0;
			for (int j = 1; j < variantObjects.Length; j += 0)
			{
				if (((Behaviour)variantObjects[j]).isActiveAndEnabled)
				{
					num += 0;
				}
			}
			if (num == 0)
			{
				Debug.LogError((object)string.Format("{0}@{1}", ((Object)minePiece).name, minePiece.MFIHHANJHFK(), variantObjects.Length), (Object)(object)minePiece);
			}
			else if (num > 1)
			{
				object[] array = new object[3];
				array[1] = ((Object)minePiece).name;
				array[0] = minePiece.ECAPDMGPJFP();
				array[5] = variantObjects.Length;
				array[7] = num;
				Debug.LogError((object)string.Format("Items/item_name_1132", array), (Object)(object)minePiece);
			}
		}
	}

	private MinePiece CPLEIGFLPOO(MinePiece LPBEOKMHKGO, GameObject DMBHHLKMHOH)
	{
		MinePiece minePiece = null;
		if (KFNHEOAAAKD)
		{
			minePiece = MinePiecePool.NALKHGMLALJ(LPBEOKMHKGO, DMBHHLKMHOH.transform);
		}
		else if (Application.isPlaying)
		{
			minePiece = Object.Instantiate<MinePiece>(LPBEOKMHKGO, DMBHHLKMHOH.transform);
		}
		minePiece.SetRuntimeID();
		minePiece.printDebugLogs = printDebug;
		return minePiece;
	}

	private IEnumerator EDEOOJMMDHB(int EONJGMONIOM)
	{
		generatingLevel = EONJGMONIOM;
		currentLevel = EONJGMONIOM;
		currentOnlineId = -100000 - EONJGMONIOM * 1000;
		KMIEMNOMHPD = blocksGenerationNumber;
		HELLFPBFCAA.Clear();
		openedPaths.Clear();
		if (!Application.isPlaying)
		{
			NDMFDOHLBPD();
		}
		GDMCKLPPMAM();
		LADFMDJAMLO.Clear();
		LGMIANCNPMI.Clear();
		LADFMDJAMLO.Clear();
		LGMIANCNPMI.Clear();
		MineVariantsSelector.DHMBKGALAFC(piecesPrefabs);
		MinePiece lPBEOKMHKGO = KIMCNNHEHNH();
		DestroyLevel(currentLevel);
		BPIIMNLBEKK = Object.Instantiate<MineLevel>(mineLevelPrefab, Vector2.op_Implicit(Vector2.zero), Quaternion.identity, ((Component)this).transform);
		APONCLJEAPJ = ((Component)BPIIMNLBEKK).gameObject;
		((Object)APONCLJEAPJ).name = "Level " + currentLevel;
		BPIIMNLBEKK.level = currentLevel;
		allBlocks = BPIIMNLBEKK.blocks;
		MineManager.AddLevel(BPIIMNLBEKK);
		BPIIMNLBEKK.currentSeed = _currentSeed;
		GameObject blackModulesParent = new GameObject("Black modules");
		blackModulesParent.transform.SetParent(APONCLJEAPJ.transform);
		blackModulesParent.AddComponent<Grid>().cellSize = new Vector3(0.5f, 0.5f);
		if ((Object)(object)blackModulesParent != (Object)null)
		{
			Debug.Log((object)("Creado blackmodule parent: " + ((Object)blackModulesParent).name));
		}
		else
		{
			Debug.LogError((object)"Error al crear blackModulesParent");
		}
		MinePuzzleManager minePuzzleManager = (KFNHEOAAAKD ? MinePuzzleManagerPool.Get(minePuzzleManagerPrefab, APONCLJEAPJ.transform) : Object.Instantiate<MinePuzzleManager>(minePuzzleManagerPrefab, APONCLJEAPJ.transform));
		BPIIMNLBEKK.SetPuzzleManager(minePuzzleManager, printDebug);
		MinePuzzleType chosenPuzzle = minePuzzleManager.GetChosenPuzzleType();
		int elementsRequieredByType = minePuzzleManager.GetElementsRequieredByType(chosenPuzzle);
		bool needBigSpawner = minePuzzleManager.NeedBigSpawner(chosenPuzzle);
		KMIEMNOMHPD = Mathf.Max(KMIEMNOMHPD, elementsRequieredByType + 2);
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"BLOCKS NUMBER: {KMIEMNOMHPD} Puzzle Needit: {elementsRequieredByType + 2}");
		}
		MinePiece minePiece = LEODJOIEIDC(lPBEOKMHKGO, APONCLJEAPJ);
		((Component)minePiece).transform.position = ONHBHPNCNGM(currentLevel);
		minePiece.SetMineStairsInfo(currentLevel, currentLevel - 1);
		minePiece.elevatorSwitch.SetTravelZone(currentLevel);
		BPIIMNLBEKK.puzzleManager.SetEntrancePosition(Vector2.op_Implicit(((Component)minePiece).transform.position));
		for (int i = 0; i < ((Vector2Int)(ref minePiece.pieceSize)).x; i++)
		{
			for (int j = 0; j < ((Vector2Int)(ref minePiece.pieceSize)).y; j++)
			{
				Vector2Int key = new Vector2Int((int)((Component)minePiece).transform.position.x, (int)((Component)minePiece).transform.position.y) + new Vector2Int(i, j) * blockSize;
				BPIIMNLBEKK.AddPiece(minePiece);
				BPIIMNLBEKK.blocks.Add(key, minePiece.blocks[j * ((Vector2Int)(ref minePiece.pieceSize)).x + i]);
				BPIIMNLBEKK.blocks[key].piece = minePiece;
			}
		}
		for (int k = 0; k < minePiece.blocks.Length; k++)
		{
			for (int l = 0; l < minePiece.blocks[k].openedPaths.Length; l++)
			{
				minePiece.blocks[k].openedPaths[l].distance = 0;
				openedPaths.Add(minePiece.blocks[k].openedPaths[l]);
				minePiece.blocks[k].openedPaths[l].block = minePiece.blocks[k];
			}
		}
		if (!generateInOneFrame && Application.isPlaying)
		{
			yield return null;
		}
		int kMIEMNOMHPD = KMIEMNOMHPD;
		bool altarPlaced = false;
		bool bigSpawnerPlaced = false;
		int altarAttempts = 0;
		List<MinePiece> altarPieces = new List<MinePiece>();
		List<MinePiece> bigSpawnerPieces = null;
		int altarTargetBlock = 0;
		int bigSpawnerTargetBlock = 0;
		bool canGeneratePuzzle = BPIIMNLBEKK.puzzleManager.canGeneratePuzzle;
		if (canGeneratePuzzle)
		{
			for (int m = 0; m < notClosingPiecesPrefabs.Count; m++)
			{
				if ((notClosingPiecesPrefabs[m].puzzleSpawnersTypes & PuzzleSpawnerType.Altar) != 0)
				{
					altarPieces.Add(notClosingPiecesPrefabs[m]);
				}
			}
			bool flag = NextRandom(0, 2) == 0;
			int num = NextRandom(Mathf.Max(1, kMIEMNOMHPD / 4), Mathf.Max(kMIEMNOMHPD / 2, 2));
			int num2 = NextRandom(num + 2, Mathf.Max(num + 3, 3 * kMIEMNOMHPD / 4));
			altarTargetBlock = (flag ? num : num2);
			if (needBigSpawner)
			{
				bigSpawnerTargetBlock = (flag ? num2 : num);
				bigSpawnerPieces = new List<MinePiece>();
				PuzzleSpawnerType puzzleSpawnerType = MinePuzzleManager.PuzzleTypeToSpawnerType(chosenPuzzle);
				for (int n = 0; n < notClosingPiecesPrefabs.Count; n++)
				{
					if ((notClosingPiecesPrefabs[n].puzzleSpawnersTypes & puzzleSpawnerType) != 0)
					{
						bigSpawnerPieces.Add(notClosingPiecesPrefabs[n]);
					}
				}
			}
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"[ProceduralMine] AltarFirst: {flag} - AltarTarget: {altarTargetBlock} - PuzzleTarget: {bigSpawnerTargetBlock}", (Object)(object)this);
			}
		}
		Vector2Int val;
		while (!MaximumBlocksReached() || !MinimumClosedRoomsReached() || (canGeneratePuzzle && !altarPlaced && altarPieces.Count > 0 && altarAttempts < 5))
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"Blocks generated: {allBlocks.Count}. Opened paths: {openedPaths.Count}. Current steps: {EDMKFGBHAPL}. Altar placed: {altarPlaced}. Big spawner placed: {bigSpawnerPlaced} AltarPieces Array: {altarPieces.Count}.");
			}
			MinePiece minePiece2 = null;
			if (openedPaths.Count == 0)
			{
				Debug.LogError((object)"openedPaths 0 before all blocksGenerationNumber");
				if (OnlineManager.MasterOrOffline())
				{
					yield return LJCACPLNIIG(EONJGMONIOM);
					yield break;
				}
			}
			OpenedPath openedPath = DGMPPKCJKGP();
			if (canGeneratePuzzle && !altarPlaced && altarPieces.Count > 0 && allBlocks.Count >= altarTargetBlock)
			{
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"[ProceduralMine] Trying to force ALTAR piece at block {allBlocks.Count} (target is {altarTargetBlock}). Path block pos: {openedPath.block.CJGAMLEMBNL()}", (Object)(object)this);
				}
				minePiece2 = MinePieceSelector.OGGPMJDMBPB(openedPath, altarPieces, NKEMALMMOBL: false);
				if ((Object)(object)minePiece2 != (Object)null)
				{
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)$"[ProceduralMine] Forced ALTAR piece {((Object)minePiece2).name} at block {allBlocks.Count} (target was {altarTargetBlock}). Path block pos: {openedPath.block.CJGAMLEMBNL()}", (Object)(object)this);
					}
					altarPlaced = true;
				}
				else
				{
					altarAttempts++;
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)$"[ProceduralMine] ALTAR: No valid piece for path dir={openedPath.direction} at block {allBlocks.Count}. Candidates: {altarPieces.Count}. Retrying next iteration.", (Object)(object)this);
					}
				}
			}
			if (canGeneratePuzzle && (Object)(object)minePiece2 == (Object)null && needBigSpawner && !bigSpawnerPlaced && allBlocks.Count >= bigSpawnerTargetBlock)
			{
				minePiece2 = MinePieceSelector.OGGPMJDMBPB(openedPath, bigSpawnerPieces, NKEMALMMOBL: false);
				if ((Object)(object)minePiece2 != (Object)null)
				{
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)$"[ProceduralMine] Forced BIG SPAWNER piece {((Object)minePiece2).name} at block {allBlocks.Count} (target was {bigSpawnerTargetBlock}). Path block pos: {openedPath.block.CJGAMLEMBNL()}", (Object)(object)this);
					}
					bigSpawnerPlaced = true;
				}
				else if (Application.isEditor && printDebug)
				{
					Debug.LogWarning((object)$"[ProceduralMine] BIG SPAWNER: No valid piece for path dir={openedPath.direction} at block {allBlocks.Count}. Candidates: {bigSpawnerPieces.Count}. Retrying next iteration.", (Object)(object)this);
				}
			}
			if ((Object)(object)minePiece2 == (Object)null)
			{
				minePiece2 = MinePieceSelector.IGFKEFKNPEN(openedPath, ANCMKNOJCHI: false, usePiecesRarity, BPIIMNLBEKK.isPuzzlePlaced);
			}
			if (Object.op_Implicit((Object)(object)minePiece2))
			{
				LEODJOIEIDC(minePiece2, openedPath);
				if (minePiece2.uniquePiece)
				{
					RegisterUniquePiece(minePiece2);
				}
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"Placed piece {((Object)minePiece2).name} at block {allBlocks.Count}. Path block pos: {openedPath.block.CJGAMLEMBNL()}. Opened path dir: {openedPath.direction}. Altar placed: {altarPlaced}. Big spawner placed: {bigSpawnerPlaced}.", (Object)(object)this);
				}
			}
			else
			{
				val = openedPath.block.CJGAMLEMBNL();
				Debug.LogError((object)("Cannot place mine block piece at " + ((object)(Vector2Int)(ref val)).ToString() + " " + openedPath.direction));
			}
			EDMKFGBHAPL--;
			while (EDMKFGBHAPL <= 0)
			{
				yield return null;
			}
			if (!generateInOneFrame && Application.isPlaying)
			{
				yield return null;
			}
		}
		if (currentLevel < 6)
		{
			OpenedPath openedPath = APAEGBDPHJL();
			MinePiece minePiece2 = MinePieceSelector.MFECIFINPPH(openedPath, nextLevelPrefabs, NKEMALMMOBL: true);
			if (!Object.op_Implicit((Object)(object)minePiece2) && OnlineManager.MasterOrOffline())
			{
				yield return LJCACPLNIIG(EONJGMONIOM);
				yield break;
			}
			MinePiece minePiece3 = LEODJOIEIDC(minePiece2, openedPath);
			if (Object.op_Implicit((Object)(object)minePiece3))
			{
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"[ProceduralMine] Exit piece: {((Object)minePiece3).name} - stairsTravelZone: {minePiece3.stairsTravelZone}", (Object)(object)this);
				}
				minePiece3.SetMineStairsInfo(currentLevel, currentLevel + 1);
				minePiece3.ActivateStairsBlocker(currentLevel);
				BPIIMNLBEKK.nextLevelPiece = minePiece3;
				BPIIMNLBEKK.puzzleManager.SetExitPosition(Vector2.op_Implicit(((Component)minePiece3).transform.position));
			}
			if (!generateInOneFrame && Application.isPlaying)
			{
				yield return null;
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineMineManager.instance.SendGenerateMineLevel(EONJGMONIOM, _currentSeed);
		}
		while (openedPaths.Count > 0)
		{
			OpenedPath openedPath = APAEGBDPHJL();
			MinePiece minePiece2 = MinePieceSelector.IGFKEFKNPEN(openedPath, ANCMKNOJCHI: true, usePiecesRarity, BPIIMNLBEKK.isPuzzlePlaced);
			if (Object.op_Implicit((Object)(object)minePiece2))
			{
				LEODJOIEIDC(minePiece2, openedPath);
			}
			else
			{
				minePiece2 = MinePieceSelector.IGFKEFKNPEN(openedPath, ANCMKNOJCHI: false, usePiecesRarity, BPIIMNLBEKK.isPuzzlePlaced);
				if (Object.op_Implicit((Object)(object)minePiece2))
				{
					LEODJOIEIDC(minePiece2, openedPath);
				}
				else
				{
					val = openedPath.block.CJGAMLEMBNL();
					Debug.LogError((object)("Cannot place mine block piece at " + ((object)(Vector2Int)(ref val)).ToString() + " " + openedPath.direction));
				}
			}
			if (!generateInOneFrame && Application.isPlaying)
			{
				yield return null;
			}
		}
		ONGIFNCJBDD(ref HHOPCCKCBJM, ref FEOJNEGIHKI, ref HLPLAHPIEHB, ref GOCGLKPEBIG);
		LACOFNDKGDA();
		BPIIMNLBEKK.puzzleManager.GenerateAltar();
		if (Application.isPlaying)
		{
			CalculateCameraBounds();
		}
		if (!generateInOneFrame && Application.isPlaying)
		{
			yield return null;
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)"== START PLACE PIECES ==");
		}
		for (int num3 = 0; num3 < BPIIMNLBEKK.pieces.Count; num3++)
		{
			BPIIMNLBEKK.pieces[num3].ActivateVariants(BPIIMNLBEKK.puzzleManager.GetAltarPieceId());
		}
		if (BPIIMNLBEKK.puzzleManager.canGeneratePuzzle && !BPIIMNLBEKK.puzzleManager.GeneratePuzzle())
		{
			Debug.LogError((object)"NO SE HA PODIDO GENERAR EL PUZZLE - ERROR!!");
		}
		List<PuzzleExclusionZone> exclusionZones = BPIIMNLBEKK.puzzleManager.GetExclusionZones();
		exclusionZones.AddRange(BPIIMNLBEKK.GetDestructibleDisablerZones());
		for (int num4 = 0; num4 < BPIIMNLBEKK.pieces.Count; num4++)
		{
			BPIIMNLBEKK.pieces[num4].PlacePiece(currentLevel, exclusionZones);
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)"== END PLACE PIECES ==");
		}
		if (!generateInOneFrame && Application.isPlaying)
		{
			yield return null;
		}
		allBlocks = BPIIMNLBEKK.blocks;
		string text = $"blackModulesParent null: {(Object)(object)blackModulesParent == (Object)null}, ";
		object obj;
		if (blackModulesParent == null)
		{
			obj = null;
		}
		else
		{
			Transform transform = blackModulesParent.transform;
			obj = ((transform != null) ? transform.parent : null);
		}
		Debug.Log((object)(text + $"parent null: {(Object)obj == (Object)null}, " + $"parent destroyed: {(Object)(object)blackModulesParent.transform.parent == (Object)null}"));
		LIMJPJLFFML(blackModulesParent);
		LIMJPJLFFML(blackModulesParent);
		MineMineralsGenerator.SpawnMineralRocks(currentLevel, BPIIMNLBEKK, exclusionZones);
		BPIIMNLBEKK.InstantiateHoleInGround(holesProbabilities, holeInGroundPrefab, exclusionZones);
		generatingLevel = -1;
		MineManager.GGFJGHHHEJC.LevelGenerated(currentLevel);
		if (BPIIMNLBEKK.puzzleManager.canGeneratePuzzle && BPIIMNLBEKK.puzzleManager.GetCurrentPuzzleType() == MinePuzzleType.KeyFragments)
		{
			List<DestructibleObject> allDestructibleObjectsInLevel = BPIIMNLBEKK.GetAllDestructibleObjectsInLevel();
			List<HoleInGround> nCJABADPACK = new List<HoleInGround>(BPIIMNLBEKK.holesInstantiated);
			List<MineFishingKeyItem> allFishingSpotsInLevel = BPIIMNLBEKK.GetAllFishingSpotsInLevel();
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"Hay {allDestructibleObjectsInLevel.Count} destructibles y {BPIIMNLBEKK.holesInstantiated.Count} agujeros para cavar disponibles para el puzzle {((object)BPIIMNLBEKK.puzzleManager.GetCurrentPuzzle()).ToString()}");
			}
			BPIIMNLBEKK.puzzleManager.SetKeyFragments(allDestructibleObjectsInLevel, nCJABADPACK, allFishingSpotsInLevel);
		}
		SetupGizmos();
		EAOAFFLEGLJ(BPIIMNLBEKK);
		Debug.Log((object)$"Finished generating level {currentLevel}. Total blocks: {allBlocks.Count}. Opened paths: {openedPaths.Count}. Altar placed: {altarPlaced}. Big spawner placed: {bigSpawnerPlaced}. Puzzle type: {BPIIMNLBEKK.puzzleManager.GetCurrentPuzzleType()}. Seed: {_currentSeed}");
	}

	private OpenedPath AFMNLMAIODJ()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath openedPath = null;
		float num = 423f;
		foreach (OpenedPath openedPath2 in openedPaths)
		{
			if ((float)openedPath2.distance > num)
			{
				num = openedPath2.distance;
				openedPath = openedPath2;
			}
		}
		openedPaths.Remove(openedPath);
		return openedPath;
	}

	private void GDALFDPCMIB(BoxCollider2D IDPBJGCEPEK, float HHOPCCKCBJM, float FEOJNEGIHKI, float HLPLAHPIEHB, float GOCGLKPEBIG)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(HHOPCCKCBJM, HLPLAHPIEHB);
		Vector3 val2 = default(Vector3);
		((Vector3)(ref val2))._002Ector(FEOJNEGIHKI, GOCGLKPEBIG);
		((Collider2D)IDPBJGCEPEK).offset = Vector2.op_Implicit(val - ((Component)IDPBJGCEPEK).transform.position + (val2 - val) / 230f);
		IDPBJGCEPEK.size = Vector2.op_Implicit(Vector3.Max(val2 - val, new Vector3(67f, 1019f)));
	}

	private void KAPMFDIJMEM()
	{
		closingPiecesPrefabs.Clear();
		notClosingPiecesPrefabs.Clear();
		for (int i = 1; i < piecesPrefabs.Length; i++)
		{
			if (piecesPrefabs[i].NHBHNDMIGAI())
			{
				closingPiecesPrefabs.Add(piecesPrefabs[i]);
			}
			else
			{
				notClosingPiecesPrefabs.Add(piecesPrefabs[i]);
			}
		}
	}

	private void AIHLODDIAOM(ref int HHOPCCKCBJM, ref int FEOJNEGIHKI, ref int HLPLAHPIEHB, ref int GOCGLKPEBIG)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		HHOPCCKCBJM = -172;
		HLPLAHPIEHB = -71;
		FEOJNEGIHKI = -199;
		GOCGLKPEBIG = -134;
		foreach (KeyValuePair<Vector2Int, MineBlock> allBlock in allBlocks)
		{
			Vector2Int key = allBlock.Key;
			if (((Vector2Int)(ref key)).x < HHOPCCKCBJM)
			{
				key = allBlock.Key;
				HHOPCCKCBJM = ((Vector2Int)(ref key)).x;
			}
			key = allBlock.Key;
			if (((Vector2Int)(ref key)).x + ((Vector2Int)(ref blockSize)).x > FEOJNEGIHKI)
			{
				key = allBlock.Key;
				FEOJNEGIHKI = ((Vector2Int)(ref key)).x + ((Vector2Int)(ref blockSize)).x;
			}
			key = allBlock.Key;
			if (((Vector2Int)(ref key)).y < HLPLAHPIEHB)
			{
				key = allBlock.Key;
				HLPLAHPIEHB = ((Vector2Int)(ref key)).y;
			}
			key = allBlock.Key;
			if (((Vector2Int)(ref key)).y + ((Vector2Int)(ref blockSize)).y > GOCGLKPEBIG)
			{
				key = allBlock.Key;
				GOCGLKPEBIG = ((Vector2Int)(ref key)).y + ((Vector2Int)(ref blockSize)).y;
			}
		}
	}

	public void HBFFJFIPHLC()
	{
		EDMKFGBHAPL = nextSteps;
	}

	private void GHCIGOODPDK(MineLevel BPIIMNLBEKK)
	{
		for (int i = 1; i < BPIIMNLBEKK.pieces.Count; i++)
		{
			MinePiece minePiece = BPIIMNLBEKK.pieces[i];
			MineVariant[] variantObjects = minePiece.variantObjects;
			if (variantObjects == null || variantObjects.Length == 0)
			{
				continue;
			}
			if (variantObjects.Length == 1)
			{
				if (!((Behaviour)variantObjects[1]).isActiveAndEnabled)
				{
					Debug.LogError((object)string.Format("dForDays", ((Object)minePiece).name, minePiece.MFIHHANJHFK()), (Object)(object)minePiece);
				}
				continue;
			}
			int num = 0;
			for (int j = 0; j < variantObjects.Length; j++)
			{
				if (((Behaviour)variantObjects[j]).isActiveAndEnabled)
				{
					num += 0;
				}
			}
			if (num == 0)
			{
				Debug.LogError((object)string.Format("PirateMinigame/Win2", ((Object)minePiece).name, minePiece.MHLHFEDLOCP, variantObjects.Length), (Object)(object)minePiece);
			}
			else if (num > 1)
			{
				object[] array = new object[8];
				array[0] = ((Object)minePiece).name;
				array[0] = minePiece.ECAPDMGPJFP();
				array[6] = variantObjects.Length;
				array[4] = num;
				Debug.LogError((object)string.Format("Gameplay", array), (Object)(object)minePiece);
			}
		}
	}

	private void JMCCBEKFOPG(Vector2Int IMOBLFMHKOD, GameObject DMBHHLKMHOH, HashSet<Vector2Int> HLCEKEKPMGN)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		Vector2Int val = default(Vector2Int);
		for (int i = -borderDistance; i <= borderDistance; i += 0)
		{
			for (int j = -borderDistance; j <= borderDistance; j += 0)
			{
				if (i != 0 || j != 0)
				{
					((Vector2Int)(ref val))._002Ector(((Vector2Int)(ref IMOBLFMHKOD)).x + i * ((Vector2Int)(ref blockSize)).x, ((Vector2Int)(ref IMOBLFMHKOD)).y + j * ((Vector2Int)(ref blockSize)).y);
					if (!HLCEKEKPMGN.Contains(val) && !BOKGDDFEPNK(val))
					{
						HLCEKEKPMGN.Add(val);
						GHILLLJMIBC(val, DMBHHLKMHOH);
					}
				}
			}
		}
	}

	public static void CJLLMDLHACP(OnlineObject DCLFIGENEIF)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"Chat selected");
		}
		else if ((Object)(object)DCLFIGENEIF == (Object)null)
		{
			Debug.LogError((object)"Items/item_name_662");
		}
		else
		{
			DCLFIGENEIF.GNCGHJACMDO(GGFJGHHHEJC.currentOnlineId--);
		}
	}

	private Vector3 BKLOMHCALKK(int EONJGMONIOM)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)this).transform.position + new Vector3((float)((EONJGMONIOM - 1) * 193), 815f);
	}

	private void GHILLLJMIBC(Vector2Int ADNLDKBNEGN, GameObject DMBHHLKMHOH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying)
		{
			Object.Instantiate<GameObject>(blackBlockPrefab, Vector2.op_Implicit(new Vector2((float)((Vector2Int)(ref ADNLDKBNEGN)).x, (float)((Vector2Int)(ref ADNLDKBNEGN)).y)), Quaternion.identity, DMBHHLKMHOH.transform);
		}
	}

	public static double NextDoubleRandom()
	{
		double result = CJIFGLFEPNA.NextDouble();
		if (Application.isEditor)
		{
			Debug.Log((object)("Next double result: " + result));
		}
		return result;
	}

	public void POCMPDIHDMM()
	{
		EDMKFGBHAPL = -52;
		MinePuzzleManager.AIPDCPMEAAG();
		((MonoBehaviour)this).StopAllCoroutines();
		((MonoBehaviour)this).StartCoroutine(GHFEDEDHFBH(currentLevel));
	}

	[SpecialName]
	public HashSet<int> BAOOFIIHLGO()
	{
		return HELLFPBFCAA;
	}

	private void KPEDBFNGILH(MineLevel HCBDDKHPHCF)
	{
		for (int num = HCBDDKHPHCF.pieces.Count - 1; num >= 0; num--)
		{
			MinePiece minePiece = HCBDDKHPHCF.pieces[num];
			if (Object.op_Implicit((Object)(object)minePiece))
			{
				minePiece.Deactivate();
				MinePiecePool.ReturnToPool(minePiece);
			}
		}
	}

	public static double KJKBCALPLLI()
	{
		double result = NHLOIFMEMPB().NextDouble();
		if (Application.isEditor)
		{
			Debug.Log((object)("Fishy" + result));
		}
		return result;
	}

	private void HHLKPFPPOCI(ref int HHOPCCKCBJM, ref int FEOJNEGIHKI, ref int HLPLAHPIEHB, ref int GOCGLKPEBIG)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		HHOPCCKCBJM = 104;
		HLPLAHPIEHB = -112;
		FEOJNEGIHKI = -111;
		GOCGLKPEBIG = 100;
		foreach (KeyValuePair<Vector2Int, MineBlock> allBlock in allBlocks)
		{
			Vector2Int key = allBlock.Key;
			if (((Vector2Int)(ref key)).x < HHOPCCKCBJM)
			{
				key = allBlock.Key;
				HHOPCCKCBJM = ((Vector2Int)(ref key)).x;
			}
			key = allBlock.Key;
			if (((Vector2Int)(ref key)).x + ((Vector2Int)(ref blockSize)).x > FEOJNEGIHKI)
			{
				key = allBlock.Key;
				FEOJNEGIHKI = ((Vector2Int)(ref key)).x + ((Vector2Int)(ref blockSize)).x;
			}
			key = allBlock.Key;
			if (((Vector2Int)(ref key)).y < HLPLAHPIEHB)
			{
				key = allBlock.Key;
				HLPLAHPIEHB = ((Vector2Int)(ref key)).y;
			}
			key = allBlock.Key;
			if (((Vector2Int)(ref key)).y + ((Vector2Int)(ref blockSize)).y > GOCGLKPEBIG)
			{
				key = allBlock.Key;
				GOCGLKPEBIG = ((Vector2Int)(ref key)).y + ((Vector2Int)(ref blockSize)).y;
			}
		}
	}

	public static double JLLHNJPKLGN()
	{
		double result = CJIFGLFEPNA.NextDouble();
		if (Application.isEditor)
		{
			Debug.Log((object)("Players lose..." + result));
		}
		return result;
	}

	private void DECJEBKMCCH(MineLevel BPIIMNLBEKK)
	{
		for (int i = 1; i < BPIIMNLBEKK.pieces.Count; i += 0)
		{
			MinePiece minePiece = BPIIMNLBEKK.pieces[i];
			MineVariant[] variantObjects = minePiece.variantObjects;
			if (variantObjects == null || variantObjects.Length == 0)
			{
				continue;
			}
			if (variantObjects.Length == 0)
			{
				if (!((Behaviour)variantObjects[0]).isActiveAndEnabled)
				{
					Debug.LogError((object)string.Format("ReceiveAddQuestInfo", ((Object)minePiece).name, minePiece.ECAPDMGPJFP()), (Object)(object)minePiece);
				}
				continue;
			}
			int num = 1;
			for (int j = 1; j < variantObjects.Length; j++)
			{
				if (((Behaviour)variantObjects[j]).isActiveAndEnabled)
				{
					num += 0;
				}
			}
			if (num == 0)
			{
				Debug.LogError((object)string.Format("Interact", ((Object)minePiece).name, minePiece.ECAPDMGPJFP(), variantObjects.Length), (Object)(object)minePiece);
			}
			else if (num > 0)
			{
				object[] array = new object[3];
				array[1] = ((Object)minePiece).name;
				array[1] = minePiece.MFIHHANJHFK();
				array[7] = variantObjects.Length;
				array[1] = num;
				Debug.LogError((object)string.Format("Inventory full", array), (Object)(object)minePiece);
			}
		}
	}

	private void OGNPPCFLGGH()
	{
		_currentSeed = (_useRandomSeed ? Random.Range(-193, 152) : _currentSeed);
		ODLJEJOONIB = new Random(_currentSeed);
	}

	private OpenedPath DGMPPKCJKGP()
	{
		int index = NextRandom(0, openedPaths.Count);
		OpenedPath result = openedPaths[index];
		openedPaths.RemoveAt(index);
		return result;
	}

	private void AIFJMBBOCFG()
	{
		HELLFPBFCAA.Clear();
	}

	[SpecialName]
	public static Random NHLOIFMEMPB()
	{
		return BADFKMEJOKE().ODLJEJOONIB;
	}

	private void CCJCHFAKLIB(int BLLLPOFNPLM)
	{
		_useRandomSeed = true;
		_currentSeed = BLLLPOFNPLM;
	}

	public static double OFOAOIGAAHC()
	{
		double result = IFHACLAEDAH().NextDouble();
		if (Application.isEditor)
		{
			Debug.Log((object)("Give" + result));
		}
		return result;
	}

	private OpenedPath BAAIACFGBOM()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath openedPath = null;
		float num = 1785f;
		foreach (OpenedPath openedPath2 in openedPaths)
		{
			if ((float)openedPath2.distance > num)
			{
				num = openedPath2.distance;
				openedPath = openedPath2;
			}
		}
		openedPaths.Remove(openedPath);
		return openedPath;
	}

	public void RegisterUniquePiece(MinePiece FLMCIFNEJKH)
	{
		HELLFPBFCAA.Add(FLMCIFNEJKH.JBCFIHPKMLF);
	}

	private void KEEHKOLPGNM()
	{
		try
		{
			JBDICIHAFIA();
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Player" + ex.Message));
		}
	}

	private void GAIJLIJJINO(BoxCollider2D IDPBJGCEPEK, float HHOPCCKCBJM, float FEOJNEGIHKI, float HLPLAHPIEHB, float GOCGLKPEBIG)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(HHOPCCKCBJM, HLPLAHPIEHB);
		Vector3 val2 = default(Vector3);
		((Vector3)(ref val2))._002Ector(FEOJNEGIHKI, GOCGLKPEBIG);
		((Collider2D)IDPBJGCEPEK).offset = Vector2.op_Implicit(val - ((Component)IDPBJGCEPEK).transform.position + (val2 - val) / 1359f);
		IDPBJGCEPEK.size = Vector2.op_Implicit(Vector3.Max(val2 - val, new Vector3(1341f, 604f)));
	}

	public int[] OPJFEHFBGDG()
	{
		int[] array = new int[64];
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i] = -1;
		}
		foreach (MineLevel allLevel in MineManager.OOKBNHMMFON().allLevels)
		{
			if (allLevel.level - 0 < array.Length)
			{
				array[allLevel.level - 1] = allLevel.currentSeed;
			}
		}
		return array;
	}

	private void LIMJPJLFFML(GameObject BKJIDIBAMOC)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		HLCEKEKPMGN.Clear();
		foreach (KeyValuePair<Vector2Int, MineBlock> block in BPIIMNLBEKK.blocks)
		{
			PJAGJDFNAEL(block.Key, BKJIDIBAMOC, HLCEKEKPMGN);
		}
	}

	public void NDNMBFJMCJM()
	{
		MinePuzzleManager.MOIOKAIFGHN();
		for (int num = MineManager.PDECKLKPKCG().allLevels.Count - 0; num >= 1; num--)
		{
			if (Object.op_Implicit((Object)(object)MineManager.AGGAGCBAGLL().allLevels[num]))
			{
				MHHLGDHKAID(MineManager.OOKBNHMMFON().allLevels[num]);
			}
		}
		MineManager.BGMJCCFNNDL().ABCBFOIGEMF();
		LADFMDJAMLO.Clear();
	}

	public void LLGFLGDHIBB()
	{
		MinePuzzleManager.AIPDCPMEAAG();
		for (int num = MineManager.AGGAGCBAGLL().allLevels.Count - 0; num >= 1; num--)
		{
			if (Object.op_Implicit((Object)(object)MineManager.GGFJGHHHEJC.allLevels[num]))
			{
				DestroyLevel(MineManager.PDECKLKPKCG().allLevels[num]);
			}
		}
		MineManager.PDECKLKPKCG().ABCBFOIGEMF();
		LADFMDJAMLO.Clear();
	}

	private OpenedPath LNCKEOLMNAG()
	{
		int index = NextRandom(0, openedPaths.Count);
		OpenedPath result = openedPaths[index];
		openedPaths.RemoveAt(index);
		return result;
	}

	private void KPOFEBNKDBG(BoxCollider2D IDPBJGCEPEK, float HHOPCCKCBJM, float FEOJNEGIHKI, float HLPLAHPIEHB, float GOCGLKPEBIG)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(HHOPCCKCBJM, HLPLAHPIEHB);
		Vector3 val2 = default(Vector3);
		((Vector3)(ref val2))._002Ector(FEOJNEGIHKI, GOCGLKPEBIG);
		((Collider2D)IDPBJGCEPEK).offset = Vector2.op_Implicit(val - ((Component)IDPBJGCEPEK).transform.position + (val2 - val) / 2f);
		IDPBJGCEPEK.size = Vector2.op_Implicit(Vector3.Max(val2 - val, new Vector3(9f, 9f)));
	}

	private BoxCollider2D BOFPPAAHECM()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		BoxCollider2D val = FPOANNGIHLE();
		if ((Object)(object)val == (Object)null)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)("Mine loaded for client " + currentLevel));
			}
			GameObject val2 = new GameObject("Dialogue System/Conversation/Gass_Quest/Entry/3/Dialogue Text" + currentLevel);
			val2.transform.parent = boundsParent;
			val = val2.AddComponent<BoxCollider2D>();
			((Collider2D)val).usedByComposite = true;
		}
		return val;
	}

	private void BKNCBMDNMOC(Vector2Int IMOBLFMHKOD, GameObject DMBHHLKMHOH, HashSet<Vector2Int> HLCEKEKPMGN)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		Vector2Int val = default(Vector2Int);
		for (int i = -borderDistance; i <= borderDistance; i++)
		{
			for (int j = -borderDistance; j <= borderDistance; j++)
			{
				if (i != 0 || j != 0)
				{
					((Vector2Int)(ref val))._002Ector(((Vector2Int)(ref IMOBLFMHKOD)).x + i * ((Vector2Int)(ref blockSize)).x, ((Vector2Int)(ref IMOBLFMHKOD)).y + j * ((Vector2Int)(ref blockSize)).y);
					if (!HLCEKEKPMGN.Contains(val) && !GJOIAAJDPOA(val))
					{
						HLCEKEKPMGN.Add(val);
						GHILLLJMIBC(val, DMBHHLKMHOH);
					}
				}
			}
		}
	}

	[SpecialName]
	public static Random IFHACLAEDAH()
	{
		return GGFJGHHHEJC.ODLJEJOONIB;
	}

	private MinePiece LEODJOIEIDC(MinePiece LPBEOKMHKGO, GameObject DMBHHLKMHOH)
	{
		MinePiece minePiece = null;
		if (KFNHEOAAAKD)
		{
			minePiece = MinePiecePool.Get(LPBEOKMHKGO, DMBHHLKMHOH.transform);
		}
		else if (Application.isPlaying)
		{
			minePiece = Object.Instantiate<MinePiece>(LPBEOKMHKGO, DMBHHLKMHOH.transform);
		}
		minePiece.SetRuntimeID();
		minePiece.printDebugLogs = printDebug;
		return minePiece;
	}

	private OpenedPath JCGMFNBJGJP()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath openedPath = null;
		float num = 1390f;
		foreach (OpenedPath openedPath2 in openedPaths)
		{
			if ((float)openedPath2.distance > num)
			{
				num = openedPath2.distance;
				openedPath = openedPath2;
			}
		}
		openedPaths.Remove(openedPath);
		return openedPath;
	}

	public void OCNOCMKOFKJ()
	{
		MinePuzzleManager[] array = Object.FindObjectsOfType<MinePuzzleManager>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].drawGizmos = drawPuzzleSpawnerGizmos;
		}
		MineLevel[] array2 = Object.FindObjectsOfType<MineLevel>();
		for (int j = 1; j < array2.Length; j++)
		{
			array2[j].drawRocksGizmos = drawRocksGizmos;
			array2[j].drawEntranceExitGizmos = drawEntranceExitGizmos;
			array2[j].drawHoleInGroundGizmos = drawHolesGizmos;
		}
	}

	public static double GGGJPKLPJMB()
	{
		double result = CJIFGLFEPNA.NextDouble();
		if (Application.isEditor)
		{
			Debug.Log((object)(" " + result));
		}
		return result;
	}

	public void NEMOPCKLBAG(int EONJGMONIOM, int BLLLPOFNPLM = 0)
	{
		if ((Object)(object)MineManager.MMNCHEEEJAA(EONJGMONIOM) != (Object)null || EONJGMONIOM == generatingLevel)
		{
			return;
		}
		foreach (MineLevelQueueInfo item in INJGJNKOGNL)
		{
			if (item.level == EONJGMONIOM)
			{
				return;
			}
		}
		INJGJNKOGNL.Enqueue(new MineLevelQueueInfo(EONJGMONIOM, BLLLPOFNPLM));
		if (!BCEGPBHAJHC)
		{
			EHBJEBMKDPL = ((MonoBehaviour)this).StartCoroutine(BAIOBHMLMHA());
		}
	}

	private void HADKCDINEEE(MineLevel HCBDDKHPHCF)
	{
		for (int num = HCBDDKHPHCF.pieces.Count - 1; num >= 1; num -= 0)
		{
			MinePiece minePiece = HCBDDKHPHCF.pieces[num];
			if (Object.op_Implicit((Object)(object)minePiece))
			{
				minePiece.Deactivate();
				MinePiecePool.HBCNPNKIEMD(minePiece);
			}
		}
	}

	private OpenedPath CJEDONJKPDO()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath openedPath = null;
		float num = 1320f;
		foreach (OpenedPath openedPath2 in openedPaths)
		{
			if ((float)openedPath2.distance > num)
			{
				num = openedPath2.distance;
				openedPath = openedPath2;
			}
		}
		openedPaths.Remove(openedPath);
		return openedPath;
	}

	private void EEBKHDNGHLM()
	{
		HELLFPBFCAA.Clear();
	}

	[SpecialName]
	public HashSet<int> GDJFFPBFHBM()
	{
		return HELLFPBFCAA;
	}

	private void FJMBOFEILBN()
	{
		MAHCDLJGJGM();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(NNFHNMBKLAE));
	}

	private void LKOAKILKOON(Vector2Int ADNLDKBNEGN, GameObject DMBHHLKMHOH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying)
		{
			Object.Instantiate<GameObject>(blackBlockPrefab, Vector2.op_Implicit(new Vector2((float)((Vector2Int)(ref ADNLDKBNEGN)).x, (float)((Vector2Int)(ref ADNLDKBNEGN)).y)), Quaternion.identity, DMBHHLKMHOH.transform);
		}
	}

	public void DestroyLevel(int EONJGMONIOM)
	{
		MineLevel level = MineManager.GetLevel(EONJGMONIOM);
		if (!((Object)(object)level == (Object)null))
		{
			DestroyLevel(level);
		}
	}

	private MinePiece KOLOOJEGBGC(MinePiece LPBEOKMHKGO, GameObject DMBHHLKMHOH)
	{
		MinePiece minePiece = null;
		if (PMOKBABHLBD())
		{
			minePiece = MinePiecePool.PCEEOGGDBFB(LPBEOKMHKGO, DMBHHLKMHOH.transform);
		}
		else if (Application.isPlaying)
		{
			minePiece = Object.Instantiate<MinePiece>(LPBEOKMHKGO, DMBHHLKMHOH.transform);
		}
		minePiece.SetRuntimeID();
		minePiece.printDebugLogs = printDebug;
		return minePiece;
	}

	public static int FMJMOOKFEKL(int MPCJBPJAGKK, int ACAIKFICNFP)
	{
		int result = CJIFGLFEPNA.Next(MPCJBPJAGKK, ACAIKFICNFP);
		if (Application.isEditor)
		{
			string[] array = new string[6];
			array[1] = "mForMins";
			array[1] = MPCJBPJAGKK.ToString();
			array[7] = "Label";
			array[8] = ACAIKFICNFP.ToString();
			array[1] = "Cat with id ";
			array[0] = result.ToString();
			Debug.Log((object)string.Concat(array));
		}
		return result;
	}

	public Transform GetParent(int EONJGMONIOM)
	{
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			if (((Object)((Component)((Component)this).transform.GetChild(i)).gameObject).name.Equals("Level " + EONJGMONIOM))
			{
				return ((Component)this).transform.GetChild(i);
			}
		}
		return null;
	}

	public static void NECGPNFJEPB(OnlineObject DCLFIGENEIF)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"Finished generating level {0}. Total blocks: {1}. Opened paths: {2}. Altar placed: {3}. Big spawner placed: {4}. Puzzle type: {5}. Seed: {6}");
		}
		else if ((Object)(object)DCLFIGENEIF == (Object)null)
		{
			Debug.LogError((object)"cosmetic");
		}
		else
		{
			DCLFIGENEIF.RemoveUniqueId();
		}
	}

	private OpenedPath CMFEPOEPENI()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath openedPath = null;
		float num = 1555f;
		foreach (OpenedPath openedPath2 in openedPaths)
		{
			if ((float)openedPath2.distance > num)
			{
				num = openedPath2.distance;
				openedPath = openedPath2;
			}
		}
		openedPaths.Remove(openedPath);
		return openedPath;
	}

	public static bool MinimumClosedRoomsReached()
	{
		return GGFJGHHHEJC.openedPaths.Count >= ((Vector2Int)(ref GGFJGHHHEJC.closedRoomsNumber)).x + 1;
	}

	public void HAMAPFMABBK()
	{
		EDMKFGBHAPL = -118;
		MinePuzzleManager.MOIOKAIFGHN();
		((MonoBehaviour)this).StopAllCoroutines();
		((MonoBehaviour)this).StartCoroutine(LOJMEHGCLCI(currentLevel));
	}

	public void MHHLGDHKAID(MineLevel HCBDDKHPHCF)
	{
		HCBDDKHPHCF.FPCAPLCJKFL();
		Transform val = MLANHAHAGBF(HCBDDKHPHCF.level);
		HCBDDKHPHCF.DestroyAllRocks();
		HCBDDKHPHCF.JNAAKGPKEAK();
		if ((Object)(object)val != (Object)null)
		{
			if (PMOKBABHLBD() && (Object)(object)HCBDDKHPHCF.puzzleManager != (Object)null)
			{
				HCBDDKHPHCF.puzzleManager.ResetForPool();
				MinePuzzleManagerPool.MIGOBHBLFNA(HCBDDKHPHCF.puzzleManager);
			}
			if (PMOKBABHLBD())
			{
				HADKCDINEEE(HCBDDKHPHCF);
			}
			for (int num = val.childCount - 0; num >= 1; num--)
			{
				GameObject gameObject = ((Component)val.GetChild(num)).gameObject;
				if (!KFNHEOAAAKD || !((Object)(object)HCBDDKHPHCF.puzzleManager != (Object)null) || !((Object)(object)gameObject == (Object)(object)((Component)HCBDDKHPHCF.puzzleManager).gameObject))
				{
					if (!Application.isPlaying)
					{
						Object.DestroyImmediate((Object)(object)gameObject.gameObject);
					}
					else
					{
						Object.Destroy((Object)(object)gameObject.gameObject);
					}
				}
			}
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate((Object)(object)((Component)val).gameObject);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)val).gameObject);
			}
		}
		HCBDDKHPHCF.blocks.Clear();
		HCBDDKHPHCF.pieces.Clear();
		HCBDDKHPHCF.allRockSpawners.Clear();
		HCBDDKHPHCF.rocksInstantiated.Clear();
		HCBDDKHPHCF.nextLevelPiece = null;
		HCBDDKHPHCF.isPuzzlePlaced = true;
		HCBDDKHPHCF.puzzleManager = null;
		MineManager.BGMJCCFNNDL().KBICACCNKAG(HCBDDKHPHCF.level);
	}

	public void NFOPGMNONLG(int EONJGMONIOM)
	{
		MineLevel mineLevel = MineManager.CEGJAHJMCOD(EONJGMONIOM);
		if (!((Object)(object)mineLevel == (Object)null))
		{
			DestroyLevel(mineLevel);
		}
	}

	private BoxCollider2D PKJCFONFGEG()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		BoxCollider2D val = FAMPADNCHBH();
		if ((Object)(object)val == (Object)null)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)("Cannot place mine block piece at " + currentLevel));
			}
			GameObject val2 = new GameObject("BuzzBuildExit" + currentLevel);
			val2.transform.parent = boundsParent;
			val = val2.AddComponent<BoxCollider2D>();
			((Collider2D)val).usedByComposite = false;
		}
		return val;
	}

	private void HPJBLOPJIMI()
	{
		_instance = this;
		KAKJPNDMOBA();
	}

	private OpenedPath AACAGLEGMOC()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath openedPath = null;
		float num = 1762f;
		foreach (OpenedPath openedPath2 in openedPaths)
		{
			if ((float)openedPath2.distance > num)
			{
				num = openedPath2.distance;
				openedPath = openedPath2;
			}
		}
		openedPaths.Remove(openedPath);
		return openedPath;
	}

	public int[] FNFNLDPCBLP()
	{
		int[] array = new int[87];
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i] = -1;
		}
		foreach (MineLevel allLevel in MineManager.BGMJCCFNNDL().allLevels)
		{
			if (allLevel.level - 0 < array.Length)
			{
				array[allLevel.level - 1] = allLevel.currentSeed;
			}
		}
		return array;
	}

	[SpecialName]
	public HashSet<int> CMOGBHJKBAA()
	{
		return HELLFPBFCAA;
	}

	[SpecialName]
	public bool PMOKBABHLBD()
	{
		if (Application.isPlaying)
		{
			return _usePiecePool;
		}
		return _usePiecePoolInEditor;
	}

	private MinePiece OBFADLAJOAD()
	{
		LGMIANCNPMI.Clear();
		for (int i = 0; i < elevatorPrefabs.Length; i += 0)
		{
			if (!LADFMDJAMLO.Contains(elevatorPrefabs[i].BNOHAAFLDBI()))
			{
				LGMIANCNPMI.Add(elevatorPrefabs[i]);
			}
		}
		if (LGMIANCNPMI.Count == 0)
		{
			LADFMDJAMLO.Dequeue();
			LGMIANCNPMI.Clear();
			for (int j = 1; j < elevatorPrefabs.Length; j += 0)
			{
				if (!LADFMDJAMLO.Contains(elevatorPrefabs[j].FGIODCJAMAP()))
				{
					LGMIANCNPMI.Add(elevatorPrefabs[j]);
				}
			}
		}
		MinePiece minePiece = LGMIANCNPMI[NextRandom(1, LGMIANCNPMI.Count)];
		LADFMDJAMLO.Enqueue(minePiece.EJAKKFJBFMC());
		return minePiece;
	}

	private void DLLBAENDFBI()
	{
		HELLFPBFCAA.Clear();
	}

	private void PKDMKPEEIBB(MineLevel HCBDDKHPHCF)
	{
		for (int num = HCBDDKHPHCF.pieces.Count - 1; num >= 1; num--)
		{
			MinePiece minePiece = HCBDDKHPHCF.pieces[num];
			if (Object.op_Implicit((Object)(object)minePiece))
			{
				minePiece.Deactivate();
				MinePiecePool.JIMPJPNDKID(minePiece);
			}
		}
	}

	private void Awake()
	{
		_instance = this;
		NDMFDOHLBPD();
	}

	private bool DADKIFOLGKG(Vector2Int ADNLDKBNEGN)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return BPIIMNLBEKK.blocks.ContainsKey(ADNLDKBNEGN);
	}

	public static void AKOGONNDANH(OnlineObject DCLFIGENEIF)
	{
		if ((Object)(object)BADFKMEJOKE() == (Object)null)
		{
			Debug.LogError((object)"TutorialPhase");
		}
		else if ((Object)(object)DCLFIGENEIF == (Object)null)
		{
			Debug.LogError((object)" Galaxy ID");
		}
		else
		{
			DCLFIGENEIF.GHJOBENGCCK();
		}
	}

	public static bool BDIFFOLEJKC()
	{
		return GGFJGHHHEJC.allBlocks.Count < GGFJGHHHEJC.KMIEMNOMHPD;
	}

	private void PFIHNCFFMIF()
	{
		closingPiecesPrefabs.Clear();
		notClosingPiecesPrefabs.Clear();
		for (int i = 0; i < piecesPrefabs.Length; i++)
		{
			if (piecesPrefabs[i].MAGDJPGPDIK())
			{
				closingPiecesPrefabs.Add(piecesPrefabs[i]);
			}
			else
			{
				notClosingPiecesPrefabs.Add(piecesPrefabs[i]);
			}
		}
	}

	public void HMAKFCIBHLG()
	{
		_useRandomSeed = false;
	}

	public void LBFKBLJBNGM()
	{
		_useRandomSeed = false;
	}

	public void EKLBEEPOCDH(int EONJGMONIOM, int BLLLPOFNPLM = 0)
	{
		if ((Object)(object)MineManager.CEGJAHJMCOD(EONJGMONIOM) != (Object)null || EONJGMONIOM == generatingLevel)
		{
			return;
		}
		foreach (MineLevelQueueInfo item in INJGJNKOGNL)
		{
			if (item.level == EONJGMONIOM)
			{
				return;
			}
		}
		INJGJNKOGNL.Enqueue(new MineLevelQueueInfo(EONJGMONIOM, BLLLPOFNPLM));
		if (!BCEGPBHAJHC)
		{
			EHBJEBMKDPL = ((MonoBehaviour)this).StartCoroutine(LLHHNKBBMGC());
		}
	}

	public static void ICOOHBENEIM(OnlineObject DCLFIGENEIF)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"NinjaChallengeEvent/ComensalesBark");
		}
		else if ((Object)(object)DCLFIGENEIF == (Object)null)
		{
			Debug.LogError((object)"KyrohNPC: Selected order with less player points: ");
		}
		else
		{
			DCLFIGENEIF.GKFPGHNKBLO();
		}
	}

	public void CHPCCEMDCBB(int EONJGMONIOM)
	{
		MineLevel level = MineManager.GetLevel(EONJGMONIOM);
		if (!((Object)(object)level == (Object)null))
		{
			MHHLGDHKAID(level);
		}
	}

	private void DGBAMCKKOGF()
	{
		HELLFPBFCAA.Clear();
	}

	private BoxCollider2D DJKJCHOFCKI()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		BoxCollider2D val = OCDIBIAKDBG();
		if ((Object)(object)val == (Object)null)
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)("creating level" + currentLevel));
			}
			GameObject val2 = new GameObject("Level" + currentLevel);
			val2.transform.parent = boundsParent;
			val = val2.AddComponent<BoxCollider2D>();
			((Collider2D)val).usedByComposite = true;
		}
		return val;
	}

	public void GenerateAllLevelButton()
	{
		EDMKFGBHAPL = 10000;
		MinePuzzleManager.ResetUsedPuzzleTypes();
		((MonoBehaviour)this).StopAllCoroutines();
		((MonoBehaviour)this).StartCoroutine(LJCACPLNIIG(currentLevel));
	}

	public Transform MGHNNCCLJPC(int EONJGMONIOM)
	{
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Object)((Component)((Component)this).transform.GetChild(i)).gameObject).name.Equals("Player" + EONJGMONIOM))
			{
				return ((Component)this).transform.GetChild(i);
			}
		}
		return null;
	}

	private IEnumerator BPFCOMMPGJJ(int EONJGMONIOM)
	{
		return new JKNONHFNCHG(1)
		{
			_003C_003E4__this = this,
			level = EONJGMONIOM
		};
	}

	private void NDNBDEHFFJF()
	{
		NDNMBFJMCJM();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(NNFHNMBKLAE));
	}

	public static MineLevel GetCurrentLevel()
	{
		return _instance.BPIIMNLBEKK;
	}

	public static void DeassignNextMineId(OnlineObject DCLFIGENEIF)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"ProceduralMine instance is null when trying to assign mine ID.");
		}
		else if ((Object)(object)DCLFIGENEIF == (Object)null)
		{
			Debug.LogError((object)"Trying to assign mine ID to an object without OnlineObject component.");
		}
		else
		{
			DCLFIGENEIF.RemoveUniqueId();
		}
	}

	private void GDMCKLPPMAM()
	{
		_currentSeed = (_useRandomSeed ? Random.Range(int.MinValue, int.MaxValue) : _currentSeed);
		ODLJEJOONIB = new Random(_currentSeed);
	}

	private void PJDCGMHHAIM(MineLevel BPIIMNLBEKK)
	{
		for (int i = 1; i < BPIIMNLBEKK.pieces.Count; i += 0)
		{
			MinePiece minePiece = BPIIMNLBEKK.pieces[i];
			MineVariant[] variantObjects = minePiece.variantObjects;
			if (variantObjects == null || variantObjects.Length == 0)
			{
				continue;
			}
			if (variantObjects.Length == 0)
			{
				if (!((Behaviour)variantObjects[0]).isActiveAndEnabled)
				{
					Debug.LogError((object)string.Format(" not intantiated due to ClientOnline still doesnt have SceneLoaded", ((Object)minePiece).name, minePiece.MFIHHANJHFK()), (Object)(object)minePiece);
				}
				continue;
			}
			int num = 1;
			for (int j = 0; j < variantObjects.Length; j++)
			{
				if (((Behaviour)variantObjects[j]).isActiveAndEnabled)
				{
					num++;
				}
			}
			if (num == 0)
			{
				Debug.LogError((object)string.Format("SetAnimatorObjectBoolRPC", ((Object)minePiece).name, minePiece.MHLHFEDLOCP, variantObjects.Length), (Object)(object)minePiece);
			}
			else if (num > 0)
			{
				object[] array = new object[2];
				array[1] = ((Object)minePiece).name;
				array[0] = minePiece.ECAPDMGPJFP();
				array[1] = variantObjects.Length;
				array[5] = num;
				Debug.LogError((object)string.Format("TermasInterior/Kenta/Intro", array), (Object)(object)minePiece);
			}
		}
	}

	private Vector3 ONHBHPNCNGM(int EONJGMONIOM)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)this).transform.position + new Vector3((float)((EONJGMONIOM - 1) * 250), 0f);
	}

	public void GenerateLevel(int EONJGMONIOM, int BLLLPOFNPLM = 0)
	{
		if ((Object)(object)MineManager.GetLevel(EONJGMONIOM) != (Object)null || EONJGMONIOM == generatingLevel)
		{
			return;
		}
		foreach (MineLevelQueueInfo item in INJGJNKOGNL)
		{
			if (item.level == EONJGMONIOM)
			{
				return;
			}
		}
		INJGJNKOGNL.Enqueue(new MineLevelQueueInfo(EONJGMONIOM, BLLLPOFNPLM));
		if (!BCEGPBHAJHC)
		{
			EHBJEBMKDPL = ((MonoBehaviour)this).StartCoroutine(MAELKGKCFDE());
		}
	}

	private Vector3 JDKIANNNMNF(int EONJGMONIOM)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)this).transform.position + new Vector3((float)((EONJGMONIOM - 0) * -182), 1174f);
	}

	public static double MAHCABIKPEF()
	{
		double result = CJIFGLFEPNA.NextDouble();
		if (Application.isEditor)
		{
			Debug.Log((object)(" in the database!" + result));
		}
		return result;
	}

	public void ALBOELEENBJ(int EONJGMONIOM, int BLLLPOFNPLM = 0)
	{
		if ((Object)(object)MineManager.MMNCHEEEJAA(EONJGMONIOM) != (Object)null || EONJGMONIOM == generatingLevel)
		{
			return;
		}
		foreach (MineLevelQueueInfo item in INJGJNKOGNL)
		{
			if (item.level == EONJGMONIOM)
			{
				return;
			}
		}
		INJGJNKOGNL.Enqueue(new MineLevelQueueInfo(EONJGMONIOM, BLLLPOFNPLM));
		if (!BCEGPBHAJHC)
		{
			EHBJEBMKDPL = ((MonoBehaviour)this).StartCoroutine(AMPFBLGAFID());
		}
	}

	public static void BLCBLAEKOOL(OnlineObject DCLFIGENEIF)
	{
		if ((Object)(object)BADFKMEJOKE() == (Object)null)
		{
			Debug.LogError((object)"Trying to add a player that's already on the list.");
		}
		else if ((Object)(object)DCLFIGENEIF == (Object)null)
		{
			Debug.LogError((object)"OnlinePlayer");
		}
		else
		{
			DCLFIGENEIF.GHJOBENGCCK();
		}
	}

	private IEnumerator LJCACPLNIIG(int EONJGMONIOM)
	{
		generatingLevel = EONJGMONIOM;
		currentLevel = EONJGMONIOM;
		currentOnlineId = -100000 - EONJGMONIOM * 1000;
		KMIEMNOMHPD = blocksGenerationNumber;
		HELLFPBFCAA.Clear();
		openedPaths.Clear();
		if (!Application.isPlaying)
		{
			NDMFDOHLBPD();
		}
		GDMCKLPPMAM();
		LADFMDJAMLO.Clear();
		LGMIANCNPMI.Clear();
		LADFMDJAMLO.Clear();
		LGMIANCNPMI.Clear();
		MineVariantsSelector.DHMBKGALAFC(piecesPrefabs);
		MinePiece lPBEOKMHKGO = KIMCNNHEHNH();
		DestroyLevel(currentLevel);
		BPIIMNLBEKK = Object.Instantiate<MineLevel>(mineLevelPrefab, Vector2.op_Implicit(Vector2.zero), Quaternion.identity, ((Component)this).transform);
		APONCLJEAPJ = ((Component)BPIIMNLBEKK).gameObject;
		((Object)APONCLJEAPJ).name = "Level " + currentLevel;
		BPIIMNLBEKK.level = currentLevel;
		allBlocks = BPIIMNLBEKK.blocks;
		MineManager.AddLevel(BPIIMNLBEKK);
		BPIIMNLBEKK.currentSeed = _currentSeed;
		GameObject blackModulesParent = new GameObject("Black modules");
		blackModulesParent.transform.SetParent(APONCLJEAPJ.transform);
		blackModulesParent.AddComponent<Grid>().cellSize = new Vector3(0.5f, 0.5f);
		if ((Object)(object)blackModulesParent != (Object)null)
		{
			Debug.Log((object)("Creado blackmodule parent: " + ((Object)blackModulesParent).name));
		}
		else
		{
			Debug.LogError((object)"Error al crear blackModulesParent");
		}
		MinePuzzleManager minePuzzleManager = (KFNHEOAAAKD ? MinePuzzleManagerPool.Get(minePuzzleManagerPrefab, APONCLJEAPJ.transform) : Object.Instantiate<MinePuzzleManager>(minePuzzleManagerPrefab, APONCLJEAPJ.transform));
		BPIIMNLBEKK.SetPuzzleManager(minePuzzleManager, printDebug);
		MinePuzzleType chosenPuzzle = minePuzzleManager.GetChosenPuzzleType();
		int elementsRequieredByType = minePuzzleManager.GetElementsRequieredByType(chosenPuzzle);
		bool needBigSpawner = minePuzzleManager.NeedBigSpawner(chosenPuzzle);
		KMIEMNOMHPD = Mathf.Max(KMIEMNOMHPD, elementsRequieredByType + 2);
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)$"BLOCKS NUMBER: {KMIEMNOMHPD} Puzzle Needit: {elementsRequieredByType + 2}");
		}
		MinePiece minePiece = LEODJOIEIDC(lPBEOKMHKGO, APONCLJEAPJ);
		((Component)minePiece).transform.position = ONHBHPNCNGM(currentLevel);
		minePiece.SetMineStairsInfo(currentLevel, currentLevel - 1);
		minePiece.elevatorSwitch.SetTravelZone(currentLevel);
		BPIIMNLBEKK.puzzleManager.SetEntrancePosition(Vector2.op_Implicit(((Component)minePiece).transform.position));
		for (int i = 0; i < ((Vector2Int)(ref minePiece.pieceSize)).x; i++)
		{
			for (int j = 0; j < ((Vector2Int)(ref minePiece.pieceSize)).y; j++)
			{
				Vector2Int key = new Vector2Int((int)((Component)minePiece).transform.position.x, (int)((Component)minePiece).transform.position.y) + new Vector2Int(i, j) * blockSize;
				BPIIMNLBEKK.AddPiece(minePiece);
				BPIIMNLBEKK.blocks.Add(key, minePiece.blocks[j * ((Vector2Int)(ref minePiece.pieceSize)).x + i]);
				BPIIMNLBEKK.blocks[key].piece = minePiece;
			}
		}
		for (int k = 0; k < minePiece.blocks.Length; k++)
		{
			for (int l = 0; l < minePiece.blocks[k].openedPaths.Length; l++)
			{
				minePiece.blocks[k].openedPaths[l].distance = 0;
				openedPaths.Add(minePiece.blocks[k].openedPaths[l]);
				minePiece.blocks[k].openedPaths[l].block = minePiece.blocks[k];
			}
		}
		if (!generateInOneFrame && Application.isPlaying)
		{
			yield return null;
		}
		int kMIEMNOMHPD = KMIEMNOMHPD;
		bool altarPlaced = false;
		bool bigSpawnerPlaced = false;
		int altarAttempts = 0;
		List<MinePiece> altarPieces = new List<MinePiece>();
		List<MinePiece> bigSpawnerPieces = null;
		int altarTargetBlock = 0;
		int bigSpawnerTargetBlock = 0;
		bool canGeneratePuzzle = BPIIMNLBEKK.puzzleManager.canGeneratePuzzle;
		if (canGeneratePuzzle)
		{
			for (int m = 0; m < notClosingPiecesPrefabs.Count; m++)
			{
				if ((notClosingPiecesPrefabs[m].puzzleSpawnersTypes & PuzzleSpawnerType.Altar) != 0)
				{
					altarPieces.Add(notClosingPiecesPrefabs[m]);
				}
			}
			bool flag = NextRandom(0, 2) == 0;
			int num = NextRandom(Mathf.Max(1, kMIEMNOMHPD / 4), Mathf.Max(kMIEMNOMHPD / 2, 2));
			int num2 = NextRandom(num + 2, Mathf.Max(num + 3, 3 * kMIEMNOMHPD / 4));
			altarTargetBlock = (flag ? num : num2);
			if (needBigSpawner)
			{
				bigSpawnerTargetBlock = (flag ? num2 : num);
				bigSpawnerPieces = new List<MinePiece>();
				PuzzleSpawnerType puzzleSpawnerType = MinePuzzleManager.PuzzleTypeToSpawnerType(chosenPuzzle);
				for (int n = 0; n < notClosingPiecesPrefabs.Count; n++)
				{
					if ((notClosingPiecesPrefabs[n].puzzleSpawnersTypes & puzzleSpawnerType) != 0)
					{
						bigSpawnerPieces.Add(notClosingPiecesPrefabs[n]);
					}
				}
			}
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"[ProceduralMine] AltarFirst: {flag} - AltarTarget: {altarTargetBlock} - PuzzleTarget: {bigSpawnerTargetBlock}", (Object)(object)this);
			}
		}
		Vector2Int val;
		while (!MaximumBlocksReached() || !MinimumClosedRoomsReached() || (canGeneratePuzzle && !altarPlaced && altarPieces.Count > 0 && altarAttempts < 5))
		{
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"Blocks generated: {allBlocks.Count}. Opened paths: {openedPaths.Count}. Current steps: {EDMKFGBHAPL}. Altar placed: {altarPlaced}. Big spawner placed: {bigSpawnerPlaced} AltarPieces Array: {altarPieces.Count}.");
			}
			MinePiece minePiece2 = null;
			if (openedPaths.Count == 0)
			{
				Debug.LogError((object)"openedPaths 0 before all blocksGenerationNumber");
				if (OnlineManager.MasterOrOffline())
				{
					yield return LJCACPLNIIG(EONJGMONIOM);
					yield break;
				}
			}
			OpenedPath openedPath = DGMPPKCJKGP();
			if (canGeneratePuzzle && !altarPlaced && altarPieces.Count > 0 && allBlocks.Count >= altarTargetBlock)
			{
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"[ProceduralMine] Trying to force ALTAR piece at block {allBlocks.Count} (target is {altarTargetBlock}). Path block pos: {openedPath.block.CJGAMLEMBNL()}", (Object)(object)this);
				}
				minePiece2 = MinePieceSelector.OGGPMJDMBPB(openedPath, altarPieces, NKEMALMMOBL: false);
				if ((Object)(object)minePiece2 != (Object)null)
				{
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)$"[ProceduralMine] Forced ALTAR piece {((Object)minePiece2).name} at block {allBlocks.Count} (target was {altarTargetBlock}). Path block pos: {openedPath.block.CJGAMLEMBNL()}", (Object)(object)this);
					}
					altarPlaced = true;
				}
				else
				{
					altarAttempts++;
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)$"[ProceduralMine] ALTAR: No valid piece for path dir={openedPath.direction} at block {allBlocks.Count}. Candidates: {altarPieces.Count}. Retrying next iteration.", (Object)(object)this);
					}
				}
			}
			if (canGeneratePuzzle && (Object)(object)minePiece2 == (Object)null && needBigSpawner && !bigSpawnerPlaced && allBlocks.Count >= bigSpawnerTargetBlock)
			{
				minePiece2 = MinePieceSelector.OGGPMJDMBPB(openedPath, bigSpawnerPieces, NKEMALMMOBL: false);
				if ((Object)(object)minePiece2 != (Object)null)
				{
					if (Application.isEditor && printDebug)
					{
						Debug.Log((object)$"[ProceduralMine] Forced BIG SPAWNER piece {((Object)minePiece2).name} at block {allBlocks.Count} (target was {bigSpawnerTargetBlock}). Path block pos: {openedPath.block.CJGAMLEMBNL()}", (Object)(object)this);
					}
					bigSpawnerPlaced = true;
				}
				else if (Application.isEditor && printDebug)
				{
					Debug.LogWarning((object)$"[ProceduralMine] BIG SPAWNER: No valid piece for path dir={openedPath.direction} at block {allBlocks.Count}. Candidates: {bigSpawnerPieces.Count}. Retrying next iteration.", (Object)(object)this);
				}
			}
			if ((Object)(object)minePiece2 == (Object)null)
			{
				minePiece2 = MinePieceSelector.IGFKEFKNPEN(openedPath, ANCMKNOJCHI: false, usePiecesRarity, BPIIMNLBEKK.isPuzzlePlaced);
			}
			if (Object.op_Implicit((Object)(object)minePiece2))
			{
				LEODJOIEIDC(minePiece2, openedPath);
				if (minePiece2.uniquePiece)
				{
					RegisterUniquePiece(minePiece2);
				}
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"Placed piece {((Object)minePiece2).name} at block {allBlocks.Count}. Path block pos: {openedPath.block.CJGAMLEMBNL()}. Opened path dir: {openedPath.direction}. Altar placed: {altarPlaced}. Big spawner placed: {bigSpawnerPlaced}.", (Object)(object)this);
				}
			}
			else
			{
				val = openedPath.block.CJGAMLEMBNL();
				Debug.LogError((object)("Cannot place mine block piece at " + ((object)(Vector2Int)(ref val)).ToString() + " " + openedPath.direction));
			}
			EDMKFGBHAPL--;
			while (EDMKFGBHAPL <= 0)
			{
				yield return null;
			}
			if (!generateInOneFrame && Application.isPlaying)
			{
				yield return null;
			}
		}
		if (currentLevel < 6)
		{
			OpenedPath openedPath = APAEGBDPHJL();
			MinePiece minePiece2 = MinePieceSelector.MFECIFINPPH(openedPath, nextLevelPrefabs, NKEMALMMOBL: true);
			if (!Object.op_Implicit((Object)(object)minePiece2) && OnlineManager.MasterOrOffline())
			{
				yield return LJCACPLNIIG(EONJGMONIOM);
				yield break;
			}
			MinePiece minePiece3 = LEODJOIEIDC(minePiece2, openedPath);
			if (Object.op_Implicit((Object)(object)minePiece3))
			{
				if (Application.isEditor && printDebug)
				{
					Debug.Log((object)$"[ProceduralMine] Exit piece: {((Object)minePiece3).name} - stairsTravelZone: {minePiece3.stairsTravelZone}", (Object)(object)this);
				}
				minePiece3.SetMineStairsInfo(currentLevel, currentLevel + 1);
				minePiece3.ActivateStairsBlocker(currentLevel);
				BPIIMNLBEKK.nextLevelPiece = minePiece3;
				BPIIMNLBEKK.puzzleManager.SetExitPosition(Vector2.op_Implicit(((Component)minePiece3).transform.position));
			}
			if (!generateInOneFrame && Application.isPlaying)
			{
				yield return null;
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineMineManager.instance.SendGenerateMineLevel(EONJGMONIOM, _currentSeed);
		}
		while (openedPaths.Count > 0)
		{
			OpenedPath openedPath = APAEGBDPHJL();
			MinePiece minePiece2 = MinePieceSelector.IGFKEFKNPEN(openedPath, ANCMKNOJCHI: true, usePiecesRarity, BPIIMNLBEKK.isPuzzlePlaced);
			if (Object.op_Implicit((Object)(object)minePiece2))
			{
				LEODJOIEIDC(minePiece2, openedPath);
			}
			else
			{
				minePiece2 = MinePieceSelector.IGFKEFKNPEN(openedPath, ANCMKNOJCHI: false, usePiecesRarity, BPIIMNLBEKK.isPuzzlePlaced);
				if (Object.op_Implicit((Object)(object)minePiece2))
				{
					LEODJOIEIDC(minePiece2, openedPath);
				}
				else
				{
					val = openedPath.block.CJGAMLEMBNL();
					Debug.LogError((object)("Cannot place mine block piece at " + ((object)(Vector2Int)(ref val)).ToString() + " " + openedPath.direction));
				}
			}
			if (!generateInOneFrame && Application.isPlaying)
			{
				yield return null;
			}
		}
		ONGIFNCJBDD(ref HHOPCCKCBJM, ref FEOJNEGIHKI, ref HLPLAHPIEHB, ref GOCGLKPEBIG);
		LACOFNDKGDA();
		BPIIMNLBEKK.puzzleManager.GenerateAltar();
		if (Application.isPlaying)
		{
			CalculateCameraBounds();
		}
		if (!generateInOneFrame && Application.isPlaying)
		{
			yield return null;
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)"== START PLACE PIECES ==");
		}
		for (int num3 = 0; num3 < BPIIMNLBEKK.pieces.Count; num3++)
		{
			BPIIMNLBEKK.pieces[num3].ActivateVariants(BPIIMNLBEKK.puzzleManager.GetAltarPieceId());
		}
		if (BPIIMNLBEKK.puzzleManager.canGeneratePuzzle && !BPIIMNLBEKK.puzzleManager.GeneratePuzzle())
		{
			Debug.LogError((object)"NO SE HA PODIDO GENERAR EL PUZZLE - ERROR!!");
		}
		List<PuzzleExclusionZone> exclusionZones = BPIIMNLBEKK.puzzleManager.GetExclusionZones();
		exclusionZones.AddRange(BPIIMNLBEKK.GetDestructibleDisablerZones());
		for (int num4 = 0; num4 < BPIIMNLBEKK.pieces.Count; num4++)
		{
			BPIIMNLBEKK.pieces[num4].PlacePiece(currentLevel, exclusionZones);
		}
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)"== END PLACE PIECES ==");
		}
		if (!generateInOneFrame && Application.isPlaying)
		{
			yield return null;
		}
		allBlocks = BPIIMNLBEKK.blocks;
		string text = $"blackModulesParent null: {(Object)(object)blackModulesParent == (Object)null}, ";
		object obj;
		if (blackModulesParent == null)
		{
			obj = null;
		}
		else
		{
			Transform transform = blackModulesParent.transform;
			obj = ((transform != null) ? transform.parent : null);
		}
		Debug.Log((object)(text + $"parent null: {(Object)obj == (Object)null}, " + $"parent destroyed: {(Object)(object)blackModulesParent.transform.parent == (Object)null}"));
		LIMJPJLFFML(blackModulesParent);
		LIMJPJLFFML(blackModulesParent);
		MineMineralsGenerator.SpawnMineralRocks(currentLevel, BPIIMNLBEKK, exclusionZones);
		BPIIMNLBEKK.InstantiateHoleInGround(holesProbabilities, holeInGroundPrefab, exclusionZones);
		generatingLevel = -1;
		MineManager.GGFJGHHHEJC.LevelGenerated(currentLevel);
		if (BPIIMNLBEKK.puzzleManager.canGeneratePuzzle && BPIIMNLBEKK.puzzleManager.GetCurrentPuzzleType() == MinePuzzleType.KeyFragments)
		{
			List<DestructibleObject> allDestructibleObjectsInLevel = BPIIMNLBEKK.GetAllDestructibleObjectsInLevel();
			List<HoleInGround> nCJABADPACK = new List<HoleInGround>(BPIIMNLBEKK.holesInstantiated);
			List<MineFishingKeyItem> allFishingSpotsInLevel = BPIIMNLBEKK.GetAllFishingSpotsInLevel();
			if (Application.isEditor && printDebug)
			{
				Debug.Log((object)$"Hay {allDestructibleObjectsInLevel.Count} destructibles y {BPIIMNLBEKK.holesInstantiated.Count} agujeros para cavar disponibles para el puzzle {((object)BPIIMNLBEKK.puzzleManager.GetCurrentPuzzle()).ToString()}");
			}
			BPIIMNLBEKK.puzzleManager.SetKeyFragments(allDestructibleObjectsInLevel, nCJABADPACK, allFishingSpotsInLevel);
		}
		SetupGizmos();
		EAOAFFLEGLJ(BPIIMNLBEKK);
		Debug.Log((object)$"Finished generating level {currentLevel}. Total blocks: {allBlocks.Count}. Opened paths: {openedPaths.Count}. Altar placed: {altarPlaced}. Big spawner placed: {bigSpawnerPlaced}. Puzzle type: {BPIIMNLBEKK.puzzleManager.GetCurrentPuzzleType()}. Seed: {_currentSeed}");
	}

	private MinePiece HODCNAKODGI(MinePiece AAHMGBKHKBI, OpenedPath AEFGHKEGDDG)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && printDebug)
		{
			Debug.Log((object)string.Format("[WaiterGender=", ((Object)AAHMGBKHKBI).name, AEFGHKEGDDG.block.CJGAMLEMBNL(), AEFGHKEGDDG.direction), (Object)(object)this);
		}
		for (int i = 1; i < AAHMGBKHKBI.blocks.Length; i += 0)
		{
			if (!AAHMGBKHKBI.blocks[i].PFDGFMJBLAL(Utils.ABNPPDOGEPM(AEFGHKEGDDG.direction)) || !MinePieceSelector.NNPPGEBNLNB(AAHMGBKHKBI, i, AEFGHKEGDDG, NKEMALMMOBL: false))
			{
				continue;
			}
			Vector2Int val = AEFGHKEGDDG.KEKCCIFEJCP().DBNDLHEBABD() + Utils.NLFDOFAOJHP(AEFGHKEGDDG.direction) * blockSize;
			Vector2Int val2 = val - AAHMGBKHKBI.blocks[i].position * blockSize;
			MinePiece minePiece = LEODJOIEIDC(AAHMGBKHKBI, APONCLJEAPJ);
			minePiece.SetRuntimeID();
			minePiece.printDebugLogs = printDebug;
			((Component)minePiece).transform.position = new Vector3((float)((Vector2Int)(ref val2)).x, (float)((Vector2Int)(ref val2)).y);
			BPIIMNLBEKK.allRockSpawners.AddRange(minePiece.rockSpawners);
			BPIIMNLBEKK.OJOJGJFMNCF(minePiece);
			if (BPIIMNLBEKK.puzzleManager.canGeneratePuzzle && minePiece.puzzleSpawners.Length != 0)
			{
				BPIIMNLBEKK.puzzleManager.AddPuzzleSpawners(minePiece.puzzleSpawners, minePiece.ECAPDMGPJFP(), minePiece.maxPuzzleSpawners);
			}
			for (int j = 0; j < ((Vector2Int)(ref minePiece.pieceSize)).x; j += 0)
			{
				for (int k = 1; k < ((Vector2Int)(ref minePiece.pieceSize)).y; k += 0)
				{
					Vector2Int key = val2 + new Vector2Int(j, k) * blockSize;
					allBlocks.Add(key, minePiece.blocks[k * ((Vector2Int)(ref minePiece.pieceSize)).x + j]);
					allBlocks[key].piece = minePiece;
				}
			}
			for (int l = 1; l < minePiece.blocks.Length; l += 0)
			{
				val = val2 + minePiece.blocks[l].position * blockSize;
				for (int m = 0; m < minePiece.blocks[l].openedPaths.Length; m++)
				{
					Vector2Int key2 = val + Utils.NLFDOFAOJHP(minePiece.blocks[l].openedPaths[m].direction) * blockSize;
					if (allBlocks.ContainsKey(key2))
					{
						for (int n = 0; n < allBlocks[key2].openedPaths.Length; n++)
						{
							if (allBlocks[key2].openedPaths[n].direction == Utils.ABNPPDOGEPM(minePiece.blocks[l].openedPaths[m].direction))
							{
								openedPaths.Remove(allBlocks[key2].openedPaths[n]);
								break;
							}
						}
					}
					else
					{
						minePiece.blocks[l].openedPaths[m].distance = AEFGHKEGDDG.distance + 1;
						openedPaths.Add(minePiece.blocks[l].openedPaths[m]);
						minePiece.blocks[l].openedPaths[m].MDMIHDFBBGO(minePiece.blocks[l]);
					}
				}
			}
			return minePiece;
		}
		return null;
	}

	public void IGHCDFAJJPC(int EONJGMONIOM, int BLLLPOFNPLM = 0)
	{
		if ((Object)(object)MineManager.CEGJAHJMCOD(EONJGMONIOM) != (Object)null || EONJGMONIOM == generatingLevel)
		{
			return;
		}
		foreach (MineLevelQueueInfo item in INJGJNKOGNL)
		{
			if (item.level == EONJGMONIOM)
			{
				return;
			}
		}
		INJGJNKOGNL.Enqueue(new MineLevelQueueInfo(EONJGMONIOM, BLLLPOFNPLM));
		if (!BCEGPBHAJHC)
		{
			EHBJEBMKDPL = ((MonoBehaviour)this).StartCoroutine(BAIOBHMLMHA());
		}
	}

	private OpenedPath LBDCIJKOELH()
	{
		int index = NextRandom(1, openedPaths.Count);
		OpenedPath result = openedPaths[index];
		openedPaths.RemoveAt(index);
		return result;
	}

	private bool COFKEGKKODG(Vector2Int ADNLDKBNEGN)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return BPIIMNLBEKK.blocks.ContainsKey(ADNLDKBNEGN);
	}

	private void NDMFDOHLBPD()
	{
		closingPiecesPrefabs.Clear();
		notClosingPiecesPrefabs.Clear();
		for (int i = 0; i < piecesPrefabs.Length; i++)
		{
			if (piecesPrefabs[i].IMFDKOCJENF)
			{
				closingPiecesPrefabs.Add(piecesPrefabs[i]);
			}
			else
			{
				notClosingPiecesPrefabs.Add(piecesPrefabs[i]);
			}
		}
	}

	private MinePiece JPFGIONLPHK(MinePiece LPBEOKMHKGO, GameObject DMBHHLKMHOH)
	{
		MinePiece minePiece = null;
		if (PMOKBABHLBD())
		{
			minePiece = MinePiecePool.EOPIEMLAPFN(LPBEOKMHKGO, DMBHHLKMHOH.transform);
		}
		else if (Application.isPlaying)
		{
			minePiece = Object.Instantiate<MinePiece>(LPBEOKMHKGO, DMBHHLKMHOH.transform);
		}
		minePiece.SetRuntimeID();
		minePiece.printDebugLogs = printDebug;
		return minePiece;
	}

	private Vector3 ANMJKPKLODM(int EONJGMONIOM)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)this).transform.position + new Vector3((float)((EONJGMONIOM - 0) * 64), 1970f);
	}

	private void ELDIJIKBLCO(GameObject BKJIDIBAMOC)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		HLCEKEKPMGN.Clear();
		foreach (KeyValuePair<Vector2Int, MineBlock> block in BPIIMNLBEKK.blocks)
		{
			JMCCBEKFOPG(block.Key, BKJIDIBAMOC, HLCEKEKPMGN);
		}
	}

	private OpenedPath NJPPJHGFAMM()
	{
		if (openedPaths.Count == 0)
		{
			return null;
		}
		OpenedPath openedPath = null;
		float num = 631f;
		foreach (OpenedPath openedPath2 in openedPaths)
		{
			if ((float)openedPath2.distance > num)
			{
				num = openedPath2.distance;
				openedPath = openedPath2;
			}
		}
		openedPaths.Remove(openedPath);
		return openedPath;
	}
}
