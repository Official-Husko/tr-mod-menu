using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class PlaceableMsg : ObjectMessage
{
	[JsonProperty("iId")]
	public int itemId;

	[JsonProperty("ro")]
	public bool rotated;

	[JsonProperty("di")]
	public byte direction;

	[JsonProperty("sI")]
	public byte skinIndex;

	[JsonProperty("vG")]
	public VariationGroup[] variationGroups;

	[JsonProperty("iS")]
	public bool onlineSelected;

	[JsonProperty("sPId")]
	public int surfaceParentId;

	private static GameObject prefab;

	private static GameObject instantiatedPrefab;

	private static Placeable placeableAux;

	private static OnlinePlaceable onlinePlaceable;

	protected override OnlineObject JCNFPEHGGKP()
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		if (Item.NGIIPJDAMGP(ItemDatabaseAccessor.GetItem(itemId), null))
		{
			Debug.LogError((object)("Item with id " + itemId + " not found. Can no instantiate online placeable"));
			return null;
		}
		prefab = ItemDatabaseAccessor.GetItem(itemId).PHGCBMPGGLI();
		if ((Object)(object)prefab == (Object)null)
		{
			return null;
		}
		placeableAux = prefab.GetComponentInChildren<Placeable>();
		if ((Object)(object)placeableAux != (Object)null && placeableAux.fourSidesRotation)
		{
			prefab = ((Component)Placeable.GetRotationPrefab(placeableAux, (Direction)direction)).gameObject;
		}
		else if (rotated)
		{
			prefab = ItemDatabaseAccessor.GetItem(itemId).ALLGGMEFAKA();
		}
		if ((Object)(object)prefab == (Object)null)
		{
			Debug.LogError((object)("Prefab not found for item with id " + itemId + ". Can no instantiate online placeable. rotated: " + rotated));
			return null;
		}
		instantiatedPrefab = Object.Instantiate<GameObject>(prefab, Vector2.op_Implicit(Utils.BPKGAMFNAGC(position)), prefab.transform.rotation);
		onlinePlaceable = instantiatedPrefab.GetComponent<OnlinePlaceable>();
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			return onlinePlaceable;
		}
		return instantiatedPrefab.GetComponentInChildren<OnlinePlaceable>();
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlinePlaceable onlinePlaceable && Object.op_Implicit((Object)(object)onlinePlaceable.placeable))
		{
			onlinePlaceable.CLHLNFFGOGA = onlineSelected;
			onlinePlaceable.placeable.randomSkin = false;
			if (onlinePlaceable.placeable.multipleSkins && (onlinePlaceable.placeable.skins.Length != 0 || onlinePlaceable.placeable.skinsGameObjects.Length != 0))
			{
				onlinePlaceable.placeable.ChangeSkin(skinIndex, PDHJLCDFNCK: false);
			}
			if (variationGroups != null && variationGroups.Length != 0 && onlinePlaceable.placeable.skinVariationGropus.Count > 0)
			{
				onlinePlaceable.placeable.randomSkin = false;
				for (int i = 0; i < onlinePlaceable.placeable.skinVariationGropus.Count; i++)
				{
					onlinePlaceable.placeable.skinVariationGropus[i].CIGBHLNFOPK();
					for (int j = 0; j < variationGroups[i].idsActivated.Length; j++)
					{
						onlinePlaceable.placeable.skinVariationGropus[i].OPBKBEIAMND(variationGroups[i].idsActivated[j], 0, null);
					}
				}
			}
			onlinePlaceable.placeable.SetDirection((Direction)direction, CDPAMNIPPEC: false);
			if (onlineSelected)
			{
				onlinePlaceable.placeable.OnThisPlaceableSelected(1, arg2: true, arg3: false);
			}
		}
		return onlineObject;
	}

	public PlaceableMsg(OnlinePlaceable HBDFJGNDOGN)
		: base(HBDFJGNDOGN)
	{
		if ((Object)(object)HBDFJGNDOGN == (Object)null)
		{
			Debug.LogError((object)"Online placeable doesn't exist loading PlaceableMsg");
			return;
		}
		if ((Object)(object)HBDFJGNDOGN.placeable == (Object)null)
		{
			Debug.LogError((object)("Online placeable component doesn't have placeable attached " + ((Object)((Component)HBDFJGNDOGN).gameObject).name));
			return;
		}
		if (HBDFJGNDOGN is OnlineCropTree)
		{
			itemId = (HBDFJGNDOGN as OnlineCropTree).cropSetter.FJJCOJGJCLF.seed.JDJGFAACPFC();
		}
		else
		{
			itemId = HBDFJGNDOGN.placeable.itemSetup.item.JDJGFAACPFC();
		}
		rotated = HBDFJGNDOGN.rotated;
		direction = (byte)HBDFJGNDOGN.placeable.direction;
		if (HBDFJGNDOGN.placeable.multipleSkins && (HBDFJGNDOGN.placeable.skins.Length != 0 || HBDFJGNDOGN.placeable.skinsGameObjects.Length != 0))
		{
			skinIndex = (byte)HBDFJGNDOGN.placeable.GetSkinIndex();
		}
		else
		{
			skinIndex = 0;
		}
		if (HBDFJGNDOGN.placeable.skinVariationGropus.Count > 0)
		{
			variationGroups = new VariationGroup[HBDFJGNDOGN.placeable.skinVariationGropus.Count];
			for (int i = 0; i < HBDFJGNDOGN.placeable.skinVariationGropus.Count; i++)
			{
				variationGroups[i].idsActivated = HBDFJGNDOGN.placeable.skinVariationGropus[i].LMANKEJLNKM().ToArray();
			}
		}
		onlineSelected = HBDFJGNDOGN.placeable.FHEMHCEAICB || HBDFJGNDOGN.CLHLNFFGOGA;
		if ((Object)(object)HBDFJGNDOGN.placeable.currentSurface != (Object)null)
		{
			if (Object.op_Implicit((Object)(object)HBDFJGNDOGN.placeable.currentSurface.placeable) && Object.op_Implicit((Object)(object)HBDFJGNDOGN.placeable.currentSurface.placeable.onlinePlaceable))
			{
				surfaceParentId = HBDFJGNDOGN.placeable.currentSurface.placeable.onlinePlaceable.uniqueId;
				return;
			}
			surfaceParentId = 0;
			if (!(HBDFJGNDOGN is OnlineAnimal))
			{
				Debug.LogError((object)("Current surface without placeable " + ((Object)((Component)HBDFJGNDOGN).gameObject).name));
			}
		}
		else
		{
			surfaceParentId = 0;
		}
	}
}
