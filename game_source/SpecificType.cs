using System;

[Flags]
public enum SpecificType
{
	None = 0,
	CellarDoor = 1,
	Door = 2,
	RoomDoor = 4,
	StairsUp = 8,
	Bar = 0x10,
	PlayerBed = 0x20,
	NextToWall = 0x40,
	StairsDown = 0x80,
	Table = 0x100,
	Seat = 0x200,
	ServiceBarrel = 0x400
}
