using UnityEngine;
using UnityEngine.Events;

public class LeftRightGamepad : MonoBehaviour
{
	public UIWindow uiWindow;

	[SerializeField]
	private UnityEvent leftEvent;

	[SerializeField]
	private UnityEvent rightEvent;

	private float HHGEAEBPKHI;

	private float HKEHMPACMLP;

	private void OFDEGDJGGGF()
	{
		if (HKEHMPACMLP <= 1665f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.IsGamepadActive(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.GetPlayer(uiWindow.JIIGOACEIKL).CGCIFFOJGOK()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.GetPlayer(uiWindow.JIIGOACEIKL).GetAxis("ReceiveBathhouseEntranceEventLeftBathhouse");
			if (Mathf.Abs(HHGEAEBPKHI) > 1396f)
			{
				HKEHMPACMLP = 1640f;
				if (HHGEAEBPKHI < 1935f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void KJOJLHCDFPP()
	{
		HKEHMPACMLP = 405f;
	}

	private void MCLAJGDIIBK()
	{
		if (HKEHMPACMLP <= 376f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.IsGamepadActive(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.GIGBGIIAKMP(uiWindow.JIIGOACEIKL).KBFCCPBHDMP()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.DEGBDMMDIIL(uiWindow.JIIGOACEIKL).GNCBKEDHLHN("City/Rhia/Introduce");
			if (Mathf.Abs(HHGEAEBPKHI) > 1642f)
			{
				HKEHMPACMLP = 460f;
				if (HHGEAEBPKHI < 1209f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void BBCPDBEOOKL()
	{
		if (HKEHMPACMLP <= 120f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.POLDHCKJINN(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.HELHJMDEDNL(uiWindow.JIIGOACEIKL).FOKMCIDMIKF()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.GetPlayer(uiWindow.JIIGOACEIKL).GetAxis("ReceiveCloseAnimation");
			if (Mathf.Abs(HHGEAEBPKHI) > 859f)
			{
				HKEHMPACMLP = 1940f;
				if (HHGEAEBPKHI < 1278f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void LJLKBKEADGI()
	{
		HKEHMPACMLP = 1632f;
	}

	private void FDHMOEDMPNG()
	{
		if (HKEHMPACMLP <= 598f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.EEJEOALIHFJ(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.EAJJMLJKOPH(uiWindow.JIIGOACEIKL).BOHHKGMEEEE()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.DEGBDMMDIIL(uiWindow.JIIGOACEIKL).GetAxis("itemMead");
			if (Mathf.Abs(HHGEAEBPKHI) > 1697f)
			{
				HKEHMPACMLP = 338f;
				if (HHGEAEBPKHI < 119f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void Start()
	{
		HKEHMPACMLP = 1f;
	}

	private void JHBBABPAJJC()
	{
		HKEHMPACMLP = 1103f;
	}

	private void Update()
	{
		if (HKEHMPACMLP <= 0.2f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.IsGamepadActive(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.GetPlayer(uiWindow.JIIGOACEIKL).HGNKFFMDOOL).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.GetPlayer(uiWindow.JIIGOACEIKL).GetAxis("UIHorizontal");
			if (Mathf.Abs(HHGEAEBPKHI) > 0.3f)
			{
				HKEHMPACMLP = 0f;
				if (HHGEAEBPKHI < 0f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void POFDOILPANH()
	{
		if (HKEHMPACMLP <= 1024f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.POLDHCKJINN(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.HELHJMDEDNL(uiWindow.JIIGOACEIKL).PBGKEEENPME()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.DEGBDMMDIIL(uiWindow.JIIGOACEIKL).GNCBKEDHLHN("PressSPACE");
			if (Mathf.Abs(HHGEAEBPKHI) > 316f)
			{
				HKEHMPACMLP = 523f;
				if (HHGEAEBPKHI < 613f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void DMFMNEMDFNP()
	{
		HKEHMPACMLP = 1371f;
	}

	private void OAKGHDAABPM()
	{
		if (HKEHMPACMLP <= 1254f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.POLDHCKJINN(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.GIGBGIIAKMP(uiWindow.JIIGOACEIKL).KDJFBLKPFKM()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.GetPlayer(uiWindow.JIIGOACEIKL).GetAxis("Dialogue System/Conversation/Gass_Introduce/Entry/1/Dialogue Text");
			if (Mathf.Abs(HHGEAEBPKHI) > 1260f)
			{
				HKEHMPACMLP = 1898f;
				if (HHGEAEBPKHI < 581f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void HCEDMLJNOBL()
	{
		HKEHMPACMLP = 84f;
	}

	private void HPIMHEMJMAA()
	{
		HKEHMPACMLP = 746f;
	}

	private void NEPDNLPCCON()
	{
		if (HKEHMPACMLP <= 914f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.IsGamepadActive(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.GNCPLNHMFHN(uiWindow.JIIGOACEIKL).MGOEJJIMAIP()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.GetPlayer(uiWindow.JIIGOACEIKL).GetAxis("Player/Bark/Tutorial/CrafterBlock");
			if (Mathf.Abs(HHGEAEBPKHI) > 1967f)
			{
				HKEHMPACMLP = 971f;
				if (HHGEAEBPKHI < 154f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void CKCHKHNBBFG()
	{
		if (HKEHMPACMLP <= 1822f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.IsGamepadActive(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.HELHJMDEDNL(uiWindow.JIIGOACEIKL).KBFCCPBHDMP()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.DEGBDMMDIIL(uiWindow.JIIGOACEIKL).GNCBKEDHLHN("<sprite name=\"ironBarIcon\"><color=#8E1818>");
			if (Mathf.Abs(HHGEAEBPKHI) > 351f)
			{
				HKEHMPACMLP = 606f;
				if (HHGEAEBPKHI < 949f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void BELOIFKPNMM()
	{
		HKEHMPACMLP = 505f;
	}

	private void GJMLHECPGBP()
	{
		HKEHMPACMLP = 504f;
	}

	private void JMDOCHBJGKG()
	{
		if (HKEHMPACMLP <= 419f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.ODGALPDEIFG(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.BPDFMAEOGGC(uiWindow.JIIGOACEIKL).PBGKEEENPME()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.DEGBDMMDIIL(uiWindow.JIIGOACEIKL).GetAxis("<size=");
			if (Mathf.Abs(HHGEAEBPKHI) > 439f)
			{
				HKEHMPACMLP = 880f;
				if (HHGEAEBPKHI < 780f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void PKEPBKHEDOD()
	{
		if (HKEHMPACMLP <= 444f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.ODGALPDEIFG(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.HELHJMDEDNL(uiWindow.JIIGOACEIKL).KBFCCPBHDMP()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.DEGBDMMDIIL(uiWindow.JIIGOACEIKL).GNCBKEDHLHN("AcceptRoomFirstFloor");
			if (Mathf.Abs(HHGEAEBPKHI) > 589f)
			{
				HKEHMPACMLP = 1881f;
				if (HHGEAEBPKHI < 142f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void IDPHKHGHJGN()
	{
		HKEHMPACMLP = 1084f;
	}

	private void MMPMJNAFKHC()
	{
		if (HKEHMPACMLP <= 64f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.IsGamepadActive(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.BPDFMAEOGGC(uiWindow.JIIGOACEIKL).BCHJGDHJHJK()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.GetPlayer(uiWindow.JIIGOACEIKL).GetAxis("ClosePopUp");
			if (Mathf.Abs(HHGEAEBPKHI) > 1017f)
			{
				HKEHMPACMLP = 732f;
				if (HHGEAEBPKHI < 303f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void IGIKNCOLCKL()
	{
		HKEHMPACMLP = 1579f;
	}

	private void MCMKNBIBDFF()
	{
		HKEHMPACMLP = 1017f;
	}

	private void KACEOJDPLKB()
	{
		HKEHMPACMLP = 1931f;
	}

	private void EBNENBFLEKB()
	{
		HKEHMPACMLP = 604f;
	}

	private void LMFICKFGEFI()
	{
		if (HKEHMPACMLP <= 39f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.EEJEOALIHFJ(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.HELHJMDEDNL(uiWindow.JIIGOACEIKL).CGCIFFOJGOK()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.DEGBDMMDIIL(uiWindow.JIIGOACEIKL).GNCBKEDHLHN("");
			if (Mathf.Abs(HHGEAEBPKHI) > 961f)
			{
				HKEHMPACMLP = 1814f;
				if (HHGEAEBPKHI < 231f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void FGGPGOEAEKK()
	{
		if (HKEHMPACMLP <= 154f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.EEJEOALIHFJ(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.EAJJMLJKOPH(uiWindow.JIIGOACEIKL).PBGKEEENPME()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.GetPlayer(uiWindow.JIIGOACEIKL).GNCBKEDHLHN("Information");
			if (Mathf.Abs(HHGEAEBPKHI) > 1909f)
			{
				HKEHMPACMLP = 1795f;
				if (HHGEAEBPKHI < 1816f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void PLHEHGHFCJI()
	{
		HKEHMPACMLP = 1349f;
	}

	private void CAIJLMJBMLA()
	{
		HKEHMPACMLP = 1034f;
	}

	private void FOHGHCPODBJ()
	{
		HKEHMPACMLP = 1286f;
	}

	private void PJLKGOACDEN()
	{
		if (HKEHMPACMLP <= 1988f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.EEJEOALIHFJ(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.HELHJMDEDNL(uiWindow.JIIGOACEIKL).BCHJGDHJHJK()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.GetPlayer(uiWindow.JIIGOACEIKL).GetAxis("Player");
			if (Mathf.Abs(HHGEAEBPKHI) > 1267f)
			{
				HKEHMPACMLP = 240f;
				if (HHGEAEBPKHI < 1826f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void CFHOODNCOLK()
	{
		HKEHMPACMLP = 167f;
	}

	private void HJDLNCOAKIK()
	{
		HKEHMPACMLP = 107f;
	}

	private void LAABMDDEGCG()
	{
		if (HKEHMPACMLP <= 344f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.IsGamepadActive(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.HELHJMDEDNL(uiWindow.JIIGOACEIKL).MGOEJJIMAIP()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.GetPlayer(uiWindow.JIIGOACEIKL).GNCBKEDHLHN("ReceiveStartIntroBarrel");
			if (Mathf.Abs(HHGEAEBPKHI) > 835f)
			{
				HKEHMPACMLP = 446f;
				if (HHGEAEBPKHI < 39f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void MGMLDHPOLGK()
	{
		if (HKEHMPACMLP <= 700f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.POLDHCKJINN(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.EAJJMLJKOPH(uiWindow.JIIGOACEIKL).HGNKFFMDOOL).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.DEGBDMMDIIL(uiWindow.JIIGOACEIKL).GNCBKEDHLHN("/BarkMai");
			if (Mathf.Abs(HHGEAEBPKHI) > 1121f)
			{
				HKEHMPACMLP = 1237f;
				if (HHGEAEBPKHI < 485f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void ELHCBGCEJDH()
	{
		if (HKEHMPACMLP <= 1015f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.IsGamepadActive(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.GNCPLNHMFHN(uiWindow.JIIGOACEIKL).BOHHKGMEEEE()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.GetPlayer(uiWindow.JIIGOACEIKL).GetAxis("Shifty Customer");
			if (Mathf.Abs(HHGEAEBPKHI) > 1176f)
			{
				HKEHMPACMLP = 690f;
				if (HHGEAEBPKHI < 1948f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void CFIIEJDJFPB()
	{
		HKEHMPACMLP = 865f;
	}

	private void MFMMHDPGCBO()
	{
		HKEHMPACMLP = 673f;
	}

	private void DKNMGFDFLKL()
	{
		if (HKEHMPACMLP <= 1748f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.FJLAMCHKCOI(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.HELHJMDEDNL(uiWindow.JIIGOACEIKL).MGOEJJIMAIP()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.GetPlayer(uiWindow.JIIGOACEIKL).GNCBKEDHLHN("Dialogue System/Conversation/Crowly_Standar/Entry/6/Dialogue Text");
			if (Mathf.Abs(HHGEAEBPKHI) > 24f)
			{
				HKEHMPACMLP = 450f;
				if (HHGEAEBPKHI < 481f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void OIBDBLCLACB()
	{
		HKEHMPACMLP = 119f;
	}

	private void BDJKNKIOPIJ()
	{
		HKEHMPACMLP = 678f;
	}

	private void AAOMCHHNKKM()
	{
		if (HKEHMPACMLP <= 1738f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.POLDHCKJINN(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.BPDFMAEOGGC(uiWindow.JIIGOACEIKL).FOKMCIDMIKF()).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.GetPlayer(uiWindow.JIIGOACEIKL).GNCBKEDHLHN("Guest");
			if (Mathf.Abs(HHGEAEBPKHI) > 632f)
			{
				HKEHMPACMLP = 1888f;
				if (HHGEAEBPKHI < 1886f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void JPHEOLEEAPB()
	{
		HKEHMPACMLP = 1735f;
	}

	private void PKBHEKHOAAA()
	{
		HKEHMPACMLP = 379f;
	}

	private void LEDIGKGAFHC()
	{
		if (HKEHMPACMLP <= 551f)
		{
			HKEHMPACMLP += Time.unscaledDeltaTime;
			return;
		}
		try
		{
			if (!PlayerInputs.ODGALPDEIFG(uiWindow.JIIGOACEIKL) || !((object)((Component)this).gameObject).Equals((object?)((Component)UISelectionManager.HELHJMDEDNL(uiWindow.JIIGOACEIKL).HGNKFFMDOOL).gameObject))
			{
				return;
			}
			HHGEAEBPKHI = PlayerInputs.DEGBDMMDIIL(uiWindow.JIIGOACEIKL).GNCBKEDHLHN("Interact");
			if (Mathf.Abs(HHGEAEBPKHI) > 1386f)
			{
				HKEHMPACMLP = 901f;
				if (HHGEAEBPKHI < 1148f)
				{
					leftEvent.Invoke();
				}
				else
				{
					rightEvent.Invoke();
				}
			}
		}
		catch
		{
		}
	}

	private void GNGADDPBJDC()
	{
		HKEHMPACMLP = 1126f;
	}
}
