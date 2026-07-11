using System;

[Flags]
public enum ZoneType
{
	None = 0,
	WithoutZone = 1,
	DiningRoom = 2,
	CraftingRoom = 4,
	RentedRoom = 8,
	Cellar = 0x10,
	WoodWorkshop = 0x20,
	MetalWorkshop = 0x40,
	StoneWorkshop = 0x80,
	RoomPlayer2 = 0x100,
	RoomPlayer3 = 0x200,
	RoomPlayer4 = 0x400,
	AnyWorkArea = 0x7FE,
	Anywhere = 0x7FF
}
