using System;

[Serializable]
public struct GridInfo
{
	public GroundType groundTypeAllowed;

	public bool checkCropNotAvailable;

	public bool checkCropAvailable;

	public bool checkWithoutHerbs;

	public bool checkCanPlaceObjects;

	public bool checkWithoutSnow;
}
