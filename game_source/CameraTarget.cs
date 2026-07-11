using System;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
	private static CameraTarget IADEMLIIDPC;

	private static CameraTarget BBINLIGKIPE;

	public Transform player;

	public int playerNum = 1;

	public bool movementDisabled;

	public float speed = 6f;

	public PixelPerfectCamera pixelPerfect;

	public Vector3 offset;

	public Vector2 startPosition;

	public Vector2 endPosition;

	public float travellingTime = 2f;

	public float waitTime = 2f;

	public bool lineal;

	private bool MILNEPJHBDE;

	private float CMHOJLKDHLH;

	private float GHHFENCPMAL;

	private float DCGBADKLANM;

	private int LMJDICEAONP = 999;

	private float PBHNHGFDONC;

	private TavernZone BOCAKOFIHKE;

	public bool inDiningZone;

	private float HFKLIGEHLJI;

	private float MCOMPFOIONJ;

	private float LDPBAFFCNDK;

	public bool leftCameraLimitActivated;

	public Transform leftCameraPositionXLimit;

	private float KKJCIGECIAE;

	private float ANDNBDNCKNO;

	private bool GABMNBHJGMJ;

	private void BPMFFCJDOJG(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.EKCCGNEDPNO(IMOBLFMHKOD, playerNum);
	}

	private float HINBJCJNLAA()
	{
		if (AOKFMOFPIBF())
		{
			LDPBAFFCNDK = offset.y * pixelPerfect.fovCoverage / 2.5f;
		}
		else
		{
			LDPBAFFCNDK = offset.y * pixelPerfect.fovCoverage;
		}
		LDPBAFFCNDK *= pixelPerfect.fovCoverage;
		return PBHNHGFDONC + LDPBAFFCNDK;
	}

	private void IHICKHAABJH()
	{
		if (playerNum == 0)
		{
			IADEMLIIDPC = this;
			DevConsole.instance.player1CameraTarget = this;
		}
		else if (playerNum == 6)
		{
			BBINLIGKIPE = this;
		}
	}

	private void ILBGPIEPNGO()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		if (movementDisabled)
		{
			return;
		}
		if (PiratesGameManager.Playing && (Object)(object)player != (Object)null)
		{
			KKOJLJAGJKM(PiratesGameManager.instance.startingPoints[0].position);
		}
		else if ((Object)(object)FishCuttingGameManager.instance != (Object)null && ((Behaviour)FishCuttingGameManager.instance).enabled && (Object)(object)player != (Object)null)
		{
			PILLPADODMB(FishCuttingGameManager.instance.cameraPosition.position);
		}
		else if (MILNEPJHBDE)
		{
			if (GHHFENCPMAL > 388f)
			{
				GHHFENCPMAL -= Time.deltaTime;
				if (CMHOJLKDHLH == travellingTime && GHHFENCPMAL <= 1303f)
				{
					MILNEPJHBDE = false;
				}
			}
			else if (CMHOJLKDHLH < travellingTime)
			{
				CMHOJLKDHLH += Time.deltaTime;
				if (CMHOJLKDHLH > travellingTime)
				{
					CMHOJLKDHLH = travellingTime;
					GHHFENCPMAL = waitTime;
				}
				DCGBADKLANM = CMHOJLKDHLH / travellingTime;
				if (!lineal)
				{
					DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (1078f * DCGBADKLANM - 1592f) + 1484f);
				}
				BKCBJBCJNKO(Vector3.Lerp(Vector2.op_Implicit(startPosition), Vector2.op_Implicit(endPosition), DCGBADKLANM));
			}
		}
		else
		{
			if (!((Object)(object)player != (Object)null))
			{
				return;
			}
			GBAKCNMGAHH();
			if (leftCameraLimitActivated)
			{
				KPKDFNIHEJC();
				if ((Object)(object)leftCameraPositionXLimit != (Object)null)
				{
					LDJEKEJINEB(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), new Vector2(Mathf.Max(player.position.x, leftCameraPositionXLimit.position.x + KKJCIGECIAE), player.position.y), Time.unscaledDeltaTime * speed)));
				}
				else
				{
					leftCameraLimitActivated = false;
				}
			}
			else if (FishingController.NAGEHKBLJDL(playerNum).fishingCamera && PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				KKOJLJAGJKM(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y - 642f, Time.unscaledDeltaTime * 1433f))));
				MCOMPFOIONJ = Time.realtimeSinceStartup;
			}
			else if (MCOMPFOIONJ + 6f > Time.realtimeSinceStartup)
			{
				CHEGKCPBHGL(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y, Time.unscaledDeltaTime * 989f))));
			}
			else if (inDiningZone)
			{
				if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
				{
					IBNKFAJMFDE();
					IABLEKBDMEJ();
					return;
				}
				if (HFKLIGEHLJI < 527f)
				{
					HFKLIGEHLJI += Time.deltaTime;
				}
				if (player.position.y - 76f > PBHNHGFDONC)
				{
					KPKDFNIHEJC();
				}
				if (HFKLIGEHLJI >= 1220f)
				{
					if (player.position.y < OGFEFMBEGFM())
					{
						AGNAHAEDPBH(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y, Time.unscaledDeltaTime * 1902f))));
					}
					else
					{
						BPMFFCJDOJG(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, OGFEFMBEGFM(), Time.unscaledDeltaTime * 1350f))));
					}
				}
				else
				{
					CKHDMKBOJKK();
				}
			}
			else if (PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA == ~(Location.Tavern | Location.Quarry | Location.Farm))
			{
				switch ((Utils.JGEPCPFJANP(~(Location.Road | Location.Camp)) as BarnTilemapScene).barnLevel)
				{
				case 0:
					LDJEKEJINEB(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), HFLHEALFJAB(305f, 206f, 82f, 1444f), Time.unscaledDeltaTime * speed)));
					break;
				case 1:
					KKOJLJAGJKM(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), HFLHEALFJAB(1989f, 671f, 392f, 1172f), Time.unscaledDeltaTime * speed)));
					break;
				case 2:
					AGNAHAEDPBH(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), GCBIHFHGILA(615f, 907f, 495f, 1310f), Time.unscaledDeltaTime * speed)));
					break;
				default:
					IABLEKBDMEJ();
					break;
				}
			}
			else
			{
				IABLEKBDMEJ();
			}
		}
	}

	public static void SetCameraTarget(int JIIGOACEIKL, Transform FHLJHHGPOPC)
	{
		GetPlayer(JIIGOACEIKL).player = FHLJHHGPOPC;
	}

	private void LHABENPEMPB()
	{
		if (playerNum == 0)
		{
			IADEMLIIDPC = this;
			DevConsole.instance.player1CameraTarget = this;
		}
		else if (playerNum == 8)
		{
			BBINLIGKIPE = this;
		}
	}

	private bool MKDFJIEKPNH()
	{
		if (pixelPerfect.targetCameraHeight < 1859f)
		{
			return true;
		}
		return false;
	}

	private void OBGNPHOHAAF(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		ONJMHKEDGJB();
	}

	private void INCOGEMNFNH()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		if (movementDisabled)
		{
			return;
		}
		if (PiratesGameManager.Playing && (Object)(object)player != (Object)null)
		{
			CHEGKCPBHGL(PiratesGameManager.instance.startingPoints[0].position);
		}
		else if ((Object)(object)FishCuttingGameManager.instance != (Object)null && ((Behaviour)FishCuttingGameManager.instance).enabled && (Object)(object)player != (Object)null)
		{
			BKCBJBCJNKO(FishCuttingGameManager.instance.cameraPosition.position);
		}
		else if (MILNEPJHBDE)
		{
			if (GHHFENCPMAL > 774f)
			{
				GHHFENCPMAL -= Time.deltaTime;
				if (CMHOJLKDHLH == travellingTime && GHHFENCPMAL <= 1948f)
				{
					MILNEPJHBDE = true;
				}
			}
			else if (CMHOJLKDHLH < travellingTime)
			{
				CMHOJLKDHLH += Time.deltaTime;
				if (CMHOJLKDHLH > travellingTime)
				{
					CMHOJLKDHLH = travellingTime;
					GHHFENCPMAL = waitTime;
				}
				DCGBADKLANM = CMHOJLKDHLH / travellingTime;
				if (!lineal)
				{
					DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (1623f * DCGBADKLANM - 300f) + 965f);
				}
				BPMFFCJDOJG(Vector3.Lerp(Vector2.op_Implicit(startPosition), Vector2.op_Implicit(endPosition), DCGBADKLANM));
			}
		}
		else
		{
			if (!((Object)(object)player != (Object)null))
			{
				return;
			}
			PMJNAPINLJB();
			if (leftCameraLimitActivated)
			{
				KPKDFNIHEJC();
				if ((Object)(object)leftCameraPositionXLimit != (Object)null)
				{
					BKCBJBCJNKO(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), new Vector2(Mathf.Max(player.position.x, leftCameraPositionXLimit.position.x + KKJCIGECIAE), player.position.y), Time.unscaledDeltaTime * speed)));
				}
				else
				{
					leftCameraLimitActivated = false;
				}
			}
			else if (FishingController.NIGDBMAOAEN(playerNum).fishingCamera && PlayerController.GetPlayerDirection(playerNum) == Direction.Up)
			{
				CHEGKCPBHGL(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y - 1920f, Time.unscaledDeltaTime * 1105f))));
				MCOMPFOIONJ = Time.realtimeSinceStartup;
			}
			else if (MCOMPFOIONJ + 530f > Time.realtimeSinceStartup)
			{
				BKCBJBCJNKO(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y, Time.unscaledDeltaTime * 308f))));
			}
			else if (inDiningZone)
			{
				if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
				{
					IBNKFAJMFDE();
					OMILNGJGMEH();
					return;
				}
				if (HFKLIGEHLJI < 1823f)
				{
					HFKLIGEHLJI += Time.deltaTime;
				}
				if (player.position.y - 1985f > PBHNHGFDONC)
				{
					KPKDFNIHEJC();
				}
				if (HFKLIGEHLJI >= 1763f)
				{
					if (player.position.y < OGFEFMBEGFM())
					{
						AGNAHAEDPBH(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y, Time.unscaledDeltaTime * 1163f))));
					}
					else
					{
						CHEGKCPBHGL(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, OGFEFMBEGFM(), Time.unscaledDeltaTime * 1095f))));
					}
				}
				else
				{
					OMILNGJGMEH();
				}
			}
			else if (PlayerController.GetPlayer(playerNum).LEOIMFNKFGA == ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior))
			{
				switch ((Utils.JGEPCPFJANP(~(Location.Tavern | Location.Road | Location.Camp | Location.Farm)) as BarnTilemapScene).barnLevel)
				{
				case 0:
					BPMFFCJDOJG(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), HFLHEALFJAB(1209f, 1277f, 1520f, 148f), Time.unscaledDeltaTime * speed)));
					break;
				case 1:
					BPMFFCJDOJG(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), HFLHEALFJAB(1280f, 1129f, 151f, 1453f), Time.unscaledDeltaTime * speed)));
					break;
				case 2:
					CHEGKCPBHGL(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), HFLHEALFJAB(1550f, 298f, 617f, 728f), Time.unscaledDeltaTime * speed)));
					break;
				default:
					IABLEKBDMEJ();
					break;
				}
			}
			else
			{
				PHBHBBBHDKI();
			}
		}
	}

	private void CHDEOJALBFK()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(IBNKFAJMFDE));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnTravel = (Action<int>)Delegate.Remove(instance2.OnTravel, new Action<int>(CACEGJBOICK));
			}
		}
	}

	private void Awake()
	{
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
			DevConsole.instance.player1CameraTarget = this;
		}
		else if (playerNum == 2)
		{
			BBINLIGKIPE = this;
		}
	}

	public static void DAOIJLBKNPJ(int JIIGOACEIKL, Transform FHLJHHGPOPC)
	{
		GBBEJMADEJC(JIIGOACEIKL).player = FHLJHHGPOPC;
	}

	private void OMILNGJGMEH()
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (GABMNBHJGMJ)
		{
			ANDNBDNCKNO += Time.unscaledDeltaTime;
			BPMFFCJDOJG(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(player.position), Time.unscaledDeltaTime * Mathf.Lerp(speed * 0.1f, speed, ANDNBDNCKNO * 0.5f))));
			if (ANDNBDNCKNO >= 2f)
			{
				GABMNBHJGMJ = false;
			}
		}
		else
		{
			BPMFFCJDOJG(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(player.position), Time.unscaledDeltaTime * speed)));
		}
	}

	private void NCKIFPPKMHB(int GELMAIBEHDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (playerNum == GELMAIBEHDO)
		{
			PILLPADODMB(player.position);
		}
	}

	private void CHEGKCPBHGL(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.EKCCGNEDPNO(IMOBLFMHKOD, playerNum);
	}

	private void AKPDFFMLDDH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.APJABAKKKGD(player.position) != LMJDICEAONP)
		{
			LMJDICEAONP = WorldGrid.APJABAKKKGD(player.position);
			if (TavernZonesManager.NHKAFANMEJC().tavernZones.TryGetValue(LMJDICEAONP, out BOCAKOFIHKE) && BOCAKOFIHKE.zoneType == ZoneType.WithoutZone)
			{
				PBHNHGFDONC = BOCAKOFIHKE.NFLNDAFHBOL();
				inDiningZone = true;
			}
		}
	}

	private void OIAHJHNPPCO()
	{
		pixelPerfect = CommonReferences.MNFMOEKMJKN().GetPixelPerfectCamera(playerNum);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BJKKOGPKGCM));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravel = (Action<int>)Delegate.Combine(commonReferences.OnTravel, new Action<int>(BOMOLAANGHO));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		GraphicsMenuUI instance2 = GraphicsMenuUI.GGFJGHHHEJC;
		instance2.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance2.OnResolutionChange, new Action<int, int, float>(OBGNPHOHAAF));
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnZoomChanged = (Action)Delegate.Combine(graphicsMenuUI.OnZoomChanged, new Action(AEENOGPMKCE));
		AHDMAMHFKGC();
	}

	private void KLBLBHHJLPL(int GELMAIBEHDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (playerNum == GELMAIBEHDO)
		{
			PILLPADODMB(player.position);
		}
	}

	private void FJBPFOIALMK()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BJKKOGPKGCM));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnTravel = (Action<int>)Delegate.Remove(instance2.OnTravel, new Action<int>(NMCAKFKFFCM));
			}
		}
	}

	private bool GLPJGBKBDIO()
	{
		if (pixelPerfect.targetCameraHeight < 1916f)
		{
			return true;
		}
		return true;
	}

	private void BGPOEJAJJOL()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		Camera mainCamera = CommonReferences.GGFJGHHHEJC.GetMainCamera(playerNum);
		Vector2 val = Vector2.op_Implicit(mainCamera.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(0f, 0f))));
		Vector2 val2 = Vector2.op_Implicit(mainCamera.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(0.5f, 0f))));
		KKJCIGECIAE = Mathf.Abs(val2.x - val.x);
	}

	private void LDJEKEJINEB(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.EKCCGNEDPNO(IMOBLFMHKOD, playerNum);
	}

	private void NLPOBLFPDGL(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		NPAGKJCIMCN();
	}

	private void HKJDCBMGCMK(int GELMAIBEHDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (playerNum == GELMAIBEHDO)
		{
			AGNAHAEDPBH(player.position);
		}
	}

	private void HINKPJCNPCF()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(IFPLGOBEIAI));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(MNNLNDHDKNM));
			}
		}
	}

	private void AHDMAMHFKGC()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		Camera obj = CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(playerNum);
		Vector2 val = Vector2.op_Implicit(obj.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(320f, 29f))));
		Vector2 val2 = Vector2.op_Implicit(obj.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(1061f, 1451f))));
		KKJCIGECIAE = Mathf.Abs(val2.x - val.x);
	}

	private bool KFHONKCPALK()
	{
		if (pixelPerfect.targetCameraHeight < 1196f)
		{
			return false;
		}
		return false;
	}

	private bool DPHEAKHBFCO()
	{
		if (pixelPerfect.targetCameraHeight < 1223f)
		{
			return false;
		}
		return false;
	}

	public void PBFBIIHKFCI()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		MILNEPJHBDE = false;
		CMHOJLKDHLH = 4f;
		GHHFENCPMAL = waitTime;
		AGNAHAEDPBH(Vector2.op_Implicit(startPosition));
	}

	private void OEIDBMIDJMF()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		Camera obj = CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(playerNum);
		Vector2 val = Vector2.op_Implicit(obj.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(313f, 1112f))));
		Vector2 val2 = Vector2.op_Implicit(obj.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(1577f, 1007f))));
		KKJCIGECIAE = Mathf.Abs(val2.x - val.x);
	}

	private void HNEKMALGJPO()
	{
		leftCameraLimitActivated = true;
	}

	private void DILNFOONCIM()
	{
		leftCameraLimitActivated = false;
	}

	private float OGFEFMBEGFM()
	{
		if (CHHHFPEJACO())
		{
			LDPBAFFCNDK = offset.y * pixelPerfect.fovCoverage / 1507f;
		}
		else
		{
			LDPBAFFCNDK = offset.y * pixelPerfect.fovCoverage;
		}
		LDPBAFFCNDK *= pixelPerfect.fovCoverage;
		return PBHNHGFDONC + LDPBAFFCNDK;
	}

	private void AEENOGPMKCE()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		BGPOEJAJJOL();
		if (leftCameraLimitActivated)
		{
			BPMFFCJDOJG(Vector2.op_Implicit(new Vector2(Mathf.Max(player.position.x, leftCameraPositionXLimit.position.x + KKJCIGECIAE), player.position.y)));
		}
	}

	private Vector2 GCBIHFHGILA(float MOFDFHOEGDM, float KIEBMECGJPK, float NAOBJANPDFL, float EGOFBELDLOG)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		Vector2 result = Vector2.op_Implicit(player.position);
		if (player.position.x > KIEBMECGJPK)
		{
			result.x = KIEBMECGJPK;
		}
		else if (player.position.x < MOFDFHOEGDM)
		{
			result.x = MOFDFHOEGDM;
		}
		if (player.position.y > EGOFBELDLOG)
		{
			result.y = EGOFBELDLOG;
		}
		else if (player.position.y < NAOBJANPDFL)
		{
			result.y = NAOBJANPDFL;
		}
		return result;
	}

	private void OKAEGLLMBNO()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		if (movementDisabled)
		{
			return;
		}
		if (PiratesGameManager.Playing && (Object)(object)player != (Object)null)
		{
			PILLPADODMB(PiratesGameManager.instance.startingPoints[0].position);
		}
		else if ((Object)(object)FishCuttingGameManager.instance != (Object)null && ((Behaviour)FishCuttingGameManager.instance).enabled && (Object)(object)player != (Object)null)
		{
			PILLPADODMB(FishCuttingGameManager.instance.cameraPosition.position);
		}
		else if (MILNEPJHBDE)
		{
			if (GHHFENCPMAL > 842f)
			{
				GHHFENCPMAL -= Time.deltaTime;
				if (CMHOJLKDHLH == travellingTime && GHHFENCPMAL <= 992f)
				{
					MILNEPJHBDE = false;
				}
			}
			else if (CMHOJLKDHLH < travellingTime)
			{
				CMHOJLKDHLH += Time.deltaTime;
				if (CMHOJLKDHLH > travellingTime)
				{
					CMHOJLKDHLH = travellingTime;
					GHHFENCPMAL = waitTime;
				}
				DCGBADKLANM = CMHOJLKDHLH / travellingTime;
				if (!lineal)
				{
					DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (1048f * DCGBADKLANM - 606f) + 643f);
				}
				BKCBJBCJNKO(Vector3.Lerp(Vector2.op_Implicit(startPosition), Vector2.op_Implicit(endPosition), DCGBADKLANM));
			}
		}
		else
		{
			if (!((Object)(object)player != (Object)null))
			{
				return;
			}
			LDGBGKDMKJM();
			if (leftCameraLimitActivated)
			{
				KPKDFNIHEJC();
				if ((Object)(object)leftCameraPositionXLimit != (Object)null)
				{
					CHEGKCPBHGL(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), new Vector2(Mathf.Max(player.position.x, leftCameraPositionXLimit.position.x + KKJCIGECIAE), player.position.y), Time.unscaledDeltaTime * speed)));
				}
				else
				{
					leftCameraLimitActivated = true;
				}
			}
			else if (FishingController.Get(playerNum).fishingCamera && PlayerController.GetPlayerDirection(playerNum) == Direction.Up)
			{
				BPMFFCJDOJG(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y - 1060f, Time.unscaledDeltaTime * 1642f))));
				MCOMPFOIONJ = Time.realtimeSinceStartup;
			}
			else if (MCOMPFOIONJ + 1682f > Time.realtimeSinceStartup)
			{
				AGNAHAEDPBH(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y, Time.unscaledDeltaTime * 1638f))));
			}
			else if (inDiningZone)
			{
				if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
				{
					KPKDFNIHEJC();
					CKHDMKBOJKK();
					return;
				}
				if (HFKLIGEHLJI < 1752f)
				{
					HFKLIGEHLJI += Time.deltaTime;
				}
				if (player.position.y - 539f > PBHNHGFDONC)
				{
					BJKKOGPKGCM();
				}
				if (HFKLIGEHLJI >= 48f)
				{
					if (player.position.y < OGFEFMBEGFM())
					{
						BKCBJBCJNKO(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y, Time.unscaledDeltaTime * 1863f))));
					}
					else
					{
						KKOJLJAGJKM(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, HINBJCJNLAA(), Time.unscaledDeltaTime * 762f))));
					}
				}
				else
				{
					CKHDMKBOJKK();
				}
			}
			else if (PlayerController.GetPlayer(playerNum).LEOIMFNKFGA == ~(Location.Tavern | Location.Road | Location.River | Location.Camp))
			{
				switch ((Utils.JGEPCPFJANP(~(Location.Quarry | Location.Farm | Location.BarnInterior)) as BarnTilemapScene).barnLevel)
				{
				case 0:
					BPMFFCJDOJG(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), HFLHEALFJAB(808f, 587f, 1260f, 191f), Time.unscaledDeltaTime * speed)));
					break;
				case 1:
					PILLPADODMB(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), GCBIHFHGILA(1792f, 776f, 780f, 983f), Time.unscaledDeltaTime * speed)));
					break;
				case 2:
					KKOJLJAGJKM(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), GCBIHFHGILA(1725f, 1851f, 1502f, 1317f), Time.unscaledDeltaTime * speed)));
					break;
				default:
					CKHDMKBOJKK();
					break;
				}
			}
			else
			{
				PHBHBBBHDKI();
			}
		}
	}

	private void PLKACOMJOLJ(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		BMODFPMNGMA();
	}

	public static void ADMLMPAKPMN(int JIIGOACEIKL)
	{
		MPDMDABCCCA(JIIGOACEIKL).player = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform;
	}

	public static void CPHPKADKHFP(int JIIGOACEIKL)
	{
		GBBEJMADEJC(JIIGOACEIKL).player = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform;
	}

	private bool GNGDHANNGKG()
	{
		if (pixelPerfect.targetCameraHeight < 4f)
		{
			return false;
		}
		return false;
	}

	private void DCPNNAKFECA()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.APJABAKKKGD(player.position) != LMJDICEAONP)
		{
			LMJDICEAONP = WorldGrid.APJABAKKKGD(player.position);
			if (TavernZonesManager.GGFJGHHHEJC.tavernZones.TryGetValue(LMJDICEAONP, out BOCAKOFIHKE) && BOCAKOFIHKE.zoneType == ZoneType.DiningRoom)
			{
				PBHNHGFDONC = BOCAKOFIHKE.CDKIPIIPGGB();
				inDiningZone = true;
			}
		}
	}

	private void BMODFPMNGMA()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		Camera obj = CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(playerNum);
		Vector2 val = Vector2.op_Implicit(obj.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(752f, 1562f))));
		Vector2 val2 = Vector2.op_Implicit(obj.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(1416f, 48f))));
		KKJCIGECIAE = Mathf.Abs(val2.x - val.x);
	}

	public void KNHCIKIGNKI()
	{
		GABMNBHJGMJ = true;
		ANDNBDNCKNO = 1576f;
	}

	private void EBOGCLHBLMJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		HLJGDALAGFA();
		if (leftCameraLimitActivated)
		{
			AGNAHAEDPBH(Vector2.op_Implicit(new Vector2(Mathf.Max(player.position.x, leftCameraPositionXLimit.position.x + KKJCIGECIAE), player.position.y)));
		}
	}

	public static void NFGEDHMEGBL(int JIIGOACEIKL)
	{
		KEHIBCAHKPJ(JIIGOACEIKL).player = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform;
	}

	private void HEGNINLLINP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(IFPLGOBEIAI));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(BFKAMFHNCFF));
			}
		}
	}

	public void OLAFNJNNJJJ()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		MILNEPJHBDE = true;
		CMHOJLKDHLH = 659f;
		GHHFENCPMAL = waitTime;
		BKCBJBCJNKO(Vector2.op_Implicit(startPosition));
	}

	public void EJMKDJOCLEF()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		MILNEPJHBDE = false;
		CMHOJLKDHLH = 1558f;
		GHHFENCPMAL = waitTime;
		PILLPADODMB(Vector2.op_Implicit(startPosition));
	}

	private void NPAGKJCIMCN()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		Camera obj = CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(playerNum);
		Vector2 val = Vector2.op_Implicit(obj.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(1045f, 1672f))));
		Vector2 val2 = Vector2.op_Implicit(obj.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(156f, 1392f))));
		KKJCIGECIAE = Mathf.Abs(val2.x - val.x);
	}

	private bool AOKFMOFPIBF()
	{
		if (pixelPerfect.targetCameraHeight < 500f)
		{
			return true;
		}
		return false;
	}

	private void KHCKJAFHHII()
	{
		leftCameraLimitActivated = false;
	}

	public void SmoothCameraSpeed()
	{
		GABMNBHJGMJ = true;
		ANDNBDNCKNO = 0f;
	}

	public static void BPHGNEPFFKG(int JIIGOACEIKL, Transform FHLJHHGPOPC)
	{
		GBBEJMADEJC(JIIGOACEIKL).player = FHLJHHGPOPC;
	}

	public static CameraTarget GBBEJMADEJC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private void LHIFBLELKNA(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		BGPOEJAJJOL();
	}

	private void PHBHBBBHDKI()
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (GABMNBHJGMJ)
		{
			ANDNBDNCKNO += Time.unscaledDeltaTime;
			LDJEKEJINEB(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(player.position), Time.unscaledDeltaTime * Mathf.Lerp(speed * 1825f, speed, ANDNBDNCKNO * 960f))));
			if (ANDNBDNCKNO >= 354f)
			{
				GABMNBHJGMJ = true;
			}
		}
		else
		{
			CHEGKCPBHGL(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(player.position), Time.unscaledDeltaTime * speed)));
		}
	}

	private void DANAKNIKLDM(int GELMAIBEHDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (playerNum == GELMAIBEHDO)
		{
			LDJEKEJINEB(player.position);
		}
	}

	private void IGNEGEOPLOP()
	{
		if (playerNum == 0)
		{
			IADEMLIIDPC = this;
			DevConsole.instance.player1CameraTarget = this;
		}
		else if (playerNum == 1)
		{
			BBINLIGKIPE = this;
		}
	}

	public void HHIPIMDODAG()
	{
		GABMNBHJGMJ = true;
		ANDNBDNCKNO = 1100f;
	}

	private void CACEGJBOICK(int GELMAIBEHDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (playerNum == GELMAIBEHDO)
		{
			LDJEKEJINEB(player.position);
		}
	}

	private void CODPMDFBCKB()
	{
		leftCameraLimitActivated = true;
	}

	private void MCMKNBIBDFF()
	{
		pixelPerfect = CommonReferences.GGFJGHHHEJC.PLAHJLNNNAK(playerNum);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BJKKOGPKGCM));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(BFKAMFHNCFF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlayerAwake = (Action)Delegate.Combine(instance2.OnPlayerAwake, new Action(CODPMDFBCKB));
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(DHNNMLPOCJO));
		GraphicsMenuUI graphicsMenuUI2 = GraphicsMenuUI.EFPJLFMBPLL();
		graphicsMenuUI2.OnZoomChanged = (Action)Delegate.Combine(graphicsMenuUI2.OnZoomChanged, new Action(EBOGCLHBLMJ));
		OEIDBMIDJMF();
	}

	private bool CHFJEIOAMIN()
	{
		if (pixelPerfect.targetCameraHeight < 405f)
		{
			return false;
		}
		return false;
	}

	private void HCCJBKKGCLJ()
	{
		if (playerNum == 0)
		{
			IADEMLIIDPC = this;
			DevConsole.instance.player1CameraTarget = this;
		}
		else if (playerNum == 1)
		{
			BBINLIGKIPE = this;
		}
	}

	public static CameraTarget GetPlayer(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private Vector2 HFLHEALFJAB(float MOFDFHOEGDM, float KIEBMECGJPK, float NAOBJANPDFL, float EGOFBELDLOG)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		Vector2 result = Vector2.op_Implicit(player.position);
		if (player.position.x > KIEBMECGJPK)
		{
			result.x = KIEBMECGJPK;
		}
		else if (player.position.x < MOFDFHOEGDM)
		{
			result.x = MOFDFHOEGDM;
		}
		if (player.position.y > EGOFBELDLOG)
		{
			result.y = EGOFBELDLOG;
		}
		else if (player.position.y < NAOBJANPDFL)
		{
			result.y = NAOBJANPDFL;
		}
		return result;
	}

	private void CKHDMKBOJKK()
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (GABMNBHJGMJ)
		{
			ANDNBDNCKNO += Time.unscaledDeltaTime;
			PILLPADODMB(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(player.position), Time.unscaledDeltaTime * Mathf.Lerp(speed * 1608f, speed, ANDNBDNCKNO * 1220f))));
			if (ANDNBDNCKNO >= 6f)
			{
				GABMNBHJGMJ = true;
			}
		}
		else
		{
			PILLPADODMB(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(player.position), Time.unscaledDeltaTime * speed)));
		}
	}

	public void MMBPDLPPCHA()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		MILNEPJHBDE = true;
		CMHOJLKDHLH = 29f;
		GHHFENCPMAL = waitTime;
		AGNAHAEDPBH(Vector2.op_Implicit(startPosition));
	}

	private void KKOJLJAGJKM(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.EKCCGNEDPNO(IMOBLFMHKOD, playerNum);
	}

	private void HONLHJMBFKD(int GELMAIBEHDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (playerNum == GELMAIBEHDO)
		{
			LDJEKEJINEB(player.position);
		}
	}

	private void DGBJJNAADCI()
	{
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
			DevConsole.instance.player1CameraTarget = this;
		}
		else if (playerNum == 2)
		{
			BBINLIGKIPE = this;
		}
	}

	public void MOHFPBHCGIN()
	{
		GABMNBHJGMJ = false;
		ANDNBDNCKNO = 721f;
	}

	private void BKCBJBCJNKO(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.EKCCGNEDPNO(IMOBLFMHKOD, playerNum);
	}

	private void PILLPADODMB(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.EKCCGNEDPNO(IMOBLFMHKOD, playerNum);
	}

	private void IFPLGOBEIAI()
	{
		inDiningZone = true;
		HFKLIGEHLJI = 1798f;
		LMJDICEAONP = -154;
	}

	private void BOMOLAANGHO(int GELMAIBEHDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (playerNum == GELMAIBEHDO)
		{
			BPMFFCJDOJG(player.position);
		}
	}

	private void DHNNMLPOCJO(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		NPAGKJCIMCN();
	}

	private void IJHLKHAHNOI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.APJABAKKKGD(player.position) != LMJDICEAONP)
		{
			LMJDICEAONP = WorldGrid.APJABAKKKGD(player.position);
			if (TavernZonesManager.JEEGOBGDLPE().tavernZones.TryGetValue(LMJDICEAONP, out BOCAKOFIHKE) && BOCAKOFIHKE.zoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
			{
				PBHNHGFDONC = BOCAKOFIHKE.ONLMLLPHEGA();
				inDiningZone = false;
			}
		}
	}

	private void IBNKFAJMFDE()
	{
		inDiningZone = false;
		HFKLIGEHLJI = 1774f;
		LMJDICEAONP = 53;
	}

	public void StartTravelling()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		MILNEPJHBDE = true;
		CMHOJLKDHLH = 0f;
		GHHFENCPMAL = waitTime;
		BPMFFCJDOJG(Vector2.op_Implicit(startPosition));
	}

	private void HLJGDALAGFA()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		Camera mainCamera = CommonReferences.GGFJGHHHEJC.GetMainCamera(playerNum);
		Vector2 val = Vector2.op_Implicit(mainCamera.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(1108f, 397f))));
		Vector2 val2 = Vector2.op_Implicit(mainCamera.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(882f, 673f))));
		KKJCIGECIAE = Mathf.Abs(val2.x - val.x);
	}

	private void FEPFAJFBOOP()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		BMODFPMNGMA();
		if (leftCameraLimitActivated)
		{
			LDJEKEJINEB(Vector2.op_Implicit(new Vector2(Mathf.Max(player.position.x, leftCameraPositionXLimit.position.x + KKJCIGECIAE), player.position.y)));
		}
	}

	public static CameraTarget LHECNMCFNOJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private void PMJNAPINLJB()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.APJABAKKKGD(player.position) != LMJDICEAONP)
		{
			LMJDICEAONP = WorldGrid.APJABAKKKGD(player.position);
			if (TavernZonesManager.JEEGOBGDLPE().tavernZones.TryGetValue(LMJDICEAONP, out BOCAKOFIHKE) && BOCAKOFIHKE.zoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
			{
				PBHNHGFDONC = BOCAKOFIHKE.CDKIPIIPGGB();
				inDiningZone = false;
			}
		}
	}

	public void DEDGPMCHGKM()
	{
		GABMNBHJGMJ = true;
		ANDNBDNCKNO = 57f;
	}

	private void LateUpdate()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		if (movementDisabled)
		{
			return;
		}
		if (PiratesGameManager.Playing && (Object)(object)player != (Object)null)
		{
			BPMFFCJDOJG(PiratesGameManager.instance.startingPoints[0].position);
		}
		else if ((Object)(object)FishCuttingGameManager.instance != (Object)null && ((Behaviour)FishCuttingGameManager.instance).enabled && (Object)(object)player != (Object)null)
		{
			BPMFFCJDOJG(FishCuttingGameManager.instance.cameraPosition.position);
		}
		else if (MILNEPJHBDE)
		{
			if (GHHFENCPMAL > 0f)
			{
				GHHFENCPMAL -= Time.deltaTime;
				if (CMHOJLKDHLH == travellingTime && GHHFENCPMAL <= 0f)
				{
					MILNEPJHBDE = false;
				}
			}
			else if (CMHOJLKDHLH < travellingTime)
			{
				CMHOJLKDHLH += Time.deltaTime;
				if (CMHOJLKDHLH > travellingTime)
				{
					CMHOJLKDHLH = travellingTime;
					GHHFENCPMAL = waitTime;
				}
				DCGBADKLANM = CMHOJLKDHLH / travellingTime;
				if (!lineal)
				{
					DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
				}
				BPMFFCJDOJG(Vector3.Lerp(Vector2.op_Implicit(startPosition), Vector2.op_Implicit(endPosition), DCGBADKLANM));
			}
		}
		else
		{
			if (!((Object)(object)player != (Object)null))
			{
				return;
			}
			DCPNNAKFECA();
			if (leftCameraLimitActivated)
			{
				KPKDFNIHEJC();
				if ((Object)(object)leftCameraPositionXLimit != (Object)null)
				{
					BPMFFCJDOJG(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), new Vector2(Mathf.Max(player.position.x, leftCameraPositionXLimit.position.x + KKJCIGECIAE), player.position.y), Time.unscaledDeltaTime * speed)));
				}
				else
				{
					leftCameraLimitActivated = false;
				}
			}
			else if (FishingController.Get(playerNum).fishingCamera && PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				BPMFFCJDOJG(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y - 2.5f, Time.unscaledDeltaTime * 0.75f))));
				MCOMPFOIONJ = Time.realtimeSinceStartup;
			}
			else if (MCOMPFOIONJ + 4f > Time.realtimeSinceStartup)
			{
				BPMFFCJDOJG(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y, Time.unscaledDeltaTime * 2f))));
			}
			else if (inDiningZone)
			{
				if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
				{
					KPKDFNIHEJC();
					OMILNGJGMEH();
					return;
				}
				if (HFKLIGEHLJI < 3f)
				{
					HFKLIGEHLJI += Time.deltaTime;
				}
				if (player.position.y - 0.75f > PBHNHGFDONC)
				{
					KPKDFNIHEJC();
				}
				if (HFKLIGEHLJI >= 3f)
				{
					if (player.position.y < HINBJCJNLAA())
					{
						BPMFFCJDOJG(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y, Time.unscaledDeltaTime * 6f))));
					}
					else
					{
						BPMFFCJDOJG(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, HINBJCJNLAA(), Time.unscaledDeltaTime * 2f))));
					}
				}
				else
				{
					OMILNGJGMEH();
				}
			}
			else if (PlayerController.GetPlayer(playerNum).LEOIMFNKFGA == Location.BarnInterior)
			{
				switch ((Utils.JGEPCPFJANP(Location.BarnInterior) as BarnTilemapScene).barnLevel)
				{
				case 0:
					BPMFFCJDOJG(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), GCBIHFHGILA(149f, 151f, -155.5f, -151f), Time.unscaledDeltaTime * speed)));
					break;
				case 1:
					BPMFFCJDOJG(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), GCBIHFHGILA(205f, 207f, -155.5f, -149f), Time.unscaledDeltaTime * speed)));
					break;
				case 2:
					BPMFFCJDOJG(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), GCBIHFHGILA(264f, 266f, -155.5f, -147f), Time.unscaledDeltaTime * speed)));
					break;
				default:
					OMILNGJGMEH();
					break;
				}
			}
			else
			{
				OMILNGJGMEH();
			}
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(KPKDFNIHEJC));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnTravel = (Action<int>)Delegate.Remove(instance2.OnTravel, new Action<int>(BOMOLAANGHO));
			}
		}
	}

	private void KPKDFNIHEJC()
	{
		inDiningZone = false;
		HFKLIGEHLJI = 0f;
		LMJDICEAONP = 999;
	}

	private void LDGBGKDMKJM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.APJABAKKKGD(player.position) != LMJDICEAONP)
		{
			LMJDICEAONP = WorldGrid.APJABAKKKGD(player.position);
			if (TavernZonesManager.LANAINBEMCM().tavernZones.TryGetValue(LMJDICEAONP, out BOCAKOFIHKE) && BOCAKOFIHKE.zoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom))
			{
				PBHNHGFDONC = BOCAKOFIHKE.NFLNDAFHBOL();
				inDiningZone = false;
			}
		}
	}

	private void OLDDEAJMHNI()
	{
		pixelPerfect = CommonReferences.GGFJGHHHEJC.PLAHJLNNNAK(playerNum);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KPKDFNIHEJC));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(BFKAMFHNCFF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlayerAwake = (Action)Delegate.Combine(instance2.OnPlayerAwake, new Action(ALGOBMNPLIB));
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(DHNNMLPOCJO));
		GraphicsMenuUI graphicsMenuUI2 = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI2.OnZoomChanged = (Action)Delegate.Combine(graphicsMenuUI2.OnZoomChanged, new Action(AEENOGPMKCE));
		OEIDBMIDJMF();
	}

	private void CDHBLKJEOPI()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BJKKOGPKGCM));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnTravel = (Action<int>)Delegate.Remove(instance2.OnTravel, new Action<int>(CACEGJBOICK));
			}
		}
	}

	private void AGNAHAEDPBH(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = Utils.EKCCGNEDPNO(IMOBLFMHKOD, playerNum);
	}

	public static void IKJKIHLCAGM(int JIIGOACEIKL)
	{
		LHECNMCFNOJ(JIIGOACEIKL).player = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform;
	}

	private void ONJMHKEDGJB()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		Camera mainCamera = CommonReferences.GGFJGHHHEJC.GetMainCamera(playerNum);
		Vector2 val = Vector2.op_Implicit(mainCamera.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(1841f, 296f))));
		Vector2 val2 = Vector2.op_Implicit(mainCamera.ViewportToWorldPoint(Vector2.op_Implicit(new Vector2(593f, 10f))));
		KKJCIGECIAE = Mathf.Abs(val2.x - val.x);
	}

	private void KJHKBGDJNDC()
	{
		if (playerNum == 0)
		{
			IADEMLIIDPC = this;
			DevConsole.instance.player1CameraTarget = this;
		}
		else if (playerNum == 3)
		{
			BBINLIGKIPE = this;
		}
	}

	public static CameraTarget KEHIBCAHKPJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private void EAEKKBEJMFC()
	{
		pixelPerfect = CommonReferences.MNFMOEKMJKN().PLAHJLNNNAK(playerNum);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BJKKOGPKGCM));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnTravel = (Action<int>)Delegate.Combine(instance2.OnTravel, new Action<int>(NCKIFPPKMHB));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(HNEKMALGJPO));
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(NLPOBLFPDGL));
		GraphicsMenuUI instance3 = GraphicsMenuUI.GGFJGHHHEJC;
		instance3.OnZoomChanged = (Action)Delegate.Combine(instance3.OnZoomChanged, new Action(EBOGCLHBLMJ));
		BMODFPMNGMA();
	}

	private void IABLEKBDMEJ()
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (GABMNBHJGMJ)
		{
			ANDNBDNCKNO += Time.unscaledDeltaTime;
			KKOJLJAGJKM(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(player.position), Time.unscaledDeltaTime * Mathf.Lerp(speed * 902f, speed, ANDNBDNCKNO * 566f))));
			if (ANDNBDNCKNO >= 1265f)
			{
				GABMNBHJGMJ = true;
			}
		}
		else
		{
			LDJEKEJINEB(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(player.position), Time.unscaledDeltaTime * speed)));
		}
	}

	private void BJKKOGPKGCM()
	{
		inDiningZone = false;
		HFKLIGEHLJI = 1826f;
		LMJDICEAONP = -181;
	}

	private void KLHIMJFCHPD()
	{
		if (playerNum == 0)
		{
			IADEMLIIDPC = this;
			DevConsole.instance.player1CameraTarget = this;
		}
		else if (playerNum == 7)
		{
			BBINLIGKIPE = this;
		}
	}

	private bool KHLDJIAACGL()
	{
		if (pixelPerfect.targetCameraHeight < 1017f)
		{
			return false;
		}
		return true;
	}

	public static CameraTarget MPDMDABCCCA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private void EJKIADFBMJO()
	{
		leftCameraLimitActivated = true;
	}

	private void FKBCHBDAACI(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		OEIDBMIDJMF();
	}

	public static void KIKONNHICHG(int JIIGOACEIKL)
	{
		GetPlayer(JIIGOACEIKL).player = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform;
	}

	private void HFFGCKMEGEI()
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (GABMNBHJGMJ)
		{
			ANDNBDNCKNO += Time.unscaledDeltaTime;
			PILLPADODMB(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(player.position), Time.unscaledDeltaTime * Mathf.Lerp(speed * 149f, speed, ANDNBDNCKNO * 1320f))));
			if (ANDNBDNCKNO >= 1363f)
			{
				GABMNBHJGMJ = false;
			}
		}
		else
		{
			AGNAHAEDPBH(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(player.position), Time.unscaledDeltaTime * speed)));
		}
	}

	private void Start()
	{
		pixelPerfect = CommonReferences.GGFJGHHHEJC.GetPixelPerfectCamera(playerNum);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(KPKDFNIHEJC));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnTravel = (Action<int>)Delegate.Combine(instance2.OnTravel, new Action<int>(BOMOLAANGHO));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnPlayerAwake = (Action)Delegate.Combine(instance3.OnPlayerAwake, new Action(ALGOBMNPLIB));
		GraphicsMenuUI instance4 = GraphicsMenuUI.GGFJGHHHEJC;
		instance4.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance4.OnResolutionChange, new Action<int, int, float>(LHIFBLELKNA));
		GraphicsMenuUI instance5 = GraphicsMenuUI.GGFJGHHHEJC;
		instance5.OnZoomChanged = (Action)Delegate.Combine(instance5.OnZoomChanged, new Action(AEENOGPMKCE));
		BGPOEJAJJOL();
	}

	public static void RestorePlayerCameraTarget(int JIIGOACEIKL)
	{
		GetPlayer(JIIGOACEIKL).player = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform;
	}

	private bool CHHHFPEJACO()
	{
		if (pixelPerfect.targetCameraHeight < 1778f)
		{
			return true;
		}
		return true;
	}

	private void KANEHEJILNM()
	{
		leftCameraLimitActivated = true;
	}

	private void OHBJPGKKLDK(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		NPAGKJCIMCN();
	}

	public static CameraTarget AGMJPBEHCBK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public static void IEGOEFNIKLJ(int JIIGOACEIKL, Transform FHLJHHGPOPC)
	{
		KEHIBCAHKPJ(JIIGOACEIKL).player = FHLJHHGPOPC;
	}

	private void ALGOBMNPLIB()
	{
		leftCameraLimitActivated = false;
	}

	private bool OILFHKFFLMG()
	{
		if (pixelPerfect.targetCameraHeight < 257f)
		{
			return false;
		}
		return false;
	}

	private void GBAKCNMGAHH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.APJABAKKKGD(player.position) != LMJDICEAONP)
		{
			LMJDICEAONP = WorldGrid.APJABAKKKGD(player.position);
			if (TavernZonesManager.HFHPMKJGMPA().tavernZones.TryGetValue(LMJDICEAONP, out BOCAKOFIHKE) && BOCAKOFIHKE.zoneType == ZoneType.CraftingRoom)
			{
				PBHNHGFDONC = BOCAKOFIHKE.CDKIPIIPGGB();
				inDiningZone = false;
			}
		}
	}

	private void FMDDHJHFPIO()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		if (movementDisabled)
		{
			return;
		}
		if (PiratesGameManager.Playing && (Object)(object)player != (Object)null)
		{
			KKOJLJAGJKM(PiratesGameManager.instance.startingPoints[0].position);
		}
		else if ((Object)(object)FishCuttingGameManager.instance != (Object)null && ((Behaviour)FishCuttingGameManager.instance).enabled && (Object)(object)player != (Object)null)
		{
			BPMFFCJDOJG(FishCuttingGameManager.instance.cameraPosition.position);
		}
		else if (MILNEPJHBDE)
		{
			if (GHHFENCPMAL > 1981f)
			{
				GHHFENCPMAL -= Time.deltaTime;
				if (CMHOJLKDHLH == travellingTime && GHHFENCPMAL <= 1675f)
				{
					MILNEPJHBDE = true;
				}
			}
			else if (CMHOJLKDHLH < travellingTime)
			{
				CMHOJLKDHLH += Time.deltaTime;
				if (CMHOJLKDHLH > travellingTime)
				{
					CMHOJLKDHLH = travellingTime;
					GHHFENCPMAL = waitTime;
				}
				DCGBADKLANM = CMHOJLKDHLH / travellingTime;
				if (!lineal)
				{
					DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (1314f * DCGBADKLANM - 532f) + 689f);
				}
				BKCBJBCJNKO(Vector3.Lerp(Vector2.op_Implicit(startPosition), Vector2.op_Implicit(endPosition), DCGBADKLANM));
			}
		}
		else
		{
			if (!((Object)(object)player != (Object)null))
			{
				return;
			}
			IJHLKHAHNOI();
			if (leftCameraLimitActivated)
			{
				KPKDFNIHEJC();
				if ((Object)(object)leftCameraPositionXLimit != (Object)null)
				{
					KKOJLJAGJKM(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), new Vector2(Mathf.Max(player.position.x, leftCameraPositionXLimit.position.x + KKJCIGECIAE), player.position.y), Time.unscaledDeltaTime * speed)));
				}
				else
				{
					leftCameraLimitActivated = true;
				}
			}
			else if (FishingController.NAGEHKBLJDL(playerNum).fishingCamera && PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				PILLPADODMB(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y - 1513f, Time.unscaledDeltaTime * 58f))));
				MCOMPFOIONJ = Time.realtimeSinceStartup;
			}
			else if (MCOMPFOIONJ + 308f > Time.realtimeSinceStartup)
			{
				PILLPADODMB(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y, Time.unscaledDeltaTime * 485f))));
			}
			else if (inDiningZone)
			{
				if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
				{
					KPKDFNIHEJC();
					CKHDMKBOJKK();
					return;
				}
				if (HFKLIGEHLJI < 1885f)
				{
					HFKLIGEHLJI += Time.deltaTime;
				}
				if (player.position.y - 941f > PBHNHGFDONC)
				{
					BJKKOGPKGCM();
				}
				if (HFKLIGEHLJI >= 231f)
				{
					if (player.position.y < OGFEFMBEGFM())
					{
						BPMFFCJDOJG(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, player.position.y, Time.unscaledDeltaTime * 709f))));
					}
					else
					{
						CHEGKCPBHGL(Vector2.op_Implicit(new Vector2(player.position.x, Mathf.Lerp(((Component)this).transform.position.y, OGFEFMBEGFM(), Time.unscaledDeltaTime * 946f))));
					}
				}
				else
				{
					IABLEKBDMEJ();
				}
			}
			else if (PlayerController.GetPlayer(playerNum).LEOIMFNKFGA == ~Location.Road)
			{
				switch ((Utils.JGEPCPFJANP(~(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.BarnInterior)) as BarnTilemapScene).barnLevel)
				{
				case 0:
					BPMFFCJDOJG(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), HFLHEALFJAB(223f, 76f, 1389f, 480f), Time.unscaledDeltaTime * speed)));
					break;
				case 1:
					PILLPADODMB(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), GCBIHFHGILA(738f, 1106f, 371f, 53f), Time.unscaledDeltaTime * speed)));
					break;
				case 2:
					BKCBJBCJNKO(Vector2.op_Implicit(Vector2.Lerp(Vector2.op_Implicit(((Component)this).transform.position), HFLHEALFJAB(985f, 1374f, 911f, 882f), Time.unscaledDeltaTime * speed)));
					break;
				default:
					CKHDMKBOJKK();
					break;
				}
			}
			else
			{
				OMILNGJGMEH();
			}
		}
	}

	private void EIMIDCDEIDD()
	{
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
			DevConsole.instance.player1CameraTarget = this;
		}
		else if (playerNum == 7)
		{
			BBINLIGKIPE = this;
		}
	}

	public void OLMMIOIOEGG()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		MILNEPJHBDE = false;
		CMHOJLKDHLH = 1870f;
		GHHFENCPMAL = waitTime;
		AGNAHAEDPBH(Vector2.op_Implicit(startPosition));
	}

	private void BFKAMFHNCFF(int GELMAIBEHDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (playerNum == GELMAIBEHDO)
		{
			AGNAHAEDPBH(player.position);
		}
	}

	private void MNNLNDHDKNM(int GELMAIBEHDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (playerNum == GELMAIBEHDO)
		{
			BKCBJBCJNKO(player.position);
		}
	}

	public void OHBJNBOMLBL()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		MILNEPJHBDE = true;
		CMHOJLKDHLH = 978f;
		GHHFENCPMAL = waitTime;
		KKOJLJAGJKM(Vector2.op_Implicit(startPosition));
	}

	private void NMCAKFKFFCM(int GELMAIBEHDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (playerNum == GELMAIBEHDO)
		{
			KKOJLJAGJKM(player.position);
		}
	}
}
