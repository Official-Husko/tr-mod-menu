using System;

[Flags]
public enum CropSeason
{
	None = 0,
	Spring = 1,
	Summer = 2,
	Autumn = 4,
	Winter = 8,
	All = 0xF
}
