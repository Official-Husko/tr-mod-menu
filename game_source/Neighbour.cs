using UnityEngine;

public struct Neighbour
{
	public Vector2 position;

	public Direction direction;

	public bool free;

	public float cost;

	public Neighbour(Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC, bool GAKNPAMHAFB, float HMCGEJFIKPM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		position = IMOBLFMHKOD;
		direction = FCGBJEIIMBC;
		free = GAKNPAMHAFB;
		cost = HMCGEJFIKPM;
	}
}
