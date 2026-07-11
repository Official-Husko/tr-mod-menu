using UnityEngine;

public class ActivateObjectsOnTriggerEnter : MonoBehaviour
{
	public GameObject[] gameObjectsToActivate;

	[SerializeField]
	private bool player1In;

	[SerializeField]
	private bool player2In;

	private void PPJEJKCPCLC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1108"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("[GetFallbackCandidates] Total fallback candidates: {0}"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void IDPJLIBONPF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("in"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("perHour"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void LJJDGAJNNCH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Estufa duplicada eliminada"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UI"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void MOKLBANPFGM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Hikari/Stand"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Invalid playerNum "))
		{
			player2In = true;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void KIJDNFODCKJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Error in Rock.OnPlayerSleep: "))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/14/Dialogue Text"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void DAGGKPKBCLD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1187"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveRemoveOrderQuest"))
		{
			player2In = true;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void BNOJNEJMCID(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/14/Dialogue Text"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("/"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void BLOCHBJIICN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Focused"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dots"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void OFNKDCBEAHP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("LearnBalance"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("City/PetShop/Nessy/PerritosAbandonados"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void IMOHIBLLPIB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("RinProgress"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ValueType"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_671"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("OnLobbyDataUpdate \nLobby: {0}\nUser: {1}"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void AAOFFIJHHIB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(")"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Body_Extra"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void CNLANNFMFCN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("HalloweenEvent"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("bathhouseinterior"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("k "))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("OnLayerOrderedRPC"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void HJIJHEONIIG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("MapCity"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveInfoWorldTiles"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void MGJIGIBHAKK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("SortByName"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Room occupied"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void NICLCHABAMK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Hikari/Stand"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Duplicate Quest id found: "))
		{
			player2In = true;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void FKILALCMOOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("DefaultSettings"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/48/Dialogue Text"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void GEFCGLEGHOA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("itemAsparagus"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("_"))
		{
			player2In = true;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void KCDODEOOBHG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ErrorUnknownChatCommand"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Changing quality "))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void OCEIGDHOJJM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Null shop in database: "))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Giving extra stones"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(":</color> "))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/NeutralInTavern/Entry/3/Dialogue Text"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void JMNPLNAGLCO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("sleep"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("<color=#713112>"))
		{
			player2In = true;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Open"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemBarleyFlour"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ErrorCreateAlreadyExists"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Game is already running"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Inventory full"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Loading tavern floor tiles"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void ILJJIFMJICA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReciveStopConversation"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemBiscuitWort"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void NPCEFHCNJGE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TavernFilthy/Entry/1/Dialogue Text"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveCrafterRepaired"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void ILNDDFELMKL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Fading out music over "))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("MainProgress"))
		{
			player2In = true;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void KGAPHAIFAFH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dig"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Disappear"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Fading out music over "))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Left"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void DHIOKICDPIK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T106/Dialogue1"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void LMNMPBNMGCH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveTeleportPlayerToCastleGarden"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void KCDMOOPJBMM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Barks_Bye/Entry/4/Dialogue Text"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ListViewEntry"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void KJJINNGPPEA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" is already in Kyroh's tray bento."))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Selected"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void LEKBKCLEEHE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("NightStart not attached to prefab "))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Error instantiating placeable from message of type "))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("All"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("El prefab '{0}' tiene {1} componentes 'OnlineObject' (duplicados)."))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void AHKDANJMEMC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Scratch"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dog"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Sending cursor move for grid index {0} in mine level {1}"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemRyeAle"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void OOALHOHGANE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Error_TableNeedsFreeSpace"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T101/Dialogue2"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("/Reports/"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Sleeve_L"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void CIMPOOJOMMH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("/"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void LBJEAHNNMCN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("mainMenuMultiplayerButtonConnecting"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(": Prefab direction not found!"))
		{
			player2In = true;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void NFDJLCGELJM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" not found (or not visible in lobby)"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Empty bites list"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void HEOHCIAMEPD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("tutorialPopUp28"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UI"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void CMJBBBHGHCD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Sit"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveStatus"))
		{
			player2In = true;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void MDODDIKGEHI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Sending "))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(")"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void JOPNDBLNDMA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Not found ingredients for trends "))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			player2In = true;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T110/Dialogue1"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LE_10"))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void DGLMPEODEKI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveSetPickupable"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("RoadBlocked/Main"))
		{
			player2In = true;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void NAFADNEKCOH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Disappear"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Tree"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void LHGOFNEIMNN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("AnimatorParameterRequest"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("MetalWorkshop"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void KKEPLLEAAMB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_614"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_637"))
		{
			player2In = true;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void LIEIDOIDBLJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Shader Model 4.1 ( DX10.1 )"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LE_16"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void DNDNCBILKMB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Running on Steamdeck: FALSE"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("PlaceableOnSpecificSurfaces"))
		{
			player2In = true;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void HCGGDMEEBHD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Walk Around cannot entry barn "))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" "))
		{
			player2In = true;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UIPreviousPage"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("└── "))
		{
			player2In = true;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void FCONKHCGBEM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Sharp"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1180"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void DJNNHILGACE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Room missing required items"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
	}

	private void ONNMDGBPGEI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Sleep"))
		{
			player1In = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveGroundTypeList"))
		{
			player2In = false;
		}
		if (!player1In && !player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (!gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void MKCEGNPBGMP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Disabled"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UIVolume"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}

	private void MOOJEOLFOOC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Sound"))
		{
			player1In = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/EnterTavernDrink/Entry/5/Dialogue Text"))
		{
			player2In = false;
		}
		if (player1In || player2In)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (gameObjectsToActivate[i].activeSelf)
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
	}
}
