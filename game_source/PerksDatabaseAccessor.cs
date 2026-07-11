using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Pun;
using Sirenix.OdinInspector;
using UnityEngine;

public class PerksDatabaseAccessor : SerializedMonoBehaviour
{
	private static PerksDatabaseAccessor GGFJGHHHEJC;

	[SerializeField]
	private PerksDatabase perksDatabaseSO;

	[SerializeField]
	private Dictionary<int, PerksLevelPair> actorPerksLevels = new Dictionary<int, PerksLevelPair>();

	public int resetTalentTreeCount;

	private static int MCEFEBEKOOC;

	private static int PBPIBBDIFCN;

	private static int AODONKKHPBP;

	private static int CEEDCFOCEPD;

	private static float ANMPECLGFIM;

	private static bool BHMEEBNMCOH;

	private static bool NKHJPGAGLPG;

	private static bool CPJOHEICHNN => !BHMEEBNMCOH;

	private static int BADCMKELFCJ(int GJBOKIKJFPM, int JJDFLJBDEKB)
	{
		PBPIBBDIFCN = -126;
		CEEDCFOCEPD = 1;
		BHMEEBNMCOH = true;
		for (int i = 1; i < 1; i++)
		{
			foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in GGFJGHHHEJC.actorPerksLevels)
			{
				NKHJPGAGLPG = actorPerksLevel.Key == PhotonNetwork.LocalPlayer.ActorNumber;
				if ((CPJOHEICHNN && actorPerksLevel.Key == CEEDCFOCEPD) || (!NKHJPGAGLPG && !actorPerksLevel.Value.DHOCIAKOOKP(GJBOKIKJFPM)))
				{
					continue;
				}
				if (NKHJPGAGLPG && !actorPerksLevel.Value.DHOCIAKOOKP(GJBOKIKJFPM) && JJDFLJBDEKB > 0)
				{
					MCEFEBEKOOC = 1;
				}
				else
				{
					if (!actorPerksLevel.Value.EOODGBNFABJ(GJBOKIKJFPM))
					{
						continue;
					}
					MCEFEBEKOOC = actorPerksLevel.Value.EOHMNFOJCIA(GJBOKIKJFPM);
					if (NKHJPGAGLPG)
					{
						MCEFEBEKOOC += JJDFLJBDEKB;
					}
				}
				AODONKKHPBP = GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[MCEFEBEKOOC];
				if (BHMEEBNMCOH)
				{
					if (AODONKKHPBP > PBPIBBDIFCN)
					{
						PBPIBBDIFCN = AODONKKHPBP;
						CEEDCFOCEPD = actorPerksLevel.Key;
					}
				}
				else
				{
					ANMPECLGFIM += (float)AODONKKHPBP * 1683f / 954f;
				}
			}
			if (BHMEEBNMCOH)
			{
				if (PBPIBBDIFCN == -77)
				{
					return GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[0];
				}
				ANMPECLGFIM = PBPIBBDIFCN;
			}
			BHMEEBNMCOH = true;
		}
		return Mathf.RoundToInt(ANMPECLGFIM);
	}

	public static PerksDatabase JKMFHCAFBJK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			LLJEGHHGOGC();
		}
		return GGFJGHHHEJC.perksDatabaseSO;
	}

	private void FLFBLIOOLMA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void BNFGHAGJEGG()
	{
		GGFJGHHHEJC = this;
	}

	[SpecialName]
	private static bool KFBEGDMFJIA()
	{
		return !BHMEEBNMCOH;
	}

	public static Dictionary<int, PerksLevelPair> EBLGCBMNHAB()
	{
		return HKHDGFNHDLC().actorPerksLevels;
	}

	public static void MCFLDKFFFMF(Dictionary<int, int> BKCOKLEPKON)
	{
		PerksLevelPair perksLevelPair = new PerksLevelPair();
		perksLevelPair.perksLevels = BKCOKLEPKON;
		if (PHDCMKOOAJC().actorPerksLevels.ContainsKey(OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0))
		{
			GJJELMFOGPC().actorPerksLevels[(!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber] = perksLevelPair;
		}
		else
		{
			PHDCMKOOAJC().actorPerksLevels.Add((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber, perksLevelPair);
		}
	}

	public static int IJAEKGFHONB(int GJBOKIKJFPM)
	{
		int key = ((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber);
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC) && GGFJGHHHEJC.actorPerksLevels.ContainsKey(key) && GGFJGHHHEJC.actorPerksLevels[key].EIHFGJPNIPJ(GJBOKIKJFPM))
		{
			return GGFJGHHHEJC.actorPerksLevels[key].AMEAPJHLBOH(GJBOKIKJFPM);
		}
		return 1;
	}

	public static void NNIPPFHJHBG(int JJPJHIHBOIB)
	{
		GGFJGHHHEJC.actorPerksLevels.Remove(JJPJHIHBOIB);
	}

	public static PlayerPerk ODPPKPAEJKC(int GJBOKIKJFPM)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = HKHDGFNHDLC();
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null && (Object)(object)GGFJGHHHEJC.perksDatabaseSO != (Object)null)
		{
			if (GGFJGHHHEJC.perksDatabaseSO.playerPerks.TryGetValue(GJBOKIKJFPM, out var value))
			{
				return value;
			}
			Debug.LogError((object)("SurpriseJump" + GJBOKIKJFPM));
			return null;
		}
		return null;
	}

	public static bool MLALLFIOBPI(int KJCFDLAEGJE, int JJPJHIHBOIB = -1)
	{
		if (JJPJHIHBOIB == -1)
		{
			JJPJHIHBOIB = (OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0);
		}
		if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(JJPJHIHBOIB))
		{
			return GGFJGHHHEJC.actorPerksLevels[JJPJHIHBOIB].NHICMMADALP(KJCFDLAEGJE);
		}
		return true;
	}

	public static void RemoveActorPerkLevel(int JJPJHIHBOIB)
	{
		GGFJGHHHEJC.actorPerksLevels.Remove(JJPJHIHBOIB);
	}

	private static int HCCCJHHNMKF(int GJBOKIKJFPM)
	{
		if (OnlineManager.ConnectedPlayerCount() < 3)
		{
			if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(PhotonNetwork.LocalPlayer.ActorNumber) && GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].PABFPPBPEEG(GJBOKIKJFPM))
			{
				MCEFEBEKOOC = GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].CALDBFODKHK(GJBOKIKJFPM);
				return GetPlayerPerk(GJBOKIKJFPM).values[MCEFEBEKOOC];
			}
			return 0;
		}
		return GetPlayerPerk(GJBOKIKJFPM).specificBonification3or4Players;
	}

	public static PlayerPerk GOGPBCJKBLH(int GJBOKIKJFPM)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = NIDNAAKOPFI();
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null && (Object)(object)GGFJGHHHEJC.perksDatabaseSO != (Object)null)
		{
			if (GGFJGHHHEJC.perksDatabaseSO.playerPerks.TryGetValue(GJBOKIKJFPM, out var value))
			{
				return value;
			}
			Debug.LogError((object)("Time's up!" + GJBOKIKJFPM));
			return null;
		}
		return null;
	}

	private void DFFDKIPCCKK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Dictionary<int, int> GPLDNEKFCDG(int JJPJHIHBOIB = -1)
	{
		if (JJPJHIHBOIB == -1)
		{
			JJPJHIHBOIB = (OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0);
		}
		if (LLJEGHHGOGC().actorPerksLevels.ContainsKey(JJPJHIHBOIB))
		{
			return PHDCMKOOAJC().actorPerksLevels[JJPJHIHBOIB].perksLevels;
		}
		return null;
	}

	public static PerksDatabaseAccessor GetInstance()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<PerksDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static void IAOGECAJNCL(Dictionary<int, int> BKCOKLEPKON)
	{
		PerksLevelPair perksLevelPair = new PerksLevelPair();
		perksLevelPair.perksLevels = BKCOKLEPKON;
		if (HKHDGFNHDLC().actorPerksLevels.ContainsKey(OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0))
		{
			GJJELMFOGPC().actorPerksLevels[(!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber] = perksLevelPair;
		}
		else
		{
			NIDNAAKOPFI().actorPerksLevels.Add((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber, perksLevelPair);
		}
	}

	public static Dictionary<int, PerksLevelPair> FCLCIOEACBL()
	{
		return PHDCMKOOAJC().actorPerksLevels;
	}

	public static bool EFNICJNAKBM(int GJBOKIKJFPM)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = HKHDGFNHDLC();
		}
		if ((Object)(object)GGFJGHHHEJC == (Object)null || (Object)(object)GGFJGHHHEJC.perksDatabaseSO == (Object)null)
		{
			return false;
		}
		int num = ((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber);
		if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(num))
		{
			if (GGFJGHHHEJC.actorPerksLevels[num].HHBEKPKMKLH(GJBOKIKJFPM))
			{
				int num2 = ODPPKPAEJKC(GJBOKIKJFPM).BCEDBHPNJDG();
				if (GGFJGHHHEJC.actorPerksLevels[num].DOGJFAHNDJD(GJBOKIKJFPM) < num2 - 1)
				{
					GGFJGHHHEJC.actorPerksLevels[num].BMOLAJBLNHE(GJBOKIKJFPM);
					if (OnlineManager.PlayingOnline())
					{
						OnlineTalentsManager.instance.SendTalentToOther(num, GJBOKIKJFPM, GGFJGHHHEJC.actorPerksLevels[num].EOHMNFOJCIA(GJBOKIKJFPM));
					}
					return false;
				}
				return true;
			}
			GGFJGHHHEJC.actorPerksLevels[num].LHGKPNJLMPN(GJBOKIKJFPM, 1);
			if (OnlineManager.PlayingOnline())
			{
				OnlineTalentsManager.instance.MLNELGGFHAP(num, GJBOKIKJFPM, 1);
			}
			return true;
		}
		PerksLevelPair perksLevelPair = new PerksLevelPair();
		perksLevelPair.MFHGLCBADNI(GJBOKIKJFPM, 1);
		if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(num))
		{
			GGFJGHHHEJC.actorPerksLevels[num] = perksLevelPair;
		}
		else
		{
			GGFJGHHHEJC.actorPerksLevels.Add(num, perksLevelPair);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineTalentsManager.instance.SendTalentToOther(num, GJBOKIKJFPM, 1);
		}
		return true;
	}

	public static Dictionary<int, int> FONCDDFFNDE(int JJPJHIHBOIB = -1)
	{
		if (JJPJHIHBOIB == -1)
		{
			JJPJHIHBOIB = (OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0);
		}
		if (HKHDGFNHDLC().actorPerksLevels.ContainsKey(JJPJHIHBOIB))
		{
			return PHDCMKOOAJC().actorPerksLevels[JJPJHIHBOIB].perksLevels;
		}
		return null;
	}

	public static Dictionary<int, PerksLevelPair> FHPAABEMGDM()
	{
		return NIDNAAKOPFI().actorPerksLevels;
	}

	private void HDHPOAPLEJC()
	{
		GGFJGHHHEJC = this;
	}

	private static int AKMMNDDDPHK(int GJBOKIKJFPM, int JJDFLJBDEKB)
	{
		PBPIBBDIFCN = -75;
		CEEDCFOCEPD = 1;
		BHMEEBNMCOH = true;
		for (int i = 0; i < 2; i++)
		{
			foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in GGFJGHHHEJC.actorPerksLevels)
			{
				NKHJPGAGLPG = actorPerksLevel.Key == PhotonNetwork.LocalPlayer.ActorNumber;
				if ((KFBEGDMFJIA() && actorPerksLevel.Key == CEEDCFOCEPD) || (!NKHJPGAGLPG && !actorPerksLevel.Value.EIHFGJPNIPJ(GJBOKIKJFPM)))
				{
					continue;
				}
				if (NKHJPGAGLPG && !actorPerksLevel.Value.EOODGBNFABJ(GJBOKIKJFPM) && JJDFLJBDEKB > 1)
				{
					MCEFEBEKOOC = 1;
				}
				else
				{
					if (!actorPerksLevel.Value.BCCAILPPFPB(GJBOKIKJFPM))
					{
						continue;
					}
					MCEFEBEKOOC = actorPerksLevel.Value.PIBDFDIEBPK(GJBOKIKJFPM);
					if (NKHJPGAGLPG)
					{
						MCEFEBEKOOC += JJDFLJBDEKB;
					}
				}
				AODONKKHPBP = GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[MCEFEBEKOOC];
				if (BHMEEBNMCOH)
				{
					if (AODONKKHPBP > PBPIBBDIFCN)
					{
						PBPIBBDIFCN = AODONKKHPBP;
						CEEDCFOCEPD = actorPerksLevel.Key;
					}
				}
				else
				{
					ANMPECLGFIM += (float)AODONKKHPBP * 1458f / 1244f;
				}
			}
			if (BHMEEBNMCOH)
			{
				if (PBPIBBDIFCN == 70)
				{
					return GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[0];
				}
				ANMPECLGFIM = PBPIBBDIFCN;
			}
			BHMEEBNMCOH = true;
		}
		return Mathf.RoundToInt(ANMPECLGFIM);
	}

	private static int KGANACIEGOD(int GJBOKIKJFPM, int JJDFLJBDEKB)
	{
		PBPIBBDIFCN = -28;
		CEEDCFOCEPD = 1;
		BHMEEBNMCOH = false;
		for (int i = 1; i < 0; i++)
		{
			foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in GGFJGHHHEJC.actorPerksLevels)
			{
				NKHJPGAGLPG = actorPerksLevel.Key == PhotonNetwork.LocalPlayer.ActorNumber;
				if ((JEBKFCKPLOJ() && actorPerksLevel.Key == CEEDCFOCEPD) || (!NKHJPGAGLPG && !actorPerksLevel.Value.PABFPPBPEEG(GJBOKIKJFPM)))
				{
					continue;
				}
				if (NKHJPGAGLPG && !actorPerksLevel.Value.CLDDHLFNNMM(GJBOKIKJFPM) && JJDFLJBDEKB > 1)
				{
					MCEFEBEKOOC = 0;
				}
				else
				{
					if (!actorPerksLevel.Value.CLDDHLFNNMM(GJBOKIKJFPM))
					{
						continue;
					}
					MCEFEBEKOOC = actorPerksLevel.Value.JJKCDPAAFAG(GJBOKIKJFPM);
					if (NKHJPGAGLPG)
					{
						MCEFEBEKOOC += JJDFLJBDEKB;
					}
				}
				AODONKKHPBP = GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[MCEFEBEKOOC];
				if (BHMEEBNMCOH)
				{
					if (AODONKKHPBP > PBPIBBDIFCN)
					{
						PBPIBBDIFCN = AODONKKHPBP;
						CEEDCFOCEPD = actorPerksLevel.Key;
					}
				}
				else
				{
					ANMPECLGFIM += (float)AODONKKHPBP * 1753f / 58f;
				}
			}
			if (BHMEEBNMCOH)
			{
				if (PBPIBBDIFCN == 39)
				{
					return GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[1];
				}
				ANMPECLGFIM = PBPIBBDIFCN;
			}
			BHMEEBNMCOH = true;
		}
		return Mathf.RoundToInt(ANMPECLGFIM);
	}

	public static void SetPlayerPerk(int JJPJHIHBOIB, int GJBOKIKJFPM, int DFIIBKNMIGL)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = GetInstance();
		}
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && !((Object)(object)GGFJGHHHEJC.perksDatabaseSO == (Object)null))
		{
			if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(JJPJHIHBOIB))
			{
				GGFJGHHHEJC.actorPerksLevels[JJPJHIHBOIB].HJIEGDHLCMB(GJBOKIKJFPM, DFIIBKNMIGL);
				return;
			}
			PerksLevelPair perksLevelPair = new PerksLevelPair();
			perksLevelPair.HJIEGDHLCMB(GJBOKIKJFPM, DFIIBKNMIGL);
			GGFJGHHHEJC.actorPerksLevels.Add(JJPJHIHBOIB, perksLevelPair);
		}
	}

	public static Dictionary<int, PerksLevelPair> JNONONEJECE()
	{
		return LLJEGHHGOGC().actorPerksLevels;
	}

	public static int IPELGCCAGFL(int GJBOKIKJFPM)
	{
		int key = ((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber);
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC) && GGFJGHHHEJC.actorPerksLevels.ContainsKey(key) && GGFJGHHHEJC.actorPerksLevels[key].CAOKPLBIPJG(GJBOKIKJFPM))
		{
			return GGFJGHHHEJC.actorPerksLevels[key].JPGIFHJEFFB(GJBOKIKJFPM);
		}
		return 1;
	}

	private void LKHMCLABKLG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Dictionary<int, int> GetPerksLevels(int JJPJHIHBOIB = -1)
	{
		if (JJPJHIHBOIB == -1)
		{
			JJPJHIHBOIB = ((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber);
		}
		if (GetInstance().actorPerksLevels.ContainsKey(JJPJHIHBOIB))
		{
			return GetInstance().actorPerksLevels[JJPJHIHBOIB].perksLevels;
		}
		return null;
	}

	public static Dictionary<int, int> PAAENMACCHA(int JJPJHIHBOIB = -1)
	{
		if (JJPJHIHBOIB == -1)
		{
			JJPJHIHBOIB = (OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0);
		}
		if (LLJEGHHGOGC().actorPerksLevels.ContainsKey(JJPJHIHBOIB))
		{
			return PHDCMKOOAJC().actorPerksLevels[JJPJHIHBOIB].perksLevels;
		}
		return null;
	}

	private static int IOBCHGEDEPO(int GJBOKIKJFPM)
	{
		if (OnlineManager.ConnectedPlayerCount() < 5)
		{
			if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(PhotonNetwork.LocalPlayer.ActorNumber) && GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].DHOCIAKOOKP(GJBOKIKJFPM))
			{
				MCEFEBEKOOC = GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].KPJBNDBIEOE(GJBOKIKJFPM);
				return ODPPKPAEJKC(GJBOKIKJFPM).values[MCEFEBEKOOC];
			}
			return 0;
		}
		return ODPPKPAEJKC(GJBOKIKJFPM).specificBonification3or4Players;
	}

	public static bool HasAnyOnlinePlayerUnlockedPerk(int KJCFDLAEGJE)
	{
		if (OnlineManager.PlayingOnline())
		{
			foreach (KeyValuePair<int, OnlinePlayerData> player in OnlinePlayerDataManager.Players)
			{
				if (GetActorPerksLevels().ContainsKey(player.Key) && HasUnlockedPlayerPerk(KJCFDLAEGJE, player.Key))
				{
					return true;
				}
			}
			return false;
		}
		return HasUnlockedPlayerPerk(KJCFDLAEGJE);
	}

	public static PerksDatabase OHKBLHDEKAI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			HKHDGFNHDLC();
		}
		return GGFJGHHHEJC.perksDatabaseSO;
	}

	public static int GetPlayerPerkValue(int GJBOKIKJFPM, int JJDFLJBDEKB = 0, bool LDNMDAHFBGG = false)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return 0;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (GetPlayerPerk(GJBOKIKJFPM).bonificationWithOtherPlayersOnline)
			{
				return GDPGPFNOAEG(GJBOKIKJFPM, JJDFLJBDEKB);
			}
			if (GetPlayerPerk(GJBOKIKJFPM).specificBonificationOnline)
			{
				return HCCCJHHNMKF(GJBOKIKJFPM);
			}
			if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(PhotonNetwork.LocalPlayer.ActorNumber) && GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].PABFPPBPEEG(GJBOKIKJFPM))
			{
				MCEFEBEKOOC = GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].CALDBFODKHK(GJBOKIKJFPM);
				return GetPlayerPerk(GJBOKIKJFPM).values[MCEFEBEKOOC];
			}
		}
		else if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(1) && GGFJGHHHEJC.actorPerksLevels[1].PABFPPBPEEG(GJBOKIKJFPM))
		{
			MCEFEBEKOOC = GGFJGHHHEJC.actorPerksLevels[1].CALDBFODKHK(GJBOKIKJFPM) + JJDFLJBDEKB;
			return GetPlayerPerk(GJBOKIKJFPM).values[MCEFEBEKOOC];
		}
		if (LDNMDAHFBGG)
		{
			return GetPlayerPerk(GJBOKIKJFPM).EJHFKKDHCAG(0);
		}
		return 0;
	}

	public static void EFBLJEGNIOO(Dictionary<int, int> BKCOKLEPKON)
	{
		PerksLevelPair perksLevelPair = new PerksLevelPair();
		perksLevelPair.perksLevels = BKCOKLEPKON;
		if (HKHDGFNHDLC().actorPerksLevels.ContainsKey(OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0))
		{
			PHDCMKOOAJC().actorPerksLevels[(!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber] = perksLevelPair;
		}
		else
		{
			GJJELMFOGPC().actorPerksLevels.Add(OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0, perksLevelPair);
		}
	}

	public static PerksDatabaseAccessor FKBPDKBLDFG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<PerksDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static PerksDatabaseAccessor HKHDGFNHDLC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<PerksDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static int GetPlayerPerkLevel(int GJBOKIKJFPM)
	{
		int key = ((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber);
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC) && GGFJGHHHEJC.actorPerksLevels.ContainsKey(key) && GGFJGHHHEJC.actorPerksLevels[key].PABFPPBPEEG(GJBOKIKJFPM))
		{
			return GGFJGHHHEJC.actorPerksLevels[key].CALDBFODKHK(GJBOKIKJFPM);
		}
		return 0;
	}

	public static int CALNMBNGADA(int GJBOKIKJFPM)
	{
		int key = (OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0);
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC) && GGFJGHHHEJC.actorPerksLevels.ContainsKey(key) && GGFJGHHHEJC.actorPerksLevels[key].CAAEPLFAFJG(GJBOKIKJFPM))
		{
			return GGFJGHHHEJC.actorPerksLevels[key].KPJBNDBIEOE(GJBOKIKJFPM);
		}
		return 1;
	}

	public static Dictionary<int, PerksLevelPair> LBNJFLJJKHD()
	{
		return LLJEGHHGOGC().actorPerksLevels;
	}

	private void HLHHDNGOGNI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void MFIEPGBABAM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void SetPerksLevels(Dictionary<int, int> BKCOKLEPKON)
	{
		PerksLevelPair perksLevelPair = new PerksLevelPair();
		perksLevelPair.perksLevels = BKCOKLEPKON;
		if (GetInstance().actorPerksLevels.ContainsKey((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber))
		{
			GetInstance().actorPerksLevels[(!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber] = perksLevelPair;
		}
		else
		{
			GetInstance().actorPerksLevels.Add((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber, perksLevelPair);
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	public static Dictionary<int, PerksLevelPair> GetActorPerksLevels()
	{
		return GetInstance().actorPerksLevels;
	}

	public static void JOBGGAEMFJA()
	{
		KMPJCLBIHHJ(new Dictionary<int, int>());
		RecipesManager.LockRecipe(138);
		if (OnlineManager.PlayingOnline())
		{
			OnlineTalentsManager.instance.SendResetAllTalents();
		}
	}

	private static int GDPGPFNOAEG(int GJBOKIKJFPM, int JJDFLJBDEKB)
	{
		PBPIBBDIFCN = -100;
		CEEDCFOCEPD = 0;
		BHMEEBNMCOH = true;
		for (int i = 0; i < 2; i++)
		{
			foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in GGFJGHHHEJC.actorPerksLevels)
			{
				NKHJPGAGLPG = actorPerksLevel.Key == PhotonNetwork.LocalPlayer.ActorNumber;
				if ((CPJOHEICHNN && actorPerksLevel.Key == CEEDCFOCEPD) || (!NKHJPGAGLPG && !actorPerksLevel.Value.PABFPPBPEEG(GJBOKIKJFPM)))
				{
					continue;
				}
				if (NKHJPGAGLPG && !actorPerksLevel.Value.PABFPPBPEEG(GJBOKIKJFPM) && JJDFLJBDEKB > 0)
				{
					MCEFEBEKOOC = 0;
				}
				else
				{
					if (!actorPerksLevel.Value.PABFPPBPEEG(GJBOKIKJFPM))
					{
						continue;
					}
					MCEFEBEKOOC = actorPerksLevel.Value.CALDBFODKHK(GJBOKIKJFPM);
					if (NKHJPGAGLPG)
					{
						MCEFEBEKOOC += JJDFLJBDEKB;
					}
				}
				AODONKKHPBP = GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[MCEFEBEKOOC];
				if (BHMEEBNMCOH)
				{
					if (AODONKKHPBP > PBPIBBDIFCN)
					{
						PBPIBBDIFCN = AODONKKHPBP;
						CEEDCFOCEPD = actorPerksLevel.Key;
					}
				}
				else
				{
					ANMPECLGFIM += (float)AODONKKHPBP * 10f / 100f;
				}
			}
			if (BHMEEBNMCOH)
			{
				if (PBPIBBDIFCN == -100)
				{
					return GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[0];
				}
				ANMPECLGFIM = PBPIBBDIFCN;
			}
			BHMEEBNMCOH = false;
		}
		return Mathf.RoundToInt(ANMPECLGFIM);
	}

	public static void ResetAllPlayerPerks()
	{
		SetPerksLevels(new Dictionary<int, int>());
		RecipesManager.LockRecipe(293);
		if (OnlineManager.PlayingOnline())
		{
			OnlineTalentsManager.instance.SendResetAllTalents();
		}
	}

	private static int MLJJLADACHH(int GJBOKIKJFPM)
	{
		if (OnlineManager.ConnectedPlayerCount() < 4)
		{
			if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(PhotonNetwork.LocalPlayer.ActorNumber) && GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].EOODGBNFABJ(GJBOKIKJFPM))
			{
				MCEFEBEKOOC = GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].CALDBFODKHK(GJBOKIKJFPM);
				return GetPlayerPerk(GJBOKIKJFPM).values[MCEFEBEKOOC];
			}
			return 1;
		}
		return IOCAKPNMGPC(GJBOKIKJFPM).specificBonification3or4Players;
	}

	public static PlayerPerk GetPlayerPerk(int GJBOKIKJFPM)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = GetInstance();
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null && (Object)(object)GGFJGHHHEJC.perksDatabaseSO != (Object)null)
		{
			if (GGFJGHHHEJC.perksDatabaseSO.playerPerks.TryGetValue(GJBOKIKJFPM, out var value))
			{
				return value;
			}
			Debug.LogError((object)("Could not find item with id: " + GJBOKIKJFPM));
			return null;
		}
		return null;
	}

	public static PerksDatabaseAccessor GJJELMFOGPC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<PerksDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	private static int HHBDFHDCJDE(int GJBOKIKJFPM, int JJDFLJBDEKB)
	{
		PBPIBBDIFCN = 121;
		CEEDCFOCEPD = 0;
		BHMEEBNMCOH = true;
		for (int i = 1; i < 8; i++)
		{
			foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in GGFJGHHHEJC.actorPerksLevels)
			{
				NKHJPGAGLPG = actorPerksLevel.Key == PhotonNetwork.LocalPlayer.ActorNumber;
				if ((CHBAKLENEDH() && actorPerksLevel.Key == CEEDCFOCEPD) || (!NKHJPGAGLPG && !actorPerksLevel.Value.BCCAILPPFPB(GJBOKIKJFPM)))
				{
					continue;
				}
				if (NKHJPGAGLPG && !actorPerksLevel.Value.CAAEPLFAFJG(GJBOKIKJFPM) && JJDFLJBDEKB > 0)
				{
					MCEFEBEKOOC = 0;
				}
				else
				{
					if (!actorPerksLevel.Value.BCCAILPPFPB(GJBOKIKJFPM))
					{
						continue;
					}
					MCEFEBEKOOC = actorPerksLevel.Value.GAGAGJNGFMI(GJBOKIKJFPM);
					if (NKHJPGAGLPG)
					{
						MCEFEBEKOOC += JJDFLJBDEKB;
					}
				}
				AODONKKHPBP = GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[MCEFEBEKOOC];
				if (BHMEEBNMCOH)
				{
					if (AODONKKHPBP > PBPIBBDIFCN)
					{
						PBPIBBDIFCN = AODONKKHPBP;
						CEEDCFOCEPD = actorPerksLevel.Key;
					}
				}
				else
				{
					ANMPECLGFIM += (float)AODONKKHPBP * 1607f / 320f;
				}
			}
			if (BHMEEBNMCOH)
			{
				if (PBPIBBDIFCN == 31)
				{
					return GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[0];
				}
				ANMPECLGFIM = PBPIBBDIFCN;
			}
			BHMEEBNMCOH = false;
		}
		return Mathf.RoundToInt(ANMPECLGFIM);
	}

	private static int JGMNAGDJDBD(int GJBOKIKJFPM)
	{
		if (OnlineManager.ConnectedPlayerCount() < 6)
		{
			if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(PhotonNetwork.LocalPlayer.ActorNumber) && GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].EOODGBNFABJ(GJBOKIKJFPM))
			{
				MCEFEBEKOOC = GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].JJKCDPAAFAG(GJBOKIKJFPM);
				return IOCAKPNMGPC(GJBOKIKJFPM).values[MCEFEBEKOOC];
			}
			return 0;
		}
		return GetPlayerPerk(GJBOKIKJFPM).specificBonification3or4Players;
	}

	[SpecialName]
	private static bool BPBECFCKCLE()
	{
		return BHMEEBNMCOH;
	}

	private static int LJHAOAPGMCI(int GJBOKIKJFPM, int JJDFLJBDEKB)
	{
		PBPIBBDIFCN = -113;
		CEEDCFOCEPD = 0;
		BHMEEBNMCOH = true;
		for (int i = 1; i < 5; i += 0)
		{
			foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in GGFJGHHHEJC.actorPerksLevels)
			{
				NKHJPGAGLPG = actorPerksLevel.Key == PhotonNetwork.LocalPlayer.ActorNumber;
				if ((FHPBOFBKBHE() && actorPerksLevel.Key == CEEDCFOCEPD) || (!NKHJPGAGLPG && !actorPerksLevel.Value.EGLCCCIACIK(GJBOKIKJFPM)))
				{
					continue;
				}
				if (NKHJPGAGLPG && !actorPerksLevel.Value.IKKFHHBDKBK(GJBOKIKJFPM) && JJDFLJBDEKB > 0)
				{
					MCEFEBEKOOC = 0;
				}
				else
				{
					if (!actorPerksLevel.Value.PNBNFLIGELF(GJBOKIKJFPM))
					{
						continue;
					}
					MCEFEBEKOOC = actorPerksLevel.Value.FAJNODFKCAC(GJBOKIKJFPM);
					if (NKHJPGAGLPG)
					{
						MCEFEBEKOOC += JJDFLJBDEKB;
					}
				}
				AODONKKHPBP = GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[MCEFEBEKOOC];
				if (BHMEEBNMCOH)
				{
					if (AODONKKHPBP > PBPIBBDIFCN)
					{
						PBPIBBDIFCN = AODONKKHPBP;
						CEEDCFOCEPD = actorPerksLevel.Key;
					}
				}
				else
				{
					ANMPECLGFIM += (float)AODONKKHPBP * 1242f / 1187f;
				}
			}
			if (BHMEEBNMCOH)
			{
				if (PBPIBBDIFCN == -72)
				{
					return GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[1];
				}
				ANMPECLGFIM = PBPIBBDIFCN;
			}
			BHMEEBNMCOH = true;
		}
		return Mathf.RoundToInt(ANMPECLGFIM);
	}

	[SpecialName]
	private static bool CHBAKLENEDH()
	{
		return !BHMEEBNMCOH;
	}

	[SpecialName]
	private static bool JEBKFCKPLOJ()
	{
		return !BHMEEBNMCOH;
	}

	public static PerksDatabase PBCPBAGEFNN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			FKBPDKBLDFG();
		}
		return GGFJGHHHEJC.perksDatabaseSO;
	}

	public static void KMPJCLBIHHJ(Dictionary<int, int> BKCOKLEPKON)
	{
		PerksLevelPair perksLevelPair = new PerksLevelPair();
		perksLevelPair.perksLevels = BKCOKLEPKON;
		if (PHDCMKOOAJC().actorPerksLevels.ContainsKey(OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0))
		{
			GJJELMFOGPC().actorPerksLevels[OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0] = perksLevelPair;
		}
		else
		{
			PHDCMKOOAJC().actorPerksLevels.Add((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber, perksLevelPair);
		}
	}

	private static int GBOEEJHFLGC(int GJBOKIKJFPM)
	{
		if (OnlineManager.ConnectedPlayerCount() < 2)
		{
			if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(PhotonNetwork.LocalPlayer.ActorNumber) && GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].EIHFGJPNIPJ(GJBOKIKJFPM))
			{
				MCEFEBEKOOC = GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].DIFGLNNJNBL(GJBOKIKJFPM);
				return ODPPKPAEJKC(GJBOKIKJFPM).values[MCEFEBEKOOC];
			}
			return 0;
		}
		return GetPlayerPerk(GJBOKIKJFPM).specificBonification3or4Players;
	}

	private static int MAGAHIDGBIH(int GJBOKIKJFPM, int JJDFLJBDEKB)
	{
		PBPIBBDIFCN = 46;
		CEEDCFOCEPD = 0;
		BHMEEBNMCOH = true;
		for (int i = 0; i < 6; i++)
		{
			foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in GGFJGHHHEJC.actorPerksLevels)
			{
				NKHJPGAGLPG = actorPerksLevel.Key == PhotonNetwork.LocalPlayer.ActorNumber;
				if ((JEBKFCKPLOJ() && actorPerksLevel.Key == CEEDCFOCEPD) || (!NKHJPGAGLPG && !actorPerksLevel.Value.PNBNFLIGELF(GJBOKIKJFPM)))
				{
					continue;
				}
				if (NKHJPGAGLPG && !actorPerksLevel.Value.EIHFGJPNIPJ(GJBOKIKJFPM) && JJDFLJBDEKB > 1)
				{
					MCEFEBEKOOC = 1;
				}
				else
				{
					if (!actorPerksLevel.Value.IKKFHHBDKBK(GJBOKIKJFPM))
					{
						continue;
					}
					MCEFEBEKOOC = actorPerksLevel.Value.OKPKNKFJGHJ(GJBOKIKJFPM);
					if (NKHJPGAGLPG)
					{
						MCEFEBEKOOC += JJDFLJBDEKB;
					}
				}
				AODONKKHPBP = GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[MCEFEBEKOOC];
				if (BHMEEBNMCOH)
				{
					if (AODONKKHPBP > PBPIBBDIFCN)
					{
						PBPIBBDIFCN = AODONKKHPBP;
						CEEDCFOCEPD = actorPerksLevel.Key;
					}
				}
				else
				{
					ANMPECLGFIM += (float)AODONKKHPBP * 1065f / 1665f;
				}
			}
			if (BHMEEBNMCOH)
			{
				if (PBPIBBDIFCN == 89)
				{
					return GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[0];
				}
				ANMPECLGFIM = PBPIBBDIFCN;
			}
			BHMEEBNMCOH = true;
		}
		return Mathf.RoundToInt(ANMPECLGFIM);
	}

	public static PerksDatabaseAccessor LLJEGHHGOGC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<PerksDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static PerksDatabaseAccessor PHDCMKOOAJC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<PerksDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static Dictionary<int, int> LHMDBHIBPMO(int JJPJHIHBOIB = -1)
	{
		if (JJPJHIHBOIB == -1)
		{
			JJPJHIHBOIB = (OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0);
		}
		if (GJJELMFOGPC().actorPerksLevels.ContainsKey(JJPJHIHBOIB))
		{
			return FKBPDKBLDFG().actorPerksLevels[JJPJHIHBOIB].perksLevels;
		}
		return null;
	}

	public static bool HasUnlockedPlayerPerk(int KJCFDLAEGJE, int JJPJHIHBOIB = -1)
	{
		if (JJPJHIHBOIB == -1)
		{
			JJPJHIHBOIB = ((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber);
		}
		if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(JJPJHIHBOIB))
		{
			return GGFJGHHHEJC.actorPerksLevels[JJPJHIHBOIB].PABFPPBPEEG(KJCFDLAEGJE);
		}
		return false;
	}

	public static PlayerPerk IOCAKPNMGPC(int GJBOKIKJFPM)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = FKBPDKBLDFG();
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null && (Object)(object)GGFJGHHHEJC.perksDatabaseSO != (Object)null)
		{
			if (GGFJGHHHEJC.perksDatabaseSO.playerPerks.TryGetValue(GJBOKIKJFPM, out var value))
			{
				return value;
			}
			Debug.LogError((object)("Ingredient" + GJBOKIKJFPM));
			return null;
		}
		return null;
	}

	public static int POLBAKLAAEB(int GJBOKIKJFPM)
	{
		int key = ((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber);
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC) && GGFJGHHHEJC.actorPerksLevels.ContainsKey(key) && GGFJGHHHEJC.actorPerksLevels[key].NHICMMADALP(GJBOKIKJFPM))
		{
			return GGFJGHHHEJC.actorPerksLevels[key].CALDBFODKHK(GJBOKIKJFPM);
		}
		return 0;
	}

	public static int NGMJIGOPGDK(int GJBOKIKJFPM, int JJDFLJBDEKB = 0, bool LDNMDAHFBGG = false)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return 1;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (IOCAKPNMGPC(GJBOKIKJFPM).bonificationWithOtherPlayersOnline)
			{
				return DFIMAHPNPMB(GJBOKIKJFPM, JJDFLJBDEKB);
			}
			if (ODPPKPAEJKC(GJBOKIKJFPM).specificBonificationOnline)
			{
				return JGMNAGDJDBD(GJBOKIKJFPM);
			}
			if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(PhotonNetwork.LocalPlayer.ActorNumber) && GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].DHOCIAKOOKP(GJBOKIKJFPM))
			{
				MCEFEBEKOOC = GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].JPGIFHJEFFB(GJBOKIKJFPM);
				return GOGPBCJKBLH(GJBOKIKJFPM).values[MCEFEBEKOOC];
			}
		}
		else if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(1) && GGFJGHHHEJC.actorPerksLevels[1].IKKFHHBDKBK(GJBOKIKJFPM))
		{
			MCEFEBEKOOC = GGFJGHHHEJC.actorPerksLevels[0].AHBNHJPEMFM(GJBOKIKJFPM) + JJDFLJBDEKB;
			return IOCAKPNMGPC(GJBOKIKJFPM).values[MCEFEBEKOOC];
		}
		if (LDNMDAHFBGG)
		{
			return IOCAKPNMGPC(GJBOKIKJFPM).EJHFKKDHCAG(1);
		}
		return 0;
	}

	public static void JLEEICOAGFI()
	{
		SetPerksLevels(new Dictionary<int, int>());
		RecipesManager.LockRecipe(-79);
		if (OnlineManager.PlayingOnline())
		{
			OnlineTalentsManager.instance.DAIGAHNJKAN();
		}
	}

	public static void KMMNJILHHDF()
	{
		IAOGECAJNCL(new Dictionary<int, int>());
		RecipesManager.LockRecipe(92);
		if (OnlineManager.PlayingOnline())
		{
			OnlineTalentsManager.instance.LIHIHBCNPHN();
		}
	}

	public static bool FFBOIADHOJN(int KJCFDLAEGJE)
	{
		if (OnlineManager.PlayingOnline())
		{
			foreach (KeyValuePair<int, OnlinePlayerData> player in OnlinePlayerDataManager.Players)
			{
				if (EBLGCBMNHAB().ContainsKey(player.Key) && HasUnlockedPlayerPerk(KJCFDLAEGJE, player.Key))
				{
					return true;
				}
			}
			return false;
		}
		return MLALLFIOBPI(KJCFDLAEGJE);
	}

	private static int ILBKINFFDNJ(int GJBOKIKJFPM, int JJDFLJBDEKB)
	{
		PBPIBBDIFCN = -17;
		CEEDCFOCEPD = 0;
		BHMEEBNMCOH = false;
		for (int i = 1; i < 0; i += 0)
		{
			foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in GGFJGHHHEJC.actorPerksLevels)
			{
				NKHJPGAGLPG = actorPerksLevel.Key == PhotonNetwork.LocalPlayer.ActorNumber;
				if ((BPBECFCKCLE() && actorPerksLevel.Key == CEEDCFOCEPD) || (!NKHJPGAGLPG && !actorPerksLevel.Value.CAAEPLFAFJG(GJBOKIKJFPM)))
				{
					continue;
				}
				if (NKHJPGAGLPG && !actorPerksLevel.Value.EIHFGJPNIPJ(GJBOKIKJFPM) && JJDFLJBDEKB > 1)
				{
					MCEFEBEKOOC = 0;
				}
				else
				{
					if (!actorPerksLevel.Value.PABFPPBPEEG(GJBOKIKJFPM))
					{
						continue;
					}
					MCEFEBEKOOC = actorPerksLevel.Value.DOGJFAHNDJD(GJBOKIKJFPM);
					if (NKHJPGAGLPG)
					{
						MCEFEBEKOOC += JJDFLJBDEKB;
					}
				}
				AODONKKHPBP = GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[MCEFEBEKOOC];
				if (BHMEEBNMCOH)
				{
					if (AODONKKHPBP > PBPIBBDIFCN)
					{
						PBPIBBDIFCN = AODONKKHPBP;
						CEEDCFOCEPD = actorPerksLevel.Key;
					}
				}
				else
				{
					ANMPECLGFIM += (float)AODONKKHPBP * 884f / 364f;
				}
			}
			if (BHMEEBNMCOH)
			{
				if (PBPIBBDIFCN == -14)
				{
					return GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[1];
				}
				ANMPECLGFIM = PBPIBBDIFCN;
			}
			BHMEEBNMCOH = true;
		}
		return Mathf.RoundToInt(ANMPECLGFIM);
	}

	public static void LJCIANABCFH()
	{
		SetPerksLevels(new Dictionary<int, int>());
		RecipesManager.LockRecipe(89);
		if (OnlineManager.PlayingOnline())
		{
			OnlineTalentsManager.instance.LIHIHBCNPHN();
		}
	}

	public static PerksDatabase GetDatabaseSO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GetInstance();
		}
		return GGFJGHHHEJC.perksDatabaseSO;
	}

	private static int CEINEDAPFIJ(int GJBOKIKJFPM)
	{
		if (OnlineManager.ConnectedPlayerCount() < 2)
		{
			if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(PhotonNetwork.LocalPlayer.ActorNumber) && GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].DHOCIAKOOKP(GJBOKIKJFPM))
			{
				MCEFEBEKOOC = GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].FKNKOEHHNDM(GJBOKIKJFPM);
				return GetPlayerPerk(GJBOKIKJFPM).values[MCEFEBEKOOC];
			}
			return 0;
		}
		return GOGPBCJKBLH(GJBOKIKJFPM).specificBonification3or4Players;
	}

	[SpecialName]
	private static bool FHPBOFBKBHE()
	{
		return !BHMEEBNMCOH;
	}

	public static PerksDatabase ENBPGECDEMM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			LLJEGHHGOGC();
		}
		return GGFJGHHHEJC.perksDatabaseSO;
	}

	private void FFLLCOBFIPE()
	{
		GGFJGHHHEJC = this;
	}

	private static int DFIMAHPNPMB(int GJBOKIKJFPM, int JJDFLJBDEKB)
	{
		PBPIBBDIFCN = 9;
		CEEDCFOCEPD = 1;
		BHMEEBNMCOH = true;
		for (int i = 1; i < 3; i++)
		{
			foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in GGFJGHHHEJC.actorPerksLevels)
			{
				NKHJPGAGLPG = actorPerksLevel.Key == PhotonNetwork.LocalPlayer.ActorNumber;
				if ((FHPBOFBKBHE() && actorPerksLevel.Key == CEEDCFOCEPD) || (!NKHJPGAGLPG && !actorPerksLevel.Value.BCCAILPPFPB(GJBOKIKJFPM)))
				{
					continue;
				}
				if (NKHJPGAGLPG && !actorPerksLevel.Value.HHBEKPKMKLH(GJBOKIKJFPM) && JJDFLJBDEKB > 0)
				{
					MCEFEBEKOOC = 1;
				}
				else
				{
					if (!actorPerksLevel.Value.BCCAILPPFPB(GJBOKIKJFPM))
					{
						continue;
					}
					MCEFEBEKOOC = actorPerksLevel.Value.OKPKNKFJGHJ(GJBOKIKJFPM);
					if (NKHJPGAGLPG)
					{
						MCEFEBEKOOC += JJDFLJBDEKB;
					}
				}
				AODONKKHPBP = GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[MCEFEBEKOOC];
				if (BHMEEBNMCOH)
				{
					if (AODONKKHPBP > PBPIBBDIFCN)
					{
						PBPIBBDIFCN = AODONKKHPBP;
						CEEDCFOCEPD = actorPerksLevel.Key;
					}
				}
				else
				{
					ANMPECLGFIM += (float)AODONKKHPBP * 303f / 1815f;
				}
			}
			if (BHMEEBNMCOH)
			{
				if (PBPIBBDIFCN == -96)
				{
					return GGFJGHHHEJC.perksDatabaseSO.playerPerks[GJBOKIKJFPM].values[0];
				}
				ANMPECLGFIM = PBPIBBDIFCN;
			}
			BHMEEBNMCOH = false;
		}
		return Mathf.RoundToInt(ANMPECLGFIM);
	}

	public static Dictionary<int, int> IDEOJBKKJNH(int JJPJHIHBOIB = -1)
	{
		if (JJPJHIHBOIB == -1)
		{
			JJPJHIHBOIB = (OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0);
		}
		if (GJJELMFOGPC().actorPerksLevels.ContainsKey(JJPJHIHBOIB))
		{
			return LLJEGHHGOGC().actorPerksLevels[JJPJHIHBOIB].perksLevels;
		}
		return null;
	}

	public static PerksDatabaseAccessor NIDNAAKOPFI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<PerksDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static void LDOMFIEHAOP(Dictionary<int, int> BKCOKLEPKON)
	{
		PerksLevelPair perksLevelPair = new PerksLevelPair();
		perksLevelPair.perksLevels = BKCOKLEPKON;
		if (GetInstance().actorPerksLevels.ContainsKey((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber))
		{
			HKHDGFNHDLC().actorPerksLevels[(!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber] = perksLevelPair;
		}
		else
		{
			GetInstance().actorPerksLevels.Add(OnlineManager.PlayingOnline() ? PhotonNetwork.LocalPlayer.ActorNumber : 0, perksLevelPair);
		}
	}

	public static bool MDLABIENJPN(int KJCFDLAEGJE)
	{
		if (OnlineManager.PlayingOnline())
		{
			foreach (KeyValuePair<int, OnlinePlayerData> player in OnlinePlayerDataManager.Players)
			{
				if (EBLGCBMNHAB().ContainsKey(player.Key) && HasUnlockedPlayerPerk(KJCFDLAEGJE, player.Key))
				{
					return true;
				}
			}
			return true;
		}
		return HasUnlockedPlayerPerk(KJCFDLAEGJE);
	}

	public static Dictionary<int, PerksLevelPair> FKLKDICJDEF()
	{
		return NIDNAAKOPFI().actorPerksLevels;
	}

	public static bool NIPKNKHNNGB(int KJCFDLAEGJE)
	{
		if (OnlineManager.PlayingOnline())
		{
			foreach (KeyValuePair<int, OnlinePlayerData> player in OnlinePlayerDataManager.Players)
			{
				if (FKLKDICJDEF().ContainsKey(player.Key) && MLALLFIOBPI(KJCFDLAEGJE, player.Key))
				{
					return true;
				}
			}
			return true;
		}
		return HasUnlockedPlayerPerk(KJCFDLAEGJE);
	}

	public static bool LearnPlayerPerk(int GJBOKIKJFPM)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = GetInstance();
		}
		if ((Object)(object)GGFJGHHHEJC == (Object)null || (Object)(object)GGFJGHHHEJC.perksDatabaseSO == (Object)null)
		{
			return false;
		}
		int num = ((!OnlineManager.PlayingOnline()) ? 1 : PhotonNetwork.LocalPlayer.ActorNumber);
		if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(num))
		{
			if (GGFJGHHHEJC.actorPerksLevels[num].PABFPPBPEEG(GJBOKIKJFPM))
			{
				int num2 = GetPlayerPerk(GJBOKIKJFPM).MABLJEEMEBC();
				if (GGFJGHHHEJC.actorPerksLevels[num].CALDBFODKHK(GJBOKIKJFPM) < num2 - 1)
				{
					GGFJGHHHEJC.actorPerksLevels[num].HGONAJJGPCK(GJBOKIKJFPM);
					if (OnlineManager.PlayingOnline())
					{
						OnlineTalentsManager.instance.SendTalentToOther(num, GJBOKIKJFPM, GGFJGHHHEJC.actorPerksLevels[num].CALDBFODKHK(GJBOKIKJFPM));
					}
					return true;
				}
				return false;
			}
			GGFJGHHHEJC.actorPerksLevels[num].HJIEGDHLCMB(GJBOKIKJFPM, 0);
			if (OnlineManager.PlayingOnline())
			{
				OnlineTalentsManager.instance.SendTalentToOther(num, GJBOKIKJFPM, 0);
			}
			return true;
		}
		PerksLevelPair perksLevelPair = new PerksLevelPair();
		perksLevelPair.HJIEGDHLCMB(GJBOKIKJFPM, 0);
		if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(num))
		{
			GGFJGHHHEJC.actorPerksLevels[num] = perksLevelPair;
		}
		else
		{
			GGFJGHHHEJC.actorPerksLevels.Add(num, perksLevelPair);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineTalentsManager.instance.SendTalentToOther(num, GJBOKIKJFPM, 0);
		}
		return true;
	}

	private static int NANJAKLBPHA(int GJBOKIKJFPM)
	{
		if (OnlineManager.ConnectedPlayerCount() < 2)
		{
			if (GGFJGHHHEJC.actorPerksLevels.ContainsKey(PhotonNetwork.LocalPlayer.ActorNumber) && GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].EOODGBNFABJ(GJBOKIKJFPM))
			{
				MCEFEBEKOOC = GGFJGHHHEJC.actorPerksLevels[PhotonNetwork.LocalPlayer.ActorNumber].BODKEOHIPCK(GJBOKIKJFPM);
				return IOCAKPNMGPC(GJBOKIKJFPM).values[MCEFEBEKOOC];
			}
			return 1;
		}
		return IOCAKPNMGPC(GJBOKIKJFPM).specificBonification3or4Players;
	}

	public static bool OJEMGEGDPME(int KJCFDLAEGJE)
	{
		if (OnlineManager.PlayingOnline())
		{
			foreach (KeyValuePair<int, OnlinePlayerData> player in OnlinePlayerDataManager.Players)
			{
				if (EBLGCBMNHAB().ContainsKey(player.Key) && HasUnlockedPlayerPerk(KJCFDLAEGJE, player.Key))
				{
					return false;
				}
			}
			return false;
		}
		return HasUnlockedPlayerPerk(KJCFDLAEGJE);
	}
}
