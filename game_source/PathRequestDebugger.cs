using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PathRequestDebugger : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class BHDPKGNKEJL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool instant;

		public PathRequestInfo currentPathRequest;

		public PathRequestParameters info;

		public int stepsIncrement;

		public List<Vector2> path;

		private bool _003Cdone_003E5__2;

		private bool _003CcheckSize_003E5__3;

		private bool _003CtileNeeded_003E5__4;

		private Location _003CgoalLocation_003E5__5;

		private bool _003CgoalLocationStarted_003E5__6;

		private Dictionary<Vector3, float> _003CcostSoFar_003E5__7;

		private int _003CstepsCount_003E5__8;

		private Neighbour[] _003Cneighbours_003E5__9;

		private HashSet<Vector2> _003Cclosed_003E5__10;

		private List<Vector2> _003CopenPositions_003E5__11;

		private Vector2[] _003ChorizontalNodes_003E5__12;

		private Vector2[] _003CverticalNodes_003E5__13;

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
		public BHDPKGNKEJL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0338: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_036c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Unknown result type (might be due to invalid IL or missing references)
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_048a: Unknown result type (might be due to invalid IL or missing references)
			//IL_048f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0444: Unknown result type (might be due to invalid IL or missing references)
			//IL_0449: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0529: Unknown result type (might be due to invalid IL or missing references)
			//IL_0545: Unknown result type (might be due to invalid IL or missing references)
			//IL_054a: Unknown result type (might be due to invalid IL or missing references)
			//IL_056e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0573: Unknown result type (might be due to invalid IL or missing references)
			//IL_057a: Unknown result type (might be due to invalid IL or missing references)
			//IL_057f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_078b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0790: Unknown result type (might be due to invalid IL or missing references)
			//IL_0659: Unknown result type (might be due to invalid IL or missing references)
			//IL_0664: Unknown result type (might be due to invalid IL or missing references)
			//IL_0611: Unknown result type (might be due to invalid IL or missing references)
			//IL_061c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0945: Unknown result type (might be due to invalid IL or missing references)
			//IL_0954: Unknown result type (might be due to invalid IL or missing references)
			//IL_0959: Unknown result type (might be due to invalid IL or missing references)
			//IL_095e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0807: Unknown result type (might be due to invalid IL or missing references)
			//IL_0816: Unknown result type (might be due to invalid IL or missing references)
			//IL_081b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0820: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0abd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
			//IL_085c: Unknown result type (might be due to invalid IL or missing references)
			//IL_086b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0870: Unknown result type (might be due to invalid IL or missing references)
			//IL_0875: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c31: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bfd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d18: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d89: Unknown result type (might be due to invalid IL or missing references)
			//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e33: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e89: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dab: Unknown result type (might be due to invalid IL or missing references)
			//IL_0db0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e06: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				if (!instant)
				{
					Debug.Log((object)"Path Request Triggered!");
				}
				_003CgoalLocation_003E5__5 = Utils.HJPCBBGHPDA(Vector2.op_Implicit(currentPathRequest.goalPos));
				_003CgoalLocationStarted_003E5__6 = false;
				info.cameFrom.Clear();
				_003CcostSoFar_003E5__7 = new Dictionary<Vector3, float>();
				_003CstepsCount_003E5__8 = stepsIncrement;
				info.diagonal = Mathf.Sqrt(info.recto * info.recto * 2f);
				_003Cdone_003E5__2 = false;
				MDMAAIKFBFB = currentPathRequest.startPos;
				MNLINFLOKHD = Vector2.op_Implicit(currentPathRequest.goalPos);
				info.cameFrom.Add(MDMAAIKFBFB, MDMAAIKFBFB);
				_003CcostSoFar_003E5__7.Add(MDMAAIKFBFB, 0f);
				if (currentPathRequest.canWalkDiagonal)
				{
					_003Cneighbours_003E5__9 = new Neighbour[WorldGrid.allMovementNeighbours.Length + 1];
				}
				else
				{
					_003Cneighbours_003E5__9 = new Neighbour[5];
				}
				info.nodes = new List<Vector3>();
				_003Cclosed_003E5__10 = new HashSet<Vector2>();
				info.open.Clear();
				_003CopenPositions_003E5__11 = new List<Vector2>();
				path.Clear();
				AStarNode value = default(AStarNode);
				value.position = Vector2.op_Implicit(currentPathRequest.startPos);
				value.EMOJEGDNKLG = 0f;
				value.MEFCBDDDMOG = 0f;
				info.open.Add(currentPathRequest.startPos, value);
				_003CopenPositions_003E5__11.Add(Vector2.op_Implicit(currentPathRequest.startPos));
				if (((Vector2Int)(ref currentPathRequest.horizontalSize)).x > 1 || ((Vector2Int)(ref currentPathRequest.horizontalSize)).y > 1 || ((Vector2Int)(ref currentPathRequest.verticalSize)).x > 1 || ((Vector2Int)(ref currentPathRequest.verticalSize)).y > 1)
				{
					_003CcheckSize_003E5__3 = true;
				}
				else
				{
					_003CcheckSize_003E5__3 = false;
				}
				if (currentPathRequest.takePath || currentPathRequest.tryAvoidGroundType != 0 || currentPathRequest.tryAvoidZones != 0)
				{
					_003CtileNeeded_003E5__4 = true;
				}
				else
				{
					_003CtileNeeded_003E5__4 = false;
				}
				GameTileMaps.LoadPathNodes();
				_003ChorizontalNodes_003E5__12 = (Vector2[])(object)new Vector2[((Vector2Int)(ref currentPathRequest.horizontalSize)).x * ((Vector2Int)(ref currentPathRequest.horizontalSize)).y];
				_003CverticalNodes_003E5__13 = (Vector2[])(object)new Vector2[((Vector2Int)(ref currentPathRequest.verticalSize)).x * ((Vector2Int)(ref currentPathRequest.verticalSize)).y];
				if (!instant)
				{
					Debug.Log((object)"Starting");
				}
				TravelZonesManager.GGFJGHHHEJC.allTravelZones = new Dictionary<Location, Dictionary<Location, TravelZone>>();
				TravelZone[] array = Object.FindObjectsOfType<TravelZone>();
				foreach (TravelZone pHGGMIMGFDK in array)
				{
					TravelZonesManager.GGFJGHHHEJC.AddToDictionary(pHGGMIMGFDK);
				}
				goto IL_0f9b;
			}
			case 1:
				_003C_003E1__state = -1;
				goto IL_0f92;
			case 2:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0f67:
				_003CstepsCount_003E5__8--;
				goto IL_0f92;
				IL_0f9b:
				while (_003CopenPositions_003E5__11.Count > 0)
				{
					AStarNode aStarNode = info.open[Vector2.op_Implicit(_003CopenPositions_003E5__11[0])];
					int index = 0;
					for (int j = 1; j < info.open.Count; j++)
					{
						if (info.open[Vector2.op_Implicit(_003CopenPositions_003E5__11[j])].JJCAEAEOLIP < aStarNode.JJCAEAEOLIP || (info.open[Vector2.op_Implicit(_003CopenPositions_003E5__11[j])].JJCAEAEOLIP == aStarNode.JJCAEAEOLIP && info.open[Vector2.op_Implicit(_003CopenPositions_003E5__11[j])].MEFCBDDDMOG < aStarNode.MEFCBDDDMOG))
						{
							aStarNode = info.open[Vector2.op_Implicit(_003CopenPositions_003E5__11[j])];
							index = j;
						}
					}
					Vector2 position;
					if (!instant)
					{
						position = aStarNode.position;
						Debug.Log((object)("---> Chosen: " + ((object)(Vector2)(ref position)).ToString() + "/" + aStarNode.JJCAEAEOLIP));
					}
					info.open.Remove(Vector2.op_Implicit(_003CopenPositions_003E5__11[index]));
					_003CopenPositions_003E5__11.RemoveAt(index);
					_003Cclosed_003E5__10.Add(aStarNode.position);
					info.nodes.Add(Vector2.op_Implicit(aStarNode.position));
					if (((Vector2)(ref aStarNode.position)).Equals(MNLINFLOKHD))
					{
						break;
					}
					WorldGrid.DLFFCGLGDLL(Vector2.op_Implicit(aStarNode.position), ref _003Cneighbours_003E5__9, currentPathRequest.canWalkDiagonal);
					for (int k = 0; k < _003Cneighbours_003E5__9.Length; k++)
					{
						if (_003Cclosed_003E5__10.Contains(_003Cneighbours_003E5__9[k].position))
						{
							continue;
						}
						if (_003Cneighbours_003E5__9[k].position == MNLINFLOKHD)
						{
							info.cameFrom.Add(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position), Vector2.op_Implicit(aStarNode.position));
							_003Cdone_003E5__2 = true;
							break;
						}
						if (!_003Cneighbours_003E5__9[k].free && (currentPathRequest.currentNodes == null || !currentPathRequest.currentNodes.Contains(_003Cneighbours_003E5__9[k].position)))
						{
							continue;
						}
						if (_003CcheckSize_003E5__3)
						{
							if (Utils.ABPDGOHBKIG(_003Cneighbours_003E5__9[k].direction))
							{
								WorldGrid.MDJDAKIMMJA(_003Cneighbours_003E5__9[k].position, currentPathRequest.horizontalSize, ref _003ChorizontalNodes_003E5__12);
								if (!WorldGrid.NGDDILJAHEK(_003ChorizontalNodes_003E5__12, currentPathRequest.currentNodes))
								{
									continue;
								}
							}
							else
							{
								WorldGrid.MDJDAKIMMJA(_003Cneighbours_003E5__9[k].position, currentPathRequest.verticalSize, ref _003CverticalNodes_003E5__13);
								if (!WorldGrid.NGDDILJAHEK(_003CverticalNodes_003E5__13, currentPathRequest.currentNodes))
								{
									continue;
								}
							}
						}
						else if (_003Cneighbours_003E5__9[k].direction == Direction.Diagonal)
						{
							switch (k)
							{
							case 4:
								if (!_003Cneighbours_003E5__9[0].free || !_003Cneighbours_003E5__9[3].free)
								{
									continue;
								}
								break;
							case 5:
								if (!_003Cneighbours_003E5__9[0].free || !_003Cneighbours_003E5__9[2].free)
								{
									continue;
								}
								break;
							case 6:
								if (!_003Cneighbours_003E5__9[1].free || !_003Cneighbours_003E5__9[3].free)
								{
									continue;
								}
								break;
							case 7:
								if (!_003Cneighbours_003E5__9[1].free || !_003Cneighbours_003E5__9[2].free)
								{
									continue;
								}
								break;
							}
						}
						float num = _003CcostSoFar_003E5__7[Vector2.op_Implicit(aStarNode.position)];
						if (_003CtileNeeded_003E5__4)
						{
							WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position), out var ILDEFBIANKO);
							if (currentPathRequest.takePath)
							{
								if (!ILDEFBIANKO.isPath || ILDEFBIANKO.isHorsePath)
								{
									num += info.pathPenalization;
								}
								else
								{
									WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position - new Vector2(0.25f, 0f)), out var ILDEFBIANKO2);
									if (!ILDEFBIANKO2.isPath || ILDEFBIANKO2.isHorsePath)
									{
										num += info.pathPenalization;
									}
									else
									{
										WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position - new Vector2(0f, 0.25f)), out ILDEFBIANKO2);
										if (!ILDEFBIANKO2.isPath || ILDEFBIANKO2.isHorsePath)
										{
											num += info.pathPenalization;
										}
									}
								}
							}
							if (currentPathRequest.tryAvoidGroundType != 0)
							{
								if (currentPathRequest.tryAvoidGroundType.HasFlag(ILDEFBIANKO.groundType))
								{
									num = ((_003Cneighbours_003E5__9[k].direction != Direction.Diagonal) ? (num + info.penalizaciones) : (num + info.penalizaciones * (info.diagonal / info.recto)));
								}
								else if (currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position + new Vector2(-0.25f, 0f)))))
								{
									num += info.penalizaciones;
								}
								else if (currentPathRequest.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position + new Vector2(0f, -0.25f)))))
								{
									num += info.penalizaciones;
								}
							}
							if (currentPathRequest.tryAvoidZones != 0)
							{
								if (currentPathRequest.tryAvoidZones.HasFlag(ILDEFBIANKO.zoneType))
								{
									num += info.penalizaciones * 2f;
								}
								else if (currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position + new Vector2(-0.25f, 0f)))))
								{
									num += info.penalizaciones * 2f;
								}
								else if (currentPathRequest.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position + new Vector2(0f, -0.25f)))))
								{
									num += info.penalizaciones * 2f;
								}
							}
						}
						if (Utils.EJPFCKFEMJF(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position)))
						{
							num += DFKMPMMLGNL(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position));
						}
						num = ((_003Cneighbours_003E5__9[k].direction != Direction.Diagonal) ? (num + info.recto * _003Cneighbours_003E5__9[k].cost) : (num + info.diagonal * _003Cneighbours_003E5__9[k].cost));
						if (_003CcostSoFar_003E5__7.ContainsKey(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position)) && !(num < _003CcostSoFar_003E5__7[Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position)]))
						{
							continue;
						}
						Vector3 oDNGJHPOMMK;
						if (_003CgoalLocationStarted_003E5__6)
						{
							if (Utils.HJPCBBGHPDA(_003Cneighbours_003E5__9[k].position) != _003CgoalLocation_003E5__5)
							{
								continue;
							}
							oDNGJHPOMMK = Vector2.op_Implicit(MNLINFLOKHD);
						}
						else if (Utils.HJPCBBGHPDA(_003Cneighbours_003E5__9[k].position) == _003CgoalLocation_003E5__5)
						{
							oDNGJHPOMMK = Vector2.op_Implicit(MNLINFLOKHD);
							info.open.Clear();
							_003CopenPositions_003E5__11.Clear();
							_003CgoalLocationStarted_003E5__6 = true;
						}
						else if (Object.op_Implicit((Object)(object)TravelZonesManager.GGFJGHHHEJC) && (Object)(object)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Utils.HJPCBBGHPDA(_003Cneighbours_003E5__9[k].position), _003CgoalLocation_003E5__5) != (Object)null)
						{
							Vector3 centrePosition = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Utils.HJPCBBGHPDA(_003Cneighbours_003E5__9[k].position), _003CgoalLocation_003E5__5).GetCentrePosition();
							Debug.Log((object)("GetTravelZone " + ((object)(Vector3)(ref centrePosition)).ToString()));
							oDNGJHPOMMK = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Utils.HJPCBBGHPDA(_003Cneighbours_003E5__9[k].position), _003CgoalLocation_003E5__5).GetCentrePosition();
						}
						else
						{
							oDNGJHPOMMK = Vector2.op_Implicit(MNLINFLOKHD);
						}
						AStarNode value = default(AStarNode);
						value.position = _003Cneighbours_003E5__9[k].position;
						value.EMOJEGDNKLG = num;
						value.MEFCBDDDMOG = Heuristic(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position), oDNGJHPOMMK, info);
						if (_003CcostSoFar_003E5__7.ContainsKey(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position)))
						{
							_003CcostSoFar_003E5__7[Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position)] = num;
							info.cameFrom[Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position)] = Vector2.op_Implicit(aStarNode.position);
							info.open[Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position)] = value;
						}
						else
						{
							_003CcostSoFar_003E5__7.Add(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position), num);
							info.cameFrom.Add(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position), Vector2.op_Implicit(aStarNode.position));
							info.open.Add(Vector2.op_Implicit(_003Cneighbours_003E5__9[k].position), value);
							_003CopenPositions_003E5__11.Add(_003Cneighbours_003E5__9[k].position);
						}
						if (!instant)
						{
							string[] obj = new string[8] { "*", null, null, null, null, null, null, null };
							position = value.position;
							obj[1] = ((object)(Vector2)(ref position)).ToString();
							obj[2] = " / H: ";
							obj[3] = value.MEFCBDDDMOG.ToString();
							obj[4] = " / G: ";
							obj[5] = value.EMOJEGDNKLG.ToString();
							obj[6] = " / F: ";
							obj[7] = value.JJCAEAEOLIP.ToString();
							Debug.Log((object)string.Concat(obj));
						}
					}
					if (_003Cdone_003E5__2)
					{
						break;
					}
					if (instant)
					{
						continue;
					}
					goto IL_0f67;
				}
				FindPath(out _003Cdone_003E5__2, path, info);
				if (!instant)
				{
					_003C_003E2__current = CommonReferences.wait5;
					_003C_003E1__state = 2;
					return true;
				}
				break;
				IL_0f92:
				if (_003CstepsCount_003E5__8 <= 0)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_0f9b;
			}
			CIPAKMCIFJI = null;
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

	public PathRequestInfo pathRequest;

	public PathRequestParameters pathRequestsInfo;

	public TilemapScene tilemapSceneEditorMode;

	public Dictionary<Vector3, Vector3> cameFrom = new Dictionary<Vector3, Vector3>();

	public Dictionary<Vector3, float> costSoFar = new Dictionary<Vector3, float>();

	private static Vector3 MDMAAIKFBFB;

	private static Vector2 MNLINFLOKHD;

	private List<Vector2> GDHHIIMLBEL = new List<Vector2>();

	public Transform startTransform;

	public Transform goalTransform;

	private static Coroutine CIPAKMCIFJI;

	public bool showDebug = true;

	public bool enableNextFinding = true;

	public int stepsIncrement = 10;

	public float heuristicMultiplier = 1.2f;

	public int stepsCount;

	private HashSet<Vector2> JLIPMGJBNPB = new HashSet<Vector2>();

	public static IEnumerator JCCMNLBHFHP(bool KENEGPFEHHI, PathRequestInfo FBKNFALLPGB, List<Vector2> GDHHIIMLBEL, PathRequestParameters BBJDPIJPLPA, int EFFPELLBCPM = 0)
	{
		return new BHDPKGNKEJL(1)
		{
			instant = KENEGPFEHHI,
			currentPathRequest = FBKNFALLPGB,
			path = GDHHIIMLBEL,
			info = BBJDPIJPLPA,
			stepsIncrement = EFFPELLBCPM
		};
	}

	public static List<Vector2> FindPath(out bool NLGIGDFOGCM, List<Vector2> GDHHIIMLBEL, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		GDHHIIMLBEL.Clear();
		Vector3 val = Vector2.op_Implicit(MNLINFLOKHD);
		while (!((Vector3)(ref val)).Equals(MDMAAIKFBFB))
		{
			if (!BBJDPIJPLPA.cameFrom.ContainsKey(val))
			{
				NLGIGDFOGCM = false;
				Debug.Log((object)("Finished Success: " + false));
				return new List<Vector2>();
			}
			GDHHIIMLBEL.Add(Vector2.op_Implicit(val));
			val = BBJDPIJPLPA.cameFrom[val];
		}
		GDHHIIMLBEL.Reverse();
		NLGIGDFOGCM = true;
		return GDHHIIMLBEL;
	}

	public void PEAIKPEKDFA()
	{
		stepsCount += stepsIncrement;
	}

	public static List<Vector2> GNKBHLAPIMN(out bool NLGIGDFOGCM, List<Vector2> GDHHIIMLBEL, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		GDHHIIMLBEL.Clear();
		Vector3 val = Vector2.op_Implicit(MNLINFLOKHD);
		while (!((Vector3)(ref val)).Equals(MDMAAIKFBFB))
		{
			if (!BBJDPIJPLPA.cameFrom.ContainsKey(val))
			{
				NLGIGDFOGCM = false;
				Debug.Log((object)("Disabled" + true));
				return new List<Vector2>();
			}
			GDHHIIMLBEL.Add(Vector2.op_Implicit(val));
			val = BBJDPIJPLPA.cameFrom[val];
		}
		GDHHIIMLBEL.Reverse();
		NLGIGDFOGCM = true;
		return GDHHIIMLBEL;
	}

	public static IEnumerator FHEBOKFKBBG(bool KENEGPFEHHI, PathRequestInfo FBKNFALLPGB, List<Vector2> GDHHIIMLBEL, PathRequestParameters BBJDPIJPLPA, int EFFPELLBCPM = 0)
	{
		return new BHDPKGNKEJL(1)
		{
			instant = KENEGPFEHHI,
			currentPathRequest = FBKNFALLPGB,
			path = GDHHIIMLBEL,
			info = BBJDPIJPLPA,
			stepsIncrement = EFFPELLBCPM
		};
	}

	public void FEDMNPGKMDB()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
			if ((Object)(object)tilemapSceneEditorMode != (Object)null)
			{
				tilemapSceneEditorMode.PICKHKINHAG(Season.Spring);
			}
			else
			{
				TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>();
				for (int i = 0; i < array.Length; i++)
				{
					array[i].PICKHKINHAG(Season.Summer);
				}
			}
		}
		if (CIPAKMCIFJI != null)
		{
			((MonoBehaviour)this).StopCoroutine(CIPAKMCIFJI);
		}
		JLIPMGJBNPB.Clear();
		pathRequest.EDLMEDOMBGN(((Component)startTransform).transform.position, ((Component)goalTransform).transform.position, null);
		CIPAKMCIFJI = ((MonoBehaviour)this).StartCoroutine(LOJKNPJKICO(Application.isPlaying ? true : false, pathRequest, GDHHIIMLBEL, pathRequestsInfo, stepsIncrement));
	}

	private void Update()
	{
		if (CIPAKMCIFJI == null && enableNextFinding)
		{
			showDebug = false;
			RequestPath();
			enableNextFinding = false;
		}
	}

	public void APKGFEPCPNN()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
			if ((Object)(object)tilemapSceneEditorMode != (Object)null)
			{
				tilemapSceneEditorMode.JFDJPELGMIN(Season.Spring);
			}
			else
			{
				TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>();
				for (int i = 1; i < array.Length; i++)
				{
					array[i].PICKHKINHAG(Season.Summer);
				}
			}
		}
		if (CIPAKMCIFJI != null)
		{
			((MonoBehaviour)this).StopCoroutine(CIPAKMCIFJI);
		}
		JLIPMGJBNPB.Clear();
		pathRequest.GFBEIBAIHFB(((Component)startTransform).transform.position, ((Component)goalTransform).transform.position, null);
		CIPAKMCIFJI = ((MonoBehaviour)this).StartCoroutine(Pathfinding(Application.isPlaying && false, pathRequest, GDHHIIMLBEL, pathRequestsInfo, stepsIncrement));
	}

	private static float NHONNDNOMFD(Vector3 DPEOLFMDLAK)
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
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1278f, 201f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1306f, 76f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(574f, 417f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1888f, 98f)))
		{
			return 1004f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(528f, 1206f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(643f, 998f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1578f, 1747f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(401f, 1355f)))
		{
			return 1455f;
		}
		return 282f;
	}

	public static float EKDKGOFIEBF(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * BBJDPIJPLPA.heuristicMultiplier;
	}

	public static float LMKMMGOACGO(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * BBJDPIJPLPA.heuristicMultiplier;
	}

	public static float FFKNEPJPKFB(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * BBJDPIJPLPA.heuristicMultiplier;
	}

	private void AGKPBDMEHKC()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		if (!showDebug || pathRequestsInfo.nodes == null)
		{
			return;
		}
		foreach (Vector3 node in pathRequestsInfo.nodes)
		{
			if (!GDHHIIMLBEL.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 1155f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 293f);
		}
		foreach (Vector2 item2 in GDHHIIMLBEL)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(item2), 1685f);
		}
	}

	public static float KKNIBIDNDOF(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * BBJDPIJPLPA.heuristicMultiplier;
	}

	public void OMEDBLOOJOO()
	{
		stepsCount += stepsIncrement;
	}

	public static float GPEMBJNDDLL(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * BBJDPIJPLPA.heuristicMultiplier;
	}

	public static IEnumerator FPCFKFJMBLC(bool KENEGPFEHHI, PathRequestInfo FBKNFALLPGB, List<Vector2> GDHHIIMLBEL, PathRequestParameters BBJDPIJPLPA, int EFFPELLBCPM = 0)
	{
		return new BHDPKGNKEJL(1)
		{
			instant = KENEGPFEHHI,
			currentPathRequest = FBKNFALLPGB,
			path = GDHHIIMLBEL,
			info = BBJDPIJPLPA,
			stepsIncrement = EFFPELLBCPM
		};
	}

	private void HBMBCANOPMH()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		if (!showDebug || pathRequestsInfo.nodes == null)
		{
			return;
		}
		foreach (Vector3 node in pathRequestsInfo.nodes)
		{
			if (!GDHHIIMLBEL.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 681f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 603f);
		}
		foreach (Vector2 item2 in GDHHIIMLBEL)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(item2), 1448f);
		}
	}

	private void OnDrawGizmosSelected()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		if (!showDebug || pathRequestsInfo.nodes == null)
		{
			return;
		}
		foreach (Vector3 node in pathRequestsInfo.nodes)
		{
			if (!GDHHIIMLBEL.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 0.1f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 0.1f);
		}
		foreach (Vector2 item2 in GDHHIIMLBEL)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(item2), 0.1f);
		}
	}

	public static List<Vector2> BJBKJPCPCFA(out bool NLGIGDFOGCM, List<Vector2> GDHHIIMLBEL, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		GDHHIIMLBEL.Clear();
		Vector3 val = Vector2.op_Implicit(MNLINFLOKHD);
		while (!((Vector3)(ref val)).Equals(MDMAAIKFBFB))
		{
			if (!BBJDPIJPLPA.cameFrom.ContainsKey(val))
			{
				NLGIGDFOGCM = true;
				Debug.Log((object)("Till" + true));
				return new List<Vector2>();
			}
			GDHHIIMLBEL.Add(Vector2.op_Implicit(val));
			val = BBJDPIJPLPA.cameFrom[val];
		}
		GDHHIIMLBEL.Reverse();
		NLGIGDFOGCM = true;
		return GDHHIIMLBEL;
	}

	private void FHKMEGJMLEG()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		if (!showDebug || pathRequestsInfo.nodes == null)
		{
			return;
		}
		foreach (Vector3 node in pathRequestsInfo.nodes)
		{
			if (!GDHHIIMLBEL.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 1248f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 1185f);
		}
		foreach (Vector2 item2 in GDHHIIMLBEL)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(item2), 728f);
		}
	}

	public void NextStep()
	{
		stepsCount += stepsIncrement;
	}

	private void OGBGFLMKFHH()
	{
		if (CIPAKMCIFJI == null && enableNextFinding)
		{
			showDebug = true;
			JJHMOBJAPLN();
			enableNextFinding = true;
		}
	}

	public void CLABJLMJKNE()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
			if ((Object)(object)tilemapSceneEditorMode != (Object)null)
			{
				tilemapSceneEditorMode.OKGEDBDIBFD(Season.Spring);
			}
			else
			{
				TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>();
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].OKGEDBDIBFD(Season.Summer);
				}
			}
		}
		if (CIPAKMCIFJI != null)
		{
			((MonoBehaviour)this).StopCoroutine(CIPAKMCIFJI);
		}
		JLIPMGJBNPB.Clear();
		pathRequest.LGHPDDMKBBH(((Component)startTransform).transform.position, ((Component)goalTransform).transform.position, null);
		CIPAKMCIFJI = ((MonoBehaviour)this).StartCoroutine(JCCMNLBHFHP(!Application.isPlaying, pathRequest, GDHHIIMLBEL, pathRequestsInfo, stepsIncrement));
	}

	public void JJHMOBJAPLN()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
			if ((Object)(object)tilemapSceneEditorMode != (Object)null)
			{
				tilemapSceneEditorMode.PICKHKINHAG(Season.Spring);
			}
			else
			{
				TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>();
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].KGLBEGCLJNB(Season.Summer);
				}
			}
		}
		if (CIPAKMCIFJI != null)
		{
			((MonoBehaviour)this).StopCoroutine(CIPAKMCIFJI);
		}
		JLIPMGJBNPB.Clear();
		pathRequest.FCEHMAHENON(((Component)startTransform).transform.position, ((Component)goalTransform).transform.position, null);
		CIPAKMCIFJI = ((MonoBehaviour)this).StartCoroutine(APGKNNPPLGM(Application.isPlaying ? true : false, pathRequest, GDHHIIMLBEL, pathRequestsInfo, stepsIncrement));
	}

	public static IEnumerator LOJKNPJKICO(bool KENEGPFEHHI, PathRequestInfo FBKNFALLPGB, List<Vector2> GDHHIIMLBEL, PathRequestParameters BBJDPIJPLPA, int EFFPELLBCPM = 0)
	{
		if (!KENEGPFEHHI)
		{
			Debug.Log((object)"Path Request Triggered!");
		}
		Location goalLocation = Utils.HJPCBBGHPDA(Vector2.op_Implicit(FBKNFALLPGB.goalPos));
		bool goalLocationStarted = false;
		BBJDPIJPLPA.cameFrom.Clear();
		Dictionary<Vector3, float> costSoFar = new Dictionary<Vector3, float>();
		int stepsCount = EFFPELLBCPM;
		BBJDPIJPLPA.diagonal = Mathf.Sqrt(BBJDPIJPLPA.recto * BBJDPIJPLPA.recto * 2f);
		bool done = false;
		MDMAAIKFBFB = FBKNFALLPGB.startPos;
		MNLINFLOKHD = Vector2.op_Implicit(FBKNFALLPGB.goalPos);
		BBJDPIJPLPA.cameFrom.Add(MDMAAIKFBFB, MDMAAIKFBFB);
		costSoFar.Add(MDMAAIKFBFB, 0f);
		Neighbour[] neighbours = ((!FBKNFALLPGB.canWalkDiagonal) ? new Neighbour[5] : new Neighbour[WorldGrid.allMovementNeighbours.Length + 1]);
		BBJDPIJPLPA.nodes = new List<Vector3>();
		HashSet<Vector2> closed = new HashSet<Vector2>();
		BBJDPIJPLPA.open.Clear();
		List<Vector2> openPositions = new List<Vector2>();
		GDHHIIMLBEL.Clear();
		AStarNode value = default(AStarNode);
		value.position = Vector2.op_Implicit(FBKNFALLPGB.startPos);
		value.EMOJEGDNKLG = 0f;
		value.MEFCBDDDMOG = 0f;
		BBJDPIJPLPA.open.Add(FBKNFALLPGB.startPos, value);
		openPositions.Add(Vector2.op_Implicit(FBKNFALLPGB.startPos));
		bool checkSize = ((((Vector2Int)(ref FBKNFALLPGB.horizontalSize)).x > 1 || ((Vector2Int)(ref FBKNFALLPGB.horizontalSize)).y > 1 || ((Vector2Int)(ref FBKNFALLPGB.verticalSize)).x > 1 || ((Vector2Int)(ref FBKNFALLPGB.verticalSize)).y > 1) ? true : false);
		bool tileNeeded = ((FBKNFALLPGB.takePath || FBKNFALLPGB.tryAvoidGroundType != 0 || FBKNFALLPGB.tryAvoidZones != 0) ? true : false);
		GameTileMaps.LoadPathNodes();
		Vector2[] horizontalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref FBKNFALLPGB.horizontalSize)).x * ((Vector2Int)(ref FBKNFALLPGB.horizontalSize)).y];
		Vector2[] verticalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref FBKNFALLPGB.verticalSize)).x * ((Vector2Int)(ref FBKNFALLPGB.verticalSize)).y];
		if (!KENEGPFEHHI)
		{
			Debug.Log((object)"Starting");
		}
		TravelZonesManager.GGFJGHHHEJC.allTravelZones = new Dictionary<Location, Dictionary<Location, TravelZone>>();
		TravelZone[] array = Object.FindObjectsOfType<TravelZone>();
		foreach (TravelZone pHGGMIMGFDK in array)
		{
			TravelZonesManager.GGFJGHHHEJC.AddToDictionary(pHGGMIMGFDK);
		}
		while (openPositions.Count > 0)
		{
			AStarNode aStarNode = BBJDPIJPLPA.open[Vector2.op_Implicit(openPositions[0])];
			int index = 0;
			for (int j = 1; j < BBJDPIJPLPA.open.Count; j++)
			{
				if (BBJDPIJPLPA.open[Vector2.op_Implicit(openPositions[j])].JJCAEAEOLIP < aStarNode.JJCAEAEOLIP || (BBJDPIJPLPA.open[Vector2.op_Implicit(openPositions[j])].JJCAEAEOLIP == aStarNode.JJCAEAEOLIP && BBJDPIJPLPA.open[Vector2.op_Implicit(openPositions[j])].MEFCBDDDMOG < aStarNode.MEFCBDDDMOG))
				{
					aStarNode = BBJDPIJPLPA.open[Vector2.op_Implicit(openPositions[j])];
					index = j;
				}
			}
			Vector2 position;
			if (!KENEGPFEHHI)
			{
				position = aStarNode.position;
				Debug.Log((object)("---> Chosen: " + ((object)(Vector2)(ref position)).ToString() + "/" + aStarNode.JJCAEAEOLIP));
			}
			BBJDPIJPLPA.open.Remove(Vector2.op_Implicit(openPositions[index]));
			openPositions.RemoveAt(index);
			closed.Add(aStarNode.position);
			BBJDPIJPLPA.nodes.Add(Vector2.op_Implicit(aStarNode.position));
			if (((Vector2)(ref aStarNode.position)).Equals(MNLINFLOKHD))
			{
				break;
			}
			WorldGrid.DLFFCGLGDLL(Vector2.op_Implicit(aStarNode.position), ref neighbours, FBKNFALLPGB.canWalkDiagonal);
			for (int k = 0; k < neighbours.Length; k++)
			{
				if (closed.Contains(neighbours[k].position))
				{
					continue;
				}
				if (neighbours[k].position == MNLINFLOKHD)
				{
					BBJDPIJPLPA.cameFrom.Add(Vector2.op_Implicit(neighbours[k].position), Vector2.op_Implicit(aStarNode.position));
					done = true;
					break;
				}
				if (!neighbours[k].free && (FBKNFALLPGB.currentNodes == null || !FBKNFALLPGB.currentNodes.Contains(neighbours[k].position)))
				{
					continue;
				}
				if (checkSize)
				{
					if (Utils.ABPDGOHBKIG(neighbours[k].direction))
					{
						WorldGrid.MDJDAKIMMJA(neighbours[k].position, FBKNFALLPGB.horizontalSize, ref horizontalNodes);
						if (!WorldGrid.NGDDILJAHEK(horizontalNodes, FBKNFALLPGB.currentNodes))
						{
							continue;
						}
					}
					else
					{
						WorldGrid.MDJDAKIMMJA(neighbours[k].position, FBKNFALLPGB.verticalSize, ref verticalNodes);
						if (!WorldGrid.NGDDILJAHEK(verticalNodes, FBKNFALLPGB.currentNodes))
						{
							continue;
						}
					}
				}
				else if (neighbours[k].direction == Direction.Diagonal)
				{
					switch (k)
					{
					case 4:
						if (!neighbours[0].free || !neighbours[3].free)
						{
							continue;
						}
						break;
					case 5:
						if (!neighbours[0].free || !neighbours[2].free)
						{
							continue;
						}
						break;
					case 6:
						if (!neighbours[1].free || !neighbours[3].free)
						{
							continue;
						}
						break;
					case 7:
						if (!neighbours[1].free || !neighbours[2].free)
						{
							continue;
						}
						break;
					}
				}
				float num = costSoFar[Vector2.op_Implicit(aStarNode.position)];
				if (tileNeeded)
				{
					WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(neighbours[k].position), out var ILDEFBIANKO);
					if (FBKNFALLPGB.takePath)
					{
						if (!ILDEFBIANKO.isPath || ILDEFBIANKO.isHorsePath)
						{
							num += BBJDPIJPLPA.pathPenalization;
						}
						else
						{
							WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(neighbours[k].position - new Vector2(0.25f, 0f)), out var ILDEFBIANKO2);
							if (!ILDEFBIANKO2.isPath || ILDEFBIANKO2.isHorsePath)
							{
								num += BBJDPIJPLPA.pathPenalization;
							}
							else
							{
								WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(neighbours[k].position - new Vector2(0f, 0.25f)), out ILDEFBIANKO2);
								if (!ILDEFBIANKO2.isPath || ILDEFBIANKO2.isHorsePath)
								{
									num += BBJDPIJPLPA.pathPenalization;
								}
							}
						}
					}
					if (FBKNFALLPGB.tryAvoidGroundType != 0)
					{
						if (FBKNFALLPGB.tryAvoidGroundType.HasFlag(ILDEFBIANKO.groundType))
						{
							num = ((neighbours[k].direction != Direction.Diagonal) ? (num + BBJDPIJPLPA.penalizaciones) : (num + BBJDPIJPLPA.penalizaciones * (BBJDPIJPLPA.diagonal / BBJDPIJPLPA.recto)));
						}
						else if (FBKNFALLPGB.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(neighbours[k].position + new Vector2(-0.25f, 0f)))))
						{
							num += BBJDPIJPLPA.penalizaciones;
						}
						else if (FBKNFALLPGB.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(neighbours[k].position + new Vector2(0f, -0.25f)))))
						{
							num += BBJDPIJPLPA.penalizaciones;
						}
					}
					if (FBKNFALLPGB.tryAvoidZones != 0)
					{
						if (FBKNFALLPGB.tryAvoidZones.HasFlag(ILDEFBIANKO.zoneType))
						{
							num += BBJDPIJPLPA.penalizaciones * 2f;
						}
						else if (FBKNFALLPGB.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(neighbours[k].position + new Vector2(-0.25f, 0f)))))
						{
							num += BBJDPIJPLPA.penalizaciones * 2f;
						}
						else if (FBKNFALLPGB.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(neighbours[k].position + new Vector2(0f, -0.25f)))))
						{
							num += BBJDPIJPLPA.penalizaciones * 2f;
						}
					}
				}
				if (Utils.EJPFCKFEMJF(Vector2.op_Implicit(neighbours[k].position)))
				{
					num += DFKMPMMLGNL(Vector2.op_Implicit(neighbours[k].position));
				}
				num = ((neighbours[k].direction != Direction.Diagonal) ? (num + BBJDPIJPLPA.recto * neighbours[k].cost) : (num + BBJDPIJPLPA.diagonal * neighbours[k].cost));
				if (costSoFar.ContainsKey(Vector2.op_Implicit(neighbours[k].position)) && !(num < costSoFar[Vector2.op_Implicit(neighbours[k].position)]))
				{
					continue;
				}
				Vector3 oDNGJHPOMMK;
				if (goalLocationStarted)
				{
					if (Utils.HJPCBBGHPDA(neighbours[k].position) != goalLocation)
					{
						continue;
					}
					oDNGJHPOMMK = Vector2.op_Implicit(MNLINFLOKHD);
				}
				else if (Utils.HJPCBBGHPDA(neighbours[k].position) == goalLocation)
				{
					oDNGJHPOMMK = Vector2.op_Implicit(MNLINFLOKHD);
					BBJDPIJPLPA.open.Clear();
					openPositions.Clear();
					goalLocationStarted = true;
				}
				else if (Object.op_Implicit((Object)(object)TravelZonesManager.GGFJGHHHEJC) && (Object)(object)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Utils.HJPCBBGHPDA(neighbours[k].position), goalLocation) != (Object)null)
				{
					Vector3 centrePosition = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Utils.HJPCBBGHPDA(neighbours[k].position), goalLocation).GetCentrePosition();
					Debug.Log((object)("GetTravelZone " + ((object)(Vector3)(ref centrePosition)).ToString()));
					oDNGJHPOMMK = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Utils.HJPCBBGHPDA(neighbours[k].position), goalLocation).GetCentrePosition();
				}
				else
				{
					oDNGJHPOMMK = Vector2.op_Implicit(MNLINFLOKHD);
				}
				value = default(AStarNode);
				value.position = neighbours[k].position;
				value.EMOJEGDNKLG = num;
				value.MEFCBDDDMOG = Heuristic(Vector2.op_Implicit(neighbours[k].position), oDNGJHPOMMK, BBJDPIJPLPA);
				if (costSoFar.ContainsKey(Vector2.op_Implicit(neighbours[k].position)))
				{
					costSoFar[Vector2.op_Implicit(neighbours[k].position)] = num;
					BBJDPIJPLPA.cameFrom[Vector2.op_Implicit(neighbours[k].position)] = Vector2.op_Implicit(aStarNode.position);
					BBJDPIJPLPA.open[Vector2.op_Implicit(neighbours[k].position)] = value;
				}
				else
				{
					costSoFar.Add(Vector2.op_Implicit(neighbours[k].position), num);
					BBJDPIJPLPA.cameFrom.Add(Vector2.op_Implicit(neighbours[k].position), Vector2.op_Implicit(aStarNode.position));
					BBJDPIJPLPA.open.Add(Vector2.op_Implicit(neighbours[k].position), value);
					openPositions.Add(neighbours[k].position);
				}
				if (!KENEGPFEHHI)
				{
					string[] obj = new string[8] { "*", null, null, null, null, null, null, null };
					position = value.position;
					obj[1] = ((object)(Vector2)(ref position)).ToString();
					obj[2] = " / H: ";
					obj[3] = value.MEFCBDDDMOG.ToString();
					obj[4] = " / G: ";
					obj[5] = value.EMOJEGDNKLG.ToString();
					obj[6] = " / F: ";
					obj[7] = value.JJCAEAEOLIP.ToString();
					Debug.Log((object)string.Concat(obj));
				}
			}
			if (done)
			{
				break;
			}
			if (!KENEGPFEHHI)
			{
				stepsCount--;
				while (stepsCount <= 0)
				{
					yield return null;
				}
			}
		}
		FindPath(out done, GDHHIIMLBEL, BBJDPIJPLPA);
		if (!KENEGPFEHHI)
		{
			yield return CommonReferences.wait5;
		}
		CIPAKMCIFJI = null;
	}

	public static float HGJEMLCCEDF(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * BBJDPIJPLPA.heuristicMultiplier;
	}

	private void EBFJOAEJPGE()
	{
		if (CIPAKMCIFJI == null && enableNextFinding)
		{
			showDebug = true;
			RequestPath();
			enableNextFinding = false;
		}
	}

	public static List<Vector2> BBMMGMOAPIF(out bool NLGIGDFOGCM, List<Vector2> GDHHIIMLBEL, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		GDHHIIMLBEL.Clear();
		Vector3 val = Vector2.op_Implicit(MNLINFLOKHD);
		while (!((Vector3)(ref val)).Equals(MDMAAIKFBFB))
		{
			if (!BBJDPIJPLPA.cameFrom.ContainsKey(val))
			{
				NLGIGDFOGCM = false;
				Debug.Log((object)("Tutorial/T112/Dialogue2" + false));
				return new List<Vector2>();
			}
			GDHHIIMLBEL.Add(Vector2.op_Implicit(val));
			val = BBJDPIJPLPA.cameFrom[val];
		}
		GDHHIIMLBEL.Reverse();
		NLGIGDFOGCM = false;
		return GDHHIIMLBEL;
	}

	private void IIOHMDNGFDH()
	{
		if (CIPAKMCIFJI == null && enableNextFinding)
		{
			showDebug = true;
			FEDMNPGKMDB();
			enableNextFinding = true;
		}
	}

	private static float OEMHGIANGKJ(Vector3 DPEOLFMDLAK)
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
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(698f, 752f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(84f, 343f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(225f, 199f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(816f, 1513f)))
		{
			return 1970f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(37f, 167f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1647f, 1066f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(218f, 1032f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(701f, 1016f)))
		{
			return 1270f;
		}
		return 985f;
	}

	private void HCCJAGPPEBB()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		if (!showDebug || pathRequestsInfo.nodes == null)
		{
			return;
		}
		foreach (Vector3 node in pathRequestsInfo.nodes)
		{
			if (!GDHHIIMLBEL.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 755f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 311f);
		}
		foreach (Vector2 item2 in GDHHIIMLBEL)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(item2), 1734f);
		}
	}

	private static float DFKMPMMLGNL(Vector3 DPEOLFMDLAK)
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
			return 0.25f;
		}
		return 0f;
	}

	private void CKEHLJPEJMI()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		if (!showDebug || pathRequestsInfo.nodes == null)
		{
			return;
		}
		foreach (Vector3 node in pathRequestsInfo.nodes)
		{
			if (!GDHHIIMLBEL.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 1335f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 352f);
		}
		foreach (Vector2 item2 in GDHHIIMLBEL)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(item2), 894f);
		}
	}

	public void RequestPath()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
			if ((Object)(object)tilemapSceneEditorMode != (Object)null)
			{
				tilemapSceneEditorMode.CreateWorldTiles(Season.Spring);
			}
			else
			{
				TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>();
				for (int i = 0; i < array.Length; i++)
				{
					array[i].CreateWorldTiles(Season.Spring);
				}
			}
		}
		if (CIPAKMCIFJI != null)
		{
			((MonoBehaviour)this).StopCoroutine(CIPAKMCIFJI);
		}
		JLIPMGJBNPB.Clear();
		pathRequest.PMBNLIOPNOH(((Component)startTransform).transform.position, ((Component)goalTransform).transform.position, null);
		CIPAKMCIFJI = ((MonoBehaviour)this).StartCoroutine(Pathfinding(!Application.isPlaying, pathRequest, GDHHIIMLBEL, pathRequestsInfo, stepsIncrement));
	}

	private void MGMLDHPOLGK()
	{
		if (CIPAKMCIFJI == null && enableNextFinding)
		{
			showDebug = true;
			CLABJLMJKNE();
			enableNextFinding = true;
		}
	}

	private void HIMCLGHLMGC()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		if (!showDebug || pathRequestsInfo.nodes == null)
		{
			return;
		}
		foreach (Vector3 node in pathRequestsInfo.nodes)
		{
			if (!GDHHIIMLBEL.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 1855f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 199f);
		}
		foreach (Vector2 item2 in GDHHIIMLBEL)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(item2), 424f);
		}
	}

	public void MKFFAGKPOGD()
	{
		stepsCount += stepsIncrement;
	}

	public static float OMAKGLJCPEI(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * BBJDPIJPLPA.heuristicMultiplier;
	}

	public void KOJLJLADEMH()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
			if ((Object)(object)tilemapSceneEditorMode != (Object)null)
			{
				tilemapSceneEditorMode.CreateWorldTiles(Season.Spring);
			}
			else
			{
				TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>();
				for (int i = 1; i < array.Length; i++)
				{
					array[i].PICKHKINHAG(Season.Summer);
				}
			}
		}
		if (CIPAKMCIFJI != null)
		{
			((MonoBehaviour)this).StopCoroutine(CIPAKMCIFJI);
		}
		JLIPMGJBNPB.Clear();
		pathRequest.PHKMJGBDAJK(((Component)startTransform).transform.position, ((Component)goalTransform).transform.position, null);
		CIPAKMCIFJI = ((MonoBehaviour)this).StartCoroutine(LOJKNPJKICO(Application.isPlaying ? true : false, pathRequest, GDHHIIMLBEL, pathRequestsInfo, stepsIncrement));
	}

	private void BHKNJOEBCKA()
	{
		if (CIPAKMCIFJI == null && enableNextFinding)
		{
			showDebug = false;
			CCJFGDNGINI();
			enableNextFinding = true;
		}
	}

	public void NGBONJFHLHC()
	{
		stepsCount += stepsIncrement;
	}

	public void DOIBMLKCAHG()
	{
		stepsCount += stepsIncrement;
	}

	public void DOONMDCDGBO()
	{
		stepsCount += stepsIncrement;
	}

	public void GGEFNCNJDJN()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
			if ((Object)(object)tilemapSceneEditorMode != (Object)null)
			{
				tilemapSceneEditorMode.KGLBEGCLJNB(Season.Spring);
			}
			else
			{
				TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>();
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].CreateWorldTiles(Season.Summer);
				}
			}
		}
		if (CIPAKMCIFJI != null)
		{
			((MonoBehaviour)this).StopCoroutine(CIPAKMCIFJI);
		}
		JLIPMGJBNPB.Clear();
		pathRequest.LGHPDDMKBBH(((Component)startTransform).transform.position, ((Component)goalTransform).transform.position, null);
		CIPAKMCIFJI = ((MonoBehaviour)this).StartCoroutine(APGKNNPPLGM(Application.isPlaying ? true : false, pathRequest, GDHHIIMLBEL, pathRequestsInfo, stepsIncrement));
	}

	public static float Heuristic(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * BBJDPIJPLPA.heuristicMultiplier;
	}

	public void BADBBAKKILH()
	{
		stepsCount += stepsIncrement;
	}

	public void AAHNNEOGOCP()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
			if ((Object)(object)tilemapSceneEditorMode != (Object)null)
			{
				tilemapSceneEditorMode.KGLBEGCLJNB(Season.Summer);
			}
			else
			{
				TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>();
				for (int i = 1; i < array.Length; i++)
				{
					array[i].PICKHKINHAG(Season.Summer);
				}
			}
		}
		if (CIPAKMCIFJI != null)
		{
			((MonoBehaviour)this).StopCoroutine(CIPAKMCIFJI);
		}
		JLIPMGJBNPB.Clear();
		pathRequest.BCHGBCDNBCO(((Component)startTransform).transform.position, ((Component)goalTransform).transform.position, null);
		CIPAKMCIFJI = ((MonoBehaviour)this).StartCoroutine(LOJKNPJKICO(Application.isPlaying && false, pathRequest, GDHHIIMLBEL, pathRequestsInfo, stepsIncrement));
	}

	private static float NLBECIONEKD(Vector3 DPEOLFMDLAK)
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
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(626f, 377f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1504f, 380f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(199f, 420f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(377f, 1982f)))
		{
			return 822f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1478f, 1134f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1866f, 1164f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1226f, 1232f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1693f, 341f)))
		{
			return 85f;
		}
		return 110f;
	}

	public void ANENAGDMBGC()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
			if ((Object)(object)tilemapSceneEditorMode != (Object)null)
			{
				tilemapSceneEditorMode.OKGEDBDIBFD(Season.Summer);
			}
			else
			{
				TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>();
				for (int i = 1; i < array.Length; i++)
				{
					array[i].KGLBEGCLJNB(Season.Summer);
				}
			}
		}
		if (CIPAKMCIFJI != null)
		{
			((MonoBehaviour)this).StopCoroutine(CIPAKMCIFJI);
		}
		JLIPMGJBNPB.Clear();
		pathRequest.IGAACLANDNP(((Component)startTransform).transform.position, ((Component)goalTransform).transform.position, null);
		CIPAKMCIFJI = ((MonoBehaviour)this).StartCoroutine(LOJKNPJKICO(Application.isPlaying || true, pathRequest, GDHHIIMLBEL, pathRequestsInfo, stepsIncrement));
	}

	public void CCJFGDNGINI()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
			if ((Object)(object)tilemapSceneEditorMode != (Object)null)
			{
				tilemapSceneEditorMode.OKGEDBDIBFD(Season.Summer);
			}
			else
			{
				TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>();
				for (int i = 0; i < array.Length; i++)
				{
					array[i].JFDJPELGMIN(Season.Spring);
				}
			}
		}
		if (CIPAKMCIFJI != null)
		{
			((MonoBehaviour)this).StopCoroutine(CIPAKMCIFJI);
		}
		JLIPMGJBNPB.Clear();
		pathRequest.BJECLKFCJLB(((Component)startTransform).transform.position, ((Component)goalTransform).transform.position, null);
		CIPAKMCIFJI = ((MonoBehaviour)this).StartCoroutine(LOJKNPJKICO(Application.isPlaying || true, pathRequest, GDHHIIMLBEL, pathRequestsInfo, stepsIncrement));
	}

	public static float JONNCMHAILI(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * BBJDPIJPLPA.heuristicMultiplier;
	}

	public static float DOBCIAONNDO(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * BBJDPIJPLPA.heuristicMultiplier;
	}

	private static float NODPKEDNBGB(Vector3 DPEOLFMDLAK)
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
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(693f, 1050f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1889f, 278f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1022f, 1308f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1321f, 124f)))
		{
			return 886f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(422f, 1033f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(100f, 1857f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(594f, 1877f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(417f, 1220f)))
		{
			return 1692f;
		}
		return 1526f;
	}

	private static float IGIAEECCPAF(Vector3 DPEOLFMDLAK)
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
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(883f, 1129f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1177f, 1890f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(804f, 1263f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1346f, 1921f)))
		{
			return 723f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1131f, 191f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(49f, 612f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(654f, 1157f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1809f, 393f)))
		{
			return 1013f;
		}
		return 1696f;
	}

	private static float MCABGKKMNGC(Vector3 DPEOLFMDLAK)
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
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1896f, 454f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(912f, 527f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1311f, 621f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(806f, 137f)))
		{
			return 1653f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1628f, 1035f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(497f, 1788f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1530f, 1272f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1234f, 521f)))
		{
			return 1602f;
		}
		return 1667f;
	}

	public static IEnumerator JCHKAJBIBPG(bool KENEGPFEHHI, PathRequestInfo FBKNFALLPGB, List<Vector2> GDHHIIMLBEL, PathRequestParameters BBJDPIJPLPA, int EFFPELLBCPM = 0)
	{
		return new BHDPKGNKEJL(1)
		{
			instant = KENEGPFEHHI,
			currentPathRequest = FBKNFALLPGB,
			path = GDHHIIMLBEL,
			info = BBJDPIJPLPA,
			stepsIncrement = EFFPELLBCPM
		};
	}

	public static IEnumerator Pathfinding(bool KENEGPFEHHI, PathRequestInfo FBKNFALLPGB, List<Vector2> GDHHIIMLBEL, PathRequestParameters BBJDPIJPLPA, int EFFPELLBCPM = 0)
	{
		if (!KENEGPFEHHI)
		{
			Debug.Log((object)"Path Request Triggered!");
		}
		Location goalLocation = Utils.HJPCBBGHPDA(Vector2.op_Implicit(FBKNFALLPGB.goalPos));
		bool goalLocationStarted = false;
		BBJDPIJPLPA.cameFrom.Clear();
		Dictionary<Vector3, float> costSoFar = new Dictionary<Vector3, float>();
		int stepsCount = EFFPELLBCPM;
		BBJDPIJPLPA.diagonal = Mathf.Sqrt(BBJDPIJPLPA.recto * BBJDPIJPLPA.recto * 2f);
		bool done = false;
		MDMAAIKFBFB = FBKNFALLPGB.startPos;
		MNLINFLOKHD = Vector2.op_Implicit(FBKNFALLPGB.goalPos);
		BBJDPIJPLPA.cameFrom.Add(MDMAAIKFBFB, MDMAAIKFBFB);
		costSoFar.Add(MDMAAIKFBFB, 0f);
		Neighbour[] neighbours = ((!FBKNFALLPGB.canWalkDiagonal) ? new Neighbour[5] : new Neighbour[WorldGrid.allMovementNeighbours.Length + 1]);
		BBJDPIJPLPA.nodes = new List<Vector3>();
		HashSet<Vector2> closed = new HashSet<Vector2>();
		BBJDPIJPLPA.open.Clear();
		List<Vector2> openPositions = new List<Vector2>();
		GDHHIIMLBEL.Clear();
		AStarNode value = default(AStarNode);
		value.position = Vector2.op_Implicit(FBKNFALLPGB.startPos);
		value.EMOJEGDNKLG = 0f;
		value.MEFCBDDDMOG = 0f;
		BBJDPIJPLPA.open.Add(FBKNFALLPGB.startPos, value);
		openPositions.Add(Vector2.op_Implicit(FBKNFALLPGB.startPos));
		bool checkSize = ((((Vector2Int)(ref FBKNFALLPGB.horizontalSize)).x > 1 || ((Vector2Int)(ref FBKNFALLPGB.horizontalSize)).y > 1 || ((Vector2Int)(ref FBKNFALLPGB.verticalSize)).x > 1 || ((Vector2Int)(ref FBKNFALLPGB.verticalSize)).y > 1) ? true : false);
		bool tileNeeded = ((FBKNFALLPGB.takePath || FBKNFALLPGB.tryAvoidGroundType != 0 || FBKNFALLPGB.tryAvoidZones != 0) ? true : false);
		GameTileMaps.LoadPathNodes();
		Vector2[] horizontalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref FBKNFALLPGB.horizontalSize)).x * ((Vector2Int)(ref FBKNFALLPGB.horizontalSize)).y];
		Vector2[] verticalNodes = (Vector2[])(object)new Vector2[((Vector2Int)(ref FBKNFALLPGB.verticalSize)).x * ((Vector2Int)(ref FBKNFALLPGB.verticalSize)).y];
		if (!KENEGPFEHHI)
		{
			Debug.Log((object)"Starting");
		}
		TravelZonesManager.GGFJGHHHEJC.allTravelZones = new Dictionary<Location, Dictionary<Location, TravelZone>>();
		TravelZone[] array = Object.FindObjectsOfType<TravelZone>();
		foreach (TravelZone pHGGMIMGFDK in array)
		{
			TravelZonesManager.GGFJGHHHEJC.AddToDictionary(pHGGMIMGFDK);
		}
		while (openPositions.Count > 0)
		{
			AStarNode aStarNode = BBJDPIJPLPA.open[Vector2.op_Implicit(openPositions[0])];
			int index = 0;
			for (int j = 1; j < BBJDPIJPLPA.open.Count; j++)
			{
				if (BBJDPIJPLPA.open[Vector2.op_Implicit(openPositions[j])].JJCAEAEOLIP < aStarNode.JJCAEAEOLIP || (BBJDPIJPLPA.open[Vector2.op_Implicit(openPositions[j])].JJCAEAEOLIP == aStarNode.JJCAEAEOLIP && BBJDPIJPLPA.open[Vector2.op_Implicit(openPositions[j])].MEFCBDDDMOG < aStarNode.MEFCBDDDMOG))
				{
					aStarNode = BBJDPIJPLPA.open[Vector2.op_Implicit(openPositions[j])];
					index = j;
				}
			}
			Vector2 position;
			if (!KENEGPFEHHI)
			{
				position = aStarNode.position;
				Debug.Log((object)("---> Chosen: " + ((object)(Vector2)(ref position)).ToString() + "/" + aStarNode.JJCAEAEOLIP));
			}
			BBJDPIJPLPA.open.Remove(Vector2.op_Implicit(openPositions[index]));
			openPositions.RemoveAt(index);
			closed.Add(aStarNode.position);
			BBJDPIJPLPA.nodes.Add(Vector2.op_Implicit(aStarNode.position));
			if (((Vector2)(ref aStarNode.position)).Equals(MNLINFLOKHD))
			{
				break;
			}
			WorldGrid.DLFFCGLGDLL(Vector2.op_Implicit(aStarNode.position), ref neighbours, FBKNFALLPGB.canWalkDiagonal);
			for (int k = 0; k < neighbours.Length; k++)
			{
				if (closed.Contains(neighbours[k].position))
				{
					continue;
				}
				if (neighbours[k].position == MNLINFLOKHD)
				{
					BBJDPIJPLPA.cameFrom.Add(Vector2.op_Implicit(neighbours[k].position), Vector2.op_Implicit(aStarNode.position));
					done = true;
					break;
				}
				if (!neighbours[k].free && (FBKNFALLPGB.currentNodes == null || !FBKNFALLPGB.currentNodes.Contains(neighbours[k].position)))
				{
					continue;
				}
				if (checkSize)
				{
					if (Utils.ABPDGOHBKIG(neighbours[k].direction))
					{
						WorldGrid.MDJDAKIMMJA(neighbours[k].position, FBKNFALLPGB.horizontalSize, ref horizontalNodes);
						if (!WorldGrid.NGDDILJAHEK(horizontalNodes, FBKNFALLPGB.currentNodes))
						{
							continue;
						}
					}
					else
					{
						WorldGrid.MDJDAKIMMJA(neighbours[k].position, FBKNFALLPGB.verticalSize, ref verticalNodes);
						if (!WorldGrid.NGDDILJAHEK(verticalNodes, FBKNFALLPGB.currentNodes))
						{
							continue;
						}
					}
				}
				else if (neighbours[k].direction == Direction.Diagonal)
				{
					switch (k)
					{
					case 4:
						if (!neighbours[0].free || !neighbours[3].free)
						{
							continue;
						}
						break;
					case 5:
						if (!neighbours[0].free || !neighbours[2].free)
						{
							continue;
						}
						break;
					case 6:
						if (!neighbours[1].free || !neighbours[3].free)
						{
							continue;
						}
						break;
					case 7:
						if (!neighbours[1].free || !neighbours[2].free)
						{
							continue;
						}
						break;
					}
				}
				float num = costSoFar[Vector2.op_Implicit(aStarNode.position)];
				if (tileNeeded)
				{
					WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(neighbours[k].position), out var ILDEFBIANKO);
					if (FBKNFALLPGB.takePath)
					{
						if (!ILDEFBIANKO.isPath || ILDEFBIANKO.isHorsePath)
						{
							num += BBJDPIJPLPA.pathPenalization;
						}
						else
						{
							WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(neighbours[k].position - new Vector2(0.25f, 0f)), out var ILDEFBIANKO2);
							if (!ILDEFBIANKO2.isPath || ILDEFBIANKO2.isHorsePath)
							{
								num += BBJDPIJPLPA.pathPenalization;
							}
							else
							{
								WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(neighbours[k].position - new Vector2(0f, 0.25f)), out ILDEFBIANKO2);
								if (!ILDEFBIANKO2.isPath || ILDEFBIANKO2.isHorsePath)
								{
									num += BBJDPIJPLPA.pathPenalization;
								}
							}
						}
					}
					if (FBKNFALLPGB.tryAvoidGroundType != 0)
					{
						if (FBKNFALLPGB.tryAvoidGroundType.HasFlag(ILDEFBIANKO.groundType))
						{
							num = ((neighbours[k].direction != Direction.Diagonal) ? (num + BBJDPIJPLPA.penalizaciones) : (num + BBJDPIJPLPA.penalizaciones * (BBJDPIJPLPA.diagonal / BBJDPIJPLPA.recto)));
						}
						else if (FBKNFALLPGB.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(neighbours[k].position + new Vector2(-0.25f, 0f)))))
						{
							num += BBJDPIJPLPA.penalizaciones;
						}
						else if (FBKNFALLPGB.tryAvoidGroundType.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(neighbours[k].position + new Vector2(0f, -0.25f)))))
						{
							num += BBJDPIJPLPA.penalizaciones;
						}
					}
					if (FBKNFALLPGB.tryAvoidZones != 0)
					{
						if (FBKNFALLPGB.tryAvoidZones.HasFlag(ILDEFBIANKO.zoneType))
						{
							num += BBJDPIJPLPA.penalizaciones * 2f;
						}
						else if (FBKNFALLPGB.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(neighbours[k].position + new Vector2(-0.25f, 0f)))))
						{
							num += BBJDPIJPLPA.penalizaciones * 2f;
						}
						else if (FBKNFALLPGB.tryAvoidZones.HasFlag(WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(neighbours[k].position + new Vector2(0f, -0.25f)))))
						{
							num += BBJDPIJPLPA.penalizaciones * 2f;
						}
					}
				}
				if (Utils.EJPFCKFEMJF(Vector2.op_Implicit(neighbours[k].position)))
				{
					num += DFKMPMMLGNL(Vector2.op_Implicit(neighbours[k].position));
				}
				num = ((neighbours[k].direction != Direction.Diagonal) ? (num + BBJDPIJPLPA.recto * neighbours[k].cost) : (num + BBJDPIJPLPA.diagonal * neighbours[k].cost));
				if (costSoFar.ContainsKey(Vector2.op_Implicit(neighbours[k].position)) && !(num < costSoFar[Vector2.op_Implicit(neighbours[k].position)]))
				{
					continue;
				}
				Vector3 oDNGJHPOMMK;
				if (goalLocationStarted)
				{
					if (Utils.HJPCBBGHPDA(neighbours[k].position) != goalLocation)
					{
						continue;
					}
					oDNGJHPOMMK = Vector2.op_Implicit(MNLINFLOKHD);
				}
				else if (Utils.HJPCBBGHPDA(neighbours[k].position) == goalLocation)
				{
					oDNGJHPOMMK = Vector2.op_Implicit(MNLINFLOKHD);
					BBJDPIJPLPA.open.Clear();
					openPositions.Clear();
					goalLocationStarted = true;
				}
				else if (Object.op_Implicit((Object)(object)TravelZonesManager.GGFJGHHHEJC) && (Object)(object)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Utils.HJPCBBGHPDA(neighbours[k].position), goalLocation) != (Object)null)
				{
					Vector3 centrePosition = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Utils.HJPCBBGHPDA(neighbours[k].position), goalLocation).GetCentrePosition();
					Debug.Log((object)("GetTravelZone " + ((object)(Vector3)(ref centrePosition)).ToString()));
					oDNGJHPOMMK = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Utils.HJPCBBGHPDA(neighbours[k].position), goalLocation).GetCentrePosition();
				}
				else
				{
					oDNGJHPOMMK = Vector2.op_Implicit(MNLINFLOKHD);
				}
				value = default(AStarNode);
				value.position = neighbours[k].position;
				value.EMOJEGDNKLG = num;
				value.MEFCBDDDMOG = Heuristic(Vector2.op_Implicit(neighbours[k].position), oDNGJHPOMMK, BBJDPIJPLPA);
				if (costSoFar.ContainsKey(Vector2.op_Implicit(neighbours[k].position)))
				{
					costSoFar[Vector2.op_Implicit(neighbours[k].position)] = num;
					BBJDPIJPLPA.cameFrom[Vector2.op_Implicit(neighbours[k].position)] = Vector2.op_Implicit(aStarNode.position);
					BBJDPIJPLPA.open[Vector2.op_Implicit(neighbours[k].position)] = value;
				}
				else
				{
					costSoFar.Add(Vector2.op_Implicit(neighbours[k].position), num);
					BBJDPIJPLPA.cameFrom.Add(Vector2.op_Implicit(neighbours[k].position), Vector2.op_Implicit(aStarNode.position));
					BBJDPIJPLPA.open.Add(Vector2.op_Implicit(neighbours[k].position), value);
					openPositions.Add(neighbours[k].position);
				}
				if (!KENEGPFEHHI)
				{
					string[] obj = new string[8] { "*", null, null, null, null, null, null, null };
					position = value.position;
					obj[1] = ((object)(Vector2)(ref position)).ToString();
					obj[2] = " / H: ";
					obj[3] = value.MEFCBDDDMOG.ToString();
					obj[4] = " / G: ";
					obj[5] = value.EMOJEGDNKLG.ToString();
					obj[6] = " / F: ";
					obj[7] = value.JJCAEAEOLIP.ToString();
					Debug.Log((object)string.Concat(obj));
				}
			}
			if (done)
			{
				break;
			}
			if (!KENEGPFEHHI)
			{
				stepsCount--;
				while (stepsCount <= 0)
				{
					yield return null;
				}
			}
		}
		FindPath(out done, GDHHIIMLBEL, BBJDPIJPLPA);
		if (!KENEGPFEHHI)
		{
			yield return CommonReferences.wait5;
		}
		CIPAKMCIFJI = null;
	}

	private static float ENDIBHINLIL(Vector3 DPEOLFMDLAK)
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
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(579f, 851f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(924f, 755f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(288f, 1268f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1101f, 400f)))
		{
			return 781f;
		}
		if (!WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1485f, 1566f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1221f, 604f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1784f, 1777f)) || !WorldGrid.DJLHADMPGBK(DPEOLFMDLAK + new Vector3(1330f, 282f)))
		{
			return 1975f;
		}
		return 562f;
	}

	public void HPLNMHLBKAI()
	{
		stepsCount += stepsIncrement;
	}

	public void IFAMNEIBOGA()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
			if ((Object)(object)tilemapSceneEditorMode != (Object)null)
			{
				tilemapSceneEditorMode.JFDJPELGMIN(Season.Spring);
			}
			else
			{
				TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>();
				for (int i = 0; i < array.Length; i++)
				{
					array[i].OKGEDBDIBFD(Season.Summer);
				}
			}
		}
		if (CIPAKMCIFJI != null)
		{
			((MonoBehaviour)this).StopCoroutine(CIPAKMCIFJI);
		}
		JLIPMGJBNPB.Clear();
		pathRequest.JDIBPLLLIIC(((Component)startTransform).transform.position, ((Component)goalTransform).transform.position, null);
		CIPAKMCIFJI = ((MonoBehaviour)this).StartCoroutine(FPCFKFJMBLC(!Application.isPlaying, pathRequest, GDHHIIMLBEL, pathRequestsInfo, stepsIncrement));
	}

	public static float DNNGIPCAKHC(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * BBJDPIJPLPA.heuristicMultiplier;
	}

	private void OOGMGIPKMAP()
	{
		if (CIPAKMCIFJI == null && enableNextFinding)
		{
			showDebug = true;
			IFAMNEIBOGA();
			enableNextFinding = true;
		}
	}

	public void JMGBCPCCPJE()
	{
		stepsCount += stepsIncrement;
	}

	public void ACBJMFKLLBG()
	{
		stepsCount += stepsIncrement;
	}

	public static float LJOCKMEHGOL(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y)) * BBJDPIJPLPA.heuristicMultiplier;
	}

	public void LKHKEHDNMDP()
	{
		stepsCount += stepsIncrement;
	}

	public void EMNIIMGIMFA()
	{
		stepsCount += stepsIncrement;
	}

	public static List<Vector2> IIMGAMNOFOK(out bool NLGIGDFOGCM, List<Vector2> GDHHIIMLBEL, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		GDHHIIMLBEL.Clear();
		Vector3 val = Vector2.op_Implicit(MNLINFLOKHD);
		while (!((Vector3)(ref val)).Equals(MDMAAIKFBFB))
		{
			if (!BBJDPIJPLPA.cameFrom.ContainsKey(val))
			{
				NLGIGDFOGCM = false;
				Debug.Log((object)("BrockProgress" + true));
				return new List<Vector2>();
			}
			GDHHIIMLBEL.Add(Vector2.op_Implicit(val));
			val = BBJDPIJPLPA.cameFrom[val];
		}
		GDHHIIMLBEL.Reverse();
		NLGIGDFOGCM = false;
		return GDHHIIMLBEL;
	}

	public static IEnumerator APGKNNPPLGM(bool KENEGPFEHHI, PathRequestInfo FBKNFALLPGB, List<Vector2> GDHHIIMLBEL, PathRequestParameters BBJDPIJPLPA, int EFFPELLBCPM = 0)
	{
		return new BHDPKGNKEJL(1)
		{
			instant = KENEGPFEHHI,
			currentPathRequest = FBKNFALLPGB,
			path = GDHHIIMLBEL,
			info = BBJDPIJPLPA,
			stepsIncrement = EFFPELLBCPM
		};
	}

	public static List<Vector2> HPIHFAHJDNN(out bool NLGIGDFOGCM, List<Vector2> GDHHIIMLBEL, PathRequestParameters BBJDPIJPLPA)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		GDHHIIMLBEL.Clear();
		Vector3 val = Vector2.op_Implicit(MNLINFLOKHD);
		while (!((Vector3)(ref val)).Equals(MDMAAIKFBFB))
		{
			if (!BBJDPIJPLPA.cameFrom.ContainsKey(val))
			{
				NLGIGDFOGCM = true;
				Debug.Log((object)("itemRawChicken" + true));
				return new List<Vector2>();
			}
			GDHHIIMLBEL.Add(Vector2.op_Implicit(val));
			val = BBJDPIJPLPA.cameFrom[val];
		}
		GDHHIIMLBEL.Reverse();
		NLGIGDFOGCM = true;
		return GDHHIIMLBEL;
	}
}
