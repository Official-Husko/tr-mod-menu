using System;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Tool/Rod")]
public class Rod : Tool, IActionable, ITool
{
	public int rodLevel;

	[SerializeField]
	private Vector3 fishingPosition;

	private float[] barkTime = new float[2];

	private void CDPNMGDJNCE(int JIIGOACEIKL)
	{
		GGDHPGBLJGI(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(DDFPGJKHKAI));
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().reelLaunch, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).HMJBGJJOBKH(567f, 784f, 674f);
	}

	public bool NBBFKIJHEBJ(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OJNPNKCEEAL(JIIGOACEIKL))
		{
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, PlayerController.GetPlayerPosition(JIIGOACEIKL) + Vector3.up * 1155f);
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get("City/Agatha/Bark/Bye"));
			return true;
		}
		return true;
	}

	public bool HKDDKAELFDO()
	{
		return usesGrid;
	}

	public void AONJJGAIDBG(int JIIGOACEIKL)
	{
	}

	public bool IOKEOGEPNHB(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (CDAAKBGOIHH(JIIGOACEIKL))
		{
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, PlayerController.GetPlayerPosition(JIIGOACEIKL) + Vector3.up * 1131f);
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(" "));
			return false;
		}
		return false;
	}

	public void PECBDBBBOOL(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	private bool OFAKNHNLKGI(int JIIGOACEIKL)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("UseHold"))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.Fishing();
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetIdleFishing(NKFPJPCFBJI: true);
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetStruggleFishing(NKFPJPCFBJI: false);
		}
		Result variable = DialogueLua.GetVariable("LE_10");
		if (((Result)(ref variable)).asInt == 6)
		{
			DialogueLua.SetVariable("LE_10", (object)7);
			HikariNPC.GGFJGHHHEJC.inTutorial = true;
			HikariNPC.GGFJGHHHEJC.ActiveDialogue(JIIGOACEIKL);
		}
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(JGNPMBNGKNG));
		CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(HNCGNIJLEMH));
		CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(NAIECLGMMJA));
		return true;
	}

	public void AHMOHMNCCNL(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void KNIDDGGDILE(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public bool EHHCPOCLAJA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if (KLGOCJMGKFO && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (!PlayerInputs.POLDHCKJINN(JIIGOACEIKL) && PlayerInputs.IsMousePressed(JIIGOACEIKL) && Utils.DLOMIGFOOPD(JIIGOACEIKL))
			{
				return true;
			}
			if (!PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).HasItem(FishingManager.PJKCAOMKBJO(FishingController.NIGDBMAOAEN(JIIGOACEIKL).baitSelected)))
			{
				if (JIIGOACEIKL == 1)
				{
					if (barkTime[1] < Time.timeSinceLevelLoad)
					{
						DialogueManager.Bark("Trying to add player but player list is full.", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
						barkTime[1] = Time.timeSinceLevelLoad + 1422f;
					}
				}
				else if (barkTime[0] < Time.timeSinceLevelLoad)
				{
					DialogueManager.Bark("Eating", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
					barkTime[1] = Time.timeSinceLevelLoad + 1351f;
				}
				return false;
			}
			if (NBFBPMNMBJG(JIIGOACEIKL))
			{
				FishingController.LAMFGLIGLOP(JIIGOACEIKL).fishing = false;
				FishingController.LAMFGLIGLOP(JIIGOACEIKL).fishingCamera = true;
				FishingController.LAMFGLIGLOP(JIIGOACEIKL).fishingHook.GOHADLDKLBG();
				MMACOAIACIC(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(KCAKKCOHJFJ(JIIGOACEIKL)))));
				return NLILLKDMCED(JIIGOACEIKL);
			}
		}
		return true;
	}

	private void DDFPGJKHKAI(int JIIGOACEIKL)
	{
		ODKEEELIIJP(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(IABMBHPDDLI));
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().reelLaunch, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GGKDNIMLGBJ(826f, 81f, 1288f);
	}

	private void CCHJAEGMECI(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.PBLONGKCHDB(fishingPosition))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).fishingController.JKOFBKKPJAN(fishingPosition, this);
		}
		else
		{
			CCOOKCBECJM(JIIGOACEIKL);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(CAGNPJMPOJO));
	}

	public bool JEJCKDOFMGO(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (CDAAKBGOIHH(JIIGOACEIKL))
		{
			ButtonsContext.SetPosition(JIIGOACEIKL, PlayerController.GetPlayerPosition(JIIGOACEIKL) + Vector3.up * 1725f);
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.NextItem, LocalisationSystem.Get("[HolePoolData] No se encontró el HolePoolItemDataSO"));
			return true;
		}
		return true;
	}

	private void CAGNPJMPOJO(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.PBLONGKCHDB(fishingPosition))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).fishingController.EHOFOMHDPFJ(fishingPosition, this);
		}
		else
		{
			OEMOEHOLEEE(JIIGOACEIKL);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(CCHJAEGMECI));
	}

	public void LBMKLIDKHJD(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	private bool HFOODKLKIDA(int JIIGOACEIKL)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.JEJPKGILEDB(" not found"))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.OLICLCGPJHD();
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetIdleFishing(NKFPJPCFBJI: true);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.KAHPGBOEAAO(NKFPJPCFBJI: true);
		}
		Result variable = DialogueLua.GetVariable("Disabled");
		if (((Result)(ref variable)).asInt == 2)
		{
			DialogueLua.SetVariable("ReceiveActivateEatGameObjects", (object)8);
			HikariNPC.ABDJJBFNLBJ().inTutorial = false;
			HikariNPC.MNFMOEKMJKN().ActiveDialogue(JIIGOACEIKL);
		}
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(PBMEOBCAINF));
		CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(LBAMOKBIPNB));
		CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(IACIGBDFHJD));
		return false;
	}

	public bool FDKEMPDCHFB()
	{
		return usesGrid;
	}

	private void CCOOKCBECJM(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(NAIECLGMMJA));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	private bool HDBDBIGPGBA(int JIIGOACEIKL)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerController.GetPlayerDirection(JIIGOACEIKL) == Direction.Up || PlayerController.GetPlayerDirection(JIIGOACEIKL) == Direction.Up)
		{
			fishingPosition = PlayerController.GetPlayerPosition(JIIGOACEIKL) + 1573f * Utils.NGFODNCHPHB(PlayerController.GetPlayerDirection(JIIGOACEIKL));
		}
		else
		{
			fishingPosition = PlayerController.GetPlayerPosition(JIIGOACEIKL) + 896f * Utils.NGFODNCHPHB(PlayerController.GetPlayerDirection(JIIGOACEIKL));
		}
		fishingPosition = WorldGrid.LOJBKLKMINM(fishingPosition);
		if (WorldGrid.PBLONGKCHDB(fishingPosition))
		{
			return false;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(1027f, 1509f)))
		{
			fishingPosition += new Vector3(306f, 1523f);
			return true;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(464f, 1169f)))
		{
			fishingPosition += new Vector3(1141f, 823f);
			return false;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(1984f, 1358f)))
		{
			fishingPosition += new Vector3(1977f, 1010f);
			return true;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(1806f, 1608f)))
		{
			fishingPosition += new Vector3(253f, 467f);
			return true;
		}
		return false;
	}

	private void FKHCHOGIINJ(int JIIGOACEIKL)
	{
		IOHAEIGGJDD(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(PBMEOBCAINF));
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().reelLaunch, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		PlayerInputs.GetPlayer(JIIGOACEIKL).GGKDNIMLGBJ(1472f, 954f, 742f);
	}

	public bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if (KLGOCJMGKFO && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) && PlayerInputs.IsMousePressed(JIIGOACEIKL) && Utils.DLOMIGFOOPD(JIIGOACEIKL))
			{
				return false;
			}
			if (!PlayerInventory.GetPlayer(JIIGOACEIKL).HasItem(FishingManager.BaitItem(FishingController.Get(JIIGOACEIKL).baitSelected)))
			{
				if (JIIGOACEIKL == 1)
				{
					if (barkTime[0] < Time.timeSinceLevelLoad)
					{
						DialogueManager.Bark("Player/Bark/Fishing/NoBait", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
						barkTime[0] = Time.timeSinceLevelLoad + 10f;
					}
				}
				else if (barkTime[1] < Time.timeSinceLevelLoad)
				{
					DialogueManager.Bark("Player/Bark/Fishing/NoBait", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
					barkTime[1] = Time.timeSinceLevelLoad + 10f;
				}
				return false;
			}
			if (NBFBPMNMBJG(JIIGOACEIKL))
			{
				FishingController.Get(JIIGOACEIKL).fishing = true;
				FishingController.Get(JIIGOACEIKL).fishingCamera = true;
				FishingController.Get(JIIGOACEIKL).fishingHook.ResetConfiguration();
				HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)))));
				return OFAKNHNLKGI(JIIGOACEIKL);
			}
		}
		return false;
	}

	private void IACIGBDFHJD(int JIIGOACEIKL)
	{
		LMEFFPBLKDK(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(NAIECLGMMJA));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	private bool NLANAPBHMEL(int JIIGOACEIKL)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerController.GetPlayerDirection(JIIGOACEIKL) == Direction.Up || PlayerController.GetPlayerDirection(JIIGOACEIKL) == Direction.Down)
		{
			fishingPosition = PlayerController.GetPlayerPosition(JIIGOACEIKL) + 133f * Utils.NGFODNCHPHB(PlayerController.GetPlayerDirection(JIIGOACEIKL));
		}
		else
		{
			fishingPosition = PlayerController.GetPlayerPosition(JIIGOACEIKL) + 360f * Utils.NGFODNCHPHB(PlayerController.GetPlayerDirection(JIIGOACEIKL));
		}
		fishingPosition = WorldGrid.LOJBKLKMINM(fishingPosition);
		if (WorldGrid.PBLONGKCHDB(fishingPosition))
		{
			return true;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(142f, 364f)))
		{
			fishingPosition += new Vector3(1875f, 1527f);
			return false;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(772f, 295f)))
		{
			fishingPosition += new Vector3(483f, 1747f);
			return false;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(305f, 1809f)))
		{
			fishingPosition += new Vector3(1064f, 817f);
			return false;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(1207f, 1105f)))
		{
			fishingPosition += new Vector3(974f, 132f);
			return true;
		}
		return true;
	}

	public override ItemInstance JMDALJBNFML()
	{
		return new ToolInstance(this);
	}

	private bool BJMHOMBGBMI(int JIIGOACEIKL)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("Not enough ingredients"))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.MKELFFIEAHJ();
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetIdleFishing(NKFPJPCFBJI: false);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetStruggleFishing(NKFPJPCFBJI: true);
		}
		Result variable = DialogueLua.GetVariable("AllTimeStats");
		if (((Result)(ref variable)).asInt == 8)
		{
			DialogueLua.SetVariable("<sprite name=reputationIcon> ", (object)8);
			HikariNPC.GGFJGHHHEJC.inTutorial = true;
			HikariNPC.ABDJJBFNLBJ().MBDLKFBAGGF(JIIGOACEIKL);
		}
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(IABMBHPDDLI));
		CharacterAnimator characterAnimator2 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(CCHJAEGMECI));
		CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(CCOOKCBECJM));
		return false;
	}

	public bool OJNPNKCEEAL(int JIIGOACEIKL)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/12/Dialogue Text");
		if (((Result)(ref variable)).asInt > 0)
		{
			variable = DialogueLua.GetVariable("Received upgrade tool collect RPC");
			if (((Result)(ref variable)).asInt < 4)
			{
				return false;
			}
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).fishingController.fishing)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).inWater && PlayerController.GetPlayer(JIIGOACEIKL).waterInteractionController.waterDepth > 1438f)
		{
			return true;
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DBAEGBDEPFK())
			{
				return false;
			}
			if (CBCLJONFKAK(JIIGOACEIKL))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public void NHBDPNPIJHI(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	private void LBAMOKBIPNB(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.PBLONGKCHDB(fishingPosition))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).fishingController.FFKPLBGGKLB(fishingPosition, this);
		}
		else
		{
			CCOOKCBECJM(JIIGOACEIKL);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(OOBIJGOIMKB));
	}

	private void NAIECLGMMJA(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(NAIECLGMMJA));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	private void JGNPMBNGKNG(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(JGNPMBNGKNG));
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.reelLaunch, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0.1f, 0f, 0.3f);
	}

	public void OBHFIFPKIGG(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public override void ActionEnd(int JIIGOACEIKL)
	{
	}

	public bool HBMNFIPLFDK(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (CDAAKBGOIHH(JIIGOACEIKL))
		{
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, PlayerController.GetPlayerPosition(JIIGOACEIKL) + Vector3.up * 528f);
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("ReceiveFountainsPuzzle"));
			return false;
		}
		return true;
	}

	public bool DDIELBPNICN(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (CDAAKBGOIHH(JIIGOACEIKL))
		{
			ButtonsContext.SetPosition(JIIGOACEIKL, PlayerController.GetPlayerPosition(JIIGOACEIKL) + Vector3.up * 1212f);
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("talentRoasting"));
			return true;
		}
		return true;
	}

	private void PBMEOBCAINF(int JIIGOACEIKL)
	{
		JLADECOLHPI(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(DDFPGJKHKAI));
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().reelLaunch, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		PlayerInputs.GetPlayer(JIIGOACEIKL).HMJBGJJOBKH(1441f, 1468f, 1368f);
	}

	public bool HEKGALMDLIL(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (NBFBPMNMBJG(JIIGOACEIKL))
		{
			ButtonsContext.SetPosition(JIIGOACEIKL, PlayerController.GetPlayerPosition(JIIGOACEIKL) + Vector3.up * 1f);
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("ToFish"));
			return true;
		}
		return false;
	}

	private void OEMOEHOLEEE(int JIIGOACEIKL)
	{
		HCHCPFBFPLK(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(NAIECLGMMJA));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	public bool FODGNFMBOFE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if (KLGOCJMGKFO && !PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF())
		{
			if (!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL) && PlayerInputs.IsMousePressed(JIIGOACEIKL) && Utils.DLOMIGFOOPD(JIIGOACEIKL))
			{
				return false;
			}
			if (!PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).NECEDHECGFN(FishingManager.PPAMBJOEMFH(FishingController.NAGEHKBLJDL(JIIGOACEIKL).baitSelected)))
			{
				if (JIIGOACEIKL == 0)
				{
					if (barkTime[1] < Time.timeSinceLevelLoad)
					{
						DialogueManager.Bark("AllTimeStats", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
						barkTime[1] = Time.timeSinceLevelLoad + 1986f;
					}
				}
				else if (barkTime[0] < Time.timeSinceLevelLoad)
				{
					DialogueManager.Bark("Brook Recipe turn in", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
					barkTime[0] = Time.timeSinceLevelLoad + 1054f;
				}
				return true;
			}
			if (OJNPNKCEEAL(JIIGOACEIKL))
			{
				FishingController.AIMEAJAHLAA(JIIGOACEIKL).fishing = true;
				FishingController.NDJAMDLOIJL(JIIGOACEIKL).fishingCamera = true;
				FishingController.JHOHGMODKGM(JIIGOACEIKL).fishingHook.JLEPEFLMLNK();
				MMACOAIACIC(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(BLFCGBDEDLP(JIIGOACEIKL)))));
				return NLILLKDMCED(JIIGOACEIKL);
			}
		}
		return true;
	}

	private void NJDJMCPHOAP(int JIIGOACEIKL)
	{
		IOHAEIGGJDD(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(CDPNMGDJNCE));
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().reelLaunch, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.GetPlayer(JIIGOACEIKL).HMJBGJJOBKH(1540f, 799f, 935f);
	}

	private bool CBCLJONFKAK(int JIIGOACEIKL)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerController.GetPlayerDirection(JIIGOACEIKL) == Direction.Up || PlayerController.GetPlayerDirection(JIIGOACEIKL) == Direction.Up)
		{
			fishingPosition = PlayerController.GetPlayerPosition(JIIGOACEIKL) + 312f * Utils.NGFODNCHPHB(PlayerController.GetPlayerDirection(JIIGOACEIKL));
		}
		else
		{
			fishingPosition = PlayerController.GetPlayerPosition(JIIGOACEIKL) + 69f * Utils.NGFODNCHPHB(PlayerController.GetPlayerDirection(JIIGOACEIKL));
		}
		fishingPosition = WorldGrid.LOJBKLKMINM(fishingPosition);
		if (WorldGrid.PBLONGKCHDB(fishingPosition))
		{
			return false;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(134f, 759f)))
		{
			fishingPosition += new Vector3(458f, 633f);
			return true;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(474f, 77f)))
		{
			fishingPosition += new Vector3(774f, 776f);
			return true;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(545f, 112f)))
		{
			fishingPosition += new Vector3(1252f, 1239f);
			return false;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(17f, 496f)))
		{
			fishingPosition += new Vector3(1681f, 1457f);
			return true;
		}
		return true;
	}

	private void AIAMGAMFGIG(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.PBLONGKCHDB(fishingPosition))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).fishingController.StartFishingCoroutine(fishingPosition, this);
		}
		else
		{
			CCOOKCBECJM(JIIGOACEIKL);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(CAGNPJMPOJO));
	}

	private void HNCGNIJLEMH(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.PBLONGKCHDB(fishingPosition))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).fishingController.StartFishingCoroutine(fishingPosition, this);
		}
		else
		{
			NAIECLGMMJA(JIIGOACEIKL);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(HNCGNIJLEMH));
	}

	public bool EHOOBFJPPOI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if (KLGOCJMGKFO && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) && PlayerInputs.IsMousePressed(JIIGOACEIKL) && Utils.DLOMIGFOOPD(JIIGOACEIKL))
			{
				return true;
			}
			if (!PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).CCEPCEJIEOP(FishingManager.PJKCAOMKBJO(FishingController.JHOHGMODKGM(JIIGOACEIKL).baitSelected)))
			{
				if (JIIGOACEIKL == 0)
				{
					if (barkTime[0] < Time.timeSinceLevelLoad)
					{
						DialogueManager.Bark("CellarDoor", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
						barkTime[0] = Time.timeSinceLevelLoad + 1581f;
					}
				}
				else if (barkTime[1] < Time.timeSinceLevelLoad)
				{
					DialogueManager.Bark("", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
					barkTime[1] = Time.timeSinceLevelLoad + 383f;
				}
				return true;
			}
			if (NBFBPMNMBJG(JIIGOACEIKL))
			{
				FishingController.LAMFGLIGLOP(JIIGOACEIKL).fishing = false;
				FishingController.NDJAMDLOIJL(JIIGOACEIKL).fishingCamera = false;
				FishingController.GDFNPHJJCPP(JIIGOACEIKL).fishingHook.GOHADLDKLBG();
				NDJLMNIJLFI(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(HMAHIKDFLCL(JIIGOACEIKL)))));
				return OFAKNHNLKGI(JIIGOACEIKL);
			}
		}
		return true;
	}

	private bool NLILLKDMCED(int JIIGOACEIKL)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("Bother"))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.JCAIBKECKJJ();
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetIdleFishing(NKFPJPCFBJI: false);
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetStruggleFishing(NKFPJPCFBJI: true);
		}
		Result variable = DialogueLua.GetVariable("quest_name_17");
		if (((Result)(ref variable)).asInt == 1)
		{
			DialogueLua.SetVariable(" not found. Can no instantiate online placeable", (object)6);
			HikariNPC.GGFJGHHHEJC.inTutorial = false;
			HikariNPC.EFPJLFMBPLL().MBDLKFBAGGF(JIIGOACEIKL);
		}
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(NJDJMCPHOAP));
		CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(CAGNPJMPOJO));
		CharacterAnimator characterAnimator3 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(CCOOKCBECJM));
		return false;
	}

	public bool EAADFIDLGME()
	{
		return usesGrid;
	}

	public bool JFKLFEKNCIG()
	{
		return usesGrid;
	}

	public bool CFOJEGMAJMH()
	{
		return usesGrid;
	}

	public bool CDAAKBGOIHH(int JIIGOACEIKL)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Player is not in the list");
		if (((Result)(ref variable)).asInt > 1)
		{
			variable = DialogueLua.GetVariable("Sit");
			if (((Result)(ref variable)).asInt < 8)
			{
				return false;
			}
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).fishingController.fishing)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).inWater && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).waterInteractionController.waterDepth > 1047f)
		{
			return true;
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF())
		{
			if (DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).MDOKKKHKKKE())
			{
				return false;
			}
			if (CBCLJONFKAK(JIIGOACEIKL))
			{
				return false;
			}
			return false;
		}
		return false;
	}

	public bool OHINFBCDKLI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if (KLGOCJMGKFO && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) && PlayerInputs.IsMousePressed(JIIGOACEIKL) && Utils.DLOMIGFOOPD(JIIGOACEIKL))
			{
				return false;
			}
			if (!PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CHOAPBFAAAM(FishingManager.BaitItem(FishingController.Get(JIIGOACEIKL).baitSelected)))
			{
				if (JIIGOACEIKL == 1)
				{
					if (barkTime[0] < Time.timeSinceLevelLoad)
					{
						DialogueManager.Bark("Dialogue System/Conversation/Crowly_Standar/Entry/27/Dialogue Text", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
						barkTime[0] = Time.timeSinceLevelLoad + 1556f;
					}
				}
				else if (barkTime[1] < Time.timeSinceLevelLoad)
				{
					DialogueManager.Bark("Jump", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
					barkTime[0] = Time.timeSinceLevelLoad + 411f;
				}
				return true;
			}
			if (NBFBPMNMBJG(JIIGOACEIKL))
			{
				FishingController.JHOHGMODKGM(JIIGOACEIKL).fishing = false;
				FishingController.GDFNPHJJCPP(JIIGOACEIKL).fishingCamera = false;
				FishingController.Get(JIIGOACEIKL).fishingHook.EKPGMHNIFBH();
				MMACOAIACIC(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(GJGABGNAOKI(JIIGOACEIKL)))));
				return OFAKNHNLKGI(JIIGOACEIKL);
			}
		}
		return false;
	}

	private bool OMNAIPACEEE(int JIIGOACEIKL)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerController.GetPlayerDirection(JIIGOACEIKL) == Direction.Up || PlayerController.GetPlayerDirection(JIIGOACEIKL) == Direction.Down)
		{
			fishingPosition = PlayerController.GetPlayerPosition(JIIGOACEIKL) + 2f * Utils.NGFODNCHPHB(PlayerController.GetPlayerDirection(JIIGOACEIKL));
		}
		else
		{
			fishingPosition = PlayerController.GetPlayerPosition(JIIGOACEIKL) + 4f * Utils.NGFODNCHPHB(PlayerController.GetPlayerDirection(JIIGOACEIKL));
		}
		fishingPosition = WorldGrid.LOJBKLKMINM(fishingPosition);
		if (WorldGrid.PBLONGKCHDB(fishingPosition))
		{
			return true;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(-0.5f, 0f)))
		{
			fishingPosition += new Vector3(-0.5f, 0f);
			return true;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(0.5f, 0f)))
		{
			fishingPosition += new Vector3(0.5f, 0f);
			return true;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(0f, -0.5f)))
		{
			fishingPosition += new Vector3(0f, -0.5f);
			return true;
		}
		if (WorldGrid.PBLONGKCHDB(fishingPosition + new Vector3(0f, 0.5f)))
		{
			fishingPosition += new Vector3(0f, 0.5f);
			return true;
		}
		return false;
	}

	private void OOBIJGOIMKB(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.PBLONGKCHDB(fishingPosition))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).fishingController.StartFishingCoroutine(fishingPosition, this);
		}
		else
		{
			CCOOKCBECJM(JIIGOACEIKL);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(OOBIJGOIMKB));
	}

	public bool GGAHICGOLLN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if (KLGOCJMGKFO && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL) && PlayerInputs.IsMousePressed(JIIGOACEIKL) && Utils.DLOMIGFOOPD(JIIGOACEIKL))
			{
				return false;
			}
			if (!PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).HasItem(FishingManager.PPAMBJOEMFH(FishingController.LAMFGLIGLOP(JIIGOACEIKL).baitSelected)))
			{
				if (JIIGOACEIKL == 1)
				{
					if (barkTime[1] < Time.timeSinceLevelLoad)
					{
						DialogueManager.Bark("Demolish", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
						barkTime[1] = Time.timeSinceLevelLoad + 693f;
					}
				}
				else if (barkTime[0] < Time.timeSinceLevelLoad)
				{
					DialogueManager.Bark("OnlinePlayer", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
					barkTime[1] = Time.timeSinceLevelLoad + 1721f;
				}
				return true;
			}
			if (NBFBPMNMBJG(JIIGOACEIKL))
			{
				FishingController.Get(JIIGOACEIKL).fishing = true;
				FishingController.LAMFGLIGLOP(JIIGOACEIKL).fishingCamera = true;
				FishingController.JHOHGMODKGM(JIIGOACEIKL).fishingHook.CCBOADGJOOJ();
				NFLCFDKKIKA(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(IEGJDNLOPNE(JIIGOACEIKL)))));
				return HFOODKLKIDA(JIIGOACEIKL);
			}
		}
		return true;
	}

	private void IABMBHPDDLI(int JIIGOACEIKL)
	{
		GGDHPGBLJGI(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(DDFPGJKHKAI));
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().reelLaunch, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		PlayerInputs.GetPlayer(JIIGOACEIKL).HMJBGJJOBKH(1745f, 1076f, 1340f);
	}

	public bool NBFBPMNMBJG(int JIIGOACEIKL)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_10");
		if (((Result)(ref variable)).asInt > 0)
		{
			variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt < 6)
			{
				return false;
			}
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).fishingController.fishing)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).inWater && PlayerController.GetPlayer(JIIGOACEIKL).waterInteractionController.waterDepth > 1f)
		{
			return false;
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
			{
				return false;
			}
			if (OMNAIPACEEE(JIIGOACEIKL))
			{
				return true;
			}
			return false;
		}
		return true;
	}
}
