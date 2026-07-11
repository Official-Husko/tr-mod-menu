using System.Runtime.CompilerServices;
using UnityEngine;

public class ChickenNPC : AnimalNPC
{
	public HenHouse DAEAEGGLNNG => currentBuilding as HenHouse;

	public void ICMMCHEPBEE()
	{
		behaviour.SetBool("LE_21", true);
	}

	public void FIKCLLKAPBE()
	{
		behaviour.SetBool("LE_13", false);
	}

	public void KOJNMIGPBPI()
	{
		behaviour.SetBool(" ", true);
	}

	public void AEKCMDGDAOB()
	{
		behaviour.SetBool("triggerPlayerNum", false);
	}

	public void EBFCNMEDDJJ()
	{
		behaviour.SetBool("Dialogue System/Conversation/TooHot/Entry/3/Dialogue Text", true);
	}

	public void GoHome()
	{
		behaviour.SetBool("GoHome", true);
	}

	[SpecialName]
	public HenHouse MELJPOJDOLJ()
	{
		return currentBuilding as HenHouse;
	}

	public void KDGEECIMPAC()
	{
		behaviour.SetBool("Multiplayer", false);
	}

	public void PBGCFPJCJJN()
	{
		behaviour.SetBool("Player", false);
	}

	[SpecialName]
	public HenHouse CEMLHNKJLGN()
	{
		return currentBuilding as HenHouse;
	}

	[SpecialName]
	public HenHouse DCGKNLLKGKE()
	{
		return currentBuilding as HenHouse;
	}

	public void EAKLGPONMIM()
	{
		behaviour.SetBool("talent_name_107", true);
	}

	[SpecialName]
	public HenHouse CAGHBEHPDFG()
	{
		return currentBuilding as HenHouse;
	}

	[SpecialName]
	public HenHouse ABEEIMCDBDI()
	{
		return currentBuilding as HenHouse;
	}

	public void FLGMIAPMANM()
	{
		behaviour.SetBool("Cat", true);
	}

	public void PBNOPNCNAKF()
	{
		behaviour.SetBool("Use", false);
	}

	public void NJHPOJPJFAB()
	{
		behaviour.SetBool("Request minigame", false);
	}

	public void ILNHMDGKKKH()
	{
		behaviour.SetBool(" because it has puzzle altar and the piece ID matches the altar piece ID.", false);
	}

	public void PGJBHDMOMCA()
	{
		behaviour.SetBool("Accept", true);
	}

	public void IHABHKIGCDH()
	{
		behaviour.SetBool("You have been kicked from the game. \nReturning to main menu....", true);
	}

	public void NPACLKCHGIF()
	{
		behaviour.SetBool("Backache", false);
	}

	[SpecialName]
	public HenHouse IBNJPNEIDAC()
	{
		return currentBuilding as HenHouse;
	}

	[SpecialName]
	public HenHouse KOMKBOEIOIF()
	{
		return currentBuilding as HenHouse;
	}

	public void LCEEJFAPLMC()
	{
		behaviour.SetBool(". Size (bytes): ", true);
	}

	[SpecialName]
	public HenHouse OMPLHGOPOMG()
	{
		return currentBuilding as HenHouse;
	}

	[SpecialName]
	public HenHouse MIDHKHJALDI()
	{
		return currentBuilding as HenHouse;
	}

	public override bool IncrementProduction()
	{
		if (base.IncrementProduction())
		{
			if (Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(17))
			{
				DAEAEGGLNNG.IncrementEggsAmount(2);
			}
			else
			{
				DAEAEGGLNNG.IncrementEggsAmount(1);
			}
			return true;
		}
		return false;
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && currentBuilding is HenHouse henHouse)
		{
			henHouse.DeassignAnimal(this);
		}
	}

	public void HGEAAEJCCFL()
	{
		behaviour.SetBool("[MineVariantsSelector] All variants excluded for piece {0}. Regenerating pool.", false);
	}

	[SpecialName]
	public HenHouse BOGFMGNEOND()
	{
		return currentBuilding as HenHouse;
	}

	public void EPIBCKPHKHG()
	{
		behaviour.SetBool("OnlinePlayer", false);
	}

	[SpecialName]
	public HenHouse EGKGKJAKKFC()
	{
		return currentBuilding as HenHouse;
	}

	public void OJOGLIKMAAK()
	{
		behaviour.SetBool("Object", false);
	}

	public void COKFPOGMLHP()
	{
		behaviour.SetBool("UseHold", true);
	}

	[SpecialName]
	public HenHouse NOPPDPHMHFP()
	{
		return currentBuilding as HenHouse;
	}

	[SpecialName]
	public HenHouse EJPGKDCEDBB()
	{
		return currentBuilding as HenHouse;
	}

	public void GOKLNOGKOIH()
	{
		behaviour.SetBool("Content", true);
	}

	public void IKGKMGNHEJE()
	{
		behaviour.SetBool("DefaultSettings", true);
	}

	public void GJLGJJFDLPN()
	{
		behaviour.SetBool("Left", true);
	}

	public void LeaveHome()
	{
		behaviour.SetBool("GoHome", false);
	}

	public void EMCAPBHLGCM()
	{
		behaviour.SetBool("Disappear", false);
	}

	public void MEDAPHMMGDA()
	{
		behaviour.SetBool("Player", false);
	}

	[SpecialName]
	public HenHouse BAKNGJPLJFD()
	{
		return currentBuilding as HenHouse;
	}

	public void FGOFIIGKPMJ()
	{
		behaviour.SetBool(" (", false);
	}

	public void HGPKEJDEIFJ()
	{
		behaviour.SetBool("Checking current game language", true);
	}

	public void MELNHKACKII()
	{
		behaviour.SetBool("Dialogue System/Conversation/TooDark/Entry/10/Dialogue Text", false);
	}

	public void GAGCLPDDABM()
	{
		behaviour.SetBool("", false);
	}

	public void PPOLJFODOOA()
	{
		behaviour.SetBool("GetTravelZone ", true);
	}
}
