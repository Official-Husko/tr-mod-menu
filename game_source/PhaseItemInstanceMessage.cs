using System;
using Newtonsoft.Json;

[Serializable]
public class PhaseItemInstanceMessage : ItemInstanceMessage
{
	[JsonProperty("1")]
	public short phaseNum;

	[JsonProperty("2")]
	public float remainingTime;

	public PhaseItemInstanceMessage()
	{
	}

	public PhaseItemInstanceMessage(PhaseItemInstance LGFLFFGGBDK)
		: base(LGFLFFGGBDK)
	{
		phaseNum = (short)LGFLFFGGBDK.BDAKJBMGIMO;
		remainingTime = LGFLFFGGBDK.remainingTime;
	}

	public override void BNBJFAHIMNH(ItemInstance DNLMCHDOMOK)
	{
		base.BNBJFAHIMNH(DNLMCHDOMOK);
		if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.BDAKJBMGIMO = phaseNum;
			phaseItemInstance.remainingTime = remainingTime;
		}
	}
}
