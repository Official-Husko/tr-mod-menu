using AlmenaraGames;
using UnityEngine;

public class CutDetection : MonoBehaviour
{
	public Harvestable harvest;

	public bool updateWeedsCutStat;

	public bool onlyIsDead;

	private void FNFNLFOJHHA()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void PCEFNHADDIG()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void OEAAPIBLALL()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void AJGPMBGBPGH()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void DEOPBEHPEIN(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("[ControllerType=") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Gass_Quest/Entry/23/Dialogue Text"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveDroppedItemMessage") ? 2 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("LE_21", 0);
		}
		PlayerInputs.DCAMKEOEKKP(jIIGOACEIKL, ControllersDatabaseAccessor.EAHOLBFLEAE(ControllersDatabase.VibrationMaterial.Pick));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.HarvestAction(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.GFKPHIPDKBM(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void OJOMNJEFKOG(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("FishCuttingEvent/Talk2") && !((Component)HANHCHBHHEH).gameObject.CompareTag("UI2"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/17/Dialogue Text") ? 1 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("Forward", 1);
		}
		PlayerInputs.TriggerVibration(jIIGOACEIKL, ControllersDatabaseAccessor.HDANLMKNMHB((ControllersDatabase.VibrationMaterial)8));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.LLBPIOHJHOC(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.MKOAFLNCNLJ(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("BetterDuringOneMonth") && !((Component)HANHCHBHHEH).gameObject.CompareTag("chatSounds"))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).gameObject.CompareTag("Cellar")) ? 1 : 4);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("</color>", 1);
		}
		PlayerInputs.AFAAEDALPII(jIIGOACEIKL, ControllersDatabaseAccessor.FCOPONLHAPP(ControllersDatabase.VibrationMaterial.SickleSwing));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.LLBPIOHJHOC(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.FANGEHGDLNG(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void AHKDANJMEMC(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("ChatCommandKickDescription") && !((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveSelectPerkLevelMaster"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("Crafters") ? 1 : 1);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("ReceiveButtonPress", 1);
		}
		PlayerInputs.DCAMKEOEKKP(jIIGOACEIKL, ControllersDatabaseAccessor.HJBAFKLIEJM((ControllersDatabase.VibrationMaterial)8));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.HarvestAction(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.GFKPHIPDKBM(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Attack/MainEvent 2") && !((Component)HANHCHBHHEH).gameObject.CompareTag("+"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag(" (Client)") ? 0 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("ReceiveThrowFish", 0);
		}
		PlayerInputs.TriggerVibration(jIIGOACEIKL, ControllersDatabaseAccessor.IBLGJCAPAMB((ControllersDatabase.VibrationMaterial)6));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.PHHEHBGGNOP(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.KJBFOECNKLB(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Tavern must be closed") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Eating"))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).gameObject.CompareTag("Bucket")) ? 1 : 5);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("Dialogue System/Conversation/Crowly_Standar/Entry/21/Dialogue Text", 1);
		}
		PlayerInputs.CDMFLDNDCPD(jIIGOACEIKL, ControllersDatabaseAccessor.EAHOLBFLEAE(ControllersDatabase.VibrationMaterial.SickleSwing));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.PHHEHBGGNOP(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.LGKDPFDNMPA(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void HNNBAAJAHEN()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Giving Quest 35") && !((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveAngryEnd"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("Lose") ? 5 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("Waking up in: ", 0);
		}
		PlayerInputs.AFAAEDALPII(jIIGOACEIKL, ControllersDatabaseAccessor.HJBAFKLIEJM((ControllersDatabase.VibrationMaterial)8));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.HarvestAction(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.NAFPABGHACJ, ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void PFIONHCONDI(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Gass_Stand/Entry/16/Dialogue Text") && !((Component)HANHCHBHHEH).gameObject.CompareTag("levelRequired"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("}") ? 1 : 1);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("Plant", 0);
		}
		PlayerInputs.CDMFLDNDCPD(jIIGOACEIKL, ControllersDatabaseAccessor.MJNNMAIJIFK(ControllersDatabase.VibrationMaterial.Hoe));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.LLBPIOHJHOC(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.HFIELOKJBJI(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void JOGBCDIAGEK()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_name_703") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Sit"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("UI2") ? 3 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("OnlyABird", 0);
		}
		PlayerInputs.CDMFLDNDCPD(jIIGOACEIKL, ControllersDatabaseAccessor.MJNNMAIJIFK(ControllersDatabase.VibrationMaterial.SickleCut));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.LLBPIOHJHOC(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.AKIGDLKMAAK(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void HEGNINLLINP()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("hallway") && !((Component)HANHCHBHHEH).gameObject.CompareTag("DialogueEndRPC"))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).gameObject.CompareTag("ThemeListScrollView")) ? 1 : 2);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("UIPreviousCategory", 0);
		}
		PlayerInputs.CDMFLDNDCPD(jIIGOACEIKL, ControllersDatabaseAccessor.EELGBLNBGPA((ControllersDatabase.VibrationMaterial)8));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.HarvestAction(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.MAJKNPNLHFM(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void BLAJFMAAMDO()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void BKJFLMPOLCH()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void JEMIPCBNPDI(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Invalid playerNum ") && !((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveRequestTableOrder"))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).gameObject.CompareTag("Interact")) ? 1 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("BuzzCanBuild", 0);
		}
		PlayerInputs.TriggerVibration(jIIGOACEIKL, ControllersDatabaseAccessor.ICANHOCHEBB((ControllersDatabase.VibrationMaterial)8));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.LLBPIOHJHOC(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.MKOAFLNCNLJ(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void OCMFFLLPHCK(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Hurt") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_description_674"))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).gameObject.CompareTag("itemPorter")) ? 1 : 2);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("<color=#BF0000>", 1);
		}
		PlayerInputs.TriggerVibration(jIIGOACEIKL, ControllersDatabaseAccessor.ICANHOCHEBB(ControllersDatabase.VibrationMaterial.Hoe));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.PHHEHBGGNOP(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.MCHGNCLEOKF(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void ACFABFCGIGH()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void KJJINNGPPEA(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Offer") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Melt"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("Player.Controllers null") ? 1 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("", 1);
		}
		PlayerInputs.DCAMKEOEKKP(jIIGOACEIKL, ControllersDatabaseAccessor.IBLGJCAPAMB(ControllersDatabase.VibrationMaterial.Ax));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.LLBPIOHJHOC(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.LGKDPFDNMPA(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Could not check user signed in status for reason ") && !((Component)HANHCHBHHEH).gameObject.CompareTag("replay banquet"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("talentTea") ? 1 : 1);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG(">", 0);
		}
		PlayerInputs.CDMFLDNDCPD(jIIGOACEIKL, ControllersDatabaseAccessor.CMDFFIAPONO(ControllersDatabase.VibrationMaterial.Ax));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.HarvestAction(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.OKKMGDHLENB(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void HFKOBCFMNJJ()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void FLFBLIOOLMA()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Waiter") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Invalid NPC photonID: {0} for NPCRoutine."))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("SatisfiedCustomers") ? 8 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("Light Fire", 1);
		}
		PlayerInputs.TriggerVibration(jIIGOACEIKL, ControllersDatabaseAccessor.FCOPONLHAPP(ControllersDatabase.VibrationMaterial.Spade));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.LLBPIOHJHOC(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.IIOBLEAFGMO(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void KKONKMFFILD(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("SkeletonBird") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Interact"))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).gameObject.CompareTag("CannotToggleUI RentRoomUI opened")) ? 1 : 3);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("Bartending speed", 0);
		}
		PlayerInputs.CDMFLDNDCPD(jIIGOACEIKL, ControllersDatabaseAccessor.GHLPAPHABNO((ControllersDatabase.VibrationMaterial)7));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.PHHEHBGGNOP(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.FGAJEKFDJGO(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void NOILIOLOOBJ()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void PDCKFGAJDJP(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Tutorial/T128/Dialogue1") && !((Component)HANHCHBHHEH).gameObject.CompareTag("LE_10"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("Argos") ? 0 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("BeginPirateMinigameRequest", 0);
		}
		PlayerInputs.DCAMKEOEKKP(jIIGOACEIKL, ControllersDatabaseAccessor.GHLPAPHABNO(ControllersDatabase.VibrationMaterial.Spade));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.HarvestAction(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.FAJBOEGHOPM(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void DMENPMHIPDA(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("add item ") && !((Component)HANHCHBHHEH).gameObject.CompareTag("\n<color=#BF0000>"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("SendEnabledNPCs") ? 2 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("Kicks the corresponding player from the game. Kicked players can rejoin if you do not lock the game.", 0);
		}
		PlayerInputs.TriggerVibration(jIIGOACEIKL, ControllersDatabaseAccessor.ANHGFMKKEPI(ControllersDatabase.VibrationMaterial.Hoe));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.PHHEHBGGNOP(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.CCJCCOJLIHK(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void NKJMIFCPJFA(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("BuildMode_ExitAndCancel") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/7/Dialogue Text"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("]") ? 5 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("Dialogue System/Conversation/Crowly_Standar/Entry/49/Dialogue Text", 0);
		}
		PlayerInputs.CDMFLDNDCPD(jIIGOACEIKL, ControllersDatabaseAccessor.GHLPAPHABNO(ControllersDatabase.VibrationMaterial.SickleSwing));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.PHHEHBGGNOP(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.FGAJEKFDJGO(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void CIMPOOJOMMH(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("") && !((Component)HANHCHBHHEH).gameObject.CompareTag("' to "))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("bathhouseinterior") ? 1 : 1);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("ObjectVerticalMove", 0);
		}
		PlayerInputs.TriggerVibration(jIIGOACEIKL, ControllersDatabaseAccessor.EELGBLNBGPA((ControllersDatabase.VibrationMaterial)6));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.HarvestAction(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.DJGGOENCBJG(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void AFCIKJPPLFA()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void FGFGCADFFBC()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void ILCBKEIEOAN()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void LJJDGAJNNCH(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveEnableNPC") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Top"))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).gameObject.CompareTag("/")) ? 1 : 8);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("Statue2={0}", 0);
		}
		PlayerInputs.DCAMKEOEKKP(jIIGOACEIKL, ControllersDatabaseAccessor.MLDKMAPEHGO(ControllersDatabase.VibrationMaterial.Ax));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.LLBPIOHJHOC(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.OPDOAOIGOCH(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void BNOJNEJMCID(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("FarmReady") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Walk Around cannot entry barn "))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).gameObject.CompareTag("[BartenderGender=")) ? 1 : 7);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("Error_CloseMenus", 0);
		}
		PlayerInputs.AFAAEDALPII(jIIGOACEIKL, ControllersDatabaseAccessor.GetVibrationProfile((ControllersDatabase.VibrationMaterial)8));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.HarvestAction(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.MCHGNCLEOKF(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void NCDBCDJKPLA()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void GBFBNCBDIOC(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Calm down") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Received {0} position to snap to: {1}"))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).gameObject.CompareTag("Brandy")) ? 1 : 8);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("RecieveSetAmbience", 0);
		}
		PlayerInputs.CDMFLDNDCPD(jIIGOACEIKL, ControllersDatabaseAccessor.MJNNMAIJIFK(ControllersDatabase.VibrationMaterial.SickleSwing));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.LLBPIOHJHOC(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.FAJBOEGHOPM(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Hikari/Introduce") && !((Component)HANHCHBHHEH).gameObject.CompareTag(""))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("Are you sure to change all buttons to default values?") ? 2 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("MenuMode/ButtonConfigure", 1);
		}
		PlayerInputs.CDMFLDNDCPD(jIIGOACEIKL, ControllersDatabaseAccessor.IAHNPIANHNP(ControllersDatabase.VibrationMaterial.Pick));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.HarvestAction(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.MKOAFLNCNLJ(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void PMLBFEFMNPF()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void MGJIGIBHAKK(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Trying to set rich presence key ") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Rowdy"))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).gameObject.CompareTag("Error_NoDogFoodOrWater")) ? 1 : 4);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG(" (", 1);
		}
		PlayerInputs.DCAMKEOEKKP(jIIGOACEIKL, ControllersDatabaseAccessor.NPHDECLHIHB(ControllersDatabase.VibrationMaterial.Ax));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.LLBPIOHJHOC(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.GFKPHIPDKBM(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("") && !((Component)HANHCHBHHEH).gameObject.CompareTag("[Variants] Piece {0} ({1}) has {2} variants and {3} are active. Only 1 should be active."))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("<sprite name=\"woodIcon\">") ? 0 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("SetAnimatorObjectBoolRPC", 1);
		}
		PlayerInputs.CDMFLDNDCPD(jIIGOACEIKL, ControllersDatabaseAccessor.ACECBDNDCKJ((ControllersDatabase.VibrationMaterial)8));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.PHHEHBGGNOP(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.MAPKINLELAM(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void ELEGGKIBHGC()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void JBBHDOMALDB()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void BPOOAHKHPCL()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("HarvestCut") && !((Component)HANHCHBHHEH).gameObject.CompareTag("HarvestCut2"))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).gameObject.CompareTag("HarvestCut2")) ? 1 : 2);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("weedsCut", 1);
		}
		PlayerInputs.TriggerVibration(jIIGOACEIKL, ControllersDatabaseAccessor.GetVibrationProfile(ControllersDatabase.VibrationMaterial.SickleCut));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.HarvestAction(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.NAFPABGHACJ, ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void PEOPFPEDFAK()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void JNJCCIFIKOC()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Gass_Introduce/Entry/11/Dialogue Text") && !((Component)HANHCHBHHEH).gameObject.CompareTag("MainProgress"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("Food") ? 6 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("Normal", 1);
		}
		PlayerInputs.TriggerVibration(jIIGOACEIKL, ControllersDatabaseAccessor.GetVibrationProfile((ControllersDatabase.VibrationMaterial)7));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.PHHEHBGGNOP(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.NKDJGHJJIPD(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void OOALHOHGANE(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Player/Bark/Tutorial/CantDoYet") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Farm/Bob/Barks_Close"))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).gameObject.CompareTag("HumanDisappear")) ? 1 : 7);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("Output is not ready", 0);
		}
		PlayerInputs.CDMFLDNDCPD(jIIGOACEIKL, ControllersDatabaseAccessor.HJBAFKLIEJM((ControllersDatabase.VibrationMaterial)7));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.LLBPIOHJHOC(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.DJGGOENCBJG(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void BNNLNCGNHFB(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("attachment") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Tutorial/T100/Dialogue1"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("Ax Level Low") ? 1 : 1);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("SalonDelTrono/OrwinIITalk", 0);
		}
		PlayerInputs.DCAMKEOEKKP(jIIGOACEIKL, ControllersDatabaseAccessor.HJBAFKLIEJM((ControllersDatabase.VibrationMaterial)6));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.LLBPIOHJHOC(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.NAFPABGHACJ, ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void NKGMEMEACNN()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void LIEIDOIDBLJ(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("MainProgress") && !((Component)HANHCHBHHEH).gameObject.CompareTag("LE_7"))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).gameObject.CompareTag("</color>")) ? 1 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("stormy clouds", 0);
		}
		PlayerInputs.DCAMKEOEKKP(jIIGOACEIKL, ControllersDatabaseAccessor.DMPAACNPNBA((ControllersDatabase.VibrationMaterial)6));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.LLBPIOHJHOC(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.BGMBLNEMIHN(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void OnDestroy()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void DCOEEADJLIK()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}

	private void AAOFFIJHHIB(Collider2D HANHCHBHHEH)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("'") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Open"))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Gass_Stand/Entry/14/Dialogue Text") ? 2 : 0);
		if (updateWeedsCutStat)
		{
			Utils.FKKHJPEMNBG("itemJerky", 0);
		}
		PlayerInputs.TriggerVibration(jIIGOACEIKL, ControllersDatabaseAccessor.ICPMABDEDHO(ControllersDatabase.VibrationMaterial.SickleSwing));
		if (Object.op_Implicit((Object)(object)harvest))
		{
			if (((Object)(object)harvest.cropSetter == (Object)null || ((Object)(object)harvest.cropSetter != (Object)null && !harvest.cropSetter.growable.isDead)) && !onlyIsDead)
			{
				harvest.HarvestAction(jIIGOACEIKL);
			}
			if ((Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
			{
				MultiAudioManager.PlayAudioObject(AudioLibrary.FANGEHGDLNG(), ((Component)this).transform.position);
				Utils.BLPDAEHPOBA(((Component)((Component)this).transform.parent).gameObject);
			}
		}
	}

	private void MBBIGANCPNE()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)harvest.cropSetter != (Object)null && harvest.cropSetter.growable.isDead)
		{
			Object.Instantiate<GameObject>(harvest.cropSetter.effectDeadCrop, ((Component)((Component)this).transform.parent).transform.position, ((Component)((Component)this).transform.parent).transform.rotation);
		}
	}
}
