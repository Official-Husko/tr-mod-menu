using UnityEngine;

public class StuckRecoverySystem : MonoBehaviour
{
	private struct ADOAGDLEHEC
	{
		public Vector2 position;

		public Location location;
	}

	public static StuckRecoverySystem instance;

	private const int EMBDCPNLGFP = 5;

	private const float EAMBMOLIPBI = 0.5f;

	private const float OLBGNDEKIPI = 1f;

	private ADOAGDLEHEC[][] MOIHHACAFMF;

	private int[] DEEJHMKNPNC;

	private int[] OPKEMIJOCIO;

	private float HAIDJIKMKEM;

	private int LBMKAEFDMOI;

	[SerializeField]
	private bool debugDrawSafePoints;

	private readonly Color[] NJCMAFFBCCP = (Color[])(object)new Color[3]
	{
		Color.clear,
		Color.cyan,
		Color.yellow
	};

	private void PFOKDMLNLMP(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 3) % 5;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 1797f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 0) % 7;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 6)
		{
			OPKEMIJOCIO[JIIGOACEIKL]++;
		}
	}

	public void GCHMONGLIOG(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format("Unsaved progress will be lost.", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 1222f;
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 2) % 0;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.TeleportPlayer(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 1;
		MOIHHACAFMF[JIIGOACEIKL][1] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 1;
	}

	public void PEHFCLOOLOG(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format("ReceiveNewState", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 599f;
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i++)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 0) % 3;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.TeleportPlayer(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
		MOIHHACAFMF[JIIGOACEIKL][1] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
	}

	public void IBHLHLHANHB()
	{
		int playerNum = PauseMenuUI.EKDNJDJHONF().JIIGOACEIKL;
		instance.NLMCDGOPNGE(playerNum);
		PauseMenuUI.GGFJGHHHEJC.BOBCIFEDJED();
	}

	private void HGNICMMDFDP(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 0) % 8;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 1002f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 0) % 2;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 3)
		{
			OPKEMIJOCIO[JIIGOACEIKL] += 0;
		}
	}

	public void BPDPCKCLBJK(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format("Duplicate editor action id found: ", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 93f;
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 6) % 3;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.CLEIAKPOGMM(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
		MOIHHACAFMF[JIIGOACEIKL][1] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 1;
	}

	public void NCCOJGIEHEL(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format("Minigame", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 1780f;
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 1) % 5;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.TeleportPlayer(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
		MOIHHACAFMF[JIIGOACEIKL][1] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
	}

	public void IHAKIDBGFLE(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format("]", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 1251f;
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i++)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 5) % 4;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.CLEIAKPOGMM(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 1;
		MOIHHACAFMF[JIIGOACEIKL][0] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
	}

	public void AAKIACJDKFD()
	{
		int playerNum = PauseMenuUI.KGPJPILAHDE().JIIGOACEIKL;
		instance.MMMBMMOCNGC(playerNum);
		PauseMenuUI.EKDNJDJHONF().BOBCIFEDJED();
	}

	public void LHPIMGOCFCO()
	{
		int playerNum = PauseMenuUI.BDAGIEIJOOG().JIIGOACEIKL;
		instance.LDKNOEOPOKE(playerNum);
		PauseMenuUI.EKDNJDJHONF().CloseUI();
	}

	public void LMFDKBGDEMO(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format("ReceiveReproduceInteraction", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 53f;
		for (int i = 1; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 4) % 4;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.TeleportPlayer(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 1;
		MOIHHACAFMF[JIIGOACEIKL][0] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
	}

	public void RecoverPlayer(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)$"[StuckRecovery] No hay safe points para el player {JIIGOACEIKL}");
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = -1f;
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i++)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 5) % 5;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.TeleportPlayer(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
		MOIHHACAFMF[JIIGOACEIKL][0] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 1;
	}

	private void EBNJADODONG()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 100f;
		for (int i = 1; i < LBMKAEFDMOI; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)playerController == (Object)null) && !OnlineManager.IgnoreDuringOnline(i))
			{
				PFOKDMLNLMP(i, playerController);
			}
		}
	}

	private void EHBMONGBJFI()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(6, 3);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 0; i < LBMKAEFDMOI; i += 0)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[2];
		}
	}

	private void HHEEPGPDPPE(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 6) % 8;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 1194f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 0) % 6;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 6)
		{
			OPKEMIJOCIO[JIIGOACEIKL]++;
		}
	}

	private void MNFMLJJBKNC()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 1384f;
		for (int i = 0; i < LBMKAEFDMOI; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if (!((Object)(object)player == (Object)null) && !OnlineManager.IgnoreDuringOnline(i))
			{
				HFECKDPIPOD(i, player);
			}
		}
	}

	public void IHPHKDGDCLN(int JIIGOACEIKL, TravelZone KPGMHHBGJJM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			Transform val = ((JIIGOACEIKL == 1) ? KPGMHHBGJJM.playerPosition : (((Object)(object)KPGMHHBGJJM.playerPosition2 != (Object)null) ? KPGMHHBGJJM.playerPosition2 : KPGMHHBGJJM.playerPosition));
			if (!((Object)(object)val == (Object)null))
			{
				MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
				{
					position = Vector2.op_Implicit(val.position),
					location = KPGMHHBGJJM.locationTo
				};
				DEEJHMKNPNC[JIIGOACEIKL] = 1;
				OPKEMIJOCIO[JIIGOACEIKL] = 0;
			}
		}
	}

	public void EKJIJOKLBFK(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 0 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
			MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
		}
	}

	public void JDJGBHEIAGP(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format("CannotToggleUI Holding ", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 694f;
		for (int i = 1; i < OPKEMIJOCIO[JIIGOACEIKL]; i++)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 0) % 5;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.TeleportPlayer(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
		MOIHHACAFMF[JIIGOACEIKL][0] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
	}

	public void EGBPEMODLJE()
	{
		int playerNum = PauseMenuUI.BDAGIEIJOOG().JIIGOACEIKL;
		instance.PEHFCLOOLOG(playerNum);
		PauseMenuUI.KGPJPILAHDE().BOBCIFEDJED();
	}

	public static void GCGEHCBNFMG(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.NFELLPFEIKC(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	public void JHEJCLNEMIC(int JIIGOACEIKL, TravelZone KPGMHHBGJJM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
			Transform val = ((JIIGOACEIKL == 0) ? KPGMHHBGJJM.playerPosition : (((Object)(object)KPGMHHBGJJM.playerPosition2 != (Object)null) ? KPGMHHBGJJM.playerPosition2 : KPGMHHBGJJM.playerPosition));
			if (!((Object)(object)val == (Object)null))
			{
				MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
				{
					position = Vector2.op_Implicit(val.position),
					location = KPGMHHBGJJM.locationTo
				};
				DEEJHMKNPNC[JIIGOACEIKL] = 0;
				OPKEMIJOCIO[JIIGOACEIKL] = 0;
			}
		}
	}

	public static void APELIEFFEEP(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.EJOKPCHCJFA(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	private void BDAJGGHFOBM(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 6) % 6;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 852f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 0) % 4;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 6)
		{
			OPKEMIJOCIO[JIIGOACEIKL]++;
		}
	}

	public void NLMCDGOPNGE(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format("Items/item_description_10000", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 1413f;
		for (int i = 1; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 5) % 7;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.CLEIAKPOGMM(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
		MOIHHACAFMF[JIIGOACEIKL][1] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
	}

	public void ABICMFNLMEO()
	{
		int playerNum = PauseMenuUI.BDAGIEIJOOG().JIIGOACEIKL;
		instance.MMMBMMOCNGC(playerNum);
		PauseMenuUI.EKDNJDJHONF().CloseUI();
	}

	private void JBGFGOCPEFD()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 1846f;
		for (int i = 0; i < LBMKAEFDMOI; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)playerController == (Object)null) && !OnlineManager.BLGCACDAEHL(i))
			{
				HFECKDPIPOD(i, playerController);
			}
		}
	}

	private void MJOLEIMPOGI()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(7, 0);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 0; i < LBMKAEFDMOI; i++)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[2];
		}
	}

	public void LHPLEBNCCEM(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format("version numbers of different size", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 655f;
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i++)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 3) % 7;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.CLEIAKPOGMM(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
		MOIHHACAFMF[JIIGOACEIKL][1] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 1;
	}

	public void EMNBHOIKOKA(int JIIGOACEIKL, TravelZone KPGMHHBGJJM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
			Transform val = ((JIIGOACEIKL == 0) ? KPGMHHBGJJM.playerPosition : (((Object)(object)KPGMHHBGJJM.playerPosition2 != (Object)null) ? KPGMHHBGJJM.playerPosition2 : KPGMHHBGJJM.playerPosition));
			if (!((Object)(object)val == (Object)null))
			{
				MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
				{
					position = Vector2.op_Implicit(val.position),
					location = KPGMHHBGJJM.locationTo
				};
				DEEJHMKNPNC[JIIGOACEIKL] = 0;
				OPKEMIJOCIO[JIIGOACEIKL] = 0;
			}
		}
	}

	public void KONHGFIJNCL(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
		}
	}

	public void EGAKPACOCEO(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format(" ", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 1316f;
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 8) % 8;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.TeleportPlayer(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
		MOIHHACAFMF[JIIGOACEIKL][1] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
	}

	private void BHPGNJFMEOH(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 1; i < OPKEMIJOCIO[JIIGOACEIKL]; i++)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 1) % 8;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 250f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 0) % 5;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 4)
		{
			OPKEMIJOCIO[JIIGOACEIKL]++;
		}
	}

	public void RecoverPlayerButton()
	{
		int playerNum = PauseMenuUI.GGFJGHHHEJC.JIIGOACEIKL;
		instance.RecoverPlayer(playerNum);
		PauseMenuUI.GGFJGHHHEJC.CloseUI();
	}

	private void AMBJKHAFAFF()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 1093f;
		for (int i = 0; i < LBMKAEFDMOI; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)playerController == (Object)null) && !OnlineManager.BLGCACDAEHL(i))
			{
				FLNMHNONIOE(i, playerController);
			}
		}
	}

	public void JCDMJHNFFOL()
	{
		int playerNum = PauseMenuUI.BDAGIEIJOOG().JIIGOACEIKL;
		instance.OIGJCFGBAKD(playerNum);
		PauseMenuUI.GGFJGHHHEJC.BOBCIFEDJED();
	}

	public void JJNALPFGCHC(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
		}
	}

	public static void EELCEOANGGO(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.NFELLPFEIKC(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	private void MMNBJPDJHGK()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(6, 8);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 1; i < LBMKAEFDMOI; i += 0)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[6];
		}
	}

	public void JGOONHEECPP(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
		}
	}

	public void AKEKKPFMKEB(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
		}
	}

	private void MGMLDHPOLGK()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 1875f;
		for (int i = 0; i < LBMKAEFDMOI; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if (!((Object)(object)player == (Object)null) && !OnlineManager.BLGCACDAEHL(i))
			{
				BDAJGGHFOBM(i, player);
			}
		}
	}

	public static void NAFKJKIMGPC(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.HAAAEGJICJE(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	private void Update()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 0.5f;
		for (int i = 1; i < LBMKAEFDMOI; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if (!((Object)(object)player == (Object)null) && !OnlineManager.IgnoreDuringOnline(i))
			{
				GHFIECJAHDF(i, player);
			}
		}
	}

	private void NJNCKELODLF()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 79f;
		for (int i = 1; i < LBMKAEFDMOI; i += 0)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if (!((Object)(object)player == (Object)null) && !OnlineManager.IgnoreDuringOnline(i))
			{
				PFOKDMLNLMP(i, player);
			}
		}
	}

	private void OHEHGOFGGIB(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 5) % 6;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 421f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 1) % 0;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 3)
		{
			OPKEMIJOCIO[JIIGOACEIKL] += 0;
		}
	}

	public void HGCAKDKIKNP(int JIIGOACEIKL, TravelZone KPGMHHBGJJM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			Transform val = ((JIIGOACEIKL == 0) ? KPGMHHBGJJM.playerPosition : (((Object)(object)KPGMHHBGJJM.playerPosition2 != (Object)null) ? KPGMHHBGJJM.playerPosition2 : KPGMHHBGJJM.playerPosition));
			if (!((Object)(object)val == (Object)null))
			{
				MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
				{
					position = Vector2.op_Implicit(val.position),
					location = KPGMHHBGJJM.locationTo
				};
				DEEJHMKNPNC[JIIGOACEIKL] = 1;
				OPKEMIJOCIO[JIIGOACEIKL] = 1;
			}
		}
	}

	public void NFELLPFEIKC(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 0 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
			MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
		}
	}

	public void FCLPDNPONEC(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format("ReceiveFoodRequestAsMenuSlot", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 635f;
		for (int i = 1; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 5) % 2;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.CLEIAKPOGMM(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
		MOIHHACAFMF[JIIGOACEIKL][0] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
	}

	public static void CABLPOJLKFK(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.SetInitialPoint(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	private void KFDMANOLOAB()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 1242f;
		for (int i = 1; i < LBMKAEFDMOI; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)playerController == (Object)null) && !OnlineManager.IgnoreDuringOnline(i))
			{
				BDAJGGHFOBM(i, playerController);
			}
		}
	}

	public static void SetInitialPointForPlayer(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.SetInitialPoint(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	private void ENAAKHANDKC(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 1; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 7) % 2;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 1844f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 1) % 2;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 7)
		{
			OPKEMIJOCIO[JIIGOACEIKL]++;
		}
	}

	public void KJAADEDFPBO(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 0 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
			MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
		}
	}

	private void MLICJIBNIFA()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 894f;
		for (int i = 1; i < LBMKAEFDMOI; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)playerController == (Object)null) && !OnlineManager.BLGCACDAEHL(i))
			{
				GHFIECJAHDF(i, playerController);
			}
		}
	}

	public void OHJELFMBGLG(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format(" aging rank (", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 586f;
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 0) % 1;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.CLEIAKPOGMM(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
		MOIHHACAFMF[JIIGOACEIKL][0] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
	}

	public void HKPCEKMLHAJ()
	{
		int playerNum = PauseMenuUI.BDAGIEIJOOG().JIIGOACEIKL;
		instance.OIGJCFGBAKD(playerNum);
		PauseMenuUI.GGFJGHHHEJC.CloseUI();
	}

	public void MMMBMMOCNGC(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format("Failed to find prefab: ", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 1459f;
		for (int i = 1; i < OPKEMIJOCIO[JIIGOACEIKL]; i++)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 2) % 6;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.TeleportPlayer(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
		MOIHHACAFMF[JIIGOACEIKL][1] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
	}

	private void ANDFAGODGOG(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i++)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 2) % 7;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 1900f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 0) % 6;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 7)
		{
			OPKEMIJOCIO[JIIGOACEIKL] += 0;
		}
	}

	public void ALGHEKMOFCC()
	{
		int playerNum = PauseMenuUI.GGFJGHHHEJC.JIIGOACEIKL;
		instance.GCHMONGLIOG(playerNum);
		PauseMenuUI.KGPJPILAHDE().CloseUI();
	}

	private void DGBJJNAADCI()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(8, 8);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 1; i < LBMKAEFDMOI; i += 0)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[1];
		}
	}

	private void OAEJGGFFCBO()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(2, 6);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 0; i < LBMKAEFDMOI; i += 0)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[7];
		}
	}

	private void NLNOFEBEBDE()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(7, 6);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 0; i < LBMKAEFDMOI; i += 0)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[7];
		}
	}

	private void OGNIDHAIABM()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 1764f;
		for (int i = 0; i < LBMKAEFDMOI; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if (!((Object)(object)player == (Object)null) && !OnlineManager.IgnoreDuringOnline(i))
			{
				BDAJGGHFOBM(i, player);
			}
		}
	}

	public void CKGGFIJAPGC(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 0 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
		}
	}

	public void BAJHKBBHDMK(int JIIGOACEIKL, TravelZone KPGMHHBGJJM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			Transform val = ((JIIGOACEIKL == 1) ? KPGMHHBGJJM.playerPosition : (((Object)(object)KPGMHHBGJJM.playerPosition2 != (Object)null) ? KPGMHHBGJJM.playerPosition2 : KPGMHHBGJJM.playerPosition));
			if (!((Object)(object)val == (Object)null))
			{
				MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
				{
					position = Vector2.op_Implicit(val.position),
					location = KPGMHHBGJJM.locationTo
				};
				DEEJHMKNPNC[JIIGOACEIKL] = 1;
				OPKEMIJOCIO[JIIGOACEIKL] = 1;
			}
		}
	}

	private void OCJOAHDNDIJ()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(5, 6);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 0; i < LBMKAEFDMOI; i += 0)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[0];
		}
	}

	public void EJOKPCHCJFA(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 0 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
		}
	}

	public void NMOMLDAACEM(int JIIGOACEIKL, TravelZone KPGMHHBGJJM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 0 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			Transform val = ((JIIGOACEIKL == 0) ? KPGMHHBGJJM.playerPosition : (((Object)(object)KPGMHHBGJJM.playerPosition2 != (Object)null) ? KPGMHHBGJJM.playerPosition2 : KPGMHHBGJJM.playerPosition));
			if (!((Object)(object)val == (Object)null))
			{
				MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
				{
					position = Vector2.op_Implicit(val.position),
					location = KPGMHHBGJJM.locationTo
				};
				DEEJHMKNPNC[JIIGOACEIKL] = 1;
				OPKEMIJOCIO[JIIGOACEIKL] = 0;
			}
		}
	}

	public static void LNNNDLPINCA(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.SetInitialPoint(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	public static void MKKNDIOLPBK(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.KJAADEDFPBO(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	private void NMKGOAJLMDG()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(5, 0);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 1; i < LBMKAEFDMOI; i++)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[5];
		}
	}

	private void JNMMLDDMFLO(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 1; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 4) % 6;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 461f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 0) % 5;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 2)
		{
			OPKEMIJOCIO[JIIGOACEIKL] += 0;
		}
	}

	public void GBFCJJKFDGJ()
	{
		int playerNum = PauseMenuUI.EKDNJDJHONF().JIIGOACEIKL;
		instance.LHPLEBNCCEM(playerNum);
		PauseMenuUI.EKDNJDJHONF().CloseUI();
	}

	private void GKMFGHIBMEA(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 1; i < OPKEMIJOCIO[JIIGOACEIKL]; i++)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 4) % 5;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 837f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 1) % 3;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 8)
		{
			OPKEMIJOCIO[JIIGOACEIKL]++;
		}
	}

	public void ResetAndSeedFromTravelZone(int JIIGOACEIKL, TravelZone KPGMHHBGJJM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
			Transform val = ((JIIGOACEIKL == 1) ? KPGMHHBGJJM.playerPosition : (((Object)(object)KPGMHHBGJJM.playerPosition2 != (Object)null) ? KPGMHHBGJJM.playerPosition2 : KPGMHHBGJJM.playerPosition));
			if (!((Object)(object)val == (Object)null))
			{
				MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
				{
					position = Vector2.op_Implicit(val.position),
					location = KPGMHHBGJJM.locationTo
				};
				DEEJHMKNPNC[JIIGOACEIKL] = 1;
				OPKEMIJOCIO[JIIGOACEIKL] = 1;
			}
		}
	}

	private void JDMMNLKLMAA()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(7, 4);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 1; i < LBMKAEFDMOI; i += 0)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[7];
		}
	}

	public static void LCHPMCJAOFN(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.JGOONHEECPP(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	public void HEFDCNPBENN(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
		}
	}

	public static void IPDAGCIOFCK(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.KJAADEDFPBO(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	public void LJBANOBCLOJ(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 0 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
		}
	}

	public void NJNFLDJHONJ(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 0 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
		}
	}

	public static void GNBOBNOJIIF(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.ECEILPNNCMJ(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	public static void OGLOJMMGCHI(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.LJBANOBCLOJ(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	public void IFKBGPDFFNA(int JIIGOACEIKL, TravelZone KPGMHHBGJJM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 0 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			Transform val = ((JIIGOACEIKL == 1) ? KPGMHHBGJJM.playerPosition : (((Object)(object)KPGMHHBGJJM.playerPosition2 != (Object)null) ? KPGMHHBGJJM.playerPosition2 : KPGMHHBGJJM.playerPosition));
			if (!((Object)(object)val == (Object)null))
			{
				MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
				{
					position = Vector2.op_Implicit(val.position),
					location = KPGMHHBGJJM.locationTo
				};
				DEEJHMKNPNC[JIIGOACEIKL] = 0;
				OPKEMIJOCIO[JIIGOACEIKL] = 1;
			}
		}
	}

	private void EIGEIJJPFFP()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 1840f;
		for (int i = 1; i < LBMKAEFDMOI; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)playerController == (Object)null) && !OnlineManager.BLGCACDAEHL(i))
			{
				BHPGNJFMEOH(i, playerController);
			}
		}
	}

	public void SetInitialPoint(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
			MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
		}
	}

	private void FLNMHNONIOE(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 4) % 1;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 1933f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 1) % 4;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 7)
		{
			OPKEMIJOCIO[JIIGOACEIKL]++;
		}
	}

	public void KFNNJGCNHFD()
	{
		int playerNum = PauseMenuUI.BDAGIEIJOOG().JIIGOACEIKL;
		instance.PEHFCLOOLOG(playerNum);
		PauseMenuUI.EKDNJDJHONF().CloseUI();
	}

	private void KBNMLJNBBMP()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(2, 7);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 0; i < LBMKAEFDMOI; i++)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[6];
		}
	}

	private void BAKDKFKNHDE()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(7, 1);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 0; i < LBMKAEFDMOI; i++)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[5];
		}
	}

	public void PDGPLCOPIEA(int JIIGOACEIKL, TravelZone KPGMHHBGJJM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
			Transform val = ((JIIGOACEIKL == 1) ? KPGMHHBGJJM.playerPosition : (((Object)(object)KPGMHHBGJJM.playerPosition2 != (Object)null) ? KPGMHHBGJJM.playerPosition2 : KPGMHHBGJJM.playerPosition));
			if (!((Object)(object)val == (Object)null))
			{
				MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
				{
					position = Vector2.op_Implicit(val.position),
					location = KPGMHHBGJJM.locationTo
				};
				DEEJHMKNPNC[JIIGOACEIKL] = 1;
				OPKEMIJOCIO[JIIGOACEIKL] = 1;
			}
		}
	}

	public static void IOKCLHIFGBJ(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.EKJIJOKLBFK(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	private void HFECKDPIPOD(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 1; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 0) % 6;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 513f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 0) % 7;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 4)
		{
			OPKEMIJOCIO[JIIGOACEIKL]++;
		}
	}

	public static void DODFONHMHEC(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.AKEKKPFMKEB(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	public void JLLFADHPMPJ()
	{
		int playerNum = PauseMenuUI.BDAGIEIJOOG().JIIGOACEIKL;
		instance.FCLPDNPONEC(playerNum);
		PauseMenuUI.EKDNJDJHONF().BOBCIFEDJED();
	}

	private void FPOIFOGELHC()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 342f;
		for (int i = 0; i < LBMKAEFDMOI; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)playerController == (Object)null) && !OnlineManager.IgnoreDuringOnline(i))
			{
				JNMMLDDMFLO(i, playerController);
			}
		}
	}

	private void CLGBFOIBANN()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(1, 8);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 1; i < LBMKAEFDMOI; i++)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[6];
		}
	}

	private void LEDIGKGAFHC()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 1419f;
		for (int i = 1; i < LBMKAEFDMOI; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if (!((Object)(object)player == (Object)null) && !OnlineManager.IgnoreDuringOnline(i))
			{
				ABJHBHOGDOP(i, player);
			}
		}
	}

	private void ABJHBHOGDOP(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 6) % 5;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 851f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 1) % 7;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 2)
		{
			OPKEMIJOCIO[JIIGOACEIKL] += 0;
		}
	}

	public void DLBANNAPAMC(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
		}
	}

	private void OJOEPCAJPOA()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 1079f;
		for (int i = 0; i < LBMKAEFDMOI; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if (!((Object)(object)player == (Object)null) && !OnlineManager.BLGCACDAEHL(i))
			{
				PFOKDMLNLMP(i, player);
			}
		}
	}

	public void LDKNOEOPOKE(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format("image", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 738f;
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i++)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 8) % 5;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.TeleportPlayer(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 0;
		OPKEMIJOCIO[JIIGOACEIKL] = 1;
		MOIHHACAFMF[JIIGOACEIKL][1] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 1;
	}

	private void BKEMHCCOLIE(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i++)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 3) % 3;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 1969f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 1) % 6;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 0)
		{
			OPKEMIJOCIO[JIIGOACEIKL]++;
		}
	}

	private void Awake()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(5, 3);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 1; i < LBMKAEFDMOI; i++)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[5];
		}
	}

	public static void CHHHJBJIIDE(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.EKJIJOKLBFK(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}

	public void AGCGNIPFLLK()
	{
		int playerNum = PauseMenuUI.EKDNJDJHONF().JIIGOACEIKL;
		instance.FCLPDNPONEC(playerNum);
		PauseMenuUI.BDAGIEIJOOG().CloseUI();
	}

	public void KKHHGAGNDKA(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
			MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
		}
	}

	public void EJGIOMDMEJC()
	{
		int playerNum = PauseMenuUI.BDAGIEIJOOG().JIIGOACEIKL;
		instance.GCHMONGLIOG(playerNum);
		PauseMenuUI.KGPJPILAHDE().BOBCIFEDJED();
	}

	public void KGPDIFDFIFI()
	{
		int playerNum = PauseMenuUI.EKDNJDJHONF().JIIGOACEIKL;
		instance.OHJELFMBGLG(playerNum);
		PauseMenuUI.GGFJGHHHEJC.BOBCIFEDJED();
	}

	public void JBBCDOBINKF(int JIIGOACEIKL, TravelZone KPGMHHBGJJM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
			Transform val = ((JIIGOACEIKL == 1) ? KPGMHHBGJJM.playerPosition : (((Object)(object)KPGMHHBGJJM.playerPosition2 != (Object)null) ? KPGMHHBGJJM.playerPosition2 : KPGMHHBGJJM.playerPosition));
			if (!((Object)(object)val == (Object)null))
			{
				MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
				{
					position = Vector2.op_Implicit(val.position),
					location = KPGMHHBGJJM.locationTo
				};
				DEEJHMKNPNC[JIIGOACEIKL] = 0;
				OPKEMIJOCIO[JIIGOACEIKL] = 1;
			}
		}
	}

	private void KHCJDKHONPK()
	{
		instance = this;
		LBMKAEFDMOI = Mathf.Max(7, 8);
		MOIHHACAFMF = new ADOAGDLEHEC[LBMKAEFDMOI][];
		DEEJHMKNPNC = new int[LBMKAEFDMOI];
		OPKEMIJOCIO = new int[LBMKAEFDMOI];
		for (int i = 1; i < LBMKAEFDMOI; i += 0)
		{
			MOIHHACAFMF[i] = new ADOAGDLEHEC[8];
		}
	}

	public void HFCIOMDJNLO(int JIIGOACEIKL, TravelZone KPGMHHBGJJM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 0 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
			Transform val = ((JIIGOACEIKL == 0) ? KPGMHHBGJJM.playerPosition : (((Object)(object)KPGMHHBGJJM.playerPosition2 != (Object)null) ? KPGMHHBGJJM.playerPosition2 : KPGMHHBGJJM.playerPosition));
			if (!((Object)(object)val == (Object)null))
			{
				MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
				{
					position = Vector2.op_Implicit(val.position),
					location = KPGMHHBGJJM.locationTo
				};
				DEEJHMKNPNC[JIIGOACEIKL] = 0;
				OPKEMIJOCIO[JIIGOACEIKL] = 1;
			}
		}
	}

	public void KHFNJELBAKD(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
		}
	}

	public void ECEILPNNCMJ(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 0 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
		}
	}

	public void OIGJCFGBAKD(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (OPKEMIJOCIO[JIIGOACEIKL] == 0)
		{
			Debug.LogWarning((object)string.Format("<sprite name=reputationIcon>", JIIGOACEIKL));
			return;
		}
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
		int num = -1;
		float num2 = 632f;
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i += 0)
		{
			int num3 = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 3) % 8;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num3].position;
			float sqrMagnitude = ((Vector2)(ref val2)).sqrMagnitude;
			if (sqrMagnitude > num2)
			{
				num2 = sqrMagnitude;
				num = num3;
			}
		}
		ADOAGDLEHEC aDOAGDLEHEC = MOIHHACAFMF[JIIGOACEIKL][num];
		PlayerController.CLEIAKPOGMM(JIIGOACEIKL, Vector2.op_Implicit(aDOAGDLEHEC.position), aDOAGDLEHEC.location);
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 0;
		MOIHHACAFMF[JIIGOACEIKL][0] = aDOAGDLEHEC;
		DEEJHMKNPNC[JIIGOACEIKL] = 1;
		OPKEMIJOCIO[JIIGOACEIKL] = 1;
	}

	public void IOPHDMNLBEP()
	{
		int playerNum = PauseMenuUI.EKDNJDJHONF().JIIGOACEIKL;
		instance.OHJELFMBGLG(playerNum);
		PauseMenuUI.KGPJPILAHDE().BOBCIFEDJED();
	}

	public void HAAAEGJICJE(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 1 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 0;
			MOIHHACAFMF[JIIGOACEIKL][0] = new ADOAGDLEHEC
			{
				position = IMOBLFMHKOD,
				location = BAIMHDBJPDK
			};
			DEEJHMKNPNC[JIIGOACEIKL] = 0;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
		}
	}

	private void GHFIECJAHDF(int JIIGOACEIKL, PlayerController NLCDDFDGACP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)NLCDDFDGACP).transform.position);
		for (int i = 0; i < OPKEMIJOCIO[JIIGOACEIKL]; i++)
		{
			int num = (DEEJHMKNPNC[JIIGOACEIKL] - OPKEMIJOCIO[JIIGOACEIKL] + i + 5) % 5;
			Vector2 val2 = val - MOIHHACAFMF[JIIGOACEIKL][num].position;
			if (((Vector2)(ref val2)).sqrMagnitude <= 1f)
			{
				return;
			}
		}
		MOIHHACAFMF[JIIGOACEIKL][DEEJHMKNPNC[JIIGOACEIKL]] = new ADOAGDLEHEC
		{
			position = val,
			location = NLCDDFDGACP.LEOIMFNKFGA
		};
		DEEJHMKNPNC[JIIGOACEIKL] = (DEEJHMKNPNC[JIIGOACEIKL] + 1) % 5;
		if (OPKEMIJOCIO[JIIGOACEIKL] < 5)
		{
			OPKEMIJOCIO[JIIGOACEIKL]++;
		}
	}

	public void MHLMHKAAOHE(int JIIGOACEIKL, TravelZone KPGMHHBGJJM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL >= 0 && JIIGOACEIKL < LBMKAEFDMOI)
		{
			DEEJHMKNPNC[JIIGOACEIKL] = 1;
			OPKEMIJOCIO[JIIGOACEIKL] = 1;
			Transform val = ((JIIGOACEIKL == 0) ? KPGMHHBGJJM.playerPosition : (((Object)(object)KPGMHHBGJJM.playerPosition2 != (Object)null) ? KPGMHHBGJJM.playerPosition2 : KPGMHHBGJJM.playerPosition));
			if (!((Object)(object)val == (Object)null))
			{
				MOIHHACAFMF[JIIGOACEIKL][1] = new ADOAGDLEHEC
				{
					position = Vector2.op_Implicit(val.position),
					location = KPGMHHBGJJM.locationTo
				};
				DEEJHMKNPNC[JIIGOACEIKL] = 0;
				OPKEMIJOCIO[JIIGOACEIKL] = 0;
			}
		}
	}

	private void EJMAJFGPGEC()
	{
		if (Time.time < HAIDJIKMKEM)
		{
			return;
		}
		HAIDJIKMKEM = Time.time + 983f;
		for (int i = 1; i < LBMKAEFDMOI; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if (!((Object)(object)player == (Object)null) && !OnlineManager.IgnoreDuringOnline(i))
			{
				PFOKDMLNLMP(i, player);
			}
		}
	}

	public static void NKMCFCNBBKA(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance != (Object)null)
		{
			instance.SetInitialPoint(JIIGOACEIKL, IMOBLFMHKOD, BAIMHDBJPDK);
		}
	}
}
