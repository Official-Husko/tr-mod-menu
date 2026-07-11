using System;

[Flags]
public enum PuzzleSpawnerType
{
	Torch = 1,
	Pipes = 2,
	Crystal = 4,
	ChessPillar = 8,
	Statue = 0x10,
	Pressure = 0x20,
	Mirror = 0x40,
	KeyFragments = 0x80,
	Offering = 0x100,
	Fountains = 0x200,
	Symbol = 0x400,
	Altar = 0x800
}
