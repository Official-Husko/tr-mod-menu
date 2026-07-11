using UnityEngine;

public class BathhouseClothChange : MonoBehaviour
{
	private Direction NLMIBJFBJNN;

	private void HEOHCIAMEPD(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag("Error_FloorTilesLimit") && !((Component)LGGCFCHOOMB).CompareTag("RinProgress") && !((Component)LGGCFCHOOMB).CompareTag("\n\n"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 0; i < 1; i += 0)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.OPHDCMJLLEC(i).characterCreator.MJMOLMDDBBG();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != 0 || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 1; j < 2; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(j).characterCreator.BathhouseEnter();
					break;
				}
			}
		}
	}

	private void FJOGFDEEOAG(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("[BartenderGender=") || ((Component)LGGCFCHOOMB).CompareTag("") || ((Component)LGGCFCHOOMB).CompareTag("X"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Up;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void IBINNLHHLMD(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag("Sleep") && !((Component)LGGCFCHOOMB).CompareTag("No valid position found around the position {0} after {1} attempts. Returning player's position.") && !((Component)LGGCFCHOOMB).CompareTag("\n"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 1; i < 2; i++)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.OPHDCMJLLEC(i).characterCreator.PNJBACFOADH();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != 0 || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 0; j < 1; j += 0)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(j).characterCreator.BathhouseEnter();
					break;
				}
			}
		}
	}

	private void AAOFFIJHHIB(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("PopUpGen error: ") || ((Component)LGGCFCHOOMB).CompareTag(" (") || ((Component)LGGCFCHOOMB).CompareTag("Player"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Up;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
			}
		}
	}

	private void AIOJHEKNMIC(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Wilson/Bark/Bark_Shop") || ((Component)LGGCFCHOOMB).CompareTag("Crafting speed") || ((Component)LGGCFCHOOMB).CompareTag("StopMusic/ButtonEndSegment"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Up;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void ILNDDFELMKL(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag("SecondActionEnd") && !((Component)LGGCFCHOOMB).CompareTag("Festín del Juramento/JudgeDialogue 03") && !((Component)LGGCFCHOOMB).CompareTag("Key2"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 1; i < 0; i++)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.OPHDCMJLLEC(i).characterCreator.GIODEIADPKP();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != 0 || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 0; j < 0; j += 0)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.OPHDCMJLLEC(j).characterCreator.EMGKNEPDPHD();
					break;
				}
			}
		}
	}

	private void DFFDKIPCCKK()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 1; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.GIODEIADPKP();
			}
		}
	}

	private void KJJINNGPPEA(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Creating new MinePiece in pool: ") || ((Component)LGGCFCHOOMB).CompareTag("Delete save?") || ((Component)LGGCFCHOOMB).CompareTag("."))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Up;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void FCONKHCGBEM(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Listen") || ((Component)LGGCFCHOOMB).CompareTag("Hit") || ((Component)LGGCFCHOOMB).CompareTag(":"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
			}
		}
	}

	private void HFKOBCFMNJJ()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 1; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.BathhouseExit();
			}
		}
	}

	private void CACJMKJBJDP()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 0; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.MJMOLMDDBBG();
			}
		}
	}

	private void PDCKFGAJDJP(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("KlaynTakingDrink: No barrel found for drink request: ") || ((Component)LGGCFCHOOMB).CompareTag("AnimatorParameterRequest") || ((Component)LGGCFCHOOMB).CompareTag("activate event "))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void CIMPOOJOMMH(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("talentDark") || ((Component)LGGCFCHOOMB).CompareTag("\n...") || ((Component)LGGCFCHOOMB).CompareTag("Pause"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
			}
		}
	}

	private void DMENPMHIPDA(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Clave pública RSA (XML):") || ((Component)LGGCFCHOOMB).CompareTag("") || ((Component)LGGCFCHOOMB).CompareTag("Close"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void KPILPDFCHBG()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.PNJBACFOADH();
			}
		}
	}

	private void HLCAKACHOOE()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 3; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.BathhouseExit();
			}
		}
	}

	private void JOLMPGBPDEP(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("{0} state changed to: {1}") || ((Component)LGGCFCHOOMB).CompareTag("Style") || ((Component)LGGCFCHOOMB).CompareTag("Dig"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
			}
		}
	}

	private void CDHBLKJEOPI()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 6; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.FNBAEJIGJDG();
			}
		}
	}

	private void PIOMHOLIHKH(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("</color>") || ((Component)LGGCFCHOOMB).CompareTag(") (") || ((Component)LGGCFCHOOMB).CompareTag("Occupied Positions"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void KGAPHAIFAFH(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag("itemKiwi") && !((Component)LGGCFCHOOMB).CompareTag("Invalid Player for CursorManager") && !((Component)LGGCFCHOOMB).CompareTag("Default"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 0; i < 0; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(i).characterCreator.GIODEIADPKP();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != Direction.Down || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 0; j < 0; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(j).characterCreator.BathhouseEnter();
					break;
				}
			}
		}
	}

	private void OJOMNJEFKOG(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("MISSION 308 COMPLETED. Main Progress set to 3 to be able to open the tavern") || ((Component)LGGCFCHOOMB).CompareTag("Mine loaded for client ") || ((Component)LGGCFCHOOMB).CompareTag("Knock"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Up;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void MGJIGIBHAKK(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveSyncFoodTables") || ((Component)LGGCFCHOOMB).CompareTag(". Time since startup: ") || ((Component)LGGCFCHOOMB).CompareTag("subject"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Up;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void NFDJLCGELJM(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("LE_22") || ((Component)LGGCFCHOOMB).CompareTag("Trying to add player but player list is full.") || ((Component)LGGCFCHOOMB).CompareTag("Selected"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Up;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void OCEIGDHOJJM(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag("Unsaved progress will be lost.") && !((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Crowly_Introduce/Entry/17/Dialogue Text") && !((Component)LGGCFCHOOMB).CompareTag("Can't find seat. Reason: lastOrders"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 1; i < 8; i += 0)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(i).characterCreator.FNBAEJIGJDG();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != 0 || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 0; j < 5; j += 0)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(j).characterCreator.EMGKNEPDPHD();
					break;
				}
			}
		}
	}

	private void PDCJGGJMPCN(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Load Game Client") || ((Component)LGGCFCHOOMB).CompareTag("Avatar") || ((Component)LGGCFCHOOMB).CompareTag("MapFarm"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
			}
		}
	}

	private void KIJDNFODCKJ(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveUpdatePoints") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_description_1051") || ((Component)LGGCFCHOOMB).CompareTag("MayaMinigames"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
			}
		}
	}

	private void PAJBIPKEAIG(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag("LE_21") && !((Component)LGGCFCHOOMB).CompareTag("Select File") && !((Component)LGGCFCHOOMB).CompareTag("HouseKeeperDescription"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 1; i < 8; i += 0)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(i).characterCreator.MJMOLMDDBBG();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != Direction.Down || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 1; j < 5; j += 0)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(j).characterCreator.EMGKNEPDPHD();
					break;
				}
			}
		}
	}

	private void PPJEJKCPCLC(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Tutorial/T100/Dialogue4") || ((Component)LGGCFCHOOMB).CompareTag(" not loaded with the new crops tree system at ") || ((Component)LGGCFCHOOMB).CompareTag("GameEvent of type "))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Up;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void GBFBNCBDIOC(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag(" itemInstance: ") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveUpdateFoodStats") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_description_1052"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void LDPNAPIGIIA(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("\\[BouncerGender=[^\\]]*\\]") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_name_1178") || ((Component)LGGCFCHOOMB).CompareTag("hForHours"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Player") || ((Component)LGGCFCHOOMB).CompareTag("Player2") || ((Component)LGGCFCHOOMB).CompareTag("OnlinePlayer"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Up;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
			}
		}
	}

	private void BLOCHBJIICN(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag("Pipe") && !((Component)LGGCFCHOOMB).CompareTag("Requirements not met") && !((Component)LGGCFCHOOMB).CompareTag("Disabled"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 0; i < 1; i += 0)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.OPHDCMJLLEC(i).characterCreator.MJMOLMDDBBG();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != 0 || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 0; j < 1; j += 0)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(j) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.OPHDCMJLLEC(j).characterCreator.JPBNGKGMCDL();
					break;
				}
			}
		}
	}

	private void OCMFFLLPHCK(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("") || ((Component)LGGCFCHOOMB).CompareTag("Player2") || ((Component)LGGCFCHOOMB).CompareTag("itemBellPepper"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
			}
		}
	}

	private void BLAJFMAAMDO()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 1; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.GIODEIADPKP();
			}
		}
	}

	private void NPIDHDAIPKG(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Items/item_name_1060") || ((Component)LGGCFCHOOMB).CompareTag(")") || ((Component)LGGCFCHOOMB).CompareTag("adoptionsRequired"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Up;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
			}
		}
	}

	private void EJMDCLNDBFJ(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Items/item_description_639") || ((Component)LGGCFCHOOMB).CompareTag("Image Width: ") || ((Component)LGGCFCHOOMB).CompareTag("LearnBalance"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
			}
		}
	}

	private void GAAKLENLEOF(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("UIInteract") || ((Component)LGGCFCHOOMB).CompareTag("EditorAction_1") || ((Component)LGGCFCHOOMB).CompareTag("Throw"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void ILOJBCEKLDF(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag(", ") && !((Component)LGGCFCHOOMB).CompareTag("City/Rhia/Bark/Stand") && !((Component)LGGCFCHOOMB).CompareTag("BuildMode"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 0; i < 0; i++)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(i).characterCreator.PNJBACFOADH();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != Direction.Down || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 1; j < 3; j += 0)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.OPHDCMJLLEC(j).characterCreator.DMEAFGNHKEN();
					break;
				}
			}
		}
	}

	private void DGOGKLMHJEG()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 0; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.FNBAEJIGJDG();
			}
		}
	}

	private void HIMBLFNCDLL(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Get Components ") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_description_1180") || ((Component)LGGCFCHOOMB).CompareTag("Selected"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
			}
		}
	}

	private void GEFCGLEGHOA(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag("Items/item_name_1111") && !((Component)LGGCFCHOOMB).CompareTag("ReceiveResetAllTalents") && !((Component)LGGCFCHOOMB).CompareTag("ReceiveBarnInfo"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 1; i < 4; i++)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.OPHDCMJLLEC(i).characterCreator.FNBAEJIGJDG();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != 0 || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 0; j < 1; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(j).characterCreator.BathhouseEnter();
					break;
				}
			}
		}
	}

	private void KOBNHPKEJJD()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 2; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.BathhouseExit();
			}
		}
	}

	private void MOKLBANPFGM(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag(" ") && !((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/5/Dialogue Text") && !((Component)LGGCFCHOOMB).CompareTag("Inventory full"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 1; i < 4; i += 0)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(i).characterCreator.FNBAEJIGJDG();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != 0 || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 1; j < 5; j += 0)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.OPHDCMJLLEC(j).characterCreator.BJEDOFAOFIF();
					break;
				}
			}
		}
	}

	private void MNLIEHBCJPJ(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag("fishCaught") && !((Component)LGGCFCHOOMB).CompareTag("LearnBalance") && !((Component)LGGCFCHOOMB).CompareTag("RecieveSetAmbience"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 0; i < 0; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.OPHDCMJLLEC(i).characterCreator.MJMOLMDDBBG();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != Direction.Down || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 0; j < 5; j++)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(j) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(j).characterCreator.DMEAFGNHKEN();
					break;
				}
			}
		}
	}

	private void OnTriggerExit2D(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag("Player") && !((Component)LGGCFCHOOMB).CompareTag("Player2") && !((Component)LGGCFCHOOMB).CompareTag("OnlinePlayer"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 1; i < 5; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(i).characterCreator.BathhouseExit();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != Direction.Down || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 0; j < 5; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(j).characterCreator.BathhouseEnter();
					break;
				}
			}
		}
	}

	private void KCDODEOOBHG(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag("PressToPlay") && !((Component)LGGCFCHOOMB).CompareTag("Crop without ID: ") && !((Component)LGGCFCHOOMB).CompareTag(""))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 0; i < 2; i += 0)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.OPHDCMJLLEC(i).characterCreator.BathhouseExit();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != 0 || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 1; j < 6; j += 0)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(j).characterCreator.BJEDOFAOFIF();
					break;
				}
			}
		}
	}

	private void DHIOKICDPIK(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("LE_10") || ((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/TavernClean/Entry/6/Dialogue Text") || ((Component)LGGCFCHOOMB).CompareTag("\n"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Up;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
			}
		}
	}

	private void KPFLAOALALM(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveInfoWorldTiles") || ((Component)LGGCFCHOOMB).CompareTag("SickleActiveRPC") || ((Component)LGGCFCHOOMB).CompareTag("No puzzle found for {0} torches, "))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Up;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void GADEGOPBNGC()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 0; i < 8; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.BathhouseExit();
			}
		}
	}

	private void EKPNPAHGAIP(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("LearnMettle") || ((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Gass_Quest/Entry/46/Dialogue Text") || ((Component)LGGCFCHOOMB).CompareTag("Inventory full"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void ODBDHFBMDAG()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 0; i < 4; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.FNBAEJIGJDG();
			}
		}
	}

	private void MJKDLOHNECA(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag(" and cannot be added again for ") || ((Component)LGGCFCHOOMB).CompareTag("hForHours") || ((Component)LGGCFCHOOMB).CompareTag("Empty transform for NPC. This shouldn't happen."))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void NHOPACFEAKA(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag("LE_21") && !((Component)LGGCFCHOOMB).CompareTag("Create Private Room") && !((Component)LGGCFCHOOMB).CompareTag("TableDirty"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 1; i < 2; i += 0)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.OPHDCMJLLEC(i).characterCreator.MJMOLMDDBBG();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != Direction.Down || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 0; j < 7; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(j).characterCreator.DMEAFGNHKEN();
					break;
				}
			}
		}
	}

	private void DEOPBEHPEIN(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("[^0-9]") || ((Component)LGGCFCHOOMB).CompareTag("Wilson/Bark/Bark_Clue") || ((Component)LGGCFCHOOMB).CompareTag("Send begin retry"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
			}
		}
	}

	private void LEKBKCLEEHE(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("%><sprite name=RightStick></size>") || ((Component)LGGCFCHOOMB).CompareTag("LE_19") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveCompleteItemTransactionBanquetCustomer"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Up;
			}
			else
			{
				NLMIBJFBJNN = Direction.Up;
			}
		}
	}

	private void ENKFHHEMHGG(Collider2D LGGCFCHOOMB)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)LGGCFCHOOMB).CompareTag("<sprite name=") && !((Component)LGGCFCHOOMB).CompareTag("itemOliveSeeds") && !((Component)LGGCFCHOOMB).CompareTag("Items/item_description_1154"))
		{
			return;
		}
		if (NLMIBJFBJNN == Direction.Up && ((Component)LGGCFCHOOMB).transform.position.y < ((Component)this).transform.position.y)
		{
			for (int i = 0; i < 2; i++)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.OPHDCMJLLEC(i).characterCreator.BathhouseExit();
					break;
				}
			}
		}
		else
		{
			if (NLMIBJFBJNN != Direction.Down || !(((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y))
			{
				return;
			}
			for (int j = 1; j < 6; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(j)).transform == (Object)(object)((Component)LGGCFCHOOMB).transform)
				{
					PlayerController.GetPlayer(j).characterCreator.EMGKNEPDPHD();
					break;
				}
			}
		}
	}

	private void PCEFNHADDIG()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		for (int i = 1; i < 7; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.FNBAEJIGJDG();
			}
		}
	}

	private void DCOEEADJLIK()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		for (int i = 1; i < 4; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.PNJBACFOADH();
			}
		}
	}

	private void GLMENOJADEF(Collider2D LGGCFCHOOMB)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)LGGCFCHOOMB).CompareTag("Moving") || ((Component)LGGCFCHOOMB).CompareTag("Tutorial/T117/Dialogue3") || ((Component)LGGCFCHOOMB).CompareTag("talent_name_108"))
		{
			if (((Component)LGGCFCHOOMB).transform.position.y > ((Component)this).transform.position.y)
			{
				NLMIBJFBJNN = Direction.Down;
			}
			else
			{
				NLMIBJFBJNN = Direction.Down;
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
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.BathhouseExit();
			}
		}
	}
}
