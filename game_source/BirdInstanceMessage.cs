using System;
using Newtonsoft.Json;

[Serializable]
public class BirdInstanceMessage : ItemInstanceMessage
{
	[JsonProperty("1")]
	public string name;

	[JsonProperty("2")]
	public GameDateMessage birthday;

	[JsonProperty("3")]
	public short birdId;

	[JsonProperty("3")]
	public short birdMaterialId;

	[JsonProperty("4")]
	public short prevSkelBirdId;

	[JsonProperty("4")]
	public short prevSkelBirdMaterialId;

	[JsonProperty("5")]
	public float commentsQuality;

	[JsonProperty("6")]
	public int cookiesGivenPerDay;

	public override void BNBJFAHIMNH(ItemInstance DNLMCHDOMOK)
	{
		base.BNBJFAHIMNH(DNLMCHDOMOK);
		if (DNLMCHDOMOK is BirdInstance birdInstance)
		{
			birdInstance.birdName = name;
			birdInstance.birthday = birthday.JBJLBDHAECK();
			birdInstance.birdId = birdId;
			birdInstance.birdMaterialId = birdMaterialId;
			birdInstance.prevSkelBirdId = prevSkelBirdId;
			birdInstance.prevSkelBirdMaterialId = prevSkelBirdMaterialId;
			birdInstance.commentsQuality = commentsQuality;
			birdInstance.cookiesGivenPerDay = cookiesGivenPerDay;
			birdInstance.PBCCAJOPKEG();
		}
	}

	public BirdInstanceMessage()
	{
	}

	public BirdInstanceMessage(BirdInstance CCDEPALBABD)
		: base(CCDEPALBABD)
	{
		name = CCDEPALBABD.birdName;
		birthday = new GameDateMessage(CCDEPALBABD.birthday);
		birdId = (short)CCDEPALBABD.birdId;
		birdMaterialId = (short)CCDEPALBABD.birdMaterialId;
		prevSkelBirdId = (short)CCDEPALBABD.prevSkelBirdId;
		prevSkelBirdMaterialId = (short)CCDEPALBABD.prevSkelBirdMaterialId;
		commentsQuality = CCDEPALBABD.commentsQuality;
		cookiesGivenPerDay = CCDEPALBABD.cookiesGivenPerDay;
	}
}
