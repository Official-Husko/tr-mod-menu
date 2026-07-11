using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class ChristmasTreeMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public bool lightsActive;

	[JsonProperty("2")]
	public bool[] presentsActive;

	public ChristmasTreeMessage(OnlineChristmasTree KIBJPHCBDIO)
		: base(KIBJPHCBDIO)
	{
		lightsActive = KIBJPHCBDIO.christmasTree.lights.activeSelf;
		presentsActive = new bool[KIBJPHCBDIO.christmasTree.presents.Length];
		for (int i = 0; i < KIBJPHCBDIO.christmasTree.presents.Length; i++)
		{
			presentsActive[i] = ((Component)KIBJPHCBDIO.christmasTree.presents[i]).gameObject.activeSelf;
		}
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineChristmasTree onlineChristmasTree)
		{
			onlineChristmasTree.christmasTree.ActivateLights(lightsActive, CDPAMNIPPEC: false);
			for (int i = 0; i < presentsActive.Length; i++)
			{
				onlineChristmasTree.christmasTree.ActivatePresents(presentsActive[i], CDPAMNIPPEC: false);
			}
		}
		return onlineObject;
	}
}
