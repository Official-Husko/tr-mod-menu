using System;
using UnityEngine;

public class CityPlaque : MonoBehaviour, IInteractable, IProximity, IHoverable, ISelectable
{
	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool BMLBGBOIOCE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void JJELBOKLMLB(int JIIGOACEIKL)
	{
	}

	public bool INDHAHEONDM(int JIIGOACEIKL)
	{
		return true;
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool DODHNPJFCCD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/RygarStatue");
			return true;
		}
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool AIGDFDEMGNN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool EDDDDEJIEHC(int JIIGOACEIKL)
	{
		return true;
	}

	public bool AENDGJJDOLL(int JIIGOACEIKL)
	{
		return true;
	}

	public void NPPALHNMMEN(int JIIGOACEIKL)
	{
	}

	public void LAEDMIPNGPJ(int JIIGOACEIKL)
	{
	}

	public bool HADFLDNPJFP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !EventTextUI.PCEEOGGDBFB(JIIGOACEIKL).HDEPMJIDJEM())
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("ReceiveAskForRockStartInfo"));
			return false;
		}
		return true;
	}

	public bool FCCIIBFDFKO(int JIIGOACEIKL)
	{
		return false;
	}

	public bool HEOEEFNLJMO(int JIIGOACEIKL)
	{
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool ELGPNJHMHPG(int JIIGOACEIKL)
	{
		return true;
	}

	public void OPGEDAEBKAC(int JIIGOACEIKL)
	{
	}

	public bool Select(int JIIGOACEIKL)
	{
		return false;
	}

	public void PNFKIHGMBLG(int JIIGOACEIKL)
	{
	}

	public bool FKDFHIKHPAG(int JIIGOACEIKL)
	{
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool HCHMAIEMAGA(int JIIGOACEIKL)
	{
		return true;
	}

	public bool NHGDAEOPGOG(int JIIGOACEIKL)
	{
		return true;
	}

	public bool KAHCMAEPNLK(int JIIGOACEIKL)
	{
		return false;
	}

	public bool LIDJEBPBDAH(int JIIGOACEIKL)
	{
		return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool MGIFADFILOI(int JIIGOACEIKL)
	{
		return true;
	}

	public bool AMIIMLAAJEP(int JIIGOACEIKL)
	{
		return true;
	}

	public bool DLFPEGEBKAG(int JIIGOACEIKL)
	{
		return true;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool CIHLILMMMBL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !EventTextUI.Get(JIIGOACEIKL).IsOpen())
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Read"));
			return true;
		}
		return false;
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		return false;
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public bool JBJLOLPICBI(int JIIGOACEIKL)
	{
		return true;
	}

	public bool EHDHLMNCLDA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (LIDJEBPBDAH(JIIGOACEIKL) && !EventTextUI.BBDNJAKIBFN(JIIGOACEIKL).HDEPMJIDJEM())
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Can't select unless we're connected."));
			return false;
		}
		return false;
	}

	public bool NCLHJLNBJIL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool PNHCLGGKBOB(int JIIGOACEIKL)
	{
		return true;
	}

	public bool CMBGCBGADCO(int JIIGOACEIKL)
	{
		return true;
	}

	public bool PLJHIFHNOBD(int JIIGOACEIKL)
	{
		return true;
	}
}
