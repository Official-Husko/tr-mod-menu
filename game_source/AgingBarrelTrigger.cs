using UnityEngine;

public class AgingBarrelTrigger : MonoBehaviour
{
	public AgingBarrel agingBarrel;

	public int num;

	public GameObject slotPoint;

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("itemHalfWindow") && (Object)(object)InputByProximityManager.DFGOGIIPPPH(0).GDJNPPCMIBL() != (Object)null && ((object)InputByProximityManager.JOFDIPFMIHF(0).ABGDFIDOCCL().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].KPINNBKMOMO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(1);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveAllDecorations") && (Object)(object)InputByProximityManager.NHJMJHGGBOA(7).GDJNPPCMIBL() != (Object)null && ((object)InputByProximityManager.FLOIJFPDJGG(7).HBIKILDEHFI().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].LCHJGCHDHFO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(5);
			ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
			iAIHNNNGNKH.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(3).INILGGIBHKF(iAIHNNNGNKH);
		}
	}

	private void KIJDNFODCKJ(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("ActionBar7") && (Object)(object)InputByProximityManager.BPDFMAEOGGC(0).ABGDFIDOCCL() != (Object)null && ((object)InputByProximityManager.MBDFOJAKELO(0).HBIKILDEHFI().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].KPINNBKMOMO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(0);
			ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
			iAIHNNNGNKH.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).INILGGIBHKF(iAIHNNNGNKH);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Right Stick Left") && (Object)(object)InputByProximityManager.NHJMJHGGBOA(5).HBIKILDEHFI() != (Object)null && ((object)InputByProximityManager.CKJGBDHHKHB(2).GDJNPPCMIBL().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].LCHJGCHDHFO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(2);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(3).SetCrafterAction(crafterAction);
		}
	}

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("CalculateTriggerInstensity() returns ") && (Object)(object)InputByProximityManager.JOFDIPFMIHF(0).GFCOOKLMLNE() != (Object)null && ((object)InputByProximityManager.FLOIJFPDJGG(0).GetCurrentFocusedInputElement().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(0);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag("<color=#FFA726>+") && (Object)(object)InputByProximityManager.NMGNGAEEKIO(1).GFCOOKLMLNE() != (Object)null && ((object)InputByProximityManager.JOFDIPFMIHF(7).HOMHFEJHKIF().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].LCHJGCHDHFO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(2);
			ItemInstanceAmount crafterAction2 = default(ItemInstanceAmount);
			crafterAction2.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction2.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(6).SetCrafterAction(crafterAction2);
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("NormalLeftExterior") && (Object)(object)InputByProximityManager.DAEEJGKLOCF(0).HOMHFEJHKIF() != (Object)null && ((object)InputByProximityManager.OGKNJNINGMH(0).HBIKILDEHFI().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(1);
			ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
			iAIHNNNGNKH.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).INILGGIBHKF(iAIHNNNGNKH);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Vodka") && (Object)(object)InputByProximityManager.FLOIJFPDJGG(3).HOMHFEJHKIF() != (Object)null && ((object)InputByProximityManager.NMGNGAEEKIO(7).GetCurrentFocusedInputElement().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].LCHJGCHDHFO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(4);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(3).SetCrafterAction(crafterAction);
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("\n") && (Object)(object)InputByProximityManager.DAEEJGKLOCF(0).ABGDFIDOCCL() != (Object)null && ((object)InputByProximityManager.HBDCJFLINDA(1).HOMHFEJHKIF().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(1);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(1).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag("On Simple Event ") && (Object)(object)InputByProximityManager.OGKNJNINGMH(0).ABGDFIDOCCL() != (Object)null && ((object)InputByProximityManager.DAEEJGKLOCF(1).HBIKILDEHFI().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].LCHJGCHDHFO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(6);
			ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
			iAIHNNNGNKH.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(4).INILGGIBHKF(iAIHNNNGNKH);
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("SendRoomRequest") && (Object)(object)InputByProximityManager.NHJMJHGGBOA(1).GFCOOKLMLNE() != (Object)null && ((object)InputByProximityManager.BPDFMAEOGGC(1).HOMHFEJHKIF().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].LCHJGCHDHFO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(1);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(1).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag(" at ") && (Object)(object)InputByProximityManager.MBDFOJAKELO(3).HOMHFEJHKIF() != (Object)null && ((object)InputByProximityManager.HBDCJFLINDA(4).GetCurrentFocusedInputElement().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(2);
			ItemInstanceAmount crafterAction2 = default(ItemInstanceAmount);
			crafterAction2.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction2.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(8).SetCrafterAction(crafterAction2);
		}
	}

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag(" with less than 6 drinks") && (Object)(object)InputByProximityManager.JOFDIPFMIHF(0).ABGDFIDOCCL() != (Object)null && ((object)InputByProximityManager.JOFDIPFMIHF(0).HBIKILDEHFI().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(0);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Scene") && (Object)(object)InputByProximityManager.CMDGPJEIIJI(0).GDJNPPCMIBL() != (Object)null && ((object)InputByProximityManager.JOFDIPFMIHF(6).GetCurrentFocusedInputElement().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].LCHJGCHDHFO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(6);
			ItemInstanceAmount crafterAction2 = default(ItemInstanceAmount);
			crafterAction2.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction2.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(8).SetCrafterAction(crafterAction2);
		}
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag(", ") && (Object)(object)InputByProximityManager.CMDGPJEIIJI(0).GFCOOKLMLNE() != (Object)null && ((object)InputByProximityManager.IJMLNIHAOGK(0).GFCOOKLMLNE().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].KPINNBKMOMO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(0);
			ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
			iAIHNNNGNKH.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(1).INILGGIBHKF(iAIHNNNGNKH);
		}
		if (((Component)HANHCHBHHEH).CompareTag("onlineProfileID is null. Initializate on prefab with length ") && (Object)(object)InputByProximityManager.JOFDIPFMIHF(3).HOMHFEJHKIF() != (Object)null && ((object)InputByProximityManager.CMDGPJEIIJI(1).GetCurrentFocusedInputElement().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].LCHJGCHDHFO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(4);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(7).SetCrafterAction(crafterAction);
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Introduce/Entry/18/Dialogue Text") && (Object)(object)InputByProximityManager.JOFDIPFMIHF(0).HOMHFEJHKIF() != (Object)null && ((object)InputByProximityManager.BPDFMAEOGGC(0).GetCurrentFocusedInputElement().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(0);
			ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
			iAIHNNNGNKH.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(1).INILGGIBHKF(iAIHNNNGNKH);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Error not founding final ingredients to ") && (Object)(object)InputByProximityManager.GetPlayer(1).GDJNPPCMIBL() != (Object)null && ((object)InputByProximityManager.NHJMJHGGBOA(2).ABGDFIDOCCL().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(5);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(7).SetCrafterAction(crafterAction);
		}
	}

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("AceT_Quest") && (Object)(object)InputByProximityManager.CKJGBDHHKHB(1).HBIKILDEHFI() != (Object)null && ((object)InputByProximityManager.GetPlayer(0).GDJNPPCMIBL().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].KPINNBKMOMO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(0);
			ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
			iAIHNNNGNKH.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).INILGGIBHKF(iAIHNNNGNKH);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Waiting for players to finish their transitions...") && (Object)(object)InputByProximityManager.IJMLNIHAOGK(4).HBIKILDEHFI() != (Object)null && ((object)InputByProximityManager.CMDGPJEIIJI(0).HOMHFEJHKIF().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].PKFKJNODGJF())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(8);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).SetCrafterAction(crafterAction);
		}
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveNextRound") && (Object)(object)InputByProximityManager.DFGOGIIPPPH(0).GFCOOKLMLNE() != (Object)null && ((object)InputByProximityManager.GetPlayer(1).GFCOOKLMLNE().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(1);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag("StartRequestMap") && (Object)(object)InputByProximityManager.MBDFOJAKELO(3).HOMHFEJHKIF() != (Object)null && ((object)InputByProximityManager.FLOIJFPDJGG(5).GFCOOKLMLNE().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].KPINNBKMOMO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(3);
			ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
			iAIHNNNGNKH.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(2).INILGGIBHKF(iAIHNNNGNKH);
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Player") && (Object)(object)InputByProximityManager.GetPlayer(1).GetCurrentFocusedInputElement() != (Object)null && ((object)InputByProximityManager.GetPlayer(1).GetCurrentFocusedInputElement().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].KPINNBKMOMO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(1);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(1).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Player2") && (Object)(object)InputByProximityManager.GetPlayer(2).GetCurrentFocusedInputElement() != (Object)null && ((object)InputByProximityManager.GetPlayer(2).GetCurrentFocusedInputElement().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].KPINNBKMOMO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(2);
			ItemInstanceAmount crafterAction2 = default(ItemInstanceAmount);
			crafterAction2.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction2.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(2).SetCrafterAction(crafterAction2);
		}
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_611") && (Object)(object)InputByProximityManager.CKJGBDHHKHB(0).HOMHFEJHKIF() != (Object)null && ((object)InputByProximityManager.MBDFOJAKELO(1).GetCurrentFocusedInputElement().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(1);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Floor_9") && (Object)(object)InputByProximityManager.DFGOGIIPPPH(0).HBIKILDEHFI() != (Object)null && ((object)InputByProximityManager.IJMLNIHAOGK(5).HBIKILDEHFI().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].KPINNBKMOMO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(7);
			ItemInstanceAmount crafterAction2 = default(ItemInstanceAmount);
			crafterAction2.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction2.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(3).SetCrafterAction(crafterAction2);
		}
	}

	private void NDFEMHNLKCE(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Target frame rate (") && (Object)(object)InputByProximityManager.HBDCJFLINDA(0).GetCurrentFocusedInputElement() != (Object)null && ((object)InputByProximityManager.FLOIJFPDJGG(1).GFCOOKLMLNE().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(1);
			ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
			iAIHNNNGNKH.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).INILGGIBHKF(iAIHNNNGNKH);
		}
		if (((Component)HANHCHBHHEH).CompareTag("quest_description_") && (Object)(object)InputByProximityManager.OGKNJNINGMH(0).HBIKILDEHFI() != (Object)null && ((object)InputByProximityManager.HBDCJFLINDA(6).GDJNPPCMIBL().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].KPINNBKMOMO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(4);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(8).SetCrafterAction(crafterAction);
		}
	}

	private void PDCJGGJMPCN(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Fill") && (Object)(object)InputByProximityManager.CMDGPJEIIJI(0).GFCOOKLMLNE() != (Object)null && ((object)InputByProximityManager.NMGNGAEEKIO(0).GDJNPPCMIBL().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].LCHJGCHDHFO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(1);
			ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
			iAIHNNNGNKH.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).INILGGIBHKF(iAIHNNNGNKH);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Waking up in: ") && (Object)(object)InputByProximityManager.NHJMJHGGBOA(7).GDJNPPCMIBL() != (Object)null && ((object)InputByProximityManager.NMGNGAEEKIO(5).GDJNPPCMIBL().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].LCHJGCHDHFO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(7);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(3).SetCrafterAction(crafterAction);
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Bartender") && (Object)(object)InputByProximityManager.DFGOGIIPPPH(1).ABGDFIDOCCL() != (Object)null && ((object)InputByProximityManager.CMDGPJEIIJI(0).GDJNPPCMIBL().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].KPINNBKMOMO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(0);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(1).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag("popUpBuilding2B") && (Object)(object)InputByProximityManager.DAEEJGKLOCF(4).HOMHFEJHKIF() != (Object)null && ((object)InputByProximityManager.HBDCJFLINDA(3).HOMHFEJHKIF().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].KPINNBKMOMO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(8);
			ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
			iAIHNNNGNKH.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).INILGGIBHKF(iAIHNNNGNKH);
		}
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("[Action") && (Object)(object)InputByProximityManager.CMDGPJEIIJI(0).HOMHFEJHKIF() != (Object)null && ((object)InputByProximityManager.BPDFMAEOGGC(1).GetCurrentFocusedInputElement().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(0);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Graphics") && (Object)(object)InputByProximityManager.OGKNJNINGMH(1).GFCOOKLMLNE() != (Object)null && ((object)InputByProximityManager.DFGOGIIPPPH(4).HBIKILDEHFI().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].LCHJGCHDHFO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(8);
			ItemInstanceAmount crafterAction2 = default(ItemInstanceAmount);
			crafterAction2.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction2.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(2).SetCrafterAction(crafterAction2);
		}
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_677") && (Object)(object)InputByProximityManager.HBDCJFLINDA(1).GDJNPPCMIBL() != (Object)null && ((object)InputByProximityManager.DAEEJGKLOCF(1).GFCOOKLMLNE().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].KPINNBKMOMO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(0);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Player2") && (Object)(object)InputByProximityManager.CKJGBDHHKHB(2).ABGDFIDOCCL() != (Object)null && ((object)InputByProximityManager.JOFDIPFMIHF(1).ABGDFIDOCCL().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(0);
			ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
			iAIHNNNGNKH.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).INILGGIBHKF(iAIHNNNGNKH);
		}
	}

	private void PFIONHCONDI(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Kicking player on bed {0} with actor number {1}") && (Object)(object)InputByProximityManager.IJMLNIHAOGK(1).HBIKILDEHFI() != (Object)null && ((object)InputByProximityManager.OGKNJNINGMH(1).ABGDFIDOCCL().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].KPINNBKMOMO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(1);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Moving") && (Object)(object)InputByProximityManager.MBDFOJAKELO(8).HBIKILDEHFI() != (Object)null && ((object)InputByProximityManager.HBDCJFLINDA(4).ABGDFIDOCCL().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].LCHJGCHDHFO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(1);
			ItemInstanceAmount crafterAction2 = default(ItemInstanceAmount);
			crafterAction2.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction2.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).SetCrafterAction(crafterAction2);
		}
	}

	private void FCONKHCGBEM(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("    ├─ ") && (Object)(object)InputByProximityManager.JOFDIPFMIHF(1).HOMHFEJHKIF() != (Object)null && ((object)InputByProximityManager.BPDFMAEOGGC(0).HOMHFEJHKIF().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].PKFKJNODGJF())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(1);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Player") && (Object)(object)InputByProximityManager.DAEEJGKLOCF(6).GDJNPPCMIBL() != (Object)null && ((object)InputByProximityManager.NHJMJHGGBOA(0).HOMHFEJHKIF().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].LCHJGCHDHFO())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(8);
			ItemInstanceAmount crafterAction2 = default(ItemInstanceAmount);
			crafterAction2.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction2.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(1).SetCrafterAction(crafterAction2);
		}
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("Disabled") && (Object)(object)InputByProximityManager.BPDFMAEOGGC(0).ABGDFIDOCCL() != (Object)null && ((object)InputByProximityManager.CMDGPJEIIJI(1).GFCOOKLMLNE().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].PKFKJNODGJF())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(1);
			ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
			crafterAction.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(1).SetCrafterAction(crafterAction);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Disabled") && (Object)(object)InputByProximityManager.FLOIJFPDJGG(5).GetCurrentFocusedInputElement() != (Object)null && ((object)InputByProximityManager.JOFDIPFMIHF(6).HBIKILDEHFI().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.CPIIFPCIJEP(6);
			ItemInstanceAmount crafterAction2 = default(ItemInstanceAmount);
			crafterAction2.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			crafterAction2.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).SetCrafterAction(crafterAction2);
		}
	}

	private void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)HANHCHBHHEH).CompareTag("GB") && (Object)(object)InputByProximityManager.IJMLNIHAOGK(0).GFCOOKLMLNE() != (Object)null && ((object)InputByProximityManager.CMDGPJEIIJI(1).GFCOOKLMLNE().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].PKFKJNODGJF())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(0);
			ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
			iAIHNNNGNKH.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(0).INILGGIBHKF(iAIHNNNGNKH);
		}
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Stand/Entry/21/Dialogue Text") && (Object)(object)InputByProximityManager.DAEEJGKLOCF(5).HBIKILDEHFI() != (Object)null && ((object)InputByProximityManager.OGKNJNINGMH(7).HBIKILDEHFI().mainGameObject).Equals((object?)((Component)agingBarrel).gameObject) && !agingBarrel.inputSlot[num].AHHEMNHJPME())
		{
			slotPoint.transform.position = ((Component)this).transform.position;
			ButtonsContext.ResetCrafterAction(0);
			ItemInstanceAmount iAIHNNNGNKH2 = default(ItemInstanceAmount);
			iAIHNNNGNKH2.itemInstance = agingBarrel.inputSlot[num].itemInstance;
			iAIHNNNGNKH2.amount = agingBarrel.inputSlot[num].Stack;
			ButtonsContext.GetPlayer(6).INILGGIBHKF(iAIHNNNGNKH2);
		}
	}
}
