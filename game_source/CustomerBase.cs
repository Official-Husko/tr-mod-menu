using Photon.Pun;
using UnityEngine;

public abstract class CustomerBase : MonoBehaviourPunCallbacks
{
	public ItemInstance currentItem;

	public ItemInstance currentRequest;

	public HumanNPC npc;

	public CustomerSpeech customerSpeech;

	public NPCHoldObject npcHoldItem;

	public OnlineBaseActor onlineActor;

	protected float JHOPNDGOKDD;

	public OnlineCustomer LJOHCJAOADD => onlineActor as OnlineCustomer;

	protected virtual void Awake()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponent<HumanNPC>();
		}
		if ((Object)(object)customerSpeech == (Object)null)
		{
			customerSpeech = ((Component)this).GetComponent<CustomerSpeech>();
		}
		if ((Object)(object)npcHoldItem == (Object)null)
		{
			npcHoldItem = ((Component)this).GetComponent<NPCHoldObject>();
		}
	}

	public void SetCurrentItem(ItemInstance HPHELAPHAHN)
	{
		currentItem = HPHELAPHAHN;
		npcHoldItem.ODDHGLHEHLA = currentItem;
		if (OnlineManager.IsMasterClient() && (Object)(object)LJOHCJAOADD != (Object)null)
		{
			LJOHCJAOADD.SendNewHeldItem(currentItem);
		}
	}
}
