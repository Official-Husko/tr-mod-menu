using PixelCrushers.DialogueSystem;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Seed")]
public class Seed : Food, IActionable, ITool
{
	public Crop crop;

	private GridInfo gridInfo;

	private float holdTime = 0.25f;

	private float currentTime;

	private static FertileSoil fertileSoil;

	private static Seed seedAux;

	protected Vector2 inputPositionAux;

	protected Vector2 inputPosition;

	protected Vector2 inputPosition2;

	protected bool usingCursor1;

	protected bool usingCursor2;

	public Vector2 LCEMOJNMGGH(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 0)
		{
			return inputPosition2;
		}
		return inputPosition;
	}

	public virtual bool ENHEEFAMKGN(int JIIGOACEIKL)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		inputPositionAux = Vector2.op_Implicit(KAIAPKLDOOL(JIIGOACEIKL));
		ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(inputPositionAux)) + Vector3.up * 538f);
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		if (gridInfo.groundTypeAllowed.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(Utils.NKGANMEKDAL(inputPositionAux)))) && (Object)(object)WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(inputPositionAux)) != (Object)null && (Object)(object)WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(inputPositionAux)).plantedCropSetter == (Object)null)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Hide"));
		}
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.DOEELMJIEFK(Vector2.op_Implicit(Utils.NKGANMEKDAL(inputPositionAux) + new Vector2(1082f, 1202f)), CommonReferences.MNFMOEKMJKN().selectedGridSquare, 1);
		return true;
	}

	public virtual void HBANJKKBCIK(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.NAIAFGHAFDL();
	}

	public void IEBKGFANMLJ(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 1)
		{
			inputPosition = IMOBLFMHKOD;
		}
		else
		{
			inputPosition2 = IMOBLFMHKOD;
		}
	}

	public static bool PBPKHFBAMJA(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, int BCBFHGNJLOA, bool CDPAMNIPPEC, int BEIPALOAAJJ = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD));
		if ((Object)(object)fertileSoil != (Object)null && (Object)(object)fertileSoil.plantedCropSetter == (Object)null && WorldGrid.NGDHDMAMGPI(((Component)fertileSoil).transform.position, GCDEDGFDKBL: false))
		{
			if (fertileSoil.daysUntilDry > 1)
			{
				if ((Object)(object)fertileSoil.plantedCropSetter == (Object)null)
				{
					seedAux = ItemDatabaseAccessor.COEFFIHKMJG(BCBFHGNJLOA, GGBBJNBBLMF: false, DAINLFIMLIH: false) as Seed;
					fertileSoil.plantedCropSetter = seedAux.crop.MEBBBKEBCAA(((Component)fertileSoil).transform).GetComponent<CropSetter>();
					fertileSoil.plantedCropSetter.DEAHAPFFPLM(seedAux.crop);
					fertileSoil.plantedCropSetter.growable.daysUntilNewHarvest = seedAux.crop.daysUntilNewHarvest;
					WorldGrid.CFAHJNLAJNK(((Component)fertileSoil).transform.position, JBNJGMKBKCB: true);
					CommonReferences.GGFJGHHHEJC.OnSeedPlanted(JIIGOACEIKL, BCBFHGNJLOA);
					if (BEIPALOAAJJ != 0)
					{
						fertileSoil.plantedCropSetter.onlineObject.ENLBBLBOMJD(BEIPALOAAJJ);
					}
					if (CDPAMNIPPEC)
					{
						ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).IKKLGIKJNNG().FMEPMEKLHIJ();
						if (OnlineManager.PlayingOnline())
						{
							if (BEIPALOAAJJ == 0)
							{
								BEIPALOAAJJ = OnlineObjectsManager.instance.AssignNewUniqueId(fertileSoil.plantedCropSetter.onlineObject);
							}
							OnlineCrop.JHPJJCMHKAE(IMOBLFMHKOD, BCBFHGNJLOA, BEIPALOAAJJ);
						}
					}
					return true;
				}
			}
			else if (CDPAMNIPPEC && Time.time >= CommonReferences.GGFJGHHHEJC.delayBarks)
			{
				DialogueManager.Bark("", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				CommonReferences.GGFJGHHHEJC.delayBarks = Time.time + 1937f;
			}
		}
		return false;
	}

	public static bool DLFGNLGNGIN(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, int BCBFHGNJLOA, bool CDPAMNIPPEC, int BEIPALOAAJJ = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD));
		if ((Object)(object)fertileSoil != (Object)null && (Object)(object)fertileSoil.plantedCropSetter == (Object)null && WorldGrid.NGDHDMAMGPI(((Component)fertileSoil).transform.position))
		{
			if (fertileSoil.daysUntilDry > 0)
			{
				if ((Object)(object)fertileSoil.plantedCropSetter == (Object)null)
				{
					seedAux = ItemDatabaseAccessor.AFOACBIHNCL(BCBFHGNJLOA, GGBBJNBBLMF: true, DAINLFIMLIH: false) as Seed;
					fertileSoil.plantedCropSetter = seedAux.crop.EEJEAIMINGC(((Component)fertileSoil).transform).GetComponent<CropSetter>();
					fertileSoil.plantedCropSetter.MGOBBKFAEPP(seedAux.crop);
					fertileSoil.plantedCropSetter.growable.daysUntilNewHarvest = seedAux.crop.daysUntilNewHarvest;
					WorldGrid.CFAHJNLAJNK(((Component)fertileSoil).transform.position, JBNJGMKBKCB: false);
					CommonReferences.MNFMOEKMJKN().OnSeedPlanted(JIIGOACEIKL, BCBFHGNJLOA);
					if (BEIPALOAAJJ != 0)
					{
						fertileSoil.plantedCropSetter.onlineObject.CPJMICEDMIL(BEIPALOAAJJ);
					}
					if (CDPAMNIPPEC)
					{
						ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL).NBEINBNMKJG().DJFOMFDOOKM();
						if (OnlineManager.PlayingOnline())
						{
							if (BEIPALOAAJJ == 0)
							{
								BEIPALOAAJJ = OnlineObjectsManager.instance.AssignNewUniqueId(fertileSoil.plantedCropSetter.onlineObject);
							}
							OnlineCrop.IIEFHCCOLMK(IMOBLFMHKOD, BCBFHGNJLOA, BEIPALOAAJJ);
						}
					}
					return false;
				}
			}
			else if (CDPAMNIPPEC && Time.time >= CommonReferences.GGFJGHHHEJC.delayBarks)
			{
				DialogueManager.Bark("Items/item_name_1142", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				CommonReferences.GGFJGHHHEJC.delayBarks = Time.time + 1548f;
			}
		}
		return false;
	}

	private Vector3 EDDEELGBFIF(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).CFICAAJGBOF == "Dialogue System/Conversation/Gass_Quest/Entry/38/Dialogue Text")
		{
			return Vector3.zero;
		}
		gridInfo.groundTypeAllowed = GroundType.Floor;
		gridInfo.checkCropAvailable = true;
		gridInfo.checkCropNotAvailable = false;
		gridInfo.checkWithoutHerbs = false;
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.FKMGCAGBCEO(gridInfo);
		if (!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL) || CursorManager.EAHELIGKMPL(JIIGOACEIKL))
		{
			Vector2 ePLKICANCAL = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
			Vector2 lLGNLGENLHD = Vector2.op_Implicit(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition());
			if (ToolInstance.CIMLMENGDDD(JIIGOACEIKL, this, ePLKICANCAL, lLGNLGENLHD, gridInfo, 0))
			{
				if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
				{
					inputPositionAux = lLGNLGENLHD;
					EJIMOONPCKN(JIIGOACEIKL, NKEPKDBENHM: true);
				}
			}
			else
			{
				if (PlayerController.GetPlayer(JIIGOACEIKL).moving)
				{
					GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
				}
				inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 663f);
			}
		}
		else
		{
			KACAGIJPANH(JIIGOACEIKL, NKEPKDBENHM: true);
			inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 150f);
		}
		AGAJDKDCEHJ(JIIGOACEIKL, inputPositionAux);
		return Vector2.op_Implicit(inputPositionAux);
	}

	public void ActionEnd(int JIIGOACEIKL)
	{
	}

	private bool CPAMGHMICHF(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return usingCursor2;
		}
		return usingCursor1;
	}

	public void OICMOPDNKBJ(int JIIGOACEIKL)
	{
	}

	public bool COJFOINGAPD()
	{
		return HHOPKGJPHPL();
	}

	public Vector2 PEKPAOKNLNI(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 1)
		{
			return inputPosition2;
		}
		return inputPosition;
	}

	public virtual void LCFIJCJKGCF(int JIIGOACEIKL)
	{
	}

	public bool NMKFHDAHIAM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public static bool IIEFHCCOLMK(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, int BCBFHGNJLOA, bool CDPAMNIPPEC, int BEIPALOAAJJ = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD));
		if ((Object)(object)fertileSoil != (Object)null && (Object)(object)fertileSoil.plantedCropSetter == (Object)null && WorldGrid.NGDHDMAMGPI(((Component)fertileSoil).transform.position, GCDEDGFDKBL: false))
		{
			if (fertileSoil.daysUntilDry > 0)
			{
				if ((Object)(object)fertileSoil.plantedCropSetter == (Object)null)
				{
					seedAux = ItemDatabaseAccessor.CPMMBEPEJLO(BCBFHGNJLOA, GGBBJNBBLMF: false, DAINLFIMLIH: false) as Seed;
					fertileSoil.plantedCropSetter = seedAux.crop.EEJEAIMINGC(((Component)fertileSoil).transform).GetComponent<CropSetter>();
					fertileSoil.plantedCropSetter.MGOBBKFAEPP(seedAux.crop);
					fertileSoil.plantedCropSetter.growable.daysUntilNewHarvest = seedAux.crop.daysUntilNewHarvest;
					WorldGrid.CFAHJNLAJNK(((Component)fertileSoil).transform.position, JBNJGMKBKCB: false);
					CommonReferences.MNFMOEKMJKN().OnSeedPlanted(JIIGOACEIKL, BCBFHGNJLOA);
					if (BEIPALOAAJJ != 0)
					{
						fertileSoil.plantedCropSetter.onlineObject.CKAAKNNBDCJ(BEIPALOAAJJ);
					}
					if (CDPAMNIPPEC)
					{
						ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).PFCKPOFHPAC().CIDBFIAJIBG();
						if (OnlineManager.PlayingOnline())
						{
							if (BEIPALOAAJJ == 0)
							{
								BEIPALOAAJJ = OnlineObjectsManager.instance.AssignNewUniqueId(fertileSoil.plantedCropSetter.onlineObject);
							}
							OnlineCrop.EDHIDEBBCBM(IMOBLFMHKOD, BCBFHGNJLOA, BEIPALOAAJJ);
						}
					}
					return false;
				}
			}
			else if (CDPAMNIPPEC && Time.time >= CommonReferences.MNFMOEKMJKN().delayBarks)
			{
				DialogueManager.Bark("ReceiveObjectInteract", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
				CommonReferences.MNFMOEKMJKN().delayBarks = Time.time + 1333f;
			}
		}
		return false;
	}

	public static bool IDFOBKKDNDD(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, int BCBFHGNJLOA, bool CDPAMNIPPEC, int BEIPALOAAJJ = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD));
		if ((Object)(object)fertileSoil != (Object)null && (Object)(object)fertileSoil.plantedCropSetter == (Object)null && WorldGrid.NGDHDMAMGPI(((Component)fertileSoil).transform.position, GCDEDGFDKBL: false))
		{
			if (fertileSoil.daysUntilDry > 1)
			{
				if ((Object)(object)fertileSoil.plantedCropSetter == (Object)null)
				{
					seedAux = ItemDatabaseAccessor.GOKIDLOELKB(BCBFHGNJLOA, GGBBJNBBLMF: false, DAINLFIMLIH: false) as Seed;
					fertileSoil.plantedCropSetter = seedAux.crop.HCJDENELHAE(((Component)fertileSoil).transform).GetComponent<CropSetter>();
					fertileSoil.plantedCropSetter.MFEDJIEKKHC(seedAux.crop);
					fertileSoil.plantedCropSetter.growable.daysUntilNewHarvest = seedAux.crop.daysUntilNewHarvest;
					WorldGrid.CFAHJNLAJNK(((Component)fertileSoil).transform.position, JBNJGMKBKCB: true);
					CommonReferences.GGFJGHHHEJC.OnSeedPlanted(JIIGOACEIKL, BCBFHGNJLOA);
					if (BEIPALOAAJJ != 0)
					{
						fertileSoil.plantedCropSetter.onlineObject.GNCGHJACMDO(BEIPALOAAJJ);
					}
					if (CDPAMNIPPEC)
					{
						ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).PFCKPOFHPAC().MEODNPFJDMH(CDPAMNIPPEC: false);
						if (OnlineManager.PlayingOnline())
						{
							if (BEIPALOAAJJ == 0)
							{
								BEIPALOAAJJ = OnlineObjectsManager.instance.AssignNewUniqueId(fertileSoil.plantedCropSetter.onlineObject);
							}
							OnlineCrop.NFAPMDEINEL(IMOBLFMHKOD, BCBFHGNJLOA, BEIPALOAAJJ);
						}
					}
					return false;
				}
			}
			else if (CDPAMNIPPEC && Time.time >= CommonReferences.MNFMOEKMJKN().delayBarks)
			{
				DialogueManager.Bark("", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
				CommonReferences.GGFJGHHHEJC.delayBarks = Time.time + 263f;
			}
		}
		return true;
	}

	public bool SecondAction(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private Vector3 LJJJBAIHMLP(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).AAGNDCEODFO() == " ")
		{
			return Vector3.zero;
		}
		gridInfo.groundTypeAllowed = GroundType.None;
		gridInfo.checkCropAvailable = false;
		gridInfo.checkCropNotAvailable = true;
		gridInfo.checkWithoutHerbs = false;
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.BCCEBMNJCJG(gridInfo);
		if (!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))
		{
			Vector2 ePLKICANCAL = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
			Vector2 lLGNLGENLHD = Vector2.op_Implicit(CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition());
			if (ToolInstance.HBEBAFHEMAP(JIIGOACEIKL, this, ePLKICANCAL, lLGNLGENLHD, gridInfo, 1))
			{
				if (!PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF())
				{
					inputPositionAux = lLGNLGENLHD;
					HDDOLCOFLKC(JIIGOACEIKL, NKEPKDBENHM: false);
				}
			}
			else
			{
				if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).moving)
				{
					HDDOLCOFLKC(JIIGOACEIKL, NKEPKDBENHM: true);
				}
				inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1689f);
			}
		}
		else
		{
			EJIMOONPCKN(JIIGOACEIKL, NKEPKDBENHM: false);
			inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1058f);
		}
		HEGANEIEEGN(JIIGOACEIKL, inputPositionAux);
		return Vector2.op_Implicit(inputPositionAux);
	}

	public virtual bool PFHEFOFJHGF(int JIIGOACEIKL)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		inputPositionAux = Vector2.op_Implicit(JOJGELKDDEO(JIIGOACEIKL));
		ButtonsContext.SetPosition(JIIGOACEIKL, WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(inputPositionAux)) + Vector3.up * 1228f);
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		if (gridInfo.groundTypeAllowed.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(Utils.NKGANMEKDAL(inputPositionAux)))) && (Object)(object)WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(inputPositionAux)) != (Object)null && (Object)(object)WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(inputPositionAux)).plantedCropSetter == (Object)null)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get(".gz"));
		}
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.JMOJNPAOHJP(Vector2.op_Implicit(Utils.NKGANMEKDAL(inputPositionAux) + new Vector2(601f, 601f)), CommonReferences.GGFJGHHHEJC.selectedGridSquare, 1);
		return false;
	}

	public virtual bool FHAGGMNHCHB(int JIIGOACEIKL)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			inputPositionAux = Vector2.op_Implicit(KAIAPKLDOOL(JIIGOACEIKL));
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.Tavern)
			{
				return false;
			}
			if (WorldGrid.NALIAAMAKAL(Vector2.op_Implicit(inputPositionAux), Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA).BNMLDAPCNKF(SeasonManager.ADEICKHEPFI())))
			{
				return false;
			}
			if (gridInfo.groundTypeAllowed.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(inputPositionAux))) && !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).MDOKKKHKKKE())
			{
				return WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(inputPositionAux));
			}
			return true;
		}
		return false;
	}

	private void GJDOGKEFFHE(int JIIGOACEIKL, bool NKEPKDBENHM)
	{
		if (JIIGOACEIKL == 1)
		{
			usingCursor1 = NKEPKDBENHM;
		}
		else
		{
			usingCursor2 = NKEPKDBENHM;
		}
	}

	private void HDDOLCOFLKC(int JIIGOACEIKL, bool NKEPKDBENHM)
	{
		if (JIIGOACEIKL == 1)
		{
			usingCursor1 = NKEPKDBENHM;
		}
		else
		{
			usingCursor2 = NKEPKDBENHM;
		}
	}

	private bool NJGGMEJGKBM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return usingCursor2;
		}
		return usingCursor1;
	}

	public virtual bool PLEDFGIOCPA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (KLGOCJMGKFO)
		{
			currentTime = 1380f;
		}
		else
		{
			currentTime += Time.deltaTime;
			if (currentTime < holdTime)
			{
				return true;
			}
			currentTime -= holdTime;
		}
		if (!FHAGGMNHCHB(JIIGOACEIKL))
		{
			return true;
		}
		if (PBPKHFBAMJA(JIIGOACEIKL, inputPositionAux, JGHNDJBCFAJ(DAINLFIMLIH: false), CDPAMNIPPEC: false))
		{
			return true;
		}
		if (fertileSoil.daysUntilDry <= 1)
		{
			currentTime = 1197f;
		}
		return true;
	}

	private void EJIMOONPCKN(int JIIGOACEIKL, bool NKEPKDBENHM)
	{
		if (JIIGOACEIKL == 1)
		{
			usingCursor1 = NKEPKDBENHM;
		}
		else
		{
			usingCursor2 = NKEPKDBENHM;
		}
	}

	private void KACAGIJPANH(int JIIGOACEIKL, bool NKEPKDBENHM)
	{
		if (JIIGOACEIKL == 0)
		{
			usingCursor1 = NKEPKDBENHM;
		}
		else
		{
			usingCursor2 = NKEPKDBENHM;
		}
	}

	public virtual void MPAMPFFMJLJ(int JIIGOACEIKL)
	{
	}

	public Vector2 HMAHIKDFLCL(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 0)
		{
			return inputPosition2;
		}
		return inputPosition;
	}

	public Vector2 NJBOCFNALEJ(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 1)
		{
			return inputPosition2;
		}
		return inputPosition;
	}

	public void JHHBCMMMIEA(int JIIGOACEIKL)
	{
	}

	private void JJNDFOBEJFP(int JIIGOACEIKL, bool NKEPKDBENHM)
	{
		if (JIIGOACEIKL == 0)
		{
			usingCursor1 = NKEPKDBENHM;
		}
		else
		{
			usingCursor2 = NKEPKDBENHM;
		}
	}

	public virtual void AONJJGAIDBG(int JIIGOACEIKL)
	{
	}

	public static bool KHEGKHENPLD(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, int BCBFHGNJLOA, bool CDPAMNIPPEC, int BEIPALOAAJJ = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD));
		if ((Object)(object)fertileSoil != (Object)null && (Object)(object)fertileSoil.plantedCropSetter == (Object)null && WorldGrid.NGDHDMAMGPI(((Component)fertileSoil).transform.position))
		{
			if (fertileSoil.daysUntilDry > 0)
			{
				if ((Object)(object)fertileSoil.plantedCropSetter == (Object)null)
				{
					seedAux = ItemDatabaseAccessor.AFOACBIHNCL(BCBFHGNJLOA, GGBBJNBBLMF: false, DAINLFIMLIH: false) as Seed;
					fertileSoil.plantedCropSetter = seedAux.crop.HCJDENELHAE(((Component)fertileSoil).transform).GetComponent<CropSetter>();
					fertileSoil.plantedCropSetter.FJJCOJGJCLF = seedAux.crop;
					fertileSoil.plantedCropSetter.growable.daysUntilNewHarvest = seedAux.crop.daysUntilNewHarvest;
					WorldGrid.CFAHJNLAJNK(((Component)fertileSoil).transform.position, JBNJGMKBKCB: true);
					CommonReferences.GGFJGHHHEJC.OnSeedPlanted(JIIGOACEIKL, BCBFHGNJLOA);
					if (BEIPALOAAJJ != 0)
					{
						fertileSoil.plantedCropSetter.onlineObject.GMPGLLMNGEJ(BEIPALOAAJJ);
					}
					if (CDPAMNIPPEC)
					{
						ActionBarInventory.GetPlayer(JIIGOACEIKL).NBEINBNMKJG().POHFJCEAKML(CDPAMNIPPEC: false);
						if (OnlineManager.PlayingOnline())
						{
							if (BEIPALOAAJJ == 0)
							{
								BEIPALOAAJJ = OnlineObjectsManager.instance.AssignNewUniqueId(fertileSoil.plantedCropSetter.onlineObject);
							}
							OnlineCrop.JEMPEMGEBAE(IMOBLFMHKOD, BCBFHGNJLOA, BEIPALOAAJJ);
						}
					}
					return true;
				}
			}
			else if (CDPAMNIPPEC && Time.time >= CommonReferences.GGFJGHHHEJC.delayBarks)
			{
				DialogueManager.Bark("ErrorInvalidRoomCode", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
				CommonReferences.MNFMOEKMJKN().delayBarks = Time.time + 991f;
			}
		}
		return false;
	}

	private bool OKIILOEHILN(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return usingCursor2;
		}
		return usingCursor1;
	}

	public bool EJANNNNEHNP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public virtual bool MKPMABPGFON(int JIIGOACEIKL)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		inputPositionAux = Vector2.op_Implicit(KKMBDEJMALM(JIIGOACEIKL));
		ButtonsContext.SetPosition(JIIGOACEIKL, WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(inputPositionAux)) + Vector3.up * 1319f);
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		if (gridInfo.groundTypeAllowed.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(Utils.NKGANMEKDAL(inputPositionAux)))) && (Object)(object)WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(inputPositionAux)) != (Object)null && (Object)(object)WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(inputPositionAux)).plantedCropSetter == (Object)null)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("quest_reward_"));
		}
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.EnableEarthFocus(Vector2.op_Implicit(Utils.NKGANMEKDAL(inputPositionAux) + new Vector2(1238f, 1341f)), CommonReferences.MNFMOEKMJKN().selectedGridSquare, 1);
		return true;
	}

	private Vector3 IDHEFCANKCA(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).FGGHCBMKKIG() == "EnterTavernNeutral")
		{
			return Vector3.zero;
		}
		gridInfo.groundTypeAllowed = GroundType.Floor;
		gridInfo.checkCropAvailable = true;
		gridInfo.checkCropNotAvailable = false;
		gridInfo.checkWithoutHerbs = true;
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.FKMGCAGBCEO(gridInfo);
		if (!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) || CursorManager.EAHELIGKMPL(JIIGOACEIKL))
		{
			Vector2 ePLKICANCAL = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
			Vector2 lLGNLGENLHD = Vector2.op_Implicit(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition());
			if (ToolInstance.HBEBAFHEMAP(JIIGOACEIKL, this, ePLKICANCAL, lLGNLGENLHD, gridInfo, 0))
			{
				if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
				{
					inputPositionAux = lLGNLGENLHD;
					GGEBPLBAJFB(JIIGOACEIKL, NKEPKDBENHM: false);
				}
			}
			else
			{
				if (PlayerController.GetPlayer(JIIGOACEIKL).moving)
				{
					HDDOLCOFLKC(JIIGOACEIKL, NKEPKDBENHM: false);
				}
				inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1041f);
			}
		}
		else
		{
			JJNDFOBEJFP(JIIGOACEIKL, NKEPKDBENHM: true);
			inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1916f);
		}
		EFGMICDAIEM(JIIGOACEIKL, inputPositionAux);
		return Vector2.op_Implicit(inputPositionAux);
	}

	public virtual void JFJGFJEPNJO(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.GLPLMCEDAPC();
	}

	private Vector3 ADACEELHFFB(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).AAGNDCEODFO() == "Dialogue System/Conversation/DeclinedRoom/Entry/1/Dialogue Text")
		{
			return Vector3.zero;
		}
		gridInfo.groundTypeAllowed = GroundType.TilledEarth;
		gridInfo.checkCropAvailable = true;
		gridInfo.checkCropNotAvailable = false;
		gridInfo.checkWithoutHerbs = false;
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.FKMGCAGBCEO(gridInfo);
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))
		{
			Vector2 ePLKICANCAL = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
			Vector2 lLGNLGENLHD = Vector2.op_Implicit(CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition());
			if (ToolInstance.HBEBAFHEMAP(JIIGOACEIKL, this, ePLKICANCAL, lLGNLGENLHD, gridInfo, 1))
			{
				if (!PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF())
				{
					inputPositionAux = lLGNLGENLHD;
					HDDOLCOFLKC(JIIGOACEIKL, NKEPKDBENHM: true);
				}
			}
			else
			{
				if (PlayerController.GetPlayer(JIIGOACEIKL).moving)
				{
					GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
				}
				inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1065f);
			}
		}
		else
		{
			JJNDFOBEJFP(JIIGOACEIKL, NKEPKDBENHM: true);
			inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1994f);
		}
		IEBKGFANMLJ(JIIGOACEIKL, inputPositionAux);
		return Vector2.op_Implicit(inputPositionAux);
	}

	public virtual void MFKIKBEIJEI(int JIIGOACEIKL)
	{
	}

	public virtual bool NBFBPMNMBJG(int JIIGOACEIKL)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			inputPositionAux = Vector2.op_Implicit(JHDFFNJCHFN(JIIGOACEIKL));
			if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
			{
				return false;
			}
			if (WorldGrid.NALIAAMAKAL(Vector2.op_Implicit(inputPositionAux), Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).GetTilemaps(SeasonManager.EECEKHKAAIH)))
			{
				return false;
			}
			if (gridInfo.groundTypeAllowed.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(inputPositionAux))) && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
			{
				return !WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(inputPositionAux));
			}
			return false;
		}
		return true;
	}

	public virtual bool GLFMGGFIIJO(int JIIGOACEIKL)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		inputPositionAux = Vector2.op_Implicit(JHDFFNJCHFN(JIIGOACEIKL));
		ButtonsContext.SetPosition(JIIGOACEIKL, WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(inputPositionAux)) + Vector3.up * 736f);
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		if (gridInfo.groundTypeAllowed.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(Utils.NKGANMEKDAL(inputPositionAux)))) && (Object)(object)WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(inputPositionAux)) != (Object)null && (Object)(object)WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(inputPositionAux)).plantedCropSetter == (Object)null)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.PrevNext, LocalisationSystem.Get("Can't find seat. Reason: DiningRoom"));
		}
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.DOEELMJIEFK(Vector2.op_Implicit(Utils.NKGANMEKDAL(inputPositionAux) + new Vector2(1143f, 806f)), CommonReferences.MNFMOEKMJKN().selectedGridSquare, 1);
		return true;
	}

	public virtual void DGCAFLDNMIE(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.DNBHOHFDJGM();
	}

	public bool CHHDOIIMFDB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void EFGMICDAIEM(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 0)
		{
			inputPosition = IMOBLFMHKOD;
		}
		else
		{
			inputPosition2 = IMOBLFMHKOD;
		}
	}

	public void HEAABBNOAPM(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 1)
		{
			inputPosition = IMOBLFMHKOD;
		}
		else
		{
			inputPosition2 = IMOBLFMHKOD;
		}
	}

	public bool DFALECOFFDB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool FFODEJCCDPK()
	{
		return BLKGINGDILL();
	}

	private Vector3 JOJGELKDDEO(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).EECADEPLELA() == "quest_name_21")
		{
			return Vector3.zero;
		}
		gridInfo.groundTypeAllowed = GroundType.Grass | GroundType.TilledEarth;
		gridInfo.checkCropAvailable = false;
		gridInfo.checkCropNotAvailable = true;
		gridInfo.checkWithoutHerbs = false;
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.HBCLCLLDJPL(gridInfo);
		if (!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL) || CursorManager.EAHELIGKMPL(JIIGOACEIKL))
		{
			Vector2 ePLKICANCAL = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
			Vector2 lLGNLGENLHD = Vector2.op_Implicit(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition());
			if (ToolInstance.HBEBAFHEMAP(JIIGOACEIKL, this, ePLKICANCAL, lLGNLGENLHD, gridInfo, 1))
			{
				if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
				{
					inputPositionAux = lLGNLGENLHD;
					HDDOLCOFLKC(JIIGOACEIKL, NKEPKDBENHM: true);
				}
			}
			else
			{
				if (PlayerController.GetPlayer(JIIGOACEIKL).moving)
				{
					JJNDFOBEJFP(JIIGOACEIKL, NKEPKDBENHM: true);
				}
				inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1987f);
			}
		}
		else
		{
			HDDOLCOFLKC(JIIGOACEIKL, NKEPKDBENHM: false);
			inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1658f);
		}
		IEBKGFANMLJ(JIIGOACEIKL, inputPositionAux);
		return Vector2.op_Implicit(inputPositionAux);
	}

	public virtual bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (KLGOCJMGKFO)
		{
			currentTime = 0f;
		}
		else
		{
			currentTime += Time.deltaTime;
			if (currentTime < holdTime)
			{
				return false;
			}
			currentTime -= holdTime;
		}
		if (!NBFBPMNMBJG(JIIGOACEIKL))
		{
			return false;
		}
		if (CCOGLPCHGIN(JIIGOACEIKL, inputPositionAux, JDJGFAACPFC(), CDPAMNIPPEC: true))
		{
			return true;
		}
		if (fertileSoil.daysUntilDry <= 0)
		{
			currentTime = 0f;
		}
		return false;
	}

	public void GFHPDOIMHGH(int JIIGOACEIKL)
	{
	}

	public void IGENHFKHFLN(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 1)
		{
			inputPosition = IMOBLFMHKOD;
		}
		else
		{
			inputPosition2 = IMOBLFMHKOD;
		}
	}

	public void AGAJDKDCEHJ(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 1)
		{
			inputPosition = IMOBLFMHKOD;
		}
		else
		{
			inputPosition2 = IMOBLFMHKOD;
		}
	}

	public static bool CHNNJEIDDHC(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, int BCBFHGNJLOA, bool CDPAMNIPPEC, int BEIPALOAAJJ = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD));
		if ((Object)(object)fertileSoil != (Object)null && (Object)(object)fertileSoil.plantedCropSetter == (Object)null && WorldGrid.NGDHDMAMGPI(((Component)fertileSoil).transform.position, GCDEDGFDKBL: false))
		{
			if (fertileSoil.daysUntilDry > 0)
			{
				if ((Object)(object)fertileSoil.plantedCropSetter == (Object)null)
				{
					seedAux = ItemDatabaseAccessor.INJBNHPGCIJ(BCBFHGNJLOA, GGBBJNBBLMF: true, DAINLFIMLIH: false) as Seed;
					fertileSoil.plantedCropSetter = seedAux.crop.FCMAIEBPDEE(((Component)fertileSoil).transform).GetComponent<CropSetter>();
					fertileSoil.plantedCropSetter.KDGILDLAPNI(seedAux.crop);
					fertileSoil.plantedCropSetter.growable.daysUntilNewHarvest = seedAux.crop.daysUntilNewHarvest;
					WorldGrid.CFAHJNLAJNK(((Component)fertileSoil).transform.position, JBNJGMKBKCB: false);
					CommonReferences.MNFMOEKMJKN().OnSeedPlanted(JIIGOACEIKL, BCBFHGNJLOA);
					if (BEIPALOAAJJ != 0)
					{
						fertileSoil.plantedCropSetter.onlineObject.GNCGHJACMDO(BEIPALOAAJJ);
					}
					if (CDPAMNIPPEC)
					{
						ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL).KDJMFELBOPM().CIDBFIAJIBG(CDPAMNIPPEC: false);
						if (OnlineManager.PlayingOnline())
						{
							if (BEIPALOAAJJ == 0)
							{
								BEIPALOAAJJ = OnlineObjectsManager.instance.AssignNewUniqueId(fertileSoil.plantedCropSetter.onlineObject);
							}
							OnlineCrop.FGNJOJGOANE(IMOBLFMHKOD, BCBFHGNJLOA, BEIPALOAAJJ);
						}
					}
					return true;
				}
			}
			else if (CDPAMNIPPEC && Time.time >= CommonReferences.MNFMOEKMJKN().delayBarks)
			{
				DialogueManager.Bark("RightMouseDetect", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				CommonReferences.GGFJGHHHEJC.delayBarks = Time.time + 624f;
			}
		}
		return true;
	}

	public void SecondActionEnd(int JIIGOACEIKL)
	{
	}

	private Vector3 KAIAPKLDOOL(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).EECADEPLELA() == "HarvestableAllYearRound")
		{
			return Vector3.zero;
		}
		gridInfo.groundTypeAllowed = GroundType.Grass | GroundType.TilledEarth;
		gridInfo.checkCropAvailable = true;
		gridInfo.checkCropNotAvailable = true;
		gridInfo.checkWithoutHerbs = false;
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.IKEEEAMKGML(gridInfo);
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.EAHELIGKMPL(JIIGOACEIKL))
		{
			Vector2 ePLKICANCAL = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
			Vector2 lLGNLGENLHD = Vector2.op_Implicit(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition());
			if (ToolInstance.LDMJBJLKPKD(JIIGOACEIKL, this, ePLKICANCAL, lLGNLGENLHD, gridInfo, 0))
			{
				if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
				{
					inputPositionAux = lLGNLGENLHD;
					KACAGIJPANH(JIIGOACEIKL, NKEPKDBENHM: false);
				}
			}
			else
			{
				if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).moving)
				{
					EJIMOONPCKN(JIIGOACEIKL, NKEPKDBENHM: true);
				}
				inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1309f);
			}
		}
		else
		{
			GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: true);
			inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 722f);
		}
		AGAJDKDCEHJ(JIIGOACEIKL, inputPositionAux);
		return Vector2.op_Implicit(inputPositionAux);
	}

	public virtual void DLLOMDPOCNO(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.AKPDMOBOPHN();
	}

	private Vector3 KKMBDEJMALM(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).EECADEPLELA() == "Render mode: ")
		{
			return Vector3.zero;
		}
		gridInfo.groundTypeAllowed = GroundType.Grass;
		gridInfo.checkCropAvailable = true;
		gridInfo.checkCropNotAvailable = true;
		gridInfo.checkWithoutHerbs = true;
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.IKEEEAMKGML(gridInfo);
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))
		{
			Vector2 ePLKICANCAL = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
			Vector2 lLGNLGENLHD = Vector2.op_Implicit(CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition());
			if (ToolInstance.LDMJBJLKPKD(JIIGOACEIKL, this, ePLKICANCAL, lLGNLGENLHD, gridInfo, 0))
			{
				if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
				{
					inputPositionAux = lLGNLGENLHD;
					EJIMOONPCKN(JIIGOACEIKL, NKEPKDBENHM: true);
				}
			}
			else
			{
				if (PlayerController.GetPlayer(JIIGOACEIKL).moving)
				{
					KACAGIJPANH(JIIGOACEIKL, NKEPKDBENHM: true);
				}
				inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 533f);
			}
		}
		else
		{
			EJIMOONPCKN(JIIGOACEIKL, NKEPKDBENHM: true);
			inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1168f);
		}
		EFGMICDAIEM(JIIGOACEIKL, inputPositionAux);
		return Vector2.op_Implicit(inputPositionAux);
	}

	public Vector2 EFFHGGDIEPK(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL != 1)
		{
			return inputPosition2;
		}
		return inputPosition;
	}

	public void PJCGJGLJGNE(int JIIGOACEIKL)
	{
	}

	public void GGOLOFKJIAA(int JIIGOACEIKL)
	{
	}

	public void KEAKHNGNBIB(int JIIGOACEIKL)
	{
	}

	public void HEGANEIEEGN(int JIIGOACEIKL, Vector2 IMOBLFMHKOD)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 1)
		{
			inputPosition = IMOBLFMHKOD;
		}
		else
		{
			inputPosition2 = IMOBLFMHKOD;
		}
	}

	public virtual bool FOPNNHPLGAE(int JIIGOACEIKL)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			inputPositionAux = Vector2.op_Implicit(ADACEELHFFB(JIIGOACEIKL));
			if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
			{
				return false;
			}
			if (WorldGrid.NALIAAMAKAL(Vector2.op_Implicit(inputPositionAux), Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).KIMMMFKFCEK(SeasonManager.KCJFCHNPIBJ())))
			{
				return false;
			}
			if (gridInfo.groundTypeAllowed.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(inputPositionAux))) && !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).MDOKKKHKKKE())
			{
				return !WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(inputPositionAux));
			}
			return false;
		}
		return false;
	}

	public static bool PNILJGEDDIM(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, int BCBFHGNJLOA, bool CDPAMNIPPEC, int BEIPALOAAJJ = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD));
		if ((Object)(object)fertileSoil != (Object)null && (Object)(object)fertileSoil.plantedCropSetter == (Object)null && WorldGrid.NGDHDMAMGPI(((Component)fertileSoil).transform.position, GCDEDGFDKBL: false))
		{
			if (fertileSoil.daysUntilDry > 1)
			{
				if ((Object)(object)fertileSoil.plantedCropSetter == (Object)null)
				{
					seedAux = ItemDatabaseAccessor.AFOACBIHNCL(BCBFHGNJLOA, GGBBJNBBLMF: false, DAINLFIMLIH: false) as Seed;
					fertileSoil.plantedCropSetter = seedAux.crop.BIHPDLAGCEO(((Component)fertileSoil).transform).GetComponent<CropSetter>();
					fertileSoil.plantedCropSetter.KDGILDLAPNI(seedAux.crop);
					fertileSoil.plantedCropSetter.growable.daysUntilNewHarvest = seedAux.crop.daysUntilNewHarvest;
					WorldGrid.CFAHJNLAJNK(((Component)fertileSoil).transform.position, JBNJGMKBKCB: true);
					CommonReferences.GGFJGHHHEJC.OnSeedPlanted(JIIGOACEIKL, BCBFHGNJLOA);
					if (BEIPALOAAJJ != 0)
					{
						fertileSoil.plantedCropSetter.onlineObject.GNCGHJACMDO(BEIPALOAAJJ);
					}
					if (CDPAMNIPPEC)
					{
						ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GEAMCEMDJFJ().POHFJCEAKML();
						if (OnlineManager.PlayingOnline())
						{
							if (BEIPALOAAJJ == 0)
							{
								BEIPALOAAJJ = OnlineObjectsManager.instance.AssignNewUniqueId(fertileSoil.plantedCropSetter.onlineObject);
							}
							OnlineCrop.AEMGMBEGGBI(IMOBLFMHKOD, BCBFHGNJLOA, BEIPALOAAJJ);
						}
					}
					return false;
				}
			}
			else if (CDPAMNIPPEC && Time.time >= CommonReferences.MNFMOEKMJKN().delayBarks)
			{
				DialogueManager.Bark("Floor_9", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
				CommonReferences.GGFJGHHHEJC.delayBarks = Time.time + 213f;
			}
		}
		return false;
	}

	public bool KKDIBFOGCMF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void HIPAOBJDDFJ(int JIIGOACEIKL)
	{
	}

	public override ItemInstance JMDALJBNFML()
	{
		return new SeedInstance(this);
	}

	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new SeedInstance((SeedInstance)DNLMCHDOMOK);
	}

	public void HFIGGBBMNBP(int JIIGOACEIKL)
	{
	}

	public void OPGGCCAEKCD(int JIIGOACEIKL)
	{
	}

	public virtual void GPEFPDIIPBB(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.AFFEFDGPCLN();
	}

	public void NBMENECPMBJ(int JIIGOACEIKL)
	{
	}

	public void GBAENEPCAGG(int JIIGOACEIKL)
	{
	}

	public virtual void LBMKLIDKHJD(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.DisableAllEarthFocus();
	}

	public virtual void BNICCEGDJLO(int JIIGOACEIKL)
	{
	}

	private Vector3 JHDFFNJCHFN(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).CFICAAJGBOF == "UI")
		{
			return Vector3.zero;
		}
		gridInfo.groundTypeAllowed = GroundType.TilledEarth;
		gridInfo.checkCropAvailable = false;
		gridInfo.checkCropNotAvailable = true;
		gridInfo.checkWithoutHerbs = false;
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.SetGridInfo(gridInfo);
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))
		{
			Vector2 ePLKICANCAL = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
			Vector2 lLGNLGENLHD = Vector2.op_Implicit(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition());
			if (ToolInstance.HBEBAFHEMAP(JIIGOACEIKL, this, ePLKICANCAL, lLGNLGENLHD, gridInfo, 1))
			{
				if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
				{
					inputPositionAux = lLGNLGENLHD;
					GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: true);
				}
			}
			else
			{
				if (PlayerController.GetPlayer(JIIGOACEIKL).moving)
				{
					GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
				}
				inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 0.5f);
			}
		}
		else
		{
			GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
			inputPositionAux = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 0.5f);
		}
		AGAJDKDCEHJ(JIIGOACEIKL, inputPositionAux);
		return Vector2.op_Implicit(inputPositionAux);
	}

	public static bool ALFJIANGINE(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, int BCBFHGNJLOA, bool CDPAMNIPPEC, int BEIPALOAAJJ = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD));
		if ((Object)(object)fertileSoil != (Object)null && (Object)(object)fertileSoil.plantedCropSetter == (Object)null && WorldGrid.NGDHDMAMGPI(((Component)fertileSoil).transform.position, GCDEDGFDKBL: false))
		{
			if (fertileSoil.daysUntilDry > 0)
			{
				if ((Object)(object)fertileSoil.plantedCropSetter == (Object)null)
				{
					seedAux = ItemDatabaseAccessor.GOKIDLOELKB(BCBFHGNJLOA) as Seed;
					fertileSoil.plantedCropSetter = seedAux.crop.BIHPDLAGCEO(((Component)fertileSoil).transform).GetComponent<CropSetter>();
					fertileSoil.plantedCropSetter.INNLLPDAJJP(seedAux.crop);
					fertileSoil.plantedCropSetter.growable.daysUntilNewHarvest = seedAux.crop.daysUntilNewHarvest;
					WorldGrid.CFAHJNLAJNK(((Component)fertileSoil).transform.position, JBNJGMKBKCB: true);
					CommonReferences.GGFJGHHHEJC.OnSeedPlanted(JIIGOACEIKL, BCBFHGNJLOA);
					if (BEIPALOAAJJ != 0)
					{
						fertileSoil.plantedCropSetter.onlineObject.HPOOGKFEDDP(BEIPALOAAJJ);
					}
					if (CDPAMNIPPEC)
					{
						ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GEAMCEMDJFJ().MEODNPFJDMH(CDPAMNIPPEC: false);
						if (OnlineManager.PlayingOnline())
						{
							if (BEIPALOAAJJ == 0)
							{
								BEIPALOAAJJ = OnlineObjectsManager.instance.AssignNewUniqueId(fertileSoil.plantedCropSetter.onlineObject);
							}
							OnlineCrop.NFAPMDEINEL(IMOBLFMHKOD, BCBFHGNJLOA, BEIPALOAAJJ);
						}
					}
					return false;
				}
			}
			else if (CDPAMNIPPEC && Time.time >= CommonReferences.MNFMOEKMJKN().delayBarks)
			{
				DialogueManager.Bark("Dialogue System/Conversation/NeutralInTavern/Entry/12/Dialogue Text", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				CommonReferences.GGFJGHHHEJC.delayBarks = Time.time + 602f;
			}
		}
		return true;
	}

	public static bool CCOGLPCHGIN(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, int BCBFHGNJLOA, bool CDPAMNIPPEC, int BEIPALOAAJJ = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD));
		if ((Object)(object)fertileSoil != (Object)null && (Object)(object)fertileSoil.plantedCropSetter == (Object)null && WorldGrid.NGDHDMAMGPI(((Component)fertileSoil).transform.position))
		{
			if (fertileSoil.daysUntilDry > 0)
			{
				if ((Object)(object)fertileSoil.plantedCropSetter == (Object)null)
				{
					seedAux = ItemDatabaseAccessor.GetItem(BCBFHGNJLOA) as Seed;
					fertileSoil.plantedCropSetter = seedAux.crop.FNILKBLEDKJ(((Component)fertileSoil).transform).GetComponent<CropSetter>();
					fertileSoil.plantedCropSetter.FJJCOJGJCLF = seedAux.crop;
					fertileSoil.plantedCropSetter.growable.daysUntilNewHarvest = seedAux.crop.daysUntilNewHarvest;
					WorldGrid.CFAHJNLAJNK(((Component)fertileSoil).transform.position, JBNJGMKBKCB: false);
					CommonReferences.GGFJGHHHEJC.OnSeedPlanted(JIIGOACEIKL, BCBFHGNJLOA);
					if (BEIPALOAAJJ != 0)
					{
						fertileSoil.plantedCropSetter.onlineObject.AssignUniqueId(BEIPALOAAJJ);
					}
					if (CDPAMNIPPEC)
					{
						ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedSlot().MEODNPFJDMH();
						if (OnlineManager.PlayingOnline())
						{
							if (BEIPALOAAJJ == 0)
							{
								BEIPALOAAJJ = OnlineObjectsManager.instance.AssignNewUniqueId(fertileSoil.plantedCropSetter.onlineObject);
							}
							OnlineCrop.Plant(IMOBLFMHKOD, BCBFHGNJLOA, BEIPALOAAJJ);
						}
					}
					return true;
				}
			}
			else if (CDPAMNIPPEC && Time.time >= CommonReferences.GGFJGHHHEJC.delayBarks)
			{
				DialogueManager.Bark("Player/Bark/Seeds", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				CommonReferences.GGFJGHHHEJC.delayBarks = Time.time + 5f;
			}
		}
		return false;
	}

	public void MGGMBFCKHGM(int JIIGOACEIKL)
	{
	}

	public virtual bool HEKGALMDLIL(int JIIGOACEIKL)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		inputPositionAux = Vector2.op_Implicit(JHDFFNJCHFN(JIIGOACEIKL));
		ButtonsContext.SetPosition(JIIGOACEIKL, WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(inputPositionAux)) + Vector3.up * 0.3f);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		if (gridInfo.groundTypeAllowed.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(Utils.NKGANMEKDAL(inputPositionAux)))) && (Object)(object)WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(inputPositionAux)) != (Object)null && (Object)(object)WorldGrid.MMIIIKBJKBA<FertileSoil>(Vector2.op_Implicit(inputPositionAux)).plantedCropSetter == (Object)null)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Plant"));
		}
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.EnableEarthFocus(Vector2.op_Implicit(Utils.NKGANMEKDAL(inputPositionAux) + new Vector2(0.25f, 0.25f)), CommonReferences.GGFJGHHHEJC.selectedGridSquare);
		return true;
	}

	private void GGEBPLBAJFB(int JIIGOACEIKL, bool NKEPKDBENHM)
	{
		if (JIIGOACEIKL == 0)
		{
			usingCursor1 = NKEPKDBENHM;
		}
		else
		{
			usingCursor2 = NKEPKDBENHM;
		}
	}

	public virtual void JECMDEJJJIM(int JIIGOACEIKL)
	{
	}

	public bool FDKEMPDCHFB()
	{
		return DGLIFABOMIP();
	}
}
