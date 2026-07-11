using UnityEngine;

public abstract class ConstructionUI : UIWindow
{
	public static ConstructionUI current;

	public ConstructionPlayerInfo playerInfo;

	[SerializeField]
	protected Sprite[] buttonAcceptSprites;

	public override void OpenUI()
	{
		DecorationMode.GetPlayer(1).DMBFKFLDDLH = false;
		if (GameManager.LocalCoop())
		{
			DecorationMode.GetPlayer(2).DMBFKFLDDLH = false;
			GameManager.GGFJGHHHEJC.BlockPlayer((base.JIIGOACEIKL != 1) ? 1 : 2);
		}
		current = this;
		base.OpenUI();
		PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
		SelectObject.GetPlayer(base.JIIGOACEIKL).ResetSelected();
		GameActionBarUI.Get(1).CloseUI();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.Get(2).CloseUI();
		}
		TavernManagerUI.HideClockAndTavernInfo();
		Weather.DeactivateSnowParticles();
		MissionsManager.HideObjectivesPanel();
	}

	public override void CloseUI()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)(IsOpen() + " CloseUI ConstructionUI"));
		if (GameManager.LocalCoop())
		{
			int num = ((base.JIIGOACEIKL == 2) ? 1 : 2);
			GameManager.GGFJGHHHEJC.UnblockPlayer(num);
			CameraTarget obj = ((num == 1) ? SceneReferences.GetPlayer1CameraTarget() : SceneReferences.GetPlayer2CameraTarget());
			((Component)obj).transform.position = ((Component)PlayerController.GetPlayer(num)).transform.position;
			((Component)obj.pixelPerfect).transform.position = ((Component)PlayerController.GetPlayer(num)).transform.position;
		}
		base.CloseUI();
		current = null;
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		SelectObject.GetPlayer(1).ResetSelected();
		if (GameManager.LocalCoop())
		{
			SelectObject.GetPlayer(2).ResetSelected();
		}
		GameActionBarUI.Get(1).OpenUI();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.Get(2).OpenUI();
		}
		TavernManagerUI.ShowClockAndTavernInfo();
		Weather.CheckAllWeather();
		MissionsManager.instance.ShowObjectivesPanelIfPossible();
	}

	public abstract void AcceptChanges();
}
