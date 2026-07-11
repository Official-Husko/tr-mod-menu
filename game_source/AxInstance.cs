using System;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class AxInstance : ToolInstance
{
	private Tree FFBBBJKKFGB;

	private Rock HICBJDGPMDM;

	private InputByProximity LFBNPHHABDK;

	private Vector2 FIAMALDJHFL;

	private bool GIOHBNPIOHF;

	private Ax KEKHBAPPAHI => item as Ax;

	private void KAGAIPAOAPG(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	private void FCMMOMIBICE(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	public bool NOHLCFIMGNJ(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.IJDMGANEEEE())
		{
			return false;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.Road && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop))
		{
			return true;
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).GABNNLJOMHI();
		}
		return true;
	}

	private void FODKLLBFOGH(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(HFODJAFMJCO));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	private void OPMNPIIEOOK(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	private void BKCJHCEMIBG(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(IDHPEDDPEEF));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	private void DEBDEMCNJLA(int JIIGOACEIKL)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		Tree tree = BEKJHDHALFG(JIIGOACEIKL);
		if ((Object)(object)tree != (Object)null)
		{
			if (BIBBFHILPPH() >= tree.toolLevelRequired)
			{
				tree.CutAction(JIIGOACEIKL, KEKHBAPPAHI.workDonePerHit);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBLHGFCINF("OpenQuests");
				MultiAudioManager.PlayAudioObject(LENHABBBOAL().axeFailSound, ((Component)tree).transform.position);
				KOIMGAIDNBP(JIIGOACEIKL, KLMDEPBMACA: false);
			}
		}
		else
		{
			Rock rock = NGHCHMCHAAO(JIIGOACEIKL);
			if ((Object)(object)rock != (Object)null)
			{
				if (DAEOCFODOML() >= rock.toolLevelRequired || (OGCEOPDOEAB() == 7 && rock.toolLevelRequired == 4))
				{
					rock.GCBHFEJOBEH(JIIGOACEIKL, LGOHEDOHOKG().workDonePerHit);
				}
				else
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBLHGFCINF("clouds");
					MultiAudioManager.PlayAudioObject(FGKBPKLEGDF().axeFailSound, ((Component)rock).transform.position);
					GFANHBFKGFB(JIIGOACEIKL, KLMDEPBMACA: false);
				}
			}
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(BDNEHBAEJKJ));
	}

	private void HABLDICIFPN(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	private Tree BCGDAAKMNIH(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private void GAEOPFJBLMN(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(FODKLLBFOGH));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	private bool AJEHKJGONML(int JIIGOACEIKL)
	{
		return GIOHBNPIOHF;
	}

	[SpecialName]
	private Ax OLLAPFJFHAA()
	{
		return item as Ax;
	}

	public bool JIJBFHCBGPN(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.JIANMIFHKID())
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != 0 && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Quarry | Location.FarmShop))
		{
			return true;
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return false;
	}

	private void OAGNNCNANNK(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	public bool LKPNFBOIGJG(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.KNMEPGLDLDH())
		{
			return true;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River) && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Camp | Location.Quarry))
		{
			return true;
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF())
		{
			return !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IBEFDKHFBFM();
		}
		return true;
	}

	private void NNFPJPHMPFK(int JIIGOACEIKL)
	{
		HKACPJAFFGN(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)OMAPDOLLKGA());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(ABHAEKMJFKD));
	}

	private void PAKLPLDCBBO(int JIIGOACEIKL)
	{
		OOJEMLIJNHM(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)OMAPDOLLKGA());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(ABHAEKMJFKD));
	}

	private void MOMILMFAPBJ(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	private Tree AMANLLHMAIC(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private void OOHKCNHNJDK(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	private void CIKJELAAEMJ(int JIIGOACEIKL)
	{
		PGBKOLMPPHF(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)BLIKNGGCLID(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(KKBENHDODCH));
	}

	private bool KAKOEDKMHBO(int JIIGOACEIKL)
	{
		return GIOHBNPIOHF;
	}

	private Rock JJIKIOMDAEE(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private bool FNKGDCJNMOJ(int JIIGOACEIKL)
	{
		return GIOHBNPIOHF;
	}

	public bool NAILPDFMEJK(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.IJDMGANEEEE())
		{
			return true;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Road | Location.River) && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Road | Location.River | Location.Camp))
		{
			return false;
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IBEFDKHFBFM();
		}
		return true;
	}

	private void BDNEHBAEJKJ(int JIIGOACEIKL)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		Tree tree = BCGDAAKMNIH(JIIGOACEIKL);
		if ((Object)(object)tree != (Object)null)
		{
			if (DAEOCFODOML() >= tree.toolLevelRequired)
			{
				tree.CutAction(JIIGOACEIKL, BJJABIMNLLB().workDonePerHit);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBarkWithI2("StartLucenDialogue ");
				MultiAudioManager.PlayAudioObject(KEKHBAPPAHI.axeFailSound, ((Component)tree).transform.position);
				KAGAIPAOAPG(JIIGOACEIKL, KLMDEPBMACA: false);
			}
		}
		else
		{
			Rock rock = EHLIHIDEBAG(JIIGOACEIKL);
			if ((Object)(object)rock != (Object)null)
			{
				if (BIBBFHILPPH() >= rock.toolLevelRequired || (LCEMDNCKAMJ() == 2 && rock.toolLevelRequired == 6))
				{
					rock.GKNMADANCLG(JIIGOACEIKL, BJJABIMNLLB().workDonePerHit, CDPAMNIPPEC: false);
				}
				else
				{
					PlayerController.GetPlayer(JIIGOACEIKL).BIBLHGFCINF(" has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object.");
					MultiAudioManager.PlayAudioObject(LGOHEDOHOKG().axeFailSound, ((Component)rock).transform.position);
					IKLAPMLADAK(JIIGOACEIKL, KLMDEPBMACA: true);
				}
			}
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(IECIOMPBHLP));
	}

	private bool JBIHGPPHLKM(int JIIGOACEIKL)
	{
		return GIOHBNPIOHF;
	}

	private void FPHMFDMJMDB(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private bool FCEKCBLDHNP(int JIIGOACEIKL)
	{
		return GIOHBNPIOHF;
	}

	private void BGILMHKGJIO(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	private void ACGHCEMFOKB(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(JOICDPOKECI));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	private void IDHPEDDPEEF(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(CCCFBAJIJME));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	private void KKBENHDODCH(int JIIGOACEIKL)
	{
		MDLDPLCDEMA(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)OMAPDOLLKGA());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(MJJBNLPDMIM));
	}

	private void CANCOOJAANJ(int JIIGOACEIKL)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		Tree tree = NLBGKIMAEOE(JIIGOACEIKL);
		if ((Object)(object)tree != (Object)null)
		{
			if (base.IGCPCEKPHCI >= tree.toolLevelRequired)
			{
				tree.ABLGPOMJFMO(JIIGOACEIKL, PFNLFFIOJEI().workDonePerHit);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBarkWithI2("Inventory full");
				MultiAudioManager.PlayAudioObject(FIJFHEGFFPG().axeFailSound, ((Component)tree).transform.position);
				IPFNKAKBAKE(JIIGOACEIKL, KLMDEPBMACA: false);
			}
		}
		else
		{
			Rock rock = JPEPNAMBCNO(JIIGOACEIKL);
			if ((Object)(object)rock != (Object)null)
			{
				if (BIBBFHILPPH() >= rock.toolLevelRequired || (BIBBFHILPPH() == 3 && rock.toolLevelRequired == 2))
				{
					rock.Chop(JIIGOACEIKL, PFNLFFIOJEI().workDonePerHit, CDPAMNIPPEC: false);
				}
				else
				{
					PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("ReceiveDisableContent");
					MultiAudioManager.PlayAudioObject(LGOHEDOHOKG().axeFailSound, ((Component)rock).transform.position);
					HAKLNGMPFAA(JIIGOACEIKL, KLMDEPBMACA: false);
				}
			}
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(FBOGICAIDHF));
	}

	private void GFJPGAMANIH(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	private void CCCFBAJIJME(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(IDHPEDDPEEF));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	public bool BNHPFIJEFFI(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.HasBeenChopped())
		{
			return true;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River) && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != ~(Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			return false;
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return true;
	}

	private void HFFBEKAJENF(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void MMJGOLLPKNC(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private Tree JJIHDHJFNGG(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private Rock JPEPNAMBCNO(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private Rock FLPEMMOEBND(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	public override bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.ToolBlocked(JIIGOACEIKL, 1060))
		{
			return false;
		}
		if ((Object)(object)MLKAICLMFLG().skin != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).toolSkinController.ChangeSkin(MLKAICLMFLG().bodyPart, MLKAICLMFLG().skin);
		}
		if (KLGOCJMGKFO)
		{
			LFBNPHHABDK = InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement();
			BGILMHKGJIO(JIIGOACEIKL, KLMDEPBMACA: false);
			if (Object.op_Implicit((Object)(object)LFBNPHHABDK))
			{
				Tree component = LFBNPHHABDK.mainGameObject.GetComponent<Tree>();
				if ((Object)(object)component != (Object)null)
				{
					KCCEDJAIIJE(JIIGOACEIKL, component);
					ADMDFPKEDDC(JIIGOACEIKL, null);
				}
				else
				{
					Rock component2 = LFBNPHHABDK.mainGameObject.GetComponent<Rock>();
					if ((Object)(object)component2 != (Object)null)
					{
						ADMDFPKEDDC(JIIGOACEIKL, component2);
						KCCEDJAIIJE(JIIGOACEIKL, null);
					}
				}
			}
			else
			{
				KCCEDJAIIJE(JIIGOACEIKL, null);
				ADMDFPKEDDC(JIIGOACEIKL, null);
			}
		}
		if (JBIHGPPHLKM(JIIGOACEIKL))
		{
			return false;
		}
		Tree tree = IAGHOJNHIPG(JIIGOACEIKL);
		Rock rock = NGHCHMCHAAO(JIIGOACEIKL);
		if (CGCAHFDCOED(JIIGOACEIKL, tree, rock))
		{
			if ((Object)(object)tree != (Object)null)
			{
				if (!tree.IsAnyPlayerPositionAvailable())
				{
					if (KLGOCJMGKFO)
					{
						MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Occupied Positions"));
					}
					return false;
				}
				FIAMALDJHFL = tree.GetNearPlayerPosition(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position));
			}
			else if ((Object)(object)rock != (Object)null)
			{
				if (!rock.work.JCMBHAEKLKK)
				{
					return false;
				}
				if (!rock.IsAnyPlayerPositionAvailable())
				{
					if (KLGOCJMGKFO)
					{
						MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Occupied Positions"));
					}
					return false;
				}
				FIAMALDJHFL = rock.GetNearPlayerPosition(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position));
			}
			if (!PlayerController.GetPlayer(JIIGOACEIKL).GoToPosition(FIAMALDJHFL, KLGOCJMGKFO))
			{
				return false;
			}
			if (Object.op_Implicit((Object)(object)tree))
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtNotDelay(Vector2.op_Implicit(((Component)tree).transform.position));
			}
			else if (Object.op_Implicit((Object)(object)rock))
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtNotDelay(Vector2.op_Implicit(((Component)rock).transform.position));
			}
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.AxRight();
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(HMFIJDJKCDK));
			CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(IECIOMPBHLP));
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(EJJLAKMBIOL));
			return true;
		}
		return false;
	}

	private void CNIHOIBJPEG(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void DNBBOJJAAGF(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	[SpecialName]
	private Ax FIJFHEGFFPG()
	{
		return item as Ax;
	}

	private void KDPAMDEKNHI(int JIIGOACEIKL)
	{
		HNJEDEJNPNL(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(EKOCMBJDGGC));
	}

	private void JOICDPOKECI(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(NBMJEBCMLGK));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	public bool CGCAHFDCOED(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.HasBeenChopped())
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Road && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Mine)
		{
			return false;
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	private void EKOCMBJDGGC(int JIIGOACEIKL)
	{
		MDLDPLCDEMA(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(EEBNGAGPFCH));
	}

	private void FNBJEDMPDHG(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	private void LNBLHKJPDIL(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void HAKLNGMPFAA(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	public bool NJDINEKAKCN(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.KNMEPGLDLDH())
		{
			return false;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River) && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != ~(Location.Camp | Location.Quarry | Location.Farm))
		{
			return false;
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			return !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).KNFEPKBIHND();
		}
		return false;
	}

	private void BDIPCKNDLDP(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	public bool EIKKNMKOHHF(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.HasBeenChopped())
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.Camp && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Camp | Location.Quarry | Location.Farm))
		{
			return true;
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return true;
	}

	private Rock KIIGIILHLHH(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void EEBNGAGPFCH(int JIIGOACEIKL)
	{
		HPFCEDGAFCH(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)LPNELFNCDMC(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(HMFIJDJKCDK));
	}

	private void CJGFCLCJMFG(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	public bool APBKEBDKICC(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.JIANMIFHKID())
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.Road && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != ~(Location.Road | Location.Farm))
		{
			return false;
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return false;
	}

	private Rock BGJIHGHAGNO(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void KCCEDJAIIJE(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	private void EBAGKGCOKLH(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	private void KOIMGAIDNBP(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	[SpecialName]
	private Ax OCEGLNFPBLF()
	{
		return item as Ax;
	}

	private void GFANHBFKGFB(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	[SpecialName]
	private Ax HJKGFMEAPIM()
	{
		return item as Ax;
	}

	private void HMFIJDJKCDK(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(HMFIJDJKCDK));
	}

	private void KOOGMMCJAFH(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(NBMJEBCMLGK));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	public AxInstance(AxInstance MCMGHPBIJDE)
		: base(MCMGHPBIJDE)
	{
	}

	[SpecialName]
	private Ax MKHNBNGCAPF()
	{
		return item as Ax;
	}

	private void NNPEECPLPPK(int JIIGOACEIKL)
	{
		HNJEDEJNPNL(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)OMAPDOLLKGA());
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(KKBENHDODCH));
	}

	private bool OEIOCMLFILK(int JIIGOACEIKL)
	{
		return GIOHBNPIOHF;
	}

	private void JPKPCGNMFHG(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(JOICDPOKECI));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	private Tree IAGHOJNHIPG(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private void CNLLIJMNJFF(int JIIGOACEIKL)
	{
		OOJEMLIJNHM(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(CNLLIJMNJFF));
	}

	public AxInstance(Item MEMGMDOCBOJ)
		: base(MEMGMDOCBOJ)
	{
	}

	private void CGAKDEKLLPJ(int JIIGOACEIKL)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		Tree tree = DHFPKFLOKGO(JIIGOACEIKL);
		if ((Object)(object)tree != (Object)null)
		{
			if (base.IGCPCEKPHCI >= tree.toolLevelRequired)
			{
				tree.ABLGPOMJFMO(JIIGOACEIKL, OCEGLNFPBLF().workDonePerHit);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).BIBLHGFCINF("RochelleProgress");
				MultiAudioManager.PlayAudioObject(FIJFHEGFFPG().axeFailSound, ((Component)tree).transform.position);
				OPMNPIIEOOK(JIIGOACEIKL, KLMDEPBMACA: true);
			}
		}
		else
		{
			Rock rock = NNCMCODIFNP(JIIGOACEIKL);
			if ((Object)(object)rock != (Object)null)
			{
				if (LCEMDNCKAMJ() >= rock.toolLevelRequired || (OCLFIAMHFAC() == 7 && rock.toolLevelRequired == 5))
				{
					rock.JABEGNMAKGG(JIIGOACEIKL, OLLAPFJFHAA().workDonePerHit, CDPAMNIPPEC: false);
				}
				else
				{
					PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("in");
					MultiAudioManager.PlayAudioObject(MKMFOGNLNCP().axeFailSound, ((Component)rock).transform.position);
					HABLDICIFPN(JIIGOACEIKL, KLMDEPBMACA: true);
				}
			}
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(IECIOMPBHLP));
	}

	private void EBJPMMLAAHG(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	private Tree NLBGKIMAEOE(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private Rock BOALANBIDIG(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void AFIFMNKIEPG(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private bool IPPHPBMAHCG(int JIIGOACEIKL)
	{
		return GIOHBNPIOHF;
	}

	private void IPFNKAKBAKE(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	private void HODFDEMGFJE(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	private void HFODJAFMJCO(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(BKCJHCEMIBG));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	[SpecialName]
	private Ax LGOHEDOHOKG()
	{
		return item as Ax;
	}

	private void CPMFEHHCCKA(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	public bool LBACFNNJKDK(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.EBKCJCLNCHB())
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River) && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != ~(Location.Road | Location.Quarry | Location.Farm))
		{
			return false;
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public bool PFIGPCBIKGM(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.IJDMGANEEEE())
		{
			return true;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != 0 && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Quarry | Location.Farm | Location.FarmShop))
		{
			return false;
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF())
		{
			return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return false;
	}

	private void ADMDFPKEDDC(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	[SpecialName]
	private Ax PFNLFFIOJEI()
	{
		return item as Ax;
	}

	private void LHECMGAHHIP(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	public bool HCHEMKHFMFE(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.HasBeenChopped())
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.River) && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != ~(Location.Tavern | Location.Road | Location.Camp | Location.FarmShop))
		{
			return false;
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IBEFDKHFBFM();
		}
		return false;
	}

	public bool OPIGILIHNMA(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.JIANMIFHKID())
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.River) && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.Quarry | Location.BarnInterior))
		{
			return true;
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return true;
	}

	private void FBOGICAIDHF(int JIIGOACEIKL)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		Tree tree = KINOEAHDJOG(JIIGOACEIKL);
		if ((Object)(object)tree != (Object)null)
		{
			if (OGCEOPDOEAB() >= tree.toolLevelRequired)
			{
				tree.ABLGPOMJFMO(JIIGOACEIKL, HJKGFMEAPIM().workDonePerHit);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBarkWithI2("Items/item_description_663");
				MultiAudioManager.PlayAudioObject(FGKBPKLEGDF().axeFailSound, ((Component)tree).transform.position);
				GFANHBFKGFB(JIIGOACEIKL, KLMDEPBMACA: false);
			}
		}
		else
		{
			Rock rock = KIIGIILHLHH(JIIGOACEIKL);
			if ((Object)(object)rock != (Object)null)
			{
				if (base.IGCPCEKPHCI >= rock.toolLevelRequired || (base.IGCPCEKPHCI == 8 && rock.toolLevelRequired == 8))
				{
					rock.Chop(JIIGOACEIKL, OLLAPFJFHAA().workDonePerHit, CDPAMNIPPEC: false);
				}
				else
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBarkWithI2("Bouncer/");
					MultiAudioManager.PlayAudioObject(OCEGLNFPBLF().axeFailSound, ((Component)rock).transform.position);
					IKLAPMLADAK(JIIGOACEIKL, KLMDEPBMACA: true);
				}
			}
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(IECIOMPBHLP));
	}

	private void IECIOMPBHLP(int JIIGOACEIKL)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		Tree tree = IAGHOJNHIPG(JIIGOACEIKL);
		if ((Object)(object)tree != (Object)null)
		{
			if (base.IGCPCEKPHCI >= tree.toolLevelRequired)
			{
				tree.CutAction(JIIGOACEIKL, KEKHBAPPAHI.workDonePerHit);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("Ax Level Low");
				MultiAudioManager.PlayAudioObject(KEKHBAPPAHI.axeFailSound, ((Component)tree).transform.position);
				BGILMHKGJIO(JIIGOACEIKL, KLMDEPBMACA: true);
			}
		}
		else
		{
			Rock rock = NGHCHMCHAAO(JIIGOACEIKL);
			if ((Object)(object)rock != (Object)null)
			{
				if (base.IGCPCEKPHCI >= rock.toolLevelRequired || (base.IGCPCEKPHCI == 3 && rock.toolLevelRequired == 4))
				{
					rock.Chop(JIIGOACEIKL, KEKHBAPPAHI.workDonePerHit);
				}
				else
				{
					PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("Ax Level Low");
					MultiAudioManager.PlayAudioObject(KEKHBAPPAHI.axeFailSound, ((Component)rock).transform.position);
					BGILMHKGJIO(JIIGOACEIKL, KLMDEPBMACA: true);
				}
			}
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(IECIOMPBHLP));
	}

	public bool DOCOCNBAECP(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.EBKCJCLNCHB())
		{
			return false;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road) && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			return true;
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return true;
	}

	public bool CPFPOELAPLC(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.EBKCJCLNCHB())
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River) && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != ~(Location.Tavern | Location.Camp))
		{
			return true;
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			return !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return true;
	}

	private Tree BEKJHDHALFG(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private Tree MJIEJKKOCFE(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private void ABHAEKMJFKD(int JIIGOACEIKL)
	{
		HPFCEDGAFCH(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(EKOCMBJDGGC));
	}

	private Rock NGHCHMCHAAO(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void KEKHLGLFBNA(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	private void MJJBNLPDMIM(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(CNLLIJMNJFF));
	}

	private void HDJKAKOCNEC(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(ACGHCEMFOKB));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	private Tree BPPOFOEJKNL(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private void FFFPFACELNK(int JIIGOACEIKL)
	{
		HKACPJAFFGN(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)BLIKNGGCLID());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(ABHAEKMJFKD));
	}

	private void DPDCDJFACLL(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	private void HGLIHBJEGJF(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	private void JHICDLBCCDF(int JIIGOACEIKL)
	{
		HPFCEDGAFCH(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)LPNELFNCDMC());
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(PAKLPLDCBBO));
	}

	private Rock NFAGNJHFAJE(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private Tree BGDDHCLAILB(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private void BDIBMKIPHGJ(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private Tree KINOEAHDJOG(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private bool COGNFIGBCFN(int JIIGOACEIKL)
	{
		return GIOHBNPIOHF;
	}

	private Rock NNCMCODIFNP(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void PMDFMGOMKLD(int JIIGOACEIKL)
	{
		HKACPJAFFGN(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(KDPAMDEKNHI));
	}

	private Rock EHLIHIDEBAG(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void DFIIDHDDMCA(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	public bool BDFDJDBDFNF(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.IJDMGANEEEE())
		{
			return false;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River) && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != ~(Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.FarmShop))
		{
			return false;
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return false;
	}

	private void AMANGELKFAP(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	public bool FKAEJAMCIHF(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.EBKCJCLNCHB())
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River) && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != ~(Location.Tavern | Location.River | Location.BarnInterior | Location.FarmShop))
		{
			return false;
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			return !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).GABNNLJOMHI();
		}
		return true;
	}

	public bool ADNCNOPPBLL(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return false;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.HasBeenChopped())
		{
			return true;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Road | Location.River) && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.Farm | Location.FarmShop))
		{
			return true;
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF())
		{
			return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return false;
	}

	[SpecialName]
	private Ax LENHABBBOAL()
	{
		return item as Ax;
	}

	public bool NFECLEKPBDN(int JIIGOACEIKL, Tree FFBBBJKKFGB, Rock HICBJDGPMDM)
	{
		if ((Object)(object)FFBBBJKKFGB == (Object)null && (Object)(object)HICBJDGPMDM == (Object)null)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && !FFBBBJKKFGB.canUseAx)
		{
			return true;
		}
		if ((Object)(object)FFBBBJKKFGB != (Object)null && FFBBBJKKFGB.KNMEPGLDLDH())
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.River) && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry))
		{
			return true;
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return true;
	}

	private void EJJLAKMBIOL(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(EJJLAKMBIOL));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	private void IIKJIMKFODL(int JIIGOACEIKL)
	{
		PGBKOLMPPHF(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)LPNELFNCDMC(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(PAKLPLDCBBO));
	}

	private void NEMENAFKGPA(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	[SpecialName]
	private Ax FGKBPKLEGDF()
	{
		return item as Ax;
	}

	private Tree DHFPKFLOKGO(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private void KNOLKFEPCBJ(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	private bool IPCAOOHDFEE(int JIIGOACEIKL)
	{
		return GIOHBNPIOHF;
	}

	[SpecialName]
	private Ax MKMFOGNLNCP()
	{
		return item as Ax;
	}

	[SpecialName]
	private Ax BJJABIMNLLB()
	{
		return item as Ax;
	}

	private bool CBLPFDNGPDK(int JIIGOACEIKL)
	{
		return GIOHBNPIOHF;
	}

	private void DOGIMOPBJDP(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	private Rock FJJLKPDLMDM(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private bool HOJCLGPAOJC(int JIIGOACEIKL)
	{
		return GIOHBNPIOHF;
	}

	private void IKLAPMLADAK(int JIIGOACEIKL, bool KLMDEPBMACA)
	{
		GIOHBNPIOHF = KLMDEPBMACA;
	}

	private void NBMJEBCMLGK(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(GAEOPFJBLMN));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	private void ELBCKLHLIOC(int JIIGOACEIKL)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		Tree tree = DHFPKFLOKGO(JIIGOACEIKL);
		if ((Object)(object)tree != (Object)null)
		{
			if (LCEMDNCKAMJ() >= tree.toolLevelRequired)
			{
				tree.CutAction(JIIGOACEIKL, BJJABIMNLLB().workDonePerHit);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).BIBLHGFCINF("Interact");
				MultiAudioManager.PlayAudioObject(MKMFOGNLNCP().axeFailSound, ((Component)tree).transform.position);
				OOHKCNHNJDK(JIIGOACEIKL, KLMDEPBMACA: false);
			}
		}
		else
		{
			Rock rock = NGHCHMCHAAO(JIIGOACEIKL);
			if ((Object)(object)rock != (Object)null)
			{
				if (base.IGCPCEKPHCI >= rock.toolLevelRequired || (DAEOCFODOML() == 3 && rock.toolLevelRequired == 0))
				{
					rock.GCBHFEJOBEH(JIIGOACEIKL, HJKGFMEAPIM().workDonePerHit, CDPAMNIPPEC: false);
				}
				else
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBarkWithI2(". New Position: ");
					MultiAudioManager.PlayAudioObject(FIJFHEGFFPG().axeFailSound, ((Component)rock).transform.position);
					DOGIMOPBJDP(JIIGOACEIKL, KLMDEPBMACA: true);
				}
			}
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(CGAKDEKLLPJ));
	}
}
