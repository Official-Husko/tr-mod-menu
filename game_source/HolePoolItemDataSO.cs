using UnityEngine;

[CreateAssetMenu(fileName = "HolePoolData", menuName = "Hole Pool/Hole Pool Data")]
public class HolePoolItemDataSO : ScriptableObject
{
	public ItemInHole[] items = new ItemInHole[0];
}
