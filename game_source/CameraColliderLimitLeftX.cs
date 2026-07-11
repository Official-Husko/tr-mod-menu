using UnityEngine;

public class CameraColliderLimitLeftX : MonoBehaviour
{
	public Transform limitXPosition;

	private void HIDDNMLHBFJ(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("LE_5"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Error_ObjectIsBlocking"))
		{
			if (((Component)PlayerController.GetPlayer(7)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = true;
				SceneReferences.AIFEHACAOCA().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.AIFEHACAOCA().leftCameraLimitActivated = false;
			}
		}
	}

	private void OCEIGDHOJJM(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Could not set value of statistic "))
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(".gz"))
		{
			if (((Component)PlayerController.GetPlayer(5)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.DOEGLOMGEKJ().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = false;
			}
		}
	}

	private void MOKLBANPFGM(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("GO"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Rest"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(4)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.AIFEHACAOCA().leftCameraLimitActivated = true;
				SceneReferences.LIEDGBKNFDC().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = false;
			}
		}
	}

	private void CNLANNFMFCN(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("LE_21"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Could not find item with id: "))
		{
			if (((Component)PlayerController.GetPlayer(8)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.DOEGLOMGEKJ().leftCameraLimitActivated = true;
				SceneReferences.AIFEHACAOCA().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.CMNMEBCHAIP().leftCameraLimitActivated = true;
			}
		}
	}

	private void KKEPLLEAAMB(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("/"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(")"))
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = true;
				SceneReferences.DOEGLOMGEKJ().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = false;
			}
		}
	}

	private void EKNEIMIENPG(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Game"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_name_"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.DOEGLOMGEKJ().leftCameraLimitActivated = true;
				SceneReferences.CMNMEBCHAIP().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.CMNMEBCHAIP().leftCameraLimitActivated = true;
			}
		}
	}

	private void JJBAEDCPDFO(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveFireCannonball"))
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_description_668"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(8)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CMNMEBCHAIP().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer2CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DOEGLOMGEKJ().leftCameraLimitActivated = true;
			}
		}
	}

	private void KEICGGPGIED(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Reputation decreased..."))
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("OnFloor"))
		{
			if (((Component)PlayerController.GetPlayer(3)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer2CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = false;
			}
		}
	}

	private void MOOJEOLFOOC(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Recipe without ID: "))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("P1Cam"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(2)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CMNMEBCHAIP().leftCameraLimitActivated = true;
				SceneReferences.AIFEHACAOCA().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = false;
			}
		}
	}

	private void LHGOFNEIMNN(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("add all resolutions"))
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Travelling time increased to "))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(5)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = true;
				SceneReferences.AIFEHACAOCA().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = false;
			}
		}
	}

	private void INBCLBHEBKE(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("materials"))
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("F2"))
		{
			if (((Component)PlayerController.GetPlayer(7)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.DOEGLOMGEKJ().leftCameraLimitActivated = true;
				SceneReferences.DAGNFNGCODB().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.AIFEHACAOCA().leftCameraLimitActivated = true;
			}
		}
	}

	private void EKJIEGLPBLA(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("UI"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(":"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(8)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = false;
				SceneReferences.DAGNFNGCODB().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DOEGLOMGEKJ().leftCameraLimitActivated = false;
			}
		}
	}

	private void ILNDDFELMKL(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("L2"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Bartender"))
		{
			if (((Component)PlayerController.GetPlayer(7)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.CMNMEBCHAIP().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.AIFEHACAOCA().leftCameraLimitActivated = true;
			}
		}
	}

	private void KCDODEOOBHG(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("None"))
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("itemBrownAle"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.AIFEHACAOCA().leftCameraLimitActivated = true;
				SceneReferences.DAGNFNGCODB().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DOEGLOMGEKJ().leftCameraLimitActivated = false;
			}
		}
	}

	private void MKCEGNPBGMP(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("centimeters"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("BobAnimation SetSleep"))
		{
			if (((Component)PlayerController.GetPlayer(7)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.CMNMEBCHAIP().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = false;
			}
		}
	}

	private void GEFCGLEGHOA(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_description_"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("https://www.isolatedgames.com/bug-report/index.php"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(3)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = true;
				SceneReferences.DOEGLOMGEKJ().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = false;
			}
		}
	}

	private void IMOHIBLLPIB(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Tool"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/1/Dialogue Text"))
		{
			if (((Component)PlayerController.GetPlayer(3)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = true;
				SceneReferences.LIEDGBKNFDC().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = true;
			}
		}
	}

	private void ENKFHHEMHGG(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("New Save"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveLookAtPlayer"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(2)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer2CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = false;
			}
		}
	}

	private void MNLIEHBCJPJ(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("DualShock"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("FinalTest/MainEvent"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(6)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = false;
				SceneReferences.DOEGLOMGEKJ().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = true;
			}
		}
	}

	private void EIEKPEEPFGA(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("City/Rhia/Bark/Stand"))
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(6)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = true;
				SceneReferences.LIEDGBKNFDC().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = false;
			}
		}
	}

	private void DGJCAFPEJHL(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Aged price"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveEndEmote"))
		{
			if (((Component)PlayerController.GetPlayer(3)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = true;
				SceneReferences.DAGNFNGCODB().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DOEGLOMGEKJ().leftCameraLimitActivated = true;
			}
		}
	}

	private void ACKAOKBCDCJ(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("itemChocolateAle"))
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ClosePopUp"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = false;
				SceneReferences.AIFEHACAOCA().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = true;
			}
		}
	}

	private void ICKIIAHACEH(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Loop"))
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("OnlinePlayer"))
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = true;
				SceneReferences.AIFEHACAOCA().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = false;
			}
		}
	}

	private void DAJNPOGFLLJ(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("buildingObjective_19_0"))
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(""))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(6)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = false;
				SceneReferences.CMNMEBCHAIP().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = true;
			}
		}
	}

	private void KGAPHAIFAFH(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("popUpBuilding14"))
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("PanelToggleUI"))
		{
			if (((Component)PlayerController.GetPlayer(7)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.AIFEHACAOCA().leftCameraLimitActivated = true;
				SceneReferences.DAGNFNGCODB().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.AIFEHACAOCA().leftCameraLimitActivated = false;
			}
		}
	}

	private void MDODDIKGEHI(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ScrollDown"))
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceivePlaceableInfo"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.AIFEHACAOCA().leftCameraLimitActivated = false;
				SceneReferences.DOEGLOMGEKJ().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = false;
			}
		}
	}

	private void ILOJBCEKLDF(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("DestroyObjectClient"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(")"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(7)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = false;
				SceneReferences.AIFEHACAOCA().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = false;
			}
		}
	}

	private void CMJBBBHGHCD(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_name_1131"))
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/NeutralInTavern/Entry/11/Dialogue Text"))
		{
			if (((Component)PlayerController.GetPlayer(2)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.DAGNFNGCODB().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = false;
			}
		}
	}

	private void NHOPACFEAKA(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_description_1099"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Keg empty"))
		{
			if (((Component)PlayerController.GetPlayer(8)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CMNMEBCHAIP().leftCameraLimitActivated = true;
				SceneReferences.CFFMMHJABJG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.CMNMEBCHAIP().leftCameraLimitActivated = false;
			}
		}
	}

	private void HHGJLOKEPJE(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Walk"))
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("itemBeetroot"))
		{
			if (((Component)PlayerController.GetPlayer(4)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = true;
				SceneReferences.DOEGLOMGEKJ().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DOEGLOMGEKJ().leftCameraLimitActivated = false;
			}
		}
	}

	private void EDCINHFBGAN(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReciveSimpleDialogueStart"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Character Sprites array needs more space!"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = false;
				SceneReferences.CFFMMHJABJG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.AIFEHACAOCA().leftCameraLimitActivated = false;
			}
		}
	}

	private void GOJEJDHAGMM(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Farm/Event/SwordVioletArthur"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_name_1231"))
		{
			if (((Component)PlayerController.GetPlayer(8)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = true;
				SceneReferences.AIFEHACAOCA().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.AIFEHACAOCA().leftCameraLimitActivated = true;
			}
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player"))
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player2"))
		{
			if (((Component)PlayerController.GetPlayer(2)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer2CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = false;
			}
		}
	}

	private void BLOCHBJIICN(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Error_IsBlockingChanges"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Not enough ingredients"))
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = false;
				SceneReferences.DAGNFNGCODB().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = false;
			}
		}
	}

	private void IBINNLHHLMD(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveSitDown"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Invalid NPC photonID: {0} for NPCRoutine."))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(7)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CMNMEBCHAIP().leftCameraLimitActivated = true;
				SceneReferences.CFFMMHJABJG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = false;
			}
		}
	}

	private void DAGGKPKBCLD(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("StackManager"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Happy"))
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = true;
				SceneReferences.LIEDGBKNFDC().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DOEGLOMGEKJ().leftCameraLimitActivated = true;
			}
		}
	}

	private void JOPNDBLNDMA(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Moving"))
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player2"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(2)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer2CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DOEGLOMGEKJ().leftCameraLimitActivated = false;
			}
		}
	}

	private void HEOHCIAMEPD(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("_EnvMatrix"))
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_name_1130"))
		{
			if (((Component)PlayerController.GetPlayer(5)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = false;
				SceneReferences.DAGNFNGCODB().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = true;
			}
		}
	}

	private void FCOMECPDBDN(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("\n"))
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Bed not found! Unique id: "))
		{
			if (((Component)PlayerController.GetPlayer(6)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.AIFEHACAOCA().leftCameraLimitActivated = true;
				SceneReferences.DOEGLOMGEKJ().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = true;
			}
		}
	}

	private void DGLMPEODEKI(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("<color=#B50000>"))
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("UI"))
		{
			if (((Component)PlayerController.GetPlayer(8)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.CMNMEBCHAIP().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = true;
			}
		}
	}

	private void JMNPLNAGLCO(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Circle"))
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("popUpBuilding21"))
		{
			if (((Component)PlayerController.GetPlayer(4)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = false;
				SceneReferences.LIEDGBKNFDC().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.CFFMMHJABJG().leftCameraLimitActivated = true;
			}
		}
	}

	private void DJNNHILGACE(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("SteamManager"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player is not in the list"))
		{
			if (((Component)PlayerController.GetPlayer(0)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.CMNMEBCHAIP().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = false;
			}
		}
	}

	private void NAFADNEKCOH(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/TavernFilthy/Entry/10/Dialogue Text"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.ODMIFGMCGAG().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("MaxProductValue"))
		{
			if (((Component)PlayerController.GetPlayer(2)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.CMNMEBCHAIP().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = false;
			}
		}
	}

	private void NICLCHABAMK(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_description_1034"))
		{
			if (((Component)PlayerController.GetPlayer(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("cameraZoom2"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer2CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = true;
			}
		}
	}

	private void BINMHNJBDNI(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceivePlayerDisconnected"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("</color>"))
		{
			if (((Component)PlayerController.GetPlayer(5)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.DOEGLOMGEKJ().leftCameraLimitActivated = true;
				SceneReferences.DAGNFNGCODB().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.DOEGLOMGEKJ().leftCameraLimitActivated = true;
			}
		}
	}

	private void OFNKDCBEAHP(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Walk"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Hurt"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(5)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.LIEDGBKNFDC().leftCameraLimitActivated = false;
				SceneReferences.LIEDGBKNFDC().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.AIFEHACAOCA().leftCameraLimitActivated = false;
			}
		}
	}

	private void APJFDMCLDBD(Collider2D HANHCHBHHEH)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(" "))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.GetPlayer1CameraTarget().leftCameraLimitActivated = false;
				SceneReferences.GetPlayer1CameraTarget().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.ODMIFGMCGAG().leftCameraLimitActivated = true;
			}
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("SendRoomRequest on Load"))
		{
			if (((Component)PlayerController.OPHDCMJLLEC(6)).transform.position.x < ((Component)this).transform.position.x)
			{
				SceneReferences.DAGNFNGCODB().leftCameraLimitActivated = true;
				SceneReferences.CMNMEBCHAIP().leftCameraPositionXLimit = limitXPosition;
			}
			else
			{
				SceneReferences.GetPlayer2CameraTarget().leftCameraLimitActivated = false;
			}
		}
	}
}
