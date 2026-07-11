using System;

[Flags]
public enum WorkerType
{
	None = 0,
	Barworker = 1,
	Waiter = 2,
	HouseKeeper = 4,
	Bouncer = 8
}
