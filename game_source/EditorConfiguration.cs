using UnityEngine;

[CreateAssetMenu(menuName = "Game/EditorConfiguration")]
public class EditorConfiguration : ScriptableObject
{
	public bool autoSaveActivated;

	public bool debugTracesActivated;

	public bool loadFirstSaveDataAfterPlay;

	public string[] initialMessageDevConsole;

	public bool loadOnlineAsAMaster;

	public bool loadOnlineAsAGuest;
}
