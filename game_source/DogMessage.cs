using System;
using Newtonsoft.Json;
using Photon.Pun;
using UnityEngine;

[Serializable]
public class DogMessage : ObjectMessage
{
	[JsonProperty("1")]
	public int relationship;

	[JsonProperty("2")]
	public int dogSelected;

	[JsonProperty("3")]
	public string dogName;

	[JsonProperty("4")]
	public GameDateMessage birthday;

	[JsonProperty("5")]
	public bool reproduceInteraction;

	[JsonProperty("6")]
	public int interactionType;

	[JsonProperty("7")]
	public int actorFollowing;

	public override OnlineObject OEJJGDMKIDN()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		((Component)onlineObject).transform.position = new Vector3(position.x, position.y, 0f);
		return onlineObject;
	}

	public DogMessage(OnlineDog DJFNFPOPIBG)
		: base(DJFNFPOPIBG)
	{
		relationship = DJFNFPOPIBG.dogNpc.dogRelationship.relationshipLevel;
		dogSelected = (int)DJFNFPOPIBG.dogNpc.dogBreed;
		dogName = DJFNFPOPIBG.dogNpc.dogName;
		birthday = new GameDateMessage(DJFNFPOPIBG.dogNpc.birthday);
		reproduceInteraction = DJFNFPOPIBG.reproduceInteraction;
		interactionType = (int)DJFNFPOPIBG.interactionType;
		if ((Object)(object)DJFNFPOPIBG.dogNpc.playerFollowing != (Object)null)
		{
			actorFollowing = ((MonoBehaviourPun)DJFNFPOPIBG.dogNpc.playerFollowing.onlinePlayer).photonView.OwnerActorNr;
		}
		else
		{
			actorFollowing = 0;
		}
	}

	protected override OnlineObject JCNFPEHGGKP()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance != (Object)null)
		{
			Object.Destroy((Object)(object)((Component)DogNPC.instance).gameObject);
		}
		DogNPC.InstantiateDog(relationship, dogSelected, dogName, birthday.JBJLBDHAECK(), position.DMBNLBPEELL(), GFNHAMCPEAK: false, CDPAMNIPPEC: false);
		if ((Object)(object)DogNPC.instance != (Object)null)
		{
			if (actorFollowing != 0)
			{
				DogNPC.instance.Follow(OnlinePlayerDataManager.GetPlayerNumByActorNumber(actorFollowing), CDPAMNIPPEC: false);
			}
			DogNPC.instance.onlineDog.reproduceInteraction = reproduceInteraction;
			DogNPC.instance.onlineDog.interactionType = (DogNPC.DogInteractionType)interactionType;
			return DogNPC.instance.onlineDog;
		}
		Debug.LogError((object)"DogNPC instance is null");
		return null;
	}
}
