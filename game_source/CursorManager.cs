using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class CursorManager : MonoBehaviour
{
	public struct POINT
	{
		public int X;

		public int Y;

		public POINT(int NCPGNLOJGAF, int JLMAILGJNCE)
		{
			X = NCPGNLOJGAF;
			Y = JLMAILGJNCE;
		}
	}

	public enum CursorType
	{
		Default,
		Select,
		Placing,
		Mouse,
		Item
	}

	private static CursorManager IADEMLIIDPC;

	private static CursorManager BBINLIGKIPE;

	[SerializeField]
	[Range(1f, 2f)]
	private int playerNum = 1;

	private CursorUI HNEFHAHLKML;

	[SerializeField]
	private Image cursorMaskImage;

	[SerializeField]
	private Image cursorImage;

	[SerializeField]
	private Image cursorRaycastBlocker;

	[SerializeField]
	private Mask cursorMask;

	private RectTransform IIIKCOBAFPA;

	private RectTransform PGBKFNPCPDE;

	public Texture2D cursorSelectTexture;

	public Texture2D cursorPlacingTexture;

	public Texture2D cursorMouseTexture;

	public Texture2D cursorItemTexture;

	public Sprite cursorSelectSprite;

	public Sprite cursorPlacingSprite;

	public Sprite cursorMouseSprite;

	public Sprite cursorItemSprite;

	private bool PBIGIIGBHAN = true;

	private CursorType FHEEFKMNALH;

	private CursorType DEPJHENIMLP;

	[SerializeField]
	private float cursorDisappearTime;

	[SerializeField]
	private float cursorSamePositionTime;

	private float DEMNOAKAHED;

	private float OGKJJAABDFD;

	private Vector2 BCPLJLGKBFF = Vector2.one;

	private Vector3 NFEOCAGIKEG;

	private Vector3 NEKMLAKFJDJ;

	private Vector3 PEDJBILEFCD;

	private Sprite HEJNLFCKOKE;

	private bool PHAJGHBEAHG;

	private bool GLMJHNMBNHF;

	private float HHGEAEBPKHI;

	private float KILGPNECLGG;

	private float JMNENCNFNGN;

	private float HJFGMODBNCD;

	private POINT MJGMEBDNKKI;

	private Vector2 IPLEPBEKJAG;

	private bool JJPNEDGKAAP;

	private float HHOPCCKCBJM;

	private float FEOJNEGIHKI;

	private Vector3 PIGIIOMOKMH;

	public bool EKHMMNNOEOI
	{
		get
		{
			return GLMJHNMBNHF;
		}
		set
		{
			if (!ConstructionManager.NEOJLHDFFMJ)
			{
				GLMJHNMBNHF = value;
				PHAJGHBEAHG = value;
				SetCursorVisible(value);
			}
		}
	}

	public float FLCGEKBIMIK { get; set; }

	public static void EABINHEOHAF(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop() && !INDKANEMPMP.compatibleWithCoopMode)
		{
			CMDGPJEIIJI(JIIGOACEIKL).HKJEEPFJNFO(DAEMAAOLHMG: false);
		}
	}

	public void SetCursorPositionFromScreen(Vector3 DAADKDLNAGE)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		IPLEPBEKJAG = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(DAADKDLNAGE));
		IIIKCOBAFPA.anchoredPosition = Vector2.op_Implicit(AEIIAMCFGDO(new Vector3(IPLEPBEKJAG.x * PGBKFNPCPDE.sizeDelta.x, IPLEPBEKJAG.y * PGBKFNPCPDE.sizeDelta.y, 0f)));
		NFEOCAGIKEG = CommonReferences.GGFJGHHHEJC.GetMainCamera(playerNum).ScreenToWorldPoint(DAADKDLNAGE);
		NFEOCAGIKEG.z = 0f;
	}

	private void CMGODAGLLGO()
	{
		if (GLMJHNMBNHF && !PHAJGHBEAHG)
		{
			CBGHFKGFGKM(AODONKKHPBP: false);
		}
		if (FarmConstructionManager.IsActived())
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (!PHAJGHBEAHG && !GLMJHNMBNHF)
				{
					if ((Object)(object)ConstructionManager.currentInstantiatedGO != (Object)null || (Object)(object)FarmConstructionManager.OIFCIKGLCJB != (Object)null)
					{
						CursorAppears();
					}
					else
					{
						SetCursorVisible(NKFPJPCFBJI: false);
					}
				}
			}
			else
			{
				NIPJALAEHOH(NKFPJPCFBJI: true);
			}
		}
		else if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (!PHAJGHBEAHG && !GLMJHNMBNHF)
				{
					if (DecorationMode.KKJABELKCNM(playerNum).KNFEPKBIHND() || ConstructionActionBarUI.currentPanel == 1)
					{
						LLJCIJIDEJG();
					}
					else
					{
						SetCursorVisible(NKFPJPCFBJI: false);
					}
				}
			}
			else
			{
				NIPJALAEHOH(NKFPJPCFBJI: false);
			}
		}
		else if (!GLMJHNMBNHF)
		{
			if (!PHAJGHBEAHG && (GetHorizontalMove() != 712f || GetVerticalMove() != 410f))
			{
				MGGNJMAAOID();
			}
			if (IsCursorVisible())
			{
				OGKJJAABDFD = 1901f;
				if (DEMNOAKAHED > cursorDisappearTime)
				{
					SetCursorVisible(NKFPJPCFBJI: true);
					PHAJGHBEAHG = false;
				}
				else
				{
					DEMNOAKAHED += Time.unscaledDeltaTime;
				}
			}
			else
			{
				OGKJJAABDFD += Time.unscaledDeltaTime;
			}
		}
		if (PHAJGHBEAHG)
		{
			if (LFAJDFBMGGL())
			{
				DEMNOAKAHED = 720f;
			}
			NBHEOGEDFLA();
		}
	}

	public static CursorManager GetPlayer(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			return IADEMLIIDPC;
		case 2:
			return BBINLIGKIPE;
		default:
			Debug.LogError((object)"Invalid Player for CursorManager");
			return null;
		}
	}

	public static void DPONDHPDFPB(int JIIGOACEIKL, bool NKFPJPCFBJI)
	{
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.PHAJGHBEAHG = NKFPJPCFBJI;
		}
		else
		{
			BBINLIGKIPE.PHAJGHBEAHG = NKFPJPCFBJI;
		}
	}

	private void GBLKJHPNEAK()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		if ((!ConstructionManager.NEOJLHDFFMJ && (((Object)(object)MainUI.openedWindow != (Object)null && !MainUI.openedWindow.compatibleWithCoopMode) || TutorialManager.GGFJGHHHEJC.ADLMJEBAPAI() || NewTutorialManager.instance.open)) || LocalCooperativeManager.instance.cameraFocusedOnOnePlayer)
		{
			return;
		}
		if (FLCGEKBIMIK > 1012f)
		{
			FLCGEKBIMIK -= Time.unscaledDeltaTime;
			return;
		}
		IPLEPBEKJAG = Vector2.op_Implicit(HEEMGJLEAPM());
		JJPNEDGKAAP = true;
		if (GameManager.OPGGPLEOGCG() || GameManager.SinglePlayer() || ConstructionManager.NEOJLHDFFMJ)
		{
			HHOPCCKCBJM = 1986f;
			FEOJNEGIHKI = 95f;
		}
		else if (playerNum == 1)
		{
			HHOPCCKCBJM = 200f;
			FEOJNEGIHKI = 1497f;
		}
		else
		{
			HHOPCCKCBJM = 248f;
			FEOJNEGIHKI = 1873f;
		}
		if (IPLEPBEKJAG.x > FEOJNEGIHKI)
		{
			IPLEPBEKJAG.x = FEOJNEGIHKI;
			JJPNEDGKAAP = false;
		}
		else if (IPLEPBEKJAG.x < HHOPCCKCBJM)
		{
			IPLEPBEKJAG.x = HHOPCCKCBJM;
			JJPNEDGKAAP = true;
		}
		if (IPLEPBEKJAG.y > 1903f)
		{
			IPLEPBEKJAG.y = 1985f;
			JJPNEDGKAAP = true;
		}
		else if (IPLEPBEKJAG.y < 1752f)
		{
			IPLEPBEKJAG.y = 413f;
			JJPNEDGKAAP = true;
		}
		if (JJPNEDGKAAP)
		{
			SetCursorPositionFromViewport(Vector2.op_Implicit(IPLEPBEKJAG));
		}
	}

	private void BCKOBEAGOJP()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.BLGCACDAEHL(playerNum) && (playerNum != 7 || GameManager.LocalCoop()))
		{
			NEKMLAKFJDJ = GetCursorWorldPosition();
			if (PlayerInputs.EEJEOALIHFJ(playerNum))
			{
				PCJPHFBLHAF();
			}
			else
			{
				AMDKONCKIEB();
			}
			GNENPKFACAK();
			if (Cursor.visible && !Application.isEditor)
			{
				Cursor.visible = true;
			}
			if (PBIGIIGBHAN)
			{
				HOLFKNIHEEP();
			}
		}
	}

	private void JHIGLABAIMK()
	{
		if (!((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null) && !((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null) && !((Object)(object)TavernConstructionManager.DOIKFJDLKJP() == (Object)null))
		{
			if (Object.op_Implicit((Object)(object)TavernConstructionManager.DEGPIHEEFHJ()) && (Object)(object)CMDGPJEIIJI(playerNum) != (Object)null)
			{
				MGAHHNHOKEM(DAEMAAOLHMG: true);
			}
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(DBDKJHDDEKI));
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KHMEGDIABBF();
			tavernConstructionManager.OnActivated = (Action<int>)Delegate.Remove(tavernConstructionManager.OnActivated, new Action<int>(HLFACFBMNEE));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(KCMBLFILELP));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Remove(instance2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(JJPONCEEHGA));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(OHHOAFJNJPP));
		}
	}

	private void DBDKJHDDEKI()
	{
		if (!GameManager.PlayingOnline())
		{
			if (playerNum == 5)
			{
				PHAJGHBEAHG = true;
				NIPJALAEHOH(NKFPJPCFBJI: true);
			}
			ActivateCursorMask(DAEMAAOLHMG: true);
		}
	}

	[SpecialName]
	public float JGAMELELGOB()
	{
		return _003CHIGBFKDMLIO_003Ek__BackingField;
	}

	public static void SetControlCursorWithGamepad(int JIIGOACEIKL, bool NKFPJPCFBJI)
	{
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.PHAJGHBEAHG = NKFPJPCFBJI;
		}
		else
		{
			BBINLIGKIPE.PHAJGHBEAHG = NKFPJPCFBJI;
		}
	}

	public void ActivateCursorMask(bool DAEMAAOLHMG)
	{
		if ((!DAEMAAOLHMG || !TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE) && !((Object)(object)cursorMask == (Object)null))
		{
			((Behaviour)cursorMask).enabled = DAEMAAOLHMG;
			((Behaviour)cursorMaskImage).enabled = DAEMAAOLHMG;
			((Behaviour)cursorRaycastBlocker).enabled = !PlayerInputs.IsGamepadActive(playerNum) && DAEMAAOLHMG;
		}
	}

	private void KGKOCCDPLAN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (playerNum == JIIGOACEIKL && GFNHAMCPEAK)
		{
			NPKNHILNKBD((CursorType)7);
			AKFANNBLIFL();
			UpdateCursorTexture(NKFPJPCFBJI: true);
		}
	}

	private void AKFANNBLIFL()
	{
		if (Object.op_Implicit((Object)(object)TutorialManager.GGFJGHHHEJC) && TutorialManager.GGFJGHHHEJC.LLBPLOCOJAG())
		{
			FHEEFKMNALH = CursorType.Default;
		}
		if (FHEEFKMNALH != DEPJHENIMLP)
		{
			switch (FHEEFKMNALH)
			{
			case CursorType.Default:
				HEJNLFCKOKE = cursorSelectSprite;
				break;
			case CursorType.Select:
				HEJNLFCKOKE = cursorSelectSprite;
				break;
			case CursorType.Placing:
				HEJNLFCKOKE = cursorPlacingSprite;
				break;
			case CursorType.Mouse:
				HEJNLFCKOKE = cursorMouseSprite;
				break;
			case CursorType.Item:
				HEJNLFCKOKE = cursorItemSprite;
				break;
			default:
				HEJNLFCKOKE = cursorSelectSprite;
				break;
			}
			cursorImage.sprite = HEJNLFCKOKE;
			DEPJHENIMLP = FHEEFKMNALH;
		}
	}

	private void Update()
	{
		NPKNHILNKBD(CursorType.Default);
	}

	public bool IsCursorVisible()
	{
		if (Object.op_Implicit((Object)(object)cursorImage))
		{
			return ((Behaviour)cursorImage).enabled;
		}
		return true;
	}

	private void MDIKFCCGEED()
	{
		if (!GameManager.SinglePlayer() && !GameManager.NoPlayers())
		{
			return;
		}
		if (PlayerInputs.IsGamepadActive(1))
		{
			if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
			{
				PHAJGHBEAHG = true;
			}
			SetCursorPos(1, 1);
		}
		else
		{
			PHAJGHBEAHG = false;
			SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	private void HOLFKNIHEEP()
	{
		if (Object.op_Implicit((Object)(object)TutorialManager.GGFJGHHHEJC) && TutorialManager.GGFJGHHHEJC.JCGLIEOIHCP())
		{
			FHEEFKMNALH = CursorType.Default;
		}
		if (FHEEFKMNALH != DEPJHENIMLP)
		{
			switch (FHEEFKMNALH)
			{
			case CursorType.Default:
				HEJNLFCKOKE = cursorSelectSprite;
				break;
			case CursorType.Select:
				HEJNLFCKOKE = cursorSelectSprite;
				break;
			case CursorType.Placing:
				HEJNLFCKOKE = cursorPlacingSprite;
				break;
			case CursorType.Mouse:
				HEJNLFCKOKE = cursorMouseSprite;
				break;
			case CursorType.Item:
				HEJNLFCKOKE = cursorItemSprite;
				break;
			default:
				HEJNLFCKOKE = cursorSelectSprite;
				break;
			}
			cursorImage.sprite = HEJNLFCKOKE;
			DEPJHENIMLP = FHEEFKMNALH;
		}
	}

	private void LateUpdate()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.IgnoreDuringOnline(playerNum) && (playerNum != 2 || GameManager.LocalCoop()))
		{
			NEKMLAKFJDJ = GetCursorWorldPosition();
			if (PlayerInputs.IsGamepadActive(playerNum))
			{
				PCJPHFBLHAF();
			}
			else
			{
				AMDKONCKIEB();
			}
			FOBCMJJMPNA();
			if (Cursor.visible && !Application.isEditor)
			{
				Cursor.visible = false;
			}
			if (PBIGIIGBHAN)
			{
				EOICBHJHCIC();
			}
		}
	}

	public static void SetCursorPositionFromWorld(int JIIGOACEIKL, Vector3 BPLKIPALDNP)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.KIPINDDCDKM(BPLKIPALDNP);
		}
		else
		{
			BBINLIGKIPE.KIPINDDCDKM(BPLKIPALDNP);
		}
	}

	private void FOBCMJJMPNA()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		PEDJBILEFCD = GetCursorWorldPosition() - NEKMLAKFJDJ;
	}

	private void HOFKJPBBLGP()
	{
		PGBKFNPCPDE = ((Component)MenuUI.GGFJGHHHEJC).GetComponent<RectTransform>();
	}

	public static void FPAAGKPLMPM(int JIIGOACEIKL, CursorType FHEEFKMNALH)
	{
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.HNNNJNGKBOC(FHEEFKMNALH);
		}
		else
		{
			BBINLIGKIPE.NPKNHILNKBD(FHEEFKMNALH);
		}
	}

	public static void LKNLCNHFCEJ(int JIIGOACEIKL, CursorType FHEEFKMNALH)
	{
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.HNNNJNGKBOC(FHEEFKMNALH);
		}
		else
		{
			BBINLIGKIPE.NPKNHILNKBD(FHEEFKMNALH);
		}
	}

	private void AGMLGNDDINL()
	{
		if (!GameManager.PlayingOnline())
		{
			if (playerNum == 2)
			{
				PHAJGHBEAHG = false;
				SetCursorVisible(NKFPJPCFBJI: false);
			}
			ActivateCursorMask(DAEMAAOLHMG: false);
		}
	}

	public float BPGKNHJEJCO()
	{
		if (ConstructionManager.NEOJLHDFFMJ)
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (PlayerInputs.ODGALPDEIFG(playerNum))
				{
					return PlayerInputs.DEGBDMMDIIL(playerNum).GetAxis("TooDark");
				}
				return PlayerInputs.DEGBDMMDIIL(playerNum).GetAxis("Items/item_description_1152");
			}
			return 7f;
		}
		return PlayerInputs.GetPlayer(playerNum).GetAxis("BuildMode");
	}

	public static void SetCursorType(int JIIGOACEIKL, CursorType FHEEFKMNALH)
	{
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.NPKNHILNKBD(FHEEFKMNALH);
		}
		else
		{
			BBINLIGKIPE.NPKNHILNKBD(FHEEFKMNALH);
		}
	}

	public Vector3 HEEMGJLEAPM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(IIIKCOBAFPA.anchoredPosition / PGBKFNPCPDE.sizeDelta);
	}

	public void IPGBBDMNMKE(bool DAEMAAOLHMG)
	{
		if ((!DAEMAAOLHMG || !TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE) && !((Object)(object)cursorMask == (Object)null))
		{
			((Behaviour)cursorMask).enabled = DAEMAAOLHMG;
			((Behaviour)cursorMaskImage).enabled = DAEMAAOLHMG;
			((Behaviour)cursorRaycastBlocker).enabled = !PlayerInputs.POLDHCKJINN(playerNum) && DAEMAAOLHMG;
		}
	}

	public Vector2 GetCursorPosition()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)cursorImage).transform.position);
	}

	private Vector3 GPAKEHPOJJB(Vector3 AMILKMFNLCC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(AMILKMFNLCC.x), (float)Mathf.RoundToInt(AMILKMFNLCC.y), (float)Mathf.RoundToInt(AMILKMFNLCC.z));
	}

	private void OHHOAFJNJPP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK && playerNum == JIIGOACEIKL)
		{
			NPKNHILNKBD(CursorType.Default);
			UpdateCursorTexture(NKFPJPCFBJI: true);
		}
	}

	public static bool EAHELIGKMPL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC.PHAJGHBEAHG;
		}
		if (Object.op_Implicit((Object)(object)BBINLIGKIPE))
		{
			return BBINLIGKIPE.PHAJGHBEAHG;
		}
		return true;
	}

	private Vector3 AEIIAMCFGDO(Vector3 AMILKMFNLCC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(AMILKMFNLCC.x), (float)Mathf.RoundToInt(AMILKMFNLCC.y), (float)Mathf.RoundToInt(AMILKMFNLCC.z));
	}

	public void EMNHEKBILGJ(Vector3 DAADKDLNAGE)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		IPLEPBEKJAG = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().ACIFGIBLENB().ScreenToViewportPoint(DAADKDLNAGE));
		IIIKCOBAFPA.anchoredPosition = Vector2.op_Implicit(BPKBMKKODNK(new Vector3(IPLEPBEKJAG.x * PGBKFNPCPDE.sizeDelta.x, IPLEPBEKJAG.y * PGBKFNPCPDE.sizeDelta.y, 1900f)));
		NFEOCAGIKEG = CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(playerNum).ScreenToWorldPoint(DAADKDLNAGE);
		NFEOCAGIKEG.z = 535f;
	}

	public void SetCursorVisible(bool NKFPJPCFBJI)
	{
		if (!PlayerInputs.IsGamepadActive(playerNum))
		{
			if (NKFPJPCFBJI)
			{
				if (!IsCursorVisible())
				{
					SetCursorPos((int)BCPLJLGKBFF.x, (int)BCPLJLGKBFF.y);
				}
			}
			else if (Application.isFocused)
			{
				GetCursorPos(out MJGMEBDNKKI);
				BCPLJLGKBFF.x = MJGMEBDNKKI.X;
				BCPLJLGKBFF.y = MJGMEBDNKKI.Y;
				SetCursorPos(1, 1);
			}
		}
		if (Object.op_Implicit((Object)(object)cursorImage) && ((Behaviour)cursorImage).enabled != NKFPJPCFBJI)
		{
			((Behaviour)cursorImage).enabled = NKFPJPCFBJI;
		}
	}

	[DllImport("User32.Dll")]
	public static extern long SetCursorPos(int NCPGNLOJGAF, int JLMAILGJNCE);

	private void GNENPKFACAK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		PEDJBILEFCD = GetCursorWorldPosition() - NEKMLAKFJDJ;
	}

	public void LLJCIJIDEJG()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			PHAJGHBEAHG = false;
			SetCursorVisible(NKFPJPCFBJI: false);
			DEMNOAKAHED = 1964f;
			if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable))
			{
				EKHMMNNOEOI = false;
				LKJAOHGIKCO(((Component)SelectObject.GetPlayer(playerNum).placeable).transform.position);
				SelectObject.GetPlayer(playerNum).placeable.SetMouseOffset(Vector3.zero);
				SelectObject.GetPlayer(playerNum).placeable.SetAttachedToPlayer(JOOEMBNDCKF: true, 582f);
			}
			else if (ConstructionManager.NEOJLHDFFMJ)
			{
				ALMELPKKCIO(((Component)ConstructionManager.current.cameraTarget).transform.position);
			}
			else if (Item.MLBOMGHINCA(ActionBarInventory.GetPlayer(playerNum).JDAFPKOHJPC(), null) && ActionBarInventory.BNMEANGDMIP(playerNum, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FGGKCJDFNEK() is ITool)
			{
				KIPINDDCDKM(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position);
			}
			else if (OGKJJAABDFD > cursorSamePositionTime)
			{
				ALMELPKKCIO(((Component)this).transform.position);
			}
		}
	}

	[SpecialName]
	public void BCLDAIFAFKP(float AODONKKHPBP)
	{
		_003CHIGBFKDMLIO_003Ek__BackingField = AODONKKHPBP;
	}

	public static void DKAICNMJIJH(int JIIGOACEIKL, Vector3 BPLKIPALDNP)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 0)
		{
			IADEMLIIDPC.LKJAOHGIKCO(BPLKIPALDNP);
		}
		else
		{
			BBINLIGKIPE.MBDGNHLBODK(BPLKIPALDNP);
		}
	}

	private Vector3 PPHOLILDPCL(Vector3 AMILKMFNLCC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(AMILKMFNLCC.x), (float)Mathf.RoundToInt(AMILKMFNLCC.y), (float)Mathf.RoundToInt(AMILKMFNLCC.z));
	}

	private void NFDIJJAMJBB()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		if ((!ConstructionManager.NEOJLHDFFMJ && (((Object)(object)MainUI.openedWindow != (Object)null && !MainUI.openedWindow.compatibleWithCoopMode) || TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO || NewTutorialManager.instance.open)) || LocalCooperativeManager.instance.cameraFocusedOnOnePlayer)
		{
			return;
		}
		if (FLCGEKBIMIK > 0f)
		{
			FLCGEKBIMIK -= Time.unscaledDeltaTime;
			return;
		}
		IPLEPBEKJAG = Vector2.op_Implicit(GetCursorViewportPosition());
		JJPNEDGKAAP = false;
		if (GameManager.NoPlayers() || GameManager.SinglePlayer() || ConstructionManager.NEOJLHDFFMJ)
		{
			HHOPCCKCBJM = 0f;
			FEOJNEGIHKI = 1f;
		}
		else if (playerNum == 1)
		{
			HHOPCCKCBJM = 0f;
			FEOJNEGIHKI = 0.5f;
		}
		else
		{
			HHOPCCKCBJM = 0.5f;
			FEOJNEGIHKI = 1f;
		}
		if (IPLEPBEKJAG.x > FEOJNEGIHKI)
		{
			IPLEPBEKJAG.x = FEOJNEGIHKI;
			JJPNEDGKAAP = true;
		}
		else if (IPLEPBEKJAG.x < HHOPCCKCBJM)
		{
			IPLEPBEKJAG.x = HHOPCCKCBJM;
			JJPNEDGKAAP = true;
		}
		if (IPLEPBEKJAG.y > 1f)
		{
			IPLEPBEKJAG.y = 1f;
			JJPNEDGKAAP = true;
		}
		else if (IPLEPBEKJAG.y < 0f)
		{
			IPLEPBEKJAG.y = 0f;
			JJPNEDGKAAP = true;
		}
		if (JJPNEDGKAAP)
		{
			SetCursorPositionFromViewport(Vector2.op_Implicit(IPLEPBEKJAG));
		}
	}

	public void LPPDBPAKDIC(bool NKFPJPCFBJI)
	{
		PBIGIIGBHAN = NKFPJPCFBJI;
	}

	public void CursorAppears()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			PHAJGHBEAHG = true;
			SetCursorVisible(NKFPJPCFBJI: true);
			DEMNOAKAHED = 0f;
			if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(playerNum).placeable))
			{
				EKHMMNNOEOI = true;
				KIPINDDCDKM(((Component)SelectObject.GetPlayer(playerNum).placeable).transform.position);
				SelectObject.GetPlayer(playerNum).placeable.SetMouseOffset(Vector3.zero);
				SelectObject.GetPlayer(playerNum).placeable.SetAttachedToPlayer(JOOEMBNDCKF: false);
			}
			else if (ConstructionManager.NEOJLHDFFMJ)
			{
				KIPINDDCDKM(((Component)ConstructionManager.current.cameraTarget).transform.position);
			}
			else if (Item.MLBOMGHINCA(ActionBarInventory.GetPlayer(playerNum).GetSelectedItem(), null) && ActionBarInventory.GetPlayer(playerNum).GetSelectedItem() is ITool)
			{
				KIPINDDCDKM(((Component)PlayerController.GetPlayer(playerNum)).transform.position);
			}
			else if (OGKJJAABDFD > cursorSamePositionTime)
			{
				KIPINDDCDKM(((Component)this).transform.position);
			}
		}
	}

	public static void PABFEDEHIFI(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop() && !INDKANEMPMP.compatibleWithCoopMode)
		{
			CMDGPJEIIJI(JIIGOACEIKL).ActivateCursorMask(DAEMAAOLHMG: false);
		}
	}

	private void FCPKCFLJLKA()
	{
		if (GLMJHNMBNHF && !PHAJGHBEAHG)
		{
			CBGHFKGFGKM(AODONKKHPBP: true);
		}
		if (FarmConstructionManager.IsActived())
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (!PHAJGHBEAHG && !GLMJHNMBNHF)
				{
					if ((Object)(object)ConstructionManager.currentInstantiatedGO != (Object)null || (Object)(object)FarmConstructionManager.AHAPLDALHDD() != (Object)null)
					{
						LLJCIJIDEJG();
					}
					else
					{
						SetCursorVisible(NKFPJPCFBJI: false);
					}
				}
			}
			else
			{
				SetCursorVisible(NKFPJPCFBJI: false);
			}
		}
		else if (TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE)
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (!PHAJGHBEAHG && !GLMJHNMBNHF)
				{
					if (DecorationMode.IECFJGHAIDO(playerNum).DMBFKFLDDLH || ConstructionActionBarUI.currentPanel == 3)
					{
						LLJCIJIDEJG();
					}
					else
					{
						SetCursorVisible(NKFPJPCFBJI: true);
					}
				}
			}
			else
			{
				SetCursorVisible(NKFPJPCFBJI: false);
			}
		}
		else if (!GLMJHNMBNHF)
		{
			if (!PHAJGHBEAHG && (GetHorizontalMove() != 1538f || KLNEINNLGCC() != 1992f))
			{
				CursorAppears();
			}
			if (IHMADDCNKAM())
			{
				OGKJJAABDFD = 1915f;
				if (DEMNOAKAHED > cursorDisappearTime)
				{
					NIPJALAEHOH(NKFPJPCFBJI: false);
					PHAJGHBEAHG = false;
				}
				else
				{
					DEMNOAKAHED += Time.unscaledDeltaTime;
				}
			}
			else
			{
				OGKJJAABDFD += Time.unscaledDeltaTime;
			}
		}
		if (PHAJGHBEAHG)
		{
			if (NPCJNLPOBBD())
			{
				DEMNOAKAHED = 1243f;
			}
			GBLKJHPNEAK();
		}
	}

	private void OnDestroy()
	{
		if (!((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null) && !((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null) && !((Object)(object)TavernConstructionManager.GGFJGHHHEJC == (Object)null))
		{
			if (Object.op_Implicit((Object)(object)TavernConstructionManager.GGFJGHHHEJC) && (Object)(object)GetPlayer(playerNum) != (Object)null)
			{
				ActivateCursorMask(DAEMAAOLHMG: false);
			}
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
			TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
			instance.OnActivated = (Action<int>)Delegate.Remove(instance.OnActivated, new Action<int>(BGHLHBHNHPO));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance2.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
			CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
			instance3.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Remove(instance3.OnPlaceablePickedUp, new Action<int, Placeable, bool>(OBBDDLKPAII));
			CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
			instance4.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance4.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
		}
	}

	public void SetCursorPositionFromViewport(Vector3 GOOKKKGIGBL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		IIIKCOBAFPA.anchoredPosition = Vector2.op_Implicit(AEIIAMCFGDO(new Vector3(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y, 0f)));
		NFEOCAGIKEG = CommonReferences.GGFJGHHHEJC.GetMainCamera(playerNum).ScreenToWorldPoint(GetCursorScreenPosition());
		NFEOCAGIKEG.z = 0f;
	}

	public void MGGNJMAAOID()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			PHAJGHBEAHG = true;
			NIPJALAEHOH(NKFPJPCFBJI: true);
			DEMNOAKAHED = 1781f;
			if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(playerNum).placeable))
			{
				CBGHFKGFGKM(AODONKKHPBP: false);
				LKJAOHGIKCO(((Component)SelectObject.GetPlayer(playerNum).placeable).transform.position);
				SelectObject.GetPlayer(playerNum).placeable.SetMouseOffset(Vector3.zero);
				SelectObject.GetPlayer(playerNum).placeable.SetAttachedToPlayer(JOOEMBNDCKF: true, 1148f);
			}
			else if (ConstructionManager.NEOJLHDFFMJ)
			{
				MBDGNHLBODK(((Component)ConstructionManager.current.cameraTarget).transform.position);
			}
			else if (Item.MLBOMGHINCA(ActionBarInventory.DACNEICGAAE(playerNum).JDAFPKOHJPC(), null) && ActionBarInventory.IFGBDFBGAED(playerNum).GetSelectedItem() is ITool)
			{
				LKJAOHGIKCO(((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.position);
			}
			else if (OGKJJAABDFD > cursorSamePositionTime)
			{
				GMLEKFPDBOI(((Component)this).transform.position);
			}
		}
	}

	public void EJCCBDAALHH(Vector3 GOOKKKGIGBL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		IIIKCOBAFPA.anchoredPosition = Vector2.op_Implicit(GPAKEHPOJJB(new Vector3(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y, 1576f)));
		NFEOCAGIKEG = CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(playerNum).ScreenToWorldPoint(GetCursorScreenPosition());
		NFEOCAGIKEG.z = 557f;
	}

	private void LKJAOHGIKCO(Vector3 BPLKIPALDNP)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		PIGIIOMOKMH = CommonReferences.MNFMOEKMJKN().GetMainCamera(playerNum).WorldToScreenPoint(BPLKIPALDNP);
		IPLEPBEKJAG = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().DGIILDNAMDA().ScreenToViewportPoint(PIGIIOMOKMH));
		IIIKCOBAFPA.anchoredPosition = Vector2.op_Implicit(AEIIAMCFGDO(new Vector3(IPLEPBEKJAG.x * PGBKFNPCPDE.sizeDelta.x, IPLEPBEKJAG.y * PGBKFNPCPDE.sizeDelta.y, 139f)));
		NFEOCAGIKEG = BPLKIPALDNP;
		NFEOCAGIKEG.z = 865f;
	}

	private void IFPALGHFPKF()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)MainUI.openedWindow) && MainUI.openedWindow.JIIGOACEIKL != playerNum)
		{
			SetCursorVisible(NKFPJPCFBJI: true);
		}
		else if (!IHMADDCNKAM() && ((Object)(object)MainUI.openedWindow == (Object)null || MainUI.openedWindow.JIIGOACEIKL == playerNum))
		{
			NIPJALAEHOH(NKFPJPCFBJI: false);
		}
		EMNHEKBILGJ(Vector2.op_Implicit(PlayerInputs.GetPlayerControllers(playerNum).Mouse.screenPosition));
		KCHFOFIJEAP();
	}

	private void AEFMPNNHMPF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		PEDJBILEFCD = GetCursorWorldPosition() - NEKMLAKFJDJ;
	}

	private void KEKOBCEAKMN()
	{
		if (!GameManager.FGFJEGOEDKJ())
		{
			if (playerNum == 8)
			{
				PHAJGHBEAHG = false;
				SetCursorVisible(NKFPJPCFBJI: false);
			}
			MGAHHNHOKEM(DAEMAAOLHMG: false);
		}
	}

	private void DKDLOBOLNFH()
	{
		if (playerNum == 1)
		{
			HNEFHAHLKML = CommonReferences.MNFMOEKMJKN().CursorUIPlayer1;
		}
		else if (playerNum == 2)
		{
			HNEFHAHLKML = CommonReferences.MNFMOEKMJKN().CursorUIPlayer2;
		}
		if ((Object)(object)HNEFHAHLKML != (Object)null)
		{
			cursorMask = HNEFHAHLKML.cursorMask;
			cursorImage = HNEFHAHLKML.cursorImage;
			cursorMaskImage = HNEFHAHLKML.cursorMaskImage;
			cursorRaycastBlocker = HNEFHAHLKML.cursorRaycastBlocker;
			IIIKCOBAFPA = HNEFHAHLKML.cursorImageRectTransform;
		}
		if (playerNum == 0)
		{
			IADEMLIIDPC = this;
			PlayerInputs.OnControllerSwitched = (Action)Delegate.Combine(PlayerInputs.OnControllerSwitched, new Action(HMOBGCBAGCJ));
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(DGMDLCNBNPI));
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(PIPKELEBLKB));
			HKJEEPFJNFO(DAEMAAOLHMG: true);
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		}
		else if (playerNum == 4 && !OnlineManager.PlayingOnline())
		{
			BBINLIGKIPE = this;
		}
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(NMIEBOFNIKD));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DOIKFJDLKJP();
		tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(MJEEKOKDAKK));
		if ((Object)(object)cursorImage != (Object)null)
		{
			IIIKCOBAFPA = ((Component)cursorImage).GetComponent<RectTransform>();
		}
		DEMNOAKAHED = 906f;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences.OnPlaceablePickedUp, new Action<int, Placeable, bool>(CDHAGFAKDNM));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences2.OnPlaceableDeselected, new Action<int, Placeable, bool>(LPCPEGLIPNB));
	}

	private void CPPGMNFEGOG()
	{
		if (!GameManager.PlayingOnline())
		{
			if (playerNum == 7)
			{
				PHAJGHBEAHG = true;
				SetCursorVisible(NKFPJPCFBJI: false);
			}
			ActivateCursorMask(DAEMAAOLHMG: false);
		}
	}

	public static void BMOGJPHIBEO(int JIIGOACEIKL, bool NKFPJPCFBJI)
	{
		if (JIIGOACEIKL == 0)
		{
			IADEMLIIDPC.PHAJGHBEAHG = NKFPJPCFBJI;
		}
		else
		{
			BBINLIGKIPE.PHAJGHBEAHG = NKFPJPCFBJI;
		}
	}

	private void MJEEKOKDAKK(int GELMAIBEHDO)
	{
		if (playerNum == GELMAIBEHDO)
		{
			MGAHHNHOKEM(DAEMAAOLHMG: false);
		}
	}

	private void LOHAMDHOLDD()
	{
		PGBKFNPCPDE = ((Component)MenuUI.GGFJGHHHEJC).GetComponent<RectTransform>();
	}

	public static void DPPPPNIDLOK(int JIIGOACEIKL, Vector3 BPLKIPALDNP)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.KIPINDDCDKM(BPLKIPALDNP);
		}
		else
		{
			BBINLIGKIPE.KIPINDDCDKM(BPLKIPALDNP);
		}
	}

	public void JHMPKHNEDEL(CursorType FHEEFKMNALH)
	{
		CPJDKNOBNNC(FHEEFKMNALH);
		HOLFKNIHEEP();
	}

	public static void OnAnyUIOpen(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop() && !INDKANEMPMP.compatibleWithCoopMode)
		{
			GetPlayer(JIIGOACEIKL).ActivateCursorMask(DAEMAAOLHMG: false);
		}
	}

	private void KIPINDDCDKM(Vector3 BPLKIPALDNP)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		PIGIIOMOKMH = CommonReferences.GGFJGHHHEJC.GetMainCamera(playerNum).WorldToScreenPoint(BPLKIPALDNP);
		IPLEPBEKJAG = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(PIGIIOMOKMH));
		IIIKCOBAFPA.anchoredPosition = Vector2.op_Implicit(AEIIAMCFGDO(new Vector3(IPLEPBEKJAG.x * PGBKFNPCPDE.sizeDelta.x, IPLEPBEKJAG.y * PGBKFNPCPDE.sizeDelta.y, 0f)));
		NFEOCAGIKEG = BPLKIPALDNP;
		NFEOCAGIKEG.z = 0f;
	}

	public Vector2 GetMouseWorldDelta()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(PEDJBILEFCD);
	}

	private void AMDKONCKIEB()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)MainUI.openedWindow) && MainUI.openedWindow.JIIGOACEIKL != playerNum)
		{
			SetCursorVisible(NKFPJPCFBJI: false);
		}
		else if (!IsCursorVisible() && ((Object)(object)MainUI.openedWindow == (Object)null || MainUI.openedWindow.JIIGOACEIKL == playerNum))
		{
			SetCursorVisible(NKFPJPCFBJI: true);
		}
		SetCursorPositionFromScreen(Vector2.op_Implicit(PlayerInputs.GetPlayerControllers(playerNum).Mouse.screenPosition));
		NFDIJJAMJBB();
	}

	private void CDHAGFAKDNM(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK && playerNum == JIIGOACEIKL)
		{
			NPKNHILNKBD(CursorType.Default);
			LPPDBPAKDIC(NKFPJPCFBJI: true);
		}
	}

	public Vector3 GetCursorWorldPosition()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return NFEOCAGIKEG;
	}

	public float FJLGIPEEMOI()
	{
		if (ConstructionManager.NEOJLHDFFMJ)
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (PlayerInputs.IsGamepadActive(playerNum))
				{
					return PlayerInputs.GetPlayer(playerNum).GetAxis("Till");
				}
				return PlayerInputs.GetPlayer(playerNum).GetAxis("Use");
			}
			return 1796f;
		}
		return PlayerInputs.DEGBDMMDIIL(playerNum).GNCBKEDHLHN("UI");
	}

	private void EINDMFNLFNL()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		if ((!ConstructionManager.NEOJLHDFFMJ && (((Object)(object)MainUI.openedWindow != (Object)null && !MainUI.openedWindow.compatibleWithCoopMode) || TutorialManager.GGFJGHHHEJC.PMGEOLNMJGB() || NewTutorialManager.instance.open)) || LocalCooperativeManager.instance.cameraFocusedOnOnePlayer)
		{
			return;
		}
		if (JGAMELELGOB() > 1431f)
		{
			BCLDAIFAFKP(JGAMELELGOB() - Time.unscaledDeltaTime);
			return;
		}
		IPLEPBEKJAG = Vector2.op_Implicit(ILNFOKKOJIJ());
		JJPNEDGKAAP = false;
		if (GameManager.OPGGPLEOGCG() || GameManager.SinglePlayer() || ConstructionManager.NEOJLHDFFMJ)
		{
			HHOPCCKCBJM = 767f;
			FEOJNEGIHKI = 340f;
		}
		else if (playerNum == 0)
		{
			HHOPCCKCBJM = 1486f;
			FEOJNEGIHKI = 408f;
		}
		else
		{
			HHOPCCKCBJM = 1575f;
			FEOJNEGIHKI = 1598f;
		}
		if (IPLEPBEKJAG.x > FEOJNEGIHKI)
		{
			IPLEPBEKJAG.x = FEOJNEGIHKI;
			JJPNEDGKAAP = false;
		}
		else if (IPLEPBEKJAG.x < HHOPCCKCBJM)
		{
			IPLEPBEKJAG.x = HHOPCCKCBJM;
			JJPNEDGKAAP = true;
		}
		if (IPLEPBEKJAG.y > 1421f)
		{
			IPLEPBEKJAG.y = 168f;
			JJPNEDGKAAP = true;
		}
		else if (IPLEPBEKJAG.y < 271f)
		{
			IPLEPBEKJAG.y = 1472f;
			JJPNEDGKAAP = false;
		}
		if (JJPNEDGKAAP)
		{
			SetCursorPositionFromViewport(Vector2.op_Implicit(IPLEPBEKJAG));
		}
	}

	public Vector2 FIGOAFLJLLL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(PEDJBILEFCD);
	}

	public void MGAHHNHOKEM(bool DAEMAAOLHMG)
	{
		if ((!DAEMAAOLHMG || !TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE) && !((Object)(object)cursorMask == (Object)null))
		{
			((Behaviour)cursorMask).enabled = DAEMAAOLHMG;
			((Behaviour)cursorMaskImage).enabled = DAEMAAOLHMG;
			((Behaviour)cursorRaycastBlocker).enabled = PlayerInputs.ODGALPDEIFG(playerNum) && DAEMAAOLHMG;
		}
	}

	private void ENJCNGGJAJN()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)MainUI.openedWindow) && MainUI.openedWindow.JIIGOACEIKL != playerNum)
		{
			NIPJALAEHOH(NKFPJPCFBJI: false);
		}
		else if (!IHMADDCNKAM() && ((Object)(object)MainUI.openedWindow == (Object)null || MainUI.openedWindow.JIIGOACEIKL == playerNum))
		{
			NIPJALAEHOH(NKFPJPCFBJI: true);
		}
		SetCursorPositionFromScreen(Vector2.op_Implicit(PlayerInputs.LGGMJONLIGE(playerNum).Mouse.screenPosition));
		NFDIJJAMJBB();
	}

	public float GetVerticalMove()
	{
		if (ConstructionManager.NEOJLHDFFMJ)
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (PlayerInputs.IsGamepadActive(playerNum))
				{
					return PlayerInputs.GetPlayer(playerNum).GetAxis("VerticalMove");
				}
				return PlayerInputs.GetPlayer(playerNum).GetAxis("ObjectVerticalMove");
			}
			return 0f;
		}
		return PlayerInputs.GetPlayer(playerNum).GetAxis("ObjectVerticalMove");
	}

	private void HMOBGCBAGCJ()
	{
		if (!GameManager.NBFLEJHLGNB() && !GameManager.NoPlayers())
		{
			return;
		}
		if (PlayerInputs.EEJEOALIHFJ(0))
		{
			if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
			{
				PHAJGHBEAHG = false;
			}
			SetCursorPos(1, 1);
		}
		else
		{
			PHAJGHBEAHG = true;
			NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}

	public static void GOJONFHJKFN(int JIIGOACEIKL, Vector3 BPLKIPALDNP)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 0)
		{
			IADEMLIIDPC.MBDGNHLBODK(BPLKIPALDNP);
		}
		else
		{
			BBINLIGKIPE.MBDGNHLBODK(BPLKIPALDNP);
		}
	}

	private bool CDAFLPIDLLE()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		HHGEAEBPKHI = BPGKNHJEJCO() * Mathf.Lerp(490f, 862f, (float)Options.IIKOHJMGJIG / 1273f) * Time.unscaledDeltaTime;
		KILGPNECLGG = KLNEINNLGCC() * Mathf.Lerp(1545f, 588f, (float)Options.IIKOHJMGJIG / 200f) * Time.unscaledDeltaTime;
		if (HHGEAEBPKHI != 780f || KILGPNECLGG != 193f)
		{
			if (HJFGMODBNCD < 576f)
			{
				HJFGMODBNCD += Time.deltaTime * 1361f;
			}
			if (HJFGMODBNCD < 1748f)
			{
				JMNENCNFNGN = Mathf.Lerp(1095f, 258f, HJFGMODBNCD);
			}
			else
			{
				JMNENCNFNGN = 449f;
			}
			HHGEAEBPKHI *= JMNENCNFNGN;
			KILGPNECLGG *= JMNENCNFNGN;
			ALMELPKKCIO(NFEOCAGIKEG + new Vector3(HHGEAEBPKHI, KILGPNECLGG));
			return true;
		}
		HJFGMODBNCD = 862f;
		KIPINDDCDKM(NFEOCAGIKEG);
		return true;
	}

	public void AMDJLKEGEIA(Vector3 GOOKKKGIGBL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		IIIKCOBAFPA.anchoredPosition = Vector2.op_Implicit(BPKBMKKODNK(new Vector3(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y, 246f)));
		NFEOCAGIKEG = CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(playerNum).ScreenToWorldPoint(IKMFEPDGBFI());
		NFEOCAGIKEG.z = 295f;
	}

	public float NCJADCOFOHK()
	{
		if (ConstructionManager.NEOJLHDFFMJ)
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (PlayerInputs.EEJEOALIHFJ(playerNum))
				{
					return PlayerInputs.DEGBDMMDIIL(playerNum).GNCBKEDHLHN(" ");
				}
				return PlayerInputs.GetPlayer(playerNum).GetAxis("NormalLeftExterior");
			}
			return 1179f;
		}
		return PlayerInputs.GetPlayer(playerNum).GNCBKEDHLHN("position");
	}

	public static void DNMILJNDLCN(int JIIGOACEIKL, CursorType FHEEFKMNALH)
	{
		if (JIIGOACEIKL == 0)
		{
			IADEMLIIDPC.NPKNHILNKBD(FHEEFKMNALH);
		}
		else
		{
			BBINLIGKIPE.CPJDKNOBNNC(FHEEFKMNALH);
		}
	}

	private bool NPCJNLPOBBD()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		HHGEAEBPKHI = NCJADCOFOHK() * Mathf.Lerp(165f, 300f, (float)Options.IIKOHJMGJIG / 1063f) * Time.unscaledDeltaTime;
		KILGPNECLGG = GetVerticalMove() * Mathf.Lerp(967f, 320f, (float)Options.IIKOHJMGJIG / 943f) * Time.unscaledDeltaTime;
		if (HHGEAEBPKHI != 1450f || KILGPNECLGG != 403f)
		{
			if (HJFGMODBNCD < 1717f)
			{
				HJFGMODBNCD += Time.deltaTime * 262f;
			}
			if (HJFGMODBNCD < 717f)
			{
				JMNENCNFNGN = Mathf.Lerp(1362f, 636f, HJFGMODBNCD);
			}
			else
			{
				JMNENCNFNGN = 104f;
			}
			HHGEAEBPKHI *= JMNENCNFNGN;
			KILGPNECLGG *= JMNENCNFNGN;
			GMLEKFPDBOI(NFEOCAGIKEG + new Vector3(HHGEAEBPKHI, KILGPNECLGG));
			return true;
		}
		HJFGMODBNCD = 1440f;
		GMLEKFPDBOI(NFEOCAGIKEG);
		return false;
	}

	private void BGHLHBHNHPO(int GELMAIBEHDO)
	{
		if (playerNum == GELMAIBEHDO)
		{
			ActivateCursorMask(DAEMAAOLHMG: false);
		}
	}

	private bool PAALHJPEDLE()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		HHGEAEBPKHI = FJLGIPEEMOI() * Mathf.Lerp(561f, 1343f, (float)Options.IIKOHJMGJIG / 1976f) * Time.unscaledDeltaTime;
		KILGPNECLGG = GetVerticalMove() * Mathf.Lerp(955f, 1451f, (float)Options.IIKOHJMGJIG / 1849f) * Time.unscaledDeltaTime;
		if (HHGEAEBPKHI != 1908f || KILGPNECLGG != 1559f)
		{
			if (HJFGMODBNCD < 545f)
			{
				HJFGMODBNCD += Time.deltaTime * 1174f;
			}
			if (HJFGMODBNCD < 1282f)
			{
				JMNENCNFNGN = Mathf.Lerp(703f, 1293f, HJFGMODBNCD);
			}
			else
			{
				JMNENCNFNGN = 237f;
			}
			HHGEAEBPKHI *= JMNENCNFNGN;
			KILGPNECLGG *= JMNENCNFNGN;
			LKJAOHGIKCO(NFEOCAGIKEG + new Vector3(HHGEAEBPKHI, KILGPNECLGG));
			return false;
		}
		HJFGMODBNCD = 1191f;
		MBDGNHLBODK(NFEOCAGIKEG);
		return true;
	}

	public void NIPJALAEHOH(bool NKFPJPCFBJI)
	{
		if (!PlayerInputs.POLDHCKJINN(playerNum))
		{
			if (NKFPJPCFBJI)
			{
				if (!IsCursorVisible())
				{
					SetCursorPos((int)BCPLJLGKBFF.x, (int)BCPLJLGKBFF.y);
				}
			}
			else if (Application.isFocused)
			{
				GetCursorPos(out MJGMEBDNKKI);
				BCPLJLGKBFF.x = MJGMEBDNKKI.X;
				BCPLJLGKBFF.y = MJGMEBDNKKI.Y;
				SetCursorPos(1, 1);
			}
		}
		if (Object.op_Implicit((Object)(object)cursorImage) && ((Behaviour)cursorImage).enabled != NKFPJPCFBJI)
		{
			((Behaviour)cursorImage).enabled = NKFPJPCFBJI;
		}
	}

	private void KCMBLFILELP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (playerNum == JIIGOACEIKL && GFNHAMCPEAK)
		{
			CPJDKNOBNNC(CursorType.Select);
			EOICBHJHCIC();
			UpdateCursorTexture(NKFPJPCFBJI: true);
		}
	}

	private void NPJOKPLAJMP()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)MainUI.openedWindow) && MainUI.openedWindow.JIIGOACEIKL != playerNum)
		{
			SetCursorVisible(NKFPJPCFBJI: true);
		}
		else if (!IHMADDCNKAM() && ((Object)(object)MainUI.openedWindow == (Object)null || MainUI.openedWindow.JIIGOACEIKL == playerNum))
		{
			NIPJALAEHOH(NKFPJPCFBJI: false);
		}
		SetCursorPositionFromScreen(Vector2.op_Implicit(PlayerInputs.LGGMJONLIGE(playerNum).Mouse.screenPosition));
		GBLKJHPNEAK();
	}

	private void EHBMONGBJFI()
	{
		if (playerNum == 0)
		{
			HNEFHAHLKML = CommonReferences.MNFMOEKMJKN().CursorUIPlayer1;
		}
		else if (playerNum == 5)
		{
			HNEFHAHLKML = CommonReferences.GGFJGHHHEJC.CursorUIPlayer2;
		}
		if ((Object)(object)HNEFHAHLKML != (Object)null)
		{
			cursorMask = HNEFHAHLKML.cursorMask;
			cursorImage = HNEFHAHLKML.cursorImage;
			cursorMaskImage = HNEFHAHLKML.cursorMaskImage;
			cursorRaycastBlocker = HNEFHAHLKML.cursorRaycastBlocker;
			IIIKCOBAFPA = HNEFHAHLKML.cursorImageRectTransform;
		}
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
			PlayerInputs.OnControllerSwitched = (Action)Delegate.Combine(PlayerInputs.OnControllerSwitched, new Action(HMOBGCBAGCJ));
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(OnAnyUIOpen));
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(AEEEPHHFPFA));
			IPGBBDMNMKE(DAEMAAOLHMG: true);
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		}
		else if (playerNum == 6 && !OnlineManager.PlayingOnline())
		{
			BBINLIGKIPE = this;
		}
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(CPPGMNFEGOG));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KNLLFEJAMNN();
		tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(BGHLHBHNHPO));
		if ((Object)(object)cursorImage != (Object)null)
		{
			IIIKCOBAFPA = ((Component)cursorImage).GetComponent<RectTransform>();
		}
		DEMNOAKAHED = 446f;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(AFNBGBMANMH));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(OHHOAFJNJPP));
		CommonReferences commonReferences3 = CommonReferences.MNFMOEKMJKN();
		commonReferences3.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences3.OnPlaceableDeselected, new Action<int, Placeable, bool>(LPCPEGLIPNB));
	}

	private void LPCPEGLIPNB(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK && playerNum == JIIGOACEIKL)
		{
			NPKNHILNKBD(CursorType.Default);
			UpdateCursorTexture(NKFPJPCFBJI: false);
		}
	}

	public Vector2 ILFGBIEOFEH()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)cursorImage).transform.position);
	}

	private void NLIBBOAOFEI()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.BLGCACDAEHL(playerNum) && (playerNum != 7 || GameManager.LocalCoop()))
		{
			NEKMLAKFJDJ = GetCursorWorldPosition();
			if (PlayerInputs.IsGamepadActive(playerNum))
			{
				JAMBDKPGMDF();
			}
			else
			{
				ENJCNGGJAJN();
			}
			AEFMPNNHMPF();
			if (Cursor.visible && !Application.isEditor)
			{
				Cursor.visible = false;
			}
			if (PBIGIIGBHAN)
			{
				HOLFKNIHEEP();
			}
		}
	}

	public static void DGMDLCNBNPI(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop() && !INDKANEMPMP.compatibleWithCoopMode)
		{
			GetPlayer(JIIGOACEIKL).IPGBBDMNMKE(DAEMAAOLHMG: true);
		}
	}

	private void AFNBGBMANMH(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (playerNum == JIIGOACEIKL && GFNHAMCPEAK)
		{
			CPJDKNOBNNC(CursorType.Item);
			AKFANNBLIFL();
			UpdateCursorTexture(NKFPJPCFBJI: false);
		}
	}

	public void DBGALOGCMOO(Vector3 GOOKKKGIGBL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		IIIKCOBAFPA.anchoredPosition = Vector2.op_Implicit(AEIIAMCFGDO(new Vector3(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y, 1569f)));
		NFEOCAGIKEG = CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(playerNum).ScreenToWorldPoint(IKMFEPDGBFI());
		NFEOCAGIKEG.z = 1590f;
	}

	private void GAPJBNMCDDK()
	{
		HNNNJNGKBOC(CursorType.Default);
	}

	private bool LFAJDFBMGGL()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		HHGEAEBPKHI = NCJADCOFOHK() * Mathf.Lerp(1702f, 1157f, (float)Options.IIKOHJMGJIG / 389f) * Time.unscaledDeltaTime;
		KILGPNECLGG = GetVerticalMove() * Mathf.Lerp(1073f, 1671f, (float)Options.IIKOHJMGJIG / 1327f) * Time.unscaledDeltaTime;
		if (HHGEAEBPKHI != 1495f || KILGPNECLGG != 51f)
		{
			if (HJFGMODBNCD < 1793f)
			{
				HJFGMODBNCD += Time.deltaTime * 1203f;
			}
			if (HJFGMODBNCD < 1740f)
			{
				JMNENCNFNGN = Mathf.Lerp(947f, 789f, HJFGMODBNCD);
			}
			else
			{
				JMNENCNFNGN = 1257f;
			}
			HHGEAEBPKHI *= JMNENCNFNGN;
			KILGPNECLGG *= JMNENCNFNGN;
			MBDGNHLBODK(NFEOCAGIKEG + new Vector3(HHGEAEBPKHI, KILGPNECLGG));
			return true;
		}
		HJFGMODBNCD = 1268f;
		ALMELPKKCIO(NFEOCAGIKEG);
		return false;
	}

	public Vector3 GetCursorScreenPosition()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.GGFJGHHHEJC.GetScreenCamera().ViewportToScreenPoint(GetCursorViewportPosition());
	}

	public static void AEEEPHHFPFA(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop() && !INDKANEMPMP.compatibleWithCoopMode)
		{
			GetPlayer(JIIGOACEIKL).HKJEEPFJNFO(DAEMAAOLHMG: true);
		}
	}

	private void PCJPHFBLHAF()
	{
		if (GLMJHNMBNHF && !PHAJGHBEAHG)
		{
			EKHMMNNOEOI = false;
		}
		if (FarmConstructionManager.IsActived())
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (!PHAJGHBEAHG && !GLMJHNMBNHF)
				{
					if ((Object)(object)ConstructionManager.currentInstantiatedGO != (Object)null || (Object)(object)FarmConstructionManager.OIFCIKGLCJB != (Object)null)
					{
						CursorAppears();
					}
					else
					{
						SetCursorVisible(NKFPJPCFBJI: false);
					}
				}
			}
			else
			{
				SetCursorVisible(NKFPJPCFBJI: false);
			}
		}
		else if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (!PHAJGHBEAHG && !GLMJHNMBNHF)
				{
					if (DecorationMode.GetPlayer(playerNum).DMBFKFLDDLH || ConstructionActionBarUI.currentPanel == 3)
					{
						CursorAppears();
					}
					else
					{
						SetCursorVisible(NKFPJPCFBJI: false);
					}
				}
			}
			else
			{
				SetCursorVisible(NKFPJPCFBJI: false);
			}
		}
		else if (!GLMJHNMBNHF)
		{
			if (!PHAJGHBEAHG && (GetHorizontalMove() != 0f || GetVerticalMove() != 0f))
			{
				CursorAppears();
			}
			if (IsCursorVisible())
			{
				OGKJJAABDFD = 0f;
				if (DEMNOAKAHED > cursorDisappearTime)
				{
					SetCursorVisible(NKFPJPCFBJI: false);
					PHAJGHBEAHG = false;
				}
				else
				{
					DEMNOAKAHED += Time.unscaledDeltaTime;
				}
			}
			else
			{
				OGKJJAABDFD += Time.unscaledDeltaTime;
			}
		}
		if (PHAJGHBEAHG)
		{
			if (ECJJILDODPJ())
			{
				DEMNOAKAHED = 0f;
			}
			NFDIJJAMJBB();
		}
	}

	private void IOJMGEBNLGN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (playerNum == JIIGOACEIKL && GFNHAMCPEAK)
		{
			NPKNHILNKBD(CursorType.Placing);
			EOICBHJHCIC();
			UpdateCursorTexture(NKFPJPCFBJI: false);
		}
	}

	public static CursorManager CMDGPJEIIJI(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		if (JIIGOACEIKL == 1)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)"add item 1445 20");
		return null;
	}

	private void AAOMCHHNKKM()
	{
		NPKNHILNKBD(CursorType.Select);
	}

	private void CPJDKNOBNNC(CursorType FHEEFKMNALH)
	{
		this.FHEEFKMNALH = FHEEFKMNALH;
	}

	private bool AAIIOOFJPJN()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		HHGEAEBPKHI = NCJADCOFOHK() * Mathf.Lerp(558f, 834f, (float)Options.IIKOHJMGJIG / 1259f) * Time.unscaledDeltaTime;
		KILGPNECLGG = GetVerticalMove() * Mathf.Lerp(650f, 1270f, (float)Options.IIKOHJMGJIG / 274f) * Time.unscaledDeltaTime;
		if (HHGEAEBPKHI != 629f || KILGPNECLGG != 965f)
		{
			if (HJFGMODBNCD < 1329f)
			{
				HJFGMODBNCD += Time.deltaTime * 1507f;
			}
			if (HJFGMODBNCD < 1889f)
			{
				JMNENCNFNGN = Mathf.Lerp(1009f, 1750f, HJFGMODBNCD);
			}
			else
			{
				JMNENCNFNGN = 1513f;
			}
			HHGEAEBPKHI *= JMNENCNFNGN;
			KILGPNECLGG *= JMNENCNFNGN;
			MBDGNHLBODK(NFEOCAGIKEG + new Vector3(HHGEAEBPKHI, KILGPNECLGG));
			return true;
		}
		HJFGMODBNCD = 953f;
		LKJAOHGIKCO(NFEOCAGIKEG);
		return true;
	}

	private void EOICBHJHCIC()
	{
		if (Object.op_Implicit((Object)(object)TutorialManager.GGFJGHHHEJC) && TutorialManager.GGFJGHHHEJC.GCEHLDLKOIC)
		{
			FHEEFKMNALH = CursorType.Select;
		}
		if (FHEEFKMNALH != DEPJHENIMLP)
		{
			switch (FHEEFKMNALH)
			{
			case CursorType.Default:
				HEJNLFCKOKE = cursorSelectSprite;
				break;
			case CursorType.Select:
				HEJNLFCKOKE = cursorSelectSprite;
				break;
			case CursorType.Placing:
				HEJNLFCKOKE = cursorPlacingSprite;
				break;
			case CursorType.Mouse:
				HEJNLFCKOKE = cursorMouseSprite;
				break;
			case CursorType.Item:
				HEJNLFCKOKE = cursorItemSprite;
				break;
			default:
				HEJNLFCKOKE = cursorSelectSprite;
				break;
			}
			cursorImage.sprite = HEJNLFCKOKE;
			DEPJHENIMLP = FHEEFKMNALH;
		}
	}

	private void EGACIHOKJLH()
	{
		PGBKFNPCPDE = ((Component)MenuUI.BDAGIEIJOOG()).GetComponent<RectTransform>();
	}

	private void KLKPIACKPCI(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (playerNum == JIIGOACEIKL && GFNHAMCPEAK)
		{
			HNNNJNGKBOC((CursorType)8);
			AKFANNBLIFL();
			UpdateCursorTexture(NKFPJPCFBJI: false);
		}
	}

	public static void AACNDMPICFG(int JIIGOACEIKL, Vector3 BPLKIPALDNP)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 0)
		{
			IADEMLIIDPC.GMLEKFPDBOI(BPLKIPALDNP);
		}
		else
		{
			BBINLIGKIPE.MBDGNHLBODK(BPLKIPALDNP);
		}
	}

	private void HJDLNCOAKIK()
	{
		PGBKFNPCPDE = ((Component)MenuUI.DIHCEGINELM()).GetComponent<RectTransform>();
	}

	public static void CEABODHKJHO(int JIIGOACEIKL, bool NKFPJPCFBJI)
	{
		if (JIIGOACEIKL == 0)
		{
			IADEMLIIDPC.PHAJGHBEAHG = NKFPJPCFBJI;
		}
		else
		{
			BBINLIGKIPE.PHAJGHBEAHG = NKFPJPCFBJI;
		}
	}

	public Vector3 ILNFOKKOJIJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(IIIKCOBAFPA.anchoredPosition / PGBKFNPCPDE.sizeDelta);
	}

	private void JAMBDKPGMDF()
	{
		if (GLMJHNMBNHF && !PHAJGHBEAHG)
		{
			CBGHFKGFGKM(AODONKKHPBP: false);
		}
		if (FarmConstructionManager.IsActived())
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (!PHAJGHBEAHG && !GLMJHNMBNHF)
				{
					if ((Object)(object)ConstructionManager.currentInstantiatedGO != (Object)null || (Object)(object)FarmConstructionManager.AHAPLDALHDD() != (Object)null)
					{
						MGGNJMAAOID();
					}
					else
					{
						SetCursorVisible(NKFPJPCFBJI: false);
					}
				}
			}
			else
			{
				NIPJALAEHOH(NKFPJPCFBJI: true);
			}
		}
		else if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (!PHAJGHBEAHG && !GLMJHNMBNHF)
				{
					if (DecorationMode.OCJGHINCLJM(playerNum).GABNNLJOMHI() || ConstructionActionBarUI.currentPanel == 0)
					{
						MGGNJMAAOID();
					}
					else
					{
						NIPJALAEHOH(NKFPJPCFBJI: false);
					}
				}
			}
			else
			{
				SetCursorVisible(NKFPJPCFBJI: true);
			}
		}
		else if (!GLMJHNMBNHF)
		{
			if (!PHAJGHBEAHG && (GetHorizontalMove() != 689f || KLNEINNLGCC() != 223f))
			{
				CursorAppears();
			}
			if (LALPELGNIJB())
			{
				OGKJJAABDFD = 710f;
				if (DEMNOAKAHED > cursorDisappearTime)
				{
					NIPJALAEHOH(NKFPJPCFBJI: true);
					PHAJGHBEAHG = true;
				}
				else
				{
					DEMNOAKAHED += Time.unscaledDeltaTime;
				}
			}
			else
			{
				OGKJJAABDFD += Time.unscaledDeltaTime;
			}
		}
		if (PHAJGHBEAHG)
		{
			if (NPCJNLPOBBD())
			{
				DEMNOAKAHED = 1835f;
			}
			KCHFOFIJEAP();
		}
	}

	private void PCIDNGOKJDN()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)MainUI.openedWindow) && MainUI.openedWindow.JIIGOACEIKL != playerNum)
		{
			SetCursorVisible(NKFPJPCFBJI: false);
		}
		else if (!IHMADDCNKAM() && ((Object)(object)MainUI.openedWindow == (Object)null || MainUI.openedWindow.JIIGOACEIKL == playerNum))
		{
			SetCursorVisible(NKFPJPCFBJI: false);
		}
		ADDBKLAFFNO(Vector2.op_Implicit(PlayerInputs.GetPlayerControllers(playerNum).Mouse.screenPosition));
		NBHEOGEDFLA();
	}

	public static void PEBAFOGDNHJ(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop() && !INDKANEMPMP.compatibleWithCoopMode)
		{
			GetPlayer(JIIGOACEIKL).IPGBBDMNMKE(DAEMAAOLHMG: true);
		}
	}

	private void HIPNEFOEJPL()
	{
		NPKNHILNKBD(CursorType.Default);
	}

	public static void MJNAGHKCDEI(int JIIGOACEIKL, Vector3 BPLKIPALDNP)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.ALMELPKKCIO(BPLKIPALDNP);
		}
		else
		{
			BBINLIGKIPE.MBDGNHLBODK(BPLKIPALDNP);
		}
	}

	private void IMEOEFJKLEA()
	{
		if (!GameManager.PlayingOnline())
		{
			if (playerNum == 4)
			{
				PHAJGHBEAHG = false;
				SetCursorVisible(NKFPJPCFBJI: true);
			}
			MGAHHNHOKEM(DAEMAAOLHMG: true);
		}
	}

	private void KCHFOFIJEAP()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		if ((!ConstructionManager.NEOJLHDFFMJ && (((Object)(object)MainUI.openedWindow != (Object)null && !MainUI.openedWindow.compatibleWithCoopMode) || TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO || NewTutorialManager.instance.open)) || LocalCooperativeManager.instance.cameraFocusedOnOnePlayer)
		{
			return;
		}
		if (FLCGEKBIMIK > 943f)
		{
			BCLDAIFAFKP(FLCGEKBIMIK - Time.unscaledDeltaTime);
			return;
		}
		IPLEPBEKJAG = Vector2.op_Implicit(ILNFOKKOJIJ());
		JJPNEDGKAAP = false;
		if (GameManager.OPGGPLEOGCG() || GameManager.SinglePlayer() || ConstructionManager.NEOJLHDFFMJ)
		{
			HHOPCCKCBJM = 930f;
			FEOJNEGIHKI = 1383f;
		}
		else if (playerNum == 1)
		{
			HHOPCCKCBJM = 1227f;
			FEOJNEGIHKI = 201f;
		}
		else
		{
			HHOPCCKCBJM = 220f;
			FEOJNEGIHKI = 510f;
		}
		if (IPLEPBEKJAG.x > FEOJNEGIHKI)
		{
			IPLEPBEKJAG.x = FEOJNEGIHKI;
			JJPNEDGKAAP = true;
		}
		else if (IPLEPBEKJAG.x < HHOPCCKCBJM)
		{
			IPLEPBEKJAG.x = HHOPCCKCBJM;
			JJPNEDGKAAP = false;
		}
		if (IPLEPBEKJAG.y > 8f)
		{
			IPLEPBEKJAG.y = 1778f;
			JJPNEDGKAAP = false;
		}
		else if (IPLEPBEKJAG.y < 45f)
		{
			IPLEPBEKJAG.y = 253f;
			JJPNEDGKAAP = false;
		}
		if (JJPNEDGKAAP)
		{
			GFHBGOCJGPK(Vector2.op_Implicit(IPLEPBEKJAG));
		}
	}

	private void NPKNHILNKBD(CursorType FHEEFKMNALH)
	{
		this.FHEEFKMNALH = FHEEFKMNALH;
	}

	private bool ECJJILDODPJ()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		HHGEAEBPKHI = GetHorizontalMove() * Mathf.Lerp(3f, 25f, (float)Options.IIKOHJMGJIG / 10f) * Time.unscaledDeltaTime;
		KILGPNECLGG = GetVerticalMove() * Mathf.Lerp(3f, 25f, (float)Options.IIKOHJMGJIG / 10f) * Time.unscaledDeltaTime;
		if (HHGEAEBPKHI != 0f || KILGPNECLGG != 0f)
		{
			if (HJFGMODBNCD < 1f)
			{
				HJFGMODBNCD += Time.deltaTime * 2f;
			}
			if (HJFGMODBNCD < 1f)
			{
				JMNENCNFNGN = Mathf.Lerp(0f, 1f, HJFGMODBNCD);
			}
			else
			{
				JMNENCNFNGN = 1f;
			}
			HHGEAEBPKHI *= JMNENCNFNGN;
			KILGPNECLGG *= JMNENCNFNGN;
			KIPINDDCDKM(NFEOCAGIKEG + new Vector3(HHGEAEBPKHI, KILGPNECLGG));
			return true;
		}
		HJFGMODBNCD = 0f;
		KIPINDDCDKM(NFEOCAGIKEG);
		return false;
	}

	public static void PIPKELEBLKB(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop() && !INDKANEMPMP.compatibleWithCoopMode)
		{
			CMDGPJEIIJI(JIIGOACEIKL).HKJEEPFJNFO(DAEMAAOLHMG: true);
		}
	}

	public void HKJEEPFJNFO(bool DAEMAAOLHMG)
	{
		if ((!DAEMAAOLHMG || !TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE) && !((Object)(object)cursorMask == (Object)null))
		{
			((Behaviour)cursorMask).enabled = DAEMAAOLHMG;
			((Behaviour)cursorMaskImage).enabled = DAEMAAOLHMG;
			((Behaviour)cursorRaycastBlocker).enabled = !PlayerInputs.ODGALPDEIFG(playerNum) && DAEMAAOLHMG;
		}
	}

	public Vector2 MEDKMHMANIN()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)cursorImage).transform.position);
	}

	private void NMIEBOFNIKD()
	{
		if (!GameManager.FGFJEGOEDKJ())
		{
			if (playerNum == 4)
			{
				PHAJGHBEAHG = true;
				NIPJALAEHOH(NKFPJPCFBJI: false);
			}
			IPGBBDMNMKE(DAEMAAOLHMG: false);
		}
	}

	private void Start()
	{
		PGBKFNPCPDE = ((Component)MenuUI.GGFJGHHHEJC).GetComponent<RectTransform>();
	}

	public Vector3 IKMFEPDGBFI()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.MNFMOEKMJKN().ACIFGIBLENB().ViewportToScreenPoint(GetCursorViewportPosition());
	}

	[SpecialName]
	public float KKJKGFCMDDI()
	{
		return _003CHIGBFKDMLIO_003Ek__BackingField;
	}

	public static void OnAnyUIClose(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop() && !INDKANEMPMP.compatibleWithCoopMode)
		{
			GetPlayer(JIIGOACEIKL).ActivateCursorMask(DAEMAAOLHMG: true);
		}
	}

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetCursorPos(out POINT ACDBIIGIOBF);

	public void ADDBKLAFFNO(Vector3 DAADKDLNAGE)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		IPLEPBEKJAG = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().ACIFGIBLENB().ScreenToViewportPoint(DAADKDLNAGE));
		IIIKCOBAFPA.anchoredPosition = Vector2.op_Implicit(BPKBMKKODNK(new Vector3(IPLEPBEKJAG.x * PGBKFNPCPDE.sizeDelta.x, IPLEPBEKJAG.y * PGBKFNPCPDE.sizeDelta.y, 1300f)));
		NFEOCAGIKEG = CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(playerNum).ScreenToWorldPoint(DAADKDLNAGE);
		NFEOCAGIKEG.z = 1962f;
	}

	public void UpdateCursorTexture(bool NKFPJPCFBJI)
	{
		PBIGIIGBHAN = NKFPJPCFBJI;
	}

	public void ChangeCursorTexture(CursorType FHEEFKMNALH)
	{
		NPKNHILNKBD(FHEEFKMNALH);
		EOICBHJHCIC();
	}

	private void GELMGKDMJFE()
	{
		PGBKFNPCPDE = ((Component)MenuUI.OJJDNLEFNPJ()).GetComponent<RectTransform>();
	}

	private void DAEJLBJDEIM()
	{
		PGBKFNPCPDE = ((Component)MenuUI.GGFJGHHHEJC).GetComponent<RectTransform>();
	}

	public Vector2 ADAKFICJPIK()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)cursorImage).transform.position);
	}

	private void ILELFPKKPKK()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)MainUI.openedWindow) && MainUI.openedWindow.JIIGOACEIKL != playerNum)
		{
			SetCursorVisible(NKFPJPCFBJI: true);
		}
		else if (!LALPELGNIJB() && ((Object)(object)MainUI.openedWindow == (Object)null || MainUI.openedWindow.JIIGOACEIKL == playerNum))
		{
			NIPJALAEHOH(NKFPJPCFBJI: true);
		}
		SetCursorPositionFromScreen(Vector2.op_Implicit(PlayerInputs.GetPlayerControllers(playerNum).Mouse.screenPosition));
		KCHFOFIJEAP();
	}

	public Vector2 DMDKFMGIEHB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(PEDJBILEFCD);
	}

	private void NBHEOGEDFLA()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		if ((!ConstructionManager.NEOJLHDFFMJ && (((Object)(object)MainUI.openedWindow != (Object)null && !MainUI.openedWindow.compatibleWithCoopMode) || TutorialManager.GGFJGHHHEJC.FJIEPAIMELO() || NewTutorialManager.instance.open)) || LocalCooperativeManager.instance.cameraFocusedOnOnePlayer)
		{
			return;
		}
		if (JGAMELELGOB() > 1560f)
		{
			BCLDAIFAFKP(JGAMELELGOB() - Time.unscaledDeltaTime);
			return;
		}
		IPLEPBEKJAG = Vector2.op_Implicit(HEEMGJLEAPM());
		JJPNEDGKAAP = false;
		if (GameManager.NoPlayers() || GameManager.NBFLEJHLGNB() || ConstructionManager.NEOJLHDFFMJ)
		{
			HHOPCCKCBJM = 1183f;
			FEOJNEGIHKI = 1421f;
		}
		else if (playerNum == 1)
		{
			HHOPCCKCBJM = 1517f;
			FEOJNEGIHKI = 366f;
		}
		else
		{
			HHOPCCKCBJM = 1315f;
			FEOJNEGIHKI = 670f;
		}
		if (IPLEPBEKJAG.x > FEOJNEGIHKI)
		{
			IPLEPBEKJAG.x = FEOJNEGIHKI;
			JJPNEDGKAAP = false;
		}
		else if (IPLEPBEKJAG.x < HHOPCCKCBJM)
		{
			IPLEPBEKJAG.x = HHOPCCKCBJM;
			JJPNEDGKAAP = false;
		}
		if (IPLEPBEKJAG.y > 734f)
		{
			IPLEPBEKJAG.y = 1221f;
			JJPNEDGKAAP = true;
		}
		else if (IPLEPBEKJAG.y < 72f)
		{
			IPLEPBEKJAG.y = 856f;
			JJPNEDGKAAP = false;
		}
		if (JJPNEDGKAAP)
		{
			DBGALOGCMOO(Vector2.op_Implicit(IPLEPBEKJAG));
		}
	}

	private bool CLMJOGFLLGO()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		HHGEAEBPKHI = FJLGIPEEMOI() * Mathf.Lerp(183f, 210f, (float)Options.IIKOHJMGJIG / 1138f) * Time.unscaledDeltaTime;
		KILGPNECLGG = GetVerticalMove() * Mathf.Lerp(356f, 775f, (float)Options.IIKOHJMGJIG / 1942f) * Time.unscaledDeltaTime;
		if (HHGEAEBPKHI != 676f || KILGPNECLGG != 757f)
		{
			if (HJFGMODBNCD < 1722f)
			{
				HJFGMODBNCD += Time.deltaTime * 980f;
			}
			if (HJFGMODBNCD < 73f)
			{
				JMNENCNFNGN = Mathf.Lerp(1747f, 1098f, HJFGMODBNCD);
			}
			else
			{
				JMNENCNFNGN = 1696f;
			}
			HHGEAEBPKHI *= JMNENCNFNGN;
			KILGPNECLGG *= JMNENCNFNGN;
			ALMELPKKCIO(NFEOCAGIKEG + new Vector3(HHGEAEBPKHI, KILGPNECLGG));
			return true;
		}
		HJFGMODBNCD = 718f;
		MBDGNHLBODK(NFEOCAGIKEG);
		return false;
	}

	public void GFHBGOCJGPK(Vector3 GOOKKKGIGBL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		IIIKCOBAFPA.anchoredPosition = Vector2.op_Implicit(HCMCGAFDBLO(new Vector3(GOOKKKGIGBL.x * PGBKFNPCPDE.sizeDelta.x, GOOKKKGIGBL.y * PGBKFNPCPDE.sizeDelta.y, 1402f)));
		NFEOCAGIKEG = CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(playerNum).ScreenToWorldPoint(CEHENKKHEID());
		NFEOCAGIKEG.z = 361f;
	}

	private void NCOGHEMBDBN()
	{
		if (!((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null) && !((Object)(object)CommonReferences.MNFMOEKMJKN() == (Object)null) && !((Object)(object)TavernConstructionManager.KHMEGDIABBF() == (Object)null))
		{
			if (Object.op_Implicit((Object)(object)TavernConstructionManager.KHMEGDIABBF()) && (Object)(object)CMDGPJEIIJI(playerNum) != (Object)null)
			{
				ActivateCursorMask(DAEMAAOLHMG: false);
			}
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(CPPGMNFEGOG));
			TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
			instance.OnActivated = (Action<int>)Delegate.Remove(instance.OnActivated, new Action<int>(BGHLHBHNHPO));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance2.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(KGKOCCDPLAN));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceablePickedUp, new Action<int, Placeable, bool>(JJPONCEEHGA));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences2.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
		}
	}

	private void HLFACFBMNEE(int GELMAIBEHDO)
	{
		if (playerNum == GELMAIBEHDO)
		{
			ActivateCursorMask(DAEMAAOLHMG: true);
		}
	}

	private void OKHHJDNNNPF()
	{
		PGBKFNPCPDE = ((Component)MenuUI.OJJDNLEFNPJ()).GetComponent<RectTransform>();
	}

	[SpecialName]
	public void CBGHFKGFGKM(bool AODONKKHPBP)
	{
		if (!ConstructionManager.NEOJLHDFFMJ)
		{
			GLMJHNMBNHF = AODONKKHPBP;
			PHAJGHBEAHG = AODONKKHPBP;
			NIPJALAEHOH(AODONKKHPBP);
		}
	}

	public static void PNLDBADHHMI(int JIIGOACEIKL, Vector3 BPLKIPALDNP)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 0)
		{
			IADEMLIIDPC.KIPINDDCDKM(BPLKIPALDNP);
		}
		else
		{
			BBINLIGKIPE.GMLEKFPDBOI(BPLKIPALDNP);
		}
	}

	public static void GEGOEAMGDEE(int JIIGOACEIKL, Vector3 BPLKIPALDNP)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 0)
		{
			IADEMLIIDPC.GMLEKFPDBOI(BPLKIPALDNP);
		}
		else
		{
			BBINLIGKIPE.ALMELPKKCIO(BPLKIPALDNP);
		}
	}

	public float KLNEINNLGCC()
	{
		if (ConstructionManager.NEOJLHDFFMJ)
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (PlayerInputs.FJLAMCHKCOI(playerNum))
				{
					return PlayerInputs.DEGBDMMDIIL(playerNum).GetAxis(".png");
				}
				return PlayerInputs.GetPlayer(playerNum).GNCBKEDHLHN("itemGrog");
			}
			return 359f;
		}
		return PlayerInputs.DEGBDMMDIIL(playerNum).GNCBKEDHLHN("There was an error with the debug rooms, disconnect and try again.");
	}

	public bool LALPELGNIJB()
	{
		if (Object.op_Implicit((Object)(object)cursorImage))
		{
			return ((Behaviour)cursorImage).enabled;
		}
		return false;
	}

	public static bool GetControlCursorWithGamepad(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC.PHAJGHBEAHG;
		}
		if (Object.op_Implicit((Object)(object)BBINLIGKIPE))
		{
			return BBINLIGKIPE.PHAJGHBEAHG;
		}
		return false;
	}

	private void JJPONCEEHGA(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK && playerNum == JIIGOACEIKL)
		{
			CPJDKNOBNNC(CursorType.Select);
			UpdateCursorTexture(NKFPJPCFBJI: true);
		}
	}

	private void HADCIGKNFKK()
	{
		if (!GameManager.PlayingOnline())
		{
			if (!PlayerInputs.IsGamepadActive(playerNum))
			{
				PHAJGHBEAHG = false;
				SetCursorVisible(NKFPJPCFBJI: true);
			}
			ActivateCursorMask(DAEMAAOLHMG: true);
		}
	}

	public float GetHorizontalMove()
	{
		if (ConstructionManager.NEOJLHDFFMJ)
		{
			if (ConstructionUI.current.JIIGOACEIKL == playerNum)
			{
				if (PlayerInputs.IsGamepadActive(playerNum))
				{
					return PlayerInputs.GetPlayer(playerNum).GetAxis("HorizontalMove");
				}
				return PlayerInputs.GetPlayer(playerNum).GetAxis("ObjectHorizontalMove");
			}
			return 0f;
		}
		return PlayerInputs.GetPlayer(playerNum).GetAxis("ObjectHorizontalMove");
	}

	private void HNNNJNGKBOC(CursorType FHEEFKMNALH)
	{
		this.FHEEFKMNALH = FHEEFKMNALH;
	}

	public Vector3 CEHENKKHEID()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ViewportToScreenPoint(GetCursorViewportPosition());
	}

	[SpecialName]
	public bool OOMEEOHNJCK()
	{
		return GLMJHNMBNHF;
	}

	private void Awake()
	{
		if (playerNum == 1)
		{
			HNEFHAHLKML = CommonReferences.GGFJGHHHEJC.CursorUIPlayer1;
		}
		else if (playerNum == 2)
		{
			HNEFHAHLKML = CommonReferences.GGFJGHHHEJC.CursorUIPlayer2;
		}
		if ((Object)(object)HNEFHAHLKML != (Object)null)
		{
			cursorMask = HNEFHAHLKML.cursorMask;
			cursorImage = HNEFHAHLKML.cursorImage;
			cursorMaskImage = HNEFHAHLKML.cursorMaskImage;
			cursorRaycastBlocker = HNEFHAHLKML.cursorRaycastBlocker;
			IIIKCOBAFPA = HNEFHAHLKML.cursorImageRectTransform;
		}
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
			PlayerInputs.OnControllerSwitched = (Action)Delegate.Combine(PlayerInputs.OnControllerSwitched, new Action(MDIKFCCGEED));
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(OnAnyUIOpen));
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(OnAnyUIClose));
			ActivateCursorMask(DAEMAAOLHMG: false);
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		}
		else if (playerNum == 2 && !OnlineManager.PlayingOnline())
		{
			BBINLIGKIPE = this;
		}
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnActivated = (Action<int>)Delegate.Combine(instance.OnActivated, new Action<int>(BGHLHBHNHPO));
		if ((Object)(object)cursorImage != (Object)null)
		{
			IIIKCOBAFPA = ((Component)cursorImage).GetComponent<RectTransform>();
		}
		DEMNOAKAHED = 0f;
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance2.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance3.OnPlaceablePickedUp, new Action<int, Placeable, bool>(OBBDDLKPAII));
		CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
		instance4.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance4.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
	}

	private void GMLEKFPDBOI(Vector3 BPLKIPALDNP)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		PIGIIOMOKMH = CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(playerNum).WorldToScreenPoint(BPLKIPALDNP);
		IPLEPBEKJAG = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().ACIFGIBLENB().ScreenToViewportPoint(PIGIIOMOKMH));
		IIIKCOBAFPA.anchoredPosition = Vector2.op_Implicit(BPKBMKKODNK(new Vector3(IPLEPBEKJAG.x * PGBKFNPCPDE.sizeDelta.x, IPLEPBEKJAG.y * PGBKFNPCPDE.sizeDelta.y, 156f)));
		NFEOCAGIKEG = BPLKIPALDNP;
		NFEOCAGIKEG.z = 1495f;
	}

	public static void MKLDHHIKFIH(int JIIGOACEIKL, CursorType FHEEFKMNALH)
	{
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.CPJDKNOBNNC(FHEEFKMNALH);
		}
		else
		{
			BBINLIGKIPE.NPKNHILNKBD(FHEEFKMNALH);
		}
	}

	public static void GHBHEAICIIM(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop() && !INDKANEMPMP.compatibleWithCoopMode)
		{
			CMDGPJEIIJI(JIIGOACEIKL).HKJEEPFJNFO(DAEMAAOLHMG: true);
		}
	}

	public Vector2 BNONHANABGA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(PEDJBILEFCD);
	}

	public static void NPEAMJBFJIB(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop() && !INDKANEMPMP.compatibleWithCoopMode)
		{
			GetPlayer(JIIGOACEIKL).HKJEEPFJNFO(DAEMAAOLHMG: true);
		}
	}

	private Vector3 BPKBMKKODNK(Vector3 AMILKMFNLCC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(AMILKMFNLCC.x), (float)Mathf.RoundToInt(AMILKMFNLCC.y), (float)Mathf.RoundToInt(AMILKMFNLCC.z));
	}

	private void OBBDDLKPAII(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK && playerNum == JIIGOACEIKL)
		{
			NPKNHILNKBD(CursorType.Select);
			UpdateCursorTexture(NKFPJPCFBJI: true);
		}
	}

	public bool IHMADDCNKAM()
	{
		if (Object.op_Implicit((Object)(object)cursorImage))
		{
			return ((Behaviour)cursorImage).enabled;
		}
		return true;
	}

	public static void BNBMOFHCNLC(int JIIGOACEIKL, CursorType FHEEFKMNALH)
	{
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.HNNNJNGKBOC(FHEEFKMNALH);
		}
		else
		{
			BBINLIGKIPE.CPJDKNOBNNC(FHEEFKMNALH);
		}
	}

	public Vector3 GetCursorViewportPosition()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(IIIKCOBAFPA.anchoredPosition / PGBKFNPCPDE.sizeDelta);
	}

	private void ALMELPKKCIO(Vector3 BPLKIPALDNP)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		PIGIIOMOKMH = CommonReferences.GGFJGHHHEJC.GetMainCamera(playerNum).WorldToScreenPoint(BPLKIPALDNP);
		IPLEPBEKJAG = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().ACIFGIBLENB().ScreenToViewportPoint(PIGIIOMOKMH));
		IIIKCOBAFPA.anchoredPosition = Vector2.op_Implicit(AEIIAMCFGDO(new Vector3(IPLEPBEKJAG.x * PGBKFNPCPDE.sizeDelta.x, IPLEPBEKJAG.y * PGBKFNPCPDE.sizeDelta.y, 511f)));
		NFEOCAGIKEG = BPLKIPALDNP;
		NFEOCAGIKEG.z = 1579f;
	}

	public static void JHADHIGOIPG(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop() && !INDKANEMPMP.compatibleWithCoopMode)
		{
			GetPlayer(JIIGOACEIKL).HKJEEPFJNFO(DAEMAAOLHMG: true);
		}
	}

	public void OBCDJBHHHBL(CursorType FHEEFKMNALH)
	{
		NPKNHILNKBD(FHEEFKMNALH);
		EOICBHJHCIC();
	}

	private Vector3 HCMCGAFDBLO(Vector3 AMILKMFNLCC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(AMILKMFNLCC.x), (float)Mathf.RoundToInt(AMILKMFNLCC.y), (float)Mathf.RoundToInt(AMILKMFNLCC.z));
	}

	private void MBDGNHLBODK(Vector3 BPLKIPALDNP)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		PIGIIOMOKMH = CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(playerNum).WorldToScreenPoint(BPLKIPALDNP);
		IPLEPBEKJAG = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetScreenCamera().ScreenToViewportPoint(PIGIIOMOKMH));
		IIIKCOBAFPA.anchoredPosition = Vector2.op_Implicit(HCMCGAFDBLO(new Vector3(IPLEPBEKJAG.x * PGBKFNPCPDE.sizeDelta.x, IPLEPBEKJAG.y * PGBKFNPCPDE.sizeDelta.y, 1396f)));
		NFEOCAGIKEG = BPLKIPALDNP;
		NFEOCAGIKEG.z = 1601f;
	}

	[SpecialName]
	public bool CMKBEHANJKL()
	{
		return GLMJHNMBNHF;
	}

	[SpecialName]
	public void ALICKGBCJOE(float AODONKKHPBP)
	{
		_003CHIGBFKDMLIO_003Ek__BackingField = AODONKKHPBP;
	}
}
