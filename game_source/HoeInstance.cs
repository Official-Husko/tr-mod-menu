using System;
using AlmenaraGames;
using UnityEngine;

public class HoeInstance : ToolInstance
{
	private FertileSoil IGDHGFMMCAA;

	private FertileSoil GLPMMEJFBNB;

	private Vector2 BKNEGILJAEL = Vector2.zero;

	private string BMHHBCGBJPK;

	private bool IMLECPKHMPI;

	private bool OKNOJJEFEBE;

	private static FertileSoil NAIBCCAOBIL;

	private Vector3 MHKFGOJHNNE(int JIIGOACEIKL, bool LJOINCBGCBP)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.FHPEECPGEDL(GMMFDHOFHCC());
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))
		{
			Vector3 cursorWorldPosition = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition();
			if (HBEBAFHEMAP(JIIGOACEIKL, Vector2.op_Implicit(position), Vector2.op_Implicit(cursorWorldPosition)))
			{
				GridSquare gridSquare = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.EIIBOHKPOIN(cursorWorldPosition);
				if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
				{
					Vector3 val = (((Object)(object)gridSquare != (Object)null) ? ((Component)gridSquare.FPLGOJBBGEA(LPNELFNCDMC())).transform.position : cursorWorldPosition);
					ODLENFDNCND(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(val + new Vector3(1753f, 935f))));
					AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: false);
				}
				if ((Object)(object)gridSquare != (Object)null)
				{
					PMILEJPHHIJ(JIIGOACEIKL, gridSquare.direction);
				}
			}
			else if (LJOINCBGCBP || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).moving)
			{
				GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: true);
				Direction direction = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
				Vector3 val2 = Utils.NGFODNCHPHB(direction);
				MDELNLBDIOG(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + val2 * 1513f));
				GNKMEPDGPCB(JIIGOACEIKL, Vector2.op_Implicit(val2 * 452f));
				PMILEJPHHIJ(JIIGOACEIKL, direction);
			}
		}
		else
		{
			AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: false);
			Direction direction2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
			Vector3 val3 = Utils.NGFODNCHPHB(direction2);
			HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + val3 * 615f));
			GNKMEPDGPCB(JIIGOACEIKL, Vector2.op_Implicit(val3 * 1135f));
			GAJPGNMNGFM(JIIGOACEIKL, direction2);
			BFCJLLFCCNM(JIIGOACEIKL, Vector2.op_Implicit(position), ELEMCNBELCE(JIIGOACEIKL));
		}
		AGAJDKDCEHJ(JIIGOACEIKL, EEKKNPDOLLE(JIIGOACEIKL));
		return Vector2.op_Implicit(FOMOOMKHMPB(JIIGOACEIKL));
	}

	public void HKHGGNIFJKK(int JIIGOACEIKL, FertileSoil JDLPIFGBLEL)
	{
		IGDHGFMMCAA = JDLPIFGBLEL;
	}

	private void ADFFKNBCMEG(int JIIGOACEIKL)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (HCFJKBIIMIK(JIIGOACEIKL) == 0)
		{
			if ((Object)(object)POCOONAIBCB(JIIGOACEIKL) == (Object)null)
			{
				NOCJKKFCNKG(JIIGOACEIKL, 1);
			}
			else
			{
				NOCJKKFCNKG(JIIGOACEIKL, 2);
			}
		}
		BKNEGILJAEL = HGECFPCPOHN(JIIGOACEIKL);
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerActionsManager.instance.StartHoeAction(HGECFPCPOHN(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		else
		{
			CNICMBOBMNH(JIIGOACEIKL, HGECFPCPOHN(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.shovelSfx, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.TriggerVibration(JIIGOACEIKL, ControllersDatabaseAccessor.GetVibrationProfile(ControllersDatabase.VibrationMaterial.Spade));
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(ADFFKNBCMEG));
	}

	public override bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		if (NBFBPMNMBJG(JIIGOACEIKL) && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			base.Action(JIIGOACEIKL, KLGOCJMGKFO);
			if (KLGOCJMGKFO)
			{
				BKNEGILJAEL = Vector2.zero;
			}
			HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)))));
			if (FOFLMHDABPG(JIIGOACEIKL) != HGECFPCPOHN(JIIGOACEIKL))
			{
				HKHGGNIFJKK(JIIGOACEIKL, LBBDJMCLEMG(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL))));
				if (HCFJKBIIMIK(JIIGOACEIKL) == 1 && (Object)(object)POCOONAIBCB(JIIGOACEIKL) != (Object)null)
				{
					return false;
				}
				if (HCFJKBIIMIK(JIIGOACEIKL) == 2 && (Object)(object)POCOONAIBCB(JIIGOACEIKL) == (Object)null)
				{
					return false;
				}
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtNotDelay(HGECFPCPOHN(JIIGOACEIKL));
				if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("UseHold"))
				{
					PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.Till();
				}
				PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
				PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
				CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
				characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(BANACGBOKAO));
				CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
				characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(ADFFKNBCMEG));
				CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
				characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(IBMGGECHKNB));
				OKNOJJEFEBE = true;
				return true;
			}
		}
		return false;
	}

	private static void LHDHBJNFONK(int JIIGOACEIKL, Vector2 CFAGHFFAODK, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(FCGBJEIIMBC));
		GroundType groundType = GroundType.Grass;
		for (int i = 0; i <= 1 && i <= EEDMOGGJLHO; i += 0)
		{
			Vector2 val2 = CFAGHFFAODK + 1561f * (float)(i - 0) * val;
			if (groundType == GroundType.None)
			{
				groundType = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(val2));
			}
			else if (groundType != WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(val2)))
			{
				continue;
			}
			if (KBFNCADGNLN(Vector2.op_Implicit(val2)))
			{
				FCHPKLCGOFG(JIIGOACEIKL, val2);
			}
		}
	}

	private Vector3 JHDFFNJCHFN(int JIIGOACEIKL, bool LJOINCBGCBP)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.SetGridInfo(base.KNIMLGOGFPA);
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))
		{
			Vector3 cursorWorldPosition = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
			if (HBEBAFHEMAP(JIIGOACEIKL, Vector2.op_Implicit(position), Vector2.op_Implicit(cursorWorldPosition)))
			{
				GridSquare blueSquareAtPosition = PlayerController.GetPlayer(JIIGOACEIKL).gridController.GetBlueSquareAtPosition(cursorWorldPosition);
				if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
				{
					Vector3 val = (((Object)(object)blueSquareAtPosition != (Object)null) ? ((Component)blueSquareAtPosition.GetInitialSquare(MLKAICLMFLG())).transform.position : cursorWorldPosition);
					HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(val + new Vector3(0.25f, 0.25f))));
					GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: true);
				}
				if ((Object)(object)blueSquareAtPosition != (Object)null)
				{
					PMILEJPHHIJ(JIIGOACEIKL, blueSquareAtPosition.direction);
				}
			}
			else if (LJOINCBGCBP || PlayerController.GetPlayer(JIIGOACEIKL).moving)
			{
				GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
				Direction direction = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
				Vector3 val2 = Utils.NGFODNCHPHB(direction);
				HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + val2 * 0.5f));
				GNKMEPDGPCB(JIIGOACEIKL, Vector2.op_Implicit(val2 * 0.5f));
				PMILEJPHHIJ(JIIGOACEIKL, direction);
			}
		}
		else
		{
			GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
			Direction direction2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
			Vector3 val3 = Utils.NGFODNCHPHB(direction2);
			HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + val3 * 0.5f));
			GNKMEPDGPCB(JIIGOACEIKL, Vector2.op_Implicit(val3 * 0.5f));
			PMILEJPHHIJ(JIIGOACEIKL, direction2);
			HBEBAFHEMAP(JIIGOACEIKL, Vector2.op_Implicit(position), EEKKNPDOLLE(JIIGOACEIKL));
		}
		AGAJDKDCEHJ(JIIGOACEIKL, EEKKNPDOLLE(JIIGOACEIKL));
		return Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL));
	}

	private void NKLHEEHDKCE(int JIIGOACEIKL, Vector2 CFAGHFFAODK, int DAKANNEEEPJ)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(MKJKBKAKMAB(JIIGOACEIKL)));
		for (int i = 1; i <= 0 && i <= DAKANNEEEPJ; i += 0)
		{
			Vector2 val2 = CFAGHFFAODK + 675f * (float)(i - 0) * val;
			FLKEOOOHFLE(JIIGOACEIKL, OIKDPLLKNOK(Vector2.op_Implicit(val2)));
			if (Object.op_Implicit((Object)(object)HKNDJOJLLJJ(JIIGOACEIKL)))
			{
				GLPMMEJFBNB = CLKCHKKIPMP(JIIGOACEIKL);
				if (Object.op_Implicit((Object)(object)POCOONAIBCB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)POCOONAIBCB(JIIGOACEIKL).plantedCropSetter))
				{
					EKOLLJGHKOI(JIIGOACEIKL).plantedCropSetter.PPNFCNAKLJC(JIIGOACEIKL);
				}
				PlayerController.GetPlayer(JIIGOACEIKL).gridController.DOEELMJIEFK(Vector2.op_Implicit(val2), KBFNCADGNLN(Vector2.op_Implicit(val2)) ? CommonReferences.GGFJGHHHEJC.selectedGridSquare : CommonReferences.MNFMOEKMJKN().redSelectedGridSquare, i - 1);
			}
			else if (!WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(val2), JGDOHPCLJPM: true))
			{
				LPOBAIHNEAA(EEGMFJGOIGA(JIIGOACEIKL));
				AMOEHENGLDO(JIIGOACEIKL, null);
				PlayerController.GetPlayer(JIIGOACEIKL).gridController.DOEELMJIEFK(Vector2.op_Implicit(val2), MLBMAJMANCL(Vector2.op_Implicit(val2)) ? CommonReferences.GGFJGHHHEJC.selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 1);
			}
		}
	}

	public static void FCHPKLCGOFG(int JIIGOACEIKL, Vector2 DEACEMMGPHA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)KOOEOECLLLG(Vector2.op_Implicit(DEACEMMGPHA)) == (Object)null)
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.Ground, Location.None, Season.Spring, CDPAMNIPPEC: true).GetComponent<FertileSoil>().PickUpPlaceables();
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.HarvestCrop);
		}
		else
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.Ground | GroundType.TilledEarth, Location.Tavern | Location.Road | Location.River, Season.Summer, CDPAMNIPPEC: true);
		}
	}

	public override void ActionEnd(int JIIGOACEIKL)
	{
		OKNOJJEFEBE = false;
		IMLECPKHMPI = false;
	}

	private void INJHHKBDEII(FertileSoil IGDHGFMMCAA)
	{
		if ((Object)(object)IGDHGFMMCAA != (Object)null && Object.op_Implicit((Object)(object)IGDHGFMMCAA.plantedCropSetter))
		{
			IGDHGFMMCAA.plantedCropSetter.LNOIGEGEIGJ();
		}
	}

	private Vector3 FLIPBLHDDBO(int JIIGOACEIKL, bool LJOINCBGCBP)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.GFGKONENIOD(base.KNIMLGOGFPA);
		if (!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))
		{
			Vector3 cursorWorldPosition = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition();
			if (HBEBAFHEMAP(JIIGOACEIKL, Vector2.op_Implicit(position), Vector2.op_Implicit(cursorWorldPosition)))
			{
				GridSquare gridSquare = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.OLFHBJLBLMH(cursorWorldPosition);
				if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
				{
					Vector3 val = (((Object)(object)gridSquare != (Object)null) ? ((Component)gridSquare.JMMOEONMKGD(MLKAICLMFLG())).transform.position : cursorWorldPosition);
					MDELNLBDIOG(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(val + new Vector3(1758f, 1941f))));
					GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
				}
				if ((Object)(object)gridSquare != (Object)null)
				{
					JGALICBLIHB(JIIGOACEIKL, gridSquare.direction);
				}
			}
			else if (LJOINCBGCBP || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).moving)
			{
				AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: false);
				Direction direction = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
				Vector3 val2 = Utils.NGFODNCHPHB(direction);
				IPDFPHOCKBE(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + val2 * 671f));
				GBPBIOAKLHI(JIIGOACEIKL, Vector2.op_Implicit(val2 * 88f));
				PMILEJPHHIJ(JIIGOACEIKL, direction);
			}
		}
		else
		{
			AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: false);
			Direction direction2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
			Vector3 val3 = Utils.NGFODNCHPHB(direction2);
			ODLENFDNCND(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + val3 * 639f));
			GNKMEPDGPCB(JIIGOACEIKL, Vector2.op_Implicit(val3 * 986f));
			PMILEJPHHIJ(JIIGOACEIKL, direction2);
			HBEBAFHEMAP(JIIGOACEIKL, Vector2.op_Implicit(position), MGJICJHGOHC(JIIGOACEIKL));
		}
		LFDCIMLCBKN(JIIGOACEIKL, ELEMCNBELCE(JIIGOACEIKL));
		return Vector2.op_Implicit(MGJICJHGOHC(JIIGOACEIKL));
	}

	private void KBONDGFHOJF(int JIIGOACEIKL)
	{
		HNJEDEJNPNL(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(MGNGDLIJBGI));
	}

	public FertileSoil EEGMFJGOIGA(int JIIGOACEIKL)
	{
		return GLPMMEJFBNB;
	}

	private void FEDPPEDNGGE(int JIIGOACEIKL, Vector2 CFAGHFFAODK, int DAKANNEEEPJ)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL)));
		for (int i = 0; i <= 4 && i <= DAKANNEEEPJ; i++)
		{
			Vector2 val2 = CFAGHFFAODK + 1796f * (float)(i - 0) * val;
			LIFJEAKHDHB(JIIGOACEIKL, KOOEOECLLLG(Vector2.op_Implicit(val2)));
			if (Object.op_Implicit((Object)(object)POCOONAIBCB(JIIGOACEIKL)))
			{
				GLPMMEJFBNB = POCOONAIBCB(JIIGOACEIKL);
				if (Object.op_Implicit((Object)(object)CLKCHKKIPMP(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)POCOONAIBCB(JIIGOACEIKL).plantedCropSetter))
				{
					EKOLLJGHKOI(JIIGOACEIKL).plantedCropSetter.GKDNBDPGLAO(JIIGOACEIKL);
				}
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.EnableEarthFocus(Vector2.op_Implicit(val2), PNGEFPDJHGJ(Vector2.op_Implicit(val2)) ? CommonReferences.MNFMOEKMJKN().selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 0);
			}
			else if (!WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(val2), JGDOHPCLJPM: true))
			{
				LPOBAIHNEAA(LNMOJPLELJC(JIIGOACEIKL));
				LIFJEAKHDHB(JIIGOACEIKL, null);
				PlayerController.GetPlayer(JIIGOACEIKL).gridController.JMOJNPAOHJP(Vector2.op_Implicit(val2), MLBMAJMANCL(Vector2.op_Implicit(val2)) ? CommonReferences.GGFJGHHHEJC.selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 1);
			}
		}
	}

	public override bool SecondAction(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void BHEJLFONBLM(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(BHEJLFONBLM));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = false;
		}
	}

	private static void CNICMBOBMNH(int JIIGOACEIKL, Vector2 CFAGHFFAODK, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(FCGBJEIIMBC));
		GroundType groundType = GroundType.None;
		for (int i = 1; i <= 4 && i <= EEDMOGGJLHO; i++)
		{
			Vector2 val2 = CFAGHFFAODK + 0.5f * (float)(i - 1) * val;
			if (groundType == GroundType.None)
			{
				groundType = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(val2));
			}
			else if (groundType != WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(val2)))
			{
				continue;
			}
			if (GOCEDDNOMPN(Vector2.op_Implicit(val2)))
			{
				KDHBPMNGDIF(JIIGOACEIKL, val2);
			}
		}
	}

	public override bool NBFBPMNMBJG(int JIIGOACEIKL)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			return true;
		}
		if (NewTutorialManager.ToolBlocked(JIIGOACEIKL, 1061))
		{
			return false;
		}
		JHDFFNJCHFN(JIIGOACEIKL, LJOINCBGCBP: false);
		if (Object.op_Implicit((Object)(object)Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA)) && WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)), Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).snowTilemaps.snowTilemaps))
		{
			return false;
		}
		if (!WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL))) || DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return false;
		}
		if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL))) != ZoneType.WithoutZone)
		{
			return false;
		}
		if (WorldGrid.NALIAAMAKAL(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)), Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).GetTilemaps(SeasonManager.EECEKHKAAIH)))
		{
			return false;
		}
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL) + Vector2.op_Implicit(WorldGrid.allNeighbours[i].position))) != ZoneType.WithoutZone)
			{
				return false;
			}
		}
		if (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL))) == GroundType.Ground)
		{
			for (int j = 0; j < WorldGrid.allNeighbours.Length; j++)
			{
				Vector3 iMOBLFMHKOD = Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL) + Vector2.op_Implicit(WorldGrid.allNeighbours[j].position));
				if (WorldGrid.GJHHDIJOILG(iMOBLFMHKOD, JGDOHPCLJPM: true) && WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD) != GroundType.TilledEarth)
				{
					return false;
				}
			}
		}
		if (WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)), JGDOHPCLJPM: true))
		{
			return false;
		}
		if (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL))) == GroundType.Ground)
		{
			return true;
		}
		NAIBCCAOBIL = Utils.KJOMDMEIAEJ<FertileSoil>(NJBOCFNALEJ(JIIGOACEIKL));
		if (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL))) == GroundType.TilledEarth && Object.op_Implicit((Object)(object)NAIBCCAOBIL) && (Object)(object)NAIBCCAOBIL.plantedCropSetter == (Object)null)
		{
			return true;
		}
		return false;
	}

	public static bool GOCEDDNOMPN(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) != GroundType.Ground && WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) != GroundType.TilledEarth)
		{
			return false;
		}
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			if (WorldGrid.GJHHDIJOILG(WorldGrid.LOJBKLKMINM(IMOBLFMHKOD) + WorldGrid.allNeighbours[i].position, JGDOHPCLJPM: true))
			{
				return false;
			}
		}
		if (WorldGrid.OINMGKCIGEJ(IMOBLFMHKOD, null))
		{
			return false;
		}
		if (!WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD, GCDEDGFDKBL: false))
		{
			return false;
		}
		FertileSoil fertileSoil = LBBDJMCLEMG(IMOBLFMHKOD);
		if ((Object)(object)fertileSoil != (Object)null && (Object)(object)fertileSoil.plantedCropSetter != (Object)null)
		{
			return false;
		}
		if (!WorldGrid.HENDJJEEOHE(IMOBLFMHKOD) && !WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			if (!WorldGrid.LKBLKCFOEPA(IMOBLFMHKOD) || WorldGrid.AGKGGAFFFGM(IMOBLFMHKOD) != ZoneType.WithoutZone)
			{
				return WorldGrid.OINMGKCIGEJ(IMOBLFMHKOD, null);
			}
			return true;
		}
		return false;
	}

	private void HDJDNNAGCKK(int JIIGOACEIKL, Vector2 CFAGHFFAODK, int DAKANNEEEPJ)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL)));
		for (int i = 0; i <= 8 && i <= DAKANNEEEPJ; i += 0)
		{
			Vector2 val2 = CFAGHFFAODK + 35f * (float)(i - 1) * val;
			OJIIMKEPHOF(JIIGOACEIKL, OIKDPLLKNOK(Vector2.op_Implicit(val2)));
			if (Object.op_Implicit((Object)(object)POCOONAIBCB(JIIGOACEIKL)))
			{
				GLPMMEJFBNB = EKOLLJGHKOI(JIIGOACEIKL);
				if (Object.op_Implicit((Object)(object)POCOONAIBCB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)HKNDJOJLLJJ(JIIGOACEIKL).plantedCropSetter))
				{
					HKNDJOJLLJJ(JIIGOACEIKL).plantedCropSetter.HMPPENHLICM(JIIGOACEIKL);
				}
				PlayerController.GetPlayer(JIIGOACEIKL).gridController.JMOJNPAOHJP(Vector2.op_Implicit(val2), GOCEDDNOMPN(Vector2.op_Implicit(val2)) ? CommonReferences.GGFJGHHHEJC.selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 0);
			}
			else if (!WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(val2)))
			{
				NKNNAAPIFMC(EEGMFJGOIGA(JIIGOACEIKL));
				OJIIMKEPHOF(JIIGOACEIKL, null);
				PlayerController.GetPlayer(JIIGOACEIKL).gridController.DOEELMJIEFK(Vector2.op_Implicit(val2), MLBMAJMANCL(Vector2.op_Implicit(val2)) ? CommonReferences.MNFMOEKMJKN().selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 1);
			}
		}
	}

	public FertileSoil EKOLLJGHKOI(int JIIGOACEIKL)
	{
		return IGDHGFMMCAA;
	}

	public void OJIIMKEPHOF(int JIIGOACEIKL, FertileSoil JDLPIFGBLEL)
	{
		IGDHGFMMCAA = JDLPIFGBLEL;
	}

	public FertileSoil FKEJKPNGKPI(int JIIGOACEIKL)
	{
		return GLPMMEJFBNB;
	}

	public Vector2 FOFLMHDABPG(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return BKNEGILJAEL;
	}

	public Vector2 HEFGCKIPGNI(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return BKNEGILJAEL;
	}

	private void BANACGBOKAO(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(BANACGBOKAO));
	}

	public HoeInstance(Item MEMGMDOCBOJ)
		: base(MEMGMDOCBOJ)
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)
	//IL_0006: Unknown result type (might be due to invalid IL or missing references)


	public static bool KBFNCADGNLN(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) != (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth) && WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) != GroundType.Ground)
		{
			return false;
		}
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			if (WorldGrid.GJHHDIJOILG(WorldGrid.LOJBKLKMINM(IMOBLFMHKOD) + WorldGrid.allNeighbours[i].position))
			{
				return true;
			}
		}
		if (WorldGrid.OINMGKCIGEJ(IMOBLFMHKOD, null))
		{
			return false;
		}
		if (!WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD))
		{
			return false;
		}
		FertileSoil fertileSoil = HNIGNABLLMA(IMOBLFMHKOD);
		if ((Object)(object)fertileSoil != (Object)null && (Object)(object)fertileSoil.plantedCropSetter != (Object)null)
		{
			return false;
		}
		if (!WorldGrid.HENDJJEEOHE(IMOBLFMHKOD) && !WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			if (!WorldGrid.LKBLKCFOEPA(IMOBLFMHKOD) || WorldGrid.AGKGGAFFFGM(IMOBLFMHKOD) != ZoneType.WithoutZone)
			{
				return WorldGrid.OINMGKCIGEJ(IMOBLFMHKOD, null);
			}
			return false;
		}
		return true;
	}

	private void CIPIACNCIOM(FertileSoil IGDHGFMMCAA)
	{
		if ((Object)(object)IGDHGFMMCAA != (Object)null && Object.op_Implicit((Object)(object)IGDHGFMMCAA.plantedCropSetter))
		{
			IGDHGFMMCAA.plantedCropSetter.UnfocusCrop();
		}
	}

	private void MGNGDLIJBGI(int JIIGOACEIKL)
	{
		HNJEDEJNPNL(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(KBONDGFHOJF));
	}

	public Vector2 ECKAAGIKJAN(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return BKNEGILJAEL;
	}

	public Vector2 NMCCDMCAGOI(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return BKNEGILJAEL;
	}

	public void DKDNMJIPNPF(int JIIGOACEIKL, FertileSoil JDLPIFGBLEL)
	{
		IGDHGFMMCAA = JDLPIFGBLEL;
	}

	private void BBFJHDPCGOL(int JIIGOACEIKL)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (HCFJKBIIMIK(JIIGOACEIKL) == 0)
		{
			if ((Object)(object)POCOONAIBCB(JIIGOACEIKL) == (Object)null)
			{
				NOCJKKFCNKG(JIIGOACEIKL, 1);
			}
			else
			{
				LOMHCBDFPCM(JIIGOACEIKL, 2);
			}
		}
		BKNEGILJAEL = HGECFPCPOHN(JIIGOACEIKL);
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerActionsManager.instance.CGFNKFDPLPD(GFEBNOIMOGI(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		else
		{
			LHDHBJNFONK(JIIGOACEIKL, GFEBNOIMOGI(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().shovelSfx, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.DCAMKEOEKKP(JIIGOACEIKL, ControllersDatabaseAccessor.CHLOKEJCMFE(ControllersDatabase.VibrationMaterial.SickleSwing));
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(ADFFKNBCMEG));
	}

	public FertileSoil JKCACLDLAGF(int JIIGOACEIKL)
	{
		return GLPMMEJFBNB;
	}

	private void PHPJDLEAMIC(int JIIGOACEIKL)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (LCNPHFHDLOM(JIIGOACEIKL) == 0)
		{
			if ((Object)(object)POCOONAIBCB(JIIGOACEIKL) == (Object)null)
			{
				LOMHCBDFPCM(JIIGOACEIKL, 0);
			}
			else
			{
				KGGNKGFPOHF(JIIGOACEIKL, 4);
			}
		}
		BKNEGILJAEL = IMMLPHODPFK(JIIGOACEIKL);
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerActionsManager.instance.LGECGMNLJPP(IMMLPHODPFK(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		else
		{
			CNICMBOBMNH(JIIGOACEIKL, IMMLPHODPFK(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().shovelSfx, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.DCAMKEOEKKP(JIIGOACEIKL, ControllersDatabaseAccessor.EELGBLNBGPA(ControllersDatabase.VibrationMaterial.Spade));
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(NAGBOOJMJHK));
	}

	private void IBMGGECHKNB(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(IBMGGECHKNB));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = false;
		}
	}

	public static bool PNGEFPDJHGJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) != GroundType.Grass && WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) != (GroundType.Grass | GroundType.TilledEarth))
		{
			return false;
		}
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			if (WorldGrid.GJHHDIJOILG(WorldGrid.LOJBKLKMINM(IMOBLFMHKOD) + WorldGrid.allNeighbours[i].position))
			{
				return false;
			}
		}
		if (WorldGrid.OINMGKCIGEJ(IMOBLFMHKOD, null))
		{
			return true;
		}
		if (!WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD))
		{
			return true;
		}
		FertileSoil fertileSoil = OIKDPLLKNOK(IMOBLFMHKOD);
		if ((Object)(object)fertileSoil != (Object)null && (Object)(object)fertileSoil.plantedCropSetter != (Object)null)
		{
			return true;
		}
		if (!WorldGrid.HENDJJEEOHE(IMOBLFMHKOD) && !WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			if (!WorldGrid.LKBLKCFOEPA(IMOBLFMHKOD) || WorldGrid.AGKGGAFFFGM(IMOBLFMHKOD) != ZoneType.WithoutZone)
			{
				return WorldGrid.OINMGKCIGEJ(IMOBLFMHKOD, null);
			}
			return true;
		}
		return false;
	}

	private void LIFKOFECNGG(int JIIGOACEIKL, Vector2 CFAGHFFAODK, int DAKANNEEEPJ)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(MKJKBKAKMAB(JIIGOACEIKL)));
		for (int i = 1; i <= 1 && i <= DAKANNEEEPJ; i += 0)
		{
			Vector2 val2 = CFAGHFFAODK + 745f * (float)(i - 0) * val;
			FLKEOOOHFLE(JIIGOACEIKL, HNIGNABLLMA(Vector2.op_Implicit(val2)));
			if (Object.op_Implicit((Object)(object)EKOLLJGHKOI(JIIGOACEIKL)))
			{
				GLPMMEJFBNB = POCOONAIBCB(JIIGOACEIKL);
				if (Object.op_Implicit((Object)(object)CLKCHKKIPMP(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)IFDJBELGLOC(JIIGOACEIKL).plantedCropSetter))
				{
					CLKCHKKIPMP(JIIGOACEIKL).plantedCropSetter.JICFALBCNIC(JIIGOACEIKL);
				}
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.EnableEarthFocus(Vector2.op_Implicit(val2), PNGEFPDJHGJ(Vector2.op_Implicit(val2)) ? CommonReferences.MNFMOEKMJKN().selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 0);
			}
			else if (!WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(val2)))
			{
				LPOBAIHNEAA(EEGMFJGOIGA(JIIGOACEIKL));
				FLKEOOOHFLE(JIIGOACEIKL, null);
				PlayerController.GetPlayer(JIIGOACEIKL).gridController.DOEELMJIEFK(Vector2.op_Implicit(val2), GOCEDDNOMPN(Vector2.op_Implicit(val2)) ? CommonReferences.GGFJGHHHEJC.selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 1);
			}
		}
	}

	public FertileSoil HKNDJOJLLJJ(int JIIGOACEIKL)
	{
		return IGDHGFMMCAA;
	}

	private void LPOBAIHNEAA(FertileSoil IGDHGFMMCAA)
	{
		if ((Object)(object)IGDHGFMMCAA != (Object)null && Object.op_Implicit((Object)(object)IGDHGFMMCAA.plantedCropSetter))
		{
			IGDHGFMMCAA.plantedCropSetter.UnfocusCrop();
		}
	}

	private void DLIANKEODNO(FertileSoil IGDHGFMMCAA)
	{
		if ((Object)(object)IGDHGFMMCAA != (Object)null && Object.op_Implicit((Object)(object)IGDHGFMMCAA.plantedCropSetter))
		{
			IGDHGFMMCAA.plantedCropSetter.LNOIGEGEIGJ();
		}
	}

	private Vector3 FKEHAFKOOOM(int JIIGOACEIKL, bool LJOINCBGCBP)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.IKEEEAMKGML(GMMFDHOFHCC());
		if (!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || CursorManager.EAHELIGKMPL(JIIGOACEIKL))
		{
			Vector3 cursorWorldPosition = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
			if (EJJIBBFBPAI(JIIGOACEIKL, Vector2.op_Implicit(position), Vector2.op_Implicit(cursorWorldPosition)))
			{
				GridSquare gridSquare = PlayerController.GetPlayer(JIIGOACEIKL).gridController.CJNCMPJIJIA(cursorWorldPosition);
				if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
				{
					Vector3 val = (((Object)(object)gridSquare != (Object)null) ? ((Component)gridSquare.MCBDJMFJAKE(BLIKNGGCLID())).transform.position : cursorWorldPosition);
					JOACJBCCCKM(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(val + new Vector3(211f, 399f))));
					AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: true);
				}
				if ((Object)(object)gridSquare != (Object)null)
				{
					GAJPGNMNGFM(JIIGOACEIKL, gridSquare.direction);
				}
			}
			else if (LJOINCBGCBP || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).moving)
			{
				AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: false);
				Direction direction = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
				Vector3 val2 = Utils.NGFODNCHPHB(direction);
				HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + val2 * 590f));
				MAKCDKOGBHK(JIIGOACEIKL, Vector2.op_Implicit(val2 * 216f));
				OHMHPBIJJAL(JIIGOACEIKL, direction);
			}
		}
		else
		{
			GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: true);
			Direction direction2 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
			Vector3 val3 = Utils.NGFODNCHPHB(direction2);
			HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + val3 * 153f));
			MAKCDKOGBHK(JIIGOACEIKL, Vector2.op_Implicit(val3 * 333f));
			PMILEJPHHIJ(JIIGOACEIKL, direction2);
			HBEBAFHEMAP(JIIGOACEIKL, Vector2.op_Implicit(position), EEKKNPDOLLE(JIIGOACEIKL));
		}
		AGAJDKDCEHJ(JIIGOACEIKL, EEKKNPDOLLE(JIIGOACEIKL));
		return Vector2.op_Implicit(FOMOOMKHMPB(JIIGOACEIKL));
	}

	private void NOCEECPGELN(int JIIGOACEIKL)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (HCFJKBIIMIK(JIIGOACEIKL) == 0)
		{
			if ((Object)(object)CLKCHKKIPMP(JIIGOACEIKL) == (Object)null)
			{
				NOCJKKFCNKG(JIIGOACEIKL, 0);
			}
			else
			{
				KGGNKGFPOHF(JIIGOACEIKL, 2);
			}
		}
		BKNEGILJAEL = GFEBNOIMOGI(JIIGOACEIKL);
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerActionsManager.instance.CGCKAINEBAK(HGECFPCPOHN(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		else
		{
			LHDHBJNFONK(JIIGOACEIKL, HGECFPCPOHN(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().shovelSfx, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.ALOLJLMGJED(ControllersDatabase.VibrationMaterial.Spade));
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(IJLPPEILICJ));
	}

	public override bool HEKGALMDLIL(int JIIGOACEIKL)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)))));
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.SetGridInfo(base.KNIMLGOGFPA);
		HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL)))));
		PLNGELGLDLP(JIIGOACEIKL);
		ButtonsContext.SetPosition(JIIGOACEIKL, Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL) + Vector2.up * 0.3f));
		HKHGGNIFJKK(JIIGOACEIKL, LBBDJMCLEMG(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL))));
		if (Object.op_Implicit((Object)(object)POCOONAIBCB(JIIGOACEIKL)))
		{
			GLPMMEJFBNB = POCOONAIBCB(JIIGOACEIKL);
			if (Object.op_Implicit((Object)(object)POCOONAIBCB(JIIGOACEIKL)))
			{
				if (Object.op_Implicit((Object)(object)POCOONAIBCB(JIIGOACEIKL).plantedCropSetter))
				{
					BMHHBCGBJPK = "Remove";
					POCOONAIBCB(JIIGOACEIKL).plantedCropSetter.FocusCrop(JIIGOACEIKL);
				}
				else
				{
					BMHHBCGBJPK = "Clear";
				}
				if (!IMLECPKHMPI || FOFLMHDABPG(JIIGOACEIKL) != HGECFPCPOHN(JIIGOACEIKL))
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get(BMHHBCGBJPK));
					IMLECPKHMPI = true;
				}
			}
		}
		else if (!WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL))))
		{
			AIOLPHODIHG(EEGMFJGOIGA(JIIGOACEIKL));
			HKHGGNIFJKK(JIIGOACEIKL, null);
			if (!IMLECPKHMPI || FOFLMHDABPG(JIIGOACEIKL) != HGECFPCPOHN(JIIGOACEIKL))
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, string.IsNullOrEmpty(LocalisationSystem.Get("Till")) ? "Till" : LocalisationSystem.Get("Till"));
				IMLECPKHMPI = true;
			}
		}
		LBEDOABMKJB(JIIGOACEIKL, HGECFPCPOHN(JIIGOACEIKL), selectedRowCount);
		return true;
	}

	private void LBEDOABMKJB(int JIIGOACEIKL, Vector2 CFAGHFFAODK, int DAKANNEEEPJ)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL)));
		for (int i = 1; i <= 4 && i <= DAKANNEEEPJ; i++)
		{
			Vector2 val2 = CFAGHFFAODK + 0.5f * (float)(i - 1) * val;
			HKHGGNIFJKK(JIIGOACEIKL, LBBDJMCLEMG(Vector2.op_Implicit(val2)));
			if (Object.op_Implicit((Object)(object)POCOONAIBCB(JIIGOACEIKL)))
			{
				GLPMMEJFBNB = POCOONAIBCB(JIIGOACEIKL);
				if (Object.op_Implicit((Object)(object)POCOONAIBCB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)POCOONAIBCB(JIIGOACEIKL).plantedCropSetter))
				{
					POCOONAIBCB(JIIGOACEIKL).plantedCropSetter.FocusCrop(JIIGOACEIKL);
				}
				PlayerController.GetPlayer(JIIGOACEIKL).gridController.EnableEarthFocus(Vector2.op_Implicit(val2), GOCEDDNOMPN(Vector2.op_Implicit(val2)) ? CommonReferences.GGFJGHHHEJC.selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 1);
			}
			else if (!WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(val2)))
			{
				AIOLPHODIHG(EEGMFJGOIGA(JIIGOACEIKL));
				HKHGGNIFJKK(JIIGOACEIKL, null);
				PlayerController.GetPlayer(JIIGOACEIKL).gridController.EnableEarthFocus(Vector2.op_Implicit(val2), GOCEDDNOMPN(Vector2.op_Implicit(val2)) ? CommonReferences.GGFJGHHHEJC.selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 1);
			}
		}
	}

	public void LIFJEAKHDHB(int JIIGOACEIKL, FertileSoil JDLPIFGBLEL)
	{
		IGDHGFMMCAA = JDLPIFGBLEL;
	}

	private static FertileSoil KOOEOECLLLG(Vector3 DEACEMMGPHA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.MMIIIKBJKBA<FertileSoil>(DEACEMMGPHA);
	}

	private static void PPHBOFPFCBJ(int JIIGOACEIKL, Vector2 CFAGHFFAODK, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(FCGBJEIIMBC));
		GroundType groundType = GroundType.Grass;
		for (int i = 0; i <= 5 && i <= EEDMOGGJLHO; i += 0)
		{
			Vector2 val2 = CFAGHFFAODK + 312f * (float)(i - 1) * val;
			if (groundType == GroundType.None)
			{
				groundType = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(val2));
			}
			else if (groundType != WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(val2)))
			{
				continue;
			}
			if (GOCEDDNOMPN(Vector2.op_Implicit(val2)))
			{
				FCHPKLCGOFG(JIIGOACEIKL, val2);
			}
		}
	}

	public override void SecondActionEnd(int JIIGOACEIKL)
	{
	}

	private void OIIMOJOKKNI(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(GJPPPIOOPPP));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = false;
		}
	}

	private void NKNNAAPIFMC(FertileSoil IGDHGFMMCAA)
	{
		if ((Object)(object)IGDHGFMMCAA != (Object)null && Object.op_Implicit((Object)(object)IGDHGFMMCAA.plantedCropSetter))
		{
			IGDHGFMMCAA.plantedCropSetter.LNOIGEGEIGJ();
		}
	}

	private void NAGBOOJMJHK(int JIIGOACEIKL)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (HCFJKBIIMIK(JIIGOACEIKL) == 0)
		{
			if ((Object)(object)IFDJBELGLOC(JIIGOACEIKL) == (Object)null)
			{
				KGGNKGFPOHF(JIIGOACEIKL, 1);
			}
			else
			{
				NOCJKKFCNKG(JIIGOACEIKL, 3);
			}
		}
		BKNEGILJAEL = GFEBNOIMOGI(JIIGOACEIKL);
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerActionsManager.instance.StartHoeAction(DMJBEGINKAG(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		else
		{
			CNICMBOBMNH(JIIGOACEIKL, IMMLPHODPFK(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.shovelSfx, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		PlayerInputs.DCAMKEOEKKP(JIIGOACEIKL, ControllersDatabaseAccessor.GetVibrationProfile((ControllersDatabase.VibrationMaterial)8));
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(PHPJDLEAMIC));
	}

	private void PMKMDPEPNFK(FertileSoil IGDHGFMMCAA)
	{
		if ((Object)(object)IGDHGFMMCAA != (Object)null && Object.op_Implicit((Object)(object)IGDHGFMMCAA.plantedCropSetter))
		{
			IGDHGFMMCAA.plantedCropSetter.LNOIGEGEIGJ();
		}
	}

	private static FertileSoil LBBDJMCLEMG(Vector3 DEACEMMGPHA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.MMIIIKBJKBA<FertileSoil>(DEACEMMGPHA);
	}

	public void FLKEOOOHFLE(int JIIGOACEIKL, FertileSoil JDLPIFGBLEL)
	{
		IGDHGFMMCAA = JDLPIFGBLEL;
	}

	private void JADDPIJEILM(int JIIGOACEIKL)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (HCFJKBIIMIK(JIIGOACEIKL) == 0)
		{
			if ((Object)(object)CLKCHKKIPMP(JIIGOACEIKL) == (Object)null)
			{
				FOPJAIJDFKP(JIIGOACEIKL, 0);
			}
			else
			{
				FOPJAIJDFKP(JIIGOACEIKL, 1);
			}
		}
		BKNEGILJAEL = IMMLPHODPFK(JIIGOACEIKL);
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerActionsManager.instance.CGCKAINEBAK(HGECFPCPOHN(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		else
		{
			CNICMBOBMNH(JIIGOACEIKL, DMJBEGINKAG(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().shovelSfx, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.AFAAEDALPII(JIIGOACEIKL, ControllersDatabaseAccessor.HDANLMKNMHB((ControllersDatabase.VibrationMaterial)7));
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(IJLPPEILICJ));
	}

	private void AKFGKGAJJBE(FertileSoil IGDHGFMMCAA)
	{
		if ((Object)(object)IGDHGFMMCAA != (Object)null && Object.op_Implicit((Object)(object)IGDHGFMMCAA.plantedCropSetter))
		{
			IGDHGFMMCAA.plantedCropSetter.LNOIGEGEIGJ();
		}
	}

	public void OAHIIFEKDMI(int JIIGOACEIKL, FertileSoil JDLPIFGBLEL)
	{
		IGDHGFMMCAA = JDLPIFGBLEL;
	}

	public void AMOEHENGLDO(int JIIGOACEIKL, FertileSoil JDLPIFGBLEL)
	{
		IGDHGFMMCAA = JDLPIFGBLEL;
	}

	private static FertileSoil HNIGNABLLMA(Vector3 DEACEMMGPHA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.MMIIIKBJKBA<FertileSoil>(DEACEMMGPHA);
	}

	private void KGEBMFLHEEP(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(BANACGBOKAO));
	}

	public override void IOCKFAELDMD(int JIIGOACEIKL)
	{
		base.IOCKFAELDMD(JIIGOACEIKL);
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.DisableAllEarthFocus();
		AIOLPHODIHG(EEGMFJGOIGA(JIIGOACEIKL));
	}

	public FertileSoil POCOONAIBCB(int JIIGOACEIKL)
	{
		return IGDHGFMMCAA;
	}

	private void GJPPPIOOPPP(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(OIIMOJOKKNI));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = false;
		}
	}

	public override void LBMKLIDKHJD(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		IOCKFAELDMD(JIIGOACEIKL);
		IMLECPKHMPI = false;
	}

	private void ACKGNJJIKCG(int JIIGOACEIKL)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (LCNPHFHDLOM(JIIGOACEIKL) == 0)
		{
			if ((Object)(object)POCOONAIBCB(JIIGOACEIKL) == (Object)null)
			{
				FOPJAIJDFKP(JIIGOACEIKL, 1);
			}
			else
			{
				FOPJAIJDFKP(JIIGOACEIKL, 2);
			}
		}
		BKNEGILJAEL = IMMLPHODPFK(JIIGOACEIKL);
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerActionsManager.instance.CGCKAINEBAK(HGECFPCPOHN(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		else
		{
			LHDHBJNFONK(JIIGOACEIKL, HGECFPCPOHN(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().shovelSfx, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.HMLALIDFODI(ControllersDatabase.VibrationMaterial.Spade));
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(JADDPIJEILM));
	}

	public static void KDHBPMNGDIF(int JIIGOACEIKL, Vector2 DEACEMMGPHA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)LBBDJMCLEMG(Vector2.op_Implicit(DEACEMMGPHA)) == (Object)null)
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.TilledEarth, Location.Road, Season.Spring, CDPAMNIPPEC: true).GetComponent<FertileSoil>().PickUpPlaceables();
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.TillEarth);
		}
		else
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.Ground, Location.Road, Season.Spring, CDPAMNIPPEC: true);
		}
	}

	public FertileSoil CLKCHKKIPMP(int JIIGOACEIKL)
	{
		return IGDHGFMMCAA;
	}

	private void DELJDEHEMLL(int JIIGOACEIKL)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (HCFJKBIIMIK(JIIGOACEIKL) == 0)
		{
			if ((Object)(object)CLKCHKKIPMP(JIIGOACEIKL) == (Object)null)
			{
				JONHEOKBPIC(JIIGOACEIKL, 0);
			}
			else
			{
				KGGNKGFPOHF(JIIGOACEIKL, 7);
			}
		}
		BKNEGILJAEL = GFEBNOIMOGI(JIIGOACEIKL);
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerActionsManager.instance.HIINMIKACMH(HGECFPCPOHN(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		else
		{
			PPHBOFPFCBJ(JIIGOACEIKL, GFEBNOIMOGI(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.shovelSfx, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.DCAMKEOEKKP(JIIGOACEIKL, ControllersDatabaseAccessor.IHLIANLOGMB((ControllersDatabase.VibrationMaterial)6));
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(ACKGNJJIKCG));
	}

	public HoeInstance(HoeInstance ABINBKNEHLI)
		: base(ABINBKNEHLI)
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)
	//IL_0006: Unknown result type (might be due to invalid IL or missing references)


	public Vector2 EGCOPOKCPBG(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return BKNEGILJAEL;
	}

	private void AIOLPHODIHG(FertileSoil IGDHGFMMCAA)
	{
		if ((Object)(object)IGDHGFMMCAA != (Object)null && Object.op_Implicit((Object)(object)IGDHGFMMCAA.plantedCropSetter))
		{
			IGDHGFMMCAA.plantedCropSetter.UnfocusCrop();
		}
	}

	private void IJLPPEILICJ(int JIIGOACEIKL)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (HCFJKBIIMIK(JIIGOACEIKL) == 0)
		{
			if ((Object)(object)IFDJBELGLOC(JIIGOACEIKL) == (Object)null)
			{
				KGGNKGFPOHF(JIIGOACEIKL, 0);
			}
			else
			{
				LOMHCBDFPCM(JIIGOACEIKL, 8);
			}
		}
		BKNEGILJAEL = GFEBNOIMOGI(JIIGOACEIKL);
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerActionsManager.instance.CGCKAINEBAK(DMJBEGINKAG(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		else
		{
			LHDHBJNFONK(JIIGOACEIKL, DMJBEGINKAG(JIIGOACEIKL), PKKABPMIAKB, selectedRowCount);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().shovelSfx, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		PlayerInputs.DCAMKEOEKKP(JIIGOACEIKL, ControllersDatabaseAccessor.JNFNCAMOIIA((ControllersDatabase.VibrationMaterial)8));
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(NOCEECPGELN));
	}

	public static bool MLBMAJMANCL(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) != (GroundType.Ground | GroundType.TilledEarth) && WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) != (GroundType.Grass | GroundType.TilledEarth))
		{
			return true;
		}
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			if (WorldGrid.GJHHDIJOILG(WorldGrid.LOJBKLKMINM(IMOBLFMHKOD) + WorldGrid.allNeighbours[i].position, JGDOHPCLJPM: true))
			{
				return true;
			}
		}
		if (WorldGrid.OINMGKCIGEJ(IMOBLFMHKOD, null))
		{
			return true;
		}
		if (!WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD, GCDEDGFDKBL: false))
		{
			return true;
		}
		FertileSoil fertileSoil = HNIGNABLLMA(IMOBLFMHKOD);
		if ((Object)(object)fertileSoil != (Object)null && (Object)(object)fertileSoil.plantedCropSetter != (Object)null)
		{
			return true;
		}
		if (!WorldGrid.HENDJJEEOHE(IMOBLFMHKOD) && !WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			if (!WorldGrid.LKBLKCFOEPA(IMOBLFMHKOD) || WorldGrid.AGKGGAFFFGM(IMOBLFMHKOD) != 0)
			{
				return WorldGrid.OINMGKCIGEJ(IMOBLFMHKOD, null);
			}
			return true;
		}
		return true;
	}

	private Vector3 GJBLDNCKKLL(int JIIGOACEIKL, bool LJOINCBGCBP)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.GFGKONENIOD(GMMFDHOFHCC());
		if (!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || CursorManager.EAHELIGKMPL(JIIGOACEIKL))
		{
			Vector3 cursorWorldPosition = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition();
			if (EJJIBBFBPAI(JIIGOACEIKL, Vector2.op_Implicit(position), Vector2.op_Implicit(cursorWorldPosition)))
			{
				GridSquare gridSquare = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.OLFHBJLBLMH(cursorWorldPosition);
				if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
				{
					Vector3 val = (((Object)(object)gridSquare != (Object)null) ? ((Component)gridSquare.AOIBPBJPCIM(LPNELFNCDMC())).transform.position : cursorWorldPosition);
					ODLENFDNCND(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(val + new Vector3(1533f, 436f))));
					AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: false);
				}
				if ((Object)(object)gridSquare != (Object)null)
				{
					GAJPGNMNGFM(JIIGOACEIKL, gridSquare.direction);
				}
			}
			else if (LJOINCBGCBP || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).moving)
			{
				GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
				Direction direction = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
				Vector3 val2 = Utils.NGFODNCHPHB(direction);
				HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + val2 * 1294f));
				OMNPNNPEEFL(JIIGOACEIKL, Vector2.op_Implicit(val2 * 1795f));
				PMILEJPHHIJ(JIIGOACEIKL, direction);
			}
		}
		else
		{
			AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: true);
			Direction direction2 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
			Vector3 val3 = Utils.NGFODNCHPHB(direction2);
			IPDFPHOCKBE(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + val3 * 1892f));
			GBPBIOAKLHI(JIIGOACEIKL, Vector2.op_Implicit(val3 * 1113f));
			GAJPGNMNGFM(JIIGOACEIKL, direction2);
			BFCJLLFCCNM(JIIGOACEIKL, Vector2.op_Implicit(position), INGEAJAMBGM(JIIGOACEIKL));
		}
		LFDCIMLCBKN(JIIGOACEIKL, EEKKNPDOLLE(JIIGOACEIKL));
		return Vector2.op_Implicit(MGJICJHGOHC(JIIGOACEIKL));
	}

	private void JLLOCFNOFLD(int JIIGOACEIKL)
	{
		PGBKOLMPPHF(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)OMAPDOLLKGA());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(MGNGDLIJBGI));
	}

	public static void BNODBAKKIBH(Vector2 DEACEMMGPHA, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		CNICMBOBMNH(1, DEACEMMGPHA, FCGBJEIIMBC, EEDMOGGJLHO);
	}

	private static FertileSoil OIKDPLLKNOK(Vector3 DEACEMMGPHA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.MMIIIKBJKBA<FertileSoil>(DEACEMMGPHA);
	}

	public static void LNPGAIAFINC(Vector2 DEACEMMGPHA, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		PPHBOFPFCBJ(0, DEACEMMGPHA, FCGBJEIIMBC, EEDMOGGJLHO);
	}

	public FertileSoil DGMKMJMNAON(int JIIGOACEIKL)
	{
		return GLPMMEJFBNB;
	}

	public FertileSoil LNMOJPLELJC(int JIIGOACEIKL)
	{
		return GLPMMEJFBNB;
	}

	public FertileSoil IFDJBELGLOC(int JIIGOACEIKL)
	{
		return IGDHGFMMCAA;
	}

	private void BKDCCNFAJLJ(FertileSoil IGDHGFMMCAA)
	{
		if ((Object)(object)IGDHGFMMCAA != (Object)null && Object.op_Implicit((Object)(object)IGDHGFMMCAA.plantedCropSetter))
		{
			IGDHGFMMCAA.plantedCropSetter.HKHFKAEEONM();
		}
	}

	public override void NFHHKCIBLDC(int JIIGOACEIKL)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(JHDFFNJCHFN(JIIGOACEIKL, LJOINCBGCBP: true)));
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.SetGridInfo(base.KNIMLGOGFPA);
	}
}
