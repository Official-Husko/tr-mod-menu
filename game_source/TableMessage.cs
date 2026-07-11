using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class TableMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public float dirtiness;

	public TableMessage(OnlineTable HENDHLBNNBB)
		: base(HENDHLBNNBB)
	{
		dirtiness = HENDHLBNNBB.table.PDPKEPEBPIK;
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineTable onlineTable)
		{
			onlineTable.table.SetDirtiness(dirtiness, CDPAMNIPPEC: false);
		}
		else
		{
			Debug.LogError((object)("Received PlaceableMsg of another type not TableMessage to " + ((Object)((Component)onlineObject).gameObject).name));
		}
		return onlineObject;
	}
}
