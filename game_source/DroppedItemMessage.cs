using System;
using Newtonsoft.Json;
using Photon.Pun;
using UnityEngine;

[Serializable]
public class DroppedItemMessage : ObjectMessage
{
	[JsonProperty("1")]
	public ItemInstanceWrapperMessage itemInstanceMessage;

	[JsonProperty("2")]
	public short amount;

	[JsonProperty("3")]
	public short actorNumberIfIgnoreTrigger = short.MaxValue;

	private static DroppedItem droppedItemAux;

	protected override OnlineObject JCNFPEHGGKP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		droppedItemAux = DroppedItem.SpawnDroppedItem(Vector2.op_Implicit(position.DMBNLBPEELL()), itemInstanceMessage.ANMBPDJLNFN(), amount);
		if (Object.op_Implicit((Object)(object)droppedItemAux))
		{
			if (actorNumberIfIgnoreTrigger != short.MaxValue)
			{
				droppedItemAux.itemFollow.SetIgnoreFirstTriggerEnter(OnlinePlayerDataManager.GetPlayerNumByActorNumber(actorNumberIfIgnoreTrigger));
			}
			return droppedItemAux.onlineDroppedItem;
		}
		Vector2 val = position.DMBNLBPEELL();
		string? text = ((object)(Vector2)(ref val)).ToString();
		ItemInstance itemInstance = itemInstanceMessage.ANMBPDJLNFN();
		Debug.LogError((object)("Cannot instantiate dropped item at " + text + " with item: " + ((itemInstance != null) ? ((Object)itemInstance.LHBPOPOIFLE()).name : null)));
		return null;
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineDroppedItem onlineDroppedItem)
		{
			onlineDroppedItem.droppedItem.HLPNOAENFHK = itemInstanceMessage.ANMBPDJLNFN();
			onlineDroppedItem.droppedItem.MGNOBNCMDJG = amount;
		}
		return onlineObject;
	}

	public DroppedItemMessage(OnlineDroppedItem KBEONEKNBIL)
		: base(KBEONEKNBIL)
	{
		itemInstanceMessage = new ItemInstanceWrapperMessage(KBEONEKNBIL.droppedItem.HLPNOAENFHK);
		amount = (short)KBEONEKNBIL.droppedItem.MGNOBNCMDJG;
		if (KBEONEKNBIL.droppedItem.itemFollow.ignoreFirstTriggerEnter[1])
		{
			actorNumberIfIgnoreTrigger = (short)PhotonNetwork.LocalPlayer.ActorNumber;
		}
	}
}
