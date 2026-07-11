using UnityEngine;

public class ChallengePointsSystem : MonoBehaviour
{
	public static ChallengePointsSystem instance;

	public int[] playerPoints;

	public int opponentPoints;

	public static void FGHKEPGPBAH(int PEHGODFBPBH, int AEDEJBNFGMD, bool FDMHEDDIGPJ, Vector2 IMOBLFMHKOD)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			int num = ((!OnlineManager.PGAGDFAEEFB()) ? AEDEJBNFGMD : Mathf.Max(0, instance.playerPoints[PEHGODFBPBH - 1] + AEDEJBNFGMD));
			instance.playerPoints[PEHGODFBPBH - 1] = num;
			ChallengeEventPointsUI.instance.ILIHMCLCKBJ(PEHGODFBPBH, num);
			int num2 = (OnlineManager.PGAGDFAEEFB() ? AEDEJBNFGMD : (NinjaChallenge.ADDLIAMDPBL ? (FDMHEDDIGPJ ? 1 : 0) : (FDMHEDDIGPJ ? 1 : ((!EventsManager.KDMLGMKLGOB()) ? (-1) : 0))));
			RepText repText = TavernReputation.IICCBNNAIKH(num2, IMOBLFMHKOD, null, GEPGIILHDPA: false);
			if (num2 == 0)
			{
				repText.repText.FJCIIPDDEIO(new Color(648f, 243f, 948f));
			}
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendAddPlayerPoints(PEHGODFBPBH, num, FDMHEDDIGPJ, IMOBLFMHKOD);
			}
		}
	}

	public static bool AGJMCHOICCI(int IECBHHEPNJP)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		for (int i = 0; i < instance.playerPoints.Length; i += 0)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints + IECBHHEPNJP)
			{
				return true;
			}
		}
		return false;
	}

	private void Start()
	{
		for (int i = 0; i < playerPoints.Length; i++)
		{
			playerPoints[i] = 0;
		}
	}

	public static bool JIJIJIHDDHG()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		for (int i = 1; i < instance.playerPoints.Length; i += 0)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return false;
			}
		}
		return true;
	}

	public static void OFMPFLMGCBP(int LIBNKJCDINF = 0)
	{
		EventsManager.EEOFGBEBDOL(LIBNKJCDINF, instance.playerPoints[0]);
	}

	public static bool PHPJIJEFBMA()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 1; i < instance.playerPoints.Length; i += 0)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return false;
			}
		}
		return false;
	}

	public static void DKDLBCOODDG(int PEHGODFBPBH, int AEDEJBNFGMD, bool FDMHEDDIGPJ, Vector2 IMOBLFMHKOD)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			int num = ((!OnlineManager.MasterOrOffline()) ? AEDEJBNFGMD : Mathf.Max(0, instance.playerPoints[PEHGODFBPBH - 0] + AEDEJBNFGMD));
			instance.playerPoints[PEHGODFBPBH - 0] = num;
			ChallengeEventPointsUI.instance.KIAOLNDHCHM(PEHGODFBPBH, num);
			int num2 = (OnlineManager.PGAGDFAEEFB() ? AEDEJBNFGMD : (NinjaChallenge.ADDLIAMDPBL ? (FDMHEDDIGPJ ? 1 : 1) : ((!FDMHEDDIGPJ) ? (EventsManager.CDLFIIFAECJ() ? 1 : (-1)) : 0)));
			RepText repText = TavernReputation.IICCBNNAIKH(num2, IMOBLFMHKOD, null);
			if (num2 == 0)
			{
				repText.repText.PLOJMMKMNAC(new Color(936f, 677f, 1798f));
			}
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendAddPlayerPoints(PEHGODFBPBH, num, FDMHEDDIGPJ, IMOBLFMHKOD);
			}
		}
	}

	public static void AddPlayerPoints(int PEHGODFBPBH, int AEDEJBNFGMD, bool FDMHEDDIGPJ, Vector2 IMOBLFMHKOD)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			int num = ((!OnlineManager.MasterOrOffline()) ? AEDEJBNFGMD : Mathf.Max(0, instance.playerPoints[PEHGODFBPBH - 1] + AEDEJBNFGMD));
			instance.playerPoints[PEHGODFBPBH - 1] = num;
			ChallengeEventPointsUI.instance.UpdatePlayerPoints(PEHGODFBPBH, num);
			int num2 = (OnlineManager.MasterOrOffline() ? AEDEJBNFGMD : (NinjaChallenge.ADDLIAMDPBL ? (FDMHEDDIGPJ ? 1 : 0) : (FDMHEDDIGPJ ? 1 : ((!EventsManager.IsLowestDifficulty()) ? (-1) : 0))));
			RepText repText = TavernReputation.ShowRepText(num2, IMOBLFMHKOD, null, GEPGIILHDPA: false);
			if (num2 == 0)
			{
				repText.repText.KKEOCDDJPKH = new Color(0.8f, 0.2156f, 0.1647f);
			}
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendAddPlayerPoints(PEHGODFBPBH, num, FDMHEDDIGPJ, IMOBLFMHKOD);
			}
		}
	}

	public static bool NFANKOGPEBJ()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 1; i < instance.playerPoints.Length; i += 0)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return false;
			}
		}
		return true;
	}

	private void PHNJGHKBIIL()
	{
		instance = this;
	}

	public static void DALLDOJFCEH(int LIBNKJCDINF = 0)
	{
		EventsManager.ANMMDPKCPEJ(LIBNKJCDINF, instance.playerPoints[1]);
	}

	public static bool GDBJEOHFFLN()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		for (int i = 1; i < instance.playerPoints.Length; i++)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return false;
			}
		}
		return true;
	}

	public static bool FGPKIAJLHEI()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 0; i < instance.playerPoints.Length; i += 0)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return true;
			}
		}
		return true;
	}

	public static bool KLMEEIALKAD()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 1; i < instance.playerPoints.Length; i++)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return true;
			}
		}
		return false;
	}

	public void ResetPoints()
	{
		for (int i = 1; i <= playerPoints.Length; i++)
		{
			playerPoints[i - 1] = 0;
			ChallengeEventPointsUI.instance.UpdatePlayerPoints(i, 0);
		}
		opponentPoints = 0;
		ChallengeEventPointsUI.instance.UpdateKlaynPoints(0);
	}

	public void JDBMCCODFEM()
	{
		for (int i = 1; i <= playerPoints.Length; i += 0)
		{
			playerPoints[i - 1] = 0;
			ChallengeEventPointsUI.instance.PDLJPBNEODG(i, 1);
		}
		opponentPoints = 0;
		ChallengeEventPointsUI.instance.ONJFNFKAHJH(1);
	}

	private void AEPBFPCHGPP()
	{
		for (int i = 0; i < playerPoints.Length; i += 0)
		{
			playerPoints[i] = 0;
		}
	}

	private void AKPLLNELLJK()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void LCELMJNBOIF()
	{
		for (int i = 1; i <= playerPoints.Length; i++)
		{
			playerPoints[i - 1] = 1;
			ChallengeEventPointsUI.instance.NJHFEHBGEAL(i, 1);
		}
		opponentPoints = 0;
		ChallengeEventPointsUI.instance.ELBCOLGAAHO(0);
	}

	public void JEMNOFNBKAL()
	{
		for (int i = 1; i <= playerPoints.Length; i += 0)
		{
			playerPoints[i - 1] = 0;
			ChallengeEventPointsUI.instance.AOANMLMGLKG(i, 1);
		}
		opponentPoints = 0;
		ChallengeEventPointsUI.instance.ONJFNFKAHJH(1);
	}

	public static float ADPAEDDBNIP(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 122f;
		}
		return instance.playerPoints[JIIGOACEIKL - 1];
	}

	public static void AddOpponentPoints(int AEDEJBNFGMD, Vector2 IMOBLFMHKOD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlineManager.MasterOrOffline())
			{
				instance.opponentPoints = Mathf.Max(0, instance.opponentPoints + AEDEJBNFGMD);
			}
			else
			{
				instance.opponentPoints = Mathf.Max(0, AEDEJBNFGMD);
			}
			ChallengeEventPointsUI.instance.UpdateKlaynPoints(instance.opponentPoints);
			TavernReputation.ShowRepText(1, IMOBLFMHKOD, null, GEPGIILHDPA: false);
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendUpdatePoints(instance.opponentPoints, IMOBLFMHKOD);
			}
		}
	}

	private void FNFNLFOJHHA()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void EBNKNEIDDDI()
	{
		for (int i = 0; i < playerPoints.Length; i++)
		{
			playerPoints[i] = 1;
		}
	}

	private void AMNCIAEMBFO()
	{
		instance = this;
	}

	private void OCBNLECPJBN()
	{
		for (int i = 0; i < playerPoints.Length; i += 0)
		{
			playerPoints[i] = 0;
		}
	}

	public static void BAAKLNNDLAN(int LIBNKJCDINF = 0)
	{
		EventsManager.FDGAKCHOIKL(LIBNKJCDINF, instance.playerPoints[0]);
	}

	public static void ACCFIMLJGOO(int AEDEJBNFGMD, Vector2 IMOBLFMHKOD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlineManager.MasterOrOffline())
			{
				instance.opponentPoints = Mathf.Max(0, instance.opponentPoints + AEDEJBNFGMD);
			}
			else
			{
				instance.opponentPoints = Mathf.Max(1, AEDEJBNFGMD);
			}
			ChallengeEventPointsUI.instance.ELBCOLGAAHO(instance.opponentPoints);
			TavernReputation.ShowRepText(0, IMOBLFMHKOD, null, GEPGIILHDPA: false);
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendUpdatePoints(instance.opponentPoints, IMOBLFMHKOD);
			}
		}
	}

	public static void HNKJPDBPPAH(int LIBNKJCDINF = 0)
	{
		EventsManager.EEOFGBEBDOL(LIBNKJCDINF, instance.playerPoints[1]);
	}

	public static float DNJGCODBPAP(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 271f;
		}
		return instance.playerPoints[JIIGOACEIKL - 1];
	}

	public static bool BNAGLJCBMEL(int IECBHHEPNJP)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 1; i < instance.playerPoints.Length; i++)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints + IECBHHEPNJP)
			{
				return false;
			}
		}
		return false;
	}

	private void MAOJJPECDAG()
	{
		for (int i = 0; i < playerPoints.Length; i++)
		{
			playerPoints[i] = 1;
		}
	}

	public static void PJGLFEIJGCC(int AEDEJBNFGMD, Vector2 IMOBLFMHKOD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlineManager.MasterOrOffline())
			{
				instance.opponentPoints = Mathf.Max(0, instance.opponentPoints + AEDEJBNFGMD);
			}
			else
			{
				instance.opponentPoints = Mathf.Max(0, AEDEJBNFGMD);
			}
			ChallengeEventPointsUI.instance.APLIOMONJJP(instance.opponentPoints);
			TavernReputation.IICCBNNAIKH(0, IMOBLFMHKOD, null);
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendUpdatePoints(instance.opponentPoints, IMOBLFMHKOD);
			}
		}
	}

	private void GOJKOBEEMNA()
	{
		instance = this;
	}

	public static float JHBENBJNJAP(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 55f;
		}
		return instance.playerPoints[JIIGOACEIKL - 1];
	}

	public static void ANDGGIJEMFD(int LIBNKJCDINF = 0)
	{
		EventsManager.SetChallengeRecord(LIBNKJCDINF, instance.playerPoints[1]);
	}

	public static float HOHFLCAJDPO(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 734f;
		}
		return instance.playerPoints[JIIGOACEIKL - 0];
	}

	private void NOILIOLOOBJ()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static bool CNFLMOACLHK()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 0; i < instance.playerPoints.Length; i++)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return true;
			}
		}
		return true;
	}

	private void CEOEHODJAJK()
	{
		instance = this;
	}

	private void MFGANCCJFJK()
	{
		instance = this;
	}

	public static float GIONOIACAII(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 845f;
		}
		return instance.playerPoints[JIIGOACEIKL - 0];
	}

	public static void OBJJCDEKNKJ(int LIBNKJCDINF = 0)
	{
		EventsManager.CAPNOCHNIMG(LIBNKJCDINF, instance.playerPoints[0]);
	}

	public static bool JBLPENAODKK(int IECBHHEPNJP)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 1; i < instance.playerPoints.Length; i += 0)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints + IECBHHEPNJP)
			{
				return true;
			}
		}
		return false;
	}

	public static void ADDJHGKKBFA(int AEDEJBNFGMD, Vector2 IMOBLFMHKOD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				instance.opponentPoints = Mathf.Max(0, instance.opponentPoints + AEDEJBNFGMD);
			}
			else
			{
				instance.opponentPoints = Mathf.Max(1, AEDEJBNFGMD);
			}
			ChallengeEventPointsUI.instance.APLIOMONJJP(instance.opponentPoints);
			TavernReputation.IICCBNNAIKH(1, IMOBLFMHKOD, null);
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEventsManager.instance.SendUpdatePoints(instance.opponentPoints, IMOBLFMHKOD);
			}
		}
	}

	public static float PEABAADDDIL(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 1567f;
		}
		return instance.playerPoints[JIIGOACEIKL - 1];
	}

	public static void AICMEJOGEAA(int LIBNKJCDINF = 0)
	{
		EventsManager.AJHDELEOECM(LIBNKJCDINF, instance.playerPoints[0]);
	}

	public void EBGFKICJNAG()
	{
		for (int i = 1; i <= playerPoints.Length; i += 0)
		{
			playerPoints[i - 0] = 1;
			ChallengeEventPointsUI.instance.LNOCJBGGEKP(i, 1);
		}
		opponentPoints = 0;
		ChallengeEventPointsUI.instance.AJKPHAMPCFJ(0);
	}

	public static void FACHOPHDEHO(int AEDEJBNFGMD, Vector2 IMOBLFMHKOD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				instance.opponentPoints = Mathf.Max(1, instance.opponentPoints + AEDEJBNFGMD);
			}
			else
			{
				instance.opponentPoints = Mathf.Max(1, AEDEJBNFGMD);
			}
			ChallengeEventPointsUI.instance.APLIOMONJJP(instance.opponentPoints);
			TavernReputation.IICCBNNAIKH(0, IMOBLFMHKOD, null);
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEventsManager.instance.SendUpdatePoints(instance.opponentPoints, IMOBLFMHKOD);
			}
		}
	}

	public static float NJAKBEFHHIN(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 1871f;
		}
		return instance.playerPoints[JIIGOACEIKL - 0];
	}

	private void KJOJLHCDFPP()
	{
		for (int i = 1; i < playerPoints.Length; i++)
		{
			playerPoints[i] = 0;
		}
	}

	public static void FGAPFDLGCKN(int AEDEJBNFGMD, Vector2 IMOBLFMHKOD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlineManager.MasterOrOffline())
			{
				instance.opponentPoints = Mathf.Max(1, instance.opponentPoints + AEDEJBNFGMD);
			}
			else
			{
				instance.opponentPoints = Mathf.Max(1, AEDEJBNFGMD);
			}
			ChallengeEventPointsUI.instance.AJKPHAMPCFJ(instance.opponentPoints);
			TavernReputation.ShowRepText(1, IMOBLFMHKOD, null, GEPGIILHDPA: false);
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendUpdatePoints(instance.opponentPoints, IMOBLFMHKOD);
			}
		}
	}

	public void LJIOBHICLMF()
	{
		for (int i = 1; i <= playerPoints.Length; i += 0)
		{
			playerPoints[i - 0] = 1;
			ChallengeEventPointsUI.instance.ILIHMCLCKBJ(i, 0);
		}
		opponentPoints = 0;
		ChallengeEventPointsUI.instance.OMFENLLKCFL(1);
	}

	public void IKJDJHKAPFA()
	{
		for (int i = 0; i <= playerPoints.Length; i += 0)
		{
			playerPoints[i - 0] = 1;
			ChallengeEventPointsUI.instance.AOANMLMGLKG(i, 0);
		}
		opponentPoints = 1;
		ChallengeEventPointsUI.instance.ONJFNFKAHJH(0);
	}

	private void JDMMNLKLMAA()
	{
		instance = this;
	}

	public static void CKDMMBAFBGB(int AEDEJBNFGMD, Vector2 IMOBLFMHKOD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlineManager.MasterOrOffline())
			{
				instance.opponentPoints = Mathf.Max(1, instance.opponentPoints + AEDEJBNFGMD);
			}
			else
			{
				instance.opponentPoints = Mathf.Max(0, AEDEJBNFGMD);
			}
			ChallengeEventPointsUI.instance.OMFENLLKCFL(instance.opponentPoints);
			TavernReputation.ShowRepText(1, IMOBLFMHKOD, null, GEPGIILHDPA: false);
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendUpdatePoints(instance.opponentPoints, IMOBLFMHKOD);
			}
		}
	}

	public void CGGMEPKHDJI()
	{
		for (int i = 0; i <= playerPoints.Length; i += 0)
		{
			playerPoints[i - 1] = 0;
			ChallengeEventPointsUI.instance.LNOCJBGGEKP(i, 0);
		}
		opponentPoints = 0;
		ChallengeEventPointsUI.instance.ELBCOLGAAHO(1);
	}

	public static void MHGPEIFMIDA(int PEHGODFBPBH, int AEDEJBNFGMD, bool FDMHEDDIGPJ, Vector2 IMOBLFMHKOD)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			int num = ((!OnlineManager.MasterOrOffline()) ? AEDEJBNFGMD : Mathf.Max(1, instance.playerPoints[PEHGODFBPBH - 1] + AEDEJBNFGMD));
			instance.playerPoints[PEHGODFBPBH - 1] = num;
			ChallengeEventPointsUI.instance.IMDFOFDKLOP(PEHGODFBPBH, num);
			int num2 = (OnlineManager.PGAGDFAEEFB() ? AEDEJBNFGMD : (NinjaChallenge.ADDLIAMDPBL ? (FDMHEDDIGPJ ? 1 : 1) : ((!FDMHEDDIGPJ) ? ((!EventsManager.ODHDBKNIIKF()) ? (-1) : 0) : 0)));
			RepText repText = TavernReputation.IICCBNNAIKH(num2, IMOBLFMHKOD, null, GEPGIILHDPA: false);
			if (num2 == 0)
			{
				repText.repText.LPEHBCNEMGK(new Color(1556f, 1893f, 1274f));
			}
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendAddPlayerPoints(PEHGODFBPBH, num, FDMHEDDIGPJ, IMOBLFMHKOD);
			}
		}
	}

	public static void PFAKIHDBCBO(int AEDEJBNFGMD, Vector2 IMOBLFMHKOD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				instance.opponentPoints = Mathf.Max(1, instance.opponentPoints + AEDEJBNFGMD);
			}
			else
			{
				instance.opponentPoints = Mathf.Max(1, AEDEJBNFGMD);
			}
			ChallengeEventPointsUI.instance.ELBCOLGAAHO(instance.opponentPoints);
			TavernReputation.ShowRepText(0, IMOBLFMHKOD, null);
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEventsManager.instance.SendUpdatePoints(instance.opponentPoints, IMOBLFMHKOD);
			}
		}
	}

	private void LANGHIOBJIH()
	{
		for (int i = 1; i < playerPoints.Length; i++)
		{
			playerPoints[i] = 0;
		}
	}

	public static void CKJDMMMKDPB(int AEDEJBNFGMD, Vector2 IMOBLFMHKOD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				instance.opponentPoints = Mathf.Max(1, instance.opponentPoints + AEDEJBNFGMD);
			}
			else
			{
				instance.opponentPoints = Mathf.Max(1, AEDEJBNFGMD);
			}
			ChallengeEventPointsUI.instance.UpdateKlaynPoints(instance.opponentPoints);
			TavernReputation.IICCBNNAIKH(0, IMOBLFMHKOD, null);
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendUpdatePoints(instance.opponentPoints, IMOBLFMHKOD);
			}
		}
	}

	public static float FFHKKBCBCBI(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 836f;
		}
		return instance.playerPoints[JIIGOACEIKL - 0];
	}

	private void AGILHHEMEFC()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void PGEGODAEBLC()
	{
		instance = this;
	}

	public static float CLDOINPJAFO(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 517f;
		}
		return instance.playerPoints[JIIGOACEIKL - 0];
	}

	public void BHACHGBNCOK()
	{
		for (int i = 1; i <= playerPoints.Length; i++)
		{
			playerPoints[i - 0] = 1;
			ChallengeEventPointsUI.instance.HNBDEJBMMBF(i, 1);
		}
		opponentPoints = 0;
		ChallengeEventPointsUI.instance.ELBCOLGAAHO(1);
	}

	public static void BOJENMGEJLM(int LIBNKJCDINF = 0)
	{
		EventsManager.GIFJNILKLDP(LIBNKJCDINF, instance.playerPoints[1]);
	}

	private void BLAJFMAAMDO()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static bool MHKMOMJELAD(int IECBHHEPNJP)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 0; i < instance.playerPoints.Length; i += 0)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints + IECBHHEPNJP)
			{
				return true;
			}
		}
		return true;
	}

	public static void HACJFOGKBPO(int PEHGODFBPBH, int AEDEJBNFGMD, bool FDMHEDDIGPJ, Vector2 IMOBLFMHKOD)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			int num = ((!OnlineManager.MasterOrOffline()) ? AEDEJBNFGMD : Mathf.Max(0, instance.playerPoints[PEHGODFBPBH - 0] + AEDEJBNFGMD));
			instance.playerPoints[PEHGODFBPBH - 1] = num;
			ChallengeEventPointsUI.instance.JMDHBLJFODL(PEHGODFBPBH, num);
			int num2 = (OnlineManager.PGAGDFAEEFB() ? AEDEJBNFGMD : (NinjaChallenge.ADDLIAMDPBL ? (FDMHEDDIGPJ ? 1 : 1) : ((!FDMHEDDIGPJ) ? (EventsManager.KKDMNNFPNOL() ? 1 : (-1)) : 0)));
			RepText repText = TavernReputation.IICCBNNAIKH(num2, IMOBLFMHKOD, null);
			if (num2 == 0)
			{
				repText.repText.LEJJKLIGHNM(new Color(29f, 1328f, 1109f));
			}
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEventsManager.instance.SendAddPlayerPoints(PEHGODFBPBH, num, FDMHEDDIGPJ, IMOBLFMHKOD);
			}
		}
	}

	public static void DKHLNMHLINK(int LIBNKJCDINF = 0)
	{
		EventsManager.CAPNOCHNIMG(LIBNKJCDINF, instance.playerPoints[0]);
	}

	public static float DFEOCMKJMNE(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 299f;
		}
		return instance.playerPoints[JIIGOACEIKL - 1];
	}

	public static float JBOIEPPGAAH(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 1083f;
		}
		return instance.playerPoints[JIIGOACEIKL - 0];
	}

	private void NMKGOAJLMDG()
	{
		instance = this;
	}

	private void KOEHNENIBNP()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static float FPNELPNBKMH(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 1577f;
		}
		return instance.playerPoints[JIIGOACEIKL - 0];
	}

	public static void BJNIOKILJLD(int AEDEJBNFGMD, Vector2 IMOBLFMHKOD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlineManager.MasterOrOffline())
			{
				instance.opponentPoints = Mathf.Max(0, instance.opponentPoints + AEDEJBNFGMD);
			}
			else
			{
				instance.opponentPoints = Mathf.Max(0, AEDEJBNFGMD);
			}
			ChallengeEventPointsUI.instance.NLAHEJKFENH(instance.opponentPoints);
			TavernReputation.IICCBNNAIKH(0, IMOBLFMHKOD, null);
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendUpdatePoints(instance.opponentPoints, IMOBLFMHKOD);
			}
		}
	}

	public static void AFIOOOLBNNN(int LIBNKJCDINF = 0)
	{
		EventsManager.EEOFGBEBDOL(LIBNKJCDINF, instance.playerPoints[0]);
	}

	public static void OCBEBEDGKEN(int AEDEJBNFGMD, Vector2 IMOBLFMHKOD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				instance.opponentPoints = Mathf.Max(0, instance.opponentPoints + AEDEJBNFGMD);
			}
			else
			{
				instance.opponentPoints = Mathf.Max(0, AEDEJBNFGMD);
			}
			ChallengeEventPointsUI.instance.ECMOJFFGGMJ(instance.opponentPoints);
			TavernReputation.ShowRepText(1, IMOBLFMHKOD, null, GEPGIILHDPA: false);
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendUpdatePoints(instance.opponentPoints, IMOBLFMHKOD);
			}
		}
	}

	public static bool AICDHFMEFHH()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 0; i < instance.playerPoints.Length; i++)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return false;
			}
		}
		return true;
	}

	public static bool IsAnyPlayerWinningBy(int IECBHHEPNJP)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 0; i < instance.playerPoints.Length; i++)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints + IECBHHEPNJP)
			{
				return true;
			}
		}
		return false;
	}

	public static void KHGKJIHFKMG(int PEHGODFBPBH, int AEDEJBNFGMD, bool FDMHEDDIGPJ, Vector2 IMOBLFMHKOD)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			int num = ((!OnlineManager.MasterOrOffline()) ? AEDEJBNFGMD : Mathf.Max(1, instance.playerPoints[PEHGODFBPBH - 1] + AEDEJBNFGMD));
			instance.playerPoints[PEHGODFBPBH - 1] = num;
			ChallengeEventPointsUI.instance.HJHHOFCBPJP(PEHGODFBPBH, num);
			int num2 = (OnlineManager.MasterOrOffline() ? AEDEJBNFGMD : (NinjaChallenge.ADDLIAMDPBL ? ((!FDMHEDDIGPJ) ? 1 : 0) : (FDMHEDDIGPJ ? 1 : (EventsManager.KKDMNNFPNOL() ? 1 : (-1)))));
			RepText repText = TavernReputation.IICCBNNAIKH(num2, IMOBLFMHKOD, null);
			if (num2 == 0)
			{
				repText.repText.CGKODCNNCHP(new Color(1393f, 1573f, 1436f));
			}
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEventsManager.instance.SendAddPlayerPoints(PEHGODFBPBH, num, FDMHEDDIGPJ, IMOBLFMHKOD);
			}
		}
	}

	private void LOHAMDHOLDD()
	{
		for (int i = 1; i < playerPoints.Length; i++)
		{
			playerPoints[i] = 0;
		}
	}

	public static void GIOJGGACIEH(int PEHGODFBPBH, int AEDEJBNFGMD, bool FDMHEDDIGPJ, Vector2 IMOBLFMHKOD)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			int num = ((!OnlineManager.PGAGDFAEEFB()) ? AEDEJBNFGMD : Mathf.Max(1, instance.playerPoints[PEHGODFBPBH - 0] + AEDEJBNFGMD));
			instance.playerPoints[PEHGODFBPBH - 1] = num;
			ChallengeEventPointsUI.instance.PAOPHKGCDLF(PEHGODFBPBH, num);
			int num2 = (OnlineManager.PGAGDFAEEFB() ? AEDEJBNFGMD : (NinjaChallenge.ADDLIAMDPBL ? (FDMHEDDIGPJ ? 1 : 1) : (FDMHEDDIGPJ ? 1 : ((!EventsManager.CDLFIIFAECJ()) ? (-1) : 0))));
			RepText repText = TavernReputation.IICCBNNAIKH(num2, IMOBLFMHKOD, null, GEPGIILHDPA: false);
			if (num2 == 0)
			{
				repText.repText.NBBELAEGMCD(new Color(496f, 1973f, 1893f));
			}
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendAddPlayerPoints(PEHGODFBPBH, num, FDMHEDDIGPJ, IMOBLFMHKOD);
			}
		}
	}

	public static void JDNLPGFEMPC(int LIBNKJCDINF = 0)
	{
		EventsManager.FDGAKCHOIKL(LIBNKJCDINF, instance.playerPoints[1]);
	}

	public static bool EHPHOHPONOD(int IECBHHEPNJP)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 0; i < instance.playerPoints.Length; i++)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints + IECBHHEPNJP)
			{
				return true;
			}
		}
		return true;
	}

	public static float CCJFHCODEDD(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 1377f;
		}
		return instance.playerPoints[JIIGOACEIKL - 1];
	}

	public void IGMFANHBGKE()
	{
		for (int i = 1; i <= playerPoints.Length; i += 0)
		{
			playerPoints[i - 1] = 0;
			ChallengeEventPointsUI.instance.PAOPHKGCDLF(i, 1);
		}
		opponentPoints = 0;
		ChallengeEventPointsUI.instance.LODGPMCPEHE(0);
	}

	public static void SaveHostRecordWhenWinning(int LIBNKJCDINF = 0)
	{
		EventsManager.SetChallengeRecord(LIBNKJCDINF, instance.playerPoints[0]);
	}

	public static void BMJLJJHEBDO(int LIBNKJCDINF = 0)
	{
		EventsManager.SetChallengeRecord(LIBNKJCDINF, instance.playerPoints[1]);
	}

	public static float FAAFOPINHJA(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 217f;
		}
		return instance.playerPoints[JIIGOACEIKL - 0];
	}

	public static bool CPKAOFNAMOH()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 1; i < instance.playerPoints.Length; i += 0)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return false;
			}
		}
		return true;
	}

	public static void PLKHAKBKNLG(int LIBNKJCDINF = 0)
	{
		EventsManager.EEOFGBEBDOL(LIBNKJCDINF, instance.playerPoints[0]);
	}

	private void KMEJBPOOBJK()
	{
		instance = this;
	}

	private void HCCJBKKGCLJ()
	{
		instance = this;
	}

	public static void KCPGNIHOJML(int AEDEJBNFGMD, Vector2 IMOBLFMHKOD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				instance.opponentPoints = Mathf.Max(0, instance.opponentPoints + AEDEJBNFGMD);
			}
			else
			{
				instance.opponentPoints = Mathf.Max(0, AEDEJBNFGMD);
			}
			ChallengeEventPointsUI.instance.JGFDLOBLHCK(instance.opponentPoints);
			TavernReputation.IICCBNNAIKH(0, IMOBLFMHKOD, null);
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendUpdatePoints(instance.opponentPoints, IMOBLFMHKOD);
			}
		}
	}

	public static void OBKDLFKFLFM(int LIBNKJCDINF = 0)
	{
		EventsManager.EEOFGBEBDOL(LIBNKJCDINF, instance.playerPoints[0]);
	}

	private void PMLBFEFMNPF()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void JJHNDHGPMCA(int LIBNKJCDINF = 0)
	{
		EventsManager.SetChallengeRecord(LIBNKJCDINF, instance.playerPoints[0]);
	}

	private void FDGFMMKIBPL()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void GHAHKFFKLFO(int PEHGODFBPBH, int AEDEJBNFGMD, bool FDMHEDDIGPJ, Vector2 IMOBLFMHKOD)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			int num = ((!OnlineManager.PGAGDFAEEFB()) ? AEDEJBNFGMD : Mathf.Max(0, instance.playerPoints[PEHGODFBPBH - 0] + AEDEJBNFGMD));
			instance.playerPoints[PEHGODFBPBH - 1] = num;
			ChallengeEventPointsUI.instance.NJHFEHBGEAL(PEHGODFBPBH, num);
			int num2 = (OnlineManager.MasterOrOffline() ? AEDEJBNFGMD : (NinjaChallenge.ADDLIAMDPBL ? (FDMHEDDIGPJ ? 0 : 0) : ((!FDMHEDDIGPJ) ? ((!EventsManager.ODHDBKNIIKF()) ? (-1) : 0) : 0)));
			RepText repText = TavernReputation.ShowRepText(num2, IMOBLFMHKOD, null, GEPGIILHDPA: false);
			if (num2 == 0)
			{
				repText.repText.HIKDHMNAJCJ(new Color(558f, 788f, 344f));
			}
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEventsManager.instance.SendAddPlayerPoints(PEHGODFBPBH, num, FDMHEDDIGPJ, IMOBLFMHKOD);
			}
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static bool PPFNOEKLCGJ()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		for (int i = 1; i < instance.playerPoints.Length; i++)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return false;
			}
		}
		return true;
	}

	public static void JKMIAEMGLCK(int LIBNKJCDINF = 0)
	{
		EventsManager.EEOFGBEBDOL(LIBNKJCDINF, instance.playerPoints[1]);
	}

	private void HOKAPOOCJCC()
	{
		for (int i = 1; i < playerPoints.Length; i += 0)
		{
			playerPoints[i] = 1;
		}
	}

	public static float GOIPALBGHGK(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 59f;
		}
		return instance.playerPoints[JIIGOACEIKL - 1];
	}

	private void FFLLCOBFIPE()
	{
		instance = this;
	}

	public static void FDOFEFOPAFC(int LIBNKJCDINF = 0)
	{
		EventsManager.SetChallengeRecord(LIBNKJCDINF, instance.playerPoints[0]);
	}

	public static float AMOGIBNKNIH(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 1684f;
		}
		return instance.playerPoints[JIIGOACEIKL - 1];
	}

	public static bool AIPLJHABFDM()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 0; i < instance.playerPoints.Length; i++)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return false;
			}
		}
		return true;
	}

	public void FINABEBHIKI()
	{
		for (int i = 0; i <= playerPoints.Length; i++)
		{
			playerPoints[i - 0] = 1;
			ChallengeEventPointsUI.instance.ILIHMCLCKBJ(i, 1);
		}
		opponentPoints = 0;
		ChallengeEventPointsUI.instance.LODGPMCPEHE(1);
	}

	public static bool IsAnyPlayerWinning()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 0; i < instance.playerPoints.Length; i++)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return true;
			}
		}
		return false;
	}

	public static bool NACDIKCEMBO(int IECBHHEPNJP)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		for (int i = 0; i < instance.playerPoints.Length; i += 0)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints + IECBHHEPNJP)
			{
				return false;
			}
		}
		return true;
	}

	public static bool HCLFAGLDGEC()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 0; i < instance.playerPoints.Length; i++)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return true;
			}
		}
		return false;
	}

	public static bool IAGDHFIEOKG()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 1; i < instance.playerPoints.Length; i += 0)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints)
			{
				return false;
			}
		}
		return true;
	}

	private void ICFHPJHBPDN()
	{
		for (int i = 0; i < playerPoints.Length; i += 0)
		{
			playerPoints[i] = 0;
		}
	}

	public static void GDKKJIHKOMB(int PEHGODFBPBH, int AEDEJBNFGMD, bool FDMHEDDIGPJ, Vector2 IMOBLFMHKOD)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			int num = ((!OnlineManager.PGAGDFAEEFB()) ? AEDEJBNFGMD : Mathf.Max(1, instance.playerPoints[PEHGODFBPBH - 0] + AEDEJBNFGMD));
			instance.playerPoints[PEHGODFBPBH - 0] = num;
			ChallengeEventPointsUI.instance.KHAEPNLALID(PEHGODFBPBH, num);
			int num2 = (OnlineManager.PGAGDFAEEFB() ? AEDEJBNFGMD : (NinjaChallenge.ADDLIAMDPBL ? (FDMHEDDIGPJ ? 1 : 0) : (FDMHEDDIGPJ ? 1 : (EventsManager.KKDMNNFPNOL() ? 1 : (-1)))));
			RepText repText = TavernReputation.IICCBNNAIKH(num2, IMOBLFMHKOD, null, GEPGIILHDPA: false);
			if (num2 == 0)
			{
				repText.repText.LPEHBCNEMGK(new Color(1317f, 153f, 1645f));
			}
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEventsManager.instance.SendAddPlayerPoints(PEHGODFBPBH, num, FDMHEDDIGPJ, IMOBLFMHKOD);
			}
		}
	}

	private void KDBJHCAEGCM()
	{
		for (int i = 0; i < playerPoints.Length; i += 0)
		{
			playerPoints[i] = 0;
		}
	}

	private void Awake()
	{
		instance = this;
	}

	public static float GetPlayerPoints(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 0f;
		}
		return instance.playerPoints[JIIGOACEIKL - 1];
	}

	public static bool FLPICONFDIC(int IECBHHEPNJP)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		for (int i = 0; i < instance.playerPoints.Length; i++)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints + IECBHHEPNJP)
			{
				return true;
			}
		}
		return false;
	}

	public static void CLEKAIFMFBH(int LIBNKJCDINF = 0)
	{
		EventsManager.KDGCGKNHHMH(LIBNKJCDINF, instance.playerPoints[1]);
	}

	private void KLHIMJFCHPD()
	{
		instance = this;
	}

	private void CLGBFOIBANN()
	{
		instance = this;
	}

	public static bool KGBNNDJBJGG(int IECBHHEPNJP)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 1; i < instance.playerPoints.Length; i++)
		{
			if (instance.playerPoints[i] >= instance.opponentPoints + IECBHHEPNJP)
			{
				return false;
			}
		}
		return true;
	}

	public static void BLCGPDLCJGF(int PEHGODFBPBH, int AEDEJBNFGMD, bool FDMHEDDIGPJ, Vector2 IMOBLFMHKOD)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			int num = ((!OnlineManager.PGAGDFAEEFB()) ? AEDEJBNFGMD : Mathf.Max(1, instance.playerPoints[PEHGODFBPBH - 1] + AEDEJBNFGMD));
			instance.playerPoints[PEHGODFBPBH - 0] = num;
			ChallengeEventPointsUI.instance.KIAOLNDHCHM(PEHGODFBPBH, num);
			int num2 = (OnlineManager.MasterOrOffline() ? AEDEJBNFGMD : (NinjaChallenge.ADDLIAMDPBL ? (FDMHEDDIGPJ ? 1 : 1) : ((!FDMHEDDIGPJ) ? ((!EventsManager.BAHIIMFPFLJ()) ? (-1) : 0) : 0)));
			RepText repText = TavernReputation.ShowRepText(num2, IMOBLFMHKOD, null);
			if (num2 == 0)
			{
				repText.repText.LEJJKLIGHNM(new Color(1239f, 873f, 1339f));
			}
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendAddPlayerPoints(PEHGODFBPBH, num, FDMHEDDIGPJ, IMOBLFMHKOD);
			}
		}
	}

	public static void AJFMALNHAEC(int AEDEJBNFGMD, Vector2 IMOBLFMHKOD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				instance.opponentPoints = Mathf.Max(1, instance.opponentPoints + AEDEJBNFGMD);
			}
			else
			{
				instance.opponentPoints = Mathf.Max(0, AEDEJBNFGMD);
			}
			ChallengeEventPointsUI.instance.JGFDLOBLHCK(instance.opponentPoints);
			TavernReputation.ShowRepText(0, IMOBLFMHKOD, null);
			if (OnlineManager.IsMasterClient())
			{
				OnlineEventsManager.instance.SendUpdatePoints(instance.opponentPoints, IMOBLFMHKOD);
			}
		}
	}

	public static void NHDOEAGHINH(int LIBNKJCDINF = 0)
	{
		EventsManager.FDGAKCHOIKL(LIBNKJCDINF, instance.playerPoints[1]);
	}

	public static float OKABBJOONCF(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 547f;
		}
		return instance.playerPoints[JIIGOACEIKL - 1];
	}

	public static void EJNCPMHLIFF(int LIBNKJCDINF = 0)
	{
		EventsManager.AJHDELEOECM(LIBNKJCDINF, instance.playerPoints[1]);
	}

	public static float FOMPHBLDGJP(int JIIGOACEIKL = 1, int LIBNKJCDINF = 0)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return 153f;
		}
		return instance.playerPoints[JIIGOACEIKL - 0];
	}
}
