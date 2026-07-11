using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Tree Sprout")]
public class SproutTree : Tool, IActionable, ITool
{
	private Placeable treeSproutAux;

	private Placeable treeSprout;

	private Placeable treeSprout2;

	private void HFDEKAEHEMJ(int JIIGOACEIKL, Placeable DDJACALAKHO)
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

	public void CDGBECJBMIE(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		PAODBHDIHEK(JIIGOACEIKL);
	}

	public void KNIDDGGDILE(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		LEFEKLOJOFI(JIIGOACEIKL);
	}

	public bool NIFILJFPFCM(int JIIGOACEIKL)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (Utils.DLOMIGFOOPD(JIIGOACEIKL) && (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.EAHELIGKMPL(JIIGOACEIKL))) || (Object)(object)MainUI.openedWindow != (Object)null)
		{
			PAODBHDIHEK(JIIGOACEIKL);
			return true;
		}
		if (DecorationMode.KKJABELKCNM(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return true;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Tavern)
		{
			return false;
		}
		if (CursorManager.GetPlayer(JIIGOACEIKL).LALPELGNIJB())
		{
			return !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).IsTavernLocation();
		}
		GPAFLICPBHE(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1864f));
		JCNLMHNEKCF(JIIGOACEIKL, NLGOOKPIOCN(JIIGOACEIKL));
		if (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(KJOFFEDOOLB(JIIGOACEIKL))) == GroundType.None || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(OGIPBMKEAGF(JIIGOACEIKL))) == (GroundType.Grass | GroundType.Ground) || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(NLGOOKPIOCN(JIIGOACEIKL))) == GroundType.Grass)
		{
			return WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(DJDNHOLIJCA(JIIGOACEIKL)));
		}
		return false;
	}

	public void FACBFEBPCPP(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		treeSproutAux = FAPECOBHLFG(JIIGOACEIKL);
		if ((Object)(object)treeSproutAux == (Object)null)
		{
			treeSproutAux = Object.Instantiate<GameObject>(LLCLICBABLN(), Vector2.op_Implicit(HLODPPMBCPH(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
			KJNEBCNHNPE(JIIGOACEIKL, treeSproutAux);
			((Component)treeSproutAux).GetComponent<Tree>().GNAFHIPCGAA();
			SelectObject.GetPlayer(JIIGOACEIKL).MHJCMDHEDCO(this);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SetMovingObject(treeSproutAux);
			}
			if ((Object)(object)treeSproutAux.itemSpace != (Object)null)
			{
				treeSproutAux.itemSpace.setUp = false;
			}
		}
		if (!((Component)treeSproutAux.itemSpace).gameObject.activeSelf)
		{
			((Component)treeSproutAux.itemSpace).gameObject.SetActive(true);
		}
		if (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
		{
			treeSproutAux.SetPosition(JIIGOACEIKL, JOOEMBNDCKF: false, OFGPEJIOLNJ: false);
		}
		else
		{
			treeSproutAux.CHMGNKHKJBN(JIIGOACEIKL, JOOEMBNDCKF: true, OFGPEJIOLNJ: true, CDPAMNIPPEC: true);
		}
		treeSproutAux.itemSpace.OOOEEICDIEI(treeSproutAux.itemSpace.KHNJOFCOIFE(BIOKGEFFNAA: true) && Tree.AreValidAllItemSpaces(treeSproutAux.itemSpace, ((Component)treeSproutAux.itemSpace).transform.position, 1) && (Object)(object)TreeGenerator.CNOCNKBGAJM(((Component)treeSproutAux).transform.position) != (Object)null);
		if (OnlineManager.PlayingOnline())
		{
			treeSproutAux.onlinePlaceable.LAGMJDLPDEJ(Vector2.op_Implicit(((Component)treeSproutAux).transform.position));
		}
	}

	public bool DCDJJEENDOG()
	{
		return true;
	}

	private void PJIBBLDNHFN(int JIIGOACEIKL)
	{
		if ((Object)(object)CLILBMBJGGM(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).MHJCMDHEDCO(null);
			Utils.BLPDAEHPOBA(((Component)HJKIBJLBHDG(JIIGOACEIKL)).gameObject);
		}
	}

	public void MCPLNBOLOBJ(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		GJLGBOIBDLI(JIIGOACEIKL);
	}

	public void PIAMAIHLMPI(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		LEFEKLOJOFI(JIIGOACEIKL);
	}

	public bool LNMCCKDLCMP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (CPHBLGFGLPG(JIIGOACEIKL) && PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF() && KLGOCJMGKFO && Object.op_Implicit((Object)(object)DNOLKGGPHLJ(JIIGOACEIKL)) && CLILBMBJGGM(JIIGOACEIKL).itemSpace.IsItemSpaceValid(BIOKGEFFNAA: true))
		{
			if (!Tree.KKFCMBNLMLK(DNOLKGGPHLJ(JIIGOACEIKL).itemSpace, ((Component)DIDEBFDMNOB(JIIGOACEIKL).itemSpace).transform.position, 1))
			{
				return true;
			}
			TreeGenerator treeGenerator = TreeGenerator.ALDNLGAPMAE(((Component)DIDEBFDMNOB(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGenerator))
			{
				HJODGHMHBJJ(JIIGOACEIKL).itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				((Component)KDFBJPGMCCG(JIIGOACEIKL).itemSpace).gameObject.SetActive(true);
				Utils.FKKHJPEMNBG("itemBar", 0);
				Tree component = ((Component)CLILBMBJGGM(JIIGOACEIKL)).GetComponent<Tree>();
				treeGenerator.JMBCNPHAAAO(component, NIIBLHMEGNJ: false);
				SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(null);
				KJNEBCNHNPE(JIIGOACEIKL, null);
				ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedSlot().DJFOMFDOOKM();
				return true;
			}
		}
		return true;
	}

	public void FIMCECDNIPI(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		PJIBBLDNHFN(JIIGOACEIKL);
	}

	public bool FMHMMKFGENK(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, treeSproutAux.inputByProximity.actionButtonsPoint.position);
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get(""));
		return false;
	}

	public bool PDIMHCENKMH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (NBFBPMNMBJG(JIIGOACEIKL) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && KLGOCJMGKFO && Object.op_Implicit((Object)(object)BCIFLHPPMHG(JIIGOACEIKL)) && FAPECOBHLFG(JIIGOACEIKL).itemSpace.IsItemSpaceValid(BIOKGEFFNAA: false, ELKPPAAMMIM: false))
		{
			if (!Tree.KKFCMBNLMLK(GJNPDDBBPFE(JIIGOACEIKL).itemSpace, ((Component)KDFBJPGMCCG(JIIGOACEIKL).itemSpace).transform.position, 1))
			{
				return true;
			}
			TreeGenerator treeGenerator = TreeGenerator.GADFLGJLCEG(((Component)OBCFNOPLIEH(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGenerator))
			{
				KMICMALEFKD(JIIGOACEIKL).itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				((Component)DNOLKGGPHLJ(JIIGOACEIKL).itemSpace).gameObject.SetActive(false);
				Utils.FKKHJPEMNBG(" : 00", 0);
				Tree component = ((Component)GJNPDDBBPFE(JIIGOACEIKL)).GetComponent<Tree>();
				treeGenerator.PBILMBDFPIB(component);
				SelectObject.BNMEANGDMIP(JIIGOACEIKL).ELBNNJOALFG = null;
				GLKCCGFFEIO(JIIGOACEIKL, null);
				ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NBEINBNMKJG().DJFOMFDOOKM(CDPAMNIPPEC: false);
				return false;
			}
		}
		return true;
	}

	private void KOIGJBGIGIE(int JIIGOACEIKL)
	{
		if ((Object)(object)OBCFNOPLIEH(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(null);
			Utils.BLPDAEHPOBA(((Component)GJOMJHOJAFE(JIIGOACEIKL)).gameObject);
		}
	}

	private void AEIJDMBGOFF(int JIIGOACEIKL)
	{
		if ((Object)(object)OBCFNOPLIEH(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = null;
			Utils.BLPDAEHPOBA(((Component)GJNPDDBBPFE(JIIGOACEIKL)).gameObject);
		}
	}

	public void NJBFLBOAHJL(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		GJLGBOIBDLI(JIIGOACEIKL);
	}

	public void AACCAIGIKGK(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		PBABIBNPPDP(JIIGOACEIKL);
	}

	public bool HEKGALMDLIL(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.SetPosition(JIIGOACEIKL, treeSproutAux.inputByProximity.actionButtonsPoint.position);
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Plant"));
		return true;
	}

	private Placeable BCIFLHPPMHG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	public void GPEFPDIIPBB(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		AEIJDMBGOFF(JIIGOACEIKL);
	}

	public bool NBFBPMNMBJG(int JIIGOACEIKL)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (Utils.DLOMIGFOOPD(JIIGOACEIKL) && (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))) || (Object)(object)MainUI.openedWindow != (Object)null)
		{
			DJCDKPBOKLD(JIIGOACEIKL);
			return false;
		}
		if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
		{
			return false;
		}
		if (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
		{
			return !PlayerController.GetPlayer(JIIGOACEIKL).IsTavernLocation();
		}
		HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 0.5f));
		AGAJDKDCEHJ(JIIGOACEIKL, EEKKNPDOLLE(JIIGOACEIKL));
		if (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) == GroundType.Grass || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) == GroundType.Ground || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) == GroundType.TilledEarth)
		{
			return WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL)));
		}
		return false;
	}

	public void HIOAPGLOAIK(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		DJCDKPBOKLD(JIIGOACEIKL);
	}

	private void IPOHNAILKBK(int JIIGOACEIKL)
	{
		if ((Object)(object)GJOMJHOJAFE(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(null);
			Utils.BLPDAEHPOBA(((Component)OBCFNOPLIEH(JIIGOACEIKL)).gameObject);
		}
	}

	private void LEFEKLOJOFI(int JIIGOACEIKL)
	{
		if ((Object)(object)OBCFNOPLIEH(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).ELBNNJOALFG = null;
			Utils.BLPDAEHPOBA(((Component)HJODGHMHBJJ(JIIGOACEIKL)).gameObject);
		}
	}

	public void AONJJGAIDBG(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		treeSproutAux = OBCFNOPLIEH(JIIGOACEIKL);
		if ((Object)(object)treeSproutAux == (Object)null)
		{
			treeSproutAux = Object.Instantiate<GameObject>(PHGCBMPGGLI(), Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
			KJNEBCNHNPE(JIIGOACEIKL, treeSproutAux);
			((Component)treeSproutAux).GetComponent<Tree>().SetUpPlayerSleepFunction();
			SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = this;
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SetMovingObject(treeSproutAux);
			}
			if ((Object)(object)treeSproutAux.itemSpace != (Object)null)
			{
				treeSproutAux.itemSpace.setUp = false;
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
		treeSproutAux.itemSpace.SetAvailable(treeSproutAux.itemSpace.IsItemSpaceValid() && Tree.AreValidAllItemSpaces(treeSproutAux.itemSpace, ((Component)treeSproutAux.itemSpace).transform.position, 1) && (Object)(object)TreeGenerator.GetTreeGeneratorInArea(((Component)treeSproutAux).transform.position) != (Object)null);
		if (OnlineManager.PlayingOnline())
		{
			treeSproutAux.onlinePlaceable.UpdatePosition(Vector2.op_Implicit(((Component)treeSproutAux).transform.position));
		}
	}

	public bool DLKLEHNNEPD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if ((!MPEDAKDMMAE(JIIGOACEIKL) || !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE) && KLGOCJMGKFO && Object.op_Implicit((Object)(object)FAPECOBHLFG(JIIGOACEIKL)) && HJKIBJLBHDG(JIIGOACEIKL).itemSpace.IsItemSpaceValid(BIOKGEFFNAA: true))
		{
			if (!Tree.AreValidAllItemSpaces(CLILBMBJGGM(JIIGOACEIKL).itemSpace, ((Component)OBCFNOPLIEH(JIIGOACEIKL).itemSpace).transform.position, 1))
			{
				return false;
			}
			TreeGenerator treeGenerator = TreeGenerator.KLLFCGOFMCI(((Component)OBCFNOPLIEH(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGenerator))
			{
				DIDEBFDMNOB(JIIGOACEIKL).itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				((Component)DIDEBFDMNOB(JIIGOACEIKL).itemSpace).gameObject.SetActive(false);
				Utils.FKKHJPEMNBG("IngameInvite", 0);
				Tree component = ((Component)KMICMALEFKD(JIIGOACEIKL)).GetComponent<Tree>();
				treeGenerator.PBILMBDFPIB(component);
				SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(null);
				GLKCCGFFEIO(JIIGOACEIKL, null);
				ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedSlot().CIDBFIAJIBG();
				return false;
			}
		}
		return false;
	}

	public bool GMBJJJLKALF()
	{
		return false;
	}

	public bool GDCJNEMPOID(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, treeSproutAux.inputByProximity.actionButtonsPoint.position);
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(" "));
		return false;
	}

	public void DACFOELCJFM(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		treeSproutAux = FAPECOBHLFG(JIIGOACEIKL);
		if ((Object)(object)treeSproutAux == (Object)null)
		{
			treeSproutAux = Object.Instantiate<GameObject>(LLCLICBABLN(), Vector2.op_Implicit(BLCEHNCLHHF(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
			GLKCCGFFEIO(JIIGOACEIKL, treeSproutAux);
			((Component)treeSproutAux).GetComponent<Tree>().SetUpPlayerSleepFunction();
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(this);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SetMovingObject(treeSproutAux);
			}
			if ((Object)(object)treeSproutAux.itemSpace != (Object)null)
			{
				treeSproutAux.itemSpace.setUp = false;
			}
		}
		if (!((Component)treeSproutAux.itemSpace).gameObject.activeSelf)
		{
			((Component)treeSproutAux.itemSpace).gameObject.SetActive(true);
		}
		if (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).IHMADDCNKAM())
		{
			treeSproutAux.CHMGNKHKJBN(JIIGOACEIKL, JOOEMBNDCKF: true, OFGPEJIOLNJ: true, CDPAMNIPPEC: true);
		}
		else
		{
			treeSproutAux.SetPosition(JIIGOACEIKL, JOOEMBNDCKF: true, OFGPEJIOLNJ: false);
		}
		treeSproutAux.itemSpace.SetAvailable(!treeSproutAux.itemSpace.LJCPGDDLJKL(BIOKGEFFNAA: false, ELKPPAAMMIM: false) || !Tree.OJMPEGIKBMJ(treeSproutAux.itemSpace, ((Component)treeSproutAux.itemSpace).transform.position, 1) || (Object)(object)TreeGenerator.FMKHIBDEDBE(((Component)treeSproutAux).transform.position) != (Object)null);
		if (OnlineManager.PlayingOnline())
		{
			treeSproutAux.onlinePlaceable.IHIFOCJOKLL(Vector2.op_Implicit(((Component)treeSproutAux).transform.position));
		}
	}

	public bool DBGGFOCJNOI()
	{
		return true;
	}

	public bool AHIDLEJJAGC()
	{
		return false;
	}

	private void JNPOLMKDOKB(int JIIGOACEIKL)
	{
		if ((Object)(object)BCIFLHPPMHG(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(null);
			Utils.BLPDAEHPOBA(((Component)CLILBMBJGGM(JIIGOACEIKL)).gameObject);
		}
	}

	public bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (NBFBPMNMBJG(JIIGOACEIKL) && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && KLGOCJMGKFO && Object.op_Implicit((Object)(object)OBCFNOPLIEH(JIIGOACEIKL)) && OBCFNOPLIEH(JIIGOACEIKL).itemSpace.IsItemSpaceValid())
		{
			if (!Tree.AreValidAllItemSpaces(OBCFNOPLIEH(JIIGOACEIKL).itemSpace, ((Component)OBCFNOPLIEH(JIIGOACEIKL).itemSpace).transform.position, 1))
			{
				return false;
			}
			TreeGenerator treeGeneratorInArea = TreeGenerator.GetTreeGeneratorInArea(((Component)OBCFNOPLIEH(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGeneratorInArea))
			{
				OBCFNOPLIEH(JIIGOACEIKL).itemSpace.Place(NMLKLAGDNPF: true);
				((Component)OBCFNOPLIEH(JIIGOACEIKL).itemSpace).gameObject.SetActive(false);
				Utils.FKKHJPEMNBG("plantedTrees", 1);
				Tree component = ((Component)OBCFNOPLIEH(JIIGOACEIKL)).GetComponent<Tree>();
				treeGeneratorInArea.AddForestElement(component);
				SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = null;
				KJNEBCNHNPE(JIIGOACEIKL, null);
				ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedSlot().MEODNPFJDMH();
				return true;
			}
		}
		return false;
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

	public bool FLDILBGJIFL(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, treeSproutAux.inputByProximity.actionButtonsPoint.position);
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("- "));
		return false;
	}

	public void AACBDKLCIAH(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		PAODBHDIHEK(JIIGOACEIKL);
	}

	public bool EHHCPOCLAJA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (CPHBLGFGLPG(JIIGOACEIKL) && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF() && KLGOCJMGKFO && Object.op_Implicit((Object)(object)DNOLKGGPHLJ(JIIGOACEIKL)) && KDFBJPGMCCG(JIIGOACEIKL).itemSpace.IsItemSpaceValid(BIOKGEFFNAA: false, ELKPPAAMMIM: false))
		{
			if (!Tree.KKFCMBNLMLK(OBCFNOPLIEH(JIIGOACEIKL).itemSpace, ((Component)CLILBMBJGGM(JIIGOACEIKL).itemSpace).transform.position, 1))
			{
				return true;
			}
			TreeGenerator treeGenerator = TreeGenerator.ALDNLGAPMAE(((Component)HJODGHMHBJJ(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGenerator))
			{
				CLILBMBJGGM(JIIGOACEIKL).itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				((Component)HJKIBJLBHDG(JIIGOACEIKL).itemSpace).gameObject.SetActive(true);
				Utils.FKKHJPEMNBG("Items/item_description_1080", 1);
				Tree component = ((Component)HJODGHMHBJJ(JIIGOACEIKL)).GetComponent<Tree>();
				treeGenerator.PBILMBDFPIB(component, NIIBLHMEGNJ: false);
				SelectObject.GetPlayer(JIIGOACEIKL).MHJCMDHEDCO(null);
				OBGPCJHEPCO(JIIGOACEIKL, null);
				ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL).IKKLGIKJNNG().CIDBFIAJIBG(CDPAMNIPPEC: false);
				return false;
			}
		}
		return false;
	}

	public bool GINOIDILKMH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if ((!PGKBFONKCLC(JIIGOACEIKL) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE) && KLGOCJMGKFO && Object.op_Implicit((Object)(object)CLILBMBJGGM(JIIGOACEIKL)) && DNOLKGGPHLJ(JIIGOACEIKL).itemSpace.IsItemSpaceValid(BIOKGEFFNAA: true))
		{
			if (!Tree.OJMPEGIKBMJ(GJOMJHOJAFE(JIIGOACEIKL).itemSpace, ((Component)GJNPDDBBPFE(JIIGOACEIKL).itemSpace).transform.position, 1))
			{
				return true;
			}
			TreeGenerator treeGenerator = TreeGenerator.HPKMKBJGBJB(((Component)DNOLKGGPHLJ(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGenerator))
			{
				HJODGHMHBJJ(JIIGOACEIKL).itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				((Component)DNOLKGGPHLJ(JIIGOACEIKL).itemSpace).gameObject.SetActive(true);
				Utils.FKKHJPEMNBG("UIPreviousCategory", 1);
				Tree component = ((Component)KMICMALEFKD(JIIGOACEIKL)).GetComponent<Tree>();
				treeGenerator.ODOFGPBFLHM(component, NIIBLHMEGNJ: false);
				SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = null;
				KIKJFHMPGDN(JIIGOACEIKL, null);
				ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).IKKLGIKJNNG().MEODNPFJDMH(CDPAMNIPPEC: false);
				return true;
			}
		}
		return false;
	}

	private void OBGPCJHEPCO(int JIIGOACEIKL, Placeable DDJACALAKHO)
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

	public void LBMKLIDKHJD(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		DJCDKPBOKLD(JIIGOACEIKL);
	}

	public bool FDKEMPDCHFB()
	{
		return false;
	}

	private void KIKJFHMPGDN(int JIIGOACEIKL, Placeable DDJACALAKHO)
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

	public bool PJIEKIPOFJH(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.SetPosition(JIIGOACEIKL, treeSproutAux.inputByProximity.actionButtonsPoint.position);
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("[MinePipePuzzle] No hay PipePuzzleInteractable asignado."));
		return false;
	}

	public bool NPJGIILEFPD()
	{
		return true;
	}

	private Placeable KMICMALEFKD(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	public void NAALPOHPJFA(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		treeSproutAux = KMICMALEFKD(JIIGOACEIKL);
		if ((Object)(object)treeSproutAux == (Object)null)
		{
			treeSproutAux = Object.Instantiate<GameObject>(PHGCBMPGGLI(), Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
			OIJMDCIIHDA(JIIGOACEIKL, treeSproutAux);
			((Component)treeSproutAux).GetComponent<Tree>().GNAFHIPCGAA();
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(this);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SetMovingObject(treeSproutAux);
			}
			if ((Object)(object)treeSproutAux.itemSpace != (Object)null)
			{
				treeSproutAux.itemSpace.setUp = false;
			}
		}
		if (!((Component)treeSproutAux.itemSpace).gameObject.activeSelf)
		{
			((Component)treeSproutAux.itemSpace).gameObject.SetActive(false);
		}
		if (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
		{
			treeSproutAux.CHMGNKHKJBN(JIIGOACEIKL, JOOEMBNDCKF: false, OFGPEJIOLNJ: false);
		}
		else
		{
			treeSproutAux.CHMGNKHKJBN(JIIGOACEIKL, JOOEMBNDCKF: false, OFGPEJIOLNJ: false, CDPAMNIPPEC: true);
		}
		treeSproutAux.itemSpace.OOOEEICDIEI(!treeSproutAux.itemSpace.KHNJOFCOIFE() || !Tree.KKFCMBNLMLK(treeSproutAux.itemSpace, ((Component)treeSproutAux.itemSpace).transform.position, 0) || (Object)(object)TreeGenerator.NOEKOJPOLLG(((Component)treeSproutAux).transform.position) != (Object)null);
		if (OnlineManager.PlayingOnline())
		{
			treeSproutAux.onlinePlaceable.MECPMONCHGB(Vector2.op_Implicit(((Component)treeSproutAux).transform.position));
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

	private Placeable FAPECOBHLFG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	public void LCOAAGGAMOO(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		treeSproutAux = OBCFNOPLIEH(JIIGOACEIKL);
		if ((Object)(object)treeSproutAux == (Object)null)
		{
			treeSproutAux = Object.Instantiate<GameObject>(LLCLICBABLN(), Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
			HFDEKAEHEMJ(JIIGOACEIKL, treeSproutAux);
			((Component)treeSproutAux).GetComponent<Tree>().EAPNPOEEKJM();
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(this);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SetMovingObject(treeSproutAux);
			}
			if ((Object)(object)treeSproutAux.itemSpace != (Object)null)
			{
				treeSproutAux.itemSpace.setUp = true;
			}
		}
		if (!((Component)treeSproutAux.itemSpace).gameObject.activeSelf)
		{
			((Component)treeSproutAux.itemSpace).gameObject.SetActive(true);
		}
		if (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).IHMADDCNKAM())
		{
			treeSproutAux.SetPosition(JIIGOACEIKL, JOOEMBNDCKF: true, OFGPEJIOLNJ: true);
		}
		else
		{
			treeSproutAux.CHMGNKHKJBN(JIIGOACEIKL, JOOEMBNDCKF: false, OFGPEJIOLNJ: false, CDPAMNIPPEC: true);
		}
		treeSproutAux.itemSpace.SetAvailable(treeSproutAux.itemSpace.LJCPGDDLJKL(BIOKGEFFNAA: true) && Tree.AreValidAllItemSpaces(treeSproutAux.itemSpace, ((Component)treeSproutAux.itemSpace).transform.position, 1) && (Object)(object)TreeGenerator.NOEKOJPOLLG(((Component)treeSproutAux).transform.position) != (Object)null);
		if (OnlineManager.PlayingOnline())
		{
			treeSproutAux.onlinePlaceable.UpdatePosition(Vector2.op_Implicit(((Component)treeSproutAux).transform.position));
		}
	}

	private Placeable HJODGHMHBJJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	private void PBABIBNPPDP(int JIIGOACEIKL)
	{
		if ((Object)(object)KMICMALEFKD(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(null);
			Utils.BLPDAEHPOBA(((Component)CLILBMBJGGM(JIIGOACEIKL)).gameObject);
		}
	}

	public bool CPHBLGFGLPG(int JIIGOACEIKL)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (Utils.DLOMIGFOOPD(JIIGOACEIKL) && (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))) || (Object)(object)MainUI.openedWindow != (Object)null)
		{
			DJCDKPBOKLD(JIIGOACEIKL);
			return true;
		}
		if (DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).GABNNLJOMHI())
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
		{
			return false;
		}
		if (CursorManager.GetPlayer(JIIGOACEIKL).IHMADDCNKAM())
		{
			return PlayerController.GetPlayer(JIIGOACEIKL).IsTavernLocation();
		}
		CGEPIJMGBKK(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1318f));
		OBNDGCDBGFP(JIIGOACEIKL, LJEOKENBKBC(JIIGOACEIKL));
		if (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) == GroundType.Grass || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(DJDNHOLIJCA(JIIGOACEIKL))) == (GroundType.Grass | GroundType.TilledEarth) || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(OGIPBMKEAGF(JIIGOACEIKL))) == GroundType.None)
		{
			return WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(LJEOKENBKBC(JIIGOACEIKL)));
		}
		return true;
	}

	public bool FIDODBLKPPK(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, treeSproutAux.inputByProximity.actionButtonsPoint.position);
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Talk"));
		return true;
	}

	public bool JNHOFEEKPLB(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, treeSproutAux.inputByProximity.actionButtonsPoint.position);
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("Items/item_name_1114"));
		return false;
	}

	public bool FODGNFMBOFE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (NIFILJFPFCM(JIIGOACEIKL) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && KLGOCJMGKFO && Object.op_Implicit((Object)(object)GJOMJHOJAFE(JIIGOACEIKL)) && HJKIBJLBHDG(JIIGOACEIKL).itemSpace.KHNJOFCOIFE(BIOKGEFFNAA: true))
		{
			if (!Tree.OJMPEGIKBMJ(HJODGHMHBJJ(JIIGOACEIKL).itemSpace, ((Component)DIDEBFDMNOB(JIIGOACEIKL).itemSpace).transform.position, 0))
			{
				return true;
			}
			TreeGenerator treeGenerator = TreeGenerator.DICEKPLIPAO(((Component)FAPECOBHLFG(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGenerator))
			{
				KDFBJPGMCCG(JIIGOACEIKL).itemSpace.Place(NMLKLAGDNPF: false);
				((Component)GJOMJHOJAFE(JIIGOACEIKL).itemSpace).gameObject.SetActive(true);
				Utils.FKKHJPEMNBG("Puente_EA/Talk 1", 0);
				Tree component = ((Component)DIDEBFDMNOB(JIIGOACEIKL)).GetComponent<Tree>();
				treeGenerator.GPOHABMFKBC(component);
				SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = null;
				OMJMLLDGOMF(JIIGOACEIKL, null);
				ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).IKKLGIKJNNG().POHFJCEAKML();
				return true;
			}
		}
		return true;
	}

	private void OMJMLLDGOMF(int JIIGOACEIKL, Placeable DDJACALAKHO)
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
		if ((Object)(object)FAPECOBHLFG(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = null;
			Utils.BLPDAEHPOBA(((Component)BCIFLHPPMHG(JIIGOACEIKL)).gameObject);
		}
	}

	public bool KENCIDJEBMJ()
	{
		return false;
	}

	public void BJPAOIJICCH(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		DJCDKPBOKLD(JIIGOACEIKL);
	}

	private void LHLHGANCLBG(int JIIGOACEIKL, Placeable DDJACALAKHO)
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

	public void HPBGDNILFBP(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		treeSproutAux = CLILBMBJGGM(JIIGOACEIKL);
		if ((Object)(object)treeSproutAux == (Object)null)
		{
			treeSproutAux = Object.Instantiate<GameObject>(LLCLICBABLN(), Vector2.op_Implicit(MEOFAIKNJHE(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
			LHLHGANCLBG(JIIGOACEIKL, treeSproutAux);
			((Component)treeSproutAux).GetComponent<Tree>().GNAFHIPCGAA();
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(this);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SetMovingObject(treeSproutAux);
			}
			if ((Object)(object)treeSproutAux.itemSpace != (Object)null)
			{
				treeSproutAux.itemSpace.setUp = false;
			}
		}
		if (!((Component)treeSproutAux.itemSpace).gameObject.activeSelf)
		{
			((Component)treeSproutAux.itemSpace).gameObject.SetActive(false);
		}
		if (CursorManager.GetPlayer(JIIGOACEIKL).LALPELGNIJB())
		{
			treeSproutAux.SetPosition(JIIGOACEIKL, JOOEMBNDCKF: true, OFGPEJIOLNJ: true);
		}
		else
		{
			treeSproutAux.CHMGNKHKJBN(JIIGOACEIKL, JOOEMBNDCKF: true, OFGPEJIOLNJ: false, CDPAMNIPPEC: true);
		}
		treeSproutAux.itemSpace.MGCHMMFFBJA(!treeSproutAux.itemSpace.IsItemSpaceValid(BIOKGEFFNAA: true) || !Tree.AreValidAllItemSpaces(treeSproutAux.itemSpace, ((Component)treeSproutAux.itemSpace).transform.position, 1) || (Object)(object)TreeGenerator.BFOJMLIEANA(((Component)treeSproutAux).transform.position) != (Object)null);
		if (OnlineManager.PlayingOnline())
		{
			treeSproutAux.onlinePlaceable.MNGPBBOIIHK(Vector2.op_Implicit(((Component)treeSproutAux).transform.position));
		}
	}

	public bool KLGPHPFNJII(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.SetPosition(JIIGOACEIKL, treeSproutAux.inputByProximity.actionButtonsPoint.position);
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.PreviousItem, LocalisationSystem.Get("repUnlockBroom"));
		return true;
	}

	public bool OLNJHIPLODD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (KEJCKMELIGH(JIIGOACEIKL) && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && KLGOCJMGKFO && Object.op_Implicit((Object)(object)HJODGHMHBJJ(JIIGOACEIKL)) && KDFBJPGMCCG(JIIGOACEIKL).itemSpace.KHNJOFCOIFE(BIOKGEFFNAA: true, ELKPPAAMMIM: false))
		{
			if (!Tree.AreValidAllItemSpaces(BEBBAFPNADO(JIIGOACEIKL).itemSpace, ((Component)KMICMALEFKD(JIIGOACEIKL).itemSpace).transform.position, 1))
			{
				return true;
			}
			TreeGenerator treeGeneratorInArea = TreeGenerator.GetTreeGeneratorInArea(((Component)FAPECOBHLFG(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGeneratorInArea))
			{
				DNOLKGGPHLJ(JIIGOACEIKL).itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true);
				((Component)GJNPDDBBPFE(JIIGOACEIKL).itemSpace).gameObject.SetActive(true);
				Utils.FKKHJPEMNBG("itemDragonFruit", 1);
				Tree component = ((Component)KMICMALEFKD(JIIGOACEIKL)).GetComponent<Tree>();
				treeGeneratorInArea.LFACCKLNDOK(component);
				SelectObject.GetPlayer(JIIGOACEIKL).MHJCMDHEDCO(null);
				GLKCCGFFEIO(JIIGOACEIKL, null);
				ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL).PFCKPOFHPAC().MBCIJPPOGJG();
				return false;
			}
		}
		return false;
	}

	private Placeable DIDEBFDMNOB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	public bool FLOENLLCHHJ(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.SetPosition(JIIGOACEIKL, treeSproutAux.inputByProximity.actionButtonsPoint.position);
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("，"));
		return false;
	}

	private void PBIEPNBCJKI(int JIIGOACEIKL, Placeable DDJACALAKHO)
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

	public bool DAODKFBNCDH()
	{
		return false;
	}

	private Placeable DNOLKGGPHLJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	private void EJJMOPBAFML(int JIIGOACEIKL)
	{
		if ((Object)(object)KDFBJPGMCCG(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(null);
			Utils.BLPDAEHPOBA(((Component)BEBBAFPNADO(JIIGOACEIKL)).gameObject);
		}
	}

	private void GJLGBOIBDLI(int JIIGOACEIKL)
	{
		if ((Object)(object)OBCFNOPLIEH(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(null);
			Utils.BLPDAEHPOBA(((Component)DIDEBFDMNOB(JIIGOACEIKL)).gameObject);
		}
	}

	public void EMENENAKHIJ(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		treeSproutAux = DIDEBFDMNOB(JIIGOACEIKL);
		if ((Object)(object)treeSproutAux == (Object)null)
		{
			treeSproutAux = Object.Instantiate<GameObject>(LLCLICBABLN(), Vector2.op_Implicit(MLFDDJONGBL(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
			GLKCCGFFEIO(JIIGOACEIKL, treeSproutAux);
			((Component)treeSproutAux).GetComponent<Tree>().EAPNPOEEKJM();
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(this);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SetMovingObject(treeSproutAux);
			}
			if ((Object)(object)treeSproutAux.itemSpace != (Object)null)
			{
				treeSproutAux.itemSpace.setUp = false;
			}
		}
		if (!((Component)treeSproutAux.itemSpace).gameObject.activeSelf)
		{
			((Component)treeSproutAux.itemSpace).gameObject.SetActive(false);
		}
		if (CursorManager.GetPlayer(JIIGOACEIKL).LALPELGNIJB())
		{
			treeSproutAux.CHMGNKHKJBN(JIIGOACEIKL, JOOEMBNDCKF: false, OFGPEJIOLNJ: false, CDPAMNIPPEC: true);
		}
		else
		{
			treeSproutAux.SetPosition(JIIGOACEIKL, JOOEMBNDCKF: true, OFGPEJIOLNJ: true);
		}
		treeSproutAux.itemSpace.SetAvailable(treeSproutAux.itemSpace.IsItemSpaceValid(BIOKGEFFNAA: false, ELKPPAAMMIM: false) && Tree.OJMPEGIKBMJ(treeSproutAux.itemSpace, ((Component)treeSproutAux.itemSpace).transform.position, 1) && (Object)(object)TreeGenerator.BCJOOJNHHHG(((Component)treeSproutAux).transform.position) != (Object)null);
		if (OnlineManager.PlayingOnline())
		{
			treeSproutAux.onlinePlaceable.LAGMJDLPDEJ(Vector2.op_Implicit(((Component)treeSproutAux).transform.position));
		}
	}

	private Placeable CLILBMBJGGM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	private Placeable KDFBJPGMCCG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	public void PGCLLOAHEAF(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		DJCDKPBOKLD(JIIGOACEIKL);
	}

	private Placeable HJKIBJLBHDG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	public bool KNJHGAPLLPK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if ((!NIFILJFPFCM(JIIGOACEIKL) || PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE) && KLGOCJMGKFO && Object.op_Implicit((Object)(object)GJNPDDBBPFE(JIIGOACEIKL)) && HJODGHMHBJJ(JIIGOACEIKL).itemSpace.LJCPGDDLJKL(BIOKGEFFNAA: true, ELKPPAAMMIM: false))
		{
			if (!Tree.OJMPEGIKBMJ(DNOLKGGPHLJ(JIIGOACEIKL).itemSpace, ((Component)CLILBMBJGGM(JIIGOACEIKL).itemSpace).transform.position, 1))
			{
				return true;
			}
			TreeGenerator treeGenerator = TreeGenerator.HDIAKEGELHJ(((Component)GJNPDDBBPFE(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGenerator))
			{
				HJKIBJLBHDG(JIIGOACEIKL).itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				((Component)FAPECOBHLFG(JIIGOACEIKL).itemSpace).gameObject.SetActive(false);
				Utils.FKKHJPEMNBG("Disabled", 1);
				Tree component = ((Component)GJOMJHOJAFE(JIIGOACEIKL)).GetComponent<Tree>();
				treeGenerator.AddForestElement(component, NIIBLHMEGNJ: false);
				SelectObject.BNMEANGDMIP(JIIGOACEIKL).ELBNNJOALFG = null;
				GLKCCGFFEIO(JIIGOACEIKL, null);
				ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GEAMCEMDJFJ().MEODNPFJDMH();
				return false;
			}
		}
		return false;
	}

	public void KCDOKIIPBGC(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		PJIBBLDNHFN(JIIGOACEIKL);
	}

	public bool PGKBFONKCLC(int JIIGOACEIKL)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (Utils.DLOMIGFOOPD(JIIGOACEIKL) && (!PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))) || (Object)(object)MainUI.openedWindow != (Object)null)
		{
			AEIJDMBGOFF(JIIGOACEIKL);
			return false;
		}
		if (DecorationMode.OCJGHINCLJM(JIIGOACEIKL).KNFEPKBIHND())
		{
			return false;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road))
		{
			return true;
		}
		if (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).IHMADDCNKAM())
		{
			return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).IsTavernLocation();
		}
		HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 305f));
		IGLFLKEGAEB(JIIGOACEIKL, KJOFFEDOOLB(JIIGOACEIKL));
		if (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(LJEOKENBKBC(JIIGOACEIKL))) == GroundType.None || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(KJOFFEDOOLB(JIIGOACEIKL))) == GroundType.None || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(OGIPBMKEAGF(JIIGOACEIKL))) == GroundType.Grass)
		{
			return WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(LJEOKENBKBC(JIIGOACEIKL)));
		}
		return false;
	}

	private void GLKCCGFFEIO(int JIIGOACEIKL, Placeable DDJACALAKHO)
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

	private Placeable OBCFNOPLIEH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	public bool KEJCKMELIGH(int JIIGOACEIKL)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (Utils.DLOMIGFOOPD(JIIGOACEIKL) && (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.EAHELIGKMPL(JIIGOACEIKL))) || (Object)(object)MainUI.openedWindow != (Object)null)
		{
			EJJMOPBAFML(JIIGOACEIKL);
			return false;
		}
		if (DecorationMode.FIHGMLABOBB(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return true;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != 0)
		{
			return true;
		}
		if (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).LALPELGNIJB())
		{
			return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).IsTavernLocation();
		}
		CPNDNPMHKDC(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1992f));
		AGAJDKDCEHJ(JIIGOACEIKL, KJOFFEDOOLB(JIIGOACEIKL));
		if (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) == GroundType.Grass || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) == (GroundType.Grass | GroundType.Ground) || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(DJDNHOLIJCA(JIIGOACEIKL))) == (GroundType.Grass | GroundType.TilledEarth))
		{
			return WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(KJOFFEDOOLB(JIIGOACEIKL)));
		}
		return false;
	}

	private Placeable GJNPDDBBPFE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	public bool IKPNNKPDGPB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if ((!NBFBPMNMBJG(JIIGOACEIKL) || !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF()) && KLGOCJMGKFO && Object.op_Implicit((Object)(object)KDFBJPGMCCG(JIIGOACEIKL)) && BEBBAFPNADO(JIIGOACEIKL).itemSpace.KHNJOFCOIFE(BIOKGEFFNAA: false, ELKPPAAMMIM: false))
		{
			if (!Tree.AreValidAllItemSpaces(GJNPDDBBPFE(JIIGOACEIKL).itemSpace, ((Component)BCIFLHPPMHG(JIIGOACEIKL).itemSpace).transform.position, 0))
			{
				return true;
			}
			TreeGenerator treeGenerator = TreeGenerator.GAHJONKFCAB(((Component)BEBBAFPNADO(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGenerator))
			{
				DIDEBFDMNOB(JIIGOACEIKL).itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				((Component)KDFBJPGMCCG(JIIGOACEIKL).itemSpace).gameObject.SetActive(true);
				Utils.FKKHJPEMNBG("Error in Bin.OnEnable: ", 1);
				Tree component = ((Component)GJOMJHOJAFE(JIIGOACEIKL)).GetComponent<Tree>();
				treeGenerator.AddForestElement(component, NIIBLHMEGNJ: false);
				SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = null;
				LHLHGANCLBG(JIIGOACEIKL, null);
				ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL).GetSelectedSlot().DJFOMFDOOKM();
				return false;
			}
		}
		return true;
	}

	public bool MPEDAKDMMAE(int JIIGOACEIKL)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE || MainUI.IsAnyUIOpen(JIIGOACEIKL) || (Utils.DLOMIGFOOPD(JIIGOACEIKL) && (!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))) || (Object)(object)MainUI.openedWindow != (Object)null)
		{
			PBABIBNPPDP(JIIGOACEIKL);
			return false;
		}
		if (DecorationMode.OCJGHINCLJM(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.River)
		{
			return false;
		}
		if (CursorManager.GetPlayer(JIIGOACEIKL).LALPELGNIJB())
		{
			return PlayerController.GetPlayer(JIIGOACEIKL).IsTavernLocation();
		}
		OCIHACOJOLG(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1348f));
		JCNLMHNEKCF(JIIGOACEIKL, DJDNHOLIJCA(JIIGOACEIKL));
		if (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(KJOFFEDOOLB(JIIGOACEIKL))) == GroundType.Grass || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(LJEOKENBKBC(JIIGOACEIKL))) == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth) || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(DJDNHOLIJCA(JIIGOACEIKL))) == GroundType.Floor)
		{
			return WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(NLGOOKPIOCN(JIIGOACEIKL)));
		}
		return false;
	}

	public bool EJCLAFGCPLH(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, treeSproutAux.inputByProximity.actionButtonsPoint.position);
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(""));
		return false;
	}

	public void ACMFFDODECH(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		NCHHMNCHOHH(JIIGOACEIKL);
	}

	private void NCHHMNCHOHH(int JIIGOACEIKL)
	{
		if ((Object)(object)CLILBMBJGGM(JIIGOACEIKL) != (Object)null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = null;
			Utils.BLPDAEHPOBA(((Component)OBCFNOPLIEH(JIIGOACEIKL)).gameObject);
		}
	}

	public void PFIPNIPEGFM(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		treeSproutAux = DIDEBFDMNOB(JIIGOACEIKL);
		if ((Object)(object)treeSproutAux == (Object)null)
		{
			treeSproutAux = Object.Instantiate<GameObject>(PHGCBMPGGLI(), Vector2.op_Implicit(MLFDDJONGBL(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
			PBIEPNBCJKI(JIIGOACEIKL, treeSproutAux);
			((Component)treeSproutAux).GetComponent<Tree>().GNAFHIPCGAA();
			SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = this;
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SetMovingObject(treeSproutAux);
			}
			if ((Object)(object)treeSproutAux.itemSpace != (Object)null)
			{
				treeSproutAux.itemSpace.setUp = false;
			}
		}
		if (!((Component)treeSproutAux.itemSpace).gameObject.activeSelf)
		{
			((Component)treeSproutAux.itemSpace).gameObject.SetActive(false);
		}
		if (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
		{
			treeSproutAux.SetPosition(JIIGOACEIKL, JOOEMBNDCKF: true, OFGPEJIOLNJ: true, CDPAMNIPPEC: true);
		}
		else
		{
			treeSproutAux.CHMGNKHKJBN(JIIGOACEIKL, JOOEMBNDCKF: false, OFGPEJIOLNJ: false, CDPAMNIPPEC: true);
		}
		treeSproutAux.itemSpace.PIPELIBAMAB(treeSproutAux.itemSpace.LJCPGDDLJKL(BIOKGEFFNAA: true, ELKPPAAMMIM: false) && Tree.AreValidAllItemSpaces(treeSproutAux.itemSpace, ((Component)treeSproutAux.itemSpace).transform.position, 1) && (Object)(object)TreeGenerator.GAHJONKFCAB(((Component)treeSproutAux).transform.position) != (Object)null);
		if (OnlineManager.PlayingOnline())
		{
			treeSproutAux.onlinePlaceable.BOILJEPIODF(Vector2.op_Implicit(((Component)treeSproutAux).transform.position));
		}
	}

	public bool EHJCPDAKEMI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (PGKBFONKCLC(JIIGOACEIKL) && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && KLGOCJMGKFO && Object.op_Implicit((Object)(object)FAPECOBHLFG(JIIGOACEIKL)) && HJODGHMHBJJ(JIIGOACEIKL).itemSpace.IsItemSpaceValid())
		{
			if (!Tree.OJMPEGIKBMJ(GJOMJHOJAFE(JIIGOACEIKL).itemSpace, ((Component)OBCFNOPLIEH(JIIGOACEIKL).itemSpace).transform.position, 0))
			{
				return true;
			}
			TreeGenerator treeGenerator = TreeGenerator.FMKHIBDEDBE(((Component)BCIFLHPPMHG(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGenerator))
			{
				GJNPDDBBPFE(JIIGOACEIKL).itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				((Component)FAPECOBHLFG(JIIGOACEIKL).itemSpace).gameObject.SetActive(true);
				Utils.FKKHJPEMNBG("Calm down", 1);
				Tree component = ((Component)HJODGHMHBJJ(JIIGOACEIKL)).GetComponent<Tree>();
				treeGenerator.OEOJKJLKMHP(component, NIIBLHMEGNJ: false);
				SelectObject.GetPlayer(JIIGOACEIKL).MHJCMDHEDCO(null);
				KIKJFHMPGDN(JIIGOACEIKL, null);
				ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedSlot().POHFJCEAKML();
				return true;
			}
		}
		return true;
	}

	public bool BPKHKKIOOKH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if ((!CPHBLGFGLPG(JIIGOACEIKL) || PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF()) && KLGOCJMGKFO && Object.op_Implicit((Object)(object)FAPECOBHLFG(JIIGOACEIKL)) && FAPECOBHLFG(JIIGOACEIKL).itemSpace.IsItemSpaceValid(BIOKGEFFNAA: true, ELKPPAAMMIM: false))
		{
			if (!Tree.OJMPEGIKBMJ(BEBBAFPNADO(JIIGOACEIKL).itemSpace, ((Component)CLILBMBJGGM(JIIGOACEIKL).itemSpace).transform.position, 1))
			{
				return true;
			}
			TreeGenerator treeGenerator = TreeGenerator.EJDIBGMJDPO(((Component)DNOLKGGPHLJ(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGenerator))
			{
				GJOMJHOJAFE(JIIGOACEIKL).itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
				((Component)HJKIBJLBHDG(JIIGOACEIKL).itemSpace).gameObject.SetActive(false);
				Utils.FKKHJPEMNBG("F2", 1);
				Tree component = ((Component)KMICMALEFKD(JIIGOACEIKL)).GetComponent<Tree>();
				treeGenerator.ODOFGPBFLHM(component);
				SelectObject.GetPlayer(JIIGOACEIKL).MHJCMDHEDCO(null);
				OMJMLLDGOMF(JIIGOACEIKL, null);
				ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedSlot().FMEPMEKLHIJ();
				return true;
			}
		}
		return true;
	}

	private void OIJMDCIIHDA(int JIIGOACEIKL, Placeable DDJACALAKHO)
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

	public bool MKKPDKNLLFD(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.SetPosition(JIIGOACEIKL, treeSproutAux.inputByProximity.actionButtonsPoint.position);
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Check For Duplicate OnlineObjects finished"));
		return false;
	}

	public void CGFOKKIANJH(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		treeSproutAux = BEBBAFPNADO(JIIGOACEIKL);
		if ((Object)(object)treeSproutAux == (Object)null)
		{
			treeSproutAux = Object.Instantiate<GameObject>(PHGCBMPGGLI(), Vector2.op_Implicit(MEOFAIKNJHE(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
			KJNEBCNHNPE(JIIGOACEIKL, treeSproutAux);
			((Component)treeSproutAux).GetComponent<Tree>().SetUpPlayerSleepFunction();
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).MHJCMDHEDCO(this);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SetMovingObject(treeSproutAux);
			}
			if ((Object)(object)treeSproutAux.itemSpace != (Object)null)
			{
				treeSproutAux.itemSpace.setUp = true;
			}
		}
		if (!((Component)treeSproutAux.itemSpace).gameObject.activeSelf)
		{
			((Component)treeSproutAux.itemSpace).gameObject.SetActive(false);
		}
		if (CursorManager.GetPlayer(JIIGOACEIKL).IHMADDCNKAM())
		{
			treeSproutAux.SetPosition(JIIGOACEIKL, JOOEMBNDCKF: false, OFGPEJIOLNJ: true, CDPAMNIPPEC: true);
		}
		else
		{
			treeSproutAux.SetPosition(JIIGOACEIKL, JOOEMBNDCKF: true, OFGPEJIOLNJ: true);
		}
		treeSproutAux.itemSpace.SetAvailable(treeSproutAux.itemSpace.IsItemSpaceValid(BIOKGEFFNAA: true, ELKPPAAMMIM: false) && Tree.AreValidAllItemSpaces(treeSproutAux.itemSpace, ((Component)treeSproutAux.itemSpace).transform.position, 0) && (Object)(object)TreeGenerator.GetTreeGeneratorInArea(((Component)treeSproutAux).transform.position) != (Object)null);
		if (OnlineManager.PlayingOnline())
		{
			treeSproutAux.onlinePlaceable.HMDMDOGLGLO(Vector2.op_Implicit(((Component)treeSproutAux).transform.position));
		}
	}

	public bool JNKIOAJBKGE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (CPHBLGFGLPG(JIIGOACEIKL) && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF() && KLGOCJMGKFO && Object.op_Implicit((Object)(object)HJODGHMHBJJ(JIIGOACEIKL)) && HJODGHMHBJJ(JIIGOACEIKL).itemSpace.IsItemSpaceValid(BIOKGEFFNAA: true, ELKPPAAMMIM: false))
		{
			if (!Tree.AreValidAllItemSpaces(DNOLKGGPHLJ(JIIGOACEIKL).itemSpace, ((Component)DNOLKGGPHLJ(JIIGOACEIKL).itemSpace).transform.position, 0))
			{
				return true;
			}
			TreeGenerator treeGenerator = TreeGenerator.HPKMKBJGBJB(((Component)GJOMJHOJAFE(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGenerator))
			{
				GJNPDDBBPFE(JIIGOACEIKL).itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				((Component)HJODGHMHBJJ(JIIGOACEIKL).itemSpace).gameObject.SetActive(false);
				Utils.FKKHJPEMNBG("CheckoutDate", 0);
				Tree component = ((Component)GJNPDDBBPFE(JIIGOACEIKL)).GetComponent<Tree>();
				treeGenerator.JMBCNPHAAAO(component, NIIBLHMEGNJ: false);
				SelectObject.GetPlayer(JIIGOACEIKL).ELBNNJOALFG = null;
				PBIEPNBCJKI(JIIGOACEIKL, null);
				ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true).MIPGHCNCOEL().MEODNPFJDMH();
				return true;
			}
		}
		return true;
	}

	public void PDFNGFOCGIP(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		treeSproutAux = GJNPDDBBPFE(JIIGOACEIKL);
		if ((Object)(object)treeSproutAux == (Object)null)
		{
			treeSproutAux = Object.Instantiate<GameObject>(LLCLICBABLN(), Vector2.op_Implicit(BLFCGBDEDLP(JIIGOACEIKL)), Quaternion.identity).GetComponent<Placeable>();
			OMJMLLDGOMF(JIIGOACEIKL, treeSproutAux);
			((Component)treeSproutAux).GetComponent<Tree>().SetUpPlayerSleepFunction();
			SelectObject.GetPlayer(JIIGOACEIKL).MHJCMDHEDCO(this);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SetMovingObject(treeSproutAux);
			}
			if ((Object)(object)treeSproutAux.itemSpace != (Object)null)
			{
				treeSproutAux.itemSpace.setUp = true;
			}
		}
		if (!((Component)treeSproutAux.itemSpace).gameObject.activeSelf)
		{
			((Component)treeSproutAux.itemSpace).gameObject.SetActive(false);
		}
		if (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).IHMADDCNKAM())
		{
			treeSproutAux.CHMGNKHKJBN(JIIGOACEIKL, JOOEMBNDCKF: true, OFGPEJIOLNJ: false, CDPAMNIPPEC: true);
		}
		else
		{
			treeSproutAux.CHMGNKHKJBN(JIIGOACEIKL, JOOEMBNDCKF: true, OFGPEJIOLNJ: false, CDPAMNIPPEC: true);
		}
		treeSproutAux.itemSpace.MGCHMMFFBJA(treeSproutAux.itemSpace.IsItemSpaceValid(BIOKGEFFNAA: true, ELKPPAAMMIM: false) && Tree.KKFCMBNLMLK(treeSproutAux.itemSpace, ((Component)treeSproutAux.itemSpace).transform.position, 0) && (Object)(object)TreeGenerator.HCLHHBLOIMD(((Component)treeSproutAux).transform.position) != (Object)null);
		if (OnlineManager.PlayingOnline())
		{
			treeSproutAux.onlinePlaceable.PDDHCKIOEHB(Vector2.op_Implicit(((Component)treeSproutAux).transform.position));
		}
	}

	private Placeable GJOMJHOJAFE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	public bool JHHDPLMGMBM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (KEJCKMELIGH(JIIGOACEIKL) && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF() && KLGOCJMGKFO && Object.op_Implicit((Object)(object)FAPECOBHLFG(JIIGOACEIKL)) && BCIFLHPPMHG(JIIGOACEIKL).itemSpace.IsItemSpaceValid())
		{
			if (!Tree.KKFCMBNLMLK(CLILBMBJGGM(JIIGOACEIKL).itemSpace, ((Component)BEBBAFPNADO(JIIGOACEIKL).itemSpace).transform.position, 1))
			{
				return true;
			}
			TreeGenerator treeGenerator = TreeGenerator.GADFLGJLCEG(((Component)DIDEBFDMNOB(JIIGOACEIKL)).transform.position);
			if (Object.op_Implicit((Object)(object)treeGenerator))
			{
				KDFBJPGMCCG(JIIGOACEIKL).itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				((Component)FAPECOBHLFG(JIIGOACEIKL).itemSpace).gameObject.SetActive(false);
				Utils.FKKHJPEMNBG("EditorConfiguration", 0);
				Tree component = ((Component)KDFBJPGMCCG(JIIGOACEIKL)).GetComponent<Tree>();
				treeGenerator.OOIPFMNLJKL(component, NIIBLHMEGNJ: false);
				SelectObject.GetPlayer(JIIGOACEIKL).MHJCMDHEDCO(null);
				OIJMDCIIHDA(JIIGOACEIKL, null);
				ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NBEINBNMKJG().DJFOMFDOOKM();
				return true;
			}
		}
		return false;
	}

	private Placeable BEBBAFPNADO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return treeSprout2;
		}
		return treeSprout;
	}

	public void PEPCEINPCLK(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		NCHHMNCHOHH(JIIGOACEIKL);
	}

	public bool OEAJKPNBGBB(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.SetPosition(JIIGOACEIKL, treeSproutAux.inputByProximity.actionButtonsPoint.position);
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("TermasInterior/Kenta/Intro"));
		return false;
	}
}
