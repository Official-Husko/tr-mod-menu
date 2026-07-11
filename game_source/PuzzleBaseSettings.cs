using System;

[Serializable]
public class PuzzleBaseSettings
{
	public bool overrideRewards;

	public RewardEntry reward;

	public Price minPriceReward;

	public Price maxPriceReward;
}
