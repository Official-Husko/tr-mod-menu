using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class AnimalInstanceMessage : ItemInstanceMessage
{
	[JsonProperty("1")]
	public string name;

	[JsonProperty("2")]
	public GameDateMessage birthday;

	[JsonProperty("3")]
	public int[] bodyParts;

	[JsonProperty("4")]
	public int[] materials;

	public AnimalInstanceMessage()
	{
	}

	public override void BNBJFAHIMNH(ItemInstance DNLMCHDOMOK)
	{
		base.BNBJFAHIMNH(DNLMCHDOMOK);
		if (DNLMCHDOMOK is AnimalInstance animalInstance)
		{
			animalInstance.FFCPMICPBIB(name, birthday.JBJLBDHAECK(), bodyParts, materials);
		}
	}

	public AnimalInstanceMessage(AnimalInstance ECMCBNFLHCI)
		: base(ECMCBNFLHCI)
	{
		name = ECMCBNFLHCI.animalName;
		birthday = new GameDateMessage(ECMCBNFLHCI.birthday);
		bodyParts = new int[4];
		materials = new int[4];
		int num = 0;
		foreach (AnimalPart value2 in Enum.GetValues(typeof(AnimalPart)))
		{
			if (ECMCBNFLHCI.bodyPartsIds.TryGetValue(value2, out var value))
			{
				bodyParts[num] = value;
			}
			else
			{
				bodyParts[num] = -1;
			}
			num++;
		}
		num = 0;
		foreach (KeyValuePair<AnimalPart, int> materialsId in ECMCBNFLHCI.materialsIds)
		{
			materials[num] = materialsId.Value;
			num++;
		}
	}
}
