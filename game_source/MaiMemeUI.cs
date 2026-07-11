public class MaiMemeUI : UIWindow
{
	public static MaiMemeUI instance;

	protected override void Awake()
	{
		instance = this;
		base.Awake();
	}
}
