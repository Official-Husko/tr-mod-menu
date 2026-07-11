using UnityEngine;

[CreateAssetMenu(menuName = "Game/Language")]
public class GameLanguage : ScriptableObject
{
	public int id;

	public string name;

	public string localisedName;

	public string text;

	public Sprite flag;

	public int spreadSheetIndex;

	public bool useIMEComposition;

	public bool communityTranslation;
}
