using System;
using UnityEngine;
using UnityEngine.Tilemaps;

public class UpgradedRoom : MonoBehaviour
{
	[Serializable]
	public class Corners
	{
		public Transform baseFrom;

		public Transform cornerFrom;

		public Transform cornerTo;
	}

	public Vector2 cameraBoundsOffset;

	public Vector2 cameraBoundsSize;

	public Transform[] moveObjectsLocation;

	[Space(20f)]
	public Corners[] corners;

	private void BNLEDOBJNEO(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.MAAAKALBBEE().tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	public void ChangeTiles()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < corners.Length; i++)
		{
			LHLCFJIDDPJ(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	public void CKADKFLBCAN()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < corners.Length; i++)
		{
			KKCPJPEDCAC(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	public void GHILLIKFMPC()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < corners.Length; i += 0)
		{
			JFOLFOJPPFM(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	private void KMOLOKKEHPG(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.GGFJGHHHEJC.tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	public void EHODJOBOAKN()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < corners.Length; i += 0)
		{
			JGAKKKOHEAB(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	public void LNADHOHFGPA()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < corners.Length; i++)
		{
			JGAKKKOHEAB(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	private void OKHHGPBKNNL(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.MAAAKALBBEE().tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	public void IEDGOAKFAOA()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < corners.Length; i += 0)
		{
			IPNJEIOCOHC(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	private void FGLGGIDKMCL(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.GGFJGHHHEJC.tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	private void PLKKJJMLDDB(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.MAAAKALBBEE().tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	private void GOLBGPKDIAN(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.MAAAKALBBEE().tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	public void DJCDNGNIKAN()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < corners.Length; i += 0)
		{
			IPNJEIOCOHC(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	public void GDNDPBBPCBL()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < corners.Length; i += 0)
		{
			IPNJEIOCOHC(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	private void PIBKFHFHPMD(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.LDBJELPPBAI().tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	public void EMONDILMFEB()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < corners.Length; i += 0)
		{
			KMOLOKKEHPG(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	private void NGOMGDGCIFC(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.GGFJGHHHEJC.tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	public void LDHAIEPKCHM()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < corners.Length; i += 0)
		{
			KKCPJPEDCAC(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	public void NCNDMDDOLOK()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < corners.Length; i++)
		{
			KMOLOKKEHPG(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	public void MPGELHBFKDJ()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < corners.Length; i += 0)
		{
			JFOLFOJPPFM(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	private void LHLCFJIDDPJ(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.GGFJGHHHEJC.tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	public void HDGJLEOOAEI()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < corners.Length; i += 0)
		{
			IPNJEIOCOHC(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	private void MEBBGPCLIJG(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.GGFJGHHHEJC.tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	private void FFAODHOIDAJ(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.LDBJELPPBAI().tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	public void IBJHMOAFDFK()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < corners.Length; i++)
		{
			JFOLFOJPPFM(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	private void JLGFIBJAFPC(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.GGFJGHHHEJC.tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	public void LAEEDOLPGHO()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < corners.Length; i += 0)
		{
			JFOLFOJPPFM(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	private void IPNJEIOCOHC(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.LDBJELPPBAI().tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	private void JGAKKKOHEAB(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.MAAAKALBBEE().tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	public void PGCHIKHIIPK()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < corners.Length; i++)
		{
			PLKKJJMLDDB(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	private void KKCPJPEDCAC(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.GGFJGHHHEJC.tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	private void JFOLFOJPPFM(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.GGFJGHHHEJC.tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	public void GIOPLEOLDHM()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < corners.Length; i += 0)
		{
			PLKKJJMLDDB(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}

	private void DIACGHMMHNP(Vector3 ALAAHCAMBHA, Vector3 PCBFAABLGOC, Vector3 EAJMEFHGGMO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		foreach (Tilemap tilemap in RoomUpgrader.LDBJELPPBAI().tilemaps)
		{
			Vector3Int val = ((GridLayout)tilemap).WorldToCell(ALAAHCAMBHA);
			Vector3Int val2 = ((GridLayout)tilemap).WorldToCell(PCBFAABLGOC);
			Vector3Int val3 = ((GridLayout)tilemap).WorldToCell(EAJMEFHGGMO);
			int num = Math.Sign(((Vector3Int)(ref val3)).x - ((Vector3Int)(ref val2)).x);
			int num2 = Math.Sign(((Vector3Int)(ref val3)).y - ((Vector3Int)(ref val2)).y);
			Vector3Int val4 = default(Vector3Int);
			((Vector3Int)(ref val4)).z = ((Vector3Int)(ref val2)).z;
			Vector3Int val5 = new Vector3Int(((Vector3Int)(ref val)).x, ((Vector3Int)(ref val)).y, ((Vector3Int)(ref val)).z);
			int num3 = ((Vector3Int)(ref val2)).x;
			while (num3 != ((Vector3Int)(ref val3)).x + num)
			{
				int num4 = ((Vector3Int)(ref val2)).y;
				while (num4 != ((Vector3Int)(ref val3)).y + num2)
				{
					((Vector3Int)(ref val4)).x = num3;
					((Vector3Int)(ref val4)).y = num4;
					tilemap.SetTile(val5, tilemap.GetTile(val4));
					tilemap.SetTile(val4, (TileBase)null);
					num4 += num2;
					((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val5)).y + num2;
				}
				((Vector3Int)(ref val5)).y = ((Vector3Int)(ref val)).y;
				num3 += num;
				((Vector3Int)(ref val5)).x = ((Vector3Int)(ref val5)).x + num;
			}
		}
	}

	public void MIABDPCAHJP()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < corners.Length; i++)
		{
			JLGFIBJAFPC(corners[i].baseFrom.position, corners[i].cornerFrom.position, corners[i].cornerTo.position);
		}
	}
}
