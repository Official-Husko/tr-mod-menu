using System;

[Serializable]
public struct PerkInfoMsg
{
	public byte id;

	public byte currentLevel;

	public byte levelsUnlocked;

	public PerkInfoMsg(EmployeePerkInfo ENCCNEGPNAB)
	{
		id = (byte)ENCCNEGPNAB.perk.id;
		currentLevel = (byte)ENCCNEGPNAB.currentLevel;
		levelsUnlocked = (byte)ENCCNEGPNAB.levelsUnlocked;
	}
}
