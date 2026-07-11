using UnityEngine;

[CreateAssetMenu(fileName = "MinePuzzleConfig_Level", menuName = "Mine/Puzzle Config")]
public class MinePuzzleConfig : ScriptableObject
{
	[Tooltip("Mine level this config applies to")]
	public int mineLevel = 1;

	[Tooltip("Overall probability that a puzzle will be generated on this level")]
	[Range(0f, 100f)]
	public int puzzleProbability = 100;

	public RewardEntry reward;

	public Price minPriceReward;

	public Price maxPriceReward;

	[Tooltip("Puzzles available in this level")]
	public PuzzleWeightEntry[] availablePuzzles;

	[Space(10f)]
	public TorchPuzzleSettings torchSettings;

	public PipePuzzleSettings pipeSettings;

	public KeyFragmentsPuzzleSettings keySettings;

	public FountainsPuzzleSettings fountainsSettings;

	public ButtonPressPuzzleSettings buttonPressSettings;

	public StatuePuzzleSettings statueSettings;

	public ChessPillarPuzzleSettings chessPillarSettings;

	public CrystalPuzzleSettings crystalPuzzleSettings;

	public OfferingPuzzleSettings offeringSettings;
}
