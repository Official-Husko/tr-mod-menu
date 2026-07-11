using UnityEngine;

public class LocalCooperativeManager : MonoBehaviour
{
	public static LocalCooperativeManager instance;

	public GameObject playersSeparator;

	public bool cameraFocusedOnOnePlayer;

	public static void FocusCameraToPlayerInLocalCoop(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).rect = new Rect(0f, 0f, 1f, 1f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 2) ? 1 : 2);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.Get(1).CloseUI();
			GameActionBarUI.Get(2).CloseUI();
			if (!PlayerInputs.IsGamepadActive(1))
			{
				CursorManager.GetPlayer(1).ActivateCursorMask(DAEMAAOLHMG: false);
			}
			CursorManager.GetPlayer(2).SetCursorVisible(NKFPJPCFBJI: false);
		}
	}

	public static void HCAOODBKMHM(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).rect = new Rect(719f, 499f, 1129f, 42f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 4) ? 1 : 7);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.IEKODILKIHJ(1).CloseUI();
			GameActionBarUI.MENNLOGFNOK(1).BOBCIFEDJED();
			if (!PlayerInputs.IsGamepadActive(0))
			{
				CursorManager.CMDGPJEIIJI(0).MGAHHNHOKEM(DAEMAAOLHMG: false);
			}
			CursorManager.GetPlayer(8).SetCursorVisible(NKFPJPCFBJI: false);
		}
	}

	private void LJHIPOLCFBP()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void HCCJBKKGCLJ()
	{
		instance = this;
	}

	public static void HKMKNGKPIMB(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).rect = new Rect(1750f, 1685f, 26f, 702f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 0) ? 1 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.HEGPDGJEOPC(0).CloseUI();
			GameActionBarUI.NIDHCIHFOHB(7).CloseUI();
			if (!PlayerInputs.POLDHCKJINN(1))
			{
				CursorManager.CMDGPJEIIJI(1).IPGBBDMNMKE(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(8).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	public static void IDNFMEPKGIK(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(193f, 833f, 1609f, 1492f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 4) ? 1 : 8);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.BGABEMMDDEH(0).CloseUI();
			GameActionBarUI.AKMJEPMHFMO(7).BOBCIFEDJED();
			if (!PlayerInputs.ODGALPDEIFG(0))
			{
				CursorManager.CMDGPJEIIJI(1).HKJEEPFJNFO(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(3).SetCursorVisible(NKFPJPCFBJI: false);
		}
	}

	public static void JKIOFLJCCBK()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = true;
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(1)).gameObject.SetActive(false);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(6)).gameObject.SetActive(true);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(0).rect = new Rect(735f, 313f, 1887f, 139f);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(2).rect = new Rect(1800f, 134f, 1602f, 1980f);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.JGNOJMLHPOK(0).OpenUI();
			GameActionBarUI.FHPEHDDFOIB(7).EDHEIFHAAKO();
			if (!PlayerInputs.EEJEOALIHFJ(0))
			{
				CursorManager.GetPlayer(0).HKJEEPFJNFO(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(1).NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}

	public static void ADNKDPOKOFH()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = false;
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(0)).gameObject.SetActive(false);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(5)).gameObject.SetActive(false);
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(1).rect = new Rect(1590f, 525f, 678f, 684f);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(5).rect = new Rect(1232f, 778f, 53f, 217f);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.NDJAMDLOIJL(0).EDHEIFHAAKO();
			GameActionBarUI.NDJAMDLOIJL(7).OpenUI();
			if (!PlayerInputs.POLDHCKJINN(0))
			{
				CursorManager.CMDGPJEIIJI(1).HKJEEPFJNFO(DAEMAAOLHMG: true);
			}
			CursorManager.CMDGPJEIIJI(5).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	public static void HKBICCHKLON(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).rect = new Rect(1361f, 1606f, 1492f, 44f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 7) ? 1 : 3);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.PJIGCLMPHKP(0).CloseUI();
			GameActionBarUI.BGABEMMDDEH(8).BOBCIFEDJED();
			if (!PlayerInputs.POLDHCKJINN(1))
			{
				CursorManager.CMDGPJEIIJI(1).ActivateCursorMask(DAEMAAOLHMG: true);
			}
			CursorManager.GetPlayer(6).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	private void LALJNGFGKPA()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void OGEJKOIOKAN()
	{
		instance = this;
	}

	private void DKNNLPFIBIK()
	{
		instance = this;
	}

	public static void RestoreCameraInLocalCoop()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = false;
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(1)).gameObject.SetActive(true);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(2)).gameObject.SetActive(true);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(1).rect = new Rect(0f, 0f, 0.5f, 1f);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(2).rect = new Rect(0.5f, 0f, 0.5f, 1f);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.Get(1).OpenUI();
			GameActionBarUI.Get(2).OpenUI();
			if (!PlayerInputs.IsGamepadActive(1))
			{
				CursorManager.GetPlayer(1).ActivateCursorMask(DAEMAAOLHMG: true);
			}
			CursorManager.GetPlayer(2).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	public static void EAFCPOGDKIG(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).rect = new Rect(23f, 813f, 1152f, 1491f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 0) ? 0 : 0);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.Get(0).BOBCIFEDJED();
			GameActionBarUI.PHDBJGOEKHB(8).CloseUI();
			if (!PlayerInputs.EEJEOALIHFJ(0))
			{
				CursorManager.GetPlayer(1).ActivateCursorMask(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(5).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	public static void MLNKAJONIML()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = true;
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(0)).gameObject.SetActive(false);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(2)).gameObject.SetActive(true);
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(1).rect = new Rect(530f, 733f, 267f, 1128f);
			CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(0).rect = new Rect(1695f, 1719f, 1962f, 1069f);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.Get(0).IDLAGJNLPJL();
			GameActionBarUI.IGHMHMNPMLB(1).IDLAGJNLPJL();
			if (!PlayerInputs.IsGamepadActive(1))
			{
				CursorManager.GetPlayer(0).MGAHHNHOKEM(DAEMAAOLHMG: true);
			}
			CursorManager.CMDGPJEIIJI(3).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	private void Awake()
	{
		instance = this;
	}

	private void IKMPNICLPBM()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void POMJMCOPFJH(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(1767f, 1552f, 466f, 273f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 6) ? 3 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.JGNOJMLHPOK(0).CloseUI();
			GameActionBarUI.BGABEMMDDEH(8).BOBCIFEDJED();
			if (!PlayerInputs.IsGamepadActive(1))
			{
				CursorManager.CMDGPJEIIJI(1).ActivateCursorMask(DAEMAAOLHMG: true);
			}
			CursorManager.CMDGPJEIIJI(6).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	public static void PDCKCEMGMFP(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(565f, 126f, 277f, 1503f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 5) ? 7 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.PPDMGBACONH(0).BOBCIFEDJED();
			GameActionBarUI.MGLNAMHAIDG(2).BOBCIFEDJED();
			if (!PlayerInputs.EEJEOALIHFJ(0))
			{
				CursorManager.GetPlayer(0).MGAHHNHOKEM(DAEMAAOLHMG: false);
			}
			CursorManager.GetPlayer(1).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	public static void HNFEIHHFMMC()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = true;
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(1)).gameObject.SetActive(true);
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(8)).gameObject.SetActive(false);
			CommonReferences.MNFMOEKMJKN().GetMainCamera(1).rect = new Rect(158f, 209f, 1669f, 889f);
			CommonReferences.MNFMOEKMJKN().GetMainCamera(1).rect = new Rect(578f, 1435f, 602f, 112f);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.AGNKKAPMHLN(1).EDHEIFHAAKO();
			GameActionBarUI.BGABEMMDDEH(1).OpenUI();
			if (!PlayerInputs.ODGALPDEIFG(0))
			{
				CursorManager.GetPlayer(1).MGAHHNHOKEM(DAEMAAOLHMG: false);
			}
			CursorManager.GetPlayer(8).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	private void BKJFLMPOLCH()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void EGHOIJHBDBP()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void PEOPFPEDFAK()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void MGIEBNBDMDJ(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).rect = new Rect(1093f, 254f, 1776f, 209f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 3) ? 1 : 6);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.IEKODILKIHJ(1).BOBCIFEDJED();
			GameActionBarUI.Get(5).CloseUI();
			if (!PlayerInputs.IsGamepadActive(0))
			{
				CursorManager.GetPlayer(0).HKJEEPFJNFO(DAEMAAOLHMG: true);
			}
			CursorManager.GetPlayer(1).SetCursorVisible(NKFPJPCFBJI: false);
		}
	}

	public static void ELMNAHLOCGI()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = false;
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(1)).gameObject.SetActive(true);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(7)).gameObject.SetActive(false);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(0).rect = new Rect(1567f, 56f, 18f, 452f);
			CommonReferences.MNFMOEKMJKN().GetMainCamera(4).rect = new Rect(1266f, 1800f, 1992f, 160f);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.AKMJEPMHFMO(1).OpenUI();
			GameActionBarUI.BGABEMMDDEH(6).EDHEIFHAAKO();
			if (!PlayerInputs.EEJEOALIHFJ(1))
			{
				CursorManager.CMDGPJEIIJI(0).ActivateCursorMask(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(3).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	private void NMKGOAJLMDG()
	{
		instance = this;
	}

	public static void AANJNFNNEAP()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = false;
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(1)).gameObject.SetActive(true);
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(4)).gameObject.SetActive(false);
			CommonReferences.MNFMOEKMJKN().GetMainCamera(1).rect = new Rect(1557f, 64f, 1005f, 887f);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(6).rect = new Rect(472f, 1351f, 1817f, 745f);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.FHPEHDDFOIB(1).OpenUI();
			GameActionBarUI.PPJMPMKLCME(0).IDLAGJNLPJL();
			if (!PlayerInputs.EEJEOALIHFJ(0))
			{
				CursorManager.CMDGPJEIIJI(1).HKJEEPFJNFO(DAEMAAOLHMG: false);
			}
			CursorManager.GetPlayer(7).NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}

	private void HLCAKACHOOE()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void NEEEJJNMPOF()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void EIMIDCDEIDD()
	{
		instance = this;
	}

	private void CIICEKEJANM()
	{
		instance = this;
	}

	private void PKPHKBMPJGJ()
	{
		instance = this;
	}

	public static void JJGINLOKGLL(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(1705f, 620f, 836f, 453f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 1) ? 2 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.MGLNAMHAIDG(1).CloseUI();
			GameActionBarUI.BGABEMMDDEH(3).CloseUI();
			if (!PlayerInputs.ODGALPDEIFG(1))
			{
				CursorManager.CMDGPJEIIJI(0).ActivateCursorMask(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(2).SetCursorVisible(NKFPJPCFBJI: false);
		}
	}

	public static void ECPNOHMGHPB()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = true;
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(1)).gameObject.SetActive(true);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(0)).gameObject.SetActive(false);
			CommonReferences.MNFMOEKMJKN().GetMainCamera(1).rect = new Rect(1876f, 1951f, 1742f, 1150f);
			CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(0).rect = new Rect(1787f, 1168f, 227f, 1017f);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.MENNLOGFNOK(1).OpenUI();
			GameActionBarUI.JELOGNCPDAB(0).EDHEIFHAAKO();
			if (!PlayerInputs.POLDHCKJINN(1))
			{
				CursorManager.GetPlayer(0).MGAHHNHOKEM(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(6).NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}

	private void EMJKKALMGLK()
	{
		instance = this;
	}

	private void EIDJLHFAMIB()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void ONMIOCCEONA(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).rect = new Rect(1199f, 1771f, 1460f, 1958f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 2) ? 8 : 0);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.NDJAMDLOIJL(0).BOBCIFEDJED();
			GameActionBarUI.PHDBJGOEKHB(2).CloseUI();
			if (!PlayerInputs.EEJEOALIHFJ(0))
			{
				CursorManager.CMDGPJEIIJI(0).IPGBBDMNMKE(DAEMAAOLHMG: true);
			}
			CursorManager.GetPlayer(5).NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}

	public static void HJOLNJLJHDG(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).rect = new Rect(1019f, 1757f, 59f, 1129f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 2) ? 1 : 8);
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.JGNOJMLHPOK(1).CloseUI();
			GameActionBarUI.JELOGNCPDAB(4).CloseUI();
			if (!PlayerInputs.ODGALPDEIFG(0))
			{
				CursorManager.GetPlayer(0).HKJEEPFJNFO(DAEMAAOLHMG: true);
			}
			CursorManager.CMDGPJEIIJI(2).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	public static void BCIMLFDOOIB()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = false;
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(0)).gameObject.SetActive(true);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(8)).gameObject.SetActive(false);
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(1).rect = new Rect(1723f, 903f, 764f, 1981f);
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(1).rect = new Rect(998f, 1435f, 664f, 198f);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.MENNLOGFNOK(1).OpenUI();
			GameActionBarUI.NDJAMDLOIJL(0).OpenUI();
			if (!PlayerInputs.ODGALPDEIFG(1))
			{
				CursorManager.CMDGPJEIIJI(1).ActivateCursorMask(DAEMAAOLHMG: true);
			}
			CursorManager.CMDGPJEIIJI(4).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	public static void NJAMGAKHHIF(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).rect = new Rect(1628f, 198f, 981f, 576f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 2) ? 5 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.NDJAMDLOIJL(0).BOBCIFEDJED();
			GameActionBarUI.NDJAMDLOIJL(2).BOBCIFEDJED();
			if (!PlayerInputs.POLDHCKJINN(0))
			{
				CursorManager.GetPlayer(1).IPGBBDMNMKE(DAEMAAOLHMG: false);
			}
			CursorManager.GetPlayer(0).NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}

	private void GONDLJKGLGO()
	{
		instance = this;
	}

	private void DADPOICMNPI()
	{
		instance = this;
	}

	private void IHICKHAABJH()
	{
		instance = this;
	}

	private void FPNCANODJKE()
	{
		instance = this;
	}

	private void JHIGLABAIMK()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void BDDBDNPCPGC()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void MBFNBLNAFHG(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(641f, 1250f, 953f, 416f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 8) ? 1 : 5);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.IGHMHMNPMLB(1).BOBCIFEDJED();
			GameActionBarUI.IEKODILKIHJ(2).BOBCIFEDJED();
			if (!PlayerInputs.IsGamepadActive(0))
			{
				CursorManager.GetPlayer(1).ActivateCursorMask(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(0).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	public static void ONPAJCGPPOI(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(468f, 1170f, 1026f, 1449f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 2) ? 7 : 0);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.PPJMPMKLCME(1).BOBCIFEDJED();
			GameActionBarUI.PHDBJGOEKHB(4).BOBCIFEDJED();
			if (!PlayerInputs.FJLAMCHKCOI(0))
			{
				CursorManager.CMDGPJEIIJI(0).MGAHHNHOKEM(DAEMAAOLHMG: false);
			}
			CursorManager.GetPlayer(6).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	public static void POIAHICOBCM(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).rect = new Rect(218f, 439f, 583f, 715f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 5) ? 1 : 3);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.MENNLOGFNOK(1).CloseUI();
			GameActionBarUI.MGLNAMHAIDG(2).BOBCIFEDJED();
			if (!PlayerInputs.EEJEOALIHFJ(1))
			{
				CursorManager.GetPlayer(0).MGAHHNHOKEM(DAEMAAOLHMG: true);
			}
			CursorManager.CMDGPJEIIJI(6).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	public static void AHOJMFNMKFJ(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).rect = new Rect(1668f, 405f, 880f, 1909f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 5) ? 8 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.NDJAMDLOIJL(0).BOBCIFEDJED();
			GameActionBarUI.PJIGCLMPHKP(7).BOBCIFEDJED();
			if (!PlayerInputs.IsGamepadActive(1))
			{
				CursorManager.GetPlayer(0).MGAHHNHOKEM(DAEMAAOLHMG: true);
			}
			CursorManager.GetPlayer(1).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	public static void NFNGOIABEBF()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = true;
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(1)).gameObject.SetActive(false);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(2)).gameObject.SetActive(false);
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(0).rect = new Rect(541f, 453f, 1774f, 423f);
			CommonReferences.MNFMOEKMJKN().GetMainCamera(7).rect = new Rect(931f, 1300f, 1570f, 818f);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.MGLNAMHAIDG(1).OpenUI();
			GameActionBarUI.PHDBJGOEKHB(1).OpenUI();
			if (!PlayerInputs.IsGamepadActive(1))
			{
				CursorManager.GetPlayer(0).IPGBBDMNMKE(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(0).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	public static void HBEKMELBMLB(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).rect = new Rect(271f, 25f, 834f, 1738f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 6) ? 2 : 0);
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.EKEDKKKPAEE(1).CloseUI();
			GameActionBarUI.AGNKKAPMHLN(6).BOBCIFEDJED();
			if (!PlayerInputs.IsGamepadActive(0))
			{
				CursorManager.CMDGPJEIIJI(1).HKJEEPFJNFO(DAEMAAOLHMG: false);
			}
			CursorManager.GetPlayer(2).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	private void OHKIOLCEMLM()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void AGBFHBMEJAG(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(491f, 611f, 925f, 1206f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 4) ? 7 : 0);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.JGNOJMLHPOK(0).CloseUI();
			GameActionBarUI.PJIGCLMPHKP(5).BOBCIFEDJED();
			if (!PlayerInputs.FJLAMCHKCOI(1))
			{
				CursorManager.GetPlayer(0).MGAHHNHOKEM(DAEMAAOLHMG: true);
			}
			CursorManager.CMDGPJEIIJI(6).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	public static void APHDGACLODE()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = false;
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(1)).gameObject.SetActive(true);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(8)).gameObject.SetActive(true);
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(0).rect = new Rect(1281f, 1468f, 1854f, 1347f);
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(8).rect = new Rect(905f, 1868f, 460f, 991f);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.PHDBJGOEKHB(1).EDHEIFHAAKO();
			GameActionBarUI.PPJMPMKLCME(5).OpenUI();
			if (!PlayerInputs.ODGALPDEIFG(1))
			{
				CursorManager.CMDGPJEIIJI(0).ActivateCursorMask(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(8).SetCursorVisible(NKFPJPCFBJI: false);
		}
	}

	public static void NIAJGDNBOHI()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = true;
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(1)).gameObject.SetActive(true);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(0)).gameObject.SetActive(false);
			CommonReferences.MNFMOEKMJKN().GetMainCamera(1).rect = new Rect(804f, 834f, 250f, 428f);
			CommonReferences.MNFMOEKMJKN().GetMainCamera(0).rect = new Rect(1367f, 1439f, 267f, 115f);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.NDPAJCGHGOB(1).OpenUI();
			GameActionBarUI.JGNOJMLHPOK(7).IDLAGJNLPJL();
			if (!PlayerInputs.EEJEOALIHFJ(1))
			{
				CursorManager.GetPlayer(0).IPGBBDMNMKE(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(6).NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}

	private void PBDNKBPBCHM()
	{
		instance = this;
	}

	private void JDMMNLKLMAA()
	{
		instance = this;
	}

	private void OnDestroy()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void NOKHOOENONP(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(1356f, 329f, 491f, 1538f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 8) ? 8 : 0);
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.JELOGNCPDAB(1).CloseUI();
			GameActionBarUI.FHPEHDDFOIB(0).BOBCIFEDJED();
			if (!PlayerInputs.EEJEOALIHFJ(1))
			{
				CursorManager.CMDGPJEIIJI(1).HKJEEPFJNFO(DAEMAAOLHMG: true);
			}
			CursorManager.CMDGPJEIIJI(7).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	private void HEGNINLLINP()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void FBLAMCDFMPE()
	{
		instance = this;
	}

	public static void PNOHBMGIPBM()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = false;
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(1)).gameObject.SetActive(true);
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(7)).gameObject.SetActive(true);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(0).rect = new Rect(1634f, 192f, 1381f, 273f);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(0).rect = new Rect(1867f, 1961f, 43f, 459f);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.MENNLOGFNOK(0).OpenUI();
			GameActionBarUI.MENNLOGFNOK(0).IDLAGJNLPJL();
			if (!PlayerInputs.POLDHCKJINN(0))
			{
				CursorManager.CMDGPJEIIJI(0).HKJEEPFJNFO(DAEMAAOLHMG: true);
			}
			CursorManager.GetPlayer(2).SetCursorVisible(NKFPJPCFBJI: false);
		}
	}

	public static void LBNLBMJPPKP(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).rect = new Rect(773f, 1010f, 145f, 703f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 4) ? 0 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.Get(0).BOBCIFEDJED();
			GameActionBarUI.IGHMHMNPMLB(4).BOBCIFEDJED();
			if (!PlayerInputs.EEJEOALIHFJ(0))
			{
				CursorManager.CMDGPJEIIJI(0).MGAHHNHOKEM(DAEMAAOLHMG: true);
			}
			CursorManager.GetPlayer(8).SetCursorVisible(NKFPJPCFBJI: false);
		}
	}

	public static void CKCLLCIFGFB(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).rect = new Rect(949f, 357f, 1311f, 821f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 8) ? 2 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.PHDBJGOEKHB(1).BOBCIFEDJED();
			GameActionBarUI.IEKODILKIHJ(6).CloseUI();
			if (!PlayerInputs.EEJEOALIHFJ(0))
			{
				CursorManager.GetPlayer(1).ActivateCursorMask(DAEMAAOLHMG: true);
			}
			CursorManager.GetPlayer(1).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	public static void KAPCDEOOEPI(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(1632f, 1387f, 257f, 1961f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 0) ? 1 : 0);
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.HEGPDGJEOPC(1).BOBCIFEDJED();
			GameActionBarUI.PPJMPMKLCME(7).BOBCIFEDJED();
			if (!PlayerInputs.ODGALPDEIFG(0))
			{
				CursorManager.GetPlayer(1).HKJEEPFJNFO(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(5).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	public static void OLCIIHKGDNP()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = false;
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(0)).gameObject.SetActive(false);
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(6)).gameObject.SetActive(false);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(0).rect = new Rect(1892f, 1925f, 1060f, 905f);
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(7).rect = new Rect(1149f, 10f, 1398f, 1475f);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.MENNLOGFNOK(0).OpenUI();
			GameActionBarUI.JELOGNCPDAB(1).OpenUI();
			if (!PlayerInputs.IsGamepadActive(0))
			{
				CursorManager.CMDGPJEIIJI(1).IPGBBDMNMKE(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(2).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	private void OMBHDODDHNO()
	{
		instance = this;
	}

	private void DNKEFFMOCKP()
	{
		instance = this;
	}

	private void COGECLBOPIG()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void OLLNPFHCCBA(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(1402f, 1740f, 1524f, 1035f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 2) ? 3 : 0);
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.DIMABMEHNNI(0).CloseUI();
			GameActionBarUI.JGNOJMLHPOK(3).BOBCIFEDJED();
			if (!PlayerInputs.EEJEOALIHFJ(1))
			{
				CursorManager.GetPlayer(1).IPGBBDMNMKE(DAEMAAOLHMG: false);
			}
			CursorManager.GetPlayer(2).NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}

	private void HHFCEBPEEPK()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void GJGPOLAECEF(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(183f, 482f, 1899f, 1132f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 3) ? 0 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.PHDBJGOEKHB(0).BOBCIFEDJED();
			GameActionBarUI.PHDBJGOEKHB(0).CloseUI();
			if (!PlayerInputs.POLDHCKJINN(0))
			{
				CursorManager.CMDGPJEIIJI(0).MGAHHNHOKEM(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(3).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	private void PKFMLJGJKCP()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void MDIENLHEDGE()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void FGAAGHOMIOO(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).rect = new Rect(1259f, 698f, 925f, 801f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 3) ? 0 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.HEGPDGJEOPC(0).CloseUI();
			GameActionBarUI.FHPEHDDFOIB(2).CloseUI();
			if (!PlayerInputs.EEJEOALIHFJ(1))
			{
				CursorManager.CMDGPJEIIJI(0).MGAHHNHOKEM(DAEMAAOLHMG: true);
			}
			CursorManager.GetPlayer(8).NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}

	private void EFCNKPEPELL()
	{
		instance = this;
	}

	private void LDLBMMMLEDJ()
	{
		instance = this;
	}

	private void BGBFJPJLPMF()
	{
		instance = this;
	}

	private void JCNPCJOBENP()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void HHAFFKFAGAE(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(724f, 1349f, 1735f, 21f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 3) ? 1 : 2);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.JELOGNCPDAB(0).CloseUI();
			GameActionBarUI.PPDMGBACONH(7).BOBCIFEDJED();
			if (!PlayerInputs.ODGALPDEIFG(0))
			{
				CursorManager.CMDGPJEIIJI(0).ActivateCursorMask(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(3).SetCursorVisible(NKFPJPCFBJI: false);
		}
	}

	private void FJBPFOIALMK()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void CHDEOJALBFK()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void DFFDKIPCCKK()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void CLNBMOPMNOF()
	{
		instance = this;
	}

	private void PHJKJHKAABL()
	{
		instance = this;
	}

	public static void DHLNJNKFKBE(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(622f, 382f, 1668f, 1215f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 3) ? 6 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.JGNOJMLHPOK(1).BOBCIFEDJED();
			GameActionBarUI.AGNKKAPMHLN(7).BOBCIFEDJED();
			if (!PlayerInputs.FJLAMCHKCOI(0))
			{
				CursorManager.GetPlayer(1).MGAHHNHOKEM(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(6).NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}

	public static void HILANEFGMOP()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = true;
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(0)).gameObject.SetActive(true);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(8)).gameObject.SetActive(true);
			CommonReferences.MNFMOEKMJKN().GetMainCamera(1).rect = new Rect(1767f, 827f, 13f, 1398f);
			CommonReferences.MNFMOEKMJKN().GetMainCamera(8).rect = new Rect(596f, 961f, 591f, 175f);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.FHPEHDDFOIB(1).IDLAGJNLPJL();
			GameActionBarUI.MGLNAMHAIDG(6).EDHEIFHAAKO();
			if (!PlayerInputs.IsGamepadActive(0))
			{
				CursorManager.CMDGPJEIIJI(1).IPGBBDMNMKE(DAEMAAOLHMG: false);
			}
			CursorManager.GetPlayer(4).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	public static void LIJOHBKFIDH(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(697f, 566f, 464f, 178f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 2) ? 6 : 0);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.EKEDKKKPAEE(0).CloseUI();
			GameActionBarUI.NDPAJCGHGOB(7).BOBCIFEDJED();
			if (!PlayerInputs.EEJEOALIHFJ(0))
			{
				CursorManager.CMDGPJEIIJI(1).IPGBBDMNMKE(DAEMAAOLHMG: false);
			}
			CursorManager.GetPlayer(5).NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}

	public static void PJAMBLLKCBB()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = false;
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(0)).gameObject.SetActive(true);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(0)).gameObject.SetActive(false);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(1).rect = new Rect(891f, 1704f, 1311f, 1204f);
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(1).rect = new Rect(1822f, 1256f, 677f, 1012f);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.PJIGCLMPHKP(1).EDHEIFHAAKO();
			GameActionBarUI.JELOGNCPDAB(3).EDHEIFHAAKO();
			if (!PlayerInputs.POLDHCKJINN(0))
			{
				CursorManager.CMDGPJEIIJI(0).ActivateCursorMask(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(6).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	public static void KNFHGHJDHEB()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = true;
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(1)).gameObject.SetActive(false);
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(3)).gameObject.SetActive(false);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(1).rect = new Rect(360f, 738f, 118f, 904f);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(2).rect = new Rect(474f, 1548f, 976f, 396f);
			instance.playersSeparator.SetActive(false);
			GameActionBarUI.NDPAJCGHGOB(0).IDLAGJNLPJL();
			GameActionBarUI.BGABEMMDDEH(1).EDHEIFHAAKO();
			if (!PlayerInputs.FJLAMCHKCOI(0))
			{
				CursorManager.CMDGPJEIIJI(1).ActivateCursorMask(DAEMAAOLHMG: true);
			}
			CursorManager.CMDGPJEIIJI(2).NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}

	public static void FFDBDEIFIEF(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).rect = new Rect(387f, 1627f, 588f, 810f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 4) ? 5 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.AGNKKAPMHLN(0).CloseUI();
			GameActionBarUI.IEKODILKIHJ(6).BOBCIFEDJED();
			if (!PlayerInputs.FJLAMCHKCOI(0))
			{
				CursorManager.GetPlayer(0).ActivateCursorMask(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(8).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	public static void LGBODMLEKEF(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(1324f, 108f, 996f, 1450f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 8) ? 8 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.GDFNPHJJCPP(1).CloseUI();
			GameActionBarUI.EKEDKKKPAEE(2).CloseUI();
			if (!PlayerInputs.POLDHCKJINN(0))
			{
				CursorManager.CMDGPJEIIJI(1).MGAHHNHOKEM(DAEMAAOLHMG: true);
			}
			CursorManager.CMDGPJEIIJI(8).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	private void EICDGBINBAG()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void DCOEEADJLIK()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void AMAPHPCDHID(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(1717f, 810f, 164f, 800f);
			int jIIGOACEIKL = ((JIIGOACEIKL == 5) ? 0 : 0);
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(true);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.PPDMGBACONH(1).BOBCIFEDJED();
			GameActionBarUI.FHPEHDDFOIB(8).CloseUI();
			if (!PlayerInputs.POLDHCKJINN(1))
			{
				CursorManager.GetPlayer(0).MGAHHNHOKEM(DAEMAAOLHMG: true);
			}
			CursorManager.CMDGPJEIIJI(3).NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}

	public static void PHBEHCBNAHB()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = false;
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(1)).gameObject.SetActive(true);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(8)).gameObject.SetActive(false);
			CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(0).rect = new Rect(627f, 555f, 979f, 974f);
			CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(0).rect = new Rect(793f, 1490f, 1308f, 1479f);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.EKEDKKKPAEE(0).EDHEIFHAAKO();
			GameActionBarUI.EKEDKKKPAEE(1).OpenUI();
			if (!PlayerInputs.IsGamepadActive(0))
			{
				CursorManager.CMDGPJEIIJI(0).MGAHHNHOKEM(DAEMAAOLHMG: true);
			}
			CursorManager.CMDGPJEIIJI(1).NIPJALAEHOH(NKFPJPCFBJI: false);
		}
	}

	private void FDGFMMKIBPL()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void AMBKBOBDAIF()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void INBBJMGBOOB(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = false;
			CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).rect = new Rect(1153f, 957f, 313f, 1090f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 0) ? 5 : 0);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.MENNLOGFNOK(0).BOBCIFEDJED();
			GameActionBarUI.FHPEHDDFOIB(1).CloseUI();
			if (!PlayerInputs.EEJEOALIHFJ(1))
			{
				CursorManager.GetPlayer(0).MGAHHNHOKEM(DAEMAAOLHMG: false);
			}
			CursorManager.GetPlayer(7).SetCursorVisible(NKFPJPCFBJI: false);
		}
	}

	public static void OFMPMGBMHNG()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && GameManager.LocalCoop())
		{
			instance.cameraFocusedOnOnePlayer = true;
			((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(1)).gameObject.SetActive(false);
			((Component)CommonReferences.MNFMOEKMJKN().GetMainCamera(5)).gameObject.SetActive(true);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(1).rect = new Rect(1937f, 1317f, 855f, 1736f);
			CommonReferences.GGFJGHHHEJC.GetMainCamera(6).rect = new Rect(289f, 1975f, 1835f, 1789f);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.NIDHCIHFOHB(0).OpenUI();
			GameActionBarUI.PPJMPMKLCME(6).EDHEIFHAAKO();
			if (!PlayerInputs.IsGamepadActive(0))
			{
				CursorManager.GetPlayer(0).MGAHHNHOKEM(DAEMAAOLHMG: true);
			}
			CursorManager.GetPlayer(6).SetCursorVisible(NKFPJPCFBJI: true);
		}
	}

	public static void KJEOOJPGHHH(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).rect = new Rect(791f, 909f, 453f, 517f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 3) ? 6 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.PHDBJGOEKHB(0).CloseUI();
			GameActionBarUI.NDPAJCGHGOB(0).CloseUI();
			if (!PlayerInputs.POLDHCKJINN(0))
			{
				CursorManager.CMDGPJEIIJI(1).HKJEEPFJNFO(DAEMAAOLHMG: true);
			}
			CursorManager.CMDGPJEIIJI(0).SetCursorVisible(NKFPJPCFBJI: false);
		}
	}

	private void KCLKEAHGGEK()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void MFGANCCJFJK()
	{
		instance = this;
	}

	private void JBBHDOMALDB()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void LNPDALMANFB()
	{
		instance = this;
	}

	private void OBHFJIDKBJN()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void GFLFDLIMOLI()
	{
		instance = this;
	}

	public static void KEDNHKCAIHN(int JIIGOACEIKL)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null))
		{
			instance.cameraFocusedOnOnePlayer = true;
			CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).rect = new Rect(80f, 1489f, 842f, 798f);
			int jIIGOACEIKL = ((JIIGOACEIKL != 3) ? 4 : 0);
			((Component)CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(jIIGOACEIKL)).gameObject.SetActive(false);
			instance.playersSeparator.SetActive(true);
			GameActionBarUI.FHPEHDDFOIB(0).BOBCIFEDJED();
			GameActionBarUI.AGNKKAPMHLN(5).CloseUI();
			if (!PlayerInputs.POLDHCKJINN(0))
			{
				CursorManager.CMDGPJEIIJI(0).ActivateCursorMask(DAEMAAOLHMG: false);
			}
			CursorManager.CMDGPJEIIJI(3).NIPJALAEHOH(NKFPJPCFBJI: true);
		}
	}
}
