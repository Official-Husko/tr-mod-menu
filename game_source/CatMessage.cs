using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class CatMessage : ObjectMessage
{
	[JsonProperty("1")]
	public int relationship;

	[JsonProperty("2")]
	public int catSelected;

	[JsonProperty("3")]
	public string catName;

	[JsonProperty("4")]
	public GameDateMessage birthday;

	public override OnlineObject OEJJGDMKIDN()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		((Component)onlineObject).transform.position = new Vector3(position.x, position.y, 0f);
		return onlineObject;
	}

	protected override OnlineObject JCNFPEHGGKP()
	{
		if ((Object)(object)SpawnCat.GGFJGHHHEJC.catNPC != (Object)null)
		{
			Object.Destroy((Object)(object)((Component)SpawnCat.GGFJGHHHEJC.catNPC).gameObject);
		}
		return SpawnCat.GGFJGHHHEJC.InstantiateOnlineCat(relationship, catSelected, catName, birthday).onlineCat;
	}

	public CatMessage(OnlineCat GCAEBEJKJPJ)
		: base(GCAEBEJKJPJ)
	{
		relationship = GCAEBEJKJPJ.catNPC.relationshipSystem.relationshipLevel;
		catSelected = CommonReferences.GGFJGHHHEJC.catSelected.id;
		catName = CommonReferences.GGFJGHHHEJC.catName;
		birthday = new GameDateMessage(GCAEBEJKJPJ.catNPC.birthday);
	}
}
