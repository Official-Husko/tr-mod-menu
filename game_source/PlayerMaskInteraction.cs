using System.Collections.Generic;
using UnityEngine;

public class PlayerMaskInteraction : MonoBehaviour
{
	public SpriteMask[] masks;

	private List<Collider2D> FIEHLBHMFGN = new List<Collider2D>();

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("<br/>Processor Type: ") || ((Component)HANHCHBHHEH).CompareTag("ReceiveStartMission") || ((Component)HANHCHBHHEH).CompareTag("0"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)8;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void GBFBNCBDIOC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Bait") || ((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("Pick"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)4;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void DCFEMOFDLHH(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Bucket") && !((Component)HANHCHBHHEH).CompareTag(":") && !((Component)HANHCHBHHEH).CompareTag("Tutorial/T137/Dialogue2"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 0)
		{
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void HHGJLOKEPJE(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("DecorationTile_16") && !((Component)HANHCHBHHEH).CompareTag("quest_objective_") && !((Component)HANHCHBHHEH).CompareTag("[Grey"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
		}
	}

	private void ABKKNODLBNL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ToFish") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_597") || ((Component)HANHCHBHHEH).CompareTag("itemRosemarySeeds"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)2;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void PDCKFGAJDJP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1053") || ((Component)HANHCHBHHEH).CompareTag("UIScrollDown") || ((Component)HANHCHBHHEH).CompareTag(" "))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)5;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Tutorial_Main_") || ((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("Invalid time range specified."))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void MJOLOCPMMBM(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("ReceivePipePuzzleSolved") && !((Component)HANHCHBHHEH).CompareTag("User ") && !((Component)HANHCHBHHEH).CompareTag("Game"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void IMOHIBLLPIB(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("ReceiveStopNinjaSoundPreparation") && !((Component)HANHCHBHHEH).CompareTag("ERROR: The object ") && !((Component)HANHCHBHHEH).CompareTag(""))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void EKJIEGLPBLA(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Ingredient null!") && !((Component)HANHCHBHHEH).CompareTag("ReceiveRemoveOrderQuest") && !((Component)HANHCHBHHEH).CompareTag("Error_CannotPickUpDirtyTable"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 0)
		{
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
		}
	}

	private void IODLDNOGLLC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("itemBiscuitWort") || ((Component)HANHCHBHHEH).CompareTag("Player/Bark/Error/NotAllPlayersHere") || ((Component)HANHCHBHHEH).CompareTag("R2"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)4;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void FADCNMKMAFI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("d2") || ((Component)HANHCHBHHEH).CompareTag("MapCity") || ((Component)HANHCHBHHEH).CompareTag("itemSausage"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)5;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void DEKJGPJMAPC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("MainProgress") || ((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("ReceiveObjectInteract"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)6;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void GEFCGLEGHOA(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("F2") && !((Component)HANHCHBHHEH).CompareTag("LE_10") && !((Component)HANHCHBHHEH).CompareTag("Desactivando el variant "))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void KGAPHAIFAFH(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Win") && !((Component)HANHCHBHHEH).CompareTag("talentBread") && !((Component)HANHCHBHHEH).CompareTag("textName InstanceId: {0}  {1}  {2}  {3}"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
		}
		for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void BNOJNEJMCID(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("LE_21") || ((Component)HANHCHBHHEH).CompareTag("Open") || ((Component)HANHCHBHHEH).CompareTag("Items/item_description_702"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)8;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void HJMGMIKGPOI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Example Method With Custom ID") || ((Component)HANHCHBHHEH).CompareTag("Received cursor move for grid index {0} from player {1} in mine level {2}") || ((Component)HANHCHBHHEH).CompareTag("RecieveMaiInBar"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Error_OccupiedRoom") || ((Component)HANHCHBHHEH).CompareTag("LE_22") || ((Component)HANHCHBHHEH).CompareTag("ReceiveSitDown"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void LIEIDOIDBLJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1097") || ((Component)HANHCHBHHEH).CompareTag("/ExtraSettings.sd") || ((Component)HANHCHBHHEH).CompareTag("houseKeeperWage"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)8;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void KCDMOOPJBMM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(", ") || ((Component)HANHCHBHHEH).CompareTag("BathhouseEntrace/Main 2") || ((Component)HANHCHBHHEH).CompareTag("Available Orders"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)3;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void NKJMIFCPJFA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveSwitchFoodAtTables") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_1144") || ((Component)HANHCHBHHEH).CompareTag("RochelleProgress"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)5;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void BLOCHBJIICN(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("waterBowlDesc") && !((Component)HANHCHBHHEH).CompareTag("/Female/") && !((Component)HANHCHBHHEH).CompareTag("City/Carpenters/Oak/Chisel"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
		}
	}

	private void AHKDANJMEMC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("City/Lia/Bark/Stand") || ((Component)HANHCHBHHEH).CompareTag("Game is already running") || ((Component)HANHCHBHHEH).CompareTag("ReceiveLookAtPlayer"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void ILOJBCEKLDF(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Player2") && !((Component)HANHCHBHHEH).CompareTag("TorchPuzzle requires TorchPuzzleSettings") && !((Component)HANHCHBHHEH).CompareTag("UI"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
		}
	}

	private void ILNDDFELMKL(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("ChatBarkRPC") && !((Component)HANHCHBHHEH).CompareTag(" ") && !((Component)HANHCHBHHEH).CompareTag(" "))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 0)
		{
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
		}
	}

	private void OGNMEEEBLJC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UIVolume") || ((Component)HANHCHBHHEH).CompareTag("XNewRecipes") || ((Component)HANHCHBHHEH).CompareTag("TakesXDaysToGrow"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)4;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void EMCFHILONOH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_593") || ((Component)HANHCHBHHEH).CompareTag("FarmReady") || ((Component)HANHCHBHHEH).CompareTag("Pick up"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void CNLANNFMFCN(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Disabled") && !((Component)HANHCHBHHEH).CompareTag("Eyebrows") && !((Component)HANHCHBHHEH).CompareTag("itemLemon"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 0)
		{
			for (int i = 0; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Message queue is running") || ((Component)HANHCHBHHEH).CompareTag("Disabled") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Quest/Entry/1/Dialogue Text"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)8;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void ILJJIFMJICA(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Pirates/Brook/Intro") && !((Component)HANHCHBHHEH).CompareTag("LE_10") && !((Component)HANHCHBHHEH).CompareTag("UI"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
		}
		for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("itemBellPepperSeeds") || ((Component)HANHCHBHHEH).CompareTag("yyyy-MM-dd_HH-mm-ss") || ((Component)HANHCHBHHEH).CompareTag("cropsHarvested"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void GBBOHCFOJLH(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("OnlinePlayer") && !((Component)HANHCHBHHEH).CompareTag("") && !((Component)HANHCHBHHEH).CompareTag("Items/item_name_1444"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void HIMBLFNCDLL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Create Public Room") || ((Component)HANHCHBHHEH).CompareTag("Error in PhaseController.OnPlayerSleep: ") || ((Component)HANHCHBHHEH).CompareTag("Information"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void CIMPOOJOMMH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Failed to get friend ") || ((Component)HANHCHBHHEH).CompareTag(": [") || ((Component)HANHCHBHHEH).CompareTag("UIPreviousCategory"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)7;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void LMNMPBNMGCH(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("ReceiveAnimalWalk") && !((Component)HANHCHBHHEH).CompareTag("Talk") && !((Component)HANHCHBHHEH).CompareTag(":"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 0)
		{
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void IBINNLHHLMD(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("[GetFallbackCandidates] Total fallback candidates: {0}") && !((Component)HANHCHBHHEH).CompareTag("NPC") && !((Component)HANHCHBHHEH).CompareTag("Walk"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void MGJIGIBHAKK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" - <b><color=#8C78BA>") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/18/Dialogue Text") || ((Component)HANHCHBHHEH).CompareTag("DLC "))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void DHIOKICDPIK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("add item 1445 20") || ((Component)HANHCHBHHEH).CompareTag("DismissWorker?") || ((Component)HANHCHBHHEH).CompareTag("Invalid playerNum"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void NBHAMBCMEGD(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Collect") && !((Component)HANHCHBHHEH).CompareTag("Waiting for other players") && !((Component)HANHCHBHHEH).CompareTag("Items/item_description_1037"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 0)
		{
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void MDODDIKGEHI(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("New_Recipe") && !((Component)HANHCHBHHEH).CompareTag("Staff") && !((Component)HANHCHBHHEH).CompareTag("BarkActor"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 0)
		{
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
		}
		for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void EKNEIMIENPG(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag(" for reason ") && !((Component)HANHCHBHHEH).CompareTag("Right") && !((Component)HANHCHBHHEH).CompareTag("Beta "))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
		}
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveSetLife") || ((Component)HANHCHBHHEH).CompareTag("Put") || ((Component)HANHCHBHHEH).CompareTag(":"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)8;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveUpdatePoints") || ((Component)HANHCHBHHEH).CompareTag("challenges") || ((Component)HANHCHBHHEH).CompareTag("Key2"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void JMNPLNAGLCO(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Boots_L") && !((Component)HANHCHBHHEH).CompareTag("MainProgress") && !((Component)HANHCHBHHEH).CompareTag("Player/Bark/Tutorial/T138"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 0)
		{
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
		}
	}

	private void OJOMNJEFKOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("[Awning:{0}] CloseAwning called. isOpen={1} animatorBool={2}") || ((Component)HANHCHBHHEH).CompareTag("Sell") || ((Component)HANHCHBHHEH).CompareTag("RecieveSetAmbience"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)7;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Room occupied") || ((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("Error_BarNotInADiningRoom"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)8;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void ENKFHHEMHGG(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("[MinePuzzleManager] Found {0} altar pieces. IsBigPuzzle:{1} PuzzleSpawners:{2} SingleSpawnerMode:{3}.") && !((Component)HANHCHBHHEH).CompareTag("Items/item_description_1059") && !((Component)HANHCHBHHEH).CompareTag("Close"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void LEKBKCLEEHE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Moving") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_1115") || ((Component)HANHCHBHHEH).CompareTag("): "))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)7;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveStartCrowlyEvent") || ((Component)HANHCHBHHEH).CompareTag("LE_3") || ((Component)HANHCHBHHEH).CompareTag("HollyAnimalShop"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)4;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void NGCPHGCKLGP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Create Public Room") || ((Component)HANHCHBHHEH).CompareTag("SelectPlaceableIfIsPossibleMaster") || ((Component)HANHCHBHHEH).CompareTag(""))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void MOJBKEGFHOD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Inventory full") || ((Component)HANHCHBHHEH).CompareTag("[PipeConnectionPuzzleUI] Falta _gridContainer.") || ((Component)HANHCHBHHEH).CompareTag("DeselectPlaceableOthers"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)8;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void OCMFFLLPHCK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("OpenTavern") || ((Component)HANHCHBHHEH).CompareTag("Value null of key: ") || ((Component)HANHCHBHHEH).CompareTag("itemIPAWort"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)6;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void ONNMDGBPGEI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Walk") || ((Component)HANHCHBHHEH).CompareTag("UIBack") || ((Component)HANHCHBHHEH).CompareTag(""))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)4;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void LDPNAPIGIIA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Null editor action in database") || ((Component)HANHCHBHHEH).CompareTag("AdjustingGraphicsQuality") || ((Component)HANHCHBHHEH).CompareTag("Time left:"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Player2") || ((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)2;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void DGLMPEODEKI(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TavernDirty/Entry/1/Dialogue Text") && !((Component)HANHCHBHHEH).CompareTag("Player") && !((Component)HANHCHBHHEH).CompareTag("Hoppy"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 0; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
		}
	}

	private void JGBLJPDNLMO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UI") || ((Component)HANHCHBHHEH).CompareTag("<br/>Graphics Memory Size: ") || ((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)8;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void KJJINNGPPEA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("itemRaspberry") || ((Component)HANHCHBHHEH).CompareTag(":</color> <sprite name=\"ChristmasTicket\">") || ((Component)HANHCHBHHEH).CompareTag("LE_12"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)6;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void LJJNLJILINI(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Player") && !((Component)HANHCHBHHEH).CompareTag("volume") && !((Component)HANHCHBHHEH).CompareTag("Body"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void DJNNHILGACE(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("NewCharacters/") && !((Component)HANHCHBHHEH).CompareTag("ReceivePhaseSlotFromContainer") && !((Component)HANHCHBHHEH).CompareTag("\n  doorSprite:         "))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 0)
		{
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
		}
		for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Player") && !((Component)HANHCHBHHEH).CompareTag("Player2") && !((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 0)
		{
			for (int i = 0; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
		}
	}

	private void MOKLBANPFGM(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("RecieveSetAmbience") && !((Component)HANHCHBHHEH).CompareTag("\n") && !((Component)HANHCHBHHEH).CompareTag("Items/item_name_607"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
		}
		for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void DMENPMHIPDA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Introduce/Entry/36/Dialogue Text") || ((Component)HANHCHBHHEH).CompareTag("BarnTutorialDone") || ((Component)HANHCHBHHEH).CompareTag("ReceiveMaiEventStart"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void BOBJMDGALPM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("tavern") || ((Component)HANHCHBHHEH).CompareTag("Could not check user signed in status for reason ") || ((Component)HANHCHBHHEH).CompareTag("Invalid player num"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)4;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void PPJEJKCPCLC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Language") || ((Component)HANHCHBHHEH).CompareTag("Top") || ((Component)HANHCHBHHEH).CompareTag("Walk"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)2;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("/Male/") || ((Component)HANHCHBHHEH).CompareTag("ObjectHorizontalMove") || ((Component)HANHCHBHHEH).CompareTag(""))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)3;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("City/Petra/Introduce") || ((Component)HANHCHBHHEH).CompareTag("ReceiveDisableContent") || ((Component)HANHCHBHHEH).CompareTag("- "))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)8;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void DNDNCBILKMB(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("player2ToDisconnectFromGame") && !((Component)HANHCHBHHEH).CompareTag("is_master") && !((Component)HANHCHBHHEH).CompareTag("Received finish minigame"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void LJJDGAJNNCH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("HostDisconnected") || ((Component)HANHCHBHHEH).CompareTag("Items/item_description_675") || ((Component)HANHCHBHHEH).CompareTag("\n  animationSprites:   "))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" nulo en ") || ((Component)HANHCHBHHEH).CompareTag("Staff") || ((Component)HANHCHBHHEH).CompareTag("AttackBird"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)4;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void DEPAEALFAEJ(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag(" in the database!") && !((Component)HANHCHBHHEH).CompareTag("Occupied Positions") && !((Component)HANHCHBHHEH).CompareTag("Walk"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j++)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" not found when loading RockMessage.") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TavernClean/Entry/3/Dialogue Text") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_1094"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)2;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void KCDODEOOBHG(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("HaveGoldenTicket") && !((Component)HANHCHBHHEH).CompareTag("Player") && !((Component)HANHCHBHHEH).CompareTag("Lose"))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 0)
		{
			for (int i = 0; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 0; j < component.characterAnimator.allReskins.Length; j += 0)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)1;
		}
	}

	private void PDCJGGJMPCN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UI") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TooCold/Entry/4/Dialogue Text") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_1064"))
		{
			CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			for (int i = 1; i < masks.Length; i++)
			{
				((Renderer)masks[i]).enabled = true;
			}
			for (int j = 1; j < component.characterAnimator.allReskins.Length; j += 0)
			{
				component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)2;
			}
			if (!FIEHLBHMFGN.Contains(HANHCHBHHEH))
			{
				FIEHLBHMFGN.Add(HANHCHBHHEH);
			}
		}
	}

	private void EIEKPEEPFGA(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("") && !((Component)HANHCHBHHEH).CompareTag("") && !((Component)HANHCHBHHEH).CompareTag("in "))
		{
			return;
		}
		FIEHLBHMFGN.Remove(HANHCHBHHEH);
		CharacterAnimation component = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
		if (FIEHLBHMFGN.Count <= 1)
		{
			for (int i = 0; i < masks.Length; i += 0)
			{
				((Renderer)masks[i]).enabled = false;
			}
		}
		for (int j = 1; j < component.characterAnimator.allReskins.Length; j++)
		{
			component.characterAnimator.allReskins[j].spriteRenderer.maskInteraction = (SpriteMaskInteraction)0;
		}
	}
}
