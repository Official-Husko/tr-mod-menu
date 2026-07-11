using System;

[Serializable]
[Flags]
public enum GroundType
{
	None = 0,
	Grass = 1,
	Ground = 2,
	TilledEarth = 4,
	Floor = 8,
	Stone = 0x10,
	Sand = 0x20,
	AllExceptTilledEarth = 0x3B,
	All = 0x3F
}
