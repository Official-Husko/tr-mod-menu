using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Sprout Seed")]
public class SproutSeed : Seed
{
	private Placeable treeSproutAux;

	private Placeable treeSprout;

	private Placeable treeSprout2;

	private Placeable OIOCMIHMFDB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	private void AHDAAKDCKNA(int JIIGOACEIKL)
	{
		if ((Object)(object)HJODGHMHBJJ(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = null;
			Utils.BLPDAEHPOBA(((Component)OBCFNOPLIEH(JIIGOACEIKL)).gameObject);
		}
	}

	private void ELANFGFOACD(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 0)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private Placeable BCIFLHPPMHG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	public override void AONJJGAIDBG(int JIIGOACEIKL)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		treeSproutAux = OBCFNOPLIEH(JIIGOACEIKL);
		if ((Object)(object)treeSproutAux == (Object)null)
		{
			treeSproutAux = PDGGADHDEAM(JIIGOACEIKL);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SetMovingObject(treeSproutAux);
			}
		}
		if (!((Component)treeSproutAux.itemSpace).gameObject.activeSelf)
		{
			((Component)treeSproutAux.itemSpace).gameObject.SetActive(true);
		}
		if (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
		{
			treeSproutAux.SetPosition(JIIGOACEIKL, JOOEMBNDCKF: false, OFGPEJIOLNJ: true);
		}
		else
		{
			treeSproutAux.SetPosition(JIIGOACEIKL, JOOEMBNDCKF: true, OFGPEJIOLNJ: true);
		}
		if (OnlineManager.PlayingOnline())
		{
			treeSproutAux.onlinePlaceable.UpdatePosition(Vector2.op_Implicit(((Component)treeSproutAux).transform.position));
		}
	}

	private void ONGPKKKCHNG(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 1)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private Placeable KCEAABOPNNP(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Placeable component = Object.Instantiate<GameObject>(crop.prefab, Vector2.op_Implicit(EFFHGGDIEPK(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
		((Component)component).GetComponent<CropSetter>().MFEDJIEKKHC(crop);
		MHLKOKIILKH(JIIGOACEIKL, component);
		SelectObject.GetPlayer(JIIGOACEIKL).MHJCMDHEDCO(this);
		if ((Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.setUp = false;
		}
		return component;
	}

	private void LPJNHEEDBCN(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 1)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private void FEMBFBBPKAG(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 1)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private Placeable EKGAEGMCNOG(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Placeable component = Object.Instantiate<GameObject>(crop.prefab, Vector2.op_Implicit(LCEMOJNMGGH(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
		((Component)component).GetComponent<CropSetter>().INNLLPDAJJP(crop);
		ELANFGFOACD(JIIGOACEIKL, component);
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(this);
		if ((Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.setUp = true;
		}
		return component;
	}

	private Placeable CAICPIJHHHA(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Placeable component = Object.Instantiate<GameObject>(crop.prefab, Vector2.op_Implicit(PEKPAOKNLNI(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
		((Component)component).GetComponent<CropSetter>().DEAHAPFFPLM(crop);
		CGKAPILLJJF(JIIGOACEIKL, component);
		SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = this;
		if ((Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.setUp = true;
		}
		return component;
	}

	private Placeable OFNJGELPAFK(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Placeable component = Object.Instantiate<GameObject>(crop.prefab, Vector2.op_Implicit(LCEMOJNMGGH(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
		((Component)component).GetComponent<CropSetter>().MFEDJIEKKHC(crop);
		CGKAPILLJJF(JIIGOACEIKL, component);
		SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = this;
		if ((Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.setUp = false;
		}
		return component;
	}

	private void LENLCOOBCKD(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 1)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private void KJNEBCNHNPE(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 1)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private void PPPJAACLAMH(int JIIGOACEIKL)
	{
		if ((Object)(object)AMFEKKBANJO(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = null;
			Utils.BLPDAEHPOBA(((Component)LCMDPNBHHAN(JIIGOACEIKL)).gameObject);
		}
	}

	public override bool NBFBPMNMBJG(int JIIGOACEIKL)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		if (ConstructionManager.NEOJLHDFFMJ || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (Utils.DLOMIGFOOPD(JIIGOACEIKL) && (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))) || (Object)(object)MainUI.openedWindow != (Object)null)
		{
			DJCDKPBOKLD(JIIGOACEIKL);
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
		{
			return false;
		}
		if (NewTutorialManager.SproutsBlocked(JIIGOACEIKL))
		{
			return false;
		}
		if (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 0.5f);
		AGAJDKDCEHJ(JIIGOACEIKL, inputPositionAux);
		if ((WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(inputPositionAux)) == GroundType.Grass || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(inputPositionAux)) == GroundType.Ground) && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(inputPositionAux)) != GroundType.TilledEarth)
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	private void NHEFPOGCJHF(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 1)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private Placeable HNBMCDNGFAA(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Placeable component = Object.Instantiate<GameObject>(crop.prefab, Vector2.op_Implicit(LCEMOJNMGGH(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
		((Component)component).GetComponent<CropSetter>().KDGILDLAPNI(crop);
		KJNEBCNHNPE(JIIGOACEIKL, component);
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).ELBNNJOALFG = this;
		if ((Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.setUp = false;
		}
		return component;
	}

	private Placeable AMFEKKBANJO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	public override bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (NBFBPMNMBJG(JIIGOACEIKL) && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && KLGOCJMGKFO && Object.op_Implicit((Object)(object)OBCFNOPLIEH(JIIGOACEIKL)) && OBCFNOPLIEH(JIIGOACEIKL).itemSpace.IsItemSpaceValid())
		{
			OBCFNOPLIEH(JIIGOACEIKL).itemSpace.Place(NMLKLAGDNPF: true);
			((Component)OBCFNOPLIEH(JIIGOACEIKL).itemSpace).gameObject.SetActive(false);
			Utils.FKKHJPEMNBG("plantedTrees", 1);
			KJNEBCNHNPE(JIIGOACEIKL, null);
			SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = null;
			ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedSlot().MEODNPFJDMH();
			CommonReferences.GGFJGHHHEJC.OnFirstFruitTreePlanted(1);
			return true;
		}
		return false;
	}

	private void IPBFMPCPFOD(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 1)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private void OGBFKLFELKL(int JIIGOACEIKL)
	{
		if ((Object)(object)AMFEKKBANJO(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).ELBNNJOALFG = null;
			Utils.BLPDAEHPOBA(((Component)LCMDPNBHHAN(JIIGOACEIKL)).gameObject);
		}
	}

	private Placeable KOMCOHCHFLH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	public override void LBMKLIDKHJD(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		DJCDKPBOKLD(JIIGOACEIKL);
	}

	private Placeable KINFDCKFPPE(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Placeable component = Object.Instantiate<GameObject>(crop.prefab, Vector2.op_Implicit(HMAHIKDFLCL(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
		((Component)component).GetComponent<CropSetter>().DEAHAPFFPLM(crop);
		LENLCOOBCKD(JIIGOACEIKL, component);
		SelectObject.GetPlayer(JIIGOACEIKL).MHJCMDHEDCO(this);
		if ((Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.setUp = false;
		}
		return component;
	}

	private Placeable AFOPAJOBMCE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	private void HOJHEKJKIJF(int JIIGOACEIKL)
	{
		if ((Object)(object)LCMDPNBHHAN(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).MHJCMDHEDCO(null);
			Utils.BLPDAEHPOBA(((Component)HJODGHMHBJJ(JIIGOACEIKL)).gameObject);
		}
	}

	private void HBPFKNNCOPG(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 1)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private void GBDBPAJFADH(int JIIGOACEIKL)
	{
		if ((Object)(object)LCMDPNBHHAN(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(null);
			Utils.BLPDAEHPOBA(((Component)BCIFLHPPMHG(JIIGOACEIKL)).gameObject);
		}
	}

	private Placeable LEOAGDGOBIN(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Placeable component = Object.Instantiate<GameObject>(crop.prefab, Vector2.op_Implicit(EFFHGGDIEPK(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
		((Component)component).GetComponent<CropSetter>().MGOBBKFAEPP(crop);
		FEMBFBBPKAG(JIIGOACEIKL, component);
		SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = this;
		if ((Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.setUp = true;
		}
		return component;
	}

	private void MHLKOKIILKH(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 1)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private Placeable KEHFNBIMDOI(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Placeable component = Object.Instantiate<GameObject>(crop.prefab, Vector2.op_Implicit(HMAHIKDFLCL(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
		((Component)component).GetComponent<CropSetter>().MGOBBKFAEPP(crop);
		IKOMJCINOEP(JIIGOACEIKL, component);
		SelectObject.GetPlayer(JIIGOACEIKL).MHJCMDHEDCO(this);
		if ((Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.setUp = true;
		}
		return component;
	}

	private void JLLFEFOJDMH(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 0)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private void PAODBHDIHEK(int JIIGOACEIKL)
	{
		if ((Object)(object)AMFEKKBANJO(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(null);
			Utils.BLPDAEHPOBA(((Component)HJODGHMHBJJ(JIIGOACEIKL)).gameObject);
		}
	}

	public override bool HEKGALMDLIL(int JIIGOACEIKL)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.SetPosition(JIIGOACEIKL, OBCFNOPLIEH(JIIGOACEIKL).inputByProximity.actionButtonsPoint.position);
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Plant"));
		return true;
	}

	private void IKOMJCINOEP(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 0)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private Placeable PDGGADHDEAM(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Placeable component = Object.Instantiate<GameObject>(crop.prefab, Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
		((Component)component).GetComponent<CropSetter>().FJJCOJGJCLF = crop;
		KJNEBCNHNPE(JIIGOACEIKL, component);
		SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = this;
		if ((Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.setUp = false;
		}
		return component;
	}

	private void AEIJDMBGOFF(int JIIGOACEIKL)
	{
		if ((Object)(object)BCIFLHPPMHG(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(null);
			Utils.BLPDAEHPOBA(((Component)LCMDPNBHHAN(JIIGOACEIKL)).gameObject);
		}
	}

	private Placeable LCMDPNBHHAN(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	private Placeable OBCFNOPLIEH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	private Placeable PBPPJHCMDAB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	private Placeable KJMCDPEGFHM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	private Placeable EKNCNKMJLKI(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Placeable component = Object.Instantiate<GameObject>(crop.prefab, Vector2.op_Implicit(LCEMOJNMGGH(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
		((Component)component).GetComponent<CropSetter>().INNLLPDAJJP(crop);
		LENLCOOBCKD(JIIGOACEIKL, component);
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).ELBNNJOALFG = this;
		if ((Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.setUp = true;
		}
		return component;
	}

	private Placeable BAHPNHNFCCC(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Placeable component = Object.Instantiate<GameObject>(crop.prefab, Vector2.op_Implicit(HMAHIKDFLCL(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
		((Component)component).GetComponent<CropSetter>().DEAHAPFFPLM(crop);
		IKOMJCINOEP(JIIGOACEIKL, component);
		SelectObject.GetPlayer(JIIGOACEIKL).MHJCMDHEDCO(this);
		if ((Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.setUp = false;
		}
		return component;
	}

	private Placeable HJODGHMHBJJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	private void CGKAPILLJJF(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 0)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private void DJCDKPBOKLD(int JIIGOACEIKL)
	{
		if ((Object)(object)OBCFNOPLIEH(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = null;
			Utils.BLPDAEHPOBA(((Component)OBCFNOPLIEH(JIIGOACEIKL)).gameObject);
		}
	}

	private Placeable GHPKOFNLPPG(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Placeable component = Object.Instantiate<GameObject>(crop.prefab, Vector2.op_Implicit(EFFHGGDIEPK(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
		((Component)component).GetComponent<CropSetter>().MGOBBKFAEPP(crop);
		CGKAPILLJJF(JIIGOACEIKL, component);
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).ELBNNJOALFG = this;
		if ((Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.setUp = false;
		}
		return component;
	}

	private Placeable NBEIHKLIFAO(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Placeable component = Object.Instantiate<GameObject>(crop.prefab, Vector2.op_Implicit(EFFHGGDIEPK(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
		((Component)component).GetComponent<CropSetter>().KDGILDLAPNI(crop);
		IKOMJCINOEP(JIIGOACEIKL, component);
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(this);
		if ((Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.setUp = false;
		}
		return component;
	}

	private void CFJHGMLAPEA(int JIIGOACEIKL, Placeable DDJACALAKHO)
	{
		if (JIIGOACEIKL == 0)
		{
			treeSprout = DDJACALAKHO;
		}
		else
		{
			treeSprout2 = DDJACALAKHO;
		}
	}

	private void CDDNOHFOEPC(int JIIGOACEIKL)
	{
		if ((Object)(object)OIOCMIHMFDB(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = null;
			Utils.BLPDAEHPOBA(((Component)AFOPAJOBMCE(JIIGOACEIKL)).gameObject);
		}
	}
}
