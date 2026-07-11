using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class TreeMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public short indexList;

	[JsonProperty("2")]
	public byte age;

	[JsonProperty("3")]
	public bool setUp;

	protected override OnlineObject JCNFPEHGGKP()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		Item item = ItemDatabaseAccessor.GetItem(itemId);
		GameObject val = ((!(item is Seed seed)) ? ((!item.growable) ? item.PHGCBMPGGLI() : item.growablePrefabs[age]) : seed.crop.growablePrefabs[age]);
		return Object.Instantiate<GameObject>(val, Vector2.op_Implicit(position.DMBNLBPEELL()), Quaternion.identity).GetComponent<OnlineTree>();
	}

	public TreeMessage(OnlineTree KIBJPHCBDIO)
		: base(KIBJPHCBDIO)
	{
		if (Object.op_Implicit((Object)(object)KIBJPHCBDIO.tree))
		{
			age = (byte)KIBJPHCBDIO.tree.GetCurrentAge();
			skinIndex = (byte)KIBJPHCBDIO.tree.skinIndex;
			setUp = KIBJPHCBDIO.tree.placeable.itemSpace.setUp;
		}
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineTree onlineTree)
		{
			onlineTree.tree.placeable.itemSpace.setUp = setUp;
		}
		return onlineObject;
	}
}
