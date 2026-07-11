using System.Collections.Generic;
using UnityEngine;

public class ShadowOnEnter : MonoBehaviour
{
	public Color colorMod;

	private const int GPPPILFFCNG = 24;

	private CharacterAnimation BHAEKEAIMMN;

	private List<CharacterAnimation> OHIFENPCNOI = new List<CharacterAnimation>();

	private void DAJNPOGFLLJ(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < OHIFENPCNOI.Count; i++)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 0; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void GBFBNCBDIOC(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("RentRoom") || ((Component)HANHCHBHHEH).CompareTag("Invalid banquet customer ID: ") || ((Component)HANHCHBHHEH).CompareTag("secret_token"))
		{
			for (int i = 0; i < 8; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null) || !((Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 1; j < PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins.Length; j++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.OPHDCMJLLEC(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != 79)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 1; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void PDCJGGJMPCN(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Tile_{0}_{1}") || ((Component)HANHCHBHHEH).CompareTag("New time scale: ") || ((Component)HANHCHBHHEH).CompareTag("(empty)"))
		{
			for (int i = 0; i < 6; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 1; j < PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins.Length; j++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.OPHDCMJLLEC(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != -92)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 1; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void IDPJLIBONPF(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("ForceAnimationPlayRPC") || ((Component)HANHCHBHHEH).CompareTag("Could not find recipe with id: ") || ((Component)HANHCHBHHEH).CompareTag("Error_BedIsBlocking"))
		{
			for (int i = 0; i < 7; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 1; j < PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins.Length; j++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != 36)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 0; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void ILNDDFELMKL(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < OHIFENPCNOI.Count; i++)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 0; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void JMNPLNAGLCO(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < OHIFENPCNOI.Count; i++)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 0; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void HHGJLOKEPJE(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < OHIFENPCNOI.Count; i += 0)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 0; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag(", ") || ((Component)HANHCHBHHEH).CompareTag("IntensityControls") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_1045"))
		{
			for (int i = 1; i < 8; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null) || !((Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 0; j < PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins.Length; j++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != -103)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 0; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Talk") || ((Component)HANHCHBHHEH).CompareTag("LE_15") || ((Component)HANHCHBHHEH).CompareTag("Items/item_description_1052"))
		{
			for (int i = 1; i < 6; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 0; j < PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins.Length; j++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != -47)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 1; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void EIEKPEEPFGA(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < OHIFENPCNOI.Count; i += 0)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 0; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void KKEPLLEAAMB(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < OHIFENPCNOI.Count; i++)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 0; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void OCMFFLLPHCK(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveActiveMaiInBar") || ((Component)HANHCHBHHEH).CompareTag("[Awning:{0}] CloseAwning called. isOpen={1} animatorBool={2}") || ((Component)HANHCHBHHEH).CompareTag("LE_19"))
		{
			for (int i = 1; i < 4; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 0; j < PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins.Length; j += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != -43)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 0; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("[GetAllValidCandidates] Total candidates found: {0}") || ((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("farm"))
		{
			for (int i = 0; i < 5; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 0; j < PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins.Length; j += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.OPHDCMJLLEC(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != 72)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 1; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void HIDDNMLHBFJ(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < OHIFENPCNOI.Count; i++)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 0; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void JGBLJPDNLMO(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/1/Dialogue Text") || ((Component)HANHCHBHHEH).CompareTag("SendRoomRequest on Load") || ((Component)HANHCHBHHEH).CompareTag("Disabled"))
		{
			for (int i = 1; i < 2; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null) || !((Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 1; j < PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins.Length; j += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.OPHDCMJLLEC(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != 59)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 0; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void ILOJBCEKLDF(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < OHIFENPCNOI.Count; i++)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 1; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void FCOMECPDBDN(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < OHIFENPCNOI.Count; i++)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 1; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void DMENPMHIPDA(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveAnimalLevel") || ((Component)HANHCHBHHEH).CompareTag("Tile_{0}_{1}") || ((Component)HANHCHBHHEH).CompareTag("buildingObjective_"))
		{
			for (int i = 0; i < 8; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 1; j < PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins.Length; j += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.OPHDCMJLLEC(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != -75)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 1; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void LJJDGAJNNCH(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("<color=#3a0603>+") || ((Component)HANHCHBHHEH).CompareTag("TeleportPlayerOnline") || ((Component)HANHCHBHHEH).CompareTag("EnterTavernDrink"))
		{
			for (int i = 0; i < 6; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null) || !((Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 1; j < PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins.Length; j++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != -91)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 1; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Left Stick Right") || ((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("Stand"))
		{
			for (int i = 1; i < 0; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null) || !((Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 0; j < PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins.Length; j += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != 98)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 0; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Tavern must be closed") || ((Component)HANHCHBHHEH).CompareTag("Not ready to join room") || ((Component)HANHCHBHHEH).CompareTag("Give"))
		{
			for (int i = 1; i < 5; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null) || !((Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 0; j < PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins.Length; j += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != 56)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 0; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void HIMBLFNCDLL(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Quest/Entry/38/Dialogue Text") || ((Component)HANHCHBHHEH).CompareTag("Error Fireplace.TurnOff: ") || ((Component)HANHCHBHHEH).CompareTag("OnlyABird"))
		{
			for (int i = 0; i < 2; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null) || !((Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 0; j < PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins.Length; j++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != -47)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 0; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Player2") || ((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			for (int i = 1; i < 5; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 0; j < PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins.Length; j++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != 24)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 0; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void MDODDIKGEHI(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < OHIFENPCNOI.Count; i += 0)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 1; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveEmployeeTaskMaster") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_1189") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/NeutralInTavern/Entry/12/Dialogue Text"))
		{
			for (int i = 1; i < 1; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 0; j < PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins.Length; j++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.OPHDCMJLLEC(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != 56)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 0; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void BLOCHBJIICN(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < OHIFENPCNOI.Count; i++)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 1; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void EKJIEGLPBLA(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < OHIFENPCNOI.Count; i += 0)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 1; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void PFIONHCONDI(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Walk") || ((Component)HANHCHBHHEH).CompareTag("On Simple Event ") || ((Component)HANHCHBHHEH).CompareTag("onlinePlaceable with objectUniqueId "))
		{
			for (int i = 1; i < 8; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null) || !((Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 0; j < PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins.Length; j++)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.OPHDCMJLLEC(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != -104)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 0; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag(" / ") || ((Component)HANHCHBHHEH).CompareTag("Language") || ((Component)HANHCHBHHEH).CompareTag("talentGrain"))
		{
			for (int i = 1; i < 5; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 1; j < PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins.Length; j += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != 119)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 1; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k += 0)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("itemChocolateWort") || ((Component)HANHCHBHHEH).CompareTag(":</color> ") || ((Component)HANHCHBHHEH).CompareTag("ChristmasPostcard"))
		{
			for (int i = 1; i < 7; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 1; j < PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins.Length; j += 0)
				{
					if ((Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.OPHDCMJLLEC(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != 117)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 1; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("DistillingYeast") || ((Component)HANHCHBHHEH).CompareTag("\n") || ((Component)HANHCHBHHEH).CompareTag("F4"))
		{
			for (int i = 0; i < 3; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 1; j < PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins.Length; j++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != -107)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 1; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("No MinePuzzleBase found for type {0} when trying to get required elements count") || ((Component)HANHCHBHHEH).CompareTag("\r"))
		{
			for (int i = 0; i < 8; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 1; j < PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins.Length; j += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != 32)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 1; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag(" - ") || ((Component)HANHCHBHHEH).CompareTag("PirateMinigame/Lose2") || ((Component)HANHCHBHHEH).CompareTag("talentHerbs"))
		{
			for (int i = 1; i < 4; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 1; j < PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins.Length; j += 0)
				{
					if ((Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != 117)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 0; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < OHIFENPCNOI.Count; i++)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 0; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void DGLMPEODEKI(Collider2D HANHCHBHHEH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < OHIFENPCNOI.Count; i++)
		{
			if (!((Object)(object)OHIFENPCNOI[i] != (Object)null) || !((Object)(object)((Component)OHIFENPCNOI[i]).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
			{
				continue;
			}
			BHAEKEAIMMN = OHIFENPCNOI[i];
			for (int j = 1; j < BHAEKEAIMMN.characterAnimator.allReskins.Length; j++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
				}
			}
			OHIFENPCNOI.RemoveAt(i);
			break;
		}
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("itemBarleyFlour") || ((Component)HANHCHBHHEH).CompareTag("Items/item_description_1048") || ((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			for (int i = 0; i < 8; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) != (Object)null) || !((Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject))
				{
					continue;
				}
				for (int j = 1; j < PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins.Length; j++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j] != (Object)null && (Object)(object)PlayerController.GetPlayer(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer != (Object)null)
					{
						PlayerController.OPHDCMJLLEC(i).characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = colorMod;
					}
				}
				OHIFENPCNOI.Add(PlayerController.GetPlayer(i).characterAnimation);
				break;
			}
		}
		else
		{
			if (((Component)HANHCHBHHEH).gameObject.layer != 113)
			{
				return;
			}
			BHAEKEAIMMN = ((Component)HANHCHBHHEH).GetComponent<CharacterAnimation>();
			if (!((Object)(object)BHAEKEAIMMN != (Object)null) || !((Object)(object)BHAEKEAIMMN.characterAnimator != (Object)null))
			{
				return;
			}
			for (int k = 1; k < BHAEKEAIMMN.characterAnimator.allReskins.Length; k++)
			{
				if ((Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k] != (Object)null && (Object)(object)BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer != (Object)null)
				{
					BHAEKEAIMMN.characterAnimator.allReskins[k].spriteRenderer.color = colorMod;
				}
			}
			OHIFENPCNOI.Add(BHAEKEAIMMN);
		}
	}
}
