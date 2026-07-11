using UnityEngine;

[CreateAssetMenu(menuName = "Game/Tavern Construction Action")]
public class TavernConstructionAction : ConstructionAction
{
	public ETavernEditorPanel panel = ETavernEditorPanel.Decoration;

	public TavernFloor tavernFloor = TavernFloor.FirstFloor | TavernFloor.SecondFloor;
}
