namespace psai.net;

public class PsaiInfo
{
	public PsaiState psaiState;

	public PsaiState upcomingPsaiState;

	public int lastBasicMoodThemeId;

	public int effectiveThemeId;

	public int upcomingThemeId;

	public float currentIntensity;

	public float upcomingIntensity;

	public int themesQueued;

	public int targetSegmentId;

	public bool intensityIsHeld;

	public bool returningToLastBasicMood;

	public int remainingMillisecondsInRestMode;

	public bool paused;
}
