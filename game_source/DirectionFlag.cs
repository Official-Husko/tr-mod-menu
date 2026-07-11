using System;

[Flags]
public enum DirectionFlag
{
	None = 0,
	Right = 1,
	Left = 2,
	Up = 4,
	Down = 8,
	All = 0xF
}
