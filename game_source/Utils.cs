using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using Galaxy.Api;
using Steamworks;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Tilemaps;

public static class Utils
{
	[Serializable]
	private class SettingsData
	{
		public bool multiplayerAgreement;
	}

	[CompilerGenerated]
	private sealed class IOAEAEOCAFL
	{
		public FindPositionsInfo info;

		public Vector3 position;

		internal bool ADLEDELHNEA(KeyValuePair<Vector3, WorldTile> wt)
		{
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			if (wt.Value.groundType != 0 && info.location.HasFlag(wt.Value.location) && info.zoneType.HasFlag(wt.Value.zoneType) && (!info.checkNodeFree || WorldGrid.APKPGNDDJHC(wt.Key)) && (!info.checkCanPlaceObject || WorldGrid.NGDHDMAMGPI(wt.Value)) && (!info.checkDistance || Vector2.Distance(Vector2.op_Implicit(wt.Key), Vector2.op_Implicit(position)) > (float)info.minDistance) && (!info.checkFarmable || WorldGrid.LKBLKCFOEPA(wt.Value)))
			{
				if (info.avoidPath)
				{
					return !WorldGrid.ECOFAPGIGMO(wt.Key);
				}
				return true;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class GJCMICMGKHP
	{
		public string overrideLanguage;

		internal string LOBCKKDHOJE(ItemInstanceAmount slot)
		{
			return slot.itemInstance.MBGFHHDOKHL(OAFPBCPDOKH: true, overrideLanguage);
		}
	}

	private static List<char> BKKHLMBNJGD = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

	private static bool MDBAIEDPBJN = false;

	private static Vector2 LMEKBPPCFJB;

	private static float ILOLBBLNEOA;

	private static float KDKLHPFGLLB;

	private static bool[] DHDIKCFNJPN = new bool[50];

	private static Vector2 FPNFMGNMCOM = new Vector2(-0.25f, 0f);

	private static Vector2 NKDGACAPIDK = new Vector2(0.25f, 0f);

	private static Vector2 DEAHHHABFIB = Vector2.op_Implicit(new Vector3(0f, 0.25f));

	private static Vector2 FDFBBEMBKNC = Vector2.op_Implicit(new Vector3(0f, -0.25f));

	private static Dictionary<Vector2, PathNode> KNEDJAHCBDI = null;

	private static TravelZone[] OKJKAAJHKNG;

	private static Vector3 DAADKDLNAGE;

	private static OrderingInfo[] FMCIAKBJFOC;

	private static MonoBehaviour NPJDIDHOEFB;

	private static List<MonoBehaviour> CENALNOKJCE = new List<MonoBehaviour>();

	private static MonoBehaviour[] DLJHBFBDAEC;

	private static Collider2D[] LGCKFFEMPBD;

	private static Collider2D[] NIAKAMHIMEJ = (Collider2D[])(object)new Collider2D[256];

	private static PointerEventData KBBOADOLFCI;

	private static List<RaycastResult> FJJOFBIHCJJ;

	private static Collider2D[] ILKCKOPJGMM;

	private static float GLOEPFGFIME;

	private static SpriteRenderer KHGFBNICFCN;

	private static SortingGroup DGDNJKBAEFC;

	private static OrderingInfo LJDOMOPBFFF;

	private static SortingGroup AKDDKKHDFEK;

	private static List<OrderingInfo> GDENBNEBKLA;

	private static Dictionary<SortingGroup, List<OrderingInfo>> FFNDHHOHNFH;

	private static List<OrderingInfo> FKFHMPKNNDC = new List<OrderingInfo>();

	private static List<OrderingInfo> JAIJKIAIDKI;

	private static OrderingInfoComparer ONKJEPNPPEB = new OrderingInfoComparer();

	private static OrderingInfo[] MBMHIJMDCPO;

	private static Slot PPFIBIBKBBI;

	private static List<Slot> CDEMNCNPNAP = new List<Slot>();

	private static ZoneType GFBDMNKHKKF;

	private static Location LFLLIMPGPGF;

	private static float MIJLMAIEEHB;

	public static bool disableHalloweenEvent = true;

	private static DateTime LCDIJAFAIEC = new DateTime(2024, 11, 8, 0, 0, 0);

	private static TimeSpan NCLIENJDJMG;

	private static int HCMOKAMNPMG = 99;

	public static bool disableChristmasEvent = false;

	private static DateTime DDKAKILPDBP = new DateTime(2026, 1, 6, 0, 0, 0);

	private static DateTime JBPAALHHCMG = new DateTime(2022, 7, 8, 4, 0, 0);

	private static DateTime BOFCEGOCOBG = new DateTime(2023, 6, 23, 4, 0, 0);

	private static Coroutine DMFCLPEOJPG;

	private static Placeable[] KCJIMDFEBBL;

	private static int NKMJAGDJPJE;

	private static HashSet<Vector3> HAKPCIKJLNM = new HashSet<Vector3>();

	private static List<Vector2> BJOIMCHHGFA = new List<Vector2>();

	private static List<Collider2D> KKBMGOICBDI;

	private static NodePoint GIAFFONHFGP;

	private static HashSet<Vector3> OOPLKGHOBHC = new HashSet<Vector3>();

	private static Transform EEBKFOLEHAB;

	private static Stack<Vector3> EHKLNEKNGDM = new Stack<Vector3>();

	private static Vector3 ECJLMIPAFGP;

	private static Slot KCJBFOAAFLK = null;

	private static List<Slot> GDHKLPOOHEO = new List<Slot>();

	private static int ICMMMGBOALP;

	private const float CCOKBFJFEKM = 4f;

	private const float ADDMFCIDELA = 0.25f;

	private static List<ItemMod> ILEKALFKLFJ;

	private static List<Vector2> NIIDDNEFOEM = new List<Vector2>();

	private static HashSet<Vector2> PFNPCONENGA = new HashSet<Vector2>();

	private static Queue<Vector2> CMOKEBMKDDH = new Queue<Vector2>();

	private static Vector2 FNMKKHCMPNC;

	public static HashSet<Vector3> fertilSoilPositions = new HashSet<Vector3>();

	private static float ACGOMBEKONN;

	private static float KDPMIAECCJM;

	private static Vector3 MDMAAIKFBFB;

	private static Vector3 DBACIMHFEKD;

	public static Dictionary<int, int> dictReplaceItems = new Dictionary<int, int>
	{
		{ 1032, 1031 },
		{ 1, 1031 },
		{ 2, 1035 },
		{ 3, 3023 },
		{ 5, 1064 },
		{ 6, 1062 },
		{ 7, 3022 },
		{ 10, 675 },
		{ 13, 673 },
		{ 14, 3022 },
		{ 15, 676 },
		{ 17, 663 },
		{ 19, 11 },
		{ 21, 1055 },
		{ 22, 615 },
		{ 23, 605 },
		{ 27, 626 },
		{ 28, 662 },
		{ 29, 635 },
		{ 30, 640 },
		{ 31, 1302 },
		{ 32, 650 },
		{ 33, 634 },
		{ 34, 666 },
		{ 35, 647 },
		{ 36, 653 },
		{ 37, 621 },
		{ 38, 1134 },
		{ 39, 627 },
		{ 40, 601 },
		{ 42, 646 },
		{ 43, 661 },
		{ 45, 642 },
		{ 46, 643 },
		{ 47, 628 },
		{ 48, 597 },
		{ 49, 641 },
		{ 52, 644 },
		{ 53, 651 },
		{ 57, 645 },
		{ 59, 660 },
		{ 60, 1132 },
		{ 61, 734 },
		{ 66, 3024 },
		{ 67, 3018 },
		{ 68, 3025 },
		{ 69, 3019 },
		{ 70, 3024 },
		{ 71, 3018 },
		{ 72, 3022 },
		{ 73, 3022 },
		{ 75, 121 },
		{ 76, 667 },
		{ 77, 1292 },
		{ 78, 672 },
		{ 79, 1298 },
		{ 86, 1303 },
		{ 87, 1065 },
		{ 92, 1545 },
		{ 96, 11 },
		{ 97, 11 },
		{ 98, 90 },
		{ 99, 90 },
		{ 100, 11 },
		{ 101, 11 },
		{ 102, 11 },
		{ 104, 11 },
		{ 105, 90 },
		{ 106, 11 },
		{ 107, 11 },
		{ 122, 1520 },
		{ 123, 1518 },
		{ 124, 1517 },
		{ 125, 1546 },
		{ 128, 1546 },
		{ 129, 121 },
		{ 130, 1522 },
		{ 140, 11 },
		{ 141, 11 },
		{ 143, 1546 },
		{ 144, 133 },
		{ 145, 1518 },
		{ 146, 133 },
		{ 147, 1255 },
		{ 149, 3400 },
		{ 152, 660 },
		{ 153, 1131 },
		{ 154, 1131 },
		{ 155, 652 },
		{ 156, 630 },
		{ 160, 157 },
		{ 161, 158 },
		{ 162, 157 },
		{ 163, 158 },
		{ 164, 157 },
		{ 169, 3054 },
		{ 170, 3054 },
		{ 172, 3054 },
		{ 173, 3055 },
		{ 174, 3055 },
		{ 176, 668 },
		{ 177, 1036 },
		{ 178, 1045 },
		{ 179, 1046 },
		{ 181, 1043 },
		{ 185, 1247 },
		{ 186, 1245 },
		{ 187, 1246 },
		{ 188, 1378 },
		{ 189, 1297 },
		{ 195, 1292 },
		{ 196, 1292 },
		{ 201, 1299 },
		{ 202, 1300 },
		{ 203, 1295 },
		{ 220, 3008 },
		{ 226, 3006 },
		{ 233, 3010 },
		{ 235, 3012 },
		{ 236, 3014 },
		{ 242, 3016 },
		{ 247, 3004 },
		{ 269, 3401 },
		{ 282, 3055 },
		{ 283, 3055 },
		{ 284, 3054 },
		{ 285, 3054 },
		{ 286, 3054 },
		{ 288, 3054 },
		{ 294, 3015 },
		{ 295, 3005 },
		{ 298, 3017 },
		{ 301, 3013 },
		{ 306, 3009 },
		{ 307, 3007 },
		{ 311, 3011 },
		{ 317, 1251 },
		{ 318, 1273 },
		{ 325, 1318 },
		{ 326, 632 },
		{ 327, 681 },
		{ 328, 669 },
		{ 329, 671 },
		{ 330, 674 },
		{ 331, 1284 },
		{ 332, 1286 },
		{ 333, 1280 },
		{ 334, 1282 },
		{ 335, 1290 },
		{ 336, 1288 },
		{ 337, 1279 },
		{ 338, 1287 },
		{ 339, 1283 },
		{ 340, 1281 },
		{ 341, 1285 },
		{ 342, 1290 },
		{ 344, 1293 },
		{ 345, 1252 },
		{ 349, 670 },
		{ 350, 1067 },
		{ 352, 351 },
		{ 356, 3055 },
		{ 360, 168 },
		{ 362, 351 },
		{ 363, 351 },
		{ 364, 358 },
		{ 365, 354 },
		{ 367, 357 },
		{ 368, 3055 },
		{ 369, 205 },
		{ 370, 90 },
		{ 372, 638 },
		{ 373, 624 },
		{ 375, 633 },
		{ 376, 619 },
		{ 378, 686 },
		{ 379, 1143 },
		{ 380, 607 },
		{ 382, 636 },
		{ 384, 609 },
		{ 385, 649 },
		{ 606, 605 },
		{ 610, 609 },
		{ 611, 609 },
		{ 613, 612 },
		{ 614, 612 },
		{ 616, 615 },
		{ 617, 615 },
		{ 655, 1131 },
		{ 656, 1132 },
		{ 657, 1131 },
		{ 658, 660 },
		{ 659, 1134 },
		{ 669, 1315 },
		{ 705, 728 },
		{ 721, 1302 },
		{ 722, 1303 },
		{ 1072, 1083 },
		{ 1218, 158 },
		{ 1516, 1546 },
		{ 632, 1699 }
	};

	private static int DJHBGBFCOCH;

	private static float JMFOAKDHFDL;

	private const string DHAHLANNIDH = "/ExtraSettings.sd";

	private static FileStream MIPJKFFDBAE;

	private static BinaryFormatter GKNCHDBNPHE;

	private static IEnumerator NPDDJMIFJMK()
	{
		yield return null;
		yield return null;
		MBODDLPENFB();
	}

	private static void GFBAMCIMECB(List<SlotUI> DPJAFMAJBKF, Slot[] JAGEECPLMIL)
	{
		for (int i = 0; i < DPJAFMAJBKF.Count; i++)
		{
			if (i < JAGEECPLMIL.Length)
			{
				DPJAFMAJBKF[i].IHENCGDNPBL = JAGEECPLMIL[i];
			}
			else
			{
				DPJAFMAJBKF[i].IHENCGDNPBL = null;
			}
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendSlots(JAGEECPLMIL);
		}
	}

	private static void CAEMMONHLNL(Vector3 IMOBLFMHKOD, HashSet<Vector3> OOPLKGHOBHC)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		EHKLNEKNGDM.Clear();
		EHKLNEKNGDM.Push(IMOBLFMHKOD);
		while (EHKLNEKNGDM.Count > 0)
		{
			ECJLMIPAFGP = EHKLNEKNGDM.Pop();
			LBJIBCPJPFH(ECJLMIPAFGP + Vector3.right * 0.5f, OOPLKGHOBHC);
			LBJIBCPJPFH(ECJLMIPAFGP + Vector3.left * 0.5f, OOPLKGHOBHC);
			LBJIBCPJPFH(ECJLMIPAFGP + Vector3.up * 0.5f, OOPLKGHOBHC);
			LBJIBCPJPFH(ECJLMIPAFGP + Vector3.down * 0.5f, OOPLKGHOBHC);
		}
	}

	public static Vector2 JOJPOKBFANL(List<Vector2> HAEIAGKNEPC, Vector2 JAFKHHNPOGJ)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC == null)
		{
			return Vector2.zero;
		}
		if (HAEIAGKNEPC.Count == 1)
		{
			return HAEIAGKNEPC[0];
		}
		LMEKBPPCFJB = HAEIAGKNEPC[0];
		ILOLBBLNEOA = Vector2.Distance(LMEKBPPCFJB, JAFKHHNPOGJ);
		for (int i = 1; i < HAEIAGKNEPC.Count; i++)
		{
			_ = HAEIAGKNEPC[i];
			KDKLHPFGLLB = Vector2.Distance(HAEIAGKNEPC[i], JAFKHHNPOGJ);
			if (KDKLHPFGLLB < ILOLBBLNEOA)
			{
				ILOLBBLNEOA = KDKLHPFGLLB;
				LMEKBPPCFJB = HAEIAGKNEPC[i];
			}
		}
		return LMEKBPPCFJB;
	}

	public static bool DKHBBNHMOEB(int JIIGOACEIKL, Slot ADEBNALPEHE, int PAFEECBJICN = 0, bool CDPAMNIPPEC = true)
	{
		if (ADEBNALPEHE != null && ADEBNALPEHE.itemInstance != null && !ADEBNALPEHE.KPINNBKMOMO() && MouseSlot.GetPlayer(JIIGOACEIKL).slot.KPINNBKMOMO() && ADEBNALPEHE?.itemInstance != null && !PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)304) && PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(ADEBNALPEHE.itemInstance, HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false))
		{
			Sound.GGFJGHHHEJC.PlayOneShot(CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 0.5f);
			ADEBNALPEHE.MEODNPFJDMH(CDPAMNIPPEC: false);
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager.instance.SendSlot(ADEBNALPEHE, PAFEECBJICN);
			}
			return true;
		}
		return false;
	}

	public static List<Slot> KKCHDNLKBMN(List<Slot> OHAPAGLBOOB, Slot[] PPKOGMLDOOC)
	{
		for (int num = OHAPAGLBOOB.Count - 1; num >= 0; num--)
		{
			if (OHAPAGLBOOB[num].itemInstance != null)
			{
				if (!PPKOGMLDOOC[0].KPINNBKMOMO() && OHAPAGLBOOB[num].itemInstance.Equals(PPKOGMLDOOC[0].itemInstance))
				{
					OHAPAGLBOOB.RemoveAt(num);
				}
				else if (!PPKOGMLDOOC[1].KPINNBKMOMO() && OHAPAGLBOOB[num].itemInstance.Equals(PPKOGMLDOOC[1].itemInstance))
				{
					OHAPAGLBOOB.RemoveAt(num);
				}
				else if (!PPKOGMLDOOC[2].KPINNBKMOMO() && OHAPAGLBOOB[num].itemInstance.Equals(PPKOGMLDOOC[2].itemInstance))
				{
					OHAPAGLBOOB.RemoveAt(num);
				}
			}
		}
		return OHAPAGLBOOB;
	}

	public static void BLPDAEHPOBA(GameObject DOFFKPMMCBD, float FLHBPHPKIML)
	{
		DestroyTracer.DestroyWithTrace(DOFFKPMMCBD, FLHBPHPKIML);
	}

	public static T JOJPOKBFANL<T>(T[] CENALNOKJCE, Vector3 JAFKHHNPOGJ) where T : MonoBehaviour
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (CENALNOKJCE == null || CENALNOKJCE.Length == 0)
		{
			return default(T);
		}
		T val = CENALNOKJCE[0];
		float num = Vector3.Distance(((Component)(object)val).transform.position, JAFKHHNPOGJ);
		for (int i = 1; i < CENALNOKJCE.Length; i++)
		{
			if (!((Object)(object)CENALNOKJCE[i] == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)(object)CENALNOKJCE[i]).transform.position, JAFKHHNPOGJ);
				if (num2 < num)
				{
					num = num2;
					val = CENALNOKJCE[i];
				}
			}
		}
		return val;
	}

	public static bool EJPFCKFEMJF(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return IMOBLFMHKOD.y > 800f;
	}

	public static void OKJMFGIFMMB(string LEOFKNOPJGA)
	{
		GUIUtility.systemCopyBuffer = LEOFKNOPJGA;
	}

	public static T DONGABMIDFG<T>(List<T> FNEHIAGFAOF)
	{
		if (FNEHIAGFAOF == null)
		{
			return default(T);
		}
		if (FNEHIAGFAOF.Count == 0)
		{
			return default(T);
		}
		if (FNEHIAGFAOF.Count == 1)
		{
			return FNEHIAGFAOF[0];
		}
		return FNEHIAGFAOF[Random.Range(0, FNEHIAGFAOF.Count)];
	}

	public static Vector2 IKJOHEODBBE(Collider2D DJDHCIHLNDO)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Bounds bounds;
		if (((Behaviour)DJDHCIHLNDO).enabled)
		{
			bounds = DJDHCIHLNDO.bounds;
			return Vector2.op_Implicit(((Bounds)(ref bounds)).max);
		}
		((Behaviour)DJDHCIHLNDO).enabled = true;
		bounds = DJDHCIHLNDO.bounds;
		Vector2 result = Vector2.op_Implicit(((Bounds)(ref bounds)).max);
		((Behaviour)DJDHCIHLNDO).enabled = false;
		return result;
	}

	public static T CPDCJAHJOPE<T>(T[] JMNCLLBHCAO)
	{
		if (JMNCLLBHCAO == null)
		{
			return default(T);
		}
		if (JMNCLLBHCAO.Length == 0)
		{
			return default(T);
		}
		if (JMNCLLBHCAO.Length == 1)
		{
			return JMNCLLBHCAO[0];
		}
		return JMNCLLBHCAO[Random.Range(0, JMNCLLBHCAO.Length)];
	}

	public static bool BMPHEAFDFPI(int JIIGOACEIKL, Slot EFDPGNOICOG, Slot[] MKDOCALGPKJ, Slot[] LCFKMJHDBOB, Container ALPOKDOCCGM)
	{
		KCJBFOAAFLK = BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, MKDOCALGPKJ, ALPOKDOCCGM);
		if (KCJBFOAAFLK == null)
		{
			KCJBFOAAFLK = BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, LCFKMJHDBOB, ALPOKDOCCGM);
		}
		if (KCJBFOAAFLK != null && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendSlots(new Slot[2] { KCJBFOAAFLK, EFDPGNOICOG });
		}
		return KCJBFOAAFLK != null;
	}

	public static bool COLGDCJOLJF()
	{
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 1; i < 5; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && PlayerController.GetPlayer(i).IsTavernLocation())
				{
					return true;
				}
			}
		}
		else
		{
			if (PlayerController.GetPlayer(1).IsTavernLocation())
			{
				return true;
			}
			if (GameManager.LocalCoop() && PlayerController.GetPlayer(2).IsTavernLocation())
			{
				return true;
			}
		}
		return false;
	}

	public static T KJOMDMEIAEJ<T>(Vector2 MJGMEBDNKKI, int FCPJIPBPGFK = -5) where T : MonoBehaviour
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		LGCKFFEMPBD = Physics2D.OverlapPointAll(MJGMEBDNKKI);
		Collider2D[] lGCKFFEMPBD = LGCKFFEMPBD;
		for (int i = 0; i < lGCKFFEMPBD.Length; i++)
		{
			T component = ((Component)lGCKFFEMPBD[i]).GetComponent<T>();
			if ((Object)(object)component != (Object)null)
			{
				return component;
			}
		}
		return default(T);
	}

	public static bool PEIFNLAFAEE(MonoBehaviour KCGACKIMHHA, MonoBehaviour EBAKLCKNJCH)
	{
		if ((Object)(object)KCGACKIMHHA == (Object)null)
		{
			return true;
		}
		if ((Object)(object)KCGACKIMHHA != (Object)(object)EBAKLCKNJCH)
		{
			Debug.LogError((object)("Duplicate instance of singleton on gameobject " + ((Object)EBAKLCKNJCH).name), (Object)(object)((Component)EBAKLCKNJCH).gameObject);
			return false;
		}
		return true;
	}

	public static Vector2 JBGFJENPEIM(Vector3 IMOBLFMHKOD, Vector2Int KKANDELPDKP, FindPositionsInfo BBJDPIJPLPA, Vector2 PABCOACIILO)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		if (BBJDPIJPLPA.checkDistance && WorldGrid.HJPCBBGHPDA(IMOBLFMHKOD) != BBJDPIJPLPA.location)
		{
			BBJDPIJPLPA.checkDistance = false;
		}
		CLGHKOEGACP(Vector2.op_Implicit(IMOBLFMHKOD), PABCOACIILO, BBJDPIJPLPA, ref BJOIMCHHGFA);
		if (KKANDELPDKP == Vector2Int.one)
		{
			if (BJOIMCHHGFA.Count > 0)
			{
				return BJOIMCHHGFA.ElementAt(Random.Range(0, BJOIMCHHGFA.Count)) + Vector2.one * 0.25f;
			}
			return Vector2.op_Implicit(IMOBLFMHKOD);
		}
		Vector2[] NHINLEILOJO = (Vector2[])(object)new Vector2[((Vector2Int)(ref KKANDELPDKP)).x * ((Vector2Int)(ref KKANDELPDKP)).y];
		List<Vector3> list = new List<Vector3>();
		while (BJOIMCHHGFA.Count > 0)
		{
			int index = Random.Range(0, BJOIMCHHGFA.Count);
			WorldGrid.MDJDAKIMMJA(BJOIMCHHGFA[index], KKANDELPDKP, ref NHINLEILOJO);
			if (WorldGrid.NGDDILJAHEK(NHINLEILOJO))
			{
				list.Add(Vector2.op_Implicit(BJOIMCHHGFA[index]));
			}
			WorldGrid.MDJDAKIMMJA(BJOIMCHHGFA[index] + NKDGACAPIDK, KKANDELPDKP, ref NHINLEILOJO);
			if (WorldGrid.NGDDILJAHEK(NHINLEILOJO))
			{
				list.Add(Vector2.op_Implicit(BJOIMCHHGFA[index] + NKDGACAPIDK));
			}
			WorldGrid.MDJDAKIMMJA(BJOIMCHHGFA[index] + DEAHHHABFIB, KKANDELPDKP, ref NHINLEILOJO);
			if (WorldGrid.NGDDILJAHEK(NHINLEILOJO))
			{
				list.Add(Vector2.op_Implicit(BJOIMCHHGFA[index] + DEAHHHABFIB));
			}
			WorldGrid.MDJDAKIMMJA(BJOIMCHHGFA[index] + new Vector2(0.25f, 0.25f), KKANDELPDKP, ref NHINLEILOJO);
			if (WorldGrid.NGDDILJAHEK(NHINLEILOJO))
			{
				list.Add(Vector2.op_Implicit(BJOIMCHHGFA[index] + new Vector2(0.25f, 0.25f)));
			}
			if (list.Count > 0)
			{
				return Vector2.op_Implicit(list.ElementAt(Random.Range(0, list.Count)));
			}
			BJOIMCHHGFA.RemoveAt(index);
		}
		return Vector2.op_Implicit(IMOBLFMHKOD);
	}

	public static IEnumerator DJOILMPJEME(CharacterAnimator LMENBHLBGLH, float LGLDPMAABLA)
	{
		float timeElapsed2;
		for (timeElapsed2 = 0f; timeElapsed2 < LGLDPMAABLA; timeElapsed2 += 0.2f)
		{
			for (int i = 0; i < LMENBHLBGLH.allReskins.Length; i++)
			{
				LMENBHLBGLH.allReskins[i].spriteRenderer.color = Color.red;
			}
			yield return CommonReferences.wait02;
			timeElapsed2 += 0.2f;
			if (timeElapsed2 >= LGLDPMAABLA)
			{
				break;
			}
			for (int j = 0; j < LMENBHLBGLH.allReskins.Length; j++)
			{
				LMENBHLBGLH.allReskins[j].spriteRenderer.color = Color.white;
			}
			yield return CommonReferences.wait02;
		}
		for (int k = 0; k < LMENBHLBGLH.allReskins.Length; k++)
		{
			LMENBHLBGLH.allReskins[k].spriteRenderer.color = Color.white;
		}
	}

	private static bool LOFACGFAOIA(Type NCMDEGABGCH, Type[] DKJLOKHJLJC)
	{
		for (int i = 0; i < DKJLOKHJLJC.Length; i++)
		{
			if (DKJLOKHJLJC[i].IsAssignableFrom(NCMDEGABGCH))
			{
				return true;
			}
		}
		return false;
	}

	public static bool OHFOEIBLGKP(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i <= 4; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerInventory.RemoveItems(i, MEMGMDOCBOJ.JDJGFAACPFC(), 99);
			}
		}
		DroppedItem.RemoveAllDroppedItems(MEMGMDOCBOJ);
		CraftingInventory.RemoveItemFromAllContainers(MEMGMDOCBOJ);
		Bin.instance.RemoveItem(MEMGMDOCBOJ);
		return true;
	}

	public static bool DOOILKJLDHD(ItemInstance BGLFLHDNOKJ, Container ALPOKDOCCGM)
	{
		return DOOILKJLDHD(BGLFLHDNOKJ, ALPOKDOCCGM.bannedTags, ALPOKDOCCGM.allowedItemsType, ALPOKDOCCGM.allowedItemsList, null, ALPOKDOCCGM.allowedIngredientTypes, ALPOKDOCCGM.allowedFoodType, ALPOKDOCCGM.specialItemsAllowedList, ALPOKDOCCGM.canBeSoldFood);
	}

	public static string FCOPLCGPMLN()
	{
		if (FFLNGLMHLBO())
		{
			NCLIENJDJMG = LCDIJAFAIEC - DateTime.UtcNow;
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("TimeLeft"), NCLIENJDJMG.Days + LocalisationSystem.Get("dForDays") + " : " + NCLIENJDJMG.Hours + LocalisationSystem.Get("hForHours") + " : " + NCLIENJDJMG.Minutes + LocalisationSystem.Get("mForMins") + " : " + NCLIENJDJMG.Seconds + LocalisationSystem.Get("sForSeconds"));
		}
		return "00" + LocalisationSystem.Get("dForDays") + " : 00" + LocalisationSystem.Get("hForHours") + " : 00" + LocalisationSystem.Get("mForMins") + " : 00" + LocalisationSystem.Get("sForSeconds");
	}

	public static void OACPIEGCCCO(DrawGizmosType KFJGKFBDPCL, Location BAIMHDBJPDK, int KNIBEKEBAHD = 0)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		switch (KFJGKFBDPCL)
		{
		case DrawGizmosType.None:
			return;
		case DrawGizmosType.PathNodes:
			MOIIHDKPMBB(BAIMHDBJPDK, KNIBEKEBAHD);
			return;
		case DrawGizmosType.SnowProbability:
		{
			foreach (KeyValuePair<Vector3, WorldTile> worldTile in GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM)
			{
				if (worldTile.Value.location == BAIMHDBJPDK)
				{
					if ((double)worldTile.Value.snowProbability < 0.33)
					{
						Gizmos.color = Color.green;
					}
					else if ((double)worldTile.Value.snowProbability < 0.66)
					{
						Gizmos.color = new Color(255f, 127f, 0f);
					}
					else
					{
						Gizmos.color = Color.red;
					}
					Gizmos.DrawSphere(worldTile.Key + new Vector3(0.25f, 0.25f), 0.1f);
				}
			}
			return;
		}
		}
		if (GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM == null)
		{
			return;
		}
		foreach (KeyValuePair<Vector3, WorldTile> worldTile2 in GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM)
		{
			if (worldTile2.Value.location != BAIMHDBJPDK)
			{
				continue;
			}
			if (KFJGKFBDPCL == DrawGizmosType.CanPlaceObjects && (!worldTile2.Value.canPlaceObjects || worldTile2.Value.blockingObjects != null) && worldTile2.Value.canPlaceSeat)
			{
				Gizmos.color = new Color(0f, 0f, 1f, 0.7f);
			}
			else if ((KFJGKFBDPCL == DrawGizmosType.Wall && !worldTile2.Value.wall) || (KFJGKFBDPCL == DrawGizmosType.Buildable && !worldTile2.Value.buildable) || (KFJGKFBDPCL == DrawGizmosType.AnyPlaceable && (worldTile2.Value.placeables == null || worldTile2.Value.placeables.Count == 0)) || (KFJGKFBDPCL == DrawGizmosType.Wooded && !worldTile2.Value.wooded) || (KFJGKFBDPCL == DrawGizmosType.Fishing && !worldTile2.Value.canFishSeasons.Equals(Season.Spring)) || (KFJGKFBDPCL == DrawGizmosType.Farmable && !worldTile2.Value.farmable) || (KFJGKFBDPCL == DrawGizmosType.Doors && (Object)(object)worldTile2.Value.door == (Object)null) || (KFJGKFBDPCL == DrawGizmosType.CanPlaceObjects && (!worldTile2.Value.canPlaceObjects || worldTile2.Value.blockingObjects != null)) || (KFJGKFBDPCL == DrawGizmosType.BlockingObjects && worldTile2.Value.blockingObjects == null) || (KFJGKFBDPCL == DrawGizmosType.HasSnow && !worldTile2.Value.hasSnow) || (KFJGKFBDPCL == DrawGizmosType.IsWater && !WorldGrid.AOPAJANIPDB(worldTile2.Key)))
			{
				Gizmos.color = Color.red * new Color(1f, 1f, 1f, 0.4f);
			}
			else
			{
				switch (KFJGKFBDPCL)
				{
				case DrawGizmosType.IsPath:
					if (!worldTile2.Value.isPath && !worldTile2.Value.isHorsePath)
					{
						Gizmos.color = Color.red * new Color(1f, 1f, 1f, 0.4f);
					}
					else if (worldTile2.Value.isHorsePath)
					{
						Gizmos.color = Color.yellow * new Color(1f, 0.6f, 1f, 0.4f);
					}
					else
					{
						Gizmos.color = Color.yellow * new Color(1f, 1f, 1f, 0.4f);
					}
					break;
				case DrawGizmosType.GroundType:
					switch (worldTile2.Value.groundType)
					{
					case GroundType.Floor:
						if (worldTile2.Value.materialType == MaterialType.Stone)
						{
							Gizmos.color = Color.grey * new Color(1f, 1f, 1f, 0.4f);
						}
						else if (worldTile2.Value.materialType == MaterialType.Wood)
						{
							Gizmos.color = Color.red * new Color(1f, 1f, 1f, 0.4f);
						}
						else
						{
							Gizmos.color = Color.magenta * new Color(1f, 1f, 1f, 0.4f);
						}
						break;
					case GroundType.Grass:
						Gizmos.color = Color.green * new Color(1f, 1f, 1f, 0.4f);
						break;
					case GroundType.Ground:
						Gizmos.color = Color.yellow * new Color(1f, 1f, 1f, 0.4f);
						break;
					case GroundType.Sand:
						Gizmos.color = new Color(1f, 0f, 1f, 0.4f);
						break;
					case GroundType.TilledEarth:
						Gizmos.color = new Color(0.6f, 0.1f, 0f, 0.4f);
						break;
					case GroundType.Stone:
						Gizmos.color = Color.grey * new Color(1f, 1f, 1f, 0.4f);
						break;
					default:
						Gizmos.color = Color.blue * new Color(1f, 1f, 1f, 0.4f);
						break;
					}
					break;
				case DrawGizmosType.Location:
					switch (worldTile2.Value.location)
					{
					case Location.Tavern:
						Gizmos.color = Color.red * new Color(1f, 1f, 1f, 0.4f);
						break;
					case Location.Road:
						Gizmos.color = Color.yellow * new Color(1f, 1f, 1f, 0.4f);
						break;
					default:
						Gizmos.color = Color.blue * new Color(1f, 1f, 1f, 0.4f);
						break;
					}
					break;
				default:
					Gizmos.color = Color.yellow * new Color(1f, 1f, 1f, 0.4f);
					break;
				}
			}
			Gizmos.DrawCube(worldTile2.Key + new Vector3(0.25f, 0.25f), new Vector3(0.3f, 0.3f));
		}
	}

	public static void DLIIAHACOJB(int JFNMCNCHMEO, bool CDPAMNIPPEC = false)
	{
		try
		{
			if (MBCCIAKKPMJ(JFNMCNCHMEO))
			{
				return;
			}
			if (SteamManager.BNBMMDGMKLM)
			{
				SteamUserStats.SetAchievement("Ach_" + JFNMCNCHMEO);
				SteamUserStats.StoreStats();
				DHDIKCFNJPN[JFNMCNCHMEO] = true;
			}
			else if (GalaxyInstance.User() != null && GalaxyInstance.User().SignedIn())
			{
				GalaxyManager.Instance.StatsAndAchievements.SetAchievement("Ach_" + JFNMCNCHMEO);
				DHDIKCFNJPN[JFNMCNCHMEO] = true;
			}
		}
		catch
		{
			Debug.LogError((object)"Error unlocking achievements. This is most likely because we are not signed in to Steam or GOG.");
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineBasicsManager.instance.SendNewAchievement(JFNMCNCHMEO);
		}
	}

	public static DecorationTile KMJAGBLPODO(TavernFloor BDCFJAHNOML)
	{
		if (EditorActionsDBAccessor.IsValid())
		{
			return EditorActionsDBAccessor.GetDecoTile(FDNIGJBNNMF(BDCFJAHNOML));
		}
		return null;
	}

	public static IEnumerator PGPMDFAEOEH(float KCGLKOAJNPB, float HAFLNNPJJKK)
	{
		float initialTimeScale = Time.timeScale;
		float currentLerpTime = 0f;
		while (currentLerpTime < HAFLNNPJJKK)
		{
			currentLerpTime += Time.unscaledDeltaTime;
			float num = currentLerpTime / HAFLNNPJJKK;
			num = num * num * num * (num * (6f * num - 15f) + 10f);
			Time.timeScale = Mathf.Lerp(initialTimeScale, KCGLKOAJNPB, num);
			yield return null;
		}
		DMFCLPEOJPG = null;
	}

	public static Direction ABNPPDOGEPM(Direction FCGBJEIIMBC)
	{
		return FCGBJEIIMBC switch
		{
			Direction.Up => Direction.Down, 
			Direction.Left => Direction.Right, 
			Direction.Right => Direction.Left, 
			_ => Direction.Up, 
		};
	}

	public static bool ABPDGOHBKIG(Direction FCGBJEIIMBC)
	{
		if (FCGBJEIIMBC != Direction.Right)
		{
			return FCGBJEIIMBC == Direction.Left;
		}
		return true;
	}

	public static bool JJDGNMHLHJD(this ZoneType AODONKKHPBP, ZoneType AKPKDELPEHN)
	{
		return (AODONKKHPBP & AKPKDELPEHN) == AKPKDELPEHN;
	}

	public static bool DLOMIGFOOPD(int JIIGOACEIKL)
	{
		if (OFBMJPNCHAA(JIIGOACEIKL).Count > 0)
		{
			return true;
		}
		return false;
	}

	public static Vector3 KGEOMOKKFKP(int JIIGOACEIKL, int JNLPKLIJPJB)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return KGEOMOKKFKP(PlayerController.GetPlayer(JIIGOACEIKL), JNLPKLIJPJB);
	}

	public static bool MMMFJPKECAB(Location NFHFNKHHGGI)
	{
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && PlayerController.GetPlayer(i).LEOIMFNKFGA != NFHFNKHHGGI)
			{
				return false;
			}
		}
		return true;
	}

	public static TilemapScene JGEPCPFJANP(Vector2 IMOBLFMHKOD)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		LFLLIMPGPGF = CommonReferences.GGFJGHHHEJC.tilemapsInfo.HJPCBBGHPDA(IMOBLFMHKOD);
		return JGEPCPFJANP(LFLLIMPGPGF);
	}

	public static bool PLIACJACMMI(Item MEMGMDOCBOJ)
	{
		if (CraftingInventory.GetSlotsWithItem(1, MEMGMDOCBOJ, null, AKNBKINJGCF: false, null).Count > 0)
		{
			return true;
		}
		if (PlaceablesManager.GGFJGHHHEJC.ExistsPlaceable(MEMGMDOCBOJ))
		{
			return true;
		}
		return false;
	}

	public static T COGFNHHIAML<T>(int JIIGOACEIKL) where T : MonoBehaviour
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (!OJNCNEJJHDD(JIIGOACEIKL))
		{
			return default(T);
		}
		if (DLOMIGFOOPD(JIIGOACEIKL))
		{
			return default(T);
		}
		Collider2D[] array = Physics2D.OverlapPointAll(Vector2.op_Implicit(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition()), -5);
		if (array.Length != 0)
		{
			for (int i = 0; i < array.Length; i++)
			{
				T component = ((Component)array[i]).GetComponent<T>();
				if ((Object)(object)component != (Object)null && ((Behaviour)(object)component).enabled)
				{
					return component;
				}
			}
		}
		return default(T);
	}

	public static Vector3 EKCCGNEDPNO(Vector3 IMOBLFMHKOD, int JIIGOACEIKL)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3(LCGAHGBBDBD(IMOBLFMHKOD.x, JIIGOACEIKL), LCGAHGBBDBD(IMOBLFMHKOD.y, JIIGOACEIKL), IMOBLFMHKOD.z);
	}

	public static void EJDPJCJHHIM(bool BMMONBIDIAC)
	{
		if (!File.Exists(Application.persistentDataPath + "/ExtraSettings.sd"))
		{
			MIPJKFFDBAE = File.Create(Application.persistentDataPath + "/ExtraSettings.sd");
		}
		else
		{
			MIPJKFFDBAE = File.OpenWrite(Application.persistentDataPath + "/ExtraSettings.sd");
		}
		SettingsData settingsData = new SettingsData();
		settingsData.multiplayerAgreement = BMMONBIDIAC;
		GKNCHDBNPHE = new BinaryFormatter();
		GKNCHDBNPHE.Serialize(MIPJKFFDBAE, settingsData);
		MIPJKFFDBAE.Close();
	}

	public static bool HKEKJHKGOJD(Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) == GroundType.None)
		{
			return false;
		}
		if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(IMOBLFMHKOD)))
		{
			return WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(IMOBLFMHKOD));
		}
		return true;
	}

	private static void FOBNOCNONBF(Vector2 IMOBLFMHKOD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (!PFNPCONENGA.Contains(IMOBLFMHKOD + NKDGACAPIDK))
		{
			CMOKEBMKDDH.Enqueue(IMOBLFMHKOD + NKDGACAPIDK);
			PFNPCONENGA.Add(IMOBLFMHKOD + NKDGACAPIDK);
		}
		if (!PFNPCONENGA.Contains(IMOBLFMHKOD + FPNFMGNMCOM))
		{
			CMOKEBMKDDH.Enqueue(IMOBLFMHKOD + FPNFMGNMCOM);
			PFNPCONENGA.Add(IMOBLFMHKOD + FPNFMGNMCOM);
		}
		if (!PFNPCONENGA.Contains(IMOBLFMHKOD + DEAHHHABFIB))
		{
			CMOKEBMKDDH.Enqueue(IMOBLFMHKOD + DEAHHHABFIB);
			PFNPCONENGA.Add(IMOBLFMHKOD + DEAHHHABFIB);
		}
		if (!PFNPCONENGA.Contains(IMOBLFMHKOD + FDFBBEMBKNC))
		{
			CMOKEBMKDDH.Enqueue(IMOBLFMHKOD + FDFBBEMBKNC);
			PFNPCONENGA.Add(IMOBLFMHKOD + FDFBBEMBKNC);
		}
	}

	public static List<Collider2D> LPONJPMNLLJ(Vector2 MJGMEBDNKKI, Vector2 KKANDELPDKP, CapsuleDirection2D LIFDAOHBBHJ, float GLOEPFGFIME, int FCPJIPBPGFK = -1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		int num = Physics2D.OverlapCapsuleNonAlloc(MJGMEBDNKKI, KKANDELPDKP, LIFDAOHBBHJ, GLOEPFGFIME, NIAKAMHIMEJ, FCPJIPBPGFK);
		List<Collider2D> list = new List<Collider2D>();
		for (int i = 0; i < num; i++)
		{
			if (!NIAKAMHIMEJ[i].isTrigger)
			{
				list.Add(NIAKAMHIMEJ[i]);
			}
		}
		return list;
	}

	public static GameObject JCNFPEHGGKP(GameObject ANADFOCHOBF)
	{
		if (OnlineManager.PlayingOnline() && OnlineManager.OnlinePrefabExists(ANADFOCHOBF))
		{
			return OnlineManager.Instantiate(ANADFOCHOBF);
		}
		return Object.Instantiate<GameObject>(ANADFOCHOBF);
	}

	public static Vector3 PFAONDFCNFD(int JIIGOACEIKL)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return PFAONDFCNFD(PlayerController.GetPlayer(JIIGOACEIKL));
	}

	public static TilemapScene JGEPCPFJANP(Location BAIMHDBJPDK)
	{
		if (!Application.isPlaying)
		{
			TilemapScene[] array = Object.FindObjectsOfType<TilemapScene>();
			foreach (TilemapScene tilemapScene in array)
			{
				if (tilemapScene.location == BAIMHDBJPDK)
				{
					return tilemapScene;
				}
			}
			return null;
		}
		if ((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		if (CommonReferences.GGFJGHHHEJC.allTilemapsScenes == null)
		{
			return null;
		}
		if (CommonReferences.GGFJGHHHEJC.allTilemapsScenes.ContainsKey(BAIMHDBJPDK))
		{
			return CommonReferences.GGFJGHHHEJC.allTilemapsScenes[BAIMHDBJPDK];
		}
		if (BAIMHDBJPDK == Location.BarnInterior && (Object)(object)Barn.instance != (Object)null)
		{
			return CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM];
		}
		return null;
	}

	public static Direction LFOGGLLPPBI(Vector2 DPNLDLEHMHO, Direction LFJKPDEMMLC)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (((Vector2)(ref DPNLDLEHMHO)).magnitude > 0.015f * Time.deltaTime)
		{
			GLOEPFGFIME = Vector2.SignedAngle(DPNLDLEHMHO, Vector2.up);
			switch (LFJKPDEMMLC)
			{
			case Direction.Up:
				if (GLOEPFGFIME > -40f && GLOEPFGFIME < 40f)
				{
					return Direction.Up;
				}
				break;
			case Direction.Left:
				if (GLOEPFGFIME < -20f && GLOEPFGFIME > -160f)
				{
					return Direction.Left;
				}
				break;
			case Direction.Right:
				if (GLOEPFGFIME > 20f && GLOEPFGFIME < 160f)
				{
					return Direction.Right;
				}
				break;
			case Direction.Down:
				if (GLOEPFGFIME <= -140f || GLOEPFGFIME >= 140f)
				{
					return Direction.Down;
				}
				break;
			}
			if (GLOEPFGFIME > -30f && GLOEPFGFIME < 30f)
			{
				return Direction.Up;
			}
			if (GLOEPFGFIME >= 30f && GLOEPFGFIME <= 150f)
			{
				return Direction.Right;
			}
			if (GLOEPFGFIME <= -30f && GLOEPFGFIME >= -150f)
			{
				return Direction.Left;
			}
			return Direction.Down;
		}
		return LFJKPDEMMLC;
	}

	public static bool PPJPJMPHKBJ(Transform KIKJBMLLHII, Transform IPFKFLKBGNI, Transform GABKFMFFDFD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(IPFKFLKBGNI.position);
		Vector2 val2 = Vector2.op_Implicit(GABKFMFFDFD.position);
		Vector2 val3 = Vector2.op_Implicit(KIKJBMLLHII.position);
		if (val3.x >= val.x && val3.x <= val2.x)
		{
			if (val3.y >= val.y)
			{
				return val3.y <= val2.y;
			}
			return false;
		}
		return false;
	}

	public static bool ICKPBBINMOH(this GroundType AODONKKHPBP, GroundType AKPKDELPEHN)
	{
		return (AODONKKHPBP & AKPKDELPEHN) == AKPKDELPEHN;
	}

	public static List<Slot> HIJGDAHBBIA(int JIIGOACEIKL, Item MEMGMDOCBOJ, Item NHACCPPICKI, int MGNOBNCMDJG, Recipe KMNOGHMAAEK, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool MMDICAMGNCL)
	{
		ILEKALFKLFJ = ODFMBJKNIEG(MEMGMDOCBOJ, KMNOGHMAAEK);
		GDHKLPOOHEO = CraftingInventory.GetSlotsWithItems(JIIGOACEIKL, ILEKALFKLFJ, NHACCPPICKI, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA: true);
		GDHKLPOOHEO = ENELGLONHKJ(GDHKLPOOHEO);
		if (MMDICAMGNCL)
		{
			DLKKOLGNKHH(GDHKLPOOHEO, MGNOBNCMDJG);
		}
		return GDHKLPOOHEO;
	}

	public static bool PINPKCAOEFL(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return PINPKCAOEFL(HJPCBBGHPDA(Vector2.op_Implicit(IMOBLFMHKOD)));
	}

	public static bool IELGICCBCHO(SpecificType CPPHBDEOJEC)
	{
		if (!CPPHBDEOJEC.HasFlag(SpecificType.Door))
		{
			return CPPHBDEOJEC.HasFlag(SpecificType.RoomDoor);
		}
		return true;
	}

	public static int ILDPJNAFIAG(float KDPHEAAOBGD)
	{
		return Mathf.RoundToInt(KDPHEAAOBGD);
	}

	public static bool HFJABMOFIML()
	{
		if (GameManager.NoPlayers())
		{
			return false;
		}
		if ((Object)(object)JGEPCPFJANP(PlayerController.GetPlayer(1).LEOIMFNKFGA) != (Object)null && TilemapsInfo.ELHHFNFJIAD(PlayerController.GetPlayer(1).LEOIMFNKFGA) == InteriorType.Exterior)
		{
			return true;
		}
		if (GameManager.LocalCoop() && (Object)(object)JGEPCPFJANP(PlayerController.GetPlayer(2).LEOIMFNKFGA) != (Object)null && TilemapsInfo.ELHHFNFJIAD(PlayerController.GetPlayer(2).LEOIMFNKFGA) == InteriorType.Exterior)
		{
			return true;
		}
		return false;
	}

	public static bool CJBADHDNEOC(this ZoneType AODONKKHPBP, ZoneType AKPKDELPEHN)
	{
		return (AODONKKHPBP & AKPKDELPEHN) != 0;
	}

	public static bool DOOILKJLDHD(ItemInstance BGLFLHDNOKJ, List<Tag> HPDCGCHCABK, Type[] DKJLOKHJLJC, Item[] EHHCDAGDKMC, List<IngredientModifier> EMHAHFPLAGB, List<IngredientType> MLOHKFFEEGP, FoodType KIJHENLPKAA, List<Item> FMKPPODOELE, bool OECLHGILEOL)
	{
		if (BGLFLHDNOKJ == null)
		{
			return false;
		}
		if (FMKPPODOELE != null && FMKPPODOELE.Contains(BGLFLHDNOKJ.LHBPOPOIFLE()))
		{
			return true;
		}
		if (Item.MLBOMGHINCA(BGLFLHDNOKJ.LHBPOPOIFLE(), null) && (HPDCGCHCABK == null || !CAAOCBKFLHH(BGLFLHDNOKJ?.LHBPOPOIFLE()?.tags, HPDCGCHCABK)) && (EHHCDAGDKMC == null || EHHCDAGDKMC.Length == 0 || EHHCDAGDKMC.Contains(BGLFLHDNOKJ.LHBPOPOIFLE())) && (!OECLHGILEOL || (BGLFLHDNOKJ is FoodInstance foodInstance && foodInstance.LHBPOPOIFLE().canBeSold && (!foodInstance.LHBPOPOIFLE().hasToBeAgedMeal || foodInstance.GBCJNGADANM > 0))) && (DKJLOKHJLJC == null || (DKJLOKHJLJC.Length == 0 && (EMHAHFPLAGB == null || !LAAIBNEKHOH(BGLFLHDNOKJ, EMHAHFPLAGB))) || LOFACGFAOIA(((object)BGLFLHDNOKJ.LHBPOPOIFLE()).GetType(), DKJLOKHJLJC)) && (MLOHKFFEEGP == null || MLOHKFFEEGP.Count == 0 || (BGLFLHDNOKJ.LHBPOPOIFLE() is Food food && MLOHKFFEEGP.Contains(food.ingredientType))))
		{
			if (KIJHENLPKAA != 0)
			{
				if (BGLFLHDNOKJ.LHBPOPOIFLE() is Food food2)
				{
					return KIJHENLPKAA == food2.foodType;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public static bool DPFCPGIEJDF()
	{
		return CommonReferences.GetEditorConfiguration().autoSaveActivated;
	}

	private static void IACLKEGBBKL<T>(ref List<T> FNEHIAGFAOF, IComparer<T> HNOBKMEKEKM)
	{
		int count = FNEHIAGFAOF.Count;
		for (int i = 1; i < count; i++)
		{
			T val = FNEHIAGFAOF[i];
			int num = i - 1;
			while (num >= 0 && HNOBKMEKEKM.Compare(FNEHIAGFAOF[num], val) == 1)
			{
				FNEHIAGFAOF[num + 1] = FNEHIAGFAOF[num];
				num--;
			}
			FNEHIAGFAOF[num + 1] = val;
		}
	}

	public static bool OHFBPMIKGHB()
	{
		return File.Exists(Application.persistentDataPath + "/ExtraSettings.sd");
	}

	public static int FDNIGJBNNMF(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return FDNIGJBNNMF(FCFHPAPKOEL(IMOBLFMHKOD));
	}

	private static Slot BMPHEAFDFPI(int JIIGOACEIKL, Slot EFDPGNOICOG, Slot[] PCJEDMJEKEF, Container ALPOKDOCCGM)
	{
		if (!DOOILKJLDHD(EFDPGNOICOG.itemInstance, ALPOKDOCCGM))
		{
			return null;
		}
		Slot slot = null;
		Slot slot2 = null;
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			if (PCJEDMJEKEF[i] == null)
			{
				continue;
			}
			if (PCJEDMJEKEF[i].KPINNBKMOMO())
			{
				if (slot == null)
				{
					slot = PCJEDMJEKEF[i];
				}
			}
			else if (PCJEDMJEKEF[i].Stack < ALPOKDOCCGM.GetMaxStack(PCJEDMJEKEF[i].itemInstance) && Slot.MJLNPAEBAFF(JIIGOACEIKL, EFDPGNOICOG, PCJEDMJEKEF[i]))
			{
				slot2 = PCJEDMJEKEF[i];
				break;
			}
		}
		if (slot2 == null && slot != null && Slot.MJLNPAEBAFF(JIIGOACEIKL, EFDPGNOICOG, slot))
		{
			slot2 = slot;
		}
		return slot2;
	}

	public static void BNDMCJGGBFK(Slot[] PCJEDMJEKEF, string KCILJNKFCCN = null)
	{
		List<ItemInstanceAmount> jAGEECPLMIL = (from slot in PCJEDMJEKEF
			where !slot.KPINNBKMOMO()
			select new ItemInstanceAmount(slot.itemInstance, slot.Stack) into slot
			orderby slot.itemInstance.LHBPOPOIFLE() is Food, ((object)slot.itemInstance.LHBPOPOIFLE()).GetType().ToString(), slot.itemInstance.LHBPOPOIFLE() is Food food2 && !food2.canBeSold, slot.itemInstance.JEPBBEBJEFI(), slot.itemInstance.LHBPOPOIFLE().tags.Contains(Tag.Unaged), slot.itemInstance is FoodInstance foodInstance && foodInstance.AJOMICMACEJ.saveMainIngredient, (!(slot.itemInstance.LHBPOPOIFLE() is Food food)) ? ((int)((slot.itemInstance.LHBPOPOIFLE().tags.Length == 0) ? ((Tag)100) : slot.itemInstance.LHBPOPOIFLE().tags[0])) : ((int)food.ingredientType), slot.itemInstance.MBGFHHDOKHL(OAFPBCPDOKH: true, KCILJNKFCCN), -slot.amount
			select slot).ToList();
		GFBAMCIMECB(1, PCJEDMJEKEF, jAGEECPLMIL);
	}

	public static bool PINPKCAOEFL(Location NFHFNKHHGGI)
	{
		if (OnlineManager.IsMasterClient())
		{
			if (OnlineManager.PlayingOnline())
			{
				for (int i = 2; i < 5; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && PlayerController.GetPlayer(i).LEOIMFNKFGA == NFHFNKHHGGI)
					{
						return true;
					}
				}
			}
			else
			{
				if (PlayerController.GetPlayer(1).LEOIMFNKFGA == NFHFNKHHGGI)
				{
					return true;
				}
				if (GameManager.LocalCoop() && PlayerController.GetPlayer(2).LEOIMFNKFGA == NFHFNKHHGGI)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static void FKKHJPEMNBG(string NKBAEMLKJEO, float FFDIEOBBFKL)
	{
		if (!(FFDIEOBBFKL > 0f))
		{
			return;
		}
		if (SteamManager.BNBMMDGMKLM)
		{
			if (SteamUserStats.GetStat(NKBAEMLKJEO, ref JMFOAKDHFDL))
			{
				JMFOAKDHFDL += FFDIEOBBFKL;
				SteamUserStats.SetStat(NKBAEMLKJEO, JMFOAKDHFDL);
				SteamUserStats.StoreStats();
			}
		}
		else if (GalaxyInstance.User() != null && GalaxyInstance.User().SignedIn())
		{
			JMFOAKDHFDL = GalaxyManager.Instance.StatsAndAchievements.GetStatFloat(NKBAEMLKJEO);
			JMFOAKDHFDL += FFDIEOBBFKL;
			GalaxyManager.Instance.StatsAndAchievements.SetStatFloat(NKBAEMLKJEO, JMFOAKDHFDL);
			MHOHJOHBAED(NKBAEMLKJEO, JMFOAKDHFDL);
		}
	}

	public static Vector3 NGFODNCHPHB(Direction FCGBJEIIMBC)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		return (Vector3)(FCGBJEIIMBC switch
		{
			Direction.Up => Vector3.up, 
			Direction.Left => Vector3.left, 
			Direction.Right => Vector3.right, 
			_ => Vector3.down, 
		});
	}

	public static void JAALINCKLPO(Vector3 IMOBLFMHKOD, bool NHIKGIKOMHH)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (NHIKGIKOMHH)
		{
			GIAFFONHFGP = KJOMDMEIAEJ<NodePoint>(Vector2.op_Implicit(IMOBLFMHKOD));
			if (Object.op_Implicit((Object)(object)GIAFFONHFGP))
			{
				WorldGrid.LMMELLKNMCF(IMOBLFMHKOD, GIAFFONHFGP.free);
				return;
			}
		}
		KKBMGOICBDI = LPONJPMNLLJ(Vector2.op_Implicit(IMOBLFMHKOD), new Vector2(0.3f, 0.2f), (CapsuleDirection2D)1, 0f, 3145728);
		WorldGrid.LMMELLKNMCF(IMOBLFMHKOD, KKBMGOICBDI.Count == 0);
	}

	public static bool DHMNBPCEMHB(this Location AODONKKHPBP, Location AKPKDELPEHN)
	{
		return (AODONKKHPBP & AKPKDELPEHN) != 0;
	}

	public static float PMNDBKBJJNP(float KDPHEAAOBGD)
	{
		return Mathf.Round(KDPHEAAOBGD);
	}

	public static bool AKDEMLPGIPH()
	{
		if (DateTime.Now.Day < 15 || DateTime.Now.Month != 12 || DateTime.Now.Year != 2025)
		{
			if (DateTime.Now.Day <= 5 && DateTime.Now.Month == 1)
			{
				return DateTime.Now.Year == 2026;
			}
			return false;
		}
		return true;
	}

	public static bool HNDBNJNJGJM(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (EJPFCKFEMJF(IMOBLFMHKOD))
		{
			return !BLIAFMGPONN(IMOBLFMHKOD);
		}
		return false;
	}

	private static Vector3 KAECEBHAPFG(GameObject NAIBCCAOBIL)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = SceneReferences.GetSceneReferences().newFarmPosition.position - SceneReferences.GetSceneReferences().oldFarmPositionMin.position;
		Vector3 val2 = BMBMPKNANAC(NAIBCCAOBIL.transform.position + val);
		WorldGrid.MMOHADHAAGD(val2, GroundType.TilledEarth, Location.Road);
		return val2;
	}

	public static string EDOCHLCJOME()
	{
		if (EGIBECKKIJJ())
		{
			NCLIENJDJMG = DDKAKILPDBP - DateTime.UtcNow;
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("TimeLeft"), NCLIENJDJMG.Days + LocalisationSystem.Get("dForDays") + " : " + NCLIENJDJMG.Hours + LocalisationSystem.Get("hForHours") + " : " + NCLIENJDJMG.Minutes + LocalisationSystem.Get("mForMins") + " : " + NCLIENJDJMG.Seconds + LocalisationSystem.Get("sForSeconds"));
		}
		return "00" + LocalisationSystem.Get("dForDays") + " : 00" + LocalisationSystem.Get("hForHours") + " : 00" + LocalisationSystem.Get("mForMins") + " : 00" + LocalisationSystem.Get("sForSeconds");
	}

	public static bool EPDMFPBLIHH()
	{
		return false;
	}

	public static int CCLEBHFHFCF(int JIIGOACEIKL, Recipe JNLKEMLDFIM, RecipeIngredient CFHCLOGEBAJ, bool AKNBKINJGCF, Placeable FLAAGFECLME)
	{
		if (CFHCLOGEBAJ.item.NGDPNIFFHKL())
		{
			return PMBOKBBDGPB(JIIGOACEIKL, JNLKEMLDFIM, CFHCLOGEBAJ, AKNBKINJGCF, FLAAGFECLME);
		}
		return JFCKPHAAAEA(JIIGOACEIKL, JNLKEMLDFIM, CFHCLOGEBAJ, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA: true);
	}

	public static MonoBehaviour[] HGPBIFIDFFD<T>(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (!OJNCNEJJHDD(JIIGOACEIKL))
		{
			return null;
		}
		FMCIAKBJFOC = JPKIAJHKOBK(JIIGOACEIKL, Vector2.op_Implicit(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition()));
		if (FMCIAKBJFOC == null || FMCIAKBJFOC.Length == 0)
		{
			return null;
		}
		CENALNOKJCE.Clear();
		if (CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
		{
			for (int i = 0; i < FMCIAKBJFOC.Length; i++)
			{
				DLJHBFBDAEC = FMCIAKBJFOC[i].gameObject.GetComponents<T>().Select(delegate(T x)
				{
					object obj = x;
					return (MonoBehaviour)((obj is MonoBehaviour) ? obj : null);
				}).ToArray();
				for (int j = 0; j < DLJHBFBDAEC.Length; j++)
				{
					if (!((Object)(object)DLJHBFBDAEC[j] == (Object)null))
					{
						NPJDIDHOEFB = DLJHBFBDAEC[j];
						if ((Object)(object)NPJDIDHOEFB != (Object)null && ((Behaviour)NPJDIDHOEFB).enabled)
						{
							CENALNOKJCE.Add(NPJDIDHOEFB);
						}
					}
				}
			}
		}
		return CENALNOKJCE.ToArray();
	}

	public static string NFEOACEFIHI(int JIIGOACEIKL, Item MEMGMDOCBOJ, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false)
	{
		NKMJAGDJPJE = 0;
		if ((Object)(object)MEMGMDOCBOJ.PHGCBMPGGLI() != (Object)null)
		{
			List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
			for (int i = 0; i < currentPlaceables.Count; i++)
			{
				if (Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup.item) && currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JDJGFAACPFC(DAINLFIMLIH: false))
				{
					NKMJAGDJPJE++;
				}
			}
		}
		NKMJAGDJPJE += CraftingInventory.NumberOfItems(JIIGOACEIKL, MEMGMDOCBOJ, AKNBKINJGCF, FLAAGFECLME, AHCENOLCIBM);
		return " (" + NKMJAGDJPJE + ")";
	}

	public static TavernFloor FCFHPAPKOEL(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (HOHLHGJHOKM(IMOBLFMHKOD))
		{
			return TavernFloor.FirstFloor;
		}
		if (FIBFKGIJMBJ(IMOBLFMHKOD))
		{
			return TavernFloor.SecondFloor;
		}
		if (BLIAFMGPONN(IMOBLFMHKOD))
		{
			return TavernFloor.Cellar;
		}
		return TavernFloor.None;
	}

	public static Vector2 POLDMHFDINK(Vector2 IMOBLFMHKOD, int JNLPKLIJPJB)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		int num = 100;
		int num2 = 0;
		while (!flag && num2 < num)
		{
			Vector3 val = Vector2.op_Implicit(IMOBLFMHKOD);
			Vector3 val2 = val + new Vector3((float)Random.Range(-JNLPKLIJPJB, JNLPKLIJPJB), (float)Random.Range(-JNLPKLIJPJB, JNLPKLIJPJB), 0f);
			val2.x = Mathf.Clamp(val2.x, val.x - 4f, val.x + 4f);
			val2.y = Mathf.Clamp(val2.y, val.y - 4f, val.y + 4f);
			flag = WorldGrid.APKPGNDDJHC(val2);
			if (flag)
			{
				return Vector2.op_Implicit(val2);
			}
			num2++;
		}
		Debug.LogWarning((object)$"No valid position found around the position {IMOBLFMHKOD} after {num} attempts. Returning player's position.");
		return Vector2.op_Implicit(Vector3.zero);
	}

	public static void MOIIHDKPMBB(Location BAIMHDBJPDK, int KNIBEKEBAHD)
	{
	}

	public static bool OKNJHFGGDCO(int HLJEAEIEJMP)
	{
		if (dictReplaceItems.ContainsKey(HLJEAEIEJMP))
		{
			return true;
		}
		return false;
	}

	public static int PMBOKBBDGPB(int JIIGOACEIKL, Recipe JNLKEMLDFIM, RecipeIngredient CFHCLOGEBAJ, bool AKNBKINJGCF, Placeable FLAAGFECLME)
	{
		GDHKLPOOHEO = HIJGDAHBBIA(JIIGOACEIKL, JNLKEMLDFIM, CFHCLOGEBAJ, AKNBKINJGCF, FLAAGFECLME);
		return Mathf.Max(GDHKLPOOHEO.Select((Slot s) => s.Stack).ToArray());
	}

	public static int FDNIGJBNNMF(TavernFloor BDCFJAHNOML)
	{
		if (BDCFJAHNOML == TavernFloor.Cellar)
		{
			return 8;
		}
		return 10;
	}

	public static List<RaycastResult> CHLHHOFKHAJ(Vector2 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		KBBOADOLFCI = new PointerEventData((EventSystem)null);
		KBBOADOLFCI.position = IMOBLFMHKOD;
		FJJOFBIHCJJ = new List<RaycastResult>();
		((BaseRaycaster)GameplayUI.GGFJGHHHEJC.graphicRaycaster).Raycast(KBBOADOLFCI, FJJOFBIHCJJ);
		((BaseRaycaster)MenuUI.GGFJGHHHEJC.graphicRaycaster).Raycast(KBBOADOLFCI, FJJOFBIHCJJ);
		for (int num = FJJOFBIHCJJ.Count - 1; num >= 0; num--)
		{
			RaycastResult val = FJJOFBIHCJJ[num];
			if (((RaycastResult)(ref val)).gameObject.layer == LayerMask.NameToLayer("Ignore Raycast"))
			{
				FJJOFBIHCJJ.RemoveAt(num);
			}
		}
		return FJJOFBIHCJJ;
	}

	public static bool AEJGKHNAABC(int JIIGOACEIKL, ref float CMGDCLIIONE, string JKJJKBAFNMO, AxisContribution HFONDHFEJMB, float EGDGLPOBPAF = 0.3f, float NKJDKMNNPFK = 0.1f)
	{
		if ((HFONDHFEJMB == AxisContribution.Positive && PlayerInputs.GetPlayer(JIIGOACEIKL).GetAxis(JKJJKBAFNMO) > EGDGLPOBPAF) || (HFONDHFEJMB == AxisContribution.Negative && PlayerInputs.GetPlayer(JIIGOACEIKL).GetAxis(JKJJKBAFNMO) < 0f - EGDGLPOBPAF))
		{
			if (CMGDCLIIONE == -1f)
			{
				CMGDCLIIONE = 0f;
				return true;
			}
			CMGDCLIIONE += Time.unscaledDeltaTime;
			if (CMGDCLIIONE > 0.3f)
			{
				CMGDCLIIONE -= NKJDKMNNPFK;
				return true;
			}
		}
		else
		{
			CMGDCLIIONE = -1f;
		}
		return false;
	}

	public static Vector2Int NLFDOFAOJHP(Direction FCGBJEIIMBC)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		return (Vector2Int)(FCGBJEIIMBC switch
		{
			Direction.Up => Vector2Int.up, 
			Direction.Left => Vector2Int.left, 
			Direction.Right => Vector2Int.right, 
			_ => Vector2Int.down, 
		});
	}

	public static GameObject JCNFPEHGGKP(GameObject ANADFOCHOBF, Vector3 IMOBLFMHKOD, Quaternion FGOIDMABFPA)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && OnlineManager.OnlinePrefabExists(ANADFOCHOBF))
		{
			if (OnlineManager.IsMasterClient())
			{
				return OnlineManager.Instantiate(ANADFOCHOBF, IMOBLFMHKOD, FGOIDMABFPA);
			}
			return null;
		}
		return Object.Instantiate<GameObject>(ANADFOCHOBF, IMOBLFMHKOD, FGOIDMABFPA);
	}

	public static bool GPJOIALPOLC()
	{
		if (DateTime.Now.Day < 21 || DateTime.Now.Month != 10 || DateTime.Now.Year != 2024)
		{
			if (DateTime.Now.Day <= 7 && DateTime.Now.Month == 11)
			{
				return DateTime.Now.Year == 2024;
			}
			return false;
		}
		return true;
	}

	public static Vector3 PPLGEIENOKA()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		List<KeyValuePair<Vector3, WorldTile>> list = GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.Where((KeyValuePair<Vector3, WorldTile> wt) => wt.Value.zoneType == ZoneType.DiningRoom && !wt.Value.wall && WorldGrid.APKPGNDDJHC(wt.Key + Vector3.one * 0.25f) && WorldGrid.EJCEAEPNJCA(wt.Key + new Vector3(0f, -0.5f)) && (Object)(object)TravelZonesManager.GGFJGHHHEJC.GetTravelZoneAtPosition(wt.Key) == (Object)null).ToList();
		if (list.Count > 0)
		{
			return list.ElementAt(Random.Range(0, list.Count)).Key + Vector3.one * 0.25f;
		}
		return ((Component)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Tavern, Location.Road)).transform.position;
	}

	public static int FAIGKGNBDGB(int JIIGOACEIKL, Slot ADEBNALPEHE, int FGFCNKFEIGF, out int FNNBABJKAIH, int PAFEECBJICN = 0, bool CDPAMNIPPEC = true)
	{
		if (ADEBNALPEHE != null && ADEBNALPEHE.itemInstance != null)
		{
			int num = ((!PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)304) || FGFCNKFEIGF <= 1) ? FGFCNKFEIGF : (ADEBNALPEHE.Stack / 2));
			FNNBABJKAIH = PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(ADEBNALPEHE.itemInstance, num, HMPDLIPFBGD: false, EHGHJNOFMKF: false, !(ADEBNALPEHE.itemInstance.LHBPOPOIFLE() is Tool));
			ADEBNALPEHE.FDOBDPPMMBH(num - FNNBABJKAIH, CDPAMNIPPEC, PAFEECBJICN);
			Sound.GGFJGHHHEJC.PlayOneShot(CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickNeg), HOMFPAFAOGD: true, null, null, 0.5f);
			return num - FNNBABJKAIH;
		}
		FNNBABJKAIH = FGFCNKFEIGF;
		return 0;
	}

	public static string MLNDLODLJJL(string KONLFBMLJGL, bool JHGAIEFCAKN = true)
	{
		return (JHGAIEFCAKN ? "<color=#A45D20>" : "") + KONLFBMLJGL + (JHGAIEFCAKN ? "</color>" : "");
	}

	public static FertileSoil LMLJCGOJFAH(Vector3 IMOBLFMHKOD, int FKECGGIOLBB, bool ABPPNNEPEAC = false)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (!fertilSoilPositions.Contains(IMOBLFMHKOD))
		{
			GameObject val = WorldGrid.MMOHADHAAGD(IMOBLFMHKOD, GroundType.TilledEarth, Location.Road);
			if (ABPPNNEPEAC)
			{
				val.transform.position = KAECEBHAPFG(val);
			}
			WorldGrid.AAFPODGPJMP(IMOBLFMHKOD, DNMKMKDAENO: false);
			fertilSoilPositions.Add(IMOBLFMHKOD);
			FertileSoil component = val.GetComponent<FertileSoil>();
			component.daysUntilDry = FKECGGIOLBB;
			return component;
		}
		return null;
	}

	public static Transform IMOJLANDCJB(TavernFloor BDCFJAHNOML)
	{
		TravelZone travelZone = null;
		travelZone = BDCFJAHNOML switch
		{
			TavernFloor.FirstFloor => TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Tavern, Location.Road), 
			TavernFloor.SecondFloor => TravelZonesManager.GGFJGHHHEJC.GetTravelZoneTavern(TavernFloor.SecondFloor, TavernFloor.FirstFloor), 
			TavernFloor.Cellar => TravelZonesManager.GGFJGHHHEJC.GetTravelZoneTavern(TavernFloor.Cellar, TavernFloor.FirstFloor), 
			_ => null, 
		};
		if ((Object)(object)travelZone == (Object)null)
		{
			Debug.LogError((object)("GetFloorEntrance travelZone null " + BDCFJAHNOML));
			return null;
		}
		return ((Component)travelZone).transform;
	}

	public static ulong POMNIOBBKOL(ref ulong NCPGNLOJGAF, ulong JPFOPOEHFKH)
	{
		ulong num = NCPGNLOJGAF % JPFOPOEHFKH;
		NCPGNLOJGAF -= num;
		return num;
	}

	public static bool KELHFMBOEKM(GameObject PIFPBJLHFJP, GameObject MEGPBGODLIL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PIFPBJLHFJP == (Object)null)
		{
			return false;
		}
		FJJOFBIHCJJ = CHLHHOFKHAJ(Vector2.op_Implicit(PIFPBJLHFJP.transform.position));
		for (int i = 0; i < FJJOFBIHCJJ.Count; i++)
		{
			RaycastResult val = FJJOFBIHCJJ[i];
			if (((object)((RaycastResult)(ref val)).gameObject).Equals((object?)MEGPBGODLIL))
			{
				return true;
			}
		}
		return false;
	}

	public static SurfaceSortOrder EBJCKGBAGLE(Item MEMGMDOCBOJ, Placeable HLLEDNDHOCM, List<Item> HKGLACOJIGJ)
	{
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!((Object)(object)currentPlaceables[i] == (Object)null) && currentPlaceables[i].CCIKENEGHCA && HKGLACOJIGJ.Contains(currentPlaceables[i].itemSetup.item) && currentPlaceables[i].currentLocation == Location.Tavern && (Object)(object)currentPlaceables[i].placeableSurface != (Object)null && currentPlaceables[i].placeableSurface.IsItemAllowed(MEMGMDOCBOJ, HLLEDNDHOCM, null))
			{
				list.Add(currentPlaceables[i]);
			}
		}
		if (list.Count > 0)
		{
			return list[Random.Range(0, list.Count)].placeableSurface;
		}
		return null;
	}

	public static Slot CHMEHDFPGCI(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, Slot[] PCJEDMJEKEF, int BCGMJPMMGFD, List<Tag> HPDCGCHCABK = null, Type[] DKJLOKHJLJC = null, Item[] EHHCDAGDKMC = null, List<IngredientType> MLOHKFFEEGP = null, FoodType KIJHENLPKAA = FoodType.None, List<Item> FMKPPODOELE = null, bool OECLHGILEOL = false, bool CDPAMNIPPEC = true)
	{
		if (!DOOILKJLDHD(BGLFLHDNOKJ, HPDCGCHCABK, DKJLOKHJLJC, EHHCDAGDKMC, null, MLOHKFFEEGP, KIJHENLPKAA, FMKPPODOELE, OECLHGILEOL))
		{
			return null;
		}
		Slot slot = null;
		Slot slot2 = null;
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			if (PCJEDMJEKEF[i] == null)
			{
				continue;
			}
			if (PCJEDMJEKEF[i].KPINNBKMOMO())
			{
				if (slot == null)
				{
					slot = PCJEDMJEKEF[i];
				}
			}
			else if (PCJEDMJEKEF[i].Stack < BCGMJPMMGFD && PCJEDMJEKEF[i].FEEOFAGCONJ(JIIGOACEIKL, BGLFLHDNOKJ))
			{
				slot2 = PCJEDMJEKEF[i];
				break;
			}
		}
		if (slot2 == null && slot != null && slot.FEEOFAGCONJ(JIIGOACEIKL, BGLFLHDNOKJ))
		{
			slot2 = slot;
		}
		if (CDPAMNIPPEC && slot2 != null && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendSlot(slot2);
		}
		return slot2;
	}

	public static IEnumerator AAGGGBAPFGJ(CharacterAnimator LMENBHLBGLH)
	{
		for (int i = 0; i < LMENBHLBGLH.allReskins.Length; i++)
		{
			LMENBHLBGLH.allReskins[i].spriteRenderer.color = Color.red;
		}
		yield return CommonReferences.wait01;
		for (int j = 0; j < LMENBHLBGLH.allReskins.Length; j++)
		{
			LMENBHLBGLH.allReskins[j].spriteRenderer.color = Color.white;
		}
		yield return CommonReferences.wait01;
		for (int k = 0; k < LMENBHLBGLH.allReskins.Length; k++)
		{
			LMENBHLBGLH.allReskins[k].spriteRenderer.color = Color.red;
		}
		yield return CommonReferences.wait01;
		for (int l = 0; l < LMENBHLBGLH.allReskins.Length; l++)
		{
			LMENBHLBGLH.allReskins[l].spriteRenderer.color = Color.white;
		}
	}

	public static Vector3 BMBMPKNANAC(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3(HEEBPOGPGMO(IMOBLFMHKOD.x), HEEBPOGPGMO(IMOBLFMHKOD.y), IMOBLFMHKOD.z);
	}

	public static List<Slot> HIJGDAHBBIA(int JIIGOACEIKL, Recipe JNLKEMLDFIM, RecipeIngredient CFHCLOGEBAJ, bool AKNBKINJGCF, Placeable FLAAGFECLME)
	{
		return HIJGDAHBBIA(JIIGOACEIKL, CFHCLOGEBAJ.item, CFHCLOGEBAJ.mod, CFHCLOGEBAJ.amount, JNLKEMLDFIM, AKNBKINJGCF, FLAAGFECLME, MMDICAMGNCL: false);
	}

	public static int FJNKHMPEEKL()
	{
		return 500;
	}

	public static bool LKIPKMJJEEJ(float DPEOLFMDLAK, float ODNGJHPOMMK, float ELAAGFDMPME = 0.001f)
	{
		return Math.Abs(DPEOLFMDLAK - ODNGJHPOMMK) < ELAAGFDMPME;
	}

	private static bool CAAOCBKFLHH(Tag[] FDAGJPHBDOG, List<Tag> HPDCGCHCABK)
	{
		if (FDAGJPHBDOG == null)
		{
			return false;
		}
		for (int i = 0; i < FDAGJPHBDOG.Length; i++)
		{
			if (HPDCGCHCABK.Contains(FDAGJPHBDOG[i]))
			{
				return true;
			}
		}
		return false;
	}

	public static bool AKIPCELELAJ(GameObject MEGPBGODLIL)
	{
		if (GameManager.LocalCoop())
		{
			ICMMMGBOALP = ((MEGPBGODLIL.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
			if ((Object)(object)UISelectionManager.GetPlayer(ICMMMGBOALP).HGNKFFMDOOL != (Object)null && ((object)MEGPBGODLIL).Equals((object?)((Component)UISelectionManager.GetPlayer(ICMMMGBOALP).HGNKFFMDOOL).gameObject))
			{
				return false;
			}
		}
		return true;
	}

	public static float LCGAHGBBDBD(float KDPHEAAOBGD, int JIIGOACEIKL)
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null)
		{
			return Mathf.Round(KDPHEAAOBGD);
		}
		if ((Object)(object)CommonReferences.GGFJGHHHEJC.GetPixelPerfectCamera(JIIGOACEIKL) == (Object)null)
		{
			return Mathf.Round(KDPHEAAOBGD);
		}
		return Mathf.Round(KDPHEAAOBGD * 48f * CommonReferences.GGFJGHHHEJC.GetPixelPerfectCamera(JIIGOACEIKL).ratio) / (48f * CommonReferences.GGFJGHHHEJC.GetPixelPerfectCamera(JIIGOACEIKL).ratio);
	}

	public static int NMLNAGFLNMC(int NCPGNLOJGAF, int JPFOPOEHFKH)
	{
		int num = NCPGNLOJGAF % JPFOPOEHFKH;
		if (num >= 0)
		{
			return num;
		}
		return num + JPFOPOEHFKH;
	}

	public static T[] AGMADMGPHMP<T>(Vector2 MJGMEBDNKKI, float INCOGJKKMIH, int FCPJIPBPGFK = -5) where T : MonoBehaviour
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		int num = Physics2D.OverlapCircleNonAlloc(MJGMEBDNKKI, INCOGJKKMIH, NIAKAMHIMEJ);
		List<T> list = new List<T>();
		for (int i = 0; i < num; i++)
		{
			if (!NIAKAMHIMEJ[i].isTrigger)
			{
				T componentInParent = ((Component)NIAKAMHIMEJ[i]).GetComponentInParent<T>();
				if ((Object)(object)componentInParent != (Object)null)
				{
					list.Add(componentInParent);
				}
			}
		}
		return list.ToArray();
	}

	public static string HJAPIJDKAME()
	{
		if (GBPMJDEKDEB())
		{
			TimeSpan timeSpan = BOFCEGOCOBG - DateTime.UtcNow;
			return string.Format(LocalisationSystem.Get("TimeLeft"), timeSpan.Days + LocalisationSystem.Get("dForDays") + " : " + timeSpan.Hours + LocalisationSystem.Get("hForHours") + " : " + timeSpan.Minutes + LocalisationSystem.Get("mForMins") + " : " + timeSpan.Seconds + LocalisationSystem.Get("sForSeconds"));
		}
		return "00" + LocalisationSystem.Get("dForDays") + " : 00" + LocalisationSystem.Get("hForHours") + " : 00" + LocalisationSystem.Get("mForMins") + " : 00" + LocalisationSystem.Get("sForSeconds");
	}

	public static string OHNBGHCNBLI()
	{
		if (BDHBLGMBBCO())
		{
			TimeSpan timeSpan = JBPAALHHCMG - DateTime.UtcNow;
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("TimeLeft"), timeSpan.Days + LocalisationSystem.Get("dForDays") + " : " + timeSpan.Hours + LocalisationSystem.Get("hForHours") + " : " + timeSpan.Minutes + LocalisationSystem.Get("mForMins") + " : " + timeSpan.Seconds + LocalisationSystem.Get("sForSeconds"));
		}
		return "00" + LocalisationSystem.Get("dForDays") + " : 00" + LocalisationSystem.Get("hForHours") + " : 00" + LocalisationSystem.Get("mForMins") + " : 00" + LocalisationSystem.Get("sForSeconds");
	}

	private static bool OJNCNEJJHDD(int JIIGOACEIKL)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		DAADKDLNAGE = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorScreenPosition();
		if (DAADKDLNAGE.x < 0f || DAADKDLNAGE.x > (float)Screen.width)
		{
			return false;
		}
		if (GameManager.LocalCoop() && !TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			if (JIIGOACEIKL == 1)
			{
				if (DAADKDLNAGE.x > 0f && DAADKDLNAGE.x > (float)(Screen.width / 2))
				{
					return false;
				}
			}
			else if (DAADKDLNAGE.x < (float)(Screen.width / 2))
			{
				return false;
			}
		}
		return true;
	}

	public static void ELNJMNKOACA(GameObject MOBFJEDPIPM, int DNIKNLKLNMK)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		if ((Object)null == (Object)(object)MOBFJEDPIPM || ((Object)MOBFJEDPIPM).name.Contains("TavernVision") || MOBFJEDPIPM.layer == 12)
		{
			return;
		}
		MOBFJEDPIPM.layer = DNIKNLKLNMK;
		foreach (Transform item in MOBFJEDPIPM.transform)
		{
			Transform val = item;
			if (!((Object)(object)val == (Object)null))
			{
				ELNJMNKOACA(((Component)val).gameObject, DNIKNLKLNMK);
			}
		}
	}

	public static Int16Vector2 LKAIECNLMDI(Vector2 FIAFDEMFKGM)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Int16Vector2 result = default(Int16Vector2);
		result.x = (short)Mathf.FloorToInt(FIAFDEMFKGM.x * 2f);
		result.y = (short)Mathf.FloorToInt(FIAFDEMFKGM.y * 2f);
		return result;
	}

	public static Location HJPCBBGHPDA(Vector2 IMOBLFMHKOD)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null)
		{
			return Location.None;
		}
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.HJPCBBGHPDA(IMOBLFMHKOD);
	}

	public static bool NGLLIJPOBEC(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return NGLLIJPOBEC(HJPCBBGHPDA(Vector2.op_Implicit(IMOBLFMHKOD)));
	}

	public static PlatformOS ILLKGGBHMLF()
	{
		try
		{
			if (SteamManager.IsSteamdeck())
			{
				return PlatformOS.Steamdeck;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (SteamManager.BNBMMDGMKLM)
			{
				return PlatformOS.WindowsSteam;
			}
		}
		catch (Exception)
		{
		}
		return PlatformOS.Windows;
	}

	public static bool GBPMJDEKDEB()
	{
		return DateTime.Compare(DateTime.UtcNow, BOFCEGOCOBG) < 0;
	}

	public static HashSet<Vector3> NLIMICIGCKC(TavernFloor BDCFJAHNOML)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		EEBKFOLEHAB = IMOJLANDCJB(BDCFJAHNOML);
		OOPLKGHOBHC.Clear();
		if (Object.op_Implicit((Object)(object)EEBKFOLEHAB))
		{
			CAEMMONHLNL(NKGANMEKDAL(EEBKFOLEHAB.position), OOPLKGHOBHC);
		}
		return OOPLKGHOBHC;
	}

	public static int JFCKPHAAAEA(int JIIGOACEIKL, Recipe KMNOGHMAAEK, RecipeIngredient CFHCLOGEBAJ, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool DDAPJEAJGGA)
	{
		if (CFHCLOGEBAJ.item is IngredientGroup ingredientGroup)
		{
			return CraftingInventory.NumberOfItems(JIIGOACEIKL, ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK), AKNBKINJGCF, FLAAGFECLME, AHCENOLCIBM: false, DDAPJEAJGGA);
		}
		return CraftingInventory.NumberOfItems(JIIGOACEIKL, CFHCLOGEBAJ.item, CFHCLOGEBAJ.mod, AKNBKINJGCF, FLAAGFECLME, AHCENOLCIBM: false, DDAPJEAJGGA);
	}

	public static T EIDILBHBHBK<T>(Vector2 MJGMEBDNKKI, float INCOGJKKMIH, int FCPJIPBPGFK = -5) where T : MonoBehaviour
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		int num = Physics2D.OverlapCircleNonAlloc(MJGMEBDNKKI, INCOGJKKMIH, NIAKAMHIMEJ);
		for (int i = 0; i < num; i++)
		{
			if (!NIAKAMHIMEJ[i].isTrigger)
			{
				T componentInParent = ((Component)NIAKAMHIMEJ[i]).GetComponentInParent<T>();
				if ((Object)(object)componentInParent != (Object)null)
				{
					return componentInParent;
				}
			}
		}
		return default(T);
	}

	public static void BDIKHDHOIPI(Slot[] PCJEDMJEKEF)
	{
		List<ItemInstanceAmount> jAGEECPLMIL = (from slot in PCJEDMJEKEF
			where !slot.KPINNBKMOMO()
			select new ItemInstanceAmount(slot.itemInstance, slot.Stack)).ToList();
		GFBAMCIMECB(1, PCJEDMJEKEF, jAGEECPLMIL);
	}

	public static Season GABFHMGHOPL(Season EECEKHKAAIH)
	{
		return (Season)NMLNAGFLNMC((int)(EECEKHKAAIH + 1), 4);
	}

	public static void ABPJKHCNLMF(Vector3 IMOBLFMHKOD, bool NHIKGIKOMHH = false)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < WorldGrid.allMovementNodesInTile.Length; i++)
		{
			ECJLMIPAFGP = NKGANMEKDAL(IMOBLFMHKOD) + WorldGrid.allMovementNodesInTile[i];
			JAALINCKLPO(ECJLMIPAFGP, NHIKGIKOMHH);
		}
	}

	public static bool MFMJBKJCMNI()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return false;
		}
		if (EJPFCKFEMJF(((Component)PlayerController.GetPlayer(1)).transform.position))
		{
			return true;
		}
		if (GameManager.LocalCoop() && EJPFCKFEMJF(((Component)PlayerController.GetPlayer(2)).transform.position))
		{
			return true;
		}
		return false;
	}

	public static Vector2 MJEACANINDN(Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = Mathf.Round(IMOBLFMHKOD.x * 4f) / 4f;
		float num2 = Mathf.Round(IMOBLFMHKOD.y * 4f) / 4f;
		return new Vector2(num, num2);
	}

	public static Vector2 MMFCGMDOLDM(Collider2D DJDHCIHLNDO)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Bounds bounds;
		if (((Behaviour)DJDHCIHLNDO).enabled)
		{
			bounds = DJDHCIHLNDO.bounds;
			return Vector2.op_Implicit(((Bounds)(ref bounds)).min);
		}
		((Behaviour)DJDHCIHLNDO).enabled = true;
		bounds = DJDHCIHLNDO.bounds;
		Vector2 result = Vector2.op_Implicit(((Bounds)(ref bounds)).min);
		((Behaviour)DJDHCIHLNDO).enabled = false;
		return result;
	}

	public static T CKNBOKKFPLJ<T>(int JIIGOACEIKL) where T : MonoBehaviour
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (!OJNCNEJJHDD(JIIGOACEIKL))
		{
			return default(T);
		}
		FMCIAKBJFOC = JPKIAJHKOBK(JIIGOACEIKL, Vector2.op_Implicit(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition()))?.ToArray();
		if (FMCIAKBJFOC == null || FMCIAKBJFOC.Length == 0)
		{
			return default(T);
		}
		for (int i = 0; i < FMCIAKBJFOC.Length; i++)
		{
			NPJDIDHOEFB = (MonoBehaviour)(object)FMCIAKBJFOC[i].gameObject.GetComponent<T>();
			if ((Object)(object)NPJDIDHOEFB != (Object)null && ((Behaviour)NPJDIDHOEFB).enabled)
			{
				return FMCIAKBJFOC[i].gameObject.GetComponent<T>();
			}
		}
		return default(T);
	}

	public static void CLGHKOEGACP(Vector2 IMOBLFMHKOD, Vector2 AAFJOAPNNBA, FindPositionsInfo BBJDPIJPLPA, ref List<Vector2> PGBEEGPOINO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Vector3.zero);
		PGBEEGPOINO.Clear();
		IMOBLFMHKOD = NKGANMEKDAL(IMOBLFMHKOD);
		for (float num = IMOBLFMHKOD.x - AAFJOAPNNBA.x; num < IMOBLFMHKOD.x + AAFJOAPNNBA.x; num += 1.5f)
		{
			for (float num2 = IMOBLFMHKOD.y - AAFJOAPNNBA.y; num2 < IMOBLFMHKOD.y + AAFJOAPNNBA.y; num2 += 1.5f)
			{
				val.x = num;
				val.y = num2;
				if (!GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.TryGetValue(Vector2.op_Implicit(val), out var value) || value.groundType == GroundType.None || !BBJDPIJPLPA.location.DHMNBPCEMHB(value.location) || BBJDPIJPLPA.avoidGroundType.GFELJCLKKMC(value.groundType) || !BBJDPIJPLPA.zoneType.CJBADHDNEOC(value.zoneType) || (BBJDPIJPLPA.checkCanPlaceObject && !WorldGrid.NGDHDMAMGPI(value)))
				{
					continue;
				}
				if (BBJDPIJPLPA.checkDistance)
				{
					Vector2 val2 = val - IMOBLFMHKOD;
					if (!(((Vector2)(ref val2)).sqrMagnitude > (float)(BBJDPIJPLPA.minDistance * BBJDPIJPLPA.minDistance)))
					{
						continue;
					}
				}
				if ((BBJDPIJPLPA.checkFarmable && !value.farmable) || (BBJDPIJPLPA.avoidPath && value.isPath) || (BBJDPIJPLPA.checkNodeFree && !WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(val))) || (!((Object)(object)Barn.instance == (Object)null) && !(Vector2.Distance(val, Vector2.op_Implicit(((Component)Barn.instance).transform.position)) > 3f)))
				{
					continue;
				}
				if (BBJDPIJPLPA.location == Location.BarnInterior)
				{
					if (value.PBLLKEKGLPK is BarnTilemapScene barnTilemapScene && barnTilemapScene.barnLevel == BBJDPIJPLPA.level)
					{
						PGBEEGPOINO.Add(val);
					}
				}
				else
				{
					PGBEEGPOINO.Add(val);
				}
			}
		}
	}

	public static void OEAOOGCGNCA(Transform DMBHHLKMHOH, Collider2D DJDHCIHLNDO, List<Vector2> ONAHMNAIPDI, bool PDLKFBANOLH = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		Bounds bounds = DJDHCIHLNDO.bounds;
		MDMAAIKFBFB = MJEACANINDN(((Bounds)(ref bounds)).min);
		bounds = DJDHCIHLNDO.bounds;
		DBACIMHFEKD = MJEACANINDN(((Bounds)(ref bounds)).max);
		for (ACGOMBEKONN = MDMAAIKFBFB.x; ACGOMBEKONN <= DBACIMHFEKD.x; ACGOMBEKONN += 0.25f)
		{
			for (KDPMIAECCJM = MDMAAIKFBFB.y; KDPMIAECCJM <= DBACIMHFEKD.y; KDPMIAECCJM += 0.25f)
			{
				ECJLMIPAFGP = Vector2.op_Implicit(new Vector2(ACGOMBEKONN, KDPMIAECCJM));
				List<Collider2D> list = LPONJPMNLLJ(Vector2.op_Implicit(ECJLMIPAFGP), new Vector2(0.3f, 0.2f), (CapsuleDirection2D)1, 0f, 3145728);
				for (int i = 0; i < list.Count; i++)
				{
					if (((Object)((Component)list[i]).gameObject).name.Equals(((Object)((Component)DJDHCIHLNDO).gameObject).name))
					{
						if (!ONAHMNAIPDI.Contains(DADALKFFODC(DMBHHLKMHOH, PDLKFBANOLH)))
						{
							ONAHMNAIPDI.Add(DADALKFFODC(DMBHHLKMHOH, PDLKFBANOLH));
						}
						break;
					}
				}
			}
		}
	}

	public static bool NGLLIJPOBEC(Location NFHFNKHHGGI)
	{
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && PlayerController.GetPlayer(i).LEOIMFNKFGA == NFHFNKHHGGI)
			{
				return true;
			}
		}
		return false;
	}

	public static bool JGLEEOBPPJC()
	{
		if (OnlineManager.PlayingOnline())
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null && PlayerController.GetPlayer(1).IsTavernLocationNotCellar())
			{
				return true;
			}
		}
		else if (((Object)(object)PlayerController.GetPlayer(1) != (Object)null && PlayerController.GetPlayer(1).IsTavernLocationNotCellar()) || ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && PlayerController.GetPlayer(2).IsTavernLocationNotCellar()))
		{
			return true;
		}
		return false;
	}

	public static bool EHNKNLNPFNB()
	{
		if (!File.Exists(Application.persistentDataPath + "/ExtraSettings.sd"))
		{
			return false;
		}
		MIPJKFFDBAE = File.OpenRead(Application.persistentDataPath + "/ExtraSettings.sd");
		GKNCHDBNPHE = new BinaryFormatter();
		SettingsData settingsData;
		try
		{
			settingsData = (SettingsData)GKNCHDBNPHE.Deserialize(MIPJKFFDBAE);
		}
		catch
		{
			MIPJKFFDBAE.Close();
			Debug.Log((object)"Deserialize SettingsData error: /ExtraSettings.sd");
			return false;
		}
		MIPJKFFDBAE.Close();
		return settingsData.multiplayerAgreement;
	}

	public static bool NGEJFMOOHNF<T>(T AKPKDELPEHN, T PODGPCFNCFH) where T : Enum
	{
		return (Convert.ToInt32(AKPKDELPEHN) & Convert.ToInt32(PODGPCFNCFH)) != 0;
	}

	public static Vector2 ONOELMILFCA(Collider2D DJDHCIHLNDO)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Bounds bounds;
		if (((Behaviour)DJDHCIHLNDO).enabled)
		{
			bounds = DJDHCIHLNDO.bounds;
			return Vector2.op_Implicit(((Bounds)(ref bounds)).center);
		}
		((Behaviour)DJDHCIHLNDO).enabled = true;
		bounds = DJDHCIHLNDO.bounds;
		Vector2 result = Vector2.op_Implicit(((Bounds)(ref bounds)).center);
		((Behaviour)DJDHCIHLNDO).enabled = false;
		return result;
	}

	public static bool NKAMHHCOEFO()
	{
		PlatformOS platformOS = ILLKGGBHMLF();
		if (platformOS == PlatformOS.Steamdeck || (uint)(platformOS - 11) <= 5u)
		{
			return true;
		}
		return false;
	}

	public static void FKKHJPEMNBG(string NKBAEMLKJEO, int FFDIEOBBFKL)
	{
		if (FFDIEOBBFKL <= 0)
		{
			return;
		}
		if (SteamManager.BNBMMDGMKLM)
		{
			if (SteamUserStats.GetStat(NKBAEMLKJEO, ref DJHBGBFCOCH))
			{
				DJHBGBFCOCH += FFDIEOBBFKL;
				SteamUserStats.SetStat(NKBAEMLKJEO, DJHBGBFCOCH);
				SteamUserStats.StoreStats();
			}
		}
		else if (GalaxyInstance.User() != null && GalaxyInstance.User().SignedIn())
		{
			DJHBGBFCOCH = GalaxyManager.Instance.StatsAndAchievements.GetStatInt(NKBAEMLKJEO);
			DJHBGBFCOCH += FFDIEOBBFKL;
			GalaxyManager.Instance.StatsAndAchievements.SetStatInt(NKBAEMLKJEO, DJHBGBFCOCH);
			MHOHJOHBAED(NKBAEMLKJEO, DJHBGBFCOCH);
		}
	}

	public static Vector3 MNOPMFHOKNI()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (CommonReferences.GGFJGHHHEJC.allTavernPositions.Count > 0)
		{
			return CommonReferences.GGFJGHHHEJC.allTavernPositions[Random.Range(0, CommonReferences.GGFJGHHHEJC.allTavernPositions.Count)] + Vector3.one * 0.25f;
		}
		Debug.LogWarning((object)"allTavernPositions is empty");
		return TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Tavern, Location.Road).GetCentrePosition();
	}

	public static int EPFNDNGBCJL(ref int NCPGNLOJGAF, int JPFOPOEHFKH)
	{
		int num = NCPGNLOJGAF % JPFOPOEHFKH;
		NCPGNLOJGAF -= num;
		return num;
	}

	public static IEnumerator KAHHFCFDJIK(int JIIGOACEIKL, float EPLACMFEGGH, Sprite[] DAIPKNMKFFN, SpriteRenderer PJMCHPFEOOA, MonoBehaviour NPJDIDHOEFB)
	{
		if ((Object)(object)NPJDIDHOEFB != (Object)null && !PlayerController.GetMovementBlockers(JIIGOACEIKL).Contains((Object)(object)NPJDIDHOEFB))
		{
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)NPJDIDHOEFB);
		}
		for (int i = 1; i < DAIPKNMKFFN.Length; i++)
		{
			yield return (object)new WaitForSeconds(EPLACMFEGGH);
			PJMCHPFEOOA.sprite = DAIPKNMKFFN[i];
		}
	}

	public static bool IIHPGJIJOAD(int JIIGOACEIKL, ref float CMGDCLIIONE, ActionType JKJJKBAFNMO, float NKJDKMNNPFK = 0.1f)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp(JKJJKBAFNMO))
		{
			CMGDCLIIONE = -1f;
		}
		else
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(JKJJKBAFNMO))
			{
				CMGDCLIIONE = 0f;
				return true;
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButton(JKJJKBAFNMO) && CMGDCLIIONE != -1f)
			{
				CMGDCLIIONE += Time.unscaledDeltaTime;
				if (CMGDCLIIONE > 0.3f)
				{
					CMGDCLIIONE -= NKJDKMNNPFK;
					return true;
				}
			}
		}
		return false;
	}

	public static bool MBCCIAKKPMJ(int JFNMCNCHMEO)
	{
		bool flag = false;
		try
		{
			flag = DHDIKCFNJPN[JFNMCNCHMEO];
			if (!flag)
			{
				if (SteamManager.BNBMMDGMKLM)
				{
					SteamUserStats.GetAchievement("Ach_" + JFNMCNCHMEO, ref flag);
				}
				else if (GalaxyInstance.User() != null && GalaxyInstance.User().SignedIn())
				{
					flag = GalaxyManager.Instance.StatsAndAchievements.GetAchievement("Ach_" + JFNMCNCHMEO);
				}
			}
		}
		catch
		{
			Debug.LogError((object)"Error unlocking achievements. This is most likely because we are not signed in to Steam or GOG.");
		}
		return flag;
	}

	public static void JEAHJILAIAP(float KCGLKOAJNPB)
	{
		if (!OnlineManager.PlayingOnline() || KCGLKOAJNPB == 1f)
		{
			Time.timeScale = KCGLKOAJNPB;
		}
	}

	public static Season HEJJDFHOGKB(Season EECEKHKAAIH)
	{
		return (Season)NMLNAGFLNMC((int)(EECEKHKAAIH + 2), 4);
	}

	public static Vector2 NKGANMEKDAL(Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		return new Vector2(Mathf.Floor(IMOBLFMHKOD.x * 2f) / 2f, Mathf.Floor(IMOBLFMHKOD.y * 2f) / 2f);
	}

	public static T[] CCCCIKOMAEN<T>(Vector2 MJGMEBDNKKI, int FCPJIPBPGFK = -5) where T : MonoBehaviour
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		LGCKFFEMPBD = Physics2D.OverlapPointAll(MJGMEBDNKKI);
		List<T> list = new List<T>();
		Collider2D[] lGCKFFEMPBD = LGCKFFEMPBD;
		for (int i = 0; i < lGCKFFEMPBD.Length; i++)
		{
			T component = ((Component)lGCKFFEMPBD[i]).GetComponent<T>();
			if ((Object)(object)component != (Object)null)
			{
				list.Add(component);
			}
		}
		return list.ToArray();
	}

	private static bool LILJOBFMELE(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(IMOBLFMHKOD) != ZoneType.RentedRoom && WorldGrid.APKPGNDDJHC(IMOBLFMHKOD + Vector3.one * 0.25f))
		{
			return WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(0f, -0.5f));
		}
		return false;
	}

	public static float NMLNAGFLNMC(float NCPGNLOJGAF, float JPFOPOEHFKH)
	{
		float num = NCPGNLOJGAF % JPFOPOEHFKH;
		if (!(num < 0f))
		{
			return num;
		}
		return num + JPFOPOEHFKH;
	}

	public static bool CMHFKDLLEOJ(this Location AODONKKHPBP, Location AKPKDELPEHN)
	{
		return (AODONKKHPBP & AKPKDELPEHN) == AKPKDELPEHN;
	}

	public static bool HNDBNJNJGJM(Vector3 IMOBLFMHKOD, ZoneType GIBJPCAFCJB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (EJPFCKFEMJF(IMOBLFMHKOD))
		{
			return GIBJPCAFCJB != ZoneType.Cellar;
		}
		return false;
	}

	public static void MBODDLPENFB()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			OnlineTavernManager.instance.SendCalculateRandomPositionsInTavern();
			return;
		}
		CommonReferences.GGFJGHHHEJC.allTavernPositions.Clear();
		HAKPCIKJLNM = NLIMICIGCKC(TavernFloor.FirstFloor);
		foreach (Vector3 item in HAKPCIKJLNM)
		{
			if (LILJOBFMELE(item))
			{
				CommonReferences.GGFJGHHHEJC.allTavernPositions.Add(item);
			}
		}
		HAKPCIKJLNM = NLIMICIGCKC(TavernFloor.SecondFloor);
		foreach (Vector3 item2 in HAKPCIKJLNM)
		{
			if (LILJOBFMELE(item2))
			{
				CommonReferences.GGFJGHHHEJC.allTavernPositions.Add(item2);
			}
		}
		HAKPCIKJLNM.Clear();
	}

	public static bool AEHLNBIKMIF(Item MEMGMDOCBOJ)
	{
		if (PlayerInventory.GetPlayer(2).RemoveItem(MEMGMDOCBOJ) == null && !CraftingInventory.RemoveItemFromAllContainers(MEMGMDOCBOJ) && Bin.instance.RemoveItem(MEMGMDOCBOJ) == null && !DroppedItem.RemoveDroppedItem(MEMGMDOCBOJ) && PlayerInventory.GetPlayer(1).RemoveItem(MEMGMDOCBOJ) == null)
		{
			return false;
		}
		return true;
	}

	public static void OFHPCBLHJBL(float KCGLKOAJNPB, float HAFLNNPJJKK)
	{
		if (KCGLKOAJNPB == 1f || !OnlineManager.PlayingOnline())
		{
			if (DMFCLPEOJPG != null)
			{
				((MonoBehaviour)GameManager.GGFJGHHHEJC).StopCoroutine(DMFCLPEOJPG);
			}
			DMFCLPEOJPG = ((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(PGPMDFAEOEH(KCGLKOAJNPB, HAFLNNPJJKK));
		}
	}

	public static int MHOPHHOJLOK(FoodInstance GCJPFFNGCJA, List<ItemInstance> JIBDHKOMAAA)
	{
		if (GCJPFFNGCJA.JEPBBEBJEFI())
		{
			List<int> list = new List<int>();
			for (int i = 0; i < JIBDHKOMAAA.Count; i++)
			{
				if (JIBDHKOMAAA[i] is FoodInstance foodInstance && foodInstance.JEPBBEBJEFI())
				{
					if (foodInstance.LHBPOPOIFLE().canBeSold && foodInstance.LHBPOPOIFLE().canBeAged)
					{
						list.Add(foodInstance.GBCJNGADANM);
					}
					else if (Object.op_Implicit((Object)(object)foodInstance.LHBPOPOIFLE().recipe) && foodInstance.LHBPOPOIFLE().recipe.EFJKIOMELOB())
					{
						list.Add(foodInstance.GBCJNGADANM);
					}
				}
			}
			if (list.Count > 0)
			{
				int num = 0;
				for (int j = 0; j < list.Count; j++)
				{
					num += list[j];
				}
				return num / list.Count;
			}
		}
		return 0;
	}

	public static bool OLEBLHNHOPI(Vector3 IMOBLFMHKOD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(MJEACANINDN(IMOBLFMHKOD))) && PathNodesManager.pathNodes[Vector2.op_Implicit(MJEACANINDN(IMOBLFMHKOD))].isFree)
		{
			return true;
		}
		for (int i = 0; i < WorldGrid.allMovementNeighbours.Length; i++)
		{
			if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(MJEACANINDN(IMOBLFMHKOD + WorldGrid.allMovementNeighbours[i].position))) && PathNodesManager.pathNodes[Vector2.op_Implicit(MJEACANINDN(IMOBLFMHKOD + WorldGrid.allMovementNeighbours[i].position))].isFree)
			{
				return true;
			}
		}
		return false;
	}

	public static bool DDPONGCPCNG(int JIIGOACEIKL)
	{
		if (GameManager.NoPlayers())
		{
			return false;
		}
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return false;
		}
		if (((Object)(object)JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA) != (Object)null && TilemapsInfo.ELHHFNFJIAD(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA) == InteriorType.Exterior) || TilemapsInfo.ELHHFNFJIAD(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA) == InteriorType.Cave)
		{
			return true;
		}
		return false;
	}

	private static void MHOHJOHBAED(string NKBAEMLKJEO, float FFDIEOBBFKL)
	{
		switch (NKBAEMLKJEO)
		{
		case "gold":
			if (FFDIEOBBFKL >= 800f)
			{
				DLIIAHACOJB(2);
			}
			else if (FFDIEOBBFKL >= 100f)
			{
				DLIIAHACOJB(1);
			}
			break;
		case "beerKegs":
			if (FFDIEOBBFKL == 100f)
			{
				DLIIAHACOJB(3);
			}
			break;
		case "tablesCleaned":
			if (FFDIEOBBFKL == 200f)
			{
				DLIIAHACOJB(4);
			}
			break;
		case "meatDishes":
			if (FFDIEOBBFKL == 1000f)
			{
				DLIIAHACOJB(5);
			}
			break;
		case "veggieDishes":
			if (FFDIEOBBFKL == 1000f)
			{
				DLIIAHACOJB(6);
			}
			break;
		case "cornHarvested":
			if (FFDIEOBBFKL >= 50f)
			{
				DLIIAHACOJB(10);
			}
			break;
		case "cropsHarvested":
			if (FFDIEOBBFKL >= 300f)
			{
				DLIIAHACOJB(11);
			}
			break;
		case "ordersDelivered":
			if (FFDIEOBBFKL == 20f)
			{
				DLIIAHACOJB(12);
			}
			break;
		case "roomsRented":
			if (FFDIEOBBFKL >= 100f)
			{
				DLIIAHACOJB(13);
			}
			break;
		case "kickedCustomers":
			if (FFDIEOBBFKL == 30f)
			{
				DLIIAHACOJB(14);
			}
			break;
		case "itemsCrafted":
			if (FFDIEOBBFKL >= 50f)
			{
				DLIIAHACOJB(15);
			}
			break;
		case "overnights":
			if (FFDIEOBBFKL == 10f)
			{
				DLIIAHACOJB(16);
			}
			break;
		case "weedsCut":
			if (FFDIEOBBFKL >= 1000f)
			{
				DLIIAHACOJB(18);
			}
			break;
		case "trashCollected":
			if (FFDIEOBBFKL >= 60f)
			{
				DLIIAHACOJB(23);
			}
			else if (FFDIEOBBFKL >= 20f)
			{
				DLIIAHACOJB(22);
			}
			break;
		case "fishDishes":
			if (FFDIEOBBFKL >= 1000f)
			{
				DLIIAHACOJB(28);
			}
			break;
		case "plantedTrees":
			if (FFDIEOBBFKL >= 50f)
			{
				DLIIAHACOJB(31);
			}
			break;
		case "holesDug":
			if (FFDIEOBBFKL >= 50f)
			{
				DLIIAHACOJB(32);
			}
			break;
		case "fishCaught":
			if (FFDIEOBBFKL >= 200f)
			{
				DLIIAHACOJB(34);
			}
			break;
		}
	}

	public static bool CIEPGMEEBON(Vector3 IMOBLFMHKOD, float DFFGLLDDEPN)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && Vector2.Distance(Vector2.op_Implicit(IMOBLFMHKOD), Vector2.op_Implicit(PlayerController.GetPlayerPosition(i))) > DFFGLLDDEPN)
			{
				return false;
			}
		}
		return true;
	}

	public static void DJCNDIOLBJC()
	{
		((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(NPDDJMIFJMK());
	}

	public static bool FNCKBOHPFFJ(int JIIGOACEIKL, Slot ADEBNALPEHE, Container ALPOKDOCCGM)
	{
		if (MouseSlot.GetPlayer(JIIGOACEIKL).slot.KPINNBKMOMO() && !PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)304) && ADEBNALPEHE?.itemInstance != null && !ADEBNALPEHE.KPINNBKMOMO())
		{
			PPFIBIBKBBI = ALPOKDOCCGM.AddItemInstance(JIIGOACEIKL, ADEBNALPEHE.itemInstance, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
			if (PPFIBIBKBBI != null)
			{
				Sound.GGFJGHHHEJC.PlayOneShot(CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 0.5f);
				PhaseItemInstance phaseItemInstance = ADEBNALPEHE.itemInstance as PhaseItemInstance;
				ADEBNALPEHE.MEODNPFJDMH(CDPAMNIPPEC: false);
				phaseItemInstance?.KCBNLEFGDPP(JIIGOACEIKL);
				if (OnlineManager.PlayingOnline())
				{
					OnlineSlotsManager.instance.SendSlots(new Slot[2] { ADEBNALPEHE, PPFIBIBKBBI });
				}
				return true;
			}
		}
		return false;
	}

	public static bool ODAKOPMKEEJ()
	{
		return CommonReferences.GetEditorConfiguration().debugTracesActivated;
	}

	public static Slot DHKKKGMMPIM(int JIIGOACEIKL, ItemInstance LECMJGJMAEO)
	{
		List<DrinkDispenser> list = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispensers(LECMJGJMAEO);
		if (list.Count == 0)
		{
			list = DrinkDispensersManager.GGFJGHHHEJC.GetLastDrinks(LECMJGJMAEO);
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].slots[0].Stack < list[i].GetMaxStack(list[i].slots[0].itemInstance))
			{
				Slot obj = list[i].slots[0];
				obj.FEEOFAGCONJ(JIIGOACEIKL, LECMJGJMAEO);
				return obj;
			}
		}
		PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(LECMJGJMAEO, HMPDLIPFBGD: true);
		return null;
	}

	public static bool FIBFKGIJMBJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return IMOBLFMHKOD.y > 1000f;
	}

	public static bool FNNJEGLDGKC(Vector3 IMOBLFMHKOD, ZoneType GIBJPCAFCJB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (EJPFCKFEMJF(IMOBLFMHKOD) && GIBJPCAFCJB != ZoneType.RentedRoom)
		{
			return GIBJPCAFCJB != ZoneType.Cellar;
		}
		return false;
	}

	public static void BGJKAOHBKMP(Vector3 IMOBLFMHKOD)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if ((!WorldTime.IsFirstDay() || WorldTime.NOAOJJLNHJJ.hour >= 9) && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD) && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + Vector3.down * 0.75f) && (Object)(object)KJOMDMEIAEJ<FloorDirt>(Vector2.op_Implicit(IMOBLFMHKOD)) == (Object)null && WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD))
		{
			Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.dirtPrefab, BMBMPKNANAC(IMOBLFMHKOD), Quaternion.identity);
		}
	}

	public static bool KHPACNEAJIC(object DPEOLFMDLAK, object ODNGJHPOMMK)
	{
		return DPEOLFMDLAK?.Equals(ODNGJHPOMMK) ?? (ODNGJHPOMMK == null);
	}

	public static Vector2Online LGLEABBIGAH(Vector2 FIAFDEMFKGM)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return new Vector2Online(FIAFDEMFKGM.x, FIAFDEMFKGM.y);
	}

	public static float HEEBPOGPGMO(float KDPHEAAOBGD)
	{
		return Mathf.Round(KDPHEAAOBGD * 48f) / 48f;
	}

	public static Vector3 HENDGAAHICI(Vector3 GCFFMKJNBLI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3(Mathf.Round(GCFFMKJNBLI.x * 2f) / 2f, Mathf.Round(GCFFMKJNBLI.y * 2f) / 2f, Mathf.Round(GCFFMKJNBLI.z * 2f) / 2f);
	}

	public static bool ELFGBIGCFGL(int EEJCKPPLOBE, Slot ADEBNALPEHE, Container ALPOKDOCCGM)
	{
		if (ADEBNALPEHE != null && ADEBNALPEHE.itemInstance != null)
		{
			int num = ((!PlayerInputs.GetPlayerControllers(EEJCKPPLOBE).Keyboard.GetKey((KeyCode)304) || ADEBNALPEHE.Stack <= 1) ? ADEBNALPEHE.Stack : (ADEBNALPEHE.Stack / 2));
			CDEMNCNPNAP.Clear();
			PhaseItemInstance phaseItemInstance = ADEBNALPEHE.itemInstance as PhaseItemInstance;
			for (int i = 0; i < num; i++)
			{
				PPFIBIBKBBI = ALPOKDOCCGM.AddItemInstance(EEJCKPPLOBE, ADEBNALPEHE.itemInstance, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
				if (PPFIBIBKBBI != null)
				{
					ADEBNALPEHE.MEODNPFJDMH(CDPAMNIPPEC: false);
					CDEMNCNPNAP.Add(PPFIBIBKBBI);
				}
			}
			phaseItemInstance?.KCBNLEFGDPP(EEJCKPPLOBE);
			Sound.GGFJGHHHEJC.PlayOneShot(CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickNeg), HOMFPAFAOGD: true, null, null, 0.5f);
			if (CDEMNCNPNAP.Count > 0)
			{
				if (OnlineManager.PlayingOnline())
				{
					CDEMNCNPNAP.Add(ADEBNALPEHE);
					OnlineSlotsManager.instance.SendSlots(CDEMNCNPNAP.ToArray());
				}
				return true;
			}
		}
		return false;
	}

	public static Season JCCJNLAAONG(Season EECEKHKAAIH)
	{
		return (Season)NMLNAGFLNMC((int)(EECEKHKAAIH - 1), 4);
	}

	private static Vector2 DADALKFFODC(Transform DMBHHLKMHOH, bool PDLKFBANOLH)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(PDLKFBANOLH ? (ECJLMIPAFGP - DMBHHLKMHOH.position) : ECJLMIPAFGP);
	}

	private static OrderingInfo[] LGHGKDEDCHC(Collider2D[] LGCKFFEMPBD)
	{
		GDENBNEBKLA = new List<OrderingInfo>();
		FFNDHHOHNFH = new Dictionary<SortingGroup, List<OrderingInfo>>();
		for (int i = 0; i < LGCKFFEMPBD.Length; i++)
		{
			KHGFBNICFCN = ((Component)LGCKFFEMPBD[i]).gameObject.GetComponent<SpriteRenderer>();
			if ((Object)(object)KHGFBNICFCN == (Object)null)
			{
				continue;
			}
			DGDNJKBAEFC = ((Component)((Component)LGCKFFEMPBD[i]).transform).GetComponent<SortingGroup>();
			if (Object.op_Implicit((Object)(object)DGDNJKBAEFC))
			{
				LJDOMOPBFFF = OrderingInfo.AFGNLHBMFKP(DGDNJKBAEFC);
			}
			else
			{
				LJDOMOPBFFF = OrderingInfo.AFGNLHBMFKP(KHGFBNICFCN);
			}
			if (Object.op_Implicit((Object)(object)((Component)LGCKFFEMPBD[i]).transform.parent))
			{
				if (Object.op_Implicit((Object)(object)((Component)((Component)LGCKFFEMPBD[i]).transform.parent).GetComponent<SurfaceSortOrder>()))
				{
					AKDDKKHDFEK = ((Component)((Component)LGCKFFEMPBD[i]).transform.parent).GetComponent<SortingGroup>();
				}
				else
				{
					AKDDKKHDFEK = null;
				}
			}
			else
			{
				AKDDKKHDFEK = null;
			}
			if (Object.op_Implicit((Object)(object)AKDDKKHDFEK))
			{
				if (FFNDHHOHNFH.ContainsKey(AKDDKKHDFEK))
				{
					FFNDHHOHNFH[AKDDKKHDFEK].Add(LJDOMOPBFFF);
					continue;
				}
				FKFHMPKNNDC.Clear();
				FKFHMPKNNDC.Add(LJDOMOPBFFF);
				FFNDHHOHNFH.Add(AKDDKKHDFEK, FKFHMPKNNDC);
			}
			else
			{
				GDENBNEBKLA.Add(LJDOMOPBFFF);
			}
		}
		foreach (SortingGroup key in FFNDHHOHNFH.Keys)
		{
			JAIJKIAIDKI = FFNDHHOHNFH[key];
			for (int j = 0; j < JAIJKIAIDKI.Count; j++)
			{
				OrderingInfo item = JAIJKIAIDKI[j];
				item.parentLayer = SortingLayer.GetLayerValueFromID(key.sortingLayerID);
				item.parentSortingOrder = key.sortingOrder;
				GDENBNEBKLA.Add(item);
			}
		}
		MBMHIJMDCPO = GDENBNEBKLA.ToArray();
		IACLKEGBBKL(ref MBMHIJMDCPO, ONKJEPNPPEB);
		return MBMHIJMDCPO;
	}

	public static Vector2 NGIEAJCBLBC(Int16Vector2 NCMDHOENENF)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector2((float)NCMDHOENENF.x, (float)NCMDHOENENF.y) * 0.5f;
	}

	public static TilemapScene HPBPMJGELIG(int JIIGOACEIKL)
	{
		return JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA);
	}

	private static List<Vector2> KHDALBNAJPL(Vector2 IMOBLFMHKOD, int ALMEEDGLGEO, int FMCCAGNDLCM)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		NIIDDNEFOEM.Clear();
		int num = 0;
		PFNPCONENGA.Clear();
		CMOKEBMKDDH.Clear();
		CMOKEBMKDDH.Enqueue(IMOBLFMHKOD);
		FOBNOCNONBF(IMOBLFMHKOD);
		while (CMOKEBMKDDH.Count > 0)
		{
			FNMKKHCMPNC = CMOKEBMKDDH.Dequeue();
			if (ALMEEDGLGEO <= 1)
			{
				if (!WorldGrid.DJLHADMPGBK(Vector2.op_Implicit(FNMKKHCMPNC)))
				{
					continue;
				}
			}
			else if (!WorldGrid.DJLHADMPGBK(Vector2.op_Implicit(FNMKKHCMPNC + NKDGACAPIDK)) || !WorldGrid.DJLHADMPGBK(Vector2.op_Implicit(FNMKKHCMPNC + FPNFMGNMCOM)) || !WorldGrid.DJLHADMPGBK(Vector2.op_Implicit(FNMKKHCMPNC + DEAHHHABFIB)) || !WorldGrid.DJLHADMPGBK(Vector2.op_Implicit(FNMKKHCMPNC + FDFBBEMBKNC)))
			{
				continue;
			}
			num++;
			if (WorldGrid.HJPCBBGHPDA(Vector2.op_Implicit(FNMKKHCMPNC)) == Location.Road)
			{
				NIIDDNEFOEM.Add(FNMKKHCMPNC);
			}
			if (num >= FMCCAGNDLCM)
			{
				break;
			}
			FOBNOCNONBF(FNMKKHCMPNC);
		}
		return NIIDDNEFOEM;
	}

	public static Vector2 BPKGAMFNAGC(Vector2Online GPONPCMBAME)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return new Vector2(GPONPCMBAME.x, GPONPCMBAME.y);
	}

	public static void EACNFFIKABJ(int JIIGOACEIKL, Item MEMGMDOCBOJ)
	{
		int recipesListNum = RecipesBookUI.Get(JIIGOACEIKL).GetRecipesListNum(MEMGMDOCBOJ);
		if (recipesListNum != -1)
		{
			RecipesBookUI.Get(JIIGOACEIKL).ToggleUI();
			RecipesBookUI.Get(JIIGOACEIKL).FocusCrafterFilter(recipesListNum);
		}
	}

	private static void GFBAMCIMECB(int JIIGOACEIKL, Slot[] PCJEDMJEKEF, List<ItemInstanceAmount> JAGEECPLMIL)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			PCJEDMJEKEF[i].FDOBDPPMMBH(PCJEDMJEKEF[i].Stack);
			if (i < JAGEECPLMIL.Count)
			{
				PCJEDMJEKEF[i].BEEDBHJANGN(JIIGOACEIKL, JAGEECPLMIL[i].itemInstance, JAGEECPLMIL[i].amount, HAGPBCJEGKM: false, BDGJBPCEFPN: true);
			}
		}
	}

	public static List<Vector2> NANFHBIPIIF(Vector3 IMOBLFMHKOD, int ALMEEDGLGEO, int FMCCAGNDLCM)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		return KHDALBNAJPL(MJEACANINDN(Vector2.op_Implicit((WorldGrid.HJPCBBGHPDA(IMOBLFMHKOD) == Location.Road) ? IMOBLFMHKOD : TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.BarnInterior).GetMiddlePosition())), ALMEEDGLGEO, FMCCAGNDLCM);
	}

	public static bool IIHPGJIJOAD(int JIIGOACEIKL, ref float CMGDCLIIONE, string JKJJKBAFNMO, float NKJDKMNNPFK = 0.1f)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp(JKJJKBAFNMO))
		{
			CMGDCLIIONE = -1f;
		}
		else
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(JKJJKBAFNMO))
			{
				CMGDCLIIONE = 0f;
				return true;
			}
			if (CMGDCLIIONE != -1f && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButton(JKJJKBAFNMO))
			{
				CMGDCLIIONE += Time.unscaledDeltaTime;
				if (CMGDCLIIONE > 0.3f)
				{
					CMGDCLIIONE -= NKJDKMNNPFK;
					return true;
				}
			}
		}
		return false;
	}

	public static bool JANBGCMGMEE(Vector2 IMOBLFMHKOD, float DFFGLLDDEPN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.Distance(Vector2.op_Implicit(PlayerController.GetPlayerPosition(1)), IMOBLFMHKOD) < DFFGLLDDEPN;
	}

	public static int JCKKCOCGDLA(int JIIGOACEIKL, Item MEMGMDOCBOJ, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false)
	{
		NKMJAGDJPJE = 0;
		if ((Object)(object)MEMGMDOCBOJ.PHGCBMPGGLI() != (Object)null)
		{
			List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
			for (int i = 0; i < currentPlaceables.Count; i++)
			{
				if (Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup.item) && currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JDJGFAACPFC(DAINLFIMLIH: false))
				{
					NKMJAGDJPJE++;
				}
			}
		}
		NKMJAGDJPJE += CraftingInventory.NumberOfItems(JIIGOACEIKL, MEMGMDOCBOJ, AKNBKINJGCF, FLAAGFECLME, AHCENOLCIBM);
		return NKMJAGDJPJE;
	}

	private static OrderingInfo[] JPKIAJHKOBK(int JIIGOACEIKL, Vector2 MJGMEBDNKKI, int FCPJIPBPGFK = -5)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (DLOMIGFOOPD(JIIGOACEIKL))
		{
			return null;
		}
		ILKCKOPJGMM = Physics2D.OverlapPointAll(MJGMEBDNKKI, FCPJIPBPGFK);
		if (ILKCKOPJGMM.Length != 0)
		{
			FMCIAKBJFOC = LGHGKDEDCHC(ILKCKOPJGMM);
			if (FMCIAKBJFOC.Length == 0)
			{
				return null;
			}
			return FMCIAKBJFOC;
		}
		return null;
	}

	public static List<Vector3> GADHLHEBHFL(Vector3 IMOBLFMHKOD, FindPositionsInfo BBJDPIJPLPA)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<KeyValuePair<Vector3, WorldTile>> enumerable = GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.Where((KeyValuePair<Vector3, WorldTile> wt) => wt.Value.groundType != 0 && BBJDPIJPLPA.location.HasFlag(wt.Value.location) && BBJDPIJPLPA.zoneType.HasFlag(wt.Value.zoneType) && (!BBJDPIJPLPA.checkNodeFree || WorldGrid.APKPGNDDJHC(wt.Key)) && (!BBJDPIJPLPA.checkCanPlaceObject || WorldGrid.NGDHDMAMGPI(wt.Value)) && (!BBJDPIJPLPA.checkDistance || Vector2.Distance(Vector2.op_Implicit(wt.Key), Vector2.op_Implicit(IMOBLFMHKOD)) > (float)BBJDPIJPLPA.minDistance) && (!BBJDPIJPLPA.checkFarmable || WorldGrid.LKBLKCFOEPA(wt.Value)) && (!BBJDPIJPLPA.avoidPath || !WorldGrid.ECOFAPGIGMO(wt.Key)));
		List<Vector3> list = new List<Vector3>();
		if (BBJDPIJPLPA.location == Location.BarnInterior)
		{
			foreach (KeyValuePair<Vector3, WorldTile> item in enumerable)
			{
				if (item.Value.PBLLKEKGLPK is BarnTilemapScene barnTilemapScene && barnTilemapScene.barnLevel == BBJDPIJPLPA.level)
				{
					list.Add(item.Key);
				}
			}
		}
		else
		{
			foreach (KeyValuePair<Vector3, WorldTile> item2 in enumerable)
			{
				list.Add(item2.Key);
			}
		}
		return list;
	}

	public static bool EGIBECKKIJJ()
	{
		if (disableChristmasEvent)
		{
			return false;
		}
		if (Options.OIJKKLHIGDD == 0 && OnlineManager.MasterOrOffline())
		{
			return false;
		}
		if (OnlineManager.ClientOnline() && !ChristmasEvent.instance.HCOPJPMDEKP)
		{
			return false;
		}
		return MDBAIEDPBJN;
	}

	public static Vector3 MKLBDDEIPEC(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (HOHLHGJHOKM(IMOBLFMHKOD))
		{
			return NKGANMEKDAL(((Component)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Tavern, Location.Road)).transform.position);
		}
		if (FIBFKGIJMBJ(IMOBLFMHKOD))
		{
			if ((Object)(object)TravelZonesManager.GGFJGHHHEJC.GetTravelZoneTavern(TavernFloor.SecondFloor, TavernFloor.FirstFloor) == (Object)null)
			{
				Debug.LogError((object)"There was an issue when loading Travel Zones for the second floor. This is likely caused in online mode. Needs further investigating.");
				return Vector3.zero;
			}
			return NKGANMEKDAL(((Component)TravelZonesManager.GGFJGHHHEJC.GetTravelZoneTavern(TavernFloor.SecondFloor, TavernFloor.FirstFloor)).transform.position);
		}
		if (BLIAFMGPONN(IMOBLFMHKOD))
		{
			return NKGANMEKDAL(((Component)TravelZonesManager.GGFJGHHHEJC.GetTravelZoneTavern(TavernFloor.Cellar, TavernFloor.FirstFloor)).transform.position);
		}
		return Vector3.zero;
	}

	public static Vector3 OPHGIHJJGPK(Vector3 IMOBLFMHKOD, bool BJOCPBIKBEE = false)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (!BJOCPBIKBEE)
		{
			return new Vector3(PMNDBKBJJNP(IMOBLFMHKOD.x), PMNDBKBJJNP(IMOBLFMHKOD.y), IMOBLFMHKOD.z);
		}
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(PMNDBKBJJNP(IMOBLFMHKOD.x), PMNDBKBJJNP(IMOBLFMHKOD.y), IMOBLFMHKOD.z);
		val.x -= val.x % 2f;
		val.y -= val.y % 2f;
		return val;
	}

	public static Price NEGAOFJKCCH(ItemInstance AAAECFKMEJJ, Employee NAKCFGEAGHH)
	{
		Price price = Money.CalculateSellPrice(AAAECFKMEJJ, HOECMANECIM: true, JNOEGJNPCFE: true);
		if (Application.isPlaying && Money.GetInstance().showPricesDebugs)
		{
			Debug.Log((object)(AAAECFKMEJJ.IABAKHPEOAF() + " get price serve customer " + price.ICIEKOLFGBJ()));
		}
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			price = NAKCFGEAGHH.ApplyPerkPrices(AAAECFKMEJJ, price);
		}
		if ((Object)(object)NAKCFGEAGHH == (Object)null && AAAECFKMEJJ is FoodInstance foodInstance)
		{
			price = Price.GMJIFJAEANF(price, Price.FAFHFJGOHPK(foodInstance.PAAFCADLNEM(), (float)PerksDatabaseAccessor.GetPlayerPerkValue(40) / 100f));
			if (Application.isPlaying && Money.GetInstance().showPricesDebugs && Price.FAFHFJGOHPK(foodInstance.PAAFCADLNEM(), (float)PerksDatabaseAccessor.GetPlayerPerkValue(40) / 100f).OOIPLIEJILO() > 0)
			{
				Debug.Log((object)(AAAECFKMEJJ.IABAKHPEOAF() + " perk 40 servicial (+" + Price.FAFHFJGOHPK(foodInstance.PAAFCADLNEM(), (float)PerksDatabaseAccessor.GetPlayerPerkValue(40) / 100f).ICIEKOLFGBJ() + ") " + price.ICIEKOLFGBJ()));
			}
		}
		if (Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(23))
		{
			price = Price.FAFHFJGOHPK(price, 2);
			if (Application.isPlaying && Money.GetInstance().showPricesDebugs)
			{
				Debug.Log((object)(AAAECFKMEJJ.IABAKHPEOAF() + " perk 23 propina " + price.ICIEKOLFGBJ()));
			}
		}
		price = Price.GHDCKOJGAMM(Mathf.Max(1, (int)((float)price.OOIPLIEJILO() + (float)price.OOIPLIEJILO() * Money.GetPlusPricesSatisfaction() / 100f)));
		if (Application.isPlaying && Money.GetInstance().showPricesDebugs)
		{
			Debug.Log((object)(AAAECFKMEJJ.IABAKHPEOAF() + " plus price satisfaction " + price.ICIEKOLFGBJ()));
		}
		return price;
	}

	public static List<RaycastResult> OFBMJPNCHAA(int JIIGOACEIKL)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return CHLHHOFKHAJ(Vector2.op_Implicit(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorScreenPosition()));
	}

	public static Vector3 NKGANMEKDAL(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3(Mathf.Floor(IMOBLFMHKOD.x * 2f) / 2f, Mathf.Floor(IMOBLFMHKOD.y * 2f) / 2f, 0f);
	}

	public static bool BDHBLGMBBCO()
	{
		return false;
	}

	public static void KIAEHEGDLPC(MonoBehaviour NPJDIDHOEFB, Exception FPAIOGKHAPI)
	{
		Debug.LogError((object)("Player Awake error on " + (((Object)(object)NPJDIDHOEFB != (Object)null) ? ((object)NPJDIDHOEFB).ToString() : "") + ": " + FPAIOGKHAPI.ToString()));
	}

	public static bool FIMCFCJHHIK(Vector2 IMOBLFMHKOD, Placeable EAPCLAODGAE, bool PHIIMPMIANE = true)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (PHIIMPMIANE && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) == GroundType.None)
		{
			return false;
		}
		KCJIMDFEBBL = HKOOAGHDKNO<Placeable>(IMOBLFMHKOD, new Vector2(0.16f, 0.1f), (CapsuleDirection2D)1, 0f, 2097152);
		for (int i = 0; i < KCJIMDFEBBL.Length; i++)
		{
			if (!((Object)(object)KCJIMDFEBBL[i] == (Object)(object)EAPCLAODGAE) && (Object)(object)KCJIMDFEBBL[i].itemSpace != (Object)null && !KCJIMDFEBBL[i].FHEMHCEAICB)
			{
				return false;
			}
		}
		return true;
	}

	public static Direction JPKPFDEBGEO(Direction FCGBJEIIMBC)
	{
		return FCGBJEIIMBC switch
		{
			Direction.Up => Direction.Right, 
			Direction.Down => Direction.Left, 
			Direction.Left => Direction.Up, 
			_ => Direction.Down, 
		};
	}

	public static void DLKKOLGNKHH(List<Slot> PCJEDMJEKEF, int BGPKFEJHDOC)
	{
		for (int num = PCJEDMJEKEF.Count - 1; num >= 0; num--)
		{
			if (PCJEDMJEKEF[num].Stack < BGPKFEJHDOC)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
		}
	}

	public static bool HOHLHGJHOKM(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.y > 900f)
		{
			return IMOBLFMHKOD.y < 1000f;
		}
		return false;
	}

	public static T GCGNCHFNEBJ<T>(Tilemap OKKHNHELKJB, Vector3Int AIJOOOIJEDC) where T : TileBase
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)OKKHNHELKJB == (Object)null)
		{
			return default(T);
		}
		TileBase tile = OKKHNHELKJB.GetTile(AIJOOOIJEDC);
		return (T)(object)((tile is T) ? tile : null);
	}

	public static float FMAGOHLBBIJ(Vector2 IMOBLFMHKOD)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return float.MaxValue;
		}
		MIJLMAIEEHB = float.MaxValue;
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && MIJLMAIEEHB > Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(i)).transform.position)))
			{
				MIJLMAIEEHB = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(i)).transform.position));
			}
		}
		return MIJLMAIEEHB;
	}

	public static bool BLIAFMGPONN(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.y > 800f)
		{
			return IMOBLFMHKOD.y < 900f;
		}
		return false;
	}

	public static bool FNLJGAEHNKA()
	{
		if (PiratesGameManager.Playing)
		{
			return true;
		}
		if (BathhouseGameManager.Playing)
		{
			return true;
		}
		if (FishCuttingGameManager.Playing || ((Object)(object)FishCuttingGameManager.instance != (Object)null && ((Behaviour)FishCuttingGameManager.instance).enabled))
		{
			return true;
		}
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			return true;
		}
		return false;
	}

	public static Direction EIDFHLPBICI(Vector2 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (Mathf.Abs(DPNLDLEHMHO.x) >= Mathf.Abs(DPNLDLEHMHO.y))
		{
			if (DPNLDLEHMHO.x > 0f)
			{
				return Direction.Right;
			}
			return Direction.Left;
		}
		if (DPNLDLEHMHO.y > 0f)
		{
			return Direction.Up;
		}
		return Direction.Down;
	}

	public static List<ItemMod> ODFMBJKNIEG(Item MEMGMDOCBOJ, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> source = ((!(MEMGMDOCBOJ is IngredientGroup ingredientGroup)) ? new List<ItemMod>
		{
			new ItemMod(MEMGMDOCBOJ)
		} : ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK));
		return source.Where((ItemMod x) => !(x.item is Food food) || food.canBeUsedAsModifier).ToList();
	}

	public static List<Slot> ENELGLONHKJ(List<Slot> PCJEDMJEKEF)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < PCJEDMJEKEF.Count; i++)
		{
			int num = PCJEDMJEKEF[i].Stack;
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j].itemInstance.Equals(PCJEDMJEKEF[i].itemInstance))
				{
					num = list[j].BEEDBHJANGN(1, PCJEDMJEKEF[i].itemInstance, PCJEDMJEKEF[i].Stack, HAGPBCJEGKM: false, BDGJBPCEFPN: true);
					if (num == 0)
					{
						break;
					}
				}
			}
			if (num > 0)
			{
				list.Add(new Slot(PCJEDMJEKEF[i].itemInstance, num, 999));
			}
		}
		Slot[] array = list.ToArray();
		BNDMCJGGBFK(array);
		return new List<Slot>(array);
	}

	public static bool AOALMGABLGN(Vector2 GCFFMKJNBLI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if ((GCFFMKJNBLI.x % 1f == 0.5f || GCFFMKJNBLI.x % 1f == -0.5f) && (GCFFMKJNBLI.y % 1f == 0.5f || GCFFMKJNBLI.y % 1f == -0.5f))
		{
			return true;
		}
		return false;
	}

	public static T GCGNCHFNEBJ<T>(Tilemap OKKHNHELKJB, Vector3 IMOBLFMHKOD) where T : TileBase
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)OKKHNHELKJB == (Object)null)
		{
			return default(T);
		}
		TileBase tile = OKKHNHELKJB.GetTile(((GridLayout)OKKHNHELKJB).WorldToCell(IMOBLFMHKOD));
		return (T)(object)((tile is T) ? tile : null);
	}

	public static void AGBFAMCBDPI(Slot[] PCJEDMJEKEF)
	{
		List<ItemInstanceAmount> jAGEECPLMIL = (from slot in PCJEDMJEKEF
			where !slot.KPINNBKMOMO()
			select new ItemInstanceAmount(slot.itemInstance, slot.Stack) into slot
			orderby slot.itemInstance.LHBPOPOIFLE().IABAKHPEOAF(OAFPBCPDOKH: true)
			select slot).ToList();
		GFBAMCIMECB(1, PCJEDMJEKEF, jAGEECPLMIL);
	}

	public static bool AFILAHPFDOD(IngredientType DJAIFDHGLJJ, IngredientType[] KHAHOLECLNI)
	{
		for (int i = 0; i < KHAHOLECLNI.Length; i++)
		{
			if (KHAHOLECLNI[i] == DJAIFDHGLJJ)
			{
				return true;
			}
		}
		return false;
	}

	public static float GNFLPFFNALP(List<Vector2> FNEHIAGFAOF, Vector3 JAFKHHNPOGJ)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (FNEHIAGFAOF == null || FNEHIAGFAOF.Count == 0)
		{
			return 0f;
		}
		LMEKBPPCFJB = FNEHIAGFAOF[0];
		ILOLBBLNEOA = Vector2.Distance(LMEKBPPCFJB, Vector2.op_Implicit(JAFKHHNPOGJ));
		for (int i = 1; i < FNEHIAGFAOF.Count; i++)
		{
			_ = FNEHIAGFAOF[i];
			KDKLHPFGLLB = Vector2.Distance(FNEHIAGFAOF[i], Vector2.op_Implicit(JAFKHHNPOGJ));
			if (KDKLHPFGLLB < ILOLBBLNEOA)
			{
				ILOLBBLNEOA = KDKLHPFGLLB;
				LMEKBPPCFJB = FNEHIAGFAOF[i];
			}
		}
		return Mathf.Max(0f, ILOLBBLNEOA);
	}

	public static bool AHMPFOEGJHF(Location BAIMHDBJPDK, int JIIGOACEIKL = 1)
	{
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)))
		{
			return PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == BAIMHDBJPDK;
		}
		return false;
	}

	public static Vector3 KGEOMOKKFKP(PlayerController PKCHNBPBHFL, int JNLPKLIJPJB)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (PKCHNBPBHFL.LEOIMFNKFGA == Location.Beach)
		{
			return Vector2.op_Implicit(POLDMHFDINK(WorldGrid.PCMIIFEGMHJ(((Component)PKCHNBPBHFL).transform.position), JNLPKLIJPJB));
		}
		return Vector2.op_Implicit(POLDMHFDINK(Vector2.op_Implicit(((Component)PKCHNBPBHFL).transform.position), JNLPKLIJPJB));
	}

	public static bool PLIACJACMMI(int MNBNGGHHMBB)
	{
		return PLIACJACMMI(ItemDatabaseAccessor.GetItem(MNBNGGHHMBB));
	}

	private static bool LAAIBNEKHOH(ItemInstance DNLMCHDOMOK, List<IngredientModifier> EMHAHFPLAGB)
	{
		if (EMHAHFPLAGB == null)
		{
			return false;
		}
		if (DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable)
		{
			for (int i = 0; i < EMHAHFPLAGB.Count; i++)
			{
				if (modifiable.CICEBNMBGMG.ContainsKey(EMHAHFPLAGB[i]))
				{
					return true;
				}
			}
		}
		return false;
	}

	public static int CDAEGJIFDIM(TavernFloor BDCFJAHNOML)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		OOPLKGHOBHC.Clear();
		CAEMMONHLNL(NKGANMEKDAL(IMOJLANDCJB(BDCFJAHNOML).position), OOPLKGHOBHC);
		return OOPLKGHOBHC.Count;
	}

	public static IEnumerator BBCAIEGMBPD<T>(T KNJGPCDAJOA, float LGLDPMAABLA) where T : Object
	{
		yield return (object)new WaitForSecondsRealtime(LGLDPMAABLA + 2f);
		Object.Destroy((Object)(object)KNJGPCDAJOA);
	}

	public static string LBEJKMLHMIP()
	{
		if (FIGOCKBBIFO(ILLKGGBHMLF()))
		{
			return SteamManager.GetSteamID();
		}
		if (GalaxyInstance.User() != null && GalaxyInstance.User().SignedIn() && GalaxyInstance.User().IsLoggedOn())
		{
			return "GOG " + InputUtils.NHGIAHHNIJF(GalaxyInstance.Friends().GetPersonaName()) + " - " + (object)GalaxyInstance.User().GetGalaxyID();
		}
		if ((Object)(object)Save.instance != (Object)null && (Object)(object)OnlineManager.saveSlotSelectedForOnlinePlay != (Object)null)
		{
			return "PLAYERNAME " + Save.instance.GetSaveData(OnlineManager.saveSlotSelectedForOnlinePlay.GetFileName()).DLOLLOFPICG().name;
		}
		return "DEBUG_FAKE_ID";
	}

	public static bool CEAMMHNBMMJ(int JIIGOACEIKL)
	{
		if ((Object)(object)CKNBOKKFPLJ<BlockInteractObjects>(JIIGOACEIKL) != (Object)null)
		{
			return true;
		}
		return false;
	}

	public static Vector3 MJEACANINDN(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		float num = Mathf.Round(IMOBLFMHKOD.x * 4f) * 0.25f;
		float num2 = Mathf.Round(IMOBLFMHKOD.y * 4f) * 0.25f;
		return new Vector3(num, num2, 0f);
	}

	public static bool BKFNPIFHBDH(Location BAIMHDBJPDK)
	{
		return TilemapsInfo.AEALFCKBGKM(BAIMHDBJPDK);
	}

	public static int BCLCKLKGFCL(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (FCFHPAPKOEL(IMOBLFMHKOD) == TavernFloor.Cellar)
		{
			return 13;
		}
		return 12;
	}

	public static void BNDMCJGGBFK(List<SlotUI> DPJAFMAJBKF, Slot[] ACJMMBKADCG)
	{
		Slot[] jAGEECPLMIL = (from slot in ACJMMBKADCG
			where !slot.KPINNBKMOMO()
			orderby ((object)slot.itemInstance.LHBPOPOIFLE()).GetType().ToString(), slot.itemInstance.LHBPOPOIFLE().tags.Contains(Tag.Unaged), (!(slot.itemInstance.LHBPOPOIFLE() is Food food)) ? ((int)((slot.itemInstance.LHBPOPOIFLE().tags.Length == 0) ? ((Tag)100) : slot.itemInstance.LHBPOPOIFLE().tags[0])) : ((int)food.ingredientType), slot.itemInstance.LHBPOPOIFLE().IABAKHPEOAF(OAFPBCPDOKH: true)
			select slot).ToArray();
		GFBAMCIMECB(DPJAFMAJBKF, jAGEECPLMIL);
	}

	public static bool JEPBBEBJEFI(IngredientType DJAIFDHGLJJ)
	{
		if (DJAIFDHGLJJ != IngredientType.Beer && DJAIFDHGLJJ != IngredientType.Distillate)
		{
			return DJAIFDHGLJJ == IngredientType.Liqueur;
		}
		return true;
	}

	public static Vector3 JOJPOKBFANL(Vector3[] HAEIAGKNEPC, Vector3 JAFKHHNPOGJ)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC == null)
		{
			return Vector3.zero;
		}
		if (HAEIAGKNEPC.Length == 1)
		{
			return HAEIAGKNEPC[0];
		}
		Vector3 val = HAEIAGKNEPC[0];
		float num = Vector3.Distance(val, JAFKHHNPOGJ);
		for (int i = 1; i < HAEIAGKNEPC.Length; i++)
		{
			float num2 = Vector3.Distance(HAEIAGKNEPC[i], JAFKHHNPOGJ);
			if (num2 < num)
			{
				num = num2;
				val = HAEIAGKNEPC[i];
			}
		}
		return val;
	}

	public static Direction DFJPGJKDAAF(Direction FCGBJEIIMBC)
	{
		return FCGBJEIIMBC switch
		{
			Direction.Up => Direction.Left, 
			Direction.Down => Direction.Right, 
			Direction.Left => Direction.Down, 
			_ => Direction.Up, 
		};
	}

	public static bool FFLNGLMHLBO()
	{
		if (Options.GPFJCMAGGAO == 0 || NewTutorialManager.CCCLOBIOMCL || disableHalloweenEvent)
		{
			return false;
		}
		if (HCMOKAMNPMG == 99)
		{
			if ((DateTime.Now.Day >= 21 && DateTime.Now.Month == 10 && DateTime.Now.Year == 2024) || (DateTime.Now.Day <= 7 && DateTime.Now.Month == 11 && DateTime.Now.Year == 2024))
			{
				HCMOKAMNPMG = 1;
			}
			else
			{
				HCMOKAMNPMG = 0;
			}
		}
		return HCMOKAMNPMG == 1;
	}

	public static bool FIGOCKBBIFO(PlatformOS DJBHINLJOBO)
	{
		if ((uint)(DJBHINLJOBO - 4) <= 3u)
		{
			return true;
		}
		return false;
	}

	public static int AICHIHLICOO()
	{
		NCLIENJDJMG = DDKAKILPDBP - DateTime.UtcNow;
		return NCLIENJDJMG.Days;
	}

	public static int BIKIBFJONAO()
	{
		return 21;
	}

	public static int KCIFBLGFJID(int HLJEAEIEJMP, bool GGBBJNBBLMF = false)
	{
		if (HLJEAEIEJMP == 1224 && AICHIHLICOO() < 0)
		{
			return 1226;
		}
		if (dictReplaceItems.ContainsKey(HLJEAEIEJMP))
		{
			return dictReplaceItems[HLJEAEIEJMP];
		}
		return HLJEAEIEJMP;
	}

	public static bool HPEMIIGAHLB<T>(T[] CDCBGDCHFGJ, T[] FJHBLEIJJKH)
	{
		if (FJHBLEIJJKH == null && CDCBGDCHFGJ == null)
		{
			return true;
		}
		if (FJHBLEIJJKH == null && CDCBGDCHFGJ != null)
		{
			return false;
		}
		if (FJHBLEIJJKH != null && CDCBGDCHFGJ == null)
		{
			return false;
		}
		if (CDCBGDCHFGJ.Length == 0)
		{
			CDCBGDCHFGJ = null;
		}
		if (FJHBLEIJJKH.Length == 0)
		{
			FJHBLEIJJKH = null;
		}
		if (FJHBLEIJJKH == null && CDCBGDCHFGJ == null)
		{
			return true;
		}
		if (FJHBLEIJJKH == null && CDCBGDCHFGJ != null)
		{
			return false;
		}
		if (FJHBLEIJJKH != null && CDCBGDCHFGJ == null)
		{
			return false;
		}
		for (int i = 0; i < FJHBLEIJJKH.Length; i++)
		{
			if (Array.IndexOf(CDCBGDCHFGJ, FJHBLEIJJKH[i]) < 0)
			{
				return false;
			}
		}
		return true;
	}

	private static void LBJIBCPJPFH(Vector3 IMOBLFMHKOD, HashSet<Vector3> OOPLKGHOBHC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (!OOPLKGHOBHC.Contains(IMOBLFMHKOD) && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD))
		{
			OOPLKGHOBHC.Add(IMOBLFMHKOD);
			EHKLNEKNGDM.Push(IMOBLFMHKOD);
		}
	}

	public static T[] HKOOAGHDKNO<T>(Vector2 MJGMEBDNKKI, Vector2 KKANDELPDKP, CapsuleDirection2D LIFDAOHBBHJ, float GLOEPFGFIME, int FCPJIPBPGFK = -5) where T : MonoBehaviour
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		int num = Physics2D.OverlapCapsuleNonAlloc(MJGMEBDNKKI, KKANDELPDKP, LIFDAOHBBHJ, GLOEPFGFIME, NIAKAMHIMEJ, FCPJIPBPGFK);
		List<T> list = new List<T>();
		for (int i = 0; i < num; i++)
		{
			if (!NIAKAMHIMEJ[i].isTrigger)
			{
				T componentInParent = ((Component)NIAKAMHIMEJ[i]).GetComponentInParent<T>();
				if ((Object)(object)componentInParent != (Object)null)
				{
					list.Add(componentInParent);
				}
			}
		}
		return list.ToArray();
	}

	public static bool MKCNPAKBDOL(int JIIGOACEIKL, Slot EFDPGNOICOG, int FGFCNKFEIGF, Slot[] MKDOCALGPKJ, Slot[] LCFKMJHDBOB, Container ALPOKDOCCGM)
	{
		GDHKLPOOHEO.Clear();
		bool result = true;
		for (int i = 0; i < FGFCNKFEIGF; i++)
		{
			KCJBFOAAFLK = BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, MKDOCALGPKJ, ALPOKDOCCGM);
			if (KCJBFOAAFLK == null)
			{
				KCJBFOAAFLK = BMPHEAFDFPI(JIIGOACEIKL, EFDPGNOICOG, LCFKMJHDBOB, ALPOKDOCCGM);
			}
			if (KCJBFOAAFLK != null)
			{
				if (!GDHKLPOOHEO.Contains(KCJBFOAAFLK))
				{
					GDHKLPOOHEO.Add(KCJBFOAAFLK);
				}
				continue;
			}
			result = false;
			break;
		}
		if (GDHKLPOOHEO.Count > 0 && OnlineManager.PlayingOnline())
		{
			GDHKLPOOHEO.Add(EFDPGNOICOG);
			OnlineSlotsManager.instance.SendSlots(GDHKLPOOHEO.ToArray());
		}
		return result;
	}

	public static void BLPDAEHPOBA(GameObject DOFFKPMMCBD)
	{
		DestroyTracer.DestroyWithTrace(DOFFKPMMCBD);
	}

	public static T OFAJOIGFMAD<T>(T[] JMNCLLBHCAO, int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE + 1 > JMNCLLBHCAO.Length)
		{
			return default(T);
		}
		return JMNCLLBHCAO[MOFKEDGAOEE];
	}

	public static float OINGDOIAHDP(float KDPHEAAOBGD)
	{
		return Mathf.Round(KDPHEAAOBGD * 2f) / 2f;
	}

	public static Vector2 EENFKOKHBLA(Vector2 GCFFMKJNBLI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		return new Vector2(Mathf.Floor(GCFFMKJNBLI.x - 0.5f) + 0.5f, Mathf.Floor(GCFFMKJNBLI.y - 0.5f) + 0.5f);
	}

	public static Vector3 PFAONDFCNFD(PlayerController PKCHNBPBHFL)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = (Vector3)(PKCHNBPBHFL.characterAnimation.animator.GetInteger("Direction") switch
		{
			0 => ((Component)PKCHNBPBHFL).transform.position + Vector3.up * 3f, 
			1 => ((Component)PKCHNBPBHFL).transform.position + Vector3.up * -3f, 
			_ => (!(((Component)PKCHNBPBHFL.characterAnimation.characterAnimator).transform.lossyScale.x < 0f)) ? (((Component)PKCHNBPBHFL).transform.position + Vector3.right * 3f) : (((Component)PKCHNBPBHFL).transform.position + Vector3.right * -3f), 
		});
		if (PKCHNBPBHFL.LEOIMFNKFGA == Location.Beach)
		{
			val = Vector2.op_Implicit(WorldGrid.PCMIIFEGMHJ(val));
		}
		if (WorldGrid.APKPGNDDJHC(val))
		{
			return val;
		}
		if (WorldGrid.APKPGNDDJHC(((Component)PKCHNBPBHFL).transform.position))
		{
			return ((Component)PKCHNBPBHFL).transform.position;
		}
		return KGEOMOKKFKP(PKCHNBPBHFL.GetPlayerNum(), 1);
	}

	public static string NLFBNICLPDN(string GEGDHHIDEEF)
	{
		if (string.IsNullOrEmpty(GEGDHHIDEEF) || GEGDHHIDEEF.Length == 0)
		{
			return "a";
		}
		if (BKKHLMBNJGD.Contains(GEGDHHIDEEF[0]))
		{
			return "an";
		}
		return "a";
	}

	public static void NEIBBLNKEMC()
	{
		MDBAIEDPBJN = AKDEMLPGIPH();
	}

	public static void IACLKEGBBKL<T>(ref T[] FNEHIAGFAOF, IComparer<T> HNOBKMEKEKM)
	{
		int num = FNEHIAGFAOF.Length;
		for (int i = 1; i < num; i++)
		{
			T val = FNEHIAGFAOF[i];
			int num2 = i - 1;
			while (num2 >= 0 && HNOBKMEKEKM.Compare(FNEHIAGFAOF[num2], val) == 1)
			{
				FNEHIAGFAOF[num2 + 1] = FNEHIAGFAOF[num2];
				num2--;
			}
			FNEHIAGFAOF[num2 + 1] = val;
		}
	}

	public static bool GFELJCLKKMC(this GroundType AODONKKHPBP, GroundType AKPKDELPEHN)
	{
		return (AODONKKHPBP & AKPKDELPEHN) != 0;
	}

	public static string BHDDKJHDLBO()
	{
		if (EGIBECKKIJJ())
		{
			NCLIENJDJMG = DDKAKILPDBP - DateTime.UtcNow;
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("TimeLeft"), NCLIENJDJMG.Days + LocalisationSystem.Get("dForDays") + " : " + NCLIENJDJMG.Hours + LocalisationSystem.Get("hForHours"));
		}
		return "00" + LocalisationSystem.Get("dForDays") + " : 00" + LocalisationSystem.Get("hForHours");
	}

	public static List<Vector3> HOLJIOOEJDJ(Vector3 OOJOENIKJPH, Vector3 LFDNMOLFKJK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		int num = (int)((LFDNMOLFKJK - OOJOENIKJPH).x / 0.5f);
		int num2 = (int)((LFDNMOLFKJK - OOJOENIKJPH).y / 0.5f);
		List<Vector3> list = new List<Vector3>();
		Vector3 item = default(Vector3);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				((Vector3)(ref item))._002Ector((float)i, (float)j);
				list.Add(item);
			}
		}
		return list;
	}

	public static bool FNNJEGLDGKC(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		GFBDMNKHKKF = WorldGrid.AGKGGAFFFGM(IMOBLFMHKOD);
		return FNNJEGLDGKC(IMOBLFMHKOD, GFBDMNKHKKF);
	}

	public static IEnumerator OBCEOGNEFPD(Sprite[] DAIPKNMKFFN, SpriteRenderer PJMCHPFEOOA, float EPLACMFEGGH)
	{
		for (int i = DAIPKNMKFFN.Length - 2; i >= 0; i--)
		{
			yield return (object)new WaitForSeconds(EPLACMFEGGH);
			PJMCHPFEOOA.sprite = DAIPKNMKFFN[i];
		}
	}
}
