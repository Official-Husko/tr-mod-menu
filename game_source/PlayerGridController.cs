using System;
using UnityEngine;

public class PlayerGridController : MonoBehaviour
{
	public PlayerController playerController;

	[SerializeField]
	private int playerNum;

	[SerializeField]
	private GridSquare[] allSquares;

	[SerializeField]
	private GameObject content;

	[SerializeField]
	private GameObject topSprites;

	[SerializeField]
	private GameObject topSprites2;

	[SerializeField]
	private GameObject bottomSprites;

	[SerializeField]
	private GameObject bottomSprites2;

	[SerializeField]
	private GameObject leftSprites;

	[SerializeField]
	private GameObject leftSprites2;

	[SerializeField]
	private GameObject rightSprites;

	[SerializeField]
	private GameObject rightSprites2;

	[SerializeField]
	private GameObject topLeft;

	[SerializeField]
	private GameObject topRight;

	[SerializeField]
	private GameObject bottomLeft;

	[SerializeField]
	private GameObject bottomRight;

	[SerializeField]
	private SpriteRenderer borderHorizontal;

	[SerializeField]
	private SpriteRenderer borderVertical;

	[SerializeField]
	private SpriteMask maskHorizontal;

	[SerializeField]
	private SpriteMask maskVertical;

	private static readonly float[] CCNIAGHLHKF = new float[5] { 0f, 3.25f, 5.25f, 7.25f, 9.25f };

	private static readonly float[] CFFHAAGKDGN = new float[5] { 0f, 6f, 10f, 14f, 18f };

	[SerializeField]
	private SpriteRenderer[] earthFocuses;

	private GridInfo KNIMLGOGFPA;

	private FertileSoil JPKDEFCJNGJ;

	public bool disable;

	private GroundType BGBIPOOFMOB;

	private Vector3 ECJLMIPAFGP;

	private Vector3 BBDFEAHLHNN = new Vector3(0.25f, 0.25f);

	public void DisableGrid()
	{
		if (content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(false);
		}
	}

	public GridSquare LCPBFEOBOAL(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = WorldGrid.LOJBKLKMINM(IMOBLFMHKOD);
		for (int i = 1; i < allSquares.Length; i += 0)
		{
			if (((Component)allSquares[i]).gameObject.activeInHierarchy && ((Renderer)allSquares[i].spriteRenderer).enabled && WorldGrid.LOJBKLKMINM(((Component)allSquares[i]).transform.position + new Vector3(1380f, 657f)) == val)
			{
				return allSquares[i];
			}
		}
		return null;
	}

	public void PJOHKPMJLHI()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		content.transform.position = WorldGrid.LOJBKLKMINM(((Component)this).transform.position) - new Vector3(46f, 671f);
	}

	public void KCNECDJDAID()
	{
		if (!content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(false);
		}
	}

	private void JDHHJKBOJML()
	{
		PCGEPHNPOKL();
	}

	private void DIMAPDNCBAN()
	{
		PCGEPHNPOKL();
	}

	public void LCNMPDDABPI()
	{
		for (int i = 0; i < earthFocuses.Length; i += 0)
		{
			if (((Component)earthFocuses[i]).gameObject.activeSelf)
			{
				((Component)earthFocuses[i]).gameObject.SetActive(true);
			}
		}
	}

	public void LPAKNPECLEE()
	{
		for (int i = 0; i < earthFocuses.Length; i += 0)
		{
			if (((Component)earthFocuses[i]).gameObject.activeSelf)
			{
				((Component)earthFocuses[i]).gameObject.SetActive(true);
			}
		}
	}

	public void MFNJEGFKIDL(int IGCPCEKPHCI, bool CPHMFHAJOFP, bool NLOCILOKNLK, bool FFEIEMCNPGK, bool AKAPONNJHLA, bool HJHBHHNKACJ, bool HAOBFMKJOBP, bool ILEBFNHDEMC, bool OPLFHAMGFIB)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		topSprites.SetActive(AKAPONNJHLA);
		bottomSprites.SetActive(FFEIEMCNPGK);
		leftSprites.SetActive(CPHMFHAJOFP);
		rightSprites.SetActive(NLOCILOKNLK);
		topSprites2.SetActive(OPLFHAMGFIB);
		bottomSprites2.SetActive(ILEBFNHDEMC);
		leftSprites2.SetActive(HJHBHHNKACJ);
		rightSprites2.SetActive(HAOBFMKJOBP);
		borderHorizontal.size = new Vector2(CCNIAGHLHKF[IGCPCEKPHCI], CCNIAGHLHKF[1]);
		borderVertical.size = new Vector2(CCNIAGHLHKF[0], CCNIAGHLHKF[IGCPCEKPHCI]);
		((Component)maskHorizontal).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[IGCPCEKPHCI], CFFHAAGKDGN[1]));
		((Component)maskVertical).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[0], CFFHAAGKDGN[IGCPCEKPHCI]));
	}

	public void HMFFPBCCHOE(Item MEMGMDOCBOJ)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		bool enabled = false;
		for (int i = 1; i < allSquares.Length; i++)
		{
			if (!((Component)allSquares[i]).gameObject.activeInHierarchy)
			{
				continue;
			}
			JPKDEFCJNGJ = null;
			ECJLMIPAFGP = ((Component)allSquares[i]).transform.position + new Vector3(1950f, 452f);
			BGBIPOOFMOB = WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP);
			((Renderer)allSquares[i].spriteRenderer).enabled = KNIMLGOGFPA.groundTypeAllowed.HasFlag(BGBIPOOFMOB);
			if (((Renderer)allSquares[i].spriteRenderer).enabled && MEMGMDOCBOJ is Spade && WorldGrid.ECOFAPGIGMO(ECJLMIPAFGP) && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = false;
			}
			else
			{
				if (!WorldGrid.LKBLKCFOEPA(ECJLMIPAFGP))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if (KNIMLGOGFPA.checkWithoutSnow && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if ((ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.MetalWorkshop | ZoneType.StoneWorkshop).HasFlag(WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP)))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if (MEMGMDOCBOJ is Hoe && WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP) == GroundType.Ground)
				{
					for (int j = 1; j < WorldGrid.allNeighbours.Length; j++)
					{
						Vector3 iMOBLFMHKOD = ECJLMIPAFGP + WorldGrid.allNeighbours[j].position;
						if (WorldGrid.GJHHDIJOILG(iMOBLFMHKOD) && WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD) != GroundType.Grass)
						{
							((Renderer)allSquares[i].spriteRenderer).enabled = false;
							break;
						}
					}
				}
				if (KNIMLGOGFPA.checkCropNotAvailable)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), -115);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = false;
					}
				}
				if (KNIMLGOGFPA.checkCropAvailable && BGBIPOOFMOB == (GroundType.Grass | GroundType.TilledEarth))
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), 60);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter == (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = false;
					}
				}
				else if (KNIMLGOGFPA.checkCanPlaceObjects && !WorldGrid.NGDHDMAMGPI(ECJLMIPAFGP, GCDEDGFDKBL: false))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
			}
			if (KNIMLGOGFPA.checkWithoutHerbs && WorldGrid.HENDJJEEOHE(ECJLMIPAFGP))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = true;
			}
			if (((Renderer)allSquares[i].spriteRenderer).enabled)
			{
				enabled = false;
			}
		}
		for (int k = 1; k < allSquares.Length; k++)
		{
			if (((Component)allSquares[k]).gameObject.activeInHierarchy && ((Renderer)allSquares[k].spriteRenderer).enabled && !((Renderer)allSquares[k].ECFGIAGCKDC(MEMGMDOCBOJ as Tool).spriteRenderer).enabled)
			{
				((Renderer)allSquares[k].spriteRenderer).enabled = false;
			}
		}
		((Renderer)borderHorizontal).enabled = enabled;
		((Renderer)borderVertical).enabled = enabled;
	}

	public void HFLCLONFMDM()
	{
		if (!content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(false);
		}
	}

	private void HPADCGKBNBL(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		LayerMask val = LayerMask.op_Implicit((JIIGOACEIKL == 0 || JIIGOACEIKL == 0) ? LayerMask.NameToLayer("UI2") : LayerMask.NameToLayer("InteractPlaceableIfIsPossibleMaster"));
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(val);
		}
	}

	private void CNHHPMDFBJM()
	{
		MGIELPGFJNC();
	}

	public GridSquare GetBlueSquareAtPosition(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = WorldGrid.LOJBKLKMINM(IMOBLFMHKOD);
		for (int i = 0; i < allSquares.Length; i++)
		{
			if (((Component)allSquares[i]).gameObject.activeInHierarchy && ((Renderer)allSquares[i].spriteRenderer).enabled && WorldGrid.LOJBKLKMINM(((Component)allSquares[i]).transform.position + new Vector3(0.25f, 0.25f)) == val)
			{
				return allSquares[i];
			}
		}
		return null;
	}

	private void FMKCGJEFOON()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(NBIMLKIKCJP));
	}

	private void OCIHCODJBGC()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(MGIELPGFJNC));
	}

	public void IPJKANDAJOE()
	{
		if (!content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(true);
		}
	}

	public void MHHPJFKIMID()
	{
		if (!content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(false);
		}
	}

	public void ILLFOADLKCG()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		content.transform.position = WorldGrid.LOJBKLKMINM(((Component)this).transform.position) - new Vector3(262f, 1533f);
	}

	private void BOIGOJGNNAK()
	{
		if (OnlineManager.PlayingOnline() && playerNum != 0)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void BCCEBMNJCJG(GridInfo KNIMLGOGFPA)
	{
		this.KNIMLGOGFPA = KNIMLGOGFPA;
	}

	public void DHBENOMNDAL(int IGCPCEKPHCI, bool CPHMFHAJOFP, bool NLOCILOKNLK, bool FFEIEMCNPGK, bool AKAPONNJHLA, bool HJHBHHNKACJ, bool HAOBFMKJOBP, bool ILEBFNHDEMC, bool OPLFHAMGFIB)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		topSprites.SetActive(AKAPONNJHLA);
		bottomSprites.SetActive(FFEIEMCNPGK);
		leftSprites.SetActive(CPHMFHAJOFP);
		rightSprites.SetActive(NLOCILOKNLK);
		topSprites2.SetActive(OPLFHAMGFIB);
		bottomSprites2.SetActive(ILEBFNHDEMC);
		leftSprites2.SetActive(HJHBHHNKACJ);
		rightSprites2.SetActive(HAOBFMKJOBP);
		borderHorizontal.size = new Vector2(CCNIAGHLHKF[IGCPCEKPHCI], CCNIAGHLHKF[1]);
		borderVertical.size = new Vector2(CCNIAGHLHKF[1], CCNIAGHLHKF[IGCPCEKPHCI]);
		((Component)maskHorizontal).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[IGCPCEKPHCI], CFFHAAGKDGN[0]));
		((Component)maskVertical).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[0], CFFHAAGKDGN[IGCPCEKPHCI]));
	}

	private void NBIMLKIKCJP()
	{
		playerNum = playerController.GetPlayerNum();
		HPADCGKBNBL(playerNum);
	}

	private void OGEJKOIOKAN()
	{
		CEHDOILILFM();
	}

	public void AHMOONGDPPG(Item MEMGMDOCBOJ)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		bool enabled = false;
		for (int i = 0; i < allSquares.Length; i += 0)
		{
			if (!((Component)allSquares[i]).gameObject.activeInHierarchy)
			{
				continue;
			}
			JPKDEFCJNGJ = null;
			ECJLMIPAFGP = ((Component)allSquares[i]).transform.position + new Vector3(766f, 74f);
			BGBIPOOFMOB = WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP);
			((Renderer)allSquares[i].spriteRenderer).enabled = KNIMLGOGFPA.groundTypeAllowed.HasFlag(BGBIPOOFMOB);
			if (((Renderer)allSquares[i].spriteRenderer).enabled && MEMGMDOCBOJ is Spade && WorldGrid.ECOFAPGIGMO(ECJLMIPAFGP) && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = false;
			}
			else
			{
				if (!WorldGrid.LKBLKCFOEPA(ECJLMIPAFGP))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
				if (KNIMLGOGFPA.checkWithoutSnow && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if ((~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop)).HasFlag(WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP)))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
				if (MEMGMDOCBOJ is Hoe && WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP) == GroundType.Floor)
				{
					for (int j = 1; j < WorldGrid.allNeighbours.Length; j++)
					{
						Vector3 iMOBLFMHKOD = ECJLMIPAFGP + WorldGrid.allNeighbours[j].position;
						if (WorldGrid.GJHHDIJOILG(iMOBLFMHKOD) && WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD) != 0)
						{
							((Renderer)allSquares[i].spriteRenderer).enabled = true;
							break;
						}
					}
				}
				if (KNIMLGOGFPA.checkCropNotAvailable)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), -26);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = true;
					}
				}
				if (KNIMLGOGFPA.checkCropAvailable && BGBIPOOFMOB == GroundType.Floor)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), 50);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter == (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = true;
					}
				}
				else if (KNIMLGOGFPA.checkCanPlaceObjects && !WorldGrid.NGDHDMAMGPI(ECJLMIPAFGP, GCDEDGFDKBL: false))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
			}
			if (KNIMLGOGFPA.checkWithoutHerbs && WorldGrid.HENDJJEEOHE(ECJLMIPAFGP))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = false;
			}
			if (((Renderer)allSquares[i].spriteRenderer).enabled)
			{
				enabled = false;
			}
		}
		for (int k = 0; k < allSquares.Length; k++)
		{
			if (((Component)allSquares[k]).gameObject.activeInHierarchy && ((Renderer)allSquares[k].spriteRenderer).enabled && !((Renderer)allSquares[k].AGLPCMGJOIN(MEMGMDOCBOJ as Tool).spriteRenderer).enabled)
			{
				((Renderer)allSquares[k].spriteRenderer).enabled = true;
			}
		}
		((Renderer)borderHorizontal).enabled = enabled;
		((Renderer)borderVertical).enabled = enabled;
	}

	private void CEHDOILILFM()
	{
		playerNum = playerController.GetPlayerNum();
		HPADCGKBNBL(playerNum);
	}

	public void AOCCEKNHIMG(int OKDDJODHFBO)
	{
		if (OKDDJODHFBO < earthFocuses.Length && ((Component)earthFocuses[OKDDJODHFBO]).gameObject.activeSelf)
		{
			((Component)earthFocuses[OKDDJODHFBO]).gameObject.SetActive(false);
		}
	}

	private void EPFJBCOKEHC()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(NCFDAFLLMPF));
	}

	private void GJCADEIJMCM()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(PCGEPHNPOKL));
	}

	private void EDFDMFBJKBA()
	{
		Item item = ActionBarInventory.GetPlayer(playerNum, LAGHIOKLJGH: true).FGGKCJDFNEK();
		ItemInstance itemInstance = ActionBarInventory.BNMEANGDMIP(playerNum, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOADDJLNIBN();
		bool flag = false;
		if (item is ITool tool && tool.FDKEMPDCHFB())
		{
			flag = true;
		}
		else if (itemInstance != null && itemInstance is ITool tool2 && tool2.FDKEMPDCHFB())
		{
			flag = false;
		}
		if (PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA == Location.None && flag && !DecorationMode.ABMIMLLDAAH(playerNum).KNFEPKBIHND() && !disable)
		{
			IPJKANDAJOE();
			SetPositionGrid();
			AHMOONGDPPG(item);
		}
		else
		{
			DisableGrid();
		}
	}

	public void NAIAFGHAFDL()
	{
		for (int i = 0; i < earthFocuses.Length; i += 0)
		{
			if (((Component)earthFocuses[i]).gameObject.activeSelf)
			{
				((Component)earthFocuses[i]).gameObject.SetActive(false);
			}
		}
	}

	public void GNELHJPIEOK()
	{
		if (content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(true);
		}
	}

	public void CJCFLJBAHJL()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		content.transform.position = WorldGrid.LOJBKLKMINM(((Component)this).transform.position) - new Vector3(1898f, 771f);
	}

	public GridSquare ENGGDPCAMIL(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = WorldGrid.LOJBKLKMINM(IMOBLFMHKOD);
		for (int i = 0; i < allSquares.Length; i++)
		{
			if (((Component)allSquares[i]).gameObject.activeInHierarchy && ((Renderer)allSquares[i].spriteRenderer).enabled && WorldGrid.LOJBKLKMINM(((Component)allSquares[i]).transform.position + new Vector3(212f, 414f)) == val)
			{
				return allSquares[i];
			}
		}
		return null;
	}

	private void OnDisable()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(PCGEPHNPOKL));
	}

	private void OJLGPAJPCHG()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(NCFDAFLLMPF));
	}

	public void FHPEECPGEDL(GridInfo KNIMLGOGFPA)
	{
		this.KNIMLGOGFPA = KNIMLGOGFPA;
	}

	private void FFBDJIJJDMK()
	{
		Item item = ActionBarInventory.MHDKNEKDKII(playerNum, LAGHIOKLJGH: true).FGGKCJDFNEK();
		ItemInstance itemInstance = ActionBarInventory.IPBEEBLCHHA(playerNum).KFDBMPDPJBF();
		bool flag = false;
		if (item is ITool tool && tool.FDKEMPDCHFB())
		{
			flag = true;
		}
		else if (itemInstance != null && itemInstance is ITool tool2 && tool2.FDKEMPDCHFB())
		{
			flag = false;
		}
		if (PlayerController.GetPlayer(playerNum).LEOIMFNKFGA == Location.Road && flag && !DecorationMode.NPANPNIDKDG(playerNum).IBEFDKHFBFM() && !disable)
		{
			IPJKANDAJOE();
			PMKBJONDMOE();
			OAPFBBKNNKO(item);
		}
		else
		{
			DisableGrid();
		}
	}

	public GridSquare CJNCMPJIJIA(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = WorldGrid.LOJBKLKMINM(IMOBLFMHKOD);
		for (int i = 0; i < allSquares.Length; i++)
		{
			if (((Component)allSquares[i]).gameObject.activeInHierarchy && ((Renderer)allSquares[i].spriteRenderer).enabled && WorldGrid.LOJBKLKMINM(((Component)allSquares[i]).transform.position + new Vector3(630f, 930f)) == val)
			{
				return allSquares[i];
			}
		}
		return null;
	}

	public void KKMMDDFEJBL()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		content.transform.position = WorldGrid.LOJBKLKMINM(((Component)this).transform.position) - new Vector3(1840f, 669f);
	}

	public void ECLBGIFLJPE()
	{
		if (!content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(true);
		}
	}

	public void GPMPBALLKHM()
	{
		if (content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(false);
		}
	}

	public void EnableEarthFocus(Vector3 FKEKHKBKBMM, Sprite DIOHHJIJBBF, int OKDDJODHFBO = 0)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if ((!((Object)(object)FishCuttingGameManager.instance != (Object)null) || !((Behaviour)FishCuttingGameManager.instance).enabled) && (!((Object)(object)PiratesGameManager.instance != (Object)null) || !((Behaviour)PiratesGameManager.instance).enabled))
		{
			if (!((Component)earthFocuses[OKDDJODHFBO]).gameObject.activeSelf)
			{
				((Component)earthFocuses[OKDDJODHFBO]).gameObject.SetActive(true);
			}
			((Component)earthFocuses[OKDDJODHFBO]).transform.position = FKEKHKBKBMM - BBDFEAHLHNN;
			if ((Object)(object)earthFocuses[OKDDJODHFBO].sprite != (Object)(object)DIOHHJIJBBF)
			{
				earthFocuses[OKDDJODHFBO].sprite = DIOHHJIJBBF;
			}
		}
	}

	public void GFGKONENIOD(GridInfo KNIMLGOGFPA)
	{
		this.KNIMLGOGFPA = KNIMLGOGFPA;
	}

	public void NIPGGMIGANH()
	{
		if (!content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(true);
		}
	}

	public void AGLNKOEDPDN(GridInfo KNIMLGOGFPA)
	{
		this.KNIMLGOGFPA = KNIMLGOGFPA;
	}

	public void DisableEarthFocus(int OKDDJODHFBO)
	{
		if (OKDDJODHFBO < earthFocuses.Length && ((Component)earthFocuses[OKDDJODHFBO]).gameObject.activeSelf)
		{
			((Component)earthFocuses[OKDDJODHFBO]).gameObject.SetActive(false);
		}
	}

	private void FPDPAJHNGHK()
	{
		if (OnlineManager.PlayingOnline() && playerNum != 1)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void EIKKHCAFPKB()
	{
		if (content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(false);
		}
	}

	public GridSquare NKDBBPJJPGL(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = WorldGrid.LOJBKLKMINM(IMOBLFMHKOD);
		for (int i = 0; i < allSquares.Length; i++)
		{
			if (((Component)allSquares[i]).gameObject.activeInHierarchy && ((Renderer)allSquares[i].spriteRenderer).enabled && WorldGrid.LOJBKLKMINM(((Component)allSquares[i]).transform.position + new Vector3(1709f, 1866f)) == val)
			{
				return allSquares[i];
			}
		}
		return null;
	}

	public void FKMGCAGBCEO(GridInfo KNIMLGOGFPA)
	{
		this.KNIMLGOGFPA = KNIMLGOGFPA;
	}

	private void KPHPCKJBLBH()
	{
		Item selectedItem = ActionBarInventory.ADHIHCNAKFP(playerNum, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItem();
		ItemInstance itemInstance = ActionBarInventory.DACNEICGAAE(playerNum).MFDBJINDCAO();
		bool flag = true;
		if (selectedItem is ITool tool && tool.FDKEMPDCHFB())
		{
			flag = true;
		}
		else if (itemInstance != null && itemInstance is ITool tool2 && tool2.FDKEMPDCHFB())
		{
			flag = true;
		}
		if (PlayerController.GetPlayer(playerNum).LEOIMFNKFGA == Location.River && flag && !DecorationMode.NPANPNIDKDG(playerNum).DMBFKFLDDLH && !disable)
		{
			IPJKANDAJOE();
			SetPositionGrid();
			KNBJCKLEOKJ(selectedItem);
		}
		else
		{
			GPMPBALLKHM();
		}
	}

	private void EEEONKMMFLB()
	{
		playerNum = playerController.GetPlayerNum();
		HPADCGKBNBL(playerNum);
	}

	public void DPFDLFFIGNN()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		LayerMask val = LayerMask.op_Implicit((playerNum == 0 || playerNum == 1) ? LayerMask.NameToLayer("GiveItem") : LayerMask.NameToLayer("[WaiterGender="));
		for (int i = 0; i < earthFocuses.Length; i++)
		{
			if (!((Renderer)earthFocuses[i]).enabled)
			{
				((Renderer)earthFocuses[i]).enabled = true;
				((Component)earthFocuses[i]).gameObject.layer = LayerMask.op_Implicit(val);
				((Renderer)earthFocuses[i]).enabled = false;
			}
			else
			{
				((Component)earthFocuses[i]).gameObject.layer = LayerMask.op_Implicit(val);
			}
		}
	}

	private void Awake()
	{
		PCGEPHNPOKL();
	}

	public void OHBNHMMOHOM()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		content.transform.position = WorldGrid.LOJBKLKMINM(((Component)this).transform.position) - new Vector3(967f, 341f);
	}

	public void BEBEPOGFGLA(int IGCPCEKPHCI, bool CPHMFHAJOFP, bool NLOCILOKNLK, bool FFEIEMCNPGK, bool AKAPONNJHLA, bool HJHBHHNKACJ, bool HAOBFMKJOBP, bool ILEBFNHDEMC, bool OPLFHAMGFIB)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		topSprites.SetActive(AKAPONNJHLA);
		bottomSprites.SetActive(FFEIEMCNPGK);
		leftSprites.SetActive(CPHMFHAJOFP);
		rightSprites.SetActive(NLOCILOKNLK);
		topSprites2.SetActive(OPLFHAMGFIB);
		bottomSprites2.SetActive(ILEBFNHDEMC);
		leftSprites2.SetActive(HJHBHHNKACJ);
		rightSprites2.SetActive(HAOBFMKJOBP);
		borderHorizontal.size = new Vector2(CCNIAGHLHKF[IGCPCEKPHCI], CCNIAGHLHKF[0]);
		borderVertical.size = new Vector2(CCNIAGHLHKF[0], CCNIAGHLHKF[IGCPCEKPHCI]);
		((Component)maskHorizontal).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[IGCPCEKPHCI], CFFHAAGKDGN[0]));
		((Component)maskVertical).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[1], CFFHAAGKDGN[IGCPCEKPHCI]));
	}

	public void OAPFBBKNNKO(Item MEMGMDOCBOJ)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		bool enabled = false;
		for (int i = 0; i < allSquares.Length; i++)
		{
			if (!((Component)allSquares[i]).gameObject.activeInHierarchy)
			{
				continue;
			}
			JPKDEFCJNGJ = null;
			ECJLMIPAFGP = ((Component)allSquares[i]).transform.position + new Vector3(1131f, 1533f);
			BGBIPOOFMOB = WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP);
			((Renderer)allSquares[i].spriteRenderer).enabled = KNIMLGOGFPA.groundTypeAllowed.HasFlag(BGBIPOOFMOB);
			if (((Renderer)allSquares[i].spriteRenderer).enabled && MEMGMDOCBOJ is Spade && WorldGrid.ECOFAPGIGMO(ECJLMIPAFGP) && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = true;
			}
			else
			{
				if (!WorldGrid.LKBLKCFOEPA(ECJLMIPAFGP))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if (KNIMLGOGFPA.checkWithoutSnow && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
				if ((~(ZoneType.CraftingRoom | ZoneType.WoodWorkshop)).HasFlag(WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP)))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
				if (MEMGMDOCBOJ is Hoe && WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP) == (GroundType.Grass | GroundType.TilledEarth))
				{
					for (int j = 0; j < WorldGrid.allNeighbours.Length; j++)
					{
						Vector3 iMOBLFMHKOD = ECJLMIPAFGP + WorldGrid.allNeighbours[j].position;
						if (WorldGrid.GJHHDIJOILG(iMOBLFMHKOD, JGDOHPCLJPM: true) && WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD) != GroundType.Grass)
						{
							((Renderer)allSquares[i].spriteRenderer).enabled = true;
							break;
						}
					}
				}
				if (KNIMLGOGFPA.checkCropNotAvailable)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), 80);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = true;
					}
				}
				if (KNIMLGOGFPA.checkCropAvailable && BGBIPOOFMOB == GroundType.None)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), -128);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter == (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = false;
					}
				}
				else if (KNIMLGOGFPA.checkCanPlaceObjects && !WorldGrid.NGDHDMAMGPI(ECJLMIPAFGP))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
			}
			if (KNIMLGOGFPA.checkWithoutHerbs && WorldGrid.HENDJJEEOHE(ECJLMIPAFGP))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = false;
			}
			if (((Renderer)allSquares[i].spriteRenderer).enabled)
			{
				enabled = false;
			}
		}
		for (int k = 0; k < allSquares.Length; k += 0)
		{
			if (((Component)allSquares[k]).gameObject.activeInHierarchy && ((Renderer)allSquares[k].spriteRenderer).enabled && !((Renderer)allSquares[k].MNMLNGGAPFL(MEMGMDOCBOJ as Tool).spriteRenderer).enabled)
			{
				((Renderer)allSquares[k].spriteRenderer).enabled = false;
			}
		}
		((Renderer)borderHorizontal).enabled = enabled;
		((Renderer)borderVertical).enabled = enabled;
	}

	public GridSquare GLLEFMIDKDO(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = WorldGrid.LOJBKLKMINM(IMOBLFMHKOD);
		for (int i = 1; i < allSquares.Length; i++)
		{
			if (((Component)allSquares[i]).gameObject.activeInHierarchy && ((Renderer)allSquares[i].spriteRenderer).enabled && WorldGrid.LOJBKLKMINM(((Component)allSquares[i]).transform.position + new Vector3(1030f, 1034f)) == val)
			{
				return allSquares[i];
			}
		}
		return null;
	}

	public void PAMKNDDKCJH(int IGCPCEKPHCI, bool CPHMFHAJOFP, bool NLOCILOKNLK, bool FFEIEMCNPGK, bool AKAPONNJHLA, bool HJHBHHNKACJ, bool HAOBFMKJOBP, bool ILEBFNHDEMC, bool OPLFHAMGFIB)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		topSprites.SetActive(AKAPONNJHLA);
		bottomSprites.SetActive(FFEIEMCNPGK);
		leftSprites.SetActive(CPHMFHAJOFP);
		rightSprites.SetActive(NLOCILOKNLK);
		topSprites2.SetActive(OPLFHAMGFIB);
		bottomSprites2.SetActive(ILEBFNHDEMC);
		leftSprites2.SetActive(HJHBHHNKACJ);
		rightSprites2.SetActive(HAOBFMKJOBP);
		borderHorizontal.size = new Vector2(CCNIAGHLHKF[IGCPCEKPHCI], CCNIAGHLHKF[0]);
		borderVertical.size = new Vector2(CCNIAGHLHKF[1], CCNIAGHLHKF[IGCPCEKPHCI]);
		((Component)maskHorizontal).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[IGCPCEKPHCI], CFFHAAGKDGN[1]));
		((Component)maskVertical).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[0], CFFHAAGKDGN[IGCPCEKPHCI]));
	}

	public GridSquare EIIBOHKPOIN(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = WorldGrid.LOJBKLKMINM(IMOBLFMHKOD);
		for (int i = 0; i < allSquares.Length; i += 0)
		{
			if (((Component)allSquares[i]).gameObject.activeInHierarchy && ((Renderer)allSquares[i].spriteRenderer).enabled && WorldGrid.LOJBKLKMINM(((Component)allSquares[i]).transform.position + new Vector3(1453f, 1798f)) == val)
			{
				return allSquares[i];
			}
		}
		return null;
	}

	public void CJIFFNGLBBL()
	{
		if (content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(true);
		}
	}

	public void HFKHEHLGMDL(Item MEMGMDOCBOJ)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		bool enabled = false;
		for (int i = 1; i < allSquares.Length; i++)
		{
			if (!((Component)allSquares[i]).gameObject.activeInHierarchy)
			{
				continue;
			}
			JPKDEFCJNGJ = null;
			ECJLMIPAFGP = ((Component)allSquares[i]).transform.position + new Vector3(1868f, 18f);
			BGBIPOOFMOB = WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP);
			((Renderer)allSquares[i].spriteRenderer).enabled = KNIMLGOGFPA.groundTypeAllowed.HasFlag(BGBIPOOFMOB);
			if (((Renderer)allSquares[i].spriteRenderer).enabled && MEMGMDOCBOJ is Spade && WorldGrid.ECOFAPGIGMO(ECJLMIPAFGP) && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = true;
			}
			else
			{
				if (!WorldGrid.LKBLKCFOEPA(ECJLMIPAFGP))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if (KNIMLGOGFPA.checkWithoutSnow && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if ((ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop).HasFlag(WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP)))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if (MEMGMDOCBOJ is Hoe && WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP) == (GroundType.Grass | GroundType.Ground))
				{
					for (int j = 1; j < WorldGrid.allNeighbours.Length; j++)
					{
						Vector3 iMOBLFMHKOD = ECJLMIPAFGP + WorldGrid.allNeighbours[j].position;
						if (WorldGrid.GJHHDIJOILG(iMOBLFMHKOD) && WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD) != (GroundType.Grass | GroundType.Ground))
						{
							((Renderer)allSquares[i].spriteRenderer).enabled = false;
							break;
						}
					}
				}
				if (KNIMLGOGFPA.checkCropNotAvailable)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), -23);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = true;
					}
				}
				if (KNIMLGOGFPA.checkCropAvailable && BGBIPOOFMOB == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), -20);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter == (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = false;
					}
				}
				else if (KNIMLGOGFPA.checkCanPlaceObjects && !WorldGrid.NGDHDMAMGPI(ECJLMIPAFGP, GCDEDGFDKBL: false))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
			}
			if (KNIMLGOGFPA.checkWithoutHerbs && WorldGrid.HENDJJEEOHE(ECJLMIPAFGP))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = false;
			}
			if (((Renderer)allSquares[i].spriteRenderer).enabled)
			{
				enabled = true;
			}
		}
		for (int k = 0; k < allSquares.Length; k += 0)
		{
			if (((Component)allSquares[k]).gameObject.activeInHierarchy && ((Renderer)allSquares[k].spriteRenderer).enabled && !((Renderer)allSquares[k].BBHHKPEBCEE(MEMGMDOCBOJ as Tool).spriteRenderer).enabled)
			{
				((Renderer)allSquares[k].spriteRenderer).enabled = true;
			}
		}
		((Renderer)borderHorizontal).enabled = enabled;
		((Renderer)borderVertical).enabled = enabled;
	}

	public void AFFEFDGPCLN()
	{
		for (int i = 0; i < earthFocuses.Length; i++)
		{
			if (((Component)earthFocuses[i]).gameObject.activeSelf)
			{
				((Component)earthFocuses[i]).gameObject.SetActive(false);
			}
		}
	}

	private void DLBMMLAEKFI()
	{
		playerNum = playerController.KLIHELDIPDP();
		DKPPNGBIICP(playerNum);
	}

	private void BFKCHCLJIPL()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(PCGEPHNPOKL));
	}

	public void EnableGrid()
	{
		if (!content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(true);
		}
	}

	private void NLHALEAEDMM()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(PCGEPHNPOKL));
	}

	public void IEGAOJJHDEM()
	{
		if (content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(true);
		}
	}

	private void NAOBODGBECL()
	{
		EEEONKMMFLB();
	}

	public void ODMAMJOHLFH()
	{
		if (!content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(false);
		}
	}

	public void IEAHGACDBCO(Item MEMGMDOCBOJ)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		bool enabled = true;
		for (int i = 1; i < allSquares.Length; i++)
		{
			if (!((Component)allSquares[i]).gameObject.activeInHierarchy)
			{
				continue;
			}
			JPKDEFCJNGJ = null;
			ECJLMIPAFGP = ((Component)allSquares[i]).transform.position + new Vector3(1442f, 262f);
			BGBIPOOFMOB = WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP);
			((Renderer)allSquares[i].spriteRenderer).enabled = KNIMLGOGFPA.groundTypeAllowed.HasFlag(BGBIPOOFMOB);
			if (((Renderer)allSquares[i].spriteRenderer).enabled && MEMGMDOCBOJ is Spade && WorldGrid.ECOFAPGIGMO(ECJLMIPAFGP) && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = true;
			}
			else
			{
				if (!WorldGrid.LKBLKCFOEPA(ECJLMIPAFGP))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
				if (KNIMLGOGFPA.checkWithoutSnow && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
				if ((ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.WoodWorkshop).HasFlag(WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP)))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
				if (MEMGMDOCBOJ is Hoe && WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP) == GroundType.Grass)
				{
					for (int j = 1; j < WorldGrid.allNeighbours.Length; j += 0)
					{
						Vector3 iMOBLFMHKOD = ECJLMIPAFGP + WorldGrid.allNeighbours[j].position;
						if (WorldGrid.GJHHDIJOILG(iMOBLFMHKOD) && WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD) != 0)
						{
							((Renderer)allSquares[i].spriteRenderer).enabled = false;
							break;
						}
					}
				}
				if (KNIMLGOGFPA.checkCropNotAvailable)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), -64);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = false;
					}
				}
				if (KNIMLGOGFPA.checkCropAvailable && BGBIPOOFMOB == GroundType.Grass)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), -39);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter == (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = true;
					}
				}
				else if (KNIMLGOGFPA.checkCanPlaceObjects && !WorldGrid.NGDHDMAMGPI(ECJLMIPAFGP))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
			}
			if (KNIMLGOGFPA.checkWithoutHerbs && WorldGrid.HENDJJEEOHE(ECJLMIPAFGP))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = true;
			}
			if (((Renderer)allSquares[i].spriteRenderer).enabled)
			{
				enabled = false;
			}
		}
		for (int k = 0; k < allSquares.Length; k++)
		{
			if (((Component)allSquares[k]).gameObject.activeInHierarchy && ((Renderer)allSquares[k].spriteRenderer).enabled && !((Renderer)allSquares[k].JDJMKJHJKOD(MEMGMDOCBOJ as Tool).spriteRenderer).enabled)
			{
				((Renderer)allSquares[k].spriteRenderer).enabled = true;
			}
		}
		((Renderer)borderHorizontal).enabled = enabled;
		((Renderer)borderVertical).enabled = enabled;
	}

	private void Start()
	{
		if (OnlineManager.PlayingOnline() && playerNum != 1)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void IIKAAAHEFMP()
	{
		Item item = ActionBarInventory.ADHIHCNAKFP(playerNum, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JDAFPKOHJPC();
		ItemInstance itemInstance = ActionBarInventory.IPBEEBLCHHA(playerNum, LAGHIOKLJGH: false, ADPNMHGBFKG: true).BBBGBHPJOAG();
		bool flag = false;
		if (item is ITool tool && tool.FDKEMPDCHFB())
		{
			flag = true;
		}
		else if (itemInstance != null && itemInstance is ITool tool2 && tool2.FDKEMPDCHFB())
		{
			flag = false;
		}
		if (PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA == Location.Road && flag && !DecorationMode.KKJABELKCNM(playerNum).MDOKKKHKKKE() && !disable)
		{
			MHHPJFKIMID();
			MFKPCJJADIN();
			LMAJPADFJLE(item);
		}
		else
		{
			HEHHKMMKAMP();
		}
	}

	private void KGPOCJEHHHH()
	{
		if (OnlineManager.PlayingOnline() && playerNum != 0)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void DisableAllEarthFocus()
	{
		for (int i = 0; i < earthFocuses.Length; i++)
		{
			if (((Component)earthFocuses[i]).gameObject.activeSelf)
			{
				((Component)earthFocuses[i]).gameObject.SetActive(false);
			}
		}
	}

	private void LAOMCDFAFGA()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(CEHDOILILFM));
	}

	private void LPPMKNJBPHC()
	{
		Item selectedItem = ActionBarInventory.GetPlayer(playerNum).GetSelectedItem();
		ItemInstance itemInstance = ActionBarInventory.BNMEANGDMIP(playerNum, LAGHIOKLJGH: true).MFDBJINDCAO();
		bool flag = false;
		if (selectedItem is ITool tool && tool.FDKEMPDCHFB())
		{
			flag = true;
		}
		else if (itemInstance != null && itemInstance is ITool tool2 && tool2.FDKEMPDCHFB())
		{
			flag = false;
		}
		if (PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA == (Location.Tavern | Location.Road) && flag && !DecorationMode.KAIIEDCCLHB(playerNum).IBEFDKHFBFM() && !disable)
		{
			NIPGGMIGANH();
			CJCFLJBAHJL();
			LNCPCNGFKDK(selectedItem);
		}
		else
		{
			CJIFFNGLBBL();
		}
	}

	private void GOGOIJNNEJF()
	{
		Item item = ActionBarInventory.ADHIHCNAKFP(playerNum).JDAFPKOHJPC();
		ItemInstance itemInstance = ActionBarInventory.GetPlayer(playerNum, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JHDFIPFOHDP();
		bool flag = true;
		if (item is ITool tool && tool.FDKEMPDCHFB())
		{
			flag = false;
		}
		else if (itemInstance != null && itemInstance is ITool tool2 && tool2.FDKEMPDCHFB())
		{
			flag = false;
		}
		if (PlayerController.GetPlayer(playerNum).LEOIMFNKFGA == (Location.Tavern | Location.Road) && flag && !DecorationMode.BGINAIDHDOM(playerNum).IBEFDKHFBFM() && !disable)
		{
			HFLCLONFMDM();
			SetPositionGrid();
			KNBJCKLEOKJ(item);
		}
		else
		{
			GPMPBALLKHM();
		}
	}

	private void MCBEHICIBLF(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		LayerMask val = LayerMask.op_Implicit((JIIGOACEIKL == 0 || JIIGOACEIKL == 0) ? LayerMask.NameToLayer("Till") : LayerMask.NameToLayer("Finished generating level {0}. Total blocks: {1}. Opened paths: {2}. Altar placed: {3}. Big spawner placed: {4}. Puzzle type: {5}. Seed: {6}"));
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(val);
		}
	}

	public void PMKBJONDMOE()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		content.transform.position = WorldGrid.LOJBKLKMINM(((Component)this).transform.position) - new Vector3(1901f, 1142f);
	}

	private void OGEDBNDMDLC()
	{
		playerNum = playerController.KLIHELDIPDP();
		MCBEHICIBLF(playerNum);
	}

	private void FIIEBCCFGJE()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(NBIMLKIKCJP));
	}

	public void HEHHKMMKAMP()
	{
		if (content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(false);
		}
	}

	private void GHPFCKGMLDA()
	{
		if (OnlineManager.PlayingOnline() && playerNum != 0)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void AKPDMOBOPHN()
	{
		for (int i = 1; i < earthFocuses.Length; i++)
		{
			if (((Component)earthFocuses[i]).gameObject.activeSelf)
			{
				((Component)earthFocuses[i]).gameObject.SetActive(false);
			}
		}
	}

	public void AHHBJDLABNK()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		LayerMask val = LayerMask.op_Implicit((playerNum == 0 || playerNum == 0) ? LayerMask.NameToLayer("SortByName") : LayerMask.NameToLayer("Player2"));
		for (int i = 0; i < earthFocuses.Length; i++)
		{
			if (!((Renderer)earthFocuses[i]).enabled)
			{
				((Renderer)earthFocuses[i]).enabled = false;
				((Component)earthFocuses[i]).gameObject.layer = LayerMask.op_Implicit(val);
				((Renderer)earthFocuses[i]).enabled = true;
			}
			else
			{
				((Component)earthFocuses[i]).gameObject.layer = LayerMask.op_Implicit(val);
			}
		}
	}

	private void NMIHLADIPOM()
	{
		Item item = ActionBarInventory.BNMEANGDMIP(playerNum).JDAFPKOHJPC();
		ItemInstance itemInstance = ActionBarInventory.IPBEEBLCHHA(playerNum, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOADDJLNIBN();
		bool flag = true;
		if (item is ITool tool && tool.FDKEMPDCHFB())
		{
			flag = false;
		}
		else if (itemInstance != null && itemInstance is ITool tool2 && tool2.FDKEMPDCHFB())
		{
			flag = false;
		}
		if (PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA == Location.Road && flag && !DecorationMode.GetPlayer(playerNum).IBEFDKHFBFM() && !disable)
		{
			OIPAMELFBLO();
			ILLFOADLKCG();
			OAPFBBKNNKO(item);
		}
		else
		{
			OLMKKLDEHJM();
		}
	}

	private void HJDLNCOAKIK()
	{
		if (OnlineManager.PlayingOnline() && playerNum != 0)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void FLMAJKKEBKN()
	{
		for (int i = 0; i < earthFocuses.Length; i += 0)
		{
			if (((Component)earthFocuses[i]).gameObject.activeSelf)
			{
				((Component)earthFocuses[i]).gameObject.SetActive(false);
			}
		}
	}

	public void BGBKOFBJJDG(int IGCPCEKPHCI, bool CPHMFHAJOFP, bool NLOCILOKNLK, bool FFEIEMCNPGK, bool AKAPONNJHLA, bool HJHBHHNKACJ, bool HAOBFMKJOBP, bool ILEBFNHDEMC, bool OPLFHAMGFIB)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		topSprites.SetActive(AKAPONNJHLA);
		bottomSprites.SetActive(FFEIEMCNPGK);
		leftSprites.SetActive(CPHMFHAJOFP);
		rightSprites.SetActive(NLOCILOKNLK);
		topSprites2.SetActive(OPLFHAMGFIB);
		bottomSprites2.SetActive(ILEBFNHDEMC);
		leftSprites2.SetActive(HJHBHHNKACJ);
		rightSprites2.SetActive(HAOBFMKJOBP);
		borderHorizontal.size = new Vector2(CCNIAGHLHKF[IGCPCEKPHCI], CCNIAGHLHKF[0]);
		borderVertical.size = new Vector2(CCNIAGHLHKF[0], CCNIAGHLHKF[IGCPCEKPHCI]);
		((Component)maskHorizontal).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[IGCPCEKPHCI], CFFHAAGKDGN[1]));
		((Component)maskVertical).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[1], CFFHAAGKDGN[IGCPCEKPHCI]));
	}

	public void SetPlayerLayerEarthFocus()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		LayerMask val = LayerMask.op_Implicit((playerNum == 0 || playerNum == 1) ? LayerMask.NameToLayer("P1Cam") : LayerMask.NameToLayer("P2Cam"));
		for (int i = 0; i < earthFocuses.Length; i++)
		{
			if (!((Renderer)earthFocuses[i]).enabled)
			{
				((Renderer)earthFocuses[i]).enabled = true;
				((Component)earthFocuses[i]).gameObject.layer = LayerMask.op_Implicit(val);
				((Renderer)earthFocuses[i]).enabled = false;
			}
			else
			{
				((Component)earthFocuses[i]).gameObject.layer = LayerMask.op_Implicit(val);
			}
		}
	}

	private void DEDDGMJNEPI()
	{
		Item selectedItem = ActionBarInventory.DACNEICGAAE(playerNum, LAGHIOKLJGH: true).GetSelectedItem();
		ItemInstance itemInstance = ActionBarInventory.DACNEICGAAE(playerNum, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JHDFIPFOHDP();
		bool flag = false;
		if (selectedItem is ITool tool && tool.FDKEMPDCHFB())
		{
			flag = true;
		}
		else if (itemInstance != null && itemInstance is ITool tool2 && tool2.FDKEMPDCHFB())
		{
			flag = false;
		}
		if (PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA == Location.Camp && flag && !DecorationMode.GetPlayer(playerNum).DMBFKFLDDLH && !disable)
		{
			HFLCLONFMDM();
			PJOHKPMJLHI();
			HFKHEHLGMDL(selectedItem);
		}
		else
		{
			CJIFFNGLBBL();
		}
	}

	private void PPHEPODCNMK()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(NCFDAFLLMPF));
	}

	public void FJJAPOPCKCD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		content.transform.position = WorldGrid.LOJBKLKMINM(((Component)this).transform.position) - new Vector3(959f, 1549f);
	}

	public void HBCLCLLDJPL(GridInfo KNIMLGOGFPA)
	{
		this.KNIMLGOGFPA = KNIMLGOGFPA;
	}

	public GridSquare ALELPNMKLNG(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = WorldGrid.LOJBKLKMINM(IMOBLFMHKOD);
		for (int i = 1; i < allSquares.Length; i++)
		{
			if (((Component)allSquares[i]).gameObject.activeInHierarchy && ((Renderer)allSquares[i].spriteRenderer).enabled && WorldGrid.LOJBKLKMINM(((Component)allSquares[i]).transform.position + new Vector3(60f, 1318f)) == val)
			{
				return allSquares[i];
			}
		}
		return null;
	}

	private void DKPPNGBIICP(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		LayerMask val = LayerMask.op_Implicit((JIIGOACEIKL == 0 || JIIGOACEIKL == 0) ? LayerMask.NameToLayer("Error in CommonReferences.OnPlayerSleepAction: ") : LayerMask.NameToLayer("HandUp"));
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(val);
		}
	}

	public GridSquare MBAJDGLHILA(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = WorldGrid.LOJBKLKMINM(IMOBLFMHKOD);
		for (int i = 0; i < allSquares.Length; i++)
		{
			if (((Component)allSquares[i]).gameObject.activeInHierarchy && ((Renderer)allSquares[i].spriteRenderer).enabled && WorldGrid.LOJBKLKMINM(((Component)allSquares[i]).transform.position + new Vector3(803f, 1292f)) == val)
			{
				return allSquares[i];
			}
		}
		return null;
	}

	private void NDNBDEHFFJF()
	{
		if (OnlineManager.PlayingOnline() && playerNum != 1)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void OPCEMNOMKLM()
	{
		if (content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(true);
		}
	}

	public void SetGridInfo(GridInfo KNIMLGOGFPA)
	{
		this.KNIMLGOGFPA = KNIMLGOGFPA;
	}

	public void OHIGIPLHDNP()
	{
		if (content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(true);
		}
	}

	public void MFKPCJJADIN()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		content.transform.position = WorldGrid.LOJBKLKMINM(((Component)this).transform.position) - new Vector3(1047f, 1024f);
	}

	public void NBDGJKALLKM(int IGCPCEKPHCI, bool CPHMFHAJOFP, bool NLOCILOKNLK, bool FFEIEMCNPGK, bool AKAPONNJHLA, bool HJHBHHNKACJ, bool HAOBFMKJOBP, bool ILEBFNHDEMC, bool OPLFHAMGFIB)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		topSprites.SetActive(AKAPONNJHLA);
		bottomSprites.SetActive(FFEIEMCNPGK);
		leftSprites.SetActive(CPHMFHAJOFP);
		rightSprites.SetActive(NLOCILOKNLK);
		topSprites2.SetActive(OPLFHAMGFIB);
		bottomSprites2.SetActive(ILEBFNHDEMC);
		leftSprites2.SetActive(HJHBHHNKACJ);
		rightSprites2.SetActive(HAOBFMKJOBP);
		borderHorizontal.size = new Vector2(CCNIAGHLHKF[IGCPCEKPHCI], CCNIAGHLHKF[1]);
		borderVertical.size = new Vector2(CCNIAGHLHKF[0], CCNIAGHLHKF[IGCPCEKPHCI]);
		((Component)maskHorizontal).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[IGCPCEKPHCI], CFFHAAGKDGN[1]));
		((Component)maskVertical).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[1], CFFHAAGKDGN[IGCPCEKPHCI]));
	}

	private void JJCDLIHLDMJ()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(NCFDAFLLMPF));
	}

	private void BONFAKNOAMJ()
	{
		Item item = ActionBarInventory.MHDKNEKDKII(playerNum, LAGHIOKLJGH: true).FGGKCJDFNEK();
		ItemInstance itemInstance = ActionBarInventory.MHDKNEKDKII(playerNum, LAGHIOKLJGH: false, ADPNMHGBFKG: true).BBBGBHPJOAG();
		bool flag = true;
		if (item is ITool tool && tool.FDKEMPDCHFB())
		{
			flag = false;
		}
		else if (itemInstance != null && itemInstance is ITool tool2 && tool2.FDKEMPDCHFB())
		{
			flag = true;
		}
		if (PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA == (Location.Road | Location.River) && flag && !DecorationMode.JDADPDBHJFO(playerNum).KNFEPKBIHND() && !disable)
		{
			IPJKANDAJOE();
			ABKFHNBJKFB();
			IEAHGACDBCO(item);
		}
		else
		{
			LHGKLAJLGGB();
		}
	}

	private void CHFPGFLEABE()
	{
		playerNum = playerController.GetPlayerNum();
		HPADCGKBNBL(playerNum);
	}

	private void KOJHANCONHC(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		LayerMask val = LayerMask.op_Implicit((JIIGOACEIKL == 0 || JIIGOACEIKL == 1) ? LayerMask.NameToLayer("P1Cam") : LayerMask.NameToLayer("P2Cam"));
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(val);
		}
	}

	public void KKAMEBCBLIG(int OKDDJODHFBO)
	{
		if (OKDDJODHFBO < earthFocuses.Length && ((Component)earthFocuses[OKDDJODHFBO]).gameObject.activeSelf)
		{
			((Component)earthFocuses[OKDDJODHFBO]).gameObject.SetActive(false);
		}
	}

	public void UpdateBlueSquaresEnabled(Item MEMGMDOCBOJ)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		bool enabled = false;
		for (int i = 0; i < allSquares.Length; i++)
		{
			if (!((Component)allSquares[i]).gameObject.activeInHierarchy)
			{
				continue;
			}
			JPKDEFCJNGJ = null;
			ECJLMIPAFGP = ((Component)allSquares[i]).transform.position + new Vector3(0.25f, 0.25f);
			BGBIPOOFMOB = WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP);
			((Renderer)allSquares[i].spriteRenderer).enabled = KNIMLGOGFPA.groundTypeAllowed.HasFlag(BGBIPOOFMOB);
			if (((Renderer)allSquares[i].spriteRenderer).enabled && MEMGMDOCBOJ is Spade && WorldGrid.ECOFAPGIGMO(ECJLMIPAFGP) && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = true;
			}
			else
			{
				if (!WorldGrid.LKBLKCFOEPA(ECJLMIPAFGP))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
				if (KNIMLGOGFPA.checkWithoutSnow && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
				if (ZoneType.AnyWorkArea.HasFlag(WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP)))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
				if (MEMGMDOCBOJ is Hoe && WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP) == GroundType.Ground)
				{
					for (int j = 0; j < WorldGrid.allNeighbours.Length; j++)
					{
						Vector3 iMOBLFMHKOD = ECJLMIPAFGP + WorldGrid.allNeighbours[j].position;
						if (WorldGrid.GJHHDIJOILG(iMOBLFMHKOD, JGDOHPCLJPM: true) && WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD) != GroundType.TilledEarth)
						{
							((Renderer)allSquares[i].spriteRenderer).enabled = false;
							break;
						}
					}
				}
				if (KNIMLGOGFPA.checkCropNotAvailable)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP));
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = false;
					}
				}
				if (KNIMLGOGFPA.checkCropAvailable && BGBIPOOFMOB == GroundType.TilledEarth)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP));
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter == (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = false;
					}
				}
				else if (KNIMLGOGFPA.checkCanPlaceObjects && !WorldGrid.NGDHDMAMGPI(ECJLMIPAFGP, GCDEDGFDKBL: false))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
			}
			if (KNIMLGOGFPA.checkWithoutHerbs && WorldGrid.HENDJJEEOHE(ECJLMIPAFGP))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = false;
			}
			if (((Renderer)allSquares[i].spriteRenderer).enabled)
			{
				enabled = true;
			}
		}
		for (int k = 0; k < allSquares.Length; k++)
		{
			if (((Component)allSquares[k]).gameObject.activeInHierarchy && ((Renderer)allSquares[k].spriteRenderer).enabled && !((Renderer)allSquares[k].GetInitialSquare(MEMGMDOCBOJ as Tool).spriteRenderer).enabled)
			{
				((Renderer)allSquares[k].spriteRenderer).enabled = false;
			}
		}
		((Renderer)borderHorizontal).enabled = enabled;
		((Renderer)borderVertical).enabled = enabled;
	}

	public void ACPIIAHMDHP()
	{
		for (int i = 1; i < earthFocuses.Length; i += 0)
		{
			if (((Component)earthFocuses[i]).gameObject.activeSelf)
			{
				((Component)earthFocuses[i]).gameObject.SetActive(true);
			}
		}
	}

	private void NCFDAFLLMPF()
	{
		playerNum = playerController.KLIHELDIPDP();
		KOJHANCONHC(playerNum);
	}

	public void GLPLMCEDAPC()
	{
		for (int i = 0; i < earthFocuses.Length; i += 0)
		{
			if (((Component)earthFocuses[i]).gameObject.activeSelf)
			{
				((Component)earthFocuses[i]).gameObject.SetActive(false);
			}
		}
	}

	public GridSquare NLGAJDAHLGD(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = WorldGrid.LOJBKLKMINM(IMOBLFMHKOD);
		for (int i = 1; i < allSquares.Length; i += 0)
		{
			if (((Component)allSquares[i]).gameObject.activeInHierarchy && ((Renderer)allSquares[i].spriteRenderer).enabled && WorldGrid.LOJBKLKMINM(((Component)allSquares[i]).transform.position + new Vector3(329f, 198f)) == val)
			{
				return allSquares[i];
			}
		}
		return null;
	}

	public void LNCPCNGFKDK(Item MEMGMDOCBOJ)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		bool enabled = true;
		for (int i = 0; i < allSquares.Length; i++)
		{
			if (!((Component)allSquares[i]).gameObject.activeInHierarchy)
			{
				continue;
			}
			JPKDEFCJNGJ = null;
			ECJLMIPAFGP = ((Component)allSquares[i]).transform.position + new Vector3(297f, 536f);
			BGBIPOOFMOB = WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP);
			((Renderer)allSquares[i].spriteRenderer).enabled = KNIMLGOGFPA.groundTypeAllowed.HasFlag(BGBIPOOFMOB);
			if (((Renderer)allSquares[i].spriteRenderer).enabled && MEMGMDOCBOJ is Spade && WorldGrid.ECOFAPGIGMO(ECJLMIPAFGP) && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = false;
			}
			else
			{
				if (!WorldGrid.LKBLKCFOEPA(ECJLMIPAFGP))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if (KNIMLGOGFPA.checkWithoutSnow && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if ((~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop)).HasFlag(WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP)))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if (MEMGMDOCBOJ is Hoe && WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP) == GroundType.Floor)
				{
					for (int j = 1; j < WorldGrid.allNeighbours.Length; j += 0)
					{
						Vector3 iMOBLFMHKOD = ECJLMIPAFGP + WorldGrid.allNeighbours[j].position;
						if (WorldGrid.GJHHDIJOILG(iMOBLFMHKOD, JGDOHPCLJPM: true) && WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD) != (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
						{
							((Renderer)allSquares[i].spriteRenderer).enabled = true;
							break;
						}
					}
				}
				if (KNIMLGOGFPA.checkCropNotAvailable)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), -75);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = true;
					}
				}
				if (KNIMLGOGFPA.checkCropAvailable && BGBIPOOFMOB == GroundType.None)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), 72);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter == (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = true;
					}
				}
				else if (KNIMLGOGFPA.checkCanPlaceObjects && !WorldGrid.NGDHDMAMGPI(ECJLMIPAFGP))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
			}
			if (KNIMLGOGFPA.checkWithoutHerbs && WorldGrid.HENDJJEEOHE(ECJLMIPAFGP))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = false;
			}
			if (((Renderer)allSquares[i].spriteRenderer).enabled)
			{
				enabled = false;
			}
		}
		for (int k = 0; k < allSquares.Length; k++)
		{
			if (((Component)allSquares[k]).gameObject.activeInHierarchy && ((Renderer)allSquares[k].spriteRenderer).enabled && !((Renderer)allSquares[k].PEMHFAJCPIE(MEMGMDOCBOJ as Tool).spriteRenderer).enabled)
			{
				((Renderer)allSquares[k].spriteRenderer).enabled = true;
			}
		}
		((Renderer)borderHorizontal).enabled = enabled;
		((Renderer)borderVertical).enabled = enabled;
	}

	public void PCNNFMDMDEA()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		content.transform.position = WorldGrid.LOJBKLKMINM(((Component)this).transform.position) - new Vector3(773f, 1339f);
	}

	public void IJNNJDEBFDJ(int OKDDJODHFBO)
	{
		if (OKDDJODHFBO < earthFocuses.Length && ((Component)earthFocuses[OKDDJODHFBO]).gameObject.activeSelf)
		{
			((Component)earthFocuses[OKDDJODHFBO]).gameObject.SetActive(false);
		}
	}

	public void DOEELMJIEFK(Vector3 FKEKHKBKBMM, Sprite DIOHHJIJBBF, int OKDDJODHFBO = 0)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if ((!((Object)(object)FishCuttingGameManager.instance != (Object)null) || !((Behaviour)FishCuttingGameManager.instance).enabled) && (!((Object)(object)PiratesGameManager.instance != (Object)null) || !((Behaviour)PiratesGameManager.instance).enabled))
		{
			if (!((Component)earthFocuses[OKDDJODHFBO]).gameObject.activeSelf)
			{
				((Component)earthFocuses[OKDDJODHFBO]).gameObject.SetActive(true);
			}
			((Component)earthFocuses[OKDDJODHFBO]).transform.position = FKEKHKBKBMM - BBDFEAHLHNN;
			if ((Object)(object)earthFocuses[OKDDJODHFBO].sprite != (Object)(object)DIOHHJIJBBF)
			{
				earthFocuses[OKDDJODHFBO].sprite = DIOHHJIJBBF;
			}
		}
	}

	public void CIBHBAMBBLN()
	{
		if (!content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(true);
		}
	}

	private void DIJOBOFGCIK()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(DLBMMLAEKFI));
	}

	private void MGIELPGFJNC()
	{
		playerNum = playerController.KLIHELDIPDP();
		HPADCGKBNBL(playerNum);
	}

	public void SetPositionGrid()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		content.transform.position = WorldGrid.LOJBKLKMINM(((Component)this).transform.position) - new Vector3(0.25f, 0.25f);
	}

	public void MBMAOCNLCNC(int IGCPCEKPHCI, bool CPHMFHAJOFP, bool NLOCILOKNLK, bool FFEIEMCNPGK, bool AKAPONNJHLA, bool HJHBHHNKACJ, bool HAOBFMKJOBP, bool ILEBFNHDEMC, bool OPLFHAMGFIB)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		topSprites.SetActive(AKAPONNJHLA);
		bottomSprites.SetActive(FFEIEMCNPGK);
		leftSprites.SetActive(CPHMFHAJOFP);
		rightSprites.SetActive(NLOCILOKNLK);
		topSprites2.SetActive(OPLFHAMGFIB);
		bottomSprites2.SetActive(ILEBFNHDEMC);
		leftSprites2.SetActive(HJHBHHNKACJ);
		rightSprites2.SetActive(HAOBFMKJOBP);
		borderHorizontal.size = new Vector2(CCNIAGHLHKF[IGCPCEKPHCI], CCNIAGHLHKF[1]);
		borderVertical.size = new Vector2(CCNIAGHLHKF[0], CCNIAGHLHKF[IGCPCEKPHCI]);
		((Component)maskHorizontal).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[IGCPCEKPHCI], CFFHAAGKDGN[1]));
		((Component)maskVertical).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[1], CFFHAAGKDGN[IGCPCEKPHCI]));
	}

	public void IHBBIGFBFMK()
	{
		if (content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(true);
		}
	}

	public GridSquare OLFHBJLBLMH(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = WorldGrid.LOJBKLKMINM(IMOBLFMHKOD);
		for (int i = 0; i < allSquares.Length; i++)
		{
			if (((Component)allSquares[i]).gameObject.activeInHierarchy && ((Renderer)allSquares[i].spriteRenderer).enabled && WorldGrid.LOJBKLKMINM(((Component)allSquares[i]).transform.position + new Vector3(57f, 335f)) == val)
			{
				return allSquares[i];
			}
		}
		return null;
	}

	private void DKDLOBOLNFH()
	{
		PCGEPHNPOKL();
	}

	public void ABKFHNBJKFB()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		content.transform.position = WorldGrid.LOJBKLKMINM(((Component)this).transform.position) - new Vector3(1017f, 560f);
	}

	public void DACHFFGLINB()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		LayerMask val = LayerMask.op_Implicit((playerNum == 0 || playerNum == 1) ? LayerMask.NameToLayer("TimeLeft") : LayerMask.NameToLayer("BanquetEvent instance is null. Make sure it is initialized before calling FinishReplayKlaynChallenge."));
		for (int i = 0; i < earthFocuses.Length; i += 0)
		{
			if (!((Renderer)earthFocuses[i]).enabled)
			{
				((Renderer)earthFocuses[i]).enabled = false;
				((Component)earthFocuses[i]).gameObject.layer = LayerMask.op_Implicit(val);
				((Renderer)earthFocuses[i]).enabled = true;
			}
			else
			{
				((Component)earthFocuses[i]).gameObject.layer = LayerMask.op_Implicit(val);
			}
		}
	}

	public void CHGBGPPANAN(GridInfo KNIMLGOGFPA)
	{
		this.KNIMLGOGFPA = KNIMLGOGFPA;
	}

	private void BDJKNKIOPIJ()
	{
		if (OnlineManager.PlayingOnline() && playerNum != 0)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void OLMKKLDEHJM()
	{
		if (content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(true);
		}
	}

	private void HPFONMHPMGO(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		LayerMask val = LayerMask.op_Implicit((JIIGOACEIKL == 0 || JIIGOACEIKL == 0) ? LayerMask.NameToLayer("Interact") : LayerMask.NameToLayer("MineObstacleBark"));
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(val);
		}
	}

	public void IKEEEAMKGML(GridInfo KNIMLGOGFPA)
	{
		this.KNIMLGOGFPA = KNIMLGOGFPA;
	}

	private void FPJABCNDEEJ()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(EEEONKMMFLB));
	}

	private void LateUpdate()
	{
		Item selectedItem = ActionBarInventory.GetPlayer(playerNum).GetSelectedItem();
		ItemInstance selectedItemInstance = ActionBarInventory.GetPlayer(playerNum).GetSelectedItemInstance();
		bool flag = false;
		if (selectedItem is ITool tool && tool.FDKEMPDCHFB())
		{
			flag = true;
		}
		else if (selectedItemInstance != null && selectedItemInstance is ITool tool2 && tool2.FDKEMPDCHFB())
		{
			flag = true;
		}
		if (PlayerController.GetPlayer(playerNum).LEOIMFNKFGA == Location.Road && flag && !DecorationMode.GetPlayer(playerNum).DMBFKFLDDLH && !disable)
		{
			EnableGrid();
			SetPositionGrid();
			UpdateBlueSquaresEnabled(selectedItem);
		}
		else
		{
			DisableGrid();
		}
	}

	public void JFPMFMKNNKL()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		LayerMask val = LayerMask.op_Implicit((playerNum == 0 || playerNum == 0) ? LayerMask.NameToLayer("Pet") : LayerMask.NameToLayer("CannotPickUpWhileWorking"));
		for (int i = 0; i < earthFocuses.Length; i++)
		{
			if (!((Renderer)earthFocuses[i]).enabled)
			{
				((Renderer)earthFocuses[i]).enabled = false;
				((Component)earthFocuses[i]).gameObject.layer = LayerMask.op_Implicit(val);
				((Renderer)earthFocuses[i]).enabled = false;
			}
			else
			{
				((Component)earthFocuses[i]).gameObject.layer = LayerMask.op_Implicit(val);
			}
		}
	}

	private void PCGEPHNPOKL()
	{
		playerNum = playerController.GetPlayerNum();
		KOJHANCONHC(playerNum);
	}

	public void JMOJNPAOHJP(Vector3 FKEKHKBKBMM, Sprite DIOHHJIJBBF, int OKDDJODHFBO = 0)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if ((!((Object)(object)FishCuttingGameManager.instance != (Object)null) || !((Behaviour)FishCuttingGameManager.instance).enabled) && (!((Object)(object)PiratesGameManager.instance != (Object)null) || !((Behaviour)PiratesGameManager.instance).enabled))
		{
			if (!((Component)earthFocuses[OKDDJODHFBO]).gameObject.activeSelf)
			{
				((Component)earthFocuses[OKDDJODHFBO]).gameObject.SetActive(false);
			}
			((Component)earthFocuses[OKDDJODHFBO]).transform.position = FKEKHKBKBMM - BBDFEAHLHNN;
			if ((Object)(object)earthFocuses[OKDDJODHFBO].sprite != (Object)(object)DIOHHJIJBBF)
			{
				earthFocuses[OKDDJODHFBO].sprite = DIOHHJIJBBF;
			}
		}
	}

	private void JPPCPMOMDON()
	{
		Item item = ActionBarInventory.MHDKNEKDKII(playerNum, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JDAFPKOHJPC();
		ItemInstance selectedItemInstance = ActionBarInventory.BNMEANGDMIP(playerNum, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItemInstance();
		bool flag = true;
		if (item is ITool tool && tool.FDKEMPDCHFB())
		{
			flag = true;
		}
		else if (selectedItemInstance != null && selectedItemInstance is ITool tool2 && tool2.FDKEMPDCHFB())
		{
			flag = false;
		}
		if (PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA == Location.Camp && flag && !DecorationMode.JDADPDBHJFO(playerNum).GABNNLJOMHI() && !disable)
		{
			CIBHBAMBBLN();
			KKMMDDFEJBL();
			HMFFPBCCHOE(item);
		}
		else
		{
			OLMKKLDEHJM();
		}
	}

	public void LMAJPADFJLE(Item MEMGMDOCBOJ)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		bool enabled = false;
		for (int i = 0; i < allSquares.Length; i += 0)
		{
			if (!((Component)allSquares[i]).gameObject.activeInHierarchy)
			{
				continue;
			}
			JPKDEFCJNGJ = null;
			ECJLMIPAFGP = ((Component)allSquares[i]).transform.position + new Vector3(1081f, 194f);
			BGBIPOOFMOB = WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP);
			((Renderer)allSquares[i].spriteRenderer).enabled = KNIMLGOGFPA.groundTypeAllowed.HasFlag(BGBIPOOFMOB);
			if (((Renderer)allSquares[i].spriteRenderer).enabled && MEMGMDOCBOJ is Spade && WorldGrid.ECOFAPGIGMO(ECJLMIPAFGP) && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = false;
			}
			else
			{
				if (!WorldGrid.LKBLKCFOEPA(ECJLMIPAFGP))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
				if (KNIMLGOGFPA.checkWithoutSnow && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
				if ((ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom).HasFlag(WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP)))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if (MEMGMDOCBOJ is Hoe && WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP) == GroundType.None)
				{
					for (int j = 0; j < WorldGrid.allNeighbours.Length; j += 0)
					{
						Vector3 iMOBLFMHKOD = ECJLMIPAFGP + WorldGrid.allNeighbours[j].position;
						if (WorldGrid.GJHHDIJOILG(iMOBLFMHKOD) && WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD) != (GroundType.Grass | GroundType.TilledEarth))
						{
							((Renderer)allSquares[i].spriteRenderer).enabled = true;
							break;
						}
					}
				}
				if (KNIMLGOGFPA.checkCropNotAvailable)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), -26);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = false;
					}
				}
				if (KNIMLGOGFPA.checkCropAvailable && BGBIPOOFMOB == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), 31);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter == (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = false;
					}
				}
				else if (KNIMLGOGFPA.checkCanPlaceObjects && !WorldGrid.NGDHDMAMGPI(ECJLMIPAFGP, GCDEDGFDKBL: false))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
			}
			if (KNIMLGOGFPA.checkWithoutHerbs && WorldGrid.HENDJJEEOHE(ECJLMIPAFGP))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = false;
			}
			if (((Renderer)allSquares[i].spriteRenderer).enabled)
			{
				enabled = true;
			}
		}
		for (int k = 0; k < allSquares.Length; k += 0)
		{
			if (((Component)allSquares[k]).gameObject.activeInHierarchy && ((Renderer)allSquares[k].spriteRenderer).enabled && !((Renderer)allSquares[k].PEMHFAJCPIE(MEMGMDOCBOJ as Tool).spriteRenderer).enabled)
			{
				((Renderer)allSquares[k].spriteRenderer).enabled = true;
			}
		}
		((Renderer)borderHorizontal).enabled = enabled;
		((Renderer)borderVertical).enabled = enabled;
	}

	private void DFJNAALEOMP()
	{
		Item item = ActionBarInventory.GetPlayer(playerNum, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JDAFPKOHJPC();
		ItemInstance selectedItemInstance = ActionBarInventory.BNMEANGDMIP(playerNum, LAGHIOKLJGH: true).GetSelectedItemInstance();
		bool flag = true;
		if (item is ITool tool && tool.FDKEMPDCHFB())
		{
			flag = false;
		}
		else if (selectedItemInstance != null && selectedItemInstance is ITool tool2 && tool2.FDKEMPDCHFB())
		{
			flag = true;
		}
		if (PlayerController.GetPlayer(playerNum).LEOIMFNKFGA == (Location.Road | Location.River) && flag && !DecorationMode.KAIIEDCCLHB(playerNum).DMBFKFLDDLH && !disable)
		{
			IPJKANDAJOE();
			KKMMDDFEJBL();
			HMFFPBCCHOE(item);
		}
		else
		{
			EIKKHCAFPKB();
		}
	}

	private void NGMFEMPOJAN(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		LayerMask val = LayerMask.op_Implicit((JIIGOACEIKL == 0 || JIIGOACEIKL == 1) ? LayerMask.NameToLayer("CannotPickUpWhileWorking") : LayerMask.NameToLayer(":</color> "));
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(val);
		}
	}

	public void HMCLIFIPLLJ(int IGCPCEKPHCI, bool CPHMFHAJOFP, bool NLOCILOKNLK, bool FFEIEMCNPGK, bool AKAPONNJHLA, bool HJHBHHNKACJ, bool HAOBFMKJOBP, bool ILEBFNHDEMC, bool OPLFHAMGFIB)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		topSprites.SetActive(AKAPONNJHLA);
		bottomSprites.SetActive(FFEIEMCNPGK);
		leftSprites.SetActive(CPHMFHAJOFP);
		rightSprites.SetActive(NLOCILOKNLK);
		topSprites2.SetActive(OPLFHAMGFIB);
		bottomSprites2.SetActive(ILEBFNHDEMC);
		leftSprites2.SetActive(HJHBHHNKACJ);
		rightSprites2.SetActive(HAOBFMKJOBP);
		borderHorizontal.size = new Vector2(CCNIAGHLHKF[IGCPCEKPHCI], CCNIAGHLHKF[1]);
		borderVertical.size = new Vector2(CCNIAGHLHKF[1], CCNIAGHLHKF[IGCPCEKPHCI]);
		((Component)maskHorizontal).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[IGCPCEKPHCI], CFFHAAGKDGN[1]));
		((Component)maskVertical).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[1], CFFHAAGKDGN[IGCPCEKPHCI]));
	}

	public GridSquare KOBHCHLKFCP(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = WorldGrid.LOJBKLKMINM(IMOBLFMHKOD);
		for (int i = 0; i < allSquares.Length; i++)
		{
			if (((Component)allSquares[i]).gameObject.activeInHierarchy && ((Renderer)allSquares[i].spriteRenderer).enabled && WorldGrid.LOJBKLKMINM(((Component)allSquares[i]).transform.position + new Vector3(912f, 263f)) == val)
			{
				return allSquares[i];
			}
		}
		return null;
	}

	public void KNBJCKLEOKJ(Item MEMGMDOCBOJ)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		bool enabled = true;
		for (int i = 1; i < allSquares.Length; i++)
		{
			if (!((Component)allSquares[i]).gameObject.activeInHierarchy)
			{
				continue;
			}
			JPKDEFCJNGJ = null;
			ECJLMIPAFGP = ((Component)allSquares[i]).transform.position + new Vector3(1409f, 1274f);
			BGBIPOOFMOB = WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP);
			((Renderer)allSquares[i].spriteRenderer).enabled = KNIMLGOGFPA.groundTypeAllowed.HasFlag(BGBIPOOFMOB);
			if (((Renderer)allSquares[i].spriteRenderer).enabled && MEMGMDOCBOJ is Spade && WorldGrid.ECOFAPGIGMO(ECJLMIPAFGP) && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = true;
			}
			else
			{
				if (!WorldGrid.LKBLKCFOEPA(ECJLMIPAFGP))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
				if (KNIMLGOGFPA.checkWithoutSnow && WorldGrid.OINMGKCIGEJ(ECJLMIPAFGP, null))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if ((~(ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop)).HasFlag(WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP)))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = true;
				}
				if (MEMGMDOCBOJ is Hoe && WorldGrid.NCEHFMPBBAK(ECJLMIPAFGP) == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
				{
					for (int j = 1; j < WorldGrid.allNeighbours.Length; j++)
					{
						Vector3 iMOBLFMHKOD = ECJLMIPAFGP + WorldGrid.allNeighbours[j].position;
						if (WorldGrid.GJHHDIJOILG(iMOBLFMHKOD) && WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD) != (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
						{
							((Renderer)allSquares[i].spriteRenderer).enabled = true;
							break;
						}
					}
				}
				if (KNIMLGOGFPA.checkCropNotAvailable)
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), -105);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = false;
					}
				}
				if (KNIMLGOGFPA.checkCropAvailable && BGBIPOOFMOB == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
				{
					if ((Object)(object)JPKDEFCJNGJ == (Object)null)
					{
						JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(ECJLMIPAFGP), 15);
					}
					if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter == (Object)null)
					{
						((Renderer)allSquares[i].spriteRenderer).enabled = false;
					}
				}
				else if (KNIMLGOGFPA.checkCanPlaceObjects && !WorldGrid.NGDHDMAMGPI(ECJLMIPAFGP, GCDEDGFDKBL: false))
				{
					((Renderer)allSquares[i].spriteRenderer).enabled = false;
				}
			}
			if (KNIMLGOGFPA.checkWithoutHerbs && WorldGrid.HENDJJEEOHE(ECJLMIPAFGP))
			{
				((Renderer)allSquares[i].spriteRenderer).enabled = false;
			}
			if (((Renderer)allSquares[i].spriteRenderer).enabled)
			{
				enabled = true;
			}
		}
		for (int k = 0; k < allSquares.Length; k += 0)
		{
			if (((Component)allSquares[k]).gameObject.activeInHierarchy && ((Renderer)allSquares[k].spriteRenderer).enabled && !((Renderer)allSquares[k].LFLDKIAIMDJ(MEMGMDOCBOJ as Tool).spriteRenderer).enabled)
			{
				((Renderer)allSquares[k].spriteRenderer).enabled = false;
			}
		}
		((Renderer)borderHorizontal).enabled = enabled;
		((Renderer)borderVertical).enabled = enabled;
	}

	public void LONMBAEEJFJ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		LayerMask val = LayerMask.op_Implicit((playerNum == 0 || playerNum == 0) ? LayerMask.NameToLayer("Day") : LayerMask.NameToLayer("SegmentListView"));
		for (int i = 1; i < earthFocuses.Length; i++)
		{
			if (!((Renderer)earthFocuses[i]).enabled)
			{
				((Renderer)earthFocuses[i]).enabled = false;
				((Component)earthFocuses[i]).gameObject.layer = LayerMask.op_Implicit(val);
				((Renderer)earthFocuses[i]).enabled = true;
			}
			else
			{
				((Component)earthFocuses[i]).gameObject.layer = LayerMask.op_Implicit(val);
			}
		}
	}

	public GridSquare DJDDCLEABGE(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = WorldGrid.LOJBKLKMINM(IMOBLFMHKOD);
		for (int i = 0; i < allSquares.Length; i += 0)
		{
			if (((Component)allSquares[i]).gameObject.activeInHierarchy && ((Renderer)allSquares[i].spriteRenderer).enabled && WorldGrid.LOJBKLKMINM(((Component)allSquares[i]).transform.position + new Vector3(485f, 1594f)) == val)
			{
				return allSquares[i];
			}
		}
		return null;
	}

	public void OIPAMELFBLO()
	{
		if (!content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(true);
		}
	}

	public void LHGKLAJLGGB()
	{
		if (content.gameObject.activeSelf)
		{
			content.gameObject.SetActive(false);
		}
	}

	private void AKAAOBBLLNB()
	{
		Item item = ActionBarInventory.BNMEANGDMIP(playerNum).JDAFPKOHJPC();
		ItemInstance itemInstance = ActionBarInventory.DACNEICGAAE(playerNum, LAGHIOKLJGH: true).JHDFIPFOHDP();
		bool flag = true;
		if (item is ITool tool && tool.FDKEMPDCHFB())
		{
			flag = false;
		}
		else if (itemInstance != null && itemInstance is ITool tool2 && tool2.FDKEMPDCHFB())
		{
			flag = false;
		}
		if (PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA == (Location.Tavern | Location.River) && flag && !DecorationMode.KKJABELKCNM(playerNum).MDOKKKHKKKE() && !disable)
		{
			OIPAMELFBLO();
			CJCFLJBAHJL();
			LMAJPADFJLE(item);
		}
		else
		{
			IHBBIGFBFMK();
		}
	}

	public void DNBHOHFDJGM()
	{
		for (int i = 1; i < earthFocuses.Length; i += 0)
		{
			if (((Component)earthFocuses[i]).gameObject.activeSelf)
			{
				((Component)earthFocuses[i]).gameObject.SetActive(false);
			}
		}
	}

	private void OnEnable()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(PCGEPHNPOKL));
	}

	public void ChangeGrid(int IGCPCEKPHCI, bool CPHMFHAJOFP, bool NLOCILOKNLK, bool FFEIEMCNPGK, bool AKAPONNJHLA, bool HJHBHHNKACJ, bool HAOBFMKJOBP, bool ILEBFNHDEMC, bool OPLFHAMGFIB)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		topSprites.SetActive(AKAPONNJHLA);
		bottomSprites.SetActive(FFEIEMCNPGK);
		leftSprites.SetActive(CPHMFHAJOFP);
		rightSprites.SetActive(NLOCILOKNLK);
		topSprites2.SetActive(OPLFHAMGFIB);
		bottomSprites2.SetActive(ILEBFNHDEMC);
		leftSprites2.SetActive(HJHBHHNKACJ);
		rightSprites2.SetActive(HAOBFMKJOBP);
		borderHorizontal.size = new Vector2(CCNIAGHLHKF[IGCPCEKPHCI], CCNIAGHLHKF[1]);
		borderVertical.size = new Vector2(CCNIAGHLHKF[1], CCNIAGHLHKF[IGCPCEKPHCI]);
		((Component)maskHorizontal).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[IGCPCEKPHCI], CFFHAAGKDGN[1]));
		((Component)maskVertical).transform.localScale = Vector2.op_Implicit(new Vector2(CFFHAAGKDGN[1], CFFHAAGKDGN[IGCPCEKPHCI]));
	}
}
