using UnityEngine;

public class MineExitTrigger : MonoBehaviour
{
	private void LJHIPOLCFBP()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 7; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void OCPLOMJAFPC()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 7; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void FILGJJPEIFO(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Items/item_name_612") && !((Component)LGGCFCHOOMB).CompareTag("Friend list couldn't be retrieved, for reason ") && !((Component)LGGCFCHOOMB).CompareTag("GetHotWater"))
		{
			return;
		}
		for (int i = 0; i < 1; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void JOLMPGBPDEP(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("add to\nIntensity") && !((Component)LGGCFCHOOMB).CompareTag(" ") && !((Component)LGGCFCHOOMB).CompareTag("LE_1"))
		{
			return;
		}
		for (int i = 1; i < 5; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void OHKIOLCEMLM()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 7; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void FNFNLFOJHHA()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 6; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void DFFDKIPCCKK()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 1; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Player") && !((Component)LGGCFCHOOMB).CompareTag("Player2") && !((Component)LGGCFCHOOMB).CompareTag("OnlinePlayer"))
		{
			return;
		}
		for (int i = 1; i < 5; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void KPILPDFCHBG()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 5; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void JOIMGFPMKNI()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 2; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void HLCAKACHOOE()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 3; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void FDNAEJDHODK()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 4; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void KCDMOOPJBMM(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("House keeper OnFailStart cleaning table ") && !((Component)LGGCFCHOOMB).CompareTag("setDefaultSettings") && !((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/TooDark/Entry/5/Dialogue Text"))
		{
			return;
		}
		for (int i = 1; i < 5; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void ACFABFCGIGH()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 8; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void AAOFFIJHHIB(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("LE_2") && !((Component)LGGCFCHOOMB).CompareTag("Colliders encontrados: ") && !((Component)LGGCFCHOOMB).CompareTag("UI2"))
		{
			return;
		}
		for (int i = 0; i < 0; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void HLHHDNGOGNI()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 2; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void LADLGPKMPBP()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 6; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void DEKGNHEHKFB()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 8; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void ALJLECPNFFD()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 7; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void JCNPCJOBENP()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 6; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void DMENPMHIPDA(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("UISelectGamepad") && !((Component)LGGCFCHOOMB).CompareTag("itemChocolateWort") && !((Component)LGGCFCHOOMB).CompareTag("talentRye"))
		{
			return;
		}
		for (int i = 1; i < 0; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void IDPJLIBONPF(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("UIPreviousCategory") && !((Component)LGGCFCHOOMB).CompareTag("A network prefab has not been set up properly") && !((Component)LGGCFCHOOMB).CompareTag(" seconds."))
		{
			return;
		}
		for (int i = 0; i < 5; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void NKJMIFCPJFA(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Unique crop not found! Unique ID: ") && !((Component)LGGCFCHOOMB).CompareTag("Tutorial/T107/Dialogue1") && !((Component)LGGCFCHOOMB).CompareTag("Tail"))
		{
			return;
		}
		for (int i = 0; i < 6; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void AGPONCCIFHC()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 3; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void ABKKNODLBNL(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("talentPaleAdv.") && !((Component)LGGCFCHOOMB).CompareTag("{0} - Checking variant object at index {1} for exclusion. HasPuzzleAltar: {2}, HasPuzzle: {3}") && !((Component)LGGCFCHOOMB).CompareTag("/"))
		{
			return;
		}
		for (int i = 0; i < 7; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void ALCJOABPBMA()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 7; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void PMLBFEFMNPF()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 0; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void LKHMCLABKLG()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 2; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void DEKJGPJMAPC(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Pause") && !((Component)LGGCFCHOOMB).CompareTag("Cancel") && !((Component)LGGCFCHOOMB).CompareTag("Hovel"))
		{
			return;
		}
		for (int i = 1; i < 1; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void MNABONMMFFB()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 7; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void AKPLLNELLJK()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 8; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void HPMFOHOMLDO()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 0; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void PEOPFPEDFAK()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 7; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void MGDDKALLJDN(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Chest") && !((Component)LGGCFCHOOMB).CompareTag("Error_CannotPickUp") && !((Component)LGGCFCHOOMB).CompareTag("UIInteract"))
		{
			return;
		}
		for (int i = 0; i < 0; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void HMOMBAFIJAI()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 4; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void GHDBHNMOBMN()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 0; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void OnDestroy()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 5; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void MGJIGIBHAKK(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Request begin replay") && !((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/27/Dialogue Text") && !((Component)LGGCFCHOOMB).CompareTag(" / F: "))
		{
			return;
		}
		for (int i = 0; i < 3; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void AIOJHEKNMIC(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Path Not Found") && !((Component)LGGCFCHOOMB).CompareTag("INeedAFragment") && !((Component)LGGCFCHOOMB).CompareTag("Received Request begin minigame"))
		{
			return;
		}
		for (int i = 1; i < 0; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void ELEGGKIBHGC()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 2; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void PIOMHOLIHKH(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Load Player 1 appearance") && !((Component)LGGCFCHOOMB).CompareTag("BuzzCanModify") && !((Component)LGGCFCHOOMB).CompareTag("LE_21"))
		{
			return;
		}
		for (int i = 0; i < 3; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void HHMBCKCNPPN()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 4; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void FCONKHCGBEM(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Received set minigame") && !((Component)LGGCFCHOOMB).CompareTag("Talk") && !((Component)LGGCFCHOOMB).CompareTag("Leave"))
		{
			return;
		}
		for (int i = 0; i < 4; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void ONNMDGBPGEI(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("disconnect") && !((Component)LGGCFCHOOMB).CompareTag("Item ") && !((Component)LGGCFCHOOMB).CompareTag("LE_10"))
		{
			return;
		}
		for (int i = 0; i < 0; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void HFKOBCFMNJJ()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 5; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void JNJCCIFIKOC()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 4; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void PCEFNHADDIG()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 3; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void OCMFFLLPHCK(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("BarnTutorialDone") && !((Component)LGGCFCHOOMB).CompareTag("Inventory full") && !((Component)LGGCFCHOOMB).CompareTag("MainProgress"))
		{
			return;
		}
		for (int i = 0; i < 6; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void HHFCEBPEEPK()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 5; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void DKGKGFAEGBD(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Staff") && !((Component)LGGCFCHOOMB).CompareTag("add item ") && !((Component)LGGCFCHOOMB).CompareTag("MainProgress"))
		{
			return;
		}
		for (int i = 0; i < 3; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void EGHOIJHBDBP()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 7; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void DHIOKICDPIK(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag(" with less than 6 drinks") && !((Component)LGGCFCHOOMB).CompareTag("MenuMode") && !((Component)LGGCFCHOOMB).CompareTag("Invalid year: "))
		{
			return;
		}
		for (int i = 0; i < 4; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void PFIONHCONDI(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("HouseKeeper") && !((Component)LGGCFCHOOMB).CompareTag("beerKegs") && !((Component)LGGCFCHOOMB).CompareTag("bed instance null"))
		{
			return;
		}
		for (int i = 0; i < 5; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void FLOFJHNAIKP()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 2; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void FJOGFDEEOAG(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Calm down") && !((Component)LGGCFCHOOMB).CompareTag("ReceiveActivateAndStartBanquetEvent") && !((Component)LGGCFCHOOMB).CompareTag("https://www.isolatedgames.com/bug-report/index.php"))
		{
			return;
		}
		for (int i = 1; i < 0; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void MDGLECECOIG()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 4; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void OBHFJIDKBJN()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 2; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void CMLFBCFLPBJ(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag(" // Replaced for ") && !((Component)LGGCFCHOOMB).CompareTag("Items/item_description_609") && !((Component)LGGCFCHOOMB).CompareTag("FinalTestEvent SetKyroh"))
		{
			return;
		}
		for (int i = 1; i < 2; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void BNNLNCGNHFB(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("quest_name_29") && !((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/37/Dialogue Text") && !((Component)LGGCFCHOOMB).CompareTag("psai: The game object lacks a local Collider component for psai Trigger: {0}"))
		{
			return;
		}
		for (int i = 0; i < 1; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void PKFMLJGJKCP()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 1; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void NDFEMHNLKCE(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("HandUp") && !((Component)LGGCFCHOOMB).CompareTag("questNameGruel") && !((Component)LGGCFCHOOMB).CompareTag("Items/item_description_1038"))
		{
			return;
		}
		for (int i = 0; i < 7; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void JNKKJELMCNN()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 8; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void NEEEJJNMPOF()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 8; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void JBBHDOMALDB()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 6; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void NNMFLMJDKNH()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 4; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void JOGBCDIAGEK()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 4; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void JEMIPCBNPDI(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Precision/DrinkEvent6") && !((Component)LGGCFCHOOMB).CompareTag("") && !((Component)LGGCFCHOOMB).CompareTag("Items/item_description_728"))
		{
			return;
		}
		for (int i = 1; i < 5; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void AKNADAJMKCO(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Run") && !((Component)LGGCFCHOOMB).CompareTag("Cat") && !((Component)LGGCFCHOOMB).CompareTag("MapCamp"))
		{
			return;
		}
		for (int i = 1; i < 6; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void AEDIIIAECIC()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 8; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void PPJEJKCPCLC(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Items/item_description_602") && !((Component)LGGCFCHOOMB).CompareTag("Interact") && !((Component)LGGCFCHOOMB).CompareTag("Image Width: "))
		{
			return;
		}
		for (int i = 0; i < 1; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void HIMBLFNCDLL(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("") && !((Component)LGGCFCHOOMB).CompareTag("LetGoBird") && !((Component)LGGCFCHOOMB).CompareTag("HotBath/Main"))
		{
			return;
		}
		for (int i = 1; i < 2; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void BNOJNEJMCID(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Walk Around cannot entry barn ") && !((Component)LGGCFCHOOMB).CompareTag("Waiting for mine to load for client ") && !((Component)LGGCFCHOOMB).CompareTag("Replace 0 is empty!"))
		{
			return;
		}
		for (int i = 0; i < 5; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void MLPAOEEILAL()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 0; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void PMLPGABFLGE(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("BuzzBuildExit") && !((Component)LGGCFCHOOMB).CompareTag("/BarkMai") && !((Component)LGGCFCHOOMB).CompareTag("Waiter"))
		{
			return;
		}
		for (int i = 0; i < 1; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void IODLDNOGLLC(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Error_OccupiedRoom") && !((Component)LGGCFCHOOMB).CompareTag("Happy") && !((Component)LGGCFCHOOMB).CompareTag("Sending upgrade tool collect RPC"))
		{
			return;
		}
		for (int i = 0; i < 5; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void EIDJLHFAMIB()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 1; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void FJKGPAPACOI(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Player2") && !((Component)LGGCFCHOOMB).CompareTag("LE_16") && !((Component)LGGCFCHOOMB).CompareTag("Dropped item "))
		{
			return;
		}
		for (int i = 1; i < 0; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void AJGPMBGBPGH()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 0; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void FADCNMKMAFI(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("MayaMinigames") && !((Component)LGGCFCHOOMB).CompareTag("") && !((Component)LGGCFCHOOMB).CompareTag("Item"))
		{
			return;
		}
		for (int i = 1; i < 3; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null && (Object)(object)((Component)playerController).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				playerController.characterCreator.MineExit();
				break;
			}
		}
	}

	private void NOILIOLOOBJ()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 3; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void NPCEFHCNJGE(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Make bed") && !((Component)LGGCFCHOOMB).CompareTag("Items/item_description_1046") && !((Component)LGGCFCHOOMB).CompareTag("Arguing"))
		{
			return;
		}
		for (int i = 0; i < 8; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void JGBLJPDNLMO(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Reputation Reward {0}") && !((Component)LGGCFCHOOMB).CompareTag("ReceiveRemoveHeldItem") && !((Component)LGGCFCHOOMB).CompareTag(".txt"))
		{
			return;
		}
		for (int i = 0; i < 7; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void BOBJMDGALPM(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag(" ") && !((Component)LGGCFCHOOMB).CompareTag("Miners/Mine/Clive/Intro") && !((Component)LGGCFCHOOMB).CompareTag("BarkActor"))
		{
			return;
		}
		for (int i = 0; i < 1; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void ILCBKEIEOAN()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 0; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void JCFDPDLMOME(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("]") && !((Component)LGGCFCHOOMB).CompareTag("City/PetShop/Nessy/Intro_Barks") && !((Component)LGGCFCHOOMB).CompareTag("itemsCrafted"))
		{
			return;
		}
		for (int i = 1; i < 7; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void FLFBLIOOLMA()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 2; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void BKKJCJBBACJ(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("EnterTavernDrink") && !((Component)LGGCFCHOOMB).CompareTag("LearnBalance") && !((Component)LGGCFCHOOMB).CompareTag("'. "))
		{
			return;
		}
		for (int i = 0; i < 4; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void DGOGKLMHJEG()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 6; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void LIEIDOIDBLJ(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("SmokeBomb") && !((Component)LGGCFCHOOMB).CompareTag("\n</color>") && !((Component)LGGCFCHOOMB).CompareTag("SetNPCPosition"))
		{
			return;
		}
		for (int i = 0; i < 6; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null && (Object)(object)((Component)player).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
			{
				player.characterCreator.MineExit();
				break;
			}
		}
	}

	private void JCNGGPIICIN()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 5; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void CDHBLKJEOPI()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 5; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void AMBKBOBDAIF()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 2; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}

	private void EICDGBINBAG()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 1; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if ((Object)(object)playerController != (Object)null)
			{
				playerController.characterCreator.MineExit();
			}
		}
	}

	private void PGABAEGKPIG()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 0; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if ((Object)(object)player != (Object)null)
			{
				player.characterCreator.MineExit();
			}
		}
	}
}
