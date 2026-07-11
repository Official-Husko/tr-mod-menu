using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Tilemaps Info")]
public class TilemapsInfo : SerializedScriptableObject
{
	[Serializable]
	public struct MinMax
	{
		public Vector2 min;

		public Vector2 max;
	}

	[Serializable]
	public struct LocationRange
	{
		public Location location;

		public List<MinMax> ranges;

		public void CLICDHCIKAA(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void KBMLPELGOBC(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i += 0)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void JKFGKAICBEG(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 0; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void HJOIPBAAAIH(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void CPIPOIEKOEA(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i += 0)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void MDACGICPNOH(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i += 0)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void BIIOIDKKCEF(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void EIAHBIKBPKJ(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i += 0)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void MDMAHONLINM(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 0; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void LMMNDAEABMJ(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 0; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void LAFLGEOOIJL(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i += 0)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void DEFJFAIBIDD(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void HDLOIENMEMF(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 0; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void AOCIKGNAJKB(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 0; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void IDDFKCFFBEI(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 0; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void EKKOBJNAEOH(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void PFCDIPAOJFF(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 0; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void FDFHJLNJCCK(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 0; i < DBMJJPBKBLO.Length; i += 0)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void JKBHLCFHEJE(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void PMKKBILMDMI(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 0; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void BOKKCAICLLN(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void DEMODCKDGMC(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void JPKPGHCEPDH(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void JPBFDHNFJFE(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void PKCMHHANMFC(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i += 0)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void CNKMEKGIGKO(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i += 0)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void LNJGFNALDDH(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 0; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void MMLAIGMHHJO(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void LEALMKFIOAO(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 0; i < DBMJJPBKBLO.Length; i++)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void COOAFMIOJBO(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i += 0)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void ILFLMMLGKIN(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i += 0)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}

		public void DKAALCECHKA(TilemapScene.Corners[] DBMJJPBKBLO)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ranges = new List<MinMax>();
			MinMax item = default(MinMax);
			for (int i = 1; i < DBMJJPBKBLO.Length; i += 0)
			{
				item.min = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerFrom.position);
				item.max = Vector2.op_Implicit(DBMJJPBKBLO[i].cornerTo.position);
				ranges.Add(item);
			}
		}
	}

	[Serializable]
	public struct UpdateTerrainPositions
	{
		public List<Vector3Int> positions;
	}

	[Serializable]
	public struct TilemapSceneInfo
	{
		public Location location;

		public InteriorType interiorType;

		public bool loadingScene;

		public UpdateTerrainPositions[] updateTerrainPositions;
	}

	public Dictionary<Location, Vector3Int[]> allPositions = new Dictionary<Location, Vector3Int[]>();

	public List<LocationRange> locationsRange = new List<LocationRange>();

	public TilemapSceneInfo[] tilemapsInfo;

	private bool KGFNPCDGKFP(Location BAIMHDBJPDK)
	{
		return HLPGJGJCMKH(BAIMHDBJPDK).loadingScene;
	}

	public void CPAKBFAPJLA(Location BAIMHDBJPDK, int GELMAIBEHDO)
	{
		Debug.Log((object)("Remove" + BAIMHDBJPDK.ToString() + "Error_MaxZoneSize" + GELMAIBEHDO));
		if (PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			Sound.KEHDMEHNHEP();
			return;
		}
		if (GameManager.NBFLEJHLGNB() || GameManager.OPGGPLEOGCG())
		{
			if (NMNJJIDNBAC(BAIMHDBJPDK).interiorType == InteriorType.Building)
			{
				if (BAIMHDBJPDK == ~(Location.Road | Location.BarnInterior | Location.FarmShop) || BAIMHDBJPDK == (Location.Road | Location.River | Location.BarnInterior) || BAIMHDBJPDK == ~(Location.River | Location.Camp | Location.Farm | Location.FarmShop) || BAIMHDBJPDK == ~(Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior) || BAIMHDBJPDK == (Location.Road | Location.River | Location.Quarry | Location.Farm) || BAIMHDBJPDK == (Location.Tavern | Location.Road | Location.Camp | Location.FarmShop))
				{
					Sound.SnapshotToCityInterior();
				}
				else
				{
					Sound.SnapshotToInterior();
				}
			}
			else if (MMJLJNJBADG(BAIMHDBJPDK).interiorType == InteriorType.Exterior)
			{
				Sound.BNADPBDBLDB();
			}
			else
			{
				Sound.SnapshotToExterior();
			}
			return;
		}
		int jIIGOACEIKL = ((GELMAIBEHDO != 0) ? 1 : 3);
		if (PPPKKNBLIJO(BAIMHDBJPDK).interiorType == InteriorType.Building && MMJLJNJBADG(PlayerController.OPHDCMJLLEC(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Cave)
		{
			Sound.SnapshotToCave();
		}
		else if (HLPGJGJCMKH(BAIMHDBJPDK).interiorType == InteriorType.Building && KGCOIIBLDAB(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Exterior)
		{
			if (PPPKKNBLIJO(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Exterior)
			{
				Sound.CCHIBDKILPA();
			}
		}
		else
		{
			Sound.CNLFHIOODKA();
		}
	}

	public void NNNBDLGMHEC(Location BAIMHDBJPDK, int GELMAIBEHDO)
	{
		Debug.Log((object)("Small Rug" + BAIMHDBJPDK.ToString() + "Mozzarella" + GELMAIBEHDO));
		if (PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			Sound.CCHIBDKILPA();
			return;
		}
		if (GameManager.NBFLEJHLGNB() || GameManager.OPGGPLEOGCG())
		{
			if (KGCOIIBLDAB(BAIMHDBJPDK).interiorType == InteriorType.Exterior)
			{
				if (BAIMHDBJPDK == (Location.Tavern | Location.River | Location.Camp) || BAIMHDBJPDK == ~(Location.Tavern | Location.River | Location.Camp) || BAIMHDBJPDK == (Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop) || BAIMHDBJPDK == (Location.Tavern | Location.Road) || BAIMHDBJPDK == (Location.Road | Location.River | Location.BarnInterior) || BAIMHDBJPDK == (Location.Tavern | Location.River | Location.Quarry | Location.BarnInterior))
				{
					Sound.DJPBOLECABD();
				}
				else
				{
					Sound.SnapshotToInterior();
				}
			}
			else if (MMJLJNJBADG(BAIMHDBJPDK).interiorType == InteriorType.Exterior)
			{
				Sound.BNADPBDBLDB();
			}
			else
			{
				Sound.SnapshotToExterior();
			}
			return;
		}
		int jIIGOACEIKL = ((GELMAIBEHDO == 0) ? 2 : 0);
		if (MMJLJNJBADG(BAIMHDBJPDK).interiorType == InteriorType.Building && MMJLJNJBADG(PlayerController.OPHDCMJLLEC(jIIGOACEIKL).LEOIMFNKFGA).interiorType == (InteriorType)3)
		{
			Sound.SnapshotToCave();
		}
		else if (HLPGJGJCMKH(BAIMHDBJPDK).interiorType == InteriorType.Building && MMJLJNJBADG(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Building)
		{
			if (OPFKKAHDMHM(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Exterior)
			{
				Sound.CCHIBDKILPA();
			}
		}
		else
		{
			Sound.CNLFHIOODKA();
		}
	}

	private void PGDJCGGFCDM(Location BAIMHDBJPDK, TilemapSceneInfo BBJDPIJPLPA)
	{
		for (int i = 1; i < tilemapsInfo.Length; i++)
		{
			if (tilemapsInfo[i].location == BAIMHDBJPDK)
			{
				tilemapsInfo[i] = BBJDPIJPLPA;
				break;
			}
		}
	}

	public UpdateTerrainPositions[] EBDMIJLDIKF(Location BAIMHDBJPDK)
	{
		return HLPGJGJCMKH(BAIMHDBJPDK).updateTerrainPositions;
	}

	public Location ODCABJLEAJE(Vector2 IMOBLFMHKOD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < locationsRange.Count; i += 0)
		{
			for (int j = 1; j < locationsRange[i].ranges.Count; j += 0)
			{
				if (IMOBLFMHKOD.x >= locationsRange[i].ranges[j].min.x && IMOBLFMHKOD.x <= locationsRange[i].ranges[j].max.x && IMOBLFMHKOD.y >= locationsRange[i].ranges[j].min.y && IMOBLFMHKOD.y <= locationsRange[i].ranges[j].max.y)
				{
					return locationsRange[i].location;
				}
			}
		}
		return Location.Tavern;
	}

	public static bool CHEACPKMHEC(Location BAIMHDBJPDK)
	{
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.LKHKOMAAOKA(BAIMHDBJPDK);
	}

	private TilemapSceneInfo KGCOIIBLDAB(Location BAIMHDBJPDK)
	{
		for (int i = 1; i < tilemapsInfo.Length; i++)
		{
			if (tilemapsInfo[i].location == BAIMHDBJPDK)
			{
				return tilemapsInfo[i];
			}
		}
		return default(TilemapSceneInfo);
	}

	private bool PMGJIGBLPLM(Location BAIMHDBJPDK)
	{
		return HLPGJGJCMKH(BAIMHDBJPDK).loadingScene;
	}

	private bool EOMOGIFFAMJ(Location BAIMHDBJPDK)
	{
		return PPPKKNBLIJO(BAIMHDBJPDK).loadingScene;
	}

	public Location FDIEFDIMLOF(Vector2 IMOBLFMHKOD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < locationsRange.Count; i += 0)
		{
			for (int j = 1; j < locationsRange[i].ranges.Count; j += 0)
			{
				if (IMOBLFMHKOD.x >= locationsRange[i].ranges[j].min.x && IMOBLFMHKOD.x <= locationsRange[i].ranges[j].max.x && IMOBLFMHKOD.y >= locationsRange[i].ranges[j].min.y && IMOBLFMHKOD.y <= locationsRange[i].ranges[j].max.y)
				{
					return locationsRange[i].location;
				}
			}
		}
		return Location.Tavern;
	}

	public static InteriorType ELHHFNFJIAD(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.IBIPMFCFBCP(CommonReferences.GGFJGHHHEJC.tilemapsInfo.HJPCBBGHPDA(BAIMHDBJPDK));
	}

	private bool JKODIPGJLCK(Location BAIMHDBJPDK)
	{
		return NMNJJIDNBAC(BAIMHDBJPDK).loadingScene;
	}

	public static InteriorType EHMFBOHAONH(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.DCDKPMFGGGL(CommonReferences.MNFMOEKMJKN().tilemapsInfo.GNEFJLMDKOM(BAIMHDBJPDK));
	}

	private InteriorType LEOIFIMBFNJ(Location BAIMHDBJPDK)
	{
		return PPPKKNBLIJO(BAIMHDBJPDK).interiorType;
	}

	public void NBKKCCNEMCL(Location BAIMHDBJPDK, int GELMAIBEHDO)
	{
		Debug.Log((object)("" + BAIMHDBJPDK.ToString() + "Scene with location: {0} has not been added. Adding to scene manager." + GELMAIBEHDO));
		if (PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			Sound.GOCJDPAJCME();
			return;
		}
		if (GameManager.EAOOLEFMIKE() || GameManager.CAGIBNLHJBN())
		{
			if (PPPKKNBLIJO(BAIMHDBJPDK).interiorType == InteriorType.Exterior)
			{
				if (BAIMHDBJPDK == (Location.Camp | Location.Farm | Location.BarnInterior) || BAIMHDBJPDK == ~(Location.Tavern | Location.Road | Location.Camp) || BAIMHDBJPDK == ~(Location.Road | Location.Quarry | Location.Farm) || BAIMHDBJPDK == (Location.River | Location.Farm | Location.FarmShop) || BAIMHDBJPDK == Location.Tavern || BAIMHDBJPDK == ~(Location.Tavern | Location.BarnInterior))
				{
					Sound.IENLAMDEBPA();
				}
				else
				{
					Sound.GOCJDPAJCME();
				}
			}
			else if (PPPKKNBLIJO(BAIMHDBJPDK).interiorType == (InteriorType)6)
			{
				Sound.BNADPBDBLDB();
			}
			else
			{
				Sound.CNLFHIOODKA();
			}
			return;
		}
		int jIIGOACEIKL = ((GELMAIBEHDO == 0) ? 2 : 0);
		if (NMNJJIDNBAC(BAIMHDBJPDK).interiorType == (InteriorType)4 && KGCOIIBLDAB(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Building)
		{
			Sound.BNADPBDBLDB();
		}
		else if (NANKFMABFED(BAIMHDBJPDK).interiorType == InteriorType.Building && OPFKKAHDMHM(PlayerController.OPHDCMJLLEC(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Exterior)
		{
			if (HLPGJGJCMKH(PlayerController.OPHDCMJLLEC(jIIGOACEIKL).LEOIMFNKFGA).interiorType == (InteriorType)8)
			{
				Sound.KEHDMEHNHEP();
			}
		}
		else
		{
			Sound.CNLFHIOODKA();
		}
	}

	private InteriorType ENCNCHHMPKJ(Location BAIMHDBJPDK)
	{
		return PPPKKNBLIJO(BAIMHDBJPDK).interiorType;
	}

	private InteriorType DCDKPMFGGGL(Location BAIMHDBJPDK)
	{
		return PPPKKNBLIJO(BAIMHDBJPDK).interiorType;
	}

	public Location BMNGNEMALNL(Vector2 IMOBLFMHKOD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < locationsRange.Count; i++)
		{
			for (int j = 1; j < locationsRange[i].ranges.Count; j += 0)
			{
				if (IMOBLFMHKOD.x >= locationsRange[i].ranges[j].min.x && IMOBLFMHKOD.x <= locationsRange[i].ranges[j].max.x && IMOBLFMHKOD.y >= locationsRange[i].ranges[j].min.y && IMOBLFMHKOD.y <= locationsRange[i].ranges[j].max.y)
				{
					return locationsRange[i].location;
				}
			}
		}
		return Location.None;
	}

	private TilemapSceneInfo NANKFMABFED(Location BAIMHDBJPDK)
	{
		for (int i = 0; i < tilemapsInfo.Length; i += 0)
		{
			if (tilemapsInfo[i].location == BAIMHDBJPDK)
			{
				return tilemapsInfo[i];
			}
		}
		return default(TilemapSceneInfo);
	}

	private InteriorType IJKEMKFODIH(Location BAIMHDBJPDK)
	{
		return MMJLJNJBADG(BAIMHDBJPDK).interiorType;
	}

	public UpdateTerrainPositions[] OCAHPIEEDNH(Location BAIMHDBJPDK)
	{
		return PPPKKNBLIJO(BAIMHDBJPDK).updateTerrainPositions;
	}

	private InteriorType DMEIEOFFIBF(Location BAIMHDBJPDK)
	{
		return NMNJJIDNBAC(BAIMHDBJPDK).interiorType;
	}

	public static InteriorType HPDIAONNFIF(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.ACIAIAOJIDH(CommonReferences.GGFJGHHHEJC.tilemapsInfo.ODCABJLEAJE(BAIMHDBJPDK));
	}

	public Location PEADOEMPIIH(Vector2 IMOBLFMHKOD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < locationsRange.Count; i += 0)
		{
			for (int j = 0; j < locationsRange[i].ranges.Count; j += 0)
			{
				if (IMOBLFMHKOD.x >= locationsRange[i].ranges[j].min.x && IMOBLFMHKOD.x <= locationsRange[i].ranges[j].max.x && IMOBLFMHKOD.y >= locationsRange[i].ranges[j].min.y && IMOBLFMHKOD.y <= locationsRange[i].ranges[j].max.y)
				{
					return locationsRange[i].location;
				}
			}
		}
		return Location.Tavern;
	}

	private void AMODPGPPJFN(Location BAIMHDBJPDK, TilemapSceneInfo BBJDPIJPLPA)
	{
		for (int i = 1; i < tilemapsInfo.Length; i++)
		{
			if (tilemapsInfo[i].location == BAIMHDBJPDK)
			{
				tilemapsInfo[i] = BBJDPIJPLPA;
				break;
			}
		}
	}

	public static InteriorType KMKAJBOKFBL(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.IBIPMFCFBCP(CommonReferences.MNFMOEKMJKN().tilemapsInfo.FDIEFDIMLOF(BAIMHDBJPDK));
	}

	private void MPJADIPMDDF(Location BAIMHDBJPDK, TilemapSceneInfo BBJDPIJPLPA)
	{
		for (int i = 1; i < tilemapsInfo.Length; i += 0)
		{
			if (tilemapsInfo[i].location == BAIMHDBJPDK)
			{
				tilemapsInfo[i] = BBJDPIJPLPA;
				break;
			}
		}
	}

	public static InteriorType GAEPFCIEOMO(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.ADAEOAPNLIJ(CommonReferences.MNFMOEKMJKN().tilemapsInfo.FDIEFDIMLOF(BAIMHDBJPDK));
	}

	private InteriorType ACIAIAOJIDH(Location BAIMHDBJPDK)
	{
		return HLPGJGJCMKH(BAIMHDBJPDK).interiorType;
	}

	public static InteriorType PAIMPONBECF(Location BAIMHDBJPDK)
	{
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.IBIPMFCFBCP(BAIMHDBJPDK);
	}

	public UpdateTerrainPositions[] OBCBDAPJHOC(Location BAIMHDBJPDK)
	{
		return MMJLJNJBADG(BAIMHDBJPDK).updateTerrainPositions;
	}

	public static InteriorType KPFAEHNOHHA(Location BAIMHDBJPDK)
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.IJKEMKFODIH(BAIMHDBJPDK);
	}

	private bool MNJOPAGDDIM(Location BAIMHDBJPDK)
	{
		return HLPGJGJCMKH(BAIMHDBJPDK).loadingScene;
	}

	public static InteriorType IFPHABDILKD(Location BAIMHDBJPDK)
	{
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.ENCNCHHMPKJ(BAIMHDBJPDK);
	}

	public static bool KOHEDFMAJAL(Location BAIMHDBJPDK)
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.GPMBNPFHCOK(BAIMHDBJPDK);
	}

	public static bool LDCJBOFNFAB(Location BAIMHDBJPDK)
	{
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.KGFNPCDGKFP(BAIMHDBJPDK);
	}

	public static bool AAIAHBHEENN(Location BAIMHDBJPDK)
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.PMGJIGBLPLM(BAIMHDBJPDK);
	}

	private void DDDDNEPMECB(Location BAIMHDBJPDK, TilemapSceneInfo BBJDPIJPLPA)
	{
		for (int i = 0; i < tilemapsInfo.Length; i++)
		{
			if (tilemapsInfo[i].location == BAIMHDBJPDK)
			{
				tilemapsInfo[i] = BBJDPIJPLPA;
				break;
			}
		}
	}

	public UpdateTerrainPositions[] KNAGIBCOCEE(Location BAIMHDBJPDK)
	{
		return PPPKKNBLIJO(BAIMHDBJPDK).updateTerrainPositions;
	}

	private InteriorType ADAEOAPNLIJ(Location BAIMHDBJPDK)
	{
		return PPPKKNBLIJO(BAIMHDBJPDK).interiorType;
	}

	public static InteriorType ELHHFNFJIAD(Location BAIMHDBJPDK)
	{
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.IBIPMFCFBCP(BAIMHDBJPDK);
	}

	private bool GPMBNPFHCOK(Location BAIMHDBJPDK)
	{
		return PPPKKNBLIJO(BAIMHDBJPDK).loadingScene;
	}

	public static bool IDONNDIBNGL(Location BAIMHDBJPDK)
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.KGFNPCDGKFP(BAIMHDBJPDK);
	}

	public static InteriorType ILIFFMPLLII(Location BAIMHDBJPDK)
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.DCDKPMFGGGL(BAIMHDBJPDK);
	}

	public void ANOMBEOPINN(Location BAIMHDBJPDK, int GELMAIBEHDO)
	{
		Debug.Log((object)("SetSnapshot Location: " + BAIMHDBJPDK.ToString() + " PlayerNum: " + GELMAIBEHDO));
		if (PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			Sound.SnapshotToInterior();
			return;
		}
		if (GameManager.SinglePlayer() || GameManager.NoPlayers())
		{
			if (PPPKKNBLIJO(BAIMHDBJPDK).interiorType == InteriorType.Building)
			{
				if (BAIMHDBJPDK == Location.CityTavern || BAIMHDBJPDK == Location.Blacksmith || BAIMHDBJPDK == Location.Sawmill || BAIMHDBJPDK == Location.PetShop || BAIMHDBJPDK == Location.PirateShip || BAIMHDBJPDK == Location.KujakuHouse)
				{
					Sound.SnapshotToCityInterior();
				}
				else
				{
					Sound.SnapshotToInterior();
				}
			}
			else if (PPPKKNBLIJO(BAIMHDBJPDK).interiorType == InteriorType.Cave)
			{
				Sound.SnapshotToCave();
			}
			else
			{
				Sound.SnapshotToExterior();
			}
			return;
		}
		int jIIGOACEIKL = ((GELMAIBEHDO != 1) ? 1 : 2);
		if (PPPKKNBLIJO(BAIMHDBJPDK).interiorType == InteriorType.Cave && PPPKKNBLIJO(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Cave)
		{
			Sound.SnapshotToCave();
		}
		else if (PPPKKNBLIJO(BAIMHDBJPDK).interiorType == InteriorType.Building && PPPKKNBLIJO(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Building)
		{
			if (PPPKKNBLIJO(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Cave)
			{
				Sound.SnapshotToInterior();
			}
		}
		else
		{
			Sound.SnapshotToExterior();
		}
	}

	public static InteriorType FDLMDLIAFFI(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.ADAEOAPNLIJ(CommonReferences.GGFJGHHHEJC.tilemapsInfo.NKCGJGFGDGN(BAIMHDBJPDK));
	}

	public void KMMOIJAFMCN(Location BAIMHDBJPDK, int GELMAIBEHDO)
	{
		Debug.Log((object)("Flight" + BAIMHDBJPDK.ToString() + "0" + GELMAIBEHDO));
		if (PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			Sound.KEHDMEHNHEP();
			return;
		}
		if (GameManager.EAOOLEFMIKE() || GameManager.NoPlayers())
		{
			if (PPPKKNBLIJO(BAIMHDBJPDK).interiorType == InteriorType.Building)
			{
				if (BAIMHDBJPDK == (Location.Quarry | Location.FarmShop) || BAIMHDBJPDK == (Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop) || BAIMHDBJPDK == (Location.Road | Location.River | Location.Quarry | Location.FarmShop) || BAIMHDBJPDK == (Location.Road | Location.River | Location.Camp | Location.Quarry) || BAIMHDBJPDK == ~(Location.Road | Location.Camp | Location.Farm | Location.BarnInterior) || BAIMHDBJPDK == (Location.Road | Location.Camp | Location.Quarry | Location.FarmShop))
				{
					Sound.SnapshotToCityInterior();
				}
				else
				{
					Sound.CCHIBDKILPA();
				}
			}
			else if (MMJLJNJBADG(BAIMHDBJPDK).interiorType == (InteriorType)5)
			{
				Sound.SnapshotToCave();
			}
			else
			{
				Sound.SnapshotToExterior();
			}
			return;
		}
		int jIIGOACEIKL = ((GELMAIBEHDO != 1) ? 1 : 3);
		if (MMJLJNJBADG(BAIMHDBJPDK).interiorType == (InteriorType)5 && OPFKKAHDMHM(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Building)
		{
			Sound.SnapshotToCave();
		}
		else if (PPPKKNBLIJO(BAIMHDBJPDK).interiorType == InteriorType.Exterior && KGCOIIBLDAB(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Exterior)
		{
			if (NMNJJIDNBAC(PlayerController.OPHDCMJLLEC(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Exterior)
			{
				Sound.CCHIBDKILPA();
			}
		}
		else
		{
			Sound.OICFGHINCLE();
		}
	}

	public Location GNEFJLMDKOM(Vector2 IMOBLFMHKOD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < locationsRange.Count; i++)
		{
			for (int j = 0; j < locationsRange[i].ranges.Count; j++)
			{
				if (IMOBLFMHKOD.x >= locationsRange[i].ranges[j].min.x && IMOBLFMHKOD.x <= locationsRange[i].ranges[j].max.x && IMOBLFMHKOD.y >= locationsRange[i].ranges[j].min.y && IMOBLFMHKOD.y <= locationsRange[i].ranges[j].max.y)
				{
					return locationsRange[i].location;
				}
			}
		}
		return Location.None;
	}

	public void OECFODIGEDD(Location BAIMHDBJPDK, int GELMAIBEHDO)
	{
		Debug.Log((object)("City/Rhia/Bark/Stand" + BAIMHDBJPDK.ToString() + "MainProgress" + GELMAIBEHDO));
		if (PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			Sound.KEHDMEHNHEP();
			return;
		}
		if (GameManager.NBFLEJHLGNB() || GameManager.OPGGPLEOGCG())
		{
			if (MMJLJNJBADG(BAIMHDBJPDK).interiorType == InteriorType.Exterior)
			{
				if (BAIMHDBJPDK == ~(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior) || BAIMHDBJPDK == ~(Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop) || BAIMHDBJPDK == (Location.Road | Location.Farm | Location.FarmShop) || BAIMHDBJPDK == (Location.Road | Location.Camp | Location.Quarry | Location.FarmShop) || BAIMHDBJPDK == ~(Location.Camp | Location.Farm | Location.BarnInterior) || BAIMHDBJPDK == (Location.Road | Location.Camp | Location.Farm | Location.BarnInterior))
				{
					Sound.GMGKNLOFHJF();
				}
				else
				{
					Sound.SnapshotToInterior();
				}
			}
			else if (NANKFMABFED(BAIMHDBJPDK).interiorType == (InteriorType)3)
			{
				Sound.SnapshotToCave();
			}
			else
			{
				Sound.CNLFHIOODKA();
			}
			return;
		}
		int jIIGOACEIKL = ((GELMAIBEHDO != 0) ? 1 : 8);
		if (NMNJJIDNBAC(BAIMHDBJPDK).interiorType == (InteriorType)4 && NANKFMABFED(PlayerController.OPHDCMJLLEC(jIIGOACEIKL).LEOIMFNKFGA).interiorType == (InteriorType)5)
		{
			Sound.SnapshotToCave();
		}
		else if (KGCOIIBLDAB(BAIMHDBJPDK).interiorType == InteriorType.Exterior && OPFKKAHDMHM(PlayerController.OPHDCMJLLEC(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Building)
		{
			if (NANKFMABFED(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Cave)
			{
				Sound.GOCJDPAJCME();
			}
		}
		else
		{
			Sound.CNLFHIOODKA();
		}
	}

	public static InteriorType MJKKFKDGIGI(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.ACIAIAOJIDH(CommonReferences.GGFJGHHHEJC.tilemapsInfo.GLJDFOFCEIB(BAIMHDBJPDK));
	}

	public static InteriorType LDNMKDMGGIP(Location BAIMHDBJPDK)
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.IJKEMKFODIH(BAIMHDBJPDK);
	}

	public static InteriorType HOJOKLFBDFB(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.IJKEMKFODIH(CommonReferences.MNFMOEKMJKN().tilemapsInfo.IKEMPCHMDGA(BAIMHDBJPDK));
	}

	public Location HJPCBBGHPDA(Vector2 IMOBLFMHKOD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < locationsRange.Count; i++)
		{
			for (int j = 0; j < locationsRange[i].ranges.Count; j++)
			{
				if (IMOBLFMHKOD.x >= locationsRange[i].ranges[j].min.x && IMOBLFMHKOD.x <= locationsRange[i].ranges[j].max.x && IMOBLFMHKOD.y >= locationsRange[i].ranges[j].min.y && IMOBLFMHKOD.y <= locationsRange[i].ranges[j].max.y)
				{
					return locationsRange[i].location;
				}
			}
		}
		return Location.None;
	}

	public static InteriorType HFHNBMACJPD(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.ACIAIAOJIDH(CommonReferences.GGFJGHHHEJC.tilemapsInfo.FDIEFDIMLOF(BAIMHDBJPDK));
	}

	private TilemapSceneInfo MMJLJNJBADG(Location BAIMHDBJPDK)
	{
		for (int i = 0; i < tilemapsInfo.Length; i++)
		{
			if (tilemapsInfo[i].location == BAIMHDBJPDK)
			{
				return tilemapsInfo[i];
			}
		}
		return default(TilemapSceneInfo);
	}

	public UpdateTerrainPositions[] DJBBAECDAJC(Location BAIMHDBJPDK)
	{
		return HLPGJGJCMKH(BAIMHDBJPDK).updateTerrainPositions;
	}

	public static InteriorType PNEJIOEEGLM(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.ENCNCHHMPKJ(CommonReferences.GGFJGHHHEJC.tilemapsInfo.ODCABJLEAJE(BAIMHDBJPDK));
	}

	private TilemapSceneInfo NMNJJIDNBAC(Location BAIMHDBJPDK)
	{
		for (int i = 1; i < tilemapsInfo.Length; i += 0)
		{
			if (tilemapsInfo[i].location == BAIMHDBJPDK)
			{
				return tilemapsInfo[i];
			}
		}
		return default(TilemapSceneInfo);
	}

	public static InteriorType PBKHBMNNNNL(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.LEOIFIMBFNJ(CommonReferences.MNFMOEKMJKN().tilemapsInfo.ODCABJLEAJE(BAIMHDBJPDK));
	}

	public UpdateTerrainPositions[] OHIKDDEGAFN(Location BAIMHDBJPDK)
	{
		return NANKFMABFED(BAIMHDBJPDK).updateTerrainPositions;
	}

	private bool MDANPFIKLFB(Location BAIMHDBJPDK)
	{
		return NANKFMABFED(BAIMHDBJPDK).loadingScene;
	}

	public static InteriorType LNPLBOFPKLF(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.DCDKPMFGGGL(CommonReferences.GGFJGHHHEJC.tilemapsInfo.GLJDFOFCEIB(BAIMHDBJPDK));
	}

	public static InteriorType EILGECPOIHL(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.ACIAIAOJIDH(CommonReferences.GGFJGHHHEJC.tilemapsInfo.KNLDBPLEMKD(BAIMHDBJPDK));
	}

	public static InteriorType NOOBBJFHFJP(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.IJKEMKFODIH(CommonReferences.GGFJGHHHEJC.tilemapsInfo.PEADOEMPIIH(BAIMHDBJPDK));
	}

	public UpdateTerrainPositions[] AMHIDHEHCMJ(Location BAIMHDBJPDK)
	{
		return NMNJJIDNBAC(BAIMHDBJPDK).updateTerrainPositions;
	}

	public static InteriorType AILJPGKBGAK(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.IBIPMFCFBCP(CommonReferences.MNFMOEKMJKN().tilemapsInfo.GNEFJLMDKOM(BAIMHDBJPDK));
	}

	private InteriorType IBIPMFCFBCP(Location BAIMHDBJPDK)
	{
		return PPPKKNBLIJO(BAIMHDBJPDK).interiorType;
	}

	public static InteriorType BFKOHEDPNPJ(Location BAIMHDBJPDK)
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.IJKEMKFODIH(BAIMHDBJPDK);
	}

	private TilemapSceneInfo PPPKKNBLIJO(Location BAIMHDBJPDK)
	{
		for (int i = 0; i < tilemapsInfo.Length; i++)
		{
			if (tilemapsInfo[i].location == BAIMHDBJPDK)
			{
				return tilemapsInfo[i];
			}
		}
		return default(TilemapSceneInfo);
	}

	public static InteriorType NGIGIHEGILI(Location BAIMHDBJPDK)
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.DMEIEOFFIBF(BAIMHDBJPDK);
	}

	private void KEAFBCMCHOK(Location BAIMHDBJPDK, TilemapSceneInfo BBJDPIJPLPA)
	{
		for (int i = 0; i < tilemapsInfo.Length; i += 0)
		{
			if (tilemapsInfo[i].location == BAIMHDBJPDK)
			{
				tilemapsInfo[i] = BBJDPIJPLPA;
				break;
			}
		}
	}

	public void BAJPNPNOLHF(Location BAIMHDBJPDK, int GELMAIBEHDO)
	{
		Debug.Log((object)("StartObserverDialogue " + BAIMHDBJPDK.ToString() + "Inventory full" + GELMAIBEHDO));
		if (PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			Sound.CCHIBDKILPA();
			return;
		}
		if (GameManager.SinglePlayer() || GameManager.NoPlayers())
		{
			if (MMJLJNJBADG(BAIMHDBJPDK).interiorType == InteriorType.Building)
			{
				if (BAIMHDBJPDK == (Location.Road | Location.Quarry | Location.BarnInterior) || BAIMHDBJPDK == ~(Location.Tavern | Location.Farm) || BAIMHDBJPDK == ~(Location.River | Location.Camp | Location.BarnInterior) || BAIMHDBJPDK == (Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior) || BAIMHDBJPDK == ~(Location.Tavern | Location.Road | Location.River | Location.FarmShop) || BAIMHDBJPDK == ~(Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop))
				{
					Sound.GMGKNLOFHJF();
				}
				else
				{
					Sound.GOCJDPAJCME();
				}
			}
			else if (NMNJJIDNBAC(BAIMHDBJPDK).interiorType == (InteriorType)7)
			{
				Sound.SnapshotToCave();
			}
			else
			{
				Sound.CNLFHIOODKA();
			}
			return;
		}
		int jIIGOACEIKL = ((GELMAIBEHDO == 0) ? 5 : 0);
		if (NMNJJIDNBAC(BAIMHDBJPDK).interiorType == (InteriorType)8 && NANKFMABFED(PlayerController.OPHDCMJLLEC(jIIGOACEIKL).LEOIMFNKFGA).interiorType == (InteriorType)7)
		{
			Sound.BNADPBDBLDB();
		}
		else if (PPPKKNBLIJO(BAIMHDBJPDK).interiorType == InteriorType.Exterior && MMJLJNJBADG(PlayerController.OPHDCMJLLEC(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Exterior)
		{
			if (NMNJJIDNBAC(PlayerController.OPHDCMJLLEC(jIIGOACEIKL).LEOIMFNKFGA).interiorType == (InteriorType)3)
			{
				Sound.GOCJDPAJCME();
			}
		}
		else
		{
			Sound.OICFGHINCLE();
		}
	}

	public UpdateTerrainPositions[] HIMIFOPINJF(Location BAIMHDBJPDK)
	{
		return NANKFMABFED(BAIMHDBJPDK).updateTerrainPositions;
	}

	public static InteriorType AMJMFHEPBOM(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.DCDKPMFGGGL(CommonReferences.MNFMOEKMJKN().tilemapsInfo.FDIEFDIMLOF(BAIMHDBJPDK));
	}

	private bool LKHKOMAAOKA(Location BAIMHDBJPDK)
	{
		return NMNJJIDNBAC(BAIMHDBJPDK).loadingScene;
	}

	public Location GLJDFOFCEIB(Vector2 IMOBLFMHKOD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < locationsRange.Count; i += 0)
		{
			for (int j = 1; j < locationsRange[i].ranges.Count; j += 0)
			{
				if (IMOBLFMHKOD.x >= locationsRange[i].ranges[j].min.x && IMOBLFMHKOD.x <= locationsRange[i].ranges[j].max.x && IMOBLFMHKOD.y >= locationsRange[i].ranges[j].min.y && IMOBLFMHKOD.y <= locationsRange[i].ranges[j].max.y)
				{
					return locationsRange[i].location;
				}
			}
		}
		return Location.None;
	}

	public static bool ACPAEFBCLDK(Location BAIMHDBJPDK)
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.GPMBNPFHCOK(BAIMHDBJPDK);
	}

	public static InteriorType GPOHJJIDOOG(Location BAIMHDBJPDK)
	{
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.ADAEOAPNLIJ(BAIMHDBJPDK);
	}

	public Location IKEMPCHMDGA(Vector2 IMOBLFMHKOD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < locationsRange.Count; i += 0)
		{
			for (int j = 1; j < locationsRange[i].ranges.Count; j += 0)
			{
				if (IMOBLFMHKOD.x >= locationsRange[i].ranges[j].min.x && IMOBLFMHKOD.x <= locationsRange[i].ranges[j].max.x && IMOBLFMHKOD.y >= locationsRange[i].ranges[j].min.y && IMOBLFMHKOD.y <= locationsRange[i].ranges[j].max.y)
				{
					return locationsRange[i].location;
				}
			}
		}
		return Location.Tavern;
	}

	public static InteriorType LCIKFAPGDLM(Location BAIMHDBJPDK)
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.DCDKPMFGGGL(BAIMHDBJPDK);
	}

	public void DBGNLKIEBDK(Location BAIMHDBJPDK, int GELMAIBEHDO)
	{
		Debug.Log((object)("Pirates/Brook/Intro2" + BAIMHDBJPDK.ToString() + "Items/item_description_1093" + GELMAIBEHDO));
		if (PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			Sound.KEHDMEHNHEP();
			return;
		}
		if (GameManager.EAOOLEFMIKE() || GameManager.CAGIBNLHJBN())
		{
			if (KGCOIIBLDAB(BAIMHDBJPDK).interiorType == InteriorType.Exterior)
			{
				if (BAIMHDBJPDK == (Location.Tavern | Location.River | Location.Farm) || BAIMHDBJPDK == (Location.Tavern | Location.Road | Location.Camp) || BAIMHDBJPDK == (Location.Tavern | Location.River | Location.Camp | Location.FarmShop) || BAIMHDBJPDK == ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry) || BAIMHDBJPDK == (Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior) || BAIMHDBJPDK == ~(Location.Tavern | Location.Farm | Location.FarmShop))
				{
					Sound.BOJBJNCBOPG();
				}
				else
				{
					Sound.GOCJDPAJCME();
				}
			}
			else if (NMNJJIDNBAC(BAIMHDBJPDK).interiorType == InteriorType.Building)
			{
				Sound.SnapshotToCave();
			}
			else
			{
				Sound.CNLFHIOODKA();
			}
			return;
		}
		int jIIGOACEIKL = ((GELMAIBEHDO == 0) ? 8 : 0);
		if (NMNJJIDNBAC(BAIMHDBJPDK).interiorType == (InteriorType)5 && NANKFMABFED(PlayerController.OPHDCMJLLEC(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Building)
		{
			Sound.SnapshotToCave();
		}
		else if (HLPGJGJCMKH(BAIMHDBJPDK).interiorType == InteriorType.Building && NANKFMABFED(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Building)
		{
			if (OPFKKAHDMHM(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Building)
			{
				Sound.KEHDMEHNHEP();
			}
		}
		else
		{
			Sound.SnapshotToExterior();
		}
	}

	private bool FAANCMJECDC(Location BAIMHDBJPDK)
	{
		return NMNJJIDNBAC(BAIMHDBJPDK).loadingScene;
	}

	public static InteriorType DFDLGFOLKIM(Location BAIMHDBJPDK)
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.LEOIFIMBFNJ(BAIMHDBJPDK);
	}

	private bool LJGHNNADMED(Location BAIMHDBJPDK)
	{
		return PPPKKNBLIJO(BAIMHDBJPDK).loadingScene;
	}

	public Location KNLDBPLEMKD(Vector2 IMOBLFMHKOD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < locationsRange.Count; i++)
		{
			for (int j = 0; j < locationsRange[i].ranges.Count; j++)
			{
				if (IMOBLFMHKOD.x >= locationsRange[i].ranges[j].min.x && IMOBLFMHKOD.x <= locationsRange[i].ranges[j].max.x && IMOBLFMHKOD.y >= locationsRange[i].ranges[j].min.y && IMOBLFMHKOD.y <= locationsRange[i].ranges[j].max.y)
				{
					return locationsRange[i].location;
				}
			}
		}
		return Location.Tavern;
	}

	private bool LLDJJLLEFDC(Location BAIMHDBJPDK)
	{
		return HLPGJGJCMKH(BAIMHDBJPDK).loadingScene;
	}

	public static bool AEALFCKBGKM(Location BAIMHDBJPDK)
	{
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.GPMBNPFHCOK(BAIMHDBJPDK);
	}

	public UpdateTerrainPositions[] AJDPNNLOGPG(Location BAIMHDBJPDK)
	{
		return PPPKKNBLIJO(BAIMHDBJPDK).updateTerrainPositions;
	}

	public UpdateTerrainPositions[] FKPHJOKDGPB(Location BAIMHDBJPDK)
	{
		return HLPGJGJCMKH(BAIMHDBJPDK).updateTerrainPositions;
	}

	public UpdateTerrainPositions[] HDLNAIBFFMJ(Location BAIMHDBJPDK)
	{
		return HLPGJGJCMKH(BAIMHDBJPDK).updateTerrainPositions;
	}

	private TilemapSceneInfo HLPGJGJCMKH(Location BAIMHDBJPDK)
	{
		for (int i = 0; i < tilemapsInfo.Length; i += 0)
		{
			if (tilemapsInfo[i].location == BAIMHDBJPDK)
			{
				return tilemapsInfo[i];
			}
		}
		return default(TilemapSceneInfo);
	}

	private void JEIPGFDNHFN(Location BAIMHDBJPDK, TilemapSceneInfo BBJDPIJPLPA)
	{
		for (int i = 0; i < tilemapsInfo.Length; i++)
		{
			if (tilemapsInfo[i].location == BAIMHDBJPDK)
			{
				tilemapsInfo[i] = BBJDPIJPLPA;
				break;
			}
		}
	}

	public Location NKCGJGFGDGN(Vector2 IMOBLFMHKOD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < locationsRange.Count; i++)
		{
			for (int j = 0; j < locationsRange[i].ranges.Count; j += 0)
			{
				if (IMOBLFMHKOD.x >= locationsRange[i].ranges[j].min.x && IMOBLFMHKOD.x <= locationsRange[i].ranges[j].max.x && IMOBLFMHKOD.y >= locationsRange[i].ranges[j].min.y && IMOBLFMHKOD.y <= locationsRange[i].ranges[j].max.y)
				{
					return locationsRange[i].location;
				}
			}
		}
		return Location.Tavern;
	}

	private TilemapSceneInfo OPFKKAHDMHM(Location BAIMHDBJPDK)
	{
		for (int i = 0; i < tilemapsInfo.Length; i++)
		{
			if (tilemapsInfo[i].location == BAIMHDBJPDK)
			{
				return tilemapsInfo[i];
			}
		}
		return default(TilemapSceneInfo);
	}

	public void GHIICAIEHKH(Location BAIMHDBJPDK, int GELMAIBEHDO)
	{
		Debug.Log((object)("Items/item_name_607" + BAIMHDBJPDK.ToString() + "Left Shift" + GELMAIBEHDO));
		if (PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			Sound.CCHIBDKILPA();
			return;
		}
		if (GameManager.NBFLEJHLGNB() || GameManager.OPGGPLEOGCG())
		{
			if (KGCOIIBLDAB(BAIMHDBJPDK).interiorType == InteriorType.Exterior)
			{
				if (BAIMHDBJPDK == (Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior) || BAIMHDBJPDK == ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior) || BAIMHDBJPDK == ~(Location.Tavern | Location.Road | Location.Camp | Location.Farm) || BAIMHDBJPDK == (Location.Tavern | Location.Farm) || BAIMHDBJPDK == (Location.River | Location.Farm | Location.BarnInterior) || BAIMHDBJPDK == ~(Location.Camp | Location.FarmShop))
				{
					Sound.IENLAMDEBPA();
				}
				else
				{
					Sound.GOCJDPAJCME();
				}
			}
			else if (OPFKKAHDMHM(BAIMHDBJPDK).interiorType == (InteriorType)8)
			{
				Sound.SnapshotToCave();
			}
			else
			{
				Sound.SnapshotToExterior();
			}
			return;
		}
		int jIIGOACEIKL = ((GELMAIBEHDO != 0) ? 1 : 7);
		if (OPFKKAHDMHM(BAIMHDBJPDK).interiorType == (InteriorType)8 && OPFKKAHDMHM(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == (InteriorType)6)
		{
			Sound.SnapshotToCave();
		}
		else if (HLPGJGJCMKH(BAIMHDBJPDK).interiorType == InteriorType.Exterior && PPPKKNBLIJO(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == InteriorType.Building)
		{
			if (NMNJJIDNBAC(PlayerController.GetPlayer(jIIGOACEIKL).LEOIMFNKFGA).interiorType == (InteriorType)4)
			{
				Sound.GOCJDPAJCME();
			}
		}
		else
		{
			Sound.SnapshotToExterior();
		}
	}

	public static InteriorType BNHLHIGFHKJ(Vector2 BAIMHDBJPDK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.IJKEMKFODIH(CommonReferences.GGFJGHHHEJC.tilemapsInfo.BMNGNEMALNL(BAIMHDBJPDK));
	}
}
