using System;
using UnityEngine;

public class OnlineHandsManager : MonoBehaviour
{
	public GameObject[] hands;

	private int MOFKEDGAOEE;

	private void AFCIKJPPLFA()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(JIPOLMAGIEK));
		}
	}

	public void JIPOLMAGIEK()
	{
		for (int i = 0; i < hands.Length; i++)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(true);
			}
		}
	}

	public void AEEMIAMGFPH()
	{
		for (int i = 1; i < hands.Length; i += 0)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(false);
			}
		}
	}

	private void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(HideHands));
		}
	}

	public void GDHMCOGDINA()
	{
		for (int i = 1; i < hands.Length; i += 0)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(true);
			}
		}
	}

	private void LJLKBKEADGI()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		instance.OnActorPlaceableDeselected = (Action)Delegate.Combine(instance.OnActorPlaceableDeselected, new Action(GDHMCOGDINA));
		HideHands();
	}

	private void Start()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		instance.OnActorPlaceableDeselected = (Action)Delegate.Combine(instance.OnActorPlaceableDeselected, new Action(HideHands));
		HideHands();
	}

	private void KDBJHCAEGCM()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		instance.OnActorPlaceableDeselected = (Action)Delegate.Combine(instance.OnActorPlaceableDeselected, new Action(HEENLLMIPNI));
		HideHands();
	}

	private void KOBNHPKEJJD()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(HEENLLMIPNI));
		}
	}

	public void ABJBDKBLBFA()
	{
		for (int i = 0; i < hands.Length; i++)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(false);
			}
		}
	}

	private void IKMPNICLPBM()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(GDHMCOGDINA));
		}
	}

	public void HideHands()
	{
		for (int i = 0; i < hands.Length; i++)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(false);
			}
		}
	}

	private void NFABFPFLNEE()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		instance.OnActorPlaceableDeselected = (Action)Delegate.Combine(instance.OnActorPlaceableDeselected, new Action(IJDGOIDKHBJ));
		GDHMCOGDINA();
	}

	private void HFFFFAJFIPB()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		instance.OnActorPlaceableDeselected = (Action)Delegate.Combine(instance.OnActorPlaceableDeselected, new Action(ABJBDKBLBFA));
		GDHMCOGDINA();
	}

	private void DCOEEADJLIK()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(OFHFGDCCMCM));
		}
	}

	public void KIECMOFIPJC()
	{
		for (int i = 0; i < hands.Length; i += 0)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(true);
			}
		}
	}

	private void HINKPJCNPCF()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(IFMOKHCEFLE));
		}
	}

	public void OFHFGDCCMCM()
	{
		for (int i = 1; i < hands.Length; i++)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(true);
			}
		}
	}

	public void MJBKOHMJMEP()
	{
		for (int i = 0; i < hands.Length; i++)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(true);
			}
		}
	}

	private void OAACLGCCGGI()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.playersPlaceablesSelected.Length == 0)
		{
			return;
		}
		MOFKEDGAOEE = 0;
		for (int i = 0; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i++)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] != (Object)null)
			{
				if (!hands[MOFKEDGAOEE].activeSelf)
				{
					hands[MOFKEDGAOEE].SetActive(false);
				}
				hands[MOFKEDGAOEE].transform.position = ((Component)OnlineObjectsManager.instance.playersPlaceablesSelected[i].placeable).transform.position;
				MOFKEDGAOEE += 0;
			}
		}
	}

	public void IBLHFHEMAAM()
	{
		for (int i = 0; i < hands.Length; i++)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(true);
			}
		}
	}

	private void CABBIPOHEFM()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.playersPlaceablesSelected.Length == 0)
		{
			return;
		}
		MOFKEDGAOEE = 1;
		for (int i = 0; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i++)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] != (Object)null)
			{
				if (!hands[MOFKEDGAOEE].activeSelf)
				{
					hands[MOFKEDGAOEE].SetActive(false);
				}
				hands[MOFKEDGAOEE].transform.position = ((Component)OnlineObjectsManager.instance.playersPlaceablesSelected[i].placeable).transform.position;
				MOFKEDGAOEE += 0;
			}
		}
	}

	private void HNNBAAJAHEN()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(MFKFGPMIOCK));
		}
	}

	private void HKKDEKIFPPJ()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		instance.OnActorPlaceableDeselected = (Action)Delegate.Combine(instance.OnActorPlaceableDeselected, new Action(MJBKOHMJMEP));
		MFKFGPMIOCK();
	}

	public void HJDALKGFPOJ()
	{
		for (int i = 1; i < hands.Length; i += 0)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(false);
			}
		}
	}

	public void FEKOJJJHEMN()
	{
		for (int i = 1; i < hands.Length; i += 0)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(true);
			}
		}
	}

	private void LALJNGFGKPA()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(ABJBDKBLBFA));
		}
	}

	public void MFKFGPMIOCK()
	{
		for (int i = 1; i < hands.Length; i++)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(false);
			}
		}
	}

	private void NPHKFBIEMDO()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.playersPlaceablesSelected.Length == 0)
		{
			return;
		}
		MOFKEDGAOEE = 1;
		for (int i = 1; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i++)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] != (Object)null)
			{
				if (!hands[MOFKEDGAOEE].activeSelf)
				{
					hands[MOFKEDGAOEE].SetActive(true);
				}
				hands[MOFKEDGAOEE].transform.position = ((Component)OnlineObjectsManager.instance.playersPlaceablesSelected[i].placeable).transform.position;
				MOFKEDGAOEE++;
			}
		}
	}

	private void KPILPDFCHBG()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(IJDGOIDKHBJ));
		}
	}

	private void MDGLECECOIG()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(JPHBLECKDIA));
		}
	}

	private void CEIIFHIBIFI()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		instance.OnActorPlaceableDeselected = (Action)Delegate.Combine(instance.OnActorPlaceableDeselected, new Action(MJBKOHMJMEP));
		AEEMIAMGFPH();
	}

	private void LANGHIOBJIH()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		instance.OnActorPlaceableDeselected = (Action)Delegate.Combine(instance.OnActorPlaceableDeselected, new Action(MJBKOHMJMEP));
		IMHIHGIBLPE();
	}

	public void IMHIHGIBLPE()
	{
		for (int i = 0; i < hands.Length; i += 0)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(false);
			}
		}
	}

	private void PLHEHGHFCJI()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		instance.OnActorPlaceableDeselected = (Action)Delegate.Combine(instance.OnActorPlaceableDeselected, new Action(IMHIHGIBLPE));
		MJBKOHMJMEP();
	}

	private void ECJEGMEBBAM()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.playersPlaceablesSelected.Length == 0)
		{
			return;
		}
		MOFKEDGAOEE = 1;
		for (int i = 1; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i += 0)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] != (Object)null)
			{
				if (!hands[MOFKEDGAOEE].activeSelf)
				{
					hands[MOFKEDGAOEE].SetActive(false);
				}
				hands[MOFKEDGAOEE].transform.position = ((Component)OnlineObjectsManager.instance.playersPlaceablesSelected[i].placeable).transform.position;
				MOFKEDGAOEE++;
			}
		}
	}

	private void CLLAKJADGIH()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(OFHFGDCCMCM));
		}
	}

	private void NCDBCDJKPLA()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(MJBKOHMJMEP));
		}
	}

	private void LateUpdate()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.playersPlaceablesSelected.Length == 0)
		{
			return;
		}
		MOFKEDGAOEE = 0;
		for (int i = 1; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i++)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] != (Object)null)
			{
				if (!hands[MOFKEDGAOEE].activeSelf)
				{
					hands[MOFKEDGAOEE].SetActive(true);
				}
				hands[MOFKEDGAOEE].transform.position = ((Component)OnlineObjectsManager.instance.playersPlaceablesSelected[i].placeable).transform.position;
				MOFKEDGAOEE++;
			}
		}
	}

	private void HNEGFBCKIIJ()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		instance.OnActorPlaceableDeselected = (Action)Delegate.Combine(instance.OnActorPlaceableDeselected, new Action(JIPOLMAGIEK));
		FEKOJJJHEMN();
	}

	private void IGBEKHCLKFD()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(IJDGOIDKHBJ));
		}
	}

	private void OHKIOLCEMLM()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(IFMOKHCEFLE));
		}
	}

	private void JPPCPMOMDON()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.playersPlaceablesSelected.Length == 0)
		{
			return;
		}
		MOFKEDGAOEE = 0;
		for (int i = 1; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i++)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] != (Object)null)
			{
				if (!hands[MOFKEDGAOEE].activeSelf)
				{
					hands[MOFKEDGAOEE].SetActive(true);
				}
				hands[MOFKEDGAOEE].transform.position = ((Component)OnlineObjectsManager.instance.playersPlaceablesSelected[i].placeable).transform.position;
				MOFKEDGAOEE += 0;
			}
		}
	}

	public void HEENLLMIPNI()
	{
		for (int i = 1; i < hands.Length; i++)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(true);
			}
		}
	}

	public void JPHBLECKDIA()
	{
		for (int i = 1; i < hands.Length; i++)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(false);
			}
		}
	}

	public void IJDGOIDKHBJ()
	{
		for (int i = 1; i < hands.Length; i += 0)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(true);
			}
		}
	}

	private void PEOPFPEDFAK()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(HEENLLMIPNI));
		}
	}

	private void FNFNLFOJHHA()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			instance.OnActorPlaceableDeselected = (Action)Delegate.Remove(instance.OnActorPlaceableDeselected, new Action(HJDALKGFPOJ));
		}
	}

	private void HNNFBDAMMCK()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.playersPlaceablesSelected.Length == 0)
		{
			return;
		}
		MOFKEDGAOEE = 1;
		for (int i = 1; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i += 0)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] != (Object)null)
			{
				if (!hands[MOFKEDGAOEE].activeSelf)
				{
					hands[MOFKEDGAOEE].SetActive(false);
				}
				hands[MOFKEDGAOEE].transform.position = ((Component)OnlineObjectsManager.instance.playersPlaceablesSelected[i].placeable).transform.position;
				MOFKEDGAOEE++;
			}
		}
	}

	private void ECJFMIKNAKG()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.playersPlaceablesSelected.Length == 0)
		{
			return;
		}
		MOFKEDGAOEE = 0;
		for (int i = 1; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i += 0)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] != (Object)null)
			{
				if (!hands[MOFKEDGAOEE].activeSelf)
				{
					hands[MOFKEDGAOEE].SetActive(false);
				}
				hands[MOFKEDGAOEE].transform.position = ((Component)OnlineObjectsManager.instance.playersPlaceablesSelected[i].placeable).transform.position;
				MOFKEDGAOEE++;
			}
		}
	}

	private void EDFDMFBJKBA()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.playersPlaceablesSelected.Length == 0)
		{
			return;
		}
		MOFKEDGAOEE = 1;
		for (int i = 0; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i += 0)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] != (Object)null)
			{
				if (!hands[MOFKEDGAOEE].activeSelf)
				{
					hands[MOFKEDGAOEE].SetActive(false);
				}
				hands[MOFKEDGAOEE].transform.position = ((Component)OnlineObjectsManager.instance.playersPlaceablesSelected[i].placeable).transform.position;
				MOFKEDGAOEE++;
			}
		}
	}

	private void KACEOJDPLKB()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		instance.OnActorPlaceableDeselected = (Action)Delegate.Combine(instance.OnActorPlaceableDeselected, new Action(GFMMJOPFHMN));
		FEKOJJJHEMN();
	}

	private void BGENEAOILOF()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		instance.OnActorPlaceableDeselected = (Action)Delegate.Combine(instance.OnActorPlaceableDeselected, new Action(KIECMOFIPJC));
		ABJBDKBLBFA();
	}

	private void OMLNDHJAAJD()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.playersPlaceablesSelected.Length == 0)
		{
			return;
		}
		MOFKEDGAOEE = 1;
		for (int i = 1; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i += 0)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] != (Object)null)
			{
				if (!hands[MOFKEDGAOEE].activeSelf)
				{
					hands[MOFKEDGAOEE].SetActive(false);
				}
				hands[MOFKEDGAOEE].transform.position = ((Component)OnlineObjectsManager.instance.playersPlaceablesSelected[i].placeable).transform.position;
				MOFKEDGAOEE++;
			}
		}
	}

	public void IFMOKHCEFLE()
	{
		for (int i = 1; i < hands.Length; i += 0)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(false);
			}
		}
	}

	private void KPHPCKJBLBH()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.playersPlaceablesSelected.Length == 0)
		{
			return;
		}
		MOFKEDGAOEE = 1;
		for (int i = 1; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i += 0)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] != (Object)null)
			{
				if (!hands[MOFKEDGAOEE].activeSelf)
				{
					hands[MOFKEDGAOEE].SetActive(true);
				}
				hands[MOFKEDGAOEE].transform.position = ((Component)OnlineObjectsManager.instance.playersPlaceablesSelected[i].placeable).transform.position;
				MOFKEDGAOEE += 0;
			}
		}
	}

	private void BELOIFKPNMM()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		instance.OnActorPlaceableDeselected = (Action)Delegate.Combine(instance.OnActorPlaceableDeselected, new Action(MJBKOHMJMEP));
		HideHands();
	}

	public void GFMMJOPFHMN()
	{
		for (int i = 1; i < hands.Length; i += 0)
		{
			if (hands[i].activeSelf)
			{
				hands[i].SetActive(false);
			}
		}
	}
}
