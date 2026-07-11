using psai.net;

public class PsaiTcSkipIfThemeTypeIsPlaying : PsaiTriggerCondition
{
	public ThemeType themeType = ThemeType.action;

	public override bool EvaluateTriggerCondition()
	{
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo != null)
		{
			ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(psaiInfo.effectiveThemeId);
			if (themeInfo != null)
			{
				return themeInfo.type != themeType;
			}
		}
		return true;
	}
}
