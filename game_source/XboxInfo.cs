using UnityEngine;

[CreateAssetMenu(menuName = "Game/Input/XboxInfo")]
public class XboxInfo : ControllerInfo
{
	public Sprite A;

	public Sprite B;

	public Sprite Y;

	public Sprite X;

	public Sprite leftShoulder;

	public Sprite rightShoulder;

	public Sprite leftTrigger;

	public Sprite rightTrigger;

	public Sprite Back;

	public Sprite Start;

	public override Sprite GLOIGJFJGME(string OLPHMLONLAE)
	{
		return (Sprite)(OLPHMLONLAE switch
		{
			"A" => A, 
			"B" => B, 
			"Y" => Y, 
			"X" => X, 
			"Left Shoulder" => leftShoulder, 
			"Right Shoulder" => rightShoulder, 
			"Left Trigger" => leftTrigger, 
			"Right Trigger" => rightTrigger, 
			"Back" => Back, 
			"Start" => Start, 
			_ => base.GLOIGJFJGME(OLPHMLONLAE), 
		});
	}
}
