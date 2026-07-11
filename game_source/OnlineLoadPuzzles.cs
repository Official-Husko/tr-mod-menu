using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineLoadPuzzles : OnlineLoadBase
{
	[Serializable]
	public class LoadPuzzleMessage : LoadMessageBase
	{
		[JsonProperty("ML")]
		public byte mineLevel;

		[JsonProperty("RC")]
		public bool rewardCollected;

		[JsonProperty("PS")]
		public bool puzzleSolved;

		public override void OEJJGDMKIDN()
		{
			for (int i = 0; i < MinePuzzleManager.puzzleInstances.Length; i++)
			{
				if (!((Object)(object)MinePuzzleManager.puzzleInstances[i] == (Object)null) && MinePuzzleManager.puzzleInstances[i].mineLevel == mineLevel)
				{
					Debug.Log((object)$"[OnlineLoadPuzzles] LoadPuzzleMessage: Found matching puzzle instance for mine level {mineLevel}. Setting reward collected: {rewardCollected}, puzzle solved: {puzzleSolved}");
					if (puzzleSolved)
					{
						MinePuzzleManager.puzzleInstances[i].GetCurrentPuzzle().GetManager().SetPuzzleSolved(rewardCollected);
					}
					break;
				}
			}
		}

		public LoadPuzzleMessage(MinePuzzleBase LEPBPPKKPHF)
		{
			if (!((Object)(object)LEPBPPKKPHF == (Object)null))
			{
				mineLevel = (byte)LEPBPPKKPHF.GetManager().mineLevel;
				rewardCollected = LEPBPPKKPHF.GetManager().rewardHandler.chest.IsChestOpened();
				puzzleSolved = LEPBPPKKPHF.IsPuzzleSolved();
			}
		}
	}

	[Serializable]
	public class LoadTorchPuzzleMessage : LoadPuzzleMessage
	{
		[JsonProperty("1")]
		public bool[] torchState;

		public LoadTorchPuzzleMessage(MineTorchPuzzle LHHEKEHGKFD)
			: base(LHHEKEHGKFD)
		{
			torchState = LHHEKEHGKFD.GetTorchsState();
		}

		public override void OEJJGDMKIDN()
		{
			base.OEJJGDMKIDN();
			for (int i = 0; i < MinePuzzleManager.puzzleInstances.Length; i++)
			{
				if ((Object)(object)MinePuzzleManager.puzzleInstances[i] == (Object)null)
				{
					Debug.LogError((object)$"[OnlineLoadPuzzles] LoadTorchPuzzleMessage: puzzle instance {i} is null");
				}
				else
				{
					if (MinePuzzleManager.puzzleInstances[i].mineLevel != mineLevel)
					{
						continue;
					}
					if (MinePuzzleManager.puzzleInstances[i].GetCurrentPuzzle() is MineTorchPuzzle mineTorchPuzzle)
					{
						mineTorchPuzzle.SetTorchStates(torchState);
						if (puzzleSolved)
						{
							mineTorchPuzzle.SetPuzzleSolved();
						}
					}
					break;
				}
			}
		}
	}

	[Serializable]
	public class LoadPipePuzzleMessage : LoadPuzzleMessage
	{
		[JsonProperty("3")]
		public int[] swappedIndices;

		public LoadPipePuzzleMessage(MinePipePuzzle GOKPLOBFDCJ)
			: base(GOKPLOBFDCJ)
		{
			swappedIndices = GOKPLOBFDCJ.GetCurrentStateAsIndices();
		}

		public override void OEJJGDMKIDN()
		{
			base.OEJJGDMKIDN();
			for (int i = 0; i < MinePuzzleManager.puzzleInstances.Length; i++)
			{
				if (!((Object)(object)MinePuzzleManager.puzzleInstances[i] == (Object)null) && MinePuzzleManager.puzzleInstances[i].mineLevel == mineLevel)
				{
					if (MinePuzzleManager.puzzleInstances[i].GetCurrentPuzzle() is MinePipePuzzle minePipePuzzle)
					{
						minePipePuzzle.SetState(swappedIndices, puzzleSolved);
					}
					break;
				}
			}
		}
	}

	[Serializable]
	public class LoadKeyPuzzleMessage : LoadPuzzleMessage
	{
		[JsonProperty("3")]
		public byte keysActivated;

		public LoadKeyPuzzleMessage(KeyAltarPuzzle MNBEHFKAPGH)
			: base(MNBEHFKAPGH)
		{
			keysActivated = MNBEHFKAPGH.interactable.GetKeysActivated();
		}

		public override void OEJJGDMKIDN()
		{
			base.OEJJGDMKIDN();
			for (int i = 0; i < MinePuzzleManager.puzzleInstances.Length; i++)
			{
				if ((Object)(object)MinePuzzleManager.puzzleInstances[i] == (Object)null || MinePuzzleManager.puzzleInstances[i].mineLevel != mineLevel)
				{
					continue;
				}
				if (MinePuzzleManager.puzzleInstances[i].GetCurrentPuzzle() is KeyAltarPuzzle keyAltarPuzzle)
				{
					if (keysActivated == 1 || keysActivated == 2)
					{
						keyAltarPuzzle.interactable.AddVisualKey(keysActivated);
					}
					if (puzzleSolved)
					{
						keyAltarPuzzle.SetPuzzleSolved();
					}
				}
				break;
			}
		}
	}

	[Serializable]
	public class LoadFountainsPuzzleMessage : LoadPuzzleMessage
	{
		[JsonProperty("3")]
		public bool[] fountainStates;

		public override void OEJJGDMKIDN()
		{
			base.OEJJGDMKIDN();
			for (int i = 0; i < MinePuzzleManager.puzzleInstances.Length; i++)
			{
				if ((Object)(object)MinePuzzleManager.puzzleInstances[i] == (Object)null || MinePuzzleManager.puzzleInstances[i].mineLevel != mineLevel)
				{
					continue;
				}
				if (!(MinePuzzleManager.puzzleInstances[i].GetCurrentPuzzle() is FountainsPuzzle fountainsPuzzle))
				{
					break;
				}
				for (int j = 0; j < fountainStates.Length; j++)
				{
					if (fountainStates[j])
					{
						fountainsPuzzle.interactables[j].FillFountainVisual();
					}
				}
				if (puzzleSolved)
				{
					fountainsPuzzle.SetPuzzleSolved();
				}
				break;
			}
		}

		public LoadFountainsPuzzleMessage(FountainsPuzzle HEBHJOEGHON)
			: base(HEBHJOEGHON)
		{
			fountainStates = new bool[HEBHJOEGHON.interactables.Count];
			for (int i = 0; i < fountainStates.Length; i++)
			{
				fountainStates[i] = HEBHJOEGHON.interactables[i].IsFilled();
			}
		}
	}

	[Serializable]
	public class LoadButtonPressPuzzleMessage : LoadPuzzleMessage
	{
		[JsonProperty("3")]
		public bool[] buttonStates;

		public override void OEJJGDMKIDN()
		{
			base.OEJJGDMKIDN();
			for (int i = 0; i < MinePuzzleManager.puzzleInstances.Length; i++)
			{
				if ((Object)(object)MinePuzzleManager.puzzleInstances[i] == (Object)null || MinePuzzleManager.puzzleInstances[i].mineLevel != mineLevel)
				{
					continue;
				}
				if (!(MinePuzzleManager.puzzleInstances[i].GetCurrentPuzzle() is ButtonPressPuzzle buttonPressPuzzle))
				{
					break;
				}
				for (int j = 0; j < buttonStates.Length; j++)
				{
					if (buttonStates[j])
					{
						buttonPressPuzzle.interactables[j].PressButtonVisual();
					}
				}
				if (puzzleSolved)
				{
					buttonPressPuzzle.SetPuzzleSolved();
				}
				break;
			}
		}

		public LoadButtonPressPuzzleMessage(ButtonPressPuzzle BLHCEGDAANK)
			: base(BLHCEGDAANK)
		{
			buttonStates = new bool[BLHCEGDAANK.interactables.Count];
			for (int i = 0; i < buttonStates.Length; i++)
			{
				buttonStates[i] = BLHCEGDAANK.interactables[i].IsPressed();
			}
		}
	}

	[Serializable]
	public class LoadStatuePuzzleMessage : LoadPuzzleMessage
	{
		[JsonProperty("3")]
		public bool[] statueStates;

		public override void OEJJGDMKIDN()
		{
			base.OEJJGDMKIDN();
			for (int i = 0; i < MinePuzzleManager.puzzleInstances.Length; i++)
			{
				if ((Object)(object)MinePuzzleManager.puzzleInstances[i] == (Object)null || MinePuzzleManager.puzzleInstances[i].mineLevel != mineLevel)
				{
					continue;
				}
				if (!(MinePuzzleManager.puzzleInstances[i].GetCurrentPuzzle() is StatuePuzzle statuePuzzle))
				{
					break;
				}
				for (int j = 0; j < statueStates.Length; j++)
				{
					if (statueStates[j])
					{
						statuePuzzle.interactables[j].DestroyStatueVisual();
					}
				}
				if (puzzleSolved)
				{
					statuePuzzle.SetPuzzleSolved();
				}
				break;
			}
		}

		public LoadStatuePuzzleMessage(StatuePuzzle GEEBMKNIHFN)
			: base(GEEBMKNIHFN)
		{
			statueStates = new bool[GEEBMKNIHFN.interactables.Count];
			for (int i = 0; i < statueStates.Length; i++)
			{
				statueStates[i] = GEEBMKNIHFN.interactables[i].IsDestroyed();
			}
		}
	}

	[Serializable]
	public class LoadCrystalPuzzleMessage : LoadPuzzleMessage
	{
		[JsonProperty("3")]
		public int currentStep;

		public LoadCrystalPuzzleMessage(CrystalPuzzle LEPBKMGGIEI)
			: base(LEPBKMGGIEI)
		{
			currentStep = LEPBKMGGIEI.GetCurrentStep();
		}

		public override void OEJJGDMKIDN()
		{
			base.OEJJGDMKIDN();
			for (int i = 0; i < MinePuzzleManager.puzzleInstances.Length; i++)
			{
				if ((Object)(object)MinePuzzleManager.puzzleInstances[i] == (Object)null || MinePuzzleManager.puzzleInstances[i].mineLevel != mineLevel)
				{
					continue;
				}
				if (MinePuzzleManager.puzzleInstances[i].GetCurrentPuzzle() is CrystalPuzzle crystalPuzzle)
				{
					crystalPuzzle.SetCurrentStep(currentStep);
					if (puzzleSolved)
					{
						crystalPuzzle.SetPuzzleSolved();
					}
				}
				break;
			}
		}
	}

	[Serializable]
	public class LoadChessPillarPuzzleMessage : LoadPuzzleMessage
	{
		[JsonProperty("3")]
		public byte[] segmentState;

		public LoadChessPillarPuzzleMessage(MineChessPillarPuzzle HJLGLGHIPPG)
			: base(HJLGLGHIPPG)
		{
			ChessPieceType[] currentState = HJLGLGHIPPG.GetCurrentState();
			segmentState = new byte[currentState.Length];
			for (int i = 0; i < currentState.Length; i++)
			{
				segmentState[i] = (byte)currentState[i];
			}
		}

		public override void OEJJGDMKIDN()
		{
			base.OEJJGDMKIDN();
			for (int i = 0; i < MinePuzzleManager.puzzleInstances.Length; i++)
			{
				if ((Object)(object)MinePuzzleManager.puzzleInstances[i] == (Object)null || MinePuzzleManager.puzzleInstances[i].mineLevel != mineLevel)
				{
					continue;
				}
				if (MinePuzzleManager.puzzleInstances[i].GetCurrentPuzzle() is MineChessPillarPuzzle mineChessPillarPuzzle)
				{
					ChessPieceType[] array = new ChessPieceType[segmentState.Length];
					for (int j = 0; j < segmentState.Length; j++)
					{
						array[j] = (ChessPieceType)segmentState[j];
					}
					mineChessPillarPuzzle.SetStateFromNetwork(array);
					if (puzzleSolved)
					{
						mineChessPillarPuzzle.SetPuzzleSolved();
					}
				}
				break;
			}
		}
	}

	[Serializable]
	public class LoadOfferingPuzzleMessage : LoadPuzzleMessage
	{
		[JsonProperty("3")]
		public int offeringItemId;

		[JsonProperty("4")]
		public bool hasFailVisual;

		public override void OEJJGDMKIDN()
		{
			base.OEJJGDMKIDN();
			for (int i = 0; i < MinePuzzleManager.puzzleInstances.Length; i++)
			{
				if ((Object)(object)MinePuzzleManager.puzzleInstances[i] == (Object)null || MinePuzzleManager.puzzleInstances[i].mineLevel != mineLevel)
				{
					continue;
				}
				if (MinePuzzleManager.puzzleInstances[i].GetCurrentPuzzle() is OfferingStatuePuzzle offeringStatuePuzzle)
				{
					if (offeringItemId >= 0)
					{
						offeringStatuePuzzle.FillOfferingSlotFromNetwork(offeringItemId);
					}
					if (hasFailVisual)
					{
						offeringStatuePuzzle.PlayFailAnimation();
					}
					if (puzzleSolved)
					{
						offeringStatuePuzzle.PlaySuccessAnimation();
						offeringStatuePuzzle.SetPuzzleSolved();
					}
				}
				break;
			}
		}

		public LoadOfferingPuzzleMessage(OfferingStatuePuzzle GAPHEECNOIF)
			: base(GAPHEECNOIF)
		{
			Slot offeringSlot = GAPHEECNOIF.GetOfferingSlot();
			offeringItemId = (offeringSlot.KPINNBKMOMO() ? (-1) : offeringSlot.itemInstance.LHBPOPOIFLE().JDJGFAACPFC());
			hasFailVisual = GAPHEECNOIF.HasFailVisual();
		}
	}

	private void EABNIPMFHAI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadChessPillarPuzzleMessage>(OINICMNOLPK);
	}

	private void AAKOMBFNOED(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTorchPuzzleMessage>(OINICMNOLPK);
	}

	private void DCDABCOAEMP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCrystalPuzzleMessage>(OINICMNOLPK);
	}

	private void ENDHDEBDNCC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPipePuzzleMessage>(OINICMNOLPK);
	}

	private void JOEJIJAEGLI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadOfferingPuzzleMessage>(OINICMNOLPK);
	}

	private void MEDJLJNNIJO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadChessPillarPuzzleMessage>(OINICMNOLPK);
	}

	private void BDJIMDMEPGO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCrystalPuzzleMessage>(OINICMNOLPK);
	}

	private void PKAPILNDLKL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCrystalPuzzleMessage>(OINICMNOLPK);
	}

	private void HEFAHKHEHAE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPipePuzzleMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveTorchPuzzle(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTorchPuzzleMessage>(OINICMNOLPK);
	}

	private void DLCHBBLCLBG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadButtonPressPuzzleMessage>(OINICMNOLPK);
	}

	private void AECMPFEGOIG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadOfferingPuzzleMessage>(OINICMNOLPK);
	}

	private void AOKNLDDANID(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFountainsPuzzleMessage>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		int mEDDFJKOJFB = 0;
		List<MinePuzzleManager> list = new List<MinePuzzleManager>();
		for (int i = 0; i < MinePuzzleManager.puzzleInstances.Length; i++)
		{
			if ((Object)(object)MinePuzzleManager.puzzleInstances[i] != (Object)null && (Object)(object)MinePuzzleManager.puzzleInstances[i].GetCurrentPuzzle() != (Object)null)
			{
				list.Add(MinePuzzleManager.puzzleInstances[i]);
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			bool kJOOOPJKLBB = j == list.Count - 1;
			if (list[j].GetCurrentPuzzle() is MineTorchPuzzle lHHEKEHGKFD)
			{
				LoadTorchPuzzleMessage oKCOIHJLGCM = new LoadTorchPuzzleMessage(lHHEKEHGKFD);
				AHGEFIOOEBL("ReceiveTorchPuzzle", player, oKCOIHJLGCM, mEDDFJKOJFB++, kJOOOPJKLBB);
			}
			else if (list[j].GetCurrentPuzzle() is MinePipePuzzle gOKPLOBFDCJ)
			{
				LoadPipePuzzleMessage oKCOIHJLGCM2 = new LoadPipePuzzleMessage(gOKPLOBFDCJ);
				AHGEFIOOEBL("ReceivePipePuzzle", player, oKCOIHJLGCM2, mEDDFJKOJFB++, kJOOOPJKLBB);
			}
			else if (list[j].GetCurrentPuzzle() is KeyAltarPuzzle mNBEHFKAPGH)
			{
				LoadKeyPuzzleMessage oKCOIHJLGCM3 = new LoadKeyPuzzleMessage(mNBEHFKAPGH);
				AHGEFIOOEBL("ReceiveKeyPuzzle", player, oKCOIHJLGCM3, mEDDFJKOJFB++, kJOOOPJKLBB);
			}
			else if (list[j].GetCurrentPuzzle() is FountainsPuzzle hEBHJOEGHON)
			{
				LoadFountainsPuzzleMessage oKCOIHJLGCM4 = new LoadFountainsPuzzleMessage(hEBHJOEGHON);
				AHGEFIOOEBL("ReceiveFountainsPuzzle", player, oKCOIHJLGCM4, mEDDFJKOJFB++, kJOOOPJKLBB);
			}
			else if (list[j].GetCurrentPuzzle() is ButtonPressPuzzle bLHCEGDAANK)
			{
				LoadButtonPressPuzzleMessage oKCOIHJLGCM5 = new LoadButtonPressPuzzleMessage(bLHCEGDAANK);
				AHGEFIOOEBL("ReceiveButtonPressPuzzle", player, oKCOIHJLGCM5, mEDDFJKOJFB++, kJOOOPJKLBB);
			}
			else if (list[j].GetCurrentPuzzle() is StatuePuzzle gEEBMKNIHFN)
			{
				LoadStatuePuzzleMessage oKCOIHJLGCM6 = new LoadStatuePuzzleMessage(gEEBMKNIHFN);
				AHGEFIOOEBL("ReceiveStatuePuzzle", player, oKCOIHJLGCM6, mEDDFJKOJFB++, kJOOOPJKLBB);
			}
			else if (list[j].GetCurrentPuzzle() is CrystalPuzzle lEPBKMGGIEI)
			{
				LoadCrystalPuzzleMessage oKCOIHJLGCM7 = new LoadCrystalPuzzleMessage(lEPBKMGGIEI);
				AHGEFIOOEBL("ReceiveCrystalPuzzle", player, oKCOIHJLGCM7, mEDDFJKOJFB++, kJOOOPJKLBB);
			}
			else if (list[j].GetCurrentPuzzle() is MineChessPillarPuzzle hJLGLGHIPPG)
			{
				LoadChessPillarPuzzleMessage oKCOIHJLGCM8 = new LoadChessPillarPuzzleMessage(hJLGLGHIPPG);
				AHGEFIOOEBL("ReceiveChessPillarPuzzle", player, oKCOIHJLGCM8, mEDDFJKOJFB++, kJOOOPJKLBB);
			}
			else if (list[j].GetCurrentPuzzle() is OfferingStatuePuzzle gAPHEECNOIF)
			{
				LoadOfferingPuzzleMessage oKCOIHJLGCM9 = new LoadOfferingPuzzleMessage(gAPHEECNOIF);
				AHGEFIOOEBL("ReceiveOfferingPuzzle", player, oKCOIHJLGCM9, mEDDFJKOJFB++, kJOOOPJKLBB);
			}
			else
			{
				Debug.LogError((object)"No puzzle type found!");
			}
		}
		if (list.Count == 0)
		{
			AHGEFIOOEBL("ReceiveBasePuzzle", player, new LoadPuzzleMessage(null), mEDDFJKOJFB, KJOOOPJKLBB: true);
		}
		yield return null;
	}

	private void DOCMKLIFLMC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadButtonPressPuzzleMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveOfferingPuzzle(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadOfferingPuzzleMessage>(OINICMNOLPK);
	}

	private void JAEAMJEOCHE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadButtonPressPuzzleMessage>(OINICMNOLPK);
	}

	private void LBIAFKMJJAE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadKeyPuzzleMessage>(OINICMNOLPK);
	}

	private void EHKMDCKNEEP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadStatuePuzzleMessage>(OINICMNOLPK);
	}

	private void EIGJDGNACKN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPipePuzzleMessage>(OINICMNOLPK);
	}

	private void JIBMDHOILFC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFountainsPuzzleMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveFountainsPuzzle(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFountainsPuzzleMessage>(OINICMNOLPK);
	}

	private void PJBGFGHFNKG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPuzzleMessage>(OINICMNOLPK);
	}

	private void KFHKJBJGILM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPipePuzzleMessage>(OINICMNOLPK);
	}

	private void GPPIIMPENDI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadButtonPressPuzzleMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveBasePuzzle(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPuzzleMessage>(OINICMNOLPK);
	}

	private void OEJBKIPKGJK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadChessPillarPuzzleMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveChessPillarPuzzle(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadChessPillarPuzzleMessage>(OINICMNOLPK);
	}

	private void DCGKMAFLBCN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPipePuzzleMessage>(OINICMNOLPK);
	}

	private void EJGBNPFDDIB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFountainsPuzzleMessage>(OINICMNOLPK);
	}

	private void JAHLEIELFIE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadButtonPressPuzzleMessage>(OINICMNOLPK);
	}

	private void LEFJBEBOAAJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFountainsPuzzleMessage>(OINICMNOLPK);
	}

	private void CBPJBBAGIOE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadStatuePuzzleMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveStatuePuzzle(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadStatuePuzzleMessage>(OINICMNOLPK);
	}

	private void HJIKAKBDPDP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPuzzleMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceivePipePuzzle(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPipePuzzleMessage>(OINICMNOLPK);
	}

	private void OADHIDOLGHA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadStatuePuzzleMessage>(OINICMNOLPK);
	}

	private void HMIJFFMOOJF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFountainsPuzzleMessage>(OINICMNOLPK);
	}

	private void CCICNOMGGMC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadButtonPressPuzzleMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveCrystalPuzzle(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCrystalPuzzleMessage>(OINICMNOLPK);
	}

	private void EFGNMABJOGC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTorchPuzzleMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveKeyPuzzle(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadKeyPuzzleMessage>(OINICMNOLPK);
	}

	private void NCJKCCEAKKD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPuzzleMessage>(OINICMNOLPK);
	}

	private void PBGIBMJDCPA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTorchPuzzleMessage>(OINICMNOLPK);
	}

	private void CPODANPEJEN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPipePuzzleMessage>(OINICMNOLPK);
	}

	private void NHAOOOIFOLH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadOfferingPuzzleMessage>(OINICMNOLPK);
	}

	private void KOGOAJBMBEA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadOfferingPuzzleMessage>(OINICMNOLPK);
	}

	private void FHPBBMMGPHN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadOfferingPuzzleMessage>(OINICMNOLPK);
	}

	private void ODNCEEJOEOO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadKeyPuzzleMessage>(OINICMNOLPK);
	}

	private void KIGMDDHJBGA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTorchPuzzleMessage>(OINICMNOLPK);
	}

	private void AELEKFELKOL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadStatuePuzzleMessage>(OINICMNOLPK);
	}

	private void PHFCFKIKBEN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFountainsPuzzleMessage>(OINICMNOLPK);
	}

	private void HLCDKGKFPMK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPipePuzzleMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveButtonPressPuzzle(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadButtonPressPuzzleMessage>(OINICMNOLPK);
	}

	private void AKEOPNGCOPH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPuzzleMessage>(OINICMNOLPK);
	}

	private void MPAOEMHPLHE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadStatuePuzzleMessage>(OINICMNOLPK);
	}

	private void MGFJPEMOOGG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadButtonPressPuzzleMessage>(OINICMNOLPK);
	}

	public override void LoadMessageStart()
	{
		base.LoadMessageStart();
	}

	public override void OnPlayerLeftRoom(Player OKAOHBANICM)
	{
		for (int i = 0; i < MinePuzzleManager.puzzleInstances.Length; i++)
		{
			if (!((Object)(object)MinePuzzleManager.puzzleInstances[i] == (Object)null) && MinePuzzleManager.puzzleInstances[i].GetCurrentPuzzle() is OfferingStatuePuzzle offeringStatuePuzzle && !offeringStatuePuzzle.CanOpenPuzzle())
			{
				offeringStatuePuzzle.SetUILocked(PHCILCGMKNK: false);
			}
		}
	}

	private void IHBLBHHPEMM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPipePuzzleMessage>(OINICMNOLPK);
	}
}
