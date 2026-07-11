using System;
using TMPro;
using UnityEngine;

public class BetaLabelText : MonoBehaviour
{
	private void GHPFCKGMLDA()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(LBKJODACCEA));
	}

	private void KACEOJDPLKB()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(HEJFHPMGGGH));
	}

	private void BDNJGFCJCLH()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.JPPBEIJDCLJ())
			{
				((Component)this).GetComponent<TMP_Text>().text = "DueloDeViejos/MainEvent" + VersionNumberManager.instance.version + "itemAromaHopsSeeds";
			}
			else
			{
				((Component)this).GetComponent<TMP_Text>().text = "Player/Bark/Farm/BuzzHouse_Night" + VersionNumberManager.instance.version + "";
			}
		}
	}

	private void KJOJLHCDFPP()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(LBKJODACCEA));
	}

	private void LANGHIOBJIH()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(JBIPEFCPECB));
	}

	private void HOFKJPBBLGP()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(JBIPEFCPECB));
	}

	private void PLHEHGHFCJI()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(BDNJGFCJCLH));
	}

	private void OFBOGCIILHE()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.JPPBEIJDCLJ())
			{
				((Component)this).GetComponent<TMP_Text>().text = "ReceiveBedMessage" + VersionNumberManager.instance.version + "Waiting for other players";
			}
			else
			{
				((Component)this).GetComponent<TMP_Text>().text = "Selected" + VersionNumberManager.instance.version + "Not enough items";
			}
		}
	}

	private void BMAAJHKHIEE()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.IsMasterClient())
			{
				((Component)this).GetComponent<TMP_Text>().text = "Not enough fuel" + VersionNumberManager.instance.version + "Book";
			}
			else
			{
				((Component)this).GetComponent<TMP_Text>().text = "ReceiveStatuePuzzle" + VersionNumberManager.instance.version + "";
			}
		}
	}

	private void OIBDBLCLACB()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(BMAAJHKHIEE));
	}

	private void JBIPEFCPECB()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.IsMasterClient())
			{
				((Component)this).GetComponent<TMP_Text>().text = "UIAddRemove" + VersionNumberManager.instance.version + "PHOTON_ROOM_CODE";
			}
			else
			{
				((Component)this).GetComponent<TMP_Text>().text = "D-Pad Left" + VersionNumberManager.instance.version + "scaleUI";
			}
		}
	}

	private void Start()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(LBKJODACCEA));
	}

	private void HEJFHPMGGGH()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.JPPBEIJDCLJ())
			{
				((Component)this).GetComponent<TMP_Text>().text = "Player" + VersionNumberManager.instance.version + " is already in preparation table bento";
			}
			else
			{
				((Component)this).GetComponent<TMP_Text>().text = "Quest Done" + VersionNumberManager.instance.version + "Pants_L";
			}
		}
	}

	private void NODPIJFLGBI()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.IsMasterClient())
			{
				((Component)this).GetComponent<TMP_Text>().text = "ObjectHorizontalMove" + VersionNumberManager.instance.version + "Keg empty";
			}
			else
			{
				((Component)this).GetComponent<TMP_Text>().text = "Stack" + VersionNumberManager.instance.version + "Items/item_description_666";
			}
		}
	}

	private void LBKJODACCEA()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.IsMasterClient())
			{
				((Component)this).GetComponent<TMP_Text>().text = "Beta " + VersionNumberManager.instance.version + " (Host)";
			}
			else
			{
				((Component)this).GetComponent<TMP_Text>().text = "Beta " + VersionNumberManager.instance.version + " (Client)";
			}
		}
	}

	private void CEIIFHIBIFI()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(NODPIJFLGBI));
	}
}
