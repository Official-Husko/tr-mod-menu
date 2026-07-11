namespace psai.net;

public class Follower
{
	public float compatibility;

	public int snippetId;

	public Follower()
	{
	}

	public Follower(int id, float compatibility)
	{
		snippetId = id;
		this.compatibility = compatibility;
	}
}
