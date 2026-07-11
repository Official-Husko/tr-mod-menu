using UnityEngine;

[CreateAssetMenu(menuName = "Game/Input/DualShockInfo")]
public class DualShockInfo : ControllerInfo
{
	public Sprite cross;

	public Sprite circle;

	public Sprite square;

	public Sprite triangle;

	public Sprite L1;

	public Sprite R1;

	public Sprite L2;

	public Sprite R2;

	public Sprite share;

	public Sprite options;

	public override Sprite GLOIGJFJGME(string OLPHMLONLAE)
	{
		return (Sprite)(OLPHMLONLAE switch
		{
			"Cross" => cross, 
			"Circle" => circle, 
			"Square" => square, 
			"Triangle" => triangle, 
			"L1" => L1, 
			"R1" => R1, 
			"L2" => L2, 
			"R2" => R2, 
			"Share" => share, 
			"Options" => options, 
			_ => base.GLOIGJFJGME(OLPHMLONLAE), 
		});
	}
}
