using UnityEngine;

namespace Mine;

public class ExplosiveCharges : MonoBehaviour, IProximity, IInteractable, IHoverable
{
	public Animator animator;

	public bool lit;

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void BOHBDMHDIDC(int JIIGOACEIKL)
	{
	}

	public void EGOCPOHOGOI()
	{
		lit = true;
		animator.SetTrigger(" ");
	}

	public bool JMLPFPAFPGE(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			MineManager.AGGAGCBAGLL().IAKICBAOCCO(CDPAMNIPPEC: false);
			return false;
		}
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Light fuse"));
			return true;
		}
		return false;
	}

	public void FGKKKMFELJH(int JIIGOACEIKL)
	{
	}

	public bool FNJHKKPGJFC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void GLMJJDOMPGH(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public bool GFMLDGEKMHA(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			MineManager.AGGAGCBAGLL().ExplodeCharges(CDPAMNIPPEC: false);
			return true;
		}
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool CanExplode()
	{
		return !lit;
	}

	public bool BAGPKDFCDPN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void CPOLPCDNPPH(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (CanExplode())
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public void AAGHEBFMDFM()
	{
		lit = false;
		animator.SetTrigger("ItemInstance is not valid.");
	}

	public bool NCMFIAHEIOH(int JIIGOACEIKL)
	{
		return false;
	}

	public bool EALAGAKPKFF(int JIIGOACEIKL)
	{
		return true;
	}

	public bool FHFFNFECPKB(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			MineManager.OOKBNHMMFON().IAKICBAOCCO(CDPAMNIPPEC: false);
			return true;
		}
		return true;
	}

	public bool DEEFMMKDBJB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Disabled"));
			return true;
		}
		return false;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			MineManager.GGFJGHHHEJC.ExplodeCharges();
			return true;
		}
		return false;
	}

	public bool AFAKDGJEKFG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool KPMGMIBPGEF(int JIIGOACEIKL)
	{
		return true;
	}

	public bool CKHHGCILKKK(int JIIGOACEIKL)
	{
		if (CanExplode())
		{
			return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return true;
	}

	public bool DODHNPJFCCD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool FCLFHOFIJAK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool CCHCKHEDBII(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool LCDFJODPNGJ(int JIIGOACEIKL)
	{
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void FireWick()
	{
		lit = true;
		animator.SetTrigger("Explosion");
	}

	public bool KALPPLBBBKH()
	{
		return lit;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void PGOIMGKKPAP(int JIIGOACEIKL)
	{
	}

	public bool DFHNFGMFGLH(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			MineManager.BGMJCCFNNDL().ExplodeCharges();
			return true;
		}
		return false;
	}

	public void JHNPGLNAFNL(int JIIGOACEIKL)
	{
	}

	public bool BANJNCOOACM(int JIIGOACEIKL)
	{
		if (CanExplode())
		{
			return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return false;
	}

	public bool DAGCKCKKKCJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KLNHOHEDAFN(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("LE_22"));
			return false;
		}
		return true;
	}

	public bool KLNHOHEDAFN(int JIIGOACEIKL)
	{
		if (KALPPLBBBKH())
		{
			return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IBEFDKHFBFM();
		}
		return false;
	}

	public bool ANLNJIGAEJM(int JIIGOACEIKL)
	{
		if (CanExplode())
		{
			return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return true;
	}

	public bool CLLBNHNONKK(int JIIGOACEIKL)
	{
		if (CKHHGCILKKK(JIIGOACEIKL))
		{
			MineManager.OOKBNHMMFON().IAKICBAOCCO();
			return false;
		}
		return true;
	}
}
