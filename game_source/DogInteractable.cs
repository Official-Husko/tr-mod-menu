using System.Collections.Generic;
using UnityEngine;

public class DogInteractable : MonoBehaviour
{
	public static List<DogInteractable> ActiveInteractables = new List<DogInteractable>();

	public float interactionMinTime = 8f;

	public float interactionMaxTime = 14f;

	public float interactionCooldown = 10f;

	public Transform interactionPoint;

	public Direction lookDirection;

	public DogNPC.DogInteractionType interactionType;

	private float EPAGDNOJECE = float.NegativeInfinity;

	public void KEKAPONBLAM()
	{
		EPAGDNOJECE = Time.time;
	}

	public void BIGIBDEHIMI()
	{
		EPAGDNOJECE = Time.time;
	}

	private void HCKMHIHALBL()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	public void GMLEEEOKJJJ()
	{
		EPAGDNOJECE = Time.time;
	}

	public void FCOPKMDLAMD()
	{
		EPAGDNOJECE = Time.time;
	}

	public bool DGBOKEDLJBG()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1251f)
		{
			return true;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	public void DLLBNBBLKIG()
	{
		EPAGDNOJECE = Time.time;
	}

	public void ANLGABMAFEF()
	{
		EPAGDNOJECE = Time.time;
	}

	public bool HMOPKMLCHKB()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 391f)
		{
			return true;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	private void LGJLKGKACAO()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	public void OHIJCAIJLMJ()
	{
		EPAGDNOJECE = Time.time;
	}

	private void GJJPNFHFBFP()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	public bool GEHODJHKOIB()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1946f)
		{
			return true;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	public bool KCEFENJKPCP()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1688f)
		{
			return true;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	private void OnEnable()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	public bool CFGPNLDHNAH()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1484f)
		{
			return false;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	private void KJOCGLKMMOM()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	private void MPMGGLKFMNJ()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	public bool COIMMAJLGLJ()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 950f)
		{
			return false;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	private void MNEAOFNAKIP()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	public bool BCOOLGHBLFB()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1523f)
		{
			return true;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	public void PGGFIBLDPBP()
	{
		EPAGDNOJECE = Time.time;
	}

	public void BNEAIGOMEGB()
	{
		EPAGDNOJECE = Time.time;
	}

	private void PMMGCDBMMMN()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	private void LCJCGFNFBBD()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	public void MOLNIAEDFAA()
	{
		EPAGDNOJECE = Time.time;
	}

	public bool FNKLCFIFPFI()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 660f)
		{
			return false;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	public bool OBIGGLMIJLJ()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1372f)
		{
			return true;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	private void GNIBPOBGDNC()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	private void OnDisable()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	public bool CanInteract()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 7f)
		{
			return false;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	public bool PFEFKINNIAN()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1808f)
		{
			return true;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	public bool EFJKOJHKLJP()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 628f)
		{
			return true;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	public bool FDONPLAFGPD()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 237f)
		{
			return false;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	private void CJDJDDNCNDJ()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	private void FGLCNIOLKKL()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	private void LAIKKHJKPNG()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	private void AFGJLAACCFN()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	private void JMJDHLOMKAP()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	private void OBLCKPMAADM()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	public bool GNBDEMPJHEE()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1184f)
		{
			return true;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	private void IJNPEAAOOEK()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	private void MMAMJDLONFA()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	public bool GEGKKAKHNAE()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1854f)
		{
			return true;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	public bool OPKKEHCDJJH()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1803f)
		{
			return true;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	public bool NOJODNMFBIH()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1529f)
		{
			return true;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	private void ADGMAKKMINA()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	private void FINKPIHPHDE()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	public bool GNJBOJOAHGA()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1199f)
		{
			return false;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	public bool EDAJIEBIMOK()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1900f)
		{
			return false;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	private void OHOHFGMJGAJ()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	private void GFPIEOPHABO()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	public void KKMNKLDBLAL()
	{
		EPAGDNOJECE = Time.time;
	}

	private void EDBDJLPHGGJ()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	public void CNEBINEPAGC()
	{
		EPAGDNOJECE = Time.time;
	}

	private void ODBKBMCMFNB()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	public void LCJOGNCDFLI()
	{
		EPAGDNOJECE = Time.time;
	}

	private void JPJDFHEANJH()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	private void CCJOOMDHMKM()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	private void FCGJBDGOHPN()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	private void AMHGMJDKONK()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	public void GLBNBBMCPCE()
	{
		EPAGDNOJECE = Time.time;
	}

	public void IFJBOIPLDMM()
	{
		EPAGDNOJECE = Time.time;
	}

	private void IJMBEEEGCGF()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	public void KPHKIIODOMD()
	{
		EPAGDNOJECE = Time.time;
	}

	public bool HIKJENLFLNP()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 30f)
		{
			return true;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	private void CHDGJHNBNEJ()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	private void NJKHCOHADCL()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	public void PDCKFIGHNDA()
	{
		EPAGDNOJECE = Time.time;
	}

	public void KLPGHHFGNCH()
	{
		EPAGDNOJECE = Time.time;
	}

	private void EEAKGHLCFOM()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	public void OEHPMJEHGCC()
	{
		EPAGDNOJECE = Time.time;
	}

	private void HHHEACKHADN()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	public void EJNEPNMEIML()
	{
		EPAGDNOJECE = Time.time;
	}

	private void MHENLAGHFOD()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	public void NNOEMCCLFGD()
	{
		EPAGDNOJECE = Time.time;
	}

	private void MAEGGDLLHBG()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	private void IILOKDBOODL()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}

	private void MEFFGGKAALB()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	public void EDEMCFEBJJA()
	{
		EPAGDNOJECE = Time.time;
	}

	public bool NIKEOCIABLE()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DogNPC.instance.playerFollowing == (Object)null || Vector3.Distance(((Component)DogNPC.instance.playerFollowing).transform.position, interactionPoint.position) > 1069f)
		{
			return false;
		}
		return Time.time - EPAGDNOJECE > interactionCooldown;
	}

	public void FIJHCCCOEDD()
	{
		EPAGDNOJECE = Time.time;
	}

	private void LEPDLPEPEFD()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	public void MarkInteracted()
	{
		EPAGDNOJECE = Time.time;
	}

	private void JNDFLHEMOBG()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	public void EKELDLDEKML()
	{
		EPAGDNOJECE = Time.time;
	}

	private void KCOFAJBKHAO()
	{
		if (!ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Add(this);
		}
	}

	private void EGHFDLCNPNC()
	{
		if (ActiveInteractables.Contains(this))
		{
			ActiveInteractables.Remove(this);
		}
	}
}
