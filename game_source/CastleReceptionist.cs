using UnityEngine;

public class CastleReceptionist : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	public static CastleReceptionist instance;

	public OnlineObject onlineObject;

	public bool HOCCIDFOPHN(int JIIGOACEIKL)
	{
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool BBAFEKJIALK(int JIIGOACEIKL)
	{
		if (HEOEEFNLJMO(JIIGOACEIKL))
		{
			return PEPBHOPBLON(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(onlineObject);
		}
		return false;
	}

	public void COMGONICNIN(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			return LFONIBMMHOB(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(onlineObject);
		}
		return false;
	}

	private void KHCJDKHONPK()
	{
		instance = this;
	}

	public bool KOLGJHCLPNE(int JIIGOACEIKL)
	{
		return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public void OGJIHMFODNC(int JIIGOACEIKL)
	{
	}

	public bool DAGCKCKKKCJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HOCCIDFOPHN(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("SceneReferences Awake"));
			return false;
		}
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool CNCFMOJHNID(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HEOEEFNLJMO(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("LevelAbbreviation"));
			return true;
		}
		return true;
	}

	public bool IFGFOAAKBCF(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(onlineObject.uniqueId);
				return false;
			}
			return LFONIBMMHOB(JIIGOACEIKL);
		}
		return true;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(onlineObject.uniqueId);
				return false;
			}
			return LFONIBMMHOB(JIIGOACEIKL);
		}
		return false;
	}

	public bool PBPIJOAIGII(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private bool LFONIBMMHOB(int JIIGOACEIKL)
	{
		ChallengesUI.Get(JIIGOACEIKL).OpenUI();
		return true;
	}

	public void FIGONJNMELG(int JIIGOACEIKL)
	{
	}

	private bool NCAGODJNPND(int JIIGOACEIKL)
	{
		ChallengesUI.Get(JIIGOACEIKL).EDHEIFHAAKO();
		return true;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool APFAKKDDFIK(int JIIGOACEIKL)
	{
		if (HOCCIDFOPHN(JIIGOACEIKL))
		{
			return PEPBHOPBLON(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(onlineObject);
		}
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private bool DAGLBADLIBE(int JIIGOACEIKL)
	{
		ChallengesUI.MHOKIBDMIPL(JIIGOACEIKL).EDHEIFHAAKO();
		return false;
	}

	public static bool IsValid()
	{
		return (Object)(object)instance != (Object)null;
	}

	public void CDNPCGKAGLI(int JIIGOACEIKL)
	{
	}

	public bool HGBEJIIANJP(int JIIGOACEIKL)
	{
		return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public void DAFFDEDGGCL(int JIIGOACEIKL)
	{
	}

	public void MJPOHFEDIHI(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void OHONHNNDOKC(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			return true;
		}
		return false;
	}

	public static bool KHFBKLDDGEG()
	{
		return (Object)(object)instance != (Object)null;
	}

	public bool NKHLGGKOKKA(int JIIGOACEIKL)
	{
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public static Vector3 GetPosition()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)instance).transform.position;
	}

	public bool KBNLCICAOCI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool BKNDGGLINDD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HEOEEFNLJMO(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("OnCustomerEnter"));
			return true;
		}
		return true;
	}

	private bool PEPBHOPBLON(int JIIGOACEIKL)
	{
		ChallengesUI.GJOPJAJJLGN(JIIGOACEIKL).IDLAGJNLPJL();
		return true;
	}

	private void CEOEHODJAJK()
	{
		instance = this;
	}

	public bool HEOEEFNLJMO(int JIIGOACEIKL)
	{
		return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IBEFDKHFBFM();
	}

	private void GFLFDLIMOLI()
	{
		instance = this;
	}

	public bool ACLPKJGGPFD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public static Vector3 KIDOKCIDHJD()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)instance).transform.position;
	}

	private void Awake()
	{
		instance = this;
	}

	public bool JMLPFPAFPGE(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(onlineObject.uniqueId);
				return true;
			}
			return LFONIBMMHOB(JIIGOACEIKL);
		}
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool BNPJHDGDFOF(int JIIGOACEIKL)
	{
		if (NKHLGGKOKKA(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.GMJPOKECENH(onlineObject.uniqueId);
				return false;
			}
			return DAGLBADLIBE(JIIGOACEIKL);
		}
		return false;
	}
}
