public class UISoloWindow : UIWindow
{
	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			MainUI.JOHIBMAAEBH = this;
		}
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			base.CloseUI();
			MainUI.JOHIBMAAEBH = null;
		}
	}
}
