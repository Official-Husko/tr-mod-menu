using System;
using AlmenaraGames;
using UnityEngine;

public class BuzzWalkAround : BuzzStateBase
{
	private bool walkingDone;

	private float nextWalk;

	private bool box;

	public void COACMHKHDBL()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(943f, 713f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool(":", EGFGNGJGBOP: false, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("Wall not found ", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.DHPFCKNGHLO() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.NJECJAHEOIA() < 629f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	private void GMFONHHLBIO()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("/");
	}

	public override void DKFOJDHBGEJ()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		walkingDone = false;
		if (!box)
		{
			buzzNpc.buzzAnimation.SetBool("Book", EGFGNGJGBOP: false);
			buzzNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(buzzNpc.boxPoint.transform.position), AHDHLIECIGH: false);
		}
		else
		{
			if ((Object)(object)buzzNpc.rummageAudio != (Object)null)
			{
				buzzNpc.rummageAudio.Stop(false);
				buzzNpc.rummageAudio = null;
			}
			buzzNpc.buzzAnimation.SetBool("Book", EGFGNGJGBOP: true);
			buzzNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(buzzNpc.doorPoint.transform.position), AHDHLIECIGH: false);
		}
		buzzNpc.walkTo.speed = buzzNpc.speed;
		NPCWalkTo walkTo = buzzNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = buzzNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		buzzNpc.walkTo.PEHELKCIECB();
	}

	private void NEEDNONKBAC()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("Rest");
	}

	private void ALBMMJPBAGA()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("KentaProgress");
	}

	private void GONBDDJHANF()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("Cheesy");
	}

	public void GBDLGKNDBIK()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(609f, 780f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("UI", EGFGNGJGBOP: true);
			buzzNpc.boxAnimator.SetBool("OnlinePlayer", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.EDIPJBOOEHD > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.DHPFCKNGHLO() < 1588f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	public void HNFMJFJPDNN()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(393f, 1469f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("PirateMinigame/Minigame", EGFGNGJGBOP: true, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("itemRyeSeeds", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.EDIPJBOOEHD > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BNKLACHEGOP() < 1526f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	private void KLDIIKJAKIB()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("TutorialPhase");
	}

	public void CAELADBMLFL()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(1796f, 1885f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("Cat", EGFGNGJGBOP: false, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("SurpriseJump", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.MCGJNJCELJG();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.GBCKNDKCFFF() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.GBCKNDKCFFF() < 679f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	public void BKNBKDKIDNJ()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(1177f, 1112f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("Disabled", EGFGNGJGBOP: false);
			buzzNpc.boxAnimator.SetBool("", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.DHPFCKNGHLO() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.NJECJAHEOIA() < 732f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	public void AGLOLKAIAMG()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(687f, 1550f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("</color>", EGFGNGJGBOP: true, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("ReceiveEmployee", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.MCGJNJCELJG();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.BBBGEBIPHPI() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BBBGEBIPHPI() < 257f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	private void KKDJEKACAIE()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("Snow");
	}

	public void BEEDFJOOPAH()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(691f, 846f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool(" not found", EGFGNGJGBOP: true);
			buzzNpc.boxAnimator.SetBool("Right Arrow", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.MCGJNJCELJG();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.NJECJAHEOIA() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BNKLACHEGOP() < 1623f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	private void HFLCAILNOHC()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("BeginPirateMinigameRequest");
	}

	public void FJNPFILECCM()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(854f, 1931f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("Setting private room code from steam was successful, but our current network state doesn't let us begin the connection or we're already in the process of establishing a connection. \nNetwork state: {0}.\nPhoton connected: {1}", EGFGNGJGBOP: false, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("ReceiveDecorationFloor", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.MCGJNJCELJG();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.NJECJAHEOIA() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.EDIPJBOOEHD < 68f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	public void IHEHHCLJFDK()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(1063f, 987f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("Sprint time", EGFGNGJGBOP: true);
			buzzNpc.boxAnimator.SetBool("UIAddRemove", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.BarksBuzzDoor();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.BNKLACHEGOP() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BNKLACHEGOP() < 1136f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	public void CEDKNKOPKAH()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(191f, 787f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("add item ", EGFGNGJGBOP: true);
			buzzNpc.boxAnimator.SetBool("SmokeBomb", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.GBCKNDKCFFF() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.NJECJAHEOIA() < 1330f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	private void KLMENKODJNG()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("Missing fade image for coop mode");
	}

	public void OKHDMEMEIEJ()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(112f, 1479f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("OnFloor", EGFGNGJGBOP: true);
			buzzNpc.boxAnimator.SetBool("Dialogue System/Conversation/TooHot/Entry/5/Dialogue Text", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.MCGJNJCELJG();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.DHPFCKNGHLO() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.EDIPJBOOEHD < 1733f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	public void KIMEBNLKFBK()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(648f, 800f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool(" ", EGFGNGJGBOP: false);
			buzzNpc.boxAnimator.SetBool("X", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.BarksBuzzDoor();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.BBBGEBIPHPI() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BBBGEBIPHPI() < 1621f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	public void HILLNFIICFK()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(1190f, 1511f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("Feet", EGFGNGJGBOP: true, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("is not a food instance", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.EDIPJBOOEHD > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.DHPFCKNGHLO() < 413f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	private void EBBAPFKABDB()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("tutorialPopUp115");
	}

	public void KNGKEAPDNLP()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(929f, 1579f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("Precision/DrinkEvent3", EGFGNGJGBOP: true);
			buzzNpc.boxAnimator.SetBool("Grass", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.EDIPJBOOEHD > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.GBCKNDKCFFF() < 701f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	private void LHEHNNJGINH()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("Select");
	}

	private void JLMKOKBPLFN()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("All plants have grown.");
	}

	public void PADPIEKGNMH()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(1829f, 31f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("Items/item_description_601", EGFGNGJGBOP: true);
			buzzNpc.boxAnimator.SetBool("/unlock: ", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.MCGJNJCELJG();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.DHPFCKNGHLO() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.DHPFCKNGHLO() < 781f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	private void GJMOKBGIBEP()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("beach");
	}

	private void ACLOFACNPDP()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("Dialogue System/Conversation/Gass_Quest/Entry/2/Dialogue Text");
	}

	private void CCHENCELDDJ()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("Interact");
	}

	public void FEHGALEDJKI()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(149f, 744f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("Trying to load group ingredient with ID ", EGFGNGJGBOP: true, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("Pet", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.BBBGEBIPHPI() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.EDIPJBOOEHD < 1306f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	private void BKKEBAFPNIA()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("itemBottle");
	}

	private void BMOAEAFBKAD()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("Title Screen");
	}

	public void EDDOIJHPBHM()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(1615f, 946f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("Disabled", EGFGNGJGBOP: true, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("talentLager", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.BNKLACHEGOP() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BNKLACHEGOP() < 1171f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	public void MAILEMECPME()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(991f, 1967f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("", EGFGNGJGBOP: false);
			buzzNpc.boxAnimator.SetBool("Items/item_description_1090", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.BNKLACHEGOP() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.NJECJAHEOIA() < 523f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	public void IKOIKCHBBNG()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(335f, 454f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("Could not find recipe with id: ", EGFGNGJGBOP: false, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("City/Woody/Bark/Buy", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.EDIPJBOOEHD > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BNKLACHEGOP() < 961f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	private void ALEEFHFLAIK()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("ERROR: The object ");
	}

	public void MKJDIMFOGIA()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(83f, 1753f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("Building", EGFGNGJGBOP: true, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool(" ", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.GBCKNDKCFFF() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BBBGEBIPHPI() < 1773f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	public override void IMLDLPHOAOJ()
	{
		if (!walkingDone && buzzNpc.walkTo.IIMEFNIECLI())
		{
			nextWalk = Time.fixedTime + Random.Range(2f, 10f);
			walkingDone = true;
		}
		if (walkingDone && Time.fixedTime > nextWalk - 0.2f && box)
		{
			buzzNpc.buzzAnimation.SetBool("Rummage", EGFGNGJGBOP: false);
			buzzNpc.boxAnimator.SetBool("Rummage", false);
			if ((Object)(object)buzzNpc.rummageAudio != (Object)null)
			{
				buzzNpc.rummageAudio.Stop(false);
				buzzNpc.rummageAudio = null;
			}
		}
		if (walkingDone && Time.fixedTime > nextWalk && buzzNpc.content.activeInHierarchy)
		{
			ACOJHBFFFIF();
		}
	}

	private void GBDAMMFCECP()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("Items/item_description_1083");
	}

	private void FOMDNPODHLG()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("Items/item_name_637");
	}

	public void GOPIJNFDCME()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(778f, 197f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("Requirements not met", EGFGNGJGBOP: true);
			buzzNpc.boxAnimator.SetBool("cameraZoom", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.BarksBuzzDoor();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.BBBGEBIPHPI() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BBBGEBIPHPI() < 513f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	public void IDBCMIMFHJC()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(1881f, 1703f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("[", EGFGNGJGBOP: false);
			buzzNpc.boxAnimator.SetBool("", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.EDIPJBOOEHD > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BBBGEBIPHPI() < 1669f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		NPCWalkTo walkTo = buzzNpc.walkTo;
		walkTo.OnFailStart = (Action)Delegate.Remove(walkTo.OnFailStart, new Action(ACOJHBFFFIF));
	}

	private void JEJGIAPPCLG()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("GameEvent of type ");
	}

	public void FIKLNLMANCH()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(1676f, 98f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("ReceivePlayerDisconnected", EGFGNGJGBOP: true, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("RecieveStartEvent", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.MCGJNJCELJG();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.BBBGEBIPHPI() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BBBGEBIPHPI() < 1012f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	private void AEOBJMKNACK()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("Tutorial/T117/Dialogue3");
	}

	public void BCDDGNEGDNL()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(1741f, 168f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("</color>", EGFGNGJGBOP: false, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("Dialogue System/Conversation/Gass_Quest/Entry/41/Dialogue Text", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.GBCKNDKCFFF() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BNKLACHEGOP() < 557f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	private void GANFLECJKBE()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("replay ninja");
	}

	public void IIEGDHJEEKC()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(97f, 1362f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("travelling time -", EGFGNGJGBOP: true, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("BuzzBuildExit", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.BarksBuzzDoor();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.NJECJAHEOIA() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.DHPFCKNGHLO() < 340f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	public void PDOBHPLPKHG()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(2f, 4f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("Rummage", EGFGNGJGBOP: true);
			buzzNpc.boxAnimator.SetBool("Rummage", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.BarksBuzzDoor();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.EDIPJBOOEHD > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.EDIPJBOOEHD < 4f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	private void EHNACEHHOJK()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("itemMushroom");
	}

	public void DLFBDNPEKAE()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(319f, 1662f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("Tray", EGFGNGJGBOP: true, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("WeaponEnd", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.DHPFCKNGHLO() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.GBCKNDKCFFF() < 262f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	private void PBMBOPDALGD()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("[OfferingStatuePuzzle] No required items configured in OfferingPuzzleSettings.");
	}

	private void OFEMFGCBLBH()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger(" ");
	}

	private void HMCGBJCGGEF()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger(")");
	}

	public void BFGEFKOODNA()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(591f, 1857f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("UIPreviousCategory", EGFGNGJGBOP: false, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("ProductValue", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.BarksBuzzDoor();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.NJECJAHEOIA() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.EDIPJBOOEHD < 513f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		buzzNpc.buzzAnimation.SetBool("Rummage", EGFGNGJGBOP: false);
		buzzNpc.boxAnimator.SetBool("Rummage", false);
		DKFOJDHBGEJ();
	}

	private void PMBPNCEPMHN()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("Error in StaffManager.StaffInstantGoHome: ");
	}

	public void FOEBEJHKEKE()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(1574f, 1831f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("Items/item_description_696", EGFGNGJGBOP: false);
			buzzNpc.boxAnimator.SetBool("FireUp", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.BarksBuzzDoor();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.BNKLACHEGOP() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.DHPFCKNGHLO() < 1955f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	private void MIFEFJBGDEP()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("Disabled");
	}

	public void IEJGDOPLBLB()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(1061f, 1239f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("ClosePopUp", EGFGNGJGBOP: false);
			buzzNpc.boxAnimator.SetBool(" seconds.", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.BNKLACHEGOP() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.DHPFCKNGHLO() < 1629f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	private void DMKNBLCAJDB()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("Right Stick Up");
	}

	private void FIFEIDAMIIG()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("TooCold");
	}

	private void DIMDLCIFFPF()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("Eating");
	}

	private void DKMIGLDKNIO()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("Sony DualShock");
	}

	private void MDILLGFCCMI()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("\n");
	}

	private void KNDLFHILBMA()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("_");
	}

	private void JAHKKNGPCJO()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("Dialogue System/Conversation/BirdPositiveComments/Entry/11/Dialogue Text");
	}

	public void OGBEGBJDNKJ()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(586f, 330f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("Occupied Positions", EGFGNGJGBOP: true);
			buzzNpc.boxAnimator.SetBool("itemJam", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.MCGJNJCELJG();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.NJECJAHEOIA() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.NJECJAHEOIA() < 1586f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	public void KBCKFDDDEGE()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(924f, 351f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("</color>", EGFGNGJGBOP: true);
			buzzNpc.boxAnimator.SetBool("Not enough money", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.BNKLACHEGOP() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.NJECJAHEOIA() < 1451f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	public void HMLFDDDGGBO()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(503f, 307f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("", EGFGNGJGBOP: true, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("Harvest", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.BarksBuzzDoor();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.BBBGEBIPHPI() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.NJECJAHEOIA() < 809f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	public void AAPBBHOHMIJ()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(290f, 1680f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("Tutorial/T127/Dialogue1", EGFGNGJGBOP: false, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("DiningRoomTiles", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.BarksBuzzDoor();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.EDIPJBOOEHD > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.NJECJAHEOIA() < 1069f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	private void KPNKHMHMBOF()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("Disabled");
	}

	private void BHKLMNJGLFN()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("ObjectMove");
	}

	public void LACDAMFANIM()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(927f, 483f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("MineFloor", EGFGNGJGBOP: true);
			buzzNpc.boxAnimator.SetBool(")", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.BNKLACHEGOP() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.NJECJAHEOIA() < 1881f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	public void ABMMONFHFGF()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(367f, 1882f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("ReceiveNewState", EGFGNGJGBOP: false, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("BarnTutorialDone", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.GBCKNDKCFFF() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.GBCKNDKCFFF() < 1326f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	private void ENOEOGABPIC()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("Interact");
	}

	private void HKGKJCOKLLD()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("sickleDesc");
	}

	public void NKAMNKDKLHI()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(636f, 938f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("Screenshot not found", EGFGNGJGBOP: true, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("UIAddRemove", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.MCGJNJCELJG();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.NJECJAHEOIA() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.DHPFCKNGHLO() < 1714f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	public void EBLFKBEMCKL()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(780f, 880f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("Ingredients", EGFGNGJGBOP: false);
			buzzNpc.boxAnimator.SetBool("Talk", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.MCGJNJCELJG();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.GBCKNDKCFFF() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.EDIPJBOOEHD < 157f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = !box;
	}

	public void AHPFECCLOBB()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(661f, 1721f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("StackManager", EGFGNGJGBOP: true, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("ReceiveNextRound", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.BarksBuzzDoor();
		}
		else
		{
			buzzNpc.content.SetActive(false);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.SendDisableContent();
			}
			if (WorldTime.BBBGEBIPHPI() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BBBGEBIPHPI() < 1443f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	private void HEADJCFMKIP()
	{
		buzzNpc.content.SetActive(false);
		animator.SetTrigger("[ProceduralMine] AltarFirst: {0} - AltarTarget: {1} - PuzzleTarget: {2}");
	}

	private void ACOJHBFFFIF()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("Walk");
	}

	private void MDLHDGDLANK()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("FadeOut");
	}

	private void GBLGELBAPOJ()
	{
		buzzNpc.content.SetActive(true);
		animator.SetTrigger("Ingredients");
	}

	public void PKKNFNMFOON()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(1827f, 197f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.CGEADHOLHCH("UIInteract", EGFGNGJGBOP: false, HALNIEBONKH: true);
			buzzNpc.boxAnimator.SetBool("\n", false);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.ODNOKGHNGCC();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.NJECJAHEOIA() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.BNKLACHEGOP() < 419f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[1];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}

	public void MMPGIKGMFMA()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		nextWalk = Time.time + Random.Range(58f, 221f);
		if (!box)
		{
			buzzNpc.buzzAnimation.LookDirectionByAngle(Vector2.down);
			buzzNpc.buzzAnimation.SetBool("[", EGFGNGJGBOP: true);
			buzzNpc.boxAnimator.SetBool(" seconds.", true);
			buzzNpc.rummageAudio = MultiAudioManager.PlayAudioObject(buzzNpc.rummageSound, ((Component)buzzNpc).transform);
			buzzNpc.BarksBuzzDoor();
		}
		else
		{
			buzzNpc.content.SetActive(true);
			if (OnlineManager.PlayingOnline())
			{
				buzzNpc.onlineDialogue.APGJMNHJNHN();
			}
			if (WorldTime.GBCKNDKCFFF() > buzzNpc.hour * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR || WorldTime.EDIPJBOOEHD < 171f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
			{
				buzzNpc.doorSprite.sprite = buzzNpc.doorSprites[0];
				MultiAudioManager.PlayAudioObject(buzzNpc.closeDoorSound, ((Component)buzzNpc).transform);
			}
		}
		box = box;
	}
}
