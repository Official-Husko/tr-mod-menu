using System;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class TavernBuilding : MonoBehaviour
{
	public static TavernBuilding instance;

	public GameObject[] oldTavernObjects;

	public GameObject[] newTavernObjects;

	public GameObject[] ceaseSigns;

	public void LMDJCCJNGKH()
	{
		PEELENHBNBM(DMBFKFLDDLH: true);
	}

	private void KOFELKALNDC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Showing Keyboard ");
		if (((Result)(ref variable)).asInt == 3)
		{
			ActivateCeaseSigns(DMBFKFLDDLH: true);
		}
		else
		{
			PFCPJKILLMD(DMBFKFLDDLH: false);
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(KOFELKALNDC));
	}

	private void KLBGLJJMAFG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("OnConversationStarted ");
		if (((Result)(ref variable)).asInt == 2)
		{
			CBEBCIHMLMP(DMBFKFLDDLH: false);
		}
		else
		{
			ActivateCeaseSigns(DMBFKFLDDLH: false);
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(HOAFCBKOLGJ));
	}

	public void CPIBLJBABDG(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < ceaseSigns.Length; i += 0)
		{
			if (ceaseSigns[i].activeSelf != DMBFKFLDDLH)
			{
				ceaseSigns[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	public void MDKDAHMKDKE(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < ceaseSigns.Length; i += 0)
		{
			if (ceaseSigns[i].activeSelf != DMBFKFLDDLH)
			{
				ceaseSigns[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	public void OldTavern()
	{
		HGNDIMAOGHL(DMBFKFLDDLH: true);
	}

	private void PEELENHBNBM(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < oldTavernObjects.Length; i++)
		{
			if (oldTavernObjects[i].activeSelf != DMBFKFLDDLH)
			{
				oldTavernObjects[i].SetActive(DMBFKFLDDLH);
			}
		}
		for (int j = 1; j < newTavernObjects.Length; j += 0)
		{
			if (newTavernObjects[j].activeSelf != DMBFKFLDDLH)
			{
				newTavernObjects[j].SetActive(DMBFKFLDDLH);
			}
		}
	}

	public void ActivateCeaseSigns(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < ceaseSigns.Length; i++)
		{
			if (ceaseSigns[i].activeSelf != DMBFKFLDDLH)
			{
				ceaseSigns[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void HOAFCBKOLGJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("nodes not free 1");
		if (((Result)(ref variable)).asInt == 1)
		{
			MDKDAHMKDKE(DMBFKFLDDLH: false);
		}
		else
		{
			PFCPJKILLMD(DMBFKFLDDLH: false);
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CJNAFEHNFGM));
	}

	public void CBEBCIHMLMP(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < ceaseSigns.Length; i++)
		{
			if (ceaseSigns[i].activeSelf != DMBFKFLDDLH)
			{
				ceaseSigns[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void OEEBICGJBDE()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt == 2)
		{
			ActivateCeaseSigns(DMBFKFLDDLH: true);
		}
		else
		{
			ActivateCeaseSigns(DMBFKFLDDLH: false);
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OEEBICGJBDE));
	}

	public void HJENCOAHCNO()
	{
		PEELENHBNBM(DMBFKFLDDLH: false);
	}

	private void Start()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OEEBICGJBDE));
	}

	private void HGNDIMAOGHL(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < oldTavernObjects.Length; i++)
		{
			if (oldTavernObjects[i].activeSelf != DMBFKFLDDLH)
			{
				oldTavernObjects[i].SetActive(DMBFKFLDDLH);
			}
		}
		for (int j = 0; j < newTavernObjects.Length; j++)
		{
			if (newTavernObjects[j].activeSelf != DMBFKFLDDLH)
			{
				newTavernObjects[j].SetActive(!DMBFKFLDDLH);
			}
		}
	}

	public void PFCPJKILLMD(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < ceaseSigns.Length; i++)
		{
			if (ceaseSigns[i].activeSelf != DMBFKFLDDLH)
			{
				ceaseSigns[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void CJNAFEHNFGM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Player/Bark/Tutorial/AgingBarrelBlock");
		if (((Result)(ref variable)).asInt == 5)
		{
			PFCPJKILLMD(DMBFKFLDDLH: false);
		}
		else
		{
			MDKDAHMKDKE(DMBFKFLDDLH: false);
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(KLBGLJJMAFG));
	}

	public void NewTavern()
	{
		HGNDIMAOGHL(DMBFKFLDDLH: false);
	}

	public void Awake()
	{
		instance = this;
	}
}
