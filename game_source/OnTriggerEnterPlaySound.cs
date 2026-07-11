using System.Collections.Generic;
using AlmenaraGames;
using UnityEngine;

public class OnTriggerEnterPlaySound : MonoBehaviour
{
	public List<string> tags;

	public AudioObject sound;

	public Placeable placeable;

	public float nextActivationWait = 40f;

	public float loopFadeOutTime = 5f;

	public bool fadeIn;

	public float fadeInTime = 5f;

	private float DEDHOAHGCIF;

	private bool MJGGACBHMHO;

	private bool IMEKKIFIBBP;

	private bool[] JKBMGFHGBAC = new bool[3];

	private bool GDCLFLFLFBM;

	private MultiAudioSource ODHLEHJPGKP;

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[8] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("target fps"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 5:
				JKBMGFHGBAC[1] = true;
				break;
			case 7:
				JKBMGFHGBAC[0] = true;
				break;
			case 3:
				JKBMGFHGBAC[2] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/26/Dialogue Text"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player/Bark/Tutorial/SleepBlock") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 2:
				JKBMGFHGBAC[0] = false;
				break;
			case 3:
				JKBMGFHGBAC[1] = false;
				break;
			case 4:
				JKBMGFHGBAC[2] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Cat"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[2] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void ILOJBCEKLDF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("us"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Drink"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 0:
				JKBMGFHGBAC[1] = true;
				break;
			case 1:
				JKBMGFHGBAC[1] = true;
				break;
			case 4:
				JKBMGFHGBAC[5] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Current map: "))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" value "))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[7] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void NBHAMBCMEGD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveGenerateMineLevel"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("F3"))
		{
			int playerNum = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum();
			if (playerNum == 1)
			{
				JKBMGFHGBAC[1] = false;
			}
			else
			{
				switch (playerNum)
				{
				case 1:
					JKBMGFHGBAC[0] = true;
					break;
				case 5:
					JKBMGFHGBAC[1] = false;
					break;
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("(Player 2) Press "))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(")"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void LHGOFNEIMNN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("IdleCamp"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("): "))
		{
			int playerNum = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum();
			switch (playerNum)
			{
			case 7:
				JKBMGFHGBAC[0] = false;
				break;
			case 0:
				JKBMGFHGBAC[0] = true;
				break;
			default:
				if (playerNum == 7)
				{
					JKBMGFHGBAC[7] = true;
				}
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Lager"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Tray"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[5] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void HJMGMIKGPOI(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[5] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("]"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("MainProgress"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 4:
				JKBMGFHGBAC[1] = true;
				break;
			case 6:
				JKBMGFHGBAC[0] = true;
				break;
			case 7:
				JKBMGFHGBAC[7] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("MopUp"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void ONNMDGBPGEI(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[4] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("add to\nIntensity"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemRoastedChicken"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 5:
				JKBMGFHGBAC[1] = false;
				break;
			case 1:
				JKBMGFHGBAC[0] = false;
				break;
			case 2:
				JKBMGFHGBAC[3] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" "))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Error_Planks") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void DHIOKICDPIK(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("sForSeconds"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Pants_R"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 7:
				JKBMGFHGBAC[1] = true;
				break;
			case 6:
				JKBMGFHGBAC[0] = true;
				break;
			case 3:
				JKBMGFHGBAC[3] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("immediately"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("NoActiveMultiDoor") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void APJFDMCLDBD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("AddObjectInDictionary() uniqueId "))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(". Size (bytes): "))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 1:
				JKBMGFHGBAC[0] = false;
				break;
			case 6:
				JKBMGFHGBAC[0] = false;
				break;
			case 7:
				JKBMGFHGBAC[7] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Crop with ID "))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UI2"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[2] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void DEOPBEHPEIN(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[6] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Ach_"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T101/Dialogue2"))
		{
			int playerNum = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum();
			switch (playerNum)
			{
			case 6:
				JKBMGFHGBAC[0] = false;
				return;
			case 0:
				JKBMGFHGBAC[0] = false;
				return;
			}
			if (playerNum == 6)
			{
				JKBMGFHGBAC[5] = true;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("TucanEgg"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/13/Dialogue Text") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void FJEKAKFLJJM(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Idle"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("TucanEgg"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 3:
				JKBMGFHGBAC[0] = true;
				break;
			case 7:
				JKBMGFHGBAC[1] = false;
				break;
			case 4:
				JKBMGFHGBAC[6] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Idle"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemLargeRock") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[5] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("letter"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("City/PetShop/Nessy/Stand"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 4:
				JKBMGFHGBAC[1] = false;
				break;
			case 6:
				JKBMGFHGBAC[1] = true;
				break;
			case 1:
				JKBMGFHGBAC[6] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Attack/MainEvent 6"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_626") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void EKNEIMIENPG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UIAddRemove"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Hurt"))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			if (num == 6)
			{
				JKBMGFHGBAC[0] = true;
			}
			else
			{
				switch (num)
				{
				case 6:
					JKBMGFHGBAC[1] = true;
					break;
				case 7:
					JKBMGFHGBAC[3] = false;
					break;
				}
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("BARKEVENT"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(") ("))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void DMENPMHIPDA(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[2] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Selected"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/28/Dialogue Text"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 7:
				JKBMGFHGBAC[1] = true;
				break;
			case 6:
				JKBMGFHGBAC[1] = false;
				break;
			case 5:
				JKBMGFHGBAC[8] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Null ControllerInfo in database"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Start") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void NPCEFHCNJGE(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[5] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Melt"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("NotMyChest"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 8:
				JKBMGFHGBAC[0] = true;
				break;
			case 3:
				JKBMGFHGBAC[0] = false;
				break;
			case 4:
				JKBMGFHGBAC[2] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Plant"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void DGJCAFPEJHL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("hForHours"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Path node error. Only 1 node at [0, 0] "))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 4:
				JKBMGFHGBAC[1] = true;
				break;
			case 5:
				JKBMGFHGBAC[0] = false;
				break;
			case 2:
				JKBMGFHGBAC[4] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Disabled"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("<br>"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[8] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[2] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("ToggleEntityView"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ExampleScripted"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 5:
				JKBMGFHGBAC[0] = true;
				break;
			case 2:
				JKBMGFHGBAC[0] = true;
				break;
			case 4:
				JKBMGFHGBAC[3] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" ("))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Right") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[2] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 2:
				JKBMGFHGBAC[0] = true;
				break;
			case 3:
				JKBMGFHGBAC[1] = true;
				break;
			case 4:
				JKBMGFHGBAC[2] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Cat") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void KGAPHAIFAFH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Serve"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UI"))
		{
			int playerNum = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum();
			switch (playerNum)
			{
			case 2:
				JKBMGFHGBAC[0] = false;
				break;
			case 1:
				JKBMGFHGBAC[0] = false;
				break;
			default:
				if (playerNum == 1)
				{
					JKBMGFHGBAC[2] = true;
				}
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Floor_6"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Reject"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[5] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[4] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Player/Bark/Error/NotAllPlayersHere"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("AceT_Quest"))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			switch (num)
			{
			case 3:
				JKBMGFHGBAC[1] = true;
				return;
			case 5:
				JKBMGFHGBAC[1] = true;
				return;
			}
			if (num == 5)
			{
				JKBMGFHGBAC[3] = false;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("positions count is 0"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("<size=") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void MOOJEOLFOOC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceivePlayerInBed"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("zuzzu"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 7:
				JKBMGFHGBAC[1] = false;
				break;
			case 1:
				JKBMGFHGBAC[1] = true;
				break;
			case 4:
				JKBMGFHGBAC[6] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" (versionOfCropsAndRecipes)"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Networked Object "))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[5] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void BIJGJOMFNOJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("CutEnd"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 3:
				JKBMGFHGBAC[0] = true;
				break;
			case 7:
				JKBMGFHGBAC[1] = true;
				break;
			case 4:
				JKBMGFHGBAC[1] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("hForHours"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[2] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Starting New Game Coroutine FINISHED"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("add item "))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 1:
				JKBMGFHGBAC[0] = true;
				break;
			case 2:
				JKBMGFHGBAC[0] = true;
				break;
			case 7:
				JKBMGFHGBAC[1] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1033"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("add item ") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void BNOJNEJMCID(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[5] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("NULL"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Cross"))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			switch (num)
			{
			case 0:
				JKBMGFHGBAC[1] = false;
				return;
			case 8:
				JKBMGFHGBAC[1] = true;
				return;
			}
			if (num == 8)
			{
				JKBMGFHGBAC[2] = true;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveDirection"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveShopInfo") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void AIOJHEKNMIC(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("MineState"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 5:
				JKBMGFHGBAC[1] = false;
				break;
			case 8:
				JKBMGFHGBAC[0] = false;
				break;
			case 3:
				JKBMGFHGBAC[5] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("High"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Item ") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void DAGGKPKBCLD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("["))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UI"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 3:
				JKBMGFHGBAC[0] = false;
				break;
			case 2:
				JKBMGFHGBAC[0] = true;
				break;
			case 6:
				JKBMGFHGBAC[8] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Farm/Violet/Main"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Walk"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[6] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void ABKKNODLBNL(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("popUpBuilding36"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("BARKEVENT"))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			if (num == 7)
			{
				JKBMGFHGBAC[1] = false;
				return;
			}
			switch (num)
			{
			case 7:
				JKBMGFHGBAC[1] = true;
				break;
			case 1:
				JKBMGFHGBAC[2] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Deselect item") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void BOBJMDGALPM(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[5] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Building"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Disabled"))
		{
			int playerNum = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum();
			switch (playerNum)
			{
			case 2:
				JKBMGFHGBAC[1] = true;
				return;
			case 3:
				JKBMGFHGBAC[1] = true;
				return;
			}
			if (playerNum == 3)
			{
				JKBMGFHGBAC[8] = false;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Direction"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("DynamicIntensity") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void KKONKMFFILD(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("itemGrainBag"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Floor workerDesc"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 3:
				JKBMGFHGBAC[1] = false;
				break;
			case 7:
				JKBMGFHGBAC[0] = true;
				break;
			case 4:
				JKBMGFHGBAC[1] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Use") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void NDDNAEAMADD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("questDescMalting"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Body"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 6:
				JKBMGFHGBAC[0] = false;
				break;
			case 7:
				JKBMGFHGBAC[1] = false;
				break;
			case 4:
				JKBMGFHGBAC[0] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Occupied Positions"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Unlocked at Tavern Reputation {0}"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[4] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void HEOHCIAMEPD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1087"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Introduce/Entry/8/Dialogue Text"))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			switch (num)
			{
			case 0:
				JKBMGFHGBAC[1] = false;
				break;
			case 4:
				JKBMGFHGBAC[1] = true;
				break;
			default:
				if (num == 4)
				{
					JKBMGFHGBAC[8] = true;
				}
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Failed to download file with ID "))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Initial Customer State Machine values are null."))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[7] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void JGBLJPDNLMO(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[4] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("autoRunP2"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_661"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 8:
				JKBMGFHGBAC[1] = false;
				break;
			case 0:
				JKBMGFHGBAC[1] = false;
				break;
			case 5:
				JKBMGFHGBAC[8] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Melt"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("parent destroyed: {0}") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void MOKLBANPFGM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Unsaved progress will be lost."))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 8:
				JKBMGFHGBAC[0] = false;
				break;
			case 7:
				JKBMGFHGBAC[1] = true;
				break;
			case 2:
				JKBMGFHGBAC[6] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("SprintHoldAction"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[8] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void LBJEAHNNMCN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Keg empty"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Perks/playerPerk_description_"))
		{
			int playerNum = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum();
			switch (playerNum)
			{
			case 0:
				JKBMGFHGBAC[0] = true;
				break;
			case 5:
				JKBMGFHGBAC[1] = true;
				break;
			default:
				if (playerNum == 0)
				{
					JKBMGFHGBAC[2] = true;
				}
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("BrookProgress"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[6] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void ILNDDFELMKL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(". Can no instantiate online placeable. rotated: "))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("popUpBuilding2B"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 3:
				JKBMGFHGBAC[1] = false;
				break;
			case 8:
				JKBMGFHGBAC[0] = true;
				break;
			case 2:
				JKBMGFHGBAC[6] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Connecting..."))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" ExitState()."))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[7] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void HIDDNMLHBFJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Deserialize SettingsData error: /ExtraSettings.sd"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Closed"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 1:
				JKBMGFHGBAC[0] = false;
				break;
			case 2:
				JKBMGFHGBAC[1] = true;
				break;
			case 3:
				JKBMGFHGBAC[3] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("/Player.log"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TooCold/Entry/1/Dialogue Text"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void IBINNLHHLMD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(">"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("BARKBUZZ"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 4:
				JKBMGFHGBAC[0] = false;
				break;
			case 0:
				JKBMGFHGBAC[1] = false;
				break;
			case 8:
				JKBMGFHGBAC[7] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("descPaperCoaster"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UI2"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void ENKFHHEMHGG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("SetBoolRPC"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("kickedCustomers"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 4:
				JKBMGFHGBAC[0] = false;
				break;
			case 6:
				JKBMGFHGBAC[1] = true;
				break;
			case 1:
				JKBMGFHGBAC[8] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("DiscusionMineros/Main"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemRoseWine"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void ACKAOKBCDCJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ClosePopUp"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Can't find seat. Reason: MaxCustomer"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 7:
				JKBMGFHGBAC[1] = true;
				break;
			case 1:
				JKBMGFHGBAC[0] = true;
				break;
			case 4:
				JKBMGFHGBAC[4] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" not found in OnlineEventsManager. Cannot start observe dialogue"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Drink"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void DAJNPOGFLLJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("PlayerJoined_F"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("WorkAnimationLoop"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 1:
				JKBMGFHGBAC[1] = false;
				break;
			case 0:
				JKBMGFHGBAC[1] = true;
				break;
			case 6:
				JKBMGFHGBAC[2] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("City/Lia/Bark/Stand"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Cider"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[2] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void OHDEOCEKHBM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("\n"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveFollow"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 5:
				JKBMGFHGBAC[0] = true;
				break;
			case 6:
				JKBMGFHGBAC[1] = false;
				break;
			case 8:
				JKBMGFHGBAC[8] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(":0"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UseHold"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[2] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void EDCINHFBGAN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(")"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player minigame states: \n {0}, {1}, {2}, {3},"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 4:
				JKBMGFHGBAC[0] = false;
				break;
			case 6:
				JKBMGFHGBAC[1] = true;
				break;
			case 3:
				JKBMGFHGBAC[1] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("vibration"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("descGrog"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[2] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void CMJBBBHGHCD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Modifier requirement not met"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemTurnipSeeds"))
		{
			int playerNum = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum();
			switch (playerNum)
			{
			case 3:
				JKBMGFHGBAC[0] = false;
				break;
			case 4:
				JKBMGFHGBAC[0] = false;
				break;
			default:
				if (playerNum == 3)
				{
					JKBMGFHGBAC[0] = true;
				}
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("quest_reward_27_28_29"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Miners/Mine/Ferro/Bomb"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void GEFCGLEGHOA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("BarkActor"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveAdoptionRequest"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 4:
				JKBMGFHGBAC[0] = false;
				break;
			case 6:
				JKBMGFHGBAC[0] = false;
				break;
			case 0:
				JKBMGFHGBAC[4] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Thurs"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Game"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[2] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void CNLANNFMFCN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("itemBlackAle"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 2:
				JKBMGFHGBAC[1] = false;
				break;
			case 0:
				JKBMGFHGBAC[1] = false;
				break;
			case 7:
				JKBMGFHGBAC[3] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Random"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_594"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[4] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void NAFADNEKCOH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Toy"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("setDefaultSettings"))
		{
			int playerNum = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum();
			switch (playerNum)
			{
			case 8:
				JKBMGFHGBAC[0] = false;
				break;
			case 1:
				JKBMGFHGBAC[0] = false;
				break;
			default:
				if (playerNum == 1)
				{
					JKBMGFHGBAC[0] = true;
				}
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T127/Dialogue1"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Build mode active"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[5] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void KIJDNFODCKJ(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[8] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Could not find item with id: "))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Lightning3"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 5:
				JKBMGFHGBAC[1] = true;
				break;
			case 3:
				JKBMGFHGBAC[1] = true;
				break;
			case 2:
				JKBMGFHGBAC[4] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("BrookProgress"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("/BarkMai") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void ILJJIFMJICA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Demolish"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 5:
				JKBMGFHGBAC[1] = true;
				break;
			case 8:
				JKBMGFHGBAC[0] = false;
				break;
			case 6:
				JKBMGFHGBAC[0] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Unique id "))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LE_10"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[7] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void LDPNAPIGIIA(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("LE_21"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Scene"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 2:
				JKBMGFHGBAC[1] = false;
				break;
			case 7:
				JKBMGFHGBAC[0] = true;
				break;
			case 6:
				JKBMGFHGBAC[4] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("cameraZoom2"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("' no referencia correctamente al item '") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void JMNPLNAGLCO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" for reason "))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			switch (num)
			{
			case 4:
				JKBMGFHGBAC[1] = false;
				break;
			case 2:
				JKBMGFHGBAC[0] = true;
				break;
			default:
				if (num == 2)
				{
					JKBMGFHGBAC[6] = true;
				}
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("BirdInAChest_Error"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" ("))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[2] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void CIMPOOJOMMH(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[4] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("[MinePuzzleManager] Ordered puzzle queue for level {0}: [{1}]"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveFireCannonball"))
		{
			int playerNum = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum();
			switch (playerNum)
			{
			case 3:
				JKBMGFHGBAC[1] = true;
				return;
			case 0:
				JKBMGFHGBAC[1] = true;
				return;
			}
			if (playerNum == 3)
			{
				JKBMGFHGBAC[1] = false;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Thickness"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Near") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void LEKBKCLEEHE(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[3] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1052"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Objective"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 7:
				JKBMGFHGBAC[1] = false;
				break;
			case 6:
				JKBMGFHGBAC[1] = false;
				break;
			case 0:
				JKBMGFHGBAC[3] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(":"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemFence") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[5] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("LE_21"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LevelX"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 4:
				JKBMGFHGBAC[0] = true;
				break;
			case 6:
				JKBMGFHGBAC[0] = false;
				break;
			case 5:
				JKBMGFHGBAC[4] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_608"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemHoney") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void LJJDGAJNNCH(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[3] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_613"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Doubt"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 7:
				JKBMGFHGBAC[0] = true;
				break;
			case 0:
				JKBMGFHGBAC[0] = true;
				break;
			case 5:
				JKBMGFHGBAC[8] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" not found. Cannot ReceiveChangeStack"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("BarnTutorialDone") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void KEICGGPGIED(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Stand/Entry/5/Dialogue Text"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" "))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 7:
				JKBMGFHGBAC[0] = true;
				break;
			case 3:
				JKBMGFHGBAC[0] = false;
				break;
			case 5:
				JKBMGFHGBAC[8] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Attack/MainEvent 7"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[6] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void EIEKPEEPFGA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("/"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 7:
				JKBMGFHGBAC[0] = false;
				break;
			case 0:
				JKBMGFHGBAC[0] = true;
				break;
			case 1:
				JKBMGFHGBAC[3] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Cat"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("\">"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[6] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void GBBOHCFOJLH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1084"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Statue2={0}"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 6:
				JKBMGFHGBAC[0] = true;
				break;
			case 2:
				JKBMGFHGBAC[1] = false;
				break;
			case 3:
				JKBMGFHGBAC[5] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/NeutralInTavern/Entry/18/Dialogue Text"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("PlayerJoined"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[6] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void LJJNLJILINI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveFloorDirtInfo"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Drink"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 7:
				JKBMGFHGBAC[1] = false;
				break;
			case 5:
				JKBMGFHGBAC[1] = false;
				break;
			case 1:
				JKBMGFHGBAC[1] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Null ingredient!"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" not found"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[2] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void LMNMPBNMGCH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("\n</color>"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Customer tried to do seat found with close tavern "))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 1:
				JKBMGFHGBAC[0] = false;
				break;
			case 7:
				JKBMGFHGBAC[0] = false;
				break;
			case 5:
				JKBMGFHGBAC[0] = true;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UIAddRemove"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("KickedSpinDirection"))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[4] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, false);
			ODHLEHJPGKP = null;
		}
	}

	private void OFNKDCBEAHP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/31/Dialogue Text"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("FishBiteRPC"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 0:
				JKBMGFHGBAC[0] = true;
				break;
			case 1:
				JKBMGFHGBAC[1] = true;
				break;
			case 3:
				JKBMGFHGBAC[2] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/NeutralInTavern/Entry/7/Dialogue Text"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Unaged"))
		{
			GDCLFLFLFBM = true;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[8] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[5] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveDisable"))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/HappyRentRoom/Entry/2/Dialogue Text"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 2:
				JKBMGFHGBAC[0] = false;
				break;
			case 3:
				JKBMGFHGBAC[1] = false;
				break;
			case 5:
				JKBMGFHGBAC[7] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Spawners disponibles: {0}. Revisa configuración de prefabs o minRockSpawnPointsPerPiece."))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Jump") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = false;
		}
	}

	private void JJBAEDCPDFO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("player2ToDisconnectFromGame"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			switch (num)
			{
			case 0:
				JKBMGFHGBAC[0] = true;
				break;
			case 4:
				JKBMGFHGBAC[1] = true;
				break;
			default:
				if (num == 4)
				{
					JKBMGFHGBAC[5] = true;
				}
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveThrowSlowingSpikes"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			GDCLFLFLFBM = false;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[5] && Object.op_Implicit((Object)(object)ODHLEHJPGKP) && ODHLEHJPGKP.Loop)
		{
			ODHLEHJPGKP.FadeOut(loopFadeOutTime, true);
			ODHLEHJPGKP = null;
		}
	}

	private void FCONKHCGBEM(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[7] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Dig"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Perks/playerPerk_name_"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 4:
				JKBMGFHGBAC[0] = false;
				break;
			case 3:
				JKBMGFHGBAC[0] = true;
				break;
			case 8:
				JKBMGFHGBAC[1] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("1"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("DecorationTile_24") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void GAAKLENLEOF(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[4] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveActorPosition"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LE_2"))
		{
			int num = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP();
			switch (num)
			{
			case 6:
				JKBMGFHGBAC[0] = false;
				return;
			case 3:
				JKBMGFHGBAC[0] = true;
				return;
			}
			if (num == 3)
			{
				JKBMGFHGBAC[5] = false;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(":"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(")") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[8] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("[MineVariantsSelector] No valid variants available for piece {0} after full pool regeneration."))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Shader Model 5.0 ( DX11.0 )"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().KLIHELDIPDP())
			{
			case 5:
				JKBMGFHGBAC[1] = false;
				break;
			case 0:
				JKBMGFHGBAC[0] = false;
				break;
			case 7:
				JKBMGFHGBAC[6] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1444"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Shop without ID: ") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void IODLDNOGLLC(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[7] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag(", "))
		{
			MJGGACBHMHO = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("A new room will be created with the name: "))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 7:
				JKBMGFHGBAC[0] = true;
				break;
			case 2:
				JKBMGFHGBAC[1] = true;
				break;
			case 5:
				JKBMGFHGBAC[3] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Bouncer/") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void KJJINNGPPEA(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[1] && !JKBMGFHGBAC[1] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Quest Complete"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceivePipePuzzleSolved"))
		{
			int playerNum = ((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum();
			switch (playerNum)
			{
			case 3:
				JKBMGFHGBAC[1] = true;
				return;
			case 5:
				JKBMGFHGBAC[0] = true;
				return;
			}
			if (playerNum == 3)
			{
				JKBMGFHGBAC[4] = false;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LE_10"))
		{
			IMEKKIFIBBP = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player/Bark/Tutorial/CantDoYet") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		if ((!((Object)(object)placeable == (Object)null) && placeable.FHEMHCEAICB) || !tags.Contains(((Component)HANHCHBHHEH).tag))
		{
			return;
		}
		if (!MJGGACBHMHO && !IMEKKIFIBBP && !GDCLFLFLFBM && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[0] && !JKBMGFHGBAC[4] && DEDHOAHGCIF + nextActivationWait < Time.timeSinceLevelLoad)
		{
			DEDHOAHGCIF = Time.timeSinceLevelLoad;
			if (fadeIn)
			{
				ODHLEHJPGKP = MultiAudioManager.FadeInAudioObject(sound, ((Component)this).transform, fadeInTime);
			}
			else
			{
				ODHLEHJPGKP = MultiAudioManager.PlayAudioObject(sound, ((Component)this).transform);
			}
		}
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Barks_Shop/Entry/1/Dialogue Text"))
		{
			MJGGACBHMHO = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Hikari/Barks_Intro"))
		{
			switch (((Component)HANHCHBHHEH).GetComponent<PlayerController>().GetPlayerNum())
			{
			case 3:
				JKBMGFHGBAC[0] = false;
				break;
			case 1:
				JKBMGFHGBAC[0] = false;
				break;
			case 7:
				JKBMGFHGBAC[5] = false;
				break;
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("place charges"))
		{
			IMEKKIFIBBP = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Disabled") && (Object)(object)((Component)HANHCHBHHEH).GetComponent<CatNPC>().currentInvocationCircle == (Object)(object)placeable)
		{
			GDCLFLFLFBM = true;
		}
	}
}
