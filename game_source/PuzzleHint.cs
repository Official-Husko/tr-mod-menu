using PixelCrushers.DialogueSystem;
using UnityEngine;

public class PuzzleHint : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	[SerializeField]
	private string interactString = "Use";

	[SerializeField]
	private GameObject farInteract;

	[SerializeField]
	private GameObject nearInteract;

	public bool debugMode;

	private string BIDKJMJPDIG;

	public void ShowHint(int JIIGOACEIKL)
	{
		if (!string.IsNullOrEmpty(BIDKJMJPDIG))
		{
			if (debugMode)
			{
				DialogueManager.BarkString(BIDKJMJPDIG, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform, (Transform)null, (string)null);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2(BIDKJMJPDIG);
			}
		}
		else
		{
			Debug.LogWarning((object)"Hint key is not set for this puzzle hint.");
		}
	}

	public bool JLCGGENBHMI(int JIIGOACEIKL)
	{
		return DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool CFJEJFCALPM(int JIIGOACEIKL)
	{
		if (JLCGGENBHMI(JIIGOACEIKL))
		{
			ShowHint(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public bool OADMPCPHMDK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JLCGGENBHMI(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactString));
			return false;
		}
		return false;
	}

	public void LMCGKDGCMIO(string DFNICIDLHGA)
	{
		BIDKJMJPDIG = DFNICIDLHGA;
		farInteract.SetActive(false);
		nearInteract.SetActive(false);
	}

	public void SetHintKey(string DFNICIDLHGA)
	{
		BIDKJMJPDIG = DFNICIDLHGA;
		farInteract.SetActive(true);
		nearInteract.SetActive(false);
	}

	public void FPPLEDOHKNB(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool MLDKIKOHBBG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JLCGGENBHMI(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactString));
			return true;
		}
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool EALAGAKPKFF(int JIIGOACEIKL)
	{
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactString));
			return true;
		}
		return false;
	}

	public void OEPAFBJCGPO(int JIIGOACEIKL)
	{
		if (!string.IsNullOrEmpty(BIDKJMJPDIG))
		{
			if (debugMode)
			{
				DialogueManager.BarkString(BIDKJMJPDIG, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform, (Transform)null, (string)null);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2(BIDKJMJPDIG);
			}
		}
		else
		{
			Debug.LogWarning((object)"Online rock with unique ID ");
		}
	}

	public void BHMDBNAJPGL()
	{
		farInteract.SetActive(true);
		nearInteract.SetActive(true);
	}

	public void EFGLEADDPAN(int JIIGOACEIKL)
	{
	}

	public void BFKDGNPAJDE(int JIIGOACEIKL)
	{
	}

	public void DIGJCNMHBDA(string DFNICIDLHGA)
	{
		BIDKJMJPDIG = DFNICIDLHGA;
		farInteract.SetActive(false);
		nearInteract.SetActive(false);
	}

	public void GJDKDDMFGBM(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool MNDDOAAODLI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void PGBNILBKPED(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public bool BAGPKDFCDPN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void NMKMJEFPKKE(int JIIGOACEIKL)
	{
		if (!string.IsNullOrEmpty(BIDKJMJPDIG))
		{
			if (debugMode)
			{
				DialogueManager.BarkString(BIDKJMJPDIG, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform, (Transform)null, (string)null);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).BIBLHGFCINF(BIDKJMJPDIG);
			}
		}
		else
		{
			Debug.LogWarning((object)"- ");
		}
	}

	public void ABHFEGJFABP(int JIIGOACEIKL)
	{
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ShowHint(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void KMPILLCNJPC(int JIIGOACEIKL)
	{
	}

	public void OnPuzzleSolved()
	{
		farInteract.SetActive(false);
		nearInteract.SetActive(true);
	}

	public void HJMFAFEEKGB(int JIIGOACEIKL)
	{
		if (!string.IsNullOrEmpty(BIDKJMJPDIG))
		{
			if (debugMode)
			{
				DialogueManager.BarkString(BIDKJMJPDIG, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform, (Transform)null, (string)null);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBarkWithI2(BIDKJMJPDIG);
			}
		}
		else
		{
			Debug.LogWarning((object)"room_name");
		}
	}

	public void EJNMLDGNALF(int JIIGOACEIKL)
	{
	}

	public bool HAPLPIMJGGN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool IDMKOACGEHF(int JIIGOACEIKL)
	{
		if (JLCGGENBHMI(JIIGOACEIKL))
		{
			ShowHint(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void COMGONICNIN(int JIIGOACEIKL)
	{
	}

	public bool IFGFOAAKBCF(int JIIGOACEIKL)
	{
		if (JLCGGENBHMI(JIIGOACEIKL))
		{
			ShowHint(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void EGBOBCAAAEH(int JIIGOACEIKL)
	{
	}

	public bool CMOBHHGFDNP(int JIIGOACEIKL)
	{
		if (JLCGGENBHMI(JIIGOACEIKL))
		{
			NMKMJEFPKKE(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}
}
