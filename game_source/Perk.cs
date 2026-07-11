using UnityEngine;

public abstract class Perk : ScriptableObject
{
	public int id;

	public bool active = true;

	public Sprite icon;

	public Sprite greyIcon;

	public string description;

	public int[] values;

	protected static string improvementColor = "<color=#4499FF>";

	public int EJHFKKDHCAG(int EONJGMONIOM)
	{
		if (EONJGMONIOM < values.Length)
		{
			return values[EONJGMONIOM];
		}
		return 0;
	}
}
